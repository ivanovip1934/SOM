using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SOM
{
    static class HelperFunc
    {

        public static List<User> SearchUser(PSCredential cred, string shablon, TypeSearch typeSearch)
        
        {
            Regex reg = new Regex(@"CN=([\w+.@\-_() ]+),\w\w=", RegexOptions.IgnoreCase);
            List<User> list_users = new List<User>();

            Collection<PSObject> output;
            

            string pattern_string = shablon.Trim();
            Console.WriteLine();
            char check_char = pattern_string.ToCharArray()[0];
            string pattern_string1 = pattern_string.Replace('?', '*');
            string filter_string = typeSearch == TypeSearch.FIO ? $"Name -like '{pattern_string1}*'" : $"samAccountName -like '{pattern_string1}*'";


            InitialSessionState iss = InitialSessionState.CreateDefault();
            iss.ExecutionPolicy = Microsoft.PowerShell.ExecutionPolicy.Unrestricted;
            using (Runspace rs = RunspaceFactory.CreateRunspace(iss))
            {
                rs.Open();
                using (Pipeline pipeline = rs.CreatePipeline())
                {
                    Command getAdUser = new Command("Get-AdUser");
                    getAdUser.Parameters.Add("Filter", filter_string);
                    getAdUser.Parameters.Add("Credential", cred);
                    getAdUser.Parameters.Add("Server", "kr01-dc-02.dp.mosreg.ru");
                    getAdUser.Parameters.Add("Properties", "*");
                    getAdUser.Parameters.Add("SearchBase", "DC=dp,DC=mosreg,DC=ru");
                    pipeline.Commands.Add(getAdUser);


                    String customScriptText = String.Empty;


                    Command whereobj = new Command("Where-Object");
                    if (check_char == '?')
                    {
                        string pattern_string2 = pattern_string.Remove(0, 1).Replace("?", ".*");
                        string pattern = typeSearch == TypeSearch.FIO ? $@"$_.Name -imatch "".+{pattern_string2}.*""" : $@"$_.samAccountName -match "".+{pattern_string2}.*""";
                        ScriptBlock scrp = ScriptBlock.Create(pattern);
                        whereobj.Parameters.Add("Filter", scrp);
                        pipeline.Commands.Add(whereobj);                        
                    }

                    output = pipeline.Invoke();



                    foreach (PSObject psObject in output)
                    {
                        Dictionary<string, string> dic_groups = new Dictionary<string, string>();
                        string Username = string.Empty;
                        string SamAccountName = string.Empty;
                        string DistinguishedName = string.Empty;
                        DateTime whenCreated = new DateTime();
                        DateTime lastLogonDate = new DateTime();
                        DateTime PasswordLastSet = new DateTime();
                        bool PasswordExpired=false;
                        bool Enabled = false;
                        if (psObject != null)
                        {
                            if (psObject?.Members["whenCreated"]?.Value != null)
                            {
                                whenCreated = (DateTime)psObject?.Members["whenCreated"]?.Value;
                            }
                            if (psObject?.Members["LastLogonDate"]?.Value != null)
                            {
                                lastLogonDate = (DateTime)psObject?.Members["LastLogonDate"]?.Value;
                            }

                            if (psObject?.Members["PasswordLastSet"]?.Value != null)
                            {
                                PasswordLastSet = (DateTime)psObject?.Members["PasswordLastSet"]?.Value;
                            }


                            PasswordExpired = (bool)psObject?.Members["PasswordExpired"].Value;
                            Username = psObject?.Members["Name"].Value.ToString();
                            SamAccountName = psObject?.Members["SamAccountName"].Value.ToString();
                            DistinguishedName = psObject?.Members["DistinguishedName"].Value.ToString();
                            Enabled = (bool)psObject?.Members["Enabled"].Value;


                            PSMemberInfo memberinfo = psObject.Members["MemberOf"];
                            if (memberinfo.Value is ICollection)
                                foreach (var item in (ICollection)memberinfo.Value)
                                {
                                    Match matches = reg.Match(item.ToString());
                                    dic_groups.Add(matches.Groups[1].Value, item.ToString());

                                }
                            //List<Microsoft.ActiveDirectory.Management.ADPropertyValueCollection> 
                            //Console.WriteLine("{0}", psObject.Members["DistinguishedName"].Value);
                            //Console.WriteLine();

                        }
                        list_users.Add(new User(Username.GetHashCode(),Username, SamAccountName, DistinguishedName,Enabled, lastLogonDate, whenCreated, PasswordLastSet,PasswordExpired, dic_groups));

                    }                    
                }
                rs.Close();
            }

            return list_users;
        }
    }
    



    class User: IComparable
    {

        public User(int Hash,string UserName, string SamAccountName, string DistinguishedName,bool Enabled,DateTime LastLogonDate, DateTime WhenCreated,DateTime PasswordLastSet, bool PasswordExpired ,Dictionary<string, string> MemberOf)
        {
            username = UserName;
            samAccountName = SamAccountName;
            distinguishedName = DistinguishedName;

            memberOf = MemberOf;
            whenCreated = WhenCreated;
            lastLogonDate = LastLogonDate;
            enabled = Enabled;
            hash = Hash;
            passwordLastSet = PasswordLastSet;
            passwordExpired = PasswordExpired;

        }
        string username;
        string samAccountName;
        string distinguishedName;
        bool enabled;
        DateTime lastLogonDate;
        DateTime whenCreated;
        DateTime passwordLastSet;
        bool passwordExpired;
        int hash;
        Dictionary<string, string> memberOf;

        public string UserName { get { return username; } }
        public string SamAccountName { get { return samAccountName; } }
        public string DistinguishedName { get { return distinguishedName; } }
        public DateTime WhenCreated { get { return whenCreated; } }
        public int Hash { get { return hash; } }
        public Dictionary<string, string> MemberOf { get { return memberOf; } }
        public bool Enabled { get { return enabled; } }
        public DateTime LastLogonDate { get { return lastLogonDate; } }
        public DateTime PasswordLastSet { get { return passwordLastSet; } }
        public bool PasswordExpired { get { return passwordExpired; } } 

        public int CompareTo(object? obj) {
            return this.UserName.CompareTo(((User)obj).UserName);
        }
        
    }
}

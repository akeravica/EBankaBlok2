using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Common.SecurityManager
{
    public class CustomPrincipal : IPrincipal
    {
        private IIdentity identity;
        private bool isInRole;
        //List<string> roles = new List<string>();
        List<string> prms = new List<string>();
        private Dictionary<string, string[]> roles = new Dictionary<string, string[]>();
        public IIdentity Identity
        {
            get { return this.identity; }
        }

        public bool IsInRole(string role)
        {
            if (prms.Contains(role))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public CustomPrincipal(WindowsIdentity identity)
        {
            this.identity = identity;
            //ovde pozovi getValue i smesti ih u listu prms...
            foreach (IdentityReference group in identity.Groups)
            {
                SecurityIdentifier sid = (SecurityIdentifier)group.Translate(typeof(SecurityIdentifier));
                var name = sid.Translate(typeof(NTAccount));
                string groupName = Formatter.ParseName(name.ToString());
                
               
                roles.Add(groupName, RolesConfig.GetValue(groupName));
            }
        }
    }
}

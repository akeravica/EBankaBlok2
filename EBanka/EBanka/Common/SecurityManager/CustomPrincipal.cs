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
        List<string> roles = new List<string>();
        List<string> prms = new List<string>();
        public IIdentity Identity
        {
            get => this.identity;
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

            foreach (IdentityReference group in identity.Groups)
            {
                SecurityIdentifier sid = (SecurityIdentifier)group.Translate(typeof(SecurityIdentifier));
                var name = sid.Translate(typeof(NTAccount));
                roles.Add(name.Value.Substring(8));
            }
        }
    }
}

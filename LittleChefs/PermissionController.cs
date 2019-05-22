using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleChefs
{
    public class PermissionController : Permissions
    {
        private List<int> permissions;

        public PermissionController()
        {
            permissions = new List<int>();
        }

        public void addPermission(int x)
        {
            if (!permissions.Contains(x))
            {
                permissions.Add(x);
            }
        }

        public List<int> getPermissions()
        {
            return permissions;
        }

        public void removePermission(int x)
        {
            permissions.Remove(x);
        }

        public void setPermissions(List<int> x)
        {
            permissions = x;
        }
    }
}

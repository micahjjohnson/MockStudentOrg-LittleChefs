using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleChefs
{
    interface Permissions
    {
        void addPermission(int x);
        void removePermission(int x);
        void setPermissions(List<int> x);
        List<int> getPermissions();
    }
}

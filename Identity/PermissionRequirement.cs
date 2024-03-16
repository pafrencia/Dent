using Microsoft.AspNetCore.Authorization;
using static Dent.Identity.Permissions;

namespace Dent.Identity
{
    public class PermissionRequirement : IAuthorizationRequirement
    {
        public PermissionTuple Permission { get; }

        public PermissionRequirement(PermissionTuple permission)
        {
            Permission = permission;
        }
    }
}

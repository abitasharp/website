using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abitasharp.Models
{
    public class Utente : IdentityUser<string>
    {
        
    }

    public partial class UserLogin : IdentityUserLogin<string>
    {
    }
    public partial class UserRole : IdentityUserRole<string>
    {
    }
    public partial class UserClaim : IdentityUserClaim<string>
    {
    }

    public partial class RoleClaim : IdentityRoleClaim<string>
    {
    }
    public partial class UserToken : IdentityUserToken<string>
    {
    }
}

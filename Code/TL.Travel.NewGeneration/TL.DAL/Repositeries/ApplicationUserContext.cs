using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TL.Models;

namespace TL.DAL
{
    /// <summary>
    /// 
    /// </summary>
    public class ApplicationUserContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationUserContext()
            : base("TravelManagementEntities")
        {
        }
    }
}

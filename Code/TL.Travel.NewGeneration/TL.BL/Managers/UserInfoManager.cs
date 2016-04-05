using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TL.DAL;
using TL.DAL.ORM;
using TL.Models;
using System.Data.Entity;


namespace TL.BL.Managers
{
    /// <summary>
    /// 
    /// </summary>
    public class UserInfoManager : ManagerBase
    {
        /// <summary>
        /// 
        /// </summary>
        private UserManager<ApplicationUser> localUserManager = null;
        public UserInfoManager()
            : this(new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationUserContext())))
        {
        }

        public UserInfoManager(UserManager<ApplicationUser> userManager)
        {
            localUserManager = userManager;
        }

        public UserManager<ApplicationUser> GetUserManager
        {
            get
            {
                return localUserManager;
            }
        }

        public IEnumerable<IdentityRole> GetRoles()
        {
            return new ApplicationUserContext().Roles;
        }

        /// <summary>
        /// 
        /// </summary>
        public void SetupRoles()
        {
            using (var context = new ApplicationUserContext())
            {
                if (null == context.Roles.FirstOrDefault(i => i.Name == "Admin"))
                {
                    context.Roles.Add(new IdentityRole { Name = "Admin" });
                }
                if (null == context.Roles.FirstOrDefault(i => i.Name == "Agent"))
                {
                    context.Roles.Add(new IdentityRole { Name = "Agent" });
                }
                context.SaveChanges();
            }
        }
    }
}

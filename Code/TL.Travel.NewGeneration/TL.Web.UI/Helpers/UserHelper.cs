using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TL.BL.Managers;
using TL.DAL;
using TL.Web.UI.Models;

namespace TL.Web.UI
{
    public static class UserHelper
    {
        static public IEnumerable<IdentityRole> GetUserRoles()
        {
            var context = new UserInfoManager();
            return context.GetRoles();
        }

        /// <summary>
        /// 
        /// </summary>
        static public void SetupRoles()
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

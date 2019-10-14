using AgueroCRM.Web.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AgueroCRM.Web.Startup))]
namespace AgueroCRM.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            createRolesandUsers();
        }
        private void createRolesandUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));


            // In Startup iam creating first Admin Role and creating a default Admin User    
            if (!roleManager.RoleExists("管理员"))
            {

                // first we create Admin rool   
                var role = new IdentityRole();
                role.Name = "管理员";
                roleManager.Create(role);

                //Here we create a Admin super user who will maintain the website                  

                var user = new ApplicationUser();
                user.UserName = "lulu";
                user.Email = "324001673@qq.com";

                string userPWD = "539286Sll";

                var chkUser = UserManager.Create(user, userPWD);

                //Add default User to Role Admin   
                if (chkUser.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user.Id, "管理员");

                }
            }

            // creating Creating Marketer role    
            if (!roleManager.RoleExists("市场"))
            {
                var role = new IdentityRole();
                role.Name = "市场";
                roleManager.Create(role);

            }

            // creating Creating SeniorConsultant role    
            if (!roleManager.RoleExists("大顾问"))
            {
                var role = new IdentityRole();
                role.Name = "大顾问";
                roleManager.Create(role);

            }

            // creating Creating JuniorConsultant role    
            if (!roleManager.RoleExists("小顾问"))
            {
                var role = new IdentityRole();
                role.Name = "小顾问";
                roleManager.Create(role);

            }

            // creating Creating CopyWriter role    
            if (!roleManager.RoleExists("文案"))
            {
                var role = new IdentityRole();
                role.Name = "文案";
                roleManager.Create(role);

            }
        }
    }
}

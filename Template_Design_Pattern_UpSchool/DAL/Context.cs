using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Template_Design_Pattern_UpSchool.DAL.Entities;

namespace Template_Design_Pattern_UpSchool.DAL
{
    public class Context:IdentityDbContext<AppUser,AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=RAMAZANSURUCU; initial catalog=UpSchoolTemplateDb; integrated security=true");
        }
    }
}

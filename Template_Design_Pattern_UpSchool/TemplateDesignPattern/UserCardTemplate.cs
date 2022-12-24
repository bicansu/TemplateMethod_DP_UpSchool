using System.Text;
using Template_Design_Pattern_UpSchool.DAL.Entities;

namespace Template_Design_Pattern_UpSchool.TemplateDesignPattern
{
    public abstract class UserCardTemplate
    {
        protected AppUser AppUser { get; set; }

        public void SetUser(AppUser appUser)
        {
            AppUser = appUser;
        }
        protected abstract string SetImage();
        protected abstract string SetFooter();

        public string Build()
        {
            var sb = new StringBuilder();
            sb.Append("<div class='card'>");
            sb.Append(SetImage());
            sb.Append($@"<div class='card-body'>
                <h5>{AppUser.UserName}</h5>
                <p>{AppUser.Description}</p>");
            sb.Append(SetFooter());
            sb.Append("</div>");
            sb.Append("</div>");
            return sb.ToString();
        }
    }
}

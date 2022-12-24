namespace Template_Design_Pattern_UpSchool.TemplateDesignPattern
{
    public class DefaultUserCardTemplate : UserCardTemplate
    {
        protected override string SetFooter()
        {
            return string.Empty;
        }

        protected override string SetImage()
        {
            return "<img class='car-img-top' src='/images/user.png' style='width:50px; height:50px;'>";
        }
    }
}

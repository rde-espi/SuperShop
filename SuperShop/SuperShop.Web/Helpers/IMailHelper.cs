namespace SuperShop.Web.Helpers
{
    public interface IMailHelper
    {
        Response SendEmail(string to,string Subject,string body);
    }
}

namespace SuperShop.Helpers
{
    public interface IEmailHelper
    {
        Response SendEmail(string to, string subject, string body);
    }
}

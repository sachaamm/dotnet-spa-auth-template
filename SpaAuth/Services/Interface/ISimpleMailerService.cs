namespace SpaAuth.Services.Interface
{
    public interface ISimpleMailerService
    {
        public void SendEmail(string toEmail, string subject, string body);
    }
}

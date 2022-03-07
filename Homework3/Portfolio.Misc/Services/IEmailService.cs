using System.Threading.Tasks;

namespace Portfolio.Misc.Services
{
    public interface IEmailService
    {
        Task SendEmail(string email, string text);
    }
}
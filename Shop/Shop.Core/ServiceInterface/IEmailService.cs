using Shop.Core.Dto.EmailDtos;

namespace Shop.Core.ServiceInterface
{
    public interface IEmailService
    {
        void SendEmail(EmailDto request );
    }
}

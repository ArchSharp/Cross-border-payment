namespace Identity.Interfaces
{
    public interface INotificationService
    {
        void Subscribe(string receiverEmail, string firstName, string lastName);
        void SendVerificationEmail(string receiverEmail, string name, string token);
        void SendPinAddEmail(string email, string firstName);
        void SendPinUpdateEmail(string email, string firstName);
        void SendPasswordResetEmail(string receiverEmail, string name, string newToken);
        void SendStaffAccountEmail(string email, string firstName);
    }
}
namespace DependencyInversion
{
    public class Reporter
    {
        private readonly ISender sender;
        public Reporter(ISender sender)
        {
            this.sender = sender;
        }
        public void SendReport()
        {
            ///MailSender mailSender = new MailSender();
            sender.Send();
        }
    }

    public interface ISender
    {
        void Send();
    }
    public class MailSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("Mail ile gönderildi");
        }
    }

    public class WhatsAppSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("WS ile gönderildi");
        }
    }

    public class TelegramSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("Telegram ile gönderildi");
        }


    }
}

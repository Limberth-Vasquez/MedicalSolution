using Azure;
using Azure.Communication.Email;

namespace AppLogic
{
    public interface IEmailManager
    {
        string SendEmail(string emailAddress);//DTO email
    }
    public class EmailManager : IEmailManager
    {
        public string SendEmail(string emailAddress)
        {
            string connectionString = "Su conection string";
            var emailClient = new EmailClient(connectionString);


            var emailMessage = new EmailMessage(
                senderAddress: "DoNotReply@b9aa511d-d9ac-42e9-b64b-5341176961f6.azurecomm.net",
                content: new EmailContent("Correo electronico de prueba")
                {
                    PlainText = @"Hola Mundo por correo electronico",
                    Html = @"
		                    <html>
			                    <body>
				                    <h1 style='color=red;'>
					                    Hola Mundo por correo.
				                    </h1>
			                    </body>
		                    </html>"
                },
                recipients: new EmailRecipients(new List<EmailAddress>
                {
                    new EmailAddress(emailAddress)
                }));


            EmailSendOperation emailSendOperation = emailClient.Send(WaitUntil.Completed, emailMessage);

            return emailSendOperation.Value.Status.ToString();
        }
    }
}

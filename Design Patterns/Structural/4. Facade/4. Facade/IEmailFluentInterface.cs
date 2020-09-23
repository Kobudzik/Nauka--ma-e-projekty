using System.Net;
using System.Net.Mail;

namespace DesignPatternDemos.Facade
{
    public interface IEmailFluentInterface
    {
        //METHODS TO IMPLEMENT- setting base class properties
        IEmailFluentInterface From(string fromAddress);
        IEmailFluentInterface To(params string[] toAddresses);
        IEmailFluentInterface CC(params string[] ccAddresses);
        IEmailFluentInterface BCC(params string[] bccAddresses);
        IEmailFluentInterface WithSubject(string subject);
        IEmailFluentInterface WithBody(string body);

        void Send();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemos.Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            EmailCreator.CreateEmailFrom("from@test.com")
              .To("to1@test.com", "to2@test.com", "to2@test.com")
              .CC("cc1@test.com", "cc2@test.com")
              .BCC("bcc1@test.com", "bcc2@test.com", "bcc3@test.com", "bcc4@test.com")
              .WithSubject("Email subject here")
              .WithBody("Email body here")
              .Send();
        }
    }
}


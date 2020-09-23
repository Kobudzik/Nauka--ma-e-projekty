using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Command
{
    public interface ITransaction
    {
        void Execute();

        int ID { get; set; }
        DateTime CreatedOn { get; set; }
        CommandState Status { get; set; }
        void Undo();
    }
}

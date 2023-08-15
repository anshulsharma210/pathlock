using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathLock_Pipeline.Commands
{
    public interface ICommand
    {
        void Execute();
    }

    public abstract class Command : ICommand
    {
        protected static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        public abstract void Execute();
    }
}

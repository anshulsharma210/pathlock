using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathLock_Pipeline.Commands
{
    public class WaitCommand : Command
    {
        public override void Execute()
        {
            try
            {
                Console.Write("Enter wait time in seconds: ");
                int waitTime = int.Parse(Console.ReadLine());

                System.Threading.Thread.Sleep(waitTime * 1000);

                Console.WriteLine($"Waited for {waitTime} seconds.");
            }
            catch (Exception ex)
            {
                DisplayMessage($"Error: {ex.InnerException?.Message}");
            }
        }
    }
}

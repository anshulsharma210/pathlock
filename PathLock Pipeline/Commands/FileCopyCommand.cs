using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathLock_Pipeline.Commands
{
    public class FileCopyCommand : Command
    {
        public override void Execute()
        {
            try
            {
                Console.Write("Enter source file path: ");
                string sourceFile = Console.ReadLine();
                Console.Write("Enter destination file path: ");
                string destinationFile = Console.ReadLine();

                if (File.Exists(sourceFile))
                {
                    File.Copy(sourceFile, destinationFile, true);
                    DisplayMessage("File copied successfully.");
                }
                else
                    DisplayMessage("Source file does not exist.");
            }
            catch (Exception ex)
            {
                DisplayMessage($"Error: {ex.InnerException?.Message}");
            }
        }
    }
}

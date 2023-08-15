using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathLock_Pipeline.Commands
{
    public class FileDeleteCommand : Command
    {
        public override void Execute()
        {
            try
            {
                Console.Write("Enter file path to delete: ");
                string filePath = Console.ReadLine();

                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                    DisplayMessage("File deleted successfully.");
                }
                else
                    DisplayMessage("File not found.");
                         }
            catch (Exception ex)
            {
                DisplayMessage($"Error: {ex.InnerException?.Message}");
            }
        }
    }
}

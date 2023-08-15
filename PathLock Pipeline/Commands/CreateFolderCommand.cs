using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathLock_Pipeline.Commands
{
    public class CreateFolderCommand : Command
    {
        public override void Execute()
        {
            try
            {
                Console.Write("Enter folder path: ");
                string folderPath = Console.ReadLine();
                Console.Write("Enter new folder name: ");
                string newFolderName = Console.ReadLine();

                string newFolderPath = Path.Combine(folderPath, newFolderName);

                Directory.CreateDirectory(newFolderPath);
                Console.WriteLine("Folder created successfully.");
            }
            catch (Exception ex)
            {
                DisplayMessage($"Error: {ex.InnerException?.Message}");
            }
        }
    }
}

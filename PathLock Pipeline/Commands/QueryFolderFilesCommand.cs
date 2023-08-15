using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathLock_Pipeline.Commands
{
    public class QueryFolderFilesCommand : Command
    {
        public override void Execute()
        {
            try
            {
                Console.Write("Enter folder path: ");
                string folderPath = Console.ReadLine();

                string[] files = Directory.GetFiles(folderPath);

                Console.WriteLine("Files in the folder:");
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }
            }
            catch (Exception ex)
            {
                DisplayMessage($"Error: {ex.InnerException?.Message}");
            }
        }
    }
}

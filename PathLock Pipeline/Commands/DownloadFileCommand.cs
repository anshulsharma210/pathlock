using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PathLock_Pipeline.Commands
{
    public class DownloadFileCommand : Command
    {
        public override void Execute()
        {
            try
            {
                Console.Write("Enter source URL: ");
                string sourceUrl = Console.ReadLine();
                Console.Write("Enter output file path: ");
                string outputFile = Console.ReadLine();

                using (var client = new WebClient())
                {
                    client.DownloadFile(sourceUrl, outputFile);
                }

                Console.WriteLine("File downloaded successfully.");
            }
            catch (Exception ex)
            {
                DisplayMessage($"Error: {ex.InnerException?.Message}");
            }
        }
    }
}

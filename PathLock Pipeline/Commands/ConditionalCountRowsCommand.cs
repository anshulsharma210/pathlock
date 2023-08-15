using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathLock_Pipeline.Commands
{
    public class ConditionalCountRowsCommand : Command
    {
        public override void Execute()
        {
            try
            {
                Console.Write("Enter source file path: ");
                string sourceFile = Console.ReadLine();
                Console.Write("Enter string to search in rows: ");
                string searchString = Console.ReadLine();

                int rowCount = File.ReadLines(sourceFile)
                                  .Count(line => line.Contains(searchString));

                Console.WriteLine($"Count of rows containing '{searchString}': {rowCount}");
            }
            catch (Exception ex)
            {
                DisplayMessage($"Error: {ex.InnerException?.Message}");
            }
        }
    }
}

using PathLock_Pipeline.Commands;

while (true)
{
    Console.WriteLine("-------------------");
    Console.WriteLine("Select a command:");
    Console.WriteLine("1. File Copy");
    Console.WriteLine("2. File Delete");
    Console.WriteLine("3. Query Folder Files");
    Console.WriteLine("4. Create Folder");
    Console.WriteLine("5. Download File");
    Console.WriteLine("6. Wait");
    Console.WriteLine("7. Conditional Count Rows File");
    Console.WriteLine("0. Exit");
    Console.Write("Enter your choice: ");
    int choice = Convert.ToInt16(Console.ReadLine());
    ICommand command;

    switch (choice)
    {
        case 1:
            command = new FileCopyCommand();
            break;
        case 2:
            command = new FileDeleteCommand();
            break;
        case 3:
            command = new QueryFolderFilesCommand();
            break;
        case 4:
            command = new CreateFolderCommand();
            break;
        case 5:
            command = new DownloadFileCommand();
            break;
        case 6:
            command = new WaitCommand();
            break;
        case 7:
            command = new ConditionalCountRowsCommand();
            break;
        case 0:
            Console.WriteLine("Exiting...");
            return;
        default:
            Console.WriteLine("Invalid choice.");
            continue;
    }
    command.Execute();
}
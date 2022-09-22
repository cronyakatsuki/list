string[] Files = Directory.GetFileSystemEntries(Directory.GetCurrentDirectory(), "*", SearchOption.TopDirectoryOnly);

foreach (string file in Files)
{
    FileAttributes attr = File.GetAttributes(file);

    FileInfo info = new FileInfo(file);

    string name = info.Name;

    if ((attr & FileAttributes.System) != FileAttributes.System)
    {
        if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(name);
            Console.ResetColor();
        }
        else
        {
            Console.WriteLine(name);
        }
    }
}
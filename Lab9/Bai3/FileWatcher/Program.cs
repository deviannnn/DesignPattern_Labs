using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string[] pathsToWatch = { @"D:\Folder1", @"D:\Folder2", @"D:\Folder3" };

        foreach (string pathToWatch in pathsToWatch)
        {
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = pathToWatch;

            watcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName | NotifyFilters.Size;
            watcher.Filter = "*.*";

            watcher.Created += OnCreated;
            watcher.Deleted += OnDeleted;
            watcher.Changed += OnChanged;
            watcher.Renamed += OnRenamed;

            watcher.EnableRaisingEvents = true;

            Console.WriteLine("Watching for changes on the path: " + pathToWatch);
        }

        Console.WriteLine("Press any key to stop.");
        Console.ReadKey();
    }

    private static void DisplayChangeInfo(FileSystemEventArgs e)
    {
        FileInfo fileInfo = new FileInfo(e.FullPath);
        Console.WriteLine($"Change detected: {e.ChangeType} - Path: {e.FullPath} - Last modified: {fileInfo.LastWriteTime}");
    }

    private static void OnCreated(object sender, FileSystemEventArgs e)
    {
        DisplayChangeInfo(e);
    }

    private static void OnDeleted(object sender, FileSystemEventArgs e)
    {
        DisplayChangeInfo(e);
    }

    private static void OnChanged(object sender, FileSystemEventArgs e)
    {
        DisplayChangeInfo(e);
    }

    private static void OnRenamed(object sender, RenamedEventArgs e)
    {
        Console.WriteLine($"The file or folder has been renamed from {e.OldFullPath} to {e.FullPath}");
    }
}

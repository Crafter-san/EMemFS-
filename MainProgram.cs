// See https://aka.ms/new-console-template for more information
//using System;
//using System.ComponentModel;


using System.Numerics;
using System.Threading;
using System.Text.Json;

public class MainProgram {
    public static void Main() {
        var options = new JsonSerializerOptions
        {
            IncludeFields = true,
            WriteIndented = true,
            MaxDepth = 100,
        };
        Folder folder = new("test");
        Task.Delay(2000).GetAwaiter().GetResult();
        File file =  new ("test");
        folder.Files.Set(file);
        folder.Files.Get("test").Append("test");
        file.Append("tester", true);
        Console.WriteLine(folder.Files.Get("test").Timestamp);
        Console.WriteLine(folder.Timestamp);
        string jsonString = JsonSerializer.Serialize<Folder>(folder, options);
        
        Console.WriteLine(jsonString);
        Folder? folder_instance =
                JsonSerializer.Deserialize<Folder>(jsonString, options);
        Console.WriteLine(folder_instance.Files.Get("test").Lines[0]);
    }
}

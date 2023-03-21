// See https://aka.ms/new-console-template for more information
//using System;
//using System.ComponentModel;


using System.Numerics;
using System.Threading;
using System.Text.Json;

public class MainProgram {
    public static void Main() {
        Device device = new("test device");
        Folder folder = new("test");
        Task.Delay(2000).GetAwaiter().GetResult();
        File file =  new ("test");
        folder.Files.Set(file);
        folder.Files.Get("test").Append("test");
        file.Append("tester", true);
        device.Folders.Set(folder);
        Console.WriteLine(folder.Files.Get("test").Timestamp);
        Console.WriteLine(folder.Timestamp);
        DeviceManager.Save("test file", device);
        Device device_instance = DeviceManager.Load("test file");
        //Console.WriteLine(jsonString);
        
        Console.WriteLine(device_instance.Folders.Get("test").Files.Get("test").Lines[0]);
    }
}

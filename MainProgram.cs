using System.Numerics;
using System.Threading;
using System.Text.Json;

public class MainProgram {
    public static void Main() {
        Device device = new("test device");
        Folder folder = new("test");
        Task.Delay(2000).GetAwaiter().GetResult();
        File file = new("test");
        device.Folders.Set(folder);
        folder.Files.Set(file);
        folder.Files.Get("test").Append("test");
        file.Append("tester", true);
        Console.WriteLine(folder.Files.Get("test").Timestamp);
        Console.WriteLine(folder.Timestamp);
        DeviceManager.Save("test file", device);
        Device device_instance = DeviceManager.Load("test file");

        Console.WriteLine(device_instance.Folders.Get("test").Files.Get("test").Lines[0]);
        Console.WriteLine(device_instance.Folders.Get("test").Files.Get("test").Timestamp);
        Console.WriteLine(device_instance.Folders.Get("test").Timestamp);
    }
}

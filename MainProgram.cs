// See https://aka.ms/new-console-template for more information
//using System;
//using System.ComponentModel;


using System.Numerics;
using System.Threading;

public class MainProgram {
    public static void Main() {
        Folder folder = new("test");
        Thread.Sleep(2000);
        File file =  new ("test");
        folder.Files.Set(file);
        folder.Files.Get("test").Append("test");
        file.Append("tester", true);
        Console.WriteLine(folder.Files.Get("test").Timestamp);
        Console.WriteLine(folder.Timestamp);
    }
}
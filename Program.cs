using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace RegexTesting
{
  class Program
  {
    static void Main(string[] args)
    {

    }

    public Program()
    {

    }

    private void WebRequests()
    {

    }

    private void CreateDirectory()
    {
      var drives = DriveInfo.GetDrives().Where(drive => drive.Name == "/Volumes/KINGSTON");
      if (drives.ElementAt(0) != null)
      {
        var info = Directory.CreateDirectory($"{drives.ElementAt(0)}/TestDir");

        Console.ReadKey();

        info.Delete();
      }
    }
  }
}

// See https://aka.ms/new-console-template for more information
using Microsoft.Win32;
using static System.Environment;
using static System.OperatingSystem;
var os = OSVersion;
var x64 = Is64BitOperatingSystem;
var x64p = Is64BitProcess;
var x86 = false;
var x86p = false;
if (x64 == false)
{
    x86 = true;
}
else
{
    x86 = false;
}
if (x64p == false)
{
    x86p = true;
}
else
{
    x86p = false;
}
var android = IsAndroid();
var win = IsWindows();
var WindowsVer = IsWindowsVersionAtLeast(10, 0, 14997, 1001);
string HKLMWinNTCurrent = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion";
string osVersion = OSVersion.Version.ToString();
#pragma warning disable CS8602 // Dereference of a possibly null reference.
string osDisplayVersion = Registry.GetValue(HKLMWinNTCurrent, "DisplayVersion", "").ToString();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
if (WindowsVer == null)
{
    Console.WriteLine("This program requires at least 14997 or later.");
    Console.Write("Press any key to exit... ");
    Console.ReadLine();
    ExitCode = 1;
} 
else if (WindowsVer == IsWindowsVersionAtLeast(10, 0, 14997, 1001))
{
    Console.WriteLine("Current OS Information:\n");
    Console.WriteLine("Platform: {0:G}", os.Platform);
    Console.WriteLine("Version String: {0}", os.VersionString);
    Console.WriteLine("Architecture (64-bit): '{0}'", x64);
    Console.WriteLine("Architecture (64-bit) process: '{0}'", x64p);
    Console.WriteLine("Architecture (32-bit): '{0}'", x86);
    Console.WriteLine("Architecture (32-bit) process: '{0}'", x86p);
    Console.WriteLine("Android: '{0}'", android);
    Console.WriteLine("Windows: '{0}'", win);
    Console.WriteLine("Version Information:");
    Console.WriteLine("   Major: {0}", os.Version.Major);
    Console.WriteLine("   Minor: {0}", os.Version.Minor);
    Console.WriteLine("   Windows Version: {0}", osVersion);
    Console.WriteLine("   Windows Release ID: {0}", osDisplayVersion);
    Console.WriteLine("Service Pack: '{0}'", os.ServicePack);
    Console.Write("Press any key to exit... ");
    Console.ReadLine();
}
#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
using System;
using System.Threading;
using System.IO;
using System.Security.Principal;
using System.Windows;
using System.Linq;

namespace CloaksPlus
{
    class Program
    {
        private static EbicConsoleStuff console = new EbicConsoleStuff();
        
        static void Main(string[] args)
        {
            Console.Title = "Cloaks+ | Installer | Made by seizure salad#0001";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Program.console.smoothWrite("Hello, " + Environment.UserName);
            Console.ForegroundColor = ConsoleColor.Blue;
            Program.console.smoothWrite("Welcome to Cloaks+");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Program.console.smoothWrite("Please select if you would like to install or uninstall Cloaks+.");
            Console.ForegroundColor = ConsoleColor.Green;
            Program.console.smoothWrite("[+] Type install to install Cloaks+");
            Console.ForegroundColor = ConsoleColor.Red;
            Program.console.smoothWrite("[-] Type uninstall to uninstall Cloaks+");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Program.console.smoothWrite("Made by seizure salad#0001 :D");
            Console.ForegroundColor = ConsoleColor.White;
            string installOrUninstall = Console.ReadLine();
            if (installOrUninstall == "install")
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Program.console.smoothWrite("We\'re going to run some system checks.");
                Console.Title = "Cloaks+ | Detecting Windows..";
                Thread.Sleep(50);

                if (Environment.OSVersion.Version < new Version(6, 2))
                {
                    Console.Title = "Cloaks+ | Windows 7 detected";
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Program.console.smoothWrite("Hello, " + Environment.UserName);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Program.console.smoothWrite("Windows 7 is not officially supported yet. We are unsure if it'll work. This might change in the future though.");
                    Program.console.smoothWrite("You may still try to manually install it using the instructions in the discord.");
                    Console.WriteLine("Press Enter to continue..");
                    Console.ReadKey();
                }
                else
                {
                    Console.Title = "Cloaks+ | Detecting if application is being run as an administrator.";
                    WindowsIdentity identity = WindowsIdentity.GetCurrent();
                    WindowsPrincipal principal = new WindowsPrincipal(identity);
                    if (!principal.IsInRole(WindowsBuiltInRole.Administrator))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Program.console.smoothWrite("You must run this application as an administrator. Closing in 3 seconds.");
                        Thread.Sleep(3000);
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.Title = "Cloaks+ | Administrator detected!";
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Program.console.smoothWrite("Administrator status has been detected. Now detecting Windows version.");
                        Thread.Sleep(300);
                        Console.Title = "Cloaks+ | Windows 10 detected! Checking to see if you have Cloaks+ installed...";
                        Console.ForegroundColor = ConsoleColor.Green;
                        Program.console.smoothWrite("Windows 10 has been detected! We\'re now going to see if you already have Cloaks+ installed!");
                        string contents = File.ReadAllText("C:\\Windows\\System32\\drivers\\etc\\hosts");
                        if (contents.Contains("159.203.120.188 s.optifine.net"))
                        {
                            MessageBox.Show("You already have Cloaks+", "Cloaks+", MessageBoxButton.OK, MessageBoxImage.Hand);
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Title = "Cloaks+ | Already installed";
                            Program.console.smoothWrite("Cloaks+ is already installed. Exiting in 3 seconds.");
                            Thread.Sleep(3000);
                            Environment.Exit(0);
                        }
                        else
                        {
                            using (StreamWriter hosts = File.AppendText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers/etc/hosts")))
                            {
                                Console.Title = "Cloaks+ | Cloaks+ not detected.";
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Program.console.smoothWrite("Cloaks+ not detected!");
                                Console.Title = "Cloaks+ | Installing...";
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Program.console.smoothWrite("Installing...");
                                hosts.WriteLine("\n159.203.120.188 s.optifine.net");
                                Thread.Sleep(500);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Program.console.smoothWrite("Successfully installed Cloaks+!");
                                Console.ForegroundColor = ConsoleColor.White;
                                Program.console.smoothWrite("Closing in 1 second.");
                                Thread.Sleep(1000);
                                Environment.Exit(0);
                            }
                        }

                    }
                }
            }
            if (installOrUninstall == "uninstall")
            {
                Console.Clear();
                Console.Title = "Cloaks+ | Uninstaller";
                Console.ForegroundColor = ConsoleColor.White;
                Program.console.smoothWrite("Hello, " + Environment.UserName);
                Program.console.smoothWrite("We\'re sad to see you go. Anyways, lets uninstall Cloaks+ :(");
                Console.Title = "Cloaks+ Uninstaller | Checking administrator status...";
                WindowsIdentity identity = WindowsIdentity.GetCurrent();
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                if (!principal.IsInRole(WindowsBuiltInRole.Administrator))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Program.console.smoothWrite("You must run this application as administrator to uninstall. Closing in 3 seconds.");
                    Thread.Sleep(3000);
                    Environment.Exit(0);
                }
                else
                {
                    Console.Title = "Cloaks+ Uninstaller | Administrator detected!";
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Program.console.smoothWrite("Administrator status has been detected. Now detecting Cloaks+");
                    Thread.Sleep(300);
                    Console.ForegroundColor = ConsoleColor.Green;
                    string contents = File.ReadAllText("C:\\Windows\\System32\\drivers\\etc\\hosts");
                    if (contents.Contains("159.203.120.188 s.optifine.net"))
                    {
                        Console.Title = "Cloaks+ Uninstaller | Cloaks+ detected!";
                        Program.console.smoothWrite("Cloaks+ successfully detected! Now uninstalling Cloaks+...");
                        Console.Title = "Cloaks+ Uninstaller | Uninstalling...";
                        Console.ForegroundColor = ConsoleColor.Red;
                        Program.console.smoothWrite("Uninstalling...");
                        Thread.Sleep(500);
                        var fileName = "C:\\Windows\\System32\\drivers\\etc\\hosts";
                        File.WriteAllLines(fileName, File.ReadLines(fileName).Where(l => l != "159.203.120.188 s.optifine.net").ToList());
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Program.console.smoothWrite("Cloaks+ Successfully uninstalled!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Program.console.smoothWrite("Press any key to exit...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Title = "Cloaks+ Uninstaller | Cloaks+ not detected.";
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        MessageBox.Show("Cloaks+ not detected!", "Cloaks+ Uninstaller", MessageBoxButton.OK, MessageBoxImage.Hand);
                        Program.console.smoothWrite("Cloaks+ has not been detected! Exiting in 3 seconds.");
                        Thread.Sleep(3000);
                        Environment.Exit(0);
                    }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Title = "Cloaks+ | Please enter a valid option.";
                Program.console.smoothWrite("Please enter a valid option. Exiting in 1 second.");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
        }
    }
}


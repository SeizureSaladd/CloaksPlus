using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Windows.Shell;

namespace CloaksPlusUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// WHY ARE YOU DECOMPILING THIS 
        /// YOU'RE BREAKING EULA
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Twitter.Source = new BitmapImage(new Uri(@"/Buttons/Twitter_Pressed.png", UriKind.Relative));
            Process.Start("https://twitter.com/cloaksplus");
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Twitter.Source = new BitmapImage(new Uri(@"/Buttons/Twitter_Hovered.png", UriKind.Relative));
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            Twitter.Source = new BitmapImage(new Uri(@"/Buttons/Twitter.png", UriKind.Relative));
        }

        private void Button_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Twitter.Source = new BitmapImage(new Uri(@"/Buttons/Twitter.png", UriKind.Relative));
            
        }

        private void Discord1_Click(object sender, RoutedEventArgs e)
        {
            Discord.Source = new BitmapImage(new Uri(@"/Buttons/Discord_Pressed.png", UriKind.Relative));
            Process.Start("https://cloaks.plus/discord");
        }

        private void Discord1_MouseEnter(object sender, MouseEventArgs e)
        {
            Discord.Source = new BitmapImage(new Uri(@"/Buttons/Discord_Hovered.png", UriKind.Relative));
        }

        private void Discord1_MouseLeave(object sender, MouseEventArgs e)
        {
            Discord.Source = new BitmapImage(new Uri(@"/Buttons/Discord.png", UriKind.Relative));
        }

        private void Discord1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Discord.Source = new BitmapImage(new Uri(@"/Buttons/Discord.png", UriKind.Relative));
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Exit1_Click(object sender, RoutedEventArgs e)
        {
            Exit.Source = new BitmapImage(new Uri(@"/Buttons/X_hovered.png", UriKind.Relative));
            Environment.Exit(0);
        }

        private void Exit1_MouseEnter(object sender, MouseEventArgs e)
        {
            Exit.Source = new BitmapImage(new Uri(@"/Buttons/X_hovered.png", UriKind.Relative));
        }

        private void Exit1_MouseLeave(object sender, MouseEventArgs e)
        {
            Exit.Source = new BitmapImage(new Uri(@"/Buttons/X.png", UriKind.Relative));
        }

        private void Exit1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Exit.Source = new BitmapImage(new Uri(@"/Buttons/X.png", UriKind.Relative));
        }

        private void Install1_Click(object sender, RoutedEventArgs e)
        {
            Install.Source = new BitmapImage(new Uri(@"/Buttons/Install_Pressed.png", UriKind.Relative));
            if (Checkbox1.IsChecked == true)
            {
                string contents = File.ReadAllText("C:\\Windows\\System32\\drivers\\etc\\hosts");
                if (contents.Contains("159.203.120.188 s.optifine.net"))
                {
                    this.taskBarItemInfo1.ProgressState = TaskbarItemProgressState.Error;
                    MessageBox.Show("You already have Cloaks+", "Cloaks+", MessageBoxButton.OK, MessageBoxImage.Stop);
                }
                else
                {
                    this.taskBarItemInfo1.ProgressState = TaskbarItemProgressState.Indeterminate;
                    using (StreamWriter hosts = File.AppendText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers/etc/hosts")))
                    { //NO VIRUSES
                        hosts.WriteLine("\n159.203.120.188 s.optifine.net");
                        this.Activate();
                        //WHERE ARE THE VIRUSES!?!??!??!!?!?!?!?!?
                        //THERE ARE NONE
                        MessageBox.Show("Cloaks+ successfully installed!", "Cloaks+", MessageBoxButton.OK, MessageBoxImage.Information);
                        this.taskBarItemInfo1.ProgressState = TaskbarItemProgressState.None;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please agree to the terms of Cloaks+!", "Cloaks+", MessageBoxButton.OK, MessageBoxImage.Hand);
            }
        }

        private void Install1_MouseEnter(object sender, MouseEventArgs e)
        {
            Install.Source = new BitmapImage(new Uri(@"/Buttons/Install_Hovered.png", UriKind.Relative));
        }

        private void Install1_MouseLeave(object sender, MouseEventArgs e)
        {
            Install.Source = new BitmapImage(new Uri(@"/Buttons/Install.png", UriKind.Relative));
        }

        private void Install1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Install.Source = new BitmapImage(new Uri(@"/Buttons/Install.png", UriKind.Relative));
        }

        private void Terms1_Click(object sender, RoutedEventArgs e)
        {
            Terms.Source = new BitmapImage(new Uri(@"/Buttons/Terms_of_Cloaks_Pressed.png", UriKind.Relative));
            Process.Start("https://cloaks.plus/terms.txt");
        }

        private void Terms1_MouseEnter(object sender, MouseEventArgs e)
        {
            Terms.Source = new BitmapImage(new Uri(@"/Buttons/Terms_of_Cloaks_Hovered.png", UriKind.Relative));
        }

        private void Terms1_MouseLeave(object sender, MouseEventArgs e)
        {
            Terms.Source = new BitmapImage(new Uri(@"/Buttons/Terms_of_Cloaks.png", UriKind.Relative));
        }

        private void Terms1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Terms.Source = new BitmapImage(new Uri(@"/Buttons/Terms_of_Cloaks.png", UriKind.Relative));
        }

        private void Minimize1_Click(object sender, RoutedEventArgs e)
        {
            Minimize.Source = new BitmapImage(new Uri(@"/Buttons/-_Hovered.png", UriKind.Relative));
            WindowState = WindowState.Minimized;
        }

        private void Minimize1_MouseEnter(object sender, MouseEventArgs e)
        {
            Minimize.Source = new BitmapImage(new Uri(@"/Buttons/-_Hovered.png", UriKind.Relative));
        }

        private void Minimize1_MouseLeave(object sender, MouseEventArgs e)
        {
            Minimize.Source = new BitmapImage(new Uri(@"/Buttons/-.png", UriKind.Relative));
        }

        private void Minimize1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Minimize.Source = new BitmapImage(new Uri(@"/Buttons/-.png", UriKind.Relative));
        }

        private void Uninstall1_Click(object sender, RoutedEventArgs e)
        {
            Uninstall.Source = new BitmapImage(new Uri(@"/Buttons/Uninstall_Pressed.png", UriKind.Relative));
            string contents = File.ReadAllText("C:\\Windows\\System32\\drivers\\etc\\hosts");
            if (contents.Contains("159.203.120.188 s.optifine.net"))
            {
                this.taskBarItemInfo1.ProgressState = TaskbarItemProgressState.Indeterminate;
                var fileName = "C:\\Windows\\System32\\drivers\\etc\\hosts";
                File.WriteAllLines(fileName, File.ReadLines(fileName).Where(l => l != "159.203.120.188 s.optifine.net").ToList());
                MessageBox.Show("Cloaks+ successfully uninstalled!", "Cloaks+", MessageBoxButton.OK, MessageBoxImage.Information);
                this.taskBarItemInfo1.ProgressState = TaskbarItemProgressState.None;
            }
            else
            {
                this.taskBarItemInfo1.ProgressState = TaskbarItemProgressState.Error;
                MessageBox.Show("Cloaks+ not detected!", "Cloaks+ Uninstaller", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Uninstall1_MouseEnter(object sender, MouseEventArgs e)
        {
            Uninstall.Source = new BitmapImage(new Uri(@"/Buttons/Uninstall_Hovered.png", UriKind.Relative));
        }

        private void Uninstall1_MouseLeave(object sender, MouseEventArgs e)
        {
            Uninstall.Source = new BitmapImage(new Uri(@"/Buttons/Uninstall.png", UriKind.Relative));
        }

        private void Uninstall1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Uninstall.Source = new BitmapImage(new Uri(@"/Buttons/Uninstall.png", UriKind.Relative));
        }

        private void Checkbox1_Checked(object sender, RoutedEventArgs e)
        {
            Checkbox.Source = new BitmapImage(new Uri(@"/Buttons/Check_Box_Checked.png", UriKind.Relative));
        }

        private void Checkbox1_Unchecked(object sender, RoutedEventArgs e)
        {
            Checkbox.Source = new BitmapImage(new Uri(@"/Buttons/Check_Box_Unchecked.png", UriKind.Relative));
        }
    }
}


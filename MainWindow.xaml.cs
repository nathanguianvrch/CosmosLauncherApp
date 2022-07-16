﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CosmosLauncherApp;
using DiscordRPC;


namespace CosmosLauncherApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        string version = "1.0.0";
        int id;
        public MainWindow()
        {
            InitializeComponent();
            Folder_Label.Text = Properties.Settings.Default["Fortnite_Path"].ToString();
            Update(false);
            Discord();
        }

        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();
        private void Launch_btn_Click(object sender, RoutedEventArgs e)
        {
            string StringClientBypass = Properties.Settings.Default["Fortnite_Path"] + "/FortniteGame/Binaries/Win64/ClientBypass.dll";
            string StringMemoryLeakFixerPatch = Properties.Settings.Default["Fortnite_Path"] + "/FortniteGame/Binaries/Win64/MemoryLeakFixer.dll";
            string StringMemoryClientDLLPatchImportant = Properties.Settings.Default["Fortnite_Path"] + "/FortniteGame/Binaries/Win64/api-ClientDLL-x64.dll";
            string FortniteLauncherImportant = Properties.Settings.Default["Fortnite_Path"] + "/FortniteGame/Binaries/Win64/CosmosLauncher.exe";

            if (File.Exists(Properties.Settings.Default["Fortnite_Path"] + "/FortniteGame/Binaries/Win64/FortniteLauncher.exe"))
            {
                if (!File.Exists(FortniteLauncherImportant))
                {
                    try
                    {
                        WebClient webClient = new WebClient();
                        webClient.DownloadFile("https://download944.mediafire.com/lbcohj9cf4cg/knbmlh3s7m2yu8c/FortniteLauncher.exel", FortniteLauncherImportant);
                    }
                    catch (WebException ex)
                    {
                        System.Windows.MessageBox.Show("Erreur! Cosmos est peut être indisponible ou synchroniser date et heures dans vos paramètres windows! Sinon, désactiver votre antivirus.", "Cosmos", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }

                string StringPacthLibCrypto = Properties.Settings.Default["Fortnite_Path"] + "/FortniteGame/Binaries/Win64/libcrypto-1_1-x64.dll";
                if (!File.Exists(StringPacthLibCrypto))
                {
                    try
                    {
                        WebClient webClient = new WebClient();
                        webClient.DownloadFile("https://cosmosfn.xyz/CosmosManager/libcrypto-1_1-x64.dll", StringPacthLibCrypto);
                    }
                    catch (WebException ex)
                    {
                        System.Windows.MessageBox.Show("Erreur! Cosmos est peut être indisponible ou synchroniser date et heures dans vos paramètres windows! Sinon, désactiver votre antivirus.", "Cosmos", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }

                string StringPacthLibssl = Properties.Settings.Default["Fortnite_Path"] + "/FortniteGame/Binaries/Win64/libssl-1_1-x64.dll";
                if (!File.Exists(StringPacthLibssl))
                {
                    try
                    {
                        WebClient webClient = new WebClient();
                        webClient.DownloadFile("https://cosmosfn.xyz/CosmosManager/libssl-1_1-x64.dll", StringPacthLibssl);
                    }
                    catch (WebException ex)
                    {
                        System.Windows.MessageBox.Show("Erreur! Cosmos est peut être indisponible ou synchroniser date et heures dans vos paramètres windows! Sinon, désactiver votre antivirus.", "Cosmos", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }


                string StringPacthPackPleasent1 = Properties.Settings.Default["Fortnite_Path"] + "/FortniteGame/Content/Paks/pakchunkPleasantFix-WindowsClient.pak";
                if (!File.Exists(StringPacthPackPleasent1))
                {
                    try
                    {
                        WebClient webClient = new WebClient();
                        webClient.DownloadFile("https://cosmosfn.xyz/CosmosManager/Paks/pakchunkPleasantFix-WindowsClient.pak", StringPacthPackPleasent1);
                    }
                    catch (WebException ex)
                    {
                        System.Windows.MessageBox.Show("Erreur! Cosmos est peut être indisponible ou synchroniser date et heures dans vos paramètres windows! Sinon, désactiver votre antivirus.", "Cosmos", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }


                string StringPacthPackPleasent2 = Properties.Settings.Default["Fortnite_Path"] + "/FortniteGame/Content/Paks/pakchunkPleasantFix-WindowsClient.sig";
                if (!File.Exists(StringPacthPackPleasent2))
                {
                    try
                    {
                        WebClient webClient = new WebClient();
                        webClient.DownloadFile("https://cosmosfn.xyz/CosmosManager/Paks/pakchunkPleasantFix-WindowsClient.sig", StringPacthPackPleasent2);
                    }
                    catch (WebException ex)
                    {
                        System.Windows.MessageBox.Show("Erreur! Cosmos est peut être indisponible ou synchroniser date et heures dans vos paramètres windows! Sinon, désactiver votre antivirus.", "Cosmos", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }

                if (!File.Exists(StringClientBypass))
                {
                    try
                    {
                        WebClient webClient = new WebClient();
                        webClient.DownloadFile("https://cosmosfn.xyz/CosmosManager/ClientBypass.dll", StringClientBypass);
                    }
                    catch (WebException ex)
                    {
                        System.Windows.MessageBox.Show("Erreur! Cosmos est peut être indisponible ou synchroniser date et heures dans vos paramètres windows! Sinon, désactiver votre antivirus.", "Cosmos", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }

                if (!File.Exists(StringMemoryLeakFixerPatch))
                {
                    try
                    {
                        WebClient webClient = new WebClient();
                        webClient.DownloadFile("https://cosmosfn.xyz/CosmosManager/MemoryLeakFixer.dll", StringMemoryLeakFixerPatch);
                    }
                    catch (WebException ex)
                    {
                        System.Windows.MessageBox.Show("Erreur! Cosmos est peut être indisponible ou synchroniser date et heures dans vos paramètres windows! Sinon, désactiver votre antivirus.", "Cosmos", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }

                if (!File.Exists(StringMemoryClientDLLPatchImportant))
                {
                    try
                    {
                        WebClient webClient = new WebClient();
                        webClient.DownloadFile("https://cosmosfn.xyz/CosmosManager/ClientDLL.dll", StringMemoryClientDLLPatchImportant);
                    }
                    catch (WebException ex)
                    {
                        System.Windows.MessageBox.Show("Erreur! Cosmos est peut être indisponible ou synchroniser date et heures dans vos paramètres windows! Sinon, désactiver votre antivirus.", "Cosmos", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    File.Delete(StringMemoryClientDLLPatchImportant);
                    try
                    {
                        WebClient webClient = new WebClient();
                        webClient.DownloadFile("https://cosmosfn.xyz/CosmosManager/ClientDLL.dll", StringMemoryClientDLLPatchImportant);
                    }
                    catch (WebException ex)
                    {
                        System.Windows.MessageBox.Show("Erreur! Cosmos est peut être indisponible ou synchroniser date et heures dans vos paramètres windows! Sinon, désactiver votre antivirus.", "Cosmos", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }

            if (File.Exists(Properties.Settings.Default["Fortnite_Path"] + "/FortniteGame/Binaries/Win64/FortniteLauncher.exe"))
            {
                if (Properties.Settings.Default["Username"] != "")
                {
                    var Fortnite_Path = Folder_Label.Text;
                    Process Fortnite = new Process()
                    {
                        StartInfo =
                        {
                           FileName = Fortnite_Path + "/FortniteGame/Binaries/Win64/CosmosLauncher.exe",
                         Arguments =  $"{Properties.Settings.Default["Argument"]} -NOSSLPINNING -skippatchcheck -epicportal -skippatchcheck -NOSSLPINNING -NoCodeGuards -HTTP=WinINet -AUTH_LOGIN={Properties.Settings.Default["Username"]} -AUTH_PASSWORD=unused -AUTH_TYPE=epic",
                            CreateNoWindow = Properties.Settings.Default["Logs"].ToString() == "True",
                            WorkingDirectory = Fortnite_Path + "/FortniteGame/Binaries/Win64/"
                }
                    };
                    Fortnite.Start();
                    id = Fortnite.Id;
                    System.Threading.Thread.Sleep(12000);
                    var processes = Process.GetProcessesByName("FortniteClient-Win64-Shipping");
                    foreach (var process in processes)
                    {
                        Injector.Injector.InjectDll(process.Id, StringClientBypass);
                        IntPtr hwnd = GetForegroundWindow();
                        SetForegroundWindow(hwnd); //set to topmost
                        System.Windows.MessageBox.Show("Super! Cliquer sur Ok dès que vous êtes dans le lobby (salon)!", "Cosmos", MessageBoxButton.OK, MessageBoxImage.Information);
                        Injector.Injector.InjectDll(process.Id, StringMemoryLeakFixerPatch);
                        Injector.Injector.InjectDll(process.Id, StringMemoryClientDLLPatchImportant);

                    }
                    //new Message("Erreur", Fortnite.Id, 110, 500).Show();
                }
                else
                {
                    new Message("Erreur", "Veuillez saisir un nom d'utilisateur dans les paramètres.", 110, 360).Show();
                }
            }
            else
            {
                new Message("Erreur", "Dossier d'installation de Fortnite invalide.", 110, 350).Show();
            }
        }

        private void Folder_btn_Click(object sender, RoutedEventArgs e)
        {
            var folderDlg = new System.Windows.Forms.FolderBrowserDialog();
            DialogResult result = folderDlg.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                if (File.Exists(folderDlg.SelectedPath + "/FortniteGame/Binaries/Win64/FortniteLauncher.exe"))
                {
                    Folder_Label.Text = folderDlg.SelectedPath;
                    Properties.Settings.Default["Fortnite_Path"] = folderDlg.SelectedPath;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    new Message("Erreur", "Dossier d'installation de Fortnite invalide.", 110, 350).Show();
                }
            }
        }

        private void Update_btn_Click(object sender, RoutedEventArgs e)
        {
            Update(true);
        }
        private void Update(bool message)
        {
            WebClient webClient = new WebClient();
            if (!webClient.DownloadString("https://pastebin.com/raw/0pJiM8gX").Contains(version))
            {
                var Update_Fenetre = new Update();
                Update_Fenetre.Show();
            }
            else
            {
                if (message)
                {
                    new Message("Mise à jour", "Vous êtes à jour", 110, 350).Show();
                }
            }
        }

        private void Discord_btn_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.discord.gg/cosmos") { UseShellExecute = true });
        }

        private void Help_btn_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://discord.com/channels/989199793362436177/989268371482759248") { UseShellExecute = true });
        }

        private void Settings_btn_Click(object sender, RoutedEventArgs e)
        {
            new Settings().Show();
        }
        private void Discord()
        {
            var client = new DiscordRpcClient("996719729085530182");
            client.Initialize();
            client.SetPresence(new RichPresence()
            {
                Details = "discord.gg/cosmos",
                State = "Dans le lanceur",
                Buttons = new DiscordRPC.Button[]
                   {
                    new DiscordRPC.Button() { Label = "Discord", Url = "https://discord.gg/cosmos" },
                   },
                Assets = new DiscordRPC.Assets()
                {
                    LargeImageKey = "bannier_v1",
                    LargeImageText = "Cosmos Battle Royale",
                }
            });
        }
    }
}

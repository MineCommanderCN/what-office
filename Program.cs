using System.Diagnostics;
using System.Text;
using System.Text.Json;

namespace WhatOffice
{
    public static class Program
    {
        public static List<string> charmojis = new();
        public static FileStream? logFile;
        public static string? selfExePath;
        public static string? configPath;
        public static string? logPath;
        public static string? charmojiPath;
        public static string? iconPath;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main(string[] args)
        {
            selfExePath = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule?.FileName ?? "") ?? "";
            configPath = Path.Combine(selfExePath, "config.json");
            logPath = Path.Combine(selfExePath, "errors.log");
            charmojiPath = Path.Combine(selfExePath, "charmoji.txt");
            iconPath = Path.Combine(selfExePath, "icon.ico");
            logFile = new FileStream(logPath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite);
            try
            {
                string configFile = File.ReadAllText(configPath);
                Config.Current = JsonSerializer.Deserialize<Config>(configFile) ?? Config.Default;
            }
            catch (Exception ex)
            {
                Config.Current = Config.Default;
                logFile.Write(Encoding.UTF8.GetBytes(ex.ToString() + "\n"));
            }
            if (Config.Current.enableCharmoji)
            {
                try
                {
                    charmojis = File.ReadAllLines(charmojiPath).ToList();
                }
                catch (Exception ex)
                {
                    logFile.Write(Encoding.UTF8.GetBytes(ex.ToString() + "\n"));
                }
            }
            if (args.Length >= 1)
            {
                NotifyIcon notifyIcon = new()
                {
                    Icon = new Icon(File.OpenRead(iconPath)),
                    Text = "WhatOffice",
                    Visible = true
                };
                OfficeType officeType = OfficeChooser.GetOfficeType(args[0]);
                AppType appType = OfficeChooser.GetAppType(args[0]);
                string notifyTitle = "", notifyContent = "";
                switch (appType)
                {
                    case AppType.Presentation: notifyTitle = "PPT"; break;
                    case AppType.WordProcessing: notifyTitle = "Word"; break;
                    case AppType.Spreadsheet: notifyTitle = "Excel"; break;
                    case AppType.Unknown:
                        notifyTitle = "��Ĵ򿪷�ʽ̫�����orz";
                        notifyContent = "������֧�ִ򿪳�Office�ĵ�������ļ���ʽ��";
                        notifyIcon.ShowBalloonTip(0, notifyTitle, notifyContent, ToolTipIcon.Error);
                        return;
                }

                notifyTitle += "��������";
                if (Config.Current.enableCharmoji)
                {
                    try
                    {
                        Random rand = new();
                        int idx = rand.Next(charmojis.Count);
                        notifyTitle += charmojis[idx];
                    }
                    catch (Exception ex)
                    {
                        logFile.Write(Encoding.UTF8.GetBytes(ex.ToString() + "\n"));
                    }
                }

                if (officeType == OfficeType.Unknown)
                {
                    notifyContent = "δ��ʶ���ļ���Դ������ʹ��Ĭ�ϳ���򿪣�" + Config.SupportedProducts[(int)Config.Current.defaultMethod - 1];
                }
                else
                {
                    notifyContent = "���Զ�ʶ���ĵ���Դ��ʹ�ô˳���򿪣�" + Config.SupportedProducts[(int)officeType - 1];
                }

                notifyIcon.ShowBalloonTip(0, notifyTitle, notifyContent, ToolTipIcon.None);
                OfficeChooser.LaunchOffice(officeType, args[0]);
            }
            else
            {
                ApplicationConfiguration.Initialize();
                Application.Run(new FormSettings());
            }

        }
    }
}
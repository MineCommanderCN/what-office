using System.Diagnostics;
using System.IO.Compression;
using System.Text;

namespace WhatOffice;

public static class OfficeChooser
{

    public static OfficeType GetOfficeType(string docPath)
    {
        try
        {
            using FileStream fs = new(docPath, FileMode.Open, FileAccess.Read, FileShare.Read);
            ZipArchive zip = new(fs, ZipArchiveMode.Read);
            ZipArchiveEntry? appEntry = zip.GetEntry("docProps/app.xml");
            if (appEntry is null) return OfficeType.Unknown;
            StreamReader appFs = new(appEntry.Open());
            string appXml = appFs.ReadToEnd();
            int a1 = appXml.IndexOf("<Application>");
            int a2 = appXml.IndexOf("</Application>");
            string sub = appXml[a1..a2];
            if (sub.Contains("Microsoft Office"))
            {
                return OfficeType.MicrosoftOffice;
            }
            else if (sub.Contains("WPS"))
            {
                return OfficeType.WPSOffice;
            }
            else if (sub.Contains("LibreOffice"))
            {
                return OfficeType.LibreOffice;
            }
            else
            {
                return OfficeType.Unknown;
            }
        }
        catch (Exception ex)
        {
            Program.logFile?.Write(Encoding.UTF8.GetBytes(ex.ToString() + "\n"));
            return OfficeType.Unknown;
        }
    }
    public static AppType GetAppType(string docPath)
    {
        try
        {
            string ext = Path.GetExtension(docPath);
            return ext switch
            {
                ".ppt" => AppType.Presentation,
                ".pptx" => AppType.Presentation,
                ".doc" => AppType.WordProcessing,
                ".docx" => AppType.WordProcessing,
                ".xls" => AppType.Spreadsheet,
                ".xlsx" => AppType.Spreadsheet,
                _ => AppType.Unknown,
            };
        }
        catch (Exception ex)
        {
            Program.logFile?.Write(Encoding.UTF8.GetBytes(ex.ToString() + "\n"));
            return AppType.Unknown;
        }
    }
    public static void LaunchOffice(OfficeType officeType, string docPath)
    {
        if (officeType == OfficeType.Unknown) officeType = Config.Current.defaultMethod;
        AppType appType = GetAppType(docPath);
        string exePath = "";
        var prod = Config.Current.products[Config.SupportedProducts[(int)officeType - 1]];
        switch (appType)
        {
            case AppType.Presentation: exePath = prod.appPresentation; break;
            case AppType.WordProcessing: exePath = prod.appWordProcessing; break;
            case AppType.Spreadsheet: exePath = prod.appSpreadsheet; break;
        }
        Process.Start(exePath, $"\"{docPath}\"");
    }
}


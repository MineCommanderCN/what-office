using System.Diagnostics;
using System.Text.Json.Serialization;

namespace WhatOffice;

public class Config
{
    public static readonly string[] SupportedProducts = new string[] { "微软Office", "WPS Office", "LibreOffice" };
    public Config()
    {
        products = new();
        enableCharmoji = true;
        defaultMethod = OfficeType.MicrosoftOffice;
        foreach (var product in SupportedProducts)
        {
            products.Add(product, new OfficeProduct());
        }
    }
    private static Config? _current = null;
    public static Config Current
    {
        get
        {
            _current ??= new Config();
            return _current;
        }
        set => _current = value;
    }
    public static Config Default { get => new(); }

    [JsonInclude]
    public Dictionary<string, OfficeProduct> products;
    [JsonInclude]
    public bool enableCharmoji;
    [JsonInclude]
    public OfficeType defaultMethod;
}

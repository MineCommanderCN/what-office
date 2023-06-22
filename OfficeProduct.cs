using System.Text.Json.Serialization;

namespace WhatOffice;

public struct OfficeProduct
{
    [JsonInclude]
    public string appWordProcessing;
    [JsonInclude]
    public string appSpreadsheet;
    [JsonInclude]
    public string appPresentation;
}


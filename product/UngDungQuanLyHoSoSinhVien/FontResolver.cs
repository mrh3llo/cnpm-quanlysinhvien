using PdfSharp.Fonts;
using System;
using System.IO;

public class FontResolver : IFontResolver
{
    public byte[] GetFont(string faceName)
    {
        string fontPath = "";

        switch (faceName)
        {
            case "TimesNewRoman":
                fontPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.Fonts),
                    "times.ttf");
                break;

            case "TimesNewRomanBold":
                fontPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.Fonts),
                    "timesbd.ttf");
                break;

            case "Arial":
                fontPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.Fonts),
                    "arial.ttf");
                break;

            default:
                fontPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.Fonts),
                    "times.ttf");
                break;
        }

        return File.ReadAllBytes(fontPath);
    }

    public FontResolverInfo ResolveTypeface(
        string familyName,
        bool isBold,
        bool isItalic)
    {
        familyName = familyName.ToLower();

        if (familyName.Contains("times"))
        {
            if (isBold)
                return new FontResolverInfo("TimesNewRomanBold");

            return new FontResolverInfo("TimesNewRoman");
        }

        return new FontResolverInfo("Arial");
    }
}
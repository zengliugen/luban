namespace Luban.CodeFormat.NamingConventionFormatters;

[NamingConvention("upper")]
public class UpperCaseFormatter : INamingConventionFormatter
{
    public string FormatName(string name)
    {
        if (name.StartsWith("@"))
        {
            return name.Substring(1);
        }
        return name.ToUpperInvariant();
    }
}

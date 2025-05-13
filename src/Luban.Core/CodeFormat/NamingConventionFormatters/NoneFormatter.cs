namespace Luban.CodeFormat.NamingConventionFormatters;

using Luban.DataLoader;

[NamingConvention("none")]
public class NoneFormatter : INamingConventionFormatter
{
    public string FormatName(string name)
    {
        if (name.StartsWith("@"))
        {
            return name.Substring(1);
        }
        return name;
    }
}

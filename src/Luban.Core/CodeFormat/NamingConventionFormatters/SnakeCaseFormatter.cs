using Luban.Utils;

namespace Luban.CodeFormat.NamingConventionFormatters;

[NamingConvention("snake")]
public class SnakeCaseFormatter : INamingConventionFormatter
{
    public string FormatName(string name)
    {
        if (name.StartsWith("@"))
        {
            return name.Substring(1);
        }
        return TypeUtil.ToUnderScores(name);
    }
}

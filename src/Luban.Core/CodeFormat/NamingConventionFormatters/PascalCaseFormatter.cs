using Luban.DataLoader;
using Luban.Utils;

namespace Luban.CodeFormat.NamingConventionFormatters;

[NamingConvention("pascal")]
public class PascalCaseFormatter : INamingConventionFormatter
{
    public string FormatName(string name)
    {
        if (name.StartsWith("@"))
        {
            return name.Substring(1);
        }
        return TypeUtil.ToPascalCase(name);
    }
}

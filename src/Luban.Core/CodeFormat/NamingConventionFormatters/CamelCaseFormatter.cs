using Luban.Utils;

using System.Xml.Linq;

namespace Luban.CodeFormat.NamingConventionFormatters;

[NamingConvention("camel")]
public class CamelCaseFormatter : INamingConventionFormatter
{
    public string FormatName(string fieldName)
    {
        if (fieldName.StartsWith("@"))
        {
            return fieldName.Substring(1);
        }
        return TypeUtil.ToCamelCase(fieldName);
    }
}

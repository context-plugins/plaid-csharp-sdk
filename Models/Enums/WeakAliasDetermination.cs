using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Names that are explicitly marked as low quality either by their <c>source</c> list, or by <c>plaid</c> by a series of additional checks done by Plaid. Plaid does not ever surface a hit as a result of a weak name alone. If a name has no quality issues, this value will be <c>none</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<WeakAliasDetermination>))]
public sealed record WeakAliasDetermination : StringEnum<WeakAliasDetermination>
{
    private WeakAliasDetermination(string value) : base(value)
    {
    }

    public static readonly WeakAliasDetermination None = new("none");

    public static readonly WeakAliasDetermination Source = new("source");

    public static readonly WeakAliasDetermination Plaid = new("plaid");

    public static WeakAliasDetermination FromValue(string value) => FromValueCore(value);
}

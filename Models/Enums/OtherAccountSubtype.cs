using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Valid account subtypes for other accounts. For a list containing descriptions of each subtype, see <see href="https://plaid.com/docs/api/accounts/#StandaloneAccountType-other">Account schemas</see>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OtherAccountSubtype>))]
public sealed record OtherAccountSubtype : StringEnum<OtherAccountSubtype>
{
    private OtherAccountSubtype(string value) : base(value)
    {
    }

    public static readonly OtherAccountSubtype Other = new("other");

    public static readonly OtherAccountSubtype All = new("all");

    public static OtherAccountSubtype FromValue(string value) => FromValueCore(value);
}

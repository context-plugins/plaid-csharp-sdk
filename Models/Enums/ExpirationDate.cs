using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A description of whether the associated document was expired when the verification was performed.
/// <para>
/// Note: In the case where an expiration date is not present on the document or failed to be extracted, this value will be <c>no_data</c>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ExpirationDate>))]
public sealed record ExpirationDate : StringEnum<ExpirationDate>
{
    private ExpirationDate(string value) : base(value)
    {
    }

    public static readonly ExpirationDate NotExpired = new("not_expired");

    public static readonly ExpirationDate Expired = new("expired");

    public static readonly ExpirationDate NoData = new("no_data");

    public static ExpirationDate FromValue(string value) => FromValueCore(value);
}

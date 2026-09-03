using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Documentation not found in the MISMO model viewer and not provided by Freddie Mac.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ServiceProductFulfillmentIdentifier>))]
public sealed record ServiceProductFulfillmentIdentifier : StringEnum<ServiceProductFulfillmentIdentifier>
{
    private ServiceProductFulfillmentIdentifier(string value) : base(value)
    {
    }

    public static readonly ServiceProductFulfillmentIdentifier Voa = new("VOA");

    public static readonly ServiceProductFulfillmentIdentifier Voe = new("VOE");

    public static ServiceProductFulfillmentIdentifier FromValue(string value) => FromValueCore(value);
}

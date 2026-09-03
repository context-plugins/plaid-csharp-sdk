using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Specifies the purpose of the uploaded file.
/// <para>
/// <c>"DUE_DILIGENCE"</c> - The transfer due diligence document of the originator.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Purpose>))]
public sealed record Purpose : StringEnum<Purpose>
{
    private Purpose(string value) : base(value)
    {
    }

    public static readonly Purpose DueDiligence = new("DUE_DILIGENCE");

    public static Purpose FromValue(string value) => FromValueCore(value);
}

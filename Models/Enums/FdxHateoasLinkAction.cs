using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// HTTP Method to use for the request
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FdxHateoasLinkAction>))]
public sealed record FdxHateoasLinkAction : StringEnum<FdxHateoasLinkAction>
{
    private FdxHateoasLinkAction(string value) : base(value)
    {
    }

    public static readonly FdxHateoasLinkAction Get = new("GET");

    public static readonly FdxHateoasLinkAction Post = new("POST");

    public static readonly FdxHateoasLinkAction Patch = new("PATCH");

    public static readonly FdxHateoasLinkAction Delete = new("DELETE");

    public static readonly FdxHateoasLinkAction Put = new("PUT");

    public static FdxHateoasLinkAction FromValue(string value) => FromValueCore(value);
}

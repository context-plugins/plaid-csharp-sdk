using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// An outcome status for this specific selfie. Distinct from the overall <c>selfie_check.status</c> that summarizes the verification outcome from one or more selfies.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SelfieStatus>))]
public sealed record SelfieStatus : StringEnum<SelfieStatus>
{
    private SelfieStatus(string value) : base(value)
    {
    }

    public static readonly SelfieStatus Success = new("success");

    public static readonly SelfieStatus Failed = new("failed");

    public static SelfieStatus FromValue(string value) => FromValueCore(value);
}

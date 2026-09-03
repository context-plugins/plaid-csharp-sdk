using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// This field is deprecated in favor of the <c>breakdown</c> object, which provides more granular institution health data.
/// <para>
/// <c>HEALTHY</c>: the majority of requests are successful
/// <c>DEGRADED</c>: only some requests are successful
/// <c>DOWN</c>: all requests are failing
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status4>))]
public sealed record Status4 : StringEnum<Status4>
{
    private Status4(string value) : base(value)
    {
    }

    public static readonly Status4 Healthy = new("HEALTHY");

    public static readonly Status4 Degraded = new("DEGRADED");

    public static readonly Status4 Down = new("DOWN");

    public static Status4 FromValue(string value) => FromValueCore(value);
}

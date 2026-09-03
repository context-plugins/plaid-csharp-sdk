using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// An enum indicating whether the reported age aligns with the estimated selfie capture age range.
/// <para>
/// <c>match</c> indicates that the reported age falls within the estimated selfie capture age range.
/// </para>
/// <para>
/// <c>warning</c> indicates that the reported age falls outside the estimated selfie capture age range, but is close enough that the result should be reviewed.
/// </para>
/// <para>
/// <c>no_match</c> indicates that the reported age falls far outside the estimated selfie capture age range.
/// </para>
/// <para>
/// <c>no_data</c> indicates that there was not enough data available at age-estimation time to compare the reported age against the estimated selfie capture age range.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SelfieAgeCheckStatus>))]
public sealed record SelfieAgeCheckStatus : StringEnum<SelfieAgeCheckStatus>
{
    private SelfieAgeCheckStatus(string value) : base(value)
    {
    }

    public static readonly SelfieAgeCheckStatus Match = new("match");

    public static readonly SelfieAgeCheckStatus Warning = new("warning");

    public static readonly SelfieAgeCheckStatus NoMatch = new("no_match");

    public static readonly SelfieAgeCheckStatus NoData = new("no_data");

    public static SelfieAgeCheckStatus FromValue(string value) => FromValueCore(value);
}

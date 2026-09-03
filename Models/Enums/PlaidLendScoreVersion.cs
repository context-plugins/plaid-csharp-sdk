using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The version of the LendScore to use. Required if using LendScore.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PlaidLendScoreVersion>))]
public sealed record PlaidLendScoreVersion : StringEnum<PlaidLendScoreVersion>
{
    private PlaidLendScoreVersion(string value) : base(value)
    {
    }

    public static readonly PlaidLendScoreVersion V10 = new("v1.0");

    public static readonly PlaidLendScoreVersion V20 = new("v2.0");

    public static readonly PlaidLendScoreVersion Ls1 = new("LS1");

    public static PlaidLendScoreVersion FromValue(string value) => FromValueCore(value);
}

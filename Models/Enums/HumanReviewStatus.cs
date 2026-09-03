using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The outcome of the human review check, when available. The following values are possible:
/// <para>
///
/// <c>success</c> - The document passed the check.
/// </para>
/// <para>
/// <c>failed</c> - The document failed the check.
/// </para>
/// <para>
/// <c>no_data</c> - The document was submitted, but the document specialist review was not completed in time.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<HumanReviewStatus>))]
public sealed record HumanReviewStatus : StringEnum<HumanReviewStatus>
{
    private HumanReviewStatus(string value) : base(value)
    {
    }

    public static readonly HumanReviewStatus Success = new("success");

    public static readonly HumanReviewStatus Failed = new("failed");

    public static readonly HumanReviewStatus NoData = new("no_data");

    public static HumanReviewStatus FromValue(string value) => FromValueCore(value);
}

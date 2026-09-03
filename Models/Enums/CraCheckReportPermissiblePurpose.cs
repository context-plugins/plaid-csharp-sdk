using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The permissible purpose under the FCRA for retrieving this consumer report. Restricted to permissible purposes related to loan servicing only. Required when <c>report_id</c> is provided.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CraCheckReportPermissiblePurpose>))]
public sealed record CraCheckReportPermissiblePurpose : StringEnum<CraCheckReportPermissiblePurpose>
{
    private CraCheckReportPermissiblePurpose(string value) : base(value)
    {
    }

    public static readonly CraCheckReportPermissiblePurpose AccountReviewCredit = new("ACCOUNT_REVIEW_CREDIT");

    public static readonly CraCheckReportPermissiblePurpose WrittenInstructionOther = new("WRITTEN_INSTRUCTION_OTHER");

    public static CraCheckReportPermissiblePurpose FromValue(string value) => FromValueCore(value);
}

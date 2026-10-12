using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The permissible purpose under the FCRA for retrieving this consumer report. Restricted to permissible purposes related to loan servicing only. Required when <c>report_id</c> is provided.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CraCheckReportPermissiblePurpose>))]
public sealed record CraCheckReportPermissiblePurpose : OpenStringEnum<CraCheckReportPermissiblePurpose>
{
    private CraCheckReportPermissiblePurpose(string value) : base(value)
    {
    }

    public static readonly CraCheckReportPermissiblePurpose AccountReviewCredit = new("ACCOUNT_REVIEW_CREDIT");

    public static readonly CraCheckReportPermissiblePurpose WrittenInstructionOther = new("WRITTEN_INSTRUCTION_OTHER");

    public TResult Match<TResult>(Func<TResult> onAccountReviewCredit,
        Func<TResult> onWrittenInstructionOther,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AccountReviewCredit => onAccountReviewCredit(),
            _ when this == WrittenInstructionOther => onWrittenInstructionOther(),
            _ => otherwise(Value)
        };

    public void Match(Action onAccountReviewCredit, Action onWrittenInstructionOther, Action<string> otherwise)
    {
        if (this == AccountReviewCredit) onAccountReviewCredit();
        else if (this == WrittenInstructionOther) onWrittenInstructionOther();
        else otherwise(Value);
    }
}

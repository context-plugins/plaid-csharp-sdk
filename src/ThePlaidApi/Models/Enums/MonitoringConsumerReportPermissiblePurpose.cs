using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Describes the reason you are generating a Consumer Report for this user.
/// <para>
/// <c>ACCOUNT_REVIEW_CREDIT</c>: In connection with a consumer credit transaction for the review or collection of an account pursuant to FCRA Section 604(a)(3)(A).
/// </para>
/// <para>
/// <c>WRITTEN_INSTRUCTION_OTHER</c>: In accordance with the written instructions of the consumer pursuant to FCRA Section 604(a)(2), such as when an individual agrees to act as a guarantor or assumes personal liability for a consumer, business, or commercial loan.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<MonitoringConsumerReportPermissiblePurpose>))]
public sealed record MonitoringConsumerReportPermissiblePurpose : OpenStringEnum<MonitoringConsumerReportPermissiblePurpose>
{
    private MonitoringConsumerReportPermissiblePurpose(string value) : base(value)
    {
    }

    public static readonly MonitoringConsumerReportPermissiblePurpose AccountReviewCredit = new(
        "ACCOUNT_REVIEW_CREDIT");

    public static readonly MonitoringConsumerReportPermissiblePurpose WrittenInstructionOther = new(
        "WRITTEN_INSTRUCTION_OTHER");

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

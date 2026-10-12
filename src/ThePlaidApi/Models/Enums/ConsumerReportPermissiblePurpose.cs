using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Describes the reason you are generating a Consumer Report for this user. When calling <c>/link/token/create</c>, this field is required when using Plaid Check (CRA) products; invalid if not using Plaid Check (CRA) products.
/// <para>
/// <c>ACCOUNT_REVIEW_CREDIT</c>: In connection with a consumer credit transaction for the review or collection of an account pursuant to FCRA Section 604(a)(3)(A).
/// </para>
/// <para>
/// <c>ACCOUNT_REVIEW_NON_CREDIT</c>: For a legitimate business need of the information to review a non-credit account provided primarily for personal, family, or household purposes to determine whether the consumer continues to meet the terms of the account pursuant to FCRA Section 604(a)(3)(F)(2).
/// </para>
/// <para>
/// <c>EXTENSION_OF_CREDIT</c>: In connection with a credit transaction initiated by and involving the consumer pursuant to FCRA Section 604(a)(3)(A).
/// </para>
/// <para>
/// <c>LEGITIMATE_BUSINESS_NEED_TENANT_SCREENING</c>: For a legitimate business need in connection with a business transaction initiated by the consumer primarily for personal, family, or household purposes in connection with a property rental assessment pursuant to FCRA Section 604(a)(3)(F)(i).
/// </para>
/// <para>
/// <c>LEGITIMATE_BUSINESS_NEED_OTHER</c>: For a legitimate business need in connection with a business transaction made primarily for personal, family, or household initiated by the consumer pursuant to FCRA Section 604(a)(3)(F)(i).
/// </para>
/// <para>
/// <c>WRITTEN_INSTRUCTION_PREQUALIFICATION</c>: In accordance with the written instructions of the consumer pursuant to FCRA Section 604(a)(2), to evaluate an application's profile to make an offer to the consumer.
/// </para>
/// <para>
/// <c>WRITTEN_INSTRUCTION_OTHER</c>: In accordance with the written instructions of the consumer pursuant to FCRA Section 604(a)(2), such as when an individual agrees to act as a guarantor or assumes personal liability for a consumer, business, or commercial loan.
/// </para>
/// <para>
/// <c>ELIGIBILITY_FOR_GOVT_BENEFITS</c>:  In connection with an eligibility determination for a government benefit where the entity is required to consider an applicant's financial status pursuant to FCRA Section 604(a)(3)(D).
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ConsumerReportPermissiblePurpose>))]
public sealed record ConsumerReportPermissiblePurpose : OpenStringEnum<ConsumerReportPermissiblePurpose>
{
    private ConsumerReportPermissiblePurpose(string value) : base(value)
    {
    }

    public static readonly ConsumerReportPermissiblePurpose AccountReviewCredit = new("ACCOUNT_REVIEW_CREDIT");

    public static readonly ConsumerReportPermissiblePurpose AccountReviewNonCredit = new("ACCOUNT_REVIEW_NON_CREDIT");

    public static readonly ConsumerReportPermissiblePurpose ExtensionOfCredit = new("EXTENSION_OF_CREDIT");

    public static readonly ConsumerReportPermissiblePurpose LegitimateBusinessNeedTenantScreening = new(
        "LEGITIMATE_BUSINESS_NEED_TENANT_SCREENING");

    public static readonly ConsumerReportPermissiblePurpose LegitimateBusinessNeedOther = new(
        "LEGITIMATE_BUSINESS_NEED_OTHER");

    public static readonly ConsumerReportPermissiblePurpose WrittenInstructionPrequalification = new(
        "WRITTEN_INSTRUCTION_PREQUALIFICATION");

    public static readonly ConsumerReportPermissiblePurpose WrittenInstructionOther = new("WRITTEN_INSTRUCTION_OTHER");

    public static readonly ConsumerReportPermissiblePurpose EligibilityForGovtBenefits = new(
        "ELIGIBILITY_FOR_GOVT_BENEFITS");

    public TResult Match<TResult>(Func<TResult> onAccountReviewCredit,
        Func<TResult> onAccountReviewNonCredit,
        Func<TResult> onExtensionOfCredit,
        Func<TResult> onLegitimateBusinessNeedTenantScreening,
        Func<TResult> onLegitimateBusinessNeedOther,
        Func<TResult> onWrittenInstructionPrequalification,
        Func<TResult> onWrittenInstructionOther,
        Func<TResult> onEligibilityForGovtBenefits,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AccountReviewCredit => onAccountReviewCredit(),
            _ when this == AccountReviewNonCredit => onAccountReviewNonCredit(),
            _ when this == ExtensionOfCredit => onExtensionOfCredit(),
            _ when this == LegitimateBusinessNeedTenantScreening => onLegitimateBusinessNeedTenantScreening(),
            _ when this == LegitimateBusinessNeedOther => onLegitimateBusinessNeedOther(),
            _ when this == WrittenInstructionPrequalification => onWrittenInstructionPrequalification(),
            _ when this == WrittenInstructionOther => onWrittenInstructionOther(),
            _ when this == EligibilityForGovtBenefits => onEligibilityForGovtBenefits(),
            _ => otherwise(Value)
        };

    public void Match(Action onAccountReviewCredit,
        Action onAccountReviewNonCredit,
        Action onExtensionOfCredit,
        Action onLegitimateBusinessNeedTenantScreening,
        Action onLegitimateBusinessNeedOther,
        Action onWrittenInstructionPrequalification,
        Action onWrittenInstructionOther,
        Action onEligibilityForGovtBenefits,
        Action<string> otherwise)
    {
        if (this == AccountReviewCredit) onAccountReviewCredit();
        else if (this == AccountReviewNonCredit) onAccountReviewNonCredit();
        else if (this == ExtensionOfCredit) onExtensionOfCredit();
        else if (this == LegitimateBusinessNeedTenantScreening) onLegitimateBusinessNeedTenantScreening();
        else if (this == LegitimateBusinessNeedOther) onLegitimateBusinessNeedOther();
        else if (this == WrittenInstructionPrequalification) onWrittenInstructionPrequalification();
        else if (this == WrittenInstructionOther) onWrittenInstructionOther();
        else if (this == EligibilityForGovtBenefits) onEligibilityForGovtBenefits();
        else otherwise(Value);
    }
}

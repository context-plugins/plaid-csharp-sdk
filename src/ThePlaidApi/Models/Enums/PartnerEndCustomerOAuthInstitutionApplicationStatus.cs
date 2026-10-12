using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The registration status for the end customer's application.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PartnerEndCustomerOAuthInstitutionApplicationStatus>))]
public sealed record PartnerEndCustomerOAuthInstitutionApplicationStatus : OpenStringEnum<PartnerEndCustomerOAuthInstitutionApplicationStatus>
{
    private PartnerEndCustomerOAuthInstitutionApplicationStatus(string value) : base(value)
    {
    }

    public static readonly PartnerEndCustomerOAuthInstitutionApplicationStatus NotStarted = new("NOT_STARTED");

    public static readonly PartnerEndCustomerOAuthInstitutionApplicationStatus Processing = new("PROCESSING");

    public static readonly PartnerEndCustomerOAuthInstitutionApplicationStatus Approved = new("APPROVED");

    public static readonly PartnerEndCustomerOAuthInstitutionApplicationStatus Enabled = new("ENABLED");

    public static readonly PartnerEndCustomerOAuthInstitutionApplicationStatus AttentionRequired = new(
        "ATTENTION_REQUIRED");

    public TResult Match<TResult>(Func<TResult> onNotStarted,
        Func<TResult> onProcessing,
        Func<TResult> onApproved,
        Func<TResult> onEnabled,
        Func<TResult> onAttentionRequired,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == NotStarted => onNotStarted(),
            _ when this == Processing => onProcessing(),
            _ when this == Approved => onApproved(),
            _ when this == Enabled => onEnabled(),
            _ when this == AttentionRequired => onAttentionRequired(),
            _ => otherwise(Value)
        };

    public void Match(Action onNotStarted,
        Action onProcessing,
        Action onApproved,
        Action onEnabled,
        Action onAttentionRequired,
        Action<string> otherwise)
    {
        if (this == NotStarted) onNotStarted();
        else if (this == Processing) onProcessing();
        else if (this == Approved) onApproved();
        else if (this == Enabled) onEnabled();
        else if (this == AttentionRequired) onAttentionRequired();
        else otherwise(Value);
    }
}

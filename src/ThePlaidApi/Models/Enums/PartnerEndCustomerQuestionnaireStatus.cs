using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The status of the end customer's security questionnaire.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PartnerEndCustomerQuestionnaireStatus>))]
public sealed record PartnerEndCustomerQuestionnaireStatus : OpenStringEnum<PartnerEndCustomerQuestionnaireStatus>
{
    private PartnerEndCustomerQuestionnaireStatus(string value) : base(value)
    {
    }

    public static readonly PartnerEndCustomerQuestionnaireStatus NotStarted = new("NOT_STARTED");

    public static readonly PartnerEndCustomerQuestionnaireStatus Received = new("RECEIVED");

    public static readonly PartnerEndCustomerQuestionnaireStatus Complete = new("COMPLETE");

    public TResult Match<TResult>(Func<TResult> onNotStarted,
        Func<TResult> onReceived,
        Func<TResult> onComplete,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == NotStarted => onNotStarted(),
            _ when this == Received => onReceived(),
            _ when this == Complete => onComplete(),
            _ => otherwise(Value)
        };

    public void Match(Action onNotStarted, Action onReceived, Action onComplete, Action<string> otherwise)
    {
        if (this == NotStarted) onNotStarted();
        else if (this == Received) onReceived();
        else if (this == Complete) onComplete();
        else otherwise(Value);
    }
}

using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The status of the end customer's security questionnaire.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PartnerEndCustomerQuestionnaireStatus>))]
public sealed record PartnerEndCustomerQuestionnaireStatus : StringEnum<PartnerEndCustomerQuestionnaireStatus>
{
    private PartnerEndCustomerQuestionnaireStatus(string value) : base(value)
    {
    }

    public static readonly PartnerEndCustomerQuestionnaireStatus NotStarted = new("NOT_STARTED");

    public static readonly PartnerEndCustomerQuestionnaireStatus Received = new("RECEIVED");

    public static readonly PartnerEndCustomerQuestionnaireStatus Complete = new("COMPLETE");

    public static PartnerEndCustomerQuestionnaireStatus FromValue(string value) => FromValueCore(value);
}

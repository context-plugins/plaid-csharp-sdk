using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A string representing the event that has just occurred in the Link flow.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LinkEventName>))]
public sealed record LinkEventName : StringEnum<LinkEventName>
{
    private LinkEventName(string value) : base(value)
    {
    }

    public static readonly LinkEventName BankIncomeInsightsCompleted = new("BANK_INCOME_INSIGHTS_COMPLETED");

    public static readonly LinkEventName CloseOauth = new("CLOSE_OAUTH");

    public static readonly LinkEventName Error = new("ERROR");

    public static readonly LinkEventName Exit = new("EXIT");

    public static readonly LinkEventName FailOauth = new("FAIL_OAUTH");

    public static readonly LinkEventName Handoff = new("HANDOFF");

    public static readonly LinkEventName IssueFollowed = new("ISSUE_FOLLOWED");

    public static readonly LinkEventName Open = new("OPEN");

    public static readonly LinkEventName OpenMyPlaid = new("OPEN_MY_PLAID");

    public static readonly LinkEventName OpenOauth = new("OPEN_OAUTH");

    public static readonly LinkEventName SearchInstitution = new("SEARCH_INSTITUTION");

    public static readonly LinkEventName SelectAuthType = new("SELECT_AUTH_TYPE");

    public static readonly LinkEventName SelectBrand = new("SELECT_BRAND");

    public static readonly LinkEventName SelectDegradedInstitution = new("SELECT_DEGRADED_INSTITUTION");

    public static readonly LinkEventName SelectDownInstitution = new("SELECT_DOWN_INSTITUTION");

    public static readonly LinkEventName SelectFilteredInstitution = new("SELECT_FILTERED_INSTITUTION");

    public static readonly LinkEventName SelectInstitution = new("SELECT_INSTITUTION");

    public static readonly LinkEventName SubmitAccountNumber = new("SUBMIT_ACCOUNT_NUMBER");

    public static readonly LinkEventName SubmitCredentials = new("SUBMIT_CREDENTIALS");

    public static readonly LinkEventName SubmitDocuments = new("SUBMIT_DOCUMENTS");

    public static readonly LinkEventName SubmitDocumentsError = new("SUBMIT_DOCUMENTS_ERROR");

    public static readonly LinkEventName SubmitDocumentsSuccess = new("SUBMIT_DOCUMENTS_SUCCESS");

    public static readonly LinkEventName SubmitMfa = new("SUBMIT_MFA");

    public static readonly LinkEventName SubmitRoutingNumber = new("SUBMIT_ROUTING_NUMBER");

    public static readonly LinkEventName TransitionView = new("TRANSITION_VIEW");

    public static readonly LinkEventName ViewDataTypes = new("VIEW_DATA_TYPES");

    public static LinkEventName FromValue(string value) => FromValueCore(value);
}

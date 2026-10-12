using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A string representing the event that has just occurred in the Link flow.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LinkEventName>))]
public sealed record LinkEventName : OpenStringEnum<LinkEventName>
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

    public TResult Match<TResult>(Func<TResult> onBankIncomeInsightsCompleted,
        Func<TResult> onCloseOauth,
        Func<TResult> onError,
        Func<TResult> onExit,
        Func<TResult> onFailOauth,
        Func<TResult> onHandoff,
        Func<TResult> onIssueFollowed,
        Func<TResult> onOpen,
        Func<TResult> onOpenMyPlaid,
        Func<TResult> onOpenOauth,
        Func<TResult> onSearchInstitution,
        Func<TResult> onSelectAuthType,
        Func<TResult> onSelectBrand,
        Func<TResult> onSelectDegradedInstitution,
        Func<TResult> onSelectDownInstitution,
        Func<TResult> onSelectFilteredInstitution,
        Func<TResult> onSelectInstitution,
        Func<TResult> onSubmitAccountNumber,
        Func<TResult> onSubmitCredentials,
        Func<TResult> onSubmitDocuments,
        Func<TResult> onSubmitDocumentsError,
        Func<TResult> onSubmitDocumentsSuccess,
        Func<TResult> onSubmitMfa,
        Func<TResult> onSubmitRoutingNumber,
        Func<TResult> onTransitionView,
        Func<TResult> onViewDataTypes,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == BankIncomeInsightsCompleted => onBankIncomeInsightsCompleted(),
            _ when this == CloseOauth => onCloseOauth(),
            _ when this == Error => onError(),
            _ when this == Exit => onExit(),
            _ when this == FailOauth => onFailOauth(),
            _ when this == Handoff => onHandoff(),
            _ when this == IssueFollowed => onIssueFollowed(),
            _ when this == Open => onOpen(),
            _ when this == OpenMyPlaid => onOpenMyPlaid(),
            _ when this == OpenOauth => onOpenOauth(),
            _ when this == SearchInstitution => onSearchInstitution(),
            _ when this == SelectAuthType => onSelectAuthType(),
            _ when this == SelectBrand => onSelectBrand(),
            _ when this == SelectDegradedInstitution => onSelectDegradedInstitution(),
            _ when this == SelectDownInstitution => onSelectDownInstitution(),
            _ when this == SelectFilteredInstitution => onSelectFilteredInstitution(),
            _ when this == SelectInstitution => onSelectInstitution(),
            _ when this == SubmitAccountNumber => onSubmitAccountNumber(),
            _ when this == SubmitCredentials => onSubmitCredentials(),
            _ when this == SubmitDocuments => onSubmitDocuments(),
            _ when this == SubmitDocumentsError => onSubmitDocumentsError(),
            _ when this == SubmitDocumentsSuccess => onSubmitDocumentsSuccess(),
            _ when this == SubmitMfa => onSubmitMfa(),
            _ when this == SubmitRoutingNumber => onSubmitRoutingNumber(),
            _ when this == TransitionView => onTransitionView(),
            _ when this == ViewDataTypes => onViewDataTypes(),
            _ => otherwise(Value)
        };

    public void Match(Action onBankIncomeInsightsCompleted,
        Action onCloseOauth,
        Action onError,
        Action onExit,
        Action onFailOauth,
        Action onHandoff,
        Action onIssueFollowed,
        Action onOpen,
        Action onOpenMyPlaid,
        Action onOpenOauth,
        Action onSearchInstitution,
        Action onSelectAuthType,
        Action onSelectBrand,
        Action onSelectDegradedInstitution,
        Action onSelectDownInstitution,
        Action onSelectFilteredInstitution,
        Action onSelectInstitution,
        Action onSubmitAccountNumber,
        Action onSubmitCredentials,
        Action onSubmitDocuments,
        Action onSubmitDocumentsError,
        Action onSubmitDocumentsSuccess,
        Action onSubmitMfa,
        Action onSubmitRoutingNumber,
        Action onTransitionView,
        Action onViewDataTypes,
        Action<string> otherwise)
    {
        if (this == BankIncomeInsightsCompleted) onBankIncomeInsightsCompleted();
        else if (this == CloseOauth) onCloseOauth();
        else if (this == Error) onError();
        else if (this == Exit) onExit();
        else if (this == FailOauth) onFailOauth();
        else if (this == Handoff) onHandoff();
        else if (this == IssueFollowed) onIssueFollowed();
        else if (this == Open) onOpen();
        else if (this == OpenMyPlaid) onOpenMyPlaid();
        else if (this == OpenOauth) onOpenOauth();
        else if (this == SearchInstitution) onSearchInstitution();
        else if (this == SelectAuthType) onSelectAuthType();
        else if (this == SelectBrand) onSelectBrand();
        else if (this == SelectDegradedInstitution) onSelectDegradedInstitution();
        else if (this == SelectDownInstitution) onSelectDownInstitution();
        else if (this == SelectFilteredInstitution) onSelectFilteredInstitution();
        else if (this == SelectInstitution) onSelectInstitution();
        else if (this == SubmitAccountNumber) onSubmitAccountNumber();
        else if (this == SubmitCredentials) onSubmitCredentials();
        else if (this == SubmitDocuments) onSubmitDocuments();
        else if (this == SubmitDocumentsError) onSubmitDocumentsError();
        else if (this == SubmitDocumentsSuccess) onSubmitDocumentsSuccess();
        else if (this == SubmitMfa) onSubmitMfa();
        else if (this == SubmitRoutingNumber) onSubmitRoutingNumber();
        else if (this == TransitionView) onTransitionView();
        else if (this == ViewDataTypes) onViewDataTypes();
        else otherwise(Value);
    }
}

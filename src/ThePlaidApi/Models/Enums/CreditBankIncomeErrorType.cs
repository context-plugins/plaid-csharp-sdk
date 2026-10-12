using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A broad categorization of the error. Safe for programmatic use.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CreditBankIncomeErrorType>))]
public sealed record CreditBankIncomeErrorType : OpenStringEnum<CreditBankIncomeErrorType>
{
    private CreditBankIncomeErrorType(string value) : base(value)
    {
    }

    public static readonly CreditBankIncomeErrorType InternalServerError = new("INTERNAL_SERVER_ERROR");

    public static readonly CreditBankIncomeErrorType InsufficientCredentials = new("INSUFFICIENT_CREDENTIALS");

    public static readonly CreditBankIncomeErrorType ItemLocked = new("ITEM_LOCKED");

    public static readonly CreditBankIncomeErrorType UserSetupRequired = new("USER_SETUP_REQUIRED");

    public static readonly CreditBankIncomeErrorType CountryNotSupported = new("COUNTRY_NOT_SUPPORTED");

    public static readonly CreditBankIncomeErrorType InstitutionDown = new("INSTITUTION_DOWN");

    public static readonly CreditBankIncomeErrorType InstitutionNoLongerSupported = new(
        "INSTITUTION_NO_LONGER_SUPPORTED");

    public static readonly CreditBankIncomeErrorType InstitutionNotResponding = new("INSTITUTION_NOT_RESPONDING");

    public static readonly CreditBankIncomeErrorType InvalidCredentials = new("INVALID_CREDENTIALS");

    public static readonly CreditBankIncomeErrorType InvalidMfa = new("INVALID_MFA");

    public static readonly CreditBankIncomeErrorType InvalidSendMethod = new("INVALID_SEND_METHOD");

    public static readonly CreditBankIncomeErrorType ItemLoginRequired = new("ITEM_LOGIN_REQUIRED");

    public static readonly CreditBankIncomeErrorType MfaNotSupported = new("MFA_NOT_SUPPORTED");

    public static readonly CreditBankIncomeErrorType NoAccounts = new("NO_ACCOUNTS");

    public static readonly CreditBankIncomeErrorType ItemNotSupported = new("ITEM_NOT_SUPPORTED");

    public static readonly CreditBankIncomeErrorType AccessNotGranted = new("ACCESS_NOT_GRANTED");

    public TResult Match<TResult>(Func<TResult> onInternalServerError,
        Func<TResult> onInsufficientCredentials,
        Func<TResult> onItemLocked,
        Func<TResult> onUserSetupRequired,
        Func<TResult> onCountryNotSupported,
        Func<TResult> onInstitutionDown,
        Func<TResult> onInstitutionNoLongerSupported,
        Func<TResult> onInstitutionNotResponding,
        Func<TResult> onInvalidCredentials,
        Func<TResult> onInvalidMfa,
        Func<TResult> onInvalidSendMethod,
        Func<TResult> onItemLoginRequired,
        Func<TResult> onMfaNotSupported,
        Func<TResult> onNoAccounts,
        Func<TResult> onItemNotSupported,
        Func<TResult> onAccessNotGranted,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == InternalServerError => onInternalServerError(),
            _ when this == InsufficientCredentials => onInsufficientCredentials(),
            _ when this == ItemLocked => onItemLocked(),
            _ when this == UserSetupRequired => onUserSetupRequired(),
            _ when this == CountryNotSupported => onCountryNotSupported(),
            _ when this == InstitutionDown => onInstitutionDown(),
            _ when this == InstitutionNoLongerSupported => onInstitutionNoLongerSupported(),
            _ when this == InstitutionNotResponding => onInstitutionNotResponding(),
            _ when this == InvalidCredentials => onInvalidCredentials(),
            _ when this == InvalidMfa => onInvalidMfa(),
            _ when this == InvalidSendMethod => onInvalidSendMethod(),
            _ when this == ItemLoginRequired => onItemLoginRequired(),
            _ when this == MfaNotSupported => onMfaNotSupported(),
            _ when this == NoAccounts => onNoAccounts(),
            _ when this == ItemNotSupported => onItemNotSupported(),
            _ when this == AccessNotGranted => onAccessNotGranted(),
            _ => otherwise(Value)
        };

    public void Match(Action onInternalServerError,
        Action onInsufficientCredentials,
        Action onItemLocked,
        Action onUserSetupRequired,
        Action onCountryNotSupported,
        Action onInstitutionDown,
        Action onInstitutionNoLongerSupported,
        Action onInstitutionNotResponding,
        Action onInvalidCredentials,
        Action onInvalidMfa,
        Action onInvalidSendMethod,
        Action onItemLoginRequired,
        Action onMfaNotSupported,
        Action onNoAccounts,
        Action onItemNotSupported,
        Action onAccessNotGranted,
        Action<string> otherwise)
    {
        if (this == InternalServerError) onInternalServerError();
        else if (this == InsufficientCredentials) onInsufficientCredentials();
        else if (this == ItemLocked) onItemLocked();
        else if (this == UserSetupRequired) onUserSetupRequired();
        else if (this == CountryNotSupported) onCountryNotSupported();
        else if (this == InstitutionDown) onInstitutionDown();
        else if (this == InstitutionNoLongerSupported) onInstitutionNoLongerSupported();
        else if (this == InstitutionNotResponding) onInstitutionNotResponding();
        else if (this == InvalidCredentials) onInvalidCredentials();
        else if (this == InvalidMfa) onInvalidMfa();
        else if (this == InvalidSendMethod) onInvalidSendMethod();
        else if (this == ItemLoginRequired) onItemLoginRequired();
        else if (this == MfaNotSupported) onMfaNotSupported();
        else if (this == NoAccounts) onNoAccounts();
        else if (this == ItemNotSupported) onItemNotSupported();
        else if (this == AccessNotGranted) onAccessNotGranted();
        else otherwise(Value);
    }
}

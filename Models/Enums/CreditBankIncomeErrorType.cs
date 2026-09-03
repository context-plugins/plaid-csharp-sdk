using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A broad categorization of the error. Safe for programmatic use.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CreditBankIncomeErrorType>))]
public sealed record CreditBankIncomeErrorType : StringEnum<CreditBankIncomeErrorType>
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

    public static readonly CreditBankIncomeErrorType InstitutionNoLongerSupported = new("INSTITUTION_NO_LONGER_SUPPORTED");

    public static readonly CreditBankIncomeErrorType InstitutionNotResponding = new("INSTITUTION_NOT_RESPONDING");

    public static readonly CreditBankIncomeErrorType InvalidCredentials = new("INVALID_CREDENTIALS");

    public static readonly CreditBankIncomeErrorType InvalidMfa = new("INVALID_MFA");

    public static readonly CreditBankIncomeErrorType InvalidSendMethod = new("INVALID_SEND_METHOD");

    public static readonly CreditBankIncomeErrorType ItemLoginRequired = new("ITEM_LOGIN_REQUIRED");

    public static readonly CreditBankIncomeErrorType MfaNotSupported = new("MFA_NOT_SUPPORTED");

    public static readonly CreditBankIncomeErrorType NoAccounts = new("NO_ACCOUNTS");

    public static readonly CreditBankIncomeErrorType ItemNotSupported = new("ITEM_NOT_SUPPORTED");

    public static readonly CreditBankIncomeErrorType AccessNotGranted = new("ACCESS_NOT_GRANTED");

    public static CreditBankIncomeErrorType FromValue(string value) => FromValueCore(value);
}

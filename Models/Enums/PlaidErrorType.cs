using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A broad categorization of the error. Safe for programmatic use.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PlaidErrorType>))]
public sealed record PlaidErrorType : StringEnum<PlaidErrorType>
{
    private PlaidErrorType(string value) : base(value)
    {
    }

    public static readonly PlaidErrorType InvalidRequest = new("INVALID_REQUEST");

    public static readonly PlaidErrorType InvalidResult = new("INVALID_RESULT");

    public static readonly PlaidErrorType InvalidInput = new("INVALID_INPUT");

    public static readonly PlaidErrorType InstitutionError = new("INSTITUTION_ERROR");

    public static readonly PlaidErrorType RateLimitExceeded = new("RATE_LIMIT_EXCEEDED");

    public static readonly PlaidErrorType ApiError = new("API_ERROR");

    public static readonly PlaidErrorType ItemError = new("ITEM_ERROR");

    public static readonly PlaidErrorType AssetReportError = new("ASSET_REPORT_ERROR");

    public static readonly PlaidErrorType BaseReportError = new("BASE_REPORT_ERROR");

    public static readonly PlaidErrorType RecaptchaError = new("RECAPTCHA_ERROR");

    public static readonly PlaidErrorType OauthError = new("OAUTH_ERROR");

    public static readonly PlaidErrorType PaymentError = new("PAYMENT_ERROR");

    public static readonly PlaidErrorType BankTransferError = new("BANK_TRANSFER_ERROR");

    public static readonly PlaidErrorType IncomeVerificationError = new("INCOME_VERIFICATION_ERROR");

    public static readonly PlaidErrorType MicrodepositsError = new("MICRODEPOSITS_ERROR");

    public static readonly PlaidErrorType SandboxError = new("SANDBOX_ERROR");

    public static readonly PlaidErrorType PartnerError = new("PARTNER_ERROR");

    public static readonly PlaidErrorType SignalError = new("SIGNAL_ERROR");

    public static readonly PlaidErrorType TransactionsError = new("TRANSACTIONS_ERROR");

    public static readonly PlaidErrorType TransactionError = new("TRANSACTION_ERROR");

    public static readonly PlaidErrorType TransferError = new("TRANSFER_ERROR");

    public static readonly PlaidErrorType CheckReportError = new("CHECK_REPORT_ERROR");

    public static readonly PlaidErrorType ConsumerReportError = new("CONSUMER_REPORT_ERROR");

    public static readonly PlaidErrorType UserError = new("USER_ERROR");

    public static readonly PlaidErrorType IdempotencyError = new("IDEMPOTENCY_ERROR");

    public static readonly PlaidErrorType AssetsError = new("ASSETS_ERROR");

    public static readonly PlaidErrorType CraMonitoringError = new("CRA_MONITORING_ERROR");

    public static readonly PlaidErrorType CreditProfileReportError = new("CREDIT_PROFILE_REPORT_ERROR");

    public static readonly PlaidErrorType EncompassError = new("ENCOMPASS_ERROR");

    public static readonly PlaidErrorType EnrichError = new("ENRICH_ERROR");

    public static readonly PlaidErrorType FraudInsightsError = new("FRAUD_INSIGHTS_ERROR");

    public static readonly PlaidErrorType FreddieMacError = new("FREDDIE_MAC_ERROR");

    public static readonly PlaidErrorType LinkDeliveryError = new("LINK_DELIVERY_ERROR");

    public static readonly PlaidErrorType ProfileError = new("PROFILE_ERROR");

    public static readonly PlaidErrorType RecurringTransactionsError = new("RECURRING_TRANSACTIONS_ERROR");

    public static readonly PlaidErrorType StatementsError = new("STATEMENTS_ERROR");

    public static readonly PlaidErrorType TransferRecurringError = new("TRANSFER_RECURRING_ERROR");

    public static readonly PlaidErrorType TransferRefundError = new("TRANSFER_REFUND_ERROR");

    public static PlaidErrorType FromValue(string value) => FromValueCore(value);
}

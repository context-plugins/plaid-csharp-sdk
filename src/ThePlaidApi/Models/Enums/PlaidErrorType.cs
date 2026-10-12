using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A broad categorization of the error. Safe for programmatic use.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PlaidErrorType>))]
public sealed record PlaidErrorType : OpenStringEnum<PlaidErrorType>
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

    public TResult Match<TResult>(Func<TResult> onInvalidRequest,
        Func<TResult> onInvalidResult,
        Func<TResult> onInvalidInput,
        Func<TResult> onInstitutionError,
        Func<TResult> onRateLimitExceeded,
        Func<TResult> onApiError,
        Func<TResult> onItemError,
        Func<TResult> onAssetReportError,
        Func<TResult> onBaseReportError,
        Func<TResult> onRecaptchaError,
        Func<TResult> onOauthError,
        Func<TResult> onPaymentError,
        Func<TResult> onBankTransferError,
        Func<TResult> onIncomeVerificationError,
        Func<TResult> onMicrodepositsError,
        Func<TResult> onSandboxError,
        Func<TResult> onPartnerError,
        Func<TResult> onSignalError,
        Func<TResult> onTransactionsError,
        Func<TResult> onTransactionError,
        Func<TResult> onTransferError,
        Func<TResult> onCheckReportError,
        Func<TResult> onConsumerReportError,
        Func<TResult> onUserError,
        Func<TResult> onIdempotencyError,
        Func<TResult> onAssetsError,
        Func<TResult> onCraMonitoringError,
        Func<TResult> onCreditProfileReportError,
        Func<TResult> onEncompassError,
        Func<TResult> onEnrichError,
        Func<TResult> onFraudInsightsError,
        Func<TResult> onFreddieMacError,
        Func<TResult> onLinkDeliveryError,
        Func<TResult> onProfileError,
        Func<TResult> onRecurringTransactionsError,
        Func<TResult> onStatementsError,
        Func<TResult> onTransferRecurringError,
        Func<TResult> onTransferRefundError,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == InvalidRequest => onInvalidRequest(),
            _ when this == InvalidResult => onInvalidResult(),
            _ when this == InvalidInput => onInvalidInput(),
            _ when this == InstitutionError => onInstitutionError(),
            _ when this == RateLimitExceeded => onRateLimitExceeded(),
            _ when this == ApiError => onApiError(),
            _ when this == ItemError => onItemError(),
            _ when this == AssetReportError => onAssetReportError(),
            _ when this == BaseReportError => onBaseReportError(),
            _ when this == RecaptchaError => onRecaptchaError(),
            _ when this == OauthError => onOauthError(),
            _ when this == PaymentError => onPaymentError(),
            _ when this == BankTransferError => onBankTransferError(),
            _ when this == IncomeVerificationError => onIncomeVerificationError(),
            _ when this == MicrodepositsError => onMicrodepositsError(),
            _ when this == SandboxError => onSandboxError(),
            _ when this == PartnerError => onPartnerError(),
            _ when this == SignalError => onSignalError(),
            _ when this == TransactionsError => onTransactionsError(),
            _ when this == TransactionError => onTransactionError(),
            _ when this == TransferError => onTransferError(),
            _ when this == CheckReportError => onCheckReportError(),
            _ when this == ConsumerReportError => onConsumerReportError(),
            _ when this == UserError => onUserError(),
            _ when this == IdempotencyError => onIdempotencyError(),
            _ when this == AssetsError => onAssetsError(),
            _ when this == CraMonitoringError => onCraMonitoringError(),
            _ when this == CreditProfileReportError => onCreditProfileReportError(),
            _ when this == EncompassError => onEncompassError(),
            _ when this == EnrichError => onEnrichError(),
            _ when this == FraudInsightsError => onFraudInsightsError(),
            _ when this == FreddieMacError => onFreddieMacError(),
            _ when this == LinkDeliveryError => onLinkDeliveryError(),
            _ when this == ProfileError => onProfileError(),
            _ when this == RecurringTransactionsError => onRecurringTransactionsError(),
            _ when this == StatementsError => onStatementsError(),
            _ when this == TransferRecurringError => onTransferRecurringError(),
            _ when this == TransferRefundError => onTransferRefundError(),
            _ => otherwise(Value)
        };

    public void Match(Action onInvalidRequest,
        Action onInvalidResult,
        Action onInvalidInput,
        Action onInstitutionError,
        Action onRateLimitExceeded,
        Action onApiError,
        Action onItemError,
        Action onAssetReportError,
        Action onBaseReportError,
        Action onRecaptchaError,
        Action onOauthError,
        Action onPaymentError,
        Action onBankTransferError,
        Action onIncomeVerificationError,
        Action onMicrodepositsError,
        Action onSandboxError,
        Action onPartnerError,
        Action onSignalError,
        Action onTransactionsError,
        Action onTransactionError,
        Action onTransferError,
        Action onCheckReportError,
        Action onConsumerReportError,
        Action onUserError,
        Action onIdempotencyError,
        Action onAssetsError,
        Action onCraMonitoringError,
        Action onCreditProfileReportError,
        Action onEncompassError,
        Action onEnrichError,
        Action onFraudInsightsError,
        Action onFreddieMacError,
        Action onLinkDeliveryError,
        Action onProfileError,
        Action onRecurringTransactionsError,
        Action onStatementsError,
        Action onTransferRecurringError,
        Action onTransferRefundError,
        Action<string> otherwise)
    {
        if (this == InvalidRequest) onInvalidRequest();
        else if (this == InvalidResult) onInvalidResult();
        else if (this == InvalidInput) onInvalidInput();
        else if (this == InstitutionError) onInstitutionError();
        else if (this == RateLimitExceeded) onRateLimitExceeded();
        else if (this == ApiError) onApiError();
        else if (this == ItemError) onItemError();
        else if (this == AssetReportError) onAssetReportError();
        else if (this == BaseReportError) onBaseReportError();
        else if (this == RecaptchaError) onRecaptchaError();
        else if (this == OauthError) onOauthError();
        else if (this == PaymentError) onPaymentError();
        else if (this == BankTransferError) onBankTransferError();
        else if (this == IncomeVerificationError) onIncomeVerificationError();
        else if (this == MicrodepositsError) onMicrodepositsError();
        else if (this == SandboxError) onSandboxError();
        else if (this == PartnerError) onPartnerError();
        else if (this == SignalError) onSignalError();
        else if (this == TransactionsError) onTransactionsError();
        else if (this == TransactionError) onTransactionError();
        else if (this == TransferError) onTransferError();
        else if (this == CheckReportError) onCheckReportError();
        else if (this == ConsumerReportError) onConsumerReportError();
        else if (this == UserError) onUserError();
        else if (this == IdempotencyError) onIdempotencyError();
        else if (this == AssetsError) onAssetsError();
        else if (this == CraMonitoringError) onCraMonitoringError();
        else if (this == CreditProfileReportError) onCreditProfileReportError();
        else if (this == EncompassError) onEncompassError();
        else if (this == EnrichError) onEnrichError();
        else if (this == FraudInsightsError) onFraudInsightsError();
        else if (this == FreddieMacError) onFreddieMacError();
        else if (this == LinkDeliveryError) onLinkDeliveryError();
        else if (this == ProfileError) onProfileError();
        else if (this == RecurringTransactionsError) onRecurringTransactionsError();
        else if (this == StatementsError) onStatementsError();
        else if (this == TransferRecurringError) onTransferRecurringError();
        else if (this == TransferRefundError) onTransferRefundError();
        else otherwise(Value);
    }
}

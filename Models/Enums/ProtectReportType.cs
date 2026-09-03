using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The type of incident being reported.
/// <para>
/// <c>USER_ACCOUNT_TAKEOVER</c> - Indicates that a legitimate user's account was accessed or controlled by an unauthorized party.
/// </para>
/// <para>
/// <c>FALSE_IDENTITY</c> - Indicates that a user created an account using stolen or fabricated identity information.
/// </para>
/// <para>
/// <c>STOLEN_IDENTITY</c> - Indicates that a user created an account using identity information belonging to a real individual without their consent.
/// </para>
/// <para>
/// <c>SYNTHETIC_IDENTITY</c> - Indicates that a user created an account using a fake or partially fabricated identity (e.g., combining real and fake information to form a new persona).
/// </para>
/// <para>
/// <c>MULTIPLE_USER_ACCOUNTS</c> - Indicates that the same individual is operating multiple accounts in violation of policy.
/// </para>
/// <para>
/// <c>SCAM_VICTIM</c> - Indicates that the user was tricked into authorizing or sending funds as part of a scam.
/// </para>
/// <para>
/// <c>BANK_ACCOUNT_TAKEOVER</c> - Indicates that a user's linked bank account was accessed or misused by an unauthorized party.
/// </para>
/// <para>
/// <c>BANK_CONNECTION_REVOKED</c> - Indicates that a linked bank account connection was revoked by the financial institution, often due to suspected misuse, fraud, or security concerns.
/// </para>
/// <para>
/// <c>CARD_TESTING</c> - Indicates that a card was used in small or repeated transactions to test its validity.
/// </para>
/// <para>
/// <c>UNAUTHORIZED_TRANSACTION</c> - Indicates that a transaction was made without the user's consent or authorization.
/// </para>
/// <para>
/// <c>CARD_CHARGEBACK</c> - Indicates that a card transaction was reversed via a chargeback claim.
/// </para>
/// <para>
/// <c>ACH_RETURN</c> - Indicates that an ACH transaction was returned or reversed by the bank.
/// </para>
/// <para>
/// <c>DISPUTE</c> - Indicates that a user filed a dispute regarding a transaction or account activity.
/// </para>
/// <para>
/// <c>FIRST_PARTY_FRAUD</c> - Indicates that a user intentionally misrepresented themselves or their actions for financial gain.
/// </para>
/// <para>
/// <c>MISSED_PAYMENT</c> - Indicates that a user failed to make a required payment on time.
/// </para>
/// <para>
/// <c>LOAN_STACKING</c> - Indicates that a user applied for or took out multiple loans simultaneously beyond their ability to repay.
/// </para>
/// <para>
/// <c>MONEY_LAUNDERING</c> - Indicates that funds are being moved through accounts to obscure their illicit origin.
/// </para>
/// <para>
/// <c>NO_FRAUD</c> - Indicates that an investigation determined no fraudulent activity occurred on user/event (positive label).
/// </para>
/// <para>
/// <c>OTHER</c> - Indicates that the case involves fraud or financial risk not covered by other report types. Requires notes describing the report.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ProtectReportType>))]
public sealed record ProtectReportType : StringEnum<ProtectReportType>
{
    private ProtectReportType(string value) : base(value)
    {
    }

    public static readonly ProtectReportType UserAccountTakeover = new("USER_ACCOUNT_TAKEOVER");

    public static readonly ProtectReportType FalseIdentity = new("FALSE_IDENTITY");

    public static readonly ProtectReportType StolenIdentity = new("STOLEN_IDENTITY");

    public static readonly ProtectReportType SyntheticIdentity = new("SYNTHETIC_IDENTITY");

    public static readonly ProtectReportType MultipleUserAccounts = new("MULTIPLE_USER_ACCOUNTS");

    public static readonly ProtectReportType ScamVictim = new("SCAM_VICTIM");

    public static readonly ProtectReportType BankAccountTakeover = new("BANK_ACCOUNT_TAKEOVER");

    public static readonly ProtectReportType BankConnectionRevoked = new("BANK_CONNECTION_REVOKED");

    public static readonly ProtectReportType CardTesting = new("CARD_TESTING");

    public static readonly ProtectReportType UnauthorizedTransaction = new("UNAUTHORIZED_TRANSACTION");

    public static readonly ProtectReportType CardChargeback = new("CARD_CHARGEBACK");

    public static readonly ProtectReportType AchReturn = new("ACH_RETURN");

    public static readonly ProtectReportType Dispute = new("DISPUTE");

    public static readonly ProtectReportType FirstPartyFraud = new("FIRST_PARTY_FRAUD");

    public static readonly ProtectReportType MissedPayment = new("MISSED_PAYMENT");

    public static readonly ProtectReportType LoanStacking = new("LOAN_STACKING");

    public static readonly ProtectReportType MoneyLaundering = new("MONEY_LAUNDERING");

    public static readonly ProtectReportType NoFraud = new("NO_FRAUD");

    public static readonly ProtectReportType Other = new("OTHER");

    public static ProtectReportType FromValue(string value) => FromValueCore(value);
}

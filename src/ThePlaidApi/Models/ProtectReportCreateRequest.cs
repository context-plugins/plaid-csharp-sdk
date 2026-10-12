using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Request object for <c>/protect/report/create</c>.
/// You must provide either <c>user_id</c>, or an <c>incident_event</c> with at least one supported identifier: <c>link_session_id</c>, <c>idv_session_id</c>, <c>protect_event_id</c>, <c>signal_client_transaction_id</c>, or <c>access_token</c>. Context fields such as <c>internal_reference</c>, <c>time</c>, <c>amount</c>, and <c>bank_account</c> do not satisfy this identifier requirement.
/// </summary>
public record ProtectReportCreateRequest
{
    /// <summary>
    /// Your Plaid API <c>client_id</c>. The <c>client_id</c> is required and may be provided either in the <c>PLAID-CLIENT-ID</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_id")]
    public string? ClientId { get; init; }

    /// <summary>
    /// Your Plaid API <c>secret</c>. The <c>secret</c> is required and may be provided either in the <c>PLAID-SECRET</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secret")]
    public string? Secret { get; init; }

    /// <summary>
    /// The Plaid User ID associated with the report.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user_id")]
    public string? UserId { get; init; }

    /// <summary>
    /// Details about the incident event.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("incident_event")]
    public ProtectIncidentEvent? IncidentEvent { get; init; }

    /// <summary>
    /// The confidence level of the incident report.
    /// <c>CONFIRMED</c> indicates the incident has been verified and definitively occurred.
    /// <para>
    /// <c>SUSPECTED</c> indicates the incident is believed to have occurred but has not been fully verified.
    /// </para>
    /// </summary>
    [JsonPropertyName("report_confidence")]
    public required ProtectReportConfidence ReportConfidence { get; init; }

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
    [JsonPropertyName("report_type")]
    public required ProtectReportType ReportType { get; init; }

    /// <summary>
    /// The source that identified or reported the incident.
    /// <para>
    /// <c>INTERNAL_REVIEW</c> - Incident was identified through internal fraud investigations or review processes.
    /// </para>
    /// <para>
    /// <c>USER_SELF_REPORTED</c> - Incident was reported directly by the affected user.
    /// </para>
    /// <para>
    /// <c>BANK_FEEDBACK</c> - Incident was identified through bank feedback, including ACH returns and connection revocations.
    /// </para>
    /// <para>
    /// <c>NETWORK_FEEDBACK</c> - Incident was identified through card network alerts or chargebacks.
    /// </para>
    /// <para>
    /// <c>AUTOMATED_SYSTEM</c> - Incident was detected by automated systems such as fraud models or rule engines.
    /// </para>
    /// <para>
    /// <c>THIRD_PARTY_ALERT</c> - Incident was identified through external vendor or consortium alerts.
    /// </para>
    /// <para>
    /// <c>OTHER</c> - Incident was identified through a source not covered by other categories.
    /// </para>
    /// </summary>
    [JsonPropertyName("report_source")]
    public required ProtectReportSource ReportSource { get; init; }

    /// <summary>
    /// Bank account information associated with the incident.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bank_account")]
    public ProtectBankAccount? BankAccount { get; init; }

    /// <summary>
    /// Must be a valid ACH return code (e.g. <c>R01</c>), required if <c>report_type</c> is <c>ACH_RETURN</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ach_return_code")]
    public string? AchReturnCode { get; init; }

    /// <summary>
    /// Additional context or details about the report, required if <c>report_type</c> is <c>OTHER</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("notes")]
    public string? Notes { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

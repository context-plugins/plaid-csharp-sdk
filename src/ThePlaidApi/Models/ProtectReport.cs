using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// A Protect report associated with a user. Contains details about documented incidents, which may include fraud, investigation outcomes, or other risk events.
/// </summary>
public record ProtectReport
{
    /// <summary>
    /// A unique identifier representing the submitted report.
    /// </summary>
    [JsonPropertyName("report_id")]
    public required string ReportId { get; init; }

    /// <summary>
    /// Details about the incident event.
    /// </summary>
    [JsonPropertyName("incident_event")]
    public required ProtectIncidentEventResponse? IncidentEvent { get; init; }

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
    [JsonPropertyName("bank_account")]
    public required ProtectBankAccount? BankAccount { get; init; }

    /// <summary>
    /// ACH return code if the report type is <c>ACH_RETURN</c> (e.g. <c>R01</c>).
    /// </summary>
    [JsonPropertyName("ach_return_code")]
    public required string? AchReturnCode { get; init; }

    /// <summary>
    /// Additional context or details about the report.
    /// </summary>
    [JsonPropertyName("notes")]
    public required string? Notes { get; init; }

    /// <summary>
    /// The timestamp when the report was created, in ISO 8601 format (e.g., '2020-07-24T03:26:02Z').
    /// </summary>
    [JsonPropertyName("created_at")]
    public required DateTimeOffset CreatedAt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

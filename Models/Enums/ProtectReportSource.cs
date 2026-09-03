using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

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
[JsonConverter(typeof(StringEnumConverter<ProtectReportSource>))]
public sealed record ProtectReportSource : StringEnum<ProtectReportSource>
{
    private ProtectReportSource(string value) : base(value)
    {
    }

    public static readonly ProtectReportSource InternalReview = new("INTERNAL_REVIEW");

    public static readonly ProtectReportSource UserSelfReported = new("USER_SELF_REPORTED");

    public static readonly ProtectReportSource BankFeedback = new("BANK_FEEDBACK");

    public static readonly ProtectReportSource NetworkFeedback = new("NETWORK_FEEDBACK");

    public static readonly ProtectReportSource AutomatedSystem = new("AUTOMATED_SYSTEM");

    public static readonly ProtectReportSource ThirdPartyAlert = new("THIRD_PARTY_ALERT");

    public static readonly ProtectReportSource Other = new("OTHER");

    public static ProtectReportSource FromValue(string value) => FromValueCore(value);
}

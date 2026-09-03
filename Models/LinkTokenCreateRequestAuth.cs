using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Specifies options for initializing Link for use with the Auth product. This field can be used to enable or disable extended Auth flows for the resulting Link session. Omitting any field will result in a default that can be configured by your account manager. The default behavior described in the documentation is the default behavior that will apply if you have not requested your account manager to apply a different default. If you have enabled the <see href="https://dashboard.plaid.com/account-verification">Dashboard Account Verification pane</see>, the settings enabled there will override any settings in this object.
/// </summary>
public record LinkTokenCreateRequestAuth
{
    /// <summary>
    /// Specifies whether Auth Type Select is enabled for the Link session, allowing the end user to choose between linking via a credentials-based flow (i.e. Instant Auth, Instant Match, Automated Micro-deposits) or a manual flow that does not require login (all other Auth flows) prior to selecting their financial institution. Default behavior is <c>false</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("auth_type_select_enabled")]
    public bool? AuthTypeSelectEnabled { get; init; }

    /// <summary>
    /// Specifies whether the Link session is enabled for the Automated Micro-deposits flow. Default behavior is <c>false</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("automated_microdeposits_enabled")]
    public bool? AutomatedMicrodepositsEnabled { get; init; }

    /// <summary>
    /// Specifies whether the Link session is enabled for the Instant Match flow. Instant Match is enabled by default. Instant Match can be disabled by setting this field to <c>false</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("instant_match_enabled")]
    public bool? InstantMatchEnabled { get; init; }

    /// <summary>
    /// Specifies whether the Link session is enabled for the Same-Day Micro-deposits flow.  Default behavior is <c>false</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("same_day_microdeposits_enabled")]
    public bool? SameDayMicrodepositsEnabled { get; init; }

    /// <summary>
    /// Specifies whether the Link session is enabled for the Instant Micro-deposits flow.  Default behavior for Plaid teams created after November 2023 is <c>false</c>; default behavior for Plaid teams created before that date is <c>true</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("instant_microdeposits_enabled")]
    public bool? InstantMicrodepositsEnabled { get; init; }

    /// <summary>
    /// Specifies what type of <see href="https://plaid.com/docs/auth/coverage/flow-options/#removing-manual-verification-entry-points-with-reroute-to-credentials">Reroute to Credentials</see> pane should be used in the Link session for the Same-Day Micro-deposits flow. Default behavior is <c>OPTIONAL</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reroute_to_credentials")]
    public RerouteToCredentials? RerouteToCredentials { get; init; }

    /// <summary>
    /// Database Match has been deprecated and replaced with Database Auth. Use the <see href="https://dashboard.plaid.com/account-verification">Account Verification Dashboard</see> to enable Database Auth.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("database_match_enabled")]
    public bool? DatabaseMatchEnabled { get; init; }

    /// <summary>
    /// Database Insights has been deprecated and replaced with Database Auth. Use the <see href="https://dashboard.plaid.com/account-verification">Account Verification Dashboard</see> to enable Database Auth. In Canada, Database Auth is in early availability and cannot yet be managed via the Dashboard; it must be enabled by passing <c>database_insights_enabled: true</c> in <c>/link/token/create</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("database_insights_enabled")]
    public bool? DatabaseInsightsEnabled { get; init; }

    /// <summary>
    /// This field has been deprecated in favor of <c>auth_type_select_enabled</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("flow_type")]
    public FlowType? FlowType { get; init; }

    /// <summary>
    /// Specifies whether the Link session is enabled for SMS micro-deposits verification. Default behavior is <c>true</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sms_microdeposits_verification_enabled")]
    public bool? SmsMicrodepositsVerificationEnabled { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

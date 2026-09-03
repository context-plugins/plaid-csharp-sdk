using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Custom test accounts are configured with a JSON configuration object formulated according to the schema below. All top level fields are optional. Sending an empty object as a configuration will result in an account configured with random balances and transaction history.
/// </summary>
public record UserCustomPassword
{
    /// <summary>
    /// The version of the password schema to use, possible values are 1 or 2. The default value is 2. You should only specify 1 if you know it is necessary for your test suite.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    public string? Version { get; init; }

    /// <summary>
    /// A seed, in the form of a string, that will be used to randomly generate account and transaction data, if this data is not specified using the <c>override_accounts</c> argument. If no seed is specified, the randomly generated data will be different each time.
    /// <para>
    /// Note that transactions data is generated relative to the Item's creation date. Different Items created on different dates with the same seed for transactions data will have different dates for the transactions. The number of days between each transaction and the Item creation will remain constant. For example, an Item created on December 15 might show a transaction on December 14. An Item created on December 20, using the same seed, would show that same transaction occurring on December 19.
    /// </para>
    /// </summary>
    [JsonPropertyName("seed")]
    public required string Seed { get; init; }

    /// <summary>
    /// An array of account overrides to configure the accounts for the Item. By default, if no override is specified, transactions and account data will be randomly generated based on the account type and subtype, and other products will have fixed or empty data.
    /// </summary>
    [JsonPropertyName("override_accounts")]
    public required IReadOnlyList<OverrideAccounts> OverrideAccounts { get; init; }

    /// <summary>
    /// Specifies the multi-factor authentication settings to use with this test account
    /// </summary>
    [JsonPropertyName("mfa")]
    public required Mfa Mfa { get; init; }

    /// <summary>
    /// You may trigger a reCAPTCHA in Plaid Link in the Sandbox environment by using the recaptcha field. Possible values are <c>good</c> or <c>bad</c>. A value of <c>good</c> will result in successful Item creation and <c>bad</c> will result in a <c>RECAPTCHA_BAD</c> error to simulate a failed reCAPTCHA. Both values require the reCAPTCHA to be manually solved within Plaid Link.
    /// </summary>
    [JsonPropertyName("recaptcha")]
    public required string Recaptcha { get; init; }

    /// <summary>
    /// An error code to force on Item creation. Possible values are:
    /// <para>
    /// <c>"INSTITUTION_NOT_RESPONDING"</c>
    /// <c>"INSTITUTION_NO_LONGER_SUPPORTED"</c>
    /// <c>"INVALID_CREDENTIALS"</c>
    /// <c>"INVALID_MFA"</c>
    /// <c>"ITEM_LOCKED"</c>
    /// <c>"ITEM_LOGIN_REQUIRED"</c>
    /// <c>"ITEM_NOT_SUPPORTED"</c>
    /// <c>"INVALID_LINK_TOKEN"</c>
    /// <c>"MFA_NOT_SUPPORTED"</c>
    /// <c>"NO_ACCOUNTS"</c>
    /// <c>"PLAID_ERROR"</c>
    /// <c>"USER_INPUT_TIMEOUT"</c>
    /// <c>"USER_SETUP_REQUIRED"</c>
    /// </para>
    /// </summary>
    [JsonPropertyName("force_error")]
    public required string ForceError { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

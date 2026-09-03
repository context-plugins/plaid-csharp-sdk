using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// This field is only used by integrations created before December 10, 2025. All other integrations must use the <c>identity</c> object instead. For more details, see <see href="https://plaid.com/docs/api/users/user-apis">New User APIs</see>.
/// To create a Plaid Check Consumer Report for a user when using a <c>user_token</c>, this field must be present. If this field is not provided during user token creation, you can add it to the user later by calling <c>/user/update</c>. Once the field has been added to the user, you will be able to call <c>/link/token/create</c> with a non-empty <c>consumer_report_permissible_purpose</c> (which will automatically create a Plaid Check Consumer Report), or call <c>/cra/check_report/create</c> for that user.
/// </summary>
public record ConsumerReportUserIdentity
{
    /// <summary>
    /// The user's first name
    /// </summary>
    [JsonPropertyName("first_name")]
    public required string FirstName { get; init; }

    /// <summary>
    /// The user's last name
    /// </summary>
    [JsonPropertyName("last_name")]
    public required string LastName { get; init; }

    /// <summary>
    /// The user's phone number, in E.164 format: +{countrycode}{number}. For example: "+14157452130". Phone numbers provided in other formats will be parsed on a best-effort basis. Phone number input is validated against valid number ranges; number strings that do not match a real-world phone numbering scheme may cause the request to fail, even in the Sandbox test environment.
    /// </summary>
    [JsonPropertyName("phone_numbers")]
    public required IReadOnlyList<string> PhoneNumbers { get; init; }

    /// <summary>
    /// The user's emails
    /// </summary>
    [JsonPropertyName("emails")]
    public required IReadOnlyList<string> Emails { get; init; }

    /// <summary>
    /// The user's full Social Security number. This field should only be provided by lenders intending to share the resulting consumer report with a Government-Sponsored Enterprise (GSE), such as Fannie Mae or Freddie Mac.
    /// <para>
    /// Format: "ddd-dd-dddd"
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ssn_full")]
    public string? SsnFull { get; init; }

    /// <summary>
    /// The last 4 digits of the user's Social Security number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ssn_last_4")]
    [StringLength(4, MinimumLength = 4)]
    public string? SsnLast4 { get; init; }

    /// <summary>
    /// To be provided in the format "yyyy-mm-dd".
    /// This field is required for all Plaid Check customers.
    /// </summary>
    [JsonPropertyName("date_of_birth")]
    public required DateTimeOffset? DateOfBirth { get; init; }

    /// <summary>
    /// Data about the components comprising an address.
    /// </summary>
    [JsonPropertyName("primary_address")]
    public required AddressData PrimaryAddress { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

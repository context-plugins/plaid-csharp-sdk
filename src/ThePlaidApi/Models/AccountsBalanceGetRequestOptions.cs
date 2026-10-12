using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Optional parameters to <c>/accounts/balance/get</c>.
/// </summary>
public record AccountsBalanceGetRequestOptions
{
    /// <summary>
    /// A list of <c>account_ids</c> to retrieve for the Item. The default value is <c>null</c>.
    /// <para>
    /// Note: An error will be returned if a provided <c>account_id</c> is not associated with the Item.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account_ids")]
    public IReadOnlyList<string>? AccountIds { get; init; }

    /// <summary>
    /// Timestamp in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format (<c>YYYY-MM-DDTHH:mm:ssZ</c>) indicating the oldest acceptable balance when making a request to <c>/accounts/balance/get</c>.
    /// <para>
    /// This field is only necessary when the institution is <c>ins_128026</c> (Capital One), *and* one or more account types being requested is a non-depository account (such as a credit card) as Capital One does not provide real-time balance for non-depository accounts. In this case, a value must be provided or an <c>INVALID_REQUEST</c> error with the code of <c>INVALID_FIELD</c> will be returned. For all other institutions, as well as for depository accounts at Capital One (including all checking and savings accounts) this field is ignored and real-time balance information will be fetched.
    /// </para>
    /// <para>
    /// If this field is not ignored, and no acceptable balance is available, an <c>INVALID_RESULT</c> error with the code <c>LAST_UPDATED_DATETIME_OUT_OF_RANGE</c> will be returned.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("min_last_updated_datetime")]
    public DateTimeOffset? MinLastUpdatedDatetime { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

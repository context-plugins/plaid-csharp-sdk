using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Specifies the originator's expected usage of debits. For all dollar amounts, use a decimal string with two digits of precision e.g. "10.00". This field is required if the originator is expected to process debit transfers.
/// </summary>
public record TransferDebitUsageConfiguration
{
    /// <summary>
    /// The originator's expected transfer frequency.
    /// </summary>
    [JsonPropertyName("expected_frequency")]
    public required OriginatorExpectedTransferFrequency ExpectedFrequency { get; init; }

    /// <summary>
    /// The originator's expected highest amount for a single debit transfer.
    /// </summary>
    [JsonPropertyName("expected_highest_amount")]
    public required string ExpectedHighestAmount { get; init; }

    /// <summary>
    /// The originator's expected average amount per debit.
    /// </summary>
    [JsonPropertyName("expected_average_amount")]
    public required string ExpectedAverageAmount { get; init; }

    /// <summary>
    /// The originator's monthly expected ACH debit processing amount for the next 6-12 months.
    /// </summary>
    [JsonPropertyName("expected_monthly_amount")]
    public required string ExpectedMonthlyAmount { get; init; }

    /// <summary>
    /// Specifies the expected use cases for the originator's debit transfers. This should be a list that contains one or more of the following codes:
    /// <para>
    /// <c>"ccd"</c> - Corporate Credit or Debit - fund transfer between two corporate bank accounts
    /// </para>
    /// <para>
    /// <c>"ppd"</c> - Prearranged Payment or Deposit - The transfer is part of a pre-existing relationship with a consumer. Authorization was obtained in writing either in person or via an electronic document signing, e.g. Docusign, by the consumer. Can be used for credits or debits.
    /// </para>
    /// <para>
    /// <c>"web"</c> - Internet-Initiated Entry. The transfer debits a consumer's bank account. Authorization from the consumer is obtained over the Internet (e.g. a web or mobile application). Can be used for single debits or recurring debits.
    /// </para>
    /// <para>
    /// <c>"tel"</c> - Telephone-Initiated Entry. The transfer debits a consumer. Debit authorization has been received orally over the telephone via a recorded call.
    /// </para>
    /// </summary>
    [JsonPropertyName("sec_codes")]
    public required IReadOnlyList<AchClass> SecCodes { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

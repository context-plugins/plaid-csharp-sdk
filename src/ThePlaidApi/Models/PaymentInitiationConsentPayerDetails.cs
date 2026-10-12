using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object representing the payment consent payer details.
/// Payer <c>name</c> and account <c>numbers</c> are required to lock the account to which the consent can be created.
/// </summary>
public record PaymentInitiationConsentPayerDetails
{
    /// <summary>
    /// The name of the payer as it appears in their bank account
    /// </summary>
    [JsonPropertyName("name")]
    [MinLength(1)]
    public required string Name { get; init; }

    /// <summary>
    /// The payer's bank account numbers. Exactly one of IBAN or Bacs data is required.
    /// </summary>
    [JsonPropertyName("numbers")]
    public required PaymentInitiationConsentPayerNumbers Numbers { get; init; }

    /// <summary>
    /// The optional address of the payment recipient's bank account. Required by most institutions outside of the UK.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address")]
    public PaymentInitiationAddress? Address { get; init; }

    /// <summary>
    /// The payer's birthdate, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> (YYYY-MM-DD) format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("date_of_birth")]
    public DateTimeOffset? DateOfBirth { get; init; }

    /// <summary>
    /// The payer's phone numbers in E.164 format: +{countrycode}{number}
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone_numbers")]
    public IReadOnlyList<string>? PhoneNumbers { get; init; }

    /// <summary>
    /// The payer's emails
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("emails")]
    public IReadOnlyList<string>? Emails { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

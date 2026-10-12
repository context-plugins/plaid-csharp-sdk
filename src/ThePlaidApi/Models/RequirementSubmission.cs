using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// A single requirement submission
/// </summary>
public record RequirementSubmission
{
    /// <summary>
    /// The type of requirement being submitted. See <see href="https://docs.google.com/document/d/1NEQkTD0sVK50iAQi6xHigrexDUxZ4QxXqSEfV_FFTiU/">Requirement type schema documentation</see> for a list of requirement types and possible values.
    /// </summary>
    [JsonPropertyName("requirement_type")]
    public required string RequirementType { get; init; }

    /// <summary>
    /// The value of the requirement, which can be a string or an object depending on the <c>requirement_type</c>. If it is an object, the object should be JSON marshaled into a string. See <see href="https://docs.google.com/document/d/1NEQkTD0sVK50iAQi6xHigrexDUxZ4QxXqSEfV_FFTiU/">Requirement type schema documentation</see> for a list of requirement types and possible values.
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; init; }

    /// <summary>
    /// The <c>person_id</c> of the person the requirement submission is related to. A <c>person_id</c> is returned by <c>/transfer/platform/person/create</c>. This field should not be included for requirements that are not related to a person.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("person_id")]
    public Guid? PersonId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

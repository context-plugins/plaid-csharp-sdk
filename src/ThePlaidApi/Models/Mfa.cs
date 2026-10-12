using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Specifies the multi-factor authentication settings to use with this test account
/// </summary>
public record Mfa
{
    /// <summary>
    /// Possible values are <c>device</c>, <c>selections</c>, or <c>questions</c>.
    /// <para>
    /// If value is <c>device</c>, the MFA answer is <c>1234</c>.
    /// </para>
    /// <para>
    /// If value is <c>selections</c>, the MFA answer is always the first option.
    /// </para>
    /// <para>
    /// If value is <c>questions</c>, the MFA answer is  <c>answer_&lt;i&gt;_&lt;j&gt;</c> for the j-th question in the i-th round, starting from 0. For example, the answer to the first question in the second round is <c>answer_1_0</c>.
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; init; }

    /// <summary>
    /// Number of rounds of questions. Required if value of <c>type</c> is <c>questions</c>.
    /// </summary>
    [JsonPropertyName("question_rounds")]
    public required double QuestionRounds { get; init; }

    /// <summary>
    /// Number of questions per round. Required if value of <c>type</c> is <c>questions</c>. If value of type is <c>selections</c>, default value is 2.
    /// </summary>
    [JsonPropertyName("questions_per_round")]
    public required double QuestionsPerRound { get; init; }

    /// <summary>
    /// Number of rounds of selections, used if <c>type</c> is <c>selections</c>. Defaults to 1.
    /// </summary>
    [JsonPropertyName("selection_rounds")]
    public required double SelectionRounds { get; init; }

    /// <summary>
    /// Number of available answers per question, used if <c>type</c> is <c>selections</c>. Defaults to 2.
    /// </summary>
    [JsonPropertyName("selections_per_question")]
    public required double SelectionsPerQuestion { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

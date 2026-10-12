using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the TransferQuestionnaireCreate operation.
/// </summary>
public sealed record TransferQuestionnaireCreateOperationRequest
{
    public required TransferQuestionnaireCreateRequest Body { get; init; }
}

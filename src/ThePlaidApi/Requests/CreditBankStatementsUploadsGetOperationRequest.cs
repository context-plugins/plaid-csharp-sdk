using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the CreditBankStatementsUploadsGet operation.
/// </summary>
public sealed record CreditBankStatementsUploadsGetOperationRequest
{
    public required CreditBankStatementsUploadsGetRequest Body { get; init; }
}

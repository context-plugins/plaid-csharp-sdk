using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the CreditAuditCopyTokenCreate operation.
/// </summary>
public sealed record CreditAuditCopyTokenCreateOperationRequest
{
    public required CreditAuditCopyTokenCreateRequest Body { get; init; }
}

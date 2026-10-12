using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the CreditAuditCopyTokenUpdate operation.
/// </summary>
public sealed record CreditAuditCopyTokenUpdateOperationRequest
{
    public required CreditAuditCopyTokenUpdateRequest Body { get; init; }
}

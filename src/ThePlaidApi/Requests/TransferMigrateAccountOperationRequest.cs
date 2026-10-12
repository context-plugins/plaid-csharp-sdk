using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the TransferMigrateAccount operation.
/// </summary>
public sealed record TransferMigrateAccountOperationRequest
{
    public required TransferMigrateAccountRequest Body { get; init; }
}

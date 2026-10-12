using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the UserFinancialDataRefresh operation.
/// </summary>
public sealed record UserFinancialDataRefreshOperationRequest
{
    public required UserFinancialDataRefreshRequest Body { get; init; }
}

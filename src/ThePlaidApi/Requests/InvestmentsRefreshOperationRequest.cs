using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the InvestmentsRefresh operation.
/// </summary>
public sealed record InvestmentsRefreshOperationRequest
{
    public required InvestmentsRefreshRequest Body { get; init; }
}

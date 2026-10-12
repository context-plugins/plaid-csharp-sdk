using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the CashflowReportRefresh operation.
/// </summary>
public sealed record CashflowReportRefreshOperationRequest
{
    public required CashflowReportRefreshRequest Body { get; init; }
}

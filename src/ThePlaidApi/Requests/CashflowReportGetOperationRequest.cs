using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the CashflowReportGet operation.
/// </summary>
public sealed record CashflowReportGetOperationRequest
{
    public required CashflowReportGetRequest Body { get; init; }
}

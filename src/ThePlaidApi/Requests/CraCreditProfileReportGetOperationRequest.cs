using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the CraCreditProfileReportGet operation.
/// </summary>
public sealed record CraCreditProfileReportGetOperationRequest
{
    public required CraCreditProfileReportGetRequest Body { get; init; }
}

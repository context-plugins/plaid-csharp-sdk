using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the CraCheckReportVerificationGet operation.
/// </summary>
public sealed record CraCheckReportVerificationGetOperationRequest
{
    public required CraCheckReportVerificationGetRequest Body { get; init; }
}

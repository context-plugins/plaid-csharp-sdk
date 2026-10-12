using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the CraCheckReportVerificationPdfGet operation.
/// </summary>
public sealed record CraCheckReportVerificationPdfGetOperationRequest
{
    public required CraCheckReportVerificationPdfGetRequest Body { get; init; }
}

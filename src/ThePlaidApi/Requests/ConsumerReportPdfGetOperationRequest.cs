using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the ConsumerReportPdfGet operation.
/// </summary>
public sealed record ConsumerReportPdfGetOperationRequest
{
    public required ConsumerReportPdfGetRequest Body { get; init; }
}

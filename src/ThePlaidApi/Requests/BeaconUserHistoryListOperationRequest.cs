using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the BeaconUserHistoryList operation.
/// </summary>
public sealed record BeaconUserHistoryListOperationRequest
{
    public required BeaconUserHistoryListRequest Body { get; init; }
}

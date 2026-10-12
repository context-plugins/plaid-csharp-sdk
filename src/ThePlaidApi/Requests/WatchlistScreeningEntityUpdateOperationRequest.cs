using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the WatchlistScreeningEntityUpdate operation.
/// </summary>
public sealed record WatchlistScreeningEntityUpdateOperationRequest
{
    /// <summary>
    /// The entity screening was successfully updated.
    /// </summary>
    public required WatchlistScreeningEntityUpdateRequest Body { get; init; }
}

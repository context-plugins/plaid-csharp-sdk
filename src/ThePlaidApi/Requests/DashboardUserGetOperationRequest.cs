using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the DashboardUserGet operation.
/// </summary>
public sealed record DashboardUserGetOperationRequest
{
    public required DashboardUserGetRequest Body { get; init; }
}

using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the DashboardUserList operation.
/// </summary>
public sealed record DashboardUserListOperationRequest
{
    public required DashboardUserListRequest Body { get; init; }
}

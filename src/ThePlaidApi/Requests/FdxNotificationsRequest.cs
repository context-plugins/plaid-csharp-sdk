using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the FdxNotifications operation.
/// </summary>
public sealed record FdxNotificationsRequest
{
    public required FdxNotificationEntity Body { get; init; }
}

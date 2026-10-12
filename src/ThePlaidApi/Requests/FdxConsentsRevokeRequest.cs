using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the FdxConsentsRevoke operation.
/// </summary>
public sealed record FdxConsentsRevokeRequest
{
    /// <summary>
    /// Consent Grant Identifier. Uniquely identifies the consent grant
    /// </summary>
    public required string ConsentId { get; init; }

    public required FdxConsentRevocation Body { get; init; }
}

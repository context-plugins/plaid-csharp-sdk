using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the FdxConsentsList operation.
/// </summary>
public sealed record FdxConsentsListRequest
{
    /// <summary>
    /// Data provider customer identifier whose consent grants to return.
    /// </summary>
    public required string CustomerId { get; init; }

    /// <summary>
    /// Optional filter restricting results to a single consent grant status. One of <c>ACTIVE</c>, <c>REVOKED</c>, <c>EXPIRED</c>.
    /// </summary>
    public FdxConsentGrantStatus? Status { get; init; }
}

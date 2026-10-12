namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the FdxConsentsRevocationGet operation.
/// </summary>
public sealed record FdxConsentsRevocationGetRequest
{
    /// <summary>
    /// Consent Grant Identifier. Uniquely identifies the consent grant
    /// </summary>
    public required string ConsentId { get; init; }
}

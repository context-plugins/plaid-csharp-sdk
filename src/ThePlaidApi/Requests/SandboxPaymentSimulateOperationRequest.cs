using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the SandboxPaymentSimulate operation.
/// </summary>
public sealed record SandboxPaymentSimulateOperationRequest
{
    public required SandboxPaymentSimulateRequest Body { get; init; }
}

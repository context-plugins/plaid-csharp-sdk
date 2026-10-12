using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the SandboxPaymentProfileResetLogin operation.
/// </summary>
public sealed record SandboxPaymentProfileResetLoginOperationRequest
{
    public required SandboxPaymentProfileResetLoginRequest Body { get; init; }
}

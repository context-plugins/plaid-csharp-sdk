using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the SandboxOauthSelectAccounts operation.
/// </summary>
public sealed record SandboxOauthSelectAccountsOperationRequest
{
    public required SandboxOauthSelectAccountsRequest Body { get; init; }
}

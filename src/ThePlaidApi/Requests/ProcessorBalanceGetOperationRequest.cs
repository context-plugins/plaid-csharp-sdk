using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the ProcessorBalanceGet operation.
/// </summary>
public sealed record ProcessorBalanceGetOperationRequest
{
    /// <summary>
    /// The <c>/processor/balance/get</c> endpoint returns the real-time balance for the account associated with a given <c>processor_token</c>.
    /// <para>
    /// The current balance is the total amount of funds in the account. The available balance is the current balance less any outstanding holds or debits that have not yet posted to the account.
    /// </para>
    /// <para>
    /// Note that not all institutions calculate the available balance. In the event that available balance is unavailable from the institution, Plaid will return an available balance value of <c>null</c>.
    /// </para>
    /// </summary>
    public required ProcessorBalanceGetRequest Body { get; init; }
}

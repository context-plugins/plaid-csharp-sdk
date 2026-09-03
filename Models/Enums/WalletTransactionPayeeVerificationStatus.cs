using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Result of payee verification check for EUR payouts. Payee verification checks whether the payee name provided matches the account holder name at the destination institution.
/// <para>
/// <c>FULL_MATCH</c>: The payee name fully matches the account holder.
/// </para>
/// <para>
/// <c>PARTIAL_MATCH</c>: The payee name partially matches the account holder.
/// </para>
/// <para>
/// <c>NO_MATCH</c>: The payee name does not match the account holder.
/// </para>
/// <para>
/// <c>ERROR</c>: An error occurred during payee verification.
/// </para>
/// <para>
/// <c>CHECK_NOT_POSSIBLE</c>: Payee verification could not be performed.
/// </para>
/// <para>
/// This field is only populated for applicable EUR payout transactions and will be <c>null</c> for other transaction types.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<WalletTransactionPayeeVerificationStatus>))]
public sealed record WalletTransactionPayeeVerificationStatus : StringEnum<WalletTransactionPayeeVerificationStatus>
{
    private WalletTransactionPayeeVerificationStatus(string value) : base(value)
    {
    }

    public static readonly WalletTransactionPayeeVerificationStatus FullMatch = new("FULL_MATCH");

    public static readonly WalletTransactionPayeeVerificationStatus PartialMatch = new("PARTIAL_MATCH");

    public static readonly WalletTransactionPayeeVerificationStatus NoMatch = new("NO_MATCH");

    public static readonly WalletTransactionPayeeVerificationStatus Error = new("ERROR");

    public static readonly WalletTransactionPayeeVerificationStatus CheckNotPossible = new("CHECK_NOT_POSSIBLE");

    public static WalletTransactionPayeeVerificationStatus FromValue(string value) => FromValueCore(value);
}

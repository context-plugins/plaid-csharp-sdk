using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The warning code identifies a specific kind of warning.
/// <c>IDENTITY_UNAVAILABLE</c>: Account-owner information is not available.
/// <c>TRANSACTIONS_UNAVAILABLE</c>: Transactions information associated with Credit and Depository accounts are unavailable.
/// <c>USER_FRAUD_ALERT</c>: The User has placed a fraud alert on their Plaid Check consumer report due to suspected fraud. Note: when a fraud alert is in place, the recipient of the consumer report has an obligation to verify the consumer's identity.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BaseReportWarningCode>))]
public sealed record BaseReportWarningCode : StringEnum<BaseReportWarningCode>
{
    private BaseReportWarningCode(string value) : base(value)
    {
    }

    public static readonly BaseReportWarningCode IdentityUnavailable = new("IDENTITY_UNAVAILABLE");

    public static readonly BaseReportWarningCode TransactionsUnavailable = new("TRANSACTIONS_UNAVAILABLE");

    public static readonly BaseReportWarningCode UserFraudAlert = new("USER_FRAUD_ALERT");

    public static BaseReportWarningCode FromValue(string value) => FromValueCore(value);
}

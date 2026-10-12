using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The method used to populate Auth data for the Item. This field is only populated for Items that have had Auth numbers data set on at least one of their accounts, and will be <c>null</c> otherwise. For info about the various flows, see our <see href="https://plaid.com/docs/auth/coverage/">Auth coverage documentation</see>.
/// <para>
/// <c>INSTANT_AUTH</c>: The Item's Auth data was provided directly by the user's institution connection.
/// </para>
/// <para>
/// <c>INSTANT_MATCH</c>: The Item's Auth data was provided via the Instant Match fallback flow.
/// </para>
/// <para>
/// <c>AUTOMATED_MICRODEPOSITS</c>: The Item's Auth data was provided via the Automated Micro-deposits flow.
/// </para>
/// <para>
/// <c>SAME_DAY_MICRODEPOSITS</c>: The Item's Auth data was provided via the Same-Day Micro-deposits flow.
/// </para>
/// <para>
/// <c>INSTANT_MICRODEPOSITS</c>: The Item's Auth data was provided via the Instant Micro-deposits flow.
/// </para>
/// <para>
/// <c>DATABASE_MATCH</c>: The Item's Auth data was provided via the Database Match flow.
/// </para>
/// <para>
/// <c>DATABASE_INSIGHTS</c>: The Item's Auth data was provided via the Database Insights flow.
/// </para>
/// <para>
/// <c>TRANSFER_MIGRATED</c>: The Item's Auth data was provided via <see href="https://plaid.com/docs/api/products/transfer/account-linking/#migrate-account-into-transfers"><c>/transfer/migrate_account</c></see>.
/// </para>
/// <para>
/// <c>INVESTMENTS_FALLBACK</c>: The Item's Auth data for Investments Move was provided via a <see href="https://plaid.com/docs/investments-move/#fallback-flows">fallback flow</see>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ItemAuthMethod>))]
public sealed record ItemAuthMethod : OpenStringEnum<ItemAuthMethod>
{
    private ItemAuthMethod(string value) : base(value)
    {
    }

    public static readonly ItemAuthMethod InstantAuth = new("INSTANT_AUTH");

    public static readonly ItemAuthMethod InstantMatch = new("INSTANT_MATCH");

    public static readonly ItemAuthMethod AutomatedMicrodeposits = new("AUTOMATED_MICRODEPOSITS");

    public static readonly ItemAuthMethod SameDayMicrodeposits = new("SAME_DAY_MICRODEPOSITS");

    public static readonly ItemAuthMethod InstantMicrodeposits = new("INSTANT_MICRODEPOSITS");

    public static readonly ItemAuthMethod DatabaseMatch = new("DATABASE_MATCH");

    public static readonly ItemAuthMethod DatabaseInsights = new("DATABASE_INSIGHTS");

    public static readonly ItemAuthMethod TransferMigrated = new("TRANSFER_MIGRATED");

    public static readonly ItemAuthMethod InvestmentsFallback = new("INVESTMENTS_FALLBACK");

    public TResult Match<TResult>(Func<TResult> onInstantAuth,
        Func<TResult> onInstantMatch,
        Func<TResult> onAutomatedMicrodeposits,
        Func<TResult> onSameDayMicrodeposits,
        Func<TResult> onInstantMicrodeposits,
        Func<TResult> onDatabaseMatch,
        Func<TResult> onDatabaseInsights,
        Func<TResult> onTransferMigrated,
        Func<TResult> onInvestmentsFallback,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == InstantAuth => onInstantAuth(),
            _ when this == InstantMatch => onInstantMatch(),
            _ when this == AutomatedMicrodeposits => onAutomatedMicrodeposits(),
            _ when this == SameDayMicrodeposits => onSameDayMicrodeposits(),
            _ when this == InstantMicrodeposits => onInstantMicrodeposits(),
            _ when this == DatabaseMatch => onDatabaseMatch(),
            _ when this == DatabaseInsights => onDatabaseInsights(),
            _ when this == TransferMigrated => onTransferMigrated(),
            _ when this == InvestmentsFallback => onInvestmentsFallback(),
            _ => otherwise(Value)
        };

    public void Match(Action onInstantAuth,
        Action onInstantMatch,
        Action onAutomatedMicrodeposits,
        Action onSameDayMicrodeposits,
        Action onInstantMicrodeposits,
        Action onDatabaseMatch,
        Action onDatabaseInsights,
        Action onTransferMigrated,
        Action onInvestmentsFallback,
        Action<string> otherwise)
    {
        if (this == InstantAuth) onInstantAuth();
        else if (this == InstantMatch) onInstantMatch();
        else if (this == AutomatedMicrodeposits) onAutomatedMicrodeposits();
        else if (this == SameDayMicrodeposits) onSameDayMicrodeposits();
        else if (this == InstantMicrodeposits) onInstantMicrodeposits();
        else if (this == DatabaseMatch) onDatabaseMatch();
        else if (this == DatabaseInsights) onDatabaseInsights();
        else if (this == TransferMigrated) onTransferMigrated();
        else if (this == InvestmentsFallback) onInvestmentsFallback();
        else otherwise(Value);
    }
}

using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The application requires that accounts be limited to a specific cardinality.
/// <c>MULTI_SELECT</c>: indicates that the user should be allowed to pick multiple accounts.
/// <c>SINGLE_SELECT</c>: indicates that the user should be allowed to pick only a single account.
/// <c>ALL</c>: indicates that the user must share all of their accounts and should not be given the opportunity to de-select
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AccountSelectionCardinality>))]
public sealed record AccountSelectionCardinality : StringEnum<AccountSelectionCardinality>
{
    private AccountSelectionCardinality(string value) : base(value)
    {
    }

    public static readonly AccountSelectionCardinality SingleSelect = new("SINGLE_SELECT");

    public static readonly AccountSelectionCardinality MultiSelect = new("MULTI_SELECT");

    public static readonly AccountSelectionCardinality All = new("ALL");

    public static AccountSelectionCardinality FromValue(string value) => FromValueCore(value);
}

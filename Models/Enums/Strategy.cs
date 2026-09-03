using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// An instruction specifying what steps the new Identity Verification attempt should require the user to complete:
/// <para>
///
/// <c>reset</c> - Restart the user at the beginning of the session, regardless of whether they successfully completed part of their previous session.
/// </para>
/// <para>
/// <c>incomplete</c> - Start the new session at the step that the user failed in the previous session, skipping steps that have already been successfully completed.
/// </para>
/// <para>
/// <c>infer</c> - If the most recent Identity Verification attempt associated with the given <c>client_user_id</c> has a status of <c>failed</c> or <c>expired</c>, retry using the <c>incomplete</c> strategy. Otherwise, use the <c>reset</c> strategy.
/// </para>
/// <para>
/// <c>custom</c> - Start the new session with a custom configuration, specified by the value of the <c>steps</c> field
/// </para>
/// <para>
/// Note:
/// </para>
/// <para>
/// The <c>incomplete</c> strategy cannot be applied if the session's failing step is <c>watchlist_screening</c> or <c>risk_check</c>.
/// </para>
/// <para>
/// The <c>infer</c> strategy cannot be applied if the session's status is still <c>active</c>
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Strategy>))]
public sealed record Strategy : StringEnum<Strategy>
{
    private Strategy(string value) : base(value)
    {
    }

    public static readonly Strategy Reset = new("reset");

    public static readonly Strategy Incomplete = new("incomplete");

    public static readonly Strategy Infer = new("infer");

    public static readonly Strategy Custom = new("custom");

    public static Strategy FromValue(string value) => FromValueCore(value);
}

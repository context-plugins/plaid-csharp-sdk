using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Enum representing the state of the action/activity.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ActionState>))]
public sealed record ActionState : StringEnum<ActionState>
{
    private ActionState(string value) : base(value)
    {
    }

    public static readonly ActionState Unknown = new("UNKNOWN");

    public static readonly ActionState Attempt = new("ATTEMPT");

    public static readonly ActionState Success = new("SUCCESS");

    public static readonly ActionState Failure = new("FAILURE");

    public static readonly ActionState Skipped = new("SKIPPED");

    public static ActionState FromValue(string value) => FromValueCore(value);
}

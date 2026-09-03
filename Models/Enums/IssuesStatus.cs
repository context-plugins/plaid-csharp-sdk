using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The current status of the issue.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<IssuesStatus>))]
public sealed record IssuesStatus : StringEnum<IssuesStatus>
{
    private IssuesStatus(string value) : base(value)
    {
    }

    public static readonly IssuesStatus Reported = new("REPORTED");

    public static readonly IssuesStatus AwaitingResolution = new("AWAITING_RESOLUTION");

    public static readonly IssuesStatus FixInProgress = new("FIX_IN_PROGRESS");

    public static readonly IssuesStatus FixPendingValidation = new("FIX_PENDING_VALIDATION");

    public static readonly IssuesStatus CannotFix = new("CANNOT_FIX");

    public static readonly IssuesStatus Resolved = new("RESOLVED");

    public static IssuesStatus FromValue(string value) => FromValueCore(value);
}

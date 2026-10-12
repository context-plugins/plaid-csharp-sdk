using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the SignalSchedule operation.
/// </summary>
public sealed record SignalScheduleOperationRequest
{
    public required SignalScheduleRequest Body { get; init; }
}

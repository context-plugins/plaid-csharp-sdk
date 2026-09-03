using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The status of the transfer intent.
/// <para>
/// <c>PENDING</c>: The transfer intent is pending.
/// <c>SUCCEEDED</c>: The transfer intent was successfully created.
/// <c>FAILED</c>: The transfer intent was unable to be created.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransferIntentStatus>))]
public sealed record TransferIntentStatus : StringEnum<TransferIntentStatus>
{
    private TransferIntentStatus(string value) : base(value)
    {
    }

    public static readonly TransferIntentStatus Pending = new("PENDING");

    public static readonly TransferIntentStatus Succeeded = new("SUCCEEDED");

    public static readonly TransferIntentStatus Failed = new("FAILED");

    public static TransferIntentStatus FromValue(string value) => FromValueCore(value);
}

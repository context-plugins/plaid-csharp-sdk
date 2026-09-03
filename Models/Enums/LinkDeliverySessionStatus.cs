using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The status of the given Hosted Link session.
/// <para>
/// <c>CREATED</c>: The session is created but not yet accessed by the user
/// </para>
/// <para>
/// <c>OPENED</c>: The session is opened by the user but not yet completed
/// </para>
/// <para>
/// <c>EXITED</c>: The session has been exited by the user
/// </para>
/// <para>
/// <c>COMPLETED</c>: The session has been completed by the user
/// </para>
/// <para>
/// <c>EXPIRED</c>: The session has expired
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LinkDeliverySessionStatus>))]
public sealed record LinkDeliverySessionStatus : StringEnum<LinkDeliverySessionStatus>
{
    private LinkDeliverySessionStatus(string value) : base(value)
    {
    }

    public static readonly LinkDeliverySessionStatus Created = new("CREATED");

    public static readonly LinkDeliverySessionStatus Opened = new("OPENED");

    public static readonly LinkDeliverySessionStatus Exited = new("EXITED");

    public static readonly LinkDeliverySessionStatus Completed = new("COMPLETED");

    public static readonly LinkDeliverySessionStatus Expired = new("EXPIRED");

    public static LinkDeliverySessionStatus FromValue(string value) => FromValueCore(value);
}

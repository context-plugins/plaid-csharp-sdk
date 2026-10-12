using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The network or rails used for the transfer. Defaults to <c>same-day-ach</c>.
/// <para>
/// For transfers submitted using <c>ach</c>, the Standard ACH cutoff is 8:30 PM Eastern Time.
/// </para>
/// <para>
/// For transfers submitted using <c>same-day-ach</c>, the Same Day ACH cutoff is 3:00 PM Eastern Time. It is recommended to send the request 15 minutes prior to the cutoff to ensure that it will be processed in time for submission before the cutoff. If the transfer is processed after this cutoff but before the Standard ACH cutoff, it will be sent over Standard ACH rails and will not incur same-day charges.
/// </para>
/// <para>
/// For transfers submitted using <c>rtp</c>, in the case that the account being credited does not support RTP, the transfer will be sent over ACH as long as an <c>ach_class</c> is provided in the request. If RTP isn't supported by the account and no <c>ach_class</c> is provided, the transfer will fail to be submitted.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransferIntentCreateNetwork>))]
public sealed record TransferIntentCreateNetwork : OpenStringEnum<TransferIntentCreateNetwork>
{
    private TransferIntentCreateNetwork(string value) : base(value)
    {
    }

    public static readonly TransferIntentCreateNetwork Ach = new("ach");

    public static readonly TransferIntentCreateNetwork SameDayAch = new("same-day-ach");

    public static readonly TransferIntentCreateNetwork Rtp = new("rtp");

    public TResult Match<TResult>(Func<TResult> onAch,
        Func<TResult> onSameDayAch,
        Func<TResult> onRtp,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Ach => onAch(),
            _ when this == SameDayAch => onSameDayAch(),
            _ when this == Rtp => onRtp(),
            _ => otherwise(Value)
        };

    public void Match(Action onAch, Action onSameDayAch, Action onRtp, Action<string> otherwise)
    {
        if (this == Ach) onAch();
        else if (this == SameDayAch) onSameDayAch();
        else if (this == Rtp) onRtp();
        else otherwise(Value);
    }
}

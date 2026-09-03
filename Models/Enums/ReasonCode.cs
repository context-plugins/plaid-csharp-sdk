using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Specifies the reason for cancelling transfer. This is required for RfP transfers, and will be ignored for other networks.
/// <para>
/// <c>"AC03"</c> - Invalid Creditor Account Number
/// </para>
/// <para>
/// <c>"AM09"</c> - Incorrect Amount
/// </para>
/// <para>
/// <c>"CUST"</c> - Requested By Customer - Cancellation requested
/// </para>
/// <para>
/// <c>"DUPL"</c> - Duplicate Payment
/// </para>
/// <para>
/// <c>"FRAD"</c> - Fraudulent Payment - Unauthorized or fraudulently induced
/// </para>
/// <para>
/// <c>"TECH"</c> - Technical Problem - Cancellation due to system issues
/// </para>
/// <para>
/// <c>"UPAY"</c> - Undue Payment - Payment was made through another channel
/// </para>
/// <para>
/// <c>"AC14"</c> - Invalid or Missing Creditor Account Type
/// </para>
/// <para>
/// <c>"AM06"</c> - Amount Too Low
/// </para>
/// <para>
/// <c>"BE05"</c> - Unrecognized Initiating Party
/// </para>
/// <para>
/// <c>"FOCR"</c> - Following Refund Request
/// </para>
/// <para>
/// <c>"MS02"</c> - No Specified Reason - Customer
/// </para>
/// <para>
/// <c>"MS03"</c> - No Specified Reason - Agent
/// </para>
/// <para>
/// <c>"RR04"</c> - Regulatory Reason
/// </para>
/// <para>
/// <c>"RUTA"</c> - Return Upon Unable To Apply
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ReasonCode>))]
public sealed record ReasonCode : StringEnum<ReasonCode>
{
    private ReasonCode(string value) : base(value)
    {
    }

    public static readonly ReasonCode Ac03 = new("AC03");

    public static readonly ReasonCode Am09 = new("AM09");

    public static readonly ReasonCode Cust = new("CUST");

    public static readonly ReasonCode Dupl = new("DUPL");

    public static readonly ReasonCode Frad = new("FRAD");

    public static readonly ReasonCode Tech = new("TECH");

    public static readonly ReasonCode Upay = new("UPAY");

    public static readonly ReasonCode Ac14 = new("AC14");

    public static readonly ReasonCode Am06 = new("AM06");

    public static readonly ReasonCode Be05 = new("BE05");

    public static readonly ReasonCode Focr = new("FOCR");

    public static readonly ReasonCode Ms02 = new("MS02");

    public static readonly ReasonCode Ms03 = new("MS03");

    public static readonly ReasonCode Rr04 = new("RR04");

    public static readonly ReasonCode Ruta = new("RUTA");

    public static ReasonCode FromValue(string value) => FromValueCore(value);
}

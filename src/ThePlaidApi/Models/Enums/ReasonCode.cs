using System;
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
public sealed record ReasonCode : OpenStringEnum<ReasonCode>
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

    public TResult Match<TResult>(Func<TResult> onAc03,
        Func<TResult> onAm09,
        Func<TResult> onCust,
        Func<TResult> onDupl,
        Func<TResult> onFrad,
        Func<TResult> onTech,
        Func<TResult> onUpay,
        Func<TResult> onAc14,
        Func<TResult> onAm06,
        Func<TResult> onBe05,
        Func<TResult> onFocr,
        Func<TResult> onMs02,
        Func<TResult> onMs03,
        Func<TResult> onRr04,
        Func<TResult> onRuta,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Ac03 => onAc03(),
            _ when this == Am09 => onAm09(),
            _ when this == Cust => onCust(),
            _ when this == Dupl => onDupl(),
            _ when this == Frad => onFrad(),
            _ when this == Tech => onTech(),
            _ when this == Upay => onUpay(),
            _ when this == Ac14 => onAc14(),
            _ when this == Am06 => onAm06(),
            _ when this == Be05 => onBe05(),
            _ when this == Focr => onFocr(),
            _ when this == Ms02 => onMs02(),
            _ when this == Ms03 => onMs03(),
            _ when this == Rr04 => onRr04(),
            _ when this == Ruta => onRuta(),
            _ => otherwise(Value)
        };

    public void Match(Action onAc03,
        Action onAm09,
        Action onCust,
        Action onDupl,
        Action onFrad,
        Action onTech,
        Action onUpay,
        Action onAc14,
        Action onAm06,
        Action onBe05,
        Action onFocr,
        Action onMs02,
        Action onMs03,
        Action onRr04,
        Action onRuta,
        Action<string> otherwise)
    {
        if (this == Ac03) onAc03();
        else if (this == Am09) onAm09();
        else if (this == Cust) onCust();
        else if (this == Dupl) onDupl();
        else if (this == Frad) onFrad();
        else if (this == Tech) onTech();
        else if (this == Upay) onUpay();
        else if (this == Ac14) onAc14();
        else if (this == Am06) onAm06();
        else if (this == Be05) onBe05();
        else if (this == Focr) onFocr();
        else if (this == Ms02) onMs02();
        else if (this == Ms03) onMs03();
        else if (this == Rr04) onRr04();
        else if (this == Ruta) onRuta();
        else otherwise(Value);
    }
}

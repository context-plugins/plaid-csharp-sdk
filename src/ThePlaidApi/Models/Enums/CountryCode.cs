using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// ISO-3166-1 alpha-2 country code standard.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CountryCode>))]
public sealed record CountryCode : OpenStringEnum<CountryCode>
{
    private CountryCode(string value) : base(value)
    {
    }

    public static readonly CountryCode Us = new("US");

    public static readonly CountryCode Gb = new("GB");

    public static readonly CountryCode Es = new("ES");

    public static readonly CountryCode Nl = new("NL");

    public static readonly CountryCode Fr = new("FR");

    public static readonly CountryCode Ie = new("IE");

    public static readonly CountryCode Ca = new("CA");

    public static readonly CountryCode De = new("DE");

    public static readonly CountryCode It = new("IT");

    public static readonly CountryCode Pl = new("PL");

    public static readonly CountryCode Dk = new("DK");

    public static readonly CountryCode No = new("NO");

    public static readonly CountryCode Se = new("SE");

    public static readonly CountryCode Ee = new("EE");

    public static readonly CountryCode Lt = new("LT");

    public static readonly CountryCode Lv = new("LV");

    public static readonly CountryCode Pt = new("PT");

    public static readonly CountryCode Be = new("BE");

    public static readonly CountryCode At = new("AT");

    public static readonly CountryCode Fi = new("FI");

    public TResult Match<TResult>(Func<TResult> onUs,
        Func<TResult> onGb,
        Func<TResult> onEs,
        Func<TResult> onNl,
        Func<TResult> onFr,
        Func<TResult> onIe,
        Func<TResult> onCa,
        Func<TResult> onDe,
        Func<TResult> onIt,
        Func<TResult> onPl,
        Func<TResult> onDk,
        Func<TResult> onNo,
        Func<TResult> onSe,
        Func<TResult> onEe,
        Func<TResult> onLt,
        Func<TResult> onLv,
        Func<TResult> onPt,
        Func<TResult> onBe,
        Func<TResult> onAt,
        Func<TResult> onFi,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Us => onUs(),
            _ when this == Gb => onGb(),
            _ when this == Es => onEs(),
            _ when this == Nl => onNl(),
            _ when this == Fr => onFr(),
            _ when this == Ie => onIe(),
            _ when this == Ca => onCa(),
            _ when this == De => onDe(),
            _ when this == It => onIt(),
            _ when this == Pl => onPl(),
            _ when this == Dk => onDk(),
            _ when this == No => onNo(),
            _ when this == Se => onSe(),
            _ when this == Ee => onEe(),
            _ when this == Lt => onLt(),
            _ when this == Lv => onLv(),
            _ when this == Pt => onPt(),
            _ when this == Be => onBe(),
            _ when this == At => onAt(),
            _ when this == Fi => onFi(),
            _ => otherwise(Value)
        };

    public void Match(Action onUs,
        Action onGb,
        Action onEs,
        Action onNl,
        Action onFr,
        Action onIe,
        Action onCa,
        Action onDe,
        Action onIt,
        Action onPl,
        Action onDk,
        Action onNo,
        Action onSe,
        Action onEe,
        Action onLt,
        Action onLv,
        Action onPt,
        Action onBe,
        Action onAt,
        Action onFi,
        Action<string> otherwise)
    {
        if (this == Us) onUs();
        else if (this == Gb) onGb();
        else if (this == Es) onEs();
        else if (this == Nl) onNl();
        else if (this == Fr) onFr();
        else if (this == Ie) onIe();
        else if (this == Ca) onCa();
        else if (this == De) onDe();
        else if (this == It) onIt();
        else if (this == Pl) onPl();
        else if (this == Dk) onDk();
        else if (this == No) onNo();
        else if (this == Se) onSe();
        else if (this == Ee) onEe();
        else if (this == Lt) onLt();
        else if (this == Lv) onLv();
        else if (this == Pt) onPt();
        else if (this == Be) onBe();
        else if (this == At) onAt();
        else if (this == Fi) onFi();
        else otherwise(Value);
    }
}

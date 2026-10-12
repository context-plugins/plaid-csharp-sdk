using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The legal structure or type of business entity
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BusinessEntityType>))]
public sealed record BusinessEntityType : OpenStringEnum<BusinessEntityType>
{
    private BusinessEntityType(string value) : base(value)
    {
    }

    public static readonly BusinessEntityType SoleProprietorship = new("sole_proprietorship");

    public static readonly BusinessEntityType GeneralPartnership = new("general_partnership");

    public static readonly BusinessEntityType Llc = new("llc");

    public static readonly BusinessEntityType Llp = new("llp");

    public static readonly BusinessEntityType Lllp = new("lllp");

    public static readonly BusinessEntityType Lp = new("lp");

    public static readonly BusinessEntityType CCorporation = new("c_corporation");

    public static readonly BusinessEntityType SCorporation = new("s_corporation");

    public static readonly BusinessEntityType BCorporation = new("b_corporation");

    public static readonly BusinessEntityType Nonprofit = new("nonprofit");

    public static readonly BusinessEntityType Cooperative = new("cooperative");

    public static readonly BusinessEntityType Trust = new("trust");

    public static readonly BusinessEntityType ProfessionalAssociation = new("professional_association");

    public static readonly BusinessEntityType ProfessionalCorporation = new("professional_corporation");

    public static readonly BusinessEntityType TradeName = new("trade_name");

    public static readonly BusinessEntityType Bank = new("bank");

    public static readonly BusinessEntityType CreditUnion = new("credit_union");

    public static readonly BusinessEntityType Insurance = new("insurance");

    public static readonly BusinessEntityType Other = new("other");

    public static readonly BusinessEntityType Unknown = new("unknown");

    public TResult Match<TResult>(Func<TResult> onSoleProprietorship,
        Func<TResult> onGeneralPartnership,
        Func<TResult> onLlc,
        Func<TResult> onLlp,
        Func<TResult> onLllp,
        Func<TResult> onLp,
        Func<TResult> onCCorporation,
        Func<TResult> onSCorporation,
        Func<TResult> onBCorporation,
        Func<TResult> onNonprofit,
        Func<TResult> onCooperative,
        Func<TResult> onTrust,
        Func<TResult> onProfessionalAssociation,
        Func<TResult> onProfessionalCorporation,
        Func<TResult> onTradeName,
        Func<TResult> onBank,
        Func<TResult> onCreditUnion,
        Func<TResult> onInsurance,
        Func<TResult> onOther,
        Func<TResult> onUnknown,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == SoleProprietorship => onSoleProprietorship(),
            _ when this == GeneralPartnership => onGeneralPartnership(),
            _ when this == Llc => onLlc(),
            _ when this == Llp => onLlp(),
            _ when this == Lllp => onLllp(),
            _ when this == Lp => onLp(),
            _ when this == CCorporation => onCCorporation(),
            _ when this == SCorporation => onSCorporation(),
            _ when this == BCorporation => onBCorporation(),
            _ when this == Nonprofit => onNonprofit(),
            _ when this == Cooperative => onCooperative(),
            _ when this == Trust => onTrust(),
            _ when this == ProfessionalAssociation => onProfessionalAssociation(),
            _ when this == ProfessionalCorporation => onProfessionalCorporation(),
            _ when this == TradeName => onTradeName(),
            _ when this == Bank => onBank(),
            _ when this == CreditUnion => onCreditUnion(),
            _ when this == Insurance => onInsurance(),
            _ when this == Other => onOther(),
            _ when this == Unknown => onUnknown(),
            _ => otherwise(Value)
        };

    public void Match(Action onSoleProprietorship,
        Action onGeneralPartnership,
        Action onLlc,
        Action onLlp,
        Action onLllp,
        Action onLp,
        Action onCCorporation,
        Action onSCorporation,
        Action onBCorporation,
        Action onNonprofit,
        Action onCooperative,
        Action onTrust,
        Action onProfessionalAssociation,
        Action onProfessionalCorporation,
        Action onTradeName,
        Action onBank,
        Action onCreditUnion,
        Action onInsurance,
        Action onOther,
        Action onUnknown,
        Action<string> otherwise)
    {
        if (this == SoleProprietorship) onSoleProprietorship();
        else if (this == GeneralPartnership) onGeneralPartnership();
        else if (this == Llc) onLlc();
        else if (this == Llp) onLlp();
        else if (this == Lllp) onLllp();
        else if (this == Lp) onLp();
        else if (this == CCorporation) onCCorporation();
        else if (this == SCorporation) onSCorporation();
        else if (this == BCorporation) onBCorporation();
        else if (this == Nonprofit) onNonprofit();
        else if (this == Cooperative) onCooperative();
        else if (this == Trust) onTrust();
        else if (this == ProfessionalAssociation) onProfessionalAssociation();
        else if (this == ProfessionalCorporation) onProfessionalCorporation();
        else if (this == TradeName) onTradeName();
        else if (this == Bank) onBank();
        else if (this == CreditUnion) onCreditUnion();
        else if (this == Insurance) onInsurance();
        else if (this == Other) onOther();
        else if (this == Unknown) onUnknown();
        else otherwise(Value);
    }
}

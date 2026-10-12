using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The registry containing the party's registration with name and id
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PartyRegistry>))]
public sealed record PartyRegistry : OpenStringEnum<PartyRegistry>
{
    private PartyRegistry(string value) : base(value)
    {
    }

    public static readonly PartyRegistry Fdx = new("FDX");

    public static readonly PartyRegistry Gleif = new("GLEIF");

    public static readonly PartyRegistry Icann = new("ICANN");

    public static readonly PartyRegistry Private = new("PRIVATE");

    public TResult Match<TResult>(Func<TResult> onFdx,
        Func<TResult> onGleif,
        Func<TResult> onIcann,
        Func<TResult> onPrivate,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Fdx => onFdx(),
            _ when this == Gleif => onGleif(),
            _ when this == Icann => onIcann(),
            _ when this == Private => onPrivate(),
            _ => otherwise(Value)
        };

    public void Match(Action onFdx, Action onGleif, Action onIcann, Action onPrivate, Action<string> otherwise)
    {
        if (this == Fdx) onFdx();
        else if (this == Gleif) onGleif();
        else if (this == Icann) onIcann();
        else if (this == Private) onPrivate();
        else otherwise(Value);
    }
}

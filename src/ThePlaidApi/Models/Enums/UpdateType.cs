using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Indicates whether an Item requires user interaction to be updated, which can be the case for Items with some forms of two-factor authentication.
/// <para>
/// <c>background</c> - Item can be updated in the background
/// </para>
/// <para>
/// <c>user_present_required</c> - Item requires user interaction to be updated
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<UpdateType>))]
public sealed record UpdateType : OpenStringEnum<UpdateType>
{
    private UpdateType(string value) : base(value)
    {
    }

    public static readonly UpdateType Background = new("background");

    public static readonly UpdateType UserPresentRequired = new("user_present_required");

    public TResult Match<TResult>(Func<TResult> onBackground,
        Func<TResult> onUserPresentRequired,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Background => onBackground(),
            _ when this == UserPresentRequired => onUserPresentRequired(),
            _ => otherwise(Value)
        };

    public void Match(Action onBackground, Action onUserPresentRequired, Action<string> otherwise)
    {
        if (this == Background) onBackground();
        else if (this == UserPresentRequired) onUserPresentRequired();
        else otherwise(Value);
    }
}

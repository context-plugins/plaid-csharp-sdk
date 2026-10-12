using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// HTTP Method to use for the request
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FdxHateoasLinkAction>))]
public sealed record FdxHateoasLinkAction : OpenStringEnum<FdxHateoasLinkAction>
{
    private FdxHateoasLinkAction(string value) : base(value)
    {
    }

    public static readonly FdxHateoasLinkAction Get = new("GET");

    public static readonly FdxHateoasLinkAction Post = new("POST");

    public static readonly FdxHateoasLinkAction Patch = new("PATCH");

    public static readonly FdxHateoasLinkAction Delete = new("DELETE");

    public static readonly FdxHateoasLinkAction Put = new("PUT");

    public TResult Match<TResult>(Func<TResult> onGet,
        Func<TResult> onPost,
        Func<TResult> onPatch,
        Func<TResult> onDelete,
        Func<TResult> onPut,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Get => onGet(),
            _ when this == Post => onPost(),
            _ when this == Patch => onPatch(),
            _ when this == Delete => onDelete(),
            _ when this == Put => onPut(),
            _ => otherwise(Value)
        };

    public void Match(Action onGet,
        Action onPost,
        Action onPatch,
        Action onDelete,
        Action onPut,
        Action<string> otherwise)
    {
        if (this == Get) onGet();
        else if (this == Post) onPost();
        else if (this == Patch) onPatch();
        else if (this == Delete) onDelete();
        else if (this == Put) onPut();
        else otherwise(Value);
    }
}

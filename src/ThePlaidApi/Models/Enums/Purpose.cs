using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Specifies the purpose of the uploaded file.
/// <para>
/// <c>"DUE_DILIGENCE"</c> - The transfer due diligence document of the originator.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Purpose>))]
public sealed record Purpose : OpenStringEnum<Purpose>
{
    private Purpose(string value) : base(value)
    {
    }

    public static readonly Purpose DueDiligence = new("DUE_DILIGENCE");

    public TResult Match<TResult>(Func<TResult> onDueDiligence, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == DueDiligence => onDueDiligence(),
            _ => otherwise(Value)
        };

    public void Match(Action onDueDiligence, Action<string> otherwise)
    {
        if (this == DueDiligence) onDueDiligence();
        else otherwise(Value);
    }
}

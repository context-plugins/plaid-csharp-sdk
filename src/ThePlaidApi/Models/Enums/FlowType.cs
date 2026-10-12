using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// This field has been deprecated in favor of <c>auth_type_select_enabled</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FlowType>))]
public sealed record FlowType : OpenStringEnum<FlowType>
{
    private FlowType(string value) : base(value)
    {
    }

    public static readonly FlowType FlexibleAuth = new("FLEXIBLE_AUTH");

    public TResult Match<TResult>(Func<TResult> onFlexibleAuth, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == FlexibleAuth => onFlexibleAuth(),
            _ => otherwise(Value)
        };

    public void Match(Action onFlexibleAuth, Action<string> otherwise)
    {
        if (this == FlexibleAuth) onFlexibleAuth();
        else otherwise(Value);
    }
}

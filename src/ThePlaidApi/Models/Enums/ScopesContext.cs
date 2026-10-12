using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// An indicator for when scopes are being updated. When scopes are updated via enrollment (i.e. OAuth), the partner must send <c>ENROLLMENT</c>. When scopes are updated in a post-enrollment view, the partner must send <c>PORTAL</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ScopesContext>))]
public sealed record ScopesContext : OpenStringEnum<ScopesContext>
{
    private ScopesContext(string value) : base(value)
    {
    }

    public static readonly ScopesContext Enrollment = new("ENROLLMENT");

    public static readonly ScopesContext Portal = new("PORTAL");

    public TResult Match<TResult>(Func<TResult> onEnrollment,
        Func<TResult> onPortal,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Enrollment => onEnrollment(),
            _ when this == Portal => onPortal(),
            _ => otherwise(Value)
        };

    public void Match(Action onEnrollment, Action onPortal, Action<string> otherwise)
    {
        if (this == Enrollment) onEnrollment();
        else if (this == Portal) onPortal();
        else otherwise(Value);
    }
}

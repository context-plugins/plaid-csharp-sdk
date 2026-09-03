using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// An indicator for when scopes are being updated. When scopes are updated via enrollment (i.e. OAuth), the partner must send <c>ENROLLMENT</c>. When scopes are updated in a post-enrollment view, the partner must send <c>PORTAL</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ScopesContext>))]
public sealed record ScopesContext : StringEnum<ScopesContext>
{
    private ScopesContext(string value) : base(value)
    {
    }

    public static readonly ScopesContext Enrollment = new("ENROLLMENT");

    public static readonly ScopesContext Portal = new("PORTAL");

    public static ScopesContext FromValue(string value) => FromValueCore(value);
}

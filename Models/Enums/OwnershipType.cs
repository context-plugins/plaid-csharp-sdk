using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// How an asset is owned.
/// <para>
/// <c>association</c>: Ownership by a corporation, partnership, or unincorporated association, including for-profit and not-for-profit organizations.
/// <c>individual</c>: Ownership by an individual.
/// <c>joint</c>: Joint ownership by multiple parties.
/// <c>trust</c>: Ownership by a revocable or irrevocable trust.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OwnershipType>))]
public sealed record OwnershipType : StringEnum<OwnershipType>
{
    private OwnershipType(string value) : base(value)
    {
    }

    public static readonly OwnershipType Individual = new("individual");

    public static readonly OwnershipType Joint = new("joint");

    public static readonly OwnershipType Association = new("association");

    public static readonly OwnershipType Trust = new("trust");

    public static OwnershipType FromValue(string value) => FromValueCore(value);
}

using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The kind of official document represented by this object.
/// <para>
/// <c>bik</c> - Russian bank code
/// </para>
/// <para>
/// <c>business_number</c> - A number that uniquely identifies the business within a category of businesses
/// </para>
/// <para>
/// <c>imo</c> - Number assigned to the entity by the International Maritime Organization
/// </para>
/// <para>
/// <c>other</c> - Any document not covered by other categories
/// </para>
/// <para>
/// <c>swift</c> - Number identifying a bank and branch.
/// </para>
/// <para>
/// <c>tax_id</c> - Identification issued for the purpose of collecting taxes
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<EntityDocumentType>))]
public sealed record EntityDocumentType : StringEnum<EntityDocumentType>
{
    private EntityDocumentType(string value) : base(value)
    {
    }

    public static readonly EntityDocumentType Bik = new("bik");

    public static readonly EntityDocumentType BusinessNumber = new("business_number");

    public static readonly EntityDocumentType Imo = new("imo");

    public static readonly EntityDocumentType Other = new("other");

    public static readonly EntityDocumentType Swift = new("swift");

    public static readonly EntityDocumentType TaxId = new("tax_id");

    public static EntityDocumentType FromValue(string value) => FromValueCore(value);
}

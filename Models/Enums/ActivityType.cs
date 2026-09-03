using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Types of consent activities
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ActivityType>))]
public sealed record ActivityType : StringEnum<ActivityType>
{
    private ActivityType(string value) : base(value)
    {
    }

    public static readonly ActivityType Unknown = new("UNKNOWN");

    public static readonly ActivityType ItemCreate = new("ITEM_CREATE");

    public static readonly ActivityType ItemImport = new("ITEM_IMPORT");

    public static readonly ActivityType ItemUpdate = new("ITEM_UPDATE");

    public static readonly ActivityType ItemUnlink = new("ITEM_UNLINK");

    public static readonly ActivityType PortalUnlink = new("PORTAL_UNLINK");

    public static readonly ActivityType PortalItemsDelete = new("PORTAL_ITEMS_DELETE");

    public static readonly ActivityType ItemRemove = new("ITEM_REMOVE");

    public static readonly ActivityType InvariantCheckerDeletion = new("INVARIANT_CHECKER_DELETION");

    public static readonly ActivityType ScopesUpdate = new("SCOPES_UPDATE");

    public static ActivityType FromValue(string value) => FromValueCore(value);
}

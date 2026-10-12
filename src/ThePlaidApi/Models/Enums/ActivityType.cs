using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Types of consent activities
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ActivityType>))]
public sealed record ActivityType : OpenStringEnum<ActivityType>
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

    public TResult Match<TResult>(Func<TResult> onUnknown,
        Func<TResult> onItemCreate,
        Func<TResult> onItemImport,
        Func<TResult> onItemUpdate,
        Func<TResult> onItemUnlink,
        Func<TResult> onPortalUnlink,
        Func<TResult> onPortalItemsDelete,
        Func<TResult> onItemRemove,
        Func<TResult> onInvariantCheckerDeletion,
        Func<TResult> onScopesUpdate,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Unknown => onUnknown(),
            _ when this == ItemCreate => onItemCreate(),
            _ when this == ItemImport => onItemImport(),
            _ when this == ItemUpdate => onItemUpdate(),
            _ when this == ItemUnlink => onItemUnlink(),
            _ when this == PortalUnlink => onPortalUnlink(),
            _ when this == PortalItemsDelete => onPortalItemsDelete(),
            _ when this == ItemRemove => onItemRemove(),
            _ when this == InvariantCheckerDeletion => onInvariantCheckerDeletion(),
            _ when this == ScopesUpdate => onScopesUpdate(),
            _ => otherwise(Value)
        };

    public void Match(Action onUnknown,
        Action onItemCreate,
        Action onItemImport,
        Action onItemUpdate,
        Action onItemUnlink,
        Action onPortalUnlink,
        Action onPortalItemsDelete,
        Action onItemRemove,
        Action onInvariantCheckerDeletion,
        Action onScopesUpdate,
        Action<string> otherwise)
    {
        if (this == Unknown) onUnknown();
        else if (this == ItemCreate) onItemCreate();
        else if (this == ItemImport) onItemImport();
        else if (this == ItemUpdate) onItemUpdate();
        else if (this == ItemUnlink) onItemUnlink();
        else if (this == PortalUnlink) onPortalUnlink();
        else if (this == PortalItemsDelete) onPortalItemsDelete();
        else if (this == ItemRemove) onItemRemove();
        else if (this == InvariantCheckerDeletion) onInvariantCheckerDeletion();
        else if (this == ScopesUpdate) onScopesUpdate();
        else otherwise(Value);
    }
}

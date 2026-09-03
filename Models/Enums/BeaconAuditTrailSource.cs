using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A type indicating what caused a resource to be changed or updated.
/// <para>
///
/// <c>dashboard</c> - The resource was created or updated by a member of your team via the Plaid dashboard.
/// </para>
/// <para>
/// <c>api</c> - The resource was created or updated via the Plaid API.
/// </para>
/// <para>
/// <c>system</c> - The resource was created or updated automatically by a part of the Plaid Beacon system. For example, if another business using Plaid Beacon created a fraud report that matched one of your users, your matching user's status would automatically be updated and the audit trail source would be <c>system</c>.
/// </para>
/// <para>
/// <c>bulk_import</c> - The resource was created or updated as part of a bulk import process. For example, if your company provided a CSV of user data as part of your initial onboarding, the audit trail source would be <c>bulk_import</c>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BeaconAuditTrailSource>))]
public sealed record BeaconAuditTrailSource : StringEnum<BeaconAuditTrailSource>
{
    private BeaconAuditTrailSource(string value) : base(value)
    {
    }

    public static readonly BeaconAuditTrailSource Dashboard = new("dashboard");

    public static readonly BeaconAuditTrailSource Api = new("api");

    public static readonly BeaconAuditTrailSource System = new("system");

    public static readonly BeaconAuditTrailSource BulkImport = new("bulk_import");

    public static BeaconAuditTrailSource FromValue(string value) => FromValueCore(value);
}

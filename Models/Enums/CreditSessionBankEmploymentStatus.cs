using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Status of the Bank Employment Link session.
/// <para>
/// <c>APPROVED</c>: User has approved and verified their employment.
/// </para>
/// <para>
/// <c>NO_EMPLOYERS_FOUND</c>: We attempted, but were unable to find any employment in the connected account.
/// </para>
/// <para>
/// <c>EMPLOYER_NOT_LISTED</c>: The user explicitly indicated that they did not see their current or previous employer in the list of employer names found.
/// </para>
/// <para>
/// <c>STARTED</c>: The user began the bank employment portion of the link flow.
/// </para>
/// <para>
/// <c>INTERNAL_ERROR</c>: The user encountered an internal error.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CreditSessionBankEmploymentStatus>))]
public sealed record CreditSessionBankEmploymentStatus : StringEnum<CreditSessionBankEmploymentStatus>
{
    private CreditSessionBankEmploymentStatus(string value) : base(value)
    {
    }

    public static readonly CreditSessionBankEmploymentStatus Approved = new("APPROVED");

    public static readonly CreditSessionBankEmploymentStatus NoEmployersFound = new("NO_EMPLOYERS_FOUND");

    public static readonly CreditSessionBankEmploymentStatus EmployerNotListed = new("EMPLOYER_NOT_LISTED");

    public static readonly CreditSessionBankEmploymentStatus Started = new("STARTED");

    public static readonly CreditSessionBankEmploymentStatus InternalError = new("INTERNAL_ERROR");

    public static CreditSessionBankEmploymentStatus FromValue(string value) => FromValueCore(value);
}

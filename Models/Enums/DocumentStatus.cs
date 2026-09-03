using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// An outcome status for this specific document submission. Distinct from the overall <c>documentary_verification.status</c> that summarizes the verification outcome from one or more documents.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DocumentStatus>))]
public sealed record DocumentStatus : StringEnum<DocumentStatus>
{
    private DocumentStatus(string value) : base(value)
    {
    }

    public static readonly DocumentStatus Success = new("success");

    public static readonly DocumentStatus Failed = new("failed");

    public static readonly DocumentStatus ManuallyApproved = new("manually_approved");

    public static DocumentStatus FromValue(string value) => FromValueCore(value);
}

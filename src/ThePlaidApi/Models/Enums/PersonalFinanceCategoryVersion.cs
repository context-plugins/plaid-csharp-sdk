using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Indicates which version of the personal finance category taxonomy is being used. <see href="https://plaid.com/documents/pfc-taxonomy-all.csv">View PFCv2 and PFCv1 taxonomies</see>.
/// <para>
/// If you enabled Transactions or Enrich before December 3, 2025 you will receive the <c>v1</c> taxonomy by default and may request <c>v2</c> by explicitly setting this field to <c>v2</c> in the request.
/// </para>
/// <para>
/// If you enabled Transactions or Enrich on or after December 3, 2025, you may only receive the <c>v2</c> taxonomy.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PersonalFinanceCategoryVersion>))]
public sealed record PersonalFinanceCategoryVersion : OpenStringEnum<PersonalFinanceCategoryVersion>
{
    private PersonalFinanceCategoryVersion(string value) : base(value)
    {
    }

    public static readonly PersonalFinanceCategoryVersion V1 = new("v1");

    public static readonly PersonalFinanceCategoryVersion V2 = new("v2");

    public TResult Match<TResult>(Func<TResult> onV1, Func<TResult> onV2, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == V1 => onV1(),
            _ when this == V2 => onV2(),
            _ => otherwise(Value)
        };

    public void Match(Action onV1, Action onV2, Action<string> otherwise)
    {
        if (this == V1) onV1();
        else if (this == V2) onV2();
        else otherwise(Value);
    }
}

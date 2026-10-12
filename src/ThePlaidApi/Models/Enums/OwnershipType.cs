using System;
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
public sealed record OwnershipType : OpenStringEnum<OwnershipType>
{
    private OwnershipType(string value) : base(value)
    {
    }

    public static readonly OwnershipType Individual = new("individual");

    public static readonly OwnershipType Joint = new("joint");

    public static readonly OwnershipType Association = new("association");

    public static readonly OwnershipType Trust = new("trust");

    public TResult Match<TResult>(Func<TResult> onIndividual,
        Func<TResult> onJoint,
        Func<TResult> onAssociation,
        Func<TResult> onTrust,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Individual => onIndividual(),
            _ when this == Joint => onJoint(),
            _ when this == Association => onAssociation(),
            _ when this == Trust => onTrust(),
            _ => otherwise(Value)
        };

    public void Match(Action onIndividual,
        Action onJoint,
        Action onAssociation,
        Action onTrust,
        Action<string> otherwise)
    {
        if (this == Individual) onIndividual();
        else if (this == Joint) onJoint();
        else if (this == Association) onAssociation();
        else if (this == Trust) onTrust();
        else otherwise(Value);
    }
}

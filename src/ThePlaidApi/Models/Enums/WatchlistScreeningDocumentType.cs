using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The kind of official document represented by this object.
/// <para>
/// <c>birth_certificate</c> - A certificate of birth
/// </para>
/// <para>
/// <c>drivers_license</c> - A license to operate a motor vehicle
/// </para>
/// <para>
/// <c>immigration_number</c> - Immigration or residence documents
/// </para>
/// <para>
/// <c>military_id</c> - Identification issued by a military group
/// </para>
/// <para>
/// <c>other</c> - Any document not covered by other categories
/// </para>
/// <para>
/// <c>passport</c> - An official passport issued by a government
/// </para>
/// <para>
/// <c>personal_identification</c> - Any generic personal identification that is not covered by other categories
/// </para>
/// <para>
/// <c>ration_card</c> - Identification that entitles the holder to rations
/// </para>
/// <para>
/// <c>ssn</c> - United States Social Security Number
/// </para>
/// <para>
/// <c>student_id</c> - Identification issued by an educational institution
/// </para>
/// <para>
/// <c>tax_id</c> - Identification issued for the purpose of collecting taxes
/// </para>
/// <para>
/// <c>travel_document</c> - Visas, entry permits, refugee documents, etc.
/// </para>
/// <para>
/// <c>voter_id</c> - Identification issued for the purpose of voting
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<WatchlistScreeningDocumentType>))]
public sealed record WatchlistScreeningDocumentType : OpenStringEnum<WatchlistScreeningDocumentType>
{
    private WatchlistScreeningDocumentType(string value) : base(value)
    {
    }

    public static readonly WatchlistScreeningDocumentType BirthCertificate = new("birth_certificate");

    public static readonly WatchlistScreeningDocumentType DriversLicense = new("drivers_license");

    public static readonly WatchlistScreeningDocumentType ImmigrationNumber = new("immigration_number");

    public static readonly WatchlistScreeningDocumentType MilitaryId = new("military_id");

    public static readonly WatchlistScreeningDocumentType Other = new("other");

    public static readonly WatchlistScreeningDocumentType Passport = new("passport");

    public static readonly WatchlistScreeningDocumentType PersonalIdentification = new("personal_identification");

    public static readonly WatchlistScreeningDocumentType RationCard = new("ration_card");

    public static readonly WatchlistScreeningDocumentType Ssn = new("ssn");

    public static readonly WatchlistScreeningDocumentType StudentId = new("student_id");

    public static readonly WatchlistScreeningDocumentType TaxId = new("tax_id");

    public static readonly WatchlistScreeningDocumentType TravelDocument = new("travel_document");

    public static readonly WatchlistScreeningDocumentType VoterId = new("voter_id");

    public TResult Match<TResult>(Func<TResult> onBirthCertificate,
        Func<TResult> onDriversLicense,
        Func<TResult> onImmigrationNumber,
        Func<TResult> onMilitaryId,
        Func<TResult> onOther,
        Func<TResult> onPassport,
        Func<TResult> onPersonalIdentification,
        Func<TResult> onRationCard,
        Func<TResult> onSsn,
        Func<TResult> onStudentId,
        Func<TResult> onTaxId,
        Func<TResult> onTravelDocument,
        Func<TResult> onVoterId,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == BirthCertificate => onBirthCertificate(),
            _ when this == DriversLicense => onDriversLicense(),
            _ when this == ImmigrationNumber => onImmigrationNumber(),
            _ when this == MilitaryId => onMilitaryId(),
            _ when this == Other => onOther(),
            _ when this == Passport => onPassport(),
            _ when this == PersonalIdentification => onPersonalIdentification(),
            _ when this == RationCard => onRationCard(),
            _ when this == Ssn => onSsn(),
            _ when this == StudentId => onStudentId(),
            _ when this == TaxId => onTaxId(),
            _ when this == TravelDocument => onTravelDocument(),
            _ when this == VoterId => onVoterId(),
            _ => otherwise(Value)
        };

    public void Match(Action onBirthCertificate,
        Action onDriversLicense,
        Action onImmigrationNumber,
        Action onMilitaryId,
        Action onOther,
        Action onPassport,
        Action onPersonalIdentification,
        Action onRationCard,
        Action onSsn,
        Action onStudentId,
        Action onTaxId,
        Action onTravelDocument,
        Action onVoterId,
        Action<string> otherwise)
    {
        if (this == BirthCertificate) onBirthCertificate();
        else if (this == DriversLicense) onDriversLicense();
        else if (this == ImmigrationNumber) onImmigrationNumber();
        else if (this == MilitaryId) onMilitaryId();
        else if (this == Other) onOther();
        else if (this == Passport) onPassport();
        else if (this == PersonalIdentification) onPersonalIdentification();
        else if (this == RationCard) onRationCard();
        else if (this == Ssn) onSsn();
        else if (this == StudentId) onStudentId();
        else if (this == TaxId) onTaxId();
        else if (this == TravelDocument) onTravelDocument();
        else if (this == VoterId) onVoterId();
        else otherwise(Value);
    }
}

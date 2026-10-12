using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// An object representing an end user's 1099 tax form
/// </summary>
public record Credit1099
{
    /// <summary>
    /// An identifier of the document referenced by the document metadata.
    /// </summary>
    [JsonPropertyName("document_id")]
    public required string? DocumentId { get; init; }

    /// <summary>
    /// Object representing metadata pertaining to the document.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("document_metadata")]
    public CreditDocumentMetadata? DocumentMetadata { get; init; }

    /// <summary>
    /// Form 1099 Type
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("form_1099_type")]
    public Form1099Type? Form1099Type { get; init; }

    /// <summary>
    /// An object representing a recipient used in both 1099-K and 1099-MISC tax documents.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recipient")]
    public Credit1099Recipient? Recipient { get; init; }

    /// <summary>
    /// An object representing a payer used by 1099-MISC tax documents.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payer")]
    public Credit1099Payer? Payer { get; init; }

    /// <summary>
    /// An object representing a filer used by 1099-K tax documents.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("filer")]
    public Credit1099Filer? Filer { get; init; }

    /// <summary>
    /// Tax year of the tax form.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tax_year")]
    public string? TaxYear { get; init; }

    /// <summary>
    /// Amount in rent by payer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rents")]
    public double? Rents { get; init; }

    /// <summary>
    /// Amount in royalties by payer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("royalties")]
    public double? Royalties { get; init; }

    /// <summary>
    /// Amount in other income by payer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("other_income")]
    public double? OtherIncome { get; init; }

    /// <summary>
    /// Amount of federal income tax withheld from payer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("federal_income_tax_withheld")]
    public double? FederalIncomeTaxWithheld { get; init; }

    /// <summary>
    /// Amount of fishing boat proceeds from payer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fishing_boat_proceeds")]
    public double? FishingBoatProceeds { get; init; }

    /// <summary>
    /// Amount of medical and healthcare payments from payer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("medical_and_healthcare_payments")]
    public double? MedicalAndHealthcarePayments { get; init; }

    /// <summary>
    /// Amount of nonemployee compensation from payer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nonemployee_compensation")]
    public double? NonemployeeCompensation { get; init; }

    /// <summary>
    /// Amount of substitute payments made by payer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("substitute_payments_in_lieu_of_dividends_or_interest")]
    public double? SubstitutePaymentsInLieuOfDividendsOrInterest { get; init; }

    /// <summary>
    /// Whether or not payer made direct sales over $5000 of consumer products.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payer_made_direct_sales_of_5000_or_more_of_consumer_products_to_buyer")]
    public string? PayerMadeDirectSalesOf5000OrMoreOfConsumerProductsToBuyer { get; init; }

    /// <summary>
    /// Amount of crop insurance proceeds.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("crop_insurance_proceeds")]
    public double? CropInsuranceProceeds { get; init; }

    /// <summary>
    /// Amount of golden parachute payments made by payer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("excess_golden_parachute_payments")]
    public double? ExcessGoldenParachutePayments { get; init; }

    /// <summary>
    /// Amount of gross proceeds paid to an attorney by payer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gross_proceeds_paid_to_an_attorney")]
    public double? GrossProceedsPaidToAnAttorney { get; init; }

    /// <summary>
    /// Amount of 409A deferrals earned by payer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("section_409a_deferrals")]
    public double? Section409ADeferrals { get; init; }

    /// <summary>
    /// Amount of 409A income earned by payer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("section_409a_income")]
    public double? Section409AIncome { get; init; }

    /// <summary>
    /// Amount of state tax withheld of payer for primary state.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("state_tax_withheld")]
    public double? StateTaxWithheld { get; init; }

    /// <summary>
    /// Amount of state tax withheld of payer for secondary state.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("state_tax_withheld_lower")]
    public double? StateTaxWithheldLower { get; init; }

    /// <summary>
    /// Primary state ID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payer_state_number")]
    public string? PayerStateNumber { get; init; }

    /// <summary>
    /// Secondary state ID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payer_state_number_lower")]
    public string? PayerStateNumberLower { get; init; }

    /// <summary>
    /// State income reported for primary state.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("state_income")]
    public double? StateIncome { get; init; }

    /// <summary>
    /// State income reported for secondary state.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("state_income_lower")]
    public double? StateIncomeLower { get; init; }

    /// <summary>
    /// One of the values will be provided Payment card Third party network
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactions_reported")]
    public string? TransactionsReported { get; init; }

    /// <summary>
    /// Name of the PSE (Payment Settlement Entity).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pse_name")]
    public string? PseName { get; init; }

    /// <summary>
    /// Formatted (XXX) XXX-XXXX. Phone number of the PSE (Payment Settlement Entity).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pse_telephone_number")]
    public string? PseTelephoneNumber { get; init; }

    /// <summary>
    /// Gross amount reported.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gross_amount")]
    public double? GrossAmount { get; init; }

    /// <summary>
    /// Amount in card not present transactions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("card_not_present_transaction")]
    public double? CardNotPresentTransaction { get; init; }

    /// <summary>
    /// Merchant category of filer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchant_category_code")]
    public string? MerchantCategoryCode { get; init; }

    /// <summary>
    /// Number of payment transactions made.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("number_of_payment_transactions")]
    public string? NumberOfPaymentTransactions { get; init; }

    /// <summary>
    /// Amount reported for January.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("january_amount")]
    public double? JanuaryAmount { get; init; }

    /// <summary>
    /// Amount reported for February.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("february_amount")]
    public double? FebruaryAmount { get; init; }

    /// <summary>
    /// Amount reported for March.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("march_amount")]
    public double? MarchAmount { get; init; }

    /// <summary>
    /// Amount reported for April.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("april_amount")]
    public double? AprilAmount { get; init; }

    /// <summary>
    /// Amount reported for May.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("may_amount")]
    public double? MayAmount { get; init; }

    /// <summary>
    /// Amount reported for June.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("june_amount")]
    public double? JuneAmount { get; init; }

    /// <summary>
    /// Amount reported for July.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("july_amount")]
    public double? JulyAmount { get; init; }

    /// <summary>
    /// Amount reported for August.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("august_amount")]
    public double? AugustAmount { get; init; }

    /// <summary>
    /// Amount reported for September.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("september_amount")]
    public double? SeptemberAmount { get; init; }

    /// <summary>
    /// Amount reported for October.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("october_amount")]
    public double? OctoberAmount { get; init; }

    /// <summary>
    /// Amount reported for November.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("november_amount")]
    public double? NovemberAmount { get; init; }

    /// <summary>
    /// Amount reported for December.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("december_amount")]
    public double? DecemberAmount { get; init; }

    /// <summary>
    /// Primary state of business.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("primary_state")]
    public string? PrimaryState { get; init; }

    /// <summary>
    /// Secondary state of business.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secondary_state")]
    public string? SecondaryState { get; init; }

    /// <summary>
    /// Primary state ID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("primary_state_id")]
    public string? PrimaryStateId { get; init; }

    /// <summary>
    /// Secondary state ID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secondary_state_id")]
    public string? SecondaryStateId { get; init; }

    /// <summary>
    /// State income tax reported for primary state.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("primary_state_income_tax")]
    public double? PrimaryStateIncomeTax { get; init; }

    /// <summary>
    /// State income tax reported for secondary state.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secondary_state_income_tax")]
    public double? SecondaryStateIncomeTax { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

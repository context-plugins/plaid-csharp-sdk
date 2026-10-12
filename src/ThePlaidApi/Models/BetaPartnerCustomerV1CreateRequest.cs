using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Request schema for <c>/beta/partner/customer/v1/create</c>.
/// </summary>
public record BetaPartnerCustomerV1CreateRequest
{
    /// <summary>
    /// Your Plaid API <c>client_id</c>. The <c>client_id</c> is required and may be provided either in the <c>PLAID-CLIENT-ID</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_id")]
    public string? ClientId { get; init; }

    /// <summary>
    /// Your Plaid API <c>secret</c>. The <c>secret</c> is required and may be provided either in the <c>PLAID-SECRET</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secret")]
    public string? Secret { get; init; }

    /// <summary>
    /// The company name of the end customer being created. This will be used to display the end customer in the Plaid Dashboard. It will not be shown to end users.
    /// </summary>
    [JsonPropertyName("company_name")]
    public required string CompanyName { get; init; }

    /// <summary>
    /// Denotes whether or not the partner has completed attestation of diligence for the end customer to be created.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_diligence_attested")]
    public bool? IsDiligenceAttested { get; init; }

    /// <summary>
    /// The products to be enabled for the end customer. If empty or <c>null</c>, this field will default to the products enabled for the reseller at the time this endpoint is called.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("products")]
    public IReadOnlyList<Products>? Products { get; init; }

    /// <summary>
    /// If <c>true</c>, the end customer's default Link customization will be set to match the partner's. You can always change the end customer's Link customization in the Plaid Dashboard. See the <see href="https://plaid.com/docs/link/customization/">Link Customization docs</see> for more information. If you require the ability to programmatically create end customers using multiple different Link customization profiles, contact your Plaid account manager for assistance.
    /// <para>
    /// Important: Data Transparency Messaging (DTM) use cases will not be copied to the end customer's Link customization unless the <b>Publish changes</b> button is clicked after the use cases are applied. Link will not work in Production unless the end customer's DTM use cases are configured. For more details, see <see href="https://plaid.com/docs/link/data-transparency-messaging-migration-guide/">Data Transparency Messaging</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("create_link_customization")]
    public bool? CreateLinkCustomization { get; init; }

    /// <summary>
    /// Base64-encoded representation of the end customer's logo. Must be a PNG of size 1024x1024 under 4MB. The logo will be shared with financial institutions and shown to the end user during Link flows. A logo is required if <c>create_link_customization</c> is <c>true</c>. If <c>create_link_customization</c> is <c>false</c> and the logo is omitted, the partner's logo will be used if one exists, otherwise a stock logo will be used.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("logo")]
    public string? Logo { get; init; }

    /// <summary>
    /// The end customer's legal name. This will be shared with financial institutions as part of the OAuth registration process. It will not be shown to end users.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("legal_entity_name")]
    public string? LegalEntityName { get; init; }

    /// <summary>
    /// The end customer's website.
    /// </summary>
    [JsonPropertyName("website")]
    public required string Website { get; init; }

    /// <summary>
    /// The name of the end customer's application. This will be shown to end users when they go through the Plaid Link flow. The application name must be unique and cannot match the name of another application already registered with Plaid.
    /// </summary>
    [JsonPropertyName("application_name")]
    public required string ApplicationName { get; init; }

    /// <summary>
    /// The technical contact for the end customer. Defaults to partner's technical contact if omitted.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("technical_contact")]
    public PartnerEndCustomerTechnicalContact? TechnicalContact { get; init; }

    /// <summary>
    /// The billing contact for the end customer. Defaults to partner's billing contact if omitted.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billing_contact")]
    public PartnerEndCustomerBillingContact? BillingContact { get; init; }

    /// <summary>
    /// This information is public. Users of your app will see this information when managing connections between your app and their bank accounts in Plaid Portal. Defaults to partner's customer support info if omitted. This field is mandatory for partners whose Plaid accounts were created after November 26, 2024 and will be mandatory for all partners by the 1033 compliance deadline.
    /// </summary>
    [JsonPropertyName("customer_support_info")]
    public required PartnerEndCustomerCustomerSupportInfo CustomerSupportInfo { get; init; }

    /// <summary>
    /// The end customer's address.
    /// </summary>
    [JsonPropertyName("address")]
    public required PartnerEndCustomerAddress Address { get; init; }

    /// <summary>
    /// A list of URIs indicating the destination(s) where a user can be forwarded after completing the Link flow; used to support OAuth authentication flows when launching Link in the browser or another app. URIs should not contain any query parameters. When used in Production, URIs must use https. To modify redirect URIs for an end customer after creating them, go to the end customer's <see href="https://dashboard.plaid.com/team/api">API page</see> in the Dashboard.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("redirect_uris")]
    public IReadOnlyList<string>? RedirectUris { get; init; }

    /// <summary>
    /// The bank addendum acceptance for the end customer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bank_addendum_acceptance")]
    public PartnerEndCustomerBankAddendumAcceptance? BankAddendumAcceptance { get; init; }

    /// <summary>
    /// The questionnaires for the end customer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("questionnaires")]
    public PartnerEndCustomerQuestionnaires? Questionnaires { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

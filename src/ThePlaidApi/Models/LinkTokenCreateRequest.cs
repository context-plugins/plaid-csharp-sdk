using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// LinkTokenCreateRequest defines the request schema for <c>/link/token/create</c>
/// </summary>
public record LinkTokenCreateRequest
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
    /// The name of your application, as it should be displayed in Link. Maximum length of 30 characters. If a value longer than 30 characters is provided, Link will display "This Application" instead.
    /// </summary>
    [JsonPropertyName("client_name")]
    [MinLength(1)]
    public required string ClientName { get; init; }

    /// <summary>
    /// The language that Link should be displayed in. When initializing with Identity Verification, this field is not used; for more details, see <see href="https://plaid.com/docs/identity-verification/#supported-languages">Identity Verification supported languages</see>.
    /// <para>
    /// Supported languages are:
    /// - Danish (<c>'da'</c>)
    /// - Dutch (<c>'nl'</c>)
    /// - English (<c>'en'</c>)
    /// - Estonian (<c>'et'</c>)
    /// - French (<c>'fr'</c>)
    /// - German (<c>'de'</c>)
    /// - Hindi (<c>'hi'</c>)
    /// - Italian (<c>'it'</c>)
    /// - Latvian (<c>'lv'</c>)
    /// - Lithuanian (<c>'lt'</c>)
    /// - Norwegian (<c>'no'</c>)
    /// - Polish (<c>'pl'</c>)
    /// - Portuguese (<c>'pt'</c>)
    /// - Romanian (<c>'ro'</c>)
    /// - Spanish (<c>'es'</c>)
    /// - Swedish (<c>'sv'</c>)
    /// - Vietnamese (<c>'vi'</c>)
    /// </para>
    /// <para>
    /// When using a Link customization, the language configured here must match the setting in the customization, or the customization will not be applied.
    /// </para>
    /// </summary>
    [JsonPropertyName("language")]
    [MinLength(1)]
    public required string Language { get; init; }

    /// <summary>
    /// Specify an array of Plaid-supported country codes using the ISO-3166-1 alpha-2 country code standard. Institutions from all listed countries will be shown. For a complete mapping of supported products by country, see https://support.plaid.com/hc/en-us/articles/27895826947735-What-Plaid-products-are-supported-in-each-country-and-region. For access to additional countries beyond what you have been approved for, <see href="https://plaid.com/contact/">contact sales</see>, your account manager, or support.
    /// <para>
    /// If using Identity Verification, <c>country_codes</c> should be set to the country where your company is based, not the country where your user is located. For all other products, <c>country_codes</c> represents the location of your user's financial institution.
    /// </para>
    /// <para>
    /// If Link is launched with multiple country codes, only products that you are enabled for in all countries will be used by Link. While all countries are enabled by default in Sandbox, in Production only the countries you have requested access for are shown. To request access to additional countries, <see href="https://dashboard.plaid.com/support/new/product-and-development/product-troubleshooting/request-product-access">file a product access Support ticket</see> via the Plaid dashboard.
    /// </para>
    /// <para>
    /// If using a Link customization, make sure the country codes in the customization match those specified in <c>country_codes</c>, or the customization may not be applied.
    /// </para>
    /// <para>
    /// If using the Auth features Instant Match, Instant Micro-deposits, Same-Day Micro-deposits, Automated Micro-deposits, or Database Auth, <c>country_codes</c> must be set to <c>['US']</c>.
    /// </para>
    /// </summary>
    [JsonPropertyName("country_codes")]
    [MinLength(1)]
    public required IReadOnlyList<CountryCode> CountryCodes { get; init; }

    /// <summary>
    /// An object specifying information about the end user who will be linking their account. <b>Required</b> if <c>user_id</c> isn't included.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user")]
    public LinkTokenCreateRequestUser? User { get; init; }

    /// <summary>
    /// A <c>user_id</c> generated using <c>/user/create</c>. Required for integrations that began using Plaid Protect, Multi-Item Link, or Plaid Check Consumer Report after December 10, 2025. For more details, see <see href="https://plaid.com/docs/api/users/user-apis">New User APIs</see>. One of either the <c>user_id</c> or the <c>user</c> field is required.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user_id")]
    public string? UserId { get; init; }

    /// <summary>
    /// List of Plaid product(s) that the linked Item must support. If launching Link in update mode, should be omitted (unless you are using update mode to add a credit product, such as Assets, Statements, Income, or Plaid Check Consumer Report, to an existing Item); at least one <c>product</c> is required otherwise.
    /// <para>
    /// To maximize the number of institutions and accounts available, initialize Link with the minimal product set required for your use case, as the products specified will limit which institutions and account types will be available to your users in Link. Only institutions that support *all* requested products can be selected; if a user attempts to select an institution that does not support a listed product, a "Connectivity not supported" error message will appear in Link. For each specified product, the Item connected by the user must contain at least one compatible account. For details on compatible product / account type combinations, see <see href="https://plaid.com/docs/api/accounts/#account-type--product-support-matrix">the account type/product support matrix</see>.
    /// </para>
    /// <para>
    /// To add products without limiting the institution list or account types, use the <see href="https://plaid.com/docs/api/link/#link-token-create-request-optional-products"><c>optional_products</c></see> or  <see href="https://plaid.com/docs/api/link/#link-token-create-request-required-if-supported-products"><c>required_if_supported_products</c></see> fields. Products can also be added to an Item by calling the product endpoint after obtaining an access token; this may require the product to be listed in the <see href="https://plaid.com/docs/api/link/#link-token-create-request-additional-consented-products"><c>additional_consented_products</c></see> array. For details, see <see href="https://plaid.com/docs/link/initializing-products/">Choosing when to initialize products</see>.
    /// </para>
    /// <para>
    /// <c>balance</c> is *not* a valid value, the Balance product does not require explicit initialization and will automatically be initialized when any other product is initialized.
    /// </para>
    /// <para>
    /// If launching Link with CRA products, <c>cra_base_report</c> is required and must be included in the <c>products</c> array.
    /// </para>
    /// <para>
    /// Note that, unless you have opted to disable Instant Match support, institutions that support Instant Match will also be shown in Link if <c>auth</c> is specified as a product, even though these institutions do not contain <c>auth</c> in their product array.
    /// </para>
    /// <para>
    /// In Production, you will be billed for each product that you specify when initializing Link. Note that a product cannot be removed from an Item once the Item has been initialized with that product. To stop billing on an Item for subscription-based products, such as Liabilities, Investments, and Transactions, remove the Item via <c>/item/remove</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("products")]
    public IReadOnlyList<Products>? Products { get; init; }

    /// <summary>
    /// List of Plaid product(s) you wish to use only if the institution and account(s) selected by the user support the product. Institutions that do not support these products will still be shown in Link. The products will only be extracted and billed if the user selects an institution and account type that supports them.
    /// <para>
    /// There should be no overlap between this array and the <c>products</c>, <c>optional_products</c>, or <c>additional_consented_products</c> arrays. The <c>products</c> array must have at least one product.
    /// </para>
    /// <para>
    /// For more details on using this feature, see <see href="https://plaid.com/docs/link/initializing-products/#required-if-supported-products">Required if Supported Products</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("required_if_supported_products")]
    public IReadOnlyList<Products>? RequiredIfSupportedProducts { get; init; }

    /// <summary>
    /// List of Plaid product(s) that will enhance the consumer's use case, but that your app can function without. Plaid will attempt to fetch data for these products on a best-effort basis, and failure to support these products will not affect Item creation.
    /// <para>
    /// There should be no overlap between this array and the <c>products</c>, <c>required_if_supported_products</c>, or <c>additional_consented_products</c> arrays. The <c>products</c> array must have at least one product.
    /// </para>
    /// <para>
    /// For more details on using this feature, see <see href="https://plaid.com/docs/link/initializing-products/#optional-products">Optional Products</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("optional_products")]
    public IReadOnlyList<Products>? OptionalProducts { get; init; }

    /// <summary>
    /// List of additional Plaid product(s) you wish to collect consent for to support your use case. These products will not be billed until you start using them by calling the relevant endpoints.
    /// <para>
    /// <c>balance</c> is *not* a valid value, the Balance product does not require explicit initialization and will automatically have consent collected.
    /// </para>
    /// <para>
    /// Institutions that do not support these products will still be shown in Link.
    /// </para>
    /// <para>
    /// There should be no overlap between this array and the <c>products</c> or <c>required_if_supported_products</c> arrays.
    /// </para>
    /// <para>
    /// If you include <c>signal</c> in <c>additional_consented_products</c>, you will need to call <see href="https://plaid.com/docs/api/products/signal/#signalprepare"><c>/signal/prepare</c></see> before calling <c>/signal/evaluate</c> for the first time on an Item in order to get the most accurate results. For more details, see <see href="https://plaid.com/docs/api/products/signal/#signalprepare"><c>/signal/prepare</c></see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("additional_consented_products")]
    public IReadOnlyList<Products>? AdditionalConsentedProducts { get; init; }

    /// <summary>
    /// The destination URL to which any webhooks should be sent. Note that webhooks for Payment Initiation (e-wallet transactions only), Transfer, Bank Transfer (including Auth micro-deposit notification webhooks), Monitor, and Identity Verification are configured via the Dashboard instead. In update mode, this field will not have an effect; to update the webhook receiver endpoint for an existing Item, use <c>/item/webhook/update</c> instead.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("webhook")]
    public string? Webhook { get; init; }

    /// <summary>
    /// The <c>access_token</c> associated with the Item to update or reference, used when updating, modifying, or accessing an existing <c>access_token</c>. Used when launching Link in update mode, when completing the Same-Day Micro-deposit (manual) flow, or (optionally) when initializing Link for a returning user as part of the Transfer UI flow.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("access_token")]
    [MinLength(1)]
    public string? AccessToken { get; init; }

    /// <summary>
    /// A list of access tokens associated with the items to update in Link update mode for the Assets product. Using this instead of the <c>access_token</c> field allows the updating of multiple items at once. This feature is in closed beta, please contact your account manager for more info.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("access_tokens")]
    public IReadOnlyList<string>? AccessTokens { get; init; }

    /// <summary>
    /// The name of the Link customization from the Plaid Dashboard to be applied to Link. If not specified, the <c>default</c> customization will be used. When using a Link customization, the language in the customization must match the language selected via the <c>language</c> parameter, and the countries in the customization should match the country codes selected via <c>country_codes</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("link_customization_name")]
    public string? LinkCustomizationName { get; init; }

    /// <summary>
    /// Enum representing the desired appearance mode for Link, used to force light or dark modes or set Link to change depending on user system settings. Currently in closed beta.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("appearance_mode")]
    public LinkTokenCreateRequestAppearanceMode? AppearanceMode { get; init; }

    /// <summary>
    /// A URI indicating the destination where a user should be forwarded after completing the Link flow; used to support OAuth authentication flows when launching Link in the browser or another app. The <c>redirect_uri</c> should not contain any query parameters. When used in Production, must be an https URI. Note that any redirect URI must also be added to the Allowed redirect URIs list in the <see href="https://dashboard.plaid.com/team/api">developer dashboard</see>. If initializing on Android, <c>android_package_name</c> must be specified instead and <c>redirect_uri</c> should be left blank.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("redirect_uri")]
    public string? RedirectUri { get; init; }

    /// <summary>
    /// The name of your app's Android package. Required if using the <c>link_token</c> to initialize Link on Android. Any package name specified here must also be added to the Allowed Android package names setting on the <see href="https://dashboard.plaid.com/team/api">developer dashboard</see>. When creating a <c>link_token</c> for initializing Link on other platforms, <c>android_package_name</c> must be left blank and <c>redirect_uri</c> should be used instead.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("android_package_name")]
    public string? AndroidPackageName { get; init; }

    /// <summary>
    /// A map containing data used to highlight institutions in Link.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("institution_data")]
    public LinkTokenCreateInstitutionData? InstitutionData { get; init; }

    /// <summary>
    /// A map containing data to pass in for the Card Switch flow.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("card_switch")]
    public LinkTokenCreateCardSwitch? CardSwitch { get; init; }

    /// <summary>
    /// By default, Link will provide limited account filtering: it will only display Institutions that are compatible with all products supplied in the <c>products</c> parameter of <c>/link/token/create</c>, and, if <c>auth</c> is specified in the <c>products</c> array, will also filter out accounts other than <c>checking</c>, <c>savings</c>, and <c>cash management</c> accounts on the Account Select pane. You can further limit the accounts shown in Link by using <c>account_filters</c> to specify the account subtypes to be shown in Link. Only the specified subtypes will be shown. This filtering applies to both the Account Select view (if enabled) and the Institution Select view. Institutions that do not support the selected subtypes will be omitted from Link. To indicate that all subtypes should be shown, use the value <c>"all"</c>. If the <c>account_filters</c> filter is used, any account type for which a filter is not specified will be entirely omitted from Link. For a full list of valid types and subtypes, see the <see href="https://plaid.com/docs/api/accounts#account-type-schema">Account schema</see>.
    /// <para>
    /// The filter may or may not impact the list of accounts shown by the institution in the OAuth account selection flow, depending on the specific institution. If the user selects excluded account subtypes in the OAuth flow, these accounts will not be added to the Item. If the user selects only excluded account subtypes, the link attempt will fail and the user will be prompted to try again.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account_filters")]
    public LinkTokenAccountFilters? AccountFilters { get; init; }

    /// <summary>
    /// Configuration parameters for EU flows
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eu_config")]
    public LinkTokenEuConfig? EuConfig { get; init; }

    /// <summary>
    /// Used for certain legacy use cases
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("institution_id")]
    public string? InstitutionId { get; init; }

    /// <summary>
    /// Specifies options for initializing Link for use with the Pay By Bank flow. This is an optional field to configure the user experience, and currently requires the amount field to be set.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payment_configuration")]
    public LinkTokenCreateRequestPaymentConfiguration? PaymentConfiguration { get; init; }

    /// <summary>
    /// Specifies options for initializing Link for use with the Payment Initiation (Europe) product. This field is required if <c>payment_initiation</c> is included in the <c>products</c> array. Either <c>payment_id</c> or <c>consent_id</c> must be provided.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payment_initiation")]
    public LinkTokenCreateRequestPaymentInitiation? PaymentInitiation { get; init; }

    /// <summary>
    /// Specifies options for initializing Link for use with the Employment product. This field is required if <c>employment</c> is included in the <c>products</c> array.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("employment")]
    public LinkTokenCreateRequestEmployment? Employment { get; init; }

    /// <summary>
    /// Specifies options for initializing Link for use with the Income product. This field is required if <c>income_verification</c> is included in the <c>products</c> array.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("income_verification")]
    public LinkTokenCreateRequestIncomeVerification? IncomeVerification { get; init; }

    /// <summary>
    /// Specifies options for initializing Link for use with the Base Report product. This field is required if <c>assets</c> is included in the <c>products</c> array and the client is CRA-enabled.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("base_report")]
    public LinkTokenCreateRequestBaseReport? BaseReport { get; init; }

    /// <summary>
    /// Specifies options for initializing Link for use with the Credit Partner Insights product.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("credit_partner_insights")]
    public LinkTokenCreateRequestCreditPartnerInsights? CreditPartnerInsights { get; init; }

    /// <summary>
    /// Specifies options for initializing Link for use with Plaid Check products
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cra_options")]
    public LinkTokenCreateRequestCraOptions? CraOptions { get; init; }

    /// <summary>
    /// Describes the reason you are generating a Consumer Report for this user. When calling <c>/link/token/create</c>, this field is required when using Plaid Check (CRA) products; invalid if not using Plaid Check (CRA) products.
    /// <para>
    /// <c>ACCOUNT_REVIEW_CREDIT</c>: In connection with a consumer credit transaction for the review or collection of an account pursuant to FCRA Section 604(a)(3)(A).
    /// </para>
    /// <para>
    /// <c>ACCOUNT_REVIEW_NON_CREDIT</c>: For a legitimate business need of the information to review a non-credit account provided primarily for personal, family, or household purposes to determine whether the consumer continues to meet the terms of the account pursuant to FCRA Section 604(a)(3)(F)(2).
    /// </para>
    /// <para>
    /// <c>EXTENSION_OF_CREDIT</c>: In connection with a credit transaction initiated by and involving the consumer pursuant to FCRA Section 604(a)(3)(A).
    /// </para>
    /// <para>
    /// <c>LEGITIMATE_BUSINESS_NEED_TENANT_SCREENING</c>: For a legitimate business need in connection with a business transaction initiated by the consumer primarily for personal, family, or household purposes in connection with a property rental assessment pursuant to FCRA Section 604(a)(3)(F)(i).
    /// </para>
    /// <para>
    /// <c>LEGITIMATE_BUSINESS_NEED_OTHER</c>: For a legitimate business need in connection with a business transaction made primarily for personal, family, or household initiated by the consumer pursuant to FCRA Section 604(a)(3)(F)(i).
    /// </para>
    /// <para>
    /// <c>WRITTEN_INSTRUCTION_PREQUALIFICATION</c>: In accordance with the written instructions of the consumer pursuant to FCRA Section 604(a)(2), to evaluate an application's profile to make an offer to the consumer.
    /// </para>
    /// <para>
    /// <c>WRITTEN_INSTRUCTION_OTHER</c>: In accordance with the written instructions of the consumer pursuant to FCRA Section 604(a)(2), such as when an individual agrees to act as a guarantor or assumes personal liability for a consumer, business, or commercial loan.
    /// </para>
    /// <para>
    /// <c>ELIGIBILITY_FOR_GOVT_BENEFITS</c>:  In connection with an eligibility determination for a government benefit where the entity is required to consider an applicant's financial status pursuant to FCRA Section 604(a)(3)(D).
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("consumer_report_permissible_purpose")]
    public ConsumerReportPermissiblePurpose? ConsumerReportPermissiblePurpose { get; init; }

    /// <summary>
    /// Specifies options for initializing Link for use with the Auth product. This field can be used to enable or disable extended Auth flows for the resulting Link session. Omitting any field will result in a default that can be configured by your account manager. The default behavior described in the documentation is the default behavior that will apply if you have not requested your account manager to apply a different default. If you have enabled the <see href="https://dashboard.plaid.com/account-verification">Dashboard Account Verification pane</see>, the settings enabled there will override any settings in this object.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("auth")]
    public LinkTokenCreateRequestAuth? Auth { get; init; }

    /// <summary>
    /// Specifies options for initializing Link for use with the Transfer product.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transfer")]
    public LinkTokenCreateRequestTransfer? Transfer { get; init; }

    /// <summary>
    /// Specifies options for initializing Link for <see href="https://plaid.com/docs/link/update-mode">update mode</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("update")]
    public LinkTokenCreateRequestUpdate? Update { get; init; }

    /// <summary>
    /// Specifies option for initializing Link for use with the Identity Verification product.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("identity_verification")]
    public LinkTokenCreateRequestIdentityVerification? IdentityVerification { get; init; }

    /// <summary>
    /// Specifies options for initializing Link for use with the Statements product. This field is required for the statements product.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("statements")]
    public LinkTokenCreateRequestStatements? Statements { get; init; }

    /// <summary>
    /// A third party user token associated with the current user.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("third_party_user_token")]
    public string? ThirdPartyUserToken { get; init; }

    /// <summary>
    /// Configuration parameters for the Investments product
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("investments")]
    public LinkTokenInvestments? Investments { get; init; }

    /// <summary>
    /// Configuration parameters for the Investments Move product
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("investments_auth")]
    public LinkTokenInvestmentsAuth? InvestmentsAuth { get; init; }

    /// <summary>
    /// Configuration parameters for Hosted Link. To enable the session for Hosted Link, send this object in the request. It can be empty.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hosted_link")]
    public LinkTokenCreateHostedLink? HostedLink { get; init; }

    /// <summary>
    /// Configuration parameters for the Transactions product
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactions")]
    public LinkTokenTransactions? Transactions { get; init; }

    /// <summary>
    /// Configuration parameters for the Cashflow Report product. Currently in closed beta.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cashflow_report")]
    public LinkTokenCashflowReport? CashflowReport { get; init; }

    /// <summary>
    /// If <c>true</c>, request a CRA connection. Defaults to <c>false</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cra_enabled")]
    public bool? CraEnabled { get; init; }

    /// <summary>
    /// Identity object used to specify document upload
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("identity")]
    public LinkTokenCreateIdentity? Identity { get; init; }

    /// <summary>
    /// If <c>true</c>, indicates that client supports linking FinanceKit / AppleCard items. Defaults to <c>false</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("financekit_supported")]
    public bool? FinancekitSupported { get; init; }

    /// <summary>
    /// If <c>true</c>, enable linking multiple items in the same Link session. Defaults to <c>false</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enable_multi_item_link")]
    public bool? EnableMultiItemLink { get; init; }

    /// <summary>
    /// A user token generated using <c>/user/create</c>. Any Item created during the Link session will be associated with the user. Integrations that began using Plaid Protect, Multi-Item Link, or Plaid Check Consumer Report before December 10, 2025 use this field instead of the <c>user_id</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user_token")]
    public string? UserToken { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

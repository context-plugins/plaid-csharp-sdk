using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// An optional object to filter <c>/asset_report/create</c> results. If provided, must be non-<c>null</c>. The optional <c>user</c> object is required for the report to be eligible for Fannie Mae's Day 1 Certainty program.
/// </summary>
public record AssetReportCreateRequestOptions
{
    /// <summary>
    /// Client-generated identifier, which can be used by lenders to track loan applications.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_report_id")]
    public string? ClientReportId { get; init; }

    /// <summary>
    /// URL to which Plaid will send Assets webhooks, for example when the requested Asset Report is ready.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("webhook")]
    public string? Webhook { get; init; }

    /// <summary>
    /// true to return balance and identity earlier as a fast report. Defaults to false if omitted.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("include_fast_report")]
    public bool? IncludeFastReport { get; init; }

    /// <summary>
    /// Additional information that can be included in the asset report. Possible values: <c>"investments"</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("products")]
    public IReadOnlyList<string>? Products { get; init; }

    /// <summary>
    /// A list of add-ons that should be included in the Asset Report.
    /// <para>
    /// When Fast Assets is requested, Plaid will create two versions of the Asset Report: the Fast Asset Report, which will contain only Identity and Balance information, and the Full Asset Report, which will also contain Transactions information. A <c>PRODUCT_READY</c> webhook will be fired for each Asset Report when it is ready, and the <c>report_type</c> field will indicate whether the webhook is firing for the <c>FULL</c> or <c>FAST</c> Asset Report. To retrieve the Fast Asset Report, call <c>/asset_report/get</c> with <c>fast_report</c> set to <c>true</c>. There is no additional charge for using Fast Assets. To create a Fast Asset Report, Plaid must successfully retrieve both Identity and Balance data; if Plaid encounters an error obtaining this data, the Fast Asset Report will not be created. However, as long as Plaid can obtain Transactions data, the Full Asset Report will still be available.
    /// </para>
    /// <para>
    /// When Investments is requested, <c>investments</c> must be specified in the <c>optional_products</c> array when initializing Link.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("add_ons")]
    public IReadOnlyList<AssetReportAddOns>? AddOns { get; init; }

    /// <summary>
    /// The user object allows you to provide additional information about the user to be appended to the Asset Report. All fields are optional. The <c>first_name</c>, <c>last_name</c>, and <c>ssn</c> fields are required if you would like the Report to be eligible for Fannie Mae's Day 1 Certainty™ program.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user")]
    public AssetReportUser? User { get; init; }

    /// <summary>
    /// By default (<c>true</c>), the asynchronous report generation fails unless all Items extract successfully. If set to <c>false</c>, the report will still be generated as long as at least one Item extracts successfully; extraction failures on the remaining Items are tolerated. This setting applies only to failures that occur during asynchronous extraction. It does not relax the synchronous check at call time: if any Item is already unhealthy when <c>/asset_report/create</c> is invoked, the request fails immediately regardless of this value.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("require_all_items")]
    public bool? RequireAllItems { get; init; } = true;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

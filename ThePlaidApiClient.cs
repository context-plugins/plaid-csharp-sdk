using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using ThePlaidApi.Core;
using ThePlaidApi.Core.Authentication;
using ThePlaidApi.Core.ErrorResponse;
using ThePlaidApi.Core.Exceptions;
using ThePlaidApi.Core.Logging;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Core.Request;
using ThePlaidApi.Core.Response;
using ThePlaidApi.Errors;
using ThePlaidApi.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi;

/// <summary>
/// The Plaid REST API. Please see https://plaid.com/docs/api for more details.
/// </summary>
public sealed class ThePlaidApiClient
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    public ThePlaidApiClient(HttpClient httpClient, ThePlaidApiClientOptions options)
    {
        _server = new Server(options.Environment, options.Server);
        var queryParameterFactory = new QueryParameterFactory([]);
        var templateParamsFactory = new TemplateParamsFactory([]);
        var urlFactory = new UriFactory(queryParameterFactory, templateParamsFactory);
        var httpStatusPolicy = new HttpStatusPolicy([]);
        var headersFactory =
            new HeadersFactory([new HeaderParam("User-Agent", "ThePlaidApiClient/2020-09-14_1.708.0 CSharp"),
                    new HeaderParam("X-APIMatic-Lang", "CSharp"),
                    new HeaderParam("X-APIMatic-Package-Version", "2020-09-14_1.708.0"),
                    new HeaderParam("X-APIMatic-Gen-Version", "4.0.0"),
                    new HeaderParam("X-APIMatic-OS", RuntimeEnvironment.Os),
                    new HeaderParam("X-APIMatic-Runtime", RuntimeEnvironment.Runtime)]);
        var resiliencePipelineFactory = new ResiliencePipelineFactory(options.Retry);
        var httpLogger = new HttpLogger(options.Logging, "ThePlaidApiClient");
        _rawClient =
            new RawClient(httpClient,
                urlFactory,
                httpStatusPolicy,
                headersFactory,
                resiliencePipelineFactory,
                httpLogger,
                options.Hooks);
        _auth = new AuthSchemes(options, _server, _rawClient);
    }

    /// <summary>
    /// Retrieve real-time balance data
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AccountsGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/accounts/balance/get</c> endpoint returns the real-time balance for each of an Item's accounts. While other endpoints, such as <c>/accounts/get</c>, return a balance object,  <c>/accounts/balance/get</c> forces the available and current balance fields to be refreshed rather than cached. This endpoint can be used for existing Items that were added via any of Plaid's other products. This endpoint can be used as long as Link has been initialized with any other product; <c>balance</c> itself is not a product that can be used to initialize Link. As this endpoint triggers a synchronous request for fresh data, latency may be higher than for other Plaid endpoints (typically less than 10 seconds, but occasionally up to 30 seconds or more); if you encounter errors, you may find it necessary to adjust your timeout period when making requests.
    /// <para>
    /// Note: If you are getting real-time balance for the purpose of assessing the return risk of a proposed ACH transaction, it is recommended to use <c>/signal/evaluate</c> instead of <c>/accounts/balance/get</c>. <c>/signal/evaluate</c> returns the same real-time balance information and also provides access to Signal Rules, which provides no-code transaction business logic configuration, backtesting and recommendations for tuning your transaction acceptance logic, and the ability to easily switch between Balance and Signal Transaction Scores as needed for ultra-low-latency, ML-powered risk assessments. For more details, see the <see href="https://plaid.com/docs/balance/#balance-integration-options">Balance documentation</see>.
    /// </para>
    /// </remarks>
    public Task<AccountsGetResponse> AccountsBalanceGet(AccountsBalanceGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/accounts/balance/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<AccountsGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve accounts
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AccountsGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/accounts/get</c> endpoint can be used to retrieve a list of accounts associated with any linked Item. Plaid will only return active bank accounts -- that is, accounts that are not closed and are capable of carrying a balance.
    /// To return new accounts that were created after the user linked their Item, you can listen for the <see href="https://plaid.com/docs/api/items/#new_accounts_available"><c>NEW_ACCOUNTS_AVAILABLE</c></see> webhook and then use Link's <see href="https://plaid.com/docs/link/update-mode/">update mode</see> to request that the user share this new account with you.
    /// <para>
    /// <c>/accounts/get</c> is free to use and retrieves cached information, rather than extracting fresh information from the institution. The balance returned will reflect the balance at the time of the last successful Item update. If the Item is enabled for a regularly updating product, such as Transactions, Investments, or Liabilities, the balance will typically update about once a day, as long as the Item is healthy. If the Item is enabled only for products that do not frequently update, such as Auth or Identity, balance data may be much older.
    /// </para>
    /// <para>
    /// For real-time balance information, use the paid endpoints <c>/accounts/balance/get</c> or <c>/signal/evaluate</c> instead.
    /// </para>
    /// </remarks>
    public Task<AccountsGetResponse> AccountsGet(AccountsGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/accounts/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<AccountsGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve information about a Plaid application
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApplicationGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Allows financial institutions to retrieve information about Plaid clients for the purpose of building control-tower experiences
    /// </remarks>
    public Task<ApplicationGetResponse> ApplicationGet(ApplicationGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/application/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ApplicationGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Create Asset Report Audit Copy
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AssetReportAuditCopyCreateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Plaid can provide an Audit Copy of any Asset Report directly to a participating third party on your behalf. For example, Plaid can supply an Audit Copy directly to the GSEs on your behalf if you participate in Fannie Mae's Day 1 Certainty™ program or utilize Freddie Mac's Loan Product Advisor® (LPA®) Asset and Income Modeler (AIM). An Audit Copy contains the same underlying data as the Asset Report.
    /// <para>
    /// To grant access to an Audit Copy, use the <c>/asset_report/audit_copy/create</c> endpoint to create an <c>audit_copy_token</c> and then pass that token to the third party who needs access. Each third party has its own <c>auditor_id</c>, for example <c>fannie_mae</c>. You'll need to create a separate Audit Copy for each third party to whom you want to grant access to the Report.
    /// </para>
    /// </remarks>
    public Task<AssetReportAuditCopyCreateResponse> AssetReportAuditCopyCreate(AssetReportAuditCopyCreateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/asset_report/audit_copy/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<AssetReportAuditCopyCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve an Asset Report Audit Copy
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AssetReportGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/asset_report/audit_copy/get</c> allows auditors to get a copy of an Asset Report that was previously shared via the <c>/asset_report/audit_copy/create</c> endpoint.  The caller of <c>/asset_report/audit_copy/create</c> must provide the <c>audit_copy_token</c> to the auditor.  This token can then be used to call <c>/asset_report/audit_copy/get</c>.
    /// </remarks>
    public Task<AssetReportGetResponse> AssetReportAuditCopyGet(AssetReportAuditCopyGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/asset_report/audit_copy/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<AssetReportGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve a PDF Asset Report Audit Copy
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/asset_report/audit_copy/pdf/get</c> endpoint retrieves an Asset Report Audit Copy in PDF format. The caller must provide the <c>audit_copy_token</c> that was shared via the <c>/asset_report/audit_copy/create</c> endpoint.
    /// <para>
    /// The response to <c>/asset_report/audit_copy/pdf/get</c> is the PDF binary data. The <c>request_id</c> is returned in the <c>Plaid-Request-ID</c> header.
    /// </para>
    /// <para>
    /// <see href="https://plaid.com/documents/sample-asset-report.pdf">View a sample PDF Asset Report</see>.
    /// </para>
    /// </remarks>
    public Task AssetReportAuditCopyPdfGet(AssetReportAuditCopyPdfGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/asset_report/audit_copy/pdf/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            VoidResponse.Instance,
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Remove Asset Report Audit Copy
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AssetReportAuditCopyRemoveResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/asset_report/audit_copy/remove</c> endpoint allows you to remove an Audit Copy. Removing an Audit Copy invalidates the <c>audit_copy_token</c> associated with it, meaning both you and any third parties holding the token will no longer be able to use it to access Report data. Items associated with the Asset Report, the Asset Report itself and other Audit Copies of it are not affected and will remain accessible after removing the given Audit Copy.
    /// </remarks>
    public Task<AssetReportAuditCopyRemoveResponse> AssetReportAuditCopyRemove(AssetReportAuditCopyRemoveRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/asset_report/audit_copy/remove"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<AssetReportAuditCopyRemoveResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Create an Asset Report
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AssetReportCreateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/asset_report/create</c> endpoint initiates the process of creating an Asset Report, which can then be retrieved by passing the <c>asset_report_token</c> return value to the <c>/asset_report/get</c> or <c>/asset_report/pdf/get</c> endpoints.
    /// <para>
    /// The Asset Report takes some time to be created and is not available immediately after calling <c>/asset_report/create</c>. The exact amount of time to create the report will vary depending on how many days of history are requested and will typically range from a few seconds to about one minute. When the Asset Report is ready to be retrieved using <c>/asset_report/get</c> or <c>/asset_report/pdf/get</c>, Plaid will fire a <c>PRODUCT_READY</c> webhook. For full details of the webhook schema, see <see href="https://plaid.com/docs/api/products/assets/#webhooks">Asset Report webhooks</see>.
    /// </para>
    /// <para>
    /// The <c>/asset_report/create</c> endpoint creates an Asset Report at a moment in time. Asset Reports are immutable. To get an updated Asset Report, use the <c>/asset_report/refresh</c> endpoint.
    /// </para>
    /// </remarks>
    public Task<AssetReportCreateResponse> AssetReportCreate(AssetReportCreateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/asset_report/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<AssetReportCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Filter Asset Report
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AssetReportFilterResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// By default, an Asset Report will contain all of the accounts on a given Item. In some cases, you may not want the Asset Report to contain all accounts. For example, you might have the end user choose which accounts are relevant in Link using the Account Select view, which you can enable in the dashboard. Or, you might always exclude certain account types or subtypes, which you can identify by using the <c>/accounts/get</c> endpoint. To narrow an Asset Report to only a subset of accounts, use the <c>/asset_report/filter</c> endpoint.
    /// <para>
    /// To exclude certain Accounts from an Asset Report, first use the <c>/asset_report/create</c> endpoint to create the report, then send the <c>asset_report_token</c> along with a list of <c>account_ids</c> to exclude to the <c>/asset_report/filter</c> endpoint, to create a new Asset Report which contains only a subset of the original Asset Report's data.
    /// </para>
    /// <para>
    /// Because Asset Reports are immutable, calling <c>/asset_report/filter</c> does not alter the original Asset Report in any way; rather, <c>/asset_report/filter</c> creates a new Asset Report with a new token and id. Asset Reports created via <c>/asset_report/filter</c> do not contain new Asset data, and are not billed.
    /// </para>
    /// <para>
    /// Plaid will fire a <see href="https://plaid.com/docs/api/products/assets/#product_ready"><c>PRODUCT_READY</c></see> webhook once generation of the filtered Asset Report has completed.
    /// </para>
    /// </remarks>
    public Task<AssetReportFilterResponse> AssetReportFilter(AssetReportFilterRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/asset_report/filter"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<AssetReportFilterResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve an Asset Report
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AssetReportGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/asset_report/get</c> endpoint retrieves the Asset Report in JSON format. Before calling <c>/asset_report/get</c>, you must first create the Asset Report using <c>/asset_report/create</c> (or filter an Asset Report using <c>/asset_report/filter</c>) and then wait for the <see href="https://plaid.com/docs/api/products/assets/#product_ready"><c>PRODUCT_READY</c></see> webhook to fire, indicating that the Report is ready to be retrieved.
    /// <para>
    /// By default, an Asset Report includes transaction descriptions as returned by the bank, as opposed to parsed and categorized by Plaid. You can also receive cleaned and categorized transactions, as well as additional insights like merchant name or location information. We call this an Asset Report with Insights. An Asset Report with Insights provides transaction category, location, and merchant information in addition to the transaction strings provided in a standard Asset Report. To retrieve an Asset Report with Insights, call the <c>/asset_report/get</c> endpoint with <c>include_insights</c> set to <c>true</c>.
    /// </para>
    /// <para>
    /// For latency-sensitive applications, you can optionally call <c>/asset_report/create</c> with <c>options.add_ons</c> set to <c>["fast_assets"]</c>. This will cause Plaid to create two versions of the Asset Report: one with only current and available balance and identity information, and then later on the complete Asset Report. You will receive separate webhooks for each version of the Asset Report.
    /// </para>
    /// </remarks>
    public Task<AssetReportGetResponse> AssetReportGet(AssetReportGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/asset_report/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<AssetReportGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve a PDF Asset Report
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/asset_report/pdf/get</c> endpoint retrieves the Asset Report in PDF format. Before calling <c>/asset_report/pdf/get</c>, you must first create the Asset Report using <c>/asset_report/create</c> (or filter an Asset Report using <c>/asset_report/filter</c>) and then wait for the <see href="https://plaid.com/docs/api/products/assets/#product_ready"><c>PRODUCT_READY</c></see> webhook to fire, indicating that the Report is ready to be retrieved.
    /// <para>
    /// The response to <c>/asset_report/pdf/get</c> is the PDF binary data. The <c>request_id</c>  is returned in the <c>Plaid-Request-ID</c> header.
    /// </para>
    /// <para>
    /// <see href="https://plaid.com/documents/sample-asset-report.pdf">View a sample PDF Asset Report</see>.
    /// </para>
    /// </remarks>
    public Task AssetReportPdfGet(AssetReportPdfGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/asset_report/pdf/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            VoidResponse.Instance,
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Refresh an Asset Report
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AssetReportRefreshResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// An Asset Report is an immutable snapshot of a user's assets. In order to "refresh" an Asset Report you created previously, you can use the <c>/asset_report/refresh</c> endpoint to create a new Asset Report based on the old one, but with the most recent data available.
    /// <para>
    /// The new Asset Report will contain the same Items as the original Report, as well as the same filters applied by any call to <c>/asset_report/filter</c>. By default, the new Asset Report will also use the same parameters you submitted with your original <c>/asset_report/create</c> request, but the original <c>days_requested</c> value and the values of any parameters in the <c>options</c> object can be overridden with new values. To change these arguments, simply supply new values for them in your request to <c>/asset_report/refresh</c>. Submit an empty string ("") for any previously-populated fields you would like set as empty.
    /// </para>
    /// </remarks>
    public Task<AssetReportRefreshResponse> AssetReportRefresh(AssetReportRefreshRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/asset_report/refresh"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<AssetReportRefreshResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Delete an Asset Report
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AssetReportRemoveResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/item/remove</c> endpoint allows you to invalidate an <c>access_token</c>, meaning you will not be able to create new Asset Reports with it. Removing an Item does not affect any Asset Reports or Audit Copies you have already created, which will remain accessible until you remove them specifically.
    /// <para>
    /// The <c>/asset_report/remove</c> endpoint allows you to remove access to an Asset Report. Removing an Asset Report invalidates its <c>asset_report_token</c>, meaning you will no longer be able to use it to access Report data or create new Audit Copies. Removing an Asset Report does not affect the underlying Items, but does invalidate any <c>audit_copy_tokens</c> associated with the Asset Report.
    /// </para>
    /// </remarks>
    public Task<AssetReportRemoveResponse> AssetReportRemove(AssetReportRemoveRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/asset_report/remove"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<AssetReportRemoveResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve auth data
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AuthGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/auth/get</c> endpoint returns the bank account and bank identification numbers (such as routing numbers, for US accounts) associated with an Item's checking, savings, and cash management accounts, along with high-level account data and balances when available.
    /// <para>
    /// Versioning note: In API version 2017-03-08, the schema of the <c>numbers</c> object returned by this endpoint is substantially different. For details, see <see href="https://plaid.com/docs/api/versioning/#version-2018-05-22">Plaid API versioning</see>.
    /// </para>
    /// </remarks>
    public Task<AuthGetResponse> AuthGet(AuthGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/auth/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<AuthGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Verify auth data
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AuthVerifyResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/auth/verify</c> endpoint verifies bank account and routing numbers and (optionally) account owner names against Plaid's database via <see href="https://plaid.com/docs/auth/coverage/database-auth/">Database Auth</see>. It can be used to verify account numbers that were not collected via the Plaid Link flow.
    /// <para>
    /// This endpoint is currently in Early Availability; contact sales or your Plaid account manager to request access.
    /// </para>
    /// </remarks>
    public Task<AuthVerifyResponse> AuthVerify(AuthVerifyRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/auth/verify"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<AuthVerifyResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// (Deprecated) Get balance of your Bank Transfer account
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BankTransferBalanceGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/bank_transfer/balance/get</c> endpoint to see the available balance in your bank transfer account. Debit transfers increase this balance once their status is posted. Credit transfers decrease this balance when they are created.
    /// <para>
    /// The transactable balance shows the amount in your account that you are able to use for transfers, and is essentially your available balance minus your minimum balance.
    /// </para>
    /// <para>
    /// Note that this endpoint can only be used with FBO accounts, when using Bank Transfers in the Full Service configuration. It cannot be used on your own account when using Bank Transfers in the BTS Platform configuration.
    /// </para>
    /// </remarks>
    public Task<BankTransferBalanceGetResponse> BankTransferBalanceGet(BankTransferBalanceGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/bank_transfer/balance/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BankTransferBalanceGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// (Deprecated) Cancel a bank transfer
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BankTransferCancelResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/bank_transfer/cancel</c> endpoint to cancel a bank transfer.  A transfer is eligible for cancelation if the <c>cancellable</c> property returned by <c>/bank_transfer/get</c> is <c>true</c>.
    /// </remarks>
    public Task<BankTransferCancelResponse> BankTransferCancel(BankTransferCancelRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/bank_transfer/cancel"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BankTransferCancelResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// (Deprecated) Create a bank transfer
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BankTransferCreateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/bank_transfer/create</c> endpoint to initiate a new bank transfer.
    /// </remarks>
    public Task<BankTransferCreateResponse> BankTransferCreate(BankTransferCreateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/bank_transfer/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BankTransferCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// List bank transfer events
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BankTransferEventListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/bank_transfer/event/list</c> endpoint to get a list of Plaid-initiated ACH or bank transfer events based on specified filter criteria. When using Auth with micro-deposit verification enabled, this endpoint can be used to fetch status updates on ACH micro-deposits. For more details, see <see href="https://plaid.com/docs/auth/coverage/microdeposit-events/">micro-deposit events</see>.
    /// </remarks>
    public Task<BankTransferEventListResponse> BankTransferEventList(BankTransferEventListRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/bank_transfer/event/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BankTransferEventListResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Sync bank transfer events
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BankTransferEventSyncResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/bank_transfer/event/sync</c> allows you to request up to the next 25 Plaid-initiated bank transfer events that happened after a specific <c>event_id</c>. When using Auth with micro-deposit verification enabled, this endpoint can be used to fetch status updates on ACH micro-deposits. For more details, see <see href="https://plaid.com/docs/auth/coverage/microdeposit-events/">micro-deposit events</see>.
    /// </remarks>
    public Task<BankTransferEventSyncResponse> BankTransferEventSync(BankTransferEventSyncRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/bank_transfer/event/sync"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BankTransferEventSyncResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// (Deprecated) Retrieve a bank transfer
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BankTransferGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/bank_transfer/get</c> fetches information about the bank transfer corresponding to the given <c>bank_transfer_id</c>.
    /// </remarks>
    public Task<BankTransferGetResponse> BankTransferGet(BankTransferGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/bank_transfer/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BankTransferGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// (Deprecated) List bank transfers
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BankTransferListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/bank_transfer/list</c> endpoint to see a list of all your bank transfers and their statuses. Results are paginated; use the <c>count</c> and <c>offset</c> query parameters to retrieve the desired bank transfers.
    /// </remarks>
    public Task<BankTransferListResponse> BankTransferList(BankTransferListRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/bank_transfer/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BankTransferListResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// (Deprecated) Migrate account into Bank Transfers
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BankTransferMigrateAccountResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// As an alternative to adding Items via Link, you can also use the <c>/bank_transfer/migrate_account</c> endpoint to migrate known account and routing numbers to Plaid Items.  Note that Items created in this way are not compatible with endpoints for other products, such as <c>/accounts/balance/get</c>, and can only be used with Bank Transfer endpoints.  If you require access to other endpoints, create the Item through Link instead.  Access to <c>/bank_transfer/migrate_account</c> is not enabled by default; to obtain access, contact your Plaid account manager.
    /// </remarks>
    public Task<BankTransferMigrateAccountResponse> BankTransferMigrateAccount(BankTransferMigrateAccountRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/bank_transfer/migrate_account"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BankTransferMigrateAccountResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// (Deprecated) Retrieve a sweep
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BankTransferSweepGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/bank_transfer/sweep/get</c> endpoint fetches information about the sweep corresponding to the given <c>sweep_id</c>.
    /// </remarks>
    public Task<BankTransferSweepGetResponse> BankTransferSweepGet(BankTransferSweepGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/bank_transfer/sweep/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BankTransferSweepGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// (Deprecated) List sweeps
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BankTransferSweepListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/bank_transfer/sweep/list</c> endpoint fetches information about the sweeps matching the given filters.
    /// </remarks>
    public Task<BankTransferSweepListResponse> BankTransferSweepList(BankTransferSweepListRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/bank_transfer/sweep/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BankTransferSweepListResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// (Deprecated) Evaluate risk of a bank account
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BeaconAccountRiskEvaluateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use <c>/beacon/account_risk/v1/evaluate</c> to get risk insights for a linked account.
    /// </remarks>
    public Task<BeaconAccountRiskEvaluateResponse> BeaconAccountRiskEvaluate(BeaconAccountRiskEvaluateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/beacon/account_risk/v1/evaluate"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BeaconAccountRiskEvaluateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// (Deprecated) Get a Beacon Duplicate
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BeaconDuplicateGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a Beacon Duplicate for a given Beacon Duplicate id.
    /// <para>
    /// A Beacon Duplicate represents a pair of similar Beacon Users within your organization.
    /// </para>
    /// <para>
    /// Two Beacon User revisions are returned for each Duplicate record in either the <c>beacon_user1</c> or <c>beacon_user2</c> response fields.
    /// </para>
    /// <para>
    /// The <c>analysis</c> field in the response indicates which fields matched between <c>beacon_user1</c> and <c>beacon_user2</c>.
    /// </para>
    /// </remarks>
    public Task<BeaconDuplicateGetResponse> BeaconDuplicateGet(BeaconDuplicateGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/beacon/duplicate/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BeaconDuplicateGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// (Deprecated) Create a Beacon Report
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BeaconReportCreateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a fraud report for a given Beacon User.
    /// </remarks>
    public Task<BeaconReportCreateResponse> BeaconReportCreate(BeaconReportCreateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/beacon/report/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BeaconReportCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// (Deprecated) Get a Beacon Report
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BeaconReportGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a Beacon Report for a given Beacon Report ID.
    /// </remarks>
    public Task<BeaconReportGetResponse> BeaconReportGet(BeaconReportGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/beacon/report/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BeaconReportGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// (Deprecated) List Beacon Reports for a Beacon User
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BeaconReportListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/beacon/report/list</c> endpoint to view all Beacon Reports you created for a specific Beacon User. The reports returned by this endpoint are exclusively reports you created for a specific user. A Beacon User can only have one active report at a time, but a new report can be created if a previous report has been deleted. The results from this endpoint are paginated; the <c>next_cursor</c> field will be populated if there is another page of results that can be retrieved. To fetch the next page, pass the <c>next_cursor</c> value as the <c>cursor</c> parameter in the next request.
    /// </remarks>
    public Task<BeaconReportListResponse> BeaconReportList(BeaconReportListRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/beacon/report/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BeaconReportListResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// (Deprecated) Get a Beacon Report Syndication
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BeaconReportSyndicationGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a Beacon Report Syndication for a given Beacon Report Syndication id.
    /// </remarks>
    public Task<BeaconReportSyndicationGetResponse> BeaconReportSyndicationGet(BeaconReportSyndicationGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/beacon/report_syndication/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BeaconReportSyndicationGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// (Deprecated) List Beacon Report Syndications for a Beacon User
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BeaconReportSyndicationListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/beacon/report_syndication/list</c> endpoint to view all Beacon Reports that have been syndicated to a specific Beacon User. This endpoint returns Beacon Report Syndications which are references to Beacon Reports created either by you, or another Beacon customer, that matched the specified Beacon User. A Beacon User can have multiple active Beacon Report Syndications at once. The results from this endpoint are paginated; the <c>next_cursor</c> field will be populated if there is another page of results that can be retrieved. To fetch the next page, pass the <c>next_cursor</c> value as the <c>cursor</c> parameter in the next request.
    /// </remarks>
    public Task<BeaconReportSyndicationListResponse> BeaconReportSyndicationList(BeaconReportSyndicationListRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/beacon/report_syndication/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BeaconReportSyndicationListResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// (Deprecated) Get Account Insights for a Beacon User
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BeaconUserAccountInsightsGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get Account Insights for all Accounts linked to this Beacon User. The insights for each account are computed based on the information that was last retrieved from the financial institution.
    /// </remarks>
    public Task<BeaconUserAccountInsightsGetResponse> BeaconUserAccountInsightsGet(BeaconUserAccountInsightsGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/beacon/user/account_insights/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BeaconUserAccountInsightsGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// (Deprecated) Create a Beacon User
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BeaconUserCreateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create and scan a Beacon User against your Beacon Program, according to your program's settings.
    /// <para>
    /// When you submit a new user to <c>/beacon/user/create</c>, several checks are performed immediately:
    /// </para>
    /// <list type="bullet">
    ///   <item><description>The user's PII (provided within the <c>user</c> object) is searched against all other users within the Beacon Program you specified. If a match is found that violates your program's "Duplicate Information Filtering" settings, the user will be returned with a status of <c>pending_review</c>.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>The user's PII is also searched against all fraud reports created by your organization across all of your Beacon Programs. If the user's data matches a fraud report that your team created, the user will be returned with a status of <c>rejected</c>.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>Finally, the user's PII is searched against all fraud reports shared with the Beacon Network by other companies. If a matching fraud report is found, the user will be returned with a <c>pending_review</c> status if your program has enabled automatic flagging based on network fraud.</description></item>
    /// </list>
    /// </remarks>
    public Task<BeaconUserCreateResponse> BeaconUserCreate(BeaconUserCreateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/beacon/user/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BeaconUserCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// (Deprecated) Get a Beacon User
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BeaconUserGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Fetch a Beacon User.
    /// <para>
    /// The Beacon User is returned with all of their associated information and a <c>status</c> based on the Beacon Network duplicate record and fraud checks.
    /// </para>
    /// </remarks>
    public Task<BeaconUserGetResponse> BeaconUserGet(BeaconUserGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/beacon/user/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BeaconUserGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// (Deprecated) List a Beacon User's history
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BeaconUserHistoryListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List all changes to the Beacon User in reverse-chronological order.
    /// </remarks>
    public Task<BeaconUserHistoryListResponse> BeaconUserHistoryList(BeaconUserHistoryListRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/beacon/user/history/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BeaconUserHistoryListResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// (Deprecated) Review a Beacon User
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BeaconUserGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update the status of a Beacon User.
    /// <para>
    /// When updating a Beacon User's status via this endpoint, Plaid validates that the status change is consistent with the related state for this Beacon User. Specifically, we will check:
    /// </para>
    /// <list type="number">
    ///   <item><description>Whether there are any associated Beacon Reports connected to the Beacon User, and</description></item>
    ///   <item><description>Whether there are any confirmed Beacon Report Syndications connected to the Beacon User.</description></item>
    /// </list>
    /// <para>
    /// When updating a Beacon User's status to <c>rejected</c>, we enforce that either a Beacon Report has been created for the Beacon User or a Beacon Report Syndication has been confirmed.
    /// When updating a Beacon User's status to <c>cleared</c>, we enforce that there are no active Beacon Reports or confirmed Beacon Report Syndications associated with the user. If you previously created a Beacon Report for this user, you must delete it before updating the Beacon User's status to <c>cleared</c>.
    /// There are no restrictions on updating a Beacon User's status to <c>pending_review</c>.
    /// </para>
    /// <para>
    /// If these conditions are not met, the request will be rejected with an error explaining the issue.
    /// </para>
    /// </remarks>
    public Task<BeaconUserGetResponse> BeaconUserReview(BeaconUserReviewRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/beacon/user/review"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BeaconUserGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// (Deprecated) Update the identity data of a Beacon User
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BeaconUserUpdateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update the identity data for a Beacon User in your Beacon Program or add new accounts to the Beacon User.
    /// <para>
    /// Similar to <c>/beacon/user/create</c>, several checks are performed immediately when you submit an identity data change to <c>/beacon/user/update</c>:
    /// </para>
    /// <list type="bullet">
    ///   <item><description>The user's updated PII is searched against all other users within the Beacon Program you specified. If a match is found that violates your program's "Duplicate Information Filtering" settings, the user will be returned with a status of <c>pending_review</c>.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>The user's updated PII is also searched against all fraud reports created by your organization across all of your Beacon Programs. If the user's data matches a fraud report that your team created, the user will be returned with a status of <c>rejected</c>.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>Finally, the user's PII is searched against all fraud reports shared with the Beacon Network by other companies. If a matching fraud report is found, the user will be returned with a <c>pending_review</c> status if your program has enabled automatic flagging based on network fraud.</description></item>
    /// </list>
    /// <para>
    /// Plaid maintains a version history for each Beacon User, so the Beacon User's identity data before and after the update is retained as separate versions.
    /// </para>
    /// </remarks>
    public Task<BeaconUserUpdateResponse> BeaconUserUpdate(BeaconUserUpdateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/beacon/user/update"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BeaconUserUpdateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Get EWA Score Report
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BetaEwaReportV1GetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/beta/ewa_report/v1/get</c> endpoint provides an Earned Wage Access (EWA) score that quantifies the delinquency risk associated with a given item. The score is derived from a combination of cashflow patterns and network-based behavioral features.
    /// <para>
    /// The response returns a list of EWA scores, where each score corresponds to a potential advance amount range. These scores estimate the likelihood of repayment for advances within that range.
    /// </para>
    /// <para>
    /// Score range: 1-99
    /// </para>
    /// <para>
    /// Interpretation: Higher scores indicate a greater likelihood of repayment.
    /// </para>
    /// <para>
    /// This endpoint enables clients to assess repayment risk and make data-driven decisions when determining eligibility or limits for earned wage advances.
    /// </para>
    /// </remarks>
    public Task<BetaEwaReportV1GetResponse> BetaEwaReportV1Get(BetaEwaReportV1GetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/beta/ewa_report/v1/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BetaEwaReportV1GetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Creates a new end customer for a Plaid reseller.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BetaPartnerCustomerV1CreateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/beta/partner/customer/v1/create</c> endpoint creates a new end customer record. You can provide as much information as you have available. If any required information is missing for the products you intend to use, it will be listed in the <c>requirements_due</c> field of the response.
    /// </remarks>
    public Task<BetaPartnerCustomerV1CreateResponse> BetaPartnerCustomerV1Create(BetaPartnerCustomerV1CreateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/beta/partner/customer/v1/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BetaPartnerCustomerV1CreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Enables a Plaid reseller's end customer in the Production environment.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BetaPartnerCustomerV1EnableResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/beta/partner/customer/v1/enable</c> endpoint is used by reseller partners to enable an end customer in the full Production environment.
    /// </remarks>
    public Task<BetaPartnerCustomerV1EnableResponse> BetaPartnerCustomerV1Enable(BetaPartnerCustomerV1EnableRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/beta/partner/customer/v1/enable"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BetaPartnerCustomerV1EnableResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieves the details of a Plaid reseller's end customer.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BetaPartnerCustomerV1GetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/beta/partner/customer/v1/get</c> endpoint is used by reseller partners to retrieve data about a single end customer.
    /// </remarks>
    public Task<BetaPartnerCustomerV1GetResponse> BetaPartnerCustomerV1Get(BetaPartnerCustomerV1GetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/beta/partner/customer/v1/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BetaPartnerCustomerV1GetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Updates an existing end customer.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BetaPartnerCustomerV1UpdateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/beta/partner/customer/v1/update</c> endpoint updates an existing end customer record.
    /// </remarks>
    public Task<BetaPartnerCustomerV1UpdateResponse> BetaPartnerCustomerV1Update(BetaPartnerCustomerV1UpdateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/beta/partner/customer/v1/update"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BetaPartnerCustomerV1UpdateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Create a Business Verification
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BusinessVerificationCreateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a new business verification to check a business's identity and risk profile.
    /// </remarks>
    public Task<BusinessVerificationCreateResponse> BusinessVerificationCreate(BusinessVerificationCreateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/business_verification/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BusinessVerificationCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Get a Business Verification
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BusinessVerificationGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieve the current state of a specific business verification.
    /// </remarks>
    public Task<BusinessVerificationGetResponse> BusinessVerificationGet(BusinessVerificationGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/business_verification/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BusinessVerificationGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Gets transaction data in <c>cashflow_report</c>
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CashflowReportGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/cashflow_report/get</c> endpoint retrieves transactions data associated with an Item. Transactions data is standardized across financial institutions.
    /// Transactions are returned in reverse-chronological order, and the sequence of transaction ordering is stable and will not shift. Transactions are not immutable and can also be removed altogether by the institution; a removed transaction will no longer appear in <c>/cashflow_report/get</c>.  For more details, see <see href="https://plaid.com/docs/transactions/transactions-data/#pending-and-posted-transactions">Pending and posted transactions</see>.
    /// Due to the potentially large number of transactions associated with an Item, results are paginated. Manipulate the <c>count</c> and <c>cursor</c> parameters in conjunction with the <c>has_more</c> response body field to fetch all available transactions.
    /// Note that data isn't likely to be immediately available to <c>/cashflow_report/get</c>. Plaid will begin to prepare transactions data upon Item link, if Link was initialized with <c>cashflow_report</c>, or if it wasn't, upon the first call to <c>/cashflow_report/refresh</c>. To be alerted when transaction data is ready to be fetched, listen for the <c>CASHFLOW_REPORT_READY</c> webhook.
    /// </remarks>
    public Task<CashflowReportGetResponse> CashflowReportGet(CashflowReportGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/cashflow_report/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CashflowReportGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Gets insights data in Cashflow Report
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CashflowReportInsightsGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/cashflow_report/insights/get</c> endpoint retrieves insights data associated with an Item. Insights are only calculated on credit and depository accounts.
    /// </remarks>
    public Task<CashflowReportInsightsGetResponse> CashflowReportInsightsGet(CashflowReportInsightsGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/cashflow_report/insights/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CashflowReportInsightsGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Refresh transaction data in <c>cashflow_report</c>
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CashflowReportRefreshResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/cashflow_report/refresh</c> is an endpoint that initiates an on-demand extraction to fetch the newest transactions for an Item (given an <c>item_id</c>). The Item must already have Cashflow Report added as a product in order to call <c>/cashflow_report/refresh</c>.
    /// <para>
    /// After calling <c>/cashflow_report/refresh</c>, Plaid will fire a webhook <c>CASHFLOW_REPORT_READY</c> alerting clients that new transactions data can then be ingested via <c>/cashflow_report/get</c> or the webhook will contain an error code informing there was an error in refreshing transactions data.
    /// </para>
    /// <para>
    /// Note that the <c>/cashflow_report/refresh</c> endpoint is not supported for Capital One (<c>ins_128026</c>) non-depository accounts and will result in a <c>PRODUCTS_NOT_SUPPORTED</c> error if called on an Item that contains only non-depository accounts from that institution.
    /// </para>
    /// <para>
    /// As this endpoint triggers a synchronous request for fresh data, latency may be higher than for other Plaid endpoints (typically less than 10 seconds, but up to 30 seconds or more). If you encounter errors, you may find it necessary to adjust your timeout period for requests.
    /// </para>
    /// </remarks>
    public Task<CashflowReportRefreshResponse> CashflowReportRefresh(CashflowReportRefreshRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/cashflow_report/refresh"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CashflowReportRefreshResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Gets transaction data in <c>cashflow_report</c>
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CashflowReportTransactionsGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/cashflow_report/transactions/get</c> endpoint retrieves transactions data associated with an Item. Transactions data is standardized across financial institutions.
    /// Transactions are returned in reverse-chronological order, and the sequence of transaction ordering is stable and will not shift. Transactions are not immutable and can also be removed altogether by the institution; a removed transaction will no longer appear in <c>/cashflow_report/transactions/get</c>.  For more details, see <see href="https://plaid.com/docs/transactions/transactions-data/#pending-and-posted-transactions">Pending and posted transactions</see>.
    /// Due to the potentially large number of transactions associated with an Item, results are paginated. Manipulate the <c>count</c> and <c>cursor</c> parameters in conjunction with the <c>has_more</c> response body field to fetch all available transactions.
    /// Note that data isn't likely to be immediately available to <c>/cashflow_report/transactions/get</c>. Plaid will begin to prepare transactions data upon Item link, if Link was initialized with <c>cashflow_report</c>, or if it wasn't, upon the first call to <c>/cashflow_report/refresh</c>. To be alerted when transaction data is ready to be fetched, listen for the <c>CASHFLOW_REPORT_READY</c> webhook.
    /// </remarks>
    public Task<CashflowReportTransactionsGetResponse> CashflowReportTransactionsGet(CashflowReportTransactionsGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/cashflow_report/transactions/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CashflowReportTransactionsGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// (Deprecated) Get legacy categories
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CategoriesGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Send a request to the <c>/categories/get</c> endpoint to get detailed information on legacy categories returned by Plaid. This endpoint does not require authentication.
    /// <para>
    /// All implementations are recommended to <see href="https://plaid.com/docs/transactions/pfc-migration/">use the newer <c>personal_finance_category</c> taxonomy</see> instead of the legacy <c>category</c> taxonomy supported by this endpoint.
    /// </para>
    /// </remarks>
    public Task<CategoriesGetResponse> CategoriesGet(object body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/categories/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CategoriesGetResponse>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// List a historical log of item consent events
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConsentEventsGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List a historical log of Item consent events. Consent logs are only available for events occurring on or after November 7, 2024. Extremely recent events (occurring within the past 12 hours) may not be available via this endpoint. Up to three years of consent logs will be available via the endpoint.
    /// </remarks>
    public Task<ConsentEventsGetResponse> ConsentEventsGet(ConsentEventsGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/consent/events/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ConsentEventsGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve PDF Reports
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves all existing CRB Bank Income and Base reports for the consumer in PDF format.
    /// <para>
    /// Response is PDF binary data. The <c>request_id</c> is returned in the <c>Plaid-Request-ID</c> header.
    /// </para>
    /// </remarks>
    public Task ConsumerReportPdfGet(ConsumerReportPdfGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/consumer_report/pdf/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            VoidResponse.Instance,
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve a Base Report
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CraCheckReportBaseReportGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows you to retrieve the Base Report for your user, allowing you to receive comprehensive bank account and cash flow data. You should call this endpoint after you've received a <c>CHECK_REPORT_READY</c> or a <c>USER_CHECK_REPORT_READY</c> webhook, either after the Link session for the user or after calling <c>/cra/check_report/create</c>. If the most recent consumer report for the user doesn't have sufficient data to generate the base report, or the consumer report has expired, you will receive an error indicating that you should create a new consumer report by calling <c>/cra/check_report/create</c>.
    /// </remarks>
    public Task<CraCheckReportBaseReportGetResponse> CraCheckReportBaseReportGet(CraCheckReportBaseReportGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/cra/check_report/base_report/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CraCheckReportBaseReportGetResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(new AuthSchemeAll(_auth.ClientId, _auth.Secret, _auth.PlaidVersion), _auth.Oauth2)],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve cash flow insights from your user's banking data
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CraCheckReportCashflowInsightsGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows you to retrieve the Cashflow Insights report for your user. You should call this endpoint after you've received a <c>CHECK_REPORT_READY</c> or a <c>USER_CHECK_REPORT_READY</c> webhook, either after the Link session for the user or after calling <c>/cra/check_report/create</c>. If the most recent consumer report for the user doesn't have sufficient data to generate the report, or the consumer report has expired, you will receive an error indicating that you should create a new consumer report by calling <c>/cra/check_report/create</c>.
    /// </remarks>
    public Task<CraCheckReportCashflowInsightsGetResponse> CraCheckReportCashflowInsightsGet(CraCheckReportCashflowInsightsGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/cra/check_report/cashflow_insights/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CraCheckReportCashflowInsightsGetResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(new AuthSchemeAll(_auth.ClientId, _auth.Secret, _auth.PlaidVersion), _auth.Oauth2)],
            requestOptions,
            ct);

    /// <summary>
    /// Refresh or create a Consumer Report
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CraCheckReportCreateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use <c>/cra/check_report/create</c> to refresh data in an existing report. A Consumer Report will last for 24 hours before expiring; you should call any <c>/get</c> endpoints on the report before it expires. If a report expires, you can call <c>/cra/check_report/create</c> again to re-generate it and refresh the data in the report.
    /// </remarks>
    public Task<CraCheckReportCreateResponse> CraCheckReportCreate(CraCheckReportCreateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/cra/check_report/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CraCheckReportCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve income insights from your user's banks
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CraCheckReportIncomeInsightsGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows you to retrieve the Income Insights report for your user. You should call this endpoint after you've received a <c>CHECK_REPORT_READY</c> or a <c>USER_CHECK_REPORT_READY</c> webhook, either after the Link session for the user or after calling <c>/cra/check_report/create</c>. If the most recent consumer report for the user doesn't have sufficient data to generate the report, or the consumer report has expired, you will receive an error indicating that you should create a new consumer report by calling <c>/cra/check_report/create</c>.
    /// <para>
    /// NOTE: The following schema was updated in April 2026 to reflect the response when the provided version is "II2". Please see <see href="https://docs.google.com/document/d/1kQkQ7FOgFaC4n-sUGUk74hoXZNY_L_nJeCuMe7Keip4/edit?tab=t.0#heading=h.rudamzinus2i">this document</see> for guidance on migrating to II2 if you are currently using the II1 version, and <see href="https://docs.google.com/document/d/1kQkQ7FOgFaC4n-sUGUk74hoXZNY_L_nJeCuMe7Keip4/edit?tab=t.0#bookmark=id.tdcc2wpk0h60">this section</see> for an example II1 response along with its <see href="https://docs.google.com/document/d/1kQkQ7FOgFaC4n-sUGUk74hoXZNY_L_nJeCuMe7Keip4/edit?tab=t.36c85n2ircqk#heading=h.79dwr5c1iszl">documentation</see>.
    /// </para>
    /// </remarks>
    public Task<CraCheckReportIncomeInsightsGetResponse> CraCheckReportIncomeInsightsGet(CraCheckReportIncomeInsightsGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/cra/check_report/income_insights/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CraCheckReportIncomeInsightsGetResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(new AuthSchemeAll(_auth.ClientId, _auth.Secret, _auth.PlaidVersion), _auth.Oauth2)],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve the LendScore from your user's banking data
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CraCheckReportLendScoreGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows you to retrieve the LendScore report for your user. You should call this endpoint after you've received a <c>CHECK_REPORT_READY</c> or a <c>USER_CHECK_REPORT_READY</c> webhook, either after the Link session for the user or after calling <c>/cra/check_report/create</c>. If the most recent consumer report for the user doesn't have sufficient data to generate the report, or the consumer report has expired, you will receive an error indicating that you should create a new consumer report by calling <c>/cra/check_report/create</c>.
    /// </remarks>
    public Task<CraCheckReportLendScoreGetResponse> CraCheckReportLendScoreGet(CraCheckReportLendScoreGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/cra/check_report/lend_score/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CraCheckReportLendScoreGetResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(new AuthSchemeAll(_auth.ClientId, _auth.Secret, _auth.PlaidVersion), _auth.Oauth2)],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve network attributes for the user
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CraCheckReportNetworkInsightsGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows you to retrieve the Network Insights report for your user. You should call this endpoint after you've received a <c>CHECK_REPORT_READY</c> or a <c>USER_CHECK_REPORT_READY</c> webhook, either after the Link session for the user or after calling <c>/cra/check_report/create</c>. If the most recent consumer report for the user doesn't have sufficient data to generate the report, or the consumer report has expired, you will receive an error indicating that you should create a new consumer report by calling <c>/cra/check_report/create</c>.
    /// </remarks>
    public Task<CraCheckReportNetworkInsightsGetResponse> CraCheckReportNetworkInsightsGet(CraCheckReportNetworkInsightsGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/cra/check_report/network_insights/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CraCheckReportNetworkInsightsGetResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(new AuthSchemeAll(_auth.ClientId, _auth.Secret, _auth.PlaidVersion), _auth.Oauth2)],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve cash flow insights from partners
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CraCheckReportPartnerInsightsGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows you to retrieve the Partner Insights report for your user. You should call this endpoint after you've received a <c>CHECK_REPORT_READY</c> or a <c>USER_CHECK_REPORT_READY</c> webhook, either after the Link session for the user or after calling <c>/cra/check_report/create</c>. If the most recent consumer report for the user doesn't have sufficient data to generate the report, or the consumer report has expired, you will receive an error indicating that you should create a new consumer report by calling <c>/cra/check_report/create</c>.
    /// </remarks>
    public Task<CraCheckReportPartnerInsightsGetResponse> CraCheckReportPartnerInsightsGet(CraCheckReportPartnerInsightsGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/cra/check_report/partner_insights/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CraCheckReportPartnerInsightsGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve a Consumer Report as a PDF
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/cra/check_report/pdf/get</c> retrieves the most recent Consumer Report in PDF format. By default, the most recent Base Report (if it exists) for the user will be returned. To request that the most recent Partner Insights or Income Insights report be included in the PDF as well, use the <c>add-ons</c> field.
    /// </remarks>
    public Task CraCheckReportPdfGet(CraCheckReportPdfGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/cra/check_report/pdf/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            VoidResponse.Instance,
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve various home lending reports for a user
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CraCheckReportVerificationGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows you to retrieve home lending reports for a user. To obtain a VoA or Employment Refresh report, you need to make sure that <c>cra_base_report</c> is included in the <c>products</c> parameter when calling <c>/link/token/create</c> or <c>/cra/check_report/create</c>.
    /// <para>
    /// You should call this endpoint after you've received a <c>CHECK_REPORT_READY</c> or a <c>USER_CHECK_REPORT_READY</c> webhook, either after the Link session for the user or after calling <c>/cra/check_report/create</c>.
    /// </para>
    /// <para>
    /// If the most recent consumer report for the user doesn't have sufficient data to generate the report, or the consumer report has expired, you will receive an error indicating that you should create a new consumer report by calling <c>/cra/check_report/create</c>.
    /// </para>
    /// </remarks>
    public Task<CraCheckReportVerificationGetResponse> CraCheckReportVerificationGet(CraCheckReportVerificationGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/cra/check_report/verification/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CraCheckReportVerificationGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve a Consumer Report as a Verification PDF
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/cra/check_report/verification/pdf/get</c> endpoint retrieves the most recent Consumer Report in PDF format, specifically formatted for Home Lending verification use cases. Before calling this endpoint, ensure that you've created a VOA report through Link or the <c>/cra/check_report/create</c> endpoint, and have received a <c>CHECK_REPORT_READY</c> or a <c>USER_CHECK_REPORT_READY</c> webhook.
    /// <para>
    /// The response to <c>/cra/check_report/verification/pdf/get</c> is the PDF binary data. The <c>request_id</c>  is returned in the <c>Plaid-Request-ID</c> header.
    /// </para>
    /// </remarks>
    public Task CraCheckReportVerificationPdfGet(CraCheckReportVerificationPdfGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/cra/check_report/verification/pdf/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            VoidResponse.Instance,
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve the credit profile report for a user
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CraCreditProfileReportGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/cra/credit_profile/report/get</c> retrieves a credit profile report for a user.
    /// </remarks>
    public Task<CraCreditProfileReportGetResponse> CraCreditProfileReportGet(CraCreditProfileReportGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/cra/credit_profile/report/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CraCreditProfileReportGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Register loan applications and decisions
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CraLoansApplicationsRegisterResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/cra/loans/applications/register</c> registers loan applications and decisions.
    /// </remarks>
    public Task<CraLoansApplicationsRegisterResponse> CraLoansApplicationsRegister(CraLoansApplicationsRegisterRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/cra/loans/applications/register"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CraLoansApplicationsRegisterResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Register a list of loans to their applicants
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CraLoansRegisterResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/cra/loans/register</c> registers a list of loans to their applicants.
    /// </remarks>
    public Task<CraLoansRegisterResponse> CraLoansRegister(CraLoansRegisterRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/cra/loans/register"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CraLoansRegisterResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Unregister a list of loans
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CraLoanUnregisterResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/cra/loans/unregister</c> indicates the loans have reached a final status and no further updates are expected.
    /// </remarks>
    public Task<CraLoanUnregisterResponse> CraLoansUnregister(CraLoansUnregisterRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/cra/loans/unregister"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CraLoanUnregisterResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Update loan data
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CraLoansUpdateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/cra/loans/update</c> updates loan information such as the status and payment history.
    /// </remarks>
    public Task<CraLoansUpdateResponse> CraLoansUpdate(CraLoansUpdateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/cra/loans/update"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CraLoansUpdateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve a Monitoring Insights Report
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CraMonitoringInsightsGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows you to retrieve a Cash Flow Updates report by passing in the <c>user_id</c> referred to in the webhook you received.
    /// </remarks>
    public Task<CraMonitoringInsightsGetResponse> CraMonitoringInsightsGet(CraMonitoringInsightsGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/cra/monitoring_insights/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CraMonitoringInsightsGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Subscribe to Monitoring Insights
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CraMonitoringInsightsSubscribeResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows you to subscribe to insights for a user's linked CRA Item, which are updated between one and four times per day (best-effort). In the current Cash Flow Updates beta experience, only one Item per user may be subscribed for monitoring updates.
    /// </remarks>
    public Task<CraMonitoringInsightsSubscribeResponse> CraMonitoringInsightsSubscribe(CraMonitoringInsightsSubscribeRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/cra/monitoring_insights/subscribe"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CraMonitoringInsightsSubscribeResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Unsubscribe from Monitoring Insights
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CraMonitoringInsightsUnsubscribeResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows you to unsubscribe from previously subscribed Monitoring Insights.
    /// </remarks>
    public Task<CraMonitoringInsightsUnsubscribeResponse> CraMonitoringInsightsUnsubscribe(CraMonitoringInsightsUnsubscribeRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/cra/monitoring_insights/unsubscribe"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CraMonitoringInsightsUnsubscribeResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve cash flow insights from the bank accounts used for income verification
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CraPartnerInsightsGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/cra/partner_insights/get</c> returns cash flow insights for a specified user.
    /// </remarks>
    public Task<CraPartnerInsightsGetResponse> CraPartnerInsightsGet(CraPartnerInsightsGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/cra/partner_insights/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CraPartnerInsightsGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve a CRA Report for provided user
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CraReportGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/cra/report/get</c> retrieves a CRA Report for a user.
    /// </remarks>
    public Task<CraReportGetResponse> CraReportGet(CraReportGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/cra/report/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CraReportGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Create payment token
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentInitiationPaymentTokenCreateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/payment_initiation/payment/token/create</c> endpoint has been deprecated. New Plaid customers will be unable to use this endpoint, and existing customers are encouraged to migrate to the newer, <c>link_token</c>-based flow. The recommended flow is to provide the <c>payment_id</c> to <c>/link/token/create</c>, which returns a <c>link_token</c> used to initialize Link.
    /// <para>
    /// The <c>/payment_initiation/payment/token/create</c> endpoint is used to create a <c>payment_token</c>, which can then be used in Link initialization to enter a payment initiation flow. You can only use a <c>payment_token</c> once. If this attempt fails, the end user aborts the flow, or the token expires, you will need to create a new payment token. Creating a new payment token does not require end user input.
    /// </para>
    /// </remarks>
    public Task<PaymentInitiationPaymentTokenCreateResponse> CreatePaymentToken(PaymentInitiationPaymentTokenCreateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/payment_initiation/payment/token/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<PaymentInitiationPaymentTokenCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve an Asset Report with Freddie Mac format. Only Freddie Mac can use this endpoint.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AssetReportFreddieGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/credit/asset_report/freddie_mac/get</c> endpoint retrieves the Asset Report in Freddie Mac's JSON format.
    /// </remarks>
    public Task<AssetReportFreddieGetResponse> CreditAssetReportFreddieMacGet(AssetReportFreddieGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/credit/asset_report/freddie_mac/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<AssetReportFreddieGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Create Asset or Income Report Audit Copy Token
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreditAuditCopyTokenCreateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Plaid can create an Audit Copy token of an Asset Report and/or Income Report to share with a participating Government-Sponsored Enterprise (GSE) if you participate in Fannie Mae's Day 1 Certainty™ program or utilize Freddie Mac's Loan Product Advisor® (LPA®) Asset and Income Modeler (AIM). An Audit Copy token contains the same underlying data as the Asset Report and/or Income Report (result of <c>/credit/payroll_income/get</c>).
    /// <para>
    /// Use the <c>/credit/audit_copy_token/create</c> endpoint to create an <c>audit_copy_token</c> and then pass that token to the GSE who needs access.
    /// </para>
    /// </remarks>
    public Task<CreditAuditCopyTokenCreateResponse> CreditAuditCopyTokenCreate(CreditAuditCopyTokenCreateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/credit/audit_copy_token/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreditAuditCopyTokenCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Update an Audit Copy Token
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreditAuditCopyTokenUpdateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/credit/audit_copy_token/update</c> endpoint updates an existing Audit Copy Token by adding the report tokens in the <c>report_tokens</c> field to the <c>audit_copy_token</c>. If the Audit Copy Token already contains a report of a certain type, it will be replaced with the token provided in the <c>report_tokens</c> field.
    /// </remarks>
    public Task<CreditAuditCopyTokenUpdateResponse> CreditAuditCopyTokenUpdate(CreditAuditCopyTokenUpdateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/credit/audit_copy_token/update"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreditAuditCopyTokenUpdateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve information from the bank accounts used for employment verification
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreditBankEmploymentGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/beta/credit/v1/bank_employment/get</c> returns the employment report(s) derived from bank transaction data for a specified user.
    /// </remarks>
    public Task<CreditBankEmploymentGetResponse> CreditBankEmploymentGet(CreditBankEmploymentGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/beta/credit/v1/bank_employment/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreditBankEmploymentGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve information from the bank accounts used for income verification
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreditBankIncomeGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/credit/bank_income/get</c> returns the bank income report(s) for a specified user. A single report corresponds to all institutions linked in a single Link session. To include multiple institutions in a single report, use <see href="https://plaid.com/docs/link/multi-item-link">Multi-Item Link</see>. To return older reports, use the <c>options.count</c> field.
    /// </remarks>
    public Task<CreditBankIncomeGetResponse> CreditBankIncomeGet(CreditBankIncomeGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/credit/bank_income/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreditBankIncomeGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve information from the bank accounts used for income verification in PDF format
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/credit/bank_income/pdf/get</c> returns the most recent bank income report for a specified user in PDF format.  A single report corresponds to all institutions linked in a single Link session. To include multiple institutions in a single report, use <see href="https://plaid.com/docs/link/multi-item-link">Multi-Item Link</see>.
    /// </remarks>
    public Task CreditBankIncomePdfGet(CreditBankIncomePdfGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/credit/bank_income/pdf/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            VoidResponse.Instance,
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Refresh a user's bank income information
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreditBankIncomeRefreshResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/credit/bank_income/refresh</c> is deprecated. The backend implementation was removed (returns an <c>Unimplemented</c> error at runtime), and the endpoint is no longer part of the documented API surface. To refresh Bank Income data for an existing user, send the user through Link's update mode so they can confirm their income sources. For a fully backend refresh, migrate to CRA Income Insights and call <c>/cra/check_report/create</c>.
    /// </remarks>
    public Task<CreditBankIncomeRefreshResponse> CreditBankIncomeRefresh(CreditBankIncomeRefreshRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/credit/bank_income/refresh"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreditBankIncomeRefreshResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Subscribe and unsubscribe to proactive notifications for a user's income profile
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreditBankIncomeWebhookUpdateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/credit/bank_income/webhook/update</c> allows you to subscribe or unsubscribe a user for income webhook notifications. By default, all users start out unsubscribed.
    /// <para>
    /// If a user is subscribed, on significant changes to the user's income profile, you will receive a <c>BANK_INCOME_REFRESH_UPDATE</c> webhook, prompting you to refresh bank income data for the user.
    /// </para>
    /// </remarks>
    public Task<CreditBankIncomeWebhookUpdateResponse> CreditBankIncomeWebhookUpdate(CreditBankIncomeWebhookUpdateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/credit/bank_income/webhook/update"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreditBankIncomeWebhookUpdateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve data for a user's uploaded bank statements
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreditBankStatementsUploadsGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/credit/bank_statements/uploads/get</c> returns parsed data from bank statements uploaded by users as part of the Document Income flow. If your account is not enabled for Document Parsing, contact your account manager to request access.
    /// </remarks>
    public Task<CreditBankStatementsUploadsGetResponse> CreditBankStatementsUploadsGet(CreditBankStatementsUploadsGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/credit/bank_statements/uploads/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreditBankStatementsUploadsGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve a summary of an individual's employment information
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreditEmploymentGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/credit/employment/get</c> returns a list of items with employment information from a user's payroll provider that was verified by an end user.
    /// </remarks>
    public Task<CreditEmploymentGetResponse> CreditEmploymentGet(CreditEmploymentGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/credit/employment/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreditEmploymentGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve an Asset Report with Freddie Mac format (aka VOA - Verification Of Assets), and a Verification Of Employment (VOE) report if this one is available. Only Freddie Mac can use this endpoint.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreditFreddieMacReportsGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/credit/freddie_mac/reports/get</c> endpoint retrieves the Verification of Assets and Verification of Employment reports.
    /// </remarks>
    public Task<CreditFreddieMacReportsGetResponse> CreditFreddieMacReportsGet(CreditFreddieMacReportsGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/credit/freddie_mac/reports/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreditFreddieMacReportsGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve a user's payroll information
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreditPayrollIncomeGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint gets payroll income information for a specific user, either as a result of the user connecting to their payroll provider or uploading a pay related document.
    /// </remarks>
    public Task<CreditPayrollIncomeGetResponse> CreditPayrollIncomeGet(CreditPayrollIncomeGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/credit/payroll_income/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreditPayrollIncomeGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Update the parsing configuration for a document income verification
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreditPayrollIncomeParsingConfigUpdateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/credit/payroll_income/parsing_config/update</c> updates the parsing configuration for a document income verification.
    /// </remarks>
    public Task<CreditPayrollIncomeParsingConfigUpdateResponse> CreditPayrollIncomeParsingConfigUpdate(CreditPayrollIncomeParsingConfigUpdateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/credit/payroll_income/parsing_config/update"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreditPayrollIncomeParsingConfigUpdateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Check income verification eligibility and optimize conversion
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreditPayrollIncomePrecheckResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/credit/payroll_income/precheck</c> is an optional endpoint that can be called before initializing a Link session for income verification. It evaluates whether a given user is supportable by digital income verification. If the user is eligible for digital verification, that information will be associated with the user token, and in this way will generate a Link UI optimized for the end user and their specific employer. If the user cannot be confirmed as eligible, the user can still use the income verification flow, but they may be required to manually upload a paystub to verify their income.
    /// <para>
    /// While all request fields are optional, providing <c>employer</c> data will increase the chance of receiving a useful result.
    /// </para>
    /// <para>
    /// When testing in Sandbox, you can control the results by providing special test values in the <c>employer</c> and <c>access_tokens</c> fields. <c>employer_good</c> and <c>employer_bad</c> will result in <c>HIGH</c> and <c>LOW</c> confidence values, respectively. <c>employer_multi</c> will result in a <c>HIGH</c> confidence with multiple payroll options. Likewise, <c>access_good</c> and <c>access_bad</c> will result in <c>HIGH</c> and <c>LOW</c> confidence values, respectively. Any other value for <c>employer</c> and <c>access_tokens</c> in Sandbox will result in <c>UNKNOWN</c> confidence.
    /// </para>
    /// </remarks>
    public Task<CreditPayrollIncomePrecheckResponse> CreditPayrollIncomePrecheck(CreditPayrollIncomePrecheckRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/credit/payroll_income/precheck"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreditPayrollIncomePrecheckResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Refresh a digital payroll income verification
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreditPayrollIncomeRefreshResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/credit/payroll_income/refresh</c> refreshes a given digital payroll income verification.
    /// </remarks>
    public Task<CreditPayrollIncomeRefreshResponse> CreditPayrollIncomeRefresh(CreditPayrollIncomeRefreshRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/credit/payroll_income/refresh"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreditPayrollIncomeRefreshResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve fraud insights for a user's manually uploaded document(s).
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreditPayrollIncomeRiskSignalsGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/credit/payroll_income/risk_signals/get</c> can be used as part of the Document Income flow to assess a user-uploaded document for signs of potential fraud or tampering. It returns a risk score for each uploaded document that indicates the likelihood of the document being fraudulent, in addition to details on the individual risk signals contributing to the score.
    /// <para>
    /// To trigger risk signal generation for an Item, call <c>/link/token/create</c> with <c>parsing_config</c> set to include <c>risk_signals</c>, or call <c>/credit/payroll_income/parsing_config/update</c>. Once risk signal generation has been triggered, <c>/credit/payroll_income/risk_signals/get</c> can be called at any time after the <c>INCOME_VERIFICATION_RISK_SIGNALS</c> webhook has been fired.
    /// </para>
    /// <para>
    /// <c>/credit/payroll_income/risk_signals/get</c> is offered as an add-on to Document Income and is billed separately. To request access to this endpoint, submit a product access request or contact your Plaid account manager.
    /// </para>
    /// </remarks>
    public Task<CreditPayrollIncomeRiskSignalsGetResponse> CreditPayrollIncomeRiskSignalsGet(CreditPayrollIncomeRiskSignalsGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/credit/payroll_income/risk_signals/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreditPayrollIncomeRiskSignalsGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Create a relay token to share an Asset Report with a partner client
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreditRelayCreateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Plaid can share an Asset Report directly with a participating third party on your behalf. The shared Asset Report is the exact same Asset Report originally created in <c>/asset_report/create</c>.
    /// <para>
    /// To grant a third party access to an Asset Report, use the <c>/credit/relay/create</c> endpoint to create a <c>relay_token</c> and then pass that token to your third party. Each third party has its own <c>secondary_client_id</c>; for example, <c>ce5bd328dcd34123456</c>. You'll need to create a separate <c>relay_token</c> for each third party that needs access to the report on your behalf.
    /// </para>
    /// </remarks>
    public Task<CreditRelayCreateResponse> CreditRelayCreate(CreditRelayCreateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/credit/relay/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreditRelayCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve the reports associated with a relay token that was shared with you
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AssetReportGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/credit/relay/get</c> allows third parties to receive a report that was shared with them, using a <c>relay_token</c> that was created by the report owner.
    /// </remarks>
    public Task<AssetReportGetResponse> CreditRelayGet(CreditRelayGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/credit/relay/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<AssetReportGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve the PDF reports associated with a relay token that was shared with you (beta)
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/credit/relay/pdf/get</c> allows third parties to receive a PDF report that was shared with them, using a <c>relay_token</c> that was created by the report owner.
    /// <para>
    /// The <c>/credit/relay/pdf/get</c> endpoint retrieves the Asset Report in PDF format. Before calling <c>/credit/relay/pdf/get</c>, you must first create the Asset Report using <c>/credit/relay/create</c> and then wait for the <see href="https://plaid.com/docs/api/products/assets/#product_ready"><c>PRODUCT_READY</c></see> webhook to fire, indicating that the Report is ready to be retrieved.
    /// </para>
    /// <para>
    /// The response to <c>/credit/relay/pdf/get</c> is the PDF binary data. The <c>request_id</c> is returned in the <c>Plaid-Request-ID</c> header.
    /// </para>
    /// <para>
    /// <see href="https://plaid.com/documents/sample-asset-report.pdf">View a sample PDF Asset Report</see>.
    /// </para>
    /// </remarks>
    public Task CreditRelayPdfGet(CreditRelayPdfGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/credit/relay/pdf/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            VoidResponse.Instance,
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Refresh a report of a relay token
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreditRelayRefreshResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/credit/relay/refresh</c> endpoint allows third parties to refresh a report that was relayed to them, using a <c>relay_token</c> that was created by the report owner. A new report will be created with the original report parameters, but with the most recent data available based on the <c>days_requested</c> value of the original report.
    /// </remarks>
    public Task<CreditRelayRefreshResponse> CreditRelayRefresh(CreditRelayRefreshRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/credit/relay/refresh"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreditRelayRefreshResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Remove relay token
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreditRelayRemoveResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/credit/relay/remove</c> endpoint allows you to invalidate a <c>relay_token</c>. The third party holding the token will no longer be able to access or refresh the reports which the <c>relay_token</c> gives access to. The original report, associated Items, and other relay tokens that provide access to the same report are not affected and will remain accessible after removing the given <c>relay_token</c>.
    /// </remarks>
    public Task<CreditRelayRemoveResponse> CreditRelayRemove(CreditRelayRemoveRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/credit/relay/remove"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreditRelayRemoveResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Remove an Audit Copy token
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreditAuditCopyTokenRemoveResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/credit/audit_copy_token/remove</c> endpoint allows you to remove an Audit Copy. Removing an Audit Copy invalidates the <c>audit_copy_token</c> associated with it, meaning both you and any third parties holding the token will no longer be able to use it to access Report data. Items associated with the Report data and other Audit Copies of it are not affected and will remain accessible after removing the given Audit Copy.
    /// </remarks>
    public Task<CreditAuditCopyTokenRemoveResponse> CreditReportAuditCopyRemove(CreditAuditCopyTokenRemoveRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/credit/audit_copy_token/remove"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreditAuditCopyTokenRemoveResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve Link sessions for your user
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreditSessionsGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint can be used for your end users after they complete the Link flow. This endpoint returns a list of Link sessions that your user completed, where each session includes the results from the Link flow.
    /// <para>
    /// These results include details about the Item that was created and some product related metadata (showing, for example, whether the user finished the bank income verification step).
    /// </para>
    /// </remarks>
    public Task<CreditSessionsGetResponse> CreditSessionsGet(CreditSessionsGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/credit/sessions/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreditSessionsGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve a Dashboard user
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DashboardUserGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/dashboard_user/get</c> endpoint provides details (such as email address) about a specific Dashboard user based on the <c>dashboard_user_id</c> field, which is returned in the <c>audit_trail</c> object of certain Monitor and Beacon endpoints. This can be used to identify the specific reviewer who performed a Dashboard action.
    /// </remarks>
    public Task<DashboardUserGetResponse> DashboardUserGet(DashboardUserGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/dashboard_user/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<DashboardUserGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// List Dashboard users
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DashboardUserListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/dashboard_user/list</c> endpoint provides details (such as email address) about all Dashboard users associated with your account. This can be used to audit or track the list of reviewers for Monitor, Beacon, and Identity Verification products.
    /// </remarks>
    public Task<DashboardUserListResponse> DashboardUserList(DashboardUserListRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/dashboard_user/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<DashboardUserListResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// (Deprecated) Search employer database
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="EmployersSearchResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/employers/search</c> allows you the ability to search Plaid's database of known employers, for use with Deposit Switch. You can use this endpoint to look up a user's employer in order to confirm that they are supported. Users with non-supported employers can then be routed out of the Deposit Switch flow.
    /// <para>
    /// The data in the employer database is currently limited. As the Deposit Switch and Income products progress through their respective beta periods, more employers are being regularly added. Because the employer database is frequently updated, we recommend that you do not cache or store data from this endpoint for more than a day.
    /// </para>
    /// </remarks>
    public Task<EmployersSearchResponse> EmployersSearch(EmployersSearchRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/employers/search"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<EmployersSearchResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// (Deprecated) Retrieve a summary of an individual's employment information
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="EmploymentVerificationGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/employment/verification/get</c> returns a list of employments through a user payroll that was verified by an end user.
    /// <para>
    /// This endpoint has been deprecated; new integrations should use <c>/credit/employment/get</c> instead.
    /// </para>
    /// </remarks>
    public Task<EmploymentVerificationGetResponse> EmploymentVerificationGet(EmploymentVerificationGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/employment/verification/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<EmploymentVerificationGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Get FDX Consent Grant
    /// </summary>
    /// <param name="consentId">Consent Grant Identifier. Uniquely identifies the consent grant</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FdxConsentGrant"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a consent grant by its identifier
    /// </remarks>
    public Task<FdxConsentGrant> FdxConsentsGet(string consentId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/fdx/consents/{consentId}"),
            [new TemplateParam("consentId", consentId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<FdxConsentGrant>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// List FDX Consent Grants for a customer
    /// </summary>
    /// <param name="customerId">Data provider customer identifier whose consent grants to return.</param>
    /// <param name="status">Optional filter restricting results to a single consent grant status. One of <c>ACTIVE</c>, <c>REVOKED</c>, <c>EXPIRED</c>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetConsentsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns zero or more consent grants associated with the given data provider customer, optionally filtered by status.
    /// </remarks>
    public Task<GetConsentsResponse> FdxConsentsList(string customerId,
        FdxConsentGrantStatus? status,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/fdx/consents"),
            [],
            [new Param("customerId", customerId), new Param("status", status)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetConsentsResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve FDX Consent Grant revocation records
    /// </summary>
    /// <param name="consentId">Consent Grant Identifier. Uniquely identifies the consent grant</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FdxConsentRevocations"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the revocation history of a consent grant
    /// </remarks>
    public Task<FdxConsentRevocations> FdxConsentsRevocationGet(string consentId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/fdx/consents/{consentId}/revocation"),
            [new TemplateParam("consentId", consentId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<FdxConsentRevocations>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Revoke FDX Consent Grant
    /// </summary>
    /// <param name="consentId">Consent Grant Identifier. Uniquely identifies the consent grant</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Appends a REVOKED status record to the named consent grant
    /// </remarks>
    public Task FdxConsentsRevoke(string consentId,
        FdxConsentRevocation body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/fdx/consents/{consentId}/revocation"),
            [new TemplateParam("consentId", consentId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            VoidResponse.Instance,
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Webhook receiver for fdx notifications
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// A generic webhook receiver endpoint for FDX Event Notifications
    /// </remarks>
    public Task FdxNotifications(FdxNotificationEntity body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/fdx/notifications"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            VoidResponse.Instance,
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Get Recipient
    /// </summary>
    /// <param name="recipientId">Recipient Identifier. Uniquely identifies the recipient</param>
    /// <param name="oauthStateId">The value that is passed into the OAuth URI 'state' query parameter.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FdxRecipientMetadata"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get a specific recipient
    /// </remarks>
    public Task<FdxRecipientMetadata> GetRecipient(string recipientId,
        string? oauthStateId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/fdx/recipient/{recipientId}"),
            [new TemplateParam("recipientId", recipientId)],
            [],
            [new HeaderParam("OAUTH-STATE-ID", oauthStateId)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<FdxRecipientMetadata>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Get Recipients
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetRecipientsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of Recipients
    /// </remarks>
    public Task<GetRecipientsResponse> GetRecipients(RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/fdx/recipients"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetRecipientsResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Returns uploaded document identity
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IdentityDocumentsUploadsGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use <c>/identity/documents/uploads/get</c> to retrieve identity details when using <see href="https://plaid.com/docs/identity/identity-document-upload/">Identity Document Upload</see>.
    /// </remarks>
    public Task<IdentityDocumentsUploadsGetResponse> IdentityDocumentsUploadsGet(IdentityDocumentsUploadsGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/identity/documents/uploads/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<IdentityDocumentsUploadsGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve identity data
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IdentityGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/identity/get</c> endpoint allows you to retrieve various account holder information on file with the financial institution, including names, emails, phone numbers, and addresses. Only name data is guaranteed to be returned; other fields will be empty arrays if not provided by the institution.
    /// <para>
    /// Note: In API versions 2018-05-22 and earlier, the <c>owners</c> object is not returned, and instead identity information is returned in the top level <c>identity</c> object. For more details, see <see href="https://plaid.com/docs/api/versioning/#version-2019-05-29">Plaid API versioning</see>.
    /// </para>
    /// </remarks>
    public Task<IdentityGetResponse> IdentityGet(IdentityGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/identity/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<IdentityGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve identity match score
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IdentityMatchResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/identity/match</c> endpoint generates a match score, which indicates how well the provided identity data matches the identity information on file with the account holder's financial institution.
    /// <para>
    /// Fields within the <c>balances</c> object will always be null when retrieved by <c>/identity/match</c>. Instead, use the free <c>/accounts/get</c> endpoint to request balance cached data, or <c>/accounts/balance/get</c> or <c>/signal/evaluate</c> for real-time data.
    /// </para>
    /// </remarks>
    public Task<IdentityMatchResponse> IdentityMatch(IdentityMatchRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/identity/match"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<IdentityMatchResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Refresh identity data
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IdentityRefreshResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/identity/refresh</c> is an optional endpoint for users of the Identity product. It initiates an on-demand extraction to fetch the most up to date Identity information from the Financial Institution. This on-demand extraction takes place in addition to the periodic extractions that automatically occur for any Identity-enabled Item. If changes to Identity are discovered after calling <c>/identity/refresh</c>, Plaid will fire a webhook <see href="https://plaid.com/docs/api/products/identity/#default_update"><c>DEFAULT_UPDATE</c></see>.
    /// <para>
    /// As this endpoint triggers a synchronous request for fresh data, latency may be higher than for other Plaid endpoints (typically less than 10 seconds, but occasionally up to 30 seconds or more); if you encounter errors, you may find it necessary to adjust your timeout period when making requests.
    /// </para>
    /// <para>
    /// <c>/identity/refresh</c> is offered as an add-on to Identity and has a separate <see href="https://plaid.com/docs/account/billing/#per-request-flat-fee">fee model</see>. To request access to this endpoint, submit a <see href="https://dashboard.plaid.com/team/products">product access request</see> or contact your Plaid account manager.
    /// </para>
    /// </remarks>
    public Task<IdentityRefreshResponse> IdentityRefresh(IdentityRefreshRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/identity/refresh"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<IdentityRefreshResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Create autofill for an Identity Verification
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IdentityVerificationAutofillCreateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Try to autofill an Identity Verification based on the provided phone number, date of birth and country of residence.
    /// </remarks>
    public Task<IdentityVerificationAutofillCreateResponse> IdentityVerificationAutofillCreate(IdentityVerificationAutofillCreateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/identity_verification/autofill/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<IdentityVerificationAutofillCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Create a new Identity Verification
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IdentityVerificationCreateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a new Identity Verification for the user specified by the <c>client_user_id</c> and/or <c>user_id</c> field. At least one of these two fields must be provided. The requirements and behavior of the verification are determined by the <c>template_id</c> provided. If <c>user_id</c> is provided, there must be an associated user; otherwise, an error will be returned.
    /// <para>
    ///
    /// If you don't know whether an active Identity Verification exists for a given <c>client_user_id</c> and/or <c>user_id</c>, you can specify <c>"is_idempotent": true</c> in the request body. With idempotency enabled, a new Identity Verification will only be created if one does not already exist for the associated <c>client_user_id</c> and/or <c>user_id</c>, and <c>template_id</c>. If an Identity Verification is found, it will be returned unmodified with a <c>200 OK</c> HTTP status code.
    /// </para>
    /// <para>
    ///
    /// If <c>user_id</c> is not provided, you can also use this endpoint to supply information you already have collected about the user; if any of these fields are specified, the screens prompting the user to enter them will be skipped during the Link flow. If <c>user_id</c> is provided, user information can not be included in the request body. Please use the <c>/user/update</c> endpoint to update user data instead.
    /// </para>
    /// </remarks>
    public Task<IdentityVerificationCreateResponse> IdentityVerificationCreate(IdentityVerificationCreateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/identity_verification/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<IdentityVerificationCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve Identity Verification
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IdentityVerificationGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieve a previously created Identity Verification.
    /// </remarks>
    public Task<IdentityVerificationGetResponse> IdentityVerificationGet(IdentityVerificationGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/identity_verification/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<IdentityVerificationGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// List Identity Verifications
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IdentityVerificationListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Filter and list Identity Verifications created by your account
    /// </remarks>
    public Task<IdentityVerificationListResponse> IdentityVerificationList(IdentityVerificationListRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/identity_verification/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<IdentityVerificationListResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retry an Identity Verification
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IdentityVerificationRetryResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Allow a customer to retry their Identity Verification
    /// </remarks>
    public Task<IdentityVerificationRetryResponse> IdentityVerificationRetry(IdentityVerificationRetryRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/identity_verification/retry"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<IdentityVerificationRetryResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// (Deprecated) Create an income verification instance
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IncomeVerificationCreateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/income/verification/create</c> begins the income verification process by returning an <c>income_verification_id</c>. You can then provide the <c>income_verification_id</c> to <c>/link/token/create</c> under the <c>income_verification</c> parameter in order to create a Link instance that will prompt the user to go through the income verification flow. Plaid will fire an <c>INCOME</c> webhook once the user completes the Payroll Income flow, or when the uploaded documents in the Document Income flow have finished processing.
    /// </remarks>
    public Task<IncomeVerificationCreateResponse> IncomeVerificationCreate(IncomeVerificationCreateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/income/verification/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<IncomeVerificationCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// (Deprecated) Download the original documents used for income verification
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/income/verification/documents/download</c> provides the ability to download the source documents associated with the verification.
    /// <para>
    /// If Document Income was used, the documents will be those the user provided in Link. For Payroll Income, the most recent files available for download from the payroll provider will be available from this endpoint.
    /// </para>
    /// <para>
    /// The response to <c>/income/verification/documents/download</c> is a ZIP file in binary data. If a <c>document_id</c> is passed, a single document will be contained in this file.
    /// If not, the response will contain all documents associated with the verification.
    /// </para>
    /// <para>
    /// The <c>request_id</c> is returned in the <c>Plaid-Request-ID</c> header.
    /// </para>
    /// </remarks>
    public Task IncomeVerificationDocumentsDownload(IncomeVerificationDocumentsDownloadRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/income/verification/documents/download"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            VoidResponse.Instance,
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// (Deprecated) Retrieve information from the paystubs used for income verification
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IncomeVerificationPaystubsGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/income/verification/paystubs/get</c> returns the information collected from the paystubs that were used to verify an end user's income. It can be called once the status of the verification has been set to <c>VERIFICATION_STATUS_PROCESSING_COMPLETE</c>, as reported by the <c>INCOME: verification_status</c> webhook. Attempting to call the endpoint before verification has been completed will result in an error.
    /// <para>
    /// This endpoint has been deprecated; new integrations should use <c>/credit/payroll_income/get</c> instead.
    /// </para>
    /// </remarks>
    public Task<IncomeVerificationPaystubsGetResponse> IncomeVerificationPaystubsGet(IncomeVerificationPaystubsGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/income/verification/paystubs/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<IncomeVerificationPaystubsGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// (Deprecated) Check digital income verification eligibility and optimize conversion
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IncomeVerificationPrecheckResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/income/verification/precheck</c> is an optional endpoint that can be called before initializing a Link session for income verification. It evaluates whether a given user is supportable by digital income verification and returns a <c>precheck_id</c> that can be provided to <c>/link/token/create</c>. If the user is eligible for digital verification, providing the <c>precheck_id</c> in this way will generate a Link UI optimized for the end user and their specific employer. If the user cannot be confirmed as eligible, the <c>precheck_id</c> can still be provided to <c>/link/token/create</c> and the user can still use the income verification flow, but they may be required to manually upload a paystub to verify their income.
    /// <para>
    /// While all request fields are optional, providing either <c>employer</c> or <c>transactions_access_tokens</c> data will increase the chance of receiving a useful result.
    /// </para>
    /// <para>
    /// This endpoint has been deprecated; new integrations should use <c>/credit/payroll_income/precheck</c> instead.
    /// </para>
    /// </remarks>
    public Task<IncomeVerificationPrecheckResponse> IncomeVerificationPrecheck(IncomeVerificationPrecheckRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/income/verification/precheck"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<IncomeVerificationPrecheckResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// (Deprecated) Retrieve information from the tax documents used for income verification
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IncomeVerificationTaxformsGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/income/verification/taxforms/get</c> returns the information collected from forms that were used to verify an end user''s income. It can be called once the status of the verification has been set to <c>VERIFICATION_STATUS_PROCESSING_COMPLETE</c>, as reported by the <c>INCOME: verification_status</c> webhook. Attempting to call the endpoint before verification has been completed will result in an error.
    /// <para>
    /// This endpoint has been deprecated; new integrations should use <c>/credit/payroll_income/get</c> instead.
    /// </para>
    /// </remarks>
    public Task<IncomeVerificationTaxformsGetResponse> IncomeVerificationTaxformsGet(IncomeVerificationTaxformsGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/income/verification/taxforms/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<IncomeVerificationTaxformsGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Get details of all supported institutions
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="InstitutionsGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a JSON response containing details on all financial institutions currently supported by Plaid. Because Plaid supports thousands of institutions, results are paginated.
    /// <para>
    /// If there is no overlap between an institution's enabled products and a client's enabled products, then the institution will be filtered out from the response. As a result, the number of institutions returned may not match the count specified in the call.
    /// </para>
    /// </remarks>
    public Task<InstitutionsGetResponse> InstitutionsGet(InstitutionsGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/institutions/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<InstitutionsGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Get details of an institution
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="InstitutionsGetByIdResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a JSON response containing details on a specified financial institution currently supported by Plaid.
    /// <para>
    /// Versioning note: API versions 2019-05-29 and earlier allow use of the <c>public_key</c> parameter instead of the <c>client_id</c> and <c>secret</c> to authenticate to this endpoint. The <c>public_key</c> has been deprecated; all customers are encouraged to use <c>client_id</c> and <c>secret</c> instead.
    /// </para>
    /// </remarks>
    public Task<InstitutionsGetByIdResponse> InstitutionsGetById(InstitutionsGetByIdRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/institutions/get_by_id"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<InstitutionsGetByIdResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Search institutions
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="InstitutionsSearchResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a JSON response containing details for institutions that match the query parameters, up to a maximum of ten institutions per query.
    /// <para>
    /// Versioning note: API versions 2019-05-29 and earlier allow use of the <c>public_key</c> parameter instead of the <c>client_id</c> and <c>secret</c> parameters to authenticate to this endpoint. The <c>public_key</c> parameter has since been deprecated; all customers are encouraged to use <c>client_id</c> and <c>secret</c> instead.
    /// </para>
    /// </remarks>
    public Task<InstitutionsSearchResponse> InstitutionsSearch(InstitutionsSearchRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/institutions/search"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<InstitutionsSearchResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Get data needed to authorize an investments transfer
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="InvestmentsAuthGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/investments/auth/get</c> endpoint allows developers to receive user-authorized data to facilitate the transfer of holdings
    /// </remarks>
    public Task<InvestmentsAuthGetResponse> InvestmentsAuthGet(InvestmentsAuthGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/investments/auth/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<InvestmentsAuthGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Get Investment holdings
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="InvestmentsHoldingsGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/investments/holdings/get</c> endpoint allows developers to receive user-authorized stock position data for <c>investment</c>-type accounts.
    /// </remarks>
    public Task<InvestmentsHoldingsGetResponse> InvestmentsHoldingsGet(InvestmentsHoldingsGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/investments/holdings/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<InvestmentsHoldingsGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Refresh investment data
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="InvestmentsRefreshResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/investments/refresh</c> is an optional endpoint for users of the Investments product. It initiates an on-demand extraction to fetch the newest investment holdings and transactions for an Item. This on-demand extraction takes place in addition to the periodic extractions that automatically occur one or more times per day for any Investments-enabled Item. If changes to investments are discovered after calling <c>/investments/refresh</c>, Plaid will fire webhooks: <see href="https://plaid.com/docs/api/products/investments/#holdings-default_update"><c>HOLDINGS: DEFAULT_UPDATE</c></see> if any new holdings are detected, and <see href="https://plaid.com/docs/api/products/investments/#investments_transactions-default_update"><c>INVESTMENTS_TRANSACTIONS: DEFAULT_UPDATE</c></see> if any new investment transactions are detected. This webhook will typically not fire in the Sandbox environment, due to the lack of dynamic investment transactions and holdings data. To test this webhook in Sandbox, call <c>/sandbox/item/fire_webhook</c>. Updated holdings and investment transactions can be fetched by calling <c>/investments/holdings/get</c> and <c>/investments/transactions/get</c>. Note that the <c>/investments/refresh</c> endpoint is not supported by all institutions. If called on an Item from an institution that does not support this functionality, it will return a <c>PRODUCT_NOT_SUPPORTED</c> error.
    /// <para>
    /// As this endpoint triggers a synchronous request for fresh data, latency may be higher than for other Plaid endpoints (typically less than 10 seconds, but occasionally up to 30 seconds or more); if you encounter errors, you may find it necessary to adjust your timeout period when making requests.
    /// </para>
    /// <para>
    /// <c>/investments/refresh</c> is offered as an add-on to Investments and has a separate <see href="https://plaid.com/docs/account/billing/#per-request-flat-fee">fee model</see>. To request access to this endpoint, submit a <see href="https://dashboard.plaid.com/team/products">product access request</see> or contact your Plaid account manager.
    /// </para>
    /// </remarks>
    public Task<InvestmentsRefreshResponse> InvestmentsRefresh(InvestmentsRefreshRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/investments/refresh"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<InvestmentsRefreshResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Get investment transactions
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="InvestmentsTransactionsGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/investments/transactions/get</c> endpoint allows developers to retrieve up to 24 months of user-authorized transaction data for investment accounts.
    /// <para>
    /// Transactions are returned in reverse-chronological order, and the sequence of transaction ordering is stable and will not shift.
    /// </para>
    /// <para>
    /// Due to the potentially large number of investment transactions associated with an Item, results are paginated. Manipulate the count and offset parameters in conjunction with the <c>total_investment_transactions</c> response body field to fetch all available investment transactions.
    /// </para>
    /// <para>
    /// Note that Investments does not have a webhook to indicate when initial transaction data has loaded (unless you use the <c>async_update</c> option). Instead, if transactions data is not ready when <c>/investments/transactions/get</c> is first called, Plaid will wait for the data. For this reason, calling <c>/investments/transactions/get</c> immediately after Link may take up to one to two minutes to return.
    /// </para>
    /// <para>
    /// Data returned by the asynchronous investments extraction flow (when <c>async_update</c> is set to true) may not be immediately available to <c>/investments/transactions/get</c>. To be alerted when the data is ready to be fetched, listen for the <c>HISTORICAL_UPDATE</c> webhook. If no investments history is ready when <c>/investments/transactions/get</c> is called, it will return a <c>PRODUCT_NOT_READY</c> error.
    /// </para>
    /// </remarks>
    public Task<InvestmentsTransactionsGetResponse> InvestmentsTransactionsGet(InvestmentsTransactionsGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/investments/transactions/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<InvestmentsTransactionsGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Get an Issue
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IssuesGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieve detailed information about a specific <c>Issue</c>. This endpoint returns a single <c>Issue</c> object.
    /// </remarks>
    public Task<IssuesGetResponse> IssuesGet(IssuesGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/issues/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<IssuesGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Search for an Issue
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IssuesSearchResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Search for an issue associated with one of the following identifiers:  <c>item_id</c>, <c>link_session_id</c> or Link session <c>request_id</c>. This endpoint returns a list of <c>Issue</c> objects, with an empty list indicating that no issues are associated with the provided identifier. At least one of the identifiers must be provided to perform the search.
    /// </remarks>
    public Task<IssuesSearchResponse> IssuesSearch(IssuesSearchRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/issues/search"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<IssuesSearchResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Subscribe to an Issue
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IssuesSubscribeResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Allows a user to subscribe to updates on a specific <c>Issue</c> using a POST method. Subscribers will receive webhook notifications when the issue status changes, particularly when resolved.
    /// </remarks>
    public Task<IssuesSubscribeResponse> IssuesSubscribe(IssuesSubscribeRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/issues/subscribe"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<IssuesSubscribeResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Invalidate access_token
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ItemAccessTokenInvalidateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// By default, the <c>access_token</c> associated with an Item does not expire and should be stored in a persistent, secure manner.
    /// <para>
    /// You can use the <c>/item/access_token/invalidate</c> endpoint to rotate the <c>access_token</c> associated with an Item. The endpoint returns a new <c>access_token</c> and immediately invalidates the previous <c>access_token</c>.
    /// </para>
    /// </remarks>
    public Task<ItemAccessTokenInvalidateResponse> ItemAccessTokenInvalidate(ItemAccessTokenInvalidateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/item/access_token/invalidate"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ItemAccessTokenInvalidateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// List a historical log of user consent events
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ItemActivityListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List a historical log of user consent events
    /// </remarks>
    public Task<ItemActivityListResponse> ItemActivityList(ItemActivityListRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/item/activity/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ItemActivityListResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// List a user's connected applications
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ItemApplicationListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List a user's connected applications
    /// </remarks>
    public Task<ItemApplicationListResponse> ItemApplicationList(ItemApplicationListRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/item/application/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ItemApplicationListResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Update the scopes of access for a particular application
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ItemApplicationScopesUpdateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Enable consumers to update product access on selected accounts for an application.
    /// </remarks>
    public Task<ItemApplicationScopesUpdateResponse> ItemApplicationScopesUpdate(ItemApplicationScopesUpdateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/item/application/scopes/update"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ItemApplicationScopesUpdateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Unlink a user's connected application
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ItemApplicationUnlinkResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Unlink a user's connected application. On an unlink request, Plaid will immediately revoke the Application's access to the User's data.  The User will have to redo the OAuth authentication process in order to restore functionality.
    /// <para>
    /// This endpoint only removes ongoing data access permissions, therefore the User will need to reach out to the Application itself in order to disable and delete their account and delete any data that the Application already received (if the Application does not do so by default).
    /// </para>
    /// <para>
    /// This endpoint should be called in real time as the User is unlinking an Application, and should not be batched in order to ensure that the change is reflected as soon as possible.
    /// </para>
    /// </remarks>
    public Task<ItemApplicationUnlinkResponse> ItemApplicationUnlink(ItemApplicationUnlinkRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/item/application/unlink"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ItemApplicationUnlinkResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// (Deprecated) Create public token
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ItemPublicTokenCreateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Note: As of July 2020, the <c>/item/public_token/create</c> endpoint is deprecated. Instead, use <c>/link/token/create</c> with an <c>access_token</c> to create a Link token for use with <see href="https://plaid.com/docs/link/update-mode">update mode</see>.
    /// <para>
    /// If you need your user to take action to restore or resolve an error associated with an Item, generate a public token with the <c>/item/public_token/create</c> endpoint and then initialize Link with that <c>public_token</c>.
    /// </para>
    /// <para>
    /// A <c>public_token</c> is one-time use and expires after 30 minutes. You use a <c>public_token</c> to initialize Link in <see href="https://plaid.com/docs/link/update-mode">update mode</see> for a particular Item. You can generate a <c>public_token</c> for an Item even if you did not use Link to create the Item originally.
    /// </para>
    /// <para>
    /// The <c>/item/public_token/create</c> endpoint is <b>not</b> used to create your initial <c>public_token</c>. If you have not already received an <c>access_token</c> for a specific Item, use Link to obtain your <c>public_token</c> instead. See the <see href="https://plaid.com/docs/quickstart">Quickstart</see> for more information.
    /// </para>
    /// </remarks>
    public Task<ItemPublicTokenCreateResponse> ItemCreatePublicToken(ItemPublicTokenCreateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/item/public_token/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ItemPublicTokenCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve an Item
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ItemGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns information about the status of an Item.
    /// </remarks>
    public Task<ItemGetResponse> ItemGet(ItemGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/item/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ItemGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Import Item
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ItemImportResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/item/import</c> creates an Item via your Plaid Exchange Integration and returns an <c>access_token</c>. As part of an <c>/item/import</c> request, you will include a User ID (<c>user_auth.user_id</c>) and Authentication Token (<c>user_auth.auth_token</c>) that enable data aggregation through your Plaid Exchange API endpoints. These authentication principals are to be chosen by you.
    /// <para>
    /// Upon creating an Item via <c>/item/import</c>, Plaid will automatically begin an extraction of that Item through the Plaid Exchange infrastructure you have already integrated.
    /// </para>
    /// </remarks>
    public Task<ItemImportResponse> ItemImport(ItemImportRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/item/import"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ItemImportResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Terminate products for an Item
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ItemProductsTerminateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/item/products/terminate</c> endpoint allows you to terminate an Item. Once terminated, the <c>access_token</c> associated with the Item is no longer valid, billing for the Item's products is ended, and relevant webhooks are fired.
    /// <para>
    /// <c>/item/products/terminate</c> is the recommended way to offboard users or disconnect accounts linked via Plaid.
    /// </para>
    /// </remarks>
    public Task<ItemProductsTerminateResponse> ItemProductsTerminate(ItemProductsTerminateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/item/products/terminate"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ItemProductsTerminateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Exchange public token for an access token
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ItemPublicTokenExchangeResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Exchange a Link <c>public_token</c> for an API <c>access_token</c>. Link hands off the <c>public_token</c> client-side via the <c>onSuccess</c> callback once a user has successfully created an Item. The <c>public_token</c> is ephemeral and expires after 30 minutes. An <c>access_token</c> does not expire, but can be revoked by calling <c>/item/remove</c>.
    /// <para>
    /// The response also includes an <c>item_id</c> that should be stored with the <c>access_token</c>. The <c>item_id</c> is used to identify an Item in a webhook. The <c>item_id</c> can also be retrieved by making an <c>/item/get</c> request.
    /// </para>
    /// </remarks>
    public Task<ItemPublicTokenExchangeResponse> ItemPublicTokenExchange(ItemPublicTokenExchangeRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/item/public_token/exchange"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ItemPublicTokenExchangeResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Remove an Item
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ItemRemoveResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/item/remove</c> endpoint allows you to remove an Item. Once removed, the <c>access_token</c>, as well as any processor tokens or bank account tokens associated with the Item, is no longer valid and cannot be used to access any data that was associated with the Item.
    /// <para>
    /// Calling <c>/item/remove</c> is a recommended best practice when offboarding users or if a user chooses to disconnect an account linked via Plaid. For subscription products, such as Transactions, Liabilities, and Investments, calling <c>/item/remove</c> is required to end subscription billing for the Item, unless the end user revoked permission (e.g. via <see href="https://my.plaid.com/">https://my.plaid.com/</see>). For more details, see <see href="https://plaid.com/docs/account/billing/#subscription-fee">Subscription fee model</see>.
    /// </para>
    /// <para>
    /// On a Trial plan, calling <c>/item/remove</c> does not impact the number of remaining Trial Items (bank connections) you have available.
    /// </para>
    /// <para>
    /// Removing an Item does not affect any Asset Reports or Audit Copies you have already created, which will remain accessible until you remove access to them specifically using the <c>/asset_report/remove</c> endpoint.
    /// </para>
    /// <para>
    /// Also note that for certain OAuth-based institutions, an Item removed via <c>/item/remove</c> may still show as an active connection in the institution's OAuth permission manager.
    /// </para>
    /// <para>
    /// API versions 2019-05-29 and earlier return a <c>removed</c> boolean as part of the response.
    /// </para>
    /// </remarks>
    public Task<ItemRemoveResponse> ItemRemove(ItemRemoveRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/item/remove"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ItemRemoveResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Update Webhook URL
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ItemWebhookUpdateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The POST <c>/item/webhook/update</c> allows you to update the webhook URL associated with an Item. This request triggers a <see href="https://plaid.com/docs/api/items/#webhook_update_acknowledged"><c>WEBHOOK_UPDATE_ACKNOWLEDGED</c></see> webhook to the newly specified webhook URL.
    /// </remarks>
    public Task<ItemWebhookUpdateResponse> ItemWebhookUpdate(ItemWebhookUpdateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/item/webhook/update"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ItemWebhookUpdateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve Liabilities data
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="LiabilitiesGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/liabilities/get</c> endpoint returns various details about an Item with loan or credit accounts. Liabilities data is available primarily for US financial institutions, with some limited coverage of Canadian institutions. Currently supported account types are account type <c>credit</c> with account subtype <c>credit card</c> or <c>paypal</c>, and account type <c>loan</c> with account subtype <c>student</c> or <c>mortgage</c>. To limit accounts listed in Link to types and subtypes supported by Liabilities, you can use the <c>account_filters</c> parameter when <see href="https://plaid.com/docs/api/link/#linktokencreate">creating a Link token</see>.
    /// <para>
    /// The types of information returned by Liabilities can include balances and due dates, loan terms, and account details such as original loan amount and guarantor. Data is refreshed approximately once per day; the latest data can be retrieved by calling <c>/liabilities/get</c>.
    /// </para>
    /// </remarks>
    public Task<LiabilitiesGetResponse> LiabilitiesGet(LiabilitiesGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/liabilities/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<LiabilitiesGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Create Hosted Link session
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="LinkDeliveryCreateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/link_delivery/create</c> endpoint to create a Hosted Link session.
    /// </remarks>
    public Task<LinkDeliveryCreateResponse> LinkDeliveryCreate(LinkDeliveryCreateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/link_delivery/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<LinkDeliveryCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Get Hosted Link session
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="LinkDeliveryGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/link_delivery/get</c> endpoint to get the status of a Hosted Link session.
    /// </remarks>
    public Task<LinkDeliveryGetResponse> LinkDeliveryGet(LinkDeliveryGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/link_delivery/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<LinkDeliveryGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Exchange the Link Correlation ID for a Link Token
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="LinkOAuthCorrelationIdExchangeResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Exchange an OAuth <c>link_correlation_id</c> for the corresponding <c>link_token</c>. The <c>link_correlation_id</c> is only available for <c>payment_initiation</c> products and is provided to the client via the OAuth <c>redirect_uri</c> as a query parameter.
    /// The <c>link_correlation_id</c> is ephemeral and expires in a brief period, after which it can no longer be exchanged for the <c>link_token</c>.
    /// </remarks>
    public Task<LinkOAuthCorrelationIdExchangeResponse> LinkOauthCorrelationIdExchange(LinkOAuthCorrelationIdExchangeRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/link/oauth/correlation_id/exchange"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<LinkOAuthCorrelationIdExchangeResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Create Link Token
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="LinkTokenCreateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/link/token/create</c> endpoint creates a <c>link_token</c>, which is required as a parameter when initializing Link. Once Link has been initialized, it returns a <c>public_token</c>. For most Plaid products, the <c>public_token</c> is saved and exchanged for an <c>access_token</c> via <c>/item/public_token/exchange</c> as part of the main Link flow. For more details, see the <see href="https://plaid.com/docs/link/#link-flow-overview">Link flow overview</see>.
    /// <para>
    /// A <c>link_token</c> generated by <c>/link/token/create</c> is also used to initialize other Link flows, such as the <see href="https://plaid.com/docs/link/update-mode">update mode</see> flow for tokens with expired credentials, or the Identity Verification flow.
    /// </para>
    /// </remarks>
    public Task<LinkTokenCreateResponse> LinkTokenCreate(LinkTokenCreateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/link/token/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<LinkTokenCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Get Link Token
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="LinkTokenGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/link/token/get</c> endpoint gets information about a Link session, including all callbacks fired during the session along with their metadata, including the public token. This endpoint is used with Link flows that don't provide a public token via frontend callbacks, such as the <see href="https://plaid.com/docs/link/hosted-link/">Hosted Link flow</see> and the <see href="https://plaid.com/docs/link/multi-item-link/">Multi-Item Link flow</see>. It also can be useful for debugging purposes.
    /// <para>
    /// By default, this endpoint will only return complete event data for Hosted Link sessions. To use <c>/link/token/get</c> to retrieve event data for non-Hosted-Link sessions, contact your account manager to request that your account be enabled for Link events. If you do not have an account manager, you can submit this request via a support ticket. Enablement for Link events will also cause you to receive additional webhooks related to Link events, such as the <c>SESSION_FINISHED</c> and <c>EVENTS</c> webhook.
    /// </para>
    /// </remarks>
    public Task<LinkTokenGetResponse> LinkTokenGet(LinkTokenGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/link/token/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<LinkTokenGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Check a user's Plaid Network status
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="NetworkStatusGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/network/status/get</c> endpoint can be used to check whether Plaid has a matching profile for the user.
    /// This is useful for determining if a user is eligible for a streamlined experience, such as Layer. To access this endpoint, contact your Plaid account manager.
    /// <para>
    /// Note: it is strongly recommended to check for Layer eligibility in the frontend. <c>/network/status/get</c> should only be used for checking Layer eligibility if a frontend check is not possible for your use case.
    /// For instructions on performing a frontend eligibility check, see the <see href="https://plaid.com/docs/layer/#integration-overview">Layer documentation</see>.
    /// </para>
    /// </remarks>
    public Task<NetworkStatusGetResponse> NetworkStatusGet(NetworkStatusGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/network/status/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<NetworkStatusGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Get metadata about an OAuth token
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OAuthIntrospectResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/oauth/introspect</c> returns metadata about an access token or refresh token.
    /// <para>
    /// Note: This endpoint supports <c>Content-Type: application/x-www-form-urlencoded</c> as well as JSON. The fields for the form are equivalent to the fields for JSON and conform to the OAuth 2.0 specification.
    /// </para>
    /// </remarks>
    public Task<OAuthIntrospectResponse> OauthIntrospect(OAuthIntrospectRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/oauth/introspect"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<OAuthIntrospectResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Revoke an OAuth token
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OAuthRevokeResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/oauth/revoke</c> revokes an access or refresh token, preventing any further use. If a refresh token is revoked, all access and refresh tokens derived from it are also revoked, including exchanged tokens.
    /// <para>
    /// Note: This endpoint supports <c>Content-Type: application/x-www-form-urlencoded</c> as well as JSON. The fields for the form are equivalent to the fields for JSON and conform to the OAuth 2.0 specification.
    /// </para>
    /// </remarks>
    public Task<OAuthRevokeResponse> OauthRevoke(OAuthRevokeRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/oauth/revoke"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<OAuthRevokeResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Create or refresh an OAuth access token
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OAuthTokenResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/oauth/token</c> issues an access token and refresh token depending on the <c>grant_type</c> provided. This endpoint supports <c>Content-Type: application/x-www-form-urlencoded</c> as well as JSON. The fields for the form are equivalent to the fields for JSON and conform to the OAuth 2.0 specification.
    /// </remarks>
    public Task<OAuthTokenResponse> OauthToken(OAuthTokenRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/oauth/token"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<OAuthTokenResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Creates a new end customer for a Plaid reseller.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PartnerCustomerCreateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/partner/customer/create</c> endpoint is used by reseller partners to create end customers. To create end customers, it should be called in the Production environment only, even when creating Sandbox API keys. If called in the Sandbox environment, it will return a sample response, but no customer will be created and the API keys will not be valid.
    /// </remarks>
    public Task<PartnerCustomerCreateResponse> PartnerCustomerCreate(PartnerCustomerCreateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/partner/customer/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<PartnerCustomerCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Enables a Plaid reseller's end customer in the Production environment.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PartnerCustomerEnableResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/partner/customer/enable</c> endpoint is used by reseller partners to enable an end customer in the full Production environment.
    /// </remarks>
    public Task<PartnerCustomerEnableResponse> PartnerCustomerEnable(PartnerCustomerEnableRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/partner/customer/enable"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<PartnerCustomerEnableResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Returns a Plaid reseller's end customer.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PartnerCustomerGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/partner/customer/get</c> endpoint is used by reseller partners to retrieve data about a single end customer.
    /// </remarks>
    public Task<PartnerCustomerGetResponse> PartnerCustomerGet(PartnerCustomerGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/partner/customer/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<PartnerCustomerGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Returns OAuth-institution registration information for a given end customer.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PartnerCustomerOAuthInstitutionsGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/partner/customer/oauth_institutions/get</c> endpoint is used by reseller partners to retrieve OAuth-institution registration information about a single end customer. To learn how to set up a webhook to listen to status update events, visit the <see href="https://plaid.com/docs/account/resellers/#enabling-end-customers">reseller documentation</see>.
    /// </remarks>
    public Task<PartnerCustomerOAuthInstitutionsGetResponse> PartnerCustomerOauthInstitutionsGet(PartnerCustomerOAuthInstitutionsGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/partner/customer/oauth_institutions/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<PartnerCustomerOAuthInstitutionsGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Removes a Plaid reseller's end customer.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PartnerCustomerRemoveResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/partner/customer/remove</c> endpoint is used by reseller partners to remove an end customer. Removing an end customer will remove it from view in the Plaid Dashboard and deactivate its API keys. This endpoint can only be used to remove an end customer that has not yet been enabled in full Production.
    /// </remarks>
    public Task<PartnerCustomerRemoveResponse> PartnerCustomerRemove(PartnerCustomerRemoveRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/partner/customer/remove"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<PartnerCustomerRemoveResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Create payment consent
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentInitiationConsentCreateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/payment_initiation/consent/create</c> endpoint is used to create a payment consent, which can be used to initiate payments on behalf of the user. Payment consents are created with <c>UNAUTHORISED</c> status by default and must be authorised by the user before payments can be initiated.
    /// <para>
    /// Consents can be limited in time and scope, and have constraints that describe limitations for payments.
    /// </para>
    /// </remarks>
    public Task<PaymentInitiationConsentCreateResponse> PaymentInitiationConsentCreate(PaymentInitiationConsentCreateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/payment_initiation/consent/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<PaymentInitiationConsentCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Get payment consent
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentInitiationConsentGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/payment_initiation/consent/get</c> endpoint can be used to check the status of a payment consent, as well as to receive basic information such as recipient and constraints.
    /// </remarks>
    public Task<PaymentInitiationConsentGetResponse> PaymentInitiationConsentGet(PaymentInitiationConsentGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/payment_initiation/consent/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<PaymentInitiationConsentGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Execute a single payment using consent
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentInitiationConsentPaymentExecuteResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/payment_initiation/consent/payment/execute</c> endpoint can be used to execute payments using payment consent.
    /// </remarks>
    public Task<PaymentInitiationConsentPaymentExecuteResponse> PaymentInitiationConsentPaymentExecute(PaymentInitiationConsentPaymentExecuteRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/payment_initiation/consent/payment/execute"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<PaymentInitiationConsentPaymentExecuteResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Revoke payment consent
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentInitiationConsentRevokeResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/payment_initiation/consent/revoke</c> endpoint can be used to revoke the payment consent. Once the consent is revoked, it is not possible to initiate payments using it.
    /// </remarks>
    public Task<PaymentInitiationConsentRevokeResponse> PaymentInitiationConsentRevoke(PaymentInitiationConsentRevokeRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/payment_initiation/consent/revoke"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<PaymentInitiationConsentRevokeResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Create a payment
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentInitiationPaymentCreateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// After creating a payment recipient, you can use the <c>/payment_initiation/payment/create</c> endpoint to create a payment to that recipient.  Payments can be one-time or standing order (recurring) and can be denominated in EUR, GBP, or another chosen <see href="https://plaid.com/docs/api/products/payment-initiation/#payment_initiation-payment-create-request-amount-currency">currency</see>.  If making domestic GBP-denominated payments, your recipient must have been created with Bacs numbers. In general, EUR-denominated payments will be sent via SEPA Credit Transfer, GBP-denominated payments will be sent via the Faster Payments network and for non-Eurozone markets typically via the local payment scheme, but the payment network used will be determined by the institution. Payments sent via Faster Payments will typically arrive immediately, while payments sent via SEPA Credit Transfer or other local payment schemes will typically arrive in one business day.
    /// <para>
    /// Standing orders (recurring payments) must be denominated in GBP and can only be sent to recipients in the UK. Once created, standing order payments cannot be modified or canceled via the API. An end user can cancel or modify a standing order directly on their banking application or website, or by contacting the bank. Standing orders will follow the payment rules of the underlying rails (Faster Payments in UK). Payments can be sent Monday to Friday, excluding bank holidays. If the pre-arranged date falls on a weekend or bank holiday, the payment is made on the next working day. It is not possible to guarantee the exact time the payment will reach the recipient's account, although at least 90% of standing order payments are sent by 6am.
    /// </para>
    /// </remarks>
    public Task<PaymentInitiationPaymentCreateResponse> PaymentInitiationPaymentCreate(PaymentInitiationPaymentCreateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/payment_initiation/payment/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<PaymentInitiationPaymentCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Get payment details
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentInitiationPaymentGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/payment_initiation/payment/get</c> endpoint can be used to check the status of a payment, as well as to receive basic information such as recipient and payment amount. In the case of standing orders, the <c>/payment_initiation/payment/get</c> endpoint will provide information about the status of the overall standing order itself; the API cannot be used to retrieve payment status for individual payments within a standing order.
    /// <para>
    /// Polling for status updates in Production is highly discouraged. Repeatedly calling <c>/payment_initiation/payment/get</c> to check a payment's status is unreliable and may trigger API rate limits. Only the <c>payment_status_update</c> webhook should be used to receive real-time status updates in Production.
    /// </para>
    /// </remarks>
    public Task<PaymentInitiationPaymentGetResponse> PaymentInitiationPaymentGet(PaymentInitiationPaymentGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/payment_initiation/payment/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<PaymentInitiationPaymentGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// List payments
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentInitiationPaymentListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/payment_initiation/payment/list</c> endpoint can be used to retrieve all created payments. By default, the 10 most recent payments are returned. You can request more payments and paginate through the results using the optional <c>count</c> and <c>cursor</c> parameters.
    /// </remarks>
    public Task<PaymentInitiationPaymentListResponse> PaymentInitiationPaymentList(PaymentInitiationPaymentListRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/payment_initiation/payment/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<PaymentInitiationPaymentListResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Reverse an existing payment
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentInitiationPaymentReverseResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Reverse a settled payment from a Plaid virtual account.
    /// <para>
    /// The original payment must be in a settled state to be refunded.
    /// To refund partially, specify the amount as part of the request.
    /// If the amount is not specified, the refund amount will be equal to all
    /// of the remaining payment amount that has not been refunded yet.
    /// </para>
    /// <para>
    /// The refund will go back to the source account that initiated the payment.
    /// The original payment must have been initiated to a Plaid virtual account
    /// so that this account can be used to initiate the refund.
    /// </para>
    /// <para>
    /// Providing counterparty information such as date of birth and address increases
    /// the likelihood of refund being successful without human intervention.
    /// </para>
    /// </remarks>
    public Task<PaymentInitiationPaymentReverseResponse> PaymentInitiationPaymentReverse(PaymentInitiationPaymentReverseRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/payment_initiation/payment/reverse"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<PaymentInitiationPaymentReverseResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Create payment recipient
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentInitiationRecipientCreateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a payment recipient for payment initiation.  The recipient must be in Europe, within a country that is a member of the Single Euro Payments Area (SEPA) or a non-Eurozone country <see href="https://support.plaid.com/hc/en-us/articles/27895826947735-What-Plaid-products-are-supported-in-each-country-and-region">supported</see> by Plaid. For a standing order (recurring) payment, the recipient must be in the UK.
    /// <para>
    /// It is recommended to use <c>bacs</c> in the UK and <c>iban</c> in EU.
    /// </para>
    /// <para>
    /// The endpoint is idempotent: if a developer has already made a request with the same payment details, Plaid will return the same <c>recipient_id</c>.
    /// </para>
    /// </remarks>
    public Task<PaymentInitiationRecipientCreateResponse> PaymentInitiationRecipientCreate(PaymentInitiationRecipientCreateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/payment_initiation/recipient/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<PaymentInitiationRecipientCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Get payment recipient
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentInitiationRecipientGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get details about a payment recipient you have previously created.
    /// </remarks>
    public Task<PaymentInitiationRecipientGetResponse> PaymentInitiationRecipientGet(PaymentInitiationRecipientGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/payment_initiation/recipient/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<PaymentInitiationRecipientGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// List payment recipients
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentInitiationRecipientListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/payment_initiation/recipient/list</c> endpoint lists the payment recipients that you have previously created.
    /// </remarks>
    public Task<PaymentInitiationRecipientListResponse> PaymentInitiationRecipientList(PaymentInitiationRecipientListRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/payment_initiation/recipient/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<PaymentInitiationRecipientListResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Create payment profile
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentProfileCreateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use <c>/payment_profile/create</c> endpoint to create a new payment profile.
    /// To initiate the account linking experience, call <c>/link/token/create</c> and provide the <c>payment_profile_token</c> in the <c>transfer.payment_profile_token</c> field.
    /// You can then use the <c>payment_profile_token</c> when creating transfers using <c>/transfer/authorization/create</c> and <c>/transfer/create</c>.
    /// </remarks>
    public Task<PaymentProfileCreateResponse> PaymentProfileCreate(PaymentProfileCreateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/payment_profile/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<PaymentProfileCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Get payment profile
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentProfileGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use <c>/payment_profile/get</c> endpoint to get the status of a given Payment Profile.
    /// </remarks>
    public Task<PaymentProfileGetResponse> PaymentProfileGet(PaymentProfileGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/payment_profile/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<PaymentProfileGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Remove payment profile
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentProfileRemoveResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/payment_profile/remove</c> endpoint to remove a given Payment Profile. Once it's removed, it can no longer be used to create transfers.
    /// </remarks>
    public Task<PaymentProfileRemoveResponse> PaymentProfileRemove(PaymentProfileRemoveRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/payment_profile/remove"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<PaymentProfileRemoveResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve the account associated with a processor token
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ProcessorAccountGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint returns the account associated with a given processor token.
    /// <para>
    /// This endpoint retrieves cached information, rather than extracting fresh information from the institution. As a result, the account balance returned may not be up-to-date; for real-time balance information, use <c>/processor/balance/get</c> instead. Note that some information is nullable.
    /// </para>
    /// </remarks>
    public Task<ProcessorAccountGetResponse> ProcessorAccountGet(ProcessorAccountGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/processor/account/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ProcessorAccountGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Create Apex processor token
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ProcessorTokenCreateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Used to create a token suitable for sending to Apex to enable Plaid-Apex integrations.
    /// </remarks>
    public Task<ProcessorTokenCreateResponse> ProcessorApexProcessorTokenCreate(ProcessorApexProcessorTokenCreateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/processor/apex/processor_token/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ProcessorTokenCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve Auth data
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ProcessorAuthGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/processor/auth/get</c> endpoint returns the bank account and bank identification number (such as the routing number, for US accounts), for a checking, savings, or cash management account that''s associated with a given <c>processor_token</c>. The endpoint also returns high-level account data and balances when available.
    /// <para>
    /// Versioning note: API versions 2019-05-29 and earlier use a different schema for the <c>numbers</c> object returned by this endpoint. For details, see <see href="https://plaid.com/docs/api/versioning/#version-2020-09-14">Plaid API versioning</see>.
    /// </para>
    /// </remarks>
    public Task<ProcessorAuthGetResponse> ProcessorAuthGet(ProcessorAuthGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/processor/auth/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ProcessorAuthGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve Balance data
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ProcessorBalanceGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/processor/balance/get</c> endpoint returns the real-time balance for each of an Item's accounts. While other endpoints may return a balance object, only <c>/processor/balance/get</c> forces the available and current balance fields to be refreshed rather than cached.
    /// </remarks>
    public Task<ProcessorBalanceGetResponse> ProcessorBalanceGet(ProcessorBalanceGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/processor/balance/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ProcessorBalanceGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// (Deprecated) Create a bank transfer as a processor
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ProcessorBankTransferCreateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/processor/bank_transfer/create</c> endpoint to initiate a new bank transfer as a processor
    /// </remarks>
    public Task<ProcessorBankTransferCreateResponse> ProcessorBankTransferCreate(ProcessorBankTransferCreateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/processor/bank_transfer/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ProcessorBankTransferCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve Identity data
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ProcessorIdentityGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/processor/identity/get</c> endpoint allows you to retrieve various account holder information on file with the financial institution, including names, emails, phone numbers, and addresses.
    /// </remarks>
    public Task<ProcessorIdentityGetResponse> ProcessorIdentityGet(ProcessorIdentityGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/processor/identity/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ProcessorIdentityGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve identity match score
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ProcessorIdentityMatchResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/processor/identity/match</c> endpoint generates a match score, which indicates how well the provided identity data matches the identity information on file with the account holder's financial institution.
    /// <para>
    /// Fields within the <c>balances</c> object will always be null when retrieved by <c>/processor/identity/match</c>. Instead, use the <c>/processor/balance/get</c> endpoint to retrieve balance data.
    /// </para>
    /// </remarks>
    public Task<ProcessorIdentityMatchResponse> ProcessorIdentityMatch(ProcessorIdentityMatchRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/processor/identity/match"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ProcessorIdentityMatchResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Get investment account authentication data
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ProcessorInvestmentsAuthGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/processor/investments/auth/get</c> endpoint allows you to retrieve information about the account
    /// authorized by a processor token, including account numbers, account owners, holdings, and data provenance information.
    /// <para>
    /// To receive Investments Auth webhooks for a processor token, set its webhook URL via the <see href="https://plaid.com/docs/api/processor-partners/#processortokenwebhookupdate"><c>/processor/token/webhook/update</c></see> endpoint.
    /// </para>
    /// </remarks>
    public Task<ProcessorInvestmentsAuthGetResponse> ProcessorInvestmentsAuthGet(ProcessorInvestmentsAuthGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/processor/investments/auth/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ProcessorInvestmentsAuthGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve Investment Holdings
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ProcessorInvestmentsHoldingsGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint returns the stock position data of the account associated with a given processor token.
    /// </remarks>
    public Task<ProcessorInvestmentsHoldingsGetResponse> ProcessorInvestmentsHoldingsGet(ProcessorInvestmentsHoldingsGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/processor/investments/holdings/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ProcessorInvestmentsHoldingsGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Get investment transactions data
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ProcessorInvestmentsTransactionsGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/processor/investments/transactions/get</c> endpoint allows developers to retrieve up to 24 months of user-authorized transaction data for the investment account associated with the processor token.
    /// <para>
    /// Transactions are returned in reverse-chronological order, and the sequence of transaction ordering is stable and will not shift.
    /// </para>
    /// <para>
    /// Due to the potentially large number of investment transactions associated with the account, results are paginated. Manipulate the count and offset parameters in conjunction with the <c>total_investment_transactions</c> response body field to fetch all available investment transactions.
    /// </para>
    /// <para>
    /// Note that Investments does not have a webhook to indicate when initial transaction data has loaded (unless you use the <c>async_update</c> option). Instead, if transactions data is not ready when <c>/processor/investments/transactions/get</c> is first called, Plaid will wait for the data. For this reason, calling <c>/processor/investments/transactions/get</c> immediately after Link may take up to one to two minutes to return.
    /// </para>
    /// <para>
    /// Data returned by the asynchronous investments extraction flow (when <c>async_update</c> is set to true) may not be immediately available to <c>/processor/investments/transactions/get</c>. To be alerted when the data is ready to be fetched, listen for the <c>HISTORICAL_UPDATE</c> webhook. If no investments history is ready when <c>/processor/investments/transactions/get</c> is called, it will return a <c>PRODUCT_NOT_READY</c> error.
    /// </para>
    /// <para>
    /// To receive Investments Transactions webhooks for a processor token, set its webhook URL via the <see href="https://plaid.com/docs/api/processor-partners/#processortokenwebhookupdate"><c>/processor/token/webhook/update</c></see> endpoint.
    /// </para>
    /// </remarks>
    public Task<ProcessorInvestmentsTransactionsGetResponse> ProcessorInvestmentsTransactionsGet(ProcessorInvestmentsTransactionsGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/processor/investments/transactions/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ProcessorInvestmentsTransactionsGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve Liabilities data
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ProcessorLiabilitiesGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/processor/liabilities/get</c> endpoint returns various details about a loan or credit account. Liabilities data is available primarily for US financial institutions, with some limited coverage of Canadian institutions. Currently supported account types are account type <c>credit</c> with account subtype <c>credit card</c> or <c>paypal</c>, and account type <c>loan</c> with account subtype <c>student</c> or <c>mortgage</c>.
    /// <para>
    /// The types of information returned by Liabilities can include balances and due dates, loan terms, and account details such as original loan amount and guarantor. Data is refreshed approximately once per day; the latest data can be retrieved by calling <c>/processor/liabilities/get</c>.
    /// </para>
    /// <para>
    /// Note: This request may take some time to complete if <c>liabilities</c> was not specified as an initial product when creating the processor token. This is because Plaid must communicate directly with the institution to retrieve the additional data.
    /// </para>
    /// </remarks>
    public Task<ProcessorLiabilitiesGetResponse> ProcessorLiabilitiesGet(ProcessorLiabilitiesGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/processor/liabilities/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ProcessorLiabilitiesGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Report whether you initiated an ACH transaction
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ProcessorSignalDecisionReportResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// After you call <c>/processor/signal/evaluate</c>, Plaid will normally infer the outcome from your Signal Rules. However, if you are not using Signal Rules, if the Signal Rules outcome was <c>REVIEW</c>, or if you take a different action than the one determined by the Signal Rules, you will need to call <c>/processor/signal/decision/report</c>. This helps improve Signal Transaction Score accuracy for your account and is necessary for proper functioning of the rule performance and rule tuning capabilities in the Dashboard. If your effective decision changes after calling <c>/processor/signal/decision/report</c> (for example, you indicated that you accepted a transaction, but later on, your payment processor rejected it, so it was never initiated), call <c>/processor/signal/decision/report</c> again for the transaction to correct Plaid's records.
    /// <para>
    /// If you are using Plaid Transfer as your payment processor, you also do not need to call <c>/processor/signal/decision/report</c>, as Plaid can infer outcomes from your Transfer activity.
    /// </para>
    /// <para>
    /// If using a Balance-only ruleset, this endpoint will not impact scores (Balance does not use scores), but is necessary to view accurate transaction outcomes and tune rule logic in the Dashboard.
    /// </para>
    /// </remarks>
    public Task<ProcessorSignalDecisionReportResponse> ProcessorSignalDecisionReport(ProcessorSignalDecisionReportRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/processor/signal/decision/report"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ProcessorSignalDecisionReportResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Evaluate a planned ACH transaction
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ProcessorSignalEvaluateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use <c>/processor/signal/evaluate</c> to evaluate a planned ACH transaction to get a return risk assessment and additional risk signals.
    /// <para>
    /// <c>/processor/signal/evaluate</c> uses Rulesets that are configured on the end customer's Dashboard and can be used with either the Signal Transaction Scores product or the Balance product. Which product is used will be determined by the <c>ruleset_key</c> that you provide. Note that only customer-configured rulesets work with this endpoint; as a processor partner, you cannot create or configure your own rulesets. For more details, see <see href="https://plaid.com/docs/signal/signal-rules/">Signal Rules</see>.
    /// </para>
    /// <para>
    /// Note: This request may have higher latency if Signal Transaction Scores is being added to an existing Item for the first time, or when using a Balance-only ruleset. This is because Plaid must communicate directly with the institution to request data.
    /// </para>
    /// </remarks>
    public Task<ProcessorSignalEvaluateResponse> ProcessorSignalEvaluate(ProcessorSignalEvaluateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/processor/signal/evaluate"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ProcessorSignalEvaluateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Opt-in a processor token to Signal
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ProcessorSignalPrepareResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// When a processor token is not initialized with <c>signal</c>, call <c>/processor/signal/prepare</c> to opt-in that processor token to the data collection process, which will improve the accuracy of the Signal Transaction Score.
    /// <para>
    /// If this endpoint is called with a processor token that is already initialized with <c>signal</c>, it will return a 200 response and will not modify the processor token.
    /// </para>
    /// </remarks>
    public Task<ProcessorSignalPrepareResponse> ProcessorSignalPrepare(ProcessorSignalPrepareRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/processor/signal/prepare"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ProcessorSignalPrepareResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Report a return for an ACH transaction
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ProcessorSignalReturnReportResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Call the <c>/processor/signal/return/report</c> endpoint to report a returned transaction that was previously sent to the <c>/processor/signal/evaluate</c> endpoint. Your feedback will be used by the model to incorporate the latest risk trend in your portfolio.
    /// <para>
    /// If you are using the <see href="https://plaid.com/docs/transfer">Plaid Transfer product</see> to create transfers, it is not necessary to use this endpoint, as Plaid already knows whether the transfer was returned.
    /// </para>
    /// </remarks>
    public Task<ProcessorSignalReturnReportResponse> ProcessorSignalReturnReport(ProcessorSignalReturnReportRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/processor/signal/return/report"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ProcessorSignalReturnReportResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Create Stripe bank account token
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ProcessorStripeBankAccountTokenCreateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    ///
    /// Used to create a token suitable for sending to Stripe to enable Plaid-Stripe integrations. For a detailed guide on integrating Stripe, see <see href="https://plaid.com/docs/auth/partnerships/stripe/">Add Stripe to your app</see>.
    /// <para>
    /// Note that the Stripe bank account token is a one-time use token. To store bank account information for later use, you can use a Stripe customer object and create an associated bank account from the token, or you can use a Stripe Custom account and create an associated external bank account from the token. This bank account information should work indefinitely, unless the user's bank account information changes or they revoke Plaid's permissions to access their account. Stripe bank account information cannot be modified once the bank account token has been created. If you ever need to change the bank account details used by Stripe for a specific customer, have the user go through Link again and create a new bank account token from the new <c>access_token</c>.
    /// </para>
    /// <para>
    /// To revoke a bank account token, the entire underlying access token must be revoked using <c>/item/remove</c>.
    /// </para>
    /// </remarks>
    public Task<ProcessorStripeBankAccountTokenCreateResponse> ProcessorStripeBankAccountTokenCreate(ProcessorStripeBankAccountTokenCreateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/processor/stripe/bank_account_token/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ProcessorStripeBankAccountTokenCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Create processor token
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ProcessorTokenCreateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Used to create a token suitable for sending to one of Plaid's partners to enable integrations. Note that Stripe partnerships use bank account tokens instead; see <c>/processor/stripe/bank_account_token/create</c> for creating tokens for use with Stripe integrations. If using multiple processors, multiple different processor tokens can be created for a single access token. Once created, a processor token for a given Item can be modified by calling <c>/processor/token/permissions/set</c>. To revoke the processor's access, the entire Item must be deleted by calling <c>/item/remove</c>.
    /// </remarks>
    public Task<ProcessorTokenCreateResponse> ProcessorTokenCreate(ProcessorTokenCreateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/processor/token/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ProcessorTokenCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Get a processor token's product permissions
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ProcessorTokenPermissionsGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Used to get a processor token's product permissions. The <c>products</c> field will be an empty list if the processor can access all available products.
    /// </remarks>
    public Task<ProcessorTokenPermissionsGetResponse> ProcessorTokenPermissionsGet(ProcessorTokenPermissionsGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/processor/token/permissions/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ProcessorTokenPermissionsGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Control a processor's access to products
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ProcessorTokenPermissionsSetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Used to control a processor's access to products on the given processor token. By default, a processor will have access to all available products on the corresponding item. To restrict access to a particular set of products, call this endpoint with the desired products. To restore access to all available products, call this endpoint with an empty list. This endpoint can be called multiple times as your needs and your processor's needs change.
    /// </remarks>
    public Task<ProcessorTokenPermissionsSetResponse> ProcessorTokenPermissionsSet(ProcessorTokenPermissionsSetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/processor/token/permissions/set"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ProcessorTokenPermissionsSetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Update a processor token's webhook URL
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ProcessorTokenWebhookUpdateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows you, the processor, to update the webhook URL associated with a processor token. This request triggers a <c>WEBHOOK_UPDATE_ACKNOWLEDGED</c> webhook to the newly specified webhook URL.
    /// </remarks>
    public Task<ProcessorTokenWebhookUpdateResponse> ProcessorTokenWebhookUpdate(ProcessorTokenWebhookUpdateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/processor/token/webhook/update"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ProcessorTokenWebhookUpdateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Get transaction data
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ProcessorTransactionsGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/processor/transactions/get</c> endpoint allows developers to receive user-authorized transaction data for credit, depository, and some loan-type accounts (only those with account subtype <c>student</c> or <c>mortgage</c>; coverage may be limited). Transaction data is standardized across financial institutions, and in many cases transactions are linked to a clean name, entity type, location, and category. Similarly, account data is standardized and returned with a clean name, number, balance, and other meta information where available.
    /// <para>
    /// Transactions are returned in reverse-chronological order, and the sequence of transaction ordering is stable and will not shift.  Transactions are not immutable and can also be removed altogether by the institution; a removed transaction will no longer appear in <c>/processor/transactions/get</c>.  For more details, see <see href="https://plaid.com/docs/transactions/transactions-data/#pending-and-posted-transactions">Pending and posted transactions</see>.
    /// </para>
    /// <para>
    /// Due to the potentially large number of transactions associated with a processor token, results are paginated. Manipulate the <c>count</c> and <c>offset</c> parameters in conjunction with the <c>total_transactions</c> response body field to fetch all available transactions.
    /// </para>
    /// <para>
    /// Data returned by <c>/processor/transactions/get</c> will be the data available for the processor token as of the most recent successful check for new transactions. Plaid typically checks for new data multiple times a day, but these checks may occur less frequently, such as once a day, depending on the institution. To force Plaid to check for new transactions, you can use the <c>/processor/transactions/refresh</c> endpoint.
    /// </para>
    /// <para>
    /// Note that data may not be immediately available to <c>/processor/transactions/get</c>. Plaid will begin to prepare transactions data upon Item link, if Link was initialized with <c>transactions</c>, or upon the first call to <c>/processor/transactions/get</c>, if it wasn't. If no transaction history is ready when <c>/processor/transactions/get</c> is called, it will return a <c>PRODUCT_NOT_READY</c> error.
    /// </para>
    /// <para>
    /// To receive Transactions webhooks for a processor token, set its webhook URL via the <see href="https://plaid.com/docs/api/processor-partners/#processortokenwebhookupdate"><c>/processor/token/webhook/update</c></see> endpoint.
    /// </para>
    /// </remarks>
    public Task<ProcessorTransactionsGetResponse> ProcessorTransactionsGet(ProcessorTransactionsGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/processor/transactions/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ProcessorTransactionsGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Fetch recurring transaction streams
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ProcessorTransactionsRecurringGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/processor/transactions/recurring/get</c> endpoint allows developers to receive a summary of the recurring outflow and inflow streams (expenses and deposits) from a user's checking, savings or credit card accounts. Additionally, Plaid provides key insights about each recurring stream including the category, merchant, last amount, and more. Developers can use these insights to build tools and experiences that help their users better manage cash flow, monitor subscriptions, reduce spend, and stay on track with bill payments.
    /// <para>
    /// This endpoint is offered as an add-on to Transactions. To request access to this endpoint, submit a <see href="https://dashboard.plaid.com/team/products">product access request</see> or contact your Plaid account manager.
    /// </para>
    /// <para>
    /// This endpoint can only be called on a processor token that has already been initialized with Transactions (either during Link, by specifying it in <c>/link/token/create</c>; or after Link, by calling <c>/processor/transactions/get</c> or <c>/processor/transactions/sync</c>). Once all historical transactions have been fetched, call <c>/processor/transactions/recurring/get</c> to receive the Recurring Transactions streams and subscribe to the <see href="https://plaid.com/docs/api/products/transactions/#recurring_transactions_update"><c>RECURRING_TRANSACTIONS_UPDATE</c></see> webhook. To know when historical transactions have been fetched, if you are using <c>/processor/transactions/sync</c> listen for the <see href="https://plaid.com/docs/api/products/transactions/#SyncUpdatesAvailableWebhook-historical-update-complete"><c>SYNC_UPDATES_AVAILABLE</c></see> webhook and check that the <c>historical_update_complete</c> field in the payload is <c>true</c>. If using <c>/processor/transactions/get</c>, listen for the <see href="https://plaid.com/docs/api/products/transactions/#historical_update"><c>HISTORICAL_UPDATE</c></see> webhook.
    /// </para>
    /// <para>
    /// After the initial call, you can call the <c>/processor/transactions/recurring/get</c> endpoint at any point in the future to retrieve the latest summary of recurring streams. Listen to the <see href="https://plaid.com/docs/api/products/transactions/#recurring_transactions_update"><c>RECURRING_TRANSACTIONS_UPDATE</c></see> webhook to be notified when new updates are available.
    /// </para>
    /// <para>
    /// To receive Transactions webhooks for a processor token, set its webhook URL via the <see href="https://plaid.com/docs/api/processor-partners/#processortokenwebhookupdate"><c>/processor/token/webhook/update</c></see> endpoint.
    /// </para>
    /// </remarks>
    public Task<ProcessorTransactionsRecurringGetResponse> ProcessorTransactionsRecurringGet(ProcessorTransactionsRecurringGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/processor/transactions/recurring/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ProcessorTransactionsRecurringGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Refresh transaction data
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ProcessorTransactionsRefreshResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/processor/transactions/refresh</c> is an optional endpoint for users of the Transactions product. It initiates an on-demand extraction to fetch the newest transactions for a processor token. This on-demand extraction takes place in addition to the periodic extractions that automatically occur one or more times per day for any Transactions-enabled processor token. If changes to transactions are discovered after calling <c>/processor/transactions/refresh</c>, Plaid will fire a webhook: for <c>/processor/transactions/sync</c> users, <see href="https://plaid.com/docs/api/products/transactions/#sync_updates_available"><c>SYNC_UPDATES_AVAILABLE</c></see> will be fired if there are any transactions updated, added, or removed. For users of both <c>/processor/transactions/sync</c> and <c>/processor/transactions/get</c>, <see href="https://plaid.com/docs/api/products/transactions/#transactions_removed"><c>TRANSACTIONS_REMOVED</c></see> will be fired if any removed transactions are detected, and <see href="https://plaid.com/docs/api/products/transactions/#default_update"><c>DEFAULT_UPDATE</c></see> will be fired if any new transactions are detected. New transactions can be fetched by calling <c>/processor/transactions/get</c> or <c>/processor/transactions/sync</c>. Note that the <c>/processor/transactions/refresh</c> endpoint is not supported for Capital One (<c>ins_128026</c>) non-depository accounts and will result in a <c>PRODUCTS_NOT_SUPPORTED</c> error if called on an Item that contains only non-depository accounts from that institution.
    /// <para>
    /// As this endpoint triggers a synchronous request for fresh data, latency may be higher than for other Plaid endpoints (typically less than 10 seconds, but occasionally up to 30 seconds or more); if you encounter errors, you may find it necessary to adjust your timeout period when making requests.
    /// </para>
    /// <para>
    /// <c>/processor/transactions/refresh</c> is offered as an add-on to Transactions and has a separate <see href="https://plaid.com/docs/account/billing/#per-request-flat-fee">fee model</see>. To request access to this endpoint, submit a <see href="https://dashboard.plaid.com/team/products">product access request</see> or contact your Plaid account manager.
    /// </para>
    /// </remarks>
    public Task<ProcessorTransactionsRefreshResponse> ProcessorTransactionsRefresh(ProcessorTransactionsRefreshRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/processor/transactions/refresh"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ProcessorTransactionsRefreshResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Get incremental transaction updates on a processor token
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ProcessorTransactionsSyncResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    ///
    /// The <c>/processor/transactions/sync</c> endpoint retrieves transactions associated with an Item and can fetch updates using a cursor to track which updates have already been seen.
    /// <para>
    /// For important instructions on integrating with <c>/processor/transactions/sync</c>, see the <see href="https://plaid.com/docs/transactions/#integration-overview">Transactions integration overview</see>. If you are migrating from an existing integration using <c>/processor/transactions/get</c>, see the <see href="https://plaid.com/docs/transactions/sync-migration/">Transactions Sync migration guide</see>.
    /// </para>
    /// <para>
    /// This endpoint supports <c>credit</c>, <c>depository</c>, and some <c>loan</c>-type accounts (only those with account subtype <c>student</c> or <c>mortgage</c>). For <c>investments</c> accounts, use <c>/investments/transactions/get</c> instead.
    /// </para>
    /// <para>
    /// When retrieving paginated updates, track both the <c>next_cursor</c> from the latest response and the original cursor from the first call in which <c>has_more</c> was <c>true</c>; if a call to <c>/processor/transactions/sync</c> fails when retrieving a paginated update (e.g. due to the <see href="https://plaid.com/docs/errors/transactions/#transactions_sync_mutation_during_pagination"><c>TRANSACTIONS_SYNC_MUTATION_DURING_PAGINATION</c></see> error), the entire pagination request loop must be restarted beginning with the cursor for the first page of the update, rather than retrying only the single request that failed.
    /// </para>
    /// <para>
    /// If transactions data is not yet available for the Item, which can happen if the Item was not initialized with transactions during the <c>/link/token/create</c> call or if <c>/processor/transactions/sync</c> was called within a few seconds of Item creation, <c>/processor/transactions/sync</c> will return empty transactions arrays.
    /// </para>
    /// <para>
    /// Plaid typically checks for new transactions data between one and four times per day, depending on the institution. To find out when transactions were last updated for an Item, use the <see href="https://plaid.com/docs/account/activity/#troubleshooting-with-item-debugger">Item Debugger</see> or call <c>/item/get</c>; the <c>item.status.transactions.last_successful_update</c> field will show the timestamp of the most recent successful update. To force Plaid to check for new transactions, use the <c>/processor/transactions/refresh</c> endpoint.
    /// </para>
    /// <para>
    /// To be alerted when new transactions are available, listen for the <see href="https://plaid.com/docs/api/products/transactions/#sync_updates_available"><c>SYNC_UPDATES_AVAILABLE</c></see> webhook.
    /// </para>
    /// <para>
    /// To receive Transactions webhooks for a processor token, set its webhook URL via the <see href="https://plaid.com/docs/api/processor-partners/#processortokenwebhookupdate"><c>/processor/token/webhook/update</c></see> endpoint.
    /// </para>
    /// </remarks>
    public Task<ProcessorTransactionsSyncResponse> ProcessorTransactionsSync(ProcessorTransactionsSyncRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/processor/transactions/sync"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ProcessorTransactionsSyncResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Check a user's Plaid Network status
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ProfileNetworkStatusGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/profile/network_status/get</c> endpoint can be used to check whether Plaid has a matching profile for the user.
    /// </remarks>
    public Task<ProfileNetworkStatusGetResponse> ProfileNetworkStatusGet(ProfileNetworkStatusGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/profile/network_status/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ProfileNetworkStatusGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Compute Protect Trust Index scores and subscores
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ProtectComputeResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Compute a Protect Trust Index score for a user. The model selected determines what is scored and what additional fields the response contains. For example, <c>ti-link-session-2.0</c> scores a completed Link session for fraud risk; <c>cash-advance-onboarding-1.0</c> scores repayment risk for a first-time cash advance and additionally populates per-amount-bucket subscores. Cash-advance models require that the user have a Plaid Item with Transactions enabled, or an Assets Report, before scoring.
    /// <para>
    /// The endpoint returns HTTP 400 with <c>error_type</c> = <c>INVALID_REQUEST</c> and <c>error_code</c> = <c>FAILED_PRECONDITION</c> when a required precondition is not met: for link-session models, when the Link session has not completed; for cash-advance models, when the user has not successfully linked any Item.
    /// </para>
    /// </remarks>
    public Task<ProtectComputeResponse> ProtectCompute(ProtectComputeRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/protect/compute"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ProtectComputeResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Get information about a user event
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ProtectEventGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get information about a user event including Trust Index score and fraud attributes.
    /// </remarks>
    public Task<ProtectEventGetResponse> ProtectEventGet(ProtectEventGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/protect/event/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ProtectEventGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Send a new event to enrich user data
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ProtectEventSendResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Send a new event to enrich user data and optionally get a Trust Index score for the event.
    /// </remarks>
    public Task<ProtectEventSendResponse> ProtectEventSend(ProtectEventSendRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/protect/event/send"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ProtectEventSendResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Create a Protect report
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ProtectReportCreateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use this endpoint to create a Protect report to document fraud incidents, investigation outcomes, or other risk events.
    /// This endpoint allows you to report various types of incidents including account takeovers, identity fraud, unauthorized transactions, and other security events.
    /// The reported data helps improve fraud detection models and provides valuable feedback to enhance the overall security of the Plaid network.
    /// Reports can be created for confirmed incidents that have been fully investigated, or for suspected incidents that require further review.
    /// You can associate reports with specific users, sessions, or transactions to provide comprehensive context about the incident.
    /// Each report must include <c>user_id</c>, or an <c>incident_event</c> with at least one supported identifier: <c>link_session_id</c>, <c>idv_session_id</c>, <c>protect_event_id</c>, <c>signal_client_transaction_id</c>, or <c>access_token</c>. Context fields such as <c>internal_reference</c>, <c>time</c>, <c>amount</c>, and <c>bank_account</c> do not satisfy this identifier requirement.
    /// </remarks>
    public Task<ProtectReportCreateResponse> ProtectReportCreate(ProtectReportCreateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/protect/report/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ProtectReportCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Get Protect user insights
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ProtectUserInsightsGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use this endpoint to get basic information about a user as it relates to their fraud profile with Protect.
    /// </remarks>
    public Task<ProtectUserInsightsGetResponse> ProtectUserInsightsGet(ProtectUserInsightsGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/protect/user/insights/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ProtectUserInsightsGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// (Deprecated) Manually fire a Bank Income webhook in Sandbox
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SandboxBankIncomeFireWebhookResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/sandbox/bank_income/fire_webhook</c> endpoint to manually trigger a Bank Income webhook in the Sandbox environment.
    /// </remarks>
    public Task<SandboxBankIncomeFireWebhookResponse> SandboxBankIncomeFireWebhook(SandboxBankIncomeFireWebhookRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sandbox/bank_income/fire_webhook"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SandboxBankIncomeFireWebhookResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// (Deprecated) Manually fire a Bank Transfer webhook
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SandboxBankTransferFireWebhookResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/sandbox/bank_transfer/fire_webhook</c> endpoint to manually trigger a Bank Transfers webhook in the Sandbox environment.
    /// </remarks>
    public Task<SandboxBankTransferFireWebhookResponse> SandboxBankTransferFireWebhook(SandboxBankTransferFireWebhookRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sandbox/bank_transfer/fire_webhook"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SandboxBankTransferFireWebhookResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// (Deprecated) Simulate a bank transfer event in Sandbox
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SandboxBankTransferSimulateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/sandbox/bank_transfer/simulate</c> endpoint to simulate a bank transfer event in the Sandbox environment.  Note that while an event will be simulated and will appear when using endpoints such as <c>/bank_transfer/event/sync</c> or <c>/bank_transfer/event/list</c>, no transactions will actually take place and funds will not move between accounts, even within the Sandbox.
    /// </remarks>
    public Task<SandboxBankTransferSimulateResponse> SandboxBankTransferSimulate(SandboxBankTransferSimulateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sandbox/bank_transfer/simulate"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SandboxBankTransferSimulateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Trigger an update for Cash Flow Updates
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SandboxCraCashflowUpdatesUpdateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/sandbox/cra/cashflow_updates/update</c> endpoint to manually trigger an update for Cash Flow Updates (Monitoring) in the Sandbox environment.
    /// </remarks>
    public Task<SandboxCraCashflowUpdatesUpdateResponse> SandboxCraCashflowUpdatesUpdate(SandboxCraCashflowUpdatesUpdateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sandbox/cra/cashflow_updates/update"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SandboxCraCashflowUpdatesUpdateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Seed an FDX consent grant for a sandbox data partner
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SandboxFdxConsentSeedResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/sandbox/fdx/consent/seed</c> creates a test FDX consent grant (and a backing Item) for a data provider's customer in Sandbox, so the FDX Consent API endpoints can be exercised end-to-end without a live data provider connection.
    /// <para>
    /// <c>customer_id</c> is the data provider's identifier for the end user and <c>application_id</c> identifies the data recipient application the consent is granted to; both are required. Optionally provide <c>consent_id</c> (a UUIDv4) to control the seeded grant's identifier; one is generated when omitted. The seeded grant is returned by <c>/fdx/consents</c> and <c>/fdx/consents/{consentId}</c>, and can be revoked via <c>/fdx/consents/{consentId}/revocation</c>.
    /// </para>
    /// </remarks>
    public Task<SandboxFdxConsentSeedResponse> SandboxFdxConsentSeed(SandboxFdxConsentSeedRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sandbox/fdx/consent/seed"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SandboxFdxConsentSeedResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Manually fire an Income webhook
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SandboxIncomeFireWebhookResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/sandbox/income/fire_webhook</c> endpoint to manually trigger a Payroll or Document Income webhook in the Sandbox environment.
    /// </remarks>
    public Task<SandboxIncomeFireWebhookResponse> SandboxIncomeFireWebhook(SandboxIncomeFireWebhookRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sandbox/income/fire_webhook"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SandboxIncomeFireWebhookResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Seed a connected application for a Permissions Manager sandbox item
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SandboxItemApplicationSeedResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/sandbox/item/application/seed</c> creates a test connected application on an existing Permissions Manager Item's login. The seeded application will appear in subsequent calls to <c>/item/application/list</c>.
    /// <para>
    /// The <c>access_token</c> must belong to a Permissions Manager Item created via <c>/item/import</c> in Sandbox. The <c>application_id</c> identifies the application to seed as a connected app. To disconnect a seeded application, use <c>/item/application/unlink</c>.
    /// </para>
    /// </remarks>
    public Task<SandboxItemApplicationSeedResponse> SandboxItemApplicationSeed(SandboxItemApplicationSeedRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sandbox/item/application/seed"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SandboxItemApplicationSeedResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Fire a test webhook
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SandboxItemFireWebhookResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/sandbox/item/fire_webhook</c> endpoint is used to test that code correctly handles webhooks. This endpoint can trigger the following webhooks:
    /// <para>
    /// <c>DEFAULT_UPDATE</c>: Webhook to be fired for a given Sandbox Item simulating a default update event for the respective product as specified with the <c>webhook_type</c> in the request body. Valid Sandbox <c>DEFAULT_UPDATE</c> webhook types include: <c>AUTH</c>, <c>IDENTITY</c>, <c>TRANSACTIONS</c>, <c>INVESTMENTS_TRANSACTIONS</c>, <c>LIABILITIES</c>, <c>HOLDINGS</c>. If the Item does not support the product, a <c>SANDBOX_PRODUCT_NOT_ENABLED</c> error will result.
    /// </para>
    /// <para>
    /// <c>NEW_ACCOUNTS_AVAILABLE</c>: Fired to indicate that a new account is available on the Item and you can launch update mode to request access to it.
    /// </para>
    /// <para>
    /// <c>SMS_MICRODEPOSITS_VERIFICATION</c>: Fired when a given Same-Day Micro-deposit Item is verified via SMS verification.
    /// </para>
    /// <para>
    /// <c>LOGIN_REPAIRED</c>: Fired when an Item recovers from the <c>ITEM_LOGIN_REQUIRED</c> without the user going through update mode in your app.
    /// </para>
    /// <para>
    /// <c>PENDING_DISCONNECT</c>: Fired when an Item will stop working in the near future (e.g. due to a planned bank migration) and must be sent through update mode to continue working.
    /// </para>
    /// <para>
    /// <c>RECURRING_TRANSACTIONS_UPDATE</c>: Recurring Transactions webhook to be fired for a given Sandbox Item. If the Item does not support Recurring Transactions, a <c>SANDBOX_PRODUCT_NOT_ENABLED</c> error will result.
    /// </para>
    /// <para>
    /// <c>SYNC_UPDATES_AVAILABLE</c>: Transactions webhook to be fired for a given Sandbox Item.  If the Item does not support Transactions, a <c>SANDBOX_PRODUCT_NOT_ENABLED</c> error will result.
    /// </para>
    /// <para>
    /// <c>PRODUCT_READY</c>: Assets webhook to be fired when a given asset report has been successfully generated. If the Item does not support Assets, a <c>SANDBOX_PRODUCT_NOT_ENABLED</c> error will result.
    /// </para>
    /// <para>
    /// <c>ERROR</c>: Assets webhook to be fired when asset report generation has failed. If the Item does not support Assets, a <c>SANDBOX_PRODUCT_NOT_ENABLED</c> error will result.
    /// </para>
    /// <para>
    /// <c>USER_PERMISSION_REVOKED</c>: Indicates an end user has revoked the permission that they previously granted to access an Item. May not always fire upon revocation, as some institutions' consent portals do not trigger this webhook. Upon receiving this webhook, it is recommended to delete any stored data from Plaid associated with the account or Item.
    /// </para>
    /// <para>
    /// <c>USER_ACCOUNT_REVOKED</c>: Fired when an end user has revoked access to their account on the Data Provider's portal. This webhook is currently sent only for PNC Items, but may be sent in the future for other financial institutions. Upon receiving this webhook, it is recommended to delete any stored data from Plaid associated with the account or Item.
    /// </para>
    /// <para>
    /// Note that this endpoint is provided for developer ease-of-use and is not required for testing webhooks; webhooks will also fire in Sandbox under the same conditions that they would in Production (except for webhooks of type <c>TRANSFER</c>).
    /// </para>
    /// </remarks>
    public Task<SandboxItemFireWebhookResponse> SandboxItemFireWebhook(SandboxItemFireWebhookRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sandbox/item/fire_webhook"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SandboxItemFireWebhookResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Force a Sandbox Item into an error state
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SandboxItemResetLoginResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/sandbox/item/reset_login</c> forces an Item into an <c>ITEM_LOGIN_REQUIRED</c> state in order to simulate an Item whose login is no longer valid. This makes it easy to test Link's <see href="https://plaid.com/docs/link/update-mode">update mode</see> flow in the Sandbox environment.  After calling <c>/sandbox/item/reset_login</c>, you can then use Plaid Link update mode to restore the Item to a good state. An <c>ITEM_LOGIN_REQUIRED</c> webhook will also be fired after a call to this endpoint, if one is associated with the Item.
    /// In the Sandbox, Items will transition to an <c>ITEM_LOGIN_REQUIRED</c> error state automatically after 30 days, even if this endpoint is not called.
    /// </remarks>
    public Task<SandboxItemResetLoginResponse> SandboxItemResetLogin(SandboxItemResetLoginRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sandbox/item/reset_login"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SandboxItemResetLoginResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Set verification status for Sandbox account
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SandboxItemSetVerificationStatusResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/sandbox/item/set_verification_status</c> endpoint can be used to change the verification status of an Item in the Sandbox in order to simulate the Automated Micro-deposit flow.
    /// <para>
    /// For more information on testing Automated Micro-deposits in Sandbox, see <see href="https://plaid.com/docs/auth/coverage/testing#">Auth full coverage testing</see>.
    /// </para>
    /// </remarks>
    public Task<SandboxItemSetVerificationStatusResponse> SandboxItemSetVerificationStatus(SandboxItemSetVerificationStatusRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sandbox/item/set_verification_status"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SandboxItemSetVerificationStatusResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Save the selected accounts when connecting to the Platypus OAuth institution
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="object"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Save the selected accounts when connecting to the Platypus OAuth institution
    /// </remarks>
    public Task<object> SandboxOauthSelectAccounts(SandboxOauthSelectAccountsRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sandbox/oauth/select_accounts"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<object>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Reset the login of a Payment Profile
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SandboxPaymentProfileResetLoginResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/sandbox/payment_profile/reset_login</c> forces a Payment Profile into a state where the login is no longer valid. This makes it easy to test update mode for Payment Profile in the Sandbox environment.
    /// <para>
    ///  After calling <c>/sandbox/payment_profile/reset_login</c>, calls to the <c>/transfer/authorization/create</c> with the Payment Profile will result in a <c>decision_rationale</c> <c>PAYMENT_PROFILE_LOGIN_REQUIRED</c>. You can then use update mode for Payment Profile to restore it into a good state.
    /// </para>
    /// <para>
    ///  In order to invoke this endpoint, you must first <see href="https://plaid.com/docs/transfer/add-to-app/#create-a-payment-profile-optional">create a Payment Profile</see> and <see href="https://plaid.com/docs/transfer/add-to-app/#create-a-link-token">go through the Link flow</see>.
    /// </para>
    /// </remarks>
    public Task<SandboxPaymentProfileResetLoginResponse> SandboxPaymentProfileResetLogin(SandboxPaymentProfileResetLoginRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sandbox/payment_profile/reset_login"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SandboxPaymentProfileResetLoginResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Simulate a payment event in Sandbox
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SandboxPaymentSimulateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/sandbox/payment/simulate</c> endpoint to simulate various payment events in the Sandbox environment. This endpoint will trigger the corresponding payment status webhook.
    /// </remarks>
    public Task<SandboxPaymentSimulateResponse> SandboxPaymentSimulate(SandboxPaymentSimulateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sandbox/payment/simulate"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SandboxPaymentSimulateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Create a test Item and processor token
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SandboxProcessorTokenCreateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/sandbox/processor_token/create</c> endpoint to create a valid <c>processor_token</c> for an arbitrary institution ID and test credentials. The created <c>processor_token</c> corresponds to a new Sandbox Item. You can then use this <c>processor_token</c> with the <c>/processor/</c> API endpoints in Sandbox. You can also use <c>/sandbox/processor_token/create</c> with the <see href="https://plaid.com/docs/sandbox/user-custom"><c>user_custom</c> test username</see> to generate a test account with custom data.
    /// </remarks>
    public Task<SandboxProcessorTokenCreateResponse> SandboxProcessorTokenCreate(SandboxProcessorTokenCreateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sandbox/processor_token/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SandboxProcessorTokenCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Create a test Item
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SandboxPublicTokenCreateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/sandbox/public_token/create</c> endpoint to create a valid <c>public_token</c>  for an arbitrary institution ID, initial products, and test credentials. The created <c>public_token</c> maps to a new Sandbox Item. You can then call <c>/item/public_token/exchange</c> to exchange the <c>public_token</c> for an <c>access_token</c> and perform all API actions. <c>/sandbox/public_token/create</c> can also be used with the <see href="https://plaid.com/docs/sandbox/user-custom"><c>user_custom</c> test username</see> to generate a test account with custom data, or with Plaid's <see href="https://plaid.com/docs/sandbox/test-credentials/">pre-populated Sandbox test accounts</see>.
    /// </remarks>
    public Task<SandboxPublicTokenCreateResponse> SandboxPublicTokenCreate(SandboxPublicTokenCreateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sandbox/public_token/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SandboxPublicTokenCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Create sandbox transactions
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SandboxTransactionsCreateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SandboxTransactionsCreateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/sandbox/transactions/create</c> endpoint to create new transactions for an existing Item. This endpoint can be used to add up to 10 transactions to any Item at a time.
    /// <para>
    /// This endpoint can only be used with Items that were created in the Sandbox environment using the <c>user_transactions_dynamic</c> test user. You can use this to add transactions to test the <c>/transactions/get</c> and <c>/transactions/sync</c> endpoints.
    /// </para>
    /// <para>
    /// Custom transactions are only applied to the depository account. Support for per-account targeting may be added in the future.
    /// </para>
    /// </remarks>
    public Task<SandboxTransactionsCreateResponse> SandboxTransactionsCreate(SandboxTransactionsCreateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sandbox/transactions/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SandboxTransactionsCreateResponse>(),
            SandboxTransactionsCreateErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Manually fire a Transfer webhook
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SandboxTransferFireWebhookResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/sandbox/transfer/fire_webhook</c> endpoint to manually trigger a <c>TRANSFER_EVENTS_UPDATE</c> webhook in the Sandbox environment.
    /// </remarks>
    public Task<SandboxTransferFireWebhookResponse> SandboxTransferFireWebhook(SandboxTransferFireWebhookRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sandbox/transfer/fire_webhook"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SandboxTransferFireWebhookResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Simulate a ledger deposit event in Sandbox
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SandboxTransferLedgerDepositSimulateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/sandbox/transfer/ledger/deposit/simulate</c> endpoint to simulate a ledger deposit event in the Sandbox environment.
    /// </remarks>
    public Task<SandboxTransferLedgerDepositSimulateResponse> SandboxTransferLedgerDepositSimulate(SandboxTransferLedgerDepositSimulateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sandbox/transfer/ledger/deposit/simulate"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SandboxTransferLedgerDepositSimulateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Simulate converting pending balance to available balance
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SandboxTransferLedgerSimulateAvailableResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/sandbox/transfer/ledger/simulate_available</c> endpoint to simulate converting pending balance to available balance for all originators in the Sandbox environment.
    /// </remarks>
    public Task<SandboxTransferLedgerSimulateAvailableResponse> SandboxTransferLedgerSimulateAvailable(SandboxTransferLedgerSimulateAvailableRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sandbox/transfer/ledger/simulate_available"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SandboxTransferLedgerSimulateAvailableResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Simulate a ledger withdraw event in Sandbox
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SandboxTransferLedgerWithdrawSimulateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/sandbox/transfer/ledger/withdraw/simulate</c> endpoint to simulate a ledger withdraw event in the Sandbox environment.
    /// </remarks>
    public Task<SandboxTransferLedgerWithdrawSimulateResponse> SandboxTransferLedgerWithdrawSimulate(SandboxTransferLedgerWithdrawSimulateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sandbox/transfer/ledger/withdraw/simulate"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SandboxTransferLedgerWithdrawSimulateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Simulate a refund event in Sandbox
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SandboxTransferRefundSimulateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/sandbox/transfer/refund/simulate</c> endpoint to simulate a refund event in the Sandbox environment.  Note that while an event will be simulated and will appear when using endpoints such as <c>/transfer/event/sync</c> or <c>/transfer/event/list</c>, no transactions will actually take place and funds will not move between accounts, even within the Sandbox.
    /// </remarks>
    public Task<SandboxTransferRefundSimulateResponse> SandboxTransferRefundSimulate(SandboxTransferRefundSimulateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sandbox/transfer/refund/simulate"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SandboxTransferRefundSimulateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Trigger the creation of a repayment
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SandboxTransferRepaymentSimulateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/sandbox/transfer/repayment/simulate</c> endpoint to trigger the creation of a repayment. As a side effect of calling this route, a repayment is created that includes all unreimbursed returns of guaranteed transfers. If there are no such returns, a 400 error is returned.
    /// </remarks>
    public Task<SandboxTransferRepaymentSimulateResponse> SandboxTransferRepaymentSimulate(SandboxTransferRepaymentSimulateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sandbox/transfer/repayment/simulate"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SandboxTransferRepaymentSimulateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Simulate a transfer event in Sandbox
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SandboxTransferSimulateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/sandbox/transfer/simulate</c> endpoint to simulate a transfer event in the Sandbox environment.  Note that while an event will be simulated and will appear when using endpoints such as <c>/transfer/event/sync</c> or <c>/transfer/event/list</c>, no transactions will actually take place and funds will not move between accounts, even within the Sandbox.
    /// </remarks>
    public Task<SandboxTransferSimulateResponse> SandboxTransferSimulate(SandboxTransferSimulateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sandbox/transfer/simulate"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SandboxTransferSimulateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Simulate creating a sweep
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SandboxTransferSweepSimulateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/sandbox/transfer/sweep/simulate</c> endpoint to create a sweep and associated events in the Sandbox environment. Upon calling this endpoint, all transfers with a sweep status of <c>swept</c> will become <c>swept_settled</c>, all <c>posted</c> or <c>pending</c> transfers with a sweep status of <c>unswept</c> will become <c>swept</c>, and all <c>returned</c> transfers with a sweep status of <c>swept</c> will become <c>return_swept</c>.
    /// </remarks>
    public Task<SandboxTransferSweepSimulateResponse> SandboxTransferSweepSimulate(SandboxTransferSweepSimulateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sandbox/transfer/sweep/simulate"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SandboxTransferSweepSimulateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Advance a test clock
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SandboxTransferTestClockAdvanceResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/sandbox/transfer/test_clock/advance</c> endpoint to advance a <c>test_clock</c> in the Sandbox environment.
    /// <para>
    /// A test clock object represents an independent timeline and has a <c>virtual_time</c> field indicating the current timestamp of the timeline. A test clock can be advanced by incrementing <c>virtual_time</c>, but may never go back to a lower <c>virtual_time</c>.
    /// </para>
    /// <para>
    /// If a test clock is advanced, we will simulate the changes that ought to occur during the time that elapsed.
    /// </para>
    /// <para>
    /// For example, a client creates a weekly recurring transfer with a test clock set at t. When the client advances the test clock by setting <c>virtual_time</c> = t + 15 days, 2 new originations should be created, along with the webhook events.
    /// </para>
    /// <para>
    /// The advancement of the test clock from its current <c>virtual_time</c> should be limited such that there are no more than 20 originations resulting from the advance operation on each <c>recurring_transfer</c> associated with the <c>test_clock</c>.
    /// </para>
    /// <para>
    /// For example, if the recurring transfer associated with this test clock originates once every 4 weeks, you can advance the <c>virtual_time</c> up to 80 weeks on each API call.
    /// </para>
    /// </remarks>
    public Task<SandboxTransferTestClockAdvanceResponse> SandboxTransferTestClockAdvance(SandboxTransferTestClockAdvanceRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sandbox/transfer/test_clock/advance"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SandboxTransferTestClockAdvanceResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Create a test clock
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SandboxTransferTestClockCreateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/sandbox/transfer/test_clock/create</c> endpoint to create a <c>test_clock</c> in the Sandbox environment.
    /// <para>
    /// A test clock object represents an independent timeline and has a <c>virtual_time</c> field indicating the current timestamp of the timeline. Test clocks are used for testing recurring transfers in Sandbox.
    /// </para>
    /// <para>
    /// A test clock can be associated with up to 5 recurring transfers.
    /// </para>
    /// </remarks>
    public Task<SandboxTransferTestClockCreateResponse> SandboxTransferTestClockCreate(SandboxTransferTestClockCreateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sandbox/transfer/test_clock/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SandboxTransferTestClockCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Get a test clock
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SandboxTransferTestClockGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/sandbox/transfer/test_clock/get</c> endpoint to get a <c>test_clock</c> in the Sandbox environment.
    /// </remarks>
    public Task<SandboxTransferTestClockGetResponse> SandboxTransferTestClockGet(SandboxTransferTestClockGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sandbox/transfer/test_clock/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SandboxTransferTestClockGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// List test clocks
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SandboxTransferTestClockListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/sandbox/transfer/test_clock/list</c> endpoint to see a list of all your test clocks in the Sandbox environment, by ascending <c>virtual_time</c>. Results are paginated; use the <c>count</c> and <c>offset</c> query parameters to retrieve the desired test clocks.
    /// </remarks>
    public Task<SandboxTransferTestClockListResponse> SandboxTransferTestClockList(SandboxTransferTestClockListRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sandbox/transfer/test_clock/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SandboxTransferTestClockListResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Force item(s) for a Sandbox User into an error state
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SandboxUserResetLoginResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/sandbox/user/reset_login</c> functions the same as <c>/sandbox/item/reset_login</c>, but will modify Items related to a User. This endpoint forces each Item into an <c>ITEM_LOGIN_REQUIRED</c> state in order to simulate an Item whose login is no longer valid. This makes it easy to test Link's <see href="https://plaid.com/docs/link/update-mode">update mode</see> flow in the Sandbox environment.  After calling <c>/sandbox/user/reset_login</c>, you can then use Plaid Link update mode to restore Items associated with the User to a good state. An <c>ITEM_LOGIN_REQUIRED</c> webhook will also be fired after a call to this endpoint, if one is associated with the Item.
    /// In the Sandbox, Items will transition to an <c>ITEM_LOGIN_REQUIRED</c> error state automatically after 30 days, even if this endpoint is not called.
    /// </remarks>
    public Task<SandboxUserResetLoginResponse> SandboxUserResetLogin(SandboxUserResetLoginRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sandbox/user/reset_login"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SandboxUserResetLoginResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Create a Link token for Layer
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SessionTokenCreateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/session/token/create</c> is used to create a Link token for Layer. The returned Link token is used as a parameter when initializing the Link SDK. For more details, see the <see href="https://plaid.com/docs/link/#link-flow-overview">Link flow overview</see>.
    /// </remarks>
    public Task<SessionTokenCreateResponse> SessionTokenCreate(SessionTokenCreateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/session/token/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SessionTokenCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Report whether you initiated an ACH transaction
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SignalDecisionReportResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// After you call <c>/signal/evaluate</c>, Plaid will normally infer the outcome from your Signal Rules. However, if you are not using Signal Rules, if the Signal Rules outcome was <c>REVIEW</c>, or if you take a different action than the one determined by the Signal Rules, you will need to call <c>/signal/decision/report</c>. This helps improve Signal Transaction Score accuracy for your account and is necessary for proper functioning of the rule performance and rule tuning capabilities in the Dashboard. If your effective decision changes after calling <c>/signal/decision/report</c> (for example, you indicated that you accepted a transaction, but later on, your payment processor rejected it, so it was never initiated), call <c>/signal/decision/report</c> again for the transaction to correct Plaid's records.
    /// <para>
    /// If you are using Plaid Transfer as your payment processor, you also do not need to call <c>/signal/decision/report</c>, as Plaid can infer outcomes from your Transfer activity.
    /// </para>
    /// <para>
    /// If using a Balance-only ruleset, this endpoint will not impact scores (Balance does not use scores), but is necessary to view accurate transaction outcomes and tune rule logic in the Dashboard.
    /// </para>
    /// </remarks>
    public Task<SignalDecisionReportResponse> SignalDecisionReport(SignalDecisionReportRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/signal/decision/report"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SignalDecisionReportResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Evaluate a planned ACH transaction
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SignalEvaluateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use <c>/signal/evaluate</c> to evaluate a planned ACH transaction to get a return risk assessment and additional risk signals.
    /// <para>
    /// Before using <c>/signal/evaluate</c>, you must first <see href="https://plaid.com/docs/signal/signal-rules/">create a ruleset</see> in the Dashboard under <see href="https://dashboard.plaid.com/signal/risk-profiles"><b>Signal-&gt;Rules</b></see>.
    /// </para>
    /// <para>
    /// <c>/signal/evaluate</c> can be used with either Signal Transaction Scores or the Balance product. Which product is used will be determined by the <c>ruleset_key</c> that you provide. For more details, see <see href="https://plaid.com/docs/signal/signal-rules/">Signal Rules</see>.
    /// </para>
    /// <para>
    /// Note: This request may have higher latency when using a Balance-only ruleset. This is because Plaid must communicate directly with the institution to request data. Balance-only rulesets may have latency of up to 30 seconds or more; if you encounter errors, you may find it necessary to adjust your timeout period when making requests.
    /// </para>
    /// </remarks>
    public Task<SignalEvaluateResponse> SignalEvaluate(SignalEvaluateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/signal/evaluate"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SignalEvaluateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Opt-in an Item to Signal Transaction Scores
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SignalPrepareResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// When an Item is not initialized with <c>signal</c>, call <c>/signal/prepare</c> to opt-in that Item to the data collection process used to develop a Signal Transaction Score. This should be done on Items where <c>signal</c> was added in the <c>additional_consented_products</c> array but not in the <c>products</c>, <c>optional_products</c>, or <c>required_if_supported_products</c> array. If <c>/signal/prepare</c> is skipped on an Item that is not initialized with <c>signal</c>, the initial call to <c>/signal/evaluate</c> on that Item will be less accurate, because Plaid will have access to less data for computing the Signal Transaction Score.
    /// <para>
    /// If your integration is purely Balance-only, this endpoint will have no effect, as Balance-only rulesets do not calculate a Signal Transaction Score.
    /// </para>
    /// <para>
    /// If run on an Item that is already initialized with <c>signal</c>, this endpoint will return a 200 response and will not modify the Item.
    /// </para>
    /// </remarks>
    public Task<SignalPrepareResponse> SignalPrepare(SignalPrepareRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/signal/prepare"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SignalPrepareResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Report a return for an ACH transaction
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SignalReturnReportResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Call the <c>/signal/return/report</c> endpoint to report a returned transaction that was previously sent to the <c>/signal/evaluate</c> endpoint. Your feedback will be used by the model to incorporate the latest risk trends into your scores and tune rule logic. If using a Balance-only ruleset, this endpoint will not impact scores (as Balance does not use scores), but is necessary to view accurate transaction outcomes and tune rule logic in the Dashboard.
    /// </remarks>
    public Task<SignalReturnReportResponse> SignalReturnReport(SignalReturnReportRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/signal/return/report"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SignalReturnReportResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Schedule a planned ACH transaction
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SignalScheduleResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use <c>/signal/schedule</c> to schedule a planned ACH transaction.
    /// </remarks>
    public Task<SignalScheduleResponse> SignalSchedule(SignalScheduleRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/signal/schedule"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SignalScheduleResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve a single statement.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/statements/download</c> endpoint retrieves a single statement PDF in binary format.  The response will contain a <c>Plaid-Content-Hash</c> header containing a SHA 256 checksum of the statement. This can be used to verify that the file being sent by Plaid is the same file that was downloaded to your system.
    /// </remarks>
    public Task StatementsDownload(StatementsDownloadRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/statements/download"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            VoidResponse.Instance,
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve a list of all statements associated with an Item.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="StatementsListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/statements/list</c> endpoint retrieves a list of all statements associated with an Item.
    /// </remarks>
    public Task<StatementsListResponse> StatementsList(StatementsListRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/statements/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<StatementsListResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Refresh statements data.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="StatementsRefreshResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/statements/refresh</c> initiates an on-demand extraction to fetch the statements for the provided dates.
    /// </remarks>
    public Task<StatementsRefreshResponse> StatementsRefresh(StatementsRefreshRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/statements/refresh"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<StatementsRefreshResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Enhance locally-held transaction data
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransactionsEnhanceGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/beta/transactions/v1/enhance</c> endpoint enriches raw transaction data provided directly by clients.
    /// <para>
    /// The product is currently in beta.
    /// </para>
    /// </remarks>
    public Task<TransactionsEnhanceGetResponse> TransactionsEnhance(TransactionsEnhanceGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/beta/transactions/v1/enhance"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransactionsEnhanceGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Enrich locally-held transaction data
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransactionsEnrichResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/transactions/enrich</c> endpoint enriches raw transaction data generated by your own banking products or retrieved from other non-Plaid sources.
    /// </remarks>
    public Task<TransactionsEnrichResponse> TransactionsEnrich(TransactionsEnrichRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transactions/enrich"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransactionsEnrichResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Get transaction data
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransactionsGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Note: All new implementations are encouraged to use <c>/transactions/sync</c> rather than <c>/transactions/get</c>. <c>/transactions/sync</c> provides the same functionality as <c>/transactions/get</c> and improves developer ease-of-use for handling transactions updates.
    /// The <c>/transactions/get</c> endpoint allows developers to receive user-authorized transaction data for credit, depository, and some loan-type accounts (only those with account subtype <c>student</c> or <c>mortgage</c>; coverage may be limited). For transaction history from investment accounts, use the <see href="https://plaid.com/docs/api/products/investments/">Investments endpoint</see> instead. Transaction data is standardized across financial institutions, and in many cases transactions are linked to a clean name, entity type, location, and category. Similarly, account data is standardized and returned with a clean name, number, balance, and other meta information where available.
    /// Transactions are returned in reverse-chronological order, and the sequence of transaction ordering is stable and will not shift.  Transactions are not immutable and can also be removed altogether by the institution; a removed transaction will no longer appear in <c>/transactions/get</c>.  For more details, see <see href="https://plaid.com/docs/transactions/transactions-data/#pending-and-posted-transactions">Pending and posted transactions</see>.
    /// Due to the potentially large number of transactions associated with an Item, results are paginated. Manipulate the <c>count</c> and <c>offset</c> parameters in conjunction with the <c>total_transactions</c> response body field to fetch all available transactions.
    /// Data returned by <c>/transactions/get</c> will be the data available for the Item as of the most recent successful check for new transactions. Plaid typically checks for new data multiple times a day, but these checks may occur less frequently, such as once a day, depending on the institution. To find out when the Item was last updated, use the <see href="https://plaid.com/docs/account/activity/#troubleshooting-with-item-debugger">Item Debugger</see> or call <c>/item/get</c>; the <c>item.status.transactions.last_successful_update</c> field will show the timestamp of the most recent successful update. To force Plaid to check for new transactions, you can use the <c>/transactions/refresh</c> endpoint.
    /// <para>
    ///
    /// Note that data may not be immediately available to <c>/transactions/get</c>. Plaid will begin to prepare transactions data upon Item link, if Link was initialized with <c>transactions</c>, or upon the first call to <c>/transactions/get</c>, if it wasn't. To be alerted when transaction data is ready to be fetched, listen for the <see href="https://plaid.com/docs/api/products/transactions/#initial_update"><c>INITIAL_UPDATE</c></see> and <see href="https://plaid.com/docs/api/products/transactions/#historical_update"><c>HISTORICAL_UPDATE</c></see> webhooks. If no transaction history is ready when <c>/transactions/get</c> is called, it will return a <c>PRODUCT_NOT_READY</c> error.
    /// </para>
    /// </remarks>
    public Task<TransactionsGetResponse> TransactionsGet(TransactionsGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transactions/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransactionsGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Fetch recurring transaction streams
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransactionsRecurringGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/transactions/recurring/get</c> endpoint allows developers to receive a summary of the recurring outflow and inflow streams (expenses and deposits) from a user's checking, savings or credit card accounts. Additionally, Plaid provides key insights about each recurring stream including the category, merchant, last amount, and more. Developers can use these insights to build tools and experiences that help their users better manage cash flow, monitor subscriptions, reduce spend, and stay on track with bill payments.
    /// <para>
    /// This endpoint is offered as an add-on to Transactions. To request access to this endpoint, submit a <see href="https://dashboard.plaid.com/team/products">product access request</see> or contact your Plaid account manager.
    /// </para>
    /// <para>
    /// This endpoint can only be called on an Item that has already been initialized with Transactions (either during Link, by specifying it in <c>/link/token/create</c>; or after Link, by calling <c>/transactions/get</c> or <c>/transactions/sync</c>).
    /// </para>
    /// <para>
    /// When using Recurring Transactions, for best results, make sure to use the <see href="https://plaid.com/docs/api/link/#link-token-create-request-transactions-days-requested"><c>days_requested</c></see> parameter to request at least 180 days of history when initializing Items with Transactions. Once all historical transactions have been fetched, call <c>/transactions/recurring/get</c> to receive the Recurring Transactions streams and subscribe to the <see href="https://plaid.com/docs/api/products/transactions/#recurring_transactions_update"><c>RECURRING_TRANSACTIONS_UPDATE</c></see> webhook. To know when historical transactions have been fetched, if you are using <c>/transactions/sync</c> listen for the <see href="https://plaid.com/docs/api/products/transactions/#SyncUpdatesAvailableWebhook-historical-update-complete"><c>SYNC_UPDATES_AVAILABLE</c></see> webhook and check that the <c>historical_update_complete</c> field in the payload is <c>true</c>. If using <c>/transactions/get</c>, listen for the <see href="https://plaid.com/docs/api/products/transactions/#historical_update"><c>HISTORICAL_UPDATE</c></see> webhook.
    /// </para>
    /// <para>
    /// After the initial call, you can call the <c>/transactions/recurring/get</c> endpoint at any point in the future to retrieve the latest summary of recurring streams. Listen to the <see href="https://plaid.com/docs/api/products/transactions/#recurring_transactions_update"><c>RECURRING_TRANSACTIONS_UPDATE</c></see> webhook to be notified when new updates are available.
    /// </para>
    /// </remarks>
    public Task<TransactionsRecurringGetResponse> TransactionsRecurringGet(TransactionsRecurringGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transactions/recurring/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransactionsRecurringGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Refresh transaction data
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransactionsRefreshResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/transactions/refresh</c> is an optional endpoint that initiates an on-demand extraction to fetch the newest transactions for an Item. The on-demand extraction takes place in addition to the periodic extractions that automatically occur one or more times per day for any Transactions-enabled Item. The Item must already have Transactions added as a product in order to call <c>/transactions/refresh</c>.
    /// <para>
    /// If changes to transactions are discovered after calling <c>/transactions/refresh</c>, Plaid will fire a webhook: for <c>/transactions/sync</c> users, <see href="https://plaid.com/docs/api/products/transactions/#sync_updates_available"><c>SYNC_UPDATES_AVAILABLE</c></see> will be fired if there are any transactions updated, added, or removed. For users of both <c>/transactions/sync</c> and <c>/transactions/get</c>, <see href="https://plaid.com/docs/api/products/transactions/#transactions_removed"><c>TRANSACTIONS_REMOVED</c></see> will be fired if any removed transactions are detected, and <see href="https://plaid.com/docs/api/products/transactions/#default_update"><c>DEFAULT_UPDATE</c></see> will be fired if any new transactions are detected. New transactions can be fetched by calling <c>/transactions/get</c> or <c>/transactions/sync</c>.
    /// </para>
    /// <para>
    /// Note that the <c>/transactions/refresh</c> endpoint is not supported for Capital One (<c>ins_128026</c>) non-depository accounts and will result in a <c>PRODUCTS_NOT_SUPPORTED</c> error if called on an Item that contains only non-depository accounts from that institution.
    /// </para>
    /// <para>
    /// As this endpoint triggers a synchronous request for fresh data, latency may be higher than for other Plaid endpoints (typically less than 10 seconds, but occasionally up to 30 seconds or more); if you encounter errors, you may find it necessary to adjust your timeout period when making requests.
    /// </para>
    /// <para>
    /// <c>/transactions/refresh</c> is offered as an optional add-on to Transactions and has a separate <see href="https://plaid.com/docs/account/billing/#per-request-flat-fee">fee model</see>. To request access to this endpoint, submit a <see href="https://dashboard.plaid.com/team/products">product access request</see> or contact your Plaid account manager.
    /// </para>
    /// </remarks>
    public Task<TransactionsRefreshResponse> TransactionsRefresh(TransactionsRefreshRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transactions/refresh"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransactionsRefreshResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Create transaction category rule
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransactionsRulesCreateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/beta/transactions/rules/v1/create</c> endpoint creates transaction categorization rules.
    /// <para>
    /// Rules will be applied on the Item's transactions returned in <c>/transactions/get</c> response.
    /// </para>
    /// <para>
    /// The product is currently in beta. To request access, contact transactions-feedback@plaid.com.
    /// </para>
    /// </remarks>
    public Task<TransactionsRulesCreateResponse> TransactionsRulesCreate(TransactionsRulesCreateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/beta/transactions/rules/v1/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransactionsRulesCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Return a list of rules created for the Item associated with the access token.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransactionsRulesListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/beta/transactions/rules/v1/list</c> returns a list of transaction rules created for the Item associated with the access token.
    /// </remarks>
    public Task<TransactionsRulesListResponse> TransactionsRulesList(TransactionsRulesListRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/beta/transactions/rules/v1/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransactionsRulesListResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Remove transaction rule
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransactionsRulesRemoveResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/beta/transactions/rules/v1/remove</c> endpoint is used to remove a transaction rule.
    /// </remarks>
    public Task<TransactionsRulesRemoveResponse> TransactionsRulesRemove(TransactionsRulesRemoveRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/beta/transactions/rules/v1/remove"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransactionsRulesRemoveResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Get incremental transaction updates on an Item
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransactionsSyncResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/transactions/sync</c> endpoint retrieves transactions associated with an Item and can fetch updates using a cursor to track which updates have already been seen.
    /// <para>
    /// For important instructions on integrating with <c>/transactions/sync</c>, see the <see href="https://plaid.com/docs/transactions/#integration-overview">Transactions integration overview</see>. If you are migrating from an existing integration using <c>/transactions/get</c>, see the <see href="https://plaid.com/docs/transactions/sync-migration/">Transactions Sync migration guide</see>.
    /// </para>
    /// <para>
    /// This endpoint supports <c>credit</c>, <c>depository</c>, and some <c>loan</c>-type accounts (only those with account subtype <c>student</c> or <c>mortgage</c>). For <c>investments</c> accounts, use <c>/investments/transactions/get</c> instead.
    /// </para>
    /// <para>
    /// When retrieving paginated updates, track both the <c>next_cursor</c> from the latest response and the original cursor from the first call in which <c>has_more</c> was <c>true</c>; if a call to <c>/transactions/sync</c> fails when retrieving a paginated update (e.g. due to the <see href="https://plaid.com/docs/errors/transactions/#transactions_sync_mutation_during_pagination"><c>TRANSACTIONS_SYNC_MUTATION_DURING_PAGINATION</c></see> error), the entire pagination request loop must be restarted beginning with the cursor for the first page of the update, rather than retrying only the single request that failed.
    /// </para>
    /// <para>
    /// If transactions data is not yet available for the Item, which can happen if the Item was not initialized with transactions during the <c>/link/token/create</c> call or if <c>/transactions/sync</c> was called within a few seconds of Item creation, <c>/transactions/sync</c> will return empty transactions arrays.
    /// </para>
    /// <para>
    /// Plaid typically checks for new transactions data between one and four times per day, depending on the institution. To find out when transactions were last updated for an Item, use the <see href="https://plaid.com/docs/account/activity/#troubleshooting-with-item-debugger">Item Debugger</see> or call <c>/item/get</c>; the <c>item.status.transactions.last_successful_update</c> field will show the timestamp of the most recent successful update. To force Plaid to check for new transactions, use the <c>/transactions/refresh</c> endpoint.
    /// </para>
    /// <para>
    /// To be alerted when new transactions are available, listen for the <see href="https://plaid.com/docs/api/products/transactions/#sync_updates_available"><c>SYNC_UPDATES_AVAILABLE</c></see> webhook.
    /// </para>
    /// </remarks>
    public Task<TransactionsSyncResponse> TransactionsSync(TransactionsSyncRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transactions/sync"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransactionsSyncResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Obtain user insights based on transactions sent through the transactions enrich endpoint
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransactionsUserInsightsGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/beta/transactions/user_insights/v1/get</c> gets user insights for clients who have enriched data with <c>/transactions/enrich</c>.
    /// <para>
    /// The product is currently in beta.
    /// </para>
    /// </remarks>
    public Task<TransactionsUserInsightsGetResponse> TransactionsUserInsightsGet(TransactionsUserInsightsGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/beta/transactions/user_insights/v1/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransactionsUserInsightsGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Cancel a transfer authorization
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferAuthorizationCancelResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/transfer/authorization/cancel</c> endpoint to cancel a transfer authorization. A transfer authorization is eligible for cancellation if it has not yet been used to create a transfer.
    /// </remarks>
    public Task<TransferAuthorizationCancelResponse> TransferAuthorizationCancel(TransferAuthorizationCancelRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transfer/authorization/cancel"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransferAuthorizationCancelResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Create a transfer authorization
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferAuthorizationCreateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/transfer/authorization/create</c> endpoint to authorize a transfer. This endpoint must be called prior to calling <c>/transfer/create</c>. The transfer authorization will expire if not used after one hour. (You can contact your account manager to change the default authorization lifetime.)
    /// <para>
    /// There are four possible outcomes to calling this endpoint:
    /// </para>
    /// <list type="bullet">
    ///   <item><description>If the <c>authorization.decision</c> in the response is <c>declined</c>, the proposed transfer has failed the risk check and you cannot proceed with the transfer.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>If the <c>authorization.decision</c> is <c>user_action_required</c>, additional user input is needed, usually to fix a broken bank connection, before Plaid can properly assess the risk. You need to launch Link in update mode to complete the required user action. When calling <c>/link/token/create</c> to get a new Link token, instead of providing <c>access_token</c> in the request, you should set <see href="https://plaid.com/docs/api/link/#link-token-create-request-transfer-authorization-id"><c>transfer.authorization_id</c></see> as the <c>authorization.id</c>. After the Link flow is completed, you may re-attempt the authorization.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>If the <c>authorization.decision</c> is <c>approved</c>, and the <c>authorization.decision_rationale.code</c> is <c>null</c>, the transfer has passed the risk check and you can proceed to call <c>/transfer/create</c>.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>If the <c>authorization.decision</c> is <c>approved</c> and the <c>authorization.decision_rationale.code</c> is non-<c>null</c>, the risk check could not be run: you may proceed with the transfer, but should perform your own risk evaluation. For more details, see the response schema.</description></item>
    /// </list>
    /// <para>
    /// In Plaid's Sandbox environment the decisions will be returned as follows:
    /// </para>
    /// <list type="bullet">
    ///   <item><description>To approve a transfer with <c>null</c> rationale code, make an authorization request with an <c>amount</c> less than the available balance in the account.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>To approve a transfer with the rationale code <c>MANUALLY_VERIFIED_ITEM</c>, create an Item in Link through the <see href="https://plaid.com/docs/auth/coverage/testing/#testing-same-day-micro-deposits">Same-Day Micro-deposits flow</see>.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>To get an authorization decision of <c>user_action_required</c>, <see href="https://plaid.com/docs/sandbox/#item_login_required">reset the login for an Item</see>.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>To decline a transfer with the rationale code <c>NSF</c>, the available balance on the account must be less than the authorization <c>amount</c>. See <see href="https://plaid.com/docs/sandbox/user-custom/">Create Sandbox test data</see> for details on how to customize data in Sandbox.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>To decline a transfer with the rationale code <c>RISK</c>, the available balance on the account must be exactly $0. See <see href="https://plaid.com/docs/sandbox/user-custom/">Create Sandbox test data</see> for details on how to customize data in Sandbox.</description></item>
    /// </list>
    /// </remarks>
    public Task<TransferAuthorizationCreateResponse> TransferAuthorizationCreate(TransferAuthorizationCreateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transfer/authorization/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransferAuthorizationCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// (Deprecated) Retrieve a balance held with Plaid
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferBalanceGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// (Deprecated) Use the <c>/transfer/ledger/get</c> endpoint to view a balance held with Plaid.
    /// </remarks>
    public Task<TransferBalanceGetResponse> TransferBalanceGet(TransferBalanceGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transfer/balance/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransferBalanceGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Cancel a transfer
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferCancelResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/transfer/cancel</c> endpoint to cancel a transfer.  A transfer is eligible for cancellation if the <c>cancellable</c> property returned by <c>/transfer/get</c> is <c>true</c>.
    /// </remarks>
    public Task<TransferCancelResponse> TransferCancel(TransferCancelRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transfer/cancel"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransferCancelResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Get RTP eligibility information of a transfer
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferCapabilitiesGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/transfer/capabilities/get</c> endpoint to determine the RTP eligibility information of an account to be used with Transfer. This endpoint works on all Transfer-capable Items, including those created by <c>/transfer/migrate_account</c>.
    /// </remarks>
    public Task<TransferCapabilitiesGetResponse> TransferCapabilitiesGet(TransferCapabilitiesGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transfer/capabilities/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransferCapabilitiesGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Get transfer product configuration
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferConfigurationGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/transfer/configuration/get</c> endpoint to view your transfer product configurations.
    /// </remarks>
    public Task<TransferConfigurationGetResponse> TransferConfigurationGet(TransferConfigurationGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transfer/configuration/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransferConfigurationGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Create a transfer
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferCreateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/transfer/create</c> endpoint to initiate a new transfer. This endpoint is retryable and idempotent; if a transfer with the provided <c>transfer_id</c> has already been created, it will return the transfer details without creating a new transfer. A transfer may still be created if a 500 error is returned; to detect this scenario, use <see href="https://plaid.com/docs/transfer/reconciling-transfers/">Transfer events</see>.
    /// </remarks>
    public Task<TransferCreateResponse> TransferCreate(TransferCreateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transfer/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransferCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Upload transfer diligence document on behalf of the originator
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferDiligenceDocumentUploadResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Third-party sender customers can use the <c>/transfer/diligence/document/upload</c> endpoint to upload a document on behalf of their end customer (i.e. originator) to Plaid. You'll need to send a request of type <c>multipart/form-data</c>.
    /// You must provide the <c>client_id</c> in the <c>PLAID-CLIENT-ID</c> header and <c>secret</c> in the <c>PLAID-SECRET</c> header.
    /// </remarks>
    public Task<TransferDiligenceDocumentUploadResponse> TransferDiligenceDocumentUpload(TransferDiligenceDocumentUploadRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transfer/diligence/document/upload"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransferDiligenceDocumentUploadResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Submit transfer diligence on behalf of the originator
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferDiligenceSubmitResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/transfer/diligence/submit</c> endpoint to submit transfer diligence on behalf of the originator (i.e., the end customer).
    /// </remarks>
    public Task<TransferDiligenceSubmitResponse> TransferDiligenceSubmit(TransferDiligenceSubmitRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transfer/diligence/submit"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransferDiligenceSubmitResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// List transfer events
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferEventListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/transfer/event/list</c> endpoint to get a list of transfer events based on specified filter criteria.
    /// </remarks>
    public Task<TransferEventListResponse> TransferEventList(TransferEventListRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transfer/event/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransferEventListResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Sync transfer events
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferEventSyncResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/transfer/event/sync</c> allows you to request up to the next 500 transfer events that happened after a specific <c>event_id</c>. Use the <c>/transfer/event/sync</c> endpoint to guarantee you have seen all transfer events.
    /// </remarks>
    public Task<TransferEventSyncResponse> TransferEventSync(TransferEventSyncRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transfer/event/sync"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransferEventSyncResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve a transfer
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/transfer/get</c> endpoint fetches information about the transfer corresponding to the given <c>transfer_id</c> or <c>authorization_id</c>. One of <c>transfer_id</c> or <c>authorization_id</c> must be populated but not both.
    /// </remarks>
    public Task<TransferGetResponse> TransferGet(TransferGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transfer/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransferGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Create a transfer intent object to invoke the Transfer UI
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferIntentCreateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/transfer/intent/create</c> endpoint to generate a transfer intent object and invoke the Transfer UI.
    /// </remarks>
    public Task<TransferIntentCreateResponse> TransferIntentCreate(TransferIntentCreateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transfer/intent/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransferIntentCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve more information about a transfer intent
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferIntentGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/transfer/intent/get</c> endpoint to retrieve more information about a transfer intent.
    /// </remarks>
    public Task<TransferIntentGetResponse> TransferIntentGet(TransferIntentGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transfer/intent/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransferIntentGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Deposit funds into a Plaid Ledger balance
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferLedgerDepositResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/transfer/ledger/deposit</c> endpoint to deposit funds into Plaid Ledger.
    /// </remarks>
    public Task<TransferLedgerDepositResponse> TransferLedgerDeposit(TransferLedgerDepositRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transfer/ledger/deposit"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransferLedgerDepositResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Move available balance between ledgers
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferLedgerDistributeResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/transfer/ledger/distribute</c> endpoint to move available balance between ledgers, if you have multiple. If you're a platform, you can move funds between one of your ledgers and one of your customer's ledgers.
    /// </remarks>
    public Task<TransferLedgerDistributeResponse> TransferLedgerDistribute(TransferLedgerDistributeRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transfer/ledger/distribute"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransferLedgerDistributeResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// List transfer ledger events
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferLedgerEventListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/transfer/ledger/event/list</c> endpoint to get a list of ledger events for a specific ledger based on specified filter criteria.
    /// </remarks>
    public Task<TransferLedgerEventListResponse> TransferLedgerEventList(TransferLedgerEventListRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transfer/ledger/event/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransferLedgerEventListResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve Plaid Ledger balance
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferLedgerGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/transfer/ledger/get</c> endpoint to view a balance on the ledger held with Plaid.
    /// </remarks>
    public Task<TransferLedgerGetResponse> TransferLedgerGet(TransferLedgerGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transfer/ledger/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransferLedgerGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Withdraw funds from a Plaid Ledger balance
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferLedgerWithdrawResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/transfer/ledger/withdraw</c> endpoint to withdraw funds from a Plaid Ledger balance.
    /// </remarks>
    public Task<TransferLedgerWithdrawResponse> TransferLedgerWithdraw(TransferLedgerWithdrawRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transfer/ledger/withdraw"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransferLedgerWithdrawResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// List transfers
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/transfer/list</c> endpoint to see a list of all your transfers and their statuses. Results are paginated; use the <c>count</c> and <c>offset</c> query parameters to retrieve the desired transfers.
    /// </remarks>
    public Task<TransferListResponse> TransferList(TransferListRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transfer/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransferListResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Get transfer product usage metrics
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferMetricsGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/transfer/metrics/get</c> endpoint to view your transfer product usage metrics.
    /// <para>
    /// In the Sandbox environment, this endpoint returns static placeholder values rather than metrics computed from your Sandbox transfer activity.
    /// </para>
    /// </remarks>
    public Task<TransferMetricsGetResponse> TransferMetricsGet(TransferMetricsGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transfer/metrics/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransferMetricsGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Migrate account into Transfers
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferMigrateAccountResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// As an alternative to adding Items via Link, you can also use the <c>/transfer/migrate_account</c> endpoint to migrate previously-verified account and routing numbers to Plaid Items. This endpoint is also required when adding an Item for use with wire transfers; if you intend to create wire transfers on this account, you must provide <c>wire_routing_number</c>. Note that Items created in this way are not compatible with endpoints for other products, such as <c>/accounts/balance/get</c>, and can only be used with Transfer endpoints.  If you require access to other endpoints, create the Item through Link instead.  Access to <c>/transfer/migrate_account</c> is not enabled by default; to obtain access, contact your Plaid account manager or <see href="https://dashboard.plaid.com/support">support</see>.
    /// </remarks>
    public Task<TransferMigrateAccountResponse> TransferMigrateAccount(TransferMigrateAccountRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transfer/migrate_account"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransferMigrateAccountResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Create a new originator
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferOriginatorCreateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/transfer/originator/create</c> endpoint to create a new originator and return an <c>originator_client_id</c>.
    /// </remarks>
    public Task<TransferOriginatorCreateResponse> TransferOriginatorCreate(TransferOriginatorCreateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transfer/originator/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransferOriginatorCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Create a new funding account for an originator
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferOriginatorFundingAccountCreateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/transfer/originator/funding_account/create</c> endpoint to create a new funding account for the originator.
    /// </remarks>
    public Task<TransferOriginatorFundingAccountCreateResponse> TransferOriginatorFundingAccountCreate(TransferOriginatorFundingAccountCreateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transfer/originator/funding_account/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransferOriginatorFundingAccountCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Update the funding account associated with the originator
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferOriginatorFundingAccountUpdateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/transfer/originator/funding_account/update</c> endpoint to update the funding account associated with the originator.
    /// </remarks>
    public Task<TransferOriginatorFundingAccountUpdateResponse> TransferOriginatorFundingAccountUpdate(TransferOriginatorFundingAccountUpdateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transfer/originator/funding_account/update"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransferOriginatorFundingAccountUpdateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Get status of an originator's onboarding
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferOriginatorGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/transfer/originator/get</c> endpoint gets status updates for an originator's onboarding process. This information is also available via the Transfer page on the Plaid dashboard.
    /// </remarks>
    public Task<TransferOriginatorGetResponse> TransferOriginatorGet(TransferOriginatorGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transfer/originator/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransferOriginatorGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Get status of all originators' onboarding
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferOriginatorListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/transfer/originator/list</c> endpoint gets status updates for all of your originators' onboarding. This information is also available via the Plaid dashboard.
    /// </remarks>
    public Task<TransferOriginatorListResponse> TransferOriginatorList(TransferOriginatorListRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transfer/originator/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransferOriginatorListResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Create an originator for Transfer for Platforms customers
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferPlatformOriginatorCreateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/transfer/platform/originator/create</c> endpoint to submit information about the originator you are onboarding, including the originator's agreement to the required legal terms.
    /// </remarks>
    public Task<TransferPlatformOriginatorCreateResponse> TransferPlatformOriginatorCreate(TransferPlatformOriginatorCreateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transfer/platform/originator/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransferPlatformOriginatorCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Create a person associated with an originator
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferPlatformPersonCreateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/transfer/platform/person/create</c> endpoint to create a person associated with an originator (e.g. beneficial owner or control person) and optionally submit personal identification information for them.
    /// </remarks>
    public Task<TransferPlatformPersonCreateResponse> TransferPlatformPersonCreate(TransferPlatformPersonCreateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transfer/platform/person/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransferPlatformPersonCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Submit additional onboarding information on behalf of an originator
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferPlatformRequirementSubmitResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/transfer/platform/requirement/submit</c> endpoint to submit additional onboarding information that is needed by Plaid to approve or decline the originator. See <see href="https://docs.google.com/document/d/1NEQkTD0sVK50iAQi6xHigrexDUxZ4QxXqSEfV_FFTiU/">Requirement type schema documentation</see> for a list of requirement types and possible values.
    /// </remarks>
    public Task<TransferPlatformRequirementSubmitResponse> TransferPlatformRequirementSubmit(TransferPlatformRequirementSubmitRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transfer/platform/requirement/submit"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransferPlatformRequirementSubmitResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Generate a Plaid-hosted onboarding UI URL.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferQuestionnaireCreateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/transfer/questionnaire/create</c> endpoint generates a Plaid-hosted onboarding UI URL. Redirect the originator to this URL to provide their due diligence information and agree to Plaid's terms for ACH money movement.
    /// </remarks>
    public Task<TransferQuestionnaireCreateResponse> TransferQuestionnaireCreate(TransferQuestionnaireCreateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transfer/questionnaire/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransferQuestionnaireCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Cancel a recurring transfer.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferRecurringCancelResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/transfer/recurring/cancel</c> endpoint to cancel a recurring transfer.  A scheduled transfer that hasn't been submitted to the bank will be cancelled.
    /// </remarks>
    public Task<TransferRecurringCancelResponse> TransferRecurringCancel(TransferRecurringCancelRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transfer/recurring/cancel"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransferRecurringCancelResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Create a recurring transfer
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferRecurringCreateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/transfer/recurring/create</c> endpoint to initiate a new recurring transfer. This capability is not currently supported for Transfer UI or Transfer for Platforms (beta) customers.
    /// </remarks>
    public Task<TransferRecurringCreateResponse> TransferRecurringCreate(TransferRecurringCreateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transfer/recurring/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransferRecurringCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve a recurring transfer
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferRecurringGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/transfer/recurring/get</c> fetches information about the recurring transfer corresponding to the given <c>recurring_transfer_id</c>.
    /// </remarks>
    public Task<TransferRecurringGetResponse> TransferRecurringGet(TransferRecurringGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transfer/recurring/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransferRecurringGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// List recurring transfers
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferRecurringListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/transfer/recurring/list</c> endpoint to see a list of all your recurring transfers and their statuses. Results are paginated; use the <c>count</c> and <c>offset</c> query parameters to retrieve the desired recurring transfers.
    /// </remarks>
    public Task<TransferRecurringListResponse> TransferRecurringList(TransferRecurringListRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transfer/recurring/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransferRecurringListResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Cancel a refund
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferRefundCancelResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/transfer/refund/cancel</c> endpoint to cancel a refund.  A refund is eligible for cancellation if it has not yet been submitted to the payment network.
    /// </remarks>
    public Task<TransferRefundCancelResponse> TransferRefundCancel(TransferRefundCancelRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transfer/refund/cancel"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransferRefundCancelResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Create a refund
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferRefundCreateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/transfer/refund/create</c> endpoint to create a refund for a transfer. A transfer can be refunded if the transfer was initiated in the past 180 days.
    /// <para>
    /// Refunds come out of the available balance of the ledger used for the original debit transfer. If there are not enough funds in the available balance to cover the refund amount, the refund will be rejected. You can create a refund at any time. Plaid does not impose any hold time on refunds.
    /// </para>
    /// <para>
    /// A refund can still be issued even if the Item's <c>access_token</c> is no longer valid (e.g. if the user revoked OAuth consent or the Item was deleted via <c>/item/remove</c>), as long as the account and routing number pair used to make the original transaction is still valid. A refund cannot be issued if the Item has an <see href="https://plaid.com/docs/auth/#tokenized-account-numbers">invalidated TAN</see>, which can occur at Chase or PNC.
    /// </para>
    /// </remarks>
    public Task<TransferRefundCreateResponse> TransferRefundCreate(TransferRefundCreateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transfer/refund/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransferRefundCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve a refund
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferRefundGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/transfer/refund/get</c> endpoint fetches information about the refund corresponding to the given <c>refund_id</c>.
    /// </remarks>
    public Task<TransferRefundGetResponse> TransferRefundGet(TransferRefundGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transfer/refund/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransferRefundGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Lists historical repayments
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferRepaymentListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/transfer/repayment/list</c> endpoint fetches repayments matching the given filters. Repayments are returned in reverse-chronological order (most recent first) starting at the given <c>start_time</c>.
    /// </remarks>
    public Task<TransferRepaymentListResponse> TransferRepaymentList(TransferRepaymentListRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transfer/repayment/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransferRepaymentListResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// List the returns included in a repayment
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferRepaymentReturnListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/transfer/repayment/return/list</c> endpoint retrieves the set of returns that were batched together into the specified repayment. The sum of amounts of returns retrieved by this request equals the amount of the repayment.
    /// </remarks>
    public Task<TransferRepaymentReturnListResponse> TransferRepaymentReturnList(TransferRepaymentReturnListRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transfer/repayment/return/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransferRepaymentReturnListResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Report a return recovery
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferReturnRecoverResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use the <c>/transfer/return/recover</c> endpoint to notify Plaid that you have recovered some or all of the loss on a returned guaranteed transfer.
    /// <para>
    /// Recovery can be reported in full or in parts; the sum of recovered amounts across calls cannot exceed the original transfer's amount.
    /// </para>
    /// </remarks>
    public Task<TransferReturnRecoverResponse> TransferReturnRecover(TransferReturnRecoverRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transfer/return/recover"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransferReturnRecoverResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve a sweep
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferSweepGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/transfer/sweep/get</c> endpoint fetches a sweep corresponding to the given <c>sweep_id</c>.
    /// </remarks>
    public Task<TransferSweepGetResponse> TransferSweepGet(TransferSweepGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transfer/sweep/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransferSweepGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// List sweeps
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferSweepListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The <c>/transfer/sweep/list</c> endpoint fetches sweeps matching the given filters.
    /// </remarks>
    public Task<TransferSweepListResponse> TransferSweepList(TransferSweepListRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transfer/sweep/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransferSweepListResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Send User Account Session Event
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UserAccountSessionEventSendResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows sending client-specific events related to Layer sessions for analytics and tracking purposes.
    /// </remarks>
    public Task<UserAccountSessionEventSendResponse> UserAccountSessionEventSend(UserAccountSessionEventSendRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/user_account/session/event/send"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<UserAccountSessionEventSendResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve User Account
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UserAccountSessionGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint returns user permissioned account data, including identity and Item access tokens, for use with <see href="https://plaid.com/docs/layer">Plaid Layer</see>. Note that end users are permitted to edit the prefilled identity data in the Link flow before sharing it with you; you should treat any identity data returned by this endpoint as user-submitted, unverified data. For a verification layer, you can add <see href="https://plaid.com/docs/identity-verification/">Identity Verification</see> to your flow, or check the submitted identity data against bank account data from linked accounts using <see href="https://plaid.com/docs/identity/#identity-match">Identity Match</see>.
    /// </remarks>
    public Task<UserAccountSessionGetResponse> UserAccountSessionGet(UserAccountSessionGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/user_account/session/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<UserAccountSessionGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Create user
    /// </summary>
    /// <param name="body"></param>
    /// <param name="plaidNewUserApiEnabled">The HTTP header used in API requests to determine which set of User APIs to invoke: the legacy CRA version or the new User API version.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UserCreateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// For Plaid products and flows that use the user object, <c>/user/create</c> provides you a single token to access all data associated with the user. You must call this endpoint before calling <c>/link/token/create</c> if you are using any of the following: Plaid Check, Income Verification, Multi-Item Link, or Plaid Protect (Identity). If you are using Plaid Protect Link session scoring, you do not need to call <c>/user/create</c> first; Plaid will resolve or create the user when <c>user.client_user_id</c> is provided in <c>/link/token/create</c>.
    /// For customers who began using this endpoint on or after December 10, 2025, this endpoint takes a <c>client_user_id</c> and an <c>identity</c> object and will return a <c>user_id</c>. For customers who began using it before that date, the endpoint takes a <c>client_user_id</c> and a <c>consumer_report_user_identity</c> object and will return a <c>user_token</c> and <c>user_id</c>. For more details, see <see href="https://plaid.com/docs/api/users/user-apis">New User APIs</see>.
    /// In order to create a Plaid Check Consumer Report for a user, the <c>identity</c> (new) or <c>consumer_report_user_identity</c> (legacy) object must be present. If it is not provided during the <c>/user/create</c> call, it can be added later by calling <c>/user/update</c>.
    /// <para>
    ///
    /// In order to generate a Plaid Check Consumer Report, the following <c>identity</c> fields, at minimum, are required and must be non-empty: <c>name</c>, <c>date_of_birth</c>, <c>emails</c>, <c>phone_numbers</c>, and <c>addresses</c> (with at least one email, phone number, and address designated as <c>primary</c>). Plaid Check Consumer Reports can only be created for US-based users; the user's address country must be <c>US</c>. If creating a report for sharing with a GSE such as Fannie or Freddie, the user's full SSN must be provided via the <c>id_numbers</c> field. Providing at least a partial SSN is also strongly recommended for all use cases, since it improves the accuracy of matching user records during compliance processes such as file disclosure, dispute, or security freeze requests.
    /// </para>
    /// <para>
    ///
    /// When using Plaid Protect, it is highly recommended that you provide an <c>identity</c> object to better identify and block fraud across your Link sessions.
    /// </para>
    /// <para>
    ///
    /// Plaid will normalize identity fields before storing them and utilize the same identity across different user-based products.
    /// </para>
    /// </remarks>
    public Task<UserCreateResponse> UserCreate(UserCreateRequest body,
        bool? plaidNewUserApiEnabled = false,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/user/create"),
            [],
            [],
            [new HeaderParam("Plaid-New-User-API-Enabled", plaidNewUserApiEnabled),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<UserCreateResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(new AuthSchemeAll(_auth.ClientId, _auth.Secret, _auth.PlaidVersion), _auth.Oauth2)],
            requestOptions,
            ct);

    /// <summary>
    /// Refresh user items for Financial-Insights bundle
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UserFinancialDataRefreshResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/user/financial_data/refresh</c> is an optional endpoint that initiates an on-demand extraction to fetch the newest transactions for a User using the Financial Insights bundle.
    /// This bundle refreshes the Transactions, Investments, and Liabilities product data.
    /// This endpoint is for clients who use the Financial Insights bundle and want to proactively update all linked Items under a user.
    /// The refresh may succeed or fail on a per-Item basis. Use the <c>results</c> array in the response to understand the outcome for each Item.
    /// <para>
    /// This endpoint is distinct from <c>/transactions/refresh</c>, which triggers a refresh for a single Item. Use <c>/user/financial_data/refresh</c> to target all Items for a user instead.
    /// </para>
    /// </remarks>
    public Task<UserFinancialDataRefreshResponse> UserFinancialDataRefresh(UserFinancialDataRefreshRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/user/financial_data/refresh"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<UserFinancialDataRefreshResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve user identity and information
    /// </summary>
    /// <param name="body"></param>
    /// <param name="plaidNewUserApiEnabled">The HTTP header used in API requests to determine which set of User APIs to invoke: the legacy CRA version or the new User API version.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UserGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get user details using a <c>user_id</c>. This endpoint only supports users that were created on the new user API flow, without a <c>user_token</c>. For more details, see <see href="https://plaid.com/docs/api/users/user-apis">New User APIs</see>.
    /// </remarks>
    public Task<UserGetResponse> UserGet(UserGetRequest body,
        bool? plaidNewUserApiEnabled = false,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/user/get"),
            [],
            [],
            [new HeaderParam("Plaid-New-User-API-Enabled", plaidNewUserApiEnabled),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<UserGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Remove user identity data
    /// </summary>
    /// <param name="body"></param>
    /// <param name="plaidNewUserApiEnabled">The HTTP header used in API requests to determine which set of User APIs to invoke: the legacy CRA version or the new User API version.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UserIdentityRemoveResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows customers to explicitly purge identity/PII data provided to Plaid for a given user. This is not exposed to customers by default, as it is meant for special scenarios or requests, but Plaid is obligated to enable customers to delete PII provided to us.
    /// </remarks>
    public Task<UserIdentityRemoveResponse> UserIdentityRemove(UserIdentityRemoveRequest body,
        bool? plaidNewUserApiEnabled = false,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/user/identity/remove"),
            [],
            [],
            [new HeaderParam("Plaid-New-User-API-Enabled", plaidNewUserApiEnabled),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<UserIdentityRemoveResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Associate Items to a User
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UserItemsAssociateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Associates Items to the target user. If an Item is already associated to another user, the Item will be disassociated with the existing user and associated to the target user. This operation supports a max of 100 Items.
    /// </remarks>
    public Task<UserItemsAssociateResponse> UserItemsAssociate(UserItemsAssociateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/user/items/associate"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<UserItemsAssociateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Get Items associated with a User
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UserItemsGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns Items associated with a <c>user_id</c>, along with their corresponding statuses. Plaid associates an Item with a User when it has been successfully connected within a Link session initialized with that <c>user_id</c>.
    /// </remarks>
    public Task<UserItemsGetResponse> UserItemsGet(UserItemsGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/user/items/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<UserItemsGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Remove Items from a User
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UserItemsRemoveResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Removes specific Items associated with a user. It is equivalent to calling <c>/item/remove</c> on each Item individually, but supports use cases (such as Plaid Check) where access tokens are not available. All specified Items must belong to the user or the entire operation fails. Similar to <c>/item/remove</c>, this deletes Item product data and terminates billing on the Item's products. Once removed, Items cannot be reconnected without going through Link again.
    /// This endpoint is not intended to remove all data for a user, as it will only remove Items and no other data for the user. If the user has any user-based recurring subscription products (Financial Management, Plaid Protect, or CRA Cash Flow Updates) and is deleting their account with your product, also call <c>/user/products/terminate</c> to end those subscriptions; per-Item billing is already terminated by this endpoint. For a user initiated data deletion request, see the <see href="https://plaid.com/check/consumer-service-center/">Consumer Service Center</see> to revoke access to data.
    /// </remarks>
    public Task<UserItemsRemoveResponse> UserItemsRemove(UserItemsRemoveRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/user/items/remove"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<UserItemsRemoveResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Terminate user-based products
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UserProductsTerminateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Terminates user-based recurring subscription bundles or products (Financial Management, Plaid Protect, and CRA Cash Flow Updates) associated with a <c>user_id</c>. After you call this endpoint, the user will no longer be billed for these products. For CRA Monitoring, the subscription is canceled but historical data remains available for future report requests.
    /// </remarks>
    public Task<UserProductsTerminateResponse> UserProductsTerminate(UserProductsTerminateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/user/products/terminate"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<UserProductsTerminateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Remove user
    /// </summary>
    /// <param name="body"></param>
    /// <param name="plaidNewUserApiEnabled">The HTTP header used in API requests to determine which set of User APIs to invoke: the legacy CRA version or the new User API version.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UserRemoveResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/user/remove</c> deletes a <c>user_id</c> or <c>user_token</c> and associated information, including any Items associated with the user.
    /// </remarks>
    public Task<UserRemoveResponse> UserRemove(UserRemoveRequest body,
        bool? plaidNewUserApiEnabled = false,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/user/remove"),
            [],
            [],
            [new HeaderParam("Plaid-New-User-API-Enabled", plaidNewUserApiEnabled),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<UserRemoveResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Create a third-party user token
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UserThirdPartyTokenCreateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint is used to create a third-party user token. This token can be shared with and used by a specified third-party client to access data associated with the user through supported endpoints.
    /// <para>
    /// Ensure you store the <c>third_party_user_token</c> along with the <c>user_token</c> and <c>third_party_client_id</c>, as it is not possible to retrieve a previously created <c>third_party_user_token</c>.
    /// </para>
    /// </remarks>
    public Task<UserThirdPartyTokenCreateResponse> UserThirdPartyTokenCreate(UserThirdPartyTokenCreateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/user/third_party_token/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<UserThirdPartyTokenCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Remove a third-party user token
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UserThirdPartyTokenRemoveResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint is used to delete a third-party user token. Once removed, the token can no longer be used to access data associated with the user.
    /// <para>
    /// Any subsequent calls to retrieve information using the same third-party user token will result in an error stating the third-party user token does not exist.
    /// </para>
    /// </remarks>
    public Task<UserThirdPartyTokenRemoveResponse> UserThirdPartyTokenRemove(UserThirdPartyTokenRemoveRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/user/third_party_token/remove"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<UserThirdPartyTokenRemoveResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Refresh user items for Transactions bundle
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UserTransactionsRefreshResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>/user/transactions/refresh</c> is an optional endpoint that initiates an on-demand extraction to fetch the newest transactions for a User using the Transactions bundle.
    /// This bundle refreshes only the Transactions product data.
    /// This endpoint is for clients who use the Transactions Insights bundle and want to proactively update all linked Items under a user.
    /// The refresh may succeed or fail on a per-Item basis. Use the <c>results</c> array in the response to understand the outcome for each Item.
    /// <para>
    /// This endpoint is distinct from <c>/transactions/refresh</c>, which triggers a refresh for a single Item. Use <c>/user/transactions/refresh</c> to target all Items for a user instead.
    /// </para>
    /// </remarks>
    public Task<UserTransactionsRefreshResponse> UserTransactionsRefresh(UserTransactionsRefreshRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/user/transactions/refresh"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<UserTransactionsRefreshResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Update user information
    /// </summary>
    /// <param name="body"></param>
    /// <param name="plaidNewUserApiEnabled">The HTTP header used in API requests to determine which set of User APIs to invoke: the legacy CRA version or the new User API version.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UserUpdateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint updates user information for an existing <c>user_id</c> or <c>user_token</c>. If an existing <c>user_id</c> or <c>user_token</c> is missing fields required for a given use case (e.g. creating a Consumer Report) use <c>/user/update</c> to add values for those fields.
    /// <para>
    /// Identity updates use merge semantics: provided fields overwrite existing ones; omitted fields remain unchanged.
    /// </para>
    /// </remarks>
    public Task<UserUpdateResponse> UserUpdate(UserUpdateRequest body,
        bool? plaidNewUserApiEnabled = false,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/user/update"),
            [],
            [],
            [new HeaderParam("Plaid-New-User-API-Enabled", plaidNewUserApiEnabled),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<UserUpdateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Create an e-wallet
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="WalletCreateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create an e-wallet. The response is the newly created e-wallet object.
    /// </remarks>
    public Task<WalletCreateResponse> WalletCreate(WalletCreateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/wallet/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<WalletCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Fetch an e-wallet
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="WalletGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Fetch an e-wallet. The response includes the current balance.
    /// </remarks>
    public Task<WalletGetResponse> WalletGet(WalletGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/wallet/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<WalletGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Fetch a list of e-wallets
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="WalletListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint lists all e-wallets in descending order of creation.
    /// </remarks>
    public Task<WalletListResponse> WalletList(WalletListRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/wallet/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<WalletListResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Execute a transaction using an e-wallet
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="WalletTransactionExecuteResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Execute a transaction using the specified e-wallet.
    /// Specify the e-wallet to debit from, the counterparty to credit to, the idempotency key to prevent duplicate transactions, the amount and reference for the transaction.
    /// Transactions will settle in seconds to several days, depending on the underlying payment rail.
    /// </remarks>
    public Task<WalletTransactionExecuteResponse> WalletTransactionExecute(WalletTransactionExecuteRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/wallet/transaction/execute"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<WalletTransactionExecuteResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Fetch an e-wallet transaction
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="WalletTransactionGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Fetch a specific e-wallet transaction
    /// </remarks>
    public Task<WalletTransactionGetResponse> WalletTransactionGet(WalletTransactionGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/wallet/transaction/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<WalletTransactionGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// List e-wallet transactions
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="WalletTransactionListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint lists the latest transactions of the specified e-wallet. Transactions are returned in descending order by the <c>created_at</c> time.
    /// </remarks>
    public Task<WalletTransactionListResponse> WalletTransactionList(WalletTransactionListRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/wallet/transaction/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<WalletTransactionListResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Create a watchlist screening for an entity
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="WatchlistScreeningEntityCreateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a new entity watchlist screening to check your customer against watchlists defined in the associated entity watchlist program. If your associated program has ongoing screening enabled, this is the profile information that will be used to monitor your customer over time.
    /// </remarks>
    public Task<WatchlistScreeningEntityCreateResponse> WatchlistScreeningEntityCreate(WatchlistScreeningEntityCreateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/watchlist_screening/entity/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<WatchlistScreeningEntityCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Get an entity screening
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="WatchlistScreeningEntityGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieve an entity watchlist screening.
    /// </remarks>
    public Task<WatchlistScreeningEntityGetResponse> WatchlistScreeningEntityGet(WatchlistScreeningEntityGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/watchlist_screening/entity/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<WatchlistScreeningEntityGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// List history for entity watchlist screenings
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="WatchlistScreeningEntityHistoryListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List all changes to the entity watchlist screening in reverse-chronological order. If the watchlist screening has not been edited, no history will be returned.
    /// </remarks>
    public Task<WatchlistScreeningEntityHistoryListResponse> WatchlistScreeningEntityHistoryList(WatchlistScreeningEntityHistoryListRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/watchlist_screening/entity/history/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<WatchlistScreeningEntityHistoryListResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// List hits for entity watchlist screenings
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="WatchlistScreeningEntityHitListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List all hits for the entity watchlist screening.
    /// </remarks>
    public Task<WatchlistScreeningEntityHitListResponse> WatchlistScreeningEntityHitList(WatchlistScreeningEntityHitListRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/watchlist_screening/entity/hit/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<WatchlistScreeningEntityHitListResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// List entity watchlist screenings
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="WatchlistScreeningEntityListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List all entity screenings.
    /// </remarks>
    public Task<WatchlistScreeningEntityListResponse> WatchlistScreeningEntityList(WatchlistScreeningEntityListRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/watchlist_screening/entity/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<WatchlistScreeningEntityListResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Get entity watchlist screening program
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="WatchlistScreeningEntityProgramGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get an entity watchlist screening program
    /// </remarks>
    public Task<WatchlistScreeningEntityProgramGetResponse> WatchlistScreeningEntityProgramGet(WatchlistScreeningEntityProgramGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/watchlist_screening/entity/program/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<WatchlistScreeningEntityProgramGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// List entity watchlist screening programs
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="WatchlistScreeningEntityProgramListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List all entity watchlist screening programs
    /// </remarks>
    public Task<WatchlistScreeningEntityProgramListResponse> WatchlistScreeningEntityProgramList(WatchlistScreeningEntityProgramListRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/watchlist_screening/entity/program/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<WatchlistScreeningEntityProgramListResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Create a review for an entity watchlist screening
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="WatchlistScreeningEntityReviewCreateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a review for an entity watchlist screening. Reviews are compliance reports created by users in your organization regarding the relevance of potential hits found by Plaid.
    /// </remarks>
    public Task<WatchlistScreeningEntityReviewCreateResponse> WatchlistScreeningEntityReviewCreate(WatchlistScreeningEntityReviewCreateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/watchlist_screening/entity/review/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<WatchlistScreeningEntityReviewCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// List reviews for entity watchlist screenings
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="WatchlistScreeningEntityReviewListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List all reviews for a particular entity watchlist screening. Reviews are compliance reports created by users in your organization regarding the relevance of potential hits found by Plaid.
    /// </remarks>
    public Task<WatchlistScreeningEntityReviewListResponse> WatchlistScreeningEntityReviewList(WatchlistScreeningEntityReviewListRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/watchlist_screening/entity/review/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<WatchlistScreeningEntityReviewListResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Update an entity screening
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="WatchlistScreeningEntityUpdateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update an entity watchlist screening.
    /// </remarks>
    public Task<WatchlistScreeningEntityUpdateResponse> WatchlistScreeningEntityUpdate(WatchlistScreeningEntityUpdateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/watchlist_screening/entity/update"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<WatchlistScreeningEntityUpdateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Create a watchlist screening for a person
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="WatchlistScreeningIndividualCreateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a new Watchlist Screening to check your customer against watchlists defined in the associated Watchlist Program. If your associated program has ongoing screening enabled, this is the profile information that will be used to monitor your customer over time.
    /// </remarks>
    public Task<WatchlistScreeningIndividualCreateResponse> WatchlistScreeningIndividualCreate(WatchlistScreeningIndividualCreateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/watchlist_screening/individual/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<WatchlistScreeningIndividualCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve an individual watchlist screening
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="WatchlistScreeningIndividualGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieve a previously created individual watchlist screening
    /// </remarks>
    public Task<WatchlistScreeningIndividualGetResponse> WatchlistScreeningIndividualGet(WatchlistScreeningIndividualGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/watchlist_screening/individual/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<WatchlistScreeningIndividualGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// List history for individual watchlist screenings
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="WatchlistScreeningIndividualHistoryListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List all changes to the individual watchlist screening in reverse-chronological order. If the watchlist screening has not been edited, no history will be returned.
    /// </remarks>
    public Task<WatchlistScreeningIndividualHistoryListResponse> WatchlistScreeningIndividualHistoryList(WatchlistScreeningIndividualHistoryListRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/watchlist_screening/individual/history/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<WatchlistScreeningIndividualHistoryListResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// List hits for individual watchlist screening
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="WatchlistScreeningIndividualHitListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List all hits found by Plaid for a particular individual watchlist screening.
    /// </remarks>
    public Task<WatchlistScreeningIndividualHitListResponse> WatchlistScreeningIndividualHitList(WatchlistScreeningIndividualHitListRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/watchlist_screening/individual/hit/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<WatchlistScreeningIndividualHitListResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// List Individual Watchlist Screenings
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="WatchlistScreeningIndividualListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List previously created watchlist screenings for individuals
    /// </remarks>
    public Task<WatchlistScreeningIndividualListResponse> WatchlistScreeningIndividualList(WatchlistScreeningIndividualListRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/watchlist_screening/individual/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<WatchlistScreeningIndividualListResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Get individual watchlist screening program
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="WatchlistScreeningIndividualProgramGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get an individual watchlist screening program
    /// </remarks>
    public Task<WatchlistScreeningIndividualProgramGetResponse> WatchlistScreeningIndividualProgramGet(WatchlistScreeningIndividualProgramGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/watchlist_screening/individual/program/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<WatchlistScreeningIndividualProgramGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// List individual watchlist screening programs
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="WatchlistScreeningIndividualProgramListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List all individual watchlist screening programs
    /// </remarks>
    public Task<WatchlistScreeningIndividualProgramListResponse> WatchlistScreeningIndividualProgramList(WatchlistScreeningIndividualProgramListRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/watchlist_screening/individual/program/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<WatchlistScreeningIndividualProgramListResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Create a review for an individual watchlist screening
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="WatchlistScreeningIndividualReviewCreateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a review for the individual watchlist screening. Reviews are compliance reports created by users in your organization regarding the relevance of potential hits found by Plaid.
    /// </remarks>
    public Task<WatchlistScreeningIndividualReviewCreateResponse> WatchlistScreeningIndividualReviewCreate(WatchlistScreeningIndividualReviewCreateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/watchlist_screening/individual/review/create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<WatchlistScreeningIndividualReviewCreateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// List reviews for individual watchlist screenings
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="WatchlistScreeningIndividualReviewListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List all reviews for the individual watchlist screening.
    /// </remarks>
    public Task<WatchlistScreeningIndividualReviewListResponse> WatchlistScreeningIndividualReviewList(WatchlistScreeningIndividualReviewListRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/watchlist_screening/individual/review/list"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<WatchlistScreeningIndividualReviewListResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Update individual watchlist screening
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="WatchlistScreeningIndividualUpdateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update a specific individual watchlist screening. This endpoint can be used to add additional customer information, correct outdated information, add a reference id, assign the individual to a reviewer, and update which program it is associated with. Please note that you may not update <c>search_terms</c> and <c>status</c> at the same time since editing <c>search_terms</c> may trigger an automatic <c>status</c> change.
    /// </remarks>
    public Task<WatchlistScreeningIndividualUpdateResponse> WatchlistScreeningIndividualUpdate(WatchlistScreeningIndividualUpdateRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/watchlist_screening/individual/update"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<WatchlistScreeningIndividualUpdateResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);

    /// <summary>
    /// Get webhook verification key
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="WebhookVerificationKeyGetResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Plaid signs all outgoing webhooks and provides JSON Web Tokens (JWTs) so that you can verify the authenticity of any incoming webhooks to your application. A message signature is included in the <c>Plaid-Verification</c> header.
    /// <para>
    /// The <c>/webhook_verification_key/get</c> endpoint provides a JSON Web Key (JWK) that can be used to verify a JWT.
    /// </para>
    /// </remarks>
    public Task<WebhookVerificationKeyGetResponse> WebhookVerificationKeyGet(WebhookVerificationKeyGetRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/webhook_verification_key/get"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<WebhookVerificationKeyGetResponse>(),
            RawErrorResponse.Instance,
            [_auth.ClientId, _auth.Secret, _auth.PlaidVersion],
            requestOptions,
            ct);
}

# Reference

Every operation below is shown in its throwing form. On an error status it throws `ApiException<TError>` — the status code, headers, content type and the operation's error type, `RawError` (the raw body) when the spec declares none — and where an operation offers an `…AsResult` sibling, that sibling returns `ApiResult<TResponse, TError>` instead. A request that produces no usable response surfaces as `SdkConnectionException` or `SdkTimeoutException`, a body that does not match the documented response type as `ResponseDeserializationException`, and a credential that cannot be applied as `AuthSchemeException`; all of them derive from `SdkException` and name the failed call. See [README → Error Handling](README.md#error-handling).

> Source: [ThePlaidApiClient](src/ThePlaidApi/ThePlaidApiClient.cs)

<details>
<summary><code>Task&lt;AccountsGetResponse&gt; AccountsBalanceGet(AccountsBalanceGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/accounts/balance/get` endpoint returns the real-time balance for each of an Item's accounts. While other endpoints, such as `/accounts/get`, return a balance object,  `/accounts/balance/get` forces the available and current balance fields to be refreshed rather than cached. This endpoint can be used for existing Items that were added via any of Plaid's other products. This endpoint can be used as long as Link has been initialized with any other product; `balance` itself is not a product that can be used to initialize Link. As this endpoint triggers a synchronous request for fresh data, latency may be higher than for other Plaid endpoints (typically less than 10 seconds, but occasionally up to 30 seconds or more); if you encounter errors, you may find it necessary to adjust your timeout period when making requests.

Note: If you are getting real-time balance for the purpose of assessing the return risk of a proposed ACH transaction, it is recommended to use `/signal/evaluate` instead of `/accounts/balance/get`. `/signal/evaluate` returns the same real-time balance information and also provides access to Signal Rules, which provides no-code transaction business logic configuration, backtesting and recommendations for tuning your transaction acceptance logic, and the ability to easily switch between Balance and Signal Transaction Scores as needed for ultra-low-latency, ML-powered risk assessments. For more details, see the [Balance documentation](https://plaid.com/docs/balance/#balance-integration-options).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountsBalanceGet(new AccountsBalanceGetOperationRequest
    {
        Body = new AccountsBalanceGetRequest
        {
            AccessToken = "string",
            Secret = "string",
            ClientId = "string",
            Options = new AccountsBalanceGetRequestOptions { AccountIds = ["string"] },
        },
    });
    // TODO: Handle 'response' of type AccountsGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AccountsBalanceGetOperationRequest](src/ThePlaidApi/Requests/AccountsBalanceGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AccountsGetResponse](src/ThePlaidApi/Models/AccountsGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AccountsGetResponse&gt; AccountsGet(AccountsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/accounts/get` endpoint can be used to retrieve a list of accounts associated with any linked Item. Plaid will only return active bank accounts -- that is, accounts that are not closed and are capable of carrying a balance.
To return new accounts that were created after the user linked their Item, you can listen for the [`NEW_ACCOUNTS_AVAILABLE`](https://plaid.com/docs/api/items/#new_accounts_available) webhook and then use Link's [update mode](https://plaid.com/docs/link/update-mode/) to request that the user share this new account with you.

`/accounts/get` is free to use and retrieves cached information, rather than extracting fresh information from the institution. The balance returned will reflect the balance at the time of the last successful Item update. If the Item is enabled for a regularly updating product, such as Transactions, Investments, or Liabilities, the balance will typically update about once a day, as long as the Item is healthy. If the Item is enabled only for products that do not frequently update, such as Auth or Identity, balance data may be much older.

For real-time balance information, use the paid endpoints `/accounts/balance/get` or `/signal/evaluate` instead.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountsGet(new AccountsGetOperationRequest
    {
        Body = new AccountsGetRequest
        {
            ClientId = "string",
            Secret = "string",
            AccessToken = "string",
            Options = new AccountsGetRequestOptions { AccountIds = ["string"] },
        },
    });
    // TODO: Handle 'response' of type AccountsGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AccountsGetOperationRequest](src/ThePlaidApi/Requests/AccountsGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AccountsGetResponse](src/ThePlaidApi/Models/AccountsGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ApplicationGetResponse&gt; ApplicationGet(ApplicationGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Allows financial institutions to retrieve information about Plaid clients for the purpose of building control-tower experiences

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ApplicationGet(new ApplicationGetOperationRequest
    {
        Body = new ApplicationGetRequest
        {
            ClientId = "some example string",
            Secret = "some example string",
            ApplicationId = "some example string",
        },
    });
    // TODO: Handle 'response' of type ApplicationGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ApplicationGetOperationRequest](src/ThePlaidApi/Requests/ApplicationGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ApplicationGetResponse](src/ThePlaidApi/Models/ApplicationGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AssetReportAuditCopyCreateResponse&gt; AssetReportAuditCopyCreate(AssetReportAuditCopyCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Plaid can provide an Audit Copy of any Asset Report directly to a participating third party on your behalf. For example, Plaid can supply an Audit Copy directly to the GSEs on your behalf if you participate in Fannie Mae's Day 1 Certainty™ program or utilize Freddie Mac's Loan Product Advisor® (LPA®) Asset and Income Modeler (AIM). An Audit Copy contains the same underlying data as the Asset Report.

To grant access to an Audit Copy, use the `/asset_report/audit_copy/create` endpoint to create an `audit_copy_token` and then pass that token to the third party who needs access. Each third party has its own `auditor_id`, for example `fannie_mae`. You'll need to create a separate Audit Copy for each third party to whom you want to grant access to the Report.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AssetReportAuditCopyCreate(new AssetReportAuditCopyCreateOperationRequest
    {
        Body = new AssetReportAuditCopyCreateRequest { AssetReportToken = "some example string" },
    });
    // TODO: Handle 'response' of type AssetReportAuditCopyCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AssetReportAuditCopyCreateOperationRequest](src/ThePlaidApi/Requests/AssetReportAuditCopyCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AssetReportAuditCopyCreateResponse](src/ThePlaidApi/Models/AssetReportAuditCopyCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AssetReportGetResponse&gt; AssetReportAuditCopyGet(AssetReportAuditCopyGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/asset_report/audit_copy/get` allows auditors to get a copy of an Asset Report that was previously shared via the `/asset_report/audit_copy/create` endpoint.  The caller of `/asset_report/audit_copy/create` must provide the `audit_copy_token` to the auditor.  This token can then be used to call `/asset_report/audit_copy/get`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AssetReportAuditCopyGet(new AssetReportAuditCopyGetOperationRequest
    {
        Body = new AssetReportAuditCopyGetRequest { AuditCopyToken = "some example string" },
    });
    // TODO: Handle 'response' of type AssetReportGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AssetReportAuditCopyGetOperationRequest](src/ThePlaidApi/Requests/AssetReportAuditCopyGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AssetReportGetResponse](src/ThePlaidApi/Models/AssetReportGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task AssetReportAuditCopyPdfGet(AssetReportAuditCopyPdfGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/asset_report/audit_copy/pdf/get` endpoint retrieves an Asset Report Audit Copy in PDF format. The caller must provide the `audit_copy_token` that was shared via the `/asset_report/audit_copy/create` endpoint.

The response to `/asset_report/audit_copy/pdf/get` is the PDF binary data. The `request_id` is returned in the `Plaid-Request-ID` header.

[View a sample PDF Asset Report](https://plaid.com/documents/sample-asset-report.pdf).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.AssetReportAuditCopyPdfGet(new AssetReportAuditCopyPdfGetOperationRequest
    {
        Body = new AssetReportAuditCopyPdfGetRequest { AuditCopyToken = "some example string" },
    });
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AssetReportAuditCopyPdfGetOperationRequest](src/ThePlaidApi/Requests/AssetReportAuditCopyPdfGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AssetReportAuditCopyRemoveResponse&gt; AssetReportAuditCopyRemove(AssetReportAuditCopyRemoveOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/asset_report/audit_copy/remove` endpoint allows you to remove an Audit Copy. Removing an Audit Copy invalidates the `audit_copy_token` associated with it, meaning both you and any third parties holding the token will no longer be able to use it to access Report data. Items associated with the Asset Report, the Asset Report itself and other Audit Copies of it are not affected and will remain accessible after removing the given Audit Copy.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AssetReportAuditCopyRemove(new AssetReportAuditCopyRemoveOperationRequest
    {
        Body = new AssetReportAuditCopyRemoveRequest { AuditCopyToken = "some example string" },
    });
    // TODO: Handle 'response' of type AssetReportAuditCopyRemoveResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AssetReportAuditCopyRemoveOperationRequest](src/ThePlaidApi/Requests/AssetReportAuditCopyRemoveOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AssetReportAuditCopyRemoveResponse](src/ThePlaidApi/Models/AssetReportAuditCopyRemoveResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AssetReportCreateResponse&gt; AssetReportCreate(AssetReportCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/asset_report/create` endpoint initiates the process of creating an Asset Report, which can then be retrieved by passing the `asset_report_token` return value to the `/asset_report/get` or `/asset_report/pdf/get` endpoints.

The Asset Report takes some time to be created and is not available immediately after calling `/asset_report/create`. The exact amount of time to create the report will vary depending on how many days of history are requested and will typically range from a few seconds to about one minute. When the Asset Report is ready to be retrieved using `/asset_report/get` or `/asset_report/pdf/get`, Plaid will fire a `PRODUCT_READY` webhook. For full details of the webhook schema, see [Asset Report webhooks](https://plaid.com/docs/api/products/assets/#webhooks).

The `/asset_report/create` endpoint creates an Asset Report at a moment in time. Asset Reports are immutable. To get an updated Asset Report, use the `/asset_report/refresh` endpoint.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AssetReportCreate(new AssetReportCreateOperationRequest
    {
        Body = new AssetReportCreateRequest { DaysRequested = 1 },
    });
    // TODO: Handle 'response' of type AssetReportCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AssetReportCreateOperationRequest](src/ThePlaidApi/Requests/AssetReportCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AssetReportCreateResponse](src/ThePlaidApi/Models/AssetReportCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AssetReportFilterResponse&gt; AssetReportFilter(AssetReportFilterOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

By default, an Asset Report will contain all of the accounts on a given Item. In some cases, you may not want the Asset Report to contain all accounts. For example, you might have the end user choose which accounts are relevant in Link using the Account Select view, which you can enable in the dashboard. Or, you might always exclude certain account types or subtypes, which you can identify by using the `/accounts/get` endpoint. To narrow an Asset Report to only a subset of accounts, use the `/asset_report/filter` endpoint.

To exclude certain Accounts from an Asset Report, first use the `/asset_report/create` endpoint to create the report, then send the `asset_report_token` along with a list of `account_ids` to exclude to the `/asset_report/filter` endpoint, to create a new Asset Report which contains only a subset of the original Asset Report's data.

Because Asset Reports are immutable, calling `/asset_report/filter` does not alter the original Asset Report in any way; rather, `/asset_report/filter` creates a new Asset Report with a new token and id. Asset Reports created via `/asset_report/filter` do not contain new Asset data, and are not billed.

Plaid will fire a [`PRODUCT_READY`](https://plaid.com/docs/api/products/assets/#product_ready) webhook once generation of the filtered Asset Report has completed.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AssetReportFilter(new AssetReportFilterOperationRequest
    {
        Body = new AssetReportFilterRequest
        {
            AssetReportToken = "some example string",
            AccountIdsToExclude = ["some example string"],
        },
    });
    // TODO: Handle 'response' of type AssetReportFilterResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AssetReportFilterOperationRequest](src/ThePlaidApi/Requests/AssetReportFilterOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AssetReportFilterResponse](src/ThePlaidApi/Models/AssetReportFilterResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AssetReportGetResponse&gt; AssetReportGet(AssetReportGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/asset_report/get` endpoint retrieves the Asset Report in JSON format. Before calling `/asset_report/get`, you must first create the Asset Report using `/asset_report/create` (or filter an Asset Report using `/asset_report/filter`) and then wait for the [`PRODUCT_READY`](https://plaid.com/docs/api/products/assets/#product_ready) webhook to fire, indicating that the Report is ready to be retrieved.

By default, an Asset Report includes transaction descriptions as returned by the bank, as opposed to parsed and categorized by Plaid. You can also receive cleaned and categorized transactions, as well as additional insights like merchant name or location information. We call this an Asset Report with Insights. An Asset Report with Insights provides transaction category, location, and merchant information in addition to the transaction strings provided in a standard Asset Report. To retrieve an Asset Report with Insights, call the `/asset_report/get` endpoint with `include_insights` set to `true`.

For latency-sensitive applications, you can optionally call `/asset_report/create` with `options.add_ons` set to `["fast_assets"]`. This will cause Plaid to create two versions of the Asset Report: one with only current and available balance and identity information, and then later on the complete Asset Report. You will receive separate webhooks for each version of the Asset Report.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AssetReportGet(new AssetReportGetOperationRequest
    {
        Body = new AssetReportGetRequest(),
    });
    // TODO: Handle 'response' of type AssetReportGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AssetReportGetOperationRequest](src/ThePlaidApi/Requests/AssetReportGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AssetReportGetResponse](src/ThePlaidApi/Models/AssetReportGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task AssetReportPdfGet(AssetReportPdfGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/asset_report/pdf/get` endpoint retrieves the Asset Report in PDF format. Before calling `/asset_report/pdf/get`, you must first create the Asset Report using `/asset_report/create` (or filter an Asset Report using `/asset_report/filter`) and then wait for the [`PRODUCT_READY`](https://plaid.com/docs/api/products/assets/#product_ready) webhook to fire, indicating that the Report is ready to be retrieved.

The response to `/asset_report/pdf/get` is the PDF binary data. The `request_id`  is returned in the `Plaid-Request-ID` header.

[View a sample PDF Asset Report](https://plaid.com/documents/sample-asset-report.pdf).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.AssetReportPdfGet(new AssetReportPdfGetOperationRequest
    {
        Body = new AssetReportPdfGetRequest { AssetReportToken = "some example string" },
    });
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AssetReportPdfGetOperationRequest](src/ThePlaidApi/Requests/AssetReportPdfGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AssetReportRefreshResponse&gt; AssetReportRefresh(AssetReportRefreshOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

An Asset Report is an immutable snapshot of a user's assets. In order to "refresh" an Asset Report you created previously, you can use the `/asset_report/refresh` endpoint to create a new Asset Report based on the old one, but with the most recent data available.

The new Asset Report will contain the same Items as the original Report, as well as the same filters applied by any call to `/asset_report/filter`. By default, the new Asset Report will also use the same parameters you submitted with your original `/asset_report/create` request, but the original `days_requested` value and the values of any parameters in the `options` object can be overridden with new values. To change these arguments, simply supply new values for them in your request to `/asset_report/refresh`. Submit an empty string ("") for any previously-populated fields you would like set as empty.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AssetReportRefresh(new AssetReportRefreshOperationRequest
    {
        Body = new AssetReportRefreshRequest { AssetReportToken = "some example string" },
    });
    // TODO: Handle 'response' of type AssetReportRefreshResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AssetReportRefreshOperationRequest](src/ThePlaidApi/Requests/AssetReportRefreshOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AssetReportRefreshResponse](src/ThePlaidApi/Models/AssetReportRefreshResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AssetReportRemoveResponse&gt; AssetReportRemove(AssetReportRemoveOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/item/remove` endpoint allows you to invalidate an `access_token`, meaning you will not be able to create new Asset Reports with it. Removing an Item does not affect any Asset Reports or Audit Copies you have already created, which will remain accessible until you remove them specifically.

The `/asset_report/remove` endpoint allows you to remove access to an Asset Report. Removing an Asset Report invalidates its `asset_report_token`, meaning you will no longer be able to use it to access Report data or create new Audit Copies. Removing an Asset Report does not affect the underlying Items, but does invalidate any `audit_copy_tokens` associated with the Asset Report.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AssetReportRemove(new AssetReportRemoveOperationRequest
    {
        Body = new AssetReportRemoveRequest { AssetReportToken = "some example string" },
    });
    // TODO: Handle 'response' of type AssetReportRemoveResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AssetReportRemoveOperationRequest](src/ThePlaidApi/Requests/AssetReportRemoveOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AssetReportRemoveResponse](src/ThePlaidApi/Models/AssetReportRemoveResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AuthGetResponse&gt; AuthGet(AuthGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/auth/get` endpoint returns the bank account and bank identification numbers (such as routing numbers, for US accounts) associated with an Item's checking, savings, and cash management accounts, along with high-level account data and balances when available.

Versioning note: In API version 2017-03-08, the schema of the `numbers` object returned by this endpoint is substantially different. For details, see [Plaid API versioning](https://plaid.com/docs/api/versioning/#version-2018-05-22).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AuthGet(new AuthGetOperationRequest
    {
        Body = new AuthGetRequest { AccessToken = "some example string" },
    });
    // TODO: Handle 'response' of type AuthGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AuthGetOperationRequest](src/ThePlaidApi/Requests/AuthGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AuthGetResponse](src/ThePlaidApi/Models/AuthGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AuthVerifyResponse&gt; AuthVerify(AuthVerifyOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/auth/verify` endpoint verifies bank account and routing numbers and (optionally) account owner names against Plaid's database via [Database Auth](https://plaid.com/docs/auth/coverage/database-auth/). It can be used to verify account numbers that were not collected via the Plaid Link flow.

This endpoint is currently in Early Availability; contact sales or your Plaid account manager to request access.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AuthVerify(new AuthVerifyOperationRequest
    {
        Body = new AuthVerifyRequest
        {
            Numbers = new AuthVerifyRequestNumbers
            {
                Ach = new AuthVerifyNumbersAch { Account = "some example string", Routing = "some example string" },
            },
        },
    });
    // TODO: Handle 'response' of type AuthVerifyResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AuthVerifyOperationRequest](src/ThePlaidApi/Requests/AuthVerifyOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AuthVerifyResponse](src/ThePlaidApi/Models/AuthVerifyResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BankTransferBalanceGetResponse&gt; BankTransferBalanceGet(BankTransferBalanceGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/bank_transfer/balance/get` endpoint to see the available balance in your bank transfer account. Debit transfers increase this balance once their status is posted. Credit transfers decrease this balance when they are created.

The transactable balance shows the amount in your account that you are able to use for transfers, and is essentially your available balance minus your minimum balance.

Note that this endpoint can only be used with FBO accounts, when using Bank Transfers in the Full Service configuration. It cannot be used on your own account when using Bank Transfers in the BTS Platform configuration.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BankTransferBalanceGet(new BankTransferBalanceGetOperationRequest
    {
        Body = new BankTransferBalanceGetRequest(),
    });
    // TODO: Handle 'response' of type BankTransferBalanceGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BankTransferBalanceGetOperationRequest](src/ThePlaidApi/Requests/BankTransferBalanceGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BankTransferBalanceGetResponse](src/ThePlaidApi/Models/BankTransferBalanceGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BankTransferCancelResponse&gt; BankTransferCancel(BankTransferCancelOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/bank_transfer/cancel` endpoint to cancel a bank transfer.  A transfer is eligible for cancelation if the `cancellable` property returned by `/bank_transfer/get` is `true`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BankTransferCancel(new BankTransferCancelOperationRequest
    {
        Body = new BankTransferCancelRequest { BankTransferId = "some example string" },
    });
    // TODO: Handle 'response' of type BankTransferCancelResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BankTransferCancelOperationRequest](src/ThePlaidApi/Requests/BankTransferCancelOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BankTransferCancelResponse](src/ThePlaidApi/Models/BankTransferCancelResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BankTransferCreateResponse&gt; BankTransferCreate(BankTransferCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/bank_transfer/create` endpoint to initiate a new bank transfer.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BankTransferCreate(new BankTransferCreateOperationRequest
    {
        Body = new BankTransferCreateRequest
        {
            IdempotencyKey = "some example string",
            AccessToken = "some example string",
            AccountId = "some example string",
            Type = BankTransferType.Debit,
            Network = BankTransferNetwork.Ach,
            Amount = "some example string",
            IsoCurrencyCode = "some example string",
            Description = "some example string",
            User = new BankTransferUser { LegalName = "some example string" },
        },
    });
    // TODO: Handle 'response' of type BankTransferCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BankTransferCreateOperationRequest](src/ThePlaidApi/Requests/BankTransferCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BankTransferCreateResponse](src/ThePlaidApi/Models/BankTransferCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BankTransferEventListResponse&gt; BankTransferEventList(BankTransferEventListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/bank_transfer/event/list` endpoint to get a list of Plaid-initiated ACH or bank transfer events based on specified filter criteria. When using Auth with micro-deposit verification enabled, this endpoint can be used to fetch status updates on ACH micro-deposits. For more details, see [micro-deposit events](https://plaid.com/docs/auth/coverage/microdeposit-events/).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BankTransferEventList(new BankTransferEventListOperationRequest
    {
        Body = new BankTransferEventListRequest(),
    });
    // TODO: Handle 'response' of type BankTransferEventListResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BankTransferEventListOperationRequest](src/ThePlaidApi/Requests/BankTransferEventListOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BankTransferEventListResponse](src/ThePlaidApi/Models/BankTransferEventListResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BankTransferEventSyncResponse&gt; BankTransferEventSync(BankTransferEventSyncOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/bank_transfer/event/sync` allows you to request up to the next 25 Plaid-initiated bank transfer events that happened after a specific `event_id`. When using Auth with micro-deposit verification enabled, this endpoint can be used to fetch status updates on ACH micro-deposits. For more details, see [micro-deposit events](https://plaid.com/docs/auth/coverage/microdeposit-events/).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BankTransferEventSync(new BankTransferEventSyncOperationRequest
    {
        Body = new BankTransferEventSyncRequest { AfterId = 1 },
    });
    // TODO: Handle 'response' of type BankTransferEventSyncResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BankTransferEventSyncOperationRequest](src/ThePlaidApi/Requests/BankTransferEventSyncOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BankTransferEventSyncResponse](src/ThePlaidApi/Models/BankTransferEventSyncResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BankTransferGetResponse&gt; BankTransferGet(BankTransferGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/bank_transfer/get` fetches information about the bank transfer corresponding to the given `bank_transfer_id`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BankTransferGet(new BankTransferGetOperationRequest
    {
        Body = new BankTransferGetRequest { BankTransferId = "some example string" },
    });
    // TODO: Handle 'response' of type BankTransferGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BankTransferGetOperationRequest](src/ThePlaidApi/Requests/BankTransferGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BankTransferGetResponse](src/ThePlaidApi/Models/BankTransferGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BankTransferListResponse&gt; BankTransferList(BankTransferListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/bank_transfer/list` endpoint to see a list of all your bank transfers and their statuses. Results are paginated; use the `count` and `offset` query parameters to retrieve the desired bank transfers.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BankTransferList(new BankTransferListOperationRequest
    {
        Body = new BankTransferListRequest(),
    });
    // TODO: Handle 'response' of type BankTransferListResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BankTransferListOperationRequest](src/ThePlaidApi/Requests/BankTransferListOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BankTransferListResponse](src/ThePlaidApi/Models/BankTransferListResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BankTransferMigrateAccountResponse&gt; BankTransferMigrateAccount(BankTransferMigrateAccountOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

As an alternative to adding Items via Link, you can also use the `/bank_transfer/migrate_account` endpoint to migrate known account and routing numbers to Plaid Items.  Note that Items created in this way are not compatible with endpoints for other products, such as `/accounts/balance/get`, and can only be used with Bank Transfer endpoints.  If you require access to other endpoints, create the Item through Link instead.  Access to `/bank_transfer/migrate_account` is not enabled by default; to obtain access, contact your Plaid account manager.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BankTransferMigrateAccount(new BankTransferMigrateAccountOperationRequest
    {
        Body = new BankTransferMigrateAccountRequest
        {
            AccountNumber = "some example string",
            RoutingNumber = "some example string",
            AccountType = "some example string",
        },
    });
    // TODO: Handle 'response' of type BankTransferMigrateAccountResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BankTransferMigrateAccountOperationRequest](src/ThePlaidApi/Requests/BankTransferMigrateAccountOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BankTransferMigrateAccountResponse](src/ThePlaidApi/Models/BankTransferMigrateAccountResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BankTransferSweepGetResponse&gt; BankTransferSweepGet(BankTransferSweepGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/bank_transfer/sweep/get` endpoint fetches information about the sweep corresponding to the given `sweep_id`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BankTransferSweepGet(new BankTransferSweepGetOperationRequest
    {
        Body = new BankTransferSweepGetRequest { SweepId = "some example string" },
    });
    // TODO: Handle 'response' of type BankTransferSweepGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BankTransferSweepGetOperationRequest](src/ThePlaidApi/Requests/BankTransferSweepGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BankTransferSweepGetResponse](src/ThePlaidApi/Models/BankTransferSweepGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BankTransferSweepListResponse&gt; BankTransferSweepList(BankTransferSweepListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/bank_transfer/sweep/list` endpoint fetches information about the sweeps matching the given filters.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BankTransferSweepList(new BankTransferSweepListOperationRequest
    {
        Body = new BankTransferSweepListRequest(),
    });
    // TODO: Handle 'response' of type BankTransferSweepListResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BankTransferSweepListOperationRequest](src/ThePlaidApi/Requests/BankTransferSweepListOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BankTransferSweepListResponse](src/ThePlaidApi/Models/BankTransferSweepListResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BeaconAccountRiskEvaluateResponse&gt; BeaconAccountRiskEvaluate(BeaconAccountRiskEvaluateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use `/beacon/account_risk/v1/evaluate` to get risk insights for a linked account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BeaconAccountRiskEvaluate(new BeaconAccountRiskEvaluateOperationRequest
    {
        Body = new BeaconAccountRiskEvaluateRequest(),
    });
    // TODO: Handle 'response' of type BeaconAccountRiskEvaluateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BeaconAccountRiskEvaluateOperationRequest](src/ThePlaidApi/Requests/BeaconAccountRiskEvaluateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BeaconAccountRiskEvaluateResponse](src/ThePlaidApi/Models/BeaconAccountRiskEvaluateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BeaconDuplicateGetResponse&gt; BeaconDuplicateGet(BeaconDuplicateGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a Beacon Duplicate for a given Beacon Duplicate id.

A Beacon Duplicate represents a pair of similar Beacon Users within your organization.

Two Beacon User revisions are returned for each Duplicate record in either the `beacon_user1` or `beacon_user2` response fields.

The `analysis` field in the response indicates which fields matched between `beacon_user1` and `beacon_user2`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BeaconDuplicateGet(new BeaconDuplicateGetOperationRequest
    {
        Body = new BeaconDuplicateGetRequest { BeaconDuplicateId = "some example string" },
    });
    // TODO: Handle 'response' of type BeaconDuplicateGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BeaconDuplicateGetOperationRequest](src/ThePlaidApi/Requests/BeaconDuplicateGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BeaconDuplicateGetResponse](src/ThePlaidApi/Models/BeaconDuplicateGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BeaconReportCreateResponse&gt; BeaconReportCreate(BeaconReportCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a fraud report for a given Beacon User.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BeaconReportCreate(new BeaconReportCreateOperationRequest
    {
        Body = new BeaconReportCreateRequest
        {
            BeaconUserId = "some example string",
            Type = BeaconReportCreateType.FirstParty,
            FraudDate = DateTimeOffset.Parse("2024-01-15T00:00:00Z"),
        },
    });
    // TODO: Handle 'response' of type BeaconReportCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BeaconReportCreateOperationRequest](src/ThePlaidApi/Requests/BeaconReportCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BeaconReportCreateResponse](src/ThePlaidApi/Models/BeaconReportCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BeaconReportGetResponse&gt; BeaconReportGet(BeaconReportGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a Beacon Report for a given Beacon Report ID.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BeaconReportGet(new BeaconReportGetOperationRequest
    {
        Body = new BeaconReportGetRequest { BeaconReportId = "some example string" },
    });
    // TODO: Handle 'response' of type BeaconReportGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BeaconReportGetOperationRequest](src/ThePlaidApi/Requests/BeaconReportGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BeaconReportGetResponse](src/ThePlaidApi/Models/BeaconReportGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BeaconReportListResponse&gt; BeaconReportList(BeaconReportListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/beacon/report/list` endpoint to view all Beacon Reports you created for a specific Beacon User. The reports returned by this endpoint are exclusively reports you created for a specific user. A Beacon User can only have one active report at a time, but a new report can be created if a previous report has been deleted. The results from this endpoint are paginated; the `next_cursor` field will be populated if there is another page of results that can be retrieved. To fetch the next page, pass the `next_cursor` value as the `cursor` parameter in the next request.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BeaconReportList(new BeaconReportListOperationRequest
    {
        Body = new BeaconReportListRequest { BeaconUserId = "some example string" },
    });
    // TODO: Handle 'response' of type BeaconReportListResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BeaconReportListOperationRequest](src/ThePlaidApi/Requests/BeaconReportListOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BeaconReportListResponse](src/ThePlaidApi/Models/BeaconReportListResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BeaconReportSyndicationGetResponse&gt; BeaconReportSyndicationGet(BeaconReportSyndicationGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a Beacon Report Syndication for a given Beacon Report Syndication id.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BeaconReportSyndicationGet(new BeaconReportSyndicationGetOperationRequest
    {
        Body = new BeaconReportSyndicationGetRequest { BeaconReportSyndicationId = "some example string" },
    });
    // TODO: Handle 'response' of type BeaconReportSyndicationGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BeaconReportSyndicationGetOperationRequest](src/ThePlaidApi/Requests/BeaconReportSyndicationGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BeaconReportSyndicationGetResponse](src/ThePlaidApi/Models/BeaconReportSyndicationGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BeaconReportSyndicationListResponse&gt; BeaconReportSyndicationList(BeaconReportSyndicationListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/beacon/report_syndication/list` endpoint to view all Beacon Reports that have been syndicated to a specific Beacon User. This endpoint returns Beacon Report Syndications which are references to Beacon Reports created either by you, or another Beacon customer, that matched the specified Beacon User. A Beacon User can have multiple active Beacon Report Syndications at once. The results from this endpoint are paginated; the `next_cursor` field will be populated if there is another page of results that can be retrieved. To fetch the next page, pass the `next_cursor` value as the `cursor` parameter in the next request.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BeaconReportSyndicationList(new BeaconReportSyndicationListOperationRequest
    {
        Body = new BeaconReportSyndicationListRequest { BeaconUserId = "some example string" },
    });
    // TODO: Handle 'response' of type BeaconReportSyndicationListResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BeaconReportSyndicationListOperationRequest](src/ThePlaidApi/Requests/BeaconReportSyndicationListOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BeaconReportSyndicationListResponse](src/ThePlaidApi/Models/BeaconReportSyndicationListResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BeaconUserAccountInsightsGetResponse&gt; BeaconUserAccountInsightsGet(BeaconUserAccountInsightsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get Account Insights for all Accounts linked to this Beacon User. The insights for each account are computed based on the information that was last retrieved from the financial institution.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BeaconUserAccountInsightsGet(new BeaconUserAccountInsightsGetOperationRequest
    {
        Body = new BeaconUserAccountInsightsGetRequest
        {
            BeaconUserId = "some example string",
            AccessToken = "some example string",
        },
    });
    // TODO: Handle 'response' of type BeaconUserAccountInsightsGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BeaconUserAccountInsightsGetOperationRequest](src/ThePlaidApi/Requests/BeaconUserAccountInsightsGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BeaconUserAccountInsightsGetResponse](src/ThePlaidApi/Models/BeaconUserAccountInsightsGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BeaconUserCreateResponse&gt; BeaconUserCreate(BeaconUserCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create and scan a Beacon User against your Beacon Program, according to your program's settings.

When you submit a new user to `/beacon/user/create`, several checks are performed immediately:

  - The user's PII (provided within the `user` object) is searched against all other users within the Beacon Program you specified. If a match is found that violates your program's "Duplicate Information Filtering" settings, the user will be returned with a status of `pending_review`.

  - The user's PII is also searched against all fraud reports created by your organization across all of your Beacon Programs. If the user's data matches a fraud report that your team created, the user will be returned with a status of `rejected`.

  - Finally, the user's PII is searched against all fraud reports shared with the Beacon Network by other companies. If a matching fraud report is found, the user will be returned with a `pending_review` status if your program has enabled automatic flagging based on network fraud.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BeaconUserCreate(new BeaconUserCreateOperationRequest
    {
        Body = new BeaconUserCreateRequest
        {
            ProgramId = "some example string",
            ClientUserId = "some example string",
            User = new BeaconUserRequestData
            {
                Name = new BeaconUserName { GivenName = "some example string", FamilyName = "some example string" },
            },
        },
    });
    // TODO: Handle 'response' of type BeaconUserCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BeaconUserCreateOperationRequest](src/ThePlaidApi/Requests/BeaconUserCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BeaconUserCreateResponse](src/ThePlaidApi/Models/BeaconUserCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BeaconUserGetResponse&gt; BeaconUserGet(BeaconUserGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Fetch a Beacon User.

The Beacon User is returned with all of their associated information and a `status` based on the Beacon Network duplicate record and fraud checks.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BeaconUserGet(new BeaconUserGetOperationRequest
    {
        Body = new BeaconUserGetRequest { BeaconUserId = "some example string" },
    });
    // TODO: Handle 'response' of type BeaconUserGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BeaconUserGetOperationRequest](src/ThePlaidApi/Requests/BeaconUserGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BeaconUserGetResponse](src/ThePlaidApi/Models/BeaconUserGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BeaconUserHistoryListResponse&gt; BeaconUserHistoryList(BeaconUserHistoryListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all changes to the Beacon User in reverse-chronological order.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BeaconUserHistoryList(new BeaconUserHistoryListOperationRequest
    {
        Body = new BeaconUserHistoryListRequest { BeaconUserId = "some example string" },
    });
    // TODO: Handle 'response' of type BeaconUserHistoryListResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BeaconUserHistoryListOperationRequest](src/ThePlaidApi/Requests/BeaconUserHistoryListOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BeaconUserHistoryListResponse](src/ThePlaidApi/Models/BeaconUserHistoryListResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BeaconUserGetResponse&gt; BeaconUserReview(BeaconUserReviewOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update the status of a Beacon User.

When updating a Beacon User's status via this endpoint, Plaid validates that the status change is consistent with the related state for this Beacon User. Specifically, we will check:

1. Whether there are any associated Beacon Reports connected to the Beacon User, and
2. Whether there are any confirmed Beacon Report Syndications connected to the Beacon User.

When updating a Beacon User's status to `rejected`, we enforce that either a Beacon Report has been created for the Beacon User or a Beacon Report Syndication has been confirmed.
When updating a Beacon User's status to `cleared`, we enforce that there are no active Beacon Reports or confirmed Beacon Report Syndications associated with the user. If you previously created a Beacon Report for this user, you must delete it before updating the Beacon User's status to `cleared`.
There are no restrictions on updating a Beacon User's status to `pending_review`.

If these conditions are not met, the request will be rejected with an error explaining the issue.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BeaconUserReview(new BeaconUserReviewOperationRequest
    {
        Body = new BeaconUserReviewRequest { BeaconUserId = "some example string", Status = BeaconUserStatus.Rejected },
    });
    // TODO: Handle 'response' of type BeaconUserGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BeaconUserReviewOperationRequest](src/ThePlaidApi/Requests/BeaconUserReviewOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BeaconUserGetResponse](src/ThePlaidApi/Models/BeaconUserGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BeaconUserUpdateResponse&gt; BeaconUserUpdate(BeaconUserUpdateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update the identity data for a Beacon User in your Beacon Program or add new accounts to the Beacon User.

Similar to `/beacon/user/create`, several checks are performed immediately when you submit an identity data change to `/beacon/user/update`:

  - The user's updated PII is searched against all other users within the Beacon Program you specified. If a match is found that violates your program's "Duplicate Information Filtering" settings, the user will be returned with a status of `pending_review`.

  - The user's updated PII is also searched against all fraud reports created by your organization across all of your Beacon Programs. If the user's data matches a fraud report that your team created, the user will be returned with a status of `rejected`.

  - Finally, the user's PII is searched against all fraud reports shared with the Beacon Network by other companies. If a matching fraud report is found, the user will be returned with a `pending_review` status if your program has enabled automatic flagging based on network fraud.

Plaid maintains a version history for each Beacon User, so the Beacon User's identity data before and after the update is retained as separate versions.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BeaconUserUpdate(new BeaconUserUpdateOperationRequest
    {
        Body = new BeaconUserUpdateRequest { BeaconUserId = "some example string" },
    });
    // TODO: Handle 'response' of type BeaconUserUpdateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BeaconUserUpdateOperationRequest](src/ThePlaidApi/Requests/BeaconUserUpdateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BeaconUserUpdateResponse](src/ThePlaidApi/Models/BeaconUserUpdateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BetaEwaReportV1GetResponse&gt; BetaEwaReportV1Get(BetaEwaReportV1GetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/beta/ewa_report/v1/get` endpoint provides an Earned Wage Access (EWA) score that quantifies the delinquency risk associated with a given item. The score is derived from a combination of cashflow patterns and network-based behavioral features.

The response returns a list of EWA scores, where each score corresponds to a potential advance amount range. These scores estimate the likelihood of repayment for advances within that range.

Score range: 1-99

Interpretation: Higher scores indicate a greater likelihood of repayment.

This endpoint enables clients to assess repayment risk and make data-driven decisions when determining eligibility or limits for earned wage advances.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BetaEwaReportV1Get(new BetaEwaReportV1GetOperationRequest
    {
        Body = new BetaEwaReportV1GetRequest { AccessToken = "access-sandbox-71e02f71-0960-4a27-abd2-5631e04f2175" },
    });
    // TODO: Handle 'response' of type BetaEwaReportV1GetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BetaEwaReportV1GetOperationRequest](src/ThePlaidApi/Requests/BetaEwaReportV1GetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BetaEwaReportV1GetResponse](src/ThePlaidApi/Models/BetaEwaReportV1GetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BetaPartnerCustomerV1CreateResponse&gt; BetaPartnerCustomerV1Create(BetaPartnerCustomerV1CreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/beta/partner/customer/v1/create` endpoint creates a new end customer record. You can provide as much information as you have available. If any required information is missing for the products you intend to use, it will be listed in the `requirements_due` field of the response.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BetaPartnerCustomerV1Create(new BetaPartnerCustomerV1CreateOperationRequest
    {
        Body = new BetaPartnerCustomerV1CreateRequest
        {
            ClientId = "7f57eb3d2a9j6480121fx361",
            Secret = "79g03eoofwl8240v776r2h667442119",
            CompanyName = "Plaid",
            Products = [Products.Auth, Products.Identity],
            CreateLinkCustomization = true,
            LegalEntityName = "Plaid",
            Website = "plaid.com",
            ApplicationName = "Plaid",
            TechnicalContact = new PartnerEndCustomerTechnicalContact
            {
                GivenName = "Alice",
                FamilyName = "Smith",
                Email = "alice.smith@example.com",
            },
            BillingContact = new PartnerEndCustomerBillingContact
            {
                GivenName = "Bob",
                FamilyName = "Jones",
                Email = "bob.jones@example.com",
            },
            CustomerSupportInfo = new PartnerEndCustomerCustomerSupportInfo
            {
                Email = "support@example.com",
                PhoneNumber = "1234567890",
                ContactUrl = "example.com/contact",
                LinkUpdateUrl = "example.com/update",
            },
            Address = new PartnerEndCustomerAddress
            {
                City = "New York",
                Street = "123 Main St",
                Region = "NY",
                PostalCode = "12345",
                CountryCode = "US",
            },
            RedirectUris = ["http://localhost/oauth.html", "https://www.example.com/oauth.html"],
        },
    });
    // TODO: Handle 'response' of type BetaPartnerCustomerV1CreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BetaPartnerCustomerV1CreateOperationRequest](src/ThePlaidApi/Requests/BetaPartnerCustomerV1CreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BetaPartnerCustomerV1CreateResponse](src/ThePlaidApi/Models/BetaPartnerCustomerV1CreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BetaPartnerCustomerV1EnableResponse&gt; BetaPartnerCustomerV1Enable(BetaPartnerCustomerV1EnableOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/beta/partner/customer/v1/enable` endpoint is used by reseller partners to enable an end customer in the full Production environment.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BetaPartnerCustomerV1Enable(new BetaPartnerCustomerV1EnableOperationRequest
    {
        Body = new BetaPartnerCustomerV1EnableRequest
        {
            ClientId = "7f57eb3d2a9j6480121fx361",
            Secret = "79g03eoofwl8240v776r2h667442119",
            EndCustomerClientId = "634758733ebb4f00134b85ea",
            Products = [Products.Auth],
        },
    });
    // TODO: Handle 'response' of type BetaPartnerCustomerV1EnableResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BetaPartnerCustomerV1EnableOperationRequest](src/ThePlaidApi/Requests/BetaPartnerCustomerV1EnableOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BetaPartnerCustomerV1EnableResponse](src/ThePlaidApi/Models/BetaPartnerCustomerV1EnableResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BetaPartnerCustomerV1GetResponse&gt; BetaPartnerCustomerV1Get(BetaPartnerCustomerV1GetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/beta/partner/customer/v1/get` endpoint is used by reseller partners to retrieve data about a single end customer.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BetaPartnerCustomerV1Get(new BetaPartnerCustomerV1GetOperationRequest
    {
        Body = new BetaPartnerCustomerV1GetRequest
        {
            ClientId = "7f57eb3d2a9j6480121fx361",
            Secret = "79g03eoofwl8240v776r2h667442119",
            EndCustomerClientId = "634758733ebb4f00134b85ea",
        },
    });
    // TODO: Handle 'response' of type BetaPartnerCustomerV1GetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BetaPartnerCustomerV1GetOperationRequest](src/ThePlaidApi/Requests/BetaPartnerCustomerV1GetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BetaPartnerCustomerV1GetResponse](src/ThePlaidApi/Models/BetaPartnerCustomerV1GetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BetaPartnerCustomerV1UpdateResponse&gt; BetaPartnerCustomerV1Update(BetaPartnerCustomerV1UpdateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/beta/partner/customer/v1/update` endpoint updates an existing end customer record.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BetaPartnerCustomerV1Update(new BetaPartnerCustomerV1UpdateOperationRequest
    {
        Body = new BetaPartnerCustomerV1UpdateRequest
        {
            ClientId = "7f57eb3d2a9j6480121fx361",
            Secret = "79g03eoofwl8240v776r2h667442119",
            EndCustomerClientId = "634758733ebb4f00134b85ea",
            BankAddendumAcceptance = new PartnerEndCustomerBankAddendumAcceptance
            {
                CustomerAccepted = true,
                CustomerIpAddress = "127.0.0.1",
                CustomerAgreementTimestamp = DateTimeOffset.Parse("2025-01-01T01:00:00Z"),
            },
            Questionnaires = new PartnerEndCustomerQuestionnaires
            {
                Cra = new PartnerEndCustomerCraQuestionnaire
                {
                    Purposes = new PartnerEndCustomerCraPurposes(),
                    IsThirdPartyInvolved = true,
                    IsTechnicalServiceProviderInvolved = true,
                },
            },
        },
    });
    // TODO: Handle 'response' of type BetaPartnerCustomerV1UpdateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BetaPartnerCustomerV1UpdateOperationRequest](src/ThePlaidApi/Requests/BetaPartnerCustomerV1UpdateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BetaPartnerCustomerV1UpdateResponse](src/ThePlaidApi/Models/BetaPartnerCustomerV1UpdateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BusinessVerificationCreateResponse&gt; BusinessVerificationCreate(BusinessVerificationCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a new business verification to check a business's identity and risk profile.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BusinessVerificationCreate(new BusinessVerificationCreateOperationRequest
    {
        Body = new BusinessVerificationCreateRequest { ClientUserId = "some example string" },
    });
    // TODO: Handle 'response' of type BusinessVerificationCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BusinessVerificationCreateOperationRequest](src/ThePlaidApi/Requests/BusinessVerificationCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BusinessVerificationCreateResponse](src/ThePlaidApi/Models/BusinessVerificationCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BusinessVerificationGetResponse&gt; BusinessVerificationGet(BusinessVerificationGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve the current state of a specific business verification.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BusinessVerificationGet(new BusinessVerificationGetOperationRequest
    {
        Body = new BusinessVerificationGetRequest { BusinessVerificationId = "some example string" },
    });
    // TODO: Handle 'response' of type BusinessVerificationGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[BusinessVerificationGetOperationRequest](src/ThePlaidApi/Requests/BusinessVerificationGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BusinessVerificationGetResponse](src/ThePlaidApi/Models/BusinessVerificationGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CashflowReportGetResponse&gt; CashflowReportGet(CashflowReportGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/cashflow_report/get` endpoint retrieves transactions data associated with an Item. Transactions data is standardized across financial institutions.
Transactions are returned in reverse-chronological order, and the sequence of transaction ordering is stable and will not shift. Transactions are not immutable and can also be removed altogether by the institution; a removed transaction will no longer appear in `/cashflow_report/get`.  For more details, see [Pending and posted transactions](https://plaid.com/docs/transactions/transactions-data/#pending-and-posted-transactions).
Due to the potentially large number of transactions associated with an Item, results are paginated. Manipulate the `count` and `cursor` parameters in conjunction with the `has_more` response body field to fetch all available transactions.
Note that data isn't likely to be immediately available to `/cashflow_report/get`. Plaid will begin to prepare transactions data upon Item link, if Link was initialized with `cashflow_report`, or if it wasn't, upon the first call to `/cashflow_report/refresh`. To be alerted when transaction data is ready to be fetched, listen for the `CASHFLOW_REPORT_READY` webhook.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CashflowReportGet(new CashflowReportGetOperationRequest
    {
        Body = new CashflowReportGetRequest { AccessToken = "some example string", DaysRequested = 1 },
    });
    // TODO: Handle 'response' of type CashflowReportGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CashflowReportGetOperationRequest](src/ThePlaidApi/Requests/CashflowReportGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CashflowReportGetResponse](src/ThePlaidApi/Models/CashflowReportGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CashflowReportInsightsGetResponse&gt; CashflowReportInsightsGet(CashflowReportInsightsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/cashflow_report/insights/get` endpoint retrieves insights data associated with an Item. Insights are only calculated on credit and depository accounts.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CashflowReportInsightsGet(new CashflowReportInsightsGetOperationRequest
    {
        Body = new CashflowReportInsightsGetRequest { AccessToken = "some example string" },
    });
    // TODO: Handle 'response' of type CashflowReportInsightsGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CashflowReportInsightsGetOperationRequest](src/ThePlaidApi/Requests/CashflowReportInsightsGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CashflowReportInsightsGetResponse](src/ThePlaidApi/Models/CashflowReportInsightsGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CashflowReportRefreshResponse&gt; CashflowReportRefresh(CashflowReportRefreshOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/cashflow_report/refresh` is an endpoint that initiates an on-demand extraction to fetch the newest transactions for an Item (given an `item_id`). The Item must already have Cashflow Report added as a product in order to call `/cashflow_report/refresh`.

After calling `/cashflow_report/refresh`, Plaid will fire a webhook `CASHFLOW_REPORT_READY` alerting clients that new transactions data can then be ingested via `/cashflow_report/get` or the webhook will contain an error code informing there was an error in refreshing transactions data.

Note that the `/cashflow_report/refresh` endpoint is not supported for Capital One (`ins_128026`) non-depository accounts and will result in a `PRODUCTS_NOT_SUPPORTED` error if called on an Item that contains only non-depository accounts from that institution.

As this endpoint triggers a synchronous request for fresh data, latency may be higher than for other Plaid endpoints (typically less than 10 seconds, but up to 30 seconds or more). If you encounter errors, you may find it necessary to adjust your timeout period for requests.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CashflowReportRefresh(new CashflowReportRefreshOperationRequest
    {
        Body = new CashflowReportRefreshRequest { AccessToken = "some example string", DaysRequested = 1 },
    });
    // TODO: Handle 'response' of type CashflowReportRefreshResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CashflowReportRefreshOperationRequest](src/ThePlaidApi/Requests/CashflowReportRefreshOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CashflowReportRefreshResponse](src/ThePlaidApi/Models/CashflowReportRefreshResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CashflowReportTransactionsGetResponse&gt; CashflowReportTransactionsGet(CashflowReportTransactionsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/cashflow_report/transactions/get` endpoint retrieves transactions data associated with an Item. Transactions data is standardized across financial institutions.
Transactions are returned in reverse-chronological order, and the sequence of transaction ordering is stable and will not shift. Transactions are not immutable and can also be removed altogether by the institution; a removed transaction will no longer appear in `/cashflow_report/transactions/get`.  For more details, see [Pending and posted transactions](https://plaid.com/docs/transactions/transactions-data/#pending-and-posted-transactions).
Due to the potentially large number of transactions associated with an Item, results are paginated. Manipulate the `count` and `cursor` parameters in conjunction with the `has_more` response body field to fetch all available transactions.
Note that data isn't likely to be immediately available to `/cashflow_report/transactions/get`. Plaid will begin to prepare transactions data upon Item link, if Link was initialized with `cashflow_report`, or if it wasn't, upon the first call to `/cashflow_report/refresh`. To be alerted when transaction data is ready to be fetched, listen for the `CASHFLOW_REPORT_READY` webhook.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CashflowReportTransactionsGet(new CashflowReportTransactionsGetOperationRequest
    {
        Body = new CashflowReportTransactionsGetRequest { AccessToken = "some example string" },
    });
    // TODO: Handle 'response' of type CashflowReportTransactionsGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CashflowReportTransactionsGetOperationRequest](src/ThePlaidApi/Requests/CashflowReportTransactionsGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CashflowReportTransactionsGetResponse](src/ThePlaidApi/Models/CashflowReportTransactionsGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CategoriesGetResponse&gt; CategoriesGet(CategoriesGetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Send a request to the `/categories/get` endpoint to get detailed information on legacy categories returned by Plaid. This endpoint does not require authentication.

All implementations are recommended to [use the newer `personal_finance_category` taxonomy](https://plaid.com/docs/transactions/pfc-migration/) instead of the legacy `category` taxonomy supported by this endpoint.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CategoriesGet(new CategoriesGetRequest { Body = body });
    // TODO: Handle 'response' of type CategoriesGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CategoriesGetRequest](src/ThePlaidApi/Requests/CategoriesGetRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CategoriesGetResponse](src/ThePlaidApi/Models/CategoriesGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ConsentEventsGetResponse&gt; ConsentEventsGet(ConsentEventsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List a historical log of Item consent events. Consent logs are only available for events occurring on or after November 7, 2024. Extremely recent events (occurring within the past 12 hours) may not be available via this endpoint. Up to three years of consent logs will be available via the endpoint.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ConsentEventsGet(new ConsentEventsGetOperationRequest
    {
        Body = new ConsentEventsGetRequest { AccessToken = "some example string" },
    });
    // TODO: Handle 'response' of type ConsentEventsGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ConsentEventsGetOperationRequest](src/ThePlaidApi/Requests/ConsentEventsGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ConsentEventsGetResponse](src/ThePlaidApi/Models/ConsentEventsGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task ConsumerReportPdfGet(ConsumerReportPdfGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves all existing CRB Bank Income and Base reports for the consumer in PDF format.

Response is PDF binary data. The `request_id` is returned in the `Plaid-Request-ID` header.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.ConsumerReportPdfGet(new ConsumerReportPdfGetOperationRequest
    {
        Body = new ConsumerReportPdfGetRequest { UserToken = "some example string" },
    });
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ConsumerReportPdfGetOperationRequest](src/ThePlaidApi/Requests/ConsumerReportPdfGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CraCheckReportBaseReportGetResponse&gt; CraCheckReportBaseReportGet(CraCheckReportBaseReportGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows you to retrieve the Base Report for your user, allowing you to receive comprehensive bank account and cash flow data. You should call this endpoint after you've received a `CHECK_REPORT_READY` or a `USER_CHECK_REPORT_READY` webhook, either after the Link session for the user or after calling `/cra/check_report/create`. If the most recent consumer report for the user doesn't have sufficient data to generate the base report, or the consumer report has expired, you will receive an error indicating that you should create a new consumer report by calling `/cra/check_report/create`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CraCheckReportBaseReportGet(new CraCheckReportBaseReportGetOperationRequest
    {
        Body = new CraCheckReportBaseReportGetRequest(),
    });
    // TODO: Handle 'response' of type CraCheckReportBaseReportGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CraCheckReportBaseReportGetOperationRequest](src/ThePlaidApi/Requests/CraCheckReportBaseReportGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CraCheckReportBaseReportGetResponse](src/ThePlaidApi/Models/CraCheckReportBaseReportGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CraCheckReportCashflowInsightsGetResponse&gt; CraCheckReportCashflowInsightsGet(CraCheckReportCashflowInsightsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows you to retrieve the Cashflow Insights report for your user. You should call this endpoint after you've received a `CHECK_REPORT_READY` or a `USER_CHECK_REPORT_READY` webhook, either after the Link session for the user or after calling `/cra/check_report/create`. If the most recent consumer report for the user doesn't have sufficient data to generate the report, or the consumer report has expired, you will receive an error indicating that you should create a new consumer report by calling `/cra/check_report/create`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CraCheckReportCashflowInsightsGet(new CraCheckReportCashflowInsightsGetOperationRequest
    {
        Body = new CraCheckReportCashflowInsightsGetRequest(),
    });
    // TODO: Handle 'response' of type CraCheckReportCashflowInsightsGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CraCheckReportCashflowInsightsGetOperationRequest](src/ThePlaidApi/Requests/CraCheckReportCashflowInsightsGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CraCheckReportCashflowInsightsGetResponse](src/ThePlaidApi/Models/CraCheckReportCashflowInsightsGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CraCheckReportCreateResponse&gt; CraCheckReportCreate(CraCheckReportCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use `/cra/check_report/create` to refresh data in an existing report. A Consumer Report will last for 24 hours before expiring; you should call any `/get` endpoints on the report before it expires. If a report expires, you can call `/cra/check_report/create` again to re-generate it and refresh the data in the report.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CraCheckReportCreate(new CraCheckReportCreateOperationRequest
    {
        Body = new CraCheckReportCreateRequest
        {
            Webhook = "some example string",
            DaysRequested = 1,
            ConsumerReportPermissiblePurpose = ConsumerReportPermissiblePurpose.AccountReviewCredit,
        },
    });
    // TODO: Handle 'response' of type CraCheckReportCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CraCheckReportCreateOperationRequest](src/ThePlaidApi/Requests/CraCheckReportCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CraCheckReportCreateResponse](src/ThePlaidApi/Models/CraCheckReportCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CraCheckReportIncomeInsightsGetResponse&gt; CraCheckReportIncomeInsightsGet(CraCheckReportIncomeInsightsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows you to retrieve the Income Insights report for your user. You should call this endpoint after you've received a `CHECK_REPORT_READY` or a `USER_CHECK_REPORT_READY` webhook, either after the Link session for the user or after calling `/cra/check_report/create`. If the most recent consumer report for the user doesn't have sufficient data to generate the report, or the consumer report has expired, you will receive an error indicating that you should create a new consumer report by calling `/cra/check_report/create`.

NOTE: The following schema was updated in April 2026 to reflect the response when the provided version is "II2". Please see [this document](https://docs.google.com/document/d/1kQkQ7FOgFaC4n-sUGUk74hoXZNY_L_nJeCuMe7Keip4/edit?tab=t.0#heading=h.rudamzinus2i) for guidance on migrating to II2 if you are currently using the II1 version, and [this section](https://docs.google.com/document/d/1kQkQ7FOgFaC4n-sUGUk74hoXZNY_L_nJeCuMe7Keip4/edit?tab=t.0#bookmark=id.tdcc2wpk0h60) for an example II1 response along with its [documentation](https://docs.google.com/document/d/1kQkQ7FOgFaC4n-sUGUk74hoXZNY_L_nJeCuMe7Keip4/edit?tab=t.36c85n2ircqk#heading=h.79dwr5c1iszl).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CraCheckReportIncomeInsightsGet(new CraCheckReportIncomeInsightsGetOperationRequest
    {
        Body = new CraCheckReportIncomeInsightsGetRequest(),
    });
    // TODO: Handle 'response' of type CraCheckReportIncomeInsightsGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CraCheckReportIncomeInsightsGetOperationRequest](src/ThePlaidApi/Requests/CraCheckReportIncomeInsightsGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CraCheckReportIncomeInsightsGetResponse](src/ThePlaidApi/Models/CraCheckReportIncomeInsightsGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CraCheckReportLendScoreGetResponse&gt; CraCheckReportLendScoreGet(CraCheckReportLendScoreGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows you to retrieve the LendScore report for your user. You should call this endpoint after you've received a `CHECK_REPORT_READY` or a `USER_CHECK_REPORT_READY` webhook, either after the Link session for the user or after calling `/cra/check_report/create`. If the most recent consumer report for the user doesn't have sufficient data to generate the report, or the consumer report has expired, you will receive an error indicating that you should create a new consumer report by calling `/cra/check_report/create`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CraCheckReportLendScoreGet(new CraCheckReportLendScoreGetOperationRequest
    {
        Body = new CraCheckReportLendScoreGetRequest(),
    });
    // TODO: Handle 'response' of type CraCheckReportLendScoreGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CraCheckReportLendScoreGetOperationRequest](src/ThePlaidApi/Requests/CraCheckReportLendScoreGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CraCheckReportLendScoreGetResponse](src/ThePlaidApi/Models/CraCheckReportLendScoreGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CraCheckReportNetworkInsightsGetResponse&gt; CraCheckReportNetworkInsightsGet(CraCheckReportNetworkInsightsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows you to retrieve the Network Insights report for your user. You should call this endpoint after you've received a `CHECK_REPORT_READY` or a `USER_CHECK_REPORT_READY` webhook, either after the Link session for the user or after calling `/cra/check_report/create`. If the most recent consumer report for the user doesn't have sufficient data to generate the report, or the consumer report has expired, you will receive an error indicating that you should create a new consumer report by calling `/cra/check_report/create`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CraCheckReportNetworkInsightsGet(new CraCheckReportNetworkInsightsGetOperationRequest
    {
        Body = new CraCheckReportNetworkInsightsGetRequest(),
    });
    // TODO: Handle 'response' of type CraCheckReportNetworkInsightsGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CraCheckReportNetworkInsightsGetOperationRequest](src/ThePlaidApi/Requests/CraCheckReportNetworkInsightsGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CraCheckReportNetworkInsightsGetResponse](src/ThePlaidApi/Models/CraCheckReportNetworkInsightsGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CraCheckReportPartnerInsightsGetResponse&gt; CraCheckReportPartnerInsightsGet(CraCheckReportPartnerInsightsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows you to retrieve the Partner Insights report for your user. You should call this endpoint after you've received a `CHECK_REPORT_READY` or a `USER_CHECK_REPORT_READY` webhook, either after the Link session for the user or after calling `/cra/check_report/create`. If the most recent consumer report for the user doesn't have sufficient data to generate the report, or the consumer report has expired, you will receive an error indicating that you should create a new consumer report by calling `/cra/check_report/create`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CraCheckReportPartnerInsightsGet(new CraCheckReportPartnerInsightsGetOperationRequest
    {
        Body = new CraCheckReportPartnerInsightsGetRequest(),
    });
    // TODO: Handle 'response' of type CraCheckReportPartnerInsightsGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CraCheckReportPartnerInsightsGetOperationRequest](src/ThePlaidApi/Requests/CraCheckReportPartnerInsightsGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CraCheckReportPartnerInsightsGetResponse](src/ThePlaidApi/Models/CraCheckReportPartnerInsightsGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task CraCheckReportPdfGet(CraCheckReportPdfGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/cra/check_report/pdf/get` retrieves the most recent Consumer Report in PDF format. By default, the most recent Base Report (if it exists) for the user will be returned. To request that the most recent Partner Insights or Income Insights report be included in the PDF as well, use the `add-ons` field.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.CraCheckReportPdfGet(new CraCheckReportPdfGetOperationRequest
    {
        Body = new CraCheckReportPdfGetRequest(),
    });
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CraCheckReportPdfGetOperationRequest](src/ThePlaidApi/Requests/CraCheckReportPdfGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CraCheckReportVerificationGetResponse&gt; CraCheckReportVerificationGet(CraCheckReportVerificationGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows you to retrieve home lending reports for a user. To obtain a VoA or Employment Refresh report, you need to make sure that `cra_base_report` is included in the `products` parameter when calling `/link/token/create` or `/cra/check_report/create`.

You should call this endpoint after you've received a `CHECK_REPORT_READY` or a `USER_CHECK_REPORT_READY` webhook, either after the Link session for the user or after calling `/cra/check_report/create`.

If the most recent consumer report for the user doesn't have sufficient data to generate the report, or the consumer report has expired, you will receive an error indicating that you should create a new consumer report by calling `/cra/check_report/create`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CraCheckReportVerificationGet(new CraCheckReportVerificationGetOperationRequest
    {
        Body = new CraCheckReportVerificationGetRequest
        {
            ReportsRequested = [CraCheckReportVerificationGetReportType.Voa],
        },
    });
    // TODO: Handle 'response' of type CraCheckReportVerificationGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CraCheckReportVerificationGetOperationRequest](src/ThePlaidApi/Requests/CraCheckReportVerificationGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CraCheckReportVerificationGetResponse](src/ThePlaidApi/Models/CraCheckReportVerificationGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task CraCheckReportVerificationPdfGet(CraCheckReportVerificationPdfGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/cra/check_report/verification/pdf/get` endpoint retrieves the most recent Consumer Report in PDF format, specifically formatted for Home Lending verification use cases. Before calling this endpoint, ensure that you've created a VOA report through Link or the `/cra/check_report/create` endpoint, and have received a `CHECK_REPORT_READY` or a `USER_CHECK_REPORT_READY` webhook.

The response to `/cra/check_report/verification/pdf/get` is the PDF binary data. The `request_id`  is returned in the `Plaid-Request-ID` header.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.CraCheckReportVerificationPdfGet(new CraCheckReportVerificationPdfGetOperationRequest
    {
        Body = new CraCheckReportVerificationPdfGetRequest(),
    });
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CraCheckReportVerificationPdfGetOperationRequest](src/ThePlaidApi/Requests/CraCheckReportVerificationPdfGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CraCreditProfileReportGetResponse&gt; CraCreditProfileReportGet(CraCreditProfileReportGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/cra/credit_profile/report/get` retrieves a credit profile report for a user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CraCreditProfileReportGet(new CraCreditProfileReportGetOperationRequest
    {
        Body = new CraCreditProfileReportGetRequest
        {
            UserId = "some example string",
            ConsumerReportPermissiblePurpose = ConsumerReportPermissiblePurpose.AccountReviewCredit,
            ClientReportId = "some example string",
            ReportType = CraCreditProfileReportType.Qualify,
            InquiryType = CraCreditProfileInquiryType.SoftInquiry,
            Version = CraCreditProfileReportVersion.V1,
        },
    });
    // TODO: Handle 'response' of type CraCreditProfileReportGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CraCreditProfileReportGetOperationRequest](src/ThePlaidApi/Requests/CraCreditProfileReportGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CraCreditProfileReportGetResponse](src/ThePlaidApi/Models/CraCreditProfileReportGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CraLoansApplicationsRegisterResponse&gt; CraLoansApplicationsRegister(CraLoansApplicationsRegisterOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/cra/loans/applications/register` registers loan applications and decisions.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CraLoansApplicationsRegister(new CraLoansApplicationsRegisterOperationRequest
    {
        Body = new CraLoansApplicationsRegisterRequest
        {
            Applications = [
                new CraLoanApplication
                {
                    UserToken = "some example string",
                    ApplicationId = "some example string",
                    Type = CraLoanType.Personal,
                    Decision = CraLoanApplicationDecision.Approved,
                },
            ],
        },
    });
    // TODO: Handle 'response' of type CraLoansApplicationsRegisterResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CraLoansApplicationsRegisterOperationRequest](src/ThePlaidApi/Requests/CraLoansApplicationsRegisterOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CraLoansApplicationsRegisterResponse](src/ThePlaidApi/Models/CraLoansApplicationsRegisterResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CraLoansRegisterResponse&gt; CraLoansRegister(CraLoansRegisterOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/cra/loans/register` registers a list of loans to their applicants.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CraLoansRegister(new CraLoansRegisterOperationRequest
    {
        Body = new CraLoansRegisterRequest
        {
            Loans = [
                new CraLoanRegister
                {
                    UserToken = "some example string",
                    LoanId = "some example string",
                    Type = CraLoanType.Personal,
                    PaymentSchedule = CraLoanPaymentSchedule.Daily,
                    OpenedDate = DateTimeOffset.Parse("2024-01-15T00:00:00Z"),
                    OpenedWithStatus = new CraLoanOpenedStatus
                    {
                        Status = CraLoanStatus.Approved,
                        Date = DateTimeOffset.Parse("2024-01-15T00:00:00Z"),
                    },
                },
            ],
        },
    });
    // TODO: Handle 'response' of type CraLoansRegisterResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CraLoansRegisterOperationRequest](src/ThePlaidApi/Requests/CraLoansRegisterOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CraLoansRegisterResponse](src/ThePlaidApi/Models/CraLoansRegisterResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CraLoanUnregisterResponse&gt; CraLoansUnregister(CraLoansUnregisterOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/cra/loans/unregister` indicates the loans have reached a final status and no further updates are expected.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CraLoansUnregister(new CraLoansUnregisterOperationRequest
    {
        Body = new CraLoansUnregisterRequest
        {
            Loans = [
                new CraLoanUnregister
                {
                    LoanId = "some example string",
                    ClosedWithStatus = new CraLoanClosedStatus
                    {
                        Status = CraLoanStatus.Approved,
                        Date = DateTimeOffset.Parse("2024-01-15T00:00:00Z"),
                    },
                },
            ],
        },
    });
    // TODO: Handle 'response' of type CraLoanUnregisterResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CraLoansUnregisterOperationRequest](src/ThePlaidApi/Requests/CraLoansUnregisterOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CraLoanUnregisterResponse](src/ThePlaidApi/Models/CraLoanUnregisterResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CraLoansUpdateResponse&gt; CraLoansUpdate(CraLoansUpdateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/cra/loans/update` updates loan information such as the status and payment history.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CraLoansUpdate(new CraLoansUpdateOperationRequest
    {
        Body = new CraLoansUpdateRequest { Loans = [new CraLoanUpdate()] },
    });
    // TODO: Handle 'response' of type CraLoansUpdateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CraLoansUpdateOperationRequest](src/ThePlaidApi/Requests/CraLoansUpdateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CraLoansUpdateResponse](src/ThePlaidApi/Models/CraLoansUpdateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CraMonitoringInsightsGetResponse&gt; CraMonitoringInsightsGet(CraMonitoringInsightsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows you to retrieve a Cash Flow Updates report by passing in the `user_id` referred to in the webhook you received.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CraMonitoringInsightsGet(new CraMonitoringInsightsGetOperationRequest
    {
        Body = new CraMonitoringInsightsGetRequest
        {
            ConsumerReportPermissiblePurpose = MonitoringConsumerReportPermissiblePurpose.AccountReviewCredit,
        },
    });
    // TODO: Handle 'response' of type CraMonitoringInsightsGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CraMonitoringInsightsGetOperationRequest](src/ThePlaidApi/Requests/CraMonitoringInsightsGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CraMonitoringInsightsGetResponse](src/ThePlaidApi/Models/CraMonitoringInsightsGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CraMonitoringInsightsSubscribeResponse&gt; CraMonitoringInsightsSubscribe(CraMonitoringInsightsSubscribeOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows you to subscribe to insights for a user's linked CRA Item, which are updated between one and four times per day (best-effort). In the current Cash Flow Updates beta experience, only one Item per user may be subscribed for monitoring updates.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CraMonitoringInsightsSubscribe(new CraMonitoringInsightsSubscribeOperationRequest
    {
        Body = new CraMonitoringInsightsSubscribeRequest { Webhook = "some example string" },
    });
    // TODO: Handle 'response' of type CraMonitoringInsightsSubscribeResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CraMonitoringInsightsSubscribeOperationRequest](src/ThePlaidApi/Requests/CraMonitoringInsightsSubscribeOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CraMonitoringInsightsSubscribeResponse](src/ThePlaidApi/Models/CraMonitoringInsightsSubscribeResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CraMonitoringInsightsUnsubscribeResponse&gt; CraMonitoringInsightsUnsubscribe(CraMonitoringInsightsUnsubscribeOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows you to unsubscribe from previously subscribed Monitoring Insights.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CraMonitoringInsightsUnsubscribe(new CraMonitoringInsightsUnsubscribeOperationRequest
    {
        Body = new CraMonitoringInsightsUnsubscribeRequest { SubscriptionId = "some example string" },
    });
    // TODO: Handle 'response' of type CraMonitoringInsightsUnsubscribeResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CraMonitoringInsightsUnsubscribeOperationRequest](src/ThePlaidApi/Requests/CraMonitoringInsightsUnsubscribeOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CraMonitoringInsightsUnsubscribeResponse](src/ThePlaidApi/Models/CraMonitoringInsightsUnsubscribeResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CraPartnerInsightsGetResponse&gt; CraPartnerInsightsGet(CraPartnerInsightsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/cra/partner_insights/get` returns cash flow insights for a specified user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CraPartnerInsightsGet(new CraPartnerInsightsGetOperationRequest
    {
        Body = new CraPartnerInsightsGetRequest { UserToken = "some example string" },
    });
    // TODO: Handle 'response' of type CraPartnerInsightsGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CraPartnerInsightsGetOperationRequest](src/ThePlaidApi/Requests/CraPartnerInsightsGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CraPartnerInsightsGetResponse](src/ThePlaidApi/Models/CraPartnerInsightsGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CraReportGetResponse&gt; CraReportGet(CraReportGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/cra/report/get` retrieves a CRA Report for a user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CraReportGet(new CraReportGetOperationRequest
    {
        Body = new CraReportGetRequest
        {
            UserId = "some example string",
            Products = [new CraReportGetRequestProduct { Product = Products.Assets, Version = "some example string" }],
            DecisionStage = CraReportDecisionStage.Prequalification,
            ConsumerReportPermissiblePurpose = ConsumerReportPermissiblePurpose.AccountReviewCredit,
        },
    });
    // TODO: Handle 'response' of type CraReportGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CraReportGetOperationRequest](src/ThePlaidApi/Requests/CraReportGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CraReportGetResponse](src/ThePlaidApi/Models/CraReportGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentInitiationPaymentTokenCreateResponse&gt; CreatePaymentToken(CreatePaymentTokenRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/payment_initiation/payment/token/create` endpoint has been deprecated. New Plaid customers will be unable to use this endpoint, and existing customers are encouraged to migrate to the newer, `link_token`-based flow. The recommended flow is to provide the `payment_id` to `/link/token/create`, which returns a `link_token` used to initialize Link.

The `/payment_initiation/payment/token/create` endpoint is used to create a `payment_token`, which can then be used in Link initialization to enter a payment initiation flow. You can only use a `payment_token` once. If this attempt fails, the end user aborts the flow, or the token expires, you will need to create a new payment token. Creating a new payment token does not require end user input.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CreatePaymentToken(new CreatePaymentTokenRequest
    {
        Body = new PaymentInitiationPaymentTokenCreateRequest { PaymentId = "some example string" },
    });
    // TODO: Handle 'response' of type PaymentInitiationPaymentTokenCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreatePaymentTokenRequest](src/ThePlaidApi/Requests/CreatePaymentTokenRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentInitiationPaymentTokenCreateResponse](src/ThePlaidApi/Models/PaymentInitiationPaymentTokenCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AssetReportFreddieGetResponse&gt; CreditAssetReportFreddieMacGet(CreditAssetReportFreddieMacGetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/credit/asset_report/freddie_mac/get` endpoint retrieves the Asset Report in Freddie Mac's JSON format.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CreditAssetReportFreddieMacGet(new CreditAssetReportFreddieMacGetRequest
    {
        Body = new AssetReportFreddieGetRequest { AuditCopyToken = "some example string" },
    });
    // TODO: Handle 'response' of type AssetReportFreddieGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreditAssetReportFreddieMacGetRequest](src/ThePlaidApi/Requests/CreditAssetReportFreddieMacGetRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AssetReportFreddieGetResponse](src/ThePlaidApi/Models/AssetReportFreddieGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreditAuditCopyTokenCreateResponse&gt; CreditAuditCopyTokenCreate(CreditAuditCopyTokenCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Plaid can create an Audit Copy token of an Asset Report and/or Income Report to share with a participating Government-Sponsored Enterprise (GSE) if you participate in Fannie Mae's Day 1 Certainty™ program or utilize Freddie Mac's Loan Product Advisor® (LPA®) Asset and Income Modeler (AIM). An Audit Copy token contains the same underlying data as the Asset Report and/or Income Report (result of `/credit/payroll_income/get`).

Use the `/credit/audit_copy_token/create` endpoint to create an `audit_copy_token` and then pass that token to the GSE who needs access.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CreditAuditCopyTokenCreate(new CreditAuditCopyTokenCreateOperationRequest
    {
        Body = new CreditAuditCopyTokenCreateRequest { ReportTokens = ["some example string"] },
    });
    // TODO: Handle 'response' of type CreditAuditCopyTokenCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreditAuditCopyTokenCreateOperationRequest](src/ThePlaidApi/Requests/CreditAuditCopyTokenCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreditAuditCopyTokenCreateResponse](src/ThePlaidApi/Models/CreditAuditCopyTokenCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreditAuditCopyTokenUpdateResponse&gt; CreditAuditCopyTokenUpdate(CreditAuditCopyTokenUpdateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/credit/audit_copy_token/update` endpoint updates an existing Audit Copy Token by adding the report tokens in the `report_tokens` field to the `audit_copy_token`. If the Audit Copy Token already contains a report of a certain type, it will be replaced with the token provided in the `report_tokens` field.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CreditAuditCopyTokenUpdate(new CreditAuditCopyTokenUpdateOperationRequest
    {
        Body = new CreditAuditCopyTokenUpdateRequest
        {
            AuditCopyToken = "some example string",
            ReportTokens = ["some example string"],
        },
    });
    // TODO: Handle 'response' of type CreditAuditCopyTokenUpdateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreditAuditCopyTokenUpdateOperationRequest](src/ThePlaidApi/Requests/CreditAuditCopyTokenUpdateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreditAuditCopyTokenUpdateResponse](src/ThePlaidApi/Models/CreditAuditCopyTokenUpdateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreditBankEmploymentGetResponse&gt; CreditBankEmploymentGet(CreditBankEmploymentGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/beta/credit/v1/bank_employment/get` returns the employment report(s) derived from bank transaction data for a specified user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CreditBankEmploymentGet(new CreditBankEmploymentGetOperationRequest
    {
        Body = new CreditBankEmploymentGetRequest { UserToken = "some example string" },
    });
    // TODO: Handle 'response' of type CreditBankEmploymentGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreditBankEmploymentGetOperationRequest](src/ThePlaidApi/Requests/CreditBankEmploymentGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreditBankEmploymentGetResponse](src/ThePlaidApi/Models/CreditBankEmploymentGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreditBankIncomeGetResponse&gt; CreditBankIncomeGet(CreditBankIncomeGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/credit/bank_income/get` returns the bank income report(s) for a specified user. A single report corresponds to all institutions linked in a single Link session. To include multiple institutions in a single report, use [Multi-Item Link](https://plaid.com/docs/link/multi-item-link). To return older reports, use the `options.count` field.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CreditBankIncomeGet(new CreditBankIncomeGetOperationRequest
    {
        Body = new CreditBankIncomeGetRequest(),
    });
    // TODO: Handle 'response' of type CreditBankIncomeGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreditBankIncomeGetOperationRequest](src/ThePlaidApi/Requests/CreditBankIncomeGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreditBankIncomeGetResponse](src/ThePlaidApi/Models/CreditBankIncomeGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task CreditBankIncomePdfGet(CreditBankIncomePdfGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/credit/bank_income/pdf/get` returns the most recent bank income report for a specified user in PDF format.  A single report corresponds to all institutions linked in a single Link session. To include multiple institutions in a single report, use [Multi-Item Link](https://plaid.com/docs/link/multi-item-link).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.CreditBankIncomePdfGet(new CreditBankIncomePdfGetOperationRequest
    {
        Body = new CreditBankIncomePdfGetRequest { UserToken = "some example string" },
    });
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreditBankIncomePdfGetOperationRequest](src/ThePlaidApi/Requests/CreditBankIncomePdfGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreditBankIncomeRefreshResponse&gt; CreditBankIncomeRefresh(CreditBankIncomeRefreshOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/credit/bank_income/refresh` is deprecated. The backend implementation was removed (returns an `Unimplemented` error at runtime), and the endpoint is no longer part of the documented API surface. To refresh Bank Income data for an existing user, send the user through Link's update mode so they can confirm their income sources. For a fully backend refresh, migrate to CRA Income Insights and call `/cra/check_report/create`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CreditBankIncomeRefresh(new CreditBankIncomeRefreshOperationRequest
    {
        Body = new CreditBankIncomeRefreshRequest { UserToken = "some example string" },
    });
    // TODO: Handle 'response' of type CreditBankIncomeRefreshResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreditBankIncomeRefreshOperationRequest](src/ThePlaidApi/Requests/CreditBankIncomeRefreshOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreditBankIncomeRefreshResponse](src/ThePlaidApi/Models/CreditBankIncomeRefreshResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreditBankIncomeWebhookUpdateResponse&gt; CreditBankIncomeWebhookUpdate(CreditBankIncomeWebhookUpdateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/credit/bank_income/webhook/update` allows you to subscribe or unsubscribe a user for income webhook notifications. By default, all users start out unsubscribed.

If a user is subscribed, on significant changes to the user's income profile, you will receive a `BANK_INCOME_REFRESH_UPDATE` webhook, prompting you to refresh bank income data for the user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CreditBankIncomeWebhookUpdate(new CreditBankIncomeWebhookUpdateOperationRequest
    {
        Body = new CreditBankIncomeWebhookUpdateRequest { UserToken = "some example string", EnableWebhooks = true },
    });
    // TODO: Handle 'response' of type CreditBankIncomeWebhookUpdateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreditBankIncomeWebhookUpdateOperationRequest](src/ThePlaidApi/Requests/CreditBankIncomeWebhookUpdateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreditBankIncomeWebhookUpdateResponse](src/ThePlaidApi/Models/CreditBankIncomeWebhookUpdateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreditBankStatementsUploadsGetResponse&gt; CreditBankStatementsUploadsGet(CreditBankStatementsUploadsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/credit/bank_statements/uploads/get` returns parsed data from bank statements uploaded by users as part of the Document Income flow. If your account is not enabled for Document Parsing, contact your account manager to request access.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CreditBankStatementsUploadsGet(new CreditBankStatementsUploadsGetOperationRequest
    {
        Body = new CreditBankStatementsUploadsGetRequest { UserToken = "some example string" },
    });
    // TODO: Handle 'response' of type CreditBankStatementsUploadsGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreditBankStatementsUploadsGetOperationRequest](src/ThePlaidApi/Requests/CreditBankStatementsUploadsGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreditBankStatementsUploadsGetResponse](src/ThePlaidApi/Models/CreditBankStatementsUploadsGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreditEmploymentGetResponse&gt; CreditEmploymentGet(CreditEmploymentGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/credit/employment/get` returns a list of items with employment information from a user's payroll provider that was verified by an end user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CreditEmploymentGet(new CreditEmploymentGetOperationRequest
    {
        Body = new CreditEmploymentGetRequest { UserToken = "some example string" },
    });
    // TODO: Handle 'response' of type CreditEmploymentGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreditEmploymentGetOperationRequest](src/ThePlaidApi/Requests/CreditEmploymentGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreditEmploymentGetResponse](src/ThePlaidApi/Models/CreditEmploymentGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreditFreddieMacReportsGetResponse&gt; CreditFreddieMacReportsGet(CreditFreddieMacReportsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/credit/freddie_mac/reports/get` endpoint retrieves the Verification of Assets and Verification of Employment reports.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CreditFreddieMacReportsGet(new CreditFreddieMacReportsGetOperationRequest
    {
        Body = new CreditFreddieMacReportsGetRequest { AuditCopyToken = "some example string" },
    });
    // TODO: Handle 'response' of type CreditFreddieMacReportsGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreditFreddieMacReportsGetOperationRequest](src/ThePlaidApi/Requests/CreditFreddieMacReportsGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreditFreddieMacReportsGetResponse](src/ThePlaidApi/Models/CreditFreddieMacReportsGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreditPayrollIncomeGetResponse&gt; CreditPayrollIncomeGet(CreditPayrollIncomeGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint gets payroll income information for a specific user, either as a result of the user connecting to their payroll provider or uploading a pay related document.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CreditPayrollIncomeGet(new CreditPayrollIncomeGetOperationRequest
    {
        Body = new CreditPayrollIncomeGetRequest(),
    });
    // TODO: Handle 'response' of type CreditPayrollIncomeGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreditPayrollIncomeGetOperationRequest](src/ThePlaidApi/Requests/CreditPayrollIncomeGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreditPayrollIncomeGetResponse](src/ThePlaidApi/Models/CreditPayrollIncomeGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreditPayrollIncomeParsingConfigUpdateResponse&gt; CreditPayrollIncomeParsingConfigUpdate(CreditPayrollIncomeParsingConfigUpdateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/credit/payroll_income/parsing_config/update` updates the parsing configuration for a document income verification.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CreditPayrollIncomeParsingConfigUpdate(
        new CreditPayrollIncomeParsingConfigUpdateOperationRequest
        {
            Body = new CreditPayrollIncomeParsingConfigUpdateRequest
            {
                UserToken = "some example string",
                ParsingConfig = [IncomeVerificationDocParsingConfig.Ocr],
            },
        });
    // TODO: Handle 'response' of type CreditPayrollIncomeParsingConfigUpdateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreditPayrollIncomeParsingConfigUpdateOperationRequest](src/ThePlaidApi/Requests/CreditPayrollIncomeParsingConfigUpdateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreditPayrollIncomeParsingConfigUpdateResponse](src/ThePlaidApi/Models/CreditPayrollIncomeParsingConfigUpdateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreditPayrollIncomePrecheckResponse&gt; CreditPayrollIncomePrecheck(CreditPayrollIncomePrecheckOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/credit/payroll_income/precheck` is an optional endpoint that can be called before initializing a Link session for income verification. It evaluates whether a given user is supportable by digital income verification. If the user is eligible for digital verification, that information will be associated with the user token, and in this way will generate a Link UI optimized for the end user and their specific employer. If the user cannot be confirmed as eligible, the user can still use the income verification flow, but they may be required to manually upload a paystub to verify their income.

While all request fields are optional, providing `employer` data will increase the chance of receiving a useful result.

When testing in Sandbox, you can control the results by providing special test values in the `employer` and `access_tokens` fields. `employer_good` and `employer_bad` will result in `HIGH` and `LOW` confidence values, respectively. `employer_multi` will result in a `HIGH` confidence with multiple payroll options. Likewise, `access_good` and `access_bad` will result in `HIGH` and `LOW` confidence values, respectively. Any other value for `employer` and `access_tokens` in Sandbox will result in `UNKNOWN` confidence.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CreditPayrollIncomePrecheck(new CreditPayrollIncomePrecheckOperationRequest
    {
        Body = new CreditPayrollIncomePrecheckRequest(),
    });
    // TODO: Handle 'response' of type CreditPayrollIncomePrecheckResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreditPayrollIncomePrecheckOperationRequest](src/ThePlaidApi/Requests/CreditPayrollIncomePrecheckOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreditPayrollIncomePrecheckResponse](src/ThePlaidApi/Models/CreditPayrollIncomePrecheckResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreditPayrollIncomeRefreshResponse&gt; CreditPayrollIncomeRefresh(CreditPayrollIncomeRefreshOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/credit/payroll_income/refresh` refreshes a given digital payroll income verification.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CreditPayrollIncomeRefresh(new CreditPayrollIncomeRefreshOperationRequest
    {
        Body = new CreditPayrollIncomeRefreshRequest { UserToken = "some example string" },
    });
    // TODO: Handle 'response' of type CreditPayrollIncomeRefreshResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreditPayrollIncomeRefreshOperationRequest](src/ThePlaidApi/Requests/CreditPayrollIncomeRefreshOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreditPayrollIncomeRefreshResponse](src/ThePlaidApi/Models/CreditPayrollIncomeRefreshResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreditPayrollIncomeRiskSignalsGetResponse&gt; CreditPayrollIncomeRiskSignalsGet(CreditPayrollIncomeRiskSignalsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/credit/payroll_income/risk_signals/get` can be used as part of the Document Income flow to assess a user-uploaded document for signs of potential fraud or tampering. It returns a risk score for each uploaded document that indicates the likelihood of the document being fraudulent, in addition to details on the individual risk signals contributing to the score.

To trigger risk signal generation for an Item, call `/link/token/create` with `parsing_config` set to include `risk_signals`, or call `/credit/payroll_income/parsing_config/update`. Once risk signal generation has been triggered, `/credit/payroll_income/risk_signals/get` can be called at any time after the `INCOME_VERIFICATION_RISK_SIGNALS` webhook has been fired.

`/credit/payroll_income/risk_signals/get` is offered as an add-on to Document Income and is billed separately. To request access to this endpoint, submit a product access request or contact your Plaid account manager.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CreditPayrollIncomeRiskSignalsGet(new CreditPayrollIncomeRiskSignalsGetOperationRequest
    {
        Body = new CreditPayrollIncomeRiskSignalsGetRequest(),
    });
    // TODO: Handle 'response' of type CreditPayrollIncomeRiskSignalsGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreditPayrollIncomeRiskSignalsGetOperationRequest](src/ThePlaidApi/Requests/CreditPayrollIncomeRiskSignalsGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreditPayrollIncomeRiskSignalsGetResponse](src/ThePlaidApi/Models/CreditPayrollIncomeRiskSignalsGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreditRelayCreateResponse&gt; CreditRelayCreate(CreditRelayCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Plaid can share an Asset Report directly with a participating third party on your behalf. The shared Asset Report is the exact same Asset Report originally created in `/asset_report/create`.

To grant a third party access to an Asset Report, use the `/credit/relay/create` endpoint to create a `relay_token` and then pass that token to your third party. Each third party has its own `secondary_client_id`; for example, `ce5bd328dcd34123456`. You'll need to create a separate `relay_token` for each third party that needs access to the report on your behalf.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CreditRelayCreate(new CreditRelayCreateOperationRequest
    {
        Body = new CreditRelayCreateRequest
        {
            ReportTokens = ["some example string"],
            SecondaryClientId = "some example string",
        },
    });
    // TODO: Handle 'response' of type CreditRelayCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreditRelayCreateOperationRequest](src/ThePlaidApi/Requests/CreditRelayCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreditRelayCreateResponse](src/ThePlaidApi/Models/CreditRelayCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AssetReportGetResponse&gt; CreditRelayGet(CreditRelayGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/credit/relay/get` allows third parties to receive a report that was shared with them, using a `relay_token` that was created by the report owner.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CreditRelayGet(new CreditRelayGetOperationRequest
    {
        Body = new CreditRelayGetRequest { RelayToken = "some example string", ReportType = ReportType.Asset },
    });
    // TODO: Handle 'response' of type AssetReportGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreditRelayGetOperationRequest](src/ThePlaidApi/Requests/CreditRelayGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AssetReportGetResponse](src/ThePlaidApi/Models/AssetReportGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task CreditRelayPdfGet(CreditRelayPdfGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/credit/relay/pdf/get` allows third parties to receive a PDF report that was shared with them, using a `relay_token` that was created by the report owner.

The `/credit/relay/pdf/get` endpoint retrieves the Asset Report in PDF format. Before calling `/credit/relay/pdf/get`, you must first create the Asset Report using `/credit/relay/create` and then wait for the [`PRODUCT_READY`](https://plaid.com/docs/api/products/assets/#product_ready) webhook to fire, indicating that the Report is ready to be retrieved.

The response to `/credit/relay/pdf/get` is the PDF binary data. The `request_id` is returned in the `Plaid-Request-ID` header.

[View a sample PDF Asset Report](https://plaid.com/documents/sample-asset-report.pdf).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.CreditRelayPdfGet(new CreditRelayPdfGetOperationRequest
    {
        Body = new CreditRelayPdfGetRequest { RelayToken = "some example string", ReportType = ReportType.Asset },
    });
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreditRelayPdfGetOperationRequest](src/ThePlaidApi/Requests/CreditRelayPdfGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreditRelayRefreshResponse&gt; CreditRelayRefresh(CreditRelayRefreshOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/credit/relay/refresh` endpoint allows third parties to refresh a report that was relayed to them, using a `relay_token` that was created by the report owner. A new report will be created with the original report parameters, but with the most recent data available based on the `days_requested` value of the original report.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CreditRelayRefresh(new CreditRelayRefreshOperationRequest
    {
        Body = new CreditRelayRefreshRequest { RelayToken = "some example string", ReportType = ReportType.Asset },
    });
    // TODO: Handle 'response' of type CreditRelayRefreshResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreditRelayRefreshOperationRequest](src/ThePlaidApi/Requests/CreditRelayRefreshOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreditRelayRefreshResponse](src/ThePlaidApi/Models/CreditRelayRefreshResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreditRelayRemoveResponse&gt; CreditRelayRemove(CreditRelayRemoveOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/credit/relay/remove` endpoint allows you to invalidate a `relay_token`. The third party holding the token will no longer be able to access or refresh the reports which the `relay_token` gives access to. The original report, associated Items, and other relay tokens that provide access to the same report are not affected and will remain accessible after removing the given `relay_token`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CreditRelayRemove(new CreditRelayRemoveOperationRequest
    {
        Body = new CreditRelayRemoveRequest { RelayToken = "some example string" },
    });
    // TODO: Handle 'response' of type CreditRelayRemoveResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreditRelayRemoveOperationRequest](src/ThePlaidApi/Requests/CreditRelayRemoveOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreditRelayRemoveResponse](src/ThePlaidApi/Models/CreditRelayRemoveResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreditAuditCopyTokenRemoveResponse&gt; CreditReportAuditCopyRemove(CreditReportAuditCopyRemoveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/credit/audit_copy_token/remove` endpoint allows you to remove an Audit Copy. Removing an Audit Copy invalidates the `audit_copy_token` associated with it, meaning both you and any third parties holding the token will no longer be able to use it to access Report data. Items associated with the Report data and other Audit Copies of it are not affected and will remain accessible after removing the given Audit Copy.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CreditReportAuditCopyRemove(new CreditReportAuditCopyRemoveRequest
    {
        Body = new CreditAuditCopyTokenRemoveRequest { AuditCopyToken = "some example string" },
    });
    // TODO: Handle 'response' of type CreditAuditCopyTokenRemoveResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreditReportAuditCopyRemoveRequest](src/ThePlaidApi/Requests/CreditReportAuditCopyRemoveRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreditAuditCopyTokenRemoveResponse](src/ThePlaidApi/Models/CreditAuditCopyTokenRemoveResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CreditSessionsGetResponse&gt; CreditSessionsGet(CreditSessionsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint can be used for your end users after they complete the Link flow. This endpoint returns a list of Link sessions that your user completed, where each session includes the results from the Link flow.

These results include details about the Item that was created and some product related metadata (showing, for example, whether the user finished the bank income verification step).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CreditSessionsGet(new CreditSessionsGetOperationRequest
    {
        Body = new CreditSessionsGetRequest { UserToken = "some example string" },
    });
    // TODO: Handle 'response' of type CreditSessionsGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreditSessionsGetOperationRequest](src/ThePlaidApi/Requests/CreditSessionsGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CreditSessionsGetResponse](src/ThePlaidApi/Models/CreditSessionsGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DashboardUserGetResponse&gt; DashboardUserGet(DashboardUserGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/dashboard_user/get` endpoint provides details (such as email address) about a specific Dashboard user based on the `dashboard_user_id` field, which is returned in the `audit_trail` object of certain Monitor and Beacon endpoints. This can be used to identify the specific reviewer who performed a Dashboard action.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DashboardUserGet(new DashboardUserGetOperationRequest
    {
        Body = new DashboardUserGetRequest { DashboardUserId = "some example string" },
    });
    // TODO: Handle 'response' of type DashboardUserGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DashboardUserGetOperationRequest](src/ThePlaidApi/Requests/DashboardUserGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DashboardUserGetResponse](src/ThePlaidApi/Models/DashboardUserGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DashboardUserListResponse&gt; DashboardUserList(DashboardUserListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/dashboard_user/list` endpoint provides details (such as email address) about all Dashboard users associated with your account. This can be used to audit or track the list of reviewers for Monitor, Beacon, and Identity Verification products.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.DashboardUserList(new DashboardUserListOperationRequest
    {
        Body = new DashboardUserListRequest(),
    });
    // TODO: Handle 'response' of type DashboardUserListResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DashboardUserListOperationRequest](src/ThePlaidApi/Requests/DashboardUserListOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DashboardUserListResponse](src/ThePlaidApi/Models/DashboardUserListResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;EmployersSearchResponse&gt; EmployersSearch(EmployersSearchOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/employers/search` allows you the ability to search Plaid's database of known employers, for use with Deposit Switch. You can use this endpoint to look up a user's employer in order to confirm that they are supported. Users with non-supported employers can then be routed out of the Deposit Switch flow.

The data in the employer database is currently limited. As the Deposit Switch and Income products progress through their respective beta periods, more employers are being regularly added. Because the employer database is frequently updated, we recommend that you do not cache or store data from this endpoint for more than a day.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EmployersSearch(new EmployersSearchOperationRequest
    {
        Body = new EmployersSearchRequest { Query = "some example string", Products = ["some example string"] },
    });
    // TODO: Handle 'response' of type EmployersSearchResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[EmployersSearchOperationRequest](src/ThePlaidApi/Requests/EmployersSearchOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EmployersSearchResponse](src/ThePlaidApi/Models/EmployersSearchResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;EmploymentVerificationGetResponse&gt; EmploymentVerificationGet(EmploymentVerificationGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/employment/verification/get` returns a list of employments through a user payroll that was verified by an end user.

This endpoint has been deprecated; new integrations should use `/credit/employment/get` instead.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.EmploymentVerificationGet(new EmploymentVerificationGetOperationRequest
    {
        Body = new EmploymentVerificationGetRequest { AccessToken = "some example string" },
    });
    // TODO: Handle 'response' of type EmploymentVerificationGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[EmploymentVerificationGetOperationRequest](src/ThePlaidApi/Requests/EmploymentVerificationGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[EmploymentVerificationGetResponse](src/ThePlaidApi/Models/EmploymentVerificationGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FdxConsentGrant&gt; FdxConsentsGet(FdxConsentsGetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a consent grant by its identifier

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FdxConsentsGet(new FdxConsentsGetRequest { ConsentId = "some example string" });
    // TODO: Handle 'response' of type FdxConsentGrant
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[FdxConsentsGetRequest](src/ThePlaidApi/Requests/FdxConsentsGetRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FdxConsentGrant](src/ThePlaidApi/Models/FdxConsentGrant.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetConsentsResponse&gt; FdxConsentsList(FdxConsentsListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns zero or more consent grants associated with the given data provider customer, optionally filtered by status.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FdxConsentsList(new FdxConsentsListRequest { CustomerId = "some example string" });
    // TODO: Handle 'response' of type GetConsentsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[FdxConsentsListRequest](src/ThePlaidApi/Requests/FdxConsentsListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetConsentsResponse](src/ThePlaidApi/Models/GetConsentsResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FdxConsentRevocations&gt; FdxConsentsRevocationGet(FdxConsentsRevocationGetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the revocation history of a consent grant

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.FdxConsentsRevocationGet(new FdxConsentsRevocationGetRequest
    {
        ConsentId = "some example string",
    });
    // TODO: Handle 'response' of type FdxConsentRevocations
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[FdxConsentsRevocationGetRequest](src/ThePlaidApi/Requests/FdxConsentsRevocationGetRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FdxConsentRevocations](src/ThePlaidApi/Models/FdxConsentRevocations.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task FdxConsentsRevoke(FdxConsentsRevokeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Appends a REVOKED status record to the named consent grant

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.FdxConsentsRevoke(new FdxConsentsRevokeRequest
    {
        ConsentId = "some example string",
        Body = new FdxConsentRevocation
        {
            Initiator = PartyType.DataAccessPlatform,
            Reason = FdxUpdateReason.BusinessRule,
        },
    });
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[FdxConsentsRevokeRequest](src/ThePlaidApi/Requests/FdxConsentsRevokeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task FdxNotifications(FdxNotificationsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

A generic webhook receiver endpoint for FDX Event Notifications

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.FdxNotifications(new FdxNotificationsRequest
    {
        Body = new FdxNotificationEntity
        {
            NotificationId = "some example string",
            Type = NotificationType.AccountTakeover,
            SentOn = DateTimeOffset.Parse("2024-01-15T09:30:00Z"),
            Category = NotificationCategory.Security,
            NotificationPayload = new NotificationPayloadEntity(),
        },
    });
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[FdxNotificationsRequest](src/ThePlaidApi/Requests/FdxNotificationsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;FdxRecipientMetadata&gt; GetRecipient(GetRecipientRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get a specific recipient

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GetRecipient(new GetRecipientRequest { RecipientId = "some example string" });
    // TODO: Handle 'response' of type FdxRecipientMetadata
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetRecipientRequest](src/ThePlaidApi/Requests/GetRecipientRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[FdxRecipientMetadata](src/ThePlaidApi/Models/FdxRecipientMetadata.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GetRecipientsResponse&gt; GetRecipients(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of Recipients

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GetRecipients();
    // TODO: Handle 'response' of type GetRecipientsResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GetRecipientsResponse](src/ThePlaidApi/Models/GetRecipientsResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IdentityDocumentsUploadsGetResponse&gt; IdentityDocumentsUploadsGet(IdentityDocumentsUploadsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use `/identity/documents/uploads/get` to retrieve identity details when using [Identity Document Upload](https://plaid.com/docs/identity/identity-document-upload/).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.IdentityDocumentsUploadsGet(new IdentityDocumentsUploadsGetOperationRequest
    {
        Body = new IdentityDocumentsUploadsGetRequest { AccessToken = "some example string" },
    });
    // TODO: Handle 'response' of type IdentityDocumentsUploadsGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[IdentityDocumentsUploadsGetOperationRequest](src/ThePlaidApi/Requests/IdentityDocumentsUploadsGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[IdentityDocumentsUploadsGetResponse](src/ThePlaidApi/Models/IdentityDocumentsUploadsGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IdentityGetResponse&gt; IdentityGet(IdentityGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/identity/get` endpoint allows you to retrieve various account holder information on file with the financial institution, including names, emails, phone numbers, and addresses. Only name data is guaranteed to be returned; other fields will be empty arrays if not provided by the institution.

Note: In API versions 2018-05-22 and earlier, the `owners` object is not returned, and instead identity information is returned in the top level `identity` object. For more details, see [Plaid API versioning](https://plaid.com/docs/api/versioning/#version-2019-05-29).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.IdentityGet(new IdentityGetOperationRequest
    {
        Body = new IdentityGetRequest { AccessToken = "some example string" },
    });
    // TODO: Handle 'response' of type IdentityGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[IdentityGetOperationRequest](src/ThePlaidApi/Requests/IdentityGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[IdentityGetResponse](src/ThePlaidApi/Models/IdentityGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IdentityMatchResponse&gt; IdentityMatch(IdentityMatchOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/identity/match` endpoint generates a match score, which indicates how well the provided identity data matches the identity information on file with the account holder's financial institution.

Fields within the `balances` object will always be null when retrieved by `/identity/match`. Instead, use the free `/accounts/get` endpoint to request balance cached data, or `/accounts/balance/get` or `/signal/evaluate` for real-time data.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.IdentityMatch(new IdentityMatchOperationRequest
    {
        Body = new IdentityMatchRequest { AccessToken = "some example string" },
    });
    // TODO: Handle 'response' of type IdentityMatchResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[IdentityMatchOperationRequest](src/ThePlaidApi/Requests/IdentityMatchOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[IdentityMatchResponse](src/ThePlaidApi/Models/IdentityMatchResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IdentityRefreshResponse&gt; IdentityRefresh(IdentityRefreshOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/identity/refresh` is an optional endpoint for users of the Identity product. It initiates an on-demand extraction to fetch the most up to date Identity information from the Financial Institution. This on-demand extraction takes place in addition to the periodic extractions that automatically occur for any Identity-enabled Item. If changes to Identity are discovered after calling `/identity/refresh`, Plaid will fire a webhook [`DEFAULT_UPDATE`](https://plaid.com/docs/api/products/identity/#default_update).

As this endpoint triggers a synchronous request for fresh data, latency may be higher than for other Plaid endpoints (typically less than 10 seconds, but occasionally up to 30 seconds or more); if you encounter errors, you may find it necessary to adjust your timeout period when making requests.

`/identity/refresh` is offered as an add-on to Identity and has a separate [fee model](https://plaid.com/docs/account/billing/#per-request-flat-fee). To request access to this endpoint, submit a [product access request](https://dashboard.plaid.com/team/products) or contact your Plaid account manager.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.IdentityRefresh(new IdentityRefreshOperationRequest
    {
        Body = new IdentityRefreshRequest { AccessToken = "some example string" },
    });
    // TODO: Handle 'response' of type IdentityRefreshResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[IdentityRefreshOperationRequest](src/ThePlaidApi/Requests/IdentityRefreshOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[IdentityRefreshResponse](src/ThePlaidApi/Models/IdentityRefreshResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IdentityVerificationAutofillCreateResponse&gt; IdentityVerificationAutofillCreate(IdentityVerificationAutofillCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Try to autofill an Identity Verification based on the provided phone number, date of birth and country of residence.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.IdentityVerificationAutofillCreate(
        new IdentityVerificationAutofillCreateOperationRequest
        {
            Body = new IdentityVerificationAutofillCreateRequest { IdentityVerificationId = "flwses_42cF1MNo42r9Xj" },
        });
    // TODO: Handle 'response' of type IdentityVerificationAutofillCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[IdentityVerificationAutofillCreateOperationRequest](src/ThePlaidApi/Requests/IdentityVerificationAutofillCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[IdentityVerificationAutofillCreateResponse](src/ThePlaidApi/Models/IdentityVerificationAutofillCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IdentityVerificationCreateResponse&gt; IdentityVerificationCreate(IdentityVerificationCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a new Identity Verification for the user specified by the `client_user_id` and/or `user_id` field. At least one of these two fields must be provided. The requirements and behavior of the verification are determined by the `template_id` provided. If `user_id` is provided, there must be an associated user; otherwise, an error will be returned.


If you don't know whether an active Identity Verification exists for a given `client_user_id` and/or `user_id`, you can specify `"is_idempotent": true` in the request body. With idempotency enabled, a new Identity Verification will only be created if one does not already exist for the associated `client_user_id` and/or `user_id`, and `template_id`. If an Identity Verification is found, it will be returned unmodified with a `200 OK` HTTP status code.


If `user_id` is not provided, you can also use this endpoint to supply information you already have collected about the user; if any of these fields are specified, the screens prompting the user to enter them will be skipped during the Link flow. If `user_id` is provided, user information can not be included in the request body. Please use the `/user/update` endpoint to update user data instead.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.IdentityVerificationCreate(new IdentityVerificationCreateOperationRequest
    {
        Body = new IdentityVerificationCreateRequest
        {
            IsShareable = true,
            TemplateId = "some example string",
            GaveConsent = true,
        },
    });
    // TODO: Handle 'response' of type IdentityVerificationCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[IdentityVerificationCreateOperationRequest](src/ThePlaidApi/Requests/IdentityVerificationCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[IdentityVerificationCreateResponse](src/ThePlaidApi/Models/IdentityVerificationCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IdentityVerificationGetResponse&gt; IdentityVerificationGet(IdentityVerificationGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve a previously created Identity Verification.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.IdentityVerificationGet(new IdentityVerificationGetOperationRequest
    {
        Body = new IdentityVerificationGetRequest { IdentityVerificationId = "some example string" },
    });
    // TODO: Handle 'response' of type IdentityVerificationGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[IdentityVerificationGetOperationRequest](src/ThePlaidApi/Requests/IdentityVerificationGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[IdentityVerificationGetResponse](src/ThePlaidApi/Models/IdentityVerificationGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IdentityVerificationListResponse&gt; IdentityVerificationList(IdentityVerificationListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Filter and list Identity Verifications created by your account

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.IdentityVerificationList(new IdentityVerificationListOperationRequest
    {
        Body = new IdentityVerificationListRequest { TemplateId = "some example string" },
    });
    // TODO: Handle 'response' of type IdentityVerificationListResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[IdentityVerificationListOperationRequest](src/ThePlaidApi/Requests/IdentityVerificationListOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[IdentityVerificationListResponse](src/ThePlaidApi/Models/IdentityVerificationListResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IdentityVerificationRetryResponse&gt; IdentityVerificationRetry(IdentityVerificationRetryOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Allow a customer to retry their Identity Verification

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.IdentityVerificationRetry(new IdentityVerificationRetryOperationRequest
    {
        Body = new IdentityVerificationRetryRequest
        {
            ClientUserId = "some example string",
            TemplateId = "some example string",
            Strategy = Strategy.Reset,
        },
    });
    // TODO: Handle 'response' of type IdentityVerificationRetryResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[IdentityVerificationRetryOperationRequest](src/ThePlaidApi/Requests/IdentityVerificationRetryOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[IdentityVerificationRetryResponse](src/ThePlaidApi/Models/IdentityVerificationRetryResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IncomeVerificationCreateResponse&gt; IncomeVerificationCreate(IncomeVerificationCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/income/verification/create` begins the income verification process by returning an `income_verification_id`. You can then provide the `income_verification_id` to `/link/token/create` under the `income_verification` parameter in order to create a Link instance that will prompt the user to go through the income verification flow. Plaid will fire an `INCOME` webhook once the user completes the Payroll Income flow, or when the uploaded documents in the Document Income flow have finished processing.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.IncomeVerificationCreate(new IncomeVerificationCreateOperationRequest
    {
        Body = new IncomeVerificationCreateRequest { Webhook = "some example string" },
    });
    // TODO: Handle 'response' of type IncomeVerificationCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[IncomeVerificationCreateOperationRequest](src/ThePlaidApi/Requests/IncomeVerificationCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[IncomeVerificationCreateResponse](src/ThePlaidApi/Models/IncomeVerificationCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task IncomeVerificationDocumentsDownload(IncomeVerificationDocumentsDownloadOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/income/verification/documents/download` provides the ability to download the source documents associated with the verification.

If Document Income was used, the documents will be those the user provided in Link. For Payroll Income, the most recent files available for download from the payroll provider will be available from this endpoint.

The response to `/income/verification/documents/download` is a ZIP file in binary data. If a `document_id` is passed, a single document will be contained in this file.
If not, the response will contain all documents associated with the verification.

The `request_id` is returned in the `Plaid-Request-ID` header.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.IncomeVerificationDocumentsDownload(new IncomeVerificationDocumentsDownloadOperationRequest
    {
        Body = new IncomeVerificationDocumentsDownloadRequest(),
    });
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[IncomeVerificationDocumentsDownloadOperationRequest](src/ThePlaidApi/Requests/IncomeVerificationDocumentsDownloadOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IncomeVerificationPaystubsGetResponse&gt; IncomeVerificationPaystubsGet(IncomeVerificationPaystubsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/income/verification/paystubs/get` returns the information collected from the paystubs that were used to verify an end user's income. It can be called once the status of the verification has been set to `VERIFICATION_STATUS_PROCESSING_COMPLETE`, as reported by the `INCOME: verification_status` webhook. Attempting to call the endpoint before verification has been completed will result in an error.

This endpoint has been deprecated; new integrations should use `/credit/payroll_income/get` instead.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.IncomeVerificationPaystubsGet(new IncomeVerificationPaystubsGetOperationRequest
    {
        Body = new IncomeVerificationPaystubsGetRequest(),
    });
    // TODO: Handle 'response' of type IncomeVerificationPaystubsGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[IncomeVerificationPaystubsGetOperationRequest](src/ThePlaidApi/Requests/IncomeVerificationPaystubsGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[IncomeVerificationPaystubsGetResponse](src/ThePlaidApi/Models/IncomeVerificationPaystubsGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IncomeVerificationPrecheckResponse&gt; IncomeVerificationPrecheck(IncomeVerificationPrecheckOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/income/verification/precheck` is an optional endpoint that can be called before initializing a Link session for income verification. It evaluates whether a given user is supportable by digital income verification and returns a `precheck_id` that can be provided to `/link/token/create`. If the user is eligible for digital verification, providing the `precheck_id` in this way will generate a Link UI optimized for the end user and their specific employer. If the user cannot be confirmed as eligible, the `precheck_id` can still be provided to `/link/token/create` and the user can still use the income verification flow, but they may be required to manually upload a paystub to verify their income.

While all request fields are optional, providing either `employer` or `transactions_access_tokens` data will increase the chance of receiving a useful result.

This endpoint has been deprecated; new integrations should use `/credit/payroll_income/precheck` instead.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.IncomeVerificationPrecheck(new IncomeVerificationPrecheckOperationRequest
    {
        Body = new IncomeVerificationPrecheckRequest(),
    });
    // TODO: Handle 'response' of type IncomeVerificationPrecheckResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[IncomeVerificationPrecheckOperationRequest](src/ThePlaidApi/Requests/IncomeVerificationPrecheckOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[IncomeVerificationPrecheckResponse](src/ThePlaidApi/Models/IncomeVerificationPrecheckResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IncomeVerificationTaxformsGetResponse&gt; IncomeVerificationTaxformsGet(IncomeVerificationTaxformsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/income/verification/taxforms/get` returns the information collected from forms that were used to verify an end user''s income. It can be called once the status of the verification has been set to `VERIFICATION_STATUS_PROCESSING_COMPLETE`, as reported by the `INCOME: verification_status` webhook. Attempting to call the endpoint before verification has been completed will result in an error.

This endpoint has been deprecated; new integrations should use `/credit/payroll_income/get` instead.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.IncomeVerificationTaxformsGet(new IncomeVerificationTaxformsGetOperationRequest
    {
        Body = new IncomeVerificationTaxformsGetRequest(),
    });
    // TODO: Handle 'response' of type IncomeVerificationTaxformsGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[IncomeVerificationTaxformsGetOperationRequest](src/ThePlaidApi/Requests/IncomeVerificationTaxformsGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[IncomeVerificationTaxformsGetResponse](src/ThePlaidApi/Models/IncomeVerificationTaxformsGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;InstitutionsGetResponse&gt; InstitutionsGet(InstitutionsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a JSON response containing details on all financial institutions currently supported by Plaid. Because Plaid supports thousands of institutions, results are paginated.

If there is no overlap between an institution's enabled products and a client's enabled products, then the institution will be filtered out from the response. As a result, the number of institutions returned may not match the count specified in the call.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.InstitutionsGet(new InstitutionsGetOperationRequest
    {
        Body = new InstitutionsGetRequest { Count = 1, Offset = 1, CountryCodes = [CountryCode.Us] },
    });
    // TODO: Handle 'response' of type InstitutionsGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[InstitutionsGetOperationRequest](src/ThePlaidApi/Requests/InstitutionsGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[InstitutionsGetResponse](src/ThePlaidApi/Models/InstitutionsGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;InstitutionsGetByIdResponse&gt; InstitutionsGetById(InstitutionsGetByIdOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a JSON response containing details on a specified financial institution currently supported by Plaid.

Versioning note: API versions 2019-05-29 and earlier allow use of the `public_key` parameter instead of the `client_id` and `secret` to authenticate to this endpoint. The `public_key` has been deprecated; all customers are encouraged to use `client_id` and `secret` instead.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.InstitutionsGetById(new InstitutionsGetByIdOperationRequest
    {
        Body = new InstitutionsGetByIdRequest
        {
            InstitutionId = "some example string",
            CountryCodes = [CountryCode.Us],
        },
    });
    // TODO: Handle 'response' of type InstitutionsGetByIdResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[InstitutionsGetByIdOperationRequest](src/ThePlaidApi/Requests/InstitutionsGetByIdOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[InstitutionsGetByIdResponse](src/ThePlaidApi/Models/InstitutionsGetByIdResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;InstitutionsSearchResponse&gt; InstitutionsSearch(InstitutionsSearchOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a JSON response containing details for institutions that match the query parameters, up to a maximum of ten institutions per query.

Versioning note: API versions 2019-05-29 and earlier allow use of the `public_key` parameter instead of the `client_id` and `secret` parameters to authenticate to this endpoint. The `public_key` parameter has since been deprecated; all customers are encouraged to use `client_id` and `secret` instead.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.InstitutionsSearch(new InstitutionsSearchOperationRequest
    {
        Body = new InstitutionsSearchRequest { Query = "some example string", CountryCodes = [CountryCode.Us] },
    });
    // TODO: Handle 'response' of type InstitutionsSearchResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[InstitutionsSearchOperationRequest](src/ThePlaidApi/Requests/InstitutionsSearchOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[InstitutionsSearchResponse](src/ThePlaidApi/Models/InstitutionsSearchResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;InvestmentsAuthGetResponse&gt; InvestmentsAuthGet(InvestmentsAuthGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/investments/auth/get` endpoint allows developers to receive user-authorized data to facilitate the transfer of holdings

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.InvestmentsAuthGet(new InvestmentsAuthGetOperationRequest
    {
        Body = new InvestmentsAuthGetRequest { AccessToken = "some example string" },
    });
    // TODO: Handle 'response' of type InvestmentsAuthGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[InvestmentsAuthGetOperationRequest](src/ThePlaidApi/Requests/InvestmentsAuthGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[InvestmentsAuthGetResponse](src/ThePlaidApi/Models/InvestmentsAuthGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;InvestmentsHoldingsGetResponse&gt; InvestmentsHoldingsGet(InvestmentsHoldingsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/investments/holdings/get` endpoint allows developers to receive user-authorized stock position data for `investment`-type accounts.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.InvestmentsHoldingsGet(new InvestmentsHoldingsGetOperationRequest
    {
        Body = new InvestmentsHoldingsGetRequest { AccessToken = "some example string" },
    });
    // TODO: Handle 'response' of type InvestmentsHoldingsGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[InvestmentsHoldingsGetOperationRequest](src/ThePlaidApi/Requests/InvestmentsHoldingsGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[InvestmentsHoldingsGetResponse](src/ThePlaidApi/Models/InvestmentsHoldingsGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;InvestmentsRefreshResponse&gt; InvestmentsRefresh(InvestmentsRefreshOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/investments/refresh` is an optional endpoint for users of the Investments product. It initiates an on-demand extraction to fetch the newest investment holdings and transactions for an Item. This on-demand extraction takes place in addition to the periodic extractions that automatically occur one or more times per day for any Investments-enabled Item. If changes to investments are discovered after calling `/investments/refresh`, Plaid will fire webhooks: [`HOLDINGS: DEFAULT_UPDATE`](https://plaid.com/docs/api/products/investments/#holdings-default_update) if any new holdings are detected, and [`INVESTMENTS_TRANSACTIONS: DEFAULT_UPDATE`](https://plaid.com/docs/api/products/investments/#investments_transactions-default_update) if any new investment transactions are detected. This webhook will typically not fire in the Sandbox environment, due to the lack of dynamic investment transactions and holdings data. To test this webhook in Sandbox, call `/sandbox/item/fire_webhook`. Updated holdings and investment transactions can be fetched by calling `/investments/holdings/get` and `/investments/transactions/get`. Note that the `/investments/refresh` endpoint is not supported by all institutions. If called on an Item from an institution that does not support this functionality, it will return a `PRODUCT_NOT_SUPPORTED` error.

As this endpoint triggers a synchronous request for fresh data, latency may be higher than for other Plaid endpoints (typically less than 10 seconds, but occasionally up to 30 seconds or more); if you encounter errors, you may find it necessary to adjust your timeout period when making requests.

`/investments/refresh` is offered as an add-on to Investments and has a separate [fee model](https://plaid.com/docs/account/billing/#per-request-flat-fee). To request access to this endpoint, submit a [product access request](https://dashboard.plaid.com/team/products) or contact your Plaid account manager.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.InvestmentsRefresh(new InvestmentsRefreshOperationRequest
    {
        Body = new InvestmentsRefreshRequest { AccessToken = "some example string" },
    });
    // TODO: Handle 'response' of type InvestmentsRefreshResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[InvestmentsRefreshOperationRequest](src/ThePlaidApi/Requests/InvestmentsRefreshOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[InvestmentsRefreshResponse](src/ThePlaidApi/Models/InvestmentsRefreshResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;InvestmentsTransactionsGetResponse&gt; InvestmentsTransactionsGet(InvestmentsTransactionsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/investments/transactions/get` endpoint allows developers to retrieve up to 24 months of user-authorized transaction data for investment accounts.

Transactions are returned in reverse-chronological order, and the sequence of transaction ordering is stable and will not shift.

Due to the potentially large number of investment transactions associated with an Item, results are paginated. Manipulate the count and offset parameters in conjunction with the `total_investment_transactions` response body field to fetch all available investment transactions.

Note that Investments does not have a webhook to indicate when initial transaction data has loaded (unless you use the `async_update` option). Instead, if transactions data is not ready when `/investments/transactions/get` is first called, Plaid will wait for the data. For this reason, calling `/investments/transactions/get` immediately after Link may take up to one to two minutes to return.

Data returned by the asynchronous investments extraction flow (when `async_update` is set to true) may not be immediately available to `/investments/transactions/get`. To be alerted when the data is ready to be fetched, listen for the `HISTORICAL_UPDATE` webhook. If no investments history is ready when `/investments/transactions/get` is called, it will return a `PRODUCT_NOT_READY` error.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.InvestmentsTransactionsGet(new InvestmentsTransactionsGetOperationRequest
    {
        Body = new InvestmentsTransactionsGetRequest
        {
            AccessToken = "some example string",
            StartDate = DateTimeOffset.Parse("2024-01-15T00:00:00Z"),
            EndDate = DateTimeOffset.Parse("2024-01-15T00:00:00Z"),
        },
    });
    // TODO: Handle 'response' of type InvestmentsTransactionsGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[InvestmentsTransactionsGetOperationRequest](src/ThePlaidApi/Requests/InvestmentsTransactionsGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[InvestmentsTransactionsGetResponse](src/ThePlaidApi/Models/InvestmentsTransactionsGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IssuesGetResponse&gt; IssuesGet(IssuesGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve detailed information about a specific `Issue`. This endpoint returns a single `Issue` object.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.IssuesGet(new IssuesGetOperationRequest
    {
        Body = new IssuesGetRequest { IssueId = "some example string" },
    });
    // TODO: Handle 'response' of type IssuesGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[IssuesGetOperationRequest](src/ThePlaidApi/Requests/IssuesGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[IssuesGetResponse](src/ThePlaidApi/Models/IssuesGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IssuesSearchResponse&gt; IssuesSearch(IssuesSearchOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Search for an issue associated with one of the following identifiers:  `item_id`, `link_session_id` or Link session `request_id`. This endpoint returns a list of `Issue` objects, with an empty list indicating that no issues are associated with the provided identifier. At least one of the identifiers must be provided to perform the search.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.IssuesSearch(new IssuesSearchOperationRequest { Body = new IssuesSearchRequest() });
    // TODO: Handle 'response' of type IssuesSearchResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[IssuesSearchOperationRequest](src/ThePlaidApi/Requests/IssuesSearchOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[IssuesSearchResponse](src/ThePlaidApi/Models/IssuesSearchResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IssuesSubscribeResponse&gt; IssuesSubscribe(IssuesSubscribeOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Allows a user to subscribe to updates on a specific `Issue` using a POST method. Subscribers will receive webhook notifications when the issue status changes, particularly when resolved.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.IssuesSubscribe(new IssuesSubscribeOperationRequest
    {
        Body = new IssuesSubscribeRequest { IssueId = "some example string", Webhook = "some example string" },
    });
    // TODO: Handle 'response' of type IssuesSubscribeResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[IssuesSubscribeOperationRequest](src/ThePlaidApi/Requests/IssuesSubscribeOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[IssuesSubscribeResponse](src/ThePlaidApi/Models/IssuesSubscribeResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ItemAccessTokenInvalidateResponse&gt; ItemAccessTokenInvalidate(ItemAccessTokenInvalidateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

By default, the `access_token` associated with an Item does not expire and should be stored in a persistent, secure manner.

You can use the `/item/access_token/invalidate` endpoint to rotate the `access_token` associated with an Item. The endpoint returns a new `access_token` and immediately invalidates the previous `access_token`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ItemAccessTokenInvalidate(new ItemAccessTokenInvalidateOperationRequest
    {
        Body = new ItemAccessTokenInvalidateRequest { AccessToken = "some example string" },
    });
    // TODO: Handle 'response' of type ItemAccessTokenInvalidateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ItemAccessTokenInvalidateOperationRequest](src/ThePlaidApi/Requests/ItemAccessTokenInvalidateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ItemAccessTokenInvalidateResponse](src/ThePlaidApi/Models/ItemAccessTokenInvalidateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ItemActivityListResponse&gt; ItemActivityList(ItemActivityListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List a historical log of user consent events

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ItemActivityList(new ItemActivityListOperationRequest
    {
        Body = new ItemActivityListRequest(),
    });
    // TODO: Handle 'response' of type ItemActivityListResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ItemActivityListOperationRequest](src/ThePlaidApi/Requests/ItemActivityListOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ItemActivityListResponse](src/ThePlaidApi/Models/ItemActivityListResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ItemApplicationListResponse&gt; ItemApplicationList(ItemApplicationListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List a user's connected applications

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ItemApplicationList(new ItemApplicationListOperationRequest
    {
        Body = new ItemApplicationListRequest(),
    });
    // TODO: Handle 'response' of type ItemApplicationListResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ItemApplicationListOperationRequest](src/ThePlaidApi/Requests/ItemApplicationListOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ItemApplicationListResponse](src/ThePlaidApi/Models/ItemApplicationListResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ItemApplicationScopesUpdateResponse&gt; ItemApplicationScopesUpdate(ItemApplicationScopesUpdateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Enable consumers to update product access on selected accounts for an application.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ItemApplicationScopesUpdate(new ItemApplicationScopesUpdateOperationRequest
    {
        Body = new ItemApplicationScopesUpdateRequest
        {
            AccessToken = "some example string",
            ApplicationId = "some example string",
            Scopes = new Scopes(),
            Context = ScopesContext.Enrollment,
        },
    });
    // TODO: Handle 'response' of type ItemApplicationScopesUpdateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ItemApplicationScopesUpdateOperationRequest](src/ThePlaidApi/Requests/ItemApplicationScopesUpdateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ItemApplicationScopesUpdateResponse](src/ThePlaidApi/Models/ItemApplicationScopesUpdateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ItemApplicationUnlinkResponse&gt; ItemApplicationUnlink(ItemApplicationUnlinkOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Unlink a user's connected application. On an unlink request, Plaid will immediately revoke the Application's access to the User's data.  The User will have to redo the OAuth authentication process in order to restore functionality.

This endpoint only removes ongoing data access permissions, therefore the User will need to reach out to the Application itself in order to disable and delete their account and delete any data that the Application already received (if the Application does not do so by default).

This endpoint should be called in real time as the User is unlinking an Application, and should not be batched in order to ensure that the change is reflected as soon as possible.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ItemApplicationUnlink(new ItemApplicationUnlinkOperationRequest
    {
        Body = new ItemApplicationUnlinkRequest
        {
            AccessToken = "some example string",
            ApplicationId = "some example string",
        },
    });
    // TODO: Handle 'response' of type ItemApplicationUnlinkResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ItemApplicationUnlinkOperationRequest](src/ThePlaidApi/Requests/ItemApplicationUnlinkOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ItemApplicationUnlinkResponse](src/ThePlaidApi/Models/ItemApplicationUnlinkResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ItemPublicTokenCreateResponse&gt; ItemCreatePublicToken(ItemCreatePublicTokenRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Note: As of July 2020, the `/item/public_token/create` endpoint is deprecated. Instead, use `/link/token/create` with an `access_token` to create a Link token for use with [update mode](https://plaid.com/docs/link/update-mode).

If you need your user to take action to restore or resolve an error associated with an Item, generate a public token with the `/item/public_token/create` endpoint and then initialize Link with that `public_token`.

A `public_token` is one-time use and expires after 30 minutes. You use a `public_token` to initialize Link in [update mode](https://plaid.com/docs/link/update-mode) for a particular Item. You can generate a `public_token` for an Item even if you did not use Link to create the Item originally.

The `/item/public_token/create` endpoint is **not** used to create your initial `public_token`. If you have not already received an `access_token` for a specific Item, use Link to obtain your `public_token` instead. See the [Quickstart](https://plaid.com/docs/quickstart) for more information.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ItemCreatePublicToken(new ItemCreatePublicTokenRequest
    {
        Body = new ItemPublicTokenCreateRequest { AccessToken = "some example string" },
    });
    // TODO: Handle 'response' of type ItemPublicTokenCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ItemCreatePublicTokenRequest](src/ThePlaidApi/Requests/ItemCreatePublicTokenRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ItemPublicTokenCreateResponse](src/ThePlaidApi/Models/ItemPublicTokenCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ItemGetResponse&gt; ItemGet(ItemGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns information about the status of an Item.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ItemGet(new ItemGetOperationRequest
    {
        Body = new ItemGetRequest { AccessToken = "some example string" },
    });
    // TODO: Handle 'response' of type ItemGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ItemGetOperationRequest](src/ThePlaidApi/Requests/ItemGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ItemGetResponse](src/ThePlaidApi/Models/ItemGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ItemImportResponse&gt; ItemImport(ItemImportOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/item/import` creates an Item via your Plaid Exchange Integration and returns an `access_token`. As part of an `/item/import` request, you will include a User ID (`user_auth.user_id`) and Authentication Token (`user_auth.auth_token`) that enable data aggregation through your Plaid Exchange API endpoints. These authentication principals are to be chosen by you.

Upon creating an Item via `/item/import`, Plaid will automatically begin an extraction of that Item through the Plaid Exchange infrastructure you have already integrated.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ItemImport(new ItemImportOperationRequest
    {
        Body = new ItemImportRequest
        {
            Products = [Products.Assets],
            UserAuth = new ItemImportRequestUserAuth
            {
                UserId = "some example string",
                AuthToken = "some example string",
            },
        },
    });
    // TODO: Handle 'response' of type ItemImportResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ItemImportOperationRequest](src/ThePlaidApi/Requests/ItemImportOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ItemImportResponse](src/ThePlaidApi/Models/ItemImportResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ItemProductsTerminateResponse&gt; ItemProductsTerminate(ItemProductsTerminateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/item/products/terminate` endpoint allows you to terminate an Item. Once terminated, the `access_token` associated with the Item is no longer valid, billing for the Item's products is ended, and relevant webhooks are fired.

`/item/products/terminate` is the recommended way to offboard users or disconnect accounts linked via Plaid.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ItemProductsTerminate(new ItemProductsTerminateOperationRequest
    {
        Body = new ItemProductsTerminateRequest
        {
            AccessToken = "some example string",
            ReasonCode = ProductsTerminateReasonCode.FraudFirstParty,
        },
    });
    // TODO: Handle 'response' of type ItemProductsTerminateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ItemProductsTerminateOperationRequest](src/ThePlaidApi/Requests/ItemProductsTerminateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ItemProductsTerminateResponse](src/ThePlaidApi/Models/ItemProductsTerminateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ItemPublicTokenExchangeResponse&gt; ItemPublicTokenExchange(ItemPublicTokenExchangeOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Exchange a Link `public_token` for an API `access_token`. Link hands off the `public_token` client-side via the `onSuccess` callback once a user has successfully created an Item. The `public_token` is ephemeral and expires after 30 minutes. An `access_token` does not expire, but can be revoked by calling `/item/remove`.

The response also includes an `item_id` that should be stored with the `access_token`. The `item_id` is used to identify an Item in a webhook. The `item_id` can also be retrieved by making an `/item/get` request.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ItemPublicTokenExchange(new ItemPublicTokenExchangeOperationRequest
    {
        Body = new ItemPublicTokenExchangeRequest { PublicToken = "some example string" },
    });
    // TODO: Handle 'response' of type ItemPublicTokenExchangeResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ItemPublicTokenExchangeOperationRequest](src/ThePlaidApi/Requests/ItemPublicTokenExchangeOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ItemPublicTokenExchangeResponse](src/ThePlaidApi/Models/ItemPublicTokenExchangeResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ItemRemoveResponse&gt; ItemRemove(ItemRemoveOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/item/remove` endpoint allows you to remove an Item. Once removed, the `access_token`, as well as any processor tokens or bank account tokens associated with the Item, is no longer valid and cannot be used to access any data that was associated with the Item.

Calling `/item/remove` is a recommended best practice when offboarding users or if a user chooses to disconnect an account linked via Plaid. For subscription products, such as Transactions, Liabilities, and Investments, calling `/item/remove` is required to end subscription billing for the Item, unless the end user revoked permission (e.g. via [https://my.plaid.com/](https://my.plaid.com/)). For more details, see [Subscription fee model](https://plaid.com/docs/account/billing/#subscription-fee).

On a Trial plan, calling `/item/remove` does not impact the number of remaining Trial Items (bank connections) you have available.

Removing an Item does not affect any Asset Reports or Audit Copies you have already created, which will remain accessible until you remove access to them specifically using the `/asset_report/remove` endpoint.

Also note that for certain OAuth-based institutions, an Item removed via `/item/remove` may still show as an active connection in the institution's OAuth permission manager.

API versions 2019-05-29 and earlier return a `removed` boolean as part of the response.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ItemRemove(new ItemRemoveOperationRequest
    {
        Body = new ItemRemoveRequest { AccessToken = "some example string" },
    });
    // TODO: Handle 'response' of type ItemRemoveResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ItemRemoveOperationRequest](src/ThePlaidApi/Requests/ItemRemoveOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ItemRemoveResponse](src/ThePlaidApi/Models/ItemRemoveResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ItemWebhookUpdateResponse&gt; ItemWebhookUpdate(ItemWebhookUpdateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The POST `/item/webhook/update` allows you to update the webhook URL associated with an Item. This request triggers a [`WEBHOOK_UPDATE_ACKNOWLEDGED`](https://plaid.com/docs/api/items/#webhook_update_acknowledged) webhook to the newly specified webhook URL.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ItemWebhookUpdate(new ItemWebhookUpdateOperationRequest
    {
        Body = new ItemWebhookUpdateRequest { AccessToken = "some example string" },
    });
    // TODO: Handle 'response' of type ItemWebhookUpdateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ItemWebhookUpdateOperationRequest](src/ThePlaidApi/Requests/ItemWebhookUpdateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ItemWebhookUpdateResponse](src/ThePlaidApi/Models/ItemWebhookUpdateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;LiabilitiesGetResponse&gt; LiabilitiesGet(LiabilitiesGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/liabilities/get` endpoint returns various details about an Item with loan or credit accounts. Liabilities data is available primarily for US financial institutions, with some limited coverage of Canadian institutions. Currently supported account types are account type `credit` with account subtype `credit card` or `paypal`, and account type `loan` with account subtype `student` or `mortgage`. To limit accounts listed in Link to types and subtypes supported by Liabilities, you can use the `account_filters` parameter when [creating a Link token](https://plaid.com/docs/api/link/#linktokencreate).

The types of information returned by Liabilities can include balances and due dates, loan terms, and account details such as original loan amount and guarantor. Data is refreshed approximately once per day; the latest data can be retrieved by calling `/liabilities/get`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LiabilitiesGet(new LiabilitiesGetOperationRequest
    {
        Body = new LiabilitiesGetRequest { AccessToken = "some example string" },
    });
    // TODO: Handle 'response' of type LiabilitiesGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[LiabilitiesGetOperationRequest](src/ThePlaidApi/Requests/LiabilitiesGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[LiabilitiesGetResponse](src/ThePlaidApi/Models/LiabilitiesGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;LinkDeliveryCreateResponse&gt; LinkDeliveryCreate(LinkDeliveryCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/link_delivery/create` endpoint to create a Hosted Link session.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LinkDeliveryCreate(new LinkDeliveryCreateOperationRequest
    {
        Body = new LinkDeliveryCreateRequest { LinkToken = "some example string" },
    });
    // TODO: Handle 'response' of type LinkDeliveryCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[LinkDeliveryCreateOperationRequest](src/ThePlaidApi/Requests/LinkDeliveryCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[LinkDeliveryCreateResponse](src/ThePlaidApi/Models/LinkDeliveryCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;LinkDeliveryGetResponse&gt; LinkDeliveryGet(LinkDeliveryGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/link_delivery/get` endpoint to get the status of a Hosted Link session.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LinkDeliveryGet(new LinkDeliveryGetOperationRequest
    {
        Body = new LinkDeliveryGetRequest { LinkDeliverySessionId = "some example string" },
    });
    // TODO: Handle 'response' of type LinkDeliveryGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[LinkDeliveryGetOperationRequest](src/ThePlaidApi/Requests/LinkDeliveryGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[LinkDeliveryGetResponse](src/ThePlaidApi/Models/LinkDeliveryGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;LinkOAuthCorrelationIdExchangeResponse&gt; LinkOauthCorrelationIdExchange(LinkOauthCorrelationIdExchangeOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Exchange an OAuth `link_correlation_id` for the corresponding `link_token`. The `link_correlation_id` is only available for `payment_initiation` products and is provided to the client via the OAuth `redirect_uri` as a query parameter.
The `link_correlation_id` is ephemeral and expires in a brief period, after which it can no longer be exchanged for the `link_token`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LinkOauthCorrelationIdExchange(new LinkOauthCorrelationIdExchangeOperationRequest
    {
        Body = new LinkOAuthCorrelationIdExchangeRequest { LinkCorrelationId = "some example string" },
    });
    // TODO: Handle 'response' of type LinkOAuthCorrelationIdExchangeResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[LinkOauthCorrelationIdExchangeOperationRequest](src/ThePlaidApi/Requests/LinkOauthCorrelationIdExchangeOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[LinkOAuthCorrelationIdExchangeResponse](src/ThePlaidApi/Models/LinkOAuthCorrelationIdExchangeResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;LinkTokenCreateResponse&gt; LinkTokenCreate(LinkTokenCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/link/token/create` endpoint creates a `link_token`, which is required as a parameter when initializing Link. Once Link has been initialized, it returns a `public_token`. For most Plaid products, the `public_token` is saved and exchanged for an `access_token` via `/item/public_token/exchange` as part of the main Link flow. For more details, see the [Link flow overview](https://plaid.com/docs/link/#link-flow-overview).

A `link_token` generated by `/link/token/create` is also used to initialize other Link flows, such as the [update mode](https://plaid.com/docs/link/update-mode) flow for tokens with expired credentials, or the Identity Verification flow.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LinkTokenCreate(new LinkTokenCreateOperationRequest
    {
        Body = new LinkTokenCreateRequest
        {
            ClientName = "some example string",
            Language = "some example string",
            CountryCodes = [CountryCode.Us],
        },
    });
    // TODO: Handle 'response' of type LinkTokenCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[LinkTokenCreateOperationRequest](src/ThePlaidApi/Requests/LinkTokenCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[LinkTokenCreateResponse](src/ThePlaidApi/Models/LinkTokenCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;LinkTokenGetResponse&gt; LinkTokenGet(LinkTokenGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/link/token/get` endpoint gets information about a Link session, including all callbacks fired during the session along with their metadata, including the public token. This endpoint is used with Link flows that don't provide a public token via frontend callbacks, such as the [Hosted Link flow](https://plaid.com/docs/link/hosted-link/) and the [Multi-Item Link flow](https://plaid.com/docs/link/multi-item-link/). It also can be useful for debugging purposes.

By default, this endpoint will only return complete event data for Hosted Link sessions. To use `/link/token/get` to retrieve event data for non-Hosted-Link sessions, contact your account manager to request that your account be enabled for Link events. If you do not have an account manager, you can submit this request via a support ticket. Enablement for Link events will also cause you to receive additional webhooks related to Link events, such as the `SESSION_FINISHED` and `EVENTS` webhook.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.LinkTokenGet(new LinkTokenGetOperationRequest
    {
        Body = new LinkTokenGetRequest { LinkToken = "some example string" },
    });
    // TODO: Handle 'response' of type LinkTokenGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[LinkTokenGetOperationRequest](src/ThePlaidApi/Requests/LinkTokenGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[LinkTokenGetResponse](src/ThePlaidApi/Models/LinkTokenGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;NetworkStatusGetResponse&gt; NetworkStatusGet(NetworkStatusGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/network/status/get` endpoint can be used to check whether Plaid has a matching profile for the user.
This is useful for determining if a user is eligible for a streamlined experience, such as Layer. To access this endpoint, contact your Plaid account manager.

Note: it is strongly recommended to check for Layer eligibility in the frontend. `/network/status/get` should only be used for checking Layer eligibility if a frontend check is not possible for your use case.
For instructions on performing a frontend eligibility check, see the [Layer documentation](https://plaid.com/docs/layer/#integration-overview).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.NetworkStatusGet(new NetworkStatusGetOperationRequest
    {
        Body = new NetworkStatusGetRequest { User = new NetworkStatusGetUser { PhoneNumber = "some example string" } },
    });
    // TODO: Handle 'response' of type NetworkStatusGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[NetworkStatusGetOperationRequest](src/ThePlaidApi/Requests/NetworkStatusGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[NetworkStatusGetResponse](src/ThePlaidApi/Models/NetworkStatusGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;OAuthIntrospectResponse&gt; OauthIntrospect(OauthIntrospectOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/oauth/introspect` returns metadata about an access token or refresh token.

Note: This endpoint supports `Content-Type: application/x-www-form-urlencoded` as well as JSON. The fields for the form are equivalent to the fields for JSON and conform to the OAuth 2.0 specification.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OauthIntrospect(new OauthIntrospectOperationRequest
    {
        Body = new OAuthIntrospectRequest { Token = "some example string" },
    });
    // TODO: Handle 'response' of type OAuthIntrospectResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[OauthIntrospectOperationRequest](src/ThePlaidApi/Requests/OauthIntrospectOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OAuthIntrospectResponse](src/ThePlaidApi/Models/OAuthIntrospectResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;OAuthRevokeResponse&gt; OauthRevoke(OauthRevokeOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/oauth/revoke` revokes an access or refresh token, preventing any further use. If a refresh token is revoked, all access and refresh tokens derived from it are also revoked, including exchanged tokens.

Note: This endpoint supports `Content-Type: application/x-www-form-urlencoded` as well as JSON. The fields for the form are equivalent to the fields for JSON and conform to the OAuth 2.0 specification.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OauthRevoke(new OauthRevokeOperationRequest
    {
        Body = new OAuthRevokeRequest { Token = "some example string" },
    });
    // TODO: Handle 'response' of type OAuthRevokeResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[OauthRevokeOperationRequest](src/ThePlaidApi/Requests/OauthRevokeOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OAuthRevokeResponse](src/ThePlaidApi/Models/OAuthRevokeResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;OAuthTokenResponse&gt; OauthToken(OauthTokenOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/oauth/token` issues an access token and refresh token depending on the `grant_type` provided. This endpoint supports `Content-Type: application/x-www-form-urlencoded` as well as JSON. The fields for the form are equivalent to the fields for JSON and conform to the OAuth 2.0 specification.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OauthToken(new OauthTokenOperationRequest
    {
        Body = new OAuthTokenRequest { GrantType = OAuthGrantType.RefreshToken },
    });
    // TODO: Handle 'response' of type OAuthTokenResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[OauthTokenOperationRequest](src/ThePlaidApi/Requests/OauthTokenOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OAuthTokenResponse](src/ThePlaidApi/Models/OAuthTokenResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PartnerCustomerCreateResponse&gt; PartnerCustomerCreate(PartnerCustomerCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/partner/customer/create` endpoint is used by reseller partners to create end customers. To create end customers, it should be called in the Production environment only, even when creating Sandbox API keys. If called in the Sandbox environment, it will return a sample response, but no customer will be created and the API keys will not be valid.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PartnerCustomerCreate(new PartnerCustomerCreateOperationRequest
    {
        Body = new PartnerCustomerCreateRequest
        {
            ClientId = "7f57eb3d2a9j6480121fx361",
            Secret = "79g03eoofwl8240v776r2h667442119",
            CompanyName = "Plaid",
            IsDiligenceAttested = true,
            Products = [Products.Auth, Products.Identity],
            CreateLinkCustomization = true,
            LegalEntityName = "Plaid",
            Website = "plaid.com",
            ApplicationName = "Plaid",
            TechnicalContact = new PartnerEndCustomerTechnicalContact
            {
                GivenName = "Alice",
                FamilyName = "Smith",
                Email = "alice.smith@example.com",
            },
            BillingContact = new PartnerEndCustomerBillingContact
            {
                GivenName = "Bob",
                FamilyName = "Jones",
                Email = "bob.jones@example.com",
            },
            CustomerSupportInfo = new PartnerEndCustomerCustomerSupportInfo
            {
                Email = "support@example.com",
                PhoneNumber = "1234567890",
                ContactUrl = "example.com/contact",
                LinkUpdateUrl = "example.com/update",
            },
            Address = new PartnerEndCustomerAddress
            {
                City = "New York",
                Street = "123 Main St",
                Region = "NY",
                PostalCode = "12345",
                CountryCode = "US",
            },
            IsBankAddendumCompleted = true,
            RedirectUris = ["http://localhost/oauth.html", "https://www.example.com/oauth.html"],
        },
    });
    // TODO: Handle 'response' of type PartnerCustomerCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PartnerCustomerCreateOperationRequest](src/ThePlaidApi/Requests/PartnerCustomerCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PartnerCustomerCreateResponse](src/ThePlaidApi/Models/PartnerCustomerCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PartnerCustomerEnableResponse&gt; PartnerCustomerEnable(PartnerCustomerEnableOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/partner/customer/enable` endpoint is used by reseller partners to enable an end customer in the full Production environment.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PartnerCustomerEnable(new PartnerCustomerEnableOperationRequest
    {
        Body = new PartnerCustomerEnableRequest
        {
            ClientId = "7f57eb3d2a9j6480121fx361",
            Secret = "79g03eoofwl8240v776r2h667442119",
            EndCustomerClientId = "7f57eb3d2a9j6480121fx361",
        },
    });
    // TODO: Handle 'response' of type PartnerCustomerEnableResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PartnerCustomerEnableOperationRequest](src/ThePlaidApi/Requests/PartnerCustomerEnableOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PartnerCustomerEnableResponse](src/ThePlaidApi/Models/PartnerCustomerEnableResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PartnerCustomerGetResponse&gt; PartnerCustomerGet(PartnerCustomerGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/partner/customer/get` endpoint is used by reseller partners to retrieve data about a single end customer.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PartnerCustomerGet(new PartnerCustomerGetOperationRequest
    {
        Body = new PartnerCustomerGetRequest
        {
            ClientId = "7f57eb3d2a9j6480121fx361",
            Secret = "79g03eoofwl8240v776r2h667442119",
            EndCustomerClientId = "7f57eb3d2a9j6480121fx361",
        },
    });
    // TODO: Handle 'response' of type PartnerCustomerGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PartnerCustomerGetOperationRequest](src/ThePlaidApi/Requests/PartnerCustomerGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PartnerCustomerGetResponse](src/ThePlaidApi/Models/PartnerCustomerGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PartnerCustomerOAuthInstitutionsGetResponse&gt; PartnerCustomerOauthInstitutionsGet(PartnerCustomerOauthInstitutionsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/partner/customer/oauth_institutions/get` endpoint is used by reseller partners to retrieve OAuth-institution registration information about a single end customer. To learn how to set up a webhook to listen to status update events, visit the [reseller documentation](https://plaid.com/docs/account/resellers/#enabling-end-customers).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PartnerCustomerOauthInstitutionsGet(
        new PartnerCustomerOauthInstitutionsGetOperationRequest
        {
            Body = new PartnerCustomerOAuthInstitutionsGetRequest
            {
                ClientId = "7f57eb3d2a9j6480121fx361",
                Secret = "79g03eoofwl8240v776r2h667442119",
                EndCustomerClientId = "7f57eb3d2a9j6480121fx361",
            },
        });
    // TODO: Handle 'response' of type PartnerCustomerOAuthInstitutionsGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PartnerCustomerOauthInstitutionsGetOperationRequest](src/ThePlaidApi/Requests/PartnerCustomerOauthInstitutionsGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PartnerCustomerOAuthInstitutionsGetResponse](src/ThePlaidApi/Models/PartnerCustomerOAuthInstitutionsGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PartnerCustomerRemoveResponse&gt; PartnerCustomerRemove(PartnerCustomerRemoveOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/partner/customer/remove` endpoint is used by reseller partners to remove an end customer. Removing an end customer will remove it from view in the Plaid Dashboard and deactivate its API keys. This endpoint can only be used to remove an end customer that has not yet been enabled in full Production.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PartnerCustomerRemove(new PartnerCustomerRemoveOperationRequest
    {
        Body = new PartnerCustomerRemoveRequest
        {
            ClientId = "7f57eb3d2a9j6480121fx361",
            Secret = "79g03eoofwl8240v776r2h667442119",
            EndCustomerClientId = "7f57eb3d2a9j6480121fx361",
        },
    });
    // TODO: Handle 'response' of type PartnerCustomerRemoveResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PartnerCustomerRemoveOperationRequest](src/ThePlaidApi/Requests/PartnerCustomerRemoveOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PartnerCustomerRemoveResponse](src/ThePlaidApi/Models/PartnerCustomerRemoveResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentInitiationConsentCreateResponse&gt; PaymentInitiationConsentCreate(PaymentInitiationConsentCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/payment_initiation/consent/create` endpoint is used to create a payment consent, which can be used to initiate payments on behalf of the user. Payment consents are created with `UNAUTHORISED` status by default and must be authorised by the user before payments can be initiated.

Consents can be limited in time and scope, and have constraints that describe limitations for payments.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentInitiationConsentCreate(new PaymentInitiationConsentCreateOperationRequest
    {
        Body = new PaymentInitiationConsentCreateRequest
        {
            RecipientId = "some example string",
            Reference = "some example string",
            Constraints = new PaymentInitiationConsentConstraints
            {
                MaxPaymentAmount = new PaymentAmount { Currency = PaymentAmountCurrency.Gbp, Value = 1.5d },
                PeriodicAmounts = [
                    new PaymentConsentPeriodicAmount
                    {
                        Amount = new PaymentAmount { Currency = currency, Value = value },
                        Interval = PaymentConsentPeriodicInterval.Day,
                        Alignment = PaymentConsentPeriodicAlignment.Calendar,
                    },
                ],
            },
        },
    });
    // TODO: Handle 'response' of type PaymentInitiationConsentCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PaymentInitiationConsentCreateOperationRequest](src/ThePlaidApi/Requests/PaymentInitiationConsentCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentInitiationConsentCreateResponse](src/ThePlaidApi/Models/PaymentInitiationConsentCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentInitiationConsentGetResponse&gt; PaymentInitiationConsentGet(PaymentInitiationConsentGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/payment_initiation/consent/get` endpoint can be used to check the status of a payment consent, as well as to receive basic information such as recipient and constraints.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentInitiationConsentGet(new PaymentInitiationConsentGetOperationRequest
    {
        Body = new PaymentInitiationConsentGetRequest { ConsentId = "some example string" },
    });
    // TODO: Handle 'response' of type PaymentInitiationConsentGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PaymentInitiationConsentGetOperationRequest](src/ThePlaidApi/Requests/PaymentInitiationConsentGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentInitiationConsentGetResponse](src/ThePlaidApi/Models/PaymentInitiationConsentGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentInitiationConsentPaymentExecuteResponse&gt; PaymentInitiationConsentPaymentExecute(PaymentInitiationConsentPaymentExecuteOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/payment_initiation/consent/payment/execute` endpoint can be used to execute payments using payment consent.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentInitiationConsentPaymentExecute(
        new PaymentInitiationConsentPaymentExecuteOperationRequest
        {
            Body = new PaymentInitiationConsentPaymentExecuteRequest
            {
                ConsentId = "some example string",
                Amount = new PaymentAmount { Currency = PaymentAmountCurrency.Gbp, Value = 1.5d },
                IdempotencyKey = "some example string",
            },
        });
    // TODO: Handle 'response' of type PaymentInitiationConsentPaymentExecuteResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PaymentInitiationConsentPaymentExecuteOperationRequest](src/ThePlaidApi/Requests/PaymentInitiationConsentPaymentExecuteOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentInitiationConsentPaymentExecuteResponse](src/ThePlaidApi/Models/PaymentInitiationConsentPaymentExecuteResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentInitiationConsentRevokeResponse&gt; PaymentInitiationConsentRevoke(PaymentInitiationConsentRevokeOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/payment_initiation/consent/revoke` endpoint can be used to revoke the payment consent. Once the consent is revoked, it is not possible to initiate payments using it.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentInitiationConsentRevoke(new PaymentInitiationConsentRevokeOperationRequest
    {
        Body = new PaymentInitiationConsentRevokeRequest { ConsentId = "some example string" },
    });
    // TODO: Handle 'response' of type PaymentInitiationConsentRevokeResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PaymentInitiationConsentRevokeOperationRequest](src/ThePlaidApi/Requests/PaymentInitiationConsentRevokeOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentInitiationConsentRevokeResponse](src/ThePlaidApi/Models/PaymentInitiationConsentRevokeResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentInitiationPaymentCreateResponse&gt; PaymentInitiationPaymentCreate(PaymentInitiationPaymentCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

After creating a payment recipient, you can use the `/payment_initiation/payment/create` endpoint to create a payment to that recipient.  Payments can be one-time or standing order (recurring) and can be denominated in EUR, GBP, or another chosen [currency](https://plaid.com/docs/api/products/payment-initiation/#payment_initiation-payment-create-request-amount-currency).  If making domestic GBP-denominated payments, your recipient must have been created with Bacs numbers. In general, EUR-denominated payments will be sent via SEPA Credit Transfer, GBP-denominated payments will be sent via the Faster Payments network and for non-Eurozone markets typically via the local payment scheme, but the payment network used will be determined by the institution. Payments sent via Faster Payments will typically arrive immediately, while payments sent via SEPA Credit Transfer or other local payment schemes will typically arrive in one business day.

Standing orders (recurring payments) must be denominated in GBP and can only be sent to recipients in the UK. Once created, standing order payments cannot be modified or canceled via the API. An end user can cancel or modify a standing order directly on their banking application or website, or by contacting the bank. Standing orders will follow the payment rules of the underlying rails (Faster Payments in UK). Payments can be sent Monday to Friday, excluding bank holidays. If the pre-arranged date falls on a weekend or bank holiday, the payment is made on the next working day. It is not possible to guarantee the exact time the payment will reach the recipient's account, although at least 90% of standing order payments are sent by 6am.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentInitiationPaymentCreate(new PaymentInitiationPaymentCreateOperationRequest
    {
        Body = new PaymentInitiationPaymentCreateRequest
        {
            RecipientId = "some example string",
            Reference = "some example string",
            Amount = new PaymentAmount { Currency = PaymentAmountCurrency.Gbp, Value = 1.5d },
        },
    });
    // TODO: Handle 'response' of type PaymentInitiationPaymentCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PaymentInitiationPaymentCreateOperationRequest](src/ThePlaidApi/Requests/PaymentInitiationPaymentCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentInitiationPaymentCreateResponse](src/ThePlaidApi/Models/PaymentInitiationPaymentCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentInitiationPaymentGetResponse&gt; PaymentInitiationPaymentGet(PaymentInitiationPaymentGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/payment_initiation/payment/get` endpoint can be used to check the status of a payment, as well as to receive basic information such as recipient and payment amount. In the case of standing orders, the `/payment_initiation/payment/get` endpoint will provide information about the status of the overall standing order itself; the API cannot be used to retrieve payment status for individual payments within a standing order.

Polling for status updates in Production is highly discouraged. Repeatedly calling `/payment_initiation/payment/get` to check a payment's status is unreliable and may trigger API rate limits. Only the `payment_status_update` webhook should be used to receive real-time status updates in Production.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentInitiationPaymentGet(new PaymentInitiationPaymentGetOperationRequest
    {
        Body = new PaymentInitiationPaymentGetRequest { PaymentId = "some example string" },
    });
    // TODO: Handle 'response' of type PaymentInitiationPaymentGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PaymentInitiationPaymentGetOperationRequest](src/ThePlaidApi/Requests/PaymentInitiationPaymentGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentInitiationPaymentGetResponse](src/ThePlaidApi/Models/PaymentInitiationPaymentGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentInitiationPaymentListResponse&gt; PaymentInitiationPaymentList(PaymentInitiationPaymentListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/payment_initiation/payment/list` endpoint can be used to retrieve all created payments. By default, the 10 most recent payments are returned. You can request more payments and paginate through the results using the optional `count` and `cursor` parameters.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentInitiationPaymentList(new PaymentInitiationPaymentListOperationRequest
    {
        Body = new PaymentInitiationPaymentListRequest(),
    });
    // TODO: Handle 'response' of type PaymentInitiationPaymentListResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PaymentInitiationPaymentListOperationRequest](src/ThePlaidApi/Requests/PaymentInitiationPaymentListOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentInitiationPaymentListResponse](src/ThePlaidApi/Models/PaymentInitiationPaymentListResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentInitiationPaymentReverseResponse&gt; PaymentInitiationPaymentReverse(PaymentInitiationPaymentReverseOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Reverse a settled payment from a Plaid virtual account.

The original payment must be in a settled state to be refunded.
To refund partially, specify the amount as part of the request.
If the amount is not specified, the refund amount will be equal to all
of the remaining payment amount that has not been refunded yet.

The refund will go back to the source account that initiated the payment.
The original payment must have been initiated to a Plaid virtual account
so that this account can be used to initiate the refund.

Providing counterparty information such as date of birth and address increases
the likelihood of refund being successful without human intervention.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentInitiationPaymentReverse(new PaymentInitiationPaymentReverseOperationRequest
    {
        Body = new PaymentInitiationPaymentReverseRequest
        {
            PaymentId = "some example string",
            IdempotencyKey = "some example string",
            Reference = "some example string",
        },
    });
    // TODO: Handle 'response' of type PaymentInitiationPaymentReverseResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PaymentInitiationPaymentReverseOperationRequest](src/ThePlaidApi/Requests/PaymentInitiationPaymentReverseOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentInitiationPaymentReverseResponse](src/ThePlaidApi/Models/PaymentInitiationPaymentReverseResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentInitiationRecipientCreateResponse&gt; PaymentInitiationRecipientCreate(PaymentInitiationRecipientCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a payment recipient for payment initiation.  The recipient must be in Europe, within a country that is a member of the Single Euro Payments Area (SEPA) or a non-Eurozone country [supported](https://support.plaid.com/hc/en-us/articles/27895826947735-What-Plaid-products-are-supported-in-each-country-and-region) by Plaid. For a standing order (recurring) payment, the recipient must be in the UK.

It is recommended to use `bacs` in the UK and `iban` in EU.

The endpoint is idempotent: if a developer has already made a request with the same payment details, Plaid will return the same `recipient_id`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentInitiationRecipientCreate(new PaymentInitiationRecipientCreateOperationRequest
    {
        Body = new PaymentInitiationRecipientCreateRequest { Name = "some example string" },
    });
    // TODO: Handle 'response' of type PaymentInitiationRecipientCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PaymentInitiationRecipientCreateOperationRequest](src/ThePlaidApi/Requests/PaymentInitiationRecipientCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentInitiationRecipientCreateResponse](src/ThePlaidApi/Models/PaymentInitiationRecipientCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentInitiationRecipientGetResponse&gt; PaymentInitiationRecipientGet(PaymentInitiationRecipientGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get details about a payment recipient you have previously created.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentInitiationRecipientGet(new PaymentInitiationRecipientGetOperationRequest
    {
        Body = new PaymentInitiationRecipientGetRequest { RecipientId = "some example string" },
    });
    // TODO: Handle 'response' of type PaymentInitiationRecipientGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PaymentInitiationRecipientGetOperationRequest](src/ThePlaidApi/Requests/PaymentInitiationRecipientGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentInitiationRecipientGetResponse](src/ThePlaidApi/Models/PaymentInitiationRecipientGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentInitiationRecipientListResponse&gt; PaymentInitiationRecipientList(PaymentInitiationRecipientListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/payment_initiation/recipient/list` endpoint lists the payment recipients that you have previously created.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentInitiationRecipientList(new PaymentInitiationRecipientListOperationRequest
    {
        Body = new PaymentInitiationRecipientListRequest(),
    });
    // TODO: Handle 'response' of type PaymentInitiationRecipientListResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PaymentInitiationRecipientListOperationRequest](src/ThePlaidApi/Requests/PaymentInitiationRecipientListOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentInitiationRecipientListResponse](src/ThePlaidApi/Models/PaymentInitiationRecipientListResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentProfileCreateResponse&gt; PaymentProfileCreate(PaymentProfileCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use `/payment_profile/create` endpoint to create a new payment profile.
To initiate the account linking experience, call `/link/token/create` and provide the `payment_profile_token` in the `transfer.payment_profile_token` field.
You can then use the `payment_profile_token` when creating transfers using `/transfer/authorization/create` and `/transfer/create`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentProfileCreate(new PaymentProfileCreateOperationRequest
    {
        Body = new PaymentProfileCreateRequest(),
    });
    // TODO: Handle 'response' of type PaymentProfileCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PaymentProfileCreateOperationRequest](src/ThePlaidApi/Requests/PaymentProfileCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentProfileCreateResponse](src/ThePlaidApi/Models/PaymentProfileCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentProfileGetResponse&gt; PaymentProfileGet(PaymentProfileGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use `/payment_profile/get` endpoint to get the status of a given Payment Profile.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentProfileGet(new PaymentProfileGetOperationRequest
    {
        Body = new PaymentProfileGetRequest { PaymentProfileToken = "some example string" },
    });
    // TODO: Handle 'response' of type PaymentProfileGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PaymentProfileGetOperationRequest](src/ThePlaidApi/Requests/PaymentProfileGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentProfileGetResponse](src/ThePlaidApi/Models/PaymentProfileGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentProfileRemoveResponse&gt; PaymentProfileRemove(PaymentProfileRemoveOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/payment_profile/remove` endpoint to remove a given Payment Profile. Once it's removed, it can no longer be used to create transfers.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PaymentProfileRemove(new PaymentProfileRemoveOperationRequest
    {
        Body = new PaymentProfileRemoveRequest { PaymentProfileToken = "some example string" },
    });
    // TODO: Handle 'response' of type PaymentProfileRemoveResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PaymentProfileRemoveOperationRequest](src/ThePlaidApi/Requests/PaymentProfileRemoveOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentProfileRemoveResponse](src/ThePlaidApi/Models/PaymentProfileRemoveResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ProcessorAccountGetResponse&gt; ProcessorAccountGet(ProcessorAccountGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint returns the account associated with a given processor token.

This endpoint retrieves cached information, rather than extracting fresh information from the institution. As a result, the account balance returned may not be up-to-date; for real-time balance information, use `/processor/balance/get` instead. Note that some information is nullable.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ProcessorAccountGet(new ProcessorAccountGetOperationRequest
    {
        Body = new ProcessorAccountGetRequest { ProcessorToken = "some example string" },
    });
    // TODO: Handle 'response' of type ProcessorAccountGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ProcessorAccountGetOperationRequest](src/ThePlaidApi/Requests/ProcessorAccountGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ProcessorAccountGetResponse](src/ThePlaidApi/Models/ProcessorAccountGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ProcessorTokenCreateResponse&gt; ProcessorApexProcessorTokenCreate(ProcessorApexProcessorTokenCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Used to create a token suitable for sending to Apex to enable Plaid-Apex integrations.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ProcessorApexProcessorTokenCreate(new ProcessorApexProcessorTokenCreateOperationRequest
    {
        Body = new ProcessorApexProcessorTokenCreateRequest
        {
            AccessToken = "some example string",
            AccountId = "some example string",
        },
    });
    // TODO: Handle 'response' of type ProcessorTokenCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ProcessorApexProcessorTokenCreateOperationRequest](src/ThePlaidApi/Requests/ProcessorApexProcessorTokenCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ProcessorTokenCreateResponse](src/ThePlaidApi/Models/ProcessorTokenCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ProcessorAuthGetResponse&gt; ProcessorAuthGet(ProcessorAuthGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/processor/auth/get` endpoint returns the bank account and bank identification number (such as the routing number, for US accounts), for a checking, savings, or cash management account that''s associated with a given `processor_token`. The endpoint also returns high-level account data and balances when available.

Versioning note: API versions 2019-05-29 and earlier use a different schema for the `numbers` object returned by this endpoint. For details, see [Plaid API versioning](https://plaid.com/docs/api/versioning/#version-2020-09-14).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ProcessorAuthGet(new ProcessorAuthGetOperationRequest
    {
        Body = new ProcessorAuthGetRequest { ProcessorToken = "some example string" },
    });
    // TODO: Handle 'response' of type ProcessorAuthGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ProcessorAuthGetOperationRequest](src/ThePlaidApi/Requests/ProcessorAuthGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ProcessorAuthGetResponse](src/ThePlaidApi/Models/ProcessorAuthGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ProcessorBalanceGetResponse&gt; ProcessorBalanceGet(ProcessorBalanceGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/processor/balance/get` endpoint returns the real-time balance for each of an Item's accounts. While other endpoints may return a balance object, only `/processor/balance/get` forces the available and current balance fields to be refreshed rather than cached.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ProcessorBalanceGet(new ProcessorBalanceGetOperationRequest
    {
        Body = new ProcessorBalanceGetRequest { ProcessorToken = "some example string" },
    });
    // TODO: Handle 'response' of type ProcessorBalanceGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ProcessorBalanceGetOperationRequest](src/ThePlaidApi/Requests/ProcessorBalanceGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ProcessorBalanceGetResponse](src/ThePlaidApi/Models/ProcessorBalanceGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ProcessorBankTransferCreateResponse&gt; ProcessorBankTransferCreate(ProcessorBankTransferCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/processor/bank_transfer/create` endpoint to initiate a new bank transfer as a processor

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ProcessorBankTransferCreate(new ProcessorBankTransferCreateOperationRequest
    {
        Body = new ProcessorBankTransferCreateRequest
        {
            IdempotencyKey = "some example string",
            ProcessorToken = "some example string",
            Type = BankTransferType.Debit,
            Network = BankTransferNetwork.Ach,
            Amount = "some example string",
            IsoCurrencyCode = "some example string",
            Description = "some example string",
            User = new BankTransferUser { LegalName = "some example string" },
        },
    });
    // TODO: Handle 'response' of type ProcessorBankTransferCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ProcessorBankTransferCreateOperationRequest](src/ThePlaidApi/Requests/ProcessorBankTransferCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ProcessorBankTransferCreateResponse](src/ThePlaidApi/Models/ProcessorBankTransferCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ProcessorIdentityGetResponse&gt; ProcessorIdentityGet(ProcessorIdentityGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/processor/identity/get` endpoint allows you to retrieve various account holder information on file with the financial institution, including names, emails, phone numbers, and addresses.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ProcessorIdentityGet(new ProcessorIdentityGetOperationRequest
    {
        Body = new ProcessorIdentityGetRequest { ProcessorToken = "some example string" },
    });
    // TODO: Handle 'response' of type ProcessorIdentityGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ProcessorIdentityGetOperationRequest](src/ThePlaidApi/Requests/ProcessorIdentityGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ProcessorIdentityGetResponse](src/ThePlaidApi/Models/ProcessorIdentityGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ProcessorIdentityMatchResponse&gt; ProcessorIdentityMatch(ProcessorIdentityMatchOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/processor/identity/match` endpoint generates a match score, which indicates how well the provided identity data matches the identity information on file with the account holder's financial institution.

Fields within the `balances` object will always be null when retrieved by `/processor/identity/match`. Instead, use the `/processor/balance/get` endpoint to retrieve balance data.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ProcessorIdentityMatch(new ProcessorIdentityMatchOperationRequest
    {
        Body = new ProcessorIdentityMatchRequest { ProcessorToken = "some example string" },
    });
    // TODO: Handle 'response' of type ProcessorIdentityMatchResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ProcessorIdentityMatchOperationRequest](src/ThePlaidApi/Requests/ProcessorIdentityMatchOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ProcessorIdentityMatchResponse](src/ThePlaidApi/Models/ProcessorIdentityMatchResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ProcessorInvestmentsAuthGetResponse&gt; ProcessorInvestmentsAuthGet(ProcessorInvestmentsAuthGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/processor/investments/auth/get` endpoint allows you to retrieve information about the account
authorized by a processor token, including account numbers, account owners, holdings, and data provenance information.

To receive Investments Auth webhooks for a processor token, set its webhook URL via the [`/processor/token/webhook/update`](https://plaid.com/docs/api/processor-partners/#processortokenwebhookupdate) endpoint.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ProcessorInvestmentsAuthGet(new ProcessorInvestmentsAuthGetOperationRequest
    {
        Body = new ProcessorInvestmentsAuthGetRequest { ProcessorToken = "some example string" },
    });
    // TODO: Handle 'response' of type ProcessorInvestmentsAuthGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ProcessorInvestmentsAuthGetOperationRequest](src/ThePlaidApi/Requests/ProcessorInvestmentsAuthGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ProcessorInvestmentsAuthGetResponse](src/ThePlaidApi/Models/ProcessorInvestmentsAuthGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ProcessorInvestmentsHoldingsGetResponse&gt; ProcessorInvestmentsHoldingsGet(ProcessorInvestmentsHoldingsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint returns the stock position data of the account associated with a given processor token.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ProcessorInvestmentsHoldingsGet(new ProcessorInvestmentsHoldingsGetOperationRequest
    {
        Body = new ProcessorInvestmentsHoldingsGetRequest { ProcessorToken = "some example string" },
    });
    // TODO: Handle 'response' of type ProcessorInvestmentsHoldingsGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ProcessorInvestmentsHoldingsGetOperationRequest](src/ThePlaidApi/Requests/ProcessorInvestmentsHoldingsGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ProcessorInvestmentsHoldingsGetResponse](src/ThePlaidApi/Models/ProcessorInvestmentsHoldingsGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ProcessorInvestmentsTransactionsGetResponse&gt; ProcessorInvestmentsTransactionsGet(ProcessorInvestmentsTransactionsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/processor/investments/transactions/get` endpoint allows developers to retrieve up to 24 months of user-authorized transaction data for the investment account associated with the processor token.

Transactions are returned in reverse-chronological order, and the sequence of transaction ordering is stable and will not shift.

Due to the potentially large number of investment transactions associated with the account, results are paginated. Manipulate the count and offset parameters in conjunction with the `total_investment_transactions` response body field to fetch all available investment transactions.

Note that Investments does not have a webhook to indicate when initial transaction data has loaded (unless you use the `async_update` option). Instead, if transactions data is not ready when `/processor/investments/transactions/get` is first called, Plaid will wait for the data. For this reason, calling `/processor/investments/transactions/get` immediately after Link may take up to one to two minutes to return.

Data returned by the asynchronous investments extraction flow (when `async_update` is set to true) may not be immediately available to `/processor/investments/transactions/get`. To be alerted when the data is ready to be fetched, listen for the `HISTORICAL_UPDATE` webhook. If no investments history is ready when `/processor/investments/transactions/get` is called, it will return a `PRODUCT_NOT_READY` error.

To receive Investments Transactions webhooks for a processor token, set its webhook URL via the [`/processor/token/webhook/update`](https://plaid.com/docs/api/processor-partners/#processortokenwebhookupdate) endpoint.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ProcessorInvestmentsTransactionsGet(
        new ProcessorInvestmentsTransactionsGetOperationRequest
        {
            Body = new ProcessorInvestmentsTransactionsGetRequest
            {
                ProcessorToken = "some example string",
                StartDate = DateTimeOffset.Parse("2024-01-15T00:00:00Z"),
                EndDate = DateTimeOffset.Parse("2024-01-15T00:00:00Z"),
            },
        });
    // TODO: Handle 'response' of type ProcessorInvestmentsTransactionsGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ProcessorInvestmentsTransactionsGetOperationRequest](src/ThePlaidApi/Requests/ProcessorInvestmentsTransactionsGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ProcessorInvestmentsTransactionsGetResponse](src/ThePlaidApi/Models/ProcessorInvestmentsTransactionsGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ProcessorLiabilitiesGetResponse&gt; ProcessorLiabilitiesGet(ProcessorLiabilitiesGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/processor/liabilities/get` endpoint returns various details about a loan or credit account. Liabilities data is available primarily for US financial institutions, with some limited coverage of Canadian institutions. Currently supported account types are account type `credit` with account subtype `credit card` or `paypal`, and account type `loan` with account subtype `student` or `mortgage`.

The types of information returned by Liabilities can include balances and due dates, loan terms, and account details such as original loan amount and guarantor. Data is refreshed approximately once per day; the latest data can be retrieved by calling `/processor/liabilities/get`.

Note: This request may take some time to complete if `liabilities` was not specified as an initial product when creating the processor token. This is because Plaid must communicate directly with the institution to retrieve the additional data.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ProcessorLiabilitiesGet(new ProcessorLiabilitiesGetOperationRequest
    {
        Body = new ProcessorLiabilitiesGetRequest { ProcessorToken = "some example string" },
    });
    // TODO: Handle 'response' of type ProcessorLiabilitiesGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ProcessorLiabilitiesGetOperationRequest](src/ThePlaidApi/Requests/ProcessorLiabilitiesGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ProcessorLiabilitiesGetResponse](src/ThePlaidApi/Models/ProcessorLiabilitiesGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ProcessorSignalDecisionReportResponse&gt; ProcessorSignalDecisionReport(ProcessorSignalDecisionReportOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

After you call `/processor/signal/evaluate`, Plaid will normally infer the outcome from your Signal Rules. However, if you are not using Signal Rules, if the Signal Rules outcome was `REVIEW`, or if you take a different action than the one determined by the Signal Rules, you will need to call `/processor/signal/decision/report`. This helps improve Signal Transaction Score accuracy for your account and is necessary for proper functioning of the rule performance and rule tuning capabilities in the Dashboard. If your effective decision changes after calling `/processor/signal/decision/report` (for example, you indicated that you accepted a transaction, but later on, your payment processor rejected it, so it was never initiated), call `/processor/signal/decision/report` again for the transaction to correct Plaid's records.

If you are using Plaid Transfer as your payment processor, you also do not need to call `/processor/signal/decision/report`, as Plaid can infer outcomes from your Transfer activity.

If using a Balance-only ruleset, this endpoint will not impact scores (Balance does not use scores), but is necessary to view accurate transaction outcomes and tune rule logic in the Dashboard.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ProcessorSignalDecisionReport(new ProcessorSignalDecisionReportOperationRequest
    {
        Body = new ProcessorSignalDecisionReportRequest
        {
            ProcessorToken = "some example string",
            ClientTransactionId = "some example string",
            Initiated = true,
        },
    });
    // TODO: Handle 'response' of type ProcessorSignalDecisionReportResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ProcessorSignalDecisionReportOperationRequest](src/ThePlaidApi/Requests/ProcessorSignalDecisionReportOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ProcessorSignalDecisionReportResponse](src/ThePlaidApi/Models/ProcessorSignalDecisionReportResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ProcessorSignalEvaluateResponse&gt; ProcessorSignalEvaluate(ProcessorSignalEvaluateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use `/processor/signal/evaluate` to evaluate a planned ACH transaction to get a return risk assessment and additional risk signals.

`/processor/signal/evaluate` uses Rulesets that are configured on the end customer's Dashboard and can be used with either the Signal Transaction Scores product or the Balance product. Which product is used will be determined by the `ruleset_key` that you provide. Note that only customer-configured rulesets work with this endpoint; as a processor partner, you cannot create or configure your own rulesets. For more details, see [Signal Rules](https://plaid.com/docs/signal/signal-rules/).

Note: This request may have higher latency if Signal Transaction Scores is being added to an existing Item for the first time, or when using a Balance-only ruleset. This is because Plaid must communicate directly with the institution to request data.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ProcessorSignalEvaluate(new ProcessorSignalEvaluateOperationRequest
    {
        Body = new ProcessorSignalEvaluateRequest
        {
            ProcessorToken = "some example string",
            ClientTransactionId = "some example string",
            Amount = 1.5d,
        },
    });
    // TODO: Handle 'response' of type ProcessorSignalEvaluateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ProcessorSignalEvaluateOperationRequest](src/ThePlaidApi/Requests/ProcessorSignalEvaluateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ProcessorSignalEvaluateResponse](src/ThePlaidApi/Models/ProcessorSignalEvaluateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ProcessorSignalPrepareResponse&gt; ProcessorSignalPrepare(ProcessorSignalPrepareOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

When a processor token is not initialized with `signal`, call `/processor/signal/prepare` to opt-in that processor token to the data collection process, which will improve the accuracy of the Signal Transaction Score.

If this endpoint is called with a processor token that is already initialized with `signal`, it will return a 200 response and will not modify the processor token.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ProcessorSignalPrepare(new ProcessorSignalPrepareOperationRequest
    {
        Body = new ProcessorSignalPrepareRequest { ProcessorToken = "some example string" },
    });
    // TODO: Handle 'response' of type ProcessorSignalPrepareResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ProcessorSignalPrepareOperationRequest](src/ThePlaidApi/Requests/ProcessorSignalPrepareOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ProcessorSignalPrepareResponse](src/ThePlaidApi/Models/ProcessorSignalPrepareResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ProcessorSignalReturnReportResponse&gt; ProcessorSignalReturnReport(ProcessorSignalReturnReportOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Call the `/processor/signal/return/report` endpoint to report a returned transaction that was previously sent to the `/processor/signal/evaluate` endpoint. Your feedback will be used by the model to incorporate the latest risk trend in your portfolio.

If you are using the [Plaid Transfer product](https://plaid.com/docs/transfer) to create transfers, it is not necessary to use this endpoint, as Plaid already knows whether the transfer was returned.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ProcessorSignalReturnReport(new ProcessorSignalReturnReportOperationRequest
    {
        Body = new ProcessorSignalReturnReportRequest
        {
            ProcessorToken = "some example string",
            ClientTransactionId = "some example string",
            ReturnCode = "some example string",
        },
    });
    // TODO: Handle 'response' of type ProcessorSignalReturnReportResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ProcessorSignalReturnReportOperationRequest](src/ThePlaidApi/Requests/ProcessorSignalReturnReportOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ProcessorSignalReturnReportResponse](src/ThePlaidApi/Models/ProcessorSignalReturnReportResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ProcessorStripeBankAccountTokenCreateResponse&gt; ProcessorStripeBankAccountTokenCreate(ProcessorStripeBankAccountTokenCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Used to create a token suitable for sending to Stripe to enable Plaid-Stripe integrations. For a detailed guide on integrating Stripe, see [Add Stripe to your app](https://plaid.com/docs/auth/partnerships/stripe/).

Note that the Stripe bank account token is a one-time use token. To store bank account information for later use, you can use a Stripe customer object and create an associated bank account from the token, or you can use a Stripe Custom account and create an associated external bank account from the token. This bank account information should work indefinitely, unless the user's bank account information changes or they revoke Plaid's permissions to access their account. Stripe bank account information cannot be modified once the bank account token has been created. If you ever need to change the bank account details used by Stripe for a specific customer, have the user go through Link again and create a new bank account token from the new `access_token`.

To revoke a bank account token, the entire underlying access token must be revoked using `/item/remove`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ProcessorStripeBankAccountTokenCreate(
        new ProcessorStripeBankAccountTokenCreateOperationRequest
        {
            Body = new ProcessorStripeBankAccountTokenCreateRequest
            {
                AccessToken = "some example string",
                AccountId = "some example string",
            },
        });
    // TODO: Handle 'response' of type ProcessorStripeBankAccountTokenCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ProcessorStripeBankAccountTokenCreateOperationRequest](src/ThePlaidApi/Requests/ProcessorStripeBankAccountTokenCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ProcessorStripeBankAccountTokenCreateResponse](src/ThePlaidApi/Models/ProcessorStripeBankAccountTokenCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ProcessorTokenCreateResponse&gt; ProcessorTokenCreate(ProcessorTokenCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Used to create a token suitable for sending to one of Plaid's partners to enable integrations. Note that Stripe partnerships use bank account tokens instead; see `/processor/stripe/bank_account_token/create` for creating tokens for use with Stripe integrations. If using multiple processors, multiple different processor tokens can be created for a single access token. Once created, a processor token for a given Item can be modified by calling `/processor/token/permissions/set`. To revoke the processor's access, the entire Item must be deleted by calling `/item/remove`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ProcessorTokenCreate(new ProcessorTokenCreateOperationRequest
    {
        Body = new ProcessorTokenCreateRequest
        {
            AccessToken = "some example string",
            AccountId = "some example string",
            Processor = Processor.Dwolla,
        },
    });
    // TODO: Handle 'response' of type ProcessorTokenCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ProcessorTokenCreateOperationRequest](src/ThePlaidApi/Requests/ProcessorTokenCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ProcessorTokenCreateResponse](src/ThePlaidApi/Models/ProcessorTokenCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ProcessorTokenPermissionsGetResponse&gt; ProcessorTokenPermissionsGet(ProcessorTokenPermissionsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Used to get a processor token's product permissions. The `products` field will be an empty list if the processor can access all available products.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ProcessorTokenPermissionsGet(new ProcessorTokenPermissionsGetOperationRequest
    {
        Body = new ProcessorTokenPermissionsGetRequest { ProcessorToken = "some example string" },
    });
    // TODO: Handle 'response' of type ProcessorTokenPermissionsGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ProcessorTokenPermissionsGetOperationRequest](src/ThePlaidApi/Requests/ProcessorTokenPermissionsGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ProcessorTokenPermissionsGetResponse](src/ThePlaidApi/Models/ProcessorTokenPermissionsGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ProcessorTokenPermissionsSetResponse&gt; ProcessorTokenPermissionsSet(ProcessorTokenPermissionsSetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Used to control a processor's access to products on the given processor token. By default, a processor will have access to all available products on the corresponding item. To restrict access to a particular set of products, call this endpoint with the desired products. To restore access to all available products, call this endpoint with an empty list. This endpoint can be called multiple times as your needs and your processor's needs change.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ProcessorTokenPermissionsSet(new ProcessorTokenPermissionsSetOperationRequest
    {
        Body = new ProcessorTokenPermissionsSetRequest
        {
            ProcessorToken = "some example string",
            Products = [Products.Assets],
        },
    });
    // TODO: Handle 'response' of type ProcessorTokenPermissionsSetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ProcessorTokenPermissionsSetOperationRequest](src/ThePlaidApi/Requests/ProcessorTokenPermissionsSetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ProcessorTokenPermissionsSetResponse](src/ThePlaidApi/Models/ProcessorTokenPermissionsSetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ProcessorTokenWebhookUpdateResponse&gt; ProcessorTokenWebhookUpdate(ProcessorTokenWebhookUpdateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows you, the processor, to update the webhook URL associated with a processor token. This request triggers a `WEBHOOK_UPDATE_ACKNOWLEDGED` webhook to the newly specified webhook URL.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ProcessorTokenWebhookUpdate(new ProcessorTokenWebhookUpdateOperationRequest
    {
        Body = new ProcessorTokenWebhookUpdateRequest
        {
            ProcessorToken = "some example string",
            Webhook = "some example string",
        },
    });
    // TODO: Handle 'response' of type ProcessorTokenWebhookUpdateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ProcessorTokenWebhookUpdateOperationRequest](src/ThePlaidApi/Requests/ProcessorTokenWebhookUpdateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ProcessorTokenWebhookUpdateResponse](src/ThePlaidApi/Models/ProcessorTokenWebhookUpdateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ProcessorTransactionsGetResponse&gt; ProcessorTransactionsGet(ProcessorTransactionsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/processor/transactions/get` endpoint allows developers to receive user-authorized transaction data for credit, depository, and some loan-type accounts (only those with account subtype `student` or `mortgage`; coverage may be limited). Transaction data is standardized across financial institutions, and in many cases transactions are linked to a clean name, entity type, location, and category. Similarly, account data is standardized and returned with a clean name, number, balance, and other meta information where available.

Transactions are returned in reverse-chronological order, and the sequence of transaction ordering is stable and will not shift.  Transactions are not immutable and can also be removed altogether by the institution; a removed transaction will no longer appear in `/processor/transactions/get`.  For more details, see [Pending and posted transactions](https://plaid.com/docs/transactions/transactions-data/#pending-and-posted-transactions).

Due to the potentially large number of transactions associated with a processor token, results are paginated. Manipulate the `count` and `offset` parameters in conjunction with the `total_transactions` response body field to fetch all available transactions.

Data returned by `/processor/transactions/get` will be the data available for the processor token as of the most recent successful check for new transactions. Plaid typically checks for new data multiple times a day, but these checks may occur less frequently, such as once a day, depending on the institution. To force Plaid to check for new transactions, you can use the `/processor/transactions/refresh` endpoint.

Note that data may not be immediately available to `/processor/transactions/get`. Plaid will begin to prepare transactions data upon Item link, if Link was initialized with `transactions`, or upon the first call to `/processor/transactions/get`, if it wasn't. If no transaction history is ready when `/processor/transactions/get` is called, it will return a `PRODUCT_NOT_READY` error.

To receive Transactions webhooks for a processor token, set its webhook URL via the [`/processor/token/webhook/update`](https://plaid.com/docs/api/processor-partners/#processortokenwebhookupdate) endpoint.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ProcessorTransactionsGet(new ProcessorTransactionsGetOperationRequest
    {
        Body = new ProcessorTransactionsGetRequest
        {
            ProcessorToken = "some example string",
            StartDate = DateTimeOffset.Parse("2024-01-15T00:00:00Z"),
            EndDate = DateTimeOffset.Parse("2024-01-15T00:00:00Z"),
        },
    });
    // TODO: Handle 'response' of type ProcessorTransactionsGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ProcessorTransactionsGetOperationRequest](src/ThePlaidApi/Requests/ProcessorTransactionsGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ProcessorTransactionsGetResponse](src/ThePlaidApi/Models/ProcessorTransactionsGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ProcessorTransactionsRecurringGetResponse&gt; ProcessorTransactionsRecurringGet(ProcessorTransactionsRecurringGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/processor/transactions/recurring/get` endpoint allows developers to receive a summary of the recurring outflow and inflow streams (expenses and deposits) from a user's checking, savings or credit card accounts. Additionally, Plaid provides key insights about each recurring stream including the category, merchant, last amount, and more. Developers can use these insights to build tools and experiences that help their users better manage cash flow, monitor subscriptions, reduce spend, and stay on track with bill payments.

This endpoint is offered as an add-on to Transactions. To request access to this endpoint, submit a [product access request](https://dashboard.plaid.com/team/products) or contact your Plaid account manager.

This endpoint can only be called on a processor token that has already been initialized with Transactions (either during Link, by specifying it in `/link/token/create`; or after Link, by calling `/processor/transactions/get` or `/processor/transactions/sync`). Once all historical transactions have been fetched, call `/processor/transactions/recurring/get` to receive the Recurring Transactions streams and subscribe to the [`RECURRING_TRANSACTIONS_UPDATE`](https://plaid.com/docs/api/products/transactions/#recurring_transactions_update) webhook. To know when historical transactions have been fetched, if you are using `/processor/transactions/sync` listen for the [`SYNC_UPDATES_AVAILABLE`](https://plaid.com/docs/api/products/transactions/#SyncUpdatesAvailableWebhook-historical-update-complete) webhook and check that the `historical_update_complete` field in the payload is `true`. If using `/processor/transactions/get`, listen for the [`HISTORICAL_UPDATE`](https://plaid.com/docs/api/products/transactions/#historical_update) webhook.

After the initial call, you can call the `/processor/transactions/recurring/get` endpoint at any point in the future to retrieve the latest summary of recurring streams. Listen to the [`RECURRING_TRANSACTIONS_UPDATE`](https://plaid.com/docs/api/products/transactions/#recurring_transactions_update) webhook to be notified when new updates are available.

To receive Transactions webhooks for a processor token, set its webhook URL via the [`/processor/token/webhook/update`](https://plaid.com/docs/api/processor-partners/#processortokenwebhookupdate) endpoint.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ProcessorTransactionsRecurringGet(new ProcessorTransactionsRecurringGetOperationRequest
    {
        Body = new ProcessorTransactionsRecurringGetRequest { ProcessorToken = "some example string" },
    });
    // TODO: Handle 'response' of type ProcessorTransactionsRecurringGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ProcessorTransactionsRecurringGetOperationRequest](src/ThePlaidApi/Requests/ProcessorTransactionsRecurringGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ProcessorTransactionsRecurringGetResponse](src/ThePlaidApi/Models/ProcessorTransactionsRecurringGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ProcessorTransactionsRefreshResponse&gt; ProcessorTransactionsRefresh(ProcessorTransactionsRefreshOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/processor/transactions/refresh` is an optional endpoint for users of the Transactions product. It initiates an on-demand extraction to fetch the newest transactions for a processor token. This on-demand extraction takes place in addition to the periodic extractions that automatically occur one or more times per day for any Transactions-enabled processor token. If changes to transactions are discovered after calling `/processor/transactions/refresh`, Plaid will fire a webhook: for `/processor/transactions/sync` users, [`SYNC_UPDATES_AVAILABLE`](https://plaid.com/docs/api/products/transactions/#sync_updates_available) will be fired if there are any transactions updated, added, or removed. For users of both `/processor/transactions/sync` and `/processor/transactions/get`, [`TRANSACTIONS_REMOVED`](https://plaid.com/docs/api/products/transactions/#transactions_removed) will be fired if any removed transactions are detected, and [`DEFAULT_UPDATE`](https://plaid.com/docs/api/products/transactions/#default_update) will be fired if any new transactions are detected. New transactions can be fetched by calling `/processor/transactions/get` or `/processor/transactions/sync`. Note that the `/processor/transactions/refresh` endpoint is not supported for Capital One (`ins_128026`) non-depository accounts and will result in a `PRODUCTS_NOT_SUPPORTED` error if called on an Item that contains only non-depository accounts from that institution.

As this endpoint triggers a synchronous request for fresh data, latency may be higher than for other Plaid endpoints (typically less than 10 seconds, but occasionally up to 30 seconds or more); if you encounter errors, you may find it necessary to adjust your timeout period when making requests.

`/processor/transactions/refresh` is offered as an add-on to Transactions and has a separate [fee model](https://plaid.com/docs/account/billing/#per-request-flat-fee). To request access to this endpoint, submit a [product access request](https://dashboard.plaid.com/team/products) or contact your Plaid account manager.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ProcessorTransactionsRefresh(new ProcessorTransactionsRefreshOperationRequest
    {
        Body = new ProcessorTransactionsRefreshRequest { ProcessorToken = "some example string" },
    });
    // TODO: Handle 'response' of type ProcessorTransactionsRefreshResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ProcessorTransactionsRefreshOperationRequest](src/ThePlaidApi/Requests/ProcessorTransactionsRefreshOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ProcessorTransactionsRefreshResponse](src/ThePlaidApi/Models/ProcessorTransactionsRefreshResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ProcessorTransactionsSyncResponse&gt; ProcessorTransactionsSync(ProcessorTransactionsSyncOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/processor/transactions/sync` endpoint retrieves transactions associated with an Item and can fetch updates using a cursor to track which updates have already been seen.

For important instructions on integrating with `/processor/transactions/sync`, see the [Transactions integration overview](https://plaid.com/docs/transactions/#integration-overview). If you are migrating from an existing integration using `/processor/transactions/get`, see the [Transactions Sync migration guide](https://plaid.com/docs/transactions/sync-migration/).

This endpoint supports `credit`, `depository`, and some `loan`-type accounts (only those with account subtype `student` or `mortgage`). For `investments` accounts, use `/investments/transactions/get` instead.

When retrieving paginated updates, track both the `next_cursor` from the latest response and the original cursor from the first call in which `has_more` was `true`; if a call to `/processor/transactions/sync` fails when retrieving a paginated update (e.g. due to the [`TRANSACTIONS_SYNC_MUTATION_DURING_PAGINATION`](https://plaid.com/docs/errors/transactions/#transactions_sync_mutation_during_pagination) error), the entire pagination request loop must be restarted beginning with the cursor for the first page of the update, rather than retrying only the single request that failed.

If transactions data is not yet available for the Item, which can happen if the Item was not initialized with transactions during the `/link/token/create` call or if `/processor/transactions/sync` was called within a few seconds of Item creation, `/processor/transactions/sync` will return empty transactions arrays.

Plaid typically checks for new transactions data between one and four times per day, depending on the institution. To find out when transactions were last updated for an Item, use the [Item Debugger](https://plaid.com/docs/account/activity/#troubleshooting-with-item-debugger) or call `/item/get`; the `item.status.transactions.last_successful_update` field will show the timestamp of the most recent successful update. To force Plaid to check for new transactions, use the `/processor/transactions/refresh` endpoint.

To be alerted when new transactions are available, listen for the [`SYNC_UPDATES_AVAILABLE`](https://plaid.com/docs/api/products/transactions/#sync_updates_available) webhook.

To receive Transactions webhooks for a processor token, set its webhook URL via the [`/processor/token/webhook/update`](https://plaid.com/docs/api/processor-partners/#processortokenwebhookupdate) endpoint.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ProcessorTransactionsSync(new ProcessorTransactionsSyncOperationRequest
    {
        Body = new ProcessorTransactionsSyncRequest { ProcessorToken = "some example string" },
    });
    // TODO: Handle 'response' of type ProcessorTransactionsSyncResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ProcessorTransactionsSyncOperationRequest](src/ThePlaidApi/Requests/ProcessorTransactionsSyncOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ProcessorTransactionsSyncResponse](src/ThePlaidApi/Models/ProcessorTransactionsSyncResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ProfileNetworkStatusGetResponse&gt; ProfileNetworkStatusGet(ProfileNetworkStatusGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/profile/network_status/get` endpoint can be used to check whether Plaid has a matching profile for the user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ProfileNetworkStatusGet(new ProfileNetworkStatusGetOperationRequest
    {
        Body = new ProfileNetworkStatusGetRequest
        {
            User = new NetworkStatusGetUser { PhoneNumber = "some example string" },
        },
    });
    // TODO: Handle 'response' of type ProfileNetworkStatusGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ProfileNetworkStatusGetOperationRequest](src/ThePlaidApi/Requests/ProfileNetworkStatusGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ProfileNetworkStatusGetResponse](src/ThePlaidApi/Models/ProfileNetworkStatusGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ProtectComputeResponse&gt; ProtectCompute(ProtectComputeOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Compute a Protect Trust Index score for a user. The model selected determines what is scored and what additional fields the response contains. For example, `ti-link-session-2.0` scores a completed Link session for fraud risk; `cash-advance-onboarding-1.0` scores repayment risk for a first-time cash advance and additionally populates per-amount-bucket subscores. Cash-advance models require that the user have a Plaid Item with Transactions enabled, or an Assets Report, before scoring.

The endpoint returns HTTP 400 with `error_type` = `INVALID_REQUEST` and `error_code` = `FAILED_PRECONDITION` when a required precondition is not met: for link-session models, when the Link session has not completed; for cash-advance models, when the user has not successfully linked any Item.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ProtectCompute(new ProtectComputeOperationRequest
    {
        Body = new ProtectComputeRequest { Model = "some example string", User = new ProtectUser() },
    });
    // TODO: Handle 'response' of type ProtectComputeResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ProtectComputeOperationRequest](src/ThePlaidApi/Requests/ProtectComputeOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ProtectComputeResponse](src/ThePlaidApi/Models/ProtectComputeResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ProtectEventGetResponse&gt; ProtectEventGet(ProtectEventGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get information about a user event including Trust Index score and fraud attributes.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ProtectEventGet(new ProtectEventGetOperationRequest
    {
        Body = new ProtectEventGetRequest { EventId = "some example string" },
    });
    // TODO: Handle 'response' of type ProtectEventGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ProtectEventGetOperationRequest](src/ThePlaidApi/Requests/ProtectEventGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ProtectEventGetResponse](src/ThePlaidApi/Models/ProtectEventGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ProtectEventSendResponse&gt; ProtectEventSend(ProtectEventSendOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Send a new event to enrich user data and optionally get a Trust Index score for the event.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ProtectEventSend(new ProtectEventSendOperationRequest
    {
        Body = new ProtectEventSendRequest
        {
            Event = new ProtectEvent { Timestamp = DateTimeOffset.Parse("2024-01-15T09:30:00Z") },
        },
    });
    // TODO: Handle 'response' of type ProtectEventSendResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ProtectEventSendOperationRequest](src/ThePlaidApi/Requests/ProtectEventSendOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ProtectEventSendResponse](src/ThePlaidApi/Models/ProtectEventSendResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ProtectReportCreateResponse&gt; ProtectReportCreate(ProtectReportCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use this endpoint to create a Protect report to document fraud incidents, investigation outcomes, or other risk events.
This endpoint allows you to report various types of incidents including account takeovers, identity fraud, unauthorized transactions, and other security events.
The reported data helps improve fraud detection models and provides valuable feedback to enhance the overall security of the Plaid network.
Reports can be created for confirmed incidents that have been fully investigated, or for suspected incidents that require further review.
You can associate reports with specific users, sessions, or transactions to provide comprehensive context about the incident.
Each report must include `user_id`, or an `incident_event` with at least one supported identifier: `link_session_id`, `idv_session_id`, `protect_event_id`, `signal_client_transaction_id`, or `access_token`. Context fields such as `internal_reference`, `time`, `amount`, and `bank_account` do not satisfy this identifier requirement.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ProtectReportCreate(new ProtectReportCreateOperationRequest
    {
        Body = new ProtectReportCreateRequest
        {
            ReportConfidence = ProtectReportConfidence.Confirmed,
            ReportType = ProtectReportType.UserAccountTakeover,
            ReportSource = ProtectReportSource.InternalReview,
        },
    });
    // TODO: Handle 'response' of type ProtectReportCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ProtectReportCreateOperationRequest](src/ThePlaidApi/Requests/ProtectReportCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ProtectReportCreateResponse](src/ThePlaidApi/Models/ProtectReportCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ProtectUserInsightsGetResponse&gt; ProtectUserInsightsGet(ProtectUserInsightsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use this endpoint to get basic information about a user as it relates to their fraud profile with Protect.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ProtectUserInsightsGet(new ProtectUserInsightsGetOperationRequest
    {
        Body = new ProtectUserInsightsGetRequest(),
    });
    // TODO: Handle 'response' of type ProtectUserInsightsGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ProtectUserInsightsGetOperationRequest](src/ThePlaidApi/Requests/ProtectUserInsightsGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ProtectUserInsightsGetResponse](src/ThePlaidApi/Models/ProtectUserInsightsGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SandboxBankIncomeFireWebhookResponse&gt; SandboxBankIncomeFireWebhook(SandboxBankIncomeFireWebhookOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/sandbox/bank_income/fire_webhook` endpoint to manually trigger a Bank Income webhook in the Sandbox environment.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SandboxBankIncomeFireWebhook(new SandboxBankIncomeFireWebhookOperationRequest
    {
        Body = new SandboxBankIncomeFireWebhookRequest
        {
            WebhookCode = SandboxBankIncomeWebhookFireRequestWebhookCode.BankIncomeRefreshUpdate,
            WebhookFields = new SandboxBankIncomeWebhookFireRequestWebhookFields { UserId = "some example string" },
        },
    });
    // TODO: Handle 'response' of type SandboxBankIncomeFireWebhookResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SandboxBankIncomeFireWebhookOperationRequest](src/ThePlaidApi/Requests/SandboxBankIncomeFireWebhookOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SandboxBankIncomeFireWebhookResponse](src/ThePlaidApi/Models/SandboxBankIncomeFireWebhookResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SandboxBankTransferFireWebhookResponse&gt; SandboxBankTransferFireWebhook(SandboxBankTransferFireWebhookOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/sandbox/bank_transfer/fire_webhook` endpoint to manually trigger a Bank Transfers webhook in the Sandbox environment.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SandboxBankTransferFireWebhook(new SandboxBankTransferFireWebhookOperationRequest
    {
        Body = new SandboxBankTransferFireWebhookRequest { Webhook = "some example string" },
    });
    // TODO: Handle 'response' of type SandboxBankTransferFireWebhookResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SandboxBankTransferFireWebhookOperationRequest](src/ThePlaidApi/Requests/SandboxBankTransferFireWebhookOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SandboxBankTransferFireWebhookResponse](src/ThePlaidApi/Models/SandboxBankTransferFireWebhookResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SandboxBankTransferSimulateResponse&gt; SandboxBankTransferSimulate(SandboxBankTransferSimulateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/sandbox/bank_transfer/simulate` endpoint to simulate a bank transfer event in the Sandbox environment.  Note that while an event will be simulated and will appear when using endpoints such as `/bank_transfer/event/sync` or `/bank_transfer/event/list`, no transactions will actually take place and funds will not move between accounts, even within the Sandbox.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SandboxBankTransferSimulate(new SandboxBankTransferSimulateOperationRequest
    {
        Body = new SandboxBankTransferSimulateRequest
        {
            BankTransferId = "some example string",
            EventType = "some example string",
        },
    });
    // TODO: Handle 'response' of type SandboxBankTransferSimulateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SandboxBankTransferSimulateOperationRequest](src/ThePlaidApi/Requests/SandboxBankTransferSimulateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SandboxBankTransferSimulateResponse](src/ThePlaidApi/Models/SandboxBankTransferSimulateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SandboxCraCashflowUpdatesUpdateResponse&gt; SandboxCraCashflowUpdatesUpdate(SandboxCraCashflowUpdatesUpdateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/sandbox/cra/cashflow_updates/update` endpoint to manually trigger an update for Cash Flow Updates (Monitoring) in the Sandbox environment.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SandboxCraCashflowUpdatesUpdate(new SandboxCraCashflowUpdatesUpdateOperationRequest
    {
        Body = new SandboxCraCashflowUpdatesUpdateRequest(),
    });
    // TODO: Handle 'response' of type SandboxCraCashflowUpdatesUpdateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SandboxCraCashflowUpdatesUpdateOperationRequest](src/ThePlaidApi/Requests/SandboxCraCashflowUpdatesUpdateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SandboxCraCashflowUpdatesUpdateResponse](src/ThePlaidApi/Models/SandboxCraCashflowUpdatesUpdateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SandboxFdxConsentSeedResponse&gt; SandboxFdxConsentSeed(SandboxFdxConsentSeedOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/sandbox/fdx/consent/seed` creates a test FDX consent grant (and a backing Item) for a data provider's customer in Sandbox, so the FDX Consent API endpoints can be exercised end-to-end without a live data provider connection.

`customer_id` is the data provider's identifier for the end user and `application_id` identifies the data recipient application the consent is granted to; both are required. Optionally provide `consent_id` (a UUIDv4) to control the seeded grant's identifier; one is generated when omitted. The seeded grant is returned by `/fdx/consents` and `/fdx/consents/{consentId}`, and can be revoked via `/fdx/consents/{consentId}/revocation`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SandboxFdxConsentSeed(new SandboxFdxConsentSeedOperationRequest
    {
        Body = new SandboxFdxConsentSeedRequest
        {
            CustomerId = "some example string",
            ApplicationId = "some example string",
        },
    });
    // TODO: Handle 'response' of type SandboxFdxConsentSeedResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SandboxFdxConsentSeedOperationRequest](src/ThePlaidApi/Requests/SandboxFdxConsentSeedOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SandboxFdxConsentSeedResponse](src/ThePlaidApi/Models/SandboxFdxConsentSeedResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SandboxIncomeFireWebhookResponse&gt; SandboxIncomeFireWebhook(SandboxIncomeFireWebhookOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/sandbox/income/fire_webhook` endpoint to manually trigger a Payroll or Document Income webhook in the Sandbox environment.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SandboxIncomeFireWebhook(new SandboxIncomeFireWebhookOperationRequest
    {
        Body = new SandboxIncomeFireWebhookRequest
        {
            ItemId = "some example string",
            Webhook = "some example string",
            WebhookCode = SandboxIncomeWebhookFireRequestWebhookCode.IncomeVerification,
        },
    });
    // TODO: Handle 'response' of type SandboxIncomeFireWebhookResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SandboxIncomeFireWebhookOperationRequest](src/ThePlaidApi/Requests/SandboxIncomeFireWebhookOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SandboxIncomeFireWebhookResponse](src/ThePlaidApi/Models/SandboxIncomeFireWebhookResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SandboxItemApplicationSeedResponse&gt; SandboxItemApplicationSeed(SandboxItemApplicationSeedOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/sandbox/item/application/seed` creates a test connected application on an existing Permissions Manager Item's login. The seeded application will appear in subsequent calls to `/item/application/list`.

The `access_token` must belong to a Permissions Manager Item created via `/item/import` in Sandbox. The `application_id` identifies the application to seed as a connected app. To disconnect a seeded application, use `/item/application/unlink`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SandboxItemApplicationSeed(new SandboxItemApplicationSeedOperationRequest
    {
        Body = new SandboxItemApplicationSeedRequest
        {
            AccessToken = "some example string",
            ApplicationId = "some example string",
        },
    });
    // TODO: Handle 'response' of type SandboxItemApplicationSeedResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SandboxItemApplicationSeedOperationRequest](src/ThePlaidApi/Requests/SandboxItemApplicationSeedOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SandboxItemApplicationSeedResponse](src/ThePlaidApi/Models/SandboxItemApplicationSeedResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SandboxItemFireWebhookResponse&gt; SandboxItemFireWebhook(SandboxItemFireWebhookOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/sandbox/item/fire_webhook` endpoint is used to test that code correctly handles webhooks. This endpoint can trigger the following webhooks:

`DEFAULT_UPDATE`: Webhook to be fired for a given Sandbox Item simulating a default update event for the respective product as specified with the `webhook_type` in the request body. Valid Sandbox `DEFAULT_UPDATE` webhook types include: `AUTH`, `IDENTITY`, `TRANSACTIONS`, `INVESTMENTS_TRANSACTIONS`, `LIABILITIES`, `HOLDINGS`. If the Item does not support the product, a `SANDBOX_PRODUCT_NOT_ENABLED` error will result.

`NEW_ACCOUNTS_AVAILABLE`: Fired to indicate that a new account is available on the Item and you can launch update mode to request access to it.

`SMS_MICRODEPOSITS_VERIFICATION`: Fired when a given Same-Day Micro-deposit Item is verified via SMS verification.

`LOGIN_REPAIRED`: Fired when an Item recovers from the `ITEM_LOGIN_REQUIRED` without the user going through update mode in your app.

`PENDING_DISCONNECT`: Fired when an Item will stop working in the near future (e.g. due to a planned bank migration) and must be sent through update mode to continue working.

`RECURRING_TRANSACTIONS_UPDATE`: Recurring Transactions webhook to be fired for a given Sandbox Item. If the Item does not support Recurring Transactions, a `SANDBOX_PRODUCT_NOT_ENABLED` error will result.

`SYNC_UPDATES_AVAILABLE`: Transactions webhook to be fired for a given Sandbox Item.  If the Item does not support Transactions, a `SANDBOX_PRODUCT_NOT_ENABLED` error will result.

`PRODUCT_READY`: Assets webhook to be fired when a given asset report has been successfully generated. If the Item does not support Assets, a `SANDBOX_PRODUCT_NOT_ENABLED` error will result.

`ERROR`: Assets webhook to be fired when asset report generation has failed. If the Item does not support Assets, a `SANDBOX_PRODUCT_NOT_ENABLED` error will result.

`USER_PERMISSION_REVOKED`: Indicates an end user has revoked the permission that they previously granted to access an Item. May not always fire upon revocation, as some institutions' consent portals do not trigger this webhook. Upon receiving this webhook, it is recommended to delete any stored data from Plaid associated with the account or Item.

`USER_ACCOUNT_REVOKED`: Fired when an end user has revoked access to their account on the Data Provider's portal. This webhook is currently sent only for PNC Items, but may be sent in the future for other financial institutions. Upon receiving this webhook, it is recommended to delete any stored data from Plaid associated with the account or Item.

Note that this endpoint is provided for developer ease-of-use and is not required for testing webhooks; webhooks will also fire in Sandbox under the same conditions that they would in Production (except for webhooks of type `TRANSFER`).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SandboxItemFireWebhook(new SandboxItemFireWebhookOperationRequest
    {
        Body = new SandboxItemFireWebhookRequest
        {
            AccessToken = "some example string",
            WebhookCode = WebhookCode.DefaultUpdate,
        },
    });
    // TODO: Handle 'response' of type SandboxItemFireWebhookResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SandboxItemFireWebhookOperationRequest](src/ThePlaidApi/Requests/SandboxItemFireWebhookOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SandboxItemFireWebhookResponse](src/ThePlaidApi/Models/SandboxItemFireWebhookResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SandboxItemResetLoginResponse&gt; SandboxItemResetLogin(SandboxItemResetLoginOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/sandbox/item/reset_login` forces an Item into an `ITEM_LOGIN_REQUIRED` state in order to simulate an Item whose login is no longer valid. This makes it easy to test Link's [update mode](https://plaid.com/docs/link/update-mode) flow in the Sandbox environment.  After calling `/sandbox/item/reset_login`, you can then use Plaid Link update mode to restore the Item to a good state. An `ITEM_LOGIN_REQUIRED` webhook will also be fired after a call to this endpoint, if one is associated with the Item.
In the Sandbox, Items will transition to an `ITEM_LOGIN_REQUIRED` error state automatically after 30 days, even if this endpoint is not called.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SandboxItemResetLogin(new SandboxItemResetLoginOperationRequest
    {
        Body = new SandboxItemResetLoginRequest { AccessToken = "some example string" },
    });
    // TODO: Handle 'response' of type SandboxItemResetLoginResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SandboxItemResetLoginOperationRequest](src/ThePlaidApi/Requests/SandboxItemResetLoginOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SandboxItemResetLoginResponse](src/ThePlaidApi/Models/SandboxItemResetLoginResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SandboxItemSetVerificationStatusResponse&gt; SandboxItemSetVerificationStatus(SandboxItemSetVerificationStatusOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/sandbox/item/set_verification_status` endpoint can be used to change the verification status of an Item in the Sandbox in order to simulate the Automated Micro-deposit flow.

For more information on testing Automated Micro-deposits in Sandbox, see [Auth full coverage testing](https://plaid.com/docs/auth/coverage/testing#).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SandboxItemSetVerificationStatus(new SandboxItemSetVerificationStatusOperationRequest
    {
        Body = new SandboxItemSetVerificationStatusRequest
        {
            AccessToken = "some example string",
            AccountId = "some example string",
            VerificationStatus = VerificationStatus1.AutomaticallyVerified,
        },
    });
    // TODO: Handle 'response' of type SandboxItemSetVerificationStatusResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SandboxItemSetVerificationStatusOperationRequest](src/ThePlaidApi/Requests/SandboxItemSetVerificationStatusOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SandboxItemSetVerificationStatusResponse](src/ThePlaidApi/Models/SandboxItemSetVerificationStatusResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;object&gt; SandboxOauthSelectAccounts(SandboxOauthSelectAccountsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Save the selected accounts when connecting to the Platypus OAuth institution

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SandboxOauthSelectAccounts(new SandboxOauthSelectAccountsOperationRequest
    {
        Body = new SandboxOauthSelectAccountsRequest
        {
            OauthStateId = "some example string",
            Accounts = ["some example string"],
        },
    });
    // TODO: Handle 'response' of type object
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SandboxOauthSelectAccountsOperationRequest](src/ThePlaidApi/Requests/SandboxOauthSelectAccountsOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>object</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SandboxPaymentProfileResetLoginResponse&gt; SandboxPaymentProfileResetLogin(SandboxPaymentProfileResetLoginOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/sandbox/payment_profile/reset_login` forces a Payment Profile into a state where the login is no longer valid. This makes it easy to test update mode for Payment Profile in the Sandbox environment.

 After calling `/sandbox/payment_profile/reset_login`, calls to the `/transfer/authorization/create` with the Payment Profile will result in a `decision_rationale` `PAYMENT_PROFILE_LOGIN_REQUIRED`. You can then use update mode for Payment Profile to restore it into a good state.

 In order to invoke this endpoint, you must first [create a Payment Profile](https://plaid.com/docs/transfer/add-to-app/#create-a-payment-profile-optional) and [go through the Link flow](https://plaid.com/docs/transfer/add-to-app/#create-a-link-token).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SandboxPaymentProfileResetLogin(new SandboxPaymentProfileResetLoginOperationRequest
    {
        Body = new SandboxPaymentProfileResetLoginRequest { PaymentProfileToken = "some example string" },
    });
    // TODO: Handle 'response' of type SandboxPaymentProfileResetLoginResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SandboxPaymentProfileResetLoginOperationRequest](src/ThePlaidApi/Requests/SandboxPaymentProfileResetLoginOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SandboxPaymentProfileResetLoginResponse](src/ThePlaidApi/Models/SandboxPaymentProfileResetLoginResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SandboxPaymentSimulateResponse&gt; SandboxPaymentSimulate(SandboxPaymentSimulateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/sandbox/payment/simulate` endpoint to simulate various payment events in the Sandbox environment. This endpoint will trigger the corresponding payment status webhook.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SandboxPaymentSimulate(new SandboxPaymentSimulateOperationRequest
    {
        Body = new SandboxPaymentSimulateRequest
        {
            PaymentId = "some example string",
            Webhook = "some example string",
            Status = "some example string",
        },
    });
    // TODO: Handle 'response' of type SandboxPaymentSimulateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SandboxPaymentSimulateOperationRequest](src/ThePlaidApi/Requests/SandboxPaymentSimulateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SandboxPaymentSimulateResponse](src/ThePlaidApi/Models/SandboxPaymentSimulateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SandboxProcessorTokenCreateResponse&gt; SandboxProcessorTokenCreate(SandboxProcessorTokenCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/sandbox/processor_token/create` endpoint to create a valid `processor_token` for an arbitrary institution ID and test credentials. The created `processor_token` corresponds to a new Sandbox Item. You can then use this `processor_token` with the `/processor/` API endpoints in Sandbox. You can also use `/sandbox/processor_token/create` with the [`user_custom` test username](https://plaid.com/docs/sandbox/user-custom) to generate a test account with custom data.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SandboxProcessorTokenCreate(new SandboxProcessorTokenCreateOperationRequest
    {
        Body = new SandboxProcessorTokenCreateRequest { InstitutionId = "some example string" },
    });
    // TODO: Handle 'response' of type SandboxProcessorTokenCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SandboxProcessorTokenCreateOperationRequest](src/ThePlaidApi/Requests/SandboxProcessorTokenCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SandboxProcessorTokenCreateResponse](src/ThePlaidApi/Models/SandboxProcessorTokenCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SandboxPublicTokenCreateResponse&gt; SandboxPublicTokenCreate(SandboxPublicTokenCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/sandbox/public_token/create` endpoint to create a valid `public_token`  for an arbitrary institution ID, initial products, and test credentials. The created `public_token` maps to a new Sandbox Item. You can then call `/item/public_token/exchange` to exchange the `public_token` for an `access_token` and perform all API actions. `/sandbox/public_token/create` can also be used with the [`user_custom` test username](https://plaid.com/docs/sandbox/user-custom) to generate a test account with custom data, or with Plaid's [pre-populated Sandbox test accounts](https://plaid.com/docs/sandbox/test-credentials/).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SandboxPublicTokenCreate(new SandboxPublicTokenCreateOperationRequest
    {
        Body = new SandboxPublicTokenCreateRequest
        {
            InstitutionId = "some example string",
            InitialProducts = [Products.Assets],
        },
    });
    // TODO: Handle 'response' of type SandboxPublicTokenCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SandboxPublicTokenCreateOperationRequest](src/ThePlaidApi/Requests/SandboxPublicTokenCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SandboxPublicTokenCreateResponse](src/ThePlaidApi/Models/SandboxPublicTokenCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SandboxTransactionsCreateResponse&gt; SandboxTransactionsCreate(SandboxTransactionsCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/sandbox/transactions/create` endpoint to create new transactions for an existing Item. This endpoint can be used to add up to 10 transactions to any Item at a time.

This endpoint can only be used with Items that were created in the Sandbox environment using the `user_transactions_dynamic` test user. You can use this to add transactions to test the `/transactions/get` and `/transactions/sync` endpoints.

Custom transactions are only applied to the depository account. Support for per-account targeting may be added in the future.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SandboxTransactionsCreate(new SandboxTransactionsCreateOperationRequest
    {
        Body = new SandboxTransactionsCreateRequest
        {
            AccessToken = "some example string",
            Transactions = [
                new CustomSandboxTransaction
                {
                    DateTransacted = DateTimeOffset.Parse("2024-01-15T00:00:00Z"),
                    DatePosted = DateTimeOffset.Parse("2024-01-15T00:00:00Z"),
                    Amount = 1.5d,
                    Description = "some example string",
                },
            ],
        },
    });
    // TODO: Handle 'response' of type SandboxTransactionsCreateResponse
}
catch (ApiException<SandboxTransactionsCreateError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error?
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SandboxTransactionsCreateOperationRequest](src/ThePlaidApi/Requests/SandboxTransactionsCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SandboxTransactionsCreateResponse](src/ThePlaidApi/Models/SandboxTransactionsCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[SandboxTransactionsCreateError](src/ThePlaidApi/Errors/SandboxTransactionsCreateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SandboxTransferFireWebhookResponse&gt; SandboxTransferFireWebhook(SandboxTransferFireWebhookOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/sandbox/transfer/fire_webhook` endpoint to manually trigger a `TRANSFER_EVENTS_UPDATE` webhook in the Sandbox environment.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SandboxTransferFireWebhook(new SandboxTransferFireWebhookOperationRequest
    {
        Body = new SandboxTransferFireWebhookRequest { Webhook = "some example string" },
    });
    // TODO: Handle 'response' of type SandboxTransferFireWebhookResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SandboxTransferFireWebhookOperationRequest](src/ThePlaidApi/Requests/SandboxTransferFireWebhookOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SandboxTransferFireWebhookResponse](src/ThePlaidApi/Models/SandboxTransferFireWebhookResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SandboxTransferLedgerDepositSimulateResponse&gt; SandboxTransferLedgerDepositSimulate(SandboxTransferLedgerDepositSimulateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/sandbox/transfer/ledger/deposit/simulate` endpoint to simulate a ledger deposit event in the Sandbox environment.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SandboxTransferLedgerDepositSimulate(
        new SandboxTransferLedgerDepositSimulateOperationRequest
        {
            Body = new SandboxTransferLedgerDepositSimulateRequest
            {
                SweepId = "some example string",
                EventType = TransferLedgerSweepSimulateEventType.SweepPosted,
            },
        });
    // TODO: Handle 'response' of type SandboxTransferLedgerDepositSimulateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SandboxTransferLedgerDepositSimulateOperationRequest](src/ThePlaidApi/Requests/SandboxTransferLedgerDepositSimulateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SandboxTransferLedgerDepositSimulateResponse](src/ThePlaidApi/Models/SandboxTransferLedgerDepositSimulateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SandboxTransferLedgerSimulateAvailableResponse&gt; SandboxTransferLedgerSimulateAvailable(SandboxTransferLedgerSimulateAvailableOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/sandbox/transfer/ledger/simulate_available` endpoint to simulate converting pending balance to available balance for all originators in the Sandbox environment.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SandboxTransferLedgerSimulateAvailable(
        new SandboxTransferLedgerSimulateAvailableOperationRequest
        {
            Body = new SandboxTransferLedgerSimulateAvailableRequest(),
        });
    // TODO: Handle 'response' of type SandboxTransferLedgerSimulateAvailableResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SandboxTransferLedgerSimulateAvailableOperationRequest](src/ThePlaidApi/Requests/SandboxTransferLedgerSimulateAvailableOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SandboxTransferLedgerSimulateAvailableResponse](src/ThePlaidApi/Models/SandboxTransferLedgerSimulateAvailableResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SandboxTransferLedgerWithdrawSimulateResponse&gt; SandboxTransferLedgerWithdrawSimulate(SandboxTransferLedgerWithdrawSimulateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/sandbox/transfer/ledger/withdraw/simulate` endpoint to simulate a ledger withdraw event in the Sandbox environment.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SandboxTransferLedgerWithdrawSimulate(
        new SandboxTransferLedgerWithdrawSimulateOperationRequest
        {
            Body = new SandboxTransferLedgerWithdrawSimulateRequest
            {
                SweepId = "some example string",
                EventType = TransferLedgerSweepSimulateEventType.SweepPosted,
            },
        });
    // TODO: Handle 'response' of type SandboxTransferLedgerWithdrawSimulateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SandboxTransferLedgerWithdrawSimulateOperationRequest](src/ThePlaidApi/Requests/SandboxTransferLedgerWithdrawSimulateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SandboxTransferLedgerWithdrawSimulateResponse](src/ThePlaidApi/Models/SandboxTransferLedgerWithdrawSimulateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SandboxTransferRefundSimulateResponse&gt; SandboxTransferRefundSimulate(SandboxTransferRefundSimulateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/sandbox/transfer/refund/simulate` endpoint to simulate a refund event in the Sandbox environment.  Note that while an event will be simulated and will appear when using endpoints such as `/transfer/event/sync` or `/transfer/event/list`, no transactions will actually take place and funds will not move between accounts, even within the Sandbox.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SandboxTransferRefundSimulate(new SandboxTransferRefundSimulateOperationRequest
    {
        Body = new SandboxTransferRefundSimulateRequest
        {
            RefundId = "some example string",
            EventType = "some example string",
        },
    });
    // TODO: Handle 'response' of type SandboxTransferRefundSimulateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SandboxTransferRefundSimulateOperationRequest](src/ThePlaidApi/Requests/SandboxTransferRefundSimulateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SandboxTransferRefundSimulateResponse](src/ThePlaidApi/Models/SandboxTransferRefundSimulateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SandboxTransferRepaymentSimulateResponse&gt; SandboxTransferRepaymentSimulate(SandboxTransferRepaymentSimulateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/sandbox/transfer/repayment/simulate` endpoint to trigger the creation of a repayment. As a side effect of calling this route, a repayment is created that includes all unreimbursed returns of guaranteed transfers. If there are no such returns, a 400 error is returned.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SandboxTransferRepaymentSimulate(new SandboxTransferRepaymentSimulateOperationRequest
    {
        Body = new SandboxTransferRepaymentSimulateRequest(),
    });
    // TODO: Handle 'response' of type SandboxTransferRepaymentSimulateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SandboxTransferRepaymentSimulateOperationRequest](src/ThePlaidApi/Requests/SandboxTransferRepaymentSimulateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SandboxTransferRepaymentSimulateResponse](src/ThePlaidApi/Models/SandboxTransferRepaymentSimulateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SandboxTransferSimulateResponse&gt; SandboxTransferSimulate(SandboxTransferSimulateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/sandbox/transfer/simulate` endpoint to simulate a transfer event in the Sandbox environment.  Note that while an event will be simulated and will appear when using endpoints such as `/transfer/event/sync` or `/transfer/event/list`, no transactions will actually take place and funds will not move between accounts, even within the Sandbox.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SandboxTransferSimulate(new SandboxTransferSimulateOperationRequest
    {
        Body = new SandboxTransferSimulateRequest
        {
            TransferId = "some example string",
            EventType = "some example string",
        },
    });
    // TODO: Handle 'response' of type SandboxTransferSimulateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SandboxTransferSimulateOperationRequest](src/ThePlaidApi/Requests/SandboxTransferSimulateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SandboxTransferSimulateResponse](src/ThePlaidApi/Models/SandboxTransferSimulateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SandboxTransferSweepSimulateResponse&gt; SandboxTransferSweepSimulate(SandboxTransferSweepSimulateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/sandbox/transfer/sweep/simulate` endpoint to create a sweep and associated events in the Sandbox environment. Upon calling this endpoint, all transfers with a sweep status of `swept` will become `swept_settled`, all `posted` or `pending` transfers with a sweep status of `unswept` will become `swept`, and all `returned` transfers with a sweep status of `swept` will become `return_swept`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SandboxTransferSweepSimulate(new SandboxTransferSweepSimulateOperationRequest
    {
        Body = new SandboxTransferSweepSimulateRequest(),
    });
    // TODO: Handle 'response' of type SandboxTransferSweepSimulateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SandboxTransferSweepSimulateOperationRequest](src/ThePlaidApi/Requests/SandboxTransferSweepSimulateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SandboxTransferSweepSimulateResponse](src/ThePlaidApi/Models/SandboxTransferSweepSimulateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SandboxTransferTestClockAdvanceResponse&gt; SandboxTransferTestClockAdvance(SandboxTransferTestClockAdvanceOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/sandbox/transfer/test_clock/advance` endpoint to advance a `test_clock` in the Sandbox environment.

A test clock object represents an independent timeline and has a `virtual_time` field indicating the current timestamp of the timeline. A test clock can be advanced by incrementing `virtual_time`, but may never go back to a lower `virtual_time`.

If a test clock is advanced, we will simulate the changes that ought to occur during the time that elapsed.

For example, a client creates a weekly recurring transfer with a test clock set at t. When the client advances the test clock by setting `virtual_time` = t + 15 days, 2 new originations should be created, along with the webhook events.

The advancement of the test clock from its current `virtual_time` should be limited such that there are no more than 20 originations resulting from the advance operation on each `recurring_transfer` associated with the `test_clock`.

For example, if the recurring transfer associated with this test clock originates once every 4 weeks, you can advance the `virtual_time` up to 80 weeks on each API call.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SandboxTransferTestClockAdvance(new SandboxTransferTestClockAdvanceOperationRequest
    {
        Body = new SandboxTransferTestClockAdvanceRequest
        {
            TestClockId = "some example string",
            NewVirtualTime = DateTimeOffset.Parse("2024-01-15T09:30:00Z"),
        },
    });
    // TODO: Handle 'response' of type SandboxTransferTestClockAdvanceResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SandboxTransferTestClockAdvanceOperationRequest](src/ThePlaidApi/Requests/SandboxTransferTestClockAdvanceOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SandboxTransferTestClockAdvanceResponse](src/ThePlaidApi/Models/SandboxTransferTestClockAdvanceResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SandboxTransferTestClockCreateResponse&gt; SandboxTransferTestClockCreate(SandboxTransferTestClockCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/sandbox/transfer/test_clock/create` endpoint to create a `test_clock` in the Sandbox environment.

A test clock object represents an independent timeline and has a `virtual_time` field indicating the current timestamp of the timeline. Test clocks are used for testing recurring transfers in Sandbox.

A test clock can be associated with up to 5 recurring transfers.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SandboxTransferTestClockCreate(new SandboxTransferTestClockCreateOperationRequest
    {
        Body = new SandboxTransferTestClockCreateRequest(),
    });
    // TODO: Handle 'response' of type SandboxTransferTestClockCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SandboxTransferTestClockCreateOperationRequest](src/ThePlaidApi/Requests/SandboxTransferTestClockCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SandboxTransferTestClockCreateResponse](src/ThePlaidApi/Models/SandboxTransferTestClockCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SandboxTransferTestClockGetResponse&gt; SandboxTransferTestClockGet(SandboxTransferTestClockGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/sandbox/transfer/test_clock/get` endpoint to get a `test_clock` in the Sandbox environment.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SandboxTransferTestClockGet(new SandboxTransferTestClockGetOperationRequest
    {
        Body = new SandboxTransferTestClockGetRequest { TestClockId = "some example string" },
    });
    // TODO: Handle 'response' of type SandboxTransferTestClockGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SandboxTransferTestClockGetOperationRequest](src/ThePlaidApi/Requests/SandboxTransferTestClockGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SandboxTransferTestClockGetResponse](src/ThePlaidApi/Models/SandboxTransferTestClockGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SandboxTransferTestClockListResponse&gt; SandboxTransferTestClockList(SandboxTransferTestClockListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/sandbox/transfer/test_clock/list` endpoint to see a list of all your test clocks in the Sandbox environment, by ascending `virtual_time`. Results are paginated; use the `count` and `offset` query parameters to retrieve the desired test clocks.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SandboxTransferTestClockList(new SandboxTransferTestClockListOperationRequest
    {
        Body = new SandboxTransferTestClockListRequest(),
    });
    // TODO: Handle 'response' of type SandboxTransferTestClockListResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SandboxTransferTestClockListOperationRequest](src/ThePlaidApi/Requests/SandboxTransferTestClockListOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SandboxTransferTestClockListResponse](src/ThePlaidApi/Models/SandboxTransferTestClockListResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SandboxUserResetLoginResponse&gt; SandboxUserResetLogin(SandboxUserResetLoginOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/sandbox/user/reset_login` functions the same as `/sandbox/item/reset_login`, but will modify Items related to a User. This endpoint forces each Item into an `ITEM_LOGIN_REQUIRED` state in order to simulate an Item whose login is no longer valid. This makes it easy to test Link's [update mode](https://plaid.com/docs/link/update-mode) flow in the Sandbox environment.  After calling `/sandbox/user/reset_login`, you can then use Plaid Link update mode to restore Items associated with the User to a good state. An `ITEM_LOGIN_REQUIRED` webhook will also be fired after a call to this endpoint, if one is associated with the Item.
In the Sandbox, Items will transition to an `ITEM_LOGIN_REQUIRED` error state automatically after 30 days, even if this endpoint is not called.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SandboxUserResetLogin(new SandboxUserResetLoginOperationRequest
    {
        Body = new SandboxUserResetLoginRequest(),
    });
    // TODO: Handle 'response' of type SandboxUserResetLoginResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SandboxUserResetLoginOperationRequest](src/ThePlaidApi/Requests/SandboxUserResetLoginOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SandboxUserResetLoginResponse](src/ThePlaidApi/Models/SandboxUserResetLoginResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SessionTokenCreateResponse&gt; SessionTokenCreate(SessionTokenCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/session/token/create` is used to create a Link token for Layer. The returned Link token is used as a parameter when initializing the Link SDK. For more details, see the [Link flow overview](https://plaid.com/docs/link/#link-flow-overview).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SessionTokenCreate(new SessionTokenCreateOperationRequest
    {
        Body = new SessionTokenCreateRequest { TemplateId = "some example string" },
    });
    // TODO: Handle 'response' of type SessionTokenCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SessionTokenCreateOperationRequest](src/ThePlaidApi/Requests/SessionTokenCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SessionTokenCreateResponse](src/ThePlaidApi/Models/SessionTokenCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SignalDecisionReportResponse&gt; SignalDecisionReport(SignalDecisionReportOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

After you call `/signal/evaluate`, Plaid will normally infer the outcome from your Signal Rules. However, if you are not using Signal Rules, if the Signal Rules outcome was `REVIEW`, or if you take a different action than the one determined by the Signal Rules, you will need to call `/signal/decision/report`. This helps improve Signal Transaction Score accuracy for your account and is necessary for proper functioning of the rule performance and rule tuning capabilities in the Dashboard. If your effective decision changes after calling `/signal/decision/report` (for example, you indicated that you accepted a transaction, but later on, your payment processor rejected it, so it was never initiated), call `/signal/decision/report` again for the transaction to correct Plaid's records.

If you are using Plaid Transfer as your payment processor, you also do not need to call `/signal/decision/report`, as Plaid can infer outcomes from your Transfer activity.

If using a Balance-only ruleset, this endpoint will not impact scores (Balance does not use scores), but is necessary to view accurate transaction outcomes and tune rule logic in the Dashboard.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SignalDecisionReport(new SignalDecisionReportOperationRequest
    {
        Body = new SignalDecisionReportRequest { ClientTransactionId = "some example string", Initiated = true },
    });
    // TODO: Handle 'response' of type SignalDecisionReportResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SignalDecisionReportOperationRequest](src/ThePlaidApi/Requests/SignalDecisionReportOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SignalDecisionReportResponse](src/ThePlaidApi/Models/SignalDecisionReportResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SignalEvaluateResponse&gt; SignalEvaluate(SignalEvaluateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use `/signal/evaluate` to evaluate a planned ACH transaction to get a return risk assessment and additional risk signals.

Before using `/signal/evaluate`, you must first [create a ruleset](https://plaid.com/docs/signal/signal-rules/) in the Dashboard under [**Signal->Rules**](https://dashboard.plaid.com/signal/risk-profiles).

`/signal/evaluate` can be used with either Signal Transaction Scores or the Balance product. Which product is used will be determined by the `ruleset_key` that you provide. For more details, see [Signal Rules](https://plaid.com/docs/signal/signal-rules/).

Note: This request may have higher latency when using a Balance-only ruleset. This is because Plaid must communicate directly with the institution to request data. Balance-only rulesets may have latency of up to 30 seconds or more; if you encounter errors, you may find it necessary to adjust your timeout period when making requests.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SignalEvaluate(new SignalEvaluateOperationRequest
    {
        Body = new SignalEvaluateRequest
        {
            AccessToken = "some example string",
            AccountId = "some example string",
            ClientTransactionId = "some example string",
            Amount = 1.5d,
        },
    });
    // TODO: Handle 'response' of type SignalEvaluateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SignalEvaluateOperationRequest](src/ThePlaidApi/Requests/SignalEvaluateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SignalEvaluateResponse](src/ThePlaidApi/Models/SignalEvaluateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SignalPrepareResponse&gt; SignalPrepare(SignalPrepareOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

When an Item is not initialized with `signal`, call `/signal/prepare` to opt-in that Item to the data collection process used to develop a Signal Transaction Score. This should be done on Items where `signal` was added in the `additional_consented_products` array but not in the `products`, `optional_products`, or `required_if_supported_products` array. If `/signal/prepare` is skipped on an Item that is not initialized with `signal`, the initial call to `/signal/evaluate` on that Item will be less accurate, because Plaid will have access to less data for computing the Signal Transaction Score.

If your integration is purely Balance-only, this endpoint will have no effect, as Balance-only rulesets do not calculate a Signal Transaction Score.

If run on an Item that is already initialized with `signal`, this endpoint will return a 200 response and will not modify the Item.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SignalPrepare(new SignalPrepareOperationRequest
    {
        Body = new SignalPrepareRequest { AccessToken = "some example string" },
    });
    // TODO: Handle 'response' of type SignalPrepareResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SignalPrepareOperationRequest](src/ThePlaidApi/Requests/SignalPrepareOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SignalPrepareResponse](src/ThePlaidApi/Models/SignalPrepareResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SignalReturnReportResponse&gt; SignalReturnReport(SignalReturnReportOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Call the `/signal/return/report` endpoint to report a returned transaction that was previously sent to the `/signal/evaluate` endpoint. Your feedback will be used by the model to incorporate the latest risk trends into your scores and tune rule logic. If using a Balance-only ruleset, this endpoint will not impact scores (as Balance does not use scores), but is necessary to view accurate transaction outcomes and tune rule logic in the Dashboard.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SignalReturnReport(new SignalReturnReportOperationRequest
    {
        Body = new SignalReturnReportRequest
        {
            ClientTransactionId = "some example string",
            ReturnCode = "some example string",
        },
    });
    // TODO: Handle 'response' of type SignalReturnReportResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SignalReturnReportOperationRequest](src/ThePlaidApi/Requests/SignalReturnReportOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SignalReturnReportResponse](src/ThePlaidApi/Models/SignalReturnReportResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SignalScheduleResponse&gt; SignalSchedule(SignalScheduleOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use `/signal/schedule` to schedule a planned ACH transaction.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SignalSchedule(new SignalScheduleOperationRequest
    {
        Body = new SignalScheduleRequest
        {
            AccessToken = "some example string",
            AccountId = "some example string",
            ClientTransactionId = "some example string",
            Amount = 1.5d,
        },
    });
    // TODO: Handle 'response' of type SignalScheduleResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SignalScheduleOperationRequest](src/ThePlaidApi/Requests/SignalScheduleOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SignalScheduleResponse](src/ThePlaidApi/Models/SignalScheduleResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task StatementsDownload(StatementsDownloadOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/statements/download` endpoint retrieves a single statement PDF in binary format.  The response will contain a `Plaid-Content-Hash` header containing a SHA 256 checksum of the statement. This can be used to verify that the file being sent by Plaid is the same file that was downloaded to your system.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.StatementsDownload(new StatementsDownloadOperationRequest
    {
        Body = new StatementsDownloadRequest
        {
            AccessToken = "some example string",
            StatementId = "some example string",
        },
    });
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[StatementsDownloadOperationRequest](src/ThePlaidApi/Requests/StatementsDownloadOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;StatementsListResponse&gt; StatementsList(StatementsListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/statements/list` endpoint retrieves a list of all statements associated with an Item.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.StatementsList(new StatementsListOperationRequest
    {
        Body = new StatementsListRequest { AccessToken = "some example string" },
    });
    // TODO: Handle 'response' of type StatementsListResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[StatementsListOperationRequest](src/ThePlaidApi/Requests/StatementsListOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[StatementsListResponse](src/ThePlaidApi/Models/StatementsListResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;StatementsRefreshResponse&gt; StatementsRefresh(StatementsRefreshOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/statements/refresh` initiates an on-demand extraction to fetch the statements for the provided dates.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.StatementsRefresh(new StatementsRefreshOperationRequest
    {
        Body = new StatementsRefreshRequest
        {
            AccessToken = "some example string",
            StartDate = DateTimeOffset.Parse("2024-01-15T00:00:00Z"),
            EndDate = DateTimeOffset.Parse("2024-01-15T00:00:00Z"),
        },
    });
    // TODO: Handle 'response' of type StatementsRefreshResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[StatementsRefreshOperationRequest](src/ThePlaidApi/Requests/StatementsRefreshOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[StatementsRefreshResponse](src/ThePlaidApi/Models/StatementsRefreshResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransactionsEnhanceGetResponse&gt; TransactionsEnhance(TransactionsEnhanceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/beta/transactions/v1/enhance` endpoint enriches raw transaction data provided directly by clients.

The product is currently in beta.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransactionsEnhance(new TransactionsEnhanceRequest
    {
        Body = new TransactionsEnhanceGetRequest
        {
            AccountType = "some example string",
            Transactions = [
                new ClientProvidedRawTransaction
                {
                    Id = "some example string",
                    Description = "some example string",
                    Amount = 1.5d,
                    IsoCurrencyCode = "some example string",
                },
            ],
        },
    });
    // TODO: Handle 'response' of type TransactionsEnhanceGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransactionsEnhanceRequest](src/ThePlaidApi/Requests/TransactionsEnhanceRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransactionsEnhanceGetResponse](src/ThePlaidApi/Models/TransactionsEnhanceGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransactionsEnrichResponse&gt; TransactionsEnrich(TransactionsEnrichOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/transactions/enrich` endpoint enriches raw transaction data generated by your own banking products or retrieved from other non-Plaid sources.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransactionsEnrich(new TransactionsEnrichOperationRequest
    {
        Body = new TransactionsEnrichRequest
        {
            AccountType = "some example string",
            Transactions = [
                new ClientProvidedTransaction
                {
                    Id = "some example string",
                    Description = "some example string",
                    Amount = 1.5d,
                    Direction = EnrichTransactionDirection.Inflow,
                    IsoCurrencyCode = "some example string",
                },
            ],
        },
    });
    // TODO: Handle 'response' of type TransactionsEnrichResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransactionsEnrichOperationRequest](src/ThePlaidApi/Requests/TransactionsEnrichOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransactionsEnrichResponse](src/ThePlaidApi/Models/TransactionsEnrichResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransactionsGetResponse&gt; TransactionsGet(TransactionsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Note: All new implementations are encouraged to use `/transactions/sync` rather than `/transactions/get`. `/transactions/sync` provides the same functionality as `/transactions/get` and improves developer ease-of-use for handling transactions updates.
The `/transactions/get` endpoint allows developers to receive user-authorized transaction data for credit, depository, and some loan-type accounts (only those with account subtype `student` or `mortgage`; coverage may be limited). For transaction history from investment accounts, use the [Investments endpoint](https://plaid.com/docs/api/products/investments/) instead. Transaction data is standardized across financial institutions, and in many cases transactions are linked to a clean name, entity type, location, and category. Similarly, account data is standardized and returned with a clean name, number, balance, and other meta information where available.
Transactions are returned in reverse-chronological order, and the sequence of transaction ordering is stable and will not shift.  Transactions are not immutable and can also be removed altogether by the institution; a removed transaction will no longer appear in `/transactions/get`.  For more details, see [Pending and posted transactions](https://plaid.com/docs/transactions/transactions-data/#pending-and-posted-transactions).
Due to the potentially large number of transactions associated with an Item, results are paginated. Manipulate the `count` and `offset` parameters in conjunction with the `total_transactions` response body field to fetch all available transactions.
Data returned by `/transactions/get` will be the data available for the Item as of the most recent successful check for new transactions. Plaid typically checks for new data multiple times a day, but these checks may occur less frequently, such as once a day, depending on the institution. To find out when the Item was last updated, use the [Item Debugger](https://plaid.com/docs/account/activity/#troubleshooting-with-item-debugger) or call `/item/get`; the `item.status.transactions.last_successful_update` field will show the timestamp of the most recent successful update. To force Plaid to check for new transactions, you can use the `/transactions/refresh` endpoint.


Note that data may not be immediately available to `/transactions/get`. Plaid will begin to prepare transactions data upon Item link, if Link was initialized with `transactions`, or upon the first call to `/transactions/get`, if it wasn't. To be alerted when transaction data is ready to be fetched, listen for the [`INITIAL_UPDATE`](https://plaid.com/docs/api/products/transactions/#initial_update) and [`HISTORICAL_UPDATE`](https://plaid.com/docs/api/products/transactions/#historical_update) webhooks. If no transaction history is ready when `/transactions/get` is called, it will return a `PRODUCT_NOT_READY` error.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransactionsGet(new TransactionsGetOperationRequest
    {
        Body = new TransactionsGetRequest
        {
            AccessToken = "some example string",
            StartDate = DateTimeOffset.Parse("2024-01-15T00:00:00Z"),
            EndDate = DateTimeOffset.Parse("2024-01-15T00:00:00Z"),
        },
    });
    // TODO: Handle 'response' of type TransactionsGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransactionsGetOperationRequest](src/ThePlaidApi/Requests/TransactionsGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransactionsGetResponse](src/ThePlaidApi/Models/TransactionsGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransactionsRecurringGetResponse&gt; TransactionsRecurringGet(TransactionsRecurringGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/transactions/recurring/get` endpoint allows developers to receive a summary of the recurring outflow and inflow streams (expenses and deposits) from a user's checking, savings or credit card accounts. Additionally, Plaid provides key insights about each recurring stream including the category, merchant, last amount, and more. Developers can use these insights to build tools and experiences that help their users better manage cash flow, monitor subscriptions, reduce spend, and stay on track with bill payments.

This endpoint is offered as an add-on to Transactions. To request access to this endpoint, submit a [product access request](https://dashboard.plaid.com/team/products) or contact your Plaid account manager.

This endpoint can only be called on an Item that has already been initialized with Transactions (either during Link, by specifying it in `/link/token/create`; or after Link, by calling `/transactions/get` or `/transactions/sync`).

When using Recurring Transactions, for best results, make sure to use the [`days_requested`](https://plaid.com/docs/api/link/#link-token-create-request-transactions-days-requested) parameter to request at least 180 days of history when initializing Items with Transactions. Once all historical transactions have been fetched, call `/transactions/recurring/get` to receive the Recurring Transactions streams and subscribe to the [`RECURRING_TRANSACTIONS_UPDATE`](https://plaid.com/docs/api/products/transactions/#recurring_transactions_update) webhook. To know when historical transactions have been fetched, if you are using `/transactions/sync` listen for the [`SYNC_UPDATES_AVAILABLE`](https://plaid.com/docs/api/products/transactions/#SyncUpdatesAvailableWebhook-historical-update-complete) webhook and check that the `historical_update_complete` field in the payload is `true`. If using `/transactions/get`, listen for the [`HISTORICAL_UPDATE`](https://plaid.com/docs/api/products/transactions/#historical_update) webhook.

After the initial call, you can call the `/transactions/recurring/get` endpoint at any point in the future to retrieve the latest summary of recurring streams. Listen to the [`RECURRING_TRANSACTIONS_UPDATE`](https://plaid.com/docs/api/products/transactions/#recurring_transactions_update) webhook to be notified when new updates are available.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransactionsRecurringGet(new TransactionsRecurringGetOperationRequest
    {
        Body = new TransactionsRecurringGetRequest { AccessToken = "some example string" },
    });
    // TODO: Handle 'response' of type TransactionsRecurringGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransactionsRecurringGetOperationRequest](src/ThePlaidApi/Requests/TransactionsRecurringGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransactionsRecurringGetResponse](src/ThePlaidApi/Models/TransactionsRecurringGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransactionsRefreshResponse&gt; TransactionsRefresh(TransactionsRefreshOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/transactions/refresh` is an optional endpoint that initiates an on-demand extraction to fetch the newest transactions for an Item. The on-demand extraction takes place in addition to the periodic extractions that automatically occur one or more times per day for any Transactions-enabled Item. The Item must already have Transactions added as a product in order to call `/transactions/refresh`.

If changes to transactions are discovered after calling `/transactions/refresh`, Plaid will fire a webhook: for `/transactions/sync` users, [`SYNC_UPDATES_AVAILABLE`](https://plaid.com/docs/api/products/transactions/#sync_updates_available) will be fired if there are any transactions updated, added, or removed. For users of both `/transactions/sync` and `/transactions/get`, [`TRANSACTIONS_REMOVED`](https://plaid.com/docs/api/products/transactions/#transactions_removed) will be fired if any removed transactions are detected, and [`DEFAULT_UPDATE`](https://plaid.com/docs/api/products/transactions/#default_update) will be fired if any new transactions are detected. New transactions can be fetched by calling `/transactions/get` or `/transactions/sync`.

Note that the `/transactions/refresh` endpoint is not supported for Capital One (`ins_128026`) non-depository accounts and will result in a `PRODUCTS_NOT_SUPPORTED` error if called on an Item that contains only non-depository accounts from that institution.

As this endpoint triggers a synchronous request for fresh data, latency may be higher than for other Plaid endpoints (typically less than 10 seconds, but occasionally up to 30 seconds or more); if you encounter errors, you may find it necessary to adjust your timeout period when making requests.

`/transactions/refresh` is offered as an optional add-on to Transactions and has a separate [fee model](https://plaid.com/docs/account/billing/#per-request-flat-fee). To request access to this endpoint, submit a [product access request](https://dashboard.plaid.com/team/products) or contact your Plaid account manager.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransactionsRefresh(new TransactionsRefreshOperationRequest
    {
        Body = new TransactionsRefreshRequest { AccessToken = "some example string" },
    });
    // TODO: Handle 'response' of type TransactionsRefreshResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransactionsRefreshOperationRequest](src/ThePlaidApi/Requests/TransactionsRefreshOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransactionsRefreshResponse](src/ThePlaidApi/Models/TransactionsRefreshResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransactionsRulesCreateResponse&gt; TransactionsRulesCreate(TransactionsRulesCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/beta/transactions/rules/v1/create` endpoint creates transaction categorization rules.

Rules will be applied on the Item's transactions returned in `/transactions/get` response.

The product is currently in beta. To request access, contact transactions-feedback@plaid.com.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransactionsRulesCreate(new TransactionsRulesCreateOperationRequest
    {
        Body = new TransactionsRulesCreateRequest
        {
            ClientId = "7f57eb3d2a9j6480121fx361",
            Secret = "79g03eoofwl8240v776r2h667442119",
            ClientUserId = "your-client-user-id",
            PfcPrimaryCategory = "FOOD_AND_DRINK",
            PfcDetailedCategory = "FOOD_AND_DRINK_FAST_FOOD",
            RuleDetails = new TransactionsRuleDetails
            {
                Field = TransactionsRuleField.MerchantName,
                Type = TransactionsRuleType.SubstringMatch,
                Query = "Burger Shack",
            },
        },
    });
    // TODO: Handle 'response' of type TransactionsRulesCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransactionsRulesCreateOperationRequest](src/ThePlaidApi/Requests/TransactionsRulesCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransactionsRulesCreateResponse](src/ThePlaidApi/Models/TransactionsRulesCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransactionsRulesListResponse&gt; TransactionsRulesList(TransactionsRulesListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/beta/transactions/rules/v1/list` returns a list of transaction rules created for the Item associated with the access token.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransactionsRulesList(new TransactionsRulesListOperationRequest
    {
        Body = new TransactionsRulesListRequest
        {
            ClientId = "7f57eb3d2a9j6480121fx361",
            Secret = "79g03eoofwl8240v776r2h667442119",
            ClientUserId = "your-client-user-id",
        },
    });
    // TODO: Handle 'response' of type TransactionsRulesListResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransactionsRulesListOperationRequest](src/ThePlaidApi/Requests/TransactionsRulesListOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransactionsRulesListResponse](src/ThePlaidApi/Models/TransactionsRulesListResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransactionsRulesRemoveResponse&gt; TransactionsRulesRemove(TransactionsRulesRemoveOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/beta/transactions/rules/v1/remove` endpoint is used to remove a transaction rule.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransactionsRulesRemove(new TransactionsRulesRemoveOperationRequest
    {
        Body = new TransactionsRulesRemoveRequest
        {
            ClientId = "7f57eb3d2a9j6480121fx361",
            Secret = "79g03eoofwl8240v776r2h667442119",
            ClientUserId = "your-client-user-id",
            RuleId = "eVBnVMp7zdTJLkRNr33Rs6zr7KNJqBF",
        },
    });
    // TODO: Handle 'response' of type TransactionsRulesRemoveResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransactionsRulesRemoveOperationRequest](src/ThePlaidApi/Requests/TransactionsRulesRemoveOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransactionsRulesRemoveResponse](src/ThePlaidApi/Models/TransactionsRulesRemoveResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransactionsSyncResponse&gt; TransactionsSync(TransactionsSyncOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/transactions/sync` endpoint retrieves transactions associated with an Item and can fetch updates using a cursor to track which updates have already been seen.

For important instructions on integrating with `/transactions/sync`, see the [Transactions integration overview](https://plaid.com/docs/transactions/#integration-overview). If you are migrating from an existing integration using `/transactions/get`, see the [Transactions Sync migration guide](https://plaid.com/docs/transactions/sync-migration/).

This endpoint supports `credit`, `depository`, and some `loan`-type accounts (only those with account subtype `student` or `mortgage`). For `investments` accounts, use `/investments/transactions/get` instead.

When retrieving paginated updates, track both the `next_cursor` from the latest response and the original cursor from the first call in which `has_more` was `true`; if a call to `/transactions/sync` fails when retrieving a paginated update (e.g. due to the [`TRANSACTIONS_SYNC_MUTATION_DURING_PAGINATION`](https://plaid.com/docs/errors/transactions/#transactions_sync_mutation_during_pagination) error), the entire pagination request loop must be restarted beginning with the cursor for the first page of the update, rather than retrying only the single request that failed.

If transactions data is not yet available for the Item, which can happen if the Item was not initialized with transactions during the `/link/token/create` call or if `/transactions/sync` was called within a few seconds of Item creation, `/transactions/sync` will return empty transactions arrays.

Plaid typically checks for new transactions data between one and four times per day, depending on the institution. To find out when transactions were last updated for an Item, use the [Item Debugger](https://plaid.com/docs/account/activity/#troubleshooting-with-item-debugger) or call `/item/get`; the `item.status.transactions.last_successful_update` field will show the timestamp of the most recent successful update. To force Plaid to check for new transactions, use the `/transactions/refresh` endpoint.

To be alerted when new transactions are available, listen for the [`SYNC_UPDATES_AVAILABLE`](https://plaid.com/docs/api/products/transactions/#sync_updates_available) webhook.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransactionsSync(new TransactionsSyncOperationRequest
    {
        Body = new TransactionsSyncRequest { AccessToken = "some example string" },
    });
    // TODO: Handle 'response' of type TransactionsSyncResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransactionsSyncOperationRequest](src/ThePlaidApi/Requests/TransactionsSyncOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransactionsSyncResponse](src/ThePlaidApi/Models/TransactionsSyncResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransactionsUserInsightsGetResponse&gt; TransactionsUserInsightsGet(TransactionsUserInsightsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/beta/transactions/user_insights/v1/get` gets user insights for clients who have enriched data with `/transactions/enrich`.

The product is currently in beta.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransactionsUserInsightsGet(new TransactionsUserInsightsGetOperationRequest
    {
        Body = new TransactionsUserInsightsGetRequest { ClientUserId = "some example string" },
    });
    // TODO: Handle 'response' of type TransactionsUserInsightsGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransactionsUserInsightsGetOperationRequest](src/ThePlaidApi/Requests/TransactionsUserInsightsGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransactionsUserInsightsGetResponse](src/ThePlaidApi/Models/TransactionsUserInsightsGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferAuthorizationCancelResponse&gt; TransferAuthorizationCancel(TransferAuthorizationCancelOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/transfer/authorization/cancel` endpoint to cancel a transfer authorization. A transfer authorization is eligible for cancellation if it has not yet been used to create a transfer.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferAuthorizationCancel(new TransferAuthorizationCancelOperationRequest
    {
        Body = new TransferAuthorizationCancelRequest { AuthorizationId = "some example string" },
    });
    // TODO: Handle 'response' of type TransferAuthorizationCancelResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransferAuthorizationCancelOperationRequest](src/ThePlaidApi/Requests/TransferAuthorizationCancelOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferAuthorizationCancelResponse](src/ThePlaidApi/Models/TransferAuthorizationCancelResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferAuthorizationCreateResponse&gt; TransferAuthorizationCreate(TransferAuthorizationCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/transfer/authorization/create` endpoint to authorize a transfer. This endpoint must be called prior to calling `/transfer/create`. The transfer authorization will expire if not used after one hour. (You can contact your account manager to change the default authorization lifetime.)

There are four possible outcomes to calling this endpoint:

  - If the `authorization.decision` in the response is `declined`, the proposed transfer has failed the risk check and you cannot proceed with the transfer.

  - If the `authorization.decision` is `user_action_required`, additional user input is needed, usually to fix a broken bank connection, before Plaid can properly assess the risk. You need to launch Link in update mode to complete the required user action. When calling `/link/token/create` to get a new Link token, instead of providing `access_token` in the request, you should set [`transfer.authorization_id`](https://plaid.com/docs/api/link/#link-token-create-request-transfer-authorization-id) as the `authorization.id`. After the Link flow is completed, you may re-attempt the authorization.

  - If the `authorization.decision` is `approved`, and the `authorization.decision_rationale.code` is `null`, the transfer has passed the risk check and you can proceed to call `/transfer/create`.

  - If the `authorization.decision` is `approved` and the `authorization.decision_rationale.code` is non-`null`, the risk check could not be run: you may proceed with the transfer, but should perform your own risk evaluation. For more details, see the response schema.

In Plaid's Sandbox environment the decisions will be returned as follows:

  - To approve a transfer with `null` rationale code, make an authorization request with an `amount` less than the available balance in the account.

  - To approve a transfer with the rationale code `MANUALLY_VERIFIED_ITEM`, create an Item in Link through the [Same-Day Micro-deposits flow](https://plaid.com/docs/auth/coverage/testing/#testing-same-day-micro-deposits).

  - To get an authorization decision of `user_action_required`, [reset the login for an Item](https://plaid.com/docs/sandbox/#item_login_required).

  - To decline a transfer with the rationale code `NSF`, the available balance on the account must be less than the authorization `amount`. See [Create Sandbox test data](https://plaid.com/docs/sandbox/user-custom/) for details on how to customize data in Sandbox.

  - To decline a transfer with the rationale code `RISK`, the available balance on the account must be exactly $0. See [Create Sandbox test data](https://plaid.com/docs/sandbox/user-custom/) for details on how to customize data in Sandbox.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferAuthorizationCreate(new TransferAuthorizationCreateOperationRequest
    {
        Body = new TransferAuthorizationCreateRequest
        {
            AccessToken = "some example string",
            AccountId = "some example string",
            Type = TransferType.Debit,
            Network = TransferNetwork.Ach,
            Amount = "some example string",
            User = new TransferAuthorizationUserInRequest { LegalName = "some example string" },
        },
    });
    // TODO: Handle 'response' of type TransferAuthorizationCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransferAuthorizationCreateOperationRequest](src/ThePlaidApi/Requests/TransferAuthorizationCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferAuthorizationCreateResponse](src/ThePlaidApi/Models/TransferAuthorizationCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferBalanceGetResponse&gt; TransferBalanceGet(TransferBalanceGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

(Deprecated) Use the `/transfer/ledger/get` endpoint to view a balance held with Plaid.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferBalanceGet(new TransferBalanceGetOperationRequest
    {
        Body = new TransferBalanceGetRequest(),
    });
    // TODO: Handle 'response' of type TransferBalanceGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransferBalanceGetOperationRequest](src/ThePlaidApi/Requests/TransferBalanceGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferBalanceGetResponse](src/ThePlaidApi/Models/TransferBalanceGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferCancelResponse&gt; TransferCancel(TransferCancelOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/transfer/cancel` endpoint to cancel a transfer.  A transfer is eligible for cancellation if the `cancellable` property returned by `/transfer/get` is `true`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferCancel(new TransferCancelOperationRequest
    {
        Body = new TransferCancelRequest { TransferId = "some example string" },
    });
    // TODO: Handle 'response' of type TransferCancelResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransferCancelOperationRequest](src/ThePlaidApi/Requests/TransferCancelOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferCancelResponse](src/ThePlaidApi/Models/TransferCancelResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferCapabilitiesGetResponse&gt; TransferCapabilitiesGet(TransferCapabilitiesGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/transfer/capabilities/get` endpoint to determine the RTP eligibility information of an account to be used with Transfer. This endpoint works on all Transfer-capable Items, including those created by `/transfer/migrate_account`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferCapabilitiesGet(new TransferCapabilitiesGetOperationRequest
    {
        Body = new TransferCapabilitiesGetRequest
        {
            AccessToken = "some example string",
            AccountId = "some example string",
        },
    });
    // TODO: Handle 'response' of type TransferCapabilitiesGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransferCapabilitiesGetOperationRequest](src/ThePlaidApi/Requests/TransferCapabilitiesGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferCapabilitiesGetResponse](src/ThePlaidApi/Models/TransferCapabilitiesGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferConfigurationGetResponse&gt; TransferConfigurationGet(TransferConfigurationGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/transfer/configuration/get` endpoint to view your transfer product configurations.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferConfigurationGet(new TransferConfigurationGetOperationRequest
    {
        Body = new TransferConfigurationGetRequest(),
    });
    // TODO: Handle 'response' of type TransferConfigurationGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransferConfigurationGetOperationRequest](src/ThePlaidApi/Requests/TransferConfigurationGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferConfigurationGetResponse](src/ThePlaidApi/Models/TransferConfigurationGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferCreateResponse&gt; TransferCreate(TransferCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/transfer/create` endpoint to initiate a new transfer. This endpoint is retryable and idempotent; if a transfer with the provided `transfer_id` has already been created, it will return the transfer details without creating a new transfer. A transfer may still be created if a 500 error is returned; to detect this scenario, use [Transfer events](https://plaid.com/docs/transfer/reconciling-transfers/).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferCreate(new TransferCreateOperationRequest
    {
        Body = new TransferCreateRequest
        {
            AccessToken = "some example string",
            AccountId = "some example string",
            AuthorizationId = "some example string",
            Description = "some example string",
        },
    });
    // TODO: Handle 'response' of type TransferCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransferCreateOperationRequest](src/ThePlaidApi/Requests/TransferCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferCreateResponse](src/ThePlaidApi/Models/TransferCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferDiligenceDocumentUploadResponse&gt; TransferDiligenceDocumentUpload(TransferDiligenceDocumentUploadOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Third-party sender customers can use the `/transfer/diligence/document/upload` endpoint to upload a document on behalf of their end customer (i.e. originator) to Plaid. You'll need to send a request of type `multipart/form-data`.
You must provide the `client_id` in the `PLAID-CLIENT-ID` header and `secret` in the `PLAID-SECRET` header.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferDiligenceDocumentUpload(new TransferDiligenceDocumentUploadOperationRequest
    {
        Body = new TransferDiligenceDocumentUploadRequest
        {
            OriginatorClientId = "some example string",
            File = Array.Empty<byte>(),
            Purpose = Purpose.DueDiligence,
        },
    });
    // TODO: Handle 'response' of type TransferDiligenceDocumentUploadResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransferDiligenceDocumentUploadOperationRequest](src/ThePlaidApi/Requests/TransferDiligenceDocumentUploadOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferDiligenceDocumentUploadResponse](src/ThePlaidApi/Models/TransferDiligenceDocumentUploadResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferDiligenceSubmitResponse&gt; TransferDiligenceSubmit(TransferDiligenceSubmitOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/transfer/diligence/submit` endpoint to submit transfer diligence on behalf of the originator (i.e., the end customer).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferDiligenceSubmit(new TransferDiligenceSubmitOperationRequest
    {
        Body = new TransferDiligenceSubmitRequest
        {
            OriginatorClientId = "some example string",
            OriginatorDiligence = new TransferOriginatorDiligence
            {
                Dba = "some example string",
                TaxId = "some example string",
                Address = new TransferOriginatorAddress
                {
                    City = "some example string",
                    Street = "some example string",
                    Region = "some example string",
                    PostalCode = "some example string",
                    CountryCode = "some example string",
                },
                Website = "some example string",
                NaicsCode = "some example string",
                FundingAccount = new TransferFundingAccount
                {
                    AccessToken = "some example string",
                    AccountId = "some example string",
                },
            },
        },
    });
    // TODO: Handle 'response' of type TransferDiligenceSubmitResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransferDiligenceSubmitOperationRequest](src/ThePlaidApi/Requests/TransferDiligenceSubmitOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferDiligenceSubmitResponse](src/ThePlaidApi/Models/TransferDiligenceSubmitResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferEventListResponse&gt; TransferEventList(TransferEventListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/transfer/event/list` endpoint to get a list of transfer events based on specified filter criteria.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferEventList(new TransferEventListOperationRequest
    {
        Body = new TransferEventListRequest(),
    });
    // TODO: Handle 'response' of type TransferEventListResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransferEventListOperationRequest](src/ThePlaidApi/Requests/TransferEventListOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferEventListResponse](src/ThePlaidApi/Models/TransferEventListResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferEventSyncResponse&gt; TransferEventSync(TransferEventSyncOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/transfer/event/sync` allows you to request up to the next 500 transfer events that happened after a specific `event_id`. Use the `/transfer/event/sync` endpoint to guarantee you have seen all transfer events.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferEventSync(new TransferEventSyncOperationRequest
    {
        Body = new TransferEventSyncRequest { AfterId = 1 },
    });
    // TODO: Handle 'response' of type TransferEventSyncResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransferEventSyncOperationRequest](src/ThePlaidApi/Requests/TransferEventSyncOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferEventSyncResponse](src/ThePlaidApi/Models/TransferEventSyncResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferGetResponse&gt; TransferGet(TransferGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/transfer/get` endpoint fetches information about the transfer corresponding to the given `transfer_id` or `authorization_id`. One of `transfer_id` or `authorization_id` must be populated but not both.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferGet(new TransferGetOperationRequest { Body = new TransferGetRequest() });
    // TODO: Handle 'response' of type TransferGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransferGetOperationRequest](src/ThePlaidApi/Requests/TransferGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferGetResponse](src/ThePlaidApi/Models/TransferGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferIntentCreateResponse&gt; TransferIntentCreate(TransferIntentCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/transfer/intent/create` endpoint to generate a transfer intent object and invoke the Transfer UI.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferIntentCreate(new TransferIntentCreateOperationRequest
    {
        Body = new TransferIntentCreateRequest
        {
            Mode = TransferIntentCreateMode.Payment,
            Amount = "some example string",
            Description = "some example string",
            User = new TransferUserInRequest { LegalName = "some example string" },
        },
    });
    // TODO: Handle 'response' of type TransferIntentCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransferIntentCreateOperationRequest](src/ThePlaidApi/Requests/TransferIntentCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferIntentCreateResponse](src/ThePlaidApi/Models/TransferIntentCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferIntentGetResponse&gt; TransferIntentGet(TransferIntentGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/transfer/intent/get` endpoint to retrieve more information about a transfer intent.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferIntentGet(new TransferIntentGetOperationRequest
    {
        Body = new TransferIntentGetRequest { TransferIntentId = "some example string" },
    });
    // TODO: Handle 'response' of type TransferIntentGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransferIntentGetOperationRequest](src/ThePlaidApi/Requests/TransferIntentGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferIntentGetResponse](src/ThePlaidApi/Models/TransferIntentGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferLedgerDepositResponse&gt; TransferLedgerDeposit(TransferLedgerDepositOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/transfer/ledger/deposit` endpoint to deposit funds into Plaid Ledger.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferLedgerDeposit(new TransferLedgerDepositOperationRequest
    {
        Body = new TransferLedgerDepositRequest
        {
            Amount = "some example string",
            IdempotencyKey = "some example string",
            Network = TransferAchNetwork.Ach,
        },
    });
    // TODO: Handle 'response' of type TransferLedgerDepositResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransferLedgerDepositOperationRequest](src/ThePlaidApi/Requests/TransferLedgerDepositOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferLedgerDepositResponse](src/ThePlaidApi/Models/TransferLedgerDepositResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferLedgerDistributeResponse&gt; TransferLedgerDistribute(TransferLedgerDistributeOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/transfer/ledger/distribute` endpoint to move available balance between ledgers, if you have multiple. If you're a platform, you can move funds between one of your ledgers and one of your customer's ledgers.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferLedgerDistribute(new TransferLedgerDistributeOperationRequest
    {
        Body = new TransferLedgerDistributeRequest
        {
            FromLedgerId = "some example string",
            ToLedgerId = "some example string",
            Amount = "some example string",
            IdempotencyKey = "some example string",
        },
    });
    // TODO: Handle 'response' of type TransferLedgerDistributeResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransferLedgerDistributeOperationRequest](src/ThePlaidApi/Requests/TransferLedgerDistributeOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferLedgerDistributeResponse](src/ThePlaidApi/Models/TransferLedgerDistributeResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferLedgerEventListResponse&gt; TransferLedgerEventList(TransferLedgerEventListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/transfer/ledger/event/list` endpoint to get a list of ledger events for a specific ledger based on specified filter criteria.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferLedgerEventList(new TransferLedgerEventListOperationRequest
    {
        Body = new TransferLedgerEventListRequest(),
    });
    // TODO: Handle 'response' of type TransferLedgerEventListResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransferLedgerEventListOperationRequest](src/ThePlaidApi/Requests/TransferLedgerEventListOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferLedgerEventListResponse](src/ThePlaidApi/Models/TransferLedgerEventListResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferLedgerGetResponse&gt; TransferLedgerGet(TransferLedgerGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/transfer/ledger/get` endpoint to view a balance on the ledger held with Plaid.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferLedgerGet(new TransferLedgerGetOperationRequest
    {
        Body = new TransferLedgerGetRequest(),
    });
    // TODO: Handle 'response' of type TransferLedgerGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransferLedgerGetOperationRequest](src/ThePlaidApi/Requests/TransferLedgerGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferLedgerGetResponse](src/ThePlaidApi/Models/TransferLedgerGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferLedgerWithdrawResponse&gt; TransferLedgerWithdraw(TransferLedgerWithdrawOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/transfer/ledger/withdraw` endpoint to withdraw funds from a Plaid Ledger balance.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferLedgerWithdraw(new TransferLedgerWithdrawOperationRequest
    {
        Body = new TransferLedgerWithdrawRequest
        {
            Amount = "some example string",
            IdempotencyKey = "some example string",
            Network = TransferNetwork.Ach,
        },
    });
    // TODO: Handle 'response' of type TransferLedgerWithdrawResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransferLedgerWithdrawOperationRequest](src/ThePlaidApi/Requests/TransferLedgerWithdrawOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferLedgerWithdrawResponse](src/ThePlaidApi/Models/TransferLedgerWithdrawResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferListResponse&gt; TransferList(TransferListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/transfer/list` endpoint to see a list of all your transfers and their statuses. Results are paginated; use the `count` and `offset` query parameters to retrieve the desired transfers.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferList(new TransferListOperationRequest { Body = new TransferListRequest() });
    // TODO: Handle 'response' of type TransferListResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransferListOperationRequest](src/ThePlaidApi/Requests/TransferListOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferListResponse](src/ThePlaidApi/Models/TransferListResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferMetricsGetResponse&gt; TransferMetricsGet(TransferMetricsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/transfer/metrics/get` endpoint to view your transfer product usage metrics.

In the Sandbox environment, this endpoint returns static placeholder values rather than metrics computed from your Sandbox transfer activity.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferMetricsGet(new TransferMetricsGetOperationRequest
    {
        Body = new TransferMetricsGetRequest(),
    });
    // TODO: Handle 'response' of type TransferMetricsGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransferMetricsGetOperationRequest](src/ThePlaidApi/Requests/TransferMetricsGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferMetricsGetResponse](src/ThePlaidApi/Models/TransferMetricsGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferMigrateAccountResponse&gt; TransferMigrateAccount(TransferMigrateAccountOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

As an alternative to adding Items via Link, you can also use the `/transfer/migrate_account` endpoint to migrate previously-verified account and routing numbers to Plaid Items. This endpoint is also required when adding an Item for use with wire transfers; if you intend to create wire transfers on this account, you must provide `wire_routing_number`. Note that Items created in this way are not compatible with endpoints for other products, such as `/accounts/balance/get`, and can only be used with Transfer endpoints.  If you require access to other endpoints, create the Item through Link instead.  Access to `/transfer/migrate_account` is not enabled by default; to obtain access, contact your Plaid account manager or [support](https://dashboard.plaid.com/support).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferMigrateAccount(new TransferMigrateAccountOperationRequest
    {
        Body = new TransferMigrateAccountRequest
        {
            AccountNumber = "some example string",
            RoutingNumber = "some example string",
            AccountType = "some example string",
        },
    });
    // TODO: Handle 'response' of type TransferMigrateAccountResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransferMigrateAccountOperationRequest](src/ThePlaidApi/Requests/TransferMigrateAccountOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferMigrateAccountResponse](src/ThePlaidApi/Models/TransferMigrateAccountResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferOriginatorCreateResponse&gt; TransferOriginatorCreate(TransferOriginatorCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/transfer/originator/create` endpoint to create a new originator and return an `originator_client_id`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferOriginatorCreate(new TransferOriginatorCreateOperationRequest
    {
        Body = new TransferOriginatorCreateRequest { CompanyName = "some example string" },
    });
    // TODO: Handle 'response' of type TransferOriginatorCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransferOriginatorCreateOperationRequest](src/ThePlaidApi/Requests/TransferOriginatorCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferOriginatorCreateResponse](src/ThePlaidApi/Models/TransferOriginatorCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferOriginatorFundingAccountCreateResponse&gt; TransferOriginatorFundingAccountCreate(TransferOriginatorFundingAccountCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/transfer/originator/funding_account/create` endpoint to create a new funding account for the originator.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferOriginatorFundingAccountCreate(
        new TransferOriginatorFundingAccountCreateOperationRequest
        {
            Body = new TransferOriginatorFundingAccountCreateRequest
            {
                OriginatorClientId = "some example string",
                FundingAccount = new TransferFundingAccountWithDisplayName
                {
                    AccessToken = "some example string",
                    AccountId = "some example string",
                },
            },
        });
    // TODO: Handle 'response' of type TransferOriginatorFundingAccountCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransferOriginatorFundingAccountCreateOperationRequest](src/ThePlaidApi/Requests/TransferOriginatorFundingAccountCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferOriginatorFundingAccountCreateResponse](src/ThePlaidApi/Models/TransferOriginatorFundingAccountCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferOriginatorFundingAccountUpdateResponse&gt; TransferOriginatorFundingAccountUpdate(TransferOriginatorFundingAccountUpdateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/transfer/originator/funding_account/update` endpoint to update the funding account associated with the originator.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferOriginatorFundingAccountUpdate(
        new TransferOriginatorFundingAccountUpdateOperationRequest
        {
            Body = new TransferOriginatorFundingAccountUpdateRequest
            {
                OriginatorClientId = "some example string",
                FundingAccount = new TransferFundingAccount
                {
                    AccessToken = "some example string",
                    AccountId = "some example string",
                },
            },
        });
    // TODO: Handle 'response' of type TransferOriginatorFundingAccountUpdateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransferOriginatorFundingAccountUpdateOperationRequest](src/ThePlaidApi/Requests/TransferOriginatorFundingAccountUpdateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferOriginatorFundingAccountUpdateResponse](src/ThePlaidApi/Models/TransferOriginatorFundingAccountUpdateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferOriginatorGetResponse&gt; TransferOriginatorGet(TransferOriginatorGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/transfer/originator/get` endpoint gets status updates for an originator's onboarding process. This information is also available via the Transfer page on the Plaid dashboard.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferOriginatorGet(new TransferOriginatorGetOperationRequest
    {
        Body = new TransferOriginatorGetRequest { OriginatorClientId = "some example string" },
    });
    // TODO: Handle 'response' of type TransferOriginatorGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransferOriginatorGetOperationRequest](src/ThePlaidApi/Requests/TransferOriginatorGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferOriginatorGetResponse](src/ThePlaidApi/Models/TransferOriginatorGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferOriginatorListResponse&gt; TransferOriginatorList(TransferOriginatorListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/transfer/originator/list` endpoint gets status updates for all of your originators' onboarding. This information is also available via the Plaid dashboard.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferOriginatorList(new TransferOriginatorListOperationRequest
    {
        Body = new TransferOriginatorListRequest(),
    });
    // TODO: Handle 'response' of type TransferOriginatorListResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransferOriginatorListOperationRequest](src/ThePlaidApi/Requests/TransferOriginatorListOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferOriginatorListResponse](src/ThePlaidApi/Models/TransferOriginatorListResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferPlatformOriginatorCreateResponse&gt; TransferPlatformOriginatorCreate(TransferPlatformOriginatorCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/transfer/platform/originator/create` endpoint to submit information about the originator you are onboarding, including the originator's agreement to the required legal terms.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferPlatformOriginatorCreate(new TransferPlatformOriginatorCreateOperationRequest
    {
        Body = new TransferPlatformOriginatorCreateRequest
        {
            OriginatorClientId = "some example string",
            TosAcceptanceMetadata = new TosAcceptanceMetadata
            {
                AgreementAccepted = true,
                OriginatorIpAddress = "some example string",
                AgreementAcceptedAt = DateTimeOffset.Parse("2024-01-15T09:30:00Z"),
            },
            OriginatorReviewedAt = DateTimeOffset.Parse("2024-01-15T09:30:00Z"),
        },
    });
    // TODO: Handle 'response' of type TransferPlatformOriginatorCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransferPlatformOriginatorCreateOperationRequest](src/ThePlaidApi/Requests/TransferPlatformOriginatorCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferPlatformOriginatorCreateResponse](src/ThePlaidApi/Models/TransferPlatformOriginatorCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferPlatformPersonCreateResponse&gt; TransferPlatformPersonCreate(TransferPlatformPersonCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/transfer/platform/person/create` endpoint to create a person associated with an originator (e.g. beneficial owner or control person) and optionally submit personal identification information for them.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferPlatformPersonCreate(new TransferPlatformPersonCreateOperationRequest
    {
        Body = new TransferPlatformPersonCreateRequest { OriginatorClientId = "some example string" },
    });
    // TODO: Handle 'response' of type TransferPlatformPersonCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransferPlatformPersonCreateOperationRequest](src/ThePlaidApi/Requests/TransferPlatformPersonCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferPlatformPersonCreateResponse](src/ThePlaidApi/Models/TransferPlatformPersonCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferPlatformRequirementSubmitResponse&gt; TransferPlatformRequirementSubmit(TransferPlatformRequirementSubmitOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/transfer/platform/requirement/submit` endpoint to submit additional onboarding information that is needed by Plaid to approve or decline the originator. See [Requirement type schema documentation](https://docs.google.com/document/d/1NEQkTD0sVK50iAQi6xHigrexDUxZ4QxXqSEfV_FFTiU/) for a list of requirement types and possible values.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferPlatformRequirementSubmit(new TransferPlatformRequirementSubmitOperationRequest
    {
        Body = new TransferPlatformRequirementSubmitRequest
        {
            OriginatorClientId = "some example string",
            RequirementSubmissions = [
                new RequirementSubmission { RequirementType = "some example string", Value = "some example string" },
            ],
        },
    });
    // TODO: Handle 'response' of type TransferPlatformRequirementSubmitResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransferPlatformRequirementSubmitOperationRequest](src/ThePlaidApi/Requests/TransferPlatformRequirementSubmitOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferPlatformRequirementSubmitResponse](src/ThePlaidApi/Models/TransferPlatformRequirementSubmitResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferQuestionnaireCreateResponse&gt; TransferQuestionnaireCreate(TransferQuestionnaireCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/transfer/questionnaire/create` endpoint generates a Plaid-hosted onboarding UI URL. Redirect the originator to this URL to provide their due diligence information and agree to Plaid's terms for ACH money movement.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferQuestionnaireCreate(new TransferQuestionnaireCreateOperationRequest
    {
        Body = new TransferQuestionnaireCreateRequest
        {
            OriginatorClientId = "some example string",
            RedirectUri = "some example string",
        },
    });
    // TODO: Handle 'response' of type TransferQuestionnaireCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransferQuestionnaireCreateOperationRequest](src/ThePlaidApi/Requests/TransferQuestionnaireCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferQuestionnaireCreateResponse](src/ThePlaidApi/Models/TransferQuestionnaireCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferRecurringCancelResponse&gt; TransferRecurringCancel(TransferRecurringCancelOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/transfer/recurring/cancel` endpoint to cancel a recurring transfer.  A scheduled transfer that hasn't been submitted to the bank will be cancelled.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferRecurringCancel(new TransferRecurringCancelOperationRequest
    {
        Body = new TransferRecurringCancelRequest { RecurringTransferId = "some example string" },
    });
    // TODO: Handle 'response' of type TransferRecurringCancelResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransferRecurringCancelOperationRequest](src/ThePlaidApi/Requests/TransferRecurringCancelOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferRecurringCancelResponse](src/ThePlaidApi/Models/TransferRecurringCancelResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferRecurringCreateResponse&gt; TransferRecurringCreate(TransferRecurringCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/transfer/recurring/create` endpoint to initiate a new recurring transfer. This capability is not currently supported for Transfer UI or Transfer for Platforms (beta) customers.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferRecurringCreate(new TransferRecurringCreateOperationRequest
    {
        Body = new TransferRecurringCreateRequest
        {
            AccessToken = "some example string",
            IdempotencyKey = "some example string",
            AccountId = "some example string",
            Type = TransferType.Debit,
            Network = TransferRecurringNetwork.Ach,
            Amount = "some example string",
            Description = "some example string",
            Schedule = new TransferRecurringSchedule
            {
                IntervalUnit = TransferScheduleIntervalUnit.Week,
                IntervalCount = 1,
                IntervalExecutionDay = 1,
                StartDate = DateTimeOffset.Parse("2024-01-15T00:00:00Z"),
            },
            User = new TransferUserInRequest { LegalName = "some example string" },
        },
    });
    // TODO: Handle 'response' of type TransferRecurringCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransferRecurringCreateOperationRequest](src/ThePlaidApi/Requests/TransferRecurringCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferRecurringCreateResponse](src/ThePlaidApi/Models/TransferRecurringCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferRecurringGetResponse&gt; TransferRecurringGet(TransferRecurringGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/transfer/recurring/get` fetches information about the recurring transfer corresponding to the given `recurring_transfer_id`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferRecurringGet(new TransferRecurringGetOperationRequest
    {
        Body = new TransferRecurringGetRequest { RecurringTransferId = "some example string" },
    });
    // TODO: Handle 'response' of type TransferRecurringGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransferRecurringGetOperationRequest](src/ThePlaidApi/Requests/TransferRecurringGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferRecurringGetResponse](src/ThePlaidApi/Models/TransferRecurringGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferRecurringListResponse&gt; TransferRecurringList(TransferRecurringListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/transfer/recurring/list` endpoint to see a list of all your recurring transfers and their statuses. Results are paginated; use the `count` and `offset` query parameters to retrieve the desired recurring transfers.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferRecurringList(new TransferRecurringListOperationRequest
    {
        Body = new TransferRecurringListRequest(),
    });
    // TODO: Handle 'response' of type TransferRecurringListResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransferRecurringListOperationRequest](src/ThePlaidApi/Requests/TransferRecurringListOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferRecurringListResponse](src/ThePlaidApi/Models/TransferRecurringListResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferRefundCancelResponse&gt; TransferRefundCancel(TransferRefundCancelOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/transfer/refund/cancel` endpoint to cancel a refund.  A refund is eligible for cancellation if it has not yet been submitted to the payment network.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferRefundCancel(new TransferRefundCancelOperationRequest
    {
        Body = new TransferRefundCancelRequest { RefundId = "some example string" },
    });
    // TODO: Handle 'response' of type TransferRefundCancelResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransferRefundCancelOperationRequest](src/ThePlaidApi/Requests/TransferRefundCancelOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferRefundCancelResponse](src/ThePlaidApi/Models/TransferRefundCancelResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferRefundCreateResponse&gt; TransferRefundCreate(TransferRefundCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/transfer/refund/create` endpoint to create a refund for a transfer. A transfer can be refunded if the transfer was initiated in the past 180 days.

Refunds come out of the available balance of the ledger used for the original debit transfer. If there are not enough funds in the available balance to cover the refund amount, the refund will be rejected. You can create a refund at any time. Plaid does not impose any hold time on refunds.

A refund can still be issued even if the Item's `access_token` is no longer valid (e.g. if the user revoked OAuth consent or the Item was deleted via `/item/remove`), as long as the account and routing number pair used to make the original transaction is still valid. A refund cannot be issued if the Item has an [invalidated TAN](https://plaid.com/docs/auth/#tokenized-account-numbers), which can occur at Chase or PNC.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferRefundCreate(new TransferRefundCreateOperationRequest
    {
        Body = new TransferRefundCreateRequest
        {
            TransferId = "some example string",
            Amount = "some example string",
            IdempotencyKey = "some example string",
        },
    });
    // TODO: Handle 'response' of type TransferRefundCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransferRefundCreateOperationRequest](src/ThePlaidApi/Requests/TransferRefundCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferRefundCreateResponse](src/ThePlaidApi/Models/TransferRefundCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferRefundGetResponse&gt; TransferRefundGet(TransferRefundGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/transfer/refund/get` endpoint fetches information about the refund corresponding to the given `refund_id`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferRefundGet(new TransferRefundGetOperationRequest
    {
        Body = new TransferRefundGetRequest { RefundId = "some example string" },
    });
    // TODO: Handle 'response' of type TransferRefundGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransferRefundGetOperationRequest](src/ThePlaidApi/Requests/TransferRefundGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferRefundGetResponse](src/ThePlaidApi/Models/TransferRefundGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferRepaymentListResponse&gt; TransferRepaymentList(TransferRepaymentListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/transfer/repayment/list` endpoint fetches repayments matching the given filters. Repayments are returned in reverse-chronological order (most recent first) starting at the given `start_time`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferRepaymentList(new TransferRepaymentListOperationRequest
    {
        Body = new TransferRepaymentListRequest { Count = 1 },
    });
    // TODO: Handle 'response' of type TransferRepaymentListResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransferRepaymentListOperationRequest](src/ThePlaidApi/Requests/TransferRepaymentListOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferRepaymentListResponse](src/ThePlaidApi/Models/TransferRepaymentListResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferRepaymentReturnListResponse&gt; TransferRepaymentReturnList(TransferRepaymentReturnListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/transfer/repayment/return/list` endpoint retrieves the set of returns that were batched together into the specified repayment. The sum of amounts of returns retrieved by this request equals the amount of the repayment.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferRepaymentReturnList(new TransferRepaymentReturnListOperationRequest
    {
        Body = new TransferRepaymentReturnListRequest
        {
            RepaymentId = "d4bfce70-2470-4298-ae87-5e9b3e18bfaf",
            Count = 1,
        },
    });
    // TODO: Handle 'response' of type TransferRepaymentReturnListResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransferRepaymentReturnListOperationRequest](src/ThePlaidApi/Requests/TransferRepaymentReturnListOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferRepaymentReturnListResponse](src/ThePlaidApi/Models/TransferRepaymentReturnListResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferReturnRecoverResponse&gt; TransferReturnRecover(TransferReturnRecoverOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Use the `/transfer/return/recover` endpoint to notify Plaid that you have recovered some or all of the loss on a returned guaranteed transfer.

Recovery can be reported in full or in parts; the sum of recovered amounts across calls cannot exceed the original transfer's amount.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferReturnRecover(new TransferReturnRecoverOperationRequest
    {
        Body = new TransferReturnRecoverRequest
        {
            TransferId = "some example string",
            Amount = "some example string",
            IdempotencyKey = "some example string",
        },
    });
    // TODO: Handle 'response' of type TransferReturnRecoverResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransferReturnRecoverOperationRequest](src/ThePlaidApi/Requests/TransferReturnRecoverOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferReturnRecoverResponse](src/ThePlaidApi/Models/TransferReturnRecoverResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferSweepGetResponse&gt; TransferSweepGet(TransferSweepGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/transfer/sweep/get` endpoint fetches a sweep corresponding to the given `sweep_id`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferSweepGet(new TransferSweepGetOperationRequest
    {
        Body = new TransferSweepGetRequest { SweepId = "some example string" },
    });
    // TODO: Handle 'response' of type TransferSweepGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransferSweepGetOperationRequest](src/ThePlaidApi/Requests/TransferSweepGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferSweepGetResponse](src/ThePlaidApi/Models/TransferSweepGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransferSweepListResponse&gt; TransferSweepList(TransferSweepListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The `/transfer/sweep/list` endpoint fetches sweeps matching the given filters.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransferSweepList(new TransferSweepListOperationRequest
    {
        Body = new TransferSweepListRequest(),
    });
    // TODO: Handle 'response' of type TransferSweepListResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TransferSweepListOperationRequest](src/ThePlaidApi/Requests/TransferSweepListOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransferSweepListResponse](src/ThePlaidApi/Models/TransferSweepListResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UserAccountSessionEventSendResponse&gt; UserAccountSessionEventSend(UserAccountSessionEventSendOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows sending client-specific events related to Layer sessions for analytics and tracking purposes.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UserAccountSessionEventSend(new UserAccountSessionEventSendOperationRequest
    {
        Body = new UserAccountSessionEventSendRequest
        {
            LinkSessionId = "some example string",
            Event = new UserAccountSessionEvent
            {
                Name = "some example string",
                Timestamp = DateTimeOffset.Parse("2024-01-15T09:30:00Z"),
            },
        },
    });
    // TODO: Handle 'response' of type UserAccountSessionEventSendResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UserAccountSessionEventSendOperationRequest](src/ThePlaidApi/Requests/UserAccountSessionEventSendOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UserAccountSessionEventSendResponse](src/ThePlaidApi/Models/UserAccountSessionEventSendResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UserAccountSessionGetResponse&gt; UserAccountSessionGet(UserAccountSessionGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint returns user permissioned account data, including identity and Item access tokens, for use with [Plaid Layer](https://plaid.com/docs/layer). Note that end users are permitted to edit the prefilled identity data in the Link flow before sharing it with you; you should treat any identity data returned by this endpoint as user-submitted, unverified data. For a verification layer, you can add [Identity Verification](https://plaid.com/docs/identity-verification/) to your flow, or check the submitted identity data against bank account data from linked accounts using [Identity Match](https://plaid.com/docs/identity/#identity-match).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UserAccountSessionGet(new UserAccountSessionGetOperationRequest
    {
        Body = new UserAccountSessionGetRequest { PublicToken = "some example string" },
    });
    // TODO: Handle 'response' of type UserAccountSessionGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UserAccountSessionGetOperationRequest](src/ThePlaidApi/Requests/UserAccountSessionGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UserAccountSessionGetResponse](src/ThePlaidApi/Models/UserAccountSessionGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UserCreateResponse&gt; UserCreate(UserCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

For Plaid products and flows that use the user object, `/user/create` provides you a single token to access all data associated with the user. You must call this endpoint before calling `/link/token/create` if you are using any of the following: Plaid Check, Income Verification, Multi-Item Link, or Plaid Protect (Identity). If you are using Plaid Protect Link session scoring, you do not need to call `/user/create` first; Plaid will resolve or create the user when `user.client_user_id` is provided in `/link/token/create`.
For customers who began using this endpoint on or after December 10, 2025, this endpoint takes a `client_user_id` and an `identity` object and will return a `user_id`. For customers who began using it before that date, the endpoint takes a `client_user_id` and a `consumer_report_user_identity` object and will return a `user_token` and `user_id`. For more details, see [New User APIs](https://plaid.com/docs/api/users/user-apis).
In order to create a Plaid Check Consumer Report for a user, the `identity` (new) or `consumer_report_user_identity` (legacy) object must be present. If it is not provided during the `/user/create` call, it can be added later by calling `/user/update`.


In order to generate a Plaid Check Consumer Report, the following `identity` fields, at minimum, are required and must be non-empty: `name`, `date_of_birth`, `emails`, `phone_numbers`, and `addresses` (with at least one email, phone number, and address designated as `primary`). Plaid Check Consumer Reports can only be created for US-based users; the user's address country must be `US`. If creating a report for sharing with a GSE such as Fannie or Freddie, the user's full SSN must be provided via the `id_numbers` field. Providing at least a partial SSN is also strongly recommended for all use cases, since it improves the accuracy of matching user records during compliance processes such as file disclosure, dispute, or security freeze requests.


When using Plaid Protect, it is highly recommended that you provide an `identity` object to better identify and block fraud across your Link sessions.


Plaid will normalize identity fields before storing them and utilize the same identity across different user-based products.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UserCreate(new UserCreateOperationRequest
    {
        Body = new UserCreateRequest { ClientUserId = "some example string" },
    });
    // TODO: Handle 'response' of type UserCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UserCreateOperationRequest](src/ThePlaidApi/Requests/UserCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UserCreateResponse](src/ThePlaidApi/Models/UserCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UserFinancialDataRefreshResponse&gt; UserFinancialDataRefresh(UserFinancialDataRefreshOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/user/financial_data/refresh` is an optional endpoint that initiates an on-demand extraction to fetch the newest transactions for a User using the Financial Insights bundle.
This bundle refreshes the Transactions, Investments, and Liabilities product data.
This endpoint is for clients who use the Financial Insights bundle and want to proactively update all linked Items under a user.
The refresh may succeed or fail on a per-Item basis. Use the `results` array in the response to understand the outcome for each Item.

This endpoint is distinct from `/transactions/refresh`, which triggers a refresh for a single Item. Use `/user/financial_data/refresh` to target all Items for a user instead.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UserFinancialDataRefresh(new UserFinancialDataRefreshOperationRequest
    {
        Body = new UserFinancialDataRefreshRequest { UserId = "usr_8c3ZbDBYjaqUXZ" },
    });
    // TODO: Handle 'response' of type UserFinancialDataRefreshResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UserFinancialDataRefreshOperationRequest](src/ThePlaidApi/Requests/UserFinancialDataRefreshOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UserFinancialDataRefreshResponse](src/ThePlaidApi/Models/UserFinancialDataRefreshResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UserGetResponse&gt; UserGet(UserGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get user details using a `user_id`. This endpoint only supports users that were created on the new user API flow, without a `user_token`. For more details, see [New User APIs](https://plaid.com/docs/api/users/user-apis).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UserGet(new UserGetOperationRequest
    {
        Body = new UserGetRequest { UserId = "some example string" },
    });
    // TODO: Handle 'response' of type UserGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UserGetOperationRequest](src/ThePlaidApi/Requests/UserGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UserGetResponse](src/ThePlaidApi/Models/UserGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UserIdentityRemoveResponse&gt; UserIdentityRemove(UserIdentityRemoveOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint allows customers to explicitly purge identity/PII data provided to Plaid for a given user. This is not exposed to customers by default, as it is meant for special scenarios or requests, but Plaid is obligated to enable customers to delete PII provided to us.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UserIdentityRemove(new UserIdentityRemoveOperationRequest
    {
        Body = new UserIdentityRemoveRequest { UserId = "some example string" },
    });
    // TODO: Handle 'response' of type UserIdentityRemoveResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UserIdentityRemoveOperationRequest](src/ThePlaidApi/Requests/UserIdentityRemoveOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UserIdentityRemoveResponse](src/ThePlaidApi/Models/UserIdentityRemoveResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UserItemsAssociateResponse&gt; UserItemsAssociate(UserItemsAssociateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Associates Items to the target user. If an Item is already associated to another user, the Item will be disassociated with the existing user and associated to the target user. This operation supports a max of 100 Items.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UserItemsAssociate(new UserItemsAssociateOperationRequest
    {
        Body = new UserItemsAssociateRequest { UserId = "some example string", ItemIds = ["some example string"] },
    });
    // TODO: Handle 'response' of type UserItemsAssociateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UserItemsAssociateOperationRequest](src/ThePlaidApi/Requests/UserItemsAssociateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UserItemsAssociateResponse](src/ThePlaidApi/Models/UserItemsAssociateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UserItemsGetResponse&gt; UserItemsGet(UserItemsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns Items associated with a `user_id`, along with their corresponding statuses. Plaid associates an Item with a User when it has been successfully connected within a Link session initialized with that `user_id`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UserItemsGet(new UserItemsGetOperationRequest { Body = new UserItemsGetRequest() });
    // TODO: Handle 'response' of type UserItemsGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UserItemsGetOperationRequest](src/ThePlaidApi/Requests/UserItemsGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UserItemsGetResponse](src/ThePlaidApi/Models/UserItemsGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UserItemsRemoveResponse&gt; UserItemsRemove(UserItemsRemoveOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Removes specific Items associated with a user. It is equivalent to calling `/item/remove` on each Item individually, but supports use cases (such as Plaid Check) where access tokens are not available. All specified Items must belong to the user or the entire operation fails. Similar to `/item/remove`, this deletes Item product data and terminates billing on the Item's products. Once removed, Items cannot be reconnected without going through Link again.
This endpoint is not intended to remove all data for a user, as it will only remove Items and no other data for the user. If the user has any user-based recurring subscription products (Financial Management, Plaid Protect, or CRA Cash Flow Updates) and is deleting their account with your product, also call `/user/products/terminate` to end those subscriptions; per-Item billing is already terminated by this endpoint. For a user initiated data deletion request, see the [Consumer Service Center](https://plaid.com/check/consumer-service-center/) to revoke access to data.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UserItemsRemove(new UserItemsRemoveOperationRequest
    {
        Body = new UserItemsRemoveRequest { ItemIds = ["some example string"] },
    });
    // TODO: Handle 'response' of type UserItemsRemoveResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UserItemsRemoveOperationRequest](src/ThePlaidApi/Requests/UserItemsRemoveOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UserItemsRemoveResponse](src/ThePlaidApi/Models/UserItemsRemoveResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UserProductsTerminateResponse&gt; UserProductsTerminate(UserProductsTerminateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Terminates user-based recurring subscription bundles or products (Financial Management, Plaid Protect, and CRA Cash Flow Updates) associated with a `user_id`. After you call this endpoint, the user will no longer be billed for these products. For CRA Monitoring, the subscription is canceled but historical data remains available for future report requests.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UserProductsTerminate(new UserProductsTerminateOperationRequest
    {
        Body = new UserProductsTerminateRequest
        {
            UserId = "usr_8c3ZbDBYjaqUXZ",
            ReasonCode = ProductsTerminateReasonCode.ConsumerAccountClosed,
            ReasonNote = "User closed account with client.",
        },
    });
    // TODO: Handle 'response' of type UserProductsTerminateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UserProductsTerminateOperationRequest](src/ThePlaidApi/Requests/UserProductsTerminateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UserProductsTerminateResponse](src/ThePlaidApi/Models/UserProductsTerminateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UserRemoveResponse&gt; UserRemove(UserRemoveOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/user/remove` deletes a `user_id` or `user_token` and associated information, including any Items associated with the user.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UserRemove(new UserRemoveOperationRequest { Body = new UserRemoveRequest() });
    // TODO: Handle 'response' of type UserRemoveResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UserRemoveOperationRequest](src/ThePlaidApi/Requests/UserRemoveOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UserRemoveResponse](src/ThePlaidApi/Models/UserRemoveResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UserThirdPartyTokenCreateResponse&gt; UserThirdPartyTokenCreate(UserThirdPartyTokenCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint is used to create a third-party user token. This token can be shared with and used by a specified third-party client to access data associated with the user through supported endpoints.

Ensure you store the `third_party_user_token` along with the `user_token` and `third_party_client_id`, as it is not possible to retrieve a previously created `third_party_user_token`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UserThirdPartyTokenCreate(new UserThirdPartyTokenCreateOperationRequest
    {
        Body = new UserThirdPartyTokenCreateRequest { ThirdPartyClientId = "some example string" },
    });
    // TODO: Handle 'response' of type UserThirdPartyTokenCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UserThirdPartyTokenCreateOperationRequest](src/ThePlaidApi/Requests/UserThirdPartyTokenCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UserThirdPartyTokenCreateResponse](src/ThePlaidApi/Models/UserThirdPartyTokenCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UserThirdPartyTokenRemoveResponse&gt; UserThirdPartyTokenRemove(UserThirdPartyTokenRemoveOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint is used to delete a third-party user token. Once removed, the token can no longer be used to access data associated with the user.

Any subsequent calls to retrieve information using the same third-party user token will result in an error stating the third-party user token does not exist.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UserThirdPartyTokenRemove(new UserThirdPartyTokenRemoveOperationRequest
    {
        Body = new UserThirdPartyTokenRemoveRequest { ThirdPartyUserToken = "some example string" },
    });
    // TODO: Handle 'response' of type UserThirdPartyTokenRemoveResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UserThirdPartyTokenRemoveOperationRequest](src/ThePlaidApi/Requests/UserThirdPartyTokenRemoveOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UserThirdPartyTokenRemoveResponse](src/ThePlaidApi/Models/UserThirdPartyTokenRemoveResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UserTransactionsRefreshResponse&gt; UserTransactionsRefresh(UserTransactionsRefreshOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

`/user/transactions/refresh` is an optional endpoint that initiates an on-demand extraction to fetch the newest transactions for a User using the Transactions bundle.
This bundle refreshes only the Transactions product data.
This endpoint is for clients who use the Transactions Insights bundle and want to proactively update all linked Items under a user.
The refresh may succeed or fail on a per-Item basis. Use the `results` array in the response to understand the outcome for each Item.

This endpoint is distinct from `/transactions/refresh`, which triggers a refresh for a single Item. Use `/user/transactions/refresh` to target all Items for a user instead.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UserTransactionsRefresh(new UserTransactionsRefreshOperationRequest
    {
        Body = new UserTransactionsRefreshRequest { UserId = "usr_8c3ZbDBYjaqUXZ" },
    });
    // TODO: Handle 'response' of type UserTransactionsRefreshResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UserTransactionsRefreshOperationRequest](src/ThePlaidApi/Requests/UserTransactionsRefreshOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UserTransactionsRefreshResponse](src/ThePlaidApi/Models/UserTransactionsRefreshResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;UserUpdateResponse&gt; UserUpdate(UserUpdateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint updates user information for an existing `user_id` or `user_token`. If an existing `user_id` or `user_token` is missing fields required for a given use case (e.g. creating a Consumer Report) use `/user/update` to add values for those fields.

Identity updates use merge semantics: provided fields overwrite existing ones; omitted fields remain unchanged.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UserUpdate(new UserUpdateOperationRequest { Body = new UserUpdateRequest() });
    // TODO: Handle 'response' of type UserUpdateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UserUpdateOperationRequest](src/ThePlaidApi/Requests/UserUpdateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[UserUpdateResponse](src/ThePlaidApi/Models/UserUpdateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;WalletCreateResponse&gt; WalletCreate(WalletCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create an e-wallet. The response is the newly created e-wallet object.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WalletCreate(new WalletCreateOperationRequest
    {
        Body = new WalletCreateRequest { IsoCurrencyCode = IsoCurrencyCode.Gbp },
    });
    // TODO: Handle 'response' of type WalletCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[WalletCreateOperationRequest](src/ThePlaidApi/Requests/WalletCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[WalletCreateResponse](src/ThePlaidApi/Models/WalletCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;WalletGetResponse&gt; WalletGet(WalletGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Fetch an e-wallet. The response includes the current balance.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WalletGet(new WalletGetOperationRequest
    {
        Body = new WalletGetRequest { WalletId = "some example string" },
    });
    // TODO: Handle 'response' of type WalletGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[WalletGetOperationRequest](src/ThePlaidApi/Requests/WalletGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[WalletGetResponse](src/ThePlaidApi/Models/WalletGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;WalletListResponse&gt; WalletList(WalletListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint lists all e-wallets in descending order of creation.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WalletList(new WalletListOperationRequest { Body = new WalletListRequest() });
    // TODO: Handle 'response' of type WalletListResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[WalletListOperationRequest](src/ThePlaidApi/Requests/WalletListOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[WalletListResponse](src/ThePlaidApi/Models/WalletListResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;WalletTransactionExecuteResponse&gt; WalletTransactionExecute(WalletTransactionExecuteOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Execute a transaction using the specified e-wallet.
Specify the e-wallet to debit from, the counterparty to credit to, the idempotency key to prevent duplicate transactions, the amount and reference for the transaction.
Transactions will settle in seconds to several days, depending on the underlying payment rail.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WalletTransactionExecute(new WalletTransactionExecuteOperationRequest
    {
        Body = new WalletTransactionExecuteRequest
        {
            IdempotencyKey = "some example string",
            WalletId = "some example string",
            Counterparty = new WalletTransactionCounterparty
            {
                Name = "some example string",
                Numbers = new WalletTransactionCounterpartyNumbers(),
            },
            Amount = new WalletTransactionAmount { IsoCurrencyCode = IsoCurrencyCode.Gbp, Value = 1.5d },
            Reference = "some example string",
        },
    });
    // TODO: Handle 'response' of type WalletTransactionExecuteResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[WalletTransactionExecuteOperationRequest](src/ThePlaidApi/Requests/WalletTransactionExecuteOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[WalletTransactionExecuteResponse](src/ThePlaidApi/Models/WalletTransactionExecuteResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;WalletTransactionGetResponse&gt; WalletTransactionGet(WalletTransactionGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Fetch a specific e-wallet transaction

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WalletTransactionGet(new WalletTransactionGetOperationRequest
    {
        Body = new WalletTransactionGetRequest { TransactionId = "some example string" },
    });
    // TODO: Handle 'response' of type WalletTransactionGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[WalletTransactionGetOperationRequest](src/ThePlaidApi/Requests/WalletTransactionGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[WalletTransactionGetResponse](src/ThePlaidApi/Models/WalletTransactionGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;WalletTransactionListResponse&gt; WalletTransactionList(WalletTransactionListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

This endpoint lists the latest transactions of the specified e-wallet. Transactions are returned in descending order by the `created_at` time.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WalletTransactionList(new WalletTransactionListOperationRequest
    {
        Body = new WalletTransactionListRequest { WalletId = "some example string" },
    });
    // TODO: Handle 'response' of type WalletTransactionListResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[WalletTransactionListOperationRequest](src/ThePlaidApi/Requests/WalletTransactionListOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[WalletTransactionListResponse](src/ThePlaidApi/Models/WalletTransactionListResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;WatchlistScreeningEntityCreateResponse&gt; WatchlistScreeningEntityCreate(WatchlistScreeningEntityCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a new entity watchlist screening to check your customer against watchlists defined in the associated entity watchlist program. If your associated program has ongoing screening enabled, this is the profile information that will be used to monitor your customer over time.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WatchlistScreeningEntityCreate(new WatchlistScreeningEntityCreateOperationRequest
    {
        Body = new WatchlistScreeningEntityCreateRequest
        {
            SearchTerms = new EntityWatchlistSearchTerms
            {
                EntityWatchlistProgramId = "some example string",
                LegalName = "some example string",
            },
        },
    });
    // TODO: Handle 'response' of type WatchlistScreeningEntityCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[WatchlistScreeningEntityCreateOperationRequest](src/ThePlaidApi/Requests/WatchlistScreeningEntityCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[WatchlistScreeningEntityCreateResponse](src/ThePlaidApi/Models/WatchlistScreeningEntityCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;WatchlistScreeningEntityGetResponse&gt; WatchlistScreeningEntityGet(WatchlistScreeningEntityGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve an entity watchlist screening.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WatchlistScreeningEntityGet(new WatchlistScreeningEntityGetOperationRequest
    {
        Body = new WatchlistScreeningEntityGetRequest { EntityWatchlistScreeningId = "some example string" },
    });
    // TODO: Handle 'response' of type WatchlistScreeningEntityGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[WatchlistScreeningEntityGetOperationRequest](src/ThePlaidApi/Requests/WatchlistScreeningEntityGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[WatchlistScreeningEntityGetResponse](src/ThePlaidApi/Models/WatchlistScreeningEntityGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;WatchlistScreeningEntityHistoryListResponse&gt; WatchlistScreeningEntityHistoryList(WatchlistScreeningEntityHistoryListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all changes to the entity watchlist screening in reverse-chronological order. If the watchlist screening has not been edited, no history will be returned.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WatchlistScreeningEntityHistoryList(
        new WatchlistScreeningEntityHistoryListOperationRequest
        {
            Body = new WatchlistScreeningEntityHistoryListRequest
            {
                EntityWatchlistScreeningId = "some example string",
            },
        });
    // TODO: Handle 'response' of type WatchlistScreeningEntityHistoryListResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[WatchlistScreeningEntityHistoryListOperationRequest](src/ThePlaidApi/Requests/WatchlistScreeningEntityHistoryListOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[WatchlistScreeningEntityHistoryListResponse](src/ThePlaidApi/Models/WatchlistScreeningEntityHistoryListResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;WatchlistScreeningEntityHitListResponse&gt; WatchlistScreeningEntityHitList(WatchlistScreeningEntityHitListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all hits for the entity watchlist screening.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WatchlistScreeningEntityHitList(new WatchlistScreeningEntityHitListOperationRequest
    {
        Body = new WatchlistScreeningEntityHitListRequest { EntityWatchlistScreeningId = "some example string" },
    });
    // TODO: Handle 'response' of type WatchlistScreeningEntityHitListResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[WatchlistScreeningEntityHitListOperationRequest](src/ThePlaidApi/Requests/WatchlistScreeningEntityHitListOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[WatchlistScreeningEntityHitListResponse](src/ThePlaidApi/Models/WatchlistScreeningEntityHitListResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;WatchlistScreeningEntityListResponse&gt; WatchlistScreeningEntityList(WatchlistScreeningEntityListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all entity screenings.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WatchlistScreeningEntityList(new WatchlistScreeningEntityListOperationRequest
    {
        Body = new WatchlistScreeningEntityListRequest { EntityWatchlistProgramId = "some example string" },
    });
    // TODO: Handle 'response' of type WatchlistScreeningEntityListResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[WatchlistScreeningEntityListOperationRequest](src/ThePlaidApi/Requests/WatchlistScreeningEntityListOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[WatchlistScreeningEntityListResponse](src/ThePlaidApi/Models/WatchlistScreeningEntityListResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;WatchlistScreeningEntityProgramGetResponse&gt; WatchlistScreeningEntityProgramGet(WatchlistScreeningEntityProgramGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get an entity watchlist screening program

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WatchlistScreeningEntityProgramGet(
        new WatchlistScreeningEntityProgramGetOperationRequest
        {
            Body = new WatchlistScreeningEntityProgramGetRequest { EntityWatchlistProgramId = "some example string" },
        });
    // TODO: Handle 'response' of type WatchlistScreeningEntityProgramGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[WatchlistScreeningEntityProgramGetOperationRequest](src/ThePlaidApi/Requests/WatchlistScreeningEntityProgramGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[WatchlistScreeningEntityProgramGetResponse](src/ThePlaidApi/Models/WatchlistScreeningEntityProgramGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;WatchlistScreeningEntityProgramListResponse&gt; WatchlistScreeningEntityProgramList(WatchlistScreeningEntityProgramListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all entity watchlist screening programs

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WatchlistScreeningEntityProgramList(
        new WatchlistScreeningEntityProgramListOperationRequest
        {
            Body = new WatchlistScreeningEntityProgramListRequest(),
        });
    // TODO: Handle 'response' of type WatchlistScreeningEntityProgramListResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[WatchlistScreeningEntityProgramListOperationRequest](src/ThePlaidApi/Requests/WatchlistScreeningEntityProgramListOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[WatchlistScreeningEntityProgramListResponse](src/ThePlaidApi/Models/WatchlistScreeningEntityProgramListResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;WatchlistScreeningEntityReviewCreateResponse&gt; WatchlistScreeningEntityReviewCreate(WatchlistScreeningEntityReviewCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a review for an entity watchlist screening. Reviews are compliance reports created by users in your organization regarding the relevance of potential hits found by Plaid.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WatchlistScreeningEntityReviewCreate(
        new WatchlistScreeningEntityReviewCreateOperationRequest
        {
            Body = new WatchlistScreeningEntityReviewCreateRequest
            {
                ConfirmedHits = ["some example string"],
                DismissedHits = ["some example string"],
                EntityWatchlistScreeningId = "some example string",
            },
        });
    // TODO: Handle 'response' of type WatchlistScreeningEntityReviewCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[WatchlistScreeningEntityReviewCreateOperationRequest](src/ThePlaidApi/Requests/WatchlistScreeningEntityReviewCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[WatchlistScreeningEntityReviewCreateResponse](src/ThePlaidApi/Models/WatchlistScreeningEntityReviewCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;WatchlistScreeningEntityReviewListResponse&gt; WatchlistScreeningEntityReviewList(WatchlistScreeningEntityReviewListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all reviews for a particular entity watchlist screening. Reviews are compliance reports created by users in your organization regarding the relevance of potential hits found by Plaid.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WatchlistScreeningEntityReviewList(
        new WatchlistScreeningEntityReviewListOperationRequest
        {
            Body = new WatchlistScreeningEntityReviewListRequest { EntityWatchlistScreeningId = "some example string" },
        });
    // TODO: Handle 'response' of type WatchlistScreeningEntityReviewListResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[WatchlistScreeningEntityReviewListOperationRequest](src/ThePlaidApi/Requests/WatchlistScreeningEntityReviewListOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[WatchlistScreeningEntityReviewListResponse](src/ThePlaidApi/Models/WatchlistScreeningEntityReviewListResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;WatchlistScreeningEntityUpdateResponse&gt; WatchlistScreeningEntityUpdate(WatchlistScreeningEntityUpdateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update an entity watchlist screening.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WatchlistScreeningEntityUpdate(new WatchlistScreeningEntityUpdateOperationRequest
    {
        Body = new WatchlistScreeningEntityUpdateRequest { EntityWatchlistScreeningId = "some example string" },
    });
    // TODO: Handle 'response' of type WatchlistScreeningEntityUpdateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[WatchlistScreeningEntityUpdateOperationRequest](src/ThePlaidApi/Requests/WatchlistScreeningEntityUpdateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[WatchlistScreeningEntityUpdateResponse](src/ThePlaidApi/Models/WatchlistScreeningEntityUpdateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;WatchlistScreeningIndividualCreateResponse&gt; WatchlistScreeningIndividualCreate(WatchlistScreeningIndividualCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a new Watchlist Screening to check your customer against watchlists defined in the associated Watchlist Program. If your associated program has ongoing screening enabled, this is the profile information that will be used to monitor your customer over time.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WatchlistScreeningIndividualCreate(
        new WatchlistScreeningIndividualCreateOperationRequest
        {
            Body = new WatchlistScreeningIndividualCreateRequest
            {
                SearchTerms = new WatchlistScreeningRequestSearchTerms
                {
                    WatchlistProgramId = "some example string",
                    LegalName = "some example string",
                },
            },
        });
    // TODO: Handle 'response' of type WatchlistScreeningIndividualCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[WatchlistScreeningIndividualCreateOperationRequest](src/ThePlaidApi/Requests/WatchlistScreeningIndividualCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[WatchlistScreeningIndividualCreateResponse](src/ThePlaidApi/Models/WatchlistScreeningIndividualCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;WatchlistScreeningIndividualGetResponse&gt; WatchlistScreeningIndividualGet(WatchlistScreeningIndividualGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieve a previously created individual watchlist screening

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WatchlistScreeningIndividualGet(new WatchlistScreeningIndividualGetOperationRequest
    {
        Body = new WatchlistScreeningIndividualGetRequest { WatchlistScreeningId = "some example string" },
    });
    // TODO: Handle 'response' of type WatchlistScreeningIndividualGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[WatchlistScreeningIndividualGetOperationRequest](src/ThePlaidApi/Requests/WatchlistScreeningIndividualGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[WatchlistScreeningIndividualGetResponse](src/ThePlaidApi/Models/WatchlistScreeningIndividualGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;WatchlistScreeningIndividualHistoryListResponse&gt; WatchlistScreeningIndividualHistoryList(WatchlistScreeningIndividualHistoryListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all changes to the individual watchlist screening in reverse-chronological order. If the watchlist screening has not been edited, no history will be returned.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WatchlistScreeningIndividualHistoryList(
        new WatchlistScreeningIndividualHistoryListOperationRequest
        {
            Body = new WatchlistScreeningIndividualHistoryListRequest { WatchlistScreeningId = "some example string" },
        });
    // TODO: Handle 'response' of type WatchlistScreeningIndividualHistoryListResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[WatchlistScreeningIndividualHistoryListOperationRequest](src/ThePlaidApi/Requests/WatchlistScreeningIndividualHistoryListOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[WatchlistScreeningIndividualHistoryListResponse](src/ThePlaidApi/Models/WatchlistScreeningIndividualHistoryListResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;WatchlistScreeningIndividualHitListResponse&gt; WatchlistScreeningIndividualHitList(WatchlistScreeningIndividualHitListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all hits found by Plaid for a particular individual watchlist screening.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WatchlistScreeningIndividualHitList(
        new WatchlistScreeningIndividualHitListOperationRequest
        {
            Body = new WatchlistScreeningIndividualHitListRequest { WatchlistScreeningId = "some example string" },
        });
    // TODO: Handle 'response' of type WatchlistScreeningIndividualHitListResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[WatchlistScreeningIndividualHitListOperationRequest](src/ThePlaidApi/Requests/WatchlistScreeningIndividualHitListOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[WatchlistScreeningIndividualHitListResponse](src/ThePlaidApi/Models/WatchlistScreeningIndividualHitListResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;WatchlistScreeningIndividualListResponse&gt; WatchlistScreeningIndividualList(WatchlistScreeningIndividualListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List previously created watchlist screenings for individuals

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WatchlistScreeningIndividualList(new WatchlistScreeningIndividualListOperationRequest
    {
        Body = new WatchlistScreeningIndividualListRequest { WatchlistProgramId = "some example string" },
    });
    // TODO: Handle 'response' of type WatchlistScreeningIndividualListResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[WatchlistScreeningIndividualListOperationRequest](src/ThePlaidApi/Requests/WatchlistScreeningIndividualListOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[WatchlistScreeningIndividualListResponse](src/ThePlaidApi/Models/WatchlistScreeningIndividualListResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;WatchlistScreeningIndividualProgramGetResponse&gt; WatchlistScreeningIndividualProgramGet(WatchlistScreeningIndividualProgramGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get an individual watchlist screening program

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WatchlistScreeningIndividualProgramGet(
        new WatchlistScreeningIndividualProgramGetOperationRequest
        {
            Body = new WatchlistScreeningIndividualProgramGetRequest { WatchlistProgramId = "some example string" },
        });
    // TODO: Handle 'response' of type WatchlistScreeningIndividualProgramGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[WatchlistScreeningIndividualProgramGetOperationRequest](src/ThePlaidApi/Requests/WatchlistScreeningIndividualProgramGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[WatchlistScreeningIndividualProgramGetResponse](src/ThePlaidApi/Models/WatchlistScreeningIndividualProgramGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;WatchlistScreeningIndividualProgramListResponse&gt; WatchlistScreeningIndividualProgramList(WatchlistScreeningIndividualProgramListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all individual watchlist screening programs

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WatchlistScreeningIndividualProgramList(
        new WatchlistScreeningIndividualProgramListOperationRequest
        {
            Body = new WatchlistScreeningIndividualProgramListRequest(),
        });
    // TODO: Handle 'response' of type WatchlistScreeningIndividualProgramListResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[WatchlistScreeningIndividualProgramListOperationRequest](src/ThePlaidApi/Requests/WatchlistScreeningIndividualProgramListOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[WatchlistScreeningIndividualProgramListResponse](src/ThePlaidApi/Models/WatchlistScreeningIndividualProgramListResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;WatchlistScreeningIndividualReviewCreateResponse&gt; WatchlistScreeningIndividualReviewCreate(WatchlistScreeningIndividualReviewCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a review for the individual watchlist screening. Reviews are compliance reports created by users in your organization regarding the relevance of potential hits found by Plaid.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WatchlistScreeningIndividualReviewCreate(
        new WatchlistScreeningIndividualReviewCreateOperationRequest
        {
            Body = new WatchlistScreeningIndividualReviewCreateRequest
            {
                ConfirmedHits = ["some example string"],
                DismissedHits = ["some example string"],
                WatchlistScreeningId = "some example string",
            },
        });
    // TODO: Handle 'response' of type WatchlistScreeningIndividualReviewCreateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[WatchlistScreeningIndividualReviewCreateOperationRequest](src/ThePlaidApi/Requests/WatchlistScreeningIndividualReviewCreateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[WatchlistScreeningIndividualReviewCreateResponse](src/ThePlaidApi/Models/WatchlistScreeningIndividualReviewCreateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;WatchlistScreeningIndividualReviewListResponse&gt; WatchlistScreeningIndividualReviewList(WatchlistScreeningIndividualReviewListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all reviews for the individual watchlist screening.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WatchlistScreeningIndividualReviewList(
        new WatchlistScreeningIndividualReviewListOperationRequest
        {
            Body = new WatchlistScreeningIndividualReviewListRequest { WatchlistScreeningId = "some example string" },
        });
    // TODO: Handle 'response' of type WatchlistScreeningIndividualReviewListResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[WatchlistScreeningIndividualReviewListOperationRequest](src/ThePlaidApi/Requests/WatchlistScreeningIndividualReviewListOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[WatchlistScreeningIndividualReviewListResponse](src/ThePlaidApi/Models/WatchlistScreeningIndividualReviewListResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;WatchlistScreeningIndividualUpdateResponse&gt; WatchlistScreeningIndividualUpdate(WatchlistScreeningIndividualUpdateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update a specific individual watchlist screening. This endpoint can be used to add additional customer information, correct outdated information, add a reference id, assign the individual to a reviewer, and update which program it is associated with. Please note that you may not update `search_terms` and `status` at the same time since editing `search_terms` may trigger an automatic `status` change.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WatchlistScreeningIndividualUpdate(
        new WatchlistScreeningIndividualUpdateOperationRequest
        {
            Body = new WatchlistScreeningIndividualUpdateRequest { WatchlistScreeningId = "some example string" },
        });
    // TODO: Handle 'response' of type WatchlistScreeningIndividualUpdateResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[WatchlistScreeningIndividualUpdateOperationRequest](src/ThePlaidApi/Requests/WatchlistScreeningIndividualUpdateOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[WatchlistScreeningIndividualUpdateResponse](src/ThePlaidApi/Models/WatchlistScreeningIndividualUpdateResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;WebhookVerificationKeyGetResponse&gt; WebhookVerificationKeyGet(WebhookVerificationKeyGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Plaid signs all outgoing webhooks and provides JSON Web Tokens (JWTs) so that you can verify the authenticity of any incoming webhooks to your application. A message signature is included in the `Plaid-Verification` header.

The `/webhook_verification_key/get` endpoint provides a JSON Web Key (JWK) that can be used to verify a JWT.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.WebhookVerificationKeyGet(new WebhookVerificationKeyGetOperationRequest
    {
        Body = new WebhookVerificationKeyGetRequest { KeyId = "some example string" },
    });
    // TODO: Handle 'response' of type WebhookVerificationKeyGetResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[WebhookVerificationKeyGetOperationRequest](src/ThePlaidApi/Requests/WebhookVerificationKeyGetOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[WebhookVerificationKeyGetResponse](src/ThePlaidApi/Models/WebhookVerificationKeyGetResponse.cs)</code>

**OnError**: <code>[ApiException](src/ThePlaidApi/Core/Exceptions/ApiException.cs)&lt;[RawError](src/ThePlaidApi/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>


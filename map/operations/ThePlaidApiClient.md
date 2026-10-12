<!-- Generated file — do not edit; regenerated with the SDK. -->

# ThePlaidApiClient — operations

Accessor: `client` · Source: `src/ThePlaidApi/ThePlaidApiClient.cs` · 335 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AccountsBalanceGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `AccountsBalanceGet(AccountsBalanceGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `AccountsGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AccountsBalanceGetOperationRequest` | `src/ThePlaidApi/Requests/AccountsBalanceGetOperationRequest.cs` |
| `AccountsBalanceGetRequest` | `src/ThePlaidApi/Models/AccountsBalanceGetRequest.cs` |
| `AccountsGetResponse` | `src/ThePlaidApi/Models/AccountsGetResponse.cs` |

### AccountsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `AccountsGet(AccountsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `AccountsGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AccountsGetOperationRequest` | `src/ThePlaidApi/Requests/AccountsGetOperationRequest.cs` |
| `AccountsGetRequest` | `src/ThePlaidApi/Models/AccountsGetRequest.cs` |
| `AccountsGetResponse` | `src/ThePlaidApi/Models/AccountsGetResponse.cs` |

### ApplicationGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ApplicationGet(ApplicationGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ApplicationGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ApplicationGetOperationRequest` | `src/ThePlaidApi/Requests/ApplicationGetOperationRequest.cs` |
| `ApplicationGetRequest` | `src/ThePlaidApi/Models/ApplicationGetRequest.cs` |
| `ApplicationGetResponse` | `src/ThePlaidApi/Models/ApplicationGetResponse.cs` |

### AssetReportAuditCopyCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `AssetReportAuditCopyCreate(AssetReportAuditCopyCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `AssetReportAuditCopyCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AssetReportAuditCopyCreateOperationRequest` | `src/ThePlaidApi/Requests/AssetReportAuditCopyCreateOperationRequest.cs` |
| `AssetReportAuditCopyCreateRequest` | `src/ThePlaidApi/Models/AssetReportAuditCopyCreateRequest.cs` |
| `AssetReportAuditCopyCreateResponse` | `src/ThePlaidApi/Models/AssetReportAuditCopyCreateResponse.cs` |

### AssetReportAuditCopyGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `AssetReportAuditCopyGet(AssetReportAuditCopyGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `AssetReportGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AssetReportAuditCopyGetOperationRequest` | `src/ThePlaidApi/Requests/AssetReportAuditCopyGetOperationRequest.cs` |
| `AssetReportAuditCopyGetRequest` | `src/ThePlaidApi/Models/AssetReportAuditCopyGetRequest.cs` |
| `AssetReportGetResponse` | `src/ThePlaidApi/Models/AssetReportGetResponse.cs` |

### AssetReportAuditCopyPdfGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `AssetReportAuditCopyPdfGet(AssetReportAuditCopyPdfGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AssetReportAuditCopyPdfGetOperationRequest` | `src/ThePlaidApi/Requests/AssetReportAuditCopyPdfGetOperationRequest.cs` |
| `AssetReportAuditCopyPdfGetRequest` | `src/ThePlaidApi/Models/AssetReportAuditCopyPdfGetRequest.cs` |

### AssetReportAuditCopyRemove

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `AssetReportAuditCopyRemove(AssetReportAuditCopyRemoveOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `AssetReportAuditCopyRemoveResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AssetReportAuditCopyRemoveOperationRequest` | `src/ThePlaidApi/Requests/AssetReportAuditCopyRemoveOperationRequest.cs` |
| `AssetReportAuditCopyRemoveRequest` | `src/ThePlaidApi/Models/AssetReportAuditCopyRemoveRequest.cs` |
| `AssetReportAuditCopyRemoveResponse` | `src/ThePlaidApi/Models/AssetReportAuditCopyRemoveResponse.cs` |

### AssetReportCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `AssetReportCreate(AssetReportCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `AssetReportCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AssetReportCreateOperationRequest` | `src/ThePlaidApi/Requests/AssetReportCreateOperationRequest.cs` |
| `AssetReportCreateRequest` | `src/ThePlaidApi/Models/AssetReportCreateRequest.cs` |
| `AssetReportCreateResponse` | `src/ThePlaidApi/Models/AssetReportCreateResponse.cs` |

### AssetReportFilter

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `AssetReportFilter(AssetReportFilterOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `AssetReportFilterResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AssetReportFilterOperationRequest` | `src/ThePlaidApi/Requests/AssetReportFilterOperationRequest.cs` |
| `AssetReportFilterRequest` | `src/ThePlaidApi/Models/AssetReportFilterRequest.cs` |
| `AssetReportFilterResponse` | `src/ThePlaidApi/Models/AssetReportFilterResponse.cs` |

### AssetReportGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `AssetReportGet(AssetReportGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `AssetReportGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AssetReportGetOperationRequest` | `src/ThePlaidApi/Requests/AssetReportGetOperationRequest.cs` |
| `AssetReportGetRequest` | `src/ThePlaidApi/Models/AssetReportGetRequest.cs` |
| `AssetReportGetResponse` | `src/ThePlaidApi/Models/AssetReportGetResponse.cs` |

### AssetReportPdfGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `AssetReportPdfGet(AssetReportPdfGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AssetReportPdfGetOperationRequest` | `src/ThePlaidApi/Requests/AssetReportPdfGetOperationRequest.cs` |
| `AssetReportPdfGetRequest` | `src/ThePlaidApi/Models/AssetReportPdfGetRequest.cs` |

### AssetReportRefresh

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `AssetReportRefresh(AssetReportRefreshOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `AssetReportRefreshResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AssetReportRefreshOperationRequest` | `src/ThePlaidApi/Requests/AssetReportRefreshOperationRequest.cs` |
| `AssetReportRefreshRequest` | `src/ThePlaidApi/Models/AssetReportRefreshRequest.cs` |
| `AssetReportRefreshResponse` | `src/ThePlaidApi/Models/AssetReportRefreshResponse.cs` |

### AssetReportRemove

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `AssetReportRemove(AssetReportRemoveOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `AssetReportRemoveResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AssetReportRemoveOperationRequest` | `src/ThePlaidApi/Requests/AssetReportRemoveOperationRequest.cs` |
| `AssetReportRemoveRequest` | `src/ThePlaidApi/Models/AssetReportRemoveRequest.cs` |
| `AssetReportRemoveResponse` | `src/ThePlaidApi/Models/AssetReportRemoveResponse.cs` |

### AuthGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `AuthGet(AuthGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `AuthGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AuthGetOperationRequest` | `src/ThePlaidApi/Requests/AuthGetOperationRequest.cs` |
| `AuthGetRequest` | `src/ThePlaidApi/Models/AuthGetRequest.cs` |
| `AuthGetResponse` | `src/ThePlaidApi/Models/AuthGetResponse.cs` |

### AuthVerify

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `AuthVerify(AuthVerifyOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `AuthVerifyResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AuthVerifyOperationRequest` | `src/ThePlaidApi/Requests/AuthVerifyOperationRequest.cs` |
| `AuthVerifyRequest` | `src/ThePlaidApi/Models/AuthVerifyRequest.cs` |
| `AuthVerifyResponse` | `src/ThePlaidApi/Models/AuthVerifyResponse.cs` |

### BankTransferBalanceGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BankTransferBalanceGet(BankTransferBalanceGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BankTransferBalanceGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BankTransferBalanceGetOperationRequest` | `src/ThePlaidApi/Requests/BankTransferBalanceGetOperationRequest.cs` |
| `BankTransferBalanceGetRequest` | `src/ThePlaidApi/Models/BankTransferBalanceGetRequest.cs` |
| `BankTransferBalanceGetResponse` | `src/ThePlaidApi/Models/BankTransferBalanceGetResponse.cs` |

### BankTransferCancel

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BankTransferCancel(BankTransferCancelOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BankTransferCancelResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BankTransferCancelOperationRequest` | `src/ThePlaidApi/Requests/BankTransferCancelOperationRequest.cs` |
| `BankTransferCancelRequest` | `src/ThePlaidApi/Models/BankTransferCancelRequest.cs` |
| `BankTransferCancelResponse` | `src/ThePlaidApi/Models/BankTransferCancelResponse.cs` |

### BankTransferCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BankTransferCreate(BankTransferCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BankTransferCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BankTransferCreateOperationRequest` | `src/ThePlaidApi/Requests/BankTransferCreateOperationRequest.cs` |
| `BankTransferCreateRequest` | `src/ThePlaidApi/Models/BankTransferCreateRequest.cs` |
| `BankTransferCreateResponse` | `src/ThePlaidApi/Models/BankTransferCreateResponse.cs` |

### BankTransferEventList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BankTransferEventList(BankTransferEventListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BankTransferEventListResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BankTransferEventListOperationRequest` | `src/ThePlaidApi/Requests/BankTransferEventListOperationRequest.cs` |
| `BankTransferEventListRequest` | `src/ThePlaidApi/Models/BankTransferEventListRequest.cs` |
| `BankTransferEventListResponse` | `src/ThePlaidApi/Models/BankTransferEventListResponse.cs` |

### BankTransferEventSync

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BankTransferEventSync(BankTransferEventSyncOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BankTransferEventSyncResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BankTransferEventSyncOperationRequest` | `src/ThePlaidApi/Requests/BankTransferEventSyncOperationRequest.cs` |
| `BankTransferEventSyncRequest` | `src/ThePlaidApi/Models/BankTransferEventSyncRequest.cs` |
| `BankTransferEventSyncResponse` | `src/ThePlaidApi/Models/BankTransferEventSyncResponse.cs` |

### BankTransferGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BankTransferGet(BankTransferGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BankTransferGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BankTransferGetOperationRequest` | `src/ThePlaidApi/Requests/BankTransferGetOperationRequest.cs` |
| `BankTransferGetRequest` | `src/ThePlaidApi/Models/BankTransferGetRequest.cs` |
| `BankTransferGetResponse` | `src/ThePlaidApi/Models/BankTransferGetResponse.cs` |

### BankTransferList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BankTransferList(BankTransferListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BankTransferListResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BankTransferListOperationRequest` | `src/ThePlaidApi/Requests/BankTransferListOperationRequest.cs` |
| `BankTransferListRequest` | `src/ThePlaidApi/Models/BankTransferListRequest.cs` |
| `BankTransferListResponse` | `src/ThePlaidApi/Models/BankTransferListResponse.cs` |

### BankTransferMigrateAccount

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BankTransferMigrateAccount(BankTransferMigrateAccountOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BankTransferMigrateAccountResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BankTransferMigrateAccountOperationRequest` | `src/ThePlaidApi/Requests/BankTransferMigrateAccountOperationRequest.cs` |
| `BankTransferMigrateAccountRequest` | `src/ThePlaidApi/Models/BankTransferMigrateAccountRequest.cs` |
| `BankTransferMigrateAccountResponse` | `src/ThePlaidApi/Models/BankTransferMigrateAccountResponse.cs` |

### BankTransferSweepGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BankTransferSweepGet(BankTransferSweepGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BankTransferSweepGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BankTransferSweepGetOperationRequest` | `src/ThePlaidApi/Requests/BankTransferSweepGetOperationRequest.cs` |
| `BankTransferSweepGetRequest` | `src/ThePlaidApi/Models/BankTransferSweepGetRequest.cs` |
| `BankTransferSweepGetResponse` | `src/ThePlaidApi/Models/BankTransferSweepGetResponse.cs` |

### BankTransferSweepList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BankTransferSweepList(BankTransferSweepListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BankTransferSweepListResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BankTransferSweepListOperationRequest` | `src/ThePlaidApi/Requests/BankTransferSweepListOperationRequest.cs` |
| `BankTransferSweepListRequest` | `src/ThePlaidApi/Models/BankTransferSweepListRequest.cs` |
| `BankTransferSweepListResponse` | `src/ThePlaidApi/Models/BankTransferSweepListResponse.cs` |

### BeaconAccountRiskEvaluate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BeaconAccountRiskEvaluate(BeaconAccountRiskEvaluateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BeaconAccountRiskEvaluateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BeaconAccountRiskEvaluateOperationRequest` | `src/ThePlaidApi/Requests/BeaconAccountRiskEvaluateOperationRequest.cs` |
| `BeaconAccountRiskEvaluateRequest` | `src/ThePlaidApi/Models/BeaconAccountRiskEvaluateRequest.cs` |
| `BeaconAccountRiskEvaluateResponse` | `src/ThePlaidApi/Models/BeaconAccountRiskEvaluateResponse.cs` |

### BeaconDuplicateGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BeaconDuplicateGet(BeaconDuplicateGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BeaconDuplicateGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BeaconDuplicateGetOperationRequest` | `src/ThePlaidApi/Requests/BeaconDuplicateGetOperationRequest.cs` |
| `BeaconDuplicateGetRequest` | `src/ThePlaidApi/Models/BeaconDuplicateGetRequest.cs` |
| `BeaconDuplicateGetResponse` | `src/ThePlaidApi/Models/BeaconDuplicateGetResponse.cs` |

### BeaconReportCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BeaconReportCreate(BeaconReportCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BeaconReportCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BeaconReportCreateOperationRequest` | `src/ThePlaidApi/Requests/BeaconReportCreateOperationRequest.cs` |
| `BeaconReportCreateRequest` | `src/ThePlaidApi/Models/BeaconReportCreateRequest.cs` |
| `BeaconReportCreateResponse` | `src/ThePlaidApi/Models/BeaconReportCreateResponse.cs` |

### BeaconReportGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BeaconReportGet(BeaconReportGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BeaconReportGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BeaconReportGetOperationRequest` | `src/ThePlaidApi/Requests/BeaconReportGetOperationRequest.cs` |
| `BeaconReportGetRequest` | `src/ThePlaidApi/Models/BeaconReportGetRequest.cs` |
| `BeaconReportGetResponse` | `src/ThePlaidApi/Models/BeaconReportGetResponse.cs` |

### BeaconReportList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BeaconReportList(BeaconReportListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BeaconReportListResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BeaconReportListOperationRequest` | `src/ThePlaidApi/Requests/BeaconReportListOperationRequest.cs` |
| `BeaconReportListRequest` | `src/ThePlaidApi/Models/BeaconReportListRequest.cs` |
| `BeaconReportListResponse` | `src/ThePlaidApi/Models/BeaconReportListResponse.cs` |

### BeaconReportSyndicationGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BeaconReportSyndicationGet(BeaconReportSyndicationGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BeaconReportSyndicationGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BeaconReportSyndicationGetOperationRequest` | `src/ThePlaidApi/Requests/BeaconReportSyndicationGetOperationRequest.cs` |
| `BeaconReportSyndicationGetRequest` | `src/ThePlaidApi/Models/BeaconReportSyndicationGetRequest.cs` |
| `BeaconReportSyndicationGetResponse` | `src/ThePlaidApi/Models/BeaconReportSyndicationGetResponse.cs` |

### BeaconReportSyndicationList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BeaconReportSyndicationList(BeaconReportSyndicationListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BeaconReportSyndicationListResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BeaconReportSyndicationListOperationRequest` | `src/ThePlaidApi/Requests/BeaconReportSyndicationListOperationRequest.cs` |
| `BeaconReportSyndicationListRequest` | `src/ThePlaidApi/Models/BeaconReportSyndicationListRequest.cs` |
| `BeaconReportSyndicationListResponse` | `src/ThePlaidApi/Models/BeaconReportSyndicationListResponse.cs` |

### BeaconUserAccountInsightsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BeaconUserAccountInsightsGet(BeaconUserAccountInsightsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BeaconUserAccountInsightsGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BeaconUserAccountInsightsGetOperationRequest` | `src/ThePlaidApi/Requests/BeaconUserAccountInsightsGetOperationRequest.cs` |
| `BeaconUserAccountInsightsGetRequest` | `src/ThePlaidApi/Models/BeaconUserAccountInsightsGetRequest.cs` |
| `BeaconUserAccountInsightsGetResponse` | `src/ThePlaidApi/Models/BeaconUserAccountInsightsGetResponse.cs` |

### BeaconUserCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BeaconUserCreate(BeaconUserCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BeaconUserCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BeaconUserCreateOperationRequest` | `src/ThePlaidApi/Requests/BeaconUserCreateOperationRequest.cs` |
| `BeaconUserCreateRequest` | `src/ThePlaidApi/Models/BeaconUserCreateRequest.cs` |
| `BeaconUserCreateResponse` | `src/ThePlaidApi/Models/BeaconUserCreateResponse.cs` |

### BeaconUserGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BeaconUserGet(BeaconUserGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BeaconUserGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BeaconUserGetOperationRequest` | `src/ThePlaidApi/Requests/BeaconUserGetOperationRequest.cs` |
| `BeaconUserGetRequest` | `src/ThePlaidApi/Models/BeaconUserGetRequest.cs` |
| `BeaconUserGetResponse` | `src/ThePlaidApi/Models/BeaconUserGetResponse.cs` |

### BeaconUserHistoryList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BeaconUserHistoryList(BeaconUserHistoryListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BeaconUserHistoryListResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BeaconUserHistoryListOperationRequest` | `src/ThePlaidApi/Requests/BeaconUserHistoryListOperationRequest.cs` |
| `BeaconUserHistoryListRequest` | `src/ThePlaidApi/Models/BeaconUserHistoryListRequest.cs` |
| `BeaconUserHistoryListResponse` | `src/ThePlaidApi/Models/BeaconUserHistoryListResponse.cs` |

### BeaconUserReview

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BeaconUserReview(BeaconUserReviewOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BeaconUserGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BeaconUserReviewOperationRequest` | `src/ThePlaidApi/Requests/BeaconUserReviewOperationRequest.cs` |
| `BeaconUserReviewRequest` | `src/ThePlaidApi/Models/BeaconUserReviewRequest.cs` |
| `BeaconUserGetResponse` | `src/ThePlaidApi/Models/BeaconUserGetResponse.cs` |

### BeaconUserUpdate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BeaconUserUpdate(BeaconUserUpdateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BeaconUserUpdateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BeaconUserUpdateOperationRequest` | `src/ThePlaidApi/Requests/BeaconUserUpdateOperationRequest.cs` |
| `BeaconUserUpdateRequest` | `src/ThePlaidApi/Models/BeaconUserUpdateRequest.cs` |
| `BeaconUserUpdateResponse` | `src/ThePlaidApi/Models/BeaconUserUpdateResponse.cs` |

### BetaEwaReportV1Get

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BetaEwaReportV1Get(BetaEwaReportV1GetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BetaEwaReportV1GetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BetaEwaReportV1GetOperationRequest` | `src/ThePlaidApi/Requests/BetaEwaReportV1GetOperationRequest.cs` |
| `BetaEwaReportV1GetRequest` | `src/ThePlaidApi/Models/BetaEwaReportV1GetRequest.cs` |
| `BetaEwaReportV1GetResponse` | `src/ThePlaidApi/Models/BetaEwaReportV1GetResponse.cs` |

### BetaPartnerCustomerV1Create

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BetaPartnerCustomerV1Create(BetaPartnerCustomerV1CreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BetaPartnerCustomerV1CreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BetaPartnerCustomerV1CreateOperationRequest` | `src/ThePlaidApi/Requests/BetaPartnerCustomerV1CreateOperationRequest.cs` |
| `BetaPartnerCustomerV1CreateRequest` | `src/ThePlaidApi/Models/BetaPartnerCustomerV1CreateRequest.cs` |
| `BetaPartnerCustomerV1CreateResponse` | `src/ThePlaidApi/Models/BetaPartnerCustomerV1CreateResponse.cs` |

### BetaPartnerCustomerV1Enable

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BetaPartnerCustomerV1Enable(BetaPartnerCustomerV1EnableOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BetaPartnerCustomerV1EnableResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BetaPartnerCustomerV1EnableOperationRequest` | `src/ThePlaidApi/Requests/BetaPartnerCustomerV1EnableOperationRequest.cs` |
| `BetaPartnerCustomerV1EnableRequest` | `src/ThePlaidApi/Models/BetaPartnerCustomerV1EnableRequest.cs` |
| `BetaPartnerCustomerV1EnableResponse` | `src/ThePlaidApi/Models/BetaPartnerCustomerV1EnableResponse.cs` |

### BetaPartnerCustomerV1Get

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BetaPartnerCustomerV1Get(BetaPartnerCustomerV1GetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BetaPartnerCustomerV1GetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BetaPartnerCustomerV1GetOperationRequest` | `src/ThePlaidApi/Requests/BetaPartnerCustomerV1GetOperationRequest.cs` |
| `BetaPartnerCustomerV1GetRequest` | `src/ThePlaidApi/Models/BetaPartnerCustomerV1GetRequest.cs` |
| `BetaPartnerCustomerV1GetResponse` | `src/ThePlaidApi/Models/BetaPartnerCustomerV1GetResponse.cs` |

### BetaPartnerCustomerV1Update

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BetaPartnerCustomerV1Update(BetaPartnerCustomerV1UpdateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BetaPartnerCustomerV1UpdateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BetaPartnerCustomerV1UpdateOperationRequest` | `src/ThePlaidApi/Requests/BetaPartnerCustomerV1UpdateOperationRequest.cs` |
| `BetaPartnerCustomerV1UpdateRequest` | `src/ThePlaidApi/Models/BetaPartnerCustomerV1UpdateRequest.cs` |
| `BetaPartnerCustomerV1UpdateResponse` | `src/ThePlaidApi/Models/BetaPartnerCustomerV1UpdateResponse.cs` |

### BusinessVerificationCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BusinessVerificationCreate(BusinessVerificationCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BusinessVerificationCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BusinessVerificationCreateOperationRequest` | `src/ThePlaidApi/Requests/BusinessVerificationCreateOperationRequest.cs` |
| `BusinessVerificationCreateRequest` | `src/ThePlaidApi/Models/BusinessVerificationCreateRequest.cs` |
| `BusinessVerificationCreateResponse` | `src/ThePlaidApi/Models/BusinessVerificationCreateResponse.cs` |

### BusinessVerificationGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BusinessVerificationGet(BusinessVerificationGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BusinessVerificationGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BusinessVerificationGetOperationRequest` | `src/ThePlaidApi/Requests/BusinessVerificationGetOperationRequest.cs` |
| `BusinessVerificationGetRequest` | `src/ThePlaidApi/Models/BusinessVerificationGetRequest.cs` |
| `BusinessVerificationGetResponse` | `src/ThePlaidApi/Models/BusinessVerificationGetResponse.cs` |

### CashflowReportGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CashflowReportGet(CashflowReportGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CashflowReportGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CashflowReportGetOperationRequest` | `src/ThePlaidApi/Requests/CashflowReportGetOperationRequest.cs` |
| `CashflowReportGetRequest` | `src/ThePlaidApi/Models/CashflowReportGetRequest.cs` |
| `CashflowReportGetResponse` | `src/ThePlaidApi/Models/CashflowReportGetResponse.cs` |

### CashflowReportInsightsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CashflowReportInsightsGet(CashflowReportInsightsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CashflowReportInsightsGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CashflowReportInsightsGetOperationRequest` | `src/ThePlaidApi/Requests/CashflowReportInsightsGetOperationRequest.cs` |
| `CashflowReportInsightsGetRequest` | `src/ThePlaidApi/Models/CashflowReportInsightsGetRequest.cs` |
| `CashflowReportInsightsGetResponse` | `src/ThePlaidApi/Models/CashflowReportInsightsGetResponse.cs` |

### CashflowReportRefresh

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CashflowReportRefresh(CashflowReportRefreshOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CashflowReportRefreshResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CashflowReportRefreshOperationRequest` | `src/ThePlaidApi/Requests/CashflowReportRefreshOperationRequest.cs` |
| `CashflowReportRefreshRequest` | `src/ThePlaidApi/Models/CashflowReportRefreshRequest.cs` |
| `CashflowReportRefreshResponse` | `src/ThePlaidApi/Models/CashflowReportRefreshResponse.cs` |

### CashflowReportTransactionsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CashflowReportTransactionsGet(CashflowReportTransactionsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CashflowReportTransactionsGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CashflowReportTransactionsGetOperationRequest` | `src/ThePlaidApi/Requests/CashflowReportTransactionsGetOperationRequest.cs` |
| `CashflowReportTransactionsGetRequest` | `src/ThePlaidApi/Models/CashflowReportTransactionsGetRequest.cs` |
| `CashflowReportTransactionsGetResponse` | `src/ThePlaidApi/Models/CashflowReportTransactionsGetResponse.cs` |

### CategoriesGet

- **Signature**: `CategoriesGet(CategoriesGetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CategoriesGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CategoriesGetRequest` | `src/ThePlaidApi/Requests/CategoriesGetRequest.cs` |
| `CategoriesGetResponse` | `src/ThePlaidApi/Models/CategoriesGetResponse.cs` |

### ConsentEventsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ConsentEventsGet(ConsentEventsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ConsentEventsGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ConsentEventsGetOperationRequest` | `src/ThePlaidApi/Requests/ConsentEventsGetOperationRequest.cs` |
| `ConsentEventsGetRequest` | `src/ThePlaidApi/Models/ConsentEventsGetRequest.cs` |
| `ConsentEventsGetResponse` | `src/ThePlaidApi/Models/ConsentEventsGetResponse.cs` |

### ConsumerReportPdfGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ConsumerReportPdfGet(ConsumerReportPdfGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ConsumerReportPdfGetOperationRequest` | `src/ThePlaidApi/Requests/ConsumerReportPdfGetOperationRequest.cs` |
| `ConsumerReportPdfGetRequest` | `src/ThePlaidApi/Models/ConsumerReportPdfGetRequest.cs` |

### CraCheckReportBaseReportGet

- **Auth**: (`options.ClientId` AND `options.Secret` AND `options.PlaidVersion`) OR `options.Oauth2`
- **Signature**: `CraCheckReportBaseReportGet(CraCheckReportBaseReportGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CraCheckReportBaseReportGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CraCheckReportBaseReportGetOperationRequest` | `src/ThePlaidApi/Requests/CraCheckReportBaseReportGetOperationRequest.cs` |
| `CraCheckReportBaseReportGetRequest` | `src/ThePlaidApi/Models/CraCheckReportBaseReportGetRequest.cs` |
| `CraCheckReportBaseReportGetResponse` | `src/ThePlaidApi/Models/CraCheckReportBaseReportGetResponse.cs` |

### CraCheckReportCashflowInsightsGet

- **Auth**: (`options.ClientId` AND `options.Secret` AND `options.PlaidVersion`) OR `options.Oauth2`
- **Signature**: `CraCheckReportCashflowInsightsGet(CraCheckReportCashflowInsightsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CraCheckReportCashflowInsightsGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CraCheckReportCashflowInsightsGetOperationRequest` | `src/ThePlaidApi/Requests/CraCheckReportCashflowInsightsGetOperationRequest.cs` |
| `CraCheckReportCashflowInsightsGetRequest` | `src/ThePlaidApi/Models/CraCheckReportCashflowInsightsGetRequest.cs` |
| `CraCheckReportCashflowInsightsGetResponse` | `src/ThePlaidApi/Models/CraCheckReportCashflowInsightsGetResponse.cs` |

### CraCheckReportCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CraCheckReportCreate(CraCheckReportCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CraCheckReportCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CraCheckReportCreateOperationRequest` | `src/ThePlaidApi/Requests/CraCheckReportCreateOperationRequest.cs` |
| `CraCheckReportCreateRequest` | `src/ThePlaidApi/Models/CraCheckReportCreateRequest.cs` |
| `CraCheckReportCreateResponse` | `src/ThePlaidApi/Models/CraCheckReportCreateResponse.cs` |

### CraCheckReportIncomeInsightsGet

- **Auth**: (`options.ClientId` AND `options.Secret` AND `options.PlaidVersion`) OR `options.Oauth2`
- **Signature**: `CraCheckReportIncomeInsightsGet(CraCheckReportIncomeInsightsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CraCheckReportIncomeInsightsGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CraCheckReportIncomeInsightsGetOperationRequest` | `src/ThePlaidApi/Requests/CraCheckReportIncomeInsightsGetOperationRequest.cs` |
| `CraCheckReportIncomeInsightsGetRequest` | `src/ThePlaidApi/Models/CraCheckReportIncomeInsightsGetRequest.cs` |
| `CraCheckReportIncomeInsightsGetResponse` | `src/ThePlaidApi/Models/CraCheckReportIncomeInsightsGetResponse.cs` |

### CraCheckReportLendScoreGet

- **Auth**: (`options.ClientId` AND `options.Secret` AND `options.PlaidVersion`) OR `options.Oauth2`
- **Signature**: `CraCheckReportLendScoreGet(CraCheckReportLendScoreGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CraCheckReportLendScoreGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CraCheckReportLendScoreGetOperationRequest` | `src/ThePlaidApi/Requests/CraCheckReportLendScoreGetOperationRequest.cs` |
| `CraCheckReportLendScoreGetRequest` | `src/ThePlaidApi/Models/CraCheckReportLendScoreGetRequest.cs` |
| `CraCheckReportLendScoreGetResponse` | `src/ThePlaidApi/Models/CraCheckReportLendScoreGetResponse.cs` |

### CraCheckReportNetworkInsightsGet

- **Auth**: (`options.ClientId` AND `options.Secret` AND `options.PlaidVersion`) OR `options.Oauth2`
- **Signature**: `CraCheckReportNetworkInsightsGet(CraCheckReportNetworkInsightsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CraCheckReportNetworkInsightsGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CraCheckReportNetworkInsightsGetOperationRequest` | `src/ThePlaidApi/Requests/CraCheckReportNetworkInsightsGetOperationRequest.cs` |
| `CraCheckReportNetworkInsightsGetRequest` | `src/ThePlaidApi/Models/CraCheckReportNetworkInsightsGetRequest.cs` |
| `CraCheckReportNetworkInsightsGetResponse` | `src/ThePlaidApi/Models/CraCheckReportNetworkInsightsGetResponse.cs` |

### CraCheckReportPartnerInsightsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CraCheckReportPartnerInsightsGet(CraCheckReportPartnerInsightsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CraCheckReportPartnerInsightsGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CraCheckReportPartnerInsightsGetOperationRequest` | `src/ThePlaidApi/Requests/CraCheckReportPartnerInsightsGetOperationRequest.cs` |
| `CraCheckReportPartnerInsightsGetRequest` | `src/ThePlaidApi/Models/CraCheckReportPartnerInsightsGetRequest.cs` |
| `CraCheckReportPartnerInsightsGetResponse` | `src/ThePlaidApi/Models/CraCheckReportPartnerInsightsGetResponse.cs` |

### CraCheckReportPdfGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CraCheckReportPdfGet(CraCheckReportPdfGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CraCheckReportPdfGetOperationRequest` | `src/ThePlaidApi/Requests/CraCheckReportPdfGetOperationRequest.cs` |
| `CraCheckReportPdfGetRequest` | `src/ThePlaidApi/Models/CraCheckReportPdfGetRequest.cs` |

### CraCheckReportVerificationGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CraCheckReportVerificationGet(CraCheckReportVerificationGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CraCheckReportVerificationGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CraCheckReportVerificationGetOperationRequest` | `src/ThePlaidApi/Requests/CraCheckReportVerificationGetOperationRequest.cs` |
| `CraCheckReportVerificationGetRequest` | `src/ThePlaidApi/Models/CraCheckReportVerificationGetRequest.cs` |
| `CraCheckReportVerificationGetResponse` | `src/ThePlaidApi/Models/CraCheckReportVerificationGetResponse.cs` |

### CraCheckReportVerificationPdfGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CraCheckReportVerificationPdfGet(CraCheckReportVerificationPdfGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CraCheckReportVerificationPdfGetOperationRequest` | `src/ThePlaidApi/Requests/CraCheckReportVerificationPdfGetOperationRequest.cs` |
| `CraCheckReportVerificationPdfGetRequest` | `src/ThePlaidApi/Models/CraCheckReportVerificationPdfGetRequest.cs` |

### CraCreditProfileReportGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CraCreditProfileReportGet(CraCreditProfileReportGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CraCreditProfileReportGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CraCreditProfileReportGetOperationRequest` | `src/ThePlaidApi/Requests/CraCreditProfileReportGetOperationRequest.cs` |
| `CraCreditProfileReportGetRequest` | `src/ThePlaidApi/Models/CraCreditProfileReportGetRequest.cs` |
| `CraCreditProfileReportGetResponse` | `src/ThePlaidApi/Models/CraCreditProfileReportGetResponse.cs` |

### CraLoansApplicationsRegister

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CraLoansApplicationsRegister(CraLoansApplicationsRegisterOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CraLoansApplicationsRegisterResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CraLoansApplicationsRegisterOperationRequest` | `src/ThePlaidApi/Requests/CraLoansApplicationsRegisterOperationRequest.cs` |
| `CraLoansApplicationsRegisterRequest` | `src/ThePlaidApi/Models/CraLoansApplicationsRegisterRequest.cs` |
| `CraLoansApplicationsRegisterResponse` | `src/ThePlaidApi/Models/CraLoansApplicationsRegisterResponse.cs` |

### CraLoansRegister

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CraLoansRegister(CraLoansRegisterOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CraLoansRegisterResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CraLoansRegisterOperationRequest` | `src/ThePlaidApi/Requests/CraLoansRegisterOperationRequest.cs` |
| `CraLoansRegisterRequest` | `src/ThePlaidApi/Models/CraLoansRegisterRequest.cs` |
| `CraLoansRegisterResponse` | `src/ThePlaidApi/Models/CraLoansRegisterResponse.cs` |

### CraLoansUnregister

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CraLoansUnregister(CraLoansUnregisterOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CraLoanUnregisterResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CraLoansUnregisterOperationRequest` | `src/ThePlaidApi/Requests/CraLoansUnregisterOperationRequest.cs` |
| `CraLoansUnregisterRequest` | `src/ThePlaidApi/Models/CraLoansUnregisterRequest.cs` |
| `CraLoanUnregisterResponse` | `src/ThePlaidApi/Models/CraLoanUnregisterResponse.cs` |

### CraLoansUpdate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CraLoansUpdate(CraLoansUpdateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CraLoansUpdateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CraLoansUpdateOperationRequest` | `src/ThePlaidApi/Requests/CraLoansUpdateOperationRequest.cs` |
| `CraLoansUpdateRequest` | `src/ThePlaidApi/Models/CraLoansUpdateRequest.cs` |
| `CraLoansUpdateResponse` | `src/ThePlaidApi/Models/CraLoansUpdateResponse.cs` |

### CraMonitoringInsightsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CraMonitoringInsightsGet(CraMonitoringInsightsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CraMonitoringInsightsGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CraMonitoringInsightsGetOperationRequest` | `src/ThePlaidApi/Requests/CraMonitoringInsightsGetOperationRequest.cs` |
| `CraMonitoringInsightsGetRequest` | `src/ThePlaidApi/Models/CraMonitoringInsightsGetRequest.cs` |
| `CraMonitoringInsightsGetResponse` | `src/ThePlaidApi/Models/CraMonitoringInsightsGetResponse.cs` |

### CraMonitoringInsightsSubscribe

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CraMonitoringInsightsSubscribe(CraMonitoringInsightsSubscribeOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CraMonitoringInsightsSubscribeResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CraMonitoringInsightsSubscribeOperationRequest` | `src/ThePlaidApi/Requests/CraMonitoringInsightsSubscribeOperationRequest.cs` |
| `CraMonitoringInsightsSubscribeRequest` | `src/ThePlaidApi/Models/CraMonitoringInsightsSubscribeRequest.cs` |
| `CraMonitoringInsightsSubscribeResponse` | `src/ThePlaidApi/Models/CraMonitoringInsightsSubscribeResponse.cs` |

### CraMonitoringInsightsUnsubscribe

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CraMonitoringInsightsUnsubscribe(CraMonitoringInsightsUnsubscribeOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CraMonitoringInsightsUnsubscribeResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CraMonitoringInsightsUnsubscribeOperationRequest` | `src/ThePlaidApi/Requests/CraMonitoringInsightsUnsubscribeOperationRequest.cs` |
| `CraMonitoringInsightsUnsubscribeRequest` | `src/ThePlaidApi/Models/CraMonitoringInsightsUnsubscribeRequest.cs` |
| `CraMonitoringInsightsUnsubscribeResponse` | `src/ThePlaidApi/Models/CraMonitoringInsightsUnsubscribeResponse.cs` |

### CraPartnerInsightsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CraPartnerInsightsGet(CraPartnerInsightsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CraPartnerInsightsGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CraPartnerInsightsGetOperationRequest` | `src/ThePlaidApi/Requests/CraPartnerInsightsGetOperationRequest.cs` |
| `CraPartnerInsightsGetRequest` | `src/ThePlaidApi/Models/CraPartnerInsightsGetRequest.cs` |
| `CraPartnerInsightsGetResponse` | `src/ThePlaidApi/Models/CraPartnerInsightsGetResponse.cs` |

### CraReportGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CraReportGet(CraReportGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CraReportGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CraReportGetOperationRequest` | `src/ThePlaidApi/Requests/CraReportGetOperationRequest.cs` |
| `CraReportGetRequest` | `src/ThePlaidApi/Models/CraReportGetRequest.cs` |
| `CraReportGetResponse` | `src/ThePlaidApi/Models/CraReportGetResponse.cs` |

### CreatePaymentToken

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CreatePaymentToken(CreatePaymentTokenRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `PaymentInitiationPaymentTokenCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreatePaymentTokenRequest` | `src/ThePlaidApi/Requests/CreatePaymentTokenRequest.cs` |
| `PaymentInitiationPaymentTokenCreateRequest` | `src/ThePlaidApi/Models/PaymentInitiationPaymentTokenCreateRequest.cs` |
| `PaymentInitiationPaymentTokenCreateResponse` | `src/ThePlaidApi/Models/PaymentInitiationPaymentTokenCreateResponse.cs` |

### CreditAssetReportFreddieMacGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CreditAssetReportFreddieMacGet(CreditAssetReportFreddieMacGetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `AssetReportFreddieGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreditAssetReportFreddieMacGetRequest` | `src/ThePlaidApi/Requests/CreditAssetReportFreddieMacGetRequest.cs` |
| `AssetReportFreddieGetRequest` | `src/ThePlaidApi/Models/AssetReportFreddieGetRequest.cs` |
| `AssetReportFreddieGetResponse` | `src/ThePlaidApi/Models/AssetReportFreddieGetResponse.cs` |

### CreditAuditCopyTokenCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CreditAuditCopyTokenCreate(CreditAuditCopyTokenCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreditAuditCopyTokenCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreditAuditCopyTokenCreateOperationRequest` | `src/ThePlaidApi/Requests/CreditAuditCopyTokenCreateOperationRequest.cs` |
| `CreditAuditCopyTokenCreateRequest` | `src/ThePlaidApi/Models/CreditAuditCopyTokenCreateRequest.cs` |
| `CreditAuditCopyTokenCreateResponse` | `src/ThePlaidApi/Models/CreditAuditCopyTokenCreateResponse.cs` |

### CreditAuditCopyTokenUpdate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CreditAuditCopyTokenUpdate(CreditAuditCopyTokenUpdateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreditAuditCopyTokenUpdateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreditAuditCopyTokenUpdateOperationRequest` | `src/ThePlaidApi/Requests/CreditAuditCopyTokenUpdateOperationRequest.cs` |
| `CreditAuditCopyTokenUpdateRequest` | `src/ThePlaidApi/Models/CreditAuditCopyTokenUpdateRequest.cs` |
| `CreditAuditCopyTokenUpdateResponse` | `src/ThePlaidApi/Models/CreditAuditCopyTokenUpdateResponse.cs` |

### CreditBankEmploymentGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CreditBankEmploymentGet(CreditBankEmploymentGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreditBankEmploymentGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreditBankEmploymentGetOperationRequest` | `src/ThePlaidApi/Requests/CreditBankEmploymentGetOperationRequest.cs` |
| `CreditBankEmploymentGetRequest` | `src/ThePlaidApi/Models/CreditBankEmploymentGetRequest.cs` |
| `CreditBankEmploymentGetResponse` | `src/ThePlaidApi/Models/CreditBankEmploymentGetResponse.cs` |

### CreditBankIncomeGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CreditBankIncomeGet(CreditBankIncomeGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreditBankIncomeGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreditBankIncomeGetOperationRequest` | `src/ThePlaidApi/Requests/CreditBankIncomeGetOperationRequest.cs` |
| `CreditBankIncomeGetRequest` | `src/ThePlaidApi/Models/CreditBankIncomeGetRequest.cs` |
| `CreditBankIncomeGetResponse` | `src/ThePlaidApi/Models/CreditBankIncomeGetResponse.cs` |

### CreditBankIncomePdfGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CreditBankIncomePdfGet(CreditBankIncomePdfGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreditBankIncomePdfGetOperationRequest` | `src/ThePlaidApi/Requests/CreditBankIncomePdfGetOperationRequest.cs` |
| `CreditBankIncomePdfGetRequest` | `src/ThePlaidApi/Models/CreditBankIncomePdfGetRequest.cs` |

### CreditBankIncomeRefresh

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CreditBankIncomeRefresh(CreditBankIncomeRefreshOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreditBankIncomeRefreshResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreditBankIncomeRefreshOperationRequest` | `src/ThePlaidApi/Requests/CreditBankIncomeRefreshOperationRequest.cs` |
| `CreditBankIncomeRefreshRequest` | `src/ThePlaidApi/Models/CreditBankIncomeRefreshRequest.cs` |
| `CreditBankIncomeRefreshResponse` | `src/ThePlaidApi/Models/CreditBankIncomeRefreshResponse.cs` |

### CreditBankIncomeWebhookUpdate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CreditBankIncomeWebhookUpdate(CreditBankIncomeWebhookUpdateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreditBankIncomeWebhookUpdateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreditBankIncomeWebhookUpdateOperationRequest` | `src/ThePlaidApi/Requests/CreditBankIncomeWebhookUpdateOperationRequest.cs` |
| `CreditBankIncomeWebhookUpdateRequest` | `src/ThePlaidApi/Models/CreditBankIncomeWebhookUpdateRequest.cs` |
| `CreditBankIncomeWebhookUpdateResponse` | `src/ThePlaidApi/Models/CreditBankIncomeWebhookUpdateResponse.cs` |

### CreditBankStatementsUploadsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CreditBankStatementsUploadsGet(CreditBankStatementsUploadsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreditBankStatementsUploadsGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreditBankStatementsUploadsGetOperationRequest` | `src/ThePlaidApi/Requests/CreditBankStatementsUploadsGetOperationRequest.cs` |
| `CreditBankStatementsUploadsGetRequest` | `src/ThePlaidApi/Models/CreditBankStatementsUploadsGetRequest.cs` |
| `CreditBankStatementsUploadsGetResponse` | `src/ThePlaidApi/Models/CreditBankStatementsUploadsGetResponse.cs` |

### CreditEmploymentGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CreditEmploymentGet(CreditEmploymentGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreditEmploymentGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreditEmploymentGetOperationRequest` | `src/ThePlaidApi/Requests/CreditEmploymentGetOperationRequest.cs` |
| `CreditEmploymentGetRequest` | `src/ThePlaidApi/Models/CreditEmploymentGetRequest.cs` |
| `CreditEmploymentGetResponse` | `src/ThePlaidApi/Models/CreditEmploymentGetResponse.cs` |

### CreditFreddieMacReportsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CreditFreddieMacReportsGet(CreditFreddieMacReportsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreditFreddieMacReportsGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreditFreddieMacReportsGetOperationRequest` | `src/ThePlaidApi/Requests/CreditFreddieMacReportsGetOperationRequest.cs` |
| `CreditFreddieMacReportsGetRequest` | `src/ThePlaidApi/Models/CreditFreddieMacReportsGetRequest.cs` |
| `CreditFreddieMacReportsGetResponse` | `src/ThePlaidApi/Models/CreditFreddieMacReportsGetResponse.cs` |

### CreditPayrollIncomeGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CreditPayrollIncomeGet(CreditPayrollIncomeGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreditPayrollIncomeGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreditPayrollIncomeGetOperationRequest` | `src/ThePlaidApi/Requests/CreditPayrollIncomeGetOperationRequest.cs` |
| `CreditPayrollIncomeGetRequest` | `src/ThePlaidApi/Models/CreditPayrollIncomeGetRequest.cs` |
| `CreditPayrollIncomeGetResponse` | `src/ThePlaidApi/Models/CreditPayrollIncomeGetResponse.cs` |

### CreditPayrollIncomeParsingConfigUpdate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CreditPayrollIncomeParsingConfigUpdate(CreditPayrollIncomeParsingConfigUpdateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreditPayrollIncomeParsingConfigUpdateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreditPayrollIncomeParsingConfigUpdateOperationRequest` | `src/ThePlaidApi/Requests/CreditPayrollIncomeParsingConfigUpdateOperationRequest.cs` |
| `CreditPayrollIncomeParsingConfigUpdateRequest` | `src/ThePlaidApi/Models/CreditPayrollIncomeParsingConfigUpdateRequest.cs` |
| `CreditPayrollIncomeParsingConfigUpdateResponse` | `src/ThePlaidApi/Models/CreditPayrollIncomeParsingConfigUpdateResponse.cs` |

### CreditPayrollIncomePrecheck

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CreditPayrollIncomePrecheck(CreditPayrollIncomePrecheckOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreditPayrollIncomePrecheckResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreditPayrollIncomePrecheckOperationRequest` | `src/ThePlaidApi/Requests/CreditPayrollIncomePrecheckOperationRequest.cs` |
| `CreditPayrollIncomePrecheckRequest` | `src/ThePlaidApi/Models/CreditPayrollIncomePrecheckRequest.cs` |
| `CreditPayrollIncomePrecheckResponse` | `src/ThePlaidApi/Models/CreditPayrollIncomePrecheckResponse.cs` |

### CreditPayrollIncomeRefresh

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CreditPayrollIncomeRefresh(CreditPayrollIncomeRefreshOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreditPayrollIncomeRefreshResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreditPayrollIncomeRefreshOperationRequest` | `src/ThePlaidApi/Requests/CreditPayrollIncomeRefreshOperationRequest.cs` |
| `CreditPayrollIncomeRefreshRequest` | `src/ThePlaidApi/Models/CreditPayrollIncomeRefreshRequest.cs` |
| `CreditPayrollIncomeRefreshResponse` | `src/ThePlaidApi/Models/CreditPayrollIncomeRefreshResponse.cs` |

### CreditPayrollIncomeRiskSignalsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CreditPayrollIncomeRiskSignalsGet(CreditPayrollIncomeRiskSignalsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreditPayrollIncomeRiskSignalsGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreditPayrollIncomeRiskSignalsGetOperationRequest` | `src/ThePlaidApi/Requests/CreditPayrollIncomeRiskSignalsGetOperationRequest.cs` |
| `CreditPayrollIncomeRiskSignalsGetRequest` | `src/ThePlaidApi/Models/CreditPayrollIncomeRiskSignalsGetRequest.cs` |
| `CreditPayrollIncomeRiskSignalsGetResponse` | `src/ThePlaidApi/Models/CreditPayrollIncomeRiskSignalsGetResponse.cs` |

### CreditRelayCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CreditRelayCreate(CreditRelayCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreditRelayCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreditRelayCreateOperationRequest` | `src/ThePlaidApi/Requests/CreditRelayCreateOperationRequest.cs` |
| `CreditRelayCreateRequest` | `src/ThePlaidApi/Models/CreditRelayCreateRequest.cs` |
| `CreditRelayCreateResponse` | `src/ThePlaidApi/Models/CreditRelayCreateResponse.cs` |

### CreditRelayGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CreditRelayGet(CreditRelayGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `AssetReportGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreditRelayGetOperationRequest` | `src/ThePlaidApi/Requests/CreditRelayGetOperationRequest.cs` |
| `CreditRelayGetRequest` | `src/ThePlaidApi/Models/CreditRelayGetRequest.cs` |
| `AssetReportGetResponse` | `src/ThePlaidApi/Models/AssetReportGetResponse.cs` |

### CreditRelayPdfGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CreditRelayPdfGet(CreditRelayPdfGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreditRelayPdfGetOperationRequest` | `src/ThePlaidApi/Requests/CreditRelayPdfGetOperationRequest.cs` |
| `CreditRelayPdfGetRequest` | `src/ThePlaidApi/Models/CreditRelayPdfGetRequest.cs` |

### CreditRelayRefresh

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CreditRelayRefresh(CreditRelayRefreshOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreditRelayRefreshResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreditRelayRefreshOperationRequest` | `src/ThePlaidApi/Requests/CreditRelayRefreshOperationRequest.cs` |
| `CreditRelayRefreshRequest` | `src/ThePlaidApi/Models/CreditRelayRefreshRequest.cs` |
| `CreditRelayRefreshResponse` | `src/ThePlaidApi/Models/CreditRelayRefreshResponse.cs` |

### CreditRelayRemove

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CreditRelayRemove(CreditRelayRemoveOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreditRelayRemoveResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreditRelayRemoveOperationRequest` | `src/ThePlaidApi/Requests/CreditRelayRemoveOperationRequest.cs` |
| `CreditRelayRemoveRequest` | `src/ThePlaidApi/Models/CreditRelayRemoveRequest.cs` |
| `CreditRelayRemoveResponse` | `src/ThePlaidApi/Models/CreditRelayRemoveResponse.cs` |

### CreditReportAuditCopyRemove

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CreditReportAuditCopyRemove(CreditReportAuditCopyRemoveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreditAuditCopyTokenRemoveResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreditReportAuditCopyRemoveRequest` | `src/ThePlaidApi/Requests/CreditReportAuditCopyRemoveRequest.cs` |
| `CreditAuditCopyTokenRemoveRequest` | `src/ThePlaidApi/Models/CreditAuditCopyTokenRemoveRequest.cs` |
| `CreditAuditCopyTokenRemoveResponse` | `src/ThePlaidApi/Models/CreditAuditCopyTokenRemoveResponse.cs` |

### CreditSessionsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CreditSessionsGet(CreditSessionsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CreditSessionsGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreditSessionsGetOperationRequest` | `src/ThePlaidApi/Requests/CreditSessionsGetOperationRequest.cs` |
| `CreditSessionsGetRequest` | `src/ThePlaidApi/Models/CreditSessionsGetRequest.cs` |
| `CreditSessionsGetResponse` | `src/ThePlaidApi/Models/CreditSessionsGetResponse.cs` |

### DashboardUserGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `DashboardUserGet(DashboardUserGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `DashboardUserGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DashboardUserGetOperationRequest` | `src/ThePlaidApi/Requests/DashboardUserGetOperationRequest.cs` |
| `DashboardUserGetRequest` | `src/ThePlaidApi/Models/DashboardUserGetRequest.cs` |
| `DashboardUserGetResponse` | `src/ThePlaidApi/Models/DashboardUserGetResponse.cs` |

### DashboardUserList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `DashboardUserList(DashboardUserListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `DashboardUserListResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DashboardUserListOperationRequest` | `src/ThePlaidApi/Requests/DashboardUserListOperationRequest.cs` |
| `DashboardUserListRequest` | `src/ThePlaidApi/Models/DashboardUserListRequest.cs` |
| `DashboardUserListResponse` | `src/ThePlaidApi/Models/DashboardUserListResponse.cs` |

### EmployersSearch

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `EmployersSearch(EmployersSearchOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `EmployersSearchResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `EmployersSearchOperationRequest` | `src/ThePlaidApi/Requests/EmployersSearchOperationRequest.cs` |
| `EmployersSearchRequest` | `src/ThePlaidApi/Models/EmployersSearchRequest.cs` |
| `EmployersSearchResponse` | `src/ThePlaidApi/Models/EmployersSearchResponse.cs` |

### EmploymentVerificationGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `EmploymentVerificationGet(EmploymentVerificationGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `EmploymentVerificationGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `EmploymentVerificationGetOperationRequest` | `src/ThePlaidApi/Requests/EmploymentVerificationGetOperationRequest.cs` |
| `EmploymentVerificationGetRequest` | `src/ThePlaidApi/Models/EmploymentVerificationGetRequest.cs` |
| `EmploymentVerificationGetResponse` | `src/ThePlaidApi/Models/EmploymentVerificationGetResponse.cs` |

### FdxConsentsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `FdxConsentsGet(FdxConsentsGetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ConsentId`
- **Returns**: `FdxConsentGrant`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `FdxConsentsGetRequest` | `src/ThePlaidApi/Requests/FdxConsentsGetRequest.cs` |
| `FdxConsentGrant` | `src/ThePlaidApi/Models/FdxConsentGrant.cs` |

### FdxConsentsList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `FdxConsentsList(FdxConsentsListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CustomerId`
- **Query params (wire ← C#)**: `customerId` ← `CustomerId`, `status` ← `Status`
- **Returns**: `GetConsentsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `FdxConsentsListRequest` | `src/ThePlaidApi/Requests/FdxConsentsListRequest.cs` |
| `FdxConsentGrantStatus` | `src/ThePlaidApi/Models/Enums/FdxConsentGrantStatus.cs` |
| `GetConsentsResponse` | `src/ThePlaidApi/Models/GetConsentsResponse.cs` |

### FdxConsentsRevocationGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `FdxConsentsRevocationGet(FdxConsentsRevocationGetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ConsentId`
- **Returns**: `FdxConsentRevocations`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `FdxConsentsRevocationGetRequest` | `src/ThePlaidApi/Requests/FdxConsentsRevocationGetRequest.cs` |
| `FdxConsentRevocations` | `src/ThePlaidApi/Models/FdxConsentRevocations.cs` |

### FdxConsentsRevoke

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `FdxConsentsRevoke(FdxConsentsRevokeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ConsentId`, `Body`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `FdxConsentsRevokeRequest` | `src/ThePlaidApi/Requests/FdxConsentsRevokeRequest.cs` |
| `FdxConsentRevocation` | `src/ThePlaidApi/Models/FdxConsentRevocation.cs` |

### FdxNotifications

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `FdxNotifications(FdxNotificationsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `FdxNotificationsRequest` | `src/ThePlaidApi/Requests/FdxNotificationsRequest.cs` |
| `FdxNotificationEntity` | `src/ThePlaidApi/Models/FdxNotificationEntity.cs` |

### GetRecipient

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `GetRecipient(GetRecipientRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `RecipientId`
- **Returns**: `FdxRecipientMetadata`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetRecipientRequest` | `src/ThePlaidApi/Requests/GetRecipientRequest.cs` |
| `FdxRecipientMetadata` | `src/ThePlaidApi/Models/FdxRecipientMetadata.cs` |

### GetRecipients

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `GetRecipients(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `GetRecipientsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetRecipientsResponse` | `src/ThePlaidApi/Models/GetRecipientsResponse.cs` |

### IdentityDocumentsUploadsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `IdentityDocumentsUploadsGet(IdentityDocumentsUploadsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `IdentityDocumentsUploadsGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `IdentityDocumentsUploadsGetOperationRequest` | `src/ThePlaidApi/Requests/IdentityDocumentsUploadsGetOperationRequest.cs` |
| `IdentityDocumentsUploadsGetRequest` | `src/ThePlaidApi/Models/IdentityDocumentsUploadsGetRequest.cs` |
| `IdentityDocumentsUploadsGetResponse` | `src/ThePlaidApi/Models/IdentityDocumentsUploadsGetResponse.cs` |

### IdentityGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `IdentityGet(IdentityGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `IdentityGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `IdentityGetOperationRequest` | `src/ThePlaidApi/Requests/IdentityGetOperationRequest.cs` |
| `IdentityGetRequest` | `src/ThePlaidApi/Models/IdentityGetRequest.cs` |
| `IdentityGetResponse` | `src/ThePlaidApi/Models/IdentityGetResponse.cs` |

### IdentityMatch

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `IdentityMatch(IdentityMatchOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `IdentityMatchResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `IdentityMatchOperationRequest` | `src/ThePlaidApi/Requests/IdentityMatchOperationRequest.cs` |
| `IdentityMatchRequest` | `src/ThePlaidApi/Models/IdentityMatchRequest.cs` |
| `IdentityMatchResponse` | `src/ThePlaidApi/Models/IdentityMatchResponse.cs` |

### IdentityRefresh

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `IdentityRefresh(IdentityRefreshOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `IdentityRefreshResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `IdentityRefreshOperationRequest` | `src/ThePlaidApi/Requests/IdentityRefreshOperationRequest.cs` |
| `IdentityRefreshRequest` | `src/ThePlaidApi/Models/IdentityRefreshRequest.cs` |
| `IdentityRefreshResponse` | `src/ThePlaidApi/Models/IdentityRefreshResponse.cs` |

### IdentityVerificationAutofillCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `IdentityVerificationAutofillCreate(IdentityVerificationAutofillCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `IdentityVerificationAutofillCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `IdentityVerificationAutofillCreateOperationRequest` | `src/ThePlaidApi/Requests/IdentityVerificationAutofillCreateOperationRequest.cs` |
| `IdentityVerificationAutofillCreateRequest` | `src/ThePlaidApi/Models/IdentityVerificationAutofillCreateRequest.cs` |
| `IdentityVerificationAutofillCreateResponse` | `src/ThePlaidApi/Models/IdentityVerificationAutofillCreateResponse.cs` |

### IdentityVerificationCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `IdentityVerificationCreate(IdentityVerificationCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `IdentityVerificationCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `IdentityVerificationCreateOperationRequest` | `src/ThePlaidApi/Requests/IdentityVerificationCreateOperationRequest.cs` |
| `IdentityVerificationCreateRequest` | `src/ThePlaidApi/Models/IdentityVerificationCreateRequest.cs` |
| `IdentityVerificationCreateResponse` | `src/ThePlaidApi/Models/IdentityVerificationCreateResponse.cs` |

### IdentityVerificationGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `IdentityVerificationGet(IdentityVerificationGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `IdentityVerificationGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `IdentityVerificationGetOperationRequest` | `src/ThePlaidApi/Requests/IdentityVerificationGetOperationRequest.cs` |
| `IdentityVerificationGetRequest` | `src/ThePlaidApi/Models/IdentityVerificationGetRequest.cs` |
| `IdentityVerificationGetResponse` | `src/ThePlaidApi/Models/IdentityVerificationGetResponse.cs` |

### IdentityVerificationList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `IdentityVerificationList(IdentityVerificationListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `IdentityVerificationListResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `IdentityVerificationListOperationRequest` | `src/ThePlaidApi/Requests/IdentityVerificationListOperationRequest.cs` |
| `IdentityVerificationListRequest` | `src/ThePlaidApi/Models/IdentityVerificationListRequest.cs` |
| `IdentityVerificationListResponse` | `src/ThePlaidApi/Models/IdentityVerificationListResponse.cs` |

### IdentityVerificationRetry

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `IdentityVerificationRetry(IdentityVerificationRetryOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `IdentityVerificationRetryResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `IdentityVerificationRetryOperationRequest` | `src/ThePlaidApi/Requests/IdentityVerificationRetryOperationRequest.cs` |
| `IdentityVerificationRetryRequest` | `src/ThePlaidApi/Models/IdentityVerificationRetryRequest.cs` |
| `IdentityVerificationRetryResponse` | `src/ThePlaidApi/Models/IdentityVerificationRetryResponse.cs` |

### IncomeVerificationCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `IncomeVerificationCreate(IncomeVerificationCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `IncomeVerificationCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `IncomeVerificationCreateOperationRequest` | `src/ThePlaidApi/Requests/IncomeVerificationCreateOperationRequest.cs` |
| `IncomeVerificationCreateRequest` | `src/ThePlaidApi/Models/IncomeVerificationCreateRequest.cs` |
| `IncomeVerificationCreateResponse` | `src/ThePlaidApi/Models/IncomeVerificationCreateResponse.cs` |

### IncomeVerificationDocumentsDownload

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `IncomeVerificationDocumentsDownload(IncomeVerificationDocumentsDownloadOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `IncomeVerificationDocumentsDownloadOperationRequest` | `src/ThePlaidApi/Requests/IncomeVerificationDocumentsDownloadOperationRequest.cs` |
| `IncomeVerificationDocumentsDownloadRequest` | `src/ThePlaidApi/Models/IncomeVerificationDocumentsDownloadRequest.cs` |

### IncomeVerificationPaystubsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `IncomeVerificationPaystubsGet(IncomeVerificationPaystubsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `IncomeVerificationPaystubsGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `IncomeVerificationPaystubsGetOperationRequest` | `src/ThePlaidApi/Requests/IncomeVerificationPaystubsGetOperationRequest.cs` |
| `IncomeVerificationPaystubsGetRequest` | `src/ThePlaidApi/Models/IncomeVerificationPaystubsGetRequest.cs` |
| `IncomeVerificationPaystubsGetResponse` | `src/ThePlaidApi/Models/IncomeVerificationPaystubsGetResponse.cs` |

### IncomeVerificationPrecheck

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `IncomeVerificationPrecheck(IncomeVerificationPrecheckOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `IncomeVerificationPrecheckResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `IncomeVerificationPrecheckOperationRequest` | `src/ThePlaidApi/Requests/IncomeVerificationPrecheckOperationRequest.cs` |
| `IncomeVerificationPrecheckRequest` | `src/ThePlaidApi/Models/IncomeVerificationPrecheckRequest.cs` |
| `IncomeVerificationPrecheckResponse` | `src/ThePlaidApi/Models/IncomeVerificationPrecheckResponse.cs` |

### IncomeVerificationTaxformsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `IncomeVerificationTaxformsGet(IncomeVerificationTaxformsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `IncomeVerificationTaxformsGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `IncomeVerificationTaxformsGetOperationRequest` | `src/ThePlaidApi/Requests/IncomeVerificationTaxformsGetOperationRequest.cs` |
| `IncomeVerificationTaxformsGetRequest` | `src/ThePlaidApi/Models/IncomeVerificationTaxformsGetRequest.cs` |
| `IncomeVerificationTaxformsGetResponse` | `src/ThePlaidApi/Models/IncomeVerificationTaxformsGetResponse.cs` |

### InstitutionsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `InstitutionsGet(InstitutionsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `InstitutionsGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `InstitutionsGetOperationRequest` | `src/ThePlaidApi/Requests/InstitutionsGetOperationRequest.cs` |
| `InstitutionsGetRequest` | `src/ThePlaidApi/Models/InstitutionsGetRequest.cs` |
| `InstitutionsGetResponse` | `src/ThePlaidApi/Models/InstitutionsGetResponse.cs` |

### InstitutionsGetById

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `InstitutionsGetById(InstitutionsGetByIdOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `InstitutionsGetByIdResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `InstitutionsGetByIdOperationRequest` | `src/ThePlaidApi/Requests/InstitutionsGetByIdOperationRequest.cs` |
| `InstitutionsGetByIdRequest` | `src/ThePlaidApi/Models/InstitutionsGetByIdRequest.cs` |
| `InstitutionsGetByIdResponse` | `src/ThePlaidApi/Models/InstitutionsGetByIdResponse.cs` |

### InstitutionsSearch

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `InstitutionsSearch(InstitutionsSearchOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `InstitutionsSearchResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `InstitutionsSearchOperationRequest` | `src/ThePlaidApi/Requests/InstitutionsSearchOperationRequest.cs` |
| `InstitutionsSearchRequest` | `src/ThePlaidApi/Models/InstitutionsSearchRequest.cs` |
| `InstitutionsSearchResponse` | `src/ThePlaidApi/Models/InstitutionsSearchResponse.cs` |

### InvestmentsAuthGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `InvestmentsAuthGet(InvestmentsAuthGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `InvestmentsAuthGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `InvestmentsAuthGetOperationRequest` | `src/ThePlaidApi/Requests/InvestmentsAuthGetOperationRequest.cs` |
| `InvestmentsAuthGetRequest` | `src/ThePlaidApi/Models/InvestmentsAuthGetRequest.cs` |
| `InvestmentsAuthGetResponse` | `src/ThePlaidApi/Models/InvestmentsAuthGetResponse.cs` |

### InvestmentsHoldingsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `InvestmentsHoldingsGet(InvestmentsHoldingsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `InvestmentsHoldingsGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `InvestmentsHoldingsGetOperationRequest` | `src/ThePlaidApi/Requests/InvestmentsHoldingsGetOperationRequest.cs` |
| `InvestmentsHoldingsGetRequest` | `src/ThePlaidApi/Models/InvestmentsHoldingsGetRequest.cs` |
| `InvestmentsHoldingsGetResponse` | `src/ThePlaidApi/Models/InvestmentsHoldingsGetResponse.cs` |

### InvestmentsRefresh

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `InvestmentsRefresh(InvestmentsRefreshOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `InvestmentsRefreshResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `InvestmentsRefreshOperationRequest` | `src/ThePlaidApi/Requests/InvestmentsRefreshOperationRequest.cs` |
| `InvestmentsRefreshRequest` | `src/ThePlaidApi/Models/InvestmentsRefreshRequest.cs` |
| `InvestmentsRefreshResponse` | `src/ThePlaidApi/Models/InvestmentsRefreshResponse.cs` |

### InvestmentsTransactionsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `InvestmentsTransactionsGet(InvestmentsTransactionsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `InvestmentsTransactionsGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `InvestmentsTransactionsGetOperationRequest` | `src/ThePlaidApi/Requests/InvestmentsTransactionsGetOperationRequest.cs` |
| `InvestmentsTransactionsGetRequest` | `src/ThePlaidApi/Models/InvestmentsTransactionsGetRequest.cs` |
| `InvestmentsTransactionsGetResponse` | `src/ThePlaidApi/Models/InvestmentsTransactionsGetResponse.cs` |

### IssuesGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `IssuesGet(IssuesGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `IssuesGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `IssuesGetOperationRequest` | `src/ThePlaidApi/Requests/IssuesGetOperationRequest.cs` |
| `IssuesGetRequest` | `src/ThePlaidApi/Models/IssuesGetRequest.cs` |
| `IssuesGetResponse` | `src/ThePlaidApi/Models/IssuesGetResponse.cs` |

### IssuesSearch

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `IssuesSearch(IssuesSearchOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `IssuesSearchResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `IssuesSearchOperationRequest` | `src/ThePlaidApi/Requests/IssuesSearchOperationRequest.cs` |
| `IssuesSearchRequest` | `src/ThePlaidApi/Models/IssuesSearchRequest.cs` |
| `IssuesSearchResponse` | `src/ThePlaidApi/Models/IssuesSearchResponse.cs` |

### IssuesSubscribe

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `IssuesSubscribe(IssuesSubscribeOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `IssuesSubscribeResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `IssuesSubscribeOperationRequest` | `src/ThePlaidApi/Requests/IssuesSubscribeOperationRequest.cs` |
| `IssuesSubscribeRequest` | `src/ThePlaidApi/Models/IssuesSubscribeRequest.cs` |
| `IssuesSubscribeResponse` | `src/ThePlaidApi/Models/IssuesSubscribeResponse.cs` |

### ItemAccessTokenInvalidate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ItemAccessTokenInvalidate(ItemAccessTokenInvalidateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ItemAccessTokenInvalidateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ItemAccessTokenInvalidateOperationRequest` | `src/ThePlaidApi/Requests/ItemAccessTokenInvalidateOperationRequest.cs` |
| `ItemAccessTokenInvalidateRequest` | `src/ThePlaidApi/Models/ItemAccessTokenInvalidateRequest.cs` |
| `ItemAccessTokenInvalidateResponse` | `src/ThePlaidApi/Models/ItemAccessTokenInvalidateResponse.cs` |

### ItemActivityList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ItemActivityList(ItemActivityListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ItemActivityListResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ItemActivityListOperationRequest` | `src/ThePlaidApi/Requests/ItemActivityListOperationRequest.cs` |
| `ItemActivityListRequest` | `src/ThePlaidApi/Models/ItemActivityListRequest.cs` |
| `ItemActivityListResponse` | `src/ThePlaidApi/Models/ItemActivityListResponse.cs` |

### ItemApplicationList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ItemApplicationList(ItemApplicationListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ItemApplicationListResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ItemApplicationListOperationRequest` | `src/ThePlaidApi/Requests/ItemApplicationListOperationRequest.cs` |
| `ItemApplicationListRequest` | `src/ThePlaidApi/Models/ItemApplicationListRequest.cs` |
| `ItemApplicationListResponse` | `src/ThePlaidApi/Models/ItemApplicationListResponse.cs` |

### ItemApplicationScopesUpdate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ItemApplicationScopesUpdate(ItemApplicationScopesUpdateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ItemApplicationScopesUpdateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ItemApplicationScopesUpdateOperationRequest` | `src/ThePlaidApi/Requests/ItemApplicationScopesUpdateOperationRequest.cs` |
| `ItemApplicationScopesUpdateRequest` | `src/ThePlaidApi/Models/ItemApplicationScopesUpdateRequest.cs` |
| `ItemApplicationScopesUpdateResponse` | `src/ThePlaidApi/Models/ItemApplicationScopesUpdateResponse.cs` |

### ItemApplicationUnlink

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ItemApplicationUnlink(ItemApplicationUnlinkOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ItemApplicationUnlinkResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ItemApplicationUnlinkOperationRequest` | `src/ThePlaidApi/Requests/ItemApplicationUnlinkOperationRequest.cs` |
| `ItemApplicationUnlinkRequest` | `src/ThePlaidApi/Models/ItemApplicationUnlinkRequest.cs` |
| `ItemApplicationUnlinkResponse` | `src/ThePlaidApi/Models/ItemApplicationUnlinkResponse.cs` |

### ItemCreatePublicToken

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ItemCreatePublicToken(ItemCreatePublicTokenRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ItemPublicTokenCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ItemCreatePublicTokenRequest` | `src/ThePlaidApi/Requests/ItemCreatePublicTokenRequest.cs` |
| `ItemPublicTokenCreateRequest` | `src/ThePlaidApi/Models/ItemPublicTokenCreateRequest.cs` |
| `ItemPublicTokenCreateResponse` | `src/ThePlaidApi/Models/ItemPublicTokenCreateResponse.cs` |

### ItemGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ItemGet(ItemGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ItemGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ItemGetOperationRequest` | `src/ThePlaidApi/Requests/ItemGetOperationRequest.cs` |
| `ItemGetRequest` | `src/ThePlaidApi/Models/ItemGetRequest.cs` |
| `ItemGetResponse` | `src/ThePlaidApi/Models/ItemGetResponse.cs` |

### ItemImport

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ItemImport(ItemImportOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ItemImportResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ItemImportOperationRequest` | `src/ThePlaidApi/Requests/ItemImportOperationRequest.cs` |
| `ItemImportRequest` | `src/ThePlaidApi/Models/ItemImportRequest.cs` |
| `ItemImportResponse` | `src/ThePlaidApi/Models/ItemImportResponse.cs` |

### ItemProductsTerminate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ItemProductsTerminate(ItemProductsTerminateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ItemProductsTerminateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ItemProductsTerminateOperationRequest` | `src/ThePlaidApi/Requests/ItemProductsTerminateOperationRequest.cs` |
| `ItemProductsTerminateRequest` | `src/ThePlaidApi/Models/ItemProductsTerminateRequest.cs` |
| `ItemProductsTerminateResponse` | `src/ThePlaidApi/Models/ItemProductsTerminateResponse.cs` |

### ItemPublicTokenExchange

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ItemPublicTokenExchange(ItemPublicTokenExchangeOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ItemPublicTokenExchangeResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ItemPublicTokenExchangeOperationRequest` | `src/ThePlaidApi/Requests/ItemPublicTokenExchangeOperationRequest.cs` |
| `ItemPublicTokenExchangeRequest` | `src/ThePlaidApi/Models/ItemPublicTokenExchangeRequest.cs` |
| `ItemPublicTokenExchangeResponse` | `src/ThePlaidApi/Models/ItemPublicTokenExchangeResponse.cs` |

### ItemRemove

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ItemRemove(ItemRemoveOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ItemRemoveResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ItemRemoveOperationRequest` | `src/ThePlaidApi/Requests/ItemRemoveOperationRequest.cs` |
| `ItemRemoveRequest` | `src/ThePlaidApi/Models/ItemRemoveRequest.cs` |
| `ItemRemoveResponse` | `src/ThePlaidApi/Models/ItemRemoveResponse.cs` |

### ItemWebhookUpdate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ItemWebhookUpdate(ItemWebhookUpdateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ItemWebhookUpdateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ItemWebhookUpdateOperationRequest` | `src/ThePlaidApi/Requests/ItemWebhookUpdateOperationRequest.cs` |
| `ItemWebhookUpdateRequest` | `src/ThePlaidApi/Models/ItemWebhookUpdateRequest.cs` |
| `ItemWebhookUpdateResponse` | `src/ThePlaidApi/Models/ItemWebhookUpdateResponse.cs` |

### LiabilitiesGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `LiabilitiesGet(LiabilitiesGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `LiabilitiesGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `LiabilitiesGetOperationRequest` | `src/ThePlaidApi/Requests/LiabilitiesGetOperationRequest.cs` |
| `LiabilitiesGetRequest` | `src/ThePlaidApi/Models/LiabilitiesGetRequest.cs` |
| `LiabilitiesGetResponse` | `src/ThePlaidApi/Models/LiabilitiesGetResponse.cs` |

### LinkDeliveryCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `LinkDeliveryCreate(LinkDeliveryCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `LinkDeliveryCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `LinkDeliveryCreateOperationRequest` | `src/ThePlaidApi/Requests/LinkDeliveryCreateOperationRequest.cs` |
| `LinkDeliveryCreateRequest` | `src/ThePlaidApi/Models/LinkDeliveryCreateRequest.cs` |
| `LinkDeliveryCreateResponse` | `src/ThePlaidApi/Models/LinkDeliveryCreateResponse.cs` |

### LinkDeliveryGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `LinkDeliveryGet(LinkDeliveryGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `LinkDeliveryGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `LinkDeliveryGetOperationRequest` | `src/ThePlaidApi/Requests/LinkDeliveryGetOperationRequest.cs` |
| `LinkDeliveryGetRequest` | `src/ThePlaidApi/Models/LinkDeliveryGetRequest.cs` |
| `LinkDeliveryGetResponse` | `src/ThePlaidApi/Models/LinkDeliveryGetResponse.cs` |

### LinkOauthCorrelationIdExchange

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `LinkOauthCorrelationIdExchange(LinkOauthCorrelationIdExchangeOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `LinkOAuthCorrelationIdExchangeResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `LinkOauthCorrelationIdExchangeOperationRequest` | `src/ThePlaidApi/Requests/LinkOauthCorrelationIdExchangeOperationRequest.cs` |
| `LinkOAuthCorrelationIdExchangeRequest` | `src/ThePlaidApi/Models/LinkOAuthCorrelationIdExchangeRequest.cs` |
| `LinkOAuthCorrelationIdExchangeResponse` | `src/ThePlaidApi/Models/LinkOAuthCorrelationIdExchangeResponse.cs` |

### LinkTokenCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `LinkTokenCreate(LinkTokenCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `LinkTokenCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `LinkTokenCreateOperationRequest` | `src/ThePlaidApi/Requests/LinkTokenCreateOperationRequest.cs` |
| `LinkTokenCreateRequest` | `src/ThePlaidApi/Models/LinkTokenCreateRequest.cs` |
| `LinkTokenCreateResponse` | `src/ThePlaidApi/Models/LinkTokenCreateResponse.cs` |

### LinkTokenGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `LinkTokenGet(LinkTokenGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `LinkTokenGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `LinkTokenGetOperationRequest` | `src/ThePlaidApi/Requests/LinkTokenGetOperationRequest.cs` |
| `LinkTokenGetRequest` | `src/ThePlaidApi/Models/LinkTokenGetRequest.cs` |
| `LinkTokenGetResponse` | `src/ThePlaidApi/Models/LinkTokenGetResponse.cs` |

### NetworkStatusGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `NetworkStatusGet(NetworkStatusGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `NetworkStatusGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `NetworkStatusGetOperationRequest` | `src/ThePlaidApi/Requests/NetworkStatusGetOperationRequest.cs` |
| `NetworkStatusGetRequest` | `src/ThePlaidApi/Models/NetworkStatusGetRequest.cs` |
| `NetworkStatusGetResponse` | `src/ThePlaidApi/Models/NetworkStatusGetResponse.cs` |

### OauthIntrospect

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `OauthIntrospect(OauthIntrospectOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `OAuthIntrospectResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `OauthIntrospectOperationRequest` | `src/ThePlaidApi/Requests/OauthIntrospectOperationRequest.cs` |
| `OAuthIntrospectRequest` | `src/ThePlaidApi/Models/OAuthIntrospectRequest.cs` |
| `OAuthIntrospectResponse` | `src/ThePlaidApi/Models/OAuthIntrospectResponse.cs` |

### OauthRevoke

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `OauthRevoke(OauthRevokeOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `OAuthRevokeResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `OauthRevokeOperationRequest` | `src/ThePlaidApi/Requests/OauthRevokeOperationRequest.cs` |
| `OAuthRevokeRequest` | `src/ThePlaidApi/Models/OAuthRevokeRequest.cs` |
| `OAuthRevokeResponse` | `src/ThePlaidApi/Models/OAuthRevokeResponse.cs` |

### OauthToken

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `OauthToken(OauthTokenOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `OAuthTokenResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `OauthTokenOperationRequest` | `src/ThePlaidApi/Requests/OauthTokenOperationRequest.cs` |
| `OAuthTokenRequest` | `src/ThePlaidApi/Models/OAuthTokenRequest.cs` |
| `OAuthTokenResponse` | `src/ThePlaidApi/Models/OAuthTokenResponse.cs` |

### PartnerCustomerCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `PartnerCustomerCreate(PartnerCustomerCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `PartnerCustomerCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PartnerCustomerCreateOperationRequest` | `src/ThePlaidApi/Requests/PartnerCustomerCreateOperationRequest.cs` |
| `PartnerCustomerCreateRequest` | `src/ThePlaidApi/Models/PartnerCustomerCreateRequest.cs` |
| `PartnerCustomerCreateResponse` | `src/ThePlaidApi/Models/PartnerCustomerCreateResponse.cs` |

### PartnerCustomerEnable

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `PartnerCustomerEnable(PartnerCustomerEnableOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `PartnerCustomerEnableResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PartnerCustomerEnableOperationRequest` | `src/ThePlaidApi/Requests/PartnerCustomerEnableOperationRequest.cs` |
| `PartnerCustomerEnableRequest` | `src/ThePlaidApi/Models/PartnerCustomerEnableRequest.cs` |
| `PartnerCustomerEnableResponse` | `src/ThePlaidApi/Models/PartnerCustomerEnableResponse.cs` |

### PartnerCustomerGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `PartnerCustomerGet(PartnerCustomerGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `PartnerCustomerGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PartnerCustomerGetOperationRequest` | `src/ThePlaidApi/Requests/PartnerCustomerGetOperationRequest.cs` |
| `PartnerCustomerGetRequest` | `src/ThePlaidApi/Models/PartnerCustomerGetRequest.cs` |
| `PartnerCustomerGetResponse` | `src/ThePlaidApi/Models/PartnerCustomerGetResponse.cs` |

### PartnerCustomerOauthInstitutionsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `PartnerCustomerOauthInstitutionsGet(PartnerCustomerOauthInstitutionsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `PartnerCustomerOAuthInstitutionsGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PartnerCustomerOauthInstitutionsGetOperationRequest` | `src/ThePlaidApi/Requests/PartnerCustomerOauthInstitutionsGetOperationRequest.cs` |
| `PartnerCustomerOAuthInstitutionsGetRequest` | `src/ThePlaidApi/Models/PartnerCustomerOAuthInstitutionsGetRequest.cs` |
| `PartnerCustomerOAuthInstitutionsGetResponse` | `src/ThePlaidApi/Models/PartnerCustomerOAuthInstitutionsGetResponse.cs` |

### PartnerCustomerRemove

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `PartnerCustomerRemove(PartnerCustomerRemoveOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `PartnerCustomerRemoveResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PartnerCustomerRemoveOperationRequest` | `src/ThePlaidApi/Requests/PartnerCustomerRemoveOperationRequest.cs` |
| `PartnerCustomerRemoveRequest` | `src/ThePlaidApi/Models/PartnerCustomerRemoveRequest.cs` |
| `PartnerCustomerRemoveResponse` | `src/ThePlaidApi/Models/PartnerCustomerRemoveResponse.cs` |

### PaymentInitiationConsentCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `PaymentInitiationConsentCreate(PaymentInitiationConsentCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `PaymentInitiationConsentCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PaymentInitiationConsentCreateOperationRequest` | `src/ThePlaidApi/Requests/PaymentInitiationConsentCreateOperationRequest.cs` |
| `PaymentInitiationConsentCreateRequest` | `src/ThePlaidApi/Models/PaymentInitiationConsentCreateRequest.cs` |
| `PaymentInitiationConsentCreateResponse` | `src/ThePlaidApi/Models/PaymentInitiationConsentCreateResponse.cs` |

### PaymentInitiationConsentGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `PaymentInitiationConsentGet(PaymentInitiationConsentGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `PaymentInitiationConsentGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PaymentInitiationConsentGetOperationRequest` | `src/ThePlaidApi/Requests/PaymentInitiationConsentGetOperationRequest.cs` |
| `PaymentInitiationConsentGetRequest` | `src/ThePlaidApi/Models/PaymentInitiationConsentGetRequest.cs` |
| `PaymentInitiationConsentGetResponse` | `src/ThePlaidApi/Models/PaymentInitiationConsentGetResponse.cs` |

### PaymentInitiationConsentPaymentExecute

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `PaymentInitiationConsentPaymentExecute(PaymentInitiationConsentPaymentExecuteOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `PaymentInitiationConsentPaymentExecuteResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PaymentInitiationConsentPaymentExecuteOperationRequest` | `src/ThePlaidApi/Requests/PaymentInitiationConsentPaymentExecuteOperationRequest.cs` |
| `PaymentInitiationConsentPaymentExecuteRequest` | `src/ThePlaidApi/Models/PaymentInitiationConsentPaymentExecuteRequest.cs` |
| `PaymentInitiationConsentPaymentExecuteResponse` | `src/ThePlaidApi/Models/PaymentInitiationConsentPaymentExecuteResponse.cs` |

### PaymentInitiationConsentRevoke

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `PaymentInitiationConsentRevoke(PaymentInitiationConsentRevokeOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `PaymentInitiationConsentRevokeResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PaymentInitiationConsentRevokeOperationRequest` | `src/ThePlaidApi/Requests/PaymentInitiationConsentRevokeOperationRequest.cs` |
| `PaymentInitiationConsentRevokeRequest` | `src/ThePlaidApi/Models/PaymentInitiationConsentRevokeRequest.cs` |
| `PaymentInitiationConsentRevokeResponse` | `src/ThePlaidApi/Models/PaymentInitiationConsentRevokeResponse.cs` |

### PaymentInitiationPaymentCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `PaymentInitiationPaymentCreate(PaymentInitiationPaymentCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `PaymentInitiationPaymentCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PaymentInitiationPaymentCreateOperationRequest` | `src/ThePlaidApi/Requests/PaymentInitiationPaymentCreateOperationRequest.cs` |
| `PaymentInitiationPaymentCreateRequest` | `src/ThePlaidApi/Models/PaymentInitiationPaymentCreateRequest.cs` |
| `PaymentInitiationPaymentCreateResponse` | `src/ThePlaidApi/Models/PaymentInitiationPaymentCreateResponse.cs` |

### PaymentInitiationPaymentGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `PaymentInitiationPaymentGet(PaymentInitiationPaymentGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `PaymentInitiationPaymentGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PaymentInitiationPaymentGetOperationRequest` | `src/ThePlaidApi/Requests/PaymentInitiationPaymentGetOperationRequest.cs` |
| `PaymentInitiationPaymentGetRequest` | `src/ThePlaidApi/Models/PaymentInitiationPaymentGetRequest.cs` |
| `PaymentInitiationPaymentGetResponse` | `src/ThePlaidApi/Models/PaymentInitiationPaymentGetResponse.cs` |

### PaymentInitiationPaymentList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `PaymentInitiationPaymentList(PaymentInitiationPaymentListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `PaymentInitiationPaymentListResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PaymentInitiationPaymentListOperationRequest` | `src/ThePlaidApi/Requests/PaymentInitiationPaymentListOperationRequest.cs` |
| `PaymentInitiationPaymentListRequest` | `src/ThePlaidApi/Models/PaymentInitiationPaymentListRequest.cs` |
| `PaymentInitiationPaymentListResponse` | `src/ThePlaidApi/Models/PaymentInitiationPaymentListResponse.cs` |

### PaymentInitiationPaymentReverse

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `PaymentInitiationPaymentReverse(PaymentInitiationPaymentReverseOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `PaymentInitiationPaymentReverseResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PaymentInitiationPaymentReverseOperationRequest` | `src/ThePlaidApi/Requests/PaymentInitiationPaymentReverseOperationRequest.cs` |
| `PaymentInitiationPaymentReverseRequest` | `src/ThePlaidApi/Models/PaymentInitiationPaymentReverseRequest.cs` |
| `PaymentInitiationPaymentReverseResponse` | `src/ThePlaidApi/Models/PaymentInitiationPaymentReverseResponse.cs` |

### PaymentInitiationRecipientCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `PaymentInitiationRecipientCreate(PaymentInitiationRecipientCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `PaymentInitiationRecipientCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PaymentInitiationRecipientCreateOperationRequest` | `src/ThePlaidApi/Requests/PaymentInitiationRecipientCreateOperationRequest.cs` |
| `PaymentInitiationRecipientCreateRequest` | `src/ThePlaidApi/Models/PaymentInitiationRecipientCreateRequest.cs` |
| `PaymentInitiationRecipientCreateResponse` | `src/ThePlaidApi/Models/PaymentInitiationRecipientCreateResponse.cs` |

### PaymentInitiationRecipientGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `PaymentInitiationRecipientGet(PaymentInitiationRecipientGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `PaymentInitiationRecipientGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PaymentInitiationRecipientGetOperationRequest` | `src/ThePlaidApi/Requests/PaymentInitiationRecipientGetOperationRequest.cs` |
| `PaymentInitiationRecipientGetRequest` | `src/ThePlaidApi/Models/PaymentInitiationRecipientGetRequest.cs` |
| `PaymentInitiationRecipientGetResponse` | `src/ThePlaidApi/Models/PaymentInitiationRecipientGetResponse.cs` |

### PaymentInitiationRecipientList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `PaymentInitiationRecipientList(PaymentInitiationRecipientListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `PaymentInitiationRecipientListResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PaymentInitiationRecipientListOperationRequest` | `src/ThePlaidApi/Requests/PaymentInitiationRecipientListOperationRequest.cs` |
| `PaymentInitiationRecipientListRequest` | `src/ThePlaidApi/Models/PaymentInitiationRecipientListRequest.cs` |
| `PaymentInitiationRecipientListResponse` | `src/ThePlaidApi/Models/PaymentInitiationRecipientListResponse.cs` |

### PaymentProfileCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `PaymentProfileCreate(PaymentProfileCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `PaymentProfileCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PaymentProfileCreateOperationRequest` | `src/ThePlaidApi/Requests/PaymentProfileCreateOperationRequest.cs` |
| `PaymentProfileCreateRequest` | `src/ThePlaidApi/Models/PaymentProfileCreateRequest.cs` |
| `PaymentProfileCreateResponse` | `src/ThePlaidApi/Models/PaymentProfileCreateResponse.cs` |

### PaymentProfileGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `PaymentProfileGet(PaymentProfileGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `PaymentProfileGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PaymentProfileGetOperationRequest` | `src/ThePlaidApi/Requests/PaymentProfileGetOperationRequest.cs` |
| `PaymentProfileGetRequest` | `src/ThePlaidApi/Models/PaymentProfileGetRequest.cs` |
| `PaymentProfileGetResponse` | `src/ThePlaidApi/Models/PaymentProfileGetResponse.cs` |

### PaymentProfileRemove

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `PaymentProfileRemove(PaymentProfileRemoveOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `PaymentProfileRemoveResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PaymentProfileRemoveOperationRequest` | `src/ThePlaidApi/Requests/PaymentProfileRemoveOperationRequest.cs` |
| `PaymentProfileRemoveRequest` | `src/ThePlaidApi/Models/PaymentProfileRemoveRequest.cs` |
| `PaymentProfileRemoveResponse` | `src/ThePlaidApi/Models/PaymentProfileRemoveResponse.cs` |

### ProcessorAccountGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProcessorAccountGet(ProcessorAccountGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ProcessorAccountGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorAccountGetOperationRequest` | `src/ThePlaidApi/Requests/ProcessorAccountGetOperationRequest.cs` |
| `ProcessorAccountGetRequest` | `src/ThePlaidApi/Models/ProcessorAccountGetRequest.cs` |
| `ProcessorAccountGetResponse` | `src/ThePlaidApi/Models/ProcessorAccountGetResponse.cs` |

### ProcessorApexProcessorTokenCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProcessorApexProcessorTokenCreate(ProcessorApexProcessorTokenCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ProcessorTokenCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorApexProcessorTokenCreateOperationRequest` | `src/ThePlaidApi/Requests/ProcessorApexProcessorTokenCreateOperationRequest.cs` |
| `ProcessorApexProcessorTokenCreateRequest` | `src/ThePlaidApi/Models/ProcessorApexProcessorTokenCreateRequest.cs` |
| `ProcessorTokenCreateResponse` | `src/ThePlaidApi/Models/ProcessorTokenCreateResponse.cs` |

### ProcessorAuthGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProcessorAuthGet(ProcessorAuthGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ProcessorAuthGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorAuthGetOperationRequest` | `src/ThePlaidApi/Requests/ProcessorAuthGetOperationRequest.cs` |
| `ProcessorAuthGetRequest` | `src/ThePlaidApi/Models/ProcessorAuthGetRequest.cs` |
| `ProcessorAuthGetResponse` | `src/ThePlaidApi/Models/ProcessorAuthGetResponse.cs` |

### ProcessorBalanceGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProcessorBalanceGet(ProcessorBalanceGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ProcessorBalanceGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorBalanceGetOperationRequest` | `src/ThePlaidApi/Requests/ProcessorBalanceGetOperationRequest.cs` |
| `ProcessorBalanceGetRequest` | `src/ThePlaidApi/Models/ProcessorBalanceGetRequest.cs` |
| `ProcessorBalanceGetResponse` | `src/ThePlaidApi/Models/ProcessorBalanceGetResponse.cs` |

### ProcessorBankTransferCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProcessorBankTransferCreate(ProcessorBankTransferCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ProcessorBankTransferCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorBankTransferCreateOperationRequest` | `src/ThePlaidApi/Requests/ProcessorBankTransferCreateOperationRequest.cs` |
| `ProcessorBankTransferCreateRequest` | `src/ThePlaidApi/Models/ProcessorBankTransferCreateRequest.cs` |
| `ProcessorBankTransferCreateResponse` | `src/ThePlaidApi/Models/ProcessorBankTransferCreateResponse.cs` |

### ProcessorIdentityGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProcessorIdentityGet(ProcessorIdentityGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ProcessorIdentityGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorIdentityGetOperationRequest` | `src/ThePlaidApi/Requests/ProcessorIdentityGetOperationRequest.cs` |
| `ProcessorIdentityGetRequest` | `src/ThePlaidApi/Models/ProcessorIdentityGetRequest.cs` |
| `ProcessorIdentityGetResponse` | `src/ThePlaidApi/Models/ProcessorIdentityGetResponse.cs` |

### ProcessorIdentityMatch

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProcessorIdentityMatch(ProcessorIdentityMatchOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ProcessorIdentityMatchResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorIdentityMatchOperationRequest` | `src/ThePlaidApi/Requests/ProcessorIdentityMatchOperationRequest.cs` |
| `ProcessorIdentityMatchRequest` | `src/ThePlaidApi/Models/ProcessorIdentityMatchRequest.cs` |
| `ProcessorIdentityMatchResponse` | `src/ThePlaidApi/Models/ProcessorIdentityMatchResponse.cs` |

### ProcessorInvestmentsAuthGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProcessorInvestmentsAuthGet(ProcessorInvestmentsAuthGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ProcessorInvestmentsAuthGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorInvestmentsAuthGetOperationRequest` | `src/ThePlaidApi/Requests/ProcessorInvestmentsAuthGetOperationRequest.cs` |
| `ProcessorInvestmentsAuthGetRequest` | `src/ThePlaidApi/Models/ProcessorInvestmentsAuthGetRequest.cs` |
| `ProcessorInvestmentsAuthGetResponse` | `src/ThePlaidApi/Models/ProcessorInvestmentsAuthGetResponse.cs` |

### ProcessorInvestmentsHoldingsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProcessorInvestmentsHoldingsGet(ProcessorInvestmentsHoldingsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ProcessorInvestmentsHoldingsGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorInvestmentsHoldingsGetOperationRequest` | `src/ThePlaidApi/Requests/ProcessorInvestmentsHoldingsGetOperationRequest.cs` |
| `ProcessorInvestmentsHoldingsGetRequest` | `src/ThePlaidApi/Models/ProcessorInvestmentsHoldingsGetRequest.cs` |
| `ProcessorInvestmentsHoldingsGetResponse` | `src/ThePlaidApi/Models/ProcessorInvestmentsHoldingsGetResponse.cs` |

### ProcessorInvestmentsTransactionsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProcessorInvestmentsTransactionsGet(ProcessorInvestmentsTransactionsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ProcessorInvestmentsTransactionsGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorInvestmentsTransactionsGetOperationRequest` | `src/ThePlaidApi/Requests/ProcessorInvestmentsTransactionsGetOperationRequest.cs` |
| `ProcessorInvestmentsTransactionsGetRequest` | `src/ThePlaidApi/Models/ProcessorInvestmentsTransactionsGetRequest.cs` |
| `ProcessorInvestmentsTransactionsGetResponse` | `src/ThePlaidApi/Models/ProcessorInvestmentsTransactionsGetResponse.cs` |

### ProcessorLiabilitiesGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProcessorLiabilitiesGet(ProcessorLiabilitiesGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ProcessorLiabilitiesGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorLiabilitiesGetOperationRequest` | `src/ThePlaidApi/Requests/ProcessorLiabilitiesGetOperationRequest.cs` |
| `ProcessorLiabilitiesGetRequest` | `src/ThePlaidApi/Models/ProcessorLiabilitiesGetRequest.cs` |
| `ProcessorLiabilitiesGetResponse` | `src/ThePlaidApi/Models/ProcessorLiabilitiesGetResponse.cs` |

### ProcessorSignalDecisionReport

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProcessorSignalDecisionReport(ProcessorSignalDecisionReportOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ProcessorSignalDecisionReportResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorSignalDecisionReportOperationRequest` | `src/ThePlaidApi/Requests/ProcessorSignalDecisionReportOperationRequest.cs` |
| `ProcessorSignalDecisionReportRequest` | `src/ThePlaidApi/Models/ProcessorSignalDecisionReportRequest.cs` |
| `ProcessorSignalDecisionReportResponse` | `src/ThePlaidApi/Models/ProcessorSignalDecisionReportResponse.cs` |

### ProcessorSignalEvaluate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProcessorSignalEvaluate(ProcessorSignalEvaluateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ProcessorSignalEvaluateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorSignalEvaluateOperationRequest` | `src/ThePlaidApi/Requests/ProcessorSignalEvaluateOperationRequest.cs` |
| `ProcessorSignalEvaluateRequest` | `src/ThePlaidApi/Models/ProcessorSignalEvaluateRequest.cs` |
| `ProcessorSignalEvaluateResponse` | `src/ThePlaidApi/Models/ProcessorSignalEvaluateResponse.cs` |

### ProcessorSignalPrepare

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProcessorSignalPrepare(ProcessorSignalPrepareOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ProcessorSignalPrepareResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorSignalPrepareOperationRequest` | `src/ThePlaidApi/Requests/ProcessorSignalPrepareOperationRequest.cs` |
| `ProcessorSignalPrepareRequest` | `src/ThePlaidApi/Models/ProcessorSignalPrepareRequest.cs` |
| `ProcessorSignalPrepareResponse` | `src/ThePlaidApi/Models/ProcessorSignalPrepareResponse.cs` |

### ProcessorSignalReturnReport

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProcessorSignalReturnReport(ProcessorSignalReturnReportOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ProcessorSignalReturnReportResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorSignalReturnReportOperationRequest` | `src/ThePlaidApi/Requests/ProcessorSignalReturnReportOperationRequest.cs` |
| `ProcessorSignalReturnReportRequest` | `src/ThePlaidApi/Models/ProcessorSignalReturnReportRequest.cs` |
| `ProcessorSignalReturnReportResponse` | `src/ThePlaidApi/Models/ProcessorSignalReturnReportResponse.cs` |

### ProcessorStripeBankAccountTokenCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProcessorStripeBankAccountTokenCreate(ProcessorStripeBankAccountTokenCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ProcessorStripeBankAccountTokenCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorStripeBankAccountTokenCreateOperationRequest` | `src/ThePlaidApi/Requests/ProcessorStripeBankAccountTokenCreateOperationRequest.cs` |
| `ProcessorStripeBankAccountTokenCreateRequest` | `src/ThePlaidApi/Models/ProcessorStripeBankAccountTokenCreateRequest.cs` |
| `ProcessorStripeBankAccountTokenCreateResponse` | `src/ThePlaidApi/Models/ProcessorStripeBankAccountTokenCreateResponse.cs` |

### ProcessorTokenCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProcessorTokenCreate(ProcessorTokenCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ProcessorTokenCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorTokenCreateOperationRequest` | `src/ThePlaidApi/Requests/ProcessorTokenCreateOperationRequest.cs` |
| `ProcessorTokenCreateRequest` | `src/ThePlaidApi/Models/ProcessorTokenCreateRequest.cs` |
| `ProcessorTokenCreateResponse` | `src/ThePlaidApi/Models/ProcessorTokenCreateResponse.cs` |

### ProcessorTokenPermissionsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProcessorTokenPermissionsGet(ProcessorTokenPermissionsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ProcessorTokenPermissionsGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorTokenPermissionsGetOperationRequest` | `src/ThePlaidApi/Requests/ProcessorTokenPermissionsGetOperationRequest.cs` |
| `ProcessorTokenPermissionsGetRequest` | `src/ThePlaidApi/Models/ProcessorTokenPermissionsGetRequest.cs` |
| `ProcessorTokenPermissionsGetResponse` | `src/ThePlaidApi/Models/ProcessorTokenPermissionsGetResponse.cs` |

### ProcessorTokenPermissionsSet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProcessorTokenPermissionsSet(ProcessorTokenPermissionsSetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ProcessorTokenPermissionsSetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorTokenPermissionsSetOperationRequest` | `src/ThePlaidApi/Requests/ProcessorTokenPermissionsSetOperationRequest.cs` |
| `ProcessorTokenPermissionsSetRequest` | `src/ThePlaidApi/Models/ProcessorTokenPermissionsSetRequest.cs` |
| `ProcessorTokenPermissionsSetResponse` | `src/ThePlaidApi/Models/ProcessorTokenPermissionsSetResponse.cs` |

### ProcessorTokenWebhookUpdate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProcessorTokenWebhookUpdate(ProcessorTokenWebhookUpdateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ProcessorTokenWebhookUpdateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorTokenWebhookUpdateOperationRequest` | `src/ThePlaidApi/Requests/ProcessorTokenWebhookUpdateOperationRequest.cs` |
| `ProcessorTokenWebhookUpdateRequest` | `src/ThePlaidApi/Models/ProcessorTokenWebhookUpdateRequest.cs` |
| `ProcessorTokenWebhookUpdateResponse` | `src/ThePlaidApi/Models/ProcessorTokenWebhookUpdateResponse.cs` |

### ProcessorTransactionsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProcessorTransactionsGet(ProcessorTransactionsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ProcessorTransactionsGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorTransactionsGetOperationRequest` | `src/ThePlaidApi/Requests/ProcessorTransactionsGetOperationRequest.cs` |
| `ProcessorTransactionsGetRequest` | `src/ThePlaidApi/Models/ProcessorTransactionsGetRequest.cs` |
| `ProcessorTransactionsGetResponse` | `src/ThePlaidApi/Models/ProcessorTransactionsGetResponse.cs` |

### ProcessorTransactionsRecurringGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProcessorTransactionsRecurringGet(ProcessorTransactionsRecurringGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ProcessorTransactionsRecurringGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorTransactionsRecurringGetOperationRequest` | `src/ThePlaidApi/Requests/ProcessorTransactionsRecurringGetOperationRequest.cs` |
| `ProcessorTransactionsRecurringGetRequest` | `src/ThePlaidApi/Models/ProcessorTransactionsRecurringGetRequest.cs` |
| `ProcessorTransactionsRecurringGetResponse` | `src/ThePlaidApi/Models/ProcessorTransactionsRecurringGetResponse.cs` |

### ProcessorTransactionsRefresh

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProcessorTransactionsRefresh(ProcessorTransactionsRefreshOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ProcessorTransactionsRefreshResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorTransactionsRefreshOperationRequest` | `src/ThePlaidApi/Requests/ProcessorTransactionsRefreshOperationRequest.cs` |
| `ProcessorTransactionsRefreshRequest` | `src/ThePlaidApi/Models/ProcessorTransactionsRefreshRequest.cs` |
| `ProcessorTransactionsRefreshResponse` | `src/ThePlaidApi/Models/ProcessorTransactionsRefreshResponse.cs` |

### ProcessorTransactionsSync

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProcessorTransactionsSync(ProcessorTransactionsSyncOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ProcessorTransactionsSyncResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorTransactionsSyncOperationRequest` | `src/ThePlaidApi/Requests/ProcessorTransactionsSyncOperationRequest.cs` |
| `ProcessorTransactionsSyncRequest` | `src/ThePlaidApi/Models/ProcessorTransactionsSyncRequest.cs` |
| `ProcessorTransactionsSyncResponse` | `src/ThePlaidApi/Models/ProcessorTransactionsSyncResponse.cs` |

### ProfileNetworkStatusGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProfileNetworkStatusGet(ProfileNetworkStatusGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ProfileNetworkStatusGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProfileNetworkStatusGetOperationRequest` | `src/ThePlaidApi/Requests/ProfileNetworkStatusGetOperationRequest.cs` |
| `ProfileNetworkStatusGetRequest` | `src/ThePlaidApi/Models/ProfileNetworkStatusGetRequest.cs` |
| `ProfileNetworkStatusGetResponse` | `src/ThePlaidApi/Models/ProfileNetworkStatusGetResponse.cs` |

### ProtectCompute

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProtectCompute(ProtectComputeOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ProtectComputeResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProtectComputeOperationRequest` | `src/ThePlaidApi/Requests/ProtectComputeOperationRequest.cs` |
| `ProtectComputeRequest` | `src/ThePlaidApi/Models/ProtectComputeRequest.cs` |
| `ProtectComputeResponse` | `src/ThePlaidApi/Models/ProtectComputeResponse.cs` |

### ProtectEventGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProtectEventGet(ProtectEventGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ProtectEventGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProtectEventGetOperationRequest` | `src/ThePlaidApi/Requests/ProtectEventGetOperationRequest.cs` |
| `ProtectEventGetRequest` | `src/ThePlaidApi/Models/ProtectEventGetRequest.cs` |
| `ProtectEventGetResponse` | `src/ThePlaidApi/Models/ProtectEventGetResponse.cs` |

### ProtectEventSend

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProtectEventSend(ProtectEventSendOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ProtectEventSendResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProtectEventSendOperationRequest` | `src/ThePlaidApi/Requests/ProtectEventSendOperationRequest.cs` |
| `ProtectEventSendRequest` | `src/ThePlaidApi/Models/ProtectEventSendRequest.cs` |
| `ProtectEventSendResponse` | `src/ThePlaidApi/Models/ProtectEventSendResponse.cs` |

### ProtectReportCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProtectReportCreate(ProtectReportCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ProtectReportCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProtectReportCreateOperationRequest` | `src/ThePlaidApi/Requests/ProtectReportCreateOperationRequest.cs` |
| `ProtectReportCreateRequest` | `src/ThePlaidApi/Models/ProtectReportCreateRequest.cs` |
| `ProtectReportCreateResponse` | `src/ThePlaidApi/Models/ProtectReportCreateResponse.cs` |

### ProtectUserInsightsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProtectUserInsightsGet(ProtectUserInsightsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ProtectUserInsightsGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProtectUserInsightsGetOperationRequest` | `src/ThePlaidApi/Requests/ProtectUserInsightsGetOperationRequest.cs` |
| `ProtectUserInsightsGetRequest` | `src/ThePlaidApi/Models/ProtectUserInsightsGetRequest.cs` |
| `ProtectUserInsightsGetResponse` | `src/ThePlaidApi/Models/ProtectUserInsightsGetResponse.cs` |

### SandboxBankIncomeFireWebhook

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxBankIncomeFireWebhook(SandboxBankIncomeFireWebhookOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SandboxBankIncomeFireWebhookResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxBankIncomeFireWebhookOperationRequest` | `src/ThePlaidApi/Requests/SandboxBankIncomeFireWebhookOperationRequest.cs` |
| `SandboxBankIncomeFireWebhookRequest` | `src/ThePlaidApi/Models/SandboxBankIncomeFireWebhookRequest.cs` |
| `SandboxBankIncomeFireWebhookResponse` | `src/ThePlaidApi/Models/SandboxBankIncomeFireWebhookResponse.cs` |

### SandboxBankTransferFireWebhook

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxBankTransferFireWebhook(SandboxBankTransferFireWebhookOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SandboxBankTransferFireWebhookResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxBankTransferFireWebhookOperationRequest` | `src/ThePlaidApi/Requests/SandboxBankTransferFireWebhookOperationRequest.cs` |
| `SandboxBankTransferFireWebhookRequest` | `src/ThePlaidApi/Models/SandboxBankTransferFireWebhookRequest.cs` |
| `SandboxBankTransferFireWebhookResponse` | `src/ThePlaidApi/Models/SandboxBankTransferFireWebhookResponse.cs` |

### SandboxBankTransferSimulate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxBankTransferSimulate(SandboxBankTransferSimulateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SandboxBankTransferSimulateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxBankTransferSimulateOperationRequest` | `src/ThePlaidApi/Requests/SandboxBankTransferSimulateOperationRequest.cs` |
| `SandboxBankTransferSimulateRequest` | `src/ThePlaidApi/Models/SandboxBankTransferSimulateRequest.cs` |
| `SandboxBankTransferSimulateResponse` | `src/ThePlaidApi/Models/SandboxBankTransferSimulateResponse.cs` |

### SandboxCraCashflowUpdatesUpdate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxCraCashflowUpdatesUpdate(SandboxCraCashflowUpdatesUpdateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SandboxCraCashflowUpdatesUpdateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxCraCashflowUpdatesUpdateOperationRequest` | `src/ThePlaidApi/Requests/SandboxCraCashflowUpdatesUpdateOperationRequest.cs` |
| `SandboxCraCashflowUpdatesUpdateRequest` | `src/ThePlaidApi/Models/SandboxCraCashflowUpdatesUpdateRequest.cs` |
| `SandboxCraCashflowUpdatesUpdateResponse` | `src/ThePlaidApi/Models/SandboxCraCashflowUpdatesUpdateResponse.cs` |

### SandboxFdxConsentSeed

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxFdxConsentSeed(SandboxFdxConsentSeedOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SandboxFdxConsentSeedResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxFdxConsentSeedOperationRequest` | `src/ThePlaidApi/Requests/SandboxFdxConsentSeedOperationRequest.cs` |
| `SandboxFdxConsentSeedRequest` | `src/ThePlaidApi/Models/SandboxFdxConsentSeedRequest.cs` |
| `SandboxFdxConsentSeedResponse` | `src/ThePlaidApi/Models/SandboxFdxConsentSeedResponse.cs` |

### SandboxIncomeFireWebhook

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxIncomeFireWebhook(SandboxIncomeFireWebhookOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SandboxIncomeFireWebhookResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxIncomeFireWebhookOperationRequest` | `src/ThePlaidApi/Requests/SandboxIncomeFireWebhookOperationRequest.cs` |
| `SandboxIncomeFireWebhookRequest` | `src/ThePlaidApi/Models/SandboxIncomeFireWebhookRequest.cs` |
| `SandboxIncomeFireWebhookResponse` | `src/ThePlaidApi/Models/SandboxIncomeFireWebhookResponse.cs` |

### SandboxItemApplicationSeed

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxItemApplicationSeed(SandboxItemApplicationSeedOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SandboxItemApplicationSeedResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxItemApplicationSeedOperationRequest` | `src/ThePlaidApi/Requests/SandboxItemApplicationSeedOperationRequest.cs` |
| `SandboxItemApplicationSeedRequest` | `src/ThePlaidApi/Models/SandboxItemApplicationSeedRequest.cs` |
| `SandboxItemApplicationSeedResponse` | `src/ThePlaidApi/Models/SandboxItemApplicationSeedResponse.cs` |

### SandboxItemFireWebhook

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxItemFireWebhook(SandboxItemFireWebhookOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SandboxItemFireWebhookResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxItemFireWebhookOperationRequest` | `src/ThePlaidApi/Requests/SandboxItemFireWebhookOperationRequest.cs` |
| `SandboxItemFireWebhookRequest` | `src/ThePlaidApi/Models/SandboxItemFireWebhookRequest.cs` |
| `SandboxItemFireWebhookResponse` | `src/ThePlaidApi/Models/SandboxItemFireWebhookResponse.cs` |

### SandboxItemResetLogin

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxItemResetLogin(SandboxItemResetLoginOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SandboxItemResetLoginResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxItemResetLoginOperationRequest` | `src/ThePlaidApi/Requests/SandboxItemResetLoginOperationRequest.cs` |
| `SandboxItemResetLoginRequest` | `src/ThePlaidApi/Models/SandboxItemResetLoginRequest.cs` |
| `SandboxItemResetLoginResponse` | `src/ThePlaidApi/Models/SandboxItemResetLoginResponse.cs` |

### SandboxItemSetVerificationStatus

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxItemSetVerificationStatus(SandboxItemSetVerificationStatusOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SandboxItemSetVerificationStatusResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxItemSetVerificationStatusOperationRequest` | `src/ThePlaidApi/Requests/SandboxItemSetVerificationStatusOperationRequest.cs` |
| `SandboxItemSetVerificationStatusRequest` | `src/ThePlaidApi/Models/SandboxItemSetVerificationStatusRequest.cs` |
| `SandboxItemSetVerificationStatusResponse` | `src/ThePlaidApi/Models/SandboxItemSetVerificationStatusResponse.cs` |

### SandboxOauthSelectAccounts

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxOauthSelectAccounts(SandboxOauthSelectAccountsOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `object`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxOauthSelectAccountsOperationRequest` | `src/ThePlaidApi/Requests/SandboxOauthSelectAccountsOperationRequest.cs` |
| `SandboxOauthSelectAccountsRequest` | `src/ThePlaidApi/Models/SandboxOauthSelectAccountsRequest.cs` |

### SandboxPaymentProfileResetLogin

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxPaymentProfileResetLogin(SandboxPaymentProfileResetLoginOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SandboxPaymentProfileResetLoginResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxPaymentProfileResetLoginOperationRequest` | `src/ThePlaidApi/Requests/SandboxPaymentProfileResetLoginOperationRequest.cs` |
| `SandboxPaymentProfileResetLoginRequest` | `src/ThePlaidApi/Models/SandboxPaymentProfileResetLoginRequest.cs` |
| `SandboxPaymentProfileResetLoginResponse` | `src/ThePlaidApi/Models/SandboxPaymentProfileResetLoginResponse.cs` |

### SandboxPaymentSimulate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxPaymentSimulate(SandboxPaymentSimulateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SandboxPaymentSimulateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxPaymentSimulateOperationRequest` | `src/ThePlaidApi/Requests/SandboxPaymentSimulateOperationRequest.cs` |
| `SandboxPaymentSimulateRequest` | `src/ThePlaidApi/Models/SandboxPaymentSimulateRequest.cs` |
| `SandboxPaymentSimulateResponse` | `src/ThePlaidApi/Models/SandboxPaymentSimulateResponse.cs` |

### SandboxProcessorTokenCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxProcessorTokenCreate(SandboxProcessorTokenCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SandboxProcessorTokenCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxProcessorTokenCreateOperationRequest` | `src/ThePlaidApi/Requests/SandboxProcessorTokenCreateOperationRequest.cs` |
| `SandboxProcessorTokenCreateRequest` | `src/ThePlaidApi/Models/SandboxProcessorTokenCreateRequest.cs` |
| `SandboxProcessorTokenCreateResponse` | `src/ThePlaidApi/Models/SandboxProcessorTokenCreateResponse.cs` |

### SandboxPublicTokenCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxPublicTokenCreate(SandboxPublicTokenCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SandboxPublicTokenCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxPublicTokenCreateOperationRequest` | `src/ThePlaidApi/Requests/SandboxPublicTokenCreateOperationRequest.cs` |
| `SandboxPublicTokenCreateRequest` | `src/ThePlaidApi/Models/SandboxPublicTokenCreateRequest.cs` |
| `SandboxPublicTokenCreateResponse` | `src/ThePlaidApi/Models/SandboxPublicTokenCreateResponse.cs` |

### SandboxTransactionsCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxTransactionsCreate(SandboxTransactionsCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SandboxTransactionsCreateResponse`
- **Error**: `ApiException<SandboxTransactionsCreateError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error?)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SandboxTransactionsCreateOperationRequest` | `src/ThePlaidApi/Requests/SandboxTransactionsCreateOperationRequest.cs` |
| `SandboxTransactionsCreateRequest` | `src/ThePlaidApi/Models/SandboxTransactionsCreateRequest.cs` |
| `SandboxTransactionsCreateResponse` | `src/ThePlaidApi/Models/SandboxTransactionsCreateResponse.cs` |
| `SandboxTransactionsCreateError` | `src/ThePlaidApi/Errors/SandboxTransactionsCreateError.cs` |
| `Error` | `src/ThePlaidApi/Models/Error.cs` |

### SandboxTransferFireWebhook

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxTransferFireWebhook(SandboxTransferFireWebhookOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SandboxTransferFireWebhookResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxTransferFireWebhookOperationRequest` | `src/ThePlaidApi/Requests/SandboxTransferFireWebhookOperationRequest.cs` |
| `SandboxTransferFireWebhookRequest` | `src/ThePlaidApi/Models/SandboxTransferFireWebhookRequest.cs` |
| `SandboxTransferFireWebhookResponse` | `src/ThePlaidApi/Models/SandboxTransferFireWebhookResponse.cs` |

### SandboxTransferLedgerDepositSimulate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxTransferLedgerDepositSimulate(SandboxTransferLedgerDepositSimulateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SandboxTransferLedgerDepositSimulateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxTransferLedgerDepositSimulateOperationRequest` | `src/ThePlaidApi/Requests/SandboxTransferLedgerDepositSimulateOperationRequest.cs` |
| `SandboxTransferLedgerDepositSimulateRequest` | `src/ThePlaidApi/Models/SandboxTransferLedgerDepositSimulateRequest.cs` |
| `SandboxTransferLedgerDepositSimulateResponse` | `src/ThePlaidApi/Models/SandboxTransferLedgerDepositSimulateResponse.cs` |

### SandboxTransferLedgerSimulateAvailable

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxTransferLedgerSimulateAvailable(SandboxTransferLedgerSimulateAvailableOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SandboxTransferLedgerSimulateAvailableResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxTransferLedgerSimulateAvailableOperationRequest` | `src/ThePlaidApi/Requests/SandboxTransferLedgerSimulateAvailableOperationRequest.cs` |
| `SandboxTransferLedgerSimulateAvailableRequest` | `src/ThePlaidApi/Models/SandboxTransferLedgerSimulateAvailableRequest.cs` |
| `SandboxTransferLedgerSimulateAvailableResponse` | `src/ThePlaidApi/Models/SandboxTransferLedgerSimulateAvailableResponse.cs` |

### SandboxTransferLedgerWithdrawSimulate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxTransferLedgerWithdrawSimulate(SandboxTransferLedgerWithdrawSimulateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SandboxTransferLedgerWithdrawSimulateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxTransferLedgerWithdrawSimulateOperationRequest` | `src/ThePlaidApi/Requests/SandboxTransferLedgerWithdrawSimulateOperationRequest.cs` |
| `SandboxTransferLedgerWithdrawSimulateRequest` | `src/ThePlaidApi/Models/SandboxTransferLedgerWithdrawSimulateRequest.cs` |
| `SandboxTransferLedgerWithdrawSimulateResponse` | `src/ThePlaidApi/Models/SandboxTransferLedgerWithdrawSimulateResponse.cs` |

### SandboxTransferRefundSimulate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxTransferRefundSimulate(SandboxTransferRefundSimulateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SandboxTransferRefundSimulateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxTransferRefundSimulateOperationRequest` | `src/ThePlaidApi/Requests/SandboxTransferRefundSimulateOperationRequest.cs` |
| `SandboxTransferRefundSimulateRequest` | `src/ThePlaidApi/Models/SandboxTransferRefundSimulateRequest.cs` |
| `SandboxTransferRefundSimulateResponse` | `src/ThePlaidApi/Models/SandboxTransferRefundSimulateResponse.cs` |

### SandboxTransferRepaymentSimulate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxTransferRepaymentSimulate(SandboxTransferRepaymentSimulateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SandboxTransferRepaymentSimulateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxTransferRepaymentSimulateOperationRequest` | `src/ThePlaidApi/Requests/SandboxTransferRepaymentSimulateOperationRequest.cs` |
| `SandboxTransferRepaymentSimulateRequest` | `src/ThePlaidApi/Models/SandboxTransferRepaymentSimulateRequest.cs` |
| `SandboxTransferRepaymentSimulateResponse` | `src/ThePlaidApi/Models/SandboxTransferRepaymentSimulateResponse.cs` |

### SandboxTransferSimulate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxTransferSimulate(SandboxTransferSimulateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SandboxTransferSimulateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxTransferSimulateOperationRequest` | `src/ThePlaidApi/Requests/SandboxTransferSimulateOperationRequest.cs` |
| `SandboxTransferSimulateRequest` | `src/ThePlaidApi/Models/SandboxTransferSimulateRequest.cs` |
| `SandboxTransferSimulateResponse` | `src/ThePlaidApi/Models/SandboxTransferSimulateResponse.cs` |

### SandboxTransferSweepSimulate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxTransferSweepSimulate(SandboxTransferSweepSimulateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SandboxTransferSweepSimulateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxTransferSweepSimulateOperationRequest` | `src/ThePlaidApi/Requests/SandboxTransferSweepSimulateOperationRequest.cs` |
| `SandboxTransferSweepSimulateRequest` | `src/ThePlaidApi/Models/SandboxTransferSweepSimulateRequest.cs` |
| `SandboxTransferSweepSimulateResponse` | `src/ThePlaidApi/Models/SandboxTransferSweepSimulateResponse.cs` |

### SandboxTransferTestClockAdvance

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxTransferTestClockAdvance(SandboxTransferTestClockAdvanceOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SandboxTransferTestClockAdvanceResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxTransferTestClockAdvanceOperationRequest` | `src/ThePlaidApi/Requests/SandboxTransferTestClockAdvanceOperationRequest.cs` |
| `SandboxTransferTestClockAdvanceRequest` | `src/ThePlaidApi/Models/SandboxTransferTestClockAdvanceRequest.cs` |
| `SandboxTransferTestClockAdvanceResponse` | `src/ThePlaidApi/Models/SandboxTransferTestClockAdvanceResponse.cs` |

### SandboxTransferTestClockCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxTransferTestClockCreate(SandboxTransferTestClockCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SandboxTransferTestClockCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxTransferTestClockCreateOperationRequest` | `src/ThePlaidApi/Requests/SandboxTransferTestClockCreateOperationRequest.cs` |
| `SandboxTransferTestClockCreateRequest` | `src/ThePlaidApi/Models/SandboxTransferTestClockCreateRequest.cs` |
| `SandboxTransferTestClockCreateResponse` | `src/ThePlaidApi/Models/SandboxTransferTestClockCreateResponse.cs` |

### SandboxTransferTestClockGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxTransferTestClockGet(SandboxTransferTestClockGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SandboxTransferTestClockGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxTransferTestClockGetOperationRequest` | `src/ThePlaidApi/Requests/SandboxTransferTestClockGetOperationRequest.cs` |
| `SandboxTransferTestClockGetRequest` | `src/ThePlaidApi/Models/SandboxTransferTestClockGetRequest.cs` |
| `SandboxTransferTestClockGetResponse` | `src/ThePlaidApi/Models/SandboxTransferTestClockGetResponse.cs` |

### SandboxTransferTestClockList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxTransferTestClockList(SandboxTransferTestClockListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SandboxTransferTestClockListResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxTransferTestClockListOperationRequest` | `src/ThePlaidApi/Requests/SandboxTransferTestClockListOperationRequest.cs` |
| `SandboxTransferTestClockListRequest` | `src/ThePlaidApi/Models/SandboxTransferTestClockListRequest.cs` |
| `SandboxTransferTestClockListResponse` | `src/ThePlaidApi/Models/SandboxTransferTestClockListResponse.cs` |

### SandboxUserResetLogin

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxUserResetLogin(SandboxUserResetLoginOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SandboxUserResetLoginResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxUserResetLoginOperationRequest` | `src/ThePlaidApi/Requests/SandboxUserResetLoginOperationRequest.cs` |
| `SandboxUserResetLoginRequest` | `src/ThePlaidApi/Models/SandboxUserResetLoginRequest.cs` |
| `SandboxUserResetLoginResponse` | `src/ThePlaidApi/Models/SandboxUserResetLoginResponse.cs` |

### SessionTokenCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SessionTokenCreate(SessionTokenCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SessionTokenCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SessionTokenCreateOperationRequest` | `src/ThePlaidApi/Requests/SessionTokenCreateOperationRequest.cs` |
| `SessionTokenCreateRequest` | `src/ThePlaidApi/Models/SessionTokenCreateRequest.cs` |
| `SessionTokenCreateResponse` | `src/ThePlaidApi/Models/SessionTokenCreateResponse.cs` |

### SignalDecisionReport

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SignalDecisionReport(SignalDecisionReportOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SignalDecisionReportResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SignalDecisionReportOperationRequest` | `src/ThePlaidApi/Requests/SignalDecisionReportOperationRequest.cs` |
| `SignalDecisionReportRequest` | `src/ThePlaidApi/Models/SignalDecisionReportRequest.cs` |
| `SignalDecisionReportResponse` | `src/ThePlaidApi/Models/SignalDecisionReportResponse.cs` |

### SignalEvaluate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SignalEvaluate(SignalEvaluateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SignalEvaluateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SignalEvaluateOperationRequest` | `src/ThePlaidApi/Requests/SignalEvaluateOperationRequest.cs` |
| `SignalEvaluateRequest` | `src/ThePlaidApi/Models/SignalEvaluateRequest.cs` |
| `SignalEvaluateResponse` | `src/ThePlaidApi/Models/SignalEvaluateResponse.cs` |

### SignalPrepare

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SignalPrepare(SignalPrepareOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SignalPrepareResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SignalPrepareOperationRequest` | `src/ThePlaidApi/Requests/SignalPrepareOperationRequest.cs` |
| `SignalPrepareRequest` | `src/ThePlaidApi/Models/SignalPrepareRequest.cs` |
| `SignalPrepareResponse` | `src/ThePlaidApi/Models/SignalPrepareResponse.cs` |

### SignalReturnReport

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SignalReturnReport(SignalReturnReportOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SignalReturnReportResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SignalReturnReportOperationRequest` | `src/ThePlaidApi/Requests/SignalReturnReportOperationRequest.cs` |
| `SignalReturnReportRequest` | `src/ThePlaidApi/Models/SignalReturnReportRequest.cs` |
| `SignalReturnReportResponse` | `src/ThePlaidApi/Models/SignalReturnReportResponse.cs` |

### SignalSchedule

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SignalSchedule(SignalScheduleOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SignalScheduleResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SignalScheduleOperationRequest` | `src/ThePlaidApi/Requests/SignalScheduleOperationRequest.cs` |
| `SignalScheduleRequest` | `src/ThePlaidApi/Models/SignalScheduleRequest.cs` |
| `SignalScheduleResponse` | `src/ThePlaidApi/Models/SignalScheduleResponse.cs` |

### StatementsDownload

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `StatementsDownload(StatementsDownloadOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `StatementsDownloadOperationRequest` | `src/ThePlaidApi/Requests/StatementsDownloadOperationRequest.cs` |
| `StatementsDownloadRequest` | `src/ThePlaidApi/Models/StatementsDownloadRequest.cs` |

### StatementsList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `StatementsList(StatementsListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `StatementsListResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `StatementsListOperationRequest` | `src/ThePlaidApi/Requests/StatementsListOperationRequest.cs` |
| `StatementsListRequest` | `src/ThePlaidApi/Models/StatementsListRequest.cs` |
| `StatementsListResponse` | `src/ThePlaidApi/Models/StatementsListResponse.cs` |

### StatementsRefresh

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `StatementsRefresh(StatementsRefreshOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `StatementsRefreshResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `StatementsRefreshOperationRequest` | `src/ThePlaidApi/Requests/StatementsRefreshOperationRequest.cs` |
| `StatementsRefreshRequest` | `src/ThePlaidApi/Models/StatementsRefreshRequest.cs` |
| `StatementsRefreshResponse` | `src/ThePlaidApi/Models/StatementsRefreshResponse.cs` |

### TransactionsEnhance

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransactionsEnhance(TransactionsEnhanceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransactionsEnhanceGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransactionsEnhanceRequest` | `src/ThePlaidApi/Requests/TransactionsEnhanceRequest.cs` |
| `TransactionsEnhanceGetRequest` | `src/ThePlaidApi/Models/TransactionsEnhanceGetRequest.cs` |
| `TransactionsEnhanceGetResponse` | `src/ThePlaidApi/Models/TransactionsEnhanceGetResponse.cs` |

### TransactionsEnrich

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransactionsEnrich(TransactionsEnrichOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransactionsEnrichResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransactionsEnrichOperationRequest` | `src/ThePlaidApi/Requests/TransactionsEnrichOperationRequest.cs` |
| `TransactionsEnrichRequest` | `src/ThePlaidApi/Models/TransactionsEnrichRequest.cs` |
| `TransactionsEnrichResponse` | `src/ThePlaidApi/Models/TransactionsEnrichResponse.cs` |

### TransactionsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransactionsGet(TransactionsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransactionsGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransactionsGetOperationRequest` | `src/ThePlaidApi/Requests/TransactionsGetOperationRequest.cs` |
| `TransactionsGetRequest` | `src/ThePlaidApi/Models/TransactionsGetRequest.cs` |
| `TransactionsGetResponse` | `src/ThePlaidApi/Models/TransactionsGetResponse.cs` |

### TransactionsRecurringGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransactionsRecurringGet(TransactionsRecurringGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransactionsRecurringGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransactionsRecurringGetOperationRequest` | `src/ThePlaidApi/Requests/TransactionsRecurringGetOperationRequest.cs` |
| `TransactionsRecurringGetRequest` | `src/ThePlaidApi/Models/TransactionsRecurringGetRequest.cs` |
| `TransactionsRecurringGetResponse` | `src/ThePlaidApi/Models/TransactionsRecurringGetResponse.cs` |

### TransactionsRefresh

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransactionsRefresh(TransactionsRefreshOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransactionsRefreshResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransactionsRefreshOperationRequest` | `src/ThePlaidApi/Requests/TransactionsRefreshOperationRequest.cs` |
| `TransactionsRefreshRequest` | `src/ThePlaidApi/Models/TransactionsRefreshRequest.cs` |
| `TransactionsRefreshResponse` | `src/ThePlaidApi/Models/TransactionsRefreshResponse.cs` |

### TransactionsRulesCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransactionsRulesCreate(TransactionsRulesCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransactionsRulesCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransactionsRulesCreateOperationRequest` | `src/ThePlaidApi/Requests/TransactionsRulesCreateOperationRequest.cs` |
| `TransactionsRulesCreateRequest` | `src/ThePlaidApi/Models/TransactionsRulesCreateRequest.cs` |
| `TransactionsRulesCreateResponse` | `src/ThePlaidApi/Models/TransactionsRulesCreateResponse.cs` |

### TransactionsRulesList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransactionsRulesList(TransactionsRulesListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransactionsRulesListResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransactionsRulesListOperationRequest` | `src/ThePlaidApi/Requests/TransactionsRulesListOperationRequest.cs` |
| `TransactionsRulesListRequest` | `src/ThePlaidApi/Models/TransactionsRulesListRequest.cs` |
| `TransactionsRulesListResponse` | `src/ThePlaidApi/Models/TransactionsRulesListResponse.cs` |

### TransactionsRulesRemove

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransactionsRulesRemove(TransactionsRulesRemoveOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransactionsRulesRemoveResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransactionsRulesRemoveOperationRequest` | `src/ThePlaidApi/Requests/TransactionsRulesRemoveOperationRequest.cs` |
| `TransactionsRulesRemoveRequest` | `src/ThePlaidApi/Models/TransactionsRulesRemoveRequest.cs` |
| `TransactionsRulesRemoveResponse` | `src/ThePlaidApi/Models/TransactionsRulesRemoveResponse.cs` |

### TransactionsSync

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransactionsSync(TransactionsSyncOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransactionsSyncResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransactionsSyncOperationRequest` | `src/ThePlaidApi/Requests/TransactionsSyncOperationRequest.cs` |
| `TransactionsSyncRequest` | `src/ThePlaidApi/Models/TransactionsSyncRequest.cs` |
| `TransactionsSyncResponse` | `src/ThePlaidApi/Models/TransactionsSyncResponse.cs` |

### TransactionsUserInsightsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransactionsUserInsightsGet(TransactionsUserInsightsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransactionsUserInsightsGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransactionsUserInsightsGetOperationRequest` | `src/ThePlaidApi/Requests/TransactionsUserInsightsGetOperationRequest.cs` |
| `TransactionsUserInsightsGetRequest` | `src/ThePlaidApi/Models/TransactionsUserInsightsGetRequest.cs` |
| `TransactionsUserInsightsGetResponse` | `src/ThePlaidApi/Models/TransactionsUserInsightsGetResponse.cs` |

### TransferAuthorizationCancel

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferAuthorizationCancel(TransferAuthorizationCancelOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransferAuthorizationCancelResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferAuthorizationCancelOperationRequest` | `src/ThePlaidApi/Requests/TransferAuthorizationCancelOperationRequest.cs` |
| `TransferAuthorizationCancelRequest` | `src/ThePlaidApi/Models/TransferAuthorizationCancelRequest.cs` |
| `TransferAuthorizationCancelResponse` | `src/ThePlaidApi/Models/TransferAuthorizationCancelResponse.cs` |

### TransferAuthorizationCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferAuthorizationCreate(TransferAuthorizationCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransferAuthorizationCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferAuthorizationCreateOperationRequest` | `src/ThePlaidApi/Requests/TransferAuthorizationCreateOperationRequest.cs` |
| `TransferAuthorizationCreateRequest` | `src/ThePlaidApi/Models/TransferAuthorizationCreateRequest.cs` |
| `TransferAuthorizationCreateResponse` | `src/ThePlaidApi/Models/TransferAuthorizationCreateResponse.cs` |

### TransferBalanceGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferBalanceGet(TransferBalanceGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransferBalanceGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferBalanceGetOperationRequest` | `src/ThePlaidApi/Requests/TransferBalanceGetOperationRequest.cs` |
| `TransferBalanceGetRequest` | `src/ThePlaidApi/Models/TransferBalanceGetRequest.cs` |
| `TransferBalanceGetResponse` | `src/ThePlaidApi/Models/TransferBalanceGetResponse.cs` |

### TransferCancel

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferCancel(TransferCancelOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransferCancelResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferCancelOperationRequest` | `src/ThePlaidApi/Requests/TransferCancelOperationRequest.cs` |
| `TransferCancelRequest` | `src/ThePlaidApi/Models/TransferCancelRequest.cs` |
| `TransferCancelResponse` | `src/ThePlaidApi/Models/TransferCancelResponse.cs` |

### TransferCapabilitiesGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferCapabilitiesGet(TransferCapabilitiesGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransferCapabilitiesGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferCapabilitiesGetOperationRequest` | `src/ThePlaidApi/Requests/TransferCapabilitiesGetOperationRequest.cs` |
| `TransferCapabilitiesGetRequest` | `src/ThePlaidApi/Models/TransferCapabilitiesGetRequest.cs` |
| `TransferCapabilitiesGetResponse` | `src/ThePlaidApi/Models/TransferCapabilitiesGetResponse.cs` |

### TransferConfigurationGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferConfigurationGet(TransferConfigurationGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransferConfigurationGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferConfigurationGetOperationRequest` | `src/ThePlaidApi/Requests/TransferConfigurationGetOperationRequest.cs` |
| `TransferConfigurationGetRequest` | `src/ThePlaidApi/Models/TransferConfigurationGetRequest.cs` |
| `TransferConfigurationGetResponse` | `src/ThePlaidApi/Models/TransferConfigurationGetResponse.cs` |

### TransferCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferCreate(TransferCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransferCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferCreateOperationRequest` | `src/ThePlaidApi/Requests/TransferCreateOperationRequest.cs` |
| `TransferCreateRequest` | `src/ThePlaidApi/Models/TransferCreateRequest.cs` |
| `TransferCreateResponse` | `src/ThePlaidApi/Models/TransferCreateResponse.cs` |

### TransferDiligenceDocumentUpload

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferDiligenceDocumentUpload(TransferDiligenceDocumentUploadOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransferDiligenceDocumentUploadResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferDiligenceDocumentUploadOperationRequest` | `src/ThePlaidApi/Requests/TransferDiligenceDocumentUploadOperationRequest.cs` |
| `TransferDiligenceDocumentUploadRequest` | `src/ThePlaidApi/Models/TransferDiligenceDocumentUploadRequest.cs` |
| `TransferDiligenceDocumentUploadResponse` | `src/ThePlaidApi/Models/TransferDiligenceDocumentUploadResponse.cs` |

### TransferDiligenceSubmit

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferDiligenceSubmit(TransferDiligenceSubmitOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransferDiligenceSubmitResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferDiligenceSubmitOperationRequest` | `src/ThePlaidApi/Requests/TransferDiligenceSubmitOperationRequest.cs` |
| `TransferDiligenceSubmitRequest` | `src/ThePlaidApi/Models/TransferDiligenceSubmitRequest.cs` |
| `TransferDiligenceSubmitResponse` | `src/ThePlaidApi/Models/TransferDiligenceSubmitResponse.cs` |

### TransferEventList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferEventList(TransferEventListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransferEventListResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferEventListOperationRequest` | `src/ThePlaidApi/Requests/TransferEventListOperationRequest.cs` |
| `TransferEventListRequest` | `src/ThePlaidApi/Models/TransferEventListRequest.cs` |
| `TransferEventListResponse` | `src/ThePlaidApi/Models/TransferEventListResponse.cs` |

### TransferEventSync

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferEventSync(TransferEventSyncOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransferEventSyncResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferEventSyncOperationRequest` | `src/ThePlaidApi/Requests/TransferEventSyncOperationRequest.cs` |
| `TransferEventSyncRequest` | `src/ThePlaidApi/Models/TransferEventSyncRequest.cs` |
| `TransferEventSyncResponse` | `src/ThePlaidApi/Models/TransferEventSyncResponse.cs` |

### TransferGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferGet(TransferGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransferGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferGetOperationRequest` | `src/ThePlaidApi/Requests/TransferGetOperationRequest.cs` |
| `TransferGetRequest` | `src/ThePlaidApi/Models/TransferGetRequest.cs` |
| `TransferGetResponse` | `src/ThePlaidApi/Models/TransferGetResponse.cs` |

### TransferIntentCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferIntentCreate(TransferIntentCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransferIntentCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferIntentCreateOperationRequest` | `src/ThePlaidApi/Requests/TransferIntentCreateOperationRequest.cs` |
| `TransferIntentCreateRequest` | `src/ThePlaidApi/Models/TransferIntentCreateRequest.cs` |
| `TransferIntentCreateResponse` | `src/ThePlaidApi/Models/TransferIntentCreateResponse.cs` |

### TransferIntentGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferIntentGet(TransferIntentGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransferIntentGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferIntentGetOperationRequest` | `src/ThePlaidApi/Requests/TransferIntentGetOperationRequest.cs` |
| `TransferIntentGetRequest` | `src/ThePlaidApi/Models/TransferIntentGetRequest.cs` |
| `TransferIntentGetResponse` | `src/ThePlaidApi/Models/TransferIntentGetResponse.cs` |

### TransferLedgerDeposit

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferLedgerDeposit(TransferLedgerDepositOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransferLedgerDepositResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferLedgerDepositOperationRequest` | `src/ThePlaidApi/Requests/TransferLedgerDepositOperationRequest.cs` |
| `TransferLedgerDepositRequest` | `src/ThePlaidApi/Models/TransferLedgerDepositRequest.cs` |
| `TransferLedgerDepositResponse` | `src/ThePlaidApi/Models/TransferLedgerDepositResponse.cs` |

### TransferLedgerDistribute

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferLedgerDistribute(TransferLedgerDistributeOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransferLedgerDistributeResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferLedgerDistributeOperationRequest` | `src/ThePlaidApi/Requests/TransferLedgerDistributeOperationRequest.cs` |
| `TransferLedgerDistributeRequest` | `src/ThePlaidApi/Models/TransferLedgerDistributeRequest.cs` |
| `TransferLedgerDistributeResponse` | `src/ThePlaidApi/Models/TransferLedgerDistributeResponse.cs` |

### TransferLedgerEventList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferLedgerEventList(TransferLedgerEventListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransferLedgerEventListResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferLedgerEventListOperationRequest` | `src/ThePlaidApi/Requests/TransferLedgerEventListOperationRequest.cs` |
| `TransferLedgerEventListRequest` | `src/ThePlaidApi/Models/TransferLedgerEventListRequest.cs` |
| `TransferLedgerEventListResponse` | `src/ThePlaidApi/Models/TransferLedgerEventListResponse.cs` |

### TransferLedgerGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferLedgerGet(TransferLedgerGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransferLedgerGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferLedgerGetOperationRequest` | `src/ThePlaidApi/Requests/TransferLedgerGetOperationRequest.cs` |
| `TransferLedgerGetRequest` | `src/ThePlaidApi/Models/TransferLedgerGetRequest.cs` |
| `TransferLedgerGetResponse` | `src/ThePlaidApi/Models/TransferLedgerGetResponse.cs` |

### TransferLedgerWithdraw

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferLedgerWithdraw(TransferLedgerWithdrawOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransferLedgerWithdrawResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferLedgerWithdrawOperationRequest` | `src/ThePlaidApi/Requests/TransferLedgerWithdrawOperationRequest.cs` |
| `TransferLedgerWithdrawRequest` | `src/ThePlaidApi/Models/TransferLedgerWithdrawRequest.cs` |
| `TransferLedgerWithdrawResponse` | `src/ThePlaidApi/Models/TransferLedgerWithdrawResponse.cs` |

### TransferList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferList(TransferListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransferListResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferListOperationRequest` | `src/ThePlaidApi/Requests/TransferListOperationRequest.cs` |
| `TransferListRequest` | `src/ThePlaidApi/Models/TransferListRequest.cs` |
| `TransferListResponse` | `src/ThePlaidApi/Models/TransferListResponse.cs` |

### TransferMetricsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferMetricsGet(TransferMetricsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransferMetricsGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferMetricsGetOperationRequest` | `src/ThePlaidApi/Requests/TransferMetricsGetOperationRequest.cs` |
| `TransferMetricsGetRequest` | `src/ThePlaidApi/Models/TransferMetricsGetRequest.cs` |
| `TransferMetricsGetResponse` | `src/ThePlaidApi/Models/TransferMetricsGetResponse.cs` |

### TransferMigrateAccount

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferMigrateAccount(TransferMigrateAccountOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransferMigrateAccountResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferMigrateAccountOperationRequest` | `src/ThePlaidApi/Requests/TransferMigrateAccountOperationRequest.cs` |
| `TransferMigrateAccountRequest` | `src/ThePlaidApi/Models/TransferMigrateAccountRequest.cs` |
| `TransferMigrateAccountResponse` | `src/ThePlaidApi/Models/TransferMigrateAccountResponse.cs` |

### TransferOriginatorCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferOriginatorCreate(TransferOriginatorCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransferOriginatorCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferOriginatorCreateOperationRequest` | `src/ThePlaidApi/Requests/TransferOriginatorCreateOperationRequest.cs` |
| `TransferOriginatorCreateRequest` | `src/ThePlaidApi/Models/TransferOriginatorCreateRequest.cs` |
| `TransferOriginatorCreateResponse` | `src/ThePlaidApi/Models/TransferOriginatorCreateResponse.cs` |

### TransferOriginatorFundingAccountCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferOriginatorFundingAccountCreate(TransferOriginatorFundingAccountCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransferOriginatorFundingAccountCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferOriginatorFundingAccountCreateOperationRequest` | `src/ThePlaidApi/Requests/TransferOriginatorFundingAccountCreateOperationRequest.cs` |
| `TransferOriginatorFundingAccountCreateRequest` | `src/ThePlaidApi/Models/TransferOriginatorFundingAccountCreateRequest.cs` |
| `TransferOriginatorFundingAccountCreateResponse` | `src/ThePlaidApi/Models/TransferOriginatorFundingAccountCreateResponse.cs` |

### TransferOriginatorFundingAccountUpdate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferOriginatorFundingAccountUpdate(TransferOriginatorFundingAccountUpdateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransferOriginatorFundingAccountUpdateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferOriginatorFundingAccountUpdateOperationRequest` | `src/ThePlaidApi/Requests/TransferOriginatorFundingAccountUpdateOperationRequest.cs` |
| `TransferOriginatorFundingAccountUpdateRequest` | `src/ThePlaidApi/Models/TransferOriginatorFundingAccountUpdateRequest.cs` |
| `TransferOriginatorFundingAccountUpdateResponse` | `src/ThePlaidApi/Models/TransferOriginatorFundingAccountUpdateResponse.cs` |

### TransferOriginatorGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferOriginatorGet(TransferOriginatorGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransferOriginatorGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferOriginatorGetOperationRequest` | `src/ThePlaidApi/Requests/TransferOriginatorGetOperationRequest.cs` |
| `TransferOriginatorGetRequest` | `src/ThePlaidApi/Models/TransferOriginatorGetRequest.cs` |
| `TransferOriginatorGetResponse` | `src/ThePlaidApi/Models/TransferOriginatorGetResponse.cs` |

### TransferOriginatorList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferOriginatorList(TransferOriginatorListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransferOriginatorListResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferOriginatorListOperationRequest` | `src/ThePlaidApi/Requests/TransferOriginatorListOperationRequest.cs` |
| `TransferOriginatorListRequest` | `src/ThePlaidApi/Models/TransferOriginatorListRequest.cs` |
| `TransferOriginatorListResponse` | `src/ThePlaidApi/Models/TransferOriginatorListResponse.cs` |

### TransferPlatformOriginatorCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferPlatformOriginatorCreate(TransferPlatformOriginatorCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransferPlatformOriginatorCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferPlatformOriginatorCreateOperationRequest` | `src/ThePlaidApi/Requests/TransferPlatformOriginatorCreateOperationRequest.cs` |
| `TransferPlatformOriginatorCreateRequest` | `src/ThePlaidApi/Models/TransferPlatformOriginatorCreateRequest.cs` |
| `TransferPlatformOriginatorCreateResponse` | `src/ThePlaidApi/Models/TransferPlatformOriginatorCreateResponse.cs` |

### TransferPlatformPersonCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferPlatformPersonCreate(TransferPlatformPersonCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransferPlatformPersonCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferPlatformPersonCreateOperationRequest` | `src/ThePlaidApi/Requests/TransferPlatformPersonCreateOperationRequest.cs` |
| `TransferPlatformPersonCreateRequest` | `src/ThePlaidApi/Models/TransferPlatformPersonCreateRequest.cs` |
| `TransferPlatformPersonCreateResponse` | `src/ThePlaidApi/Models/TransferPlatformPersonCreateResponse.cs` |

### TransferPlatformRequirementSubmit

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferPlatformRequirementSubmit(TransferPlatformRequirementSubmitOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransferPlatformRequirementSubmitResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferPlatformRequirementSubmitOperationRequest` | `src/ThePlaidApi/Requests/TransferPlatformRequirementSubmitOperationRequest.cs` |
| `TransferPlatformRequirementSubmitRequest` | `src/ThePlaidApi/Models/TransferPlatformRequirementSubmitRequest.cs` |
| `TransferPlatformRequirementSubmitResponse` | `src/ThePlaidApi/Models/TransferPlatformRequirementSubmitResponse.cs` |

### TransferQuestionnaireCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferQuestionnaireCreate(TransferQuestionnaireCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransferQuestionnaireCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferQuestionnaireCreateOperationRequest` | `src/ThePlaidApi/Requests/TransferQuestionnaireCreateOperationRequest.cs` |
| `TransferQuestionnaireCreateRequest` | `src/ThePlaidApi/Models/TransferQuestionnaireCreateRequest.cs` |
| `TransferQuestionnaireCreateResponse` | `src/ThePlaidApi/Models/TransferQuestionnaireCreateResponse.cs` |

### TransferRecurringCancel

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferRecurringCancel(TransferRecurringCancelOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransferRecurringCancelResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferRecurringCancelOperationRequest` | `src/ThePlaidApi/Requests/TransferRecurringCancelOperationRequest.cs` |
| `TransferRecurringCancelRequest` | `src/ThePlaidApi/Models/TransferRecurringCancelRequest.cs` |
| `TransferRecurringCancelResponse` | `src/ThePlaidApi/Models/TransferRecurringCancelResponse.cs` |

### TransferRecurringCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferRecurringCreate(TransferRecurringCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransferRecurringCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferRecurringCreateOperationRequest` | `src/ThePlaidApi/Requests/TransferRecurringCreateOperationRequest.cs` |
| `TransferRecurringCreateRequest` | `src/ThePlaidApi/Models/TransferRecurringCreateRequest.cs` |
| `TransferRecurringCreateResponse` | `src/ThePlaidApi/Models/TransferRecurringCreateResponse.cs` |

### TransferRecurringGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferRecurringGet(TransferRecurringGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransferRecurringGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferRecurringGetOperationRequest` | `src/ThePlaidApi/Requests/TransferRecurringGetOperationRequest.cs` |
| `TransferRecurringGetRequest` | `src/ThePlaidApi/Models/TransferRecurringGetRequest.cs` |
| `TransferRecurringGetResponse` | `src/ThePlaidApi/Models/TransferRecurringGetResponse.cs` |

### TransferRecurringList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferRecurringList(TransferRecurringListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransferRecurringListResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferRecurringListOperationRequest` | `src/ThePlaidApi/Requests/TransferRecurringListOperationRequest.cs` |
| `TransferRecurringListRequest` | `src/ThePlaidApi/Models/TransferRecurringListRequest.cs` |
| `TransferRecurringListResponse` | `src/ThePlaidApi/Models/TransferRecurringListResponse.cs` |

### TransferRefundCancel

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferRefundCancel(TransferRefundCancelOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransferRefundCancelResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferRefundCancelOperationRequest` | `src/ThePlaidApi/Requests/TransferRefundCancelOperationRequest.cs` |
| `TransferRefundCancelRequest` | `src/ThePlaidApi/Models/TransferRefundCancelRequest.cs` |
| `TransferRefundCancelResponse` | `src/ThePlaidApi/Models/TransferRefundCancelResponse.cs` |

### TransferRefundCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferRefundCreate(TransferRefundCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransferRefundCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferRefundCreateOperationRequest` | `src/ThePlaidApi/Requests/TransferRefundCreateOperationRequest.cs` |
| `TransferRefundCreateRequest` | `src/ThePlaidApi/Models/TransferRefundCreateRequest.cs` |
| `TransferRefundCreateResponse` | `src/ThePlaidApi/Models/TransferRefundCreateResponse.cs` |

### TransferRefundGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferRefundGet(TransferRefundGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransferRefundGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferRefundGetOperationRequest` | `src/ThePlaidApi/Requests/TransferRefundGetOperationRequest.cs` |
| `TransferRefundGetRequest` | `src/ThePlaidApi/Models/TransferRefundGetRequest.cs` |
| `TransferRefundGetResponse` | `src/ThePlaidApi/Models/TransferRefundGetResponse.cs` |

### TransferRepaymentList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferRepaymentList(TransferRepaymentListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransferRepaymentListResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferRepaymentListOperationRequest` | `src/ThePlaidApi/Requests/TransferRepaymentListOperationRequest.cs` |
| `TransferRepaymentListRequest` | `src/ThePlaidApi/Models/TransferRepaymentListRequest.cs` |
| `TransferRepaymentListResponse` | `src/ThePlaidApi/Models/TransferRepaymentListResponse.cs` |

### TransferRepaymentReturnList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferRepaymentReturnList(TransferRepaymentReturnListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransferRepaymentReturnListResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferRepaymentReturnListOperationRequest` | `src/ThePlaidApi/Requests/TransferRepaymentReturnListOperationRequest.cs` |
| `TransferRepaymentReturnListRequest` | `src/ThePlaidApi/Models/TransferRepaymentReturnListRequest.cs` |
| `TransferRepaymentReturnListResponse` | `src/ThePlaidApi/Models/TransferRepaymentReturnListResponse.cs` |

### TransferReturnRecover

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferReturnRecover(TransferReturnRecoverOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransferReturnRecoverResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferReturnRecoverOperationRequest` | `src/ThePlaidApi/Requests/TransferReturnRecoverOperationRequest.cs` |
| `TransferReturnRecoverRequest` | `src/ThePlaidApi/Models/TransferReturnRecoverRequest.cs` |
| `TransferReturnRecoverResponse` | `src/ThePlaidApi/Models/TransferReturnRecoverResponse.cs` |

### TransferSweepGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferSweepGet(TransferSweepGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransferSweepGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferSweepGetOperationRequest` | `src/ThePlaidApi/Requests/TransferSweepGetOperationRequest.cs` |
| `TransferSweepGetRequest` | `src/ThePlaidApi/Models/TransferSweepGetRequest.cs` |
| `TransferSweepGetResponse` | `src/ThePlaidApi/Models/TransferSweepGetResponse.cs` |

### TransferSweepList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferSweepList(TransferSweepListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `TransferSweepListResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferSweepListOperationRequest` | `src/ThePlaidApi/Requests/TransferSweepListOperationRequest.cs` |
| `TransferSweepListRequest` | `src/ThePlaidApi/Models/TransferSweepListRequest.cs` |
| `TransferSweepListResponse` | `src/ThePlaidApi/Models/TransferSweepListResponse.cs` |

### UserAccountSessionEventSend

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `UserAccountSessionEventSend(UserAccountSessionEventSendOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `UserAccountSessionEventSendResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UserAccountSessionEventSendOperationRequest` | `src/ThePlaidApi/Requests/UserAccountSessionEventSendOperationRequest.cs` |
| `UserAccountSessionEventSendRequest` | `src/ThePlaidApi/Models/UserAccountSessionEventSendRequest.cs` |
| `UserAccountSessionEventSendResponse` | `src/ThePlaidApi/Models/UserAccountSessionEventSendResponse.cs` |

### UserAccountSessionGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `UserAccountSessionGet(UserAccountSessionGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `UserAccountSessionGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UserAccountSessionGetOperationRequest` | `src/ThePlaidApi/Requests/UserAccountSessionGetOperationRequest.cs` |
| `UserAccountSessionGetRequest` | `src/ThePlaidApi/Models/UserAccountSessionGetRequest.cs` |
| `UserAccountSessionGetResponse` | `src/ThePlaidApi/Models/UserAccountSessionGetResponse.cs` |

### UserCreate

- **Auth**: (`options.ClientId` AND `options.Secret` AND `options.PlaidVersion`) OR `options.Oauth2`
- **Signature**: `UserCreate(UserCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `UserCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UserCreateOperationRequest` | `src/ThePlaidApi/Requests/UserCreateOperationRequest.cs` |
| `UserCreateRequest` | `src/ThePlaidApi/Models/UserCreateRequest.cs` |
| `UserCreateResponse` | `src/ThePlaidApi/Models/UserCreateResponse.cs` |

### UserFinancialDataRefresh

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `UserFinancialDataRefresh(UserFinancialDataRefreshOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `UserFinancialDataRefreshResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UserFinancialDataRefreshOperationRequest` | `src/ThePlaidApi/Requests/UserFinancialDataRefreshOperationRequest.cs` |
| `UserFinancialDataRefreshRequest` | `src/ThePlaidApi/Models/UserFinancialDataRefreshRequest.cs` |
| `UserFinancialDataRefreshResponse` | `src/ThePlaidApi/Models/UserFinancialDataRefreshResponse.cs` |

### UserGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `UserGet(UserGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `UserGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UserGetOperationRequest` | `src/ThePlaidApi/Requests/UserGetOperationRequest.cs` |
| `UserGetRequest` | `src/ThePlaidApi/Models/UserGetRequest.cs` |
| `UserGetResponse` | `src/ThePlaidApi/Models/UserGetResponse.cs` |

### UserIdentityRemove

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `UserIdentityRemove(UserIdentityRemoveOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `UserIdentityRemoveResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UserIdentityRemoveOperationRequest` | `src/ThePlaidApi/Requests/UserIdentityRemoveOperationRequest.cs` |
| `UserIdentityRemoveRequest` | `src/ThePlaidApi/Models/UserIdentityRemoveRequest.cs` |
| `UserIdentityRemoveResponse` | `src/ThePlaidApi/Models/UserIdentityRemoveResponse.cs` |

### UserItemsAssociate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `UserItemsAssociate(UserItemsAssociateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `UserItemsAssociateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UserItemsAssociateOperationRequest` | `src/ThePlaidApi/Requests/UserItemsAssociateOperationRequest.cs` |
| `UserItemsAssociateRequest` | `src/ThePlaidApi/Models/UserItemsAssociateRequest.cs` |
| `UserItemsAssociateResponse` | `src/ThePlaidApi/Models/UserItemsAssociateResponse.cs` |

### UserItemsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `UserItemsGet(UserItemsGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `UserItemsGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UserItemsGetOperationRequest` | `src/ThePlaidApi/Requests/UserItemsGetOperationRequest.cs` |
| `UserItemsGetRequest` | `src/ThePlaidApi/Models/UserItemsGetRequest.cs` |
| `UserItemsGetResponse` | `src/ThePlaidApi/Models/UserItemsGetResponse.cs` |

### UserItemsRemove

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `UserItemsRemove(UserItemsRemoveOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `UserItemsRemoveResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UserItemsRemoveOperationRequest` | `src/ThePlaidApi/Requests/UserItemsRemoveOperationRequest.cs` |
| `UserItemsRemoveRequest` | `src/ThePlaidApi/Models/UserItemsRemoveRequest.cs` |
| `UserItemsRemoveResponse` | `src/ThePlaidApi/Models/UserItemsRemoveResponse.cs` |

### UserProductsTerminate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `UserProductsTerminate(UserProductsTerminateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `UserProductsTerminateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UserProductsTerminateOperationRequest` | `src/ThePlaidApi/Requests/UserProductsTerminateOperationRequest.cs` |
| `UserProductsTerminateRequest` | `src/ThePlaidApi/Models/UserProductsTerminateRequest.cs` |
| `UserProductsTerminateResponse` | `src/ThePlaidApi/Models/UserProductsTerminateResponse.cs` |

### UserRemove

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `UserRemove(UserRemoveOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `UserRemoveResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UserRemoveOperationRequest` | `src/ThePlaidApi/Requests/UserRemoveOperationRequest.cs` |
| `UserRemoveRequest` | `src/ThePlaidApi/Models/UserRemoveRequest.cs` |
| `UserRemoveResponse` | `src/ThePlaidApi/Models/UserRemoveResponse.cs` |

### UserThirdPartyTokenCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `UserThirdPartyTokenCreate(UserThirdPartyTokenCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `UserThirdPartyTokenCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UserThirdPartyTokenCreateOperationRequest` | `src/ThePlaidApi/Requests/UserThirdPartyTokenCreateOperationRequest.cs` |
| `UserThirdPartyTokenCreateRequest` | `src/ThePlaidApi/Models/UserThirdPartyTokenCreateRequest.cs` |
| `UserThirdPartyTokenCreateResponse` | `src/ThePlaidApi/Models/UserThirdPartyTokenCreateResponse.cs` |

### UserThirdPartyTokenRemove

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `UserThirdPartyTokenRemove(UserThirdPartyTokenRemoveOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `UserThirdPartyTokenRemoveResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UserThirdPartyTokenRemoveOperationRequest` | `src/ThePlaidApi/Requests/UserThirdPartyTokenRemoveOperationRequest.cs` |
| `UserThirdPartyTokenRemoveRequest` | `src/ThePlaidApi/Models/UserThirdPartyTokenRemoveRequest.cs` |
| `UserThirdPartyTokenRemoveResponse` | `src/ThePlaidApi/Models/UserThirdPartyTokenRemoveResponse.cs` |

### UserTransactionsRefresh

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `UserTransactionsRefresh(UserTransactionsRefreshOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `UserTransactionsRefreshResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UserTransactionsRefreshOperationRequest` | `src/ThePlaidApi/Requests/UserTransactionsRefreshOperationRequest.cs` |
| `UserTransactionsRefreshRequest` | `src/ThePlaidApi/Models/UserTransactionsRefreshRequest.cs` |
| `UserTransactionsRefreshResponse` | `src/ThePlaidApi/Models/UserTransactionsRefreshResponse.cs` |

### UserUpdate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `UserUpdate(UserUpdateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `UserUpdateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UserUpdateOperationRequest` | `src/ThePlaidApi/Requests/UserUpdateOperationRequest.cs` |
| `UserUpdateRequest` | `src/ThePlaidApi/Models/UserUpdateRequest.cs` |
| `UserUpdateResponse` | `src/ThePlaidApi/Models/UserUpdateResponse.cs` |

### WalletCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `WalletCreate(WalletCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `WalletCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WalletCreateOperationRequest` | `src/ThePlaidApi/Requests/WalletCreateOperationRequest.cs` |
| `WalletCreateRequest` | `src/ThePlaidApi/Models/WalletCreateRequest.cs` |
| `WalletCreateResponse` | `src/ThePlaidApi/Models/WalletCreateResponse.cs` |

### WalletGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `WalletGet(WalletGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `WalletGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WalletGetOperationRequest` | `src/ThePlaidApi/Requests/WalletGetOperationRequest.cs` |
| `WalletGetRequest` | `src/ThePlaidApi/Models/WalletGetRequest.cs` |
| `WalletGetResponse` | `src/ThePlaidApi/Models/WalletGetResponse.cs` |

### WalletList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `WalletList(WalletListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `WalletListResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WalletListOperationRequest` | `src/ThePlaidApi/Requests/WalletListOperationRequest.cs` |
| `WalletListRequest` | `src/ThePlaidApi/Models/WalletListRequest.cs` |
| `WalletListResponse` | `src/ThePlaidApi/Models/WalletListResponse.cs` |

### WalletTransactionExecute

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `WalletTransactionExecute(WalletTransactionExecuteOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `WalletTransactionExecuteResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WalletTransactionExecuteOperationRequest` | `src/ThePlaidApi/Requests/WalletTransactionExecuteOperationRequest.cs` |
| `WalletTransactionExecuteRequest` | `src/ThePlaidApi/Models/WalletTransactionExecuteRequest.cs` |
| `WalletTransactionExecuteResponse` | `src/ThePlaidApi/Models/WalletTransactionExecuteResponse.cs` |

### WalletTransactionGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `WalletTransactionGet(WalletTransactionGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `WalletTransactionGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WalletTransactionGetOperationRequest` | `src/ThePlaidApi/Requests/WalletTransactionGetOperationRequest.cs` |
| `WalletTransactionGetRequest` | `src/ThePlaidApi/Models/WalletTransactionGetRequest.cs` |
| `WalletTransactionGetResponse` | `src/ThePlaidApi/Models/WalletTransactionGetResponse.cs` |

### WalletTransactionList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `WalletTransactionList(WalletTransactionListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `WalletTransactionListResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WalletTransactionListOperationRequest` | `src/ThePlaidApi/Requests/WalletTransactionListOperationRequest.cs` |
| `WalletTransactionListRequest` | `src/ThePlaidApi/Models/WalletTransactionListRequest.cs` |
| `WalletTransactionListResponse` | `src/ThePlaidApi/Models/WalletTransactionListResponse.cs` |

### WatchlistScreeningEntityCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `WatchlistScreeningEntityCreate(WatchlistScreeningEntityCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `WatchlistScreeningEntityCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WatchlistScreeningEntityCreateOperationRequest` | `src/ThePlaidApi/Requests/WatchlistScreeningEntityCreateOperationRequest.cs` |
| `WatchlistScreeningEntityCreateRequest` | `src/ThePlaidApi/Models/WatchlistScreeningEntityCreateRequest.cs` |
| `WatchlistScreeningEntityCreateResponse` | `src/ThePlaidApi/Models/WatchlistScreeningEntityCreateResponse.cs` |

### WatchlistScreeningEntityGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `WatchlistScreeningEntityGet(WatchlistScreeningEntityGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `WatchlistScreeningEntityGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WatchlistScreeningEntityGetOperationRequest` | `src/ThePlaidApi/Requests/WatchlistScreeningEntityGetOperationRequest.cs` |
| `WatchlistScreeningEntityGetRequest` | `src/ThePlaidApi/Models/WatchlistScreeningEntityGetRequest.cs` |
| `WatchlistScreeningEntityGetResponse` | `src/ThePlaidApi/Models/WatchlistScreeningEntityGetResponse.cs` |

### WatchlistScreeningEntityHistoryList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `WatchlistScreeningEntityHistoryList(WatchlistScreeningEntityHistoryListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `WatchlistScreeningEntityHistoryListResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WatchlistScreeningEntityHistoryListOperationRequest` | `src/ThePlaidApi/Requests/WatchlistScreeningEntityHistoryListOperationRequest.cs` |
| `WatchlistScreeningEntityHistoryListRequest` | `src/ThePlaidApi/Models/WatchlistScreeningEntityHistoryListRequest.cs` |
| `WatchlistScreeningEntityHistoryListResponse` | `src/ThePlaidApi/Models/WatchlistScreeningEntityHistoryListResponse.cs` |

### WatchlistScreeningEntityHitList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `WatchlistScreeningEntityHitList(WatchlistScreeningEntityHitListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `WatchlistScreeningEntityHitListResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WatchlistScreeningEntityHitListOperationRequest` | `src/ThePlaidApi/Requests/WatchlistScreeningEntityHitListOperationRequest.cs` |
| `WatchlistScreeningEntityHitListRequest` | `src/ThePlaidApi/Models/WatchlistScreeningEntityHitListRequest.cs` |
| `WatchlistScreeningEntityHitListResponse` | `src/ThePlaidApi/Models/WatchlistScreeningEntityHitListResponse.cs` |

### WatchlistScreeningEntityList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `WatchlistScreeningEntityList(WatchlistScreeningEntityListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `WatchlistScreeningEntityListResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WatchlistScreeningEntityListOperationRequest` | `src/ThePlaidApi/Requests/WatchlistScreeningEntityListOperationRequest.cs` |
| `WatchlistScreeningEntityListRequest` | `src/ThePlaidApi/Models/WatchlistScreeningEntityListRequest.cs` |
| `WatchlistScreeningEntityListResponse` | `src/ThePlaidApi/Models/WatchlistScreeningEntityListResponse.cs` |

### WatchlistScreeningEntityProgramGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `WatchlistScreeningEntityProgramGet(WatchlistScreeningEntityProgramGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `WatchlistScreeningEntityProgramGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WatchlistScreeningEntityProgramGetOperationRequest` | `src/ThePlaidApi/Requests/WatchlistScreeningEntityProgramGetOperationRequest.cs` |
| `WatchlistScreeningEntityProgramGetRequest` | `src/ThePlaidApi/Models/WatchlistScreeningEntityProgramGetRequest.cs` |
| `WatchlistScreeningEntityProgramGetResponse` | `src/ThePlaidApi/Models/WatchlistScreeningEntityProgramGetResponse.cs` |

### WatchlistScreeningEntityProgramList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `WatchlistScreeningEntityProgramList(WatchlistScreeningEntityProgramListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `WatchlistScreeningEntityProgramListResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WatchlistScreeningEntityProgramListOperationRequest` | `src/ThePlaidApi/Requests/WatchlistScreeningEntityProgramListOperationRequest.cs` |
| `WatchlistScreeningEntityProgramListRequest` | `src/ThePlaidApi/Models/WatchlistScreeningEntityProgramListRequest.cs` |
| `WatchlistScreeningEntityProgramListResponse` | `src/ThePlaidApi/Models/WatchlistScreeningEntityProgramListResponse.cs` |

### WatchlistScreeningEntityReviewCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `WatchlistScreeningEntityReviewCreate(WatchlistScreeningEntityReviewCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `WatchlistScreeningEntityReviewCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WatchlistScreeningEntityReviewCreateOperationRequest` | `src/ThePlaidApi/Requests/WatchlistScreeningEntityReviewCreateOperationRequest.cs` |
| `WatchlistScreeningEntityReviewCreateRequest` | `src/ThePlaidApi/Models/WatchlistScreeningEntityReviewCreateRequest.cs` |
| `WatchlistScreeningEntityReviewCreateResponse` | `src/ThePlaidApi/Models/WatchlistScreeningEntityReviewCreateResponse.cs` |

### WatchlistScreeningEntityReviewList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `WatchlistScreeningEntityReviewList(WatchlistScreeningEntityReviewListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `WatchlistScreeningEntityReviewListResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WatchlistScreeningEntityReviewListOperationRequest` | `src/ThePlaidApi/Requests/WatchlistScreeningEntityReviewListOperationRequest.cs` |
| `WatchlistScreeningEntityReviewListRequest` | `src/ThePlaidApi/Models/WatchlistScreeningEntityReviewListRequest.cs` |
| `WatchlistScreeningEntityReviewListResponse` | `src/ThePlaidApi/Models/WatchlistScreeningEntityReviewListResponse.cs` |

### WatchlistScreeningEntityUpdate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `WatchlistScreeningEntityUpdate(WatchlistScreeningEntityUpdateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `WatchlistScreeningEntityUpdateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WatchlistScreeningEntityUpdateOperationRequest` | `src/ThePlaidApi/Requests/WatchlistScreeningEntityUpdateOperationRequest.cs` |
| `WatchlistScreeningEntityUpdateRequest` | `src/ThePlaidApi/Models/WatchlistScreeningEntityUpdateRequest.cs` |
| `WatchlistScreeningEntityUpdateResponse` | `src/ThePlaidApi/Models/WatchlistScreeningEntityUpdateResponse.cs` |

### WatchlistScreeningIndividualCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `WatchlistScreeningIndividualCreate(WatchlistScreeningIndividualCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `WatchlistScreeningIndividualCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WatchlistScreeningIndividualCreateOperationRequest` | `src/ThePlaidApi/Requests/WatchlistScreeningIndividualCreateOperationRequest.cs` |
| `WatchlistScreeningIndividualCreateRequest` | `src/ThePlaidApi/Models/WatchlistScreeningIndividualCreateRequest.cs` |
| `WatchlistScreeningIndividualCreateResponse` | `src/ThePlaidApi/Models/WatchlistScreeningIndividualCreateResponse.cs` |

### WatchlistScreeningIndividualGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `WatchlistScreeningIndividualGet(WatchlistScreeningIndividualGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `WatchlistScreeningIndividualGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WatchlistScreeningIndividualGetOperationRequest` | `src/ThePlaidApi/Requests/WatchlistScreeningIndividualGetOperationRequest.cs` |
| `WatchlistScreeningIndividualGetRequest` | `src/ThePlaidApi/Models/WatchlistScreeningIndividualGetRequest.cs` |
| `WatchlistScreeningIndividualGetResponse` | `src/ThePlaidApi/Models/WatchlistScreeningIndividualGetResponse.cs` |

### WatchlistScreeningIndividualHistoryList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `WatchlistScreeningIndividualHistoryList(WatchlistScreeningIndividualHistoryListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `WatchlistScreeningIndividualHistoryListResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WatchlistScreeningIndividualHistoryListOperationRequest` | `src/ThePlaidApi/Requests/WatchlistScreeningIndividualHistoryListOperationRequest.cs` |
| `WatchlistScreeningIndividualHistoryListRequest` | `src/ThePlaidApi/Models/WatchlistScreeningIndividualHistoryListRequest.cs` |
| `WatchlistScreeningIndividualHistoryListResponse` | `src/ThePlaidApi/Models/WatchlistScreeningIndividualHistoryListResponse.cs` |

### WatchlistScreeningIndividualHitList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `WatchlistScreeningIndividualHitList(WatchlistScreeningIndividualHitListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `WatchlistScreeningIndividualHitListResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WatchlistScreeningIndividualHitListOperationRequest` | `src/ThePlaidApi/Requests/WatchlistScreeningIndividualHitListOperationRequest.cs` |
| `WatchlistScreeningIndividualHitListRequest` | `src/ThePlaidApi/Models/WatchlistScreeningIndividualHitListRequest.cs` |
| `WatchlistScreeningIndividualHitListResponse` | `src/ThePlaidApi/Models/WatchlistScreeningIndividualHitListResponse.cs` |

### WatchlistScreeningIndividualList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `WatchlistScreeningIndividualList(WatchlistScreeningIndividualListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `WatchlistScreeningIndividualListResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WatchlistScreeningIndividualListOperationRequest` | `src/ThePlaidApi/Requests/WatchlistScreeningIndividualListOperationRequest.cs` |
| `WatchlistScreeningIndividualListRequest` | `src/ThePlaidApi/Models/WatchlistScreeningIndividualListRequest.cs` |
| `WatchlistScreeningIndividualListResponse` | `src/ThePlaidApi/Models/WatchlistScreeningIndividualListResponse.cs` |

### WatchlistScreeningIndividualProgramGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `WatchlistScreeningIndividualProgramGet(WatchlistScreeningIndividualProgramGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `WatchlistScreeningIndividualProgramGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WatchlistScreeningIndividualProgramGetOperationRequest` | `src/ThePlaidApi/Requests/WatchlistScreeningIndividualProgramGetOperationRequest.cs` |
| `WatchlistScreeningIndividualProgramGetRequest` | `src/ThePlaidApi/Models/WatchlistScreeningIndividualProgramGetRequest.cs` |
| `WatchlistScreeningIndividualProgramGetResponse` | `src/ThePlaidApi/Models/WatchlistScreeningIndividualProgramGetResponse.cs` |

### WatchlistScreeningIndividualProgramList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `WatchlistScreeningIndividualProgramList(WatchlistScreeningIndividualProgramListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `WatchlistScreeningIndividualProgramListResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WatchlistScreeningIndividualProgramListOperationRequest` | `src/ThePlaidApi/Requests/WatchlistScreeningIndividualProgramListOperationRequest.cs` |
| `WatchlistScreeningIndividualProgramListRequest` | `src/ThePlaidApi/Models/WatchlistScreeningIndividualProgramListRequest.cs` |
| `WatchlistScreeningIndividualProgramListResponse` | `src/ThePlaidApi/Models/WatchlistScreeningIndividualProgramListResponse.cs` |

### WatchlistScreeningIndividualReviewCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `WatchlistScreeningIndividualReviewCreate(WatchlistScreeningIndividualReviewCreateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `WatchlistScreeningIndividualReviewCreateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WatchlistScreeningIndividualReviewCreateOperationRequest` | `src/ThePlaidApi/Requests/WatchlistScreeningIndividualReviewCreateOperationRequest.cs` |
| `WatchlistScreeningIndividualReviewCreateRequest` | `src/ThePlaidApi/Models/WatchlistScreeningIndividualReviewCreateRequest.cs` |
| `WatchlistScreeningIndividualReviewCreateResponse` | `src/ThePlaidApi/Models/WatchlistScreeningIndividualReviewCreateResponse.cs` |

### WatchlistScreeningIndividualReviewList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `WatchlistScreeningIndividualReviewList(WatchlistScreeningIndividualReviewListOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `WatchlistScreeningIndividualReviewListResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WatchlistScreeningIndividualReviewListOperationRequest` | `src/ThePlaidApi/Requests/WatchlistScreeningIndividualReviewListOperationRequest.cs` |
| `WatchlistScreeningIndividualReviewListRequest` | `src/ThePlaidApi/Models/WatchlistScreeningIndividualReviewListRequest.cs` |
| `WatchlistScreeningIndividualReviewListResponse` | `src/ThePlaidApi/Models/WatchlistScreeningIndividualReviewListResponse.cs` |

### WatchlistScreeningIndividualUpdate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `WatchlistScreeningIndividualUpdate(WatchlistScreeningIndividualUpdateOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `WatchlistScreeningIndividualUpdateResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WatchlistScreeningIndividualUpdateOperationRequest` | `src/ThePlaidApi/Requests/WatchlistScreeningIndividualUpdateOperationRequest.cs` |
| `WatchlistScreeningIndividualUpdateRequest` | `src/ThePlaidApi/Models/WatchlistScreeningIndividualUpdateRequest.cs` |
| `WatchlistScreeningIndividualUpdateResponse` | `src/ThePlaidApi/Models/WatchlistScreeningIndividualUpdateResponse.cs` |

### WebhookVerificationKeyGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `WebhookVerificationKeyGet(WebhookVerificationKeyGetOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `WebhookVerificationKeyGetResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WebhookVerificationKeyGetOperationRequest` | `src/ThePlaidApi/Requests/WebhookVerificationKeyGetOperationRequest.cs` |
| `WebhookVerificationKeyGetRequest` | `src/ThePlaidApi/Models/WebhookVerificationKeyGetRequest.cs` |
| `WebhookVerificationKeyGetResponse` | `src/ThePlaidApi/Models/WebhookVerificationKeyGetResponse.cs` |


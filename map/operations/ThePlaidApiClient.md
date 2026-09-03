<!-- Generated file — do not edit; regenerated with the SDK. -->

# ThePlaidApiClient — operations

Accessor: `client` · Source: `ThePlaidApiClient.cs` · 335 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AccountsBalanceGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `AccountsBalanceGet(AccountsBalanceGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AccountsGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AccountsBalanceGetRequest` | `Models/AccountsBalanceGetRequest.cs` |
| `AccountsGetResponse` | `Models/AccountsGetResponse.cs` |

### AccountsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `AccountsGet(AccountsGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AccountsGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AccountsGetRequest` | `Models/AccountsGetRequest.cs` |
| `AccountsGetResponse` | `Models/AccountsGetResponse.cs` |

### ApplicationGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ApplicationGet(ApplicationGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ApplicationGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ApplicationGetRequest` | `Models/ApplicationGetRequest.cs` |
| `ApplicationGetResponse` | `Models/ApplicationGetResponse.cs` |

### AssetReportAuditCopyCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `AssetReportAuditCopyCreate(AssetReportAuditCopyCreateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AssetReportAuditCopyCreateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AssetReportAuditCopyCreateRequest` | `Models/AssetReportAuditCopyCreateRequest.cs` |
| `AssetReportAuditCopyCreateResponse` | `Models/AssetReportAuditCopyCreateResponse.cs` |

### AssetReportAuditCopyGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `AssetReportAuditCopyGet(AssetReportAuditCopyGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AssetReportGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AssetReportAuditCopyGetRequest` | `Models/AssetReportAuditCopyGetRequest.cs` |
| `AssetReportGetResponse` | `Models/AssetReportGetResponse.cs` |

### AssetReportAuditCopyPdfGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `AssetReportAuditCopyPdfGet(AssetReportAuditCopyPdfGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AssetReportAuditCopyPdfGetRequest` | `Models/AssetReportAuditCopyPdfGetRequest.cs` |

### AssetReportAuditCopyRemove

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `AssetReportAuditCopyRemove(AssetReportAuditCopyRemoveRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AssetReportAuditCopyRemoveResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AssetReportAuditCopyRemoveRequest` | `Models/AssetReportAuditCopyRemoveRequest.cs` |
| `AssetReportAuditCopyRemoveResponse` | `Models/AssetReportAuditCopyRemoveResponse.cs` |

### AssetReportCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `AssetReportCreate(AssetReportCreateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AssetReportCreateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AssetReportCreateRequest` | `Models/AssetReportCreateRequest.cs` |
| `AssetReportCreateResponse` | `Models/AssetReportCreateResponse.cs` |

### AssetReportFilter

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `AssetReportFilter(AssetReportFilterRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AssetReportFilterResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AssetReportFilterRequest` | `Models/AssetReportFilterRequest.cs` |
| `AssetReportFilterResponse` | `Models/AssetReportFilterResponse.cs` |

### AssetReportGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `AssetReportGet(AssetReportGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AssetReportGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AssetReportGetRequest` | `Models/AssetReportGetRequest.cs` |
| `AssetReportGetResponse` | `Models/AssetReportGetResponse.cs` |

### AssetReportPdfGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `AssetReportPdfGet(AssetReportPdfGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AssetReportPdfGetRequest` | `Models/AssetReportPdfGetRequest.cs` |

### AssetReportRefresh

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `AssetReportRefresh(AssetReportRefreshRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AssetReportRefreshResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AssetReportRefreshRequest` | `Models/AssetReportRefreshRequest.cs` |
| `AssetReportRefreshResponse` | `Models/AssetReportRefreshResponse.cs` |

### AssetReportRemove

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `AssetReportRemove(AssetReportRemoveRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AssetReportRemoveResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AssetReportRemoveRequest` | `Models/AssetReportRemoveRequest.cs` |
| `AssetReportRemoveResponse` | `Models/AssetReportRemoveResponse.cs` |

### AuthGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `AuthGet(AuthGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AuthGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AuthGetRequest` | `Models/AuthGetRequest.cs` |
| `AuthGetResponse` | `Models/AuthGetResponse.cs` |

### AuthVerify

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `AuthVerify(AuthVerifyRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AuthVerifyResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AuthVerifyRequest` | `Models/AuthVerifyRequest.cs` |
| `AuthVerifyResponse` | `Models/AuthVerifyResponse.cs` |

### BankTransferBalanceGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BankTransferBalanceGet(BankTransferBalanceGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BankTransferBalanceGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BankTransferBalanceGetRequest` | `Models/BankTransferBalanceGetRequest.cs` |
| `BankTransferBalanceGetResponse` | `Models/BankTransferBalanceGetResponse.cs` |

### BankTransferCancel

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BankTransferCancel(BankTransferCancelRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BankTransferCancelResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BankTransferCancelRequest` | `Models/BankTransferCancelRequest.cs` |
| `BankTransferCancelResponse` | `Models/BankTransferCancelResponse.cs` |

### BankTransferCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BankTransferCreate(BankTransferCreateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BankTransferCreateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BankTransferCreateRequest` | `Models/BankTransferCreateRequest.cs` |
| `BankTransferCreateResponse` | `Models/BankTransferCreateResponse.cs` |

### BankTransferEventList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BankTransferEventList(BankTransferEventListRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BankTransferEventListResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BankTransferEventListRequest` | `Models/BankTransferEventListRequest.cs` |
| `BankTransferEventListResponse` | `Models/BankTransferEventListResponse.cs` |

### BankTransferEventSync

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BankTransferEventSync(BankTransferEventSyncRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BankTransferEventSyncResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BankTransferEventSyncRequest` | `Models/BankTransferEventSyncRequest.cs` |
| `BankTransferEventSyncResponse` | `Models/BankTransferEventSyncResponse.cs` |

### BankTransferGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BankTransferGet(BankTransferGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BankTransferGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BankTransferGetRequest` | `Models/BankTransferGetRequest.cs` |
| `BankTransferGetResponse` | `Models/BankTransferGetResponse.cs` |

### BankTransferList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BankTransferList(BankTransferListRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BankTransferListResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BankTransferListRequest` | `Models/BankTransferListRequest.cs` |
| `BankTransferListResponse` | `Models/BankTransferListResponse.cs` |

### BankTransferMigrateAccount

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BankTransferMigrateAccount(BankTransferMigrateAccountRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BankTransferMigrateAccountResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BankTransferMigrateAccountRequest` | `Models/BankTransferMigrateAccountRequest.cs` |
| `BankTransferMigrateAccountResponse` | `Models/BankTransferMigrateAccountResponse.cs` |

### BankTransferSweepGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BankTransferSweepGet(BankTransferSweepGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BankTransferSweepGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BankTransferSweepGetRequest` | `Models/BankTransferSweepGetRequest.cs` |
| `BankTransferSweepGetResponse` | `Models/BankTransferSweepGetResponse.cs` |

### BankTransferSweepList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BankTransferSweepList(BankTransferSweepListRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BankTransferSweepListResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BankTransferSweepListRequest` | `Models/BankTransferSweepListRequest.cs` |
| `BankTransferSweepListResponse` | `Models/BankTransferSweepListResponse.cs` |

### BeaconAccountRiskEvaluate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BeaconAccountRiskEvaluate(BeaconAccountRiskEvaluateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BeaconAccountRiskEvaluateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BeaconAccountRiskEvaluateRequest` | `Models/BeaconAccountRiskEvaluateRequest.cs` |
| `BeaconAccountRiskEvaluateResponse` | `Models/BeaconAccountRiskEvaluateResponse.cs` |

### BeaconDuplicateGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BeaconDuplicateGet(BeaconDuplicateGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BeaconDuplicateGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BeaconDuplicateGetRequest` | `Models/BeaconDuplicateGetRequest.cs` |
| `BeaconDuplicateGetResponse` | `Models/BeaconDuplicateGetResponse.cs` |

### BeaconReportCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BeaconReportCreate(BeaconReportCreateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BeaconReportCreateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BeaconReportCreateRequest` | `Models/BeaconReportCreateRequest.cs` |
| `BeaconReportCreateResponse` | `Models/BeaconReportCreateResponse.cs` |

### BeaconReportGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BeaconReportGet(BeaconReportGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BeaconReportGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BeaconReportGetRequest` | `Models/BeaconReportGetRequest.cs` |
| `BeaconReportGetResponse` | `Models/BeaconReportGetResponse.cs` |

### BeaconReportList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BeaconReportList(BeaconReportListRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BeaconReportListResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BeaconReportListRequest` | `Models/BeaconReportListRequest.cs` |
| `BeaconReportListResponse` | `Models/BeaconReportListResponse.cs` |

### BeaconReportSyndicationGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BeaconReportSyndicationGet(BeaconReportSyndicationGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BeaconReportSyndicationGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BeaconReportSyndicationGetRequest` | `Models/BeaconReportSyndicationGetRequest.cs` |
| `BeaconReportSyndicationGetResponse` | `Models/BeaconReportSyndicationGetResponse.cs` |

### BeaconReportSyndicationList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BeaconReportSyndicationList(BeaconReportSyndicationListRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BeaconReportSyndicationListResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BeaconReportSyndicationListRequest` | `Models/BeaconReportSyndicationListRequest.cs` |
| `BeaconReportSyndicationListResponse` | `Models/BeaconReportSyndicationListResponse.cs` |

### BeaconUserAccountInsightsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BeaconUserAccountInsightsGet(BeaconUserAccountInsightsGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BeaconUserAccountInsightsGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BeaconUserAccountInsightsGetRequest` | `Models/BeaconUserAccountInsightsGetRequest.cs` |
| `BeaconUserAccountInsightsGetResponse` | `Models/BeaconUserAccountInsightsGetResponse.cs` |

### BeaconUserCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BeaconUserCreate(BeaconUserCreateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BeaconUserCreateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BeaconUserCreateRequest` | `Models/BeaconUserCreateRequest.cs` |
| `BeaconUserCreateResponse` | `Models/BeaconUserCreateResponse.cs` |

### BeaconUserGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BeaconUserGet(BeaconUserGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BeaconUserGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BeaconUserGetRequest` | `Models/BeaconUserGetRequest.cs` |
| `BeaconUserGetResponse` | `Models/BeaconUserGetResponse.cs` |

### BeaconUserHistoryList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BeaconUserHistoryList(BeaconUserHistoryListRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BeaconUserHistoryListResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BeaconUserHistoryListRequest` | `Models/BeaconUserHistoryListRequest.cs` |
| `BeaconUserHistoryListResponse` | `Models/BeaconUserHistoryListResponse.cs` |

### BeaconUserReview

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BeaconUserReview(BeaconUserReviewRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BeaconUserGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BeaconUserReviewRequest` | `Models/BeaconUserReviewRequest.cs` |
| `BeaconUserGetResponse` | `Models/BeaconUserGetResponse.cs` |

### BeaconUserUpdate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BeaconUserUpdate(BeaconUserUpdateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BeaconUserUpdateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BeaconUserUpdateRequest` | `Models/BeaconUserUpdateRequest.cs` |
| `BeaconUserUpdateResponse` | `Models/BeaconUserUpdateResponse.cs` |

### BetaEwaReportV1Get

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BetaEwaReportV1Get(BetaEwaReportV1GetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BetaEwaReportV1GetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BetaEwaReportV1GetRequest` | `Models/BetaEwaReportV1GetRequest.cs` |
| `BetaEwaReportV1GetResponse` | `Models/BetaEwaReportV1GetResponse.cs` |

### BetaPartnerCustomerV1Create

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BetaPartnerCustomerV1Create(BetaPartnerCustomerV1CreateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BetaPartnerCustomerV1CreateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BetaPartnerCustomerV1CreateRequest` | `Models/BetaPartnerCustomerV1CreateRequest.cs` |
| `BetaPartnerCustomerV1CreateResponse` | `Models/BetaPartnerCustomerV1CreateResponse.cs` |

### BetaPartnerCustomerV1Enable

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BetaPartnerCustomerV1Enable(BetaPartnerCustomerV1EnableRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BetaPartnerCustomerV1EnableResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BetaPartnerCustomerV1EnableRequest` | `Models/BetaPartnerCustomerV1EnableRequest.cs` |
| `BetaPartnerCustomerV1EnableResponse` | `Models/BetaPartnerCustomerV1EnableResponse.cs` |

### BetaPartnerCustomerV1Get

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BetaPartnerCustomerV1Get(BetaPartnerCustomerV1GetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BetaPartnerCustomerV1GetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BetaPartnerCustomerV1GetRequest` | `Models/BetaPartnerCustomerV1GetRequest.cs` |
| `BetaPartnerCustomerV1GetResponse` | `Models/BetaPartnerCustomerV1GetResponse.cs` |

### BetaPartnerCustomerV1Update

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BetaPartnerCustomerV1Update(BetaPartnerCustomerV1UpdateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BetaPartnerCustomerV1UpdateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BetaPartnerCustomerV1UpdateRequest` | `Models/BetaPartnerCustomerV1UpdateRequest.cs` |
| `BetaPartnerCustomerV1UpdateResponse` | `Models/BetaPartnerCustomerV1UpdateResponse.cs` |

### BusinessVerificationCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BusinessVerificationCreate(BusinessVerificationCreateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BusinessVerificationCreateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BusinessVerificationCreateRequest` | `Models/BusinessVerificationCreateRequest.cs` |
| `BusinessVerificationCreateResponse` | `Models/BusinessVerificationCreateResponse.cs` |

### BusinessVerificationGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `BusinessVerificationGet(BusinessVerificationGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `BusinessVerificationGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BusinessVerificationGetRequest` | `Models/BusinessVerificationGetRequest.cs` |
| `BusinessVerificationGetResponse` | `Models/BusinessVerificationGetResponse.cs` |

### CashflowReportGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CashflowReportGet(CashflowReportGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CashflowReportGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CashflowReportGetRequest` | `Models/CashflowReportGetRequest.cs` |
| `CashflowReportGetResponse` | `Models/CashflowReportGetResponse.cs` |

### CashflowReportInsightsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CashflowReportInsightsGet(CashflowReportInsightsGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CashflowReportInsightsGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CashflowReportInsightsGetRequest` | `Models/CashflowReportInsightsGetRequest.cs` |
| `CashflowReportInsightsGetResponse` | `Models/CashflowReportInsightsGetResponse.cs` |

### CashflowReportRefresh

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CashflowReportRefresh(CashflowReportRefreshRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CashflowReportRefreshResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CashflowReportRefreshRequest` | `Models/CashflowReportRefreshRequest.cs` |
| `CashflowReportRefreshResponse` | `Models/CashflowReportRefreshResponse.cs` |

### CashflowReportTransactionsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CashflowReportTransactionsGet(CashflowReportTransactionsGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CashflowReportTransactionsGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CashflowReportTransactionsGetRequest` | `Models/CashflowReportTransactionsGetRequest.cs` |
| `CashflowReportTransactionsGetResponse` | `Models/CashflowReportTransactionsGetResponse.cs` |

### CategoriesGet

- **Signature**: `CategoriesGet(object body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CategoriesGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CategoriesGetResponse` | `Models/CategoriesGetResponse.cs` |

### ConsentEventsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ConsentEventsGet(ConsentEventsGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ConsentEventsGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ConsentEventsGetRequest` | `Models/ConsentEventsGetRequest.cs` |
| `ConsentEventsGetResponse` | `Models/ConsentEventsGetResponse.cs` |

### ConsumerReportPdfGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ConsumerReportPdfGet(ConsumerReportPdfGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ConsumerReportPdfGetRequest` | `Models/ConsumerReportPdfGetRequest.cs` |

### CraCheckReportBaseReportGet

- **Auth**: (`options.ClientId` AND `options.Secret` AND `options.PlaidVersion`) OR `options.Oauth2`
- **Signature**: `CraCheckReportBaseReportGet(CraCheckReportBaseReportGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CraCheckReportBaseReportGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CraCheckReportBaseReportGetRequest` | `Models/CraCheckReportBaseReportGetRequest.cs` |
| `CraCheckReportBaseReportGetResponse` | `Models/CraCheckReportBaseReportGetResponse.cs` |

### CraCheckReportCashflowInsightsGet

- **Auth**: (`options.ClientId` AND `options.Secret` AND `options.PlaidVersion`) OR `options.Oauth2`
- **Signature**: `CraCheckReportCashflowInsightsGet(CraCheckReportCashflowInsightsGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CraCheckReportCashflowInsightsGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CraCheckReportCashflowInsightsGetRequest` | `Models/CraCheckReportCashflowInsightsGetRequest.cs` |
| `CraCheckReportCashflowInsightsGetResponse` | `Models/CraCheckReportCashflowInsightsGetResponse.cs` |

### CraCheckReportCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CraCheckReportCreate(CraCheckReportCreateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CraCheckReportCreateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CraCheckReportCreateRequest` | `Models/CraCheckReportCreateRequest.cs` |
| `CraCheckReportCreateResponse` | `Models/CraCheckReportCreateResponse.cs` |

### CraCheckReportIncomeInsightsGet

- **Auth**: (`options.ClientId` AND `options.Secret` AND `options.PlaidVersion`) OR `options.Oauth2`
- **Signature**: `CraCheckReportIncomeInsightsGet(CraCheckReportIncomeInsightsGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CraCheckReportIncomeInsightsGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CraCheckReportIncomeInsightsGetRequest` | `Models/CraCheckReportIncomeInsightsGetRequest.cs` |
| `CraCheckReportIncomeInsightsGetResponse` | `Models/CraCheckReportIncomeInsightsGetResponse.cs` |

### CraCheckReportLendScoreGet

- **Auth**: (`options.ClientId` AND `options.Secret` AND `options.PlaidVersion`) OR `options.Oauth2`
- **Signature**: `CraCheckReportLendScoreGet(CraCheckReportLendScoreGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CraCheckReportLendScoreGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CraCheckReportLendScoreGetRequest` | `Models/CraCheckReportLendScoreGetRequest.cs` |
| `CraCheckReportLendScoreGetResponse` | `Models/CraCheckReportLendScoreGetResponse.cs` |

### CraCheckReportNetworkInsightsGet

- **Auth**: (`options.ClientId` AND `options.Secret` AND `options.PlaidVersion`) OR `options.Oauth2`
- **Signature**: `CraCheckReportNetworkInsightsGet(CraCheckReportNetworkInsightsGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CraCheckReportNetworkInsightsGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CraCheckReportNetworkInsightsGetRequest` | `Models/CraCheckReportNetworkInsightsGetRequest.cs` |
| `CraCheckReportNetworkInsightsGetResponse` | `Models/CraCheckReportNetworkInsightsGetResponse.cs` |

### CraCheckReportPartnerInsightsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CraCheckReportPartnerInsightsGet(CraCheckReportPartnerInsightsGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CraCheckReportPartnerInsightsGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CraCheckReportPartnerInsightsGetRequest` | `Models/CraCheckReportPartnerInsightsGetRequest.cs` |
| `CraCheckReportPartnerInsightsGetResponse` | `Models/CraCheckReportPartnerInsightsGetResponse.cs` |

### CraCheckReportPdfGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CraCheckReportPdfGet(CraCheckReportPdfGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CraCheckReportPdfGetRequest` | `Models/CraCheckReportPdfGetRequest.cs` |

### CraCheckReportVerificationGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CraCheckReportVerificationGet(CraCheckReportVerificationGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CraCheckReportVerificationGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CraCheckReportVerificationGetRequest` | `Models/CraCheckReportVerificationGetRequest.cs` |
| `CraCheckReportVerificationGetResponse` | `Models/CraCheckReportVerificationGetResponse.cs` |

### CraCheckReportVerificationPdfGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CraCheckReportVerificationPdfGet(CraCheckReportVerificationPdfGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CraCheckReportVerificationPdfGetRequest` | `Models/CraCheckReportVerificationPdfGetRequest.cs` |

### CraCreditProfileReportGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CraCreditProfileReportGet(CraCreditProfileReportGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CraCreditProfileReportGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CraCreditProfileReportGetRequest` | `Models/CraCreditProfileReportGetRequest.cs` |
| `CraCreditProfileReportGetResponse` | `Models/CraCreditProfileReportGetResponse.cs` |

### CraLoansApplicationsRegister

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CraLoansApplicationsRegister(CraLoansApplicationsRegisterRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CraLoansApplicationsRegisterResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CraLoansApplicationsRegisterRequest` | `Models/CraLoansApplicationsRegisterRequest.cs` |
| `CraLoansApplicationsRegisterResponse` | `Models/CraLoansApplicationsRegisterResponse.cs` |

### CraLoansRegister

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CraLoansRegister(CraLoansRegisterRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CraLoansRegisterResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CraLoansRegisterRequest` | `Models/CraLoansRegisterRequest.cs` |
| `CraLoansRegisterResponse` | `Models/CraLoansRegisterResponse.cs` |

### CraLoansUnregister

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CraLoansUnregister(CraLoansUnregisterRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CraLoanUnregisterResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CraLoansUnregisterRequest` | `Models/CraLoansUnregisterRequest.cs` |
| `CraLoanUnregisterResponse` | `Models/CraLoanUnregisterResponse.cs` |

### CraLoansUpdate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CraLoansUpdate(CraLoansUpdateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CraLoansUpdateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CraLoansUpdateRequest` | `Models/CraLoansUpdateRequest.cs` |
| `CraLoansUpdateResponse` | `Models/CraLoansUpdateResponse.cs` |

### CraMonitoringInsightsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CraMonitoringInsightsGet(CraMonitoringInsightsGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CraMonitoringInsightsGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CraMonitoringInsightsGetRequest` | `Models/CraMonitoringInsightsGetRequest.cs` |
| `CraMonitoringInsightsGetResponse` | `Models/CraMonitoringInsightsGetResponse.cs` |

### CraMonitoringInsightsSubscribe

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CraMonitoringInsightsSubscribe(CraMonitoringInsightsSubscribeRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CraMonitoringInsightsSubscribeResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CraMonitoringInsightsSubscribeRequest` | `Models/CraMonitoringInsightsSubscribeRequest.cs` |
| `CraMonitoringInsightsSubscribeResponse` | `Models/CraMonitoringInsightsSubscribeResponse.cs` |

### CraMonitoringInsightsUnsubscribe

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CraMonitoringInsightsUnsubscribe(CraMonitoringInsightsUnsubscribeRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CraMonitoringInsightsUnsubscribeResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CraMonitoringInsightsUnsubscribeRequest` | `Models/CraMonitoringInsightsUnsubscribeRequest.cs` |
| `CraMonitoringInsightsUnsubscribeResponse` | `Models/CraMonitoringInsightsUnsubscribeResponse.cs` |

### CraPartnerInsightsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CraPartnerInsightsGet(CraPartnerInsightsGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CraPartnerInsightsGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CraPartnerInsightsGetRequest` | `Models/CraPartnerInsightsGetRequest.cs` |
| `CraPartnerInsightsGetResponse` | `Models/CraPartnerInsightsGetResponse.cs` |

### CraReportGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CraReportGet(CraReportGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CraReportGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CraReportGetRequest` | `Models/CraReportGetRequest.cs` |
| `CraReportGetResponse` | `Models/CraReportGetResponse.cs` |

### CreatePaymentToken

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CreatePaymentToken(PaymentInitiationPaymentTokenCreateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `PaymentInitiationPaymentTokenCreateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PaymentInitiationPaymentTokenCreateRequest` | `Models/PaymentInitiationPaymentTokenCreateRequest.cs` |
| `PaymentInitiationPaymentTokenCreateResponse` | `Models/PaymentInitiationPaymentTokenCreateResponse.cs` |

### CreditAssetReportFreddieMacGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CreditAssetReportFreddieMacGet(AssetReportFreddieGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AssetReportFreddieGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AssetReportFreddieGetRequest` | `Models/AssetReportFreddieGetRequest.cs` |
| `AssetReportFreddieGetResponse` | `Models/AssetReportFreddieGetResponse.cs` |

### CreditAuditCopyTokenCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CreditAuditCopyTokenCreate(CreditAuditCopyTokenCreateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreditAuditCopyTokenCreateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreditAuditCopyTokenCreateRequest` | `Models/CreditAuditCopyTokenCreateRequest.cs` |
| `CreditAuditCopyTokenCreateResponse` | `Models/CreditAuditCopyTokenCreateResponse.cs` |

### CreditAuditCopyTokenUpdate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CreditAuditCopyTokenUpdate(CreditAuditCopyTokenUpdateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreditAuditCopyTokenUpdateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreditAuditCopyTokenUpdateRequest` | `Models/CreditAuditCopyTokenUpdateRequest.cs` |
| `CreditAuditCopyTokenUpdateResponse` | `Models/CreditAuditCopyTokenUpdateResponse.cs` |

### CreditBankEmploymentGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CreditBankEmploymentGet(CreditBankEmploymentGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreditBankEmploymentGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreditBankEmploymentGetRequest` | `Models/CreditBankEmploymentGetRequest.cs` |
| `CreditBankEmploymentGetResponse` | `Models/CreditBankEmploymentGetResponse.cs` |

### CreditBankIncomeGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CreditBankIncomeGet(CreditBankIncomeGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreditBankIncomeGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreditBankIncomeGetRequest` | `Models/CreditBankIncomeGetRequest.cs` |
| `CreditBankIncomeGetResponse` | `Models/CreditBankIncomeGetResponse.cs` |

### CreditBankIncomePdfGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CreditBankIncomePdfGet(CreditBankIncomePdfGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreditBankIncomePdfGetRequest` | `Models/CreditBankIncomePdfGetRequest.cs` |

### CreditBankIncomeRefresh

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CreditBankIncomeRefresh(CreditBankIncomeRefreshRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreditBankIncomeRefreshResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreditBankIncomeRefreshRequest` | `Models/CreditBankIncomeRefreshRequest.cs` |
| `CreditBankIncomeRefreshResponse` | `Models/CreditBankIncomeRefreshResponse.cs` |

### CreditBankIncomeWebhookUpdate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CreditBankIncomeWebhookUpdate(CreditBankIncomeWebhookUpdateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreditBankIncomeWebhookUpdateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreditBankIncomeWebhookUpdateRequest` | `Models/CreditBankIncomeWebhookUpdateRequest.cs` |
| `CreditBankIncomeWebhookUpdateResponse` | `Models/CreditBankIncomeWebhookUpdateResponse.cs` |

### CreditBankStatementsUploadsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CreditBankStatementsUploadsGet(CreditBankStatementsUploadsGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreditBankStatementsUploadsGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreditBankStatementsUploadsGetRequest` | `Models/CreditBankStatementsUploadsGetRequest.cs` |
| `CreditBankStatementsUploadsGetResponse` | `Models/CreditBankStatementsUploadsGetResponse.cs` |

### CreditEmploymentGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CreditEmploymentGet(CreditEmploymentGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreditEmploymentGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreditEmploymentGetRequest` | `Models/CreditEmploymentGetRequest.cs` |
| `CreditEmploymentGetResponse` | `Models/CreditEmploymentGetResponse.cs` |

### CreditFreddieMacReportsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CreditFreddieMacReportsGet(CreditFreddieMacReportsGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreditFreddieMacReportsGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreditFreddieMacReportsGetRequest` | `Models/CreditFreddieMacReportsGetRequest.cs` |
| `CreditFreddieMacReportsGetResponse` | `Models/CreditFreddieMacReportsGetResponse.cs` |

### CreditPayrollIncomeGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CreditPayrollIncomeGet(CreditPayrollIncomeGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreditPayrollIncomeGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreditPayrollIncomeGetRequest` | `Models/CreditPayrollIncomeGetRequest.cs` |
| `CreditPayrollIncomeGetResponse` | `Models/CreditPayrollIncomeGetResponse.cs` |

### CreditPayrollIncomeParsingConfigUpdate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CreditPayrollIncomeParsingConfigUpdate(CreditPayrollIncomeParsingConfigUpdateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreditPayrollIncomeParsingConfigUpdateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreditPayrollIncomeParsingConfigUpdateRequest` | `Models/CreditPayrollIncomeParsingConfigUpdateRequest.cs` |
| `CreditPayrollIncomeParsingConfigUpdateResponse` | `Models/CreditPayrollIncomeParsingConfigUpdateResponse.cs` |

### CreditPayrollIncomePrecheck

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CreditPayrollIncomePrecheck(CreditPayrollIncomePrecheckRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreditPayrollIncomePrecheckResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreditPayrollIncomePrecheckRequest` | `Models/CreditPayrollIncomePrecheckRequest.cs` |
| `CreditPayrollIncomePrecheckResponse` | `Models/CreditPayrollIncomePrecheckResponse.cs` |

### CreditPayrollIncomeRefresh

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CreditPayrollIncomeRefresh(CreditPayrollIncomeRefreshRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreditPayrollIncomeRefreshResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreditPayrollIncomeRefreshRequest` | `Models/CreditPayrollIncomeRefreshRequest.cs` |
| `CreditPayrollIncomeRefreshResponse` | `Models/CreditPayrollIncomeRefreshResponse.cs` |

### CreditPayrollIncomeRiskSignalsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CreditPayrollIncomeRiskSignalsGet(CreditPayrollIncomeRiskSignalsGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreditPayrollIncomeRiskSignalsGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreditPayrollIncomeRiskSignalsGetRequest` | `Models/CreditPayrollIncomeRiskSignalsGetRequest.cs` |
| `CreditPayrollIncomeRiskSignalsGetResponse` | `Models/CreditPayrollIncomeRiskSignalsGetResponse.cs` |

### CreditRelayCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CreditRelayCreate(CreditRelayCreateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreditRelayCreateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreditRelayCreateRequest` | `Models/CreditRelayCreateRequest.cs` |
| `CreditRelayCreateResponse` | `Models/CreditRelayCreateResponse.cs` |

### CreditRelayGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CreditRelayGet(CreditRelayGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AssetReportGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreditRelayGetRequest` | `Models/CreditRelayGetRequest.cs` |
| `AssetReportGetResponse` | `Models/AssetReportGetResponse.cs` |

### CreditRelayPdfGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CreditRelayPdfGet(CreditRelayPdfGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreditRelayPdfGetRequest` | `Models/CreditRelayPdfGetRequest.cs` |

### CreditRelayRefresh

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CreditRelayRefresh(CreditRelayRefreshRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreditRelayRefreshResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreditRelayRefreshRequest` | `Models/CreditRelayRefreshRequest.cs` |
| `CreditRelayRefreshResponse` | `Models/CreditRelayRefreshResponse.cs` |

### CreditRelayRemove

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CreditRelayRemove(CreditRelayRemoveRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreditRelayRemoveResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreditRelayRemoveRequest` | `Models/CreditRelayRemoveRequest.cs` |
| `CreditRelayRemoveResponse` | `Models/CreditRelayRemoveResponse.cs` |

### CreditReportAuditCopyRemove

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CreditReportAuditCopyRemove(CreditAuditCopyTokenRemoveRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreditAuditCopyTokenRemoveResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreditAuditCopyTokenRemoveRequest` | `Models/CreditAuditCopyTokenRemoveRequest.cs` |
| `CreditAuditCopyTokenRemoveResponse` | `Models/CreditAuditCopyTokenRemoveResponse.cs` |

### CreditSessionsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `CreditSessionsGet(CreditSessionsGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CreditSessionsGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CreditSessionsGetRequest` | `Models/CreditSessionsGetRequest.cs` |
| `CreditSessionsGetResponse` | `Models/CreditSessionsGetResponse.cs` |

### DashboardUserGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `DashboardUserGet(DashboardUserGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DashboardUserGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DashboardUserGetRequest` | `Models/DashboardUserGetRequest.cs` |
| `DashboardUserGetResponse` | `Models/DashboardUserGetResponse.cs` |

### DashboardUserList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `DashboardUserList(DashboardUserListRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DashboardUserListResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DashboardUserListRequest` | `Models/DashboardUserListRequest.cs` |
| `DashboardUserListResponse` | `Models/DashboardUserListResponse.cs` |

### EmployersSearch

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `EmployersSearch(EmployersSearchRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `EmployersSearchResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `EmployersSearchRequest` | `Models/EmployersSearchRequest.cs` |
| `EmployersSearchResponse` | `Models/EmployersSearchResponse.cs` |

### EmploymentVerificationGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `EmploymentVerificationGet(EmploymentVerificationGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `EmploymentVerificationGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `EmploymentVerificationGetRequest` | `Models/EmploymentVerificationGetRequest.cs` |
| `EmploymentVerificationGetResponse` | `Models/EmploymentVerificationGetResponse.cs` |

### FdxConsentsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `FdxConsentsGet(string consentId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `FdxConsentGrant`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `FdxConsentGrant` | `Models/FdxConsentGrant.cs` |

### FdxConsentsList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `FdxConsentsList(string customerId, FdxConsentGrantStatus? status, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `status` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `customerId` ← `customerId`, `status` ← `status`
- **Returns**: `GetConsentsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `FdxConsentGrantStatus` | `Models/Enums/FdxConsentGrantStatus.cs` |
| `GetConsentsResponse` | `Models/GetConsentsResponse.cs` |

### FdxConsentsRevocationGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `FdxConsentsRevocationGet(string consentId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `FdxConsentRevocations`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `FdxConsentRevocations` | `Models/FdxConsentRevocations.cs` |

### FdxConsentsRevoke

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `FdxConsentsRevoke(string consentId, FdxConsentRevocation body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `FdxConsentRevocation` | `Models/FdxConsentRevocation.cs` |

### FdxNotifications

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `FdxNotifications(FdxNotificationEntity body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `FdxNotificationEntity` | `Models/FdxNotificationEntity.cs` |

### GetRecipient

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `GetRecipient(string recipientId, string? oauthStateId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `oauthStateId` — nullable, no default → **must pass explicitly**
- **Returns**: `FdxRecipientMetadata`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `FdxRecipientMetadata` | `Models/FdxRecipientMetadata.cs` |

### GetRecipients

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `GetRecipients(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GetRecipientsResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetRecipientsResponse` | `Models/GetRecipientsResponse.cs` |

### IdentityDocumentsUploadsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `IdentityDocumentsUploadsGet(IdentityDocumentsUploadsGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IdentityDocumentsUploadsGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `IdentityDocumentsUploadsGetRequest` | `Models/IdentityDocumentsUploadsGetRequest.cs` |
| `IdentityDocumentsUploadsGetResponse` | `Models/IdentityDocumentsUploadsGetResponse.cs` |

### IdentityGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `IdentityGet(IdentityGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IdentityGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `IdentityGetRequest` | `Models/IdentityGetRequest.cs` |
| `IdentityGetResponse` | `Models/IdentityGetResponse.cs` |

### IdentityMatch

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `IdentityMatch(IdentityMatchRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IdentityMatchResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `IdentityMatchRequest` | `Models/IdentityMatchRequest.cs` |
| `IdentityMatchResponse` | `Models/IdentityMatchResponse.cs` |

### IdentityRefresh

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `IdentityRefresh(IdentityRefreshRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IdentityRefreshResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `IdentityRefreshRequest` | `Models/IdentityRefreshRequest.cs` |
| `IdentityRefreshResponse` | `Models/IdentityRefreshResponse.cs` |

### IdentityVerificationAutofillCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `IdentityVerificationAutofillCreate(IdentityVerificationAutofillCreateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IdentityVerificationAutofillCreateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `IdentityVerificationAutofillCreateRequest` | `Models/IdentityVerificationAutofillCreateRequest.cs` |
| `IdentityVerificationAutofillCreateResponse` | `Models/IdentityVerificationAutofillCreateResponse.cs` |

### IdentityVerificationCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `IdentityVerificationCreate(IdentityVerificationCreateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IdentityVerificationCreateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `IdentityVerificationCreateRequest` | `Models/IdentityVerificationCreateRequest.cs` |
| `IdentityVerificationCreateResponse` | `Models/IdentityVerificationCreateResponse.cs` |

### IdentityVerificationGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `IdentityVerificationGet(IdentityVerificationGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IdentityVerificationGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `IdentityVerificationGetRequest` | `Models/IdentityVerificationGetRequest.cs` |
| `IdentityVerificationGetResponse` | `Models/IdentityVerificationGetResponse.cs` |

### IdentityVerificationList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `IdentityVerificationList(IdentityVerificationListRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IdentityVerificationListResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `IdentityVerificationListRequest` | `Models/IdentityVerificationListRequest.cs` |
| `IdentityVerificationListResponse` | `Models/IdentityVerificationListResponse.cs` |

### IdentityVerificationRetry

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `IdentityVerificationRetry(IdentityVerificationRetryRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IdentityVerificationRetryResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `IdentityVerificationRetryRequest` | `Models/IdentityVerificationRetryRequest.cs` |
| `IdentityVerificationRetryResponse` | `Models/IdentityVerificationRetryResponse.cs` |

### IncomeVerificationCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `IncomeVerificationCreate(IncomeVerificationCreateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IncomeVerificationCreateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `IncomeVerificationCreateRequest` | `Models/IncomeVerificationCreateRequest.cs` |
| `IncomeVerificationCreateResponse` | `Models/IncomeVerificationCreateResponse.cs` |

### IncomeVerificationDocumentsDownload

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `IncomeVerificationDocumentsDownload(IncomeVerificationDocumentsDownloadRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `IncomeVerificationDocumentsDownloadRequest` | `Models/IncomeVerificationDocumentsDownloadRequest.cs` |

### IncomeVerificationPaystubsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `IncomeVerificationPaystubsGet(IncomeVerificationPaystubsGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IncomeVerificationPaystubsGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `IncomeVerificationPaystubsGetRequest` | `Models/IncomeVerificationPaystubsGetRequest.cs` |
| `IncomeVerificationPaystubsGetResponse` | `Models/IncomeVerificationPaystubsGetResponse.cs` |

### IncomeVerificationPrecheck

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `IncomeVerificationPrecheck(IncomeVerificationPrecheckRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IncomeVerificationPrecheckResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `IncomeVerificationPrecheckRequest` | `Models/IncomeVerificationPrecheckRequest.cs` |
| `IncomeVerificationPrecheckResponse` | `Models/IncomeVerificationPrecheckResponse.cs` |

### IncomeVerificationTaxformsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `IncomeVerificationTaxformsGet(IncomeVerificationTaxformsGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IncomeVerificationTaxformsGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `IncomeVerificationTaxformsGetRequest` | `Models/IncomeVerificationTaxformsGetRequest.cs` |
| `IncomeVerificationTaxformsGetResponse` | `Models/IncomeVerificationTaxformsGetResponse.cs` |

### InstitutionsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `InstitutionsGet(InstitutionsGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `InstitutionsGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `InstitutionsGetRequest` | `Models/InstitutionsGetRequest.cs` |
| `InstitutionsGetResponse` | `Models/InstitutionsGetResponse.cs` |

### InstitutionsGetById

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `InstitutionsGetById(InstitutionsGetByIdRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `InstitutionsGetByIdResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `InstitutionsGetByIdRequest` | `Models/InstitutionsGetByIdRequest.cs` |
| `InstitutionsGetByIdResponse` | `Models/InstitutionsGetByIdResponse.cs` |

### InstitutionsSearch

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `InstitutionsSearch(InstitutionsSearchRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `InstitutionsSearchResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `InstitutionsSearchRequest` | `Models/InstitutionsSearchRequest.cs` |
| `InstitutionsSearchResponse` | `Models/InstitutionsSearchResponse.cs` |

### InvestmentsAuthGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `InvestmentsAuthGet(InvestmentsAuthGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `InvestmentsAuthGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `InvestmentsAuthGetRequest` | `Models/InvestmentsAuthGetRequest.cs` |
| `InvestmentsAuthGetResponse` | `Models/InvestmentsAuthGetResponse.cs` |

### InvestmentsHoldingsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `InvestmentsHoldingsGet(InvestmentsHoldingsGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `InvestmentsHoldingsGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `InvestmentsHoldingsGetRequest` | `Models/InvestmentsHoldingsGetRequest.cs` |
| `InvestmentsHoldingsGetResponse` | `Models/InvestmentsHoldingsGetResponse.cs` |

### InvestmentsRefresh

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `InvestmentsRefresh(InvestmentsRefreshRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `InvestmentsRefreshResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `InvestmentsRefreshRequest` | `Models/InvestmentsRefreshRequest.cs` |
| `InvestmentsRefreshResponse` | `Models/InvestmentsRefreshResponse.cs` |

### InvestmentsTransactionsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `InvestmentsTransactionsGet(InvestmentsTransactionsGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `InvestmentsTransactionsGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `InvestmentsTransactionsGetRequest` | `Models/InvestmentsTransactionsGetRequest.cs` |
| `InvestmentsTransactionsGetResponse` | `Models/InvestmentsTransactionsGetResponse.cs` |

### IssuesGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `IssuesGet(IssuesGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IssuesGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `IssuesGetRequest` | `Models/IssuesGetRequest.cs` |
| `IssuesGetResponse` | `Models/IssuesGetResponse.cs` |

### IssuesSearch

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `IssuesSearch(IssuesSearchRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IssuesSearchResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `IssuesSearchRequest` | `Models/IssuesSearchRequest.cs` |
| `IssuesSearchResponse` | `Models/IssuesSearchResponse.cs` |

### IssuesSubscribe

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `IssuesSubscribe(IssuesSubscribeRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IssuesSubscribeResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `IssuesSubscribeRequest` | `Models/IssuesSubscribeRequest.cs` |
| `IssuesSubscribeResponse` | `Models/IssuesSubscribeResponse.cs` |

### ItemAccessTokenInvalidate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ItemAccessTokenInvalidate(ItemAccessTokenInvalidateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ItemAccessTokenInvalidateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ItemAccessTokenInvalidateRequest` | `Models/ItemAccessTokenInvalidateRequest.cs` |
| `ItemAccessTokenInvalidateResponse` | `Models/ItemAccessTokenInvalidateResponse.cs` |

### ItemActivityList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ItemActivityList(ItemActivityListRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ItemActivityListResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ItemActivityListRequest` | `Models/ItemActivityListRequest.cs` |
| `ItemActivityListResponse` | `Models/ItemActivityListResponse.cs` |

### ItemApplicationList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ItemApplicationList(ItemApplicationListRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ItemApplicationListResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ItemApplicationListRequest` | `Models/ItemApplicationListRequest.cs` |
| `ItemApplicationListResponse` | `Models/ItemApplicationListResponse.cs` |

### ItemApplicationScopesUpdate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ItemApplicationScopesUpdate(ItemApplicationScopesUpdateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ItemApplicationScopesUpdateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ItemApplicationScopesUpdateRequest` | `Models/ItemApplicationScopesUpdateRequest.cs` |
| `ItemApplicationScopesUpdateResponse` | `Models/ItemApplicationScopesUpdateResponse.cs` |

### ItemApplicationUnlink

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ItemApplicationUnlink(ItemApplicationUnlinkRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ItemApplicationUnlinkResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ItemApplicationUnlinkRequest` | `Models/ItemApplicationUnlinkRequest.cs` |
| `ItemApplicationUnlinkResponse` | `Models/ItemApplicationUnlinkResponse.cs` |

### ItemCreatePublicToken

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ItemCreatePublicToken(ItemPublicTokenCreateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ItemPublicTokenCreateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ItemPublicTokenCreateRequest` | `Models/ItemPublicTokenCreateRequest.cs` |
| `ItemPublicTokenCreateResponse` | `Models/ItemPublicTokenCreateResponse.cs` |

### ItemGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ItemGet(ItemGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ItemGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ItemGetRequest` | `Models/ItemGetRequest.cs` |
| `ItemGetResponse` | `Models/ItemGetResponse.cs` |

### ItemImport

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ItemImport(ItemImportRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ItemImportResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ItemImportRequest` | `Models/ItemImportRequest.cs` |
| `ItemImportResponse` | `Models/ItemImportResponse.cs` |

### ItemProductsTerminate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ItemProductsTerminate(ItemProductsTerminateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ItemProductsTerminateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ItemProductsTerminateRequest` | `Models/ItemProductsTerminateRequest.cs` |
| `ItemProductsTerminateResponse` | `Models/ItemProductsTerminateResponse.cs` |

### ItemPublicTokenExchange

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ItemPublicTokenExchange(ItemPublicTokenExchangeRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ItemPublicTokenExchangeResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ItemPublicTokenExchangeRequest` | `Models/ItemPublicTokenExchangeRequest.cs` |
| `ItemPublicTokenExchangeResponse` | `Models/ItemPublicTokenExchangeResponse.cs` |

### ItemRemove

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ItemRemove(ItemRemoveRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ItemRemoveResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ItemRemoveRequest` | `Models/ItemRemoveRequest.cs` |
| `ItemRemoveResponse` | `Models/ItemRemoveResponse.cs` |

### ItemWebhookUpdate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ItemWebhookUpdate(ItemWebhookUpdateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ItemWebhookUpdateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ItemWebhookUpdateRequest` | `Models/ItemWebhookUpdateRequest.cs` |
| `ItemWebhookUpdateResponse` | `Models/ItemWebhookUpdateResponse.cs` |

### LiabilitiesGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `LiabilitiesGet(LiabilitiesGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `LiabilitiesGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `LiabilitiesGetRequest` | `Models/LiabilitiesGetRequest.cs` |
| `LiabilitiesGetResponse` | `Models/LiabilitiesGetResponse.cs` |

### LinkDeliveryCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `LinkDeliveryCreate(LinkDeliveryCreateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `LinkDeliveryCreateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `LinkDeliveryCreateRequest` | `Models/LinkDeliveryCreateRequest.cs` |
| `LinkDeliveryCreateResponse` | `Models/LinkDeliveryCreateResponse.cs` |

### LinkDeliveryGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `LinkDeliveryGet(LinkDeliveryGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `LinkDeliveryGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `LinkDeliveryGetRequest` | `Models/LinkDeliveryGetRequest.cs` |
| `LinkDeliveryGetResponse` | `Models/LinkDeliveryGetResponse.cs` |

### LinkOauthCorrelationIdExchange

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `LinkOauthCorrelationIdExchange(LinkOAuthCorrelationIdExchangeRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `LinkOAuthCorrelationIdExchangeResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `LinkOAuthCorrelationIdExchangeRequest` | `Models/LinkOAuthCorrelationIdExchangeRequest.cs` |
| `LinkOAuthCorrelationIdExchangeResponse` | `Models/LinkOAuthCorrelationIdExchangeResponse.cs` |

### LinkTokenCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `LinkTokenCreate(LinkTokenCreateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `LinkTokenCreateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `LinkTokenCreateRequest` | `Models/LinkTokenCreateRequest.cs` |
| `LinkTokenCreateResponse` | `Models/LinkTokenCreateResponse.cs` |

### LinkTokenGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `LinkTokenGet(LinkTokenGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `LinkTokenGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `LinkTokenGetRequest` | `Models/LinkTokenGetRequest.cs` |
| `LinkTokenGetResponse` | `Models/LinkTokenGetResponse.cs` |

### NetworkStatusGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `NetworkStatusGet(NetworkStatusGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `NetworkStatusGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `NetworkStatusGetRequest` | `Models/NetworkStatusGetRequest.cs` |
| `NetworkStatusGetResponse` | `Models/NetworkStatusGetResponse.cs` |

### OauthIntrospect

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `OauthIntrospect(OAuthIntrospectRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `OAuthIntrospectResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `OAuthIntrospectRequest` | `Models/OAuthIntrospectRequest.cs` |
| `OAuthIntrospectResponse` | `Models/OAuthIntrospectResponse.cs` |

### OauthRevoke

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `OauthRevoke(OAuthRevokeRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `OAuthRevokeResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `OAuthRevokeRequest` | `Models/OAuthRevokeRequest.cs` |
| `OAuthRevokeResponse` | `Models/OAuthRevokeResponse.cs` |

### OauthToken

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `OauthToken(OAuthTokenRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `OAuthTokenResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `OAuthTokenRequest` | `Models/OAuthTokenRequest.cs` |
| `OAuthTokenResponse` | `Models/OAuthTokenResponse.cs` |

### PartnerCustomerCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `PartnerCustomerCreate(PartnerCustomerCreateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `PartnerCustomerCreateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PartnerCustomerCreateRequest` | `Models/PartnerCustomerCreateRequest.cs` |
| `PartnerCustomerCreateResponse` | `Models/PartnerCustomerCreateResponse.cs` |

### PartnerCustomerEnable

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `PartnerCustomerEnable(PartnerCustomerEnableRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `PartnerCustomerEnableResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PartnerCustomerEnableRequest` | `Models/PartnerCustomerEnableRequest.cs` |
| `PartnerCustomerEnableResponse` | `Models/PartnerCustomerEnableResponse.cs` |

### PartnerCustomerGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `PartnerCustomerGet(PartnerCustomerGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `PartnerCustomerGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PartnerCustomerGetRequest` | `Models/PartnerCustomerGetRequest.cs` |
| `PartnerCustomerGetResponse` | `Models/PartnerCustomerGetResponse.cs` |

### PartnerCustomerOauthInstitutionsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `PartnerCustomerOauthInstitutionsGet(PartnerCustomerOAuthInstitutionsGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `PartnerCustomerOAuthInstitutionsGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PartnerCustomerOAuthInstitutionsGetRequest` | `Models/PartnerCustomerOAuthInstitutionsGetRequest.cs` |
| `PartnerCustomerOAuthInstitutionsGetResponse` | `Models/PartnerCustomerOAuthInstitutionsGetResponse.cs` |

### PartnerCustomerRemove

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `PartnerCustomerRemove(PartnerCustomerRemoveRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `PartnerCustomerRemoveResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PartnerCustomerRemoveRequest` | `Models/PartnerCustomerRemoveRequest.cs` |
| `PartnerCustomerRemoveResponse` | `Models/PartnerCustomerRemoveResponse.cs` |

### PaymentInitiationConsentCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `PaymentInitiationConsentCreate(PaymentInitiationConsentCreateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `PaymentInitiationConsentCreateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PaymentInitiationConsentCreateRequest` | `Models/PaymentInitiationConsentCreateRequest.cs` |
| `PaymentInitiationConsentCreateResponse` | `Models/PaymentInitiationConsentCreateResponse.cs` |

### PaymentInitiationConsentGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `PaymentInitiationConsentGet(PaymentInitiationConsentGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `PaymentInitiationConsentGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PaymentInitiationConsentGetRequest` | `Models/PaymentInitiationConsentGetRequest.cs` |
| `PaymentInitiationConsentGetResponse` | `Models/PaymentInitiationConsentGetResponse.cs` |

### PaymentInitiationConsentPaymentExecute

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `PaymentInitiationConsentPaymentExecute(PaymentInitiationConsentPaymentExecuteRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `PaymentInitiationConsentPaymentExecuteResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PaymentInitiationConsentPaymentExecuteRequest` | `Models/PaymentInitiationConsentPaymentExecuteRequest.cs` |
| `PaymentInitiationConsentPaymentExecuteResponse` | `Models/PaymentInitiationConsentPaymentExecuteResponse.cs` |

### PaymentInitiationConsentRevoke

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `PaymentInitiationConsentRevoke(PaymentInitiationConsentRevokeRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `PaymentInitiationConsentRevokeResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PaymentInitiationConsentRevokeRequest` | `Models/PaymentInitiationConsentRevokeRequest.cs` |
| `PaymentInitiationConsentRevokeResponse` | `Models/PaymentInitiationConsentRevokeResponse.cs` |

### PaymentInitiationPaymentCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `PaymentInitiationPaymentCreate(PaymentInitiationPaymentCreateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `PaymentInitiationPaymentCreateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PaymentInitiationPaymentCreateRequest` | `Models/PaymentInitiationPaymentCreateRequest.cs` |
| `PaymentInitiationPaymentCreateResponse` | `Models/PaymentInitiationPaymentCreateResponse.cs` |

### PaymentInitiationPaymentGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `PaymentInitiationPaymentGet(PaymentInitiationPaymentGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `PaymentInitiationPaymentGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PaymentInitiationPaymentGetRequest` | `Models/PaymentInitiationPaymentGetRequest.cs` |
| `PaymentInitiationPaymentGetResponse` | `Models/PaymentInitiationPaymentGetResponse.cs` |

### PaymentInitiationPaymentList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `PaymentInitiationPaymentList(PaymentInitiationPaymentListRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `PaymentInitiationPaymentListResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PaymentInitiationPaymentListRequest` | `Models/PaymentInitiationPaymentListRequest.cs` |
| `PaymentInitiationPaymentListResponse` | `Models/PaymentInitiationPaymentListResponse.cs` |

### PaymentInitiationPaymentReverse

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `PaymentInitiationPaymentReverse(PaymentInitiationPaymentReverseRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `PaymentInitiationPaymentReverseResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PaymentInitiationPaymentReverseRequest` | `Models/PaymentInitiationPaymentReverseRequest.cs` |
| `PaymentInitiationPaymentReverseResponse` | `Models/PaymentInitiationPaymentReverseResponse.cs` |

### PaymentInitiationRecipientCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `PaymentInitiationRecipientCreate(PaymentInitiationRecipientCreateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `PaymentInitiationRecipientCreateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PaymentInitiationRecipientCreateRequest` | `Models/PaymentInitiationRecipientCreateRequest.cs` |
| `PaymentInitiationRecipientCreateResponse` | `Models/PaymentInitiationRecipientCreateResponse.cs` |

### PaymentInitiationRecipientGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `PaymentInitiationRecipientGet(PaymentInitiationRecipientGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `PaymentInitiationRecipientGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PaymentInitiationRecipientGetRequest` | `Models/PaymentInitiationRecipientGetRequest.cs` |
| `PaymentInitiationRecipientGetResponse` | `Models/PaymentInitiationRecipientGetResponse.cs` |

### PaymentInitiationRecipientList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `PaymentInitiationRecipientList(PaymentInitiationRecipientListRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `PaymentInitiationRecipientListResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PaymentInitiationRecipientListRequest` | `Models/PaymentInitiationRecipientListRequest.cs` |
| `PaymentInitiationRecipientListResponse` | `Models/PaymentInitiationRecipientListResponse.cs` |

### PaymentProfileCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `PaymentProfileCreate(PaymentProfileCreateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `PaymentProfileCreateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PaymentProfileCreateRequest` | `Models/PaymentProfileCreateRequest.cs` |
| `PaymentProfileCreateResponse` | `Models/PaymentProfileCreateResponse.cs` |

### PaymentProfileGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `PaymentProfileGet(PaymentProfileGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `PaymentProfileGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PaymentProfileGetRequest` | `Models/PaymentProfileGetRequest.cs` |
| `PaymentProfileGetResponse` | `Models/PaymentProfileGetResponse.cs` |

### PaymentProfileRemove

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `PaymentProfileRemove(PaymentProfileRemoveRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `PaymentProfileRemoveResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PaymentProfileRemoveRequest` | `Models/PaymentProfileRemoveRequest.cs` |
| `PaymentProfileRemoveResponse` | `Models/PaymentProfileRemoveResponse.cs` |

### ProcessorAccountGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProcessorAccountGet(ProcessorAccountGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ProcessorAccountGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorAccountGetRequest` | `Models/ProcessorAccountGetRequest.cs` |
| `ProcessorAccountGetResponse` | `Models/ProcessorAccountGetResponse.cs` |

### ProcessorApexProcessorTokenCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProcessorApexProcessorTokenCreate(ProcessorApexProcessorTokenCreateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ProcessorTokenCreateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorApexProcessorTokenCreateRequest` | `Models/ProcessorApexProcessorTokenCreateRequest.cs` |
| `ProcessorTokenCreateResponse` | `Models/ProcessorTokenCreateResponse.cs` |

### ProcessorAuthGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProcessorAuthGet(ProcessorAuthGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ProcessorAuthGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorAuthGetRequest` | `Models/ProcessorAuthGetRequest.cs` |
| `ProcessorAuthGetResponse` | `Models/ProcessorAuthGetResponse.cs` |

### ProcessorBalanceGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProcessorBalanceGet(ProcessorBalanceGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ProcessorBalanceGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorBalanceGetRequest` | `Models/ProcessorBalanceGetRequest.cs` |
| `ProcessorBalanceGetResponse` | `Models/ProcessorBalanceGetResponse.cs` |

### ProcessorBankTransferCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProcessorBankTransferCreate(ProcessorBankTransferCreateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ProcessorBankTransferCreateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorBankTransferCreateRequest` | `Models/ProcessorBankTransferCreateRequest.cs` |
| `ProcessorBankTransferCreateResponse` | `Models/ProcessorBankTransferCreateResponse.cs` |

### ProcessorIdentityGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProcessorIdentityGet(ProcessorIdentityGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ProcessorIdentityGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorIdentityGetRequest` | `Models/ProcessorIdentityGetRequest.cs` |
| `ProcessorIdentityGetResponse` | `Models/ProcessorIdentityGetResponse.cs` |

### ProcessorIdentityMatch

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProcessorIdentityMatch(ProcessorIdentityMatchRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ProcessorIdentityMatchResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorIdentityMatchRequest` | `Models/ProcessorIdentityMatchRequest.cs` |
| `ProcessorIdentityMatchResponse` | `Models/ProcessorIdentityMatchResponse.cs` |

### ProcessorInvestmentsAuthGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProcessorInvestmentsAuthGet(ProcessorInvestmentsAuthGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ProcessorInvestmentsAuthGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorInvestmentsAuthGetRequest` | `Models/ProcessorInvestmentsAuthGetRequest.cs` |
| `ProcessorInvestmentsAuthGetResponse` | `Models/ProcessorInvestmentsAuthGetResponse.cs` |

### ProcessorInvestmentsHoldingsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProcessorInvestmentsHoldingsGet(ProcessorInvestmentsHoldingsGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ProcessorInvestmentsHoldingsGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorInvestmentsHoldingsGetRequest` | `Models/ProcessorInvestmentsHoldingsGetRequest.cs` |
| `ProcessorInvestmentsHoldingsGetResponse` | `Models/ProcessorInvestmentsHoldingsGetResponse.cs` |

### ProcessorInvestmentsTransactionsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProcessorInvestmentsTransactionsGet(ProcessorInvestmentsTransactionsGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ProcessorInvestmentsTransactionsGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorInvestmentsTransactionsGetRequest` | `Models/ProcessorInvestmentsTransactionsGetRequest.cs` |
| `ProcessorInvestmentsTransactionsGetResponse` | `Models/ProcessorInvestmentsTransactionsGetResponse.cs` |

### ProcessorLiabilitiesGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProcessorLiabilitiesGet(ProcessorLiabilitiesGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ProcessorLiabilitiesGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorLiabilitiesGetRequest` | `Models/ProcessorLiabilitiesGetRequest.cs` |
| `ProcessorLiabilitiesGetResponse` | `Models/ProcessorLiabilitiesGetResponse.cs` |

### ProcessorSignalDecisionReport

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProcessorSignalDecisionReport(ProcessorSignalDecisionReportRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ProcessorSignalDecisionReportResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorSignalDecisionReportRequest` | `Models/ProcessorSignalDecisionReportRequest.cs` |
| `ProcessorSignalDecisionReportResponse` | `Models/ProcessorSignalDecisionReportResponse.cs` |

### ProcessorSignalEvaluate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProcessorSignalEvaluate(ProcessorSignalEvaluateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ProcessorSignalEvaluateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorSignalEvaluateRequest` | `Models/ProcessorSignalEvaluateRequest.cs` |
| `ProcessorSignalEvaluateResponse` | `Models/ProcessorSignalEvaluateResponse.cs` |

### ProcessorSignalPrepare

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProcessorSignalPrepare(ProcessorSignalPrepareRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ProcessorSignalPrepareResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorSignalPrepareRequest` | `Models/ProcessorSignalPrepareRequest.cs` |
| `ProcessorSignalPrepareResponse` | `Models/ProcessorSignalPrepareResponse.cs` |

### ProcessorSignalReturnReport

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProcessorSignalReturnReport(ProcessorSignalReturnReportRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ProcessorSignalReturnReportResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorSignalReturnReportRequest` | `Models/ProcessorSignalReturnReportRequest.cs` |
| `ProcessorSignalReturnReportResponse` | `Models/ProcessorSignalReturnReportResponse.cs` |

### ProcessorStripeBankAccountTokenCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProcessorStripeBankAccountTokenCreate(ProcessorStripeBankAccountTokenCreateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ProcessorStripeBankAccountTokenCreateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorStripeBankAccountTokenCreateRequest` | `Models/ProcessorStripeBankAccountTokenCreateRequest.cs` |
| `ProcessorStripeBankAccountTokenCreateResponse` | `Models/ProcessorStripeBankAccountTokenCreateResponse.cs` |

### ProcessorTokenCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProcessorTokenCreate(ProcessorTokenCreateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ProcessorTokenCreateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorTokenCreateRequest` | `Models/ProcessorTokenCreateRequest.cs` |
| `ProcessorTokenCreateResponse` | `Models/ProcessorTokenCreateResponse.cs` |

### ProcessorTokenPermissionsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProcessorTokenPermissionsGet(ProcessorTokenPermissionsGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ProcessorTokenPermissionsGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorTokenPermissionsGetRequest` | `Models/ProcessorTokenPermissionsGetRequest.cs` |
| `ProcessorTokenPermissionsGetResponse` | `Models/ProcessorTokenPermissionsGetResponse.cs` |

### ProcessorTokenPermissionsSet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProcessorTokenPermissionsSet(ProcessorTokenPermissionsSetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ProcessorTokenPermissionsSetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorTokenPermissionsSetRequest` | `Models/ProcessorTokenPermissionsSetRequest.cs` |
| `ProcessorTokenPermissionsSetResponse` | `Models/ProcessorTokenPermissionsSetResponse.cs` |

### ProcessorTokenWebhookUpdate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProcessorTokenWebhookUpdate(ProcessorTokenWebhookUpdateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ProcessorTokenWebhookUpdateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorTokenWebhookUpdateRequest` | `Models/ProcessorTokenWebhookUpdateRequest.cs` |
| `ProcessorTokenWebhookUpdateResponse` | `Models/ProcessorTokenWebhookUpdateResponse.cs` |

### ProcessorTransactionsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProcessorTransactionsGet(ProcessorTransactionsGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ProcessorTransactionsGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorTransactionsGetRequest` | `Models/ProcessorTransactionsGetRequest.cs` |
| `ProcessorTransactionsGetResponse` | `Models/ProcessorTransactionsGetResponse.cs` |

### ProcessorTransactionsRecurringGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProcessorTransactionsRecurringGet(ProcessorTransactionsRecurringGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ProcessorTransactionsRecurringGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorTransactionsRecurringGetRequest` | `Models/ProcessorTransactionsRecurringGetRequest.cs` |
| `ProcessorTransactionsRecurringGetResponse` | `Models/ProcessorTransactionsRecurringGetResponse.cs` |

### ProcessorTransactionsRefresh

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProcessorTransactionsRefresh(ProcessorTransactionsRefreshRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ProcessorTransactionsRefreshResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorTransactionsRefreshRequest` | `Models/ProcessorTransactionsRefreshRequest.cs` |
| `ProcessorTransactionsRefreshResponse` | `Models/ProcessorTransactionsRefreshResponse.cs` |

### ProcessorTransactionsSync

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProcessorTransactionsSync(ProcessorTransactionsSyncRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ProcessorTransactionsSyncResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProcessorTransactionsSyncRequest` | `Models/ProcessorTransactionsSyncRequest.cs` |
| `ProcessorTransactionsSyncResponse` | `Models/ProcessorTransactionsSyncResponse.cs` |

### ProfileNetworkStatusGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProfileNetworkStatusGet(ProfileNetworkStatusGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ProfileNetworkStatusGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProfileNetworkStatusGetRequest` | `Models/ProfileNetworkStatusGetRequest.cs` |
| `ProfileNetworkStatusGetResponse` | `Models/ProfileNetworkStatusGetResponse.cs` |

### ProtectCompute

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProtectCompute(ProtectComputeRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ProtectComputeResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProtectComputeRequest` | `Models/ProtectComputeRequest.cs` |
| `ProtectComputeResponse` | `Models/ProtectComputeResponse.cs` |

### ProtectEventGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProtectEventGet(ProtectEventGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ProtectEventGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProtectEventGetRequest` | `Models/ProtectEventGetRequest.cs` |
| `ProtectEventGetResponse` | `Models/ProtectEventGetResponse.cs` |

### ProtectEventSend

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProtectEventSend(ProtectEventSendRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ProtectEventSendResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProtectEventSendRequest` | `Models/ProtectEventSendRequest.cs` |
| `ProtectEventSendResponse` | `Models/ProtectEventSendResponse.cs` |

### ProtectReportCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProtectReportCreate(ProtectReportCreateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ProtectReportCreateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProtectReportCreateRequest` | `Models/ProtectReportCreateRequest.cs` |
| `ProtectReportCreateResponse` | `Models/ProtectReportCreateResponse.cs` |

### ProtectUserInsightsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `ProtectUserInsightsGet(ProtectUserInsightsGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ProtectUserInsightsGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ProtectUserInsightsGetRequest` | `Models/ProtectUserInsightsGetRequest.cs` |
| `ProtectUserInsightsGetResponse` | `Models/ProtectUserInsightsGetResponse.cs` |

### SandboxBankIncomeFireWebhook

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxBankIncomeFireWebhook(SandboxBankIncomeFireWebhookRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SandboxBankIncomeFireWebhookResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxBankIncomeFireWebhookRequest` | `Models/SandboxBankIncomeFireWebhookRequest.cs` |
| `SandboxBankIncomeFireWebhookResponse` | `Models/SandboxBankIncomeFireWebhookResponse.cs` |

### SandboxBankTransferFireWebhook

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxBankTransferFireWebhook(SandboxBankTransferFireWebhookRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SandboxBankTransferFireWebhookResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxBankTransferFireWebhookRequest` | `Models/SandboxBankTransferFireWebhookRequest.cs` |
| `SandboxBankTransferFireWebhookResponse` | `Models/SandboxBankTransferFireWebhookResponse.cs` |

### SandboxBankTransferSimulate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxBankTransferSimulate(SandboxBankTransferSimulateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SandboxBankTransferSimulateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxBankTransferSimulateRequest` | `Models/SandboxBankTransferSimulateRequest.cs` |
| `SandboxBankTransferSimulateResponse` | `Models/SandboxBankTransferSimulateResponse.cs` |

### SandboxCraCashflowUpdatesUpdate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxCraCashflowUpdatesUpdate(SandboxCraCashflowUpdatesUpdateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SandboxCraCashflowUpdatesUpdateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxCraCashflowUpdatesUpdateRequest` | `Models/SandboxCraCashflowUpdatesUpdateRequest.cs` |
| `SandboxCraCashflowUpdatesUpdateResponse` | `Models/SandboxCraCashflowUpdatesUpdateResponse.cs` |

### SandboxFdxConsentSeed

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxFdxConsentSeed(SandboxFdxConsentSeedRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SandboxFdxConsentSeedResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxFdxConsentSeedRequest` | `Models/SandboxFdxConsentSeedRequest.cs` |
| `SandboxFdxConsentSeedResponse` | `Models/SandboxFdxConsentSeedResponse.cs` |

### SandboxIncomeFireWebhook

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxIncomeFireWebhook(SandboxIncomeFireWebhookRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SandboxIncomeFireWebhookResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxIncomeFireWebhookRequest` | `Models/SandboxIncomeFireWebhookRequest.cs` |
| `SandboxIncomeFireWebhookResponse` | `Models/SandboxIncomeFireWebhookResponse.cs` |

### SandboxItemApplicationSeed

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxItemApplicationSeed(SandboxItemApplicationSeedRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SandboxItemApplicationSeedResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxItemApplicationSeedRequest` | `Models/SandboxItemApplicationSeedRequest.cs` |
| `SandboxItemApplicationSeedResponse` | `Models/SandboxItemApplicationSeedResponse.cs` |

### SandboxItemFireWebhook

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxItemFireWebhook(SandboxItemFireWebhookRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SandboxItemFireWebhookResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxItemFireWebhookRequest` | `Models/SandboxItemFireWebhookRequest.cs` |
| `SandboxItemFireWebhookResponse` | `Models/SandboxItemFireWebhookResponse.cs` |

### SandboxItemResetLogin

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxItemResetLogin(SandboxItemResetLoginRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SandboxItemResetLoginResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxItemResetLoginRequest` | `Models/SandboxItemResetLoginRequest.cs` |
| `SandboxItemResetLoginResponse` | `Models/SandboxItemResetLoginResponse.cs` |

### SandboxItemSetVerificationStatus

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxItemSetVerificationStatus(SandboxItemSetVerificationStatusRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SandboxItemSetVerificationStatusResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxItemSetVerificationStatusRequest` | `Models/SandboxItemSetVerificationStatusRequest.cs` |
| `SandboxItemSetVerificationStatusResponse` | `Models/SandboxItemSetVerificationStatusResponse.cs` |

### SandboxOauthSelectAccounts

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxOauthSelectAccounts(SandboxOauthSelectAccountsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `object`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxOauthSelectAccountsRequest` | `Models/SandboxOauthSelectAccountsRequest.cs` |

### SandboxPaymentProfileResetLogin

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxPaymentProfileResetLogin(SandboxPaymentProfileResetLoginRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SandboxPaymentProfileResetLoginResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxPaymentProfileResetLoginRequest` | `Models/SandboxPaymentProfileResetLoginRequest.cs` |
| `SandboxPaymentProfileResetLoginResponse` | `Models/SandboxPaymentProfileResetLoginResponse.cs` |

### SandboxPaymentSimulate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxPaymentSimulate(SandboxPaymentSimulateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SandboxPaymentSimulateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxPaymentSimulateRequest` | `Models/SandboxPaymentSimulateRequest.cs` |
| `SandboxPaymentSimulateResponse` | `Models/SandboxPaymentSimulateResponse.cs` |

### SandboxProcessorTokenCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxProcessorTokenCreate(SandboxProcessorTokenCreateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SandboxProcessorTokenCreateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxProcessorTokenCreateRequest` | `Models/SandboxProcessorTokenCreateRequest.cs` |
| `SandboxProcessorTokenCreateResponse` | `Models/SandboxProcessorTokenCreateResponse.cs` |

### SandboxPublicTokenCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxPublicTokenCreate(SandboxPublicTokenCreateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SandboxPublicTokenCreateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxPublicTokenCreateRequest` | `Models/SandboxPublicTokenCreateRequest.cs` |
| `SandboxPublicTokenCreateResponse` | `Models/SandboxPublicTokenCreateResponse.cs` |

### SandboxTransactionsCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxTransactionsCreate(SandboxTransactionsCreateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SandboxTransactionsCreateResponse`
- **Error**: `SdkException<SandboxTransactionsCreateError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error?)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SandboxTransactionsCreateRequest` | `Models/SandboxTransactionsCreateRequest.cs` |
| `SandboxTransactionsCreateResponse` | `Models/SandboxTransactionsCreateResponse.cs` |
| `SandboxTransactionsCreateError` | `Errors/SandboxTransactionsCreateError.cs` |
| `Error` | `Models/Error.cs` |

### SandboxTransferFireWebhook

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxTransferFireWebhook(SandboxTransferFireWebhookRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SandboxTransferFireWebhookResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxTransferFireWebhookRequest` | `Models/SandboxTransferFireWebhookRequest.cs` |
| `SandboxTransferFireWebhookResponse` | `Models/SandboxTransferFireWebhookResponse.cs` |

### SandboxTransferLedgerDepositSimulate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxTransferLedgerDepositSimulate(SandboxTransferLedgerDepositSimulateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SandboxTransferLedgerDepositSimulateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxTransferLedgerDepositSimulateRequest` | `Models/SandboxTransferLedgerDepositSimulateRequest.cs` |
| `SandboxTransferLedgerDepositSimulateResponse` | `Models/SandboxTransferLedgerDepositSimulateResponse.cs` |

### SandboxTransferLedgerSimulateAvailable

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxTransferLedgerSimulateAvailable(SandboxTransferLedgerSimulateAvailableRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SandboxTransferLedgerSimulateAvailableResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxTransferLedgerSimulateAvailableRequest` | `Models/SandboxTransferLedgerSimulateAvailableRequest.cs` |
| `SandboxTransferLedgerSimulateAvailableResponse` | `Models/SandboxTransferLedgerSimulateAvailableResponse.cs` |

### SandboxTransferLedgerWithdrawSimulate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxTransferLedgerWithdrawSimulate(SandboxTransferLedgerWithdrawSimulateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SandboxTransferLedgerWithdrawSimulateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxTransferLedgerWithdrawSimulateRequest` | `Models/SandboxTransferLedgerWithdrawSimulateRequest.cs` |
| `SandboxTransferLedgerWithdrawSimulateResponse` | `Models/SandboxTransferLedgerWithdrawSimulateResponse.cs` |

### SandboxTransferRefundSimulate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxTransferRefundSimulate(SandboxTransferRefundSimulateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SandboxTransferRefundSimulateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxTransferRefundSimulateRequest` | `Models/SandboxTransferRefundSimulateRequest.cs` |
| `SandboxTransferRefundSimulateResponse` | `Models/SandboxTransferRefundSimulateResponse.cs` |

### SandboxTransferRepaymentSimulate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxTransferRepaymentSimulate(SandboxTransferRepaymentSimulateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SandboxTransferRepaymentSimulateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxTransferRepaymentSimulateRequest` | `Models/SandboxTransferRepaymentSimulateRequest.cs` |
| `SandboxTransferRepaymentSimulateResponse` | `Models/SandboxTransferRepaymentSimulateResponse.cs` |

### SandboxTransferSimulate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxTransferSimulate(SandboxTransferSimulateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SandboxTransferSimulateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxTransferSimulateRequest` | `Models/SandboxTransferSimulateRequest.cs` |
| `SandboxTransferSimulateResponse` | `Models/SandboxTransferSimulateResponse.cs` |

### SandboxTransferSweepSimulate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxTransferSweepSimulate(SandboxTransferSweepSimulateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SandboxTransferSweepSimulateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxTransferSweepSimulateRequest` | `Models/SandboxTransferSweepSimulateRequest.cs` |
| `SandboxTransferSweepSimulateResponse` | `Models/SandboxTransferSweepSimulateResponse.cs` |

### SandboxTransferTestClockAdvance

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxTransferTestClockAdvance(SandboxTransferTestClockAdvanceRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SandboxTransferTestClockAdvanceResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxTransferTestClockAdvanceRequest` | `Models/SandboxTransferTestClockAdvanceRequest.cs` |
| `SandboxTransferTestClockAdvanceResponse` | `Models/SandboxTransferTestClockAdvanceResponse.cs` |

### SandboxTransferTestClockCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxTransferTestClockCreate(SandboxTransferTestClockCreateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SandboxTransferTestClockCreateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxTransferTestClockCreateRequest` | `Models/SandboxTransferTestClockCreateRequest.cs` |
| `SandboxTransferTestClockCreateResponse` | `Models/SandboxTransferTestClockCreateResponse.cs` |

### SandboxTransferTestClockGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxTransferTestClockGet(SandboxTransferTestClockGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SandboxTransferTestClockGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxTransferTestClockGetRequest` | `Models/SandboxTransferTestClockGetRequest.cs` |
| `SandboxTransferTestClockGetResponse` | `Models/SandboxTransferTestClockGetResponse.cs` |

### SandboxTransferTestClockList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxTransferTestClockList(SandboxTransferTestClockListRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SandboxTransferTestClockListResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxTransferTestClockListRequest` | `Models/SandboxTransferTestClockListRequest.cs` |
| `SandboxTransferTestClockListResponse` | `Models/SandboxTransferTestClockListResponse.cs` |

### SandboxUserResetLogin

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SandboxUserResetLogin(SandboxUserResetLoginRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SandboxUserResetLoginResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SandboxUserResetLoginRequest` | `Models/SandboxUserResetLoginRequest.cs` |
| `SandboxUserResetLoginResponse` | `Models/SandboxUserResetLoginResponse.cs` |

### SessionTokenCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SessionTokenCreate(SessionTokenCreateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SessionTokenCreateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SessionTokenCreateRequest` | `Models/SessionTokenCreateRequest.cs` |
| `SessionTokenCreateResponse` | `Models/SessionTokenCreateResponse.cs` |

### SignalDecisionReport

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SignalDecisionReport(SignalDecisionReportRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SignalDecisionReportResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SignalDecisionReportRequest` | `Models/SignalDecisionReportRequest.cs` |
| `SignalDecisionReportResponse` | `Models/SignalDecisionReportResponse.cs` |

### SignalEvaluate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SignalEvaluate(SignalEvaluateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SignalEvaluateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SignalEvaluateRequest` | `Models/SignalEvaluateRequest.cs` |
| `SignalEvaluateResponse` | `Models/SignalEvaluateResponse.cs` |

### SignalPrepare

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SignalPrepare(SignalPrepareRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SignalPrepareResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SignalPrepareRequest` | `Models/SignalPrepareRequest.cs` |
| `SignalPrepareResponse` | `Models/SignalPrepareResponse.cs` |

### SignalReturnReport

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SignalReturnReport(SignalReturnReportRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SignalReturnReportResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SignalReturnReportRequest` | `Models/SignalReturnReportRequest.cs` |
| `SignalReturnReportResponse` | `Models/SignalReturnReportResponse.cs` |

### SignalSchedule

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `SignalSchedule(SignalScheduleRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `SignalScheduleResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SignalScheduleRequest` | `Models/SignalScheduleRequest.cs` |
| `SignalScheduleResponse` | `Models/SignalScheduleResponse.cs` |

### StatementsDownload

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `StatementsDownload(StatementsDownloadRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `StatementsDownloadRequest` | `Models/StatementsDownloadRequest.cs` |

### StatementsList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `StatementsList(StatementsListRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `StatementsListResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `StatementsListRequest` | `Models/StatementsListRequest.cs` |
| `StatementsListResponse` | `Models/StatementsListResponse.cs` |

### StatementsRefresh

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `StatementsRefresh(StatementsRefreshRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `StatementsRefreshResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `StatementsRefreshRequest` | `Models/StatementsRefreshRequest.cs` |
| `StatementsRefreshResponse` | `Models/StatementsRefreshResponse.cs` |

### TransactionsEnhance

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransactionsEnhance(TransactionsEnhanceGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TransactionsEnhanceGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransactionsEnhanceGetRequest` | `Models/TransactionsEnhanceGetRequest.cs` |
| `TransactionsEnhanceGetResponse` | `Models/TransactionsEnhanceGetResponse.cs` |

### TransactionsEnrich

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransactionsEnrich(TransactionsEnrichRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TransactionsEnrichResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransactionsEnrichRequest` | `Models/TransactionsEnrichRequest.cs` |
| `TransactionsEnrichResponse` | `Models/TransactionsEnrichResponse.cs` |

### TransactionsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransactionsGet(TransactionsGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TransactionsGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransactionsGetRequest` | `Models/TransactionsGetRequest.cs` |
| `TransactionsGetResponse` | `Models/TransactionsGetResponse.cs` |

### TransactionsRecurringGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransactionsRecurringGet(TransactionsRecurringGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TransactionsRecurringGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransactionsRecurringGetRequest` | `Models/TransactionsRecurringGetRequest.cs` |
| `TransactionsRecurringGetResponse` | `Models/TransactionsRecurringGetResponse.cs` |

### TransactionsRefresh

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransactionsRefresh(TransactionsRefreshRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TransactionsRefreshResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransactionsRefreshRequest` | `Models/TransactionsRefreshRequest.cs` |
| `TransactionsRefreshResponse` | `Models/TransactionsRefreshResponse.cs` |

### TransactionsRulesCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransactionsRulesCreate(TransactionsRulesCreateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TransactionsRulesCreateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransactionsRulesCreateRequest` | `Models/TransactionsRulesCreateRequest.cs` |
| `TransactionsRulesCreateResponse` | `Models/TransactionsRulesCreateResponse.cs` |

### TransactionsRulesList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransactionsRulesList(TransactionsRulesListRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TransactionsRulesListResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransactionsRulesListRequest` | `Models/TransactionsRulesListRequest.cs` |
| `TransactionsRulesListResponse` | `Models/TransactionsRulesListResponse.cs` |

### TransactionsRulesRemove

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransactionsRulesRemove(TransactionsRulesRemoveRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TransactionsRulesRemoveResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransactionsRulesRemoveRequest` | `Models/TransactionsRulesRemoveRequest.cs` |
| `TransactionsRulesRemoveResponse` | `Models/TransactionsRulesRemoveResponse.cs` |

### TransactionsSync

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransactionsSync(TransactionsSyncRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TransactionsSyncResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransactionsSyncRequest` | `Models/TransactionsSyncRequest.cs` |
| `TransactionsSyncResponse` | `Models/TransactionsSyncResponse.cs` |

### TransactionsUserInsightsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransactionsUserInsightsGet(TransactionsUserInsightsGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TransactionsUserInsightsGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransactionsUserInsightsGetRequest` | `Models/TransactionsUserInsightsGetRequest.cs` |
| `TransactionsUserInsightsGetResponse` | `Models/TransactionsUserInsightsGetResponse.cs` |

### TransferAuthorizationCancel

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferAuthorizationCancel(TransferAuthorizationCancelRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TransferAuthorizationCancelResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferAuthorizationCancelRequest` | `Models/TransferAuthorizationCancelRequest.cs` |
| `TransferAuthorizationCancelResponse` | `Models/TransferAuthorizationCancelResponse.cs` |

### TransferAuthorizationCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferAuthorizationCreate(TransferAuthorizationCreateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TransferAuthorizationCreateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferAuthorizationCreateRequest` | `Models/TransferAuthorizationCreateRequest.cs` |
| `TransferAuthorizationCreateResponse` | `Models/TransferAuthorizationCreateResponse.cs` |

### TransferBalanceGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferBalanceGet(TransferBalanceGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TransferBalanceGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferBalanceGetRequest` | `Models/TransferBalanceGetRequest.cs` |
| `TransferBalanceGetResponse` | `Models/TransferBalanceGetResponse.cs` |

### TransferCancel

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferCancel(TransferCancelRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TransferCancelResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferCancelRequest` | `Models/TransferCancelRequest.cs` |
| `TransferCancelResponse` | `Models/TransferCancelResponse.cs` |

### TransferCapabilitiesGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferCapabilitiesGet(TransferCapabilitiesGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TransferCapabilitiesGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferCapabilitiesGetRequest` | `Models/TransferCapabilitiesGetRequest.cs` |
| `TransferCapabilitiesGetResponse` | `Models/TransferCapabilitiesGetResponse.cs` |

### TransferConfigurationGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferConfigurationGet(TransferConfigurationGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TransferConfigurationGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferConfigurationGetRequest` | `Models/TransferConfigurationGetRequest.cs` |
| `TransferConfigurationGetResponse` | `Models/TransferConfigurationGetResponse.cs` |

### TransferCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferCreate(TransferCreateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TransferCreateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferCreateRequest` | `Models/TransferCreateRequest.cs` |
| `TransferCreateResponse` | `Models/TransferCreateResponse.cs` |

### TransferDiligenceDocumentUpload

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferDiligenceDocumentUpload(TransferDiligenceDocumentUploadRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TransferDiligenceDocumentUploadResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferDiligenceDocumentUploadRequest` | `Models/TransferDiligenceDocumentUploadRequest.cs` |
| `TransferDiligenceDocumentUploadResponse` | `Models/TransferDiligenceDocumentUploadResponse.cs` |

### TransferDiligenceSubmit

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferDiligenceSubmit(TransferDiligenceSubmitRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TransferDiligenceSubmitResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferDiligenceSubmitRequest` | `Models/TransferDiligenceSubmitRequest.cs` |
| `TransferDiligenceSubmitResponse` | `Models/TransferDiligenceSubmitResponse.cs` |

### TransferEventList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferEventList(TransferEventListRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TransferEventListResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferEventListRequest` | `Models/TransferEventListRequest.cs` |
| `TransferEventListResponse` | `Models/TransferEventListResponse.cs` |

### TransferEventSync

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferEventSync(TransferEventSyncRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TransferEventSyncResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferEventSyncRequest` | `Models/TransferEventSyncRequest.cs` |
| `TransferEventSyncResponse` | `Models/TransferEventSyncResponse.cs` |

### TransferGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferGet(TransferGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TransferGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferGetRequest` | `Models/TransferGetRequest.cs` |
| `TransferGetResponse` | `Models/TransferGetResponse.cs` |

### TransferIntentCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferIntentCreate(TransferIntentCreateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TransferIntentCreateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferIntentCreateRequest` | `Models/TransferIntentCreateRequest.cs` |
| `TransferIntentCreateResponse` | `Models/TransferIntentCreateResponse.cs` |

### TransferIntentGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferIntentGet(TransferIntentGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TransferIntentGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferIntentGetRequest` | `Models/TransferIntentGetRequest.cs` |
| `TransferIntentGetResponse` | `Models/TransferIntentGetResponse.cs` |

### TransferLedgerDeposit

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferLedgerDeposit(TransferLedgerDepositRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TransferLedgerDepositResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferLedgerDepositRequest` | `Models/TransferLedgerDepositRequest.cs` |
| `TransferLedgerDepositResponse` | `Models/TransferLedgerDepositResponse.cs` |

### TransferLedgerDistribute

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferLedgerDistribute(TransferLedgerDistributeRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TransferLedgerDistributeResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferLedgerDistributeRequest` | `Models/TransferLedgerDistributeRequest.cs` |
| `TransferLedgerDistributeResponse` | `Models/TransferLedgerDistributeResponse.cs` |

### TransferLedgerEventList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferLedgerEventList(TransferLedgerEventListRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TransferLedgerEventListResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferLedgerEventListRequest` | `Models/TransferLedgerEventListRequest.cs` |
| `TransferLedgerEventListResponse` | `Models/TransferLedgerEventListResponse.cs` |

### TransferLedgerGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferLedgerGet(TransferLedgerGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TransferLedgerGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferLedgerGetRequest` | `Models/TransferLedgerGetRequest.cs` |
| `TransferLedgerGetResponse` | `Models/TransferLedgerGetResponse.cs` |

### TransferLedgerWithdraw

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferLedgerWithdraw(TransferLedgerWithdrawRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TransferLedgerWithdrawResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferLedgerWithdrawRequest` | `Models/TransferLedgerWithdrawRequest.cs` |
| `TransferLedgerWithdrawResponse` | `Models/TransferLedgerWithdrawResponse.cs` |

### TransferList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferList(TransferListRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TransferListResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferListRequest` | `Models/TransferListRequest.cs` |
| `TransferListResponse` | `Models/TransferListResponse.cs` |

### TransferMetricsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferMetricsGet(TransferMetricsGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TransferMetricsGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferMetricsGetRequest` | `Models/TransferMetricsGetRequest.cs` |
| `TransferMetricsGetResponse` | `Models/TransferMetricsGetResponse.cs` |

### TransferMigrateAccount

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferMigrateAccount(TransferMigrateAccountRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TransferMigrateAccountResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferMigrateAccountRequest` | `Models/TransferMigrateAccountRequest.cs` |
| `TransferMigrateAccountResponse` | `Models/TransferMigrateAccountResponse.cs` |

### TransferOriginatorCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferOriginatorCreate(TransferOriginatorCreateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TransferOriginatorCreateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferOriginatorCreateRequest` | `Models/TransferOriginatorCreateRequest.cs` |
| `TransferOriginatorCreateResponse` | `Models/TransferOriginatorCreateResponse.cs` |

### TransferOriginatorFundingAccountCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferOriginatorFundingAccountCreate(TransferOriginatorFundingAccountCreateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TransferOriginatorFundingAccountCreateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferOriginatorFundingAccountCreateRequest` | `Models/TransferOriginatorFundingAccountCreateRequest.cs` |
| `TransferOriginatorFundingAccountCreateResponse` | `Models/TransferOriginatorFundingAccountCreateResponse.cs` |

### TransferOriginatorFundingAccountUpdate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferOriginatorFundingAccountUpdate(TransferOriginatorFundingAccountUpdateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TransferOriginatorFundingAccountUpdateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferOriginatorFundingAccountUpdateRequest` | `Models/TransferOriginatorFundingAccountUpdateRequest.cs` |
| `TransferOriginatorFundingAccountUpdateResponse` | `Models/TransferOriginatorFundingAccountUpdateResponse.cs` |

### TransferOriginatorGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferOriginatorGet(TransferOriginatorGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TransferOriginatorGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferOriginatorGetRequest` | `Models/TransferOriginatorGetRequest.cs` |
| `TransferOriginatorGetResponse` | `Models/TransferOriginatorGetResponse.cs` |

### TransferOriginatorList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferOriginatorList(TransferOriginatorListRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TransferOriginatorListResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferOriginatorListRequest` | `Models/TransferOriginatorListRequest.cs` |
| `TransferOriginatorListResponse` | `Models/TransferOriginatorListResponse.cs` |

### TransferPlatformOriginatorCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferPlatformOriginatorCreate(TransferPlatformOriginatorCreateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TransferPlatformOriginatorCreateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferPlatformOriginatorCreateRequest` | `Models/TransferPlatformOriginatorCreateRequest.cs` |
| `TransferPlatformOriginatorCreateResponse` | `Models/TransferPlatformOriginatorCreateResponse.cs` |

### TransferPlatformPersonCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferPlatformPersonCreate(TransferPlatformPersonCreateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TransferPlatformPersonCreateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferPlatformPersonCreateRequest` | `Models/TransferPlatformPersonCreateRequest.cs` |
| `TransferPlatformPersonCreateResponse` | `Models/TransferPlatformPersonCreateResponse.cs` |

### TransferPlatformRequirementSubmit

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferPlatformRequirementSubmit(TransferPlatformRequirementSubmitRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TransferPlatformRequirementSubmitResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferPlatformRequirementSubmitRequest` | `Models/TransferPlatformRequirementSubmitRequest.cs` |
| `TransferPlatformRequirementSubmitResponse` | `Models/TransferPlatformRequirementSubmitResponse.cs` |

### TransferQuestionnaireCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferQuestionnaireCreate(TransferQuestionnaireCreateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TransferQuestionnaireCreateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferQuestionnaireCreateRequest` | `Models/TransferQuestionnaireCreateRequest.cs` |
| `TransferQuestionnaireCreateResponse` | `Models/TransferQuestionnaireCreateResponse.cs` |

### TransferRecurringCancel

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferRecurringCancel(TransferRecurringCancelRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TransferRecurringCancelResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferRecurringCancelRequest` | `Models/TransferRecurringCancelRequest.cs` |
| `TransferRecurringCancelResponse` | `Models/TransferRecurringCancelResponse.cs` |

### TransferRecurringCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferRecurringCreate(TransferRecurringCreateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TransferRecurringCreateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferRecurringCreateRequest` | `Models/TransferRecurringCreateRequest.cs` |
| `TransferRecurringCreateResponse` | `Models/TransferRecurringCreateResponse.cs` |

### TransferRecurringGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferRecurringGet(TransferRecurringGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TransferRecurringGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferRecurringGetRequest` | `Models/TransferRecurringGetRequest.cs` |
| `TransferRecurringGetResponse` | `Models/TransferRecurringGetResponse.cs` |

### TransferRecurringList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferRecurringList(TransferRecurringListRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TransferRecurringListResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferRecurringListRequest` | `Models/TransferRecurringListRequest.cs` |
| `TransferRecurringListResponse` | `Models/TransferRecurringListResponse.cs` |

### TransferRefundCancel

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferRefundCancel(TransferRefundCancelRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TransferRefundCancelResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferRefundCancelRequest` | `Models/TransferRefundCancelRequest.cs` |
| `TransferRefundCancelResponse` | `Models/TransferRefundCancelResponse.cs` |

### TransferRefundCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferRefundCreate(TransferRefundCreateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TransferRefundCreateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferRefundCreateRequest` | `Models/TransferRefundCreateRequest.cs` |
| `TransferRefundCreateResponse` | `Models/TransferRefundCreateResponse.cs` |

### TransferRefundGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferRefundGet(TransferRefundGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TransferRefundGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferRefundGetRequest` | `Models/TransferRefundGetRequest.cs` |
| `TransferRefundGetResponse` | `Models/TransferRefundGetResponse.cs` |

### TransferRepaymentList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferRepaymentList(TransferRepaymentListRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TransferRepaymentListResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferRepaymentListRequest` | `Models/TransferRepaymentListRequest.cs` |
| `TransferRepaymentListResponse` | `Models/TransferRepaymentListResponse.cs` |

### TransferRepaymentReturnList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferRepaymentReturnList(TransferRepaymentReturnListRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TransferRepaymentReturnListResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferRepaymentReturnListRequest` | `Models/TransferRepaymentReturnListRequest.cs` |
| `TransferRepaymentReturnListResponse` | `Models/TransferRepaymentReturnListResponse.cs` |

### TransferReturnRecover

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferReturnRecover(TransferReturnRecoverRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TransferReturnRecoverResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferReturnRecoverRequest` | `Models/TransferReturnRecoverRequest.cs` |
| `TransferReturnRecoverResponse` | `Models/TransferReturnRecoverResponse.cs` |

### TransferSweepGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferSweepGet(TransferSweepGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TransferSweepGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferSweepGetRequest` | `Models/TransferSweepGetRequest.cs` |
| `TransferSweepGetResponse` | `Models/TransferSweepGetResponse.cs` |

### TransferSweepList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `TransferSweepList(TransferSweepListRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TransferSweepListResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransferSweepListRequest` | `Models/TransferSweepListRequest.cs` |
| `TransferSweepListResponse` | `Models/TransferSweepListResponse.cs` |

### UserAccountSessionEventSend

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `UserAccountSessionEventSend(UserAccountSessionEventSendRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UserAccountSessionEventSendResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UserAccountSessionEventSendRequest` | `Models/UserAccountSessionEventSendRequest.cs` |
| `UserAccountSessionEventSendResponse` | `Models/UserAccountSessionEventSendResponse.cs` |

### UserAccountSessionGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `UserAccountSessionGet(UserAccountSessionGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UserAccountSessionGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UserAccountSessionGetRequest` | `Models/UserAccountSessionGetRequest.cs` |
| `UserAccountSessionGetResponse` | `Models/UserAccountSessionGetResponse.cs` |

### UserCreate

- **Auth**: (`options.ClientId` AND `options.Secret` AND `options.PlaidVersion`) OR `options.Oauth2`
- **Signature**: `UserCreate(UserCreateRequest body, bool? plaidNewUserApiEnabled = false, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - defaults: `plaidNewUserApiEnabled` = `false`
- **Returns**: `UserCreateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UserCreateRequest` | `Models/UserCreateRequest.cs` |
| `UserCreateResponse` | `Models/UserCreateResponse.cs` |

### UserFinancialDataRefresh

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `UserFinancialDataRefresh(UserFinancialDataRefreshRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UserFinancialDataRefreshResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UserFinancialDataRefreshRequest` | `Models/UserFinancialDataRefreshRequest.cs` |
| `UserFinancialDataRefreshResponse` | `Models/UserFinancialDataRefreshResponse.cs` |

### UserGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `UserGet(UserGetRequest body, bool? plaidNewUserApiEnabled = false, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - defaults: `plaidNewUserApiEnabled` = `false`
- **Returns**: `UserGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UserGetRequest` | `Models/UserGetRequest.cs` |
| `UserGetResponse` | `Models/UserGetResponse.cs` |

### UserIdentityRemove

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `UserIdentityRemove(UserIdentityRemoveRequest body, bool? plaidNewUserApiEnabled = false, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - defaults: `plaidNewUserApiEnabled` = `false`
- **Returns**: `UserIdentityRemoveResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UserIdentityRemoveRequest` | `Models/UserIdentityRemoveRequest.cs` |
| `UserIdentityRemoveResponse` | `Models/UserIdentityRemoveResponse.cs` |

### UserItemsAssociate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `UserItemsAssociate(UserItemsAssociateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UserItemsAssociateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UserItemsAssociateRequest` | `Models/UserItemsAssociateRequest.cs` |
| `UserItemsAssociateResponse` | `Models/UserItemsAssociateResponse.cs` |

### UserItemsGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `UserItemsGet(UserItemsGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UserItemsGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UserItemsGetRequest` | `Models/UserItemsGetRequest.cs` |
| `UserItemsGetResponse` | `Models/UserItemsGetResponse.cs` |

### UserItemsRemove

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `UserItemsRemove(UserItemsRemoveRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UserItemsRemoveResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UserItemsRemoveRequest` | `Models/UserItemsRemoveRequest.cs` |
| `UserItemsRemoveResponse` | `Models/UserItemsRemoveResponse.cs` |

### UserProductsTerminate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `UserProductsTerminate(UserProductsTerminateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UserProductsTerminateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UserProductsTerminateRequest` | `Models/UserProductsTerminateRequest.cs` |
| `UserProductsTerminateResponse` | `Models/UserProductsTerminateResponse.cs` |

### UserRemove

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `UserRemove(UserRemoveRequest body, bool? plaidNewUserApiEnabled = false, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - defaults: `plaidNewUserApiEnabled` = `false`
- **Returns**: `UserRemoveResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UserRemoveRequest` | `Models/UserRemoveRequest.cs` |
| `UserRemoveResponse` | `Models/UserRemoveResponse.cs` |

### UserThirdPartyTokenCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `UserThirdPartyTokenCreate(UserThirdPartyTokenCreateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UserThirdPartyTokenCreateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UserThirdPartyTokenCreateRequest` | `Models/UserThirdPartyTokenCreateRequest.cs` |
| `UserThirdPartyTokenCreateResponse` | `Models/UserThirdPartyTokenCreateResponse.cs` |

### UserThirdPartyTokenRemove

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `UserThirdPartyTokenRemove(UserThirdPartyTokenRemoveRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UserThirdPartyTokenRemoveResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UserThirdPartyTokenRemoveRequest` | `Models/UserThirdPartyTokenRemoveRequest.cs` |
| `UserThirdPartyTokenRemoveResponse` | `Models/UserThirdPartyTokenRemoveResponse.cs` |

### UserTransactionsRefresh

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `UserTransactionsRefresh(UserTransactionsRefreshRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `UserTransactionsRefreshResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UserTransactionsRefreshRequest` | `Models/UserTransactionsRefreshRequest.cs` |
| `UserTransactionsRefreshResponse` | `Models/UserTransactionsRefreshResponse.cs` |

### UserUpdate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `UserUpdate(UserUpdateRequest body, bool? plaidNewUserApiEnabled = false, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - defaults: `plaidNewUserApiEnabled` = `false`
- **Returns**: `UserUpdateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UserUpdateRequest` | `Models/UserUpdateRequest.cs` |
| `UserUpdateResponse` | `Models/UserUpdateResponse.cs` |

### WalletCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `WalletCreate(WalletCreateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `WalletCreateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WalletCreateRequest` | `Models/WalletCreateRequest.cs` |
| `WalletCreateResponse` | `Models/WalletCreateResponse.cs` |

### WalletGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `WalletGet(WalletGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `WalletGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WalletGetRequest` | `Models/WalletGetRequest.cs` |
| `WalletGetResponse` | `Models/WalletGetResponse.cs` |

### WalletList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `WalletList(WalletListRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `WalletListResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WalletListRequest` | `Models/WalletListRequest.cs` |
| `WalletListResponse` | `Models/WalletListResponse.cs` |

### WalletTransactionExecute

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `WalletTransactionExecute(WalletTransactionExecuteRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `WalletTransactionExecuteResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WalletTransactionExecuteRequest` | `Models/WalletTransactionExecuteRequest.cs` |
| `WalletTransactionExecuteResponse` | `Models/WalletTransactionExecuteResponse.cs` |

### WalletTransactionGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `WalletTransactionGet(WalletTransactionGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `WalletTransactionGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WalletTransactionGetRequest` | `Models/WalletTransactionGetRequest.cs` |
| `WalletTransactionGetResponse` | `Models/WalletTransactionGetResponse.cs` |

### WalletTransactionList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `WalletTransactionList(WalletTransactionListRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `WalletTransactionListResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WalletTransactionListRequest` | `Models/WalletTransactionListRequest.cs` |
| `WalletTransactionListResponse` | `Models/WalletTransactionListResponse.cs` |

### WatchlistScreeningEntityCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `WatchlistScreeningEntityCreate(WatchlistScreeningEntityCreateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `WatchlistScreeningEntityCreateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WatchlistScreeningEntityCreateRequest` | `Models/WatchlistScreeningEntityCreateRequest.cs` |
| `WatchlistScreeningEntityCreateResponse` | `Models/WatchlistScreeningEntityCreateResponse.cs` |

### WatchlistScreeningEntityGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `WatchlistScreeningEntityGet(WatchlistScreeningEntityGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `WatchlistScreeningEntityGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WatchlistScreeningEntityGetRequest` | `Models/WatchlistScreeningEntityGetRequest.cs` |
| `WatchlistScreeningEntityGetResponse` | `Models/WatchlistScreeningEntityGetResponse.cs` |

### WatchlistScreeningEntityHistoryList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `WatchlistScreeningEntityHistoryList(WatchlistScreeningEntityHistoryListRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `WatchlistScreeningEntityHistoryListResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WatchlistScreeningEntityHistoryListRequest` | `Models/WatchlistScreeningEntityHistoryListRequest.cs` |
| `WatchlistScreeningEntityHistoryListResponse` | `Models/WatchlistScreeningEntityHistoryListResponse.cs` |

### WatchlistScreeningEntityHitList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `WatchlistScreeningEntityHitList(WatchlistScreeningEntityHitListRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `WatchlistScreeningEntityHitListResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WatchlistScreeningEntityHitListRequest` | `Models/WatchlistScreeningEntityHitListRequest.cs` |
| `WatchlistScreeningEntityHitListResponse` | `Models/WatchlistScreeningEntityHitListResponse.cs` |

### WatchlistScreeningEntityList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `WatchlistScreeningEntityList(WatchlistScreeningEntityListRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `WatchlistScreeningEntityListResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WatchlistScreeningEntityListRequest` | `Models/WatchlistScreeningEntityListRequest.cs` |
| `WatchlistScreeningEntityListResponse` | `Models/WatchlistScreeningEntityListResponse.cs` |

### WatchlistScreeningEntityProgramGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `WatchlistScreeningEntityProgramGet(WatchlistScreeningEntityProgramGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `WatchlistScreeningEntityProgramGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WatchlistScreeningEntityProgramGetRequest` | `Models/WatchlistScreeningEntityProgramGetRequest.cs` |
| `WatchlistScreeningEntityProgramGetResponse` | `Models/WatchlistScreeningEntityProgramGetResponse.cs` |

### WatchlistScreeningEntityProgramList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `WatchlistScreeningEntityProgramList(WatchlistScreeningEntityProgramListRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `WatchlistScreeningEntityProgramListResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WatchlistScreeningEntityProgramListRequest` | `Models/WatchlistScreeningEntityProgramListRequest.cs` |
| `WatchlistScreeningEntityProgramListResponse` | `Models/WatchlistScreeningEntityProgramListResponse.cs` |

### WatchlistScreeningEntityReviewCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `WatchlistScreeningEntityReviewCreate(WatchlistScreeningEntityReviewCreateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `WatchlistScreeningEntityReviewCreateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WatchlistScreeningEntityReviewCreateRequest` | `Models/WatchlistScreeningEntityReviewCreateRequest.cs` |
| `WatchlistScreeningEntityReviewCreateResponse` | `Models/WatchlistScreeningEntityReviewCreateResponse.cs` |

### WatchlistScreeningEntityReviewList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `WatchlistScreeningEntityReviewList(WatchlistScreeningEntityReviewListRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `WatchlistScreeningEntityReviewListResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WatchlistScreeningEntityReviewListRequest` | `Models/WatchlistScreeningEntityReviewListRequest.cs` |
| `WatchlistScreeningEntityReviewListResponse` | `Models/WatchlistScreeningEntityReviewListResponse.cs` |

### WatchlistScreeningEntityUpdate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `WatchlistScreeningEntityUpdate(WatchlistScreeningEntityUpdateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `WatchlistScreeningEntityUpdateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WatchlistScreeningEntityUpdateRequest` | `Models/WatchlistScreeningEntityUpdateRequest.cs` |
| `WatchlistScreeningEntityUpdateResponse` | `Models/WatchlistScreeningEntityUpdateResponse.cs` |

### WatchlistScreeningIndividualCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `WatchlistScreeningIndividualCreate(WatchlistScreeningIndividualCreateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `WatchlistScreeningIndividualCreateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WatchlistScreeningIndividualCreateRequest` | `Models/WatchlistScreeningIndividualCreateRequest.cs` |
| `WatchlistScreeningIndividualCreateResponse` | `Models/WatchlistScreeningIndividualCreateResponse.cs` |

### WatchlistScreeningIndividualGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `WatchlistScreeningIndividualGet(WatchlistScreeningIndividualGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `WatchlistScreeningIndividualGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WatchlistScreeningIndividualGetRequest` | `Models/WatchlistScreeningIndividualGetRequest.cs` |
| `WatchlistScreeningIndividualGetResponse` | `Models/WatchlistScreeningIndividualGetResponse.cs` |

### WatchlistScreeningIndividualHistoryList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `WatchlistScreeningIndividualHistoryList(WatchlistScreeningIndividualHistoryListRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `WatchlistScreeningIndividualHistoryListResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WatchlistScreeningIndividualHistoryListRequest` | `Models/WatchlistScreeningIndividualHistoryListRequest.cs` |
| `WatchlistScreeningIndividualHistoryListResponse` | `Models/WatchlistScreeningIndividualHistoryListResponse.cs` |

### WatchlistScreeningIndividualHitList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `WatchlistScreeningIndividualHitList(WatchlistScreeningIndividualHitListRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `WatchlistScreeningIndividualHitListResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WatchlistScreeningIndividualHitListRequest` | `Models/WatchlistScreeningIndividualHitListRequest.cs` |
| `WatchlistScreeningIndividualHitListResponse` | `Models/WatchlistScreeningIndividualHitListResponse.cs` |

### WatchlistScreeningIndividualList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `WatchlistScreeningIndividualList(WatchlistScreeningIndividualListRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `WatchlistScreeningIndividualListResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WatchlistScreeningIndividualListRequest` | `Models/WatchlistScreeningIndividualListRequest.cs` |
| `WatchlistScreeningIndividualListResponse` | `Models/WatchlistScreeningIndividualListResponse.cs` |

### WatchlistScreeningIndividualProgramGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `WatchlistScreeningIndividualProgramGet(WatchlistScreeningIndividualProgramGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `WatchlistScreeningIndividualProgramGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WatchlistScreeningIndividualProgramGetRequest` | `Models/WatchlistScreeningIndividualProgramGetRequest.cs` |
| `WatchlistScreeningIndividualProgramGetResponse` | `Models/WatchlistScreeningIndividualProgramGetResponse.cs` |

### WatchlistScreeningIndividualProgramList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `WatchlistScreeningIndividualProgramList(WatchlistScreeningIndividualProgramListRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `WatchlistScreeningIndividualProgramListResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WatchlistScreeningIndividualProgramListRequest` | `Models/WatchlistScreeningIndividualProgramListRequest.cs` |
| `WatchlistScreeningIndividualProgramListResponse` | `Models/WatchlistScreeningIndividualProgramListResponse.cs` |

### WatchlistScreeningIndividualReviewCreate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `WatchlistScreeningIndividualReviewCreate(WatchlistScreeningIndividualReviewCreateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `WatchlistScreeningIndividualReviewCreateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WatchlistScreeningIndividualReviewCreateRequest` | `Models/WatchlistScreeningIndividualReviewCreateRequest.cs` |
| `WatchlistScreeningIndividualReviewCreateResponse` | `Models/WatchlistScreeningIndividualReviewCreateResponse.cs` |

### WatchlistScreeningIndividualReviewList

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `WatchlistScreeningIndividualReviewList(WatchlistScreeningIndividualReviewListRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `WatchlistScreeningIndividualReviewListResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WatchlistScreeningIndividualReviewListRequest` | `Models/WatchlistScreeningIndividualReviewListRequest.cs` |
| `WatchlistScreeningIndividualReviewListResponse` | `Models/WatchlistScreeningIndividualReviewListResponse.cs` |

### WatchlistScreeningIndividualUpdate

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `WatchlistScreeningIndividualUpdate(WatchlistScreeningIndividualUpdateRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `WatchlistScreeningIndividualUpdateResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WatchlistScreeningIndividualUpdateRequest` | `Models/WatchlistScreeningIndividualUpdateRequest.cs` |
| `WatchlistScreeningIndividualUpdateResponse` | `Models/WatchlistScreeningIndividualUpdateResponse.cs` |

### WebhookVerificationKeyGet

- **Auth**: `options.ClientId` AND `options.Secret` AND `options.PlaidVersion`
- **Signature**: `WebhookVerificationKeyGet(WebhookVerificationKeyGetRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `WebhookVerificationKeyGetResponse`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `WebhookVerificationKeyGetRequest` | `Models/WebhookVerificationKeyGetRequest.cs` |
| `WebhookVerificationKeyGetResponse` | `Models/WebhookVerificationKeyGetResponse.cs` |


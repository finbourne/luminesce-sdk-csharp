# Finbourne.Luminesce.Sdk.Api.LuminesceCertificateManagementApi

All URIs are relative to *https://fbn-prd.lusid.com/honeycomb*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetCertificates**](LuminesceCertificateManagementApi.md#getcertificates) | **GET** /api/Certificate/certificates | [EXPERIMENTAL] GetCertificates: Shows Table and Field level information on Providers that are currently running that you have access to (in Json format) |
| [**ManageCertificate**](LuminesceCertificateManagementApi.md#managecertificate) | **PUT** /api/Certificate/manage | [EXPERIMENTAL] ManageCertificate: Manages a new certificate (Create / Renew / Revoke) |

<a id="getcertificates"></a>
# **GetCertificates**
> List&lt;CertificateState&gt; GetCertificates ()

[EXPERIMENTAL] GetCertificates: Shows Table and Field level information on Providers that are currently running that you have access to (in Json format)

 Lists all the certificates previously minted to which you have access.  The following error codes are to be anticipated with standard Problem Detail reports: - 401 Unauthorized 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class GetCertificatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LuminesceCertificateManagementApi(config);

            try
            {
                // [EXPERIMENTAL] GetCertificates: Shows Table and Field level information on Providers that are currently running that you have access to (in Json format)
                List<CertificateState> result = apiInstance.GetCertificates();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LuminesceCertificateManagementApi.GetCertificates: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCertificatesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetCertificates: Shows Table and Field level information on Providers that are currently running that you have access to (in Json format)
    ApiResponse<List<CertificateState>> response = apiInstance.GetCertificatesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LuminesceCertificateManagementApi.GetCertificatesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;CertificateState&gt;**](CertificateState.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="managecertificate"></a>
# **ManageCertificate**
> CertificateState ManageCertificate (CertificateAction? action = null, CertificateType? type = null, int? version = null, DateTimeOffset? validityStart = null, DateTimeOffset? validityEnd = null, bool? dryRun = null, CertificateStatus? skipSystems = null)

[EXPERIMENTAL] ManageCertificate: Manages a new certificate (Create / Renew / Revoke)

 Manages a certificate.  This could be creating a new one, renewing an old one or revoking one explicitly.  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something about the request cannot be processed - 401 Unauthorized 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class ManageCertificateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LuminesceCertificateManagementApi(config);
            var action = new CertificateAction?(); // CertificateAction? | The Action to perform, e.g. Create / Renew / Revoke (optional) 
            var type = new CertificateType?(); // CertificateType? | User or Domain level cert (Domain level requires additional entitlements) (optional) 
            var version = 1;  // int? | Version number of the cert, the request will fail to validate if incorrect (optional)  (default to 1)
            var validityStart = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | When should the cert first be valid (defaults to the current time in UTC) (optional) 
            var validityEnd = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | When should the cert no longer be valid (defaults to 13 months from now) (optional) 
            var dryRun = true;  // bool? | True will just validate the request, but perform no changes to any system (optional)  (default to true)
            var skipSystems = new CertificateStatus?(); // CertificateStatus? | Any systems that should be skipped  (if any are the certificate will not function, but can be useful for certain forms of validation) (optional) 

            try
            {
                // [EXPERIMENTAL] ManageCertificate: Manages a new certificate (Create / Renew / Revoke)
                CertificateState result = apiInstance.ManageCertificate(action, type, version, validityStart, validityEnd, dryRun, skipSystems);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LuminesceCertificateManagementApi.ManageCertificate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ManageCertificateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ManageCertificate: Manages a new certificate (Create / Renew / Revoke)
    ApiResponse<CertificateState> response = apiInstance.ManageCertificateWithHttpInfo(action, type, version, validityStart, validityEnd, dryRun, skipSystems);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LuminesceCertificateManagementApi.ManageCertificateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **action** | [**CertificateAction?**](CertificateAction?.md) | The Action to perform, e.g. Create / Renew / Revoke | [optional]  |
| **type** | [**CertificateType?**](CertificateType?.md) | User or Domain level cert (Domain level requires additional entitlements) | [optional]  |
| **version** | **int?** | Version number of the cert, the request will fail to validate if incorrect | [optional] [default to 1] |
| **validityStart** | **DateTimeOffset?** | When should the cert first be valid (defaults to the current time in UTC) | [optional]  |
| **validityEnd** | **DateTimeOffset?** | When should the cert no longer be valid (defaults to 13 months from now) | [optional]  |
| **dryRun** | **bool?** | True will just validate the request, but perform no changes to any system | [optional] [default to true] |
| **skipSystems** | [**CertificateStatus?**](CertificateStatus?.md) | Any systems that should be skipped  (if any are the certificate will not function, but can be useful for certain forms of validation) | [optional]  |

### Return type

[**CertificateState**](CertificateState.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


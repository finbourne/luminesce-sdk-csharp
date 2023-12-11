# Finbourne.Luminesce.Sdk.Api.CertificateManagementApi

All URIs are relative to *https://fbn-prd.lusid.com/honeycomb*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DownloadCertificate**](CertificateManagementApi.md#downloadcertificate) | **GET** /api/Certificate/certificate | [EXPERIMENTAL] DownloadCertificate: Downloads your latest Domain or User certificate&#39;s public or private key - if any. |
| [**ListCertificates**](CertificateManagementApi.md#listcertificates) | **GET** /api/Certificate/certificates | [EXPERIMENTAL] ListCertificates: Shows Table and Field level information on Providers that are currently running that you have access to (in Json format) |
| [**ManageCertificate**](CertificateManagementApi.md#managecertificate) | **PUT** /api/Certificate/manage | [EXPERIMENTAL] ManageCertificate: Manages a new certificate (Create / Renew / Revoke) |

<a id="downloadcertificate"></a>
# **DownloadCertificate**
> System.IO.Stream DownloadCertificate (CertificateType? type = null, CertificateFileType? fileType = null)

[EXPERIMENTAL] DownloadCertificate: Downloads your latest Domain or User certificate's public or private key - if any.

 Downloads your latest Domain or User certificate's public or private key - if any.  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - certificate is not available for some reason - 401 Unauthorized 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class DownloadCertificateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CertificateManagementApi(config);
            var type = new CertificateType?(); // CertificateType? | User or Domain level cert (Domain level requires additional entitlements) (optional) 
            var fileType = new CertificateFileType?(); // CertificateFileType? | Should the public key or private key be downloaded? (both must be in place to run providers) (optional) 

            try
            {
                // [EXPERIMENTAL] DownloadCertificate: Downloads your latest Domain or User certificate's public or private key - if any.
                System.IO.Stream result = apiInstance.DownloadCertificate(type, fileType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CertificateManagementApi.DownloadCertificate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DownloadCertificateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DownloadCertificate: Downloads your latest Domain or User certificate's public or private key - if any.
    ApiResponse<System.IO.Stream> response = apiInstance.DownloadCertificateWithHttpInfo(type, fileType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CertificateManagementApi.DownloadCertificateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **type** | [**CertificateType?**](CertificateType?.md) | User or Domain level cert (Domain level requires additional entitlements) | [optional]  |
| **fileType** | [**CertificateFileType?**](CertificateFileType?.md) | Should the public key or private key be downloaded? (both must be in place to run providers) | [optional]  |

### Return type

**System.IO.Stream**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listcertificates"></a>
# **ListCertificates**
> List&lt;CertificateState&gt; ListCertificates ()

[EXPERIMENTAL] ListCertificates: Shows Table and Field level information on Providers that are currently running that you have access to (in Json format)

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
    public class ListCertificatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CertificateManagementApi(config);

            try
            {
                // [EXPERIMENTAL] ListCertificates: Shows Table and Field level information on Providers that are currently running that you have access to (in Json format)
                List<CertificateState> result = apiInstance.ListCertificates();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CertificateManagementApi.ListCertificates: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListCertificatesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListCertificates: Shows Table and Field level information on Providers that are currently running that you have access to (in Json format)
    ApiResponse<List<CertificateState>> response = apiInstance.ListCertificatesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CertificateManagementApi.ListCertificatesWithHttpInfo: " + e.Message);
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
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="managecertificate"></a>
# **ManageCertificate**
> CertificateState ManageCertificate (CertificateAction? action = null, CertificateType? type = null, int? version = null, DateTimeOffset? validityStart = null, DateTimeOffset? validityEnd = null, bool? dryRun = null)

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

            var apiInstance = new CertificateManagementApi(config);
            var action = new CertificateAction?(); // CertificateAction? | The Action to perform, e.g. Create / Renew / Revoke (optional) 
            var type = new CertificateType?(); // CertificateType? | User or Domain level cert (Domain level requires additional entitlements) (optional) 
            var version = 1;  // int? | Version number of the cert, the request will fail to validate if incorrect (optional)  (default to 1)
            var validityStart = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | When should the cert first be valid (defaults to the current time in UTC) (optional) 
            var validityEnd = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | When should the cert no longer be valid (defaults to 13 months from now) (optional) 
            var dryRun = true;  // bool? | True will just validate the request, but perform no changes to any system (optional)  (default to true)

            try
            {
                // [EXPERIMENTAL] ManageCertificate: Manages a new certificate (Create / Renew / Revoke)
                CertificateState result = apiInstance.ManageCertificate(action, type, version, validityStart, validityEnd, dryRun);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CertificateManagementApi.ManageCertificate: " + e.Message);
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
    ApiResponse<CertificateState> response = apiInstance.ManageCertificateWithHttpInfo(action, type, version, validityStart, validityEnd, dryRun);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CertificateManagementApi.ManageCertificateWithHttpInfo: " + e.Message);
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
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


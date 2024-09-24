# Finbourne.Luminesce.Sdk.Api.CertificateManagementApi

All URIs are relative to *https://fbn-prd.lusid.com/honeycomb*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DownloadCertificate**](CertificateManagementApi.md#downloadcertificate) | **GET** /api/Certificate/certificate | [EXPERIMENTAL] DownloadCertificate: Download Domain or your personal certificates |
| [**ListCertificates**](CertificateManagementApi.md#listcertificates) | **GET** /api/Certificate/certificates | [EXPERIMENTAL] ListCertificates: Lists previously minted certificates |
| [**ManageCertificate**](CertificateManagementApi.md#managecertificate) | **PUT** /api/Certificate/manage | [EXPERIMENTAL] ManageCertificate: Create / Renew / Revoke a certificate |

<a id="downloadcertificate"></a>
# **DownloadCertificate**
> System.IO.Stream DownloadCertificate (CertificateType? type = null, CertificateFileType? fileType = null, bool? mayAutoCreate = null)

[EXPERIMENTAL] DownloadCertificate: Download Domain or your personal certificates

 Downloads your latest Domain or your User certificate's public or private key - if any.  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - certificate is not available for some reason - 401 Unauthorized - 403 Forbidden 

### Example
```csharp
using System.Collections.Generic;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Extensions;
using Finbourne.Luminesce.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""luminesceUrl"": ""https://<your-domain>.lusid.com/honeycomb"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CertificateManagementApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CertificateManagementApi>();
            var type = new CertificateType?(); // CertificateType? | User or Domain level cert (Domain level requires additional entitlements) (optional) 
            var fileType = new CertificateFileType?(); // CertificateFileType? | Should the public key or private key be downloaded? (both must be in place to run providers) (optional) 
            var mayAutoCreate = false;  // bool? | If no matching cert is available, should an attempt be made to Create/Renew it with default options? (optional)  (default to false)

            try
            {
                // uncomment the below to set overrides at the request level
                // System.IO.Stream result = apiInstance.DownloadCertificate(type, fileType, mayAutoCreate, opts: opts);

                // [EXPERIMENTAL] DownloadCertificate: Download Domain or your personal certificates
                System.IO.Stream result = apiInstance.DownloadCertificate(type, fileType, mayAutoCreate);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CertificateManagementApi.DownloadCertificate: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    // [EXPERIMENTAL] DownloadCertificate: Download Domain or your personal certificates
    ApiResponse<System.IO.Stream> response = apiInstance.DownloadCertificateWithHttpInfo(type, fileType, mayAutoCreate);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CertificateManagementApi.DownloadCertificateWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **type** | [**CertificateType?**](CertificateType?.md) | User or Domain level cert (Domain level requires additional entitlements) | [optional]  |
| **fileType** | [**CertificateFileType?**](CertificateFileType?.md) | Should the public key or private key be downloaded? (both must be in place to run providers) | [optional]  |
| **mayAutoCreate** | **bool?** | If no matching cert is available, should an attempt be made to Create/Renew it with default options? | [optional] [default to false] |

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listcertificates"></a>
# **ListCertificates**
> List&lt;CertificateState&gt; ListCertificates ()

[EXPERIMENTAL] ListCertificates: Lists previously minted certificates

 Lists all the certificates previously minted to which you have access.  The following error codes are to be anticipated with standard Problem Detail reports: - 401 Unauthorized - 403 Forbidden 

### Example
```csharp
using System.Collections.Generic;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Extensions;
using Finbourne.Luminesce.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""luminesceUrl"": ""https://<your-domain>.lusid.com/honeycomb"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CertificateManagementApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CertificateManagementApi>();

            try
            {
                // uncomment the below to set overrides at the request level
                // List<CertificateState> result = apiInstance.ListCertificates(opts: opts);

                // [EXPERIMENTAL] ListCertificates: Lists previously minted certificates
                List<CertificateState> result = apiInstance.ListCertificates();
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CertificateManagementApi.ListCertificates: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    // [EXPERIMENTAL] ListCertificates: Lists previously minted certificates
    ApiResponse<List<CertificateState>> response = apiInstance.ListCertificatesWithHttpInfo();
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CertificateManagementApi.ListCertificatesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;CertificateState&gt;**](CertificateState.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="managecertificate"></a>
# **ManageCertificate**
> CertificateState ManageCertificate (CertificateAction? action = null, CertificateType? type = null, int? version = null, DateTimeOffset? validityStart = null, DateTimeOffset? validityEnd = null, bool? dryRun = null)

[EXPERIMENTAL] ManageCertificate: Create / Renew / Revoke a certificate

 Manages a certificate.  This could be creating a new one, renewing an old one or revoking one explicitly.  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something about the request cannot be processed - 401 Unauthorized - 403 Forbidden 

### Example
```csharp
using System.Collections.Generic;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Extensions;
using Finbourne.Luminesce.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""luminesceUrl"": ""https://<your-domain>.lusid.com/honeycomb"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CertificateManagementApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CertificateManagementApi>();
            var action = new CertificateAction?(); // CertificateAction? | The Action to perform, e.g. Create / Renew / Revoke (optional) 
            var type = new CertificateType?(); // CertificateType? | User or Domain level cert (Domain level requires additional entitlements) (optional) 
            var version = 1;  // int? | Version number of the cert, the request will fail to validate if incorrect (optional)  (default to 1)
            var validityStart = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | When should the cert first be valid (defaults to the current time in UTC) (optional) 
            var validityEnd = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | When should the cert no longer be valid (defaults to 13 months from now) (optional) 
            var dryRun = true;  // bool? | True will just validate the request, but perform no changes to any system (optional)  (default to true)

            try
            {
                // uncomment the below to set overrides at the request level
                // CertificateState result = apiInstance.ManageCertificate(action, type, version, validityStart, validityEnd, dryRun, opts: opts);

                // [EXPERIMENTAL] ManageCertificate: Create / Renew / Revoke a certificate
                CertificateState result = apiInstance.ManageCertificate(action, type, version, validityStart, validityEnd, dryRun);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CertificateManagementApi.ManageCertificate: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    // [EXPERIMENTAL] ManageCertificate: Create / Renew / Revoke a certificate
    ApiResponse<CertificateState> response = apiInstance.ManageCertificateWithHttpInfo(action, type, version, validityStart, validityEnd, dryRun);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CertificateManagementApi.ManageCertificateWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
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

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)


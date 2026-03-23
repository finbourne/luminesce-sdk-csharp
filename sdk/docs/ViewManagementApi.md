# Finbourne.Luminesce.Sdk.Api.ViewManagementApi

All URIs are relative to *https://fbn-prd.lusid.com/honeycomb*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetViewCreationSql**](ViewManagementApi.md#getviewcreationsql) | **PUT** /api/View/sql | [EXPERIMENTAL] GetViewCreationSql: Gets the original source Sql for a view (if available) |
| [**ListViews**](ViewManagementApi.md#listviews) | **GET** /api/View/list | [EXPERIMENTAL] ListViews: List views which are visible to the current users |

<a id="getviewcreationsql"></a>
# **GetViewCreationSql**
> string GetViewCreationSql (ViewItem? viewItem = null)

[EXPERIMENTAL] GetViewCreationSql: Gets the original source Sql for a view (if available)

 Gets the original source Sql for a view (if available, 404 if not found in the logs)  The following error codes are to be anticipated with standard Problem Detail reports: - 401 Unauthorized - 403 Forbidden 

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ViewManagementApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ViewManagementApi>();
            var viewItem = new ViewItem?(); // ViewItem? | View to fetch the create SQL for. Only the LastUpdatedAt and LastUpdatedExecutionId properties are required. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // string result = apiInstance.GetViewCreationSql(viewItem, opts: opts);

                // [EXPERIMENTAL] GetViewCreationSql: Gets the original source Sql for a view (if available)
                string result = apiInstance.GetViewCreationSql(viewItem);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ViewManagementApi.GetViewCreationSql: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetViewCreationSqlWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetViewCreationSql: Gets the original source Sql for a view (if available)
    ApiResponse<string> response = apiInstance.GetViewCreationSqlWithHttpInfo(viewItem);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ViewManagementApi.GetViewCreationSqlWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **viewItem** | [**ViewItem?**](ViewItem?.md) | View to fetch the create SQL for. Only the LastUpdatedAt and LastUpdatedExecutionId properties are required. | [optional]  |

### Return type

**string**

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listviews"></a>
# **ListViews**
> List&lt;ViewItem&gt; ListViews (bool? showAll = null, string? regExFilter = null)

[EXPERIMENTAL] ListViews: List views which are visible to the current users

 Lists all the views which you have access, some limited filtering is available. These come from directly from persisted files in the file system.  The following error codes are to be anticipated with standard Problem Detail reports: - 401 Unauthorized - 403 Forbidden 

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ViewManagementApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ViewManagementApi>();
            var showAll = false;  // bool? | Show additional views if permissions allow (optional)  (default to false)
            var regExFilter = "regExFilter_example";  // string? | Regular Expression filter to apply to the view content (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // List<ViewItem> result = apiInstance.ListViews(showAll, regExFilter, opts: opts);

                // [EXPERIMENTAL] ListViews: List views which are visible to the current users
                List<ViewItem> result = apiInstance.ListViews(showAll, regExFilter);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ViewManagementApi.ListViews: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListViewsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListViews: List views which are visible to the current users
    ApiResponse<List<ViewItem>> response = apiInstance.ListViewsWithHttpInfo(showAll, regExFilter);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ViewManagementApi.ListViewsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **showAll** | **bool?** | Show additional views if permissions allow | [optional] [default to false] |
| **regExFilter** | **string?** | Regular Expression filter to apply to the view content | [optional]  |

### Return type

[**List&lt;ViewItem&gt;**](ViewItem.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)


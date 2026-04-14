# Finbourne.Luminesce.Sdk.Api.ViewManagementApi

All URIs are relative to *https://fbn-prd.lusid.com/honeycomb*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteView**](ViewManagementApi.md#deleteview) | **DELETE** /api/View/update | [EXPERIMENTAL] DeleteView: Deletes a view by name |
| [**GetViewCreationSql**](ViewManagementApi.md#getviewcreationsql) | **PUT** /api/View/sql | [EXPERIMENTAL] GetViewCreationSql: Gets the original source Sql for a view (if available) |
| [**ListViews**](ViewManagementApi.md#listviews) | **GET** /api/View/list | [EXPERIMENTAL] ListViews: List views which are visible to the current user |
| [**UpsertView**](ViewManagementApi.md#upsertview) | **PUT** /api/View/update | [EXPERIMENTAL] UpsertView: Creates or updates a view from a full ViewDefinition. |

<a id="deleteview"></a>
# **DeleteView**
> string DeleteView (string? viewName = null)

[EXPERIMENTAL] DeleteView: Deletes a view by name

 Deletes a view.  This is primarily intended for use by an automated tool to synchronise views between domains.  The following error codes are to be anticipated with standard Problem Detail reports: - 401 Unauthorized - 403 Forbidden 

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
            var viewName = "viewName_example";  // string? | View to delete (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // string result = apiInstance.DeleteView(viewName, opts: opts);

                // [EXPERIMENTAL] DeleteView: Deletes a view by name
                string result = apiInstance.DeleteView(viewName);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ViewManagementApi.DeleteView: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteViewWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteView: Deletes a view by name
    ApiResponse<string> response = apiInstance.DeleteViewWithHttpInfo(viewName);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ViewManagementApi.DeleteViewWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **viewName** | **string?** | View to delete | [optional]  |

### Return type

**string**

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
> List&lt;ViewItem&gt; ListViews (bool? showAll = null, string? regExFilter = null, string? nameLikeFilter = null)

[EXPERIMENTAL] ListViews: List views which are visible to the current user

 Lists all the views which you have access to see. These come from directly from persisted files in the file system. Some limited filtering is available.  The following error codes are to be anticipated with standard Problem Detail reports: - 401 Unauthorized - 403 Forbidden 

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
            var regExFilter = "regExFilter_example";  // string? | Regular Expression filter to reduce the number of views returned, it is applied to the view *content* (this filter is applied withing the Filesystem itself.) (optional) 
            var nameLikeFilter = "nameLikeFilter_example";  // string? | SQL Like-style filter on the view name, to reduce the number of views returned (this filter is applied to the Filesystem-returned view list.) (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // List<ViewItem> result = apiInstance.ListViews(showAll, regExFilter, nameLikeFilter, opts: opts);

                // [EXPERIMENTAL] ListViews: List views which are visible to the current user
                List<ViewItem> result = apiInstance.ListViews(showAll, regExFilter, nameLikeFilter);
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
    // [EXPERIMENTAL] ListViews: List views which are visible to the current user
    ApiResponse<List<ViewItem>> response = apiInstance.ListViewsWithHttpInfo(showAll, regExFilter, nameLikeFilter);
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
| **regExFilter** | **string?** | Regular Expression filter to reduce the number of views returned, it is applied to the view *content* (this filter is applied withing the Filesystem itself.) | [optional]  |
| **nameLikeFilter** | **string?** | SQL Like-style filter on the view name, to reduce the number of views returned (this filter is applied to the Filesystem-returned view list.) | [optional]  |

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

<a id="upsertview"></a>
# **UpsertView**
> string UpsertView (bool? allowWarnings = null, bool? mayUpdateExisting = null, ViewItem? viewItem = null)

[EXPERIMENTAL] UpsertView: Creates or updates a view from a full ViewDefinition.

 Creates or updates a view from a full ViewDefinition.  Adds or creates a view from a view definition - without running the SQL of the view.  This is primarily intended for use by an automated tool to copy views between domains.  What this is *absolutely not* intended to do is to update views to tampered with definitions that were not originally created by `Sys.Admin.SetupView`, not even the smallest of changes are permitted as they may not work and will lead to additional support loads.  The flow for using fbn-config and these endpoints should generally be: - version control the `Sys.Admin.SetupView` query or the fbn-config resource that runs that query. - that can be automatically deployed to a development environment / domain. - an automated process then uses the `list` endpoint to get the full view definition (see above) from the dev-domain - then that definition can be given to a sit/uat/prod domain via this endpoint   - fbn-config could be responsible for this via a new resource type or simply a new, or any other script with PATs for both domains could be responsible for that)  The following error codes are to be anticipated with standard Problem Detail reports: - 401 Unauthorized - 403 Forbidden 

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
            var allowWarnings = false;  // bool? | May views with *warnings* be upserted?  Regardless of this views with *errors* may not be. Warnings includes things like: - not using macros properly so that filters or aggregations cannot be passed down - using things like `select *` that can lead to results changing over time Errors includes things like: - uses a provider or view that simply doesn't exists (so perhaps a view this depends on needs creating first?) - The SQL or Metadata of the view was manually edited, not setup correctly by `Sys.Admin.SetupView` (optional)  (default to false)
            var mayUpdateExisting = false;  // bool? | May an existing view be overwritten?  Defaults to false to prevent accidental overwrites. Set to true when intentionally deploying an updated view definition to a domain. (optional)  (default to false)
            var viewItem = new ViewItem?(); // ViewItem? | View to create / change the definition of. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // string result = apiInstance.UpsertView(allowWarnings, mayUpdateExisting, viewItem, opts: opts);

                // [EXPERIMENTAL] UpsertView: Creates or updates a view from a full ViewDefinition.
                string result = apiInstance.UpsertView(allowWarnings, mayUpdateExisting, viewItem);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ViewManagementApi.UpsertView: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertViewWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpsertView: Creates or updates a view from a full ViewDefinition.
    ApiResponse<string> response = apiInstance.UpsertViewWithHttpInfo(allowWarnings, mayUpdateExisting, viewItem);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ViewManagementApi.UpsertViewWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **allowWarnings** | **bool?** | May views with *warnings* be upserted?  Regardless of this views with *errors* may not be. Warnings includes things like: - not using macros properly so that filters or aggregations cannot be passed down - using things like &#x60;select *&#x60; that can lead to results changing over time Errors includes things like: - uses a provider or view that simply doesn&#39;t exists (so perhaps a view this depends on needs creating first?) - The SQL or Metadata of the view was manually edited, not setup correctly by &#x60;Sys.Admin.SetupView&#x60; | [optional] [default to false] |
| **mayUpdateExisting** | **bool?** | May an existing view be overwritten?  Defaults to false to prevent accidental overwrites. Set to true when intentionally deploying an updated view definition to a domain. | [optional] [default to false] |
| **viewItem** | [**ViewItem?**](ViewItem?.md) | View to create / change the definition of. | [optional]  |

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


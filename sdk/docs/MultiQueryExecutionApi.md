# Finbourne.Luminesce.Sdk.Api.MultiQueryExecutionApi

All URIs are relative to *https://fbn-prd.lusid.com/honeycomb*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CancelMultiQuery**](MultiQueryExecutionApi.md#cancelmultiquery) | **DELETE** /api/MultiQueryBackground/{executionId} | CancelMultiQuery: Cancel / Clear a previously started query-set |
| [**GetProgressOfMultiQuery**](MultiQueryExecutionApi.md#getprogressofmultiquery) | **GET** /api/MultiQueryBackground/{executionId} | GetProgressOfMultiQuery: View progress of the entire query-set load |
| [**StartQueries**](MultiQueryExecutionApi.md#startqueries) | **PUT** /api/MultiQueryBackground | StartQueries: Run a given set of Sql queries in the background |

<a id="cancelmultiquery"></a>
# **CancelMultiQuery**
> BackgroundQueryCancelResponse CancelMultiQuery (string executionId)

CancelMultiQuery: Cancel / Clear a previously started query-set

Cancel the query-set (if still running) / clear the data (if already returned) The following error codes are to be anticipated with standard Problem Detail reports: - 401 Unauthorized - 403 Forbidden - 404 Not Found : The requested query result doesn't exist and is not running. 

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<MultiQueryExecutionApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<MultiQueryExecutionApi>();
            var executionId = "executionId_example";  // string | ExecutionId returned when starting the query

            try
            {
                // uncomment the below to set overrides at the request level
                // BackgroundQueryCancelResponse result = apiInstance.CancelMultiQuery(executionId, opts: opts);

                // CancelMultiQuery: Cancel / Clear a previously started query-set
                BackgroundQueryCancelResponse result = apiInstance.CancelMultiQuery(executionId);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling MultiQueryExecutionApi.CancelMultiQuery: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CancelMultiQueryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // CancelMultiQuery: Cancel / Clear a previously started query-set
    ApiResponse<BackgroundQueryCancelResponse> response = apiInstance.CancelMultiQueryWithHttpInfo(executionId);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling MultiQueryExecutionApi.CancelMultiQueryWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **executionId** | **string** | ExecutionId returned when starting the query |  |

### Return type

[**BackgroundQueryCancelResponse**](BackgroundQueryCancelResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getprogressofmultiquery"></a>
# **GetProgressOfMultiQuery**
> BackgroundMultiQueryProgressResponse GetProgressOfMultiQuery (string executionId)

GetProgressOfMultiQuery: View progress of the entire query-set load

View progress information (up until this point) for the entire query-set The following error codes are to be anticipated with standard Problem Detail reports: - 401 Unauthorized - 403 Forbidden - 404 Not Found : The requested query result doesn't exist and is not running. - 429 Too Many Requests : Please try your request again soon   1. The query has been executed successfully in the past yet the server-instance receiving this request (e.g. from a load balancer) doesn't yet have this data available.   1. By virtue of the request you have just placed this will have started to load from the persisted cache and will soon be available.   1. It is also the case that the original server-instance to process the original query is likely to already be able to service this request.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<MultiQueryExecutionApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<MultiQueryExecutionApi>();
            var executionId = "executionId_example";  // string | ExecutionId returned when starting the query

            try
            {
                // uncomment the below to set overrides at the request level
                // BackgroundMultiQueryProgressResponse result = apiInstance.GetProgressOfMultiQuery(executionId, opts: opts);

                // GetProgressOfMultiQuery: View progress of the entire query-set load
                BackgroundMultiQueryProgressResponse result = apiInstance.GetProgressOfMultiQuery(executionId);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling MultiQueryExecutionApi.GetProgressOfMultiQuery: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProgressOfMultiQueryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetProgressOfMultiQuery: View progress of the entire query-set load
    ApiResponse<BackgroundMultiQueryProgressResponse> response = apiInstance.GetProgressOfMultiQueryWithHttpInfo(executionId);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling MultiQueryExecutionApi.GetProgressOfMultiQueryWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **executionId** | **string** | ExecutionId returned when starting the query |  |

### Return type

[**BackgroundMultiQueryProgressResponse**](BackgroundMultiQueryProgressResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="startqueries"></a>
# **StartQueries**
> BackgroundMultiQueryResponse StartQueries (MultiQueryDefinitionType type, string body, DateTimeOffset? asAt = null, DateTimeOffset? effectiveAt = null, int? limit1 = null, int? limit2 = null, string? input1 = null, string? input2 = null, string? input3 = null, int? timeoutSeconds = null, int? keepForSeconds = null)

StartQueries: Run a given set of Sql queries in the background

 Allow for starting a potentially long running query and getting back an immediate response with how to  - fetch the data in various formats (if available, or if not simply being informed it is not yet ready), on a per result basis - view progress information (up until this point), for all results in one go - cancel the queries (if still running) / clear the data (if already returned)  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - there was something wrong with your query syntax (the issue was detected at parse-time) - 401 Unauthorized - 403 Forbidden 

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<MultiQueryExecutionApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<MultiQueryExecutionApi>();
            var type = Instrument;  // MultiQueryDefinitionType | An enum value defining the set of statements being executed
            var body = Apple;  // string | A \"search\" value (e.g. 'Apple' on an instrument search, a `Finbourne.Filtering` expression of Insights, etc.)  In the cases where \"Nothing\" is valid for a `Finbourne.Filtering` expression, pass `True`.
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The AsAt time used by any bitemporal provider in the queries. (optional) 
            var effectiveAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The EffectiveAt time used by any bitemporal provider in the queries. (optional) 
            var limit1 = 56;  // int? | A limit that is applied to first-level queries (e.g. Instruments themselves) (optional) 
            var limit2 = 56;  // int? | A limit that is applied to second-level queries (e.g. Holdings based on the set of Instruments found) (optional) 
            var input1 = "input1_example";  // string? | A value available to queries, these vary by 'type' and are only used by some types at all.  e.g. a start-date of some sort (optional) 
            var input2 = "input2_example";  // string? | A second value available to queries, these vary by 'type' and are only used by some types at all. (optional) 
            var input3 = "input3_example";  // string? | A third value available to queries, these vary by 'type' and are only used by some types at all. (optional) 
            var timeoutSeconds = 1200;  // int? | Maximum time the query may run for, in seconds: <0 → ∞, 0 → 1200s (20m) (optional)  (default to 0)
            var keepForSeconds = 7200;  // int? | Maximum time the result may be kept for, in seconds: <0 → 1200 (20m), 0 → 28800 (8h), max = 2,678,400 (31d) (optional)  (default to 0)

            try
            {
                // uncomment the below to set overrides at the request level
                // BackgroundMultiQueryResponse result = apiInstance.StartQueries(type, body, asAt, effectiveAt, limit1, limit2, input1, input2, input3, timeoutSeconds, keepForSeconds, opts: opts);

                // StartQueries: Run a given set of Sql queries in the background
                BackgroundMultiQueryResponse result = apiInstance.StartQueries(type, body, asAt, effectiveAt, limit1, limit2, input1, input2, input3, timeoutSeconds, keepForSeconds);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling MultiQueryExecutionApi.StartQueries: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the StartQueriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // StartQueries: Run a given set of Sql queries in the background
    ApiResponse<BackgroundMultiQueryResponse> response = apiInstance.StartQueriesWithHttpInfo(type, body, asAt, effectiveAt, limit1, limit2, input1, input2, input3, timeoutSeconds, keepForSeconds);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling MultiQueryExecutionApi.StartQueriesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **type** | **MultiQueryDefinitionType** | An enum value defining the set of statements being executed |  |
| **body** | **string** | A \&quot;search\&quot; value (e.g. &#39;Apple&#39; on an instrument search, a &#x60;Finbourne.Filtering&#x60; expression of Insights, etc.)  In the cases where \&quot;Nothing\&quot; is valid for a &#x60;Finbourne.Filtering&#x60; expression, pass &#x60;True&#x60;. |  |
| **asAt** | **DateTimeOffset?** | The AsAt time used by any bitemporal provider in the queries. | [optional]  |
| **effectiveAt** | **DateTimeOffset?** | The EffectiveAt time used by any bitemporal provider in the queries. | [optional]  |
| **limit1** | **int?** | A limit that is applied to first-level queries (e.g. Instruments themselves) | [optional]  |
| **limit2** | **int?** | A limit that is applied to second-level queries (e.g. Holdings based on the set of Instruments found) | [optional]  |
| **input1** | **string?** | A value available to queries, these vary by &#39;type&#39; and are only used by some types at all.  e.g. a start-date of some sort | [optional]  |
| **input2** | **string?** | A second value available to queries, these vary by &#39;type&#39; and are only used by some types at all. | [optional]  |
| **input3** | **string?** | A third value available to queries, these vary by &#39;type&#39; and are only used by some types at all. | [optional]  |
| **timeoutSeconds** | **int?** | Maximum time the query may run for, in seconds: &lt;0 → ∞, 0 → 1200s (20m) | [optional] [default to 0] |
| **keepForSeconds** | **int?** | Maximum time the result may be kept for, in seconds: &lt;0 → 1200 (20m), 0 → 28800 (8h), max &#x3D; 2,678,400 (31d) | [optional] [default to 0] |

### Return type

[**BackgroundMultiQueryResponse**](BackgroundMultiQueryResponse.md)

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Accepted |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)


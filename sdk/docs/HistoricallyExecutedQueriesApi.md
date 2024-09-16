# Finbourne.Luminesce.Sdk.Api.HistoricallyExecutedQueriesApi

All URIs are relative to *https://fbn-prd.lusid.com/honeycomb*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CancelHistory**](HistoricallyExecutedQueriesApi.md#cancelhistory) | **DELETE** /api/History/{executionId} | CancelHistory: Cancels (if running) or clears the data from (if completed) a previously started History query |
| [**FetchHistoryResultHistogram**](HistoricallyExecutedQueriesApi.md#fetchhistoryresulthistogram) | **GET** /api/History/{executionId}/histogram | FetchHistoryResultHistogram: Fetches the result from a previously started query, converts it to a histogram (counts in buckets). |
| [**FetchHistoryResultJson**](HistoricallyExecutedQueriesApi.md#fetchhistoryresultjson) | **GET** /api/History/{executionId}/json | FetchHistoryResultJson: Fetches the result from a previously started query, in JSON format. |
| [**GetHistory**](HistoricallyExecutedQueriesApi.md#gethistory) | **GET** /api/History | GetHistory: Shows queries executed in a given historical time window (in Json format). |
| [**GetProgressOfHistory**](HistoricallyExecutedQueriesApi.md#getprogressofhistory) | **GET** /api/History/{executionId} | GetProgressOfHistory: View progress information (up until this point) of a history query |

<a id="cancelhistory"></a>
# **CancelHistory**
> BackgroundQueryCancelResponse CancelHistory (string executionId)

CancelHistory: Cancels (if running) or clears the data from (if completed) a previously started History query

Cancel the query (if still running) / clear the data (if already returned) The following error codes are to be anticipated with standard Problem Detail reports: - 401 Unauthorized - 403 Forbidden - 404 Not Found : The requested query result doesn't exist and is not running. 

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<HistoricallyExecutedQueriesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<HistoricallyExecutedQueriesApi>();
            var executionId = "executionId_example";  // string | ExecutionId returned when starting the query

            try
            {
                // uncomment the below to set overrides at the request level
                // BackgroundQueryCancelResponse result = apiInstance.CancelHistory(executionId, opts: opts);

                // CancelHistory: Cancels (if running) or clears the data from (if completed) a previously started History query
                BackgroundQueryCancelResponse result = apiInstance.CancelHistory(executionId);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling HistoricallyExecutedQueriesApi.CancelHistory: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CancelHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // CancelHistory: Cancels (if running) or clears the data from (if completed) a previously started History query
    ApiResponse<BackgroundQueryCancelResponse> response = apiInstance.CancelHistoryWithHttpInfo(executionId);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling HistoricallyExecutedQueriesApi.CancelHistoryWithHttpInfo: " + e.Message);
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

<a id="fetchhistoryresulthistogram"></a>
# **FetchHistoryResultHistogram**
> string FetchHistoryResultHistogram (string executionId, string? bucketSize = null, string? filter = null, bool? jsonProper = null)

FetchHistoryResultHistogram: Fetches the result from a previously started query, converts it to a histogram (counts in buckets).

Fetch the histogram in Json format (if available, or if not simply being informed it is not yet ready) The following error codes are to be anticipated with standard Problem Detail reports: - 401 Unauthorized - 403 Forbidden - 404 Not Found : The requested query result doesn't (yet) exist. - 429 Too Many Requests : Please try your request again soon   1. The query has been executed successfully in the past yet the server-instance receiving this request (e.g. from a load balancer) doesn't yet have this data available.   1. By virtue of the request you have just placed this will have started to load from the persisted cache and will soon be available.   1. It is also the case that the original server-instance to process the original query is likely to already be able to service this request.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<HistoricallyExecutedQueriesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<HistoricallyExecutedQueriesApi>();
            var executionId = "executionId_example";  // string | ExecutionId returned when starting the query
            var bucketSize = "bucketSize_example";  // string? | Optional histogram bucket width.  If not provided a set number of buckets between start/end range will be generated. (optional) 
            var filter = "filter_example";  // string? | An ODATA filter per Finbourne.Filtering syntax. (optional) 
            var jsonProper = false;  // bool? | Should this be text/json (not json-encoded-as-a-string) (optional)  (default to false)

            try
            {
                // uncomment the below to set overrides at the request level
                // string result = apiInstance.FetchHistoryResultHistogram(executionId, bucketSize, filter, jsonProper, opts: opts);

                // FetchHistoryResultHistogram: Fetches the result from a previously started query, converts it to a histogram (counts in buckets).
                string result = apiInstance.FetchHistoryResultHistogram(executionId, bucketSize, filter, jsonProper);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling HistoricallyExecutedQueriesApi.FetchHistoryResultHistogram: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the FetchHistoryResultHistogramWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // FetchHistoryResultHistogram: Fetches the result from a previously started query, converts it to a histogram (counts in buckets).
    ApiResponse<string> response = apiInstance.FetchHistoryResultHistogramWithHttpInfo(executionId, bucketSize, filter, jsonProper);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling HistoricallyExecutedQueriesApi.FetchHistoryResultHistogramWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **executionId** | **string** | ExecutionId returned when starting the query |  |
| **bucketSize** | **string?** | Optional histogram bucket width.  If not provided a set number of buckets between start/end range will be generated. | [optional]  |
| **filter** | **string?** | An ODATA filter per Finbourne.Filtering syntax. | [optional]  |
| **jsonProper** | **bool?** | Should this be text/json (not json-encoded-as-a-string) | [optional] [default to false] |

### Return type

**string**

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

<a id="fetchhistoryresultjson"></a>
# **FetchHistoryResultJson**
> string FetchHistoryResultJson (string executionId, string? sortBy = null, string? filter = null, string? select = null, string? groupBy = null, int? limit = null, int? page = null, bool? jsonProper = null)

FetchHistoryResultJson: Fetches the result from a previously started query, in JSON format.

Fetch the data in Json format (if available, or if not simply being informed it is not yet ready) The following error codes are to be anticipated with standard Problem Detail reports: - 401 Unauthorized - 403 Forbidden - 404 Not Found : The requested query result doesn't (yet) exist. - 429 Too Many Requests : Please try your request again soon   1. The query has been executed successfully in the past yet the server-instance receiving this request (e.g. from a load balancer) doesn't yet have this data available.   1. By virtue of the request you have just placed this will have started to load from the persisted cache and will soon be available.   1. It is also the case that the original server-instance to process the original query is likely to already be able to service this request.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<HistoricallyExecutedQueriesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<HistoricallyExecutedQueriesApi>();
            var executionId = "executionId_example";  // string | ExecutionId returned when starting the query
            var sortBy = "sortBy_example";  // string? | Order the results by these fields.              Use the `-` sign to denote descending order, e.g. `-MyFieldName`.  Numeric indexes may be used also, e.g. `2,-3`.              Multiple fields can be denoted by a comma e.g. `-MyFieldName,AnotherFieldName,-AFurtherFieldName`.              Default is null, the sort order specified in the query itself. (optional) 
            var filter = "filter_example";  // string? | An ODATA filter per Finbourne.Filtering syntax. (optional) 
            var select = "select_example";  // string? | Default is null (meaning return all columns in the original query itself).  The values are in terms of the result column name from the original data set and are comma delimited.  The power of this comes in that you may aggregate the data if you wish  (that is the main reason for allowing this, in fact).  e.g.:  - `MyField`  - `Max(x) FILTER (WHERE y > 12) as ABC` (max of a field, if another field lets it qualify, with a nice column name)  - `count(*)` (count the rows for the given group, that would produce a rather ugly column name, but  it works)  - `count(distinct x) as numOfXs`  If there was an illegal character in a field you are selecting from, you are responsible for bracketing it with [ ].   e.g.  - `some_field, count(*) as a, max(x) as b, min([column with space in name]) as nice_name`    where you would likely want to pass `1` as the `groupBy` also. (optional) 
            var groupBy = "groupBy_example";  // string? | Groups by the specified fields.              A comma delimited list of: 1 based numeric indexes (cleaner), or repeats of the select expressions (a bit verbose and must match exactly).              e.g. `2,3`, `myColumn`.              Default is null (meaning no grouping will be performed on the selected columns).              This applies only over the result set being requested here, meaning indexes into the \"select\" parameter fields.              Only specify this if you are selecting aggregations in the \"select\" parameter. (optional) 
            var limit = 0;  // int? | When paginating, only return this number of records, page should also be specified. (optional)  (default to 0)
            var page = 0;  // int? | 0-N based on chunk sized determined by the limit, ignored if limit < 1. (optional)  (default to 0)
            var jsonProper = false;  // bool? | Should this be text/json (not json-encoded-as-a-string) (optional)  (default to false)

            try
            {
                // uncomment the below to set overrides at the request level
                // string result = apiInstance.FetchHistoryResultJson(executionId, sortBy, filter, select, groupBy, limit, page, jsonProper, opts: opts);

                // FetchHistoryResultJson: Fetches the result from a previously started query, in JSON format.
                string result = apiInstance.FetchHistoryResultJson(executionId, sortBy, filter, select, groupBy, limit, page, jsonProper);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling HistoricallyExecutedQueriesApi.FetchHistoryResultJson: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the FetchHistoryResultJsonWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // FetchHistoryResultJson: Fetches the result from a previously started query, in JSON format.
    ApiResponse<string> response = apiInstance.FetchHistoryResultJsonWithHttpInfo(executionId, sortBy, filter, select, groupBy, limit, page, jsonProper);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling HistoricallyExecutedQueriesApi.FetchHistoryResultJsonWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **executionId** | **string** | ExecutionId returned when starting the query |  |
| **sortBy** | **string?** | Order the results by these fields.              Use the &#x60;-&#x60; sign to denote descending order, e.g. &#x60;-MyFieldName&#x60;.  Numeric indexes may be used also, e.g. &#x60;2,-3&#x60;.              Multiple fields can be denoted by a comma e.g. &#x60;-MyFieldName,AnotherFieldName,-AFurtherFieldName&#x60;.              Default is null, the sort order specified in the query itself. | [optional]  |
| **filter** | **string?** | An ODATA filter per Finbourne.Filtering syntax. | [optional]  |
| **select** | **string?** | Default is null (meaning return all columns in the original query itself).  The values are in terms of the result column name from the original data set and are comma delimited.  The power of this comes in that you may aggregate the data if you wish  (that is the main reason for allowing this, in fact).  e.g.:  - &#x60;MyField&#x60;  - &#x60;Max(x) FILTER (WHERE y &gt; 12) as ABC&#x60; (max of a field, if another field lets it qualify, with a nice column name)  - &#x60;count(*)&#x60; (count the rows for the given group, that would produce a rather ugly column name, but  it works)  - &#x60;count(distinct x) as numOfXs&#x60;  If there was an illegal character in a field you are selecting from, you are responsible for bracketing it with [ ].   e.g.  - &#x60;some_field, count(*) as a, max(x) as b, min([column with space in name]) as nice_name&#x60;    where you would likely want to pass &#x60;1&#x60; as the &#x60;groupBy&#x60; also. | [optional]  |
| **groupBy** | **string?** | Groups by the specified fields.              A comma delimited list of: 1 based numeric indexes (cleaner), or repeats of the select expressions (a bit verbose and must match exactly).              e.g. &#x60;2,3&#x60;, &#x60;myColumn&#x60;.              Default is null (meaning no grouping will be performed on the selected columns).              This applies only over the result set being requested here, meaning indexes into the \&quot;select\&quot; parameter fields.              Only specify this if you are selecting aggregations in the \&quot;select\&quot; parameter. | [optional]  |
| **limit** | **int?** | When paginating, only return this number of records, page should also be specified. | [optional] [default to 0] |
| **page** | **int?** | 0-N based on chunk sized determined by the limit, ignored if limit &lt; 1. | [optional] [default to 0] |
| **jsonProper** | **bool?** | Should this be text/json (not json-encoded-as-a-string) | [optional] [default to false] |

### Return type

**string**

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

<a id="gethistory"></a>
# **GetHistory**
> BackgroundQueryResponse GetHistory (DateTimeOffset? startAt = null, DateTimeOffset? endAt = null, string? freeTextSearch = null, bool? showAll = null, bool? mayUseNativeStore = null)

GetHistory: Shows queries executed in a given historical time window (in Json format).

 Starts to load the historical query logs for a certain time range, search criteria, etc.  The following error codes are to be anticipated with standard Problem Detail reports: - 401 Unauthorized - 403 Forbidden 

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<HistoricallyExecutedQueriesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<HistoricallyExecutedQueriesApi>();
            var startAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Date time to start the search from.  Will default to Now - 1 Day (optional) 
            var endAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Date time to end the search at.  Defaults to now. (optional) 
            var freeTextSearch = "freeTextSearch_example";  // string? | Some test that must be in at least one field returned. (optional) 
            var showAll = false;  // bool? | For users with extra permissions, they may optionally see other users' queries. (optional)  (default to false)
            var mayUseNativeStore = true;  // bool? | Should a native data store (e.g. Athena or Fabric) be used over Elastic Search if available? (optional)  (default to true)

            try
            {
                // uncomment the below to set overrides at the request level
                // BackgroundQueryResponse result = apiInstance.GetHistory(startAt, endAt, freeTextSearch, showAll, mayUseNativeStore, opts: opts);

                // GetHistory: Shows queries executed in a given historical time window (in Json format).
                BackgroundQueryResponse result = apiInstance.GetHistory(startAt, endAt, freeTextSearch, showAll, mayUseNativeStore);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling HistoricallyExecutedQueriesApi.GetHistory: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetHistory: Shows queries executed in a given historical time window (in Json format).
    ApiResponse<BackgroundQueryResponse> response = apiInstance.GetHistoryWithHttpInfo(startAt, endAt, freeTextSearch, showAll, mayUseNativeStore);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling HistoricallyExecutedQueriesApi.GetHistoryWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **startAt** | **DateTimeOffset?** | Date time to start the search from.  Will default to Now - 1 Day | [optional]  |
| **endAt** | **DateTimeOffset?** | Date time to end the search at.  Defaults to now. | [optional]  |
| **freeTextSearch** | **string?** | Some test that must be in at least one field returned. | [optional]  |
| **showAll** | **bool?** | For users with extra permissions, they may optionally see other users&#39; queries. | [optional] [default to false] |
| **mayUseNativeStore** | **bool?** | Should a native data store (e.g. Athena or Fabric) be used over Elastic Search if available? | [optional] [default to true] |

### Return type

[**BackgroundQueryResponse**](BackgroundQueryResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Accepted |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getprogressofhistory"></a>
# **GetProgressOfHistory**
> BackgroundQueryProgressResponse GetProgressOfHistory (string executionId)

GetProgressOfHistory: View progress information (up until this point) of a history query

View progress information (up until this point) of previously started History query The following error codes are to be anticipated with standard Problem Detail reports: - 401 Unauthorized - 403 Forbidden - 404 Not Found : The requested query result doesn't exist and is not running. - 429 Too Many Requests : Please try your request again soon   1. The query has been executed successfully in the past yet the server-instance receiving this request (e.g. from a load balancer) doesn't yet have this data available.   1. By virtue of the request you have just placed this will have started to load from the persisted cache and will soon be available.   1. It is also the case that the original server-instance to process the original query is likely to already be able to service this request.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<HistoricallyExecutedQueriesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<HistoricallyExecutedQueriesApi>();
            var executionId = "executionId_example";  // string | ExecutionId returned when starting the query

            try
            {
                // uncomment the below to set overrides at the request level
                // BackgroundQueryProgressResponse result = apiInstance.GetProgressOfHistory(executionId, opts: opts);

                // GetProgressOfHistory: View progress information (up until this point) of a history query
                BackgroundQueryProgressResponse result = apiInstance.GetProgressOfHistory(executionId);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling HistoricallyExecutedQueriesApi.GetProgressOfHistory: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProgressOfHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetProgressOfHistory: View progress information (up until this point) of a history query
    ApiResponse<BackgroundQueryProgressResponse> response = apiInstance.GetProgressOfHistoryWithHttpInfo(executionId);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling HistoricallyExecutedQueriesApi.GetProgressOfHistoryWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **executionId** | **string** | ExecutionId returned when starting the query |  |

### Return type

[**BackgroundQueryProgressResponse**](BackgroundQueryProgressResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)


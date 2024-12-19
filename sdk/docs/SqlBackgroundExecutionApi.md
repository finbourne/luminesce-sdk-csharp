# Finbourne.Luminesce.Sdk.Api.SqlBackgroundExecutionApi

All URIs are relative to *https://fbn-prd.lusid.com/honeycomb*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CancelQuery**](SqlBackgroundExecutionApi.md#cancelquery) | **DELETE** /api/SqlBackground/{executionId} | CancelQuery: Cancel / Clear data from a previously run query |
| [**FetchQueryResultCsv**](SqlBackgroundExecutionApi.md#fetchqueryresultcsv) | **GET** /api/SqlBackground/{executionId}/csv | FetchQueryResultCsv: Fetch the result of a query as CSV |
| [**FetchQueryResultExcel**](SqlBackgroundExecutionApi.md#fetchqueryresultexcel) | **GET** /api/SqlBackground/{executionId}/excel | FetchQueryResultExcel: Fetch the result of a query as an Excel file |
| [**FetchQueryResultHistogram**](SqlBackgroundExecutionApi.md#fetchqueryresulthistogram) | **GET** /api/SqlBackground/{executionId}/histogram | FetchQueryResultHistogram: Construct a histogram of the result of a query |
| [**FetchQueryResultJson**](SqlBackgroundExecutionApi.md#fetchqueryresultjson) | **GET** /api/SqlBackground/{executionId}/json | FetchQueryResultJson: Fetch the result of a query as a JSON string |
| [**FetchQueryResultJsonProper**](SqlBackgroundExecutionApi.md#fetchqueryresultjsonproper) | **GET** /api/SqlBackground/{executionId}/jsonProper | FetchQueryResultJsonProper: Fetch the result of a query as JSON |
| [**FetchQueryResultParquet**](SqlBackgroundExecutionApi.md#fetchqueryresultparquet) | **GET** /api/SqlBackground/{executionId}/parquet | FetchQueryResultParquet: Fetch the result of a query as Parquet |
| [**FetchQueryResultPipe**](SqlBackgroundExecutionApi.md#fetchqueryresultpipe) | **GET** /api/SqlBackground/{executionId}/pipe | FetchQueryResultPipe: Fetch the result of a query as pipe-delimited |
| [**FetchQueryResultSqlite**](SqlBackgroundExecutionApi.md#fetchqueryresultsqlite) | **GET** /api/SqlBackground/{executionId}/sqlite | FetchQueryResultSqlite: Fetch the result of a query as SqLite |
| [**FetchQueryResultXml**](SqlBackgroundExecutionApi.md#fetchqueryresultxml) | **GET** /api/SqlBackground/{executionId}/xml | FetchQueryResultXml: Fetch the result of a query as XML |
| [**GetProgressOf**](SqlBackgroundExecutionApi.md#getprogressof) | **GET** /api/SqlBackground/{executionId} | GetProgressOf: View query progress up to this point |
| [**StartQuery**](SqlBackgroundExecutionApi.md#startquery) | **PUT** /api/SqlBackground | StartQuery: Start to Execute Sql in the background |

<a id="cancelquery"></a>
# **CancelQuery**
> BackgroundQueryCancelResponse CancelQuery (string executionId)

CancelQuery: Cancel / Clear data from a previously run query

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SqlBackgroundExecutionApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SqlBackgroundExecutionApi>();
            var executionId = "executionId_example";  // string | ExecutionId returned when starting the query

            try
            {
                // uncomment the below to set overrides at the request level
                // BackgroundQueryCancelResponse result = apiInstance.CancelQuery(executionId, opts: opts);

                // CancelQuery: Cancel / Clear data from a previously run query
                BackgroundQueryCancelResponse result = apiInstance.CancelQuery(executionId);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SqlBackgroundExecutionApi.CancelQuery: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CancelQueryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // CancelQuery: Cancel / Clear data from a previously run query
    ApiResponse<BackgroundQueryCancelResponse> response = apiInstance.CancelQueryWithHttpInfo(executionId);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SqlBackgroundExecutionApi.CancelQueryWithHttpInfo: " + e.Message);
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

<a id="fetchqueryresultcsv"></a>
# **FetchQueryResultCsv**
> string FetchQueryResultCsv (string executionId, bool? download = null, string? sortBy = null, string? filter = null, string? select = null, string? groupBy = null, int? limit = null, int? page = null, string? delimiter = null, string? escape = null, int? loadWaitMilliseconds = null)

FetchQueryResultCsv: Fetch the result of a query as CSV

Fetch the data in the format of the method's name (if available, or if not simply being informed it is not yet ready).  The following error codes are to be anticipated most with standard Problem Detail reports: - 400 BadRequest : Something failed with the execution of your query - 401 Unauthorized - 403 Forbidden - 404 Not Found : The requested query result doesn't (yet) exist. - 429 Too Many Requests : Please try your request again soon   1. The query has been executed successfully in the past yet the server-instance receiving this request (e.g. from a load balancer) doesn't yet have this data available.   1. By virtue of the request you have just placed this will have started to load from the persisted cache and will soon be available.   1. It is also the case that the original server-instance to process the original query is likely to already be able to service this request.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SqlBackgroundExecutionApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SqlBackgroundExecutionApi>();
            var executionId = "executionId_example";  // string | ExecutionId returned when starting the query
            var download = false;  // bool? | Makes this a file-download request (as opposed to returning the data in the response-body) (optional)  (default to false)
            var sortBy = "sortBy_example";  // string? | Order the results by these fields.              Use the `-` sign to denote descending order, e.g. `-MyFieldName`.  Numeric indexes may be used also, e.g. `2,-3`.              Multiple fields can be denoted by a comma e.g. `-MyFieldName,AnotherFieldName,-AFurtherFieldName`.              Default is null, the sort order specified in the query itself. (optional) 
            var filter = "filter_example";  // string? | An ODATA filter per Finbourne.Filtering syntax. (optional) 
            var select = "select_example";  // string? | Default is null (meaning return all columns in the original query itself).  The values are in terms of the result column name from the original data set and are comma delimited.  The power of this comes in that you may aggregate the data if you wish  (that is the main reason for allowing this, in fact).  e.g.:  - `MyField`  - `Max(x) FILTER (WHERE y > 12) as ABC` (max of a field, if another field lets it qualify, with a nice column name)  - `count(*)` (count the rows for the given group, that would produce a rather ugly column name, but  it works)  - `count(distinct x) as numOfXs`  If there was an illegal character in a field you are selecting from, you are responsible for bracketing it with [ ].   e.g.  - `some_field, count(*) as a, max(x) as b, min([column with space in name]) as nice_name`    where you would likely want to pass `1` as the `groupBy` also. (optional) 
            var groupBy = "groupBy_example";  // string? | Groups by the specified fields.              A comma delimited list of: 1 based numeric indexes (cleaner), or repeats of the select expressions (a bit verbose and must match exactly).              e.g. `2,3`, `myColumn`.              Default is null (meaning no grouping will be performed on the selected columns).              This applies only over the result set being requested here, meaning indexes into the \"select\" parameter fields.              Only specify this if you are selecting aggregations in the \"select\" parameter. (optional) 
            var limit = 0;  // int? | When paginating, only return this number of records, page should also be specified. (optional)  (default to 0)
            var page = 0;  // int? | 0-N based on chunk sized determined by the limit, ignored if limit < 1. (optional)  (default to 0)
            var delimiter = "delimiter_example";  // string? | Delimiter string to override the default (optional) 
            var escape = "escape_example";  // string? | Escape character to override the default (optional) 
            var loadWaitMilliseconds = 0;  // int? | Optional maximum additional wait period for post execution platform processing. (optional)  (default to 0)

            try
            {
                // uncomment the below to set overrides at the request level
                // string result = apiInstance.FetchQueryResultCsv(executionId, download, sortBy, filter, select, groupBy, limit, page, delimiter, escape, loadWaitMilliseconds, opts: opts);

                // FetchQueryResultCsv: Fetch the result of a query as CSV
                string result = apiInstance.FetchQueryResultCsv(executionId, download, sortBy, filter, select, groupBy, limit, page, delimiter, escape, loadWaitMilliseconds);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SqlBackgroundExecutionApi.FetchQueryResultCsv: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the FetchQueryResultCsvWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // FetchQueryResultCsv: Fetch the result of a query as CSV
    ApiResponse<string> response = apiInstance.FetchQueryResultCsvWithHttpInfo(executionId, download, sortBy, filter, select, groupBy, limit, page, delimiter, escape, loadWaitMilliseconds);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SqlBackgroundExecutionApi.FetchQueryResultCsvWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **executionId** | **string** | ExecutionId returned when starting the query |  |
| **download** | **bool?** | Makes this a file-download request (as opposed to returning the data in the response-body) | [optional] [default to false] |
| **sortBy** | **string?** | Order the results by these fields.              Use the &#x60;-&#x60; sign to denote descending order, e.g. &#x60;-MyFieldName&#x60;.  Numeric indexes may be used also, e.g. &#x60;2,-3&#x60;.              Multiple fields can be denoted by a comma e.g. &#x60;-MyFieldName,AnotherFieldName,-AFurtherFieldName&#x60;.              Default is null, the sort order specified in the query itself. | [optional]  |
| **filter** | **string?** | An ODATA filter per Finbourne.Filtering syntax. | [optional]  |
| **select** | **string?** | Default is null (meaning return all columns in the original query itself).  The values are in terms of the result column name from the original data set and are comma delimited.  The power of this comes in that you may aggregate the data if you wish  (that is the main reason for allowing this, in fact).  e.g.:  - &#x60;MyField&#x60;  - &#x60;Max(x) FILTER (WHERE y &gt; 12) as ABC&#x60; (max of a field, if another field lets it qualify, with a nice column name)  - &#x60;count(*)&#x60; (count the rows for the given group, that would produce a rather ugly column name, but  it works)  - &#x60;count(distinct x) as numOfXs&#x60;  If there was an illegal character in a field you are selecting from, you are responsible for bracketing it with [ ].   e.g.  - &#x60;some_field, count(*) as a, max(x) as b, min([column with space in name]) as nice_name&#x60;    where you would likely want to pass &#x60;1&#x60; as the &#x60;groupBy&#x60; also. | [optional]  |
| **groupBy** | **string?** | Groups by the specified fields.              A comma delimited list of: 1 based numeric indexes (cleaner), or repeats of the select expressions (a bit verbose and must match exactly).              e.g. &#x60;2,3&#x60;, &#x60;myColumn&#x60;.              Default is null (meaning no grouping will be performed on the selected columns).              This applies only over the result set being requested here, meaning indexes into the \&quot;select\&quot; parameter fields.              Only specify this if you are selecting aggregations in the \&quot;select\&quot; parameter. | [optional]  |
| **limit** | **int?** | When paginating, only return this number of records, page should also be specified. | [optional] [default to 0] |
| **page** | **int?** | 0-N based on chunk sized determined by the limit, ignored if limit &lt; 1. | [optional] [default to 0] |
| **delimiter** | **string?** | Delimiter string to override the default | [optional]  |
| **escape** | **string?** | Escape character to override the default | [optional]  |
| **loadWaitMilliseconds** | **int?** | Optional maximum additional wait period for post execution platform processing. | [optional] [default to 0] |

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

<a id="fetchqueryresultexcel"></a>
# **FetchQueryResultExcel**
> System.IO.Stream FetchQueryResultExcel (string executionId, string? sortBy = null, string? filter = null, string? select = null, string? groupBy = null, int? loadWaitMilliseconds = null)

FetchQueryResultExcel: Fetch the result of a query as an Excel file

Fetch the data in the format of the method's name (if available, or if not simply being informed it is not yet ready).  The following error codes are to be anticipated most with standard Problem Detail reports: - 400 BadRequest : Something failed with the execution of your query - 401 Unauthorized - 403 Forbidden - 404 Not Found : The requested query result doesn't (yet) exist. - 429 Too Many Requests : Please try your request again soon   1. The query has been executed successfully in the past yet the server-instance receiving this request (e.g. from a load balancer) doesn't yet have this data available.   1. By virtue of the request you have just placed this will have started to load from the persisted cache and will soon be available.   1. It is also the case that the original server-instance to process the original query is likely to already be able to service this request.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SqlBackgroundExecutionApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SqlBackgroundExecutionApi>();
            var executionId = "executionId_example";  // string | ExecutionId returned when starting the query
            var sortBy = "sortBy_example";  // string? | Order the results by these fields.              Use the `-` sign to denote descending order, e.g. `-MyFieldName`.  Numeric indexes may be used also, e.g. `2,-3`.              Multiple fields can be denoted by a comma e.g. `-MyFieldName,AnotherFieldName,-AFurtherFieldName`.              Default is null, the sort order specified in the query itself. (optional) 
            var filter = "filter_example";  // string? | An ODATA filter per Finbourne.Filtering syntax. (optional) 
            var select = "select_example";  // string? | Default is null (meaning return all columns in the original query itself).  The values are in terms of the result column name from the original data set and are comma delimited.  The power of this comes in that you may aggregate the data if you wish  (that is the main reason for allowing this, in fact).  e.g.:  - `MyField`  - `Max(x) FILTER (WHERE y > 12) as ABC` (max of a field, if another field lets it qualify, with a nice column name)  - `count(*)` (count the rows for the given group, that would produce a rather ugly column name, but  it works)  - `count(distinct x) as numOfXs`  If there was an illegal character in a field you are selecting from, you are responsible for bracketing it with [ ].   e.g.  - `some_field, count(*) as a, max(x) as b, min([column with space in name]) as nice_name`    where you would likely want to pass `1` as the `groupBy` also. (optional) 
            var groupBy = "groupBy_example";  // string? | Groups by the specified fields.              A comma delimited list of: 1 based numeric indexes (cleaner), or repeats of the select expressions (a bit verbose and must match exactly).              e.g. `2,3`, `myColumn`.              Default is null (meaning no grouping will be performed on the selected columns).              This applies only over the result set being requested here, meaning indexes into the \"select\" parameter fields.              Only specify this if you are selecting aggregations in the \"select\" parameter. (optional) 
            var loadWaitMilliseconds = 0;  // int? | Optional maximum additional wait period for post execution platform processing. (optional)  (default to 0)

            try
            {
                // uncomment the below to set overrides at the request level
                // System.IO.Stream result = apiInstance.FetchQueryResultExcel(executionId, sortBy, filter, select, groupBy, loadWaitMilliseconds, opts: opts);

                // FetchQueryResultExcel: Fetch the result of a query as an Excel file
                System.IO.Stream result = apiInstance.FetchQueryResultExcel(executionId, sortBy, filter, select, groupBy, loadWaitMilliseconds);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SqlBackgroundExecutionApi.FetchQueryResultExcel: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the FetchQueryResultExcelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // FetchQueryResultExcel: Fetch the result of a query as an Excel file
    ApiResponse<System.IO.Stream> response = apiInstance.FetchQueryResultExcelWithHttpInfo(executionId, sortBy, filter, select, groupBy, loadWaitMilliseconds);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SqlBackgroundExecutionApi.FetchQueryResultExcelWithHttpInfo: " + e.Message);
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
| **loadWaitMilliseconds** | **int?** | Optional maximum additional wait period for post execution platform processing. | [optional] [default to 0] |

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

<a id="fetchqueryresulthistogram"></a>
# **FetchQueryResultHistogram**
> string FetchQueryResultHistogram (string executionId, string timestampFieldName, DateTimeOffset? startAt = null, DateTimeOffset? endAt = null, string? bucketSize = null, string? filter = null, bool? jsonProper = null)

FetchQueryResultHistogram: Construct a histogram of the result of a query

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SqlBackgroundExecutionApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SqlBackgroundExecutionApi>();
            var executionId = "executionId_example";  // string | ExecutionId returned when starting the query
            var timestampFieldName = "timestampFieldName_example";  // string | Name of the timestamp field used in building the histogram
            var startAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Start point (of the timestampFieldName field) for the histogram (optional) 
            var endAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | End point (of the timestampFieldName field) for the histogram (optional) 
            var bucketSize = "bucketSize_example";  // string? | Optional histogram bucket width.  If not provided a set number of buckets between start/end range will be generated. (optional) 
            var filter = "filter_example";  // string? | An ODATA filter per Finbourne.Filtering syntax. (optional) 
            var jsonProper = false;  // bool? | Should this be text/json (not json-encoded-as-a-string) (optional)  (default to false)

            try
            {
                // uncomment the below to set overrides at the request level
                // string result = apiInstance.FetchQueryResultHistogram(executionId, timestampFieldName, startAt, endAt, bucketSize, filter, jsonProper, opts: opts);

                // FetchQueryResultHistogram: Construct a histogram of the result of a query
                string result = apiInstance.FetchQueryResultHistogram(executionId, timestampFieldName, startAt, endAt, bucketSize, filter, jsonProper);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SqlBackgroundExecutionApi.FetchQueryResultHistogram: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the FetchQueryResultHistogramWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // FetchQueryResultHistogram: Construct a histogram of the result of a query
    ApiResponse<string> response = apiInstance.FetchQueryResultHistogramWithHttpInfo(executionId, timestampFieldName, startAt, endAt, bucketSize, filter, jsonProper);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SqlBackgroundExecutionApi.FetchQueryResultHistogramWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **executionId** | **string** | ExecutionId returned when starting the query |  |
| **timestampFieldName** | **string** | Name of the timestamp field used in building the histogram |  |
| **startAt** | **DateTimeOffset?** | Start point (of the timestampFieldName field) for the histogram | [optional]  |
| **endAt** | **DateTimeOffset?** | End point (of the timestampFieldName field) for the histogram | [optional]  |
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

<a id="fetchqueryresultjson"></a>
# **FetchQueryResultJson**
> string FetchQueryResultJson (string executionId, string? sortBy = null, string? filter = null, string? select = null, string? groupBy = null, int? limit = null, int? page = null, int? loadWaitMilliseconds = null)

FetchQueryResultJson: Fetch the result of a query as a JSON string

 *Please move to '/jsonProper' instead.  This may be marked as Deprecated in the future.*  Fetch the data in the format of the method's name (if available, or if not simply being informed it is not yet ready).  The following error codes are to be anticipated most with standard Problem Detail reports: - 400 BadRequest : Something failed with the execution of your query - 401 Unauthorized - 403 Forbidden - 404 Not Found : The requested query result doesn't (yet) exist. - 429 Too Many Requests : Please try your request again soon   1. The query has been executed successfully in the past yet the server-instance receiving this request (e.g. from a load balancer) doesn't yet have this data available.   1. By virtue of the request you have just placed this will have started to load from the persisted cache and will soon be available.   1. It is also the case that the original server-instance to process the original query is likely to already be able to service this request.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SqlBackgroundExecutionApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SqlBackgroundExecutionApi>();
            var executionId = "executionId_example";  // string | ExecutionId returned when starting the query
            var sortBy = "sortBy_example";  // string? | Order the results by these fields.              Use the `-` sign to denote descending order, e.g. `-MyFieldName`.  Numeric indexes may be used also, e.g. `2,-3`.              Multiple fields can be denoted by a comma e.g. `-MyFieldName,AnotherFieldName,-AFurtherFieldName`.              Default is null, the sort order specified in the query itself. (optional) 
            var filter = "filter_example";  // string? | An ODATA filter per Finbourne.Filtering syntax. (optional) 
            var select = "select_example";  // string? | Default is null (meaning return all columns in the original query itself).  The values are in terms of the result column name from the original data set and are comma delimited.  The power of this comes in that you may aggregate the data if you wish  (that is the main reason for allowing this, in fact).  e.g.:  - `MyField`  - `Max(x) FILTER (WHERE y > 12) as ABC` (max of a field, if another field lets it qualify, with a nice column name)  - `count(*)` (count the rows for the given group, that would produce a rather ugly column name, but  it works)  - `count(distinct x) as numOfXs`  If there was an illegal character in a field you are selecting from, you are responsible for bracketing it with [ ].   e.g.  - `some_field, count(*) as a, max(x) as b, min([column with space in name]) as nice_name`    where you would likely want to pass `1` as the `groupBy` also. (optional) 
            var groupBy = "groupBy_example";  // string? | Groups by the specified fields.              A comma delimited list of: 1 based numeric indexes (cleaner), or repeats of the select expressions (a bit verbose and must match exactly).              e.g. `2,3`, `myColumn`.              Default is null (meaning no grouping will be performed on the selected columns).              This applies only over the result set being requested here, meaning indexes into the \"select\" parameter fields.              Only specify this if you are selecting aggregations in the \"select\" parameter. (optional) 
            var limit = 0;  // int? | When paginating, only return this number of records, page should also be specified. (optional)  (default to 0)
            var page = 0;  // int? | 0-N based on chunk sized determined by the limit, ignored if limit < 1. (optional)  (default to 0)
            var loadWaitMilliseconds = 0;  // int? | Optional maximum additional wait period for post execution platform processing. (optional)  (default to 0)

            try
            {
                // uncomment the below to set overrides at the request level
                // string result = apiInstance.FetchQueryResultJson(executionId, sortBy, filter, select, groupBy, limit, page, loadWaitMilliseconds, opts: opts);

                // FetchQueryResultJson: Fetch the result of a query as a JSON string
                string result = apiInstance.FetchQueryResultJson(executionId, sortBy, filter, select, groupBy, limit, page, loadWaitMilliseconds);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SqlBackgroundExecutionApi.FetchQueryResultJson: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the FetchQueryResultJsonWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // FetchQueryResultJson: Fetch the result of a query as a JSON string
    ApiResponse<string> response = apiInstance.FetchQueryResultJsonWithHttpInfo(executionId, sortBy, filter, select, groupBy, limit, page, loadWaitMilliseconds);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SqlBackgroundExecutionApi.FetchQueryResultJsonWithHttpInfo: " + e.Message);
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
| **loadWaitMilliseconds** | **int?** | Optional maximum additional wait period for post execution platform processing. | [optional] [default to 0] |

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

<a id="fetchqueryresultjsonproper"></a>
# **FetchQueryResultJsonProper**
> string FetchQueryResultJsonProper (string executionId, bool? download = null, string? sortBy = null, string? filter = null, string? select = null, string? groupBy = null, int? limit = null, int? page = null, int? loadWaitMilliseconds = null)

FetchQueryResultJsonProper: Fetch the result of a query as JSON

Fetch the data in the format of the method's name (if available, or if not simply being informed it is not yet ready).  The following error codes are to be anticipated most with standard Problem Detail reports: - 400 BadRequest : Something failed with the execution of your query - 401 Unauthorized - 403 Forbidden - 404 Not Found : The requested query result doesn't (yet) exist. - 429 Too Many Requests : Please try your request again soon   1. The query has been executed successfully in the past yet the server-instance receiving this request (e.g. from a load balancer) doesn't yet have this data available.   1. By virtue of the request you have just placed this will have started to load from the persisted cache and will soon be available.   1. It is also the case that the original server-instance to process the original query is likely to already be able to service this request.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SqlBackgroundExecutionApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SqlBackgroundExecutionApi>();
            var executionId = "executionId_example";  // string | ExecutionId returned when starting the query
            var download = false;  // bool? | Makes this a file-download request (as opposed to returning the data in the response-body) (optional)  (default to false)
            var sortBy = "sortBy_example";  // string? | Order the results by these fields.              Use the `-` sign to denote descending order, e.g. `-MyFieldName`.  Numeric indexes may be used also, e.g. `2,-3`.              Multiple fields can be denoted by a comma e.g. `-MyFieldName,AnotherFieldName,-AFurtherFieldName`.              Default is null, the sort order specified in the query itself. (optional) 
            var filter = "filter_example";  // string? | An ODATA filter per Finbourne.Filtering syntax. (optional) 
            var select = "select_example";  // string? | Default is null (meaning return all columns in the original query itself).  The values are in terms of the result column name from the original data set and are comma delimited.  The power of this comes in that you may aggregate the data if you wish  (that is the main reason for allowing this, in fact).  e.g.:  - `MyField`  - `Max(x) FILTER (WHERE y > 12) as ABC` (max of a field, if another field lets it qualify, with a nice column name)  - `count(*)` (count the rows for the given group, that would produce a rather ugly column name, but  it works)  - `count(distinct x) as numOfXs`  If there was an illegal character in a field you are selecting from, you are responsible for bracketing it with [ ].   e.g.  - `some_field, count(*) as a, max(x) as b, min([column with space in name]) as nice_name`    where you would likely want to pass `1` as the `groupBy` also. (optional) 
            var groupBy = "groupBy_example";  // string? | Groups by the specified fields.              A comma delimited list of: 1 based numeric indexes (cleaner), or repeats of the select expressions (a bit verbose and must match exactly).              e.g. `2,3`, `myColumn`.              Default is null (meaning no grouping will be performed on the selected columns).              This applies only over the result set being requested here, meaning indexes into the \"select\" parameter fields.              Only specify this if you are selecting aggregations in the \"select\" parameter. (optional) 
            var limit = 0;  // int? | When paginating, only return this number of records, page should also be specified. (optional)  (default to 0)
            var page = 0;  // int? | 0-N based on chunk sized determined by the limit, ignored if limit < 1. (optional)  (default to 0)
            var loadWaitMilliseconds = 0;  // int? | Optional maximum additional wait period for post execution platform processing. (optional)  (default to 0)

            try
            {
                // uncomment the below to set overrides at the request level
                // string result = apiInstance.FetchQueryResultJsonProper(executionId, download, sortBy, filter, select, groupBy, limit, page, loadWaitMilliseconds, opts: opts);

                // FetchQueryResultJsonProper: Fetch the result of a query as JSON
                string result = apiInstance.FetchQueryResultJsonProper(executionId, download, sortBy, filter, select, groupBy, limit, page, loadWaitMilliseconds);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SqlBackgroundExecutionApi.FetchQueryResultJsonProper: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the FetchQueryResultJsonProperWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // FetchQueryResultJsonProper: Fetch the result of a query as JSON
    ApiResponse<string> response = apiInstance.FetchQueryResultJsonProperWithHttpInfo(executionId, download, sortBy, filter, select, groupBy, limit, page, loadWaitMilliseconds);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SqlBackgroundExecutionApi.FetchQueryResultJsonProperWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **executionId** | **string** | ExecutionId returned when starting the query |  |
| **download** | **bool?** | Makes this a file-download request (as opposed to returning the data in the response-body) | [optional] [default to false] |
| **sortBy** | **string?** | Order the results by these fields.              Use the &#x60;-&#x60; sign to denote descending order, e.g. &#x60;-MyFieldName&#x60;.  Numeric indexes may be used also, e.g. &#x60;2,-3&#x60;.              Multiple fields can be denoted by a comma e.g. &#x60;-MyFieldName,AnotherFieldName,-AFurtherFieldName&#x60;.              Default is null, the sort order specified in the query itself. | [optional]  |
| **filter** | **string?** | An ODATA filter per Finbourne.Filtering syntax. | [optional]  |
| **select** | **string?** | Default is null (meaning return all columns in the original query itself).  The values are in terms of the result column name from the original data set and are comma delimited.  The power of this comes in that you may aggregate the data if you wish  (that is the main reason for allowing this, in fact).  e.g.:  - &#x60;MyField&#x60;  - &#x60;Max(x) FILTER (WHERE y &gt; 12) as ABC&#x60; (max of a field, if another field lets it qualify, with a nice column name)  - &#x60;count(*)&#x60; (count the rows for the given group, that would produce a rather ugly column name, but  it works)  - &#x60;count(distinct x) as numOfXs&#x60;  If there was an illegal character in a field you are selecting from, you are responsible for bracketing it with [ ].   e.g.  - &#x60;some_field, count(*) as a, max(x) as b, min([column with space in name]) as nice_name&#x60;    where you would likely want to pass &#x60;1&#x60; as the &#x60;groupBy&#x60; also. | [optional]  |
| **groupBy** | **string?** | Groups by the specified fields.              A comma delimited list of: 1 based numeric indexes (cleaner), or repeats of the select expressions (a bit verbose and must match exactly).              e.g. &#x60;2,3&#x60;, &#x60;myColumn&#x60;.              Default is null (meaning no grouping will be performed on the selected columns).              This applies only over the result set being requested here, meaning indexes into the \&quot;select\&quot; parameter fields.              Only specify this if you are selecting aggregations in the \&quot;select\&quot; parameter. | [optional]  |
| **limit** | **int?** | When paginating, only return this number of records, page should also be specified. | [optional] [default to 0] |
| **page** | **int?** | 0-N based on chunk sized determined by the limit, ignored if limit &lt; 1. | [optional] [default to 0] |
| **loadWaitMilliseconds** | **int?** | Optional maximum additional wait period for post execution platform processing. | [optional] [default to 0] |

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

<a id="fetchqueryresultparquet"></a>
# **FetchQueryResultParquet**
> System.IO.Stream FetchQueryResultParquet (string executionId, string? sortBy = null, string? filter = null, string? select = null, string? groupBy = null, int? loadWaitMilliseconds = null)

FetchQueryResultParquet: Fetch the result of a query as Parquet

Fetch the data in the format of the method's name (if available, or if not simply being informed it is not yet ready).  The following error codes are to be anticipated most with standard Problem Detail reports: - 400 BadRequest : Something failed with the execution of your query - 401 Unauthorized - 403 Forbidden - 404 Not Found : The requested query result doesn't (yet) exist. - 429 Too Many Requests : Please try your request again soon   1. The query has been executed successfully in the past yet the server-instance receiving this request (e.g. from a load balancer) doesn't yet have this data available.   1. By virtue of the request you have just placed this will have started to load from the persisted cache and will soon be available.   1. It is also the case that the original server-instance to process the original query is likely to already be able to service this request.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SqlBackgroundExecutionApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SqlBackgroundExecutionApi>();
            var executionId = "executionId_example";  // string | ExecutionId returned when starting the query
            var sortBy = "sortBy_example";  // string? | Order the results by these fields.              Use the `-` sign to denote descending order, e.g. `-MyFieldName`.  Numeric indexes may be used also, e.g. `2,-3`.              Multiple fields can be denoted by a comma e.g. `-MyFieldName,AnotherFieldName,-AFurtherFieldName`.              Default is null, the sort order specified in the query itself. (optional) 
            var filter = "filter_example";  // string? | An ODATA filter per Finbourne.Filtering syntax. (optional) 
            var select = "select_example";  // string? | Default is null (meaning return all columns in the original query itself).  The values are in terms of the result column name from the original data set and are comma delimited.  The power of this comes in that you may aggregate the data if you wish  (that is the main reason for allowing this, in fact).  e.g.:  - `MyField`  - `Max(x) FILTER (WHERE y > 12) as ABC` (max of a field, if another field lets it qualify, with a nice column name)  - `count(*)` (count the rows for the given group, that would produce a rather ugly column name, but  it works)  - `count(distinct x) as numOfXs`  If there was an illegal character in a field you are selecting from, you are responsible for bracketing it with [ ].   e.g.  - `some_field, count(*) as a, max(x) as b, min([column with space in name]) as nice_name`    where you would likely want to pass `1` as the `groupBy` also. (optional) 
            var groupBy = "groupBy_example";  // string? | Groups by the specified fields.              A comma delimited list of: 1 based numeric indexes (cleaner), or repeats of the select expressions (a bit verbose and must match exactly).              e.g. `2,3`, `myColumn`.              Default is null (meaning no grouping will be performed on the selected columns).              This applies only over the result set being requested here, meaning indexes into the \"select\" parameter fields.              Only specify this if you are selecting aggregations in the \"select\" parameter. (optional) 
            var loadWaitMilliseconds = 0;  // int? | Optional maximum additional wait period for post execution platform processing. (optional)  (default to 0)

            try
            {
                // uncomment the below to set overrides at the request level
                // System.IO.Stream result = apiInstance.FetchQueryResultParquet(executionId, sortBy, filter, select, groupBy, loadWaitMilliseconds, opts: opts);

                // FetchQueryResultParquet: Fetch the result of a query as Parquet
                System.IO.Stream result = apiInstance.FetchQueryResultParquet(executionId, sortBy, filter, select, groupBy, loadWaitMilliseconds);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SqlBackgroundExecutionApi.FetchQueryResultParquet: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the FetchQueryResultParquetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // FetchQueryResultParquet: Fetch the result of a query as Parquet
    ApiResponse<System.IO.Stream> response = apiInstance.FetchQueryResultParquetWithHttpInfo(executionId, sortBy, filter, select, groupBy, loadWaitMilliseconds);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SqlBackgroundExecutionApi.FetchQueryResultParquetWithHttpInfo: " + e.Message);
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
| **loadWaitMilliseconds** | **int?** | Optional maximum additional wait period for post execution platform processing. | [optional] [default to 0] |

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

<a id="fetchqueryresultpipe"></a>
# **FetchQueryResultPipe**
> string FetchQueryResultPipe (string executionId, bool? download = null, string? sortBy = null, string? filter = null, string? select = null, string? groupBy = null, int? limit = null, int? page = null, int? loadWaitMilliseconds = null)

FetchQueryResultPipe: Fetch the result of a query as pipe-delimited

Fetch the data in the format of the method's name (if available, or if not simply being informed it is not yet ready).  The following error codes are to be anticipated most with standard Problem Detail reports: - 400 BadRequest : Something failed with the execution of your query - 401 Unauthorized - 403 Forbidden - 404 Not Found : The requested query result doesn't (yet) exist. - 429 Too Many Requests : Please try your request again soon   1. The query has been executed successfully in the past yet the server-instance receiving this request (e.g. from a load balancer) doesn't yet have this data available.   1. By virtue of the request you have just placed this will have started to load from the persisted cache and will soon be available.   1. It is also the case that the original server-instance to process the original query is likely to already be able to service this request.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SqlBackgroundExecutionApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SqlBackgroundExecutionApi>();
            var executionId = "executionId_example";  // string | ExecutionId returned when starting the query
            var download = false;  // bool? | Makes this a file-download request (as opposed to returning the data in the response-body) (optional)  (default to false)
            var sortBy = "sortBy_example";  // string? | Order the results by these fields.              Use the `-` sign to denote descending order, e.g. `-MyFieldName`.  Numeric indexes may be used also, e.g. `2,-3`.              Multiple fields can be denoted by a comma e.g. `-MyFieldName,AnotherFieldName,-AFurtherFieldName`.              Default is null, the sort order specified in the query itself. (optional) 
            var filter = "filter_example";  // string? | An ODATA filter per Finbourne.Filtering syntax. (optional) 
            var select = "select_example";  // string? | Default is null (meaning return all columns in the original query itself).  The values are in terms of the result column name from the original data set and are comma delimited.  The power of this comes in that you may aggregate the data if you wish  (that is the main reason for allowing this, in fact).  e.g.:  - `MyField`  - `Max(x) FILTER (WHERE y > 12) as ABC` (max of a field, if another field lets it qualify, with a nice column name)  - `count(*)` (count the rows for the given group, that would produce a rather ugly column name, but  it works)  - `count(distinct x) as numOfXs`  If there was an illegal character in a field you are selecting from, you are responsible for bracketing it with [ ].   e.g.  - `some_field, count(*) as a, max(x) as b, min([column with space in name]) as nice_name`    where you would likely want to pass `1` as the `groupBy` also. (optional) 
            var groupBy = "groupBy_example";  // string? | Groups by the specified fields.              A comma delimited list of: 1 based numeric indexes (cleaner), or repeats of the select expressions (a bit verbose and must match exactly).              e.g. `2,3`, `myColumn`.              Default is null (meaning no grouping will be performed on the selected columns).              This applies only over the result set being requested here, meaning indexes into the \"select\" parameter fields.              Only specify this if you are selecting aggregations in the \"select\" parameter. (optional) 
            var limit = 0;  // int? | When paginating, only return this number of records, page should also be specified. (optional)  (default to 0)
            var page = 0;  // int? | 0-N based on chunk sized determined by the limit, ignored if limit < 1. (optional)  (default to 0)
            var loadWaitMilliseconds = 0;  // int? | Optional maximum additional wait period for post execution platform processing. (optional)  (default to 0)

            try
            {
                // uncomment the below to set overrides at the request level
                // string result = apiInstance.FetchQueryResultPipe(executionId, download, sortBy, filter, select, groupBy, limit, page, loadWaitMilliseconds, opts: opts);

                // FetchQueryResultPipe: Fetch the result of a query as pipe-delimited
                string result = apiInstance.FetchQueryResultPipe(executionId, download, sortBy, filter, select, groupBy, limit, page, loadWaitMilliseconds);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SqlBackgroundExecutionApi.FetchQueryResultPipe: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the FetchQueryResultPipeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // FetchQueryResultPipe: Fetch the result of a query as pipe-delimited
    ApiResponse<string> response = apiInstance.FetchQueryResultPipeWithHttpInfo(executionId, download, sortBy, filter, select, groupBy, limit, page, loadWaitMilliseconds);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SqlBackgroundExecutionApi.FetchQueryResultPipeWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **executionId** | **string** | ExecutionId returned when starting the query |  |
| **download** | **bool?** | Makes this a file-download request (as opposed to returning the data in the response-body) | [optional] [default to false] |
| **sortBy** | **string?** | Order the results by these fields.              Use the &#x60;-&#x60; sign to denote descending order, e.g. &#x60;-MyFieldName&#x60;.  Numeric indexes may be used also, e.g. &#x60;2,-3&#x60;.              Multiple fields can be denoted by a comma e.g. &#x60;-MyFieldName,AnotherFieldName,-AFurtherFieldName&#x60;.              Default is null, the sort order specified in the query itself. | [optional]  |
| **filter** | **string?** | An ODATA filter per Finbourne.Filtering syntax. | [optional]  |
| **select** | **string?** | Default is null (meaning return all columns in the original query itself).  The values are in terms of the result column name from the original data set and are comma delimited.  The power of this comes in that you may aggregate the data if you wish  (that is the main reason for allowing this, in fact).  e.g.:  - &#x60;MyField&#x60;  - &#x60;Max(x) FILTER (WHERE y &gt; 12) as ABC&#x60; (max of a field, if another field lets it qualify, with a nice column name)  - &#x60;count(*)&#x60; (count the rows for the given group, that would produce a rather ugly column name, but  it works)  - &#x60;count(distinct x) as numOfXs&#x60;  If there was an illegal character in a field you are selecting from, you are responsible for bracketing it with [ ].   e.g.  - &#x60;some_field, count(*) as a, max(x) as b, min([column with space in name]) as nice_name&#x60;    where you would likely want to pass &#x60;1&#x60; as the &#x60;groupBy&#x60; also. | [optional]  |
| **groupBy** | **string?** | Groups by the specified fields.              A comma delimited list of: 1 based numeric indexes (cleaner), or repeats of the select expressions (a bit verbose and must match exactly).              e.g. &#x60;2,3&#x60;, &#x60;myColumn&#x60;.              Default is null (meaning no grouping will be performed on the selected columns).              This applies only over the result set being requested here, meaning indexes into the \&quot;select\&quot; parameter fields.              Only specify this if you are selecting aggregations in the \&quot;select\&quot; parameter. | [optional]  |
| **limit** | **int?** | When paginating, only return this number of records, page should also be specified. | [optional] [default to 0] |
| **page** | **int?** | 0-N based on chunk sized determined by the limit, ignored if limit &lt; 1. | [optional] [default to 0] |
| **loadWaitMilliseconds** | **int?** | Optional maximum additional wait period for post execution platform processing. | [optional] [default to 0] |

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

<a id="fetchqueryresultsqlite"></a>
# **FetchQueryResultSqlite**
> System.IO.Stream FetchQueryResultSqlite (string executionId, string? sortBy = null, string? filter = null, string? select = null, string? groupBy = null, int? loadWaitMilliseconds = null)

FetchQueryResultSqlite: Fetch the result of a query as SqLite

Fetch the data in the format of the method's name (if available, or if not simply being informed it is not yet ready).  The following error codes are to be anticipated most with standard Problem Detail reports: - 400 BadRequest : Something failed with the execution of your query - 401 Unauthorized - 403 Forbidden - 404 Not Found : The requested query result doesn't (yet) exist. - 429 Too Many Requests : Please try your request again soon   1. The query has been executed successfully in the past yet the server-instance receiving this request (e.g. from a load balancer) doesn't yet have this data available.   1. By virtue of the request you have just placed this will have started to load from the persisted cache and will soon be available.   1. It is also the case that the original server-instance to process the original query is likely to already be able to service this request.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SqlBackgroundExecutionApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SqlBackgroundExecutionApi>();
            var executionId = "executionId_example";  // string | ExecutionId returned when starting the query
            var sortBy = "sortBy_example";  // string? | Order the results by these fields.              Use the `-` sign to denote descending order, e.g. `-MyFieldName`.  Numeric indexes may be used also, e.g. `2,-3`.              Multiple fields can be denoted by a comma e.g. `-MyFieldName,AnotherFieldName,-AFurtherFieldName`.              Default is null, the sort order specified in the query itself. (optional) 
            var filter = "filter_example";  // string? | An ODATA filter per Finbourne.Filtering syntax. (optional) 
            var select = "select_example";  // string? | Default is null (meaning return all columns in the original query itself).  The values are in terms of the result column name from the original data set and are comma delimited.  The power of this comes in that you may aggregate the data if you wish  (that is the main reason for allowing this, in fact).  e.g.:  - `MyField`  - `Max(x) FILTER (WHERE y > 12) as ABC` (max of a field, if another field lets it qualify, with a nice column name)  - `count(*)` (count the rows for the given group, that would produce a rather ugly column name, but  it works)  - `count(distinct x) as numOfXs`  If there was an illegal character in a field you are selecting from, you are responsible for bracketing it with [ ].   e.g.  - `some_field, count(*) as a, max(x) as b, min([column with space in name]) as nice_name`    where you would likely want to pass `1` as the `groupBy` also. (optional) 
            var groupBy = "groupBy_example";  // string? | Groups by the specified fields.              A comma delimited list of: 1 based numeric indexes (cleaner), or repeats of the select expressions (a bit verbose and must match exactly).              e.g. `2,3`, `myColumn`.              Default is null (meaning no grouping will be performed on the selected columns).              This applies only over the result set being requested here, meaning indexes into the \"select\" parameter fields.              Only specify this if you are selecting aggregations in the \"select\" parameter. (optional) 
            var loadWaitMilliseconds = 0;  // int? | Optional maximum additional wait period for post execution platform processing. (optional)  (default to 0)

            try
            {
                // uncomment the below to set overrides at the request level
                // System.IO.Stream result = apiInstance.FetchQueryResultSqlite(executionId, sortBy, filter, select, groupBy, loadWaitMilliseconds, opts: opts);

                // FetchQueryResultSqlite: Fetch the result of a query as SqLite
                System.IO.Stream result = apiInstance.FetchQueryResultSqlite(executionId, sortBy, filter, select, groupBy, loadWaitMilliseconds);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SqlBackgroundExecutionApi.FetchQueryResultSqlite: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the FetchQueryResultSqliteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // FetchQueryResultSqlite: Fetch the result of a query as SqLite
    ApiResponse<System.IO.Stream> response = apiInstance.FetchQueryResultSqliteWithHttpInfo(executionId, sortBy, filter, select, groupBy, loadWaitMilliseconds);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SqlBackgroundExecutionApi.FetchQueryResultSqliteWithHttpInfo: " + e.Message);
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
| **loadWaitMilliseconds** | **int?** | Optional maximum additional wait period for post execution platform processing. | [optional] [default to 0] |

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

<a id="fetchqueryresultxml"></a>
# **FetchQueryResultXml**
> string FetchQueryResultXml (string executionId, bool? download = null, string? sortBy = null, string? filter = null, string? select = null, string? groupBy = null, int? limit = null, int? page = null, int? loadWaitMilliseconds = null)

FetchQueryResultXml: Fetch the result of a query as XML

Fetch the data in the format of the method's name (if available, or if not simply being informed it is not yet ready).  The following error codes are to be anticipated most with standard Problem Detail reports: - 400 BadRequest : Something failed with the execution of your query - 401 Unauthorized - 403 Forbidden - 404 Not Found : The requested query result doesn't (yet) exist. - 429 Too Many Requests : Please try your request again soon   1. The query has been executed successfully in the past yet the server-instance receiving this request (e.g. from a load balancer) doesn't yet have this data available.   1. By virtue of the request you have just placed this will have started to load from the persisted cache and will soon be available.   1. It is also the case that the original server-instance to process the original query is likely to already be able to service this request.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SqlBackgroundExecutionApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SqlBackgroundExecutionApi>();
            var executionId = "executionId_example";  // string | ExecutionId returned when starting the query
            var download = false;  // bool? | Makes this a file-download request (as opposed to returning the data in the response-body) (optional)  (default to false)
            var sortBy = "sortBy_example";  // string? | Order the results by these fields.              Use the `-` sign to denote descending order, e.g. `-MyFieldName`.  Numeric indexes may be used also, e.g. `2,-3`.              Multiple fields can be denoted by a comma e.g. `-MyFieldName,AnotherFieldName,-AFurtherFieldName`.              Default is null, the sort order specified in the query itself. (optional) 
            var filter = "filter_example";  // string? | An ODATA filter per Finbourne.Filtering syntax. (optional) 
            var select = "select_example";  // string? | Default is null (meaning return all columns in the original query itself).  The values are in terms of the result column name from the original data set and are comma delimited.  The power of this comes in that you may aggregate the data if you wish  (that is the main reason for allowing this, in fact).  e.g.:  - `MyField`  - `Max(x) FILTER (WHERE y > 12) as ABC` (max of a field, if another field lets it qualify, with a nice column name)  - `count(*)` (count the rows for the given group, that would produce a rather ugly column name, but  it works)  - `count(distinct x) as numOfXs`  If there was an illegal character in a field you are selecting from, you are responsible for bracketing it with [ ].   e.g.  - `some_field, count(*) as a, max(x) as b, min([column with space in name]) as nice_name`    where you would likely want to pass `1` as the `groupBy` also. (optional) 
            var groupBy = "groupBy_example";  // string? | Groups by the specified fields.              A comma delimited list of: 1 based numeric indexes (cleaner), or repeats of the select expressions (a bit verbose and must match exactly).              e.g. `2,3`, `myColumn`.              Default is null (meaning no grouping will be performed on the selected columns).              This applies only over the result set being requested here, meaning indexes into the \"select\" parameter fields.              Only specify this if you are selecting aggregations in the \"select\" parameter. (optional) 
            var limit = 0;  // int? | When paginating, only return this number of records, page should also be specified. (optional)  (default to 0)
            var page = 0;  // int? | 0-N based on chunk sized determined by the limit, ignored if limit < 1. (optional)  (default to 0)
            var loadWaitMilliseconds = 0;  // int? | Optional maximum additional wait period for post execution platform processing. (optional)  (default to 0)

            try
            {
                // uncomment the below to set overrides at the request level
                // string result = apiInstance.FetchQueryResultXml(executionId, download, sortBy, filter, select, groupBy, limit, page, loadWaitMilliseconds, opts: opts);

                // FetchQueryResultXml: Fetch the result of a query as XML
                string result = apiInstance.FetchQueryResultXml(executionId, download, sortBy, filter, select, groupBy, limit, page, loadWaitMilliseconds);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SqlBackgroundExecutionApi.FetchQueryResultXml: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the FetchQueryResultXmlWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // FetchQueryResultXml: Fetch the result of a query as XML
    ApiResponse<string> response = apiInstance.FetchQueryResultXmlWithHttpInfo(executionId, download, sortBy, filter, select, groupBy, limit, page, loadWaitMilliseconds);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SqlBackgroundExecutionApi.FetchQueryResultXmlWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **executionId** | **string** | ExecutionId returned when starting the query |  |
| **download** | **bool?** | Makes this a file-download request (as opposed to returning the data in the response-body) | [optional] [default to false] |
| **sortBy** | **string?** | Order the results by these fields.              Use the &#x60;-&#x60; sign to denote descending order, e.g. &#x60;-MyFieldName&#x60;.  Numeric indexes may be used also, e.g. &#x60;2,-3&#x60;.              Multiple fields can be denoted by a comma e.g. &#x60;-MyFieldName,AnotherFieldName,-AFurtherFieldName&#x60;.              Default is null, the sort order specified in the query itself. | [optional]  |
| **filter** | **string?** | An ODATA filter per Finbourne.Filtering syntax. | [optional]  |
| **select** | **string?** | Default is null (meaning return all columns in the original query itself).  The values are in terms of the result column name from the original data set and are comma delimited.  The power of this comes in that you may aggregate the data if you wish  (that is the main reason for allowing this, in fact).  e.g.:  - &#x60;MyField&#x60;  - &#x60;Max(x) FILTER (WHERE y &gt; 12) as ABC&#x60; (max of a field, if another field lets it qualify, with a nice column name)  - &#x60;count(*)&#x60; (count the rows for the given group, that would produce a rather ugly column name, but  it works)  - &#x60;count(distinct x) as numOfXs&#x60;  If there was an illegal character in a field you are selecting from, you are responsible for bracketing it with [ ].   e.g.  - &#x60;some_field, count(*) as a, max(x) as b, min([column with space in name]) as nice_name&#x60;    where you would likely want to pass &#x60;1&#x60; as the &#x60;groupBy&#x60; also. | [optional]  |
| **groupBy** | **string?** | Groups by the specified fields.              A comma delimited list of: 1 based numeric indexes (cleaner), or repeats of the select expressions (a bit verbose and must match exactly).              e.g. &#x60;2,3&#x60;, &#x60;myColumn&#x60;.              Default is null (meaning no grouping will be performed on the selected columns).              This applies only over the result set being requested here, meaning indexes into the \&quot;select\&quot; parameter fields.              Only specify this if you are selecting aggregations in the \&quot;select\&quot; parameter. | [optional]  |
| **limit** | **int?** | When paginating, only return this number of records, page should also be specified. | [optional] [default to 0] |
| **page** | **int?** | 0-N based on chunk sized determined by the limit, ignored if limit &lt; 1. | [optional] [default to 0] |
| **loadWaitMilliseconds** | **int?** | Optional maximum additional wait period for post execution platform processing. | [optional] [default to 0] |

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

<a id="getprogressof"></a>
# **GetProgressOf**
> BackgroundQueryProgressResponse GetProgressOf (string executionId, bool? buildFromLogs = null)

GetProgressOf: View query progress up to this point

View progress information (up until this point and starting from the last point requested) The following error codes are to be anticipated most with standard Problem Detail reports: - 401 Unauthorized - 403 Forbidden - 404 Not Found : The requested query result doesn't exist and is not running. - 429 Too Many Requests : Please try your request again soon   1. The query has been executed successfully in the past yet the server-instance receiving this request (e.g. from a load balancer) doesn't yet have this data available.   1. By virtue of the request you have just placed this will have started to load from the persisted cache and will soon be available.   1. It is also the case that the original server-instance to process the original query is likely to already be able to service this request.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SqlBackgroundExecutionApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SqlBackgroundExecutionApi>();
            var executionId = "executionId_example";  // string | ExecutionId returned when starting the query
            var buildFromLogs = true;  // bool? | Should the response state be build from query logs if missing from the shared-db-state?  False will mean `404 Not Found` in cases where it was a real query but has passed its `keepForSeconds`  since the query completed (as well as 'this was not a query at all' of course) (optional)  (default to true)

            try
            {
                // uncomment the below to set overrides at the request level
                // BackgroundQueryProgressResponse result = apiInstance.GetProgressOf(executionId, buildFromLogs, opts: opts);

                // GetProgressOf: View query progress up to this point
                BackgroundQueryProgressResponse result = apiInstance.GetProgressOf(executionId, buildFromLogs);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SqlBackgroundExecutionApi.GetProgressOf: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProgressOfWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetProgressOf: View query progress up to this point
    ApiResponse<BackgroundQueryProgressResponse> response = apiInstance.GetProgressOfWithHttpInfo(executionId, buildFromLogs);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SqlBackgroundExecutionApi.GetProgressOfWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **executionId** | **string** | ExecutionId returned when starting the query |  |
| **buildFromLogs** | **bool?** | Should the response state be build from query logs if missing from the shared-db-state?  False will mean &#x60;404 Not Found&#x60; in cases where it was a real query but has passed its &#x60;keepForSeconds&#x60;  since the query completed (as well as &#39;this was not a query at all&#39; of course) | [optional] [default to true] |

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

<a id="startquery"></a>
# **StartQuery**
> BackgroundQueryResponse StartQuery (string body, string? executionId = null, Dictionary<string, string>? scalarParameters = null, string? queryName = null, int? timeoutSeconds = null, int? keepForSeconds = null)

StartQuery: Start to Execute Sql in the background

 Allow for starting a potentially long running query and getting back an immediate response with how to  - fetch the data in various formats (if available, or if not simply being informed it is not yet ready) - view progress information (up until this point) - cancel the query (if still running) / clear the data (if already returned)  This can still error on things like an outright syntax error, but more runtime errors (e.g. from providers) will not cause this to error (that will happen when attempting to fetch data)  Here is an example that intentionally takes one minute to run:  ```sql select Str, Takes500Ms from Testing1K where UseLinq = true and [Int] <= 120 ```  This is the only place in the Luminesce WebAPI where the following is supported. This will allow for the same user running a character-identical query not kick off a new query but simply be returned a reference  to the already running one for up to `N` seconds (where `N` should be `<=` `keepForSeconds`).  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - there was something wrong with your query syntax (the issue was detected at parse-time) - 401 Unauthorized - 403 Forbidden 

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SqlBackgroundExecutionApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SqlBackgroundExecutionApi>();
            var body = select Str, Takes500Ms from Testing1K where UseLinq = true and [Int] <= 120;  // string | The LuminesceSql query to kick off.
            var executionId = 686a0b70-0e97-4187-a2ab-509cf6d1091b;  // string? | An explicit ExecutionId to use.  This must be blank OR assigned to a valid GUID-as-a-string.  It might be ignored / replaced, for example if using the query cache and a cached query is found. (optional) 
            var scalarParameters = new Dictionary<string, string>?(); // Dictionary<string, string>? | Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. (optional) 
            var queryName = Intentionally slow test query;  // string? | A name for this query.  This goes into logs and is available in `Sys.Logs.HcQueryStart`. (optional) 
            var timeoutSeconds = 1200;  // int? | Maximum time the query may run for, in seconds: <0 → ∞, 0 → 7200 (2h) (optional)  (default to 0)
            var keepForSeconds = 7200;  // int? | Maximum time the result may be kept for, in seconds: <0 → 1200 (20m), 0 → 28800 (8h), max = 2,678,400 (31d) (optional)  (default to 0)

            try
            {
                // uncomment the below to set overrides at the request level
                // BackgroundQueryResponse result = apiInstance.StartQuery(body, executionId, scalarParameters, queryName, timeoutSeconds, keepForSeconds, opts: opts);

                // StartQuery: Start to Execute Sql in the background
                BackgroundQueryResponse result = apiInstance.StartQuery(body, executionId, scalarParameters, queryName, timeoutSeconds, keepForSeconds);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SqlBackgroundExecutionApi.StartQuery: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the StartQueryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // StartQuery: Start to Execute Sql in the background
    ApiResponse<BackgroundQueryResponse> response = apiInstance.StartQueryWithHttpInfo(body, executionId, scalarParameters, queryName, timeoutSeconds, keepForSeconds);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SqlBackgroundExecutionApi.StartQueryWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **string** | The LuminesceSql query to kick off. |  |
| **executionId** | **string?** | An explicit ExecutionId to use.  This must be blank OR assigned to a valid GUID-as-a-string.  It might be ignored / replaced, for example if using the query cache and a cached query is found. | [optional]  |
| **scalarParameters** | [**Dictionary&lt;string, string&gt;?**](string.md) | Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. | [optional]  |
| **queryName** | **string?** | A name for this query.  This goes into logs and is available in &#x60;Sys.Logs.HcQueryStart&#x60;. | [optional]  |
| **timeoutSeconds** | **int?** | Maximum time the query may run for, in seconds: &lt;0 → ∞, 0 → 7200 (2h) | [optional] [default to 0] |
| **keepForSeconds** | **int?** | Maximum time the result may be kept for, in seconds: &lt;0 → 1200 (20m), 0 → 28800 (8h), max &#x3D; 2,678,400 (31d) | [optional] [default to 0] |

### Return type

[**BackgroundQueryResponse**](BackgroundQueryResponse.md)

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


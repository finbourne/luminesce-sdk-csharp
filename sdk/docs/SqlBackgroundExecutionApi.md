# Finbourne.Luminesce.Sdk.Api.SqlBackgroundExecutionApi

All URIs are relative to *https://fbn-prd.lusid.com/honeycomb*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CancelQuery**](SqlBackgroundExecutionApi.md#cancelquery) | **DELETE** /api/SqlBackground/{executionId} | CancelQuery: Cancels (if running) or clears the data from (if completed) a previously started query |
| [**FetchQueryResultCsv**](SqlBackgroundExecutionApi.md#fetchqueryresultcsv) | **GET** /api/SqlBackground/{executionId}/csv | FetchQueryResultCsv: Fetches the result from a previously started query, in CSV format. |
| [**FetchQueryResultExcel**](SqlBackgroundExecutionApi.md#fetchqueryresultexcel) | **GET** /api/SqlBackground/{executionId}/excel | FetchQueryResultExcel: Fetches the result from a previously started query, in Excel format. |
| [**FetchQueryResultHistogram**](SqlBackgroundExecutionApi.md#fetchqueryresulthistogram) | **GET** /api/SqlBackground/{executionId}/histogram | FetchQueryResultHistogram: Fetches the result from a previously started query, converts it to a histogram (counts in buckets). |
| [**FetchQueryResultJson**](SqlBackgroundExecutionApi.md#fetchqueryresultjson) | **GET** /api/SqlBackground/{executionId}/json | FetchQueryResultJson: Fetches the result from a previously started query, in JSON string format.  Please move to &#39;/jsonProper&#39; instead.  This may be marked as Deprecated in the future. |
| [**FetchQueryResultJsonProper**](SqlBackgroundExecutionApi.md#fetchqueryresultjsonproper) | **GET** /api/SqlBackground/{executionId}/jsonProper | FetchQueryResultJsonProper: Fetches the result from a previously started query, in JSON format. |
| [**FetchQueryResultParquet**](SqlBackgroundExecutionApi.md#fetchqueryresultparquet) | **GET** /api/SqlBackground/{executionId}/parquet | FetchQueryResultParquet: Fetches the result from a previously started query, in Parquet format. |
| [**FetchQueryResultPipe**](SqlBackgroundExecutionApi.md#fetchqueryresultpipe) | **GET** /api/SqlBackground/{executionId}/pipe | FetchQueryResultPipe: Fetches the result from a previously started query, in pipe-delimited format. |
| [**FetchQueryResultSqlite**](SqlBackgroundExecutionApi.md#fetchqueryresultsqlite) | **GET** /api/SqlBackground/{executionId}/sqlite | FetchQueryResultSqlite: Fetches the result from a previously started query, in SqLite format. |
| [**FetchQueryResultXml**](SqlBackgroundExecutionApi.md#fetchqueryresultxml) | **GET** /api/SqlBackground/{executionId}/xml | FetchQueryResultXml: Fetches the result from a previously started query, in Xml format. |
| [**GetProgressOf**](SqlBackgroundExecutionApi.md#getprogressof) | **GET** /api/SqlBackground/{executionId} | GetProgressOf: View progress information (up until this point) |
| [**StartQuery**](SqlBackgroundExecutionApi.md#startquery) | **PUT** /api/SqlBackground | StartQuery: Starts to Execute LuminesceSql in the background. |

<a id="cancelquery"></a>
# **CancelQuery**
> BackgroundQueryCancelResponse CancelQuery (string executionId)

CancelQuery: Cancels (if running) or clears the data from (if completed) a previously started query

Cancel the query (if still running) / clear the data (if already returned) The following error codes are to be anticipated with standard Problem Detail reports: - 401 Unauthorized - 403 Forbidden - 404 Not Found : The requested query result doesn't exist and is not running. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class CancelQueryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlBackgroundExecutionApi(config);
            var executionId = "executionId_example";  // string | ExecutionId returned when starting the query

            try
            {
                // CancelQuery: Cancels (if running) or clears the data from (if completed) a previously started query
                BackgroundQueryCancelResponse result = apiInstance.CancelQuery(executionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlBackgroundExecutionApi.CancelQuery: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    // CancelQuery: Cancels (if running) or clears the data from (if completed) a previously started query
    ApiResponse<BackgroundQueryCancelResponse> response = apiInstance.CancelQueryWithHttpInfo(executionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SqlBackgroundExecutionApi.CancelQueryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **executionId** | **string** | ExecutionId returned when starting the query |  |

### Return type

[**BackgroundQueryCancelResponse**](BackgroundQueryCancelResponse.md)

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

<a id="fetchqueryresultcsv"></a>
# **FetchQueryResultCsv**
> string FetchQueryResultCsv (string executionId, bool? download = null, string? sortBy = null, string? filter = null, string? select = null, string? groupBy = null, int? limit = null, int? page = null, string? delimiter = null, string? escape = null)

FetchQueryResultCsv: Fetches the result from a previously started query, in CSV format.

Fetch the data in various formats (if available, or if not simply being informed it is not yet ready) The following error codes are to be anticipated most with standard Problem Detail reports: - 400 BadRequest : Something failed with the execution of your query - 401 Unauthorized - 403 Forbidden - 404 Not Found : The requested query result doesn't (yet) exist. - 429 Too Many Requests : Please try your request again soon   1. The query has been executed successfully in the past yet the server-instance receiving this request (e.g. from a load balancer) doesn't yet have this data available.   1. By virtue of the request you have just placed this will have started to load from the persisted cache and will soon be available.   1. It is also the case that the original server-instance to process the original query is likely to already be able to service this request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class FetchQueryResultCsvExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlBackgroundExecutionApi(config);
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

            try
            {
                // FetchQueryResultCsv: Fetches the result from a previously started query, in CSV format.
                string result = apiInstance.FetchQueryResultCsv(executionId, download, sortBy, filter, select, groupBy, limit, page, delimiter, escape);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlBackgroundExecutionApi.FetchQueryResultCsv: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    // FetchQueryResultCsv: Fetches the result from a previously started query, in CSV format.
    ApiResponse<string> response = apiInstance.FetchQueryResultCsvWithHttpInfo(executionId, download, sortBy, filter, select, groupBy, limit, page, delimiter, escape);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SqlBackgroundExecutionApi.FetchQueryResultCsvWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
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

### Return type

**string**

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
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="fetchqueryresultexcel"></a>
# **FetchQueryResultExcel**
> System.IO.Stream FetchQueryResultExcel (string executionId, string? sortBy = null, string? filter = null, string? select = null, string? groupBy = null)

FetchQueryResultExcel: Fetches the result from a previously started query, in Excel format.

Fetch the data in various formats (if available, or if not simply being informed it is not yet ready) The following error codes are to be anticipated most with standard Problem Detail reports: - 400 BadRequest : Something failed with the execution of your query - 401 Unauthorized - 403 Forbidden - 404 Not Found : The requested query result doesn't (yet) exist. - 429 Too Many Requests : Please try your request again soon   1. The query has been executed successfully in the past yet the server-instance receiving this request (e.g. from a load balancer) doesn't yet have this data available.   1. By virtue of the request you have just placed this will have started to load from the persisted cache and will soon be available.   1. It is also the case that the original server-instance to process the original query is likely to already be able to service this request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class FetchQueryResultExcelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlBackgroundExecutionApi(config);
            var executionId = "executionId_example";  // string | ExecutionId returned when starting the query
            var sortBy = "sortBy_example";  // string? | Order the results by these fields.              Use the `-` sign to denote descending order, e.g. `-MyFieldName`.  Numeric indexes may be used also, e.g. `2,-3`.              Multiple fields can be denoted by a comma e.g. `-MyFieldName,AnotherFieldName,-AFurtherFieldName`.              Default is null, the sort order specified in the query itself. (optional) 
            var filter = "filter_example";  // string? | An ODATA filter per Finbourne.Filtering syntax. (optional) 
            var select = "select_example";  // string? | Default is null (meaning return all columns in the original query itself).  The values are in terms of the result column name from the original data set and are comma delimited.  The power of this comes in that you may aggregate the data if you wish  (that is the main reason for allowing this, in fact).  e.g.:  - `MyField`  - `Max(x) FILTER (WHERE y > 12) as ABC` (max of a field, if another field lets it qualify, with a nice column name)  - `count(*)` (count the rows for the given group, that would produce a rather ugly column name, but  it works)  - `count(distinct x) as numOfXs`  If there was an illegal character in a field you are selecting from, you are responsible for bracketing it with [ ].   e.g.  - `some_field, count(*) as a, max(x) as b, min([column with space in name]) as nice_name`    where you would likely want to pass `1` as the `groupBy` also. (optional) 
            var groupBy = "groupBy_example";  // string? | Groups by the specified fields.              A comma delimited list of: 1 based numeric indexes (cleaner), or repeats of the select expressions (a bit verbose and must match exactly).              e.g. `2,3`, `myColumn`.              Default is null (meaning no grouping will be performed on the selected columns).              This applies only over the result set being requested here, meaning indexes into the \"select\" parameter fields.              Only specify this if you are selecting aggregations in the \"select\" parameter. (optional) 

            try
            {
                // FetchQueryResultExcel: Fetches the result from a previously started query, in Excel format.
                System.IO.Stream result = apiInstance.FetchQueryResultExcel(executionId, sortBy, filter, select, groupBy);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlBackgroundExecutionApi.FetchQueryResultExcel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    // FetchQueryResultExcel: Fetches the result from a previously started query, in Excel format.
    ApiResponse<System.IO.Stream> response = apiInstance.FetchQueryResultExcelWithHttpInfo(executionId, sortBy, filter, select, groupBy);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SqlBackgroundExecutionApi.FetchQueryResultExcelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
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
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="fetchqueryresulthistogram"></a>
# **FetchQueryResultHistogram**
> string FetchQueryResultHistogram (string executionId, string timestampFieldName, DateTimeOffset? startAt = null, DateTimeOffset? endAt = null, string? bucketSize = null, string? filter = null, bool? jsonProper = null)

FetchQueryResultHistogram: Fetches the result from a previously started query, converts it to a histogram (counts in buckets).

Fetch the histogram in Json format (if available, or if not simply being informed it is not yet ready) The following error codes are to be anticipated with standard Problem Detail reports: - 401 Unauthorized - 403 Forbidden - 404 Not Found : The requested query result doesn't (yet) exist. - 429 Too Many Requests : Please try your request again soon   1. The query has been executed successfully in the past yet the server-instance receiving this request (e.g. from a load balancer) doesn't yet have this data available.   1. By virtue of the request you have just placed this will have started to load from the persisted cache and will soon be available.   1. It is also the case that the original server-instance to process the original query is likely to already be able to service this request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class FetchQueryResultHistogramExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlBackgroundExecutionApi(config);
            var executionId = "executionId_example";  // string | ExecutionId returned when starting the query
            var timestampFieldName = "timestampFieldName_example";  // string | Name of the timestamp field used in building the histogram
            var startAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Start point (of the timestampFieldName field) for the histogram (optional) 
            var endAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | End point (of the timestampFieldName field) for the histogram (optional) 
            var bucketSize = "bucketSize_example";  // string? | Optional histogram bucket width.  If not provided a set number of buckets between start/end range will be generated. (optional) 
            var filter = "filter_example";  // string? | An ODATA filter per Finbourne.Filtering syntax. (optional) 
            var jsonProper = false;  // bool? | Should this be text/json (not json-encoded-as-a-string) (optional)  (default to false)

            try
            {
                // FetchQueryResultHistogram: Fetches the result from a previously started query, converts it to a histogram (counts in buckets).
                string result = apiInstance.FetchQueryResultHistogram(executionId, timestampFieldName, startAt, endAt, bucketSize, filter, jsonProper);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlBackgroundExecutionApi.FetchQueryResultHistogram: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    // FetchQueryResultHistogram: Fetches the result from a previously started query, converts it to a histogram (counts in buckets).
    ApiResponse<string> response = apiInstance.FetchQueryResultHistogramWithHttpInfo(executionId, timestampFieldName, startAt, endAt, bucketSize, filter, jsonProper);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SqlBackgroundExecutionApi.FetchQueryResultHistogramWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
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
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="fetchqueryresultjson"></a>
# **FetchQueryResultJson**
> string FetchQueryResultJson (string executionId, string? sortBy = null, string? filter = null, string? select = null, string? groupBy = null, int? limit = null, int? page = null)

FetchQueryResultJson: Fetches the result from a previously started query, in JSON string format.  Please move to '/jsonProper' instead.  This may be marked as Deprecated in the future.

Fetch the data in various formats (if available, or if not simply being informed it is not yet ready) The following error codes are to be anticipated most with standard Problem Detail reports: - 400 BadRequest : Something failed with the execution of your query - 401 Unauthorized - 403 Forbidden - 404 Not Found : The requested query result doesn't (yet) exist. - 429 Too Many Requests : Please try your request again soon   1. The query has been executed successfully in the past yet the server-instance receiving this request (e.g. from a load balancer) doesn't yet have this data available.   1. By virtue of the request you have just placed this will have started to load from the persisted cache and will soon be available.   1. It is also the case that the original server-instance to process the original query is likely to already be able to service this request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class FetchQueryResultJsonExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlBackgroundExecutionApi(config);
            var executionId = "executionId_example";  // string | ExecutionId returned when starting the query
            var sortBy = "sortBy_example";  // string? | Order the results by these fields.              Use the `-` sign to denote descending order, e.g. `-MyFieldName`.  Numeric indexes may be used also, e.g. `2,-3`.              Multiple fields can be denoted by a comma e.g. `-MyFieldName,AnotherFieldName,-AFurtherFieldName`.              Default is null, the sort order specified in the query itself. (optional) 
            var filter = "filter_example";  // string? | An ODATA filter per Finbourne.Filtering syntax. (optional) 
            var select = "select_example";  // string? | Default is null (meaning return all columns in the original query itself).  The values are in terms of the result column name from the original data set and are comma delimited.  The power of this comes in that you may aggregate the data if you wish  (that is the main reason for allowing this, in fact).  e.g.:  - `MyField`  - `Max(x) FILTER (WHERE y > 12) as ABC` (max of a field, if another field lets it qualify, with a nice column name)  - `count(*)` (count the rows for the given group, that would produce a rather ugly column name, but  it works)  - `count(distinct x) as numOfXs`  If there was an illegal character in a field you are selecting from, you are responsible for bracketing it with [ ].   e.g.  - `some_field, count(*) as a, max(x) as b, min([column with space in name]) as nice_name`    where you would likely want to pass `1` as the `groupBy` also. (optional) 
            var groupBy = "groupBy_example";  // string? | Groups by the specified fields.              A comma delimited list of: 1 based numeric indexes (cleaner), or repeats of the select expressions (a bit verbose and must match exactly).              e.g. `2,3`, `myColumn`.              Default is null (meaning no grouping will be performed on the selected columns).              This applies only over the result set being requested here, meaning indexes into the \"select\" parameter fields.              Only specify this if you are selecting aggregations in the \"select\" parameter. (optional) 
            var limit = 0;  // int? | When paginating, only return this number of records, page should also be specified. (optional)  (default to 0)
            var page = 0;  // int? | 0-N based on chunk sized determined by the limit, ignored if limit < 1. (optional)  (default to 0)

            try
            {
                // FetchQueryResultJson: Fetches the result from a previously started query, in JSON string format.  Please move to '/jsonProper' instead.  This may be marked as Deprecated in the future.
                string result = apiInstance.FetchQueryResultJson(executionId, sortBy, filter, select, groupBy, limit, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlBackgroundExecutionApi.FetchQueryResultJson: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    // FetchQueryResultJson: Fetches the result from a previously started query, in JSON string format.  Please move to '/jsonProper' instead.  This may be marked as Deprecated in the future.
    ApiResponse<string> response = apiInstance.FetchQueryResultJsonWithHttpInfo(executionId, sortBy, filter, select, groupBy, limit, page);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SqlBackgroundExecutionApi.FetchQueryResultJsonWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
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

### Return type

**string**

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
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="fetchqueryresultjsonproper"></a>
# **FetchQueryResultJsonProper**
> string FetchQueryResultJsonProper (string executionId, bool? download = null, string? sortBy = null, string? filter = null, string? select = null, string? groupBy = null, int? limit = null, int? page = null)

FetchQueryResultJsonProper: Fetches the result from a previously started query, in JSON format.

Fetch the data in various formats (if available, or if not simply being informed it is not yet ready) The following error codes are to be anticipated most with standard Problem Detail reports: - 400 BadRequest : Something failed with the execution of your query - 401 Unauthorized - 403 Forbidden - 404 Not Found : The requested query result doesn't (yet) exist. - 429 Too Many Requests : Please try your request again soon   1. The query has been executed successfully in the past yet the server-instance receiving this request (e.g. from a load balancer) doesn't yet have this data available.   1. By virtue of the request you have just placed this will have started to load from the persisted cache and will soon be available.   1. It is also the case that the original server-instance to process the original query is likely to already be able to service this request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class FetchQueryResultJsonProperExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlBackgroundExecutionApi(config);
            var executionId = "executionId_example";  // string | ExecutionId returned when starting the query
            var download = false;  // bool? | Makes this a file-download request (as opposed to returning the data in the response-body) (optional)  (default to false)
            var sortBy = "sortBy_example";  // string? | Order the results by these fields.              Use the `-` sign to denote descending order, e.g. `-MyFieldName`.  Numeric indexes may be used also, e.g. `2,-3`.              Multiple fields can be denoted by a comma e.g. `-MyFieldName,AnotherFieldName,-AFurtherFieldName`.              Default is null, the sort order specified in the query itself. (optional) 
            var filter = "filter_example";  // string? | An ODATA filter per Finbourne.Filtering syntax. (optional) 
            var select = "select_example";  // string? | Default is null (meaning return all columns in the original query itself).  The values are in terms of the result column name from the original data set and are comma delimited.  The power of this comes in that you may aggregate the data if you wish  (that is the main reason for allowing this, in fact).  e.g.:  - `MyField`  - `Max(x) FILTER (WHERE y > 12) as ABC` (max of a field, if another field lets it qualify, with a nice column name)  - `count(*)` (count the rows for the given group, that would produce a rather ugly column name, but  it works)  - `count(distinct x) as numOfXs`  If there was an illegal character in a field you are selecting from, you are responsible for bracketing it with [ ].   e.g.  - `some_field, count(*) as a, max(x) as b, min([column with space in name]) as nice_name`    where you would likely want to pass `1` as the `groupBy` also. (optional) 
            var groupBy = "groupBy_example";  // string? | Groups by the specified fields.              A comma delimited list of: 1 based numeric indexes (cleaner), or repeats of the select expressions (a bit verbose and must match exactly).              e.g. `2,3`, `myColumn`.              Default is null (meaning no grouping will be performed on the selected columns).              This applies only over the result set being requested here, meaning indexes into the \"select\" parameter fields.              Only specify this if you are selecting aggregations in the \"select\" parameter. (optional) 
            var limit = 0;  // int? | When paginating, only return this number of records, page should also be specified. (optional)  (default to 0)
            var page = 0;  // int? | 0-N based on chunk sized determined by the limit, ignored if limit < 1. (optional)  (default to 0)

            try
            {
                // FetchQueryResultJsonProper: Fetches the result from a previously started query, in JSON format.
                string result = apiInstance.FetchQueryResultJsonProper(executionId, download, sortBy, filter, select, groupBy, limit, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlBackgroundExecutionApi.FetchQueryResultJsonProper: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    // FetchQueryResultJsonProper: Fetches the result from a previously started query, in JSON format.
    ApiResponse<string> response = apiInstance.FetchQueryResultJsonProperWithHttpInfo(executionId, download, sortBy, filter, select, groupBy, limit, page);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SqlBackgroundExecutionApi.FetchQueryResultJsonProperWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
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

### Return type

**string**

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
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="fetchqueryresultparquet"></a>
# **FetchQueryResultParquet**
> System.IO.Stream FetchQueryResultParquet (string executionId, string? sortBy = null, string? filter = null, string? select = null, string? groupBy = null)

FetchQueryResultParquet: Fetches the result from a previously started query, in Parquet format.

Fetch the data in various formats (if available, or if not simply being informed it is not yet ready) The following error codes are to be anticipated most with standard Problem Detail reports: - 400 BadRequest : Something failed with the execution of your query - 401 Unauthorized - 403 Forbidden - 404 Not Found : The requested query result doesn't (yet) exist. - 429 Too Many Requests : Please try your request again soon   1. The query has been executed successfully in the past yet the server-instance receiving this request (e.g. from a load balancer) doesn't yet have this data available.   1. By virtue of the request you have just placed this will have started to load from the persisted cache and will soon be available.   1. It is also the case that the original server-instance to process the original query is likely to already be able to service this request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class FetchQueryResultParquetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlBackgroundExecutionApi(config);
            var executionId = "executionId_example";  // string | ExecutionId returned when starting the query
            var sortBy = "sortBy_example";  // string? | Order the results by these fields.              Use the `-` sign to denote descending order, e.g. `-MyFieldName`.  Numeric indexes may be used also, e.g. `2,-3`.              Multiple fields can be denoted by a comma e.g. `-MyFieldName,AnotherFieldName,-AFurtherFieldName`.              Default is null, the sort order specified in the query itself. (optional) 
            var filter = "filter_example";  // string? | An ODATA filter per Finbourne.Filtering syntax. (optional) 
            var select = "select_example";  // string? | Default is null (meaning return all columns in the original query itself).  The values are in terms of the result column name from the original data set and are comma delimited.  The power of this comes in that you may aggregate the data if you wish  (that is the main reason for allowing this, in fact).  e.g.:  - `MyField`  - `Max(x) FILTER (WHERE y > 12) as ABC` (max of a field, if another field lets it qualify, with a nice column name)  - `count(*)` (count the rows for the given group, that would produce a rather ugly column name, but  it works)  - `count(distinct x) as numOfXs`  If there was an illegal character in a field you are selecting from, you are responsible for bracketing it with [ ].   e.g.  - `some_field, count(*) as a, max(x) as b, min([column with space in name]) as nice_name`    where you would likely want to pass `1` as the `groupBy` also. (optional) 
            var groupBy = "groupBy_example";  // string? | Groups by the specified fields.              A comma delimited list of: 1 based numeric indexes (cleaner), or repeats of the select expressions (a bit verbose and must match exactly).              e.g. `2,3`, `myColumn`.              Default is null (meaning no grouping will be performed on the selected columns).              This applies only over the result set being requested here, meaning indexes into the \"select\" parameter fields.              Only specify this if you are selecting aggregations in the \"select\" parameter. (optional) 

            try
            {
                // FetchQueryResultParquet: Fetches the result from a previously started query, in Parquet format.
                System.IO.Stream result = apiInstance.FetchQueryResultParquet(executionId, sortBy, filter, select, groupBy);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlBackgroundExecutionApi.FetchQueryResultParquet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    // FetchQueryResultParquet: Fetches the result from a previously started query, in Parquet format.
    ApiResponse<System.IO.Stream> response = apiInstance.FetchQueryResultParquetWithHttpInfo(executionId, sortBy, filter, select, groupBy);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SqlBackgroundExecutionApi.FetchQueryResultParquetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
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
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="fetchqueryresultpipe"></a>
# **FetchQueryResultPipe**
> string FetchQueryResultPipe (string executionId, bool? download = null, string? sortBy = null, string? filter = null, string? select = null, string? groupBy = null, int? limit = null, int? page = null)

FetchQueryResultPipe: Fetches the result from a previously started query, in pipe-delimited format.

Fetch the data in various formats (if available, or if not simply being informed it is not yet ready) The following error codes are to be anticipated most with standard Problem Detail reports: - 400 BadRequest : Something failed with the execution of your query - 401 Unauthorized - 403 Forbidden - 404 Not Found : The requested query result doesn't (yet) exist. - 429 Too Many Requests : Please try your request again soon   1. The query has been executed successfully in the past yet the server-instance receiving this request (e.g. from a load balancer) doesn't yet have this data available.   1. By virtue of the request you have just placed this will have started to load from the persisted cache and will soon be available.   1. It is also the case that the original server-instance to process the original query is likely to already be able to service this request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class FetchQueryResultPipeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlBackgroundExecutionApi(config);
            var executionId = "executionId_example";  // string | ExecutionId returned when starting the query
            var download = false;  // bool? | Makes this a file-download request (as opposed to returning the data in the response-body) (optional)  (default to false)
            var sortBy = "sortBy_example";  // string? | Order the results by these fields.              Use the `-` sign to denote descending order, e.g. `-MyFieldName`.  Numeric indexes may be used also, e.g. `2,-3`.              Multiple fields can be denoted by a comma e.g. `-MyFieldName,AnotherFieldName,-AFurtherFieldName`.              Default is null, the sort order specified in the query itself. (optional) 
            var filter = "filter_example";  // string? | An ODATA filter per Finbourne.Filtering syntax. (optional) 
            var select = "select_example";  // string? | Default is null (meaning return all columns in the original query itself).  The values are in terms of the result column name from the original data set and are comma delimited.  The power of this comes in that you may aggregate the data if you wish  (that is the main reason for allowing this, in fact).  e.g.:  - `MyField`  - `Max(x) FILTER (WHERE y > 12) as ABC` (max of a field, if another field lets it qualify, with a nice column name)  - `count(*)` (count the rows for the given group, that would produce a rather ugly column name, but  it works)  - `count(distinct x) as numOfXs`  If there was an illegal character in a field you are selecting from, you are responsible for bracketing it with [ ].   e.g.  - `some_field, count(*) as a, max(x) as b, min([column with space in name]) as nice_name`    where you would likely want to pass `1` as the `groupBy` also. (optional) 
            var groupBy = "groupBy_example";  // string? | Groups by the specified fields.              A comma delimited list of: 1 based numeric indexes (cleaner), or repeats of the select expressions (a bit verbose and must match exactly).              e.g. `2,3`, `myColumn`.              Default is null (meaning no grouping will be performed on the selected columns).              This applies only over the result set being requested here, meaning indexes into the \"select\" parameter fields.              Only specify this if you are selecting aggregations in the \"select\" parameter. (optional) 
            var limit = 0;  // int? | When paginating, only return this number of records, page should also be specified. (optional)  (default to 0)
            var page = 0;  // int? | 0-N based on chunk sized determined by the limit, ignored if limit < 1. (optional)  (default to 0)

            try
            {
                // FetchQueryResultPipe: Fetches the result from a previously started query, in pipe-delimited format.
                string result = apiInstance.FetchQueryResultPipe(executionId, download, sortBy, filter, select, groupBy, limit, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlBackgroundExecutionApi.FetchQueryResultPipe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    // FetchQueryResultPipe: Fetches the result from a previously started query, in pipe-delimited format.
    ApiResponse<string> response = apiInstance.FetchQueryResultPipeWithHttpInfo(executionId, download, sortBy, filter, select, groupBy, limit, page);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SqlBackgroundExecutionApi.FetchQueryResultPipeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
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

### Return type

**string**

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
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="fetchqueryresultsqlite"></a>
# **FetchQueryResultSqlite**
> System.IO.Stream FetchQueryResultSqlite (string executionId, string? sortBy = null, string? filter = null, string? select = null, string? groupBy = null)

FetchQueryResultSqlite: Fetches the result from a previously started query, in SqLite format.

Fetch the data in various formats (if available, or if not simply being informed it is not yet ready) The following error codes are to be anticipated most with standard Problem Detail reports: - 400 BadRequest : Something failed with the execution of your query - 401 Unauthorized - 403 Forbidden - 404 Not Found : The requested query result doesn't (yet) exist. - 429 Too Many Requests : Please try your request again soon   1. The query has been executed successfully in the past yet the server-instance receiving this request (e.g. from a load balancer) doesn't yet have this data available.   1. By virtue of the request you have just placed this will have started to load from the persisted cache and will soon be available.   1. It is also the case that the original server-instance to process the original query is likely to already be able to service this request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class FetchQueryResultSqliteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlBackgroundExecutionApi(config);
            var executionId = "executionId_example";  // string | ExecutionId returned when starting the query
            var sortBy = "sortBy_example";  // string? | Order the results by these fields.              Use the `-` sign to denote descending order, e.g. `-MyFieldName`.  Numeric indexes may be used also, e.g. `2,-3`.              Multiple fields can be denoted by a comma e.g. `-MyFieldName,AnotherFieldName,-AFurtherFieldName`.              Default is null, the sort order specified in the query itself. (optional) 
            var filter = "filter_example";  // string? | An ODATA filter per Finbourne.Filtering syntax. (optional) 
            var select = "select_example";  // string? | Default is null (meaning return all columns in the original query itself).  The values are in terms of the result column name from the original data set and are comma delimited.  The power of this comes in that you may aggregate the data if you wish  (that is the main reason for allowing this, in fact).  e.g.:  - `MyField`  - `Max(x) FILTER (WHERE y > 12) as ABC` (max of a field, if another field lets it qualify, with a nice column name)  - `count(*)` (count the rows for the given group, that would produce a rather ugly column name, but  it works)  - `count(distinct x) as numOfXs`  If there was an illegal character in a field you are selecting from, you are responsible for bracketing it with [ ].   e.g.  - `some_field, count(*) as a, max(x) as b, min([column with space in name]) as nice_name`    where you would likely want to pass `1` as the `groupBy` also. (optional) 
            var groupBy = "groupBy_example";  // string? | Groups by the specified fields.              A comma delimited list of: 1 based numeric indexes (cleaner), or repeats of the select expressions (a bit verbose and must match exactly).              e.g. `2,3`, `myColumn`.              Default is null (meaning no grouping will be performed on the selected columns).              This applies only over the result set being requested here, meaning indexes into the \"select\" parameter fields.              Only specify this if you are selecting aggregations in the \"select\" parameter. (optional) 

            try
            {
                // FetchQueryResultSqlite: Fetches the result from a previously started query, in SqLite format.
                System.IO.Stream result = apiInstance.FetchQueryResultSqlite(executionId, sortBy, filter, select, groupBy);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlBackgroundExecutionApi.FetchQueryResultSqlite: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    // FetchQueryResultSqlite: Fetches the result from a previously started query, in SqLite format.
    ApiResponse<System.IO.Stream> response = apiInstance.FetchQueryResultSqliteWithHttpInfo(executionId, sortBy, filter, select, groupBy);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SqlBackgroundExecutionApi.FetchQueryResultSqliteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
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
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="fetchqueryresultxml"></a>
# **FetchQueryResultXml**
> string FetchQueryResultXml (string executionId, bool? download = null, string? sortBy = null, string? filter = null, string? select = null, string? groupBy = null, int? limit = null, int? page = null)

FetchQueryResultXml: Fetches the result from a previously started query, in Xml format.

Fetch the data in various formats (if available, or if not simply being informed it is not yet ready) The following error codes are to be anticipated most with standard Problem Detail reports: - 400 BadRequest : Something failed with the execution of your query - 401 Unauthorized - 403 Forbidden - 404 Not Found : The requested query result doesn't (yet) exist. - 429 Too Many Requests : Please try your request again soon   1. The query has been executed successfully in the past yet the server-instance receiving this request (e.g. from a load balancer) doesn't yet have this data available.   1. By virtue of the request you have just placed this will have started to load from the persisted cache and will soon be available.   1. It is also the case that the original server-instance to process the original query is likely to already be able to service this request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class FetchQueryResultXmlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlBackgroundExecutionApi(config);
            var executionId = "executionId_example";  // string | ExecutionId returned when starting the query
            var download = false;  // bool? | Makes this a file-download request (as opposed to returning the data in the response-body) (optional)  (default to false)
            var sortBy = "sortBy_example";  // string? | Order the results by these fields.              Use the `-` sign to denote descending order, e.g. `-MyFieldName`.  Numeric indexes may be used also, e.g. `2,-3`.              Multiple fields can be denoted by a comma e.g. `-MyFieldName,AnotherFieldName,-AFurtherFieldName`.              Default is null, the sort order specified in the query itself. (optional) 
            var filter = "filter_example";  // string? | An ODATA filter per Finbourne.Filtering syntax. (optional) 
            var select = "select_example";  // string? | Default is null (meaning return all columns in the original query itself).  The values are in terms of the result column name from the original data set and are comma delimited.  The power of this comes in that you may aggregate the data if you wish  (that is the main reason for allowing this, in fact).  e.g.:  - `MyField`  - `Max(x) FILTER (WHERE y > 12) as ABC` (max of a field, if another field lets it qualify, with a nice column name)  - `count(*)` (count the rows for the given group, that would produce a rather ugly column name, but  it works)  - `count(distinct x) as numOfXs`  If there was an illegal character in a field you are selecting from, you are responsible for bracketing it with [ ].   e.g.  - `some_field, count(*) as a, max(x) as b, min([column with space in name]) as nice_name`    where you would likely want to pass `1` as the `groupBy` also. (optional) 
            var groupBy = "groupBy_example";  // string? | Groups by the specified fields.              A comma delimited list of: 1 based numeric indexes (cleaner), or repeats of the select expressions (a bit verbose and must match exactly).              e.g. `2,3`, `myColumn`.              Default is null (meaning no grouping will be performed on the selected columns).              This applies only over the result set being requested here, meaning indexes into the \"select\" parameter fields.              Only specify this if you are selecting aggregations in the \"select\" parameter. (optional) 
            var limit = 0;  // int? | When paginating, only return this number of records, page should also be specified. (optional)  (default to 0)
            var page = 0;  // int? | 0-N based on chunk sized determined by the limit, ignored if limit < 1. (optional)  (default to 0)

            try
            {
                // FetchQueryResultXml: Fetches the result from a previously started query, in Xml format.
                string result = apiInstance.FetchQueryResultXml(executionId, download, sortBy, filter, select, groupBy, limit, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlBackgroundExecutionApi.FetchQueryResultXml: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    // FetchQueryResultXml: Fetches the result from a previously started query, in Xml format.
    ApiResponse<string> response = apiInstance.FetchQueryResultXmlWithHttpInfo(executionId, download, sortBy, filter, select, groupBy, limit, page);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SqlBackgroundExecutionApi.FetchQueryResultXmlWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
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

### Return type

**string**

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
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getprogressof"></a>
# **GetProgressOf**
> BackgroundQueryProgressResponse GetProgressOf (string executionId, bool buildFromLogs)

GetProgressOf: View progress information (up until this point)

View progress information (up until this point) The following error codes are to be anticipated most with standard Problem Detail reports: - 401 Unauthorized - 403 Forbidden - 404 Not Found : The requested query result doesn't exist and is not running. - 429 Too Many Requests : Please try your request again soon   1. The query has been executed successfully in the past yet the server-instance receiving this request (e.g. from a load balancer) doesn't yet have this data available.   1. By virtue of the request you have just placed this will have started to load from the persisted cache and will soon be available.   1. It is also the case that the original server-instance to process the original query is likely to already be able to service this request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class GetProgressOfExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlBackgroundExecutionApi(config);
            var executionId = "executionId_example";  // string | ExecutionId returned when starting the query
            var buildFromLogs = true;  // bool | Should the response state be build from query logs if missing from the shared-db-state?  False will mean `404 Not Found` in cases where it was a real query but has passed its `keepForSeconds`  since the query completed (as well as 'this was not a query at all' of course) (default to true)

            try
            {
                // GetProgressOf: View progress information (up until this point)
                BackgroundQueryProgressResponse result = apiInstance.GetProgressOf(executionId, buildFromLogs);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlBackgroundExecutionApi.GetProgressOf: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    // GetProgressOf: View progress information (up until this point)
    ApiResponse<BackgroundQueryProgressResponse> response = apiInstance.GetProgressOfWithHttpInfo(executionId, buildFromLogs);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SqlBackgroundExecutionApi.GetProgressOfWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **executionId** | **string** | ExecutionId returned when starting the query |  |
| **buildFromLogs** | **bool** | Should the response state be build from query logs if missing from the shared-db-state?  False will mean &#x60;404 Not Found&#x60; in cases where it was a real query but has passed its &#x60;keepForSeconds&#x60;  since the query completed (as well as &#39;this was not a query at all&#39; of course) | [default to true] |

### Return type

[**BackgroundQueryProgressResponse**](BackgroundQueryProgressResponse.md)

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

<a id="startquery"></a>
# **StartQuery**
> BackgroundQueryResponse StartQuery (string body, Dictionary<string, string>? scalarParameters = null, string? queryName = null, int? timeoutSeconds = null, int? keepForSeconds = null)

StartQuery: Starts to Execute LuminesceSql in the background.

 Allow for starting a potentially long running query and getting back an immediate response with how to  - fetch the data in various formats (if available, or if not simply being informed it is not yet ready) - view progress information (up until this point) - cancel the query (if still running) / clear the data (if already returned)  This can still error on things like an outright syntax error, but more runtime errors (e.g. from providers) will not cause this to error (that will happen when attempting to fetch data)  Here is an example that intentionally takes one minute to run:  ```sql select Str, Takes500Ms from Testing1K where UseLinq = true and [Int] <= 120 ```  This is the only place in the Luminesce WebAPI where the following is supported. This will allow for the same user running a character-identical query not kick off a new query but simply be returned a reference  to the already running one for up to `N` seconds (where `N` should be `<=` `keepForSeconds`).  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - there was something wrong with your query syntax (the issue was detected at parse-time) - 401 Unauthorized - 403 Forbidden 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class StartQueryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlBackgroundExecutionApi(config);
            var body = select Str, Takes500Ms from Testing1K where UseLinq = true and [Int] <= 120;  // string | The LuminesceSql query to kick off.
            var scalarParameters = new Dictionary<string, string>?(); // Dictionary<string, string>? | Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. (optional) 
            var queryName = Intentionally slow test query;  // string? | A name for this query.  This goes into logs and is available in `Sys.Logs.HcQueryStart`. (optional) 
            var timeoutSeconds = 1200;  // int? | Maximum time the query may run for, in seconds: <0 → ∞, 0 → 7200 (2h) (optional)  (default to 0)
            var keepForSeconds = 7200;  // int? | Maximum time the result may be kept for, in seconds: <0 → 1200 (20m), 0 → 28800 (8h), max = 2,678,400 (31d) (optional)  (default to 0)

            try
            {
                // StartQuery: Starts to Execute LuminesceSql in the background.
                BackgroundQueryResponse result = apiInstance.StartQuery(body, scalarParameters, queryName, timeoutSeconds, keepForSeconds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlBackgroundExecutionApi.StartQuery: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    // StartQuery: Starts to Execute LuminesceSql in the background.
    ApiResponse<BackgroundQueryResponse> response = apiInstance.StartQueryWithHttpInfo(body, scalarParameters, queryName, timeoutSeconds, keepForSeconds);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SqlBackgroundExecutionApi.StartQueryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **string** | The LuminesceSql query to kick off. |  |
| **scalarParameters** | [**Dictionary&lt;string, string&gt;?**](string.md) | Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. | [optional]  |
| **queryName** | **string?** | A name for this query.  This goes into logs and is available in &#x60;Sys.Logs.HcQueryStart&#x60;. | [optional]  |
| **timeoutSeconds** | **int?** | Maximum time the query may run for, in seconds: &lt;0 → ∞, 0 → 7200 (2h) | [optional] [default to 0] |
| **keepForSeconds** | **int?** | Maximum time the result may be kept for, in seconds: &lt;0 → 1200 (20m), 0 → 28800 (8h), max &#x3D; 2,678,400 (31d) | [optional] [default to 0] |

### Return type

[**BackgroundQueryResponse**](BackgroundQueryResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Accepted |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


# Finbourne.Luminesce.Sdk.Api.SqlExecutionApi

All URIs are relative to *https://fbn-prd.lusid.com/honeycomb*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetByQueryCsv**](SqlExecutionApi.md#getbyquerycsv) | **GET** /api/Sql/csv/{query} | GetByQueryCsv: Executes Sql, returned in CSV format, where the sql is simply in the url. |
| [**GetByQueryExcel**](SqlExecutionApi.md#getbyqueryexcel) | **GET** /api/Sql/excel/{query} | GetByQueryExcel: Executes Sql, returned in Excel (xlsx) format (as a file to be downloaded) format, where the sql is simply in the url. |
| [**GetByQueryJson**](SqlExecutionApi.md#getbyqueryjson) | **GET** /api/Sql/json/{query} | GetByQueryJson: Executes Sql, returned in JSON format, where the sql is simply in the url. |
| [**GetByQueryParquet**](SqlExecutionApi.md#getbyqueryparquet) | **GET** /api/Sql/parquet/{query} | GetByQueryParquet: Executes Sql, returned in Parquet (.parquet) format (as a file to be downloaded) format, where the sql is simply in the url. |
| [**GetByQueryPipe**](SqlExecutionApi.md#getbyquerypipe) | **GET** /api/Sql/pipe/{query} | GetByQueryPipe: Executes Sql, returned in pipe-delimited format, where the sql is simply in the url. |
| [**GetByQuerySqlite**](SqlExecutionApi.md#getbyquerysqlite) | **GET** /api/Sql/sqlite/{query} | GetByQuerySqlite: Executes Sql, returned in SqLite DB (sqlite3) format (as a file to be downloaded) format, where the sql is simply in the url. |
| [**GetByQueryXml**](SqlExecutionApi.md#getbyqueryxml) | **GET** /api/Sql/xml/{query} | GetByQueryXml: Executes Sql, returned in Xml format, where the sql is simply in the url. |
| [**PutByQueryCsv**](SqlExecutionApi.md#putbyquerycsv) | **PUT** /api/Sql/csv | PutByQueryCsv: Executes Sql, returned in CSV format, where the sql is the post-body url. |
| [**PutByQueryExcel**](SqlExecutionApi.md#putbyqueryexcel) | **PUT** /api/Sql/excel | PutByQueryExcel: Executes Sql, returned in Excel (xlsx) format (as a file to be downloaded), where the sql is the post-body url. |
| [**PutByQueryJson**](SqlExecutionApi.md#putbyqueryjson) | **PUT** /api/Sql/json | PutByQueryJson: Executes Sql, returned in JSON format, where the sql is the post-body url. |
| [**PutByQueryParquet**](SqlExecutionApi.md#putbyqueryparquet) | **PUT** /api/Sql/parquet | PutByQueryParquet: Executes Sql, returned in Parquet format, where the sql is the post-body url. |
| [**PutByQueryPipe**](SqlExecutionApi.md#putbyquerypipe) | **PUT** /api/Sql/pipe | PutByQueryPipe: Executes Sql, returned in pipe-delimited format, where the sql is the post-body url. |
| [**PutByQuerySqlite**](SqlExecutionApi.md#putbyquerysqlite) | **PUT** /api/Sql/sqlite | PutByQuerySqlite: Executes Sql, returned in SqLite DB (sqlite3) format (as a file to be downloaded), where the sql is the post-body url. |
| [**PutByQueryXml**](SqlExecutionApi.md#putbyqueryxml) | **PUT** /api/Sql/xml | PutByQueryXml: Executes Sql, returned in Xml format, where the sql is the post-body url. |

<a id="getbyquerycsv"></a>
# **GetByQueryCsv**
> string GetByQueryCsv (string query, string? queryName = null, bool? download = null, int? timeout = null, string? delimiter = null, string? escape = null)

GetByQueryCsv: Executes Sql, returned in CSV format, where the sql is simply in the url.

 For simple single-line query execution via the url. e.g. `select ^ from Sys.Field order by 1, 2`  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something failed with the execution or parsing of your query - 401 Unauthorized - 403 Forbidden 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class GetByQueryCsvExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlExecutionApi(config);
            var query = select ^ from Sys.Field order by 1, 2;  // string | LuminesceSql to Execute (must be one line only)
            var queryName = Get tables/fields;  // string? | Name to apply to the query in logs and `Sys.Logs.HcQueryStart` (optional) 
            var download = false;  // bool? | Makes this a file-download request (as opposed to returning the data in the response-body) (optional)  (default to false)
            var timeout = 120;  // int? | In seconds: <0 → ∞, 0 → 120s (optional)  (default to 0)
            var delimiter = "delimiter_example";  // string? | Delimiter string to override the default (optional) 
            var escape = "escape_example";  // string? | Escape character to override the default (optional) 

            try
            {
                // GetByQueryCsv: Executes Sql, returned in CSV format, where the sql is simply in the url.
                string result = apiInstance.GetByQueryCsv(query, queryName, download, timeout, delimiter, escape);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlExecutionApi.GetByQueryCsv: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetByQueryCsvWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetByQueryCsv: Executes Sql, returned in CSV format, where the sql is simply in the url.
    ApiResponse<string> response = apiInstance.GetByQueryCsvWithHttpInfo(query, queryName, download, timeout, delimiter, escape);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SqlExecutionApi.GetByQueryCsvWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **query** | **string** | LuminesceSql to Execute (must be one line only) |  |
| **queryName** | **string?** | Name to apply to the query in logs and &#x60;Sys.Logs.HcQueryStart&#x60; | [optional]  |
| **download** | **bool?** | Makes this a file-download request (as opposed to returning the data in the response-body) | [optional] [default to false] |
| **timeout** | **int?** | In seconds: &lt;0 → ∞, 0 → 120s | [optional] [default to 0] |
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

<a id="getbyqueryexcel"></a>
# **GetByQueryExcel**
> System.IO.Stream GetByQueryExcel (string query, string? queryName = null, int? timeout = null)

GetByQueryExcel: Executes Sql, returned in Excel (xlsx) format (as a file to be downloaded) format, where the sql is simply in the url.

 For simple single-line query execution via the url. e.g. `select ^ from Sys.Field order by 1, 2`  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something failed with the execution or parsing of your query - 401 Unauthorized - 403 Forbidden 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class GetByQueryExcelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlExecutionApi(config);
            var query = select ^ from Sys.Field order by 1, 2;  // string | LuminesceSql to Execute (must be one line only)
            var queryName = Get tables/fields;  // string? | Name to apply to the query in logs and `Sys.Logs.HcQueryStart` (optional) 
            var timeout = 120;  // int? | In seconds: <0 → ∞, 0 → 120s (optional)  (default to 0)

            try
            {
                // GetByQueryExcel: Executes Sql, returned in Excel (xlsx) format (as a file to be downloaded) format, where the sql is simply in the url.
                System.IO.Stream result = apiInstance.GetByQueryExcel(query, queryName, timeout);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlExecutionApi.GetByQueryExcel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetByQueryExcelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetByQueryExcel: Executes Sql, returned in Excel (xlsx) format (as a file to be downloaded) format, where the sql is simply in the url.
    ApiResponse<System.IO.Stream> response = apiInstance.GetByQueryExcelWithHttpInfo(query, queryName, timeout);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SqlExecutionApi.GetByQueryExcelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **query** | **string** | LuminesceSql to Execute (must be one line only) |  |
| **queryName** | **string?** | Name to apply to the query in logs and &#x60;Sys.Logs.HcQueryStart&#x60; | [optional]  |
| **timeout** | **int?** | In seconds: &lt;0 → ∞, 0 → 120s | [optional] [default to 0] |

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

<a id="getbyqueryjson"></a>
# **GetByQueryJson**
> string GetByQueryJson (string query, string? queryName = null, int? timeout = null, bool? jsonProper = null)

GetByQueryJson: Executes Sql, returned in JSON format, where the sql is simply in the url.

 For simple single-line query execution via the url. e.g. `select ^ from Sys.Field order by 1, 2`  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something failed with the execution or parsing of your query - 401 Unauthorized - 403 Forbidden 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class GetByQueryJsonExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlExecutionApi(config);
            var query = select ^ from Sys.Field order by 1, 2;  // string | LuminesceSql to Execute (must be one line only)
            var queryName = Get tables/fields;  // string? | Name to apply to the query in logs and `Sys.Logs.HcQueryStart` (optional) 
            var timeout = 120;  // int? | In seconds: <0 → ∞, 0 → 120s (optional)  (default to 0)
            var jsonProper = false;  // bool? | Should this be text/json (not json-encoded-as-a-string) (optional)  (default to false)

            try
            {
                // GetByQueryJson: Executes Sql, returned in JSON format, where the sql is simply in the url.
                string result = apiInstance.GetByQueryJson(query, queryName, timeout, jsonProper);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlExecutionApi.GetByQueryJson: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetByQueryJsonWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetByQueryJson: Executes Sql, returned in JSON format, where the sql is simply in the url.
    ApiResponse<string> response = apiInstance.GetByQueryJsonWithHttpInfo(query, queryName, timeout, jsonProper);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SqlExecutionApi.GetByQueryJsonWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **query** | **string** | LuminesceSql to Execute (must be one line only) |  |
| **queryName** | **string?** | Name to apply to the query in logs and &#x60;Sys.Logs.HcQueryStart&#x60; | [optional]  |
| **timeout** | **int?** | In seconds: &lt;0 → ∞, 0 → 120s | [optional] [default to 0] |
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

<a id="getbyqueryparquet"></a>
# **GetByQueryParquet**
> System.IO.Stream GetByQueryParquet (string query, string? queryName = null, int? timeout = null)

GetByQueryParquet: Executes Sql, returned in Parquet (.parquet) format (as a file to be downloaded) format, where the sql is simply in the url.

 For simple single-line query execution via the url. e.g. `select ^ from Sys.Field order by 1, 2`  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something failed with the execution or parsing of your query - 401 Unauthorized - 403 Forbidden 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class GetByQueryParquetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlExecutionApi(config);
            var query = select ^ from Sys.Field order by 1, 2;  // string | LuminesceSql to Execute (must be one line only)
            var queryName = Get tables/fields;  // string? | Name to apply to the query in logs and `Sys.Logs.HcQueryStart` (optional) 
            var timeout = 120;  // int? | In seconds: <0 → ∞, 0 → 120s (optional)  (default to 0)

            try
            {
                // GetByQueryParquet: Executes Sql, returned in Parquet (.parquet) format (as a file to be downloaded) format, where the sql is simply in the url.
                System.IO.Stream result = apiInstance.GetByQueryParquet(query, queryName, timeout);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlExecutionApi.GetByQueryParquet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetByQueryParquetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetByQueryParquet: Executes Sql, returned in Parquet (.parquet) format (as a file to be downloaded) format, where the sql is simply in the url.
    ApiResponse<System.IO.Stream> response = apiInstance.GetByQueryParquetWithHttpInfo(query, queryName, timeout);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SqlExecutionApi.GetByQueryParquetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **query** | **string** | LuminesceSql to Execute (must be one line only) |  |
| **queryName** | **string?** | Name to apply to the query in logs and &#x60;Sys.Logs.HcQueryStart&#x60; | [optional]  |
| **timeout** | **int?** | In seconds: &lt;0 → ∞, 0 → 120s | [optional] [default to 0] |

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

<a id="getbyquerypipe"></a>
# **GetByQueryPipe**
> string GetByQueryPipe (string query, string? queryName = null, bool? download = null, int? timeout = null)

GetByQueryPipe: Executes Sql, returned in pipe-delimited format, where the sql is simply in the url.

 For simple single-line query execution via the url. e.g. `select ^ from Sys.Field order by 1, 2`  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something failed with the execution or parsing of your query - 401 Unauthorized - 403 Forbidden 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class GetByQueryPipeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlExecutionApi(config);
            var query = select ^ from Sys.Field order by 1, 2;  // string | LuminesceSql to Execute (must be one line only)
            var queryName = Get tables/fields;  // string? | Name to apply to the query in logs and `Sys.Logs.HcQueryStart` (optional) 
            var download = false;  // bool? | Makes this a file-download request (as opposed to returning the data in the response-body) (optional)  (default to false)
            var timeout = 120;  // int? | In seconds: <0 → ∞, 0 → 120s (optional)  (default to 0)

            try
            {
                // GetByQueryPipe: Executes Sql, returned in pipe-delimited format, where the sql is simply in the url.
                string result = apiInstance.GetByQueryPipe(query, queryName, download, timeout);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlExecutionApi.GetByQueryPipe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetByQueryPipeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetByQueryPipe: Executes Sql, returned in pipe-delimited format, where the sql is simply in the url.
    ApiResponse<string> response = apiInstance.GetByQueryPipeWithHttpInfo(query, queryName, download, timeout);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SqlExecutionApi.GetByQueryPipeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **query** | **string** | LuminesceSql to Execute (must be one line only) |  |
| **queryName** | **string?** | Name to apply to the query in logs and &#x60;Sys.Logs.HcQueryStart&#x60; | [optional]  |
| **download** | **bool?** | Makes this a file-download request (as opposed to returning the data in the response-body) | [optional] [default to false] |
| **timeout** | **int?** | In seconds: &lt;0 → ∞, 0 → 120s | [optional] [default to 0] |

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

<a id="getbyquerysqlite"></a>
# **GetByQuerySqlite**
> System.IO.Stream GetByQuerySqlite (string query, string? queryName = null, int? timeout = null)

GetByQuerySqlite: Executes Sql, returned in SqLite DB (sqlite3) format (as a file to be downloaded) format, where the sql is simply in the url.

 For simple single-line query execution via the url. e.g. `select ^ from Sys.Field order by 1, 2`  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something failed with the execution or parsing of your query - 401 Unauthorized - 403 Forbidden 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class GetByQuerySqliteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlExecutionApi(config);
            var query = select ^ from Sys.Field order by 1, 2;  // string | LuminesceSql to Execute (must be one line only)
            var queryName = Get tables/fields;  // string? | Name to apply to the query in logs and `Sys.Logs.HcQueryStart` (optional) 
            var timeout = 120;  // int? | In seconds: <0 → ∞, 0 → 120s (optional)  (default to 0)

            try
            {
                // GetByQuerySqlite: Executes Sql, returned in SqLite DB (sqlite3) format (as a file to be downloaded) format, where the sql is simply in the url.
                System.IO.Stream result = apiInstance.GetByQuerySqlite(query, queryName, timeout);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlExecutionApi.GetByQuerySqlite: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetByQuerySqliteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetByQuerySqlite: Executes Sql, returned in SqLite DB (sqlite3) format (as a file to be downloaded) format, where the sql is simply in the url.
    ApiResponse<System.IO.Stream> response = apiInstance.GetByQuerySqliteWithHttpInfo(query, queryName, timeout);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SqlExecutionApi.GetByQuerySqliteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **query** | **string** | LuminesceSql to Execute (must be one line only) |  |
| **queryName** | **string?** | Name to apply to the query in logs and &#x60;Sys.Logs.HcQueryStart&#x60; | [optional]  |
| **timeout** | **int?** | In seconds: &lt;0 → ∞, 0 → 120s | [optional] [default to 0] |

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

<a id="getbyqueryxml"></a>
# **GetByQueryXml**
> string GetByQueryXml (string query, string? queryName = null, bool? download = null, int? timeout = null)

GetByQueryXml: Executes Sql, returned in Xml format, where the sql is simply in the url.

 For simple single-line query execution via the url. e.g. `select ^ from Sys.Field order by 1, 2`  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something failed with the execution or parsing of your query - 401 Unauthorized - 403 Forbidden 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class GetByQueryXmlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlExecutionApi(config);
            var query = select ^ from Sys.Field order by 1, 2;  // string | LuminesceSql to Execute (must be one line only)
            var queryName = Get tables/fields;  // string? | Name to apply to the query in logs and `Sys.Logs.HcQueryStart` (optional) 
            var download = false;  // bool? | Makes this a file-download request (as opposed to returning the data in the response-body) (optional)  (default to false)
            var timeout = 120;  // int? | In seconds: <0 → ∞, 0 → 120s (optional)  (default to 0)

            try
            {
                // GetByQueryXml: Executes Sql, returned in Xml format, where the sql is simply in the url.
                string result = apiInstance.GetByQueryXml(query, queryName, download, timeout);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlExecutionApi.GetByQueryXml: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetByQueryXmlWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetByQueryXml: Executes Sql, returned in Xml format, where the sql is simply in the url.
    ApiResponse<string> response = apiInstance.GetByQueryXmlWithHttpInfo(query, queryName, download, timeout);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SqlExecutionApi.GetByQueryXmlWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **query** | **string** | LuminesceSql to Execute (must be one line only) |  |
| **queryName** | **string?** | Name to apply to the query in logs and &#x60;Sys.Logs.HcQueryStart&#x60; | [optional]  |
| **download** | **bool?** | Makes this a file-download request (as opposed to returning the data in the response-body) | [optional] [default to false] |
| **timeout** | **int?** | In seconds: &lt;0 → ∞, 0 → 120s | [optional] [default to 0] |

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

<a id="putbyquerycsv"></a>
# **PutByQueryCsv**
> string PutByQueryCsv (string body, string? queryName = null, bool? download = null, int? timeoutSeconds = null, string? delimiter = null, string? escape = null)

PutByQueryCsv: Executes Sql, returned in CSV format, where the sql is the post-body url.

 For more complex LuminesceSql a PUT will allow for longer Sql. e.g.: ```sql @@cutoff = select #2020-02-01#; @issues = select Id, SortId, Summary, Created, Updated from Dev.Jira.Issue where Project='HC' and Created < @@cutoff and Updated > @@cutoff;  select i.Id, i.SortId, i.Summary, LinkText, LinkedIssueId, LinkedIssueSortId, LinkedIssueSummary from @issues i inner join Dev.Jira.Issue.Link li     on i.Id = li.IssueId ```  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something failed with the execution or parsing of your query - 401 Unauthorized - 403 Forbidden 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class PutByQueryCsvExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlExecutionApi(config);
            var body = select * from sys.field;  // string | LuminesceSql to Execute (may be multi-line)
            var queryName = Get tables/fields;  // string? | Name to apply to the query in logs and `Sys.Logs.HcQueryStart` (optional) 
            var download = false;  // bool? | Makes this a file-download request (as opposed to returning the data in the response-body) (optional)  (default to false)
            var timeoutSeconds = 120;  // int? | In seconds: <0 → ∞, 0 → 120s (optional)  (default to 0)
            var delimiter = "delimiter_example";  // string? | Delimiter string to override the default (optional) 
            var escape = "escape_example";  // string? | Escape character to override the default (optional) 

            try
            {
                // PutByQueryCsv: Executes Sql, returned in CSV format, where the sql is the post-body url.
                string result = apiInstance.PutByQueryCsv(body, queryName, download, timeoutSeconds, delimiter, escape);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlExecutionApi.PutByQueryCsv: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutByQueryCsvWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PutByQueryCsv: Executes Sql, returned in CSV format, where the sql is the post-body url.
    ApiResponse<string> response = apiInstance.PutByQueryCsvWithHttpInfo(body, queryName, download, timeoutSeconds, delimiter, escape);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SqlExecutionApi.PutByQueryCsvWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **string** | LuminesceSql to Execute (may be multi-line) |  |
| **queryName** | **string?** | Name to apply to the query in logs and &#x60;Sys.Logs.HcQueryStart&#x60; | [optional]  |
| **download** | **bool?** | Makes this a file-download request (as opposed to returning the data in the response-body) | [optional] [default to false] |
| **timeoutSeconds** | **int?** | In seconds: &lt;0 → ∞, 0 → 120s | [optional] [default to 0] |
| **delimiter** | **string?** | Delimiter string to override the default | [optional]  |
| **escape** | **string?** | Escape character to override the default | [optional]  |

### Return type

**string**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="putbyqueryexcel"></a>
# **PutByQueryExcel**
> System.IO.Stream PutByQueryExcel (string body, string? queryName = null, int? timeoutSeconds = null)

PutByQueryExcel: Executes Sql, returned in Excel (xlsx) format (as a file to be downloaded), where the sql is the post-body url.

 For more complex LuminesceSql a PUT will allow for longer Sql. e.g.: ```sql @@cutoff = select #2020-02-01#; @issues = select Id, SortId, Summary, Created, Updated from Dev.Jira.Issue where Project='HC' and Created < @@cutoff and Updated > @@cutoff;  select i.Id, i.SortId, i.Summary, LinkText, LinkedIssueId, LinkedIssueSortId, LinkedIssueSummary from @issues i inner join Dev.Jira.Issue.Link li     on i.Id = li.IssueId ```  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something failed with the execution or parsing of your query - 401 Unauthorized - 403 Forbidden 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class PutByQueryExcelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlExecutionApi(config);
            var body = select * from sys.field;  // string | LuminesceSql to Execute (may be multi-line)
            var queryName = Get tables/fields;  // string? | Name to apply to the query in logs and `Sys.Logs.HcQueryStart` (optional) 
            var timeoutSeconds = 120;  // int? | In seconds: <0 → ∞, 0 → 120s (optional)  (default to 0)

            try
            {
                // PutByQueryExcel: Executes Sql, returned in Excel (xlsx) format (as a file to be downloaded), where the sql is the post-body url.
                System.IO.Stream result = apiInstance.PutByQueryExcel(body, queryName, timeoutSeconds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlExecutionApi.PutByQueryExcel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutByQueryExcelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PutByQueryExcel: Executes Sql, returned in Excel (xlsx) format (as a file to be downloaded), where the sql is the post-body url.
    ApiResponse<System.IO.Stream> response = apiInstance.PutByQueryExcelWithHttpInfo(body, queryName, timeoutSeconds);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SqlExecutionApi.PutByQueryExcelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **string** | LuminesceSql to Execute (may be multi-line) |  |
| **queryName** | **string?** | Name to apply to the query in logs and &#x60;Sys.Logs.HcQueryStart&#x60; | [optional]  |
| **timeoutSeconds** | **int?** | In seconds: &lt;0 → ∞, 0 → 120s | [optional] [default to 0] |

### Return type

**System.IO.Stream**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="putbyqueryjson"></a>
# **PutByQueryJson**
> string PutByQueryJson (string body, string? queryName = null, int? timeoutSeconds = null, bool? jsonProper = null)

PutByQueryJson: Executes Sql, returned in JSON format, where the sql is the post-body url.

 For more complex LuminesceSql a PUT will allow for longer Sql. e.g.: ```sql @@cutoff = select #2020-02-01#; @issues = select Id, SortId, Summary, Created, Updated from Dev.Jira.Issue where Project='HC' and Created < @@cutoff and Updated > @@cutoff;  select i.Id, i.SortId, i.Summary, LinkText, LinkedIssueId, LinkedIssueSortId, LinkedIssueSummary from @issues i inner join Dev.Jira.Issue.Link li     on i.Id = li.IssueId ```  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something failed with the execution or parsing of your query - 401 Unauthorized - 403 Forbidden 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class PutByQueryJsonExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlExecutionApi(config);
            var body = select * from sys.field;  // string | LuminesceSql to Execute (may be multi-line)
            var queryName = Get tables/fields;  // string? | Name to apply to the query in logs and `Sys.Logs.HcQueryStart` (optional) 
            var timeoutSeconds = 120;  // int? | In seconds: <0 → ∞, 0 → 120s (optional)  (default to 0)
            var jsonProper = false;  // bool? | Should this be text/json (not json-encoded-as-a-string) (optional)  (default to false)

            try
            {
                // PutByQueryJson: Executes Sql, returned in JSON format, where the sql is the post-body url.
                string result = apiInstance.PutByQueryJson(body, queryName, timeoutSeconds, jsonProper);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlExecutionApi.PutByQueryJson: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutByQueryJsonWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PutByQueryJson: Executes Sql, returned in JSON format, where the sql is the post-body url.
    ApiResponse<string> response = apiInstance.PutByQueryJsonWithHttpInfo(body, queryName, timeoutSeconds, jsonProper);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SqlExecutionApi.PutByQueryJsonWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **string** | LuminesceSql to Execute (may be multi-line) |  |
| **queryName** | **string?** | Name to apply to the query in logs and &#x60;Sys.Logs.HcQueryStart&#x60; | [optional]  |
| **timeoutSeconds** | **int?** | In seconds: &lt;0 → ∞, 0 → 120s | [optional] [default to 0] |
| **jsonProper** | **bool?** | Should this be text/json (not json-encoded-as-a-string) | [optional] [default to false] |

### Return type

**string**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="putbyqueryparquet"></a>
# **PutByQueryParquet**
> System.IO.Stream PutByQueryParquet (string body, string? queryName = null, int? timeoutSeconds = null)

PutByQueryParquet: Executes Sql, returned in Parquet format, where the sql is the post-body url.

 For more complex LuminesceSql a PUT will allow for longer Sql. e.g.: ```sql @@cutoff = select #2020-02-01#; @issues = select Id, SortId, Summary, Created, Updated from Dev.Jira.Issue where Project='HC' and Created < @@cutoff and Updated > @@cutoff;  select i.Id, i.SortId, i.Summary, LinkText, LinkedIssueId, LinkedIssueSortId, LinkedIssueSummary from @issues i inner join Dev.Jira.Issue.Link li     on i.Id = li.IssueId ```  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something failed with the execution or parsing of your query - 401 Unauthorized - 403 Forbidden 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class PutByQueryParquetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlExecutionApi(config);
            var body = select * from sys.field;  // string | LuminesceSql to Execute (may be multi-line)
            var queryName = Get tables/fields;  // string? | Name to apply to the query in logs and `Sys.Logs.HcQueryStart` (optional) 
            var timeoutSeconds = 120;  // int? | In seconds: <0 → ∞, 0 → 120s (optional)  (default to 0)

            try
            {
                // PutByQueryParquet: Executes Sql, returned in Parquet format, where the sql is the post-body url.
                System.IO.Stream result = apiInstance.PutByQueryParquet(body, queryName, timeoutSeconds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlExecutionApi.PutByQueryParquet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutByQueryParquetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PutByQueryParquet: Executes Sql, returned in Parquet format, where the sql is the post-body url.
    ApiResponse<System.IO.Stream> response = apiInstance.PutByQueryParquetWithHttpInfo(body, queryName, timeoutSeconds);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SqlExecutionApi.PutByQueryParquetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **string** | LuminesceSql to Execute (may be multi-line) |  |
| **queryName** | **string?** | Name to apply to the query in logs and &#x60;Sys.Logs.HcQueryStart&#x60; | [optional]  |
| **timeoutSeconds** | **int?** | In seconds: &lt;0 → ∞, 0 → 120s | [optional] [default to 0] |

### Return type

**System.IO.Stream**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="putbyquerypipe"></a>
# **PutByQueryPipe**
> string PutByQueryPipe (string body, string? queryName = null, bool? download = null, int? timeoutSeconds = null)

PutByQueryPipe: Executes Sql, returned in pipe-delimited format, where the sql is the post-body url.

 For more complex LuminesceSql a PUT will allow for longer Sql. e.g.: ```sql @@cutoff = select #2020-02-01#; @issues = select Id, SortId, Summary, Created, Updated from Dev.Jira.Issue where Project='HC' and Created < @@cutoff and Updated > @@cutoff;  select i.Id, i.SortId, i.Summary, LinkText, LinkedIssueId, LinkedIssueSortId, LinkedIssueSummary from @issues i inner join Dev.Jira.Issue.Link li     on i.Id = li.IssueId ```  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something failed with the execution or parsing of your query - 401 Unauthorized - 403 Forbidden 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class PutByQueryPipeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlExecutionApi(config);
            var body = select * from sys.field;  // string | LuminesceSql to Execute (may be multi-line)
            var queryName = Get tables/fields;  // string? | Name to apply to the query in logs and `Sys.Logs.HcQueryStart` (optional) 
            var download = false;  // bool? | Makes this a file-download request (as opposed to returning the data in the response-body) (optional)  (default to false)
            var timeoutSeconds = 120;  // int? | In seconds: <0 → ∞, 0 → 120s (optional)  (default to 0)

            try
            {
                // PutByQueryPipe: Executes Sql, returned in pipe-delimited format, where the sql is the post-body url.
                string result = apiInstance.PutByQueryPipe(body, queryName, download, timeoutSeconds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlExecutionApi.PutByQueryPipe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutByQueryPipeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PutByQueryPipe: Executes Sql, returned in pipe-delimited format, where the sql is the post-body url.
    ApiResponse<string> response = apiInstance.PutByQueryPipeWithHttpInfo(body, queryName, download, timeoutSeconds);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SqlExecutionApi.PutByQueryPipeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **string** | LuminesceSql to Execute (may be multi-line) |  |
| **queryName** | **string?** | Name to apply to the query in logs and &#x60;Sys.Logs.HcQueryStart&#x60; | [optional]  |
| **download** | **bool?** | Makes this a file-download request (as opposed to returning the data in the response-body) | [optional] [default to false] |
| **timeoutSeconds** | **int?** | In seconds: &lt;0 → ∞, 0 → 120s | [optional] [default to 0] |

### Return type

**string**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="putbyquerysqlite"></a>
# **PutByQuerySqlite**
> System.IO.Stream PutByQuerySqlite (string body, string? queryName = null, int? timeoutSeconds = null)

PutByQuerySqlite: Executes Sql, returned in SqLite DB (sqlite3) format (as a file to be downloaded), where the sql is the post-body url.

 For more complex LuminesceSql a PUT will allow for longer Sql. e.g.: ```sql @@cutoff = select #2020-02-01#; @issues = select Id, SortId, Summary, Created, Updated from Dev.Jira.Issue where Project='HC' and Created < @@cutoff and Updated > @@cutoff;  select i.Id, i.SortId, i.Summary, LinkText, LinkedIssueId, LinkedIssueSortId, LinkedIssueSummary from @issues i inner join Dev.Jira.Issue.Link li     on i.Id = li.IssueId ```  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something failed with the execution or parsing of your query - 401 Unauthorized - 403 Forbidden 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class PutByQuerySqliteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlExecutionApi(config);
            var body = select * from sys.field;  // string | LuminesceSql to Execute (may be multi-line)
            var queryName = Get tables/fields;  // string? | Name to apply to the query in logs and `Sys.Logs.HcQueryStart` (optional) 
            var timeoutSeconds = 120;  // int? | In seconds: <0 → ∞, 0 → 120s (optional)  (default to 0)

            try
            {
                // PutByQuerySqlite: Executes Sql, returned in SqLite DB (sqlite3) format (as a file to be downloaded), where the sql is the post-body url.
                System.IO.Stream result = apiInstance.PutByQuerySqlite(body, queryName, timeoutSeconds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlExecutionApi.PutByQuerySqlite: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutByQuerySqliteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PutByQuerySqlite: Executes Sql, returned in SqLite DB (sqlite3) format (as a file to be downloaded), where the sql is the post-body url.
    ApiResponse<System.IO.Stream> response = apiInstance.PutByQuerySqliteWithHttpInfo(body, queryName, timeoutSeconds);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SqlExecutionApi.PutByQuerySqliteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **string** | LuminesceSql to Execute (may be multi-line) |  |
| **queryName** | **string?** | Name to apply to the query in logs and &#x60;Sys.Logs.HcQueryStart&#x60; | [optional]  |
| **timeoutSeconds** | **int?** | In seconds: &lt;0 → ∞, 0 → 120s | [optional] [default to 0] |

### Return type

**System.IO.Stream**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="putbyqueryxml"></a>
# **PutByQueryXml**
> string PutByQueryXml (string body, string? queryName = null, bool? download = null, int? timeoutSeconds = null)

PutByQueryXml: Executes Sql, returned in Xml format, where the sql is the post-body url.

 For more complex LuminesceSql a PUT will allow for longer Sql. e.g.: ```sql @@cutoff = select #2020-02-01#; @issues = select Id, SortId, Summary, Created, Updated from Dev.Jira.Issue where Project='HC' and Created < @@cutoff and Updated > @@cutoff;  select i.Id, i.SortId, i.Summary, LinkText, LinkedIssueId, LinkedIssueSortId, LinkedIssueSummary from @issues i inner join Dev.Jira.Issue.Link li     on i.Id = li.IssueId ```  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something failed with the execution or parsing of your query - 401 Unauthorized - 403 Forbidden 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class PutByQueryXmlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlExecutionApi(config);
            var body = select * from sys.field;  // string | LuminesceSql to Execute (may be multi-line)
            var queryName = Get tables/fields;  // string? | Name to apply to the query in logs and `Sys.Logs.HcQueryStart` (optional) 
            var download = false;  // bool? | Makes this a file-download request (as opposed to returning the data in the response-body) (optional)  (default to false)
            var timeoutSeconds = 120;  // int? | In seconds: <0 → ∞, 0 → 120s (optional)  (default to 0)

            try
            {
                // PutByQueryXml: Executes Sql, returned in Xml format, where the sql is the post-body url.
                string result = apiInstance.PutByQueryXml(body, queryName, download, timeoutSeconds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlExecutionApi.PutByQueryXml: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutByQueryXmlWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PutByQueryXml: Executes Sql, returned in Xml format, where the sql is the post-body url.
    ApiResponse<string> response = apiInstance.PutByQueryXmlWithHttpInfo(body, queryName, download, timeoutSeconds);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SqlExecutionApi.PutByQueryXmlWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **string** | LuminesceSql to Execute (may be multi-line) |  |
| **queryName** | **string?** | Name to apply to the query in logs and &#x60;Sys.Logs.HcQueryStart&#x60; | [optional]  |
| **download** | **bool?** | Makes this a file-download request (as opposed to returning the data in the response-body) | [optional] [default to false] |
| **timeoutSeconds** | **int?** | In seconds: &lt;0 → ∞, 0 → 120s | [optional] [default to 0] |

### Return type

**string**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


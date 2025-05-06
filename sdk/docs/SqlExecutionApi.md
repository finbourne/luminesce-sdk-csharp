# Finbourne.Luminesce.Sdk.Api.SqlExecutionApi

All URIs are relative to *https://fbn-prd.lusid.com/honeycomb*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetByQueryCsv**](SqlExecutionApi.md#getbyquerycsv) | **GET** /api/Sql/csv/{query} | GetByQueryCsv: Execute Sql from the url returning CSV |
| [**GetByQueryExcel**](SqlExecutionApi.md#getbyqueryexcel) | **GET** /api/Sql/excel/{query} | GetByQueryExcel: Execute Sql from the url returning an Excel file |
| [**GetByQueryJson**](SqlExecutionApi.md#getbyqueryjson) | **GET** /api/Sql/json/{query} | GetByQueryJson: Execute Sql from the url returning JSON |
| [**GetByQueryParquet**](SqlExecutionApi.md#getbyqueryparquet) | **GET** /api/Sql/parquet/{query} | GetByQueryParquet: Execute Sql from the url returning a Parquet file |
| [**GetByQueryPipe**](SqlExecutionApi.md#getbyquerypipe) | **GET** /api/Sql/pipe/{query} | GetByQueryPipe: Execute Sql from the url returning pipe-delimited |
| [**GetByQuerySqlite**](SqlExecutionApi.md#getbyquerysqlite) | **GET** /api/Sql/sqlite/{query} | GetByQuerySqlite: Execute Sql from the url returning SqLite DB |
| [**GetByQueryXml**](SqlExecutionApi.md#getbyqueryxml) | **GET** /api/Sql/xml/{query} | GetByQueryXml: Execute Sql from the url returning XML |
| [**PutByQueryCsv**](SqlExecutionApi.md#putbyquerycsv) | **PUT** /api/Sql/csv | PutByQueryCsv: Execute Sql from the body returning CSV |
| [**PutByQueryExcel**](SqlExecutionApi.md#putbyqueryexcel) | **PUT** /api/Sql/excel | PutByQueryExcel: Execute Sql from the body making an Excel file |
| [**PutByQueryJson**](SqlExecutionApi.md#putbyqueryjson) | **PUT** /api/Sql/json | PutByQueryJson: Execute Sql from the body returning JSON |
| [**PutByQueryParquet**](SqlExecutionApi.md#putbyqueryparquet) | **PUT** /api/Sql/parquet | PutByQueryParquet: Execute Sql from the body making a Parquet file |
| [**PutByQueryPipe**](SqlExecutionApi.md#putbyquerypipe) | **PUT** /api/Sql/pipe | PutByQueryPipe: Execute Sql from the body making pipe-delimited |
| [**PutByQuerySqlite**](SqlExecutionApi.md#putbyquerysqlite) | **PUT** /api/Sql/sqlite | PutByQuerySqlite: Execute Sql from the body returning SqLite DB |
| [**PutByQueryXml**](SqlExecutionApi.md#putbyqueryxml) | **PUT** /api/Sql/xml | PutByQueryXml: Execute Sql from the body returning XML |

<a id="getbyquerycsv"></a>
# **GetByQueryCsv**
> string GetByQueryCsv (string query, Dictionary<string, string>? scalarParameters = null, string? queryName = null, bool? download = null, int? timeout = null, string? delimiter = null, string? escape = null)

GetByQueryCsv: Execute Sql from the url returning CSV

 Returns data from a simple single-line query execution which is specified on the url. e.g. `select ^ from Sys.Field order by 1, 2`, returned in the format of the method name.  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something failed with the execution or parsing of your query - 401 Unauthorized - 403 Forbidden 

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SqlExecutionApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SqlExecutionApi>();
            var query = select ^ from Sys.Field order by 1, 2;  // string | LuminesceSql to Execute (must be one line only)
            var scalarParameters = new Dictionary<string, string>?(); // Dictionary<string, string>? | Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. (optional) 
            var queryName = Get tables/fields;  // string? | Name to apply to the query in logs and `Sys.Logs.HcQueryStart` (optional) 
            var download = false;  // bool? | Makes this a file-download request (as opposed to returning the data in the response-body) (optional)  (default to false)
            var timeout = 150;  // int? | In seconds: <0 or > 175 → 175s (Maximum allowed), 0 → 120s (optional)  (default to 0)
            var delimiter = "delimiter_example";  // string? | Delimiter string to override the default (optional) 
            var escape = "escape_example";  // string? | Escape character to override the default (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // string result = apiInstance.GetByQueryCsv(query, scalarParameters, queryName, download, timeout, delimiter, escape, opts: opts);

                // GetByQueryCsv: Execute Sql from the url returning CSV
                string result = apiInstance.GetByQueryCsv(query, scalarParameters, queryName, download, timeout, delimiter, escape);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SqlExecutionApi.GetByQueryCsv: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    // GetByQueryCsv: Execute Sql from the url returning CSV
    ApiResponse<string> response = apiInstance.GetByQueryCsvWithHttpInfo(query, scalarParameters, queryName, download, timeout, delimiter, escape);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SqlExecutionApi.GetByQueryCsvWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **query** | **string** | LuminesceSql to Execute (must be one line only) |  |
| **scalarParameters** | [**Dictionary&lt;string, string&gt;?**](string.md) | Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. | [optional]  |
| **queryName** | **string?** | Name to apply to the query in logs and &#x60;Sys.Logs.HcQueryStart&#x60; | [optional]  |
| **download** | **bool?** | Makes this a file-download request (as opposed to returning the data in the response-body) | [optional] [default to false] |
| **timeout** | **int?** | In seconds: &lt;0 or &gt; 175 → 175s (Maximum allowed), 0 → 120s | [optional] [default to 0] |
| **delimiter** | **string?** | Delimiter string to override the default | [optional]  |
| **escape** | **string?** | Escape character to override the default | [optional]  |

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

<a id="getbyqueryexcel"></a>
# **GetByQueryExcel**
> System.IO.Stream GetByQueryExcel (string query, Dictionary<string, string>? scalarParameters = null, string? queryName = null, int? timeout = null)

GetByQueryExcel: Execute Sql from the url returning an Excel file

 Returns data from a simple single-line query execution which is specified on the url. e.g. `select ^ from Sys.Field order by 1, 2`, returned in the format of the method name.  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something failed with the execution or parsing of your query - 401 Unauthorized - 403 Forbidden 

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SqlExecutionApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SqlExecutionApi>();
            var query = select ^ from Sys.Field order by 1, 2;  // string | LuminesceSql to Execute (must be one line only)
            var scalarParameters = new Dictionary<string, string>?(); // Dictionary<string, string>? | Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. (optional) 
            var queryName = Get tables/fields;  // string? | Name to apply to the query in logs and `Sys.Logs.HcQueryStart` (optional) 
            var timeout = 150;  // int? | In seconds: <0 or > 175 → 175s (Maximum allowed), 0 → 120s (optional)  (default to 0)

            try
            {
                // uncomment the below to set overrides at the request level
                // System.IO.Stream result = apiInstance.GetByQueryExcel(query, scalarParameters, queryName, timeout, opts: opts);

                // GetByQueryExcel: Execute Sql from the url returning an Excel file
                System.IO.Stream result = apiInstance.GetByQueryExcel(query, scalarParameters, queryName, timeout);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SqlExecutionApi.GetByQueryExcel: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    // GetByQueryExcel: Execute Sql from the url returning an Excel file
    ApiResponse<System.IO.Stream> response = apiInstance.GetByQueryExcelWithHttpInfo(query, scalarParameters, queryName, timeout);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SqlExecutionApi.GetByQueryExcelWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **query** | **string** | LuminesceSql to Execute (must be one line only) |  |
| **scalarParameters** | [**Dictionary&lt;string, string&gt;?**](string.md) | Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. | [optional]  |
| **queryName** | **string?** | Name to apply to the query in logs and &#x60;Sys.Logs.HcQueryStart&#x60; | [optional]  |
| **timeout** | **int?** | In seconds: &lt;0 or &gt; 175 → 175s (Maximum allowed), 0 → 120s | [optional] [default to 0] |

### Return type

**System.IO.Stream**

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

<a id="getbyqueryjson"></a>
# **GetByQueryJson**
> string GetByQueryJson (string query, Dictionary<string, string>? scalarParameters = null, string? queryName = null, int? timeout = null, bool? jsonProper = null)

GetByQueryJson: Execute Sql from the url returning JSON

 Returns data from a simple single-line query execution which is specified on the url. e.g. `select ^ from Sys.Field order by 1, 2`, returned in the format of the method name.  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something failed with the execution or parsing of your query - 401 Unauthorized - 403 Forbidden 

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SqlExecutionApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SqlExecutionApi>();
            var query = select ^ from Sys.Field order by 1, 2;  // string | LuminesceSql to Execute (must be one line only)
            var scalarParameters = new Dictionary<string, string>?(); // Dictionary<string, string>? | Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. (optional) 
            var queryName = Get tables/fields;  // string? | Name to apply to the query in logs and `Sys.Logs.HcQueryStart` (optional) 
            var timeout = 150;  // int? | In seconds: <0 or > 175 → 175s (Maximum allowed), 0 → 120s (optional)  (default to 0)
            var jsonProper = false;  // bool? | Should this be text/json (not json-encoded-as-a-string) (optional)  (default to false)

            try
            {
                // uncomment the below to set overrides at the request level
                // string result = apiInstance.GetByQueryJson(query, scalarParameters, queryName, timeout, jsonProper, opts: opts);

                // GetByQueryJson: Execute Sql from the url returning JSON
                string result = apiInstance.GetByQueryJson(query, scalarParameters, queryName, timeout, jsonProper);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SqlExecutionApi.GetByQueryJson: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    // GetByQueryJson: Execute Sql from the url returning JSON
    ApiResponse<string> response = apiInstance.GetByQueryJsonWithHttpInfo(query, scalarParameters, queryName, timeout, jsonProper);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SqlExecutionApi.GetByQueryJsonWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **query** | **string** | LuminesceSql to Execute (must be one line only) |  |
| **scalarParameters** | [**Dictionary&lt;string, string&gt;?**](string.md) | Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. | [optional]  |
| **queryName** | **string?** | Name to apply to the query in logs and &#x60;Sys.Logs.HcQueryStart&#x60; | [optional]  |
| **timeout** | **int?** | In seconds: &lt;0 or &gt; 175 → 175s (Maximum allowed), 0 → 120s | [optional] [default to 0] |
| **jsonProper** | **bool?** | Should this be text/json (not json-encoded-as-a-string) | [optional] [default to false] |

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

<a id="getbyqueryparquet"></a>
# **GetByQueryParquet**
> System.IO.Stream GetByQueryParquet (string query, Dictionary<string, string>? scalarParameters = null, string? queryName = null, int? timeout = null)

GetByQueryParquet: Execute Sql from the url returning a Parquet file

 Returns data from a simple single-line query execution which is specified on the url. e.g. `select ^ from Sys.Field order by 1, 2`, returned in the format of the method name.  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something failed with the execution or parsing of your query - 401 Unauthorized - 403 Forbidden 

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SqlExecutionApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SqlExecutionApi>();
            var query = select ^ from Sys.Field order by 1, 2;  // string | LuminesceSql to Execute (must be one line only)
            var scalarParameters = new Dictionary<string, string>?(); // Dictionary<string, string>? | Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. (optional) 
            var queryName = Get tables/fields;  // string? | Name to apply to the query in logs and `Sys.Logs.HcQueryStart` (optional) 
            var timeout = 150;  // int? | In seconds: <0 or > 175 → 175s (Maximum allowed), 0 → 120s (optional)  (default to 0)

            try
            {
                // uncomment the below to set overrides at the request level
                // System.IO.Stream result = apiInstance.GetByQueryParquet(query, scalarParameters, queryName, timeout, opts: opts);

                // GetByQueryParquet: Execute Sql from the url returning a Parquet file
                System.IO.Stream result = apiInstance.GetByQueryParquet(query, scalarParameters, queryName, timeout);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SqlExecutionApi.GetByQueryParquet: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    // GetByQueryParquet: Execute Sql from the url returning a Parquet file
    ApiResponse<System.IO.Stream> response = apiInstance.GetByQueryParquetWithHttpInfo(query, scalarParameters, queryName, timeout);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SqlExecutionApi.GetByQueryParquetWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **query** | **string** | LuminesceSql to Execute (must be one line only) |  |
| **scalarParameters** | [**Dictionary&lt;string, string&gt;?**](string.md) | Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. | [optional]  |
| **queryName** | **string?** | Name to apply to the query in logs and &#x60;Sys.Logs.HcQueryStart&#x60; | [optional]  |
| **timeout** | **int?** | In seconds: &lt;0 or &gt; 175 → 175s (Maximum allowed), 0 → 120s | [optional] [default to 0] |

### Return type

**System.IO.Stream**

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

<a id="getbyquerypipe"></a>
# **GetByQueryPipe**
> string GetByQueryPipe (string query, Dictionary<string, string>? scalarParameters = null, string? queryName = null, bool? download = null, int? timeout = null)

GetByQueryPipe: Execute Sql from the url returning pipe-delimited

 Returns data from a simple single-line query execution which is specified on the url. e.g. `select ^ from Sys.Field order by 1, 2`, returned in the format of the method name.  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something failed with the execution or parsing of your query - 401 Unauthorized - 403 Forbidden 

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SqlExecutionApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SqlExecutionApi>();
            var query = select ^ from Sys.Field order by 1, 2;  // string | LuminesceSql to Execute (must be one line only)
            var scalarParameters = new Dictionary<string, string>?(); // Dictionary<string, string>? | Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. (optional) 
            var queryName = Get tables/fields;  // string? | Name to apply to the query in logs and `Sys.Logs.HcQueryStart` (optional) 
            var download = false;  // bool? | Makes this a file-download request (as opposed to returning the data in the response-body) (optional)  (default to false)
            var timeout = 150;  // int? | In seconds: <0 or > 175 → 175s (Maximum allowed), 0 → 120s (optional)  (default to 0)

            try
            {
                // uncomment the below to set overrides at the request level
                // string result = apiInstance.GetByQueryPipe(query, scalarParameters, queryName, download, timeout, opts: opts);

                // GetByQueryPipe: Execute Sql from the url returning pipe-delimited
                string result = apiInstance.GetByQueryPipe(query, scalarParameters, queryName, download, timeout);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SqlExecutionApi.GetByQueryPipe: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    // GetByQueryPipe: Execute Sql from the url returning pipe-delimited
    ApiResponse<string> response = apiInstance.GetByQueryPipeWithHttpInfo(query, scalarParameters, queryName, download, timeout);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SqlExecutionApi.GetByQueryPipeWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **query** | **string** | LuminesceSql to Execute (must be one line only) |  |
| **scalarParameters** | [**Dictionary&lt;string, string&gt;?**](string.md) | Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. | [optional]  |
| **queryName** | **string?** | Name to apply to the query in logs and &#x60;Sys.Logs.HcQueryStart&#x60; | [optional]  |
| **download** | **bool?** | Makes this a file-download request (as opposed to returning the data in the response-body) | [optional] [default to false] |
| **timeout** | **int?** | In seconds: &lt;0 or &gt; 175 → 175s (Maximum allowed), 0 → 120s | [optional] [default to 0] |

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

<a id="getbyquerysqlite"></a>
# **GetByQuerySqlite**
> System.IO.Stream GetByQuerySqlite (string query, Dictionary<string, string>? scalarParameters = null, string? queryName = null, int? timeout = null)

GetByQuerySqlite: Execute Sql from the url returning SqLite DB

 Returns data from a simple single-line query execution which is specified on the url. e.g. `select ^ from Sys.Field order by 1, 2`, returned in the format of the method name.  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something failed with the execution or parsing of your query - 401 Unauthorized - 403 Forbidden 

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SqlExecutionApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SqlExecutionApi>();
            var query = select ^ from Sys.Field order by 1, 2;  // string | LuminesceSql to Execute (must be one line only)
            var scalarParameters = new Dictionary<string, string>?(); // Dictionary<string, string>? | Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. (optional) 
            var queryName = Get tables/fields;  // string? | Name to apply to the query in logs and `Sys.Logs.HcQueryStart` (optional) 
            var timeout = 150;  // int? | In seconds: <0 or > 175 → 175s (Maximum allowed), 0 → 120s (optional)  (default to 0)

            try
            {
                // uncomment the below to set overrides at the request level
                // System.IO.Stream result = apiInstance.GetByQuerySqlite(query, scalarParameters, queryName, timeout, opts: opts);

                // GetByQuerySqlite: Execute Sql from the url returning SqLite DB
                System.IO.Stream result = apiInstance.GetByQuerySqlite(query, scalarParameters, queryName, timeout);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SqlExecutionApi.GetByQuerySqlite: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    // GetByQuerySqlite: Execute Sql from the url returning SqLite DB
    ApiResponse<System.IO.Stream> response = apiInstance.GetByQuerySqliteWithHttpInfo(query, scalarParameters, queryName, timeout);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SqlExecutionApi.GetByQuerySqliteWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **query** | **string** | LuminesceSql to Execute (must be one line only) |  |
| **scalarParameters** | [**Dictionary&lt;string, string&gt;?**](string.md) | Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. | [optional]  |
| **queryName** | **string?** | Name to apply to the query in logs and &#x60;Sys.Logs.HcQueryStart&#x60; | [optional]  |
| **timeout** | **int?** | In seconds: &lt;0 or &gt; 175 → 175s (Maximum allowed), 0 → 120s | [optional] [default to 0] |

### Return type

**System.IO.Stream**

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

<a id="getbyqueryxml"></a>
# **GetByQueryXml**
> string GetByQueryXml (string query, Dictionary<string, string>? scalarParameters = null, string? queryName = null, bool? download = null, int? timeout = null)

GetByQueryXml: Execute Sql from the url returning XML

 Returns data from a simple single-line query execution which is specified on the url. e.g. `select ^ from Sys.Field order by 1, 2`, returned in the format of the method name.  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something failed with the execution or parsing of your query - 401 Unauthorized - 403 Forbidden 

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SqlExecutionApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SqlExecutionApi>();
            var query = select ^ from Sys.Field order by 1, 2;  // string | LuminesceSql to Execute (must be one line only)
            var scalarParameters = new Dictionary<string, string>?(); // Dictionary<string, string>? | Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. (optional) 
            var queryName = Get tables/fields;  // string? | Name to apply to the query in logs and `Sys.Logs.HcQueryStart` (optional) 
            var download = false;  // bool? | Makes this a file-download request (as opposed to returning the data in the response-body) (optional)  (default to false)
            var timeout = 150;  // int? | In seconds: <0 or > 175 → 175s (Maximum allowed), 0 → 120s (optional)  (default to 0)

            try
            {
                // uncomment the below to set overrides at the request level
                // string result = apiInstance.GetByQueryXml(query, scalarParameters, queryName, download, timeout, opts: opts);

                // GetByQueryXml: Execute Sql from the url returning XML
                string result = apiInstance.GetByQueryXml(query, scalarParameters, queryName, download, timeout);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SqlExecutionApi.GetByQueryXml: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    // GetByQueryXml: Execute Sql from the url returning XML
    ApiResponse<string> response = apiInstance.GetByQueryXmlWithHttpInfo(query, scalarParameters, queryName, download, timeout);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SqlExecutionApi.GetByQueryXmlWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **query** | **string** | LuminesceSql to Execute (must be one line only) |  |
| **scalarParameters** | [**Dictionary&lt;string, string&gt;?**](string.md) | Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. | [optional]  |
| **queryName** | **string?** | Name to apply to the query in logs and &#x60;Sys.Logs.HcQueryStart&#x60; | [optional]  |
| **download** | **bool?** | Makes this a file-download request (as opposed to returning the data in the response-body) | [optional] [default to false] |
| **timeout** | **int?** | In seconds: &lt;0 or &gt; 175 → 175s (Maximum allowed), 0 → 120s | [optional] [default to 0] |

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

<a id="putbyquerycsv"></a>
# **PutByQueryCsv**
> string PutByQueryCsv (string body, Dictionary<string, string>? scalarParameters = null, string? queryName = null, bool? download = null, int? timeoutSeconds = null, string? delimiter = null, string? escape = null)

PutByQueryCsv: Execute Sql from the body returning CSV

 For more complex LuminesceSql a PUT will allow for longer and line break delimited Sql, whic will be returned in the format of the method name. e.g.: ```sql @@cutoff = select #2020-02-01#; @issues = select Id, SortId, Summary, Created, Updated from Dev.Jira.Issue where Project='HC' and Created < @@cutoff and Updated > @@cutoff;  select i.Id, i.SortId, i.Summary, LinkText, LinkedIssueId, LinkedIssueSortId, LinkedIssueSummary from @issues i inner join Dev.Jira.Issue.Link li     on i.Id = li.IssueId ```  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something failed with the execution or parsing of your query - 401 Unauthorized - 403 Forbidden 

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SqlExecutionApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SqlExecutionApi>();
            var body = select * from sys.field;  // string | LuminesceSql to Execute (may be multi-line)
            var scalarParameters = new Dictionary<string, string>?(); // Dictionary<string, string>? | Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. (optional) 
            var queryName = Get tables/fields;  // string? | Name to apply to the query in logs and `Sys.Logs.HcQueryStart` (optional) 
            var download = false;  // bool? | Makes this a file-download request (as opposed to returning the data in the response-body) (optional)  (default to false)
            var timeoutSeconds = 150;  // int? | In seconds: <0 or > 175 → 175s (Maximum allowed), 0 → 120s (optional)  (default to 0)
            var delimiter = "delimiter_example";  // string? | Delimiter string to override the default (optional) 
            var escape = "escape_example";  // string? | Escape character to override the default (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // string result = apiInstance.PutByQueryCsv(body, scalarParameters, queryName, download, timeoutSeconds, delimiter, escape, opts: opts);

                // PutByQueryCsv: Execute Sql from the body returning CSV
                string result = apiInstance.PutByQueryCsv(body, scalarParameters, queryName, download, timeoutSeconds, delimiter, escape);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SqlExecutionApi.PutByQueryCsv: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    // PutByQueryCsv: Execute Sql from the body returning CSV
    ApiResponse<string> response = apiInstance.PutByQueryCsvWithHttpInfo(body, scalarParameters, queryName, download, timeoutSeconds, delimiter, escape);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SqlExecutionApi.PutByQueryCsvWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **string** | LuminesceSql to Execute (may be multi-line) |  |
| **scalarParameters** | [**Dictionary&lt;string, string&gt;?**](string.md) | Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. | [optional]  |
| **queryName** | **string?** | Name to apply to the query in logs and &#x60;Sys.Logs.HcQueryStart&#x60; | [optional]  |
| **download** | **bool?** | Makes this a file-download request (as opposed to returning the data in the response-body) | [optional] [default to false] |
| **timeoutSeconds** | **int?** | In seconds: &lt;0 or &gt; 175 → 175s (Maximum allowed), 0 → 120s | [optional] [default to 0] |
| **delimiter** | **string?** | Delimiter string to override the default | [optional]  |
| **escape** | **string?** | Escape character to override the default | [optional]  |

### Return type

**string**

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="putbyqueryexcel"></a>
# **PutByQueryExcel**
> System.IO.Stream PutByQueryExcel (string body, Dictionary<string, string>? scalarParameters = null, string? queryName = null, int? timeoutSeconds = null)

PutByQueryExcel: Execute Sql from the body making an Excel file

 For more complex LuminesceSql a PUT will allow for longer and line break delimited Sql, whic will be returned in the format of the method name. e.g.: ```sql @@cutoff = select #2020-02-01#; @issues = select Id, SortId, Summary, Created, Updated from Dev.Jira.Issue where Project='HC' and Created < @@cutoff and Updated > @@cutoff;  select i.Id, i.SortId, i.Summary, LinkText, LinkedIssueId, LinkedIssueSortId, LinkedIssueSummary from @issues i inner join Dev.Jira.Issue.Link li     on i.Id = li.IssueId ```  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something failed with the execution or parsing of your query - 401 Unauthorized - 403 Forbidden 

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SqlExecutionApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SqlExecutionApi>();
            var body = select * from sys.field;  // string | LuminesceSql to Execute (may be multi-line)
            var scalarParameters = new Dictionary<string, string>?(); // Dictionary<string, string>? | Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. (optional) 
            var queryName = Get tables/fields;  // string? | Name to apply to the query in logs and `Sys.Logs.HcQueryStart` (optional) 
            var timeoutSeconds = 150;  // int? | In seconds: <0 or > 175 → 175s (Maximum allowed), 0 → 120s (optional)  (default to 0)

            try
            {
                // uncomment the below to set overrides at the request level
                // System.IO.Stream result = apiInstance.PutByQueryExcel(body, scalarParameters, queryName, timeoutSeconds, opts: opts);

                // PutByQueryExcel: Execute Sql from the body making an Excel file
                System.IO.Stream result = apiInstance.PutByQueryExcel(body, scalarParameters, queryName, timeoutSeconds);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SqlExecutionApi.PutByQueryExcel: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    // PutByQueryExcel: Execute Sql from the body making an Excel file
    ApiResponse<System.IO.Stream> response = apiInstance.PutByQueryExcelWithHttpInfo(body, scalarParameters, queryName, timeoutSeconds);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SqlExecutionApi.PutByQueryExcelWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **string** | LuminesceSql to Execute (may be multi-line) |  |
| **scalarParameters** | [**Dictionary&lt;string, string&gt;?**](string.md) | Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. | [optional]  |
| **queryName** | **string?** | Name to apply to the query in logs and &#x60;Sys.Logs.HcQueryStart&#x60; | [optional]  |
| **timeoutSeconds** | **int?** | In seconds: &lt;0 or &gt; 175 → 175s (Maximum allowed), 0 → 120s | [optional] [default to 0] |

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="putbyqueryjson"></a>
# **PutByQueryJson**
> string PutByQueryJson (string body, Dictionary<string, string>? scalarParameters = null, string? queryName = null, int? timeoutSeconds = null, bool? jsonProper = null)

PutByQueryJson: Execute Sql from the body returning JSON

 For more complex LuminesceSql a PUT will allow for longer and line break delimited Sql, whic will be returned in the format of the method name. e.g.: ```sql @@cutoff = select #2020-02-01#; @issues = select Id, SortId, Summary, Created, Updated from Dev.Jira.Issue where Project='HC' and Created < @@cutoff and Updated > @@cutoff;  select i.Id, i.SortId, i.Summary, LinkText, LinkedIssueId, LinkedIssueSortId, LinkedIssueSummary from @issues i inner join Dev.Jira.Issue.Link li     on i.Id = li.IssueId ```  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something failed with the execution or parsing of your query - 401 Unauthorized - 403 Forbidden 

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SqlExecutionApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SqlExecutionApi>();
            var body = select * from sys.field;  // string | LuminesceSql to Execute (may be multi-line)
            var scalarParameters = new Dictionary<string, string>?(); // Dictionary<string, string>? | Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. (optional) 
            var queryName = Get tables/fields;  // string? | Name to apply to the query in logs and `Sys.Logs.HcQueryStart` (optional) 
            var timeoutSeconds = 150;  // int? | In seconds: <0 or > 175 → 175s (Maximum allowed), 0 → 120s (optional)  (default to 0)
            var jsonProper = false;  // bool? | Should this be text/json (not json-encoded-as-a-string) (optional)  (default to false)

            try
            {
                // uncomment the below to set overrides at the request level
                // string result = apiInstance.PutByQueryJson(body, scalarParameters, queryName, timeoutSeconds, jsonProper, opts: opts);

                // PutByQueryJson: Execute Sql from the body returning JSON
                string result = apiInstance.PutByQueryJson(body, scalarParameters, queryName, timeoutSeconds, jsonProper);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SqlExecutionApi.PutByQueryJson: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    // PutByQueryJson: Execute Sql from the body returning JSON
    ApiResponse<string> response = apiInstance.PutByQueryJsonWithHttpInfo(body, scalarParameters, queryName, timeoutSeconds, jsonProper);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SqlExecutionApi.PutByQueryJsonWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **string** | LuminesceSql to Execute (may be multi-line) |  |
| **scalarParameters** | [**Dictionary&lt;string, string&gt;?**](string.md) | Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. | [optional]  |
| **queryName** | **string?** | Name to apply to the query in logs and &#x60;Sys.Logs.HcQueryStart&#x60; | [optional]  |
| **timeoutSeconds** | **int?** | In seconds: &lt;0 or &gt; 175 → 175s (Maximum allowed), 0 → 120s | [optional] [default to 0] |
| **jsonProper** | **bool?** | Should this be text/json (not json-encoded-as-a-string) | [optional] [default to false] |

### Return type

**string**

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="putbyqueryparquet"></a>
# **PutByQueryParquet**
> System.IO.Stream PutByQueryParquet (string body, Dictionary<string, string>? scalarParameters = null, string? queryName = null, int? timeoutSeconds = null)

PutByQueryParquet: Execute Sql from the body making a Parquet file

 For more complex LuminesceSql a PUT will allow for longer and line break delimited Sql, whic will be returned in the format of the method name. e.g.: ```sql @@cutoff = select #2020-02-01#; @issues = select Id, SortId, Summary, Created, Updated from Dev.Jira.Issue where Project='HC' and Created < @@cutoff and Updated > @@cutoff;  select i.Id, i.SortId, i.Summary, LinkText, LinkedIssueId, LinkedIssueSortId, LinkedIssueSummary from @issues i inner join Dev.Jira.Issue.Link li     on i.Id = li.IssueId ```  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something failed with the execution or parsing of your query - 401 Unauthorized - 403 Forbidden 

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SqlExecutionApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SqlExecutionApi>();
            var body = select * from sys.field;  // string | LuminesceSql to Execute (may be multi-line)
            var scalarParameters = new Dictionary<string, string>?(); // Dictionary<string, string>? | Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. (optional) 
            var queryName = Get tables/fields;  // string? | Name to apply to the query in logs and `Sys.Logs.HcQueryStart` (optional) 
            var timeoutSeconds = 150;  // int? | In seconds: <0 or > 175 → 175s (Maximum allowed), 0 → 120s (optional)  (default to 0)

            try
            {
                // uncomment the below to set overrides at the request level
                // System.IO.Stream result = apiInstance.PutByQueryParquet(body, scalarParameters, queryName, timeoutSeconds, opts: opts);

                // PutByQueryParquet: Execute Sql from the body making a Parquet file
                System.IO.Stream result = apiInstance.PutByQueryParquet(body, scalarParameters, queryName, timeoutSeconds);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SqlExecutionApi.PutByQueryParquet: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    // PutByQueryParquet: Execute Sql from the body making a Parquet file
    ApiResponse<System.IO.Stream> response = apiInstance.PutByQueryParquetWithHttpInfo(body, scalarParameters, queryName, timeoutSeconds);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SqlExecutionApi.PutByQueryParquetWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **string** | LuminesceSql to Execute (may be multi-line) |  |
| **scalarParameters** | [**Dictionary&lt;string, string&gt;?**](string.md) | Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. | [optional]  |
| **queryName** | **string?** | Name to apply to the query in logs and &#x60;Sys.Logs.HcQueryStart&#x60; | [optional]  |
| **timeoutSeconds** | **int?** | In seconds: &lt;0 or &gt; 175 → 175s (Maximum allowed), 0 → 120s | [optional] [default to 0] |

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="putbyquerypipe"></a>
# **PutByQueryPipe**
> string PutByQueryPipe (string body, Dictionary<string, string>? scalarParameters = null, string? queryName = null, bool? download = null, int? timeoutSeconds = null)

PutByQueryPipe: Execute Sql from the body making pipe-delimited

 For more complex LuminesceSql a PUT will allow for longer and line break delimited Sql, whic will be returned in the format of the method name. e.g.: ```sql @@cutoff = select #2020-02-01#; @issues = select Id, SortId, Summary, Created, Updated from Dev.Jira.Issue where Project='HC' and Created < @@cutoff and Updated > @@cutoff;  select i.Id, i.SortId, i.Summary, LinkText, LinkedIssueId, LinkedIssueSortId, LinkedIssueSummary from @issues i inner join Dev.Jira.Issue.Link li     on i.Id = li.IssueId ```  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something failed with the execution or parsing of your query - 401 Unauthorized - 403 Forbidden 

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SqlExecutionApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SqlExecutionApi>();
            var body = select * from sys.field;  // string | LuminesceSql to Execute (may be multi-line)
            var scalarParameters = new Dictionary<string, string>?(); // Dictionary<string, string>? | Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. (optional) 
            var queryName = Get tables/fields;  // string? | Name to apply to the query in logs and `Sys.Logs.HcQueryStart` (optional) 
            var download = false;  // bool? | Makes this a file-download request (as opposed to returning the data in the response-body) (optional)  (default to false)
            var timeoutSeconds = 150;  // int? | In seconds: <0 or > 175 → 175s (Maximum allowed), 0 → 120s (optional)  (default to 0)

            try
            {
                // uncomment the below to set overrides at the request level
                // string result = apiInstance.PutByQueryPipe(body, scalarParameters, queryName, download, timeoutSeconds, opts: opts);

                // PutByQueryPipe: Execute Sql from the body making pipe-delimited
                string result = apiInstance.PutByQueryPipe(body, scalarParameters, queryName, download, timeoutSeconds);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SqlExecutionApi.PutByQueryPipe: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    // PutByQueryPipe: Execute Sql from the body making pipe-delimited
    ApiResponse<string> response = apiInstance.PutByQueryPipeWithHttpInfo(body, scalarParameters, queryName, download, timeoutSeconds);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SqlExecutionApi.PutByQueryPipeWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **string** | LuminesceSql to Execute (may be multi-line) |  |
| **scalarParameters** | [**Dictionary&lt;string, string&gt;?**](string.md) | Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. | [optional]  |
| **queryName** | **string?** | Name to apply to the query in logs and &#x60;Sys.Logs.HcQueryStart&#x60; | [optional]  |
| **download** | **bool?** | Makes this a file-download request (as opposed to returning the data in the response-body) | [optional] [default to false] |
| **timeoutSeconds** | **int?** | In seconds: &lt;0 or &gt; 175 → 175s (Maximum allowed), 0 → 120s | [optional] [default to 0] |

### Return type

**string**

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="putbyquerysqlite"></a>
# **PutByQuerySqlite**
> System.IO.Stream PutByQuerySqlite (string body, Dictionary<string, string>? scalarParameters = null, string? queryName = null, int? timeoutSeconds = null)

PutByQuerySqlite: Execute Sql from the body returning SqLite DB

 For more complex LuminesceSql a PUT will allow for longer and line break delimited Sql, whic will be returned in the format of the method name. e.g.: ```sql @@cutoff = select #2020-02-01#; @issues = select Id, SortId, Summary, Created, Updated from Dev.Jira.Issue where Project='HC' and Created < @@cutoff and Updated > @@cutoff;  select i.Id, i.SortId, i.Summary, LinkText, LinkedIssueId, LinkedIssueSortId, LinkedIssueSummary from @issues i inner join Dev.Jira.Issue.Link li     on i.Id = li.IssueId ```  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something failed with the execution or parsing of your query - 401 Unauthorized - 403 Forbidden 

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SqlExecutionApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SqlExecutionApi>();
            var body = select * from sys.field;  // string | LuminesceSql to Execute (may be multi-line)
            var scalarParameters = new Dictionary<string, string>?(); // Dictionary<string, string>? | Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. (optional) 
            var queryName = Get tables/fields;  // string? | Name to apply to the query in logs and `Sys.Logs.HcQueryStart` (optional) 
            var timeoutSeconds = 150;  // int? | In seconds: <0 or > 175 → 175s (Maximum allowed), 0 → 120s (optional)  (default to 0)

            try
            {
                // uncomment the below to set overrides at the request level
                // System.IO.Stream result = apiInstance.PutByQuerySqlite(body, scalarParameters, queryName, timeoutSeconds, opts: opts);

                // PutByQuerySqlite: Execute Sql from the body returning SqLite DB
                System.IO.Stream result = apiInstance.PutByQuerySqlite(body, scalarParameters, queryName, timeoutSeconds);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SqlExecutionApi.PutByQuerySqlite: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    // PutByQuerySqlite: Execute Sql from the body returning SqLite DB
    ApiResponse<System.IO.Stream> response = apiInstance.PutByQuerySqliteWithHttpInfo(body, scalarParameters, queryName, timeoutSeconds);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SqlExecutionApi.PutByQuerySqliteWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **string** | LuminesceSql to Execute (may be multi-line) |  |
| **scalarParameters** | [**Dictionary&lt;string, string&gt;?**](string.md) | Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. | [optional]  |
| **queryName** | **string?** | Name to apply to the query in logs and &#x60;Sys.Logs.HcQueryStart&#x60; | [optional]  |
| **timeoutSeconds** | **int?** | In seconds: &lt;0 or &gt; 175 → 175s (Maximum allowed), 0 → 120s | [optional] [default to 0] |

### Return type

**System.IO.Stream**

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="putbyqueryxml"></a>
# **PutByQueryXml**
> string PutByQueryXml (string body, Dictionary<string, string>? scalarParameters = null, string? queryName = null, bool? download = null, int? timeoutSeconds = null)

PutByQueryXml: Execute Sql from the body returning XML

 For more complex LuminesceSql a PUT will allow for longer and line break delimited Sql, whic will be returned in the format of the method name. e.g.: ```sql @@cutoff = select #2020-02-01#; @issues = select Id, SortId, Summary, Created, Updated from Dev.Jira.Issue where Project='HC' and Created < @@cutoff and Updated > @@cutoff;  select i.Id, i.SortId, i.Summary, LinkText, LinkedIssueId, LinkedIssueSortId, LinkedIssueSummary from @issues i inner join Dev.Jira.Issue.Link li     on i.Id = li.IssueId ```  The following error codes are to be anticipated with standard Problem Detail reports: - 400 BadRequest - something failed with the execution or parsing of your query - 401 Unauthorized - 403 Forbidden 

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SqlExecutionApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SqlExecutionApi>();
            var body = select * from sys.field;  // string | LuminesceSql to Execute (may be multi-line)
            var scalarParameters = new Dictionary<string, string>?(); // Dictionary<string, string>? | Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. (optional) 
            var queryName = Get tables/fields;  // string? | Name to apply to the query in logs and `Sys.Logs.HcQueryStart` (optional) 
            var download = false;  // bool? | Makes this a file-download request (as opposed to returning the data in the response-body) (optional)  (default to false)
            var timeoutSeconds = 150;  // int? | In seconds: <0 or > 175 → 175s (Maximum allowed), 0 → 120s (optional)  (default to 0)

            try
            {
                // uncomment the below to set overrides at the request level
                // string result = apiInstance.PutByQueryXml(body, scalarParameters, queryName, download, timeoutSeconds, opts: opts);

                // PutByQueryXml: Execute Sql from the body returning XML
                string result = apiInstance.PutByQueryXml(body, scalarParameters, queryName, download, timeoutSeconds);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SqlExecutionApi.PutByQueryXml: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    // PutByQueryXml: Execute Sql from the body returning XML
    ApiResponse<string> response = apiInstance.PutByQueryXmlWithHttpInfo(body, scalarParameters, queryName, download, timeoutSeconds);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SqlExecutionApi.PutByQueryXmlWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **string** | LuminesceSql to Execute (may be multi-line) |  |
| **scalarParameters** | [**Dictionary&lt;string, string&gt;?**](string.md) | Json encoded dictionary of key-value pairs for scalar parameter values to use in the sql execution. | [optional]  |
| **queryName** | **string?** | Name to apply to the query in logs and &#x60;Sys.Logs.HcQueryStart&#x60; | [optional]  |
| **download** | **bool?** | Makes this a file-download request (as opposed to returning the data in the response-body) | [optional] [default to false] |
| **timeoutSeconds** | **int?** | In seconds: &lt;0 or &gt; 175 → 175s (Maximum allowed), 0 → 120s | [optional] [default to 0] |

### Return type

**string**

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)


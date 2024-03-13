# Finbourne.Luminesce.Sdk.Api.SqlDesignApi

All URIs are relative to *https://fbn-prd.lusid.com/honeycomb*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PutFileReadDesignToSql**](SqlDesignApi.md#putfilereaddesigntosql) | **PUT** /api/Sql/fromfilereaddesign | [EXPERIMENTAL] PutFileReadDesignToSql: Generates file read SQL from a structured query design |
| [**PutIntellisense**](SqlDesignApi.md#putintellisense) | **PUT** /api/Sql/intellisense | [EXPERIMENTAL] PutIntellisense: Generate a set of possible intellisense prompts given a SQL snip-it (in need not yet be valid) and cursor location |
| [**PutIntellisenseError**](SqlDesignApi.md#putintellisenseerror) | **PUT** /api/Sql/intellisenseError | [EXPERIMENTAL] PutIntellisenseError: Generate a set of error ranges, if any, in the given SQL (expressed as Lines) |
| [**PutQueryDesignToSql**](SqlDesignApi.md#putquerydesigntosql) | **PUT** /api/Sql/fromdesign | [EXPERIMENTAL] PutQueryDesignToSql: Generates SQL from a structured query design |
| [**PutQueryToFormat**](SqlDesignApi.md#putquerytoformat) | **PUT** /api/Sql/pretty | PutQueryToFormat: Formats SQL into a more readable form, a.k.a. Pretty-Print the SQL. |
| [**PutSqlToFileReadDesign**](SqlDesignApi.md#putsqltofilereaddesign) | **PUT** /api/Sql/tofilereaddesign | [EXPERIMENTAL] PutSqlToFileReadDesign: Generates a SQL-file-read-design object from SQL string, if possible. |
| [**PutSqlToQueryDesign**](SqlDesignApi.md#putsqltoquerydesign) | **PUT** /api/Sql/todesign | [EXPERIMENTAL] PutSqlToQueryDesign: Generates a SQL-design object from SQL string, if possible. |
| [**PutSqlToViewDesign**](SqlDesignApi.md#putsqltoviewdesign) | **PUT** /api/Sql/toviewdesign | [EXPERIMENTAL] PutSqlToViewDesign: Generates a structured view creation design from existing view creation SQL. |
| [**PutSqlToWriterDesign**](SqlDesignApi.md#putsqltowriterdesign) | **PUT** /api/Sql/towriterdesign | [EXPERIMENTAL] PutSqlToWriterDesign: Generates a SQL-writer-design object from SQL string, if possible. |
| [**PutViewDesignToSql**](SqlDesignApi.md#putviewdesigntosql) | **PUT** /api/Sql/fromviewdesign | [EXPERIMENTAL] PutViewDesignToSql: Generates view creation sql from a structured view creation design |
| [**PutWriterDesignToSql**](SqlDesignApi.md#putwriterdesigntosql) | **PUT** /api/Sql/fromwriterdesign | [EXPERIMENTAL] PutWriterDesignToSql: Generates writer SQL from a valid writer-design structure |

<a id="putfilereaddesigntosql"></a>
# **PutFileReadDesignToSql**
> FileReaderBuilderResponse PutFileReadDesignToSql (FileReaderBuilderDef fileReaderBuilderDef, bool? executeQuery = null)

[EXPERIMENTAL] PutFileReadDesignToSql: Generates file read SQL from a structured query design

SQL Designer specification to generate SQL from

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class PutFileReadDesignToSqlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlDesignApi(config);
            var fileReaderBuilderDef = new FileReaderBuilderDef(); // FileReaderBuilderDef | Structured file read design object to generate SQL from
            var executeQuery = true;  // bool? | Should the generated query be executed to build preview data or determine errors.> (optional)  (default to true)

            try
            {
                // [EXPERIMENTAL] PutFileReadDesignToSql: Generates file read SQL from a structured query design
                FileReaderBuilderResponse result = apiInstance.PutFileReadDesignToSql(fileReaderBuilderDef, executeQuery);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlDesignApi.PutFileReadDesignToSql: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutFileReadDesignToSqlWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] PutFileReadDesignToSql: Generates file read SQL from a structured query design
    ApiResponse<FileReaderBuilderResponse> response = apiInstance.PutFileReadDesignToSqlWithHttpInfo(fileReaderBuilderDef, executeQuery);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SqlDesignApi.PutFileReadDesignToSqlWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileReaderBuilderDef** | [**FileReaderBuilderDef**](FileReaderBuilderDef.md) | Structured file read design object to generate SQL from |  |
| **executeQuery** | **bool?** | Should the generated query be executed to build preview data or determine errors.&gt; | [optional] [default to true] |

### Return type

[**FileReaderBuilderResponse**](FileReaderBuilderResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="putintellisense"></a>
# **PutIntellisense**
> IntellisenseResponse PutIntellisense (IntellisenseRequest intellisenseRequest)

[EXPERIMENTAL] PutIntellisense: Generate a set of possible intellisense prompts given a SQL snip-it (in need not yet be valid) and cursor location

SQL and a row/colum position within it from which to determine intellisense options for the user to potentially choose from.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class PutIntellisenseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlDesignApi(config);
            var intellisenseRequest = new IntellisenseRequest(); // IntellisenseRequest | 

            try
            {
                // [EXPERIMENTAL] PutIntellisense: Generate a set of possible intellisense prompts given a SQL snip-it (in need not yet be valid) and cursor location
                IntellisenseResponse result = apiInstance.PutIntellisense(intellisenseRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlDesignApi.PutIntellisense: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutIntellisenseWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] PutIntellisense: Generate a set of possible intellisense prompts given a SQL snip-it (in need not yet be valid) and cursor location
    ApiResponse<IntellisenseResponse> response = apiInstance.PutIntellisenseWithHttpInfo(intellisenseRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SqlDesignApi.PutIntellisenseWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **intellisenseRequest** | [**IntellisenseRequest**](IntellisenseRequest.md) |  |  |

### Return type

[**IntellisenseResponse**](IntellisenseResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="putintellisenseerror"></a>
# **PutIntellisenseError**
> ErrorHighlightResponse PutIntellisenseError (ErrorHighlightRequest errorHighlightRequest)

[EXPERIMENTAL] PutIntellisenseError: Generate a set of error ranges, if any, in the given SQL (expressed as Lines)

SQL (by line) to syntax check and return error ranges from within, if any.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class PutIntellisenseErrorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlDesignApi(config);
            var errorHighlightRequest = new ErrorHighlightRequest(); // ErrorHighlightRequest | 

            try
            {
                // [EXPERIMENTAL] PutIntellisenseError: Generate a set of error ranges, if any, in the given SQL (expressed as Lines)
                ErrorHighlightResponse result = apiInstance.PutIntellisenseError(errorHighlightRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlDesignApi.PutIntellisenseError: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutIntellisenseErrorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] PutIntellisenseError: Generate a set of error ranges, if any, in the given SQL (expressed as Lines)
    ApiResponse<ErrorHighlightResponse> response = apiInstance.PutIntellisenseErrorWithHttpInfo(errorHighlightRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SqlDesignApi.PutIntellisenseErrorWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **errorHighlightRequest** | [**ErrorHighlightRequest**](ErrorHighlightRequest.md) |  |  |

### Return type

[**ErrorHighlightResponse**](ErrorHighlightResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="putquerydesigntosql"></a>
# **PutQueryDesignToSql**
> string PutQueryDesignToSql (QueryDesign queryDesign)

[EXPERIMENTAL] PutQueryDesignToSql: Generates SQL from a structured query design

SQL Designer specification to generate SQL from

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class PutQueryDesignToSqlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlDesignApi(config);
            var queryDesign = new QueryDesign(); // QueryDesign | Structured Query design object to generate SQL from

            try
            {
                // [EXPERIMENTAL] PutQueryDesignToSql: Generates SQL from a structured query design
                string result = apiInstance.PutQueryDesignToSql(queryDesign);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlDesignApi.PutQueryDesignToSql: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutQueryDesignToSqlWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] PutQueryDesignToSql: Generates SQL from a structured query design
    ApiResponse<string> response = apiInstance.PutQueryDesignToSqlWithHttpInfo(queryDesign);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SqlDesignApi.PutQueryDesignToSqlWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **queryDesign** | [**QueryDesign**](QueryDesign.md) | Structured Query design object to generate SQL from |  |

### Return type

**string**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="putquerytoformat"></a>
# **PutQueryToFormat**
> string PutQueryToFormat (string body, bool? trailingCommas = null, bool? uppercaseKeywords = null, bool? breakJoinOnSections = null, bool? spaceAfterExpandedComma = null, bool? keywordStandardization = null, bool? expandCommaLists = null, bool? expandInLists = null, bool? expandBooleanExpressions = null, bool? expandBetweenConditions = null, bool? expandCaseStatements = null, int? maxLineWidth = null, bool? spaceBeforeTrailingSingleLineComments = null, bool? multilineCommentExtraLineBreak = null)

PutQueryToFormat: Formats SQL into a more readable form, a.k.a. Pretty-Print the SQL.

 This formats SQL (given a set of options as to how to do so). It takes some SQL (or a fragment thereof, it need not fully parse as yet and certainly need not execute correctly) and returns the reformatted version. e.g. ```sql select x,y,z from a inner join b on a.x=b.x where x>y or y!=z ``` becomes ```sql select x, y, z from a inner join b    on a.x = b.x where x > y    or y != z ``` 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class PutQueryToFormatExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlDesignApi(config);
            var body = select * from sys.field;  // string | LuminesceSql to Pretty-Print. Even if it doesn't parse an attempt will be made to format it
            var trailingCommas = true;  // bool? | Should commas be after an expression (as opposed to before) (optional)  (default to true)
            var uppercaseKeywords = false;  // bool? | Should key words be capitalized (optional)  (default to false)
            var breakJoinOnSections = true;  // bool? | Should clauses on joins be given line breaks? (optional)  (default to true)
            var spaceAfterExpandedComma = true;  // bool? | Should comma-lists have spaces after the commas? (optional)  (default to true)
            var keywordStandardization = true;  // bool? | Should the \"nicest\" key words be used? (e.g. JOIN -> INNER JOIN) (optional)  (default to true)
            var expandCommaLists = false;  // bool? | Should comma-lists (e.g. select a,b,c) have line breaks added? (optional)  (default to false)
            var expandInLists = false;  // bool? | Should IN-lists have line breaks added? (optional)  (default to false)
            var expandBooleanExpressions = true;  // bool? | Should boolean expressions have line breaks added? (optional)  (default to true)
            var expandBetweenConditions = true;  // bool? | Should between conditions have line breaks added? (optional)  (default to true)
            var expandCaseStatements = true;  // bool? | Should case-statements have line breaks added? (optional)  (default to true)
            var maxLineWidth = 120;  // int? | Maximum number of characters to allow on one line (if possible) (optional)  (default to 120)
            var spaceBeforeTrailingSingleLineComments = true;  // bool? | Should the be a space before trailing single line comments? (optional)  (default to true)
            var multilineCommentExtraLineBreak = false;  // bool? | Should an additional line break be added after multi-line comments? (optional)  (default to false)

            try
            {
                // PutQueryToFormat: Formats SQL into a more readable form, a.k.a. Pretty-Print the SQL.
                string result = apiInstance.PutQueryToFormat(body, trailingCommas, uppercaseKeywords, breakJoinOnSections, spaceAfterExpandedComma, keywordStandardization, expandCommaLists, expandInLists, expandBooleanExpressions, expandBetweenConditions, expandCaseStatements, maxLineWidth, spaceBeforeTrailingSingleLineComments, multilineCommentExtraLineBreak);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlDesignApi.PutQueryToFormat: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutQueryToFormatWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PutQueryToFormat: Formats SQL into a more readable form, a.k.a. Pretty-Print the SQL.
    ApiResponse<string> response = apiInstance.PutQueryToFormatWithHttpInfo(body, trailingCommas, uppercaseKeywords, breakJoinOnSections, spaceAfterExpandedComma, keywordStandardization, expandCommaLists, expandInLists, expandBooleanExpressions, expandBetweenConditions, expandCaseStatements, maxLineWidth, spaceBeforeTrailingSingleLineComments, multilineCommentExtraLineBreak);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SqlDesignApi.PutQueryToFormatWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **string** | LuminesceSql to Pretty-Print. Even if it doesn&#39;t parse an attempt will be made to format it |  |
| **trailingCommas** | **bool?** | Should commas be after an expression (as opposed to before) | [optional] [default to true] |
| **uppercaseKeywords** | **bool?** | Should key words be capitalized | [optional] [default to false] |
| **breakJoinOnSections** | **bool?** | Should clauses on joins be given line breaks? | [optional] [default to true] |
| **spaceAfterExpandedComma** | **bool?** | Should comma-lists have spaces after the commas? | [optional] [default to true] |
| **keywordStandardization** | **bool?** | Should the \&quot;nicest\&quot; key words be used? (e.g. JOIN -&gt; INNER JOIN) | [optional] [default to true] |
| **expandCommaLists** | **bool?** | Should comma-lists (e.g. select a,b,c) have line breaks added? | [optional] [default to false] |
| **expandInLists** | **bool?** | Should IN-lists have line breaks added? | [optional] [default to false] |
| **expandBooleanExpressions** | **bool?** | Should boolean expressions have line breaks added? | [optional] [default to true] |
| **expandBetweenConditions** | **bool?** | Should between conditions have line breaks added? | [optional] [default to true] |
| **expandCaseStatements** | **bool?** | Should case-statements have line breaks added? | [optional] [default to true] |
| **maxLineWidth** | **int?** | Maximum number of characters to allow on one line (if possible) | [optional] [default to 120] |
| **spaceBeforeTrailingSingleLineComments** | **bool?** | Should the be a space before trailing single line comments? | [optional] [default to true] |
| **multilineCommentExtraLineBreak** | **bool?** | Should an additional line break be added after multi-line comments? | [optional] [default to false] |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="putsqltofilereaddesign"></a>
# **PutSqlToFileReadDesign**
> FileReaderBuilderDef PutSqlToFileReadDesign (bool? determineAvailableSources = null, string? body = null)

[EXPERIMENTAL] PutSqlToFileReadDesign: Generates a SQL-file-read-design object from SQL string, if possible.

SQL to attempt to create a Design object from

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class PutSqlToFileReadDesignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlDesignApi(config);
            var determineAvailableSources = true;  // bool? | Should the available sources be determined from `Sys.Registration` (optional)  (default to true)
            var body = @x = 
use Drive.Csv
  --file=/some/folder/somefile.csv
enduse;

select * from @x;;  // string? | SQL query to generate the file read design object from (optional) 

            try
            {
                // [EXPERIMENTAL] PutSqlToFileReadDesign: Generates a SQL-file-read-design object from SQL string, if possible.
                FileReaderBuilderDef result = apiInstance.PutSqlToFileReadDesign(determineAvailableSources, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlDesignApi.PutSqlToFileReadDesign: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutSqlToFileReadDesignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] PutSqlToFileReadDesign: Generates a SQL-file-read-design object from SQL string, if possible.
    ApiResponse<FileReaderBuilderDef> response = apiInstance.PutSqlToFileReadDesignWithHttpInfo(determineAvailableSources, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SqlDesignApi.PutSqlToFileReadDesignWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **determineAvailableSources** | **bool?** | Should the available sources be determined from &#x60;Sys.Registration&#x60; | [optional] [default to true] |
| **body** | **string?** | SQL query to generate the file read design object from | [optional]  |

### Return type

[**FileReaderBuilderDef**](FileReaderBuilderDef.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="putsqltoquerydesign"></a>
# **PutSqlToQueryDesign**
> QueryDesign PutSqlToQueryDesign (string body, bool? validateWithMetadata = null)

[EXPERIMENTAL] PutSqlToQueryDesign: Generates a SQL-design object from SQL string, if possible.

SQL to attempt to create a Design object from

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class PutSqlToQueryDesignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlDesignApi(config);
            var body = SELECT
    [TableName],
    Count(distinct [FieldName]) as [NumberOfFields]
FROM
    [Sys.Field]
WHERE
    ([TableName] = 'Sys.Registration')
GROUP BY
    [TableName]
ORDER BY
    [DataType]
LIMIT 42;  // string | SQL query to generate the design object from
            var validateWithMetadata = true;  // bool? | Should the table be validated against the users' view of Sys.Field to fill in DataTypes, etc.? (optional)  (default to true)

            try
            {
                // [EXPERIMENTAL] PutSqlToQueryDesign: Generates a SQL-design object from SQL string, if possible.
                QueryDesign result = apiInstance.PutSqlToQueryDesign(body, validateWithMetadata);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlDesignApi.PutSqlToQueryDesign: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutSqlToQueryDesignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] PutSqlToQueryDesign: Generates a SQL-design object from SQL string, if possible.
    ApiResponse<QueryDesign> response = apiInstance.PutSqlToQueryDesignWithHttpInfo(body, validateWithMetadata);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SqlDesignApi.PutSqlToQueryDesignWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **string** | SQL query to generate the design object from |  |
| **validateWithMetadata** | **bool?** | Should the table be validated against the users&#39; view of Sys.Field to fill in DataTypes, etc.? | [optional] [default to true] |

### Return type

[**QueryDesign**](QueryDesign.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="putsqltoviewdesign"></a>
# **PutSqlToViewDesign**
> ConvertToViewData PutSqlToViewDesign (string body)

[EXPERIMENTAL] PutSqlToViewDesign: Generates a structured view creation design from existing view creation SQL.

SQL which creates a view into a structured ConvertToViewData object

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class PutSqlToViewDesignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlDesignApi(config);
            var body = @x = 
use Sys.Admin.SetupView
  --provider=YourView
----
select * from Lusid.Instrument
enduse;

select * from @x;;  // string | SQL Query to generate the ConvertToViewData object from

            try
            {
                // [EXPERIMENTAL] PutSqlToViewDesign: Generates a structured view creation design from existing view creation SQL.
                ConvertToViewData result = apiInstance.PutSqlToViewDesign(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlDesignApi.PutSqlToViewDesign: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutSqlToViewDesignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] PutSqlToViewDesign: Generates a structured view creation design from existing view creation SQL.
    ApiResponse<ConvertToViewData> response = apiInstance.PutSqlToViewDesignWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SqlDesignApi.PutSqlToViewDesignWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **string** | SQL Query to generate the ConvertToViewData object from |  |

### Return type

[**ConvertToViewData**](ConvertToViewData.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="putsqltowriterdesign"></a>
# **PutSqlToWriterDesign**
> WriterDesign PutSqlToWriterDesign (string body, bool? mergeAdditionalMappingFields = null)

[EXPERIMENTAL] PutSqlToWriterDesign: Generates a SQL-writer-design object from SQL string, if possible.

SQL to attempt to create a Writer Design object from

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class PutSqlToWriterDesignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlDesignApi(config);
            var body = Select abc from xyz;  // string | SQL query to generate the writer design object from
            var mergeAdditionalMappingFields = false;  // bool? | Should `Sys.Field` be used to find additional potential fields to map from? (not always possible) (optional)  (default to false)

            try
            {
                // [EXPERIMENTAL] PutSqlToWriterDesign: Generates a SQL-writer-design object from SQL string, if possible.
                WriterDesign result = apiInstance.PutSqlToWriterDesign(body, mergeAdditionalMappingFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlDesignApi.PutSqlToWriterDesign: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutSqlToWriterDesignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] PutSqlToWriterDesign: Generates a SQL-writer-design object from SQL string, if possible.
    ApiResponse<WriterDesign> response = apiInstance.PutSqlToWriterDesignWithHttpInfo(body, mergeAdditionalMappingFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SqlDesignApi.PutSqlToWriterDesignWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **string** | SQL query to generate the writer design object from |  |
| **mergeAdditionalMappingFields** | **bool?** | Should &#x60;Sys.Field&#x60; be used to find additional potential fields to map from? (not always possible) | [optional] [default to false] |

### Return type

[**WriterDesign**](WriterDesign.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="putviewdesigntosql"></a>
# **PutViewDesignToSql**
> string PutViewDesignToSql (ConvertToViewData convertToViewData)

[EXPERIMENTAL] PutViewDesignToSql: Generates view creation sql from a structured view creation design

Converts a ConvertToView specification into SQL that creates a view

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class PutViewDesignToSqlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlDesignApi(config);
            var convertToViewData = new ConvertToViewData(); // ConvertToViewData | Structured Query design object to generate SQL from

            try
            {
                // [EXPERIMENTAL] PutViewDesignToSql: Generates view creation sql from a structured view creation design
                string result = apiInstance.PutViewDesignToSql(convertToViewData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlDesignApi.PutViewDesignToSql: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutViewDesignToSqlWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] PutViewDesignToSql: Generates view creation sql from a structured view creation design
    ApiResponse<string> response = apiInstance.PutViewDesignToSqlWithHttpInfo(convertToViewData);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SqlDesignApi.PutViewDesignToSqlWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **convertToViewData** | [**ConvertToViewData**](ConvertToViewData.md) | Structured Query design object to generate SQL from |  |

### Return type

**string**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="putwriterdesigntosql"></a>
# **PutWriterDesignToSql**
> string PutWriterDesignToSql (WriterDesign writerDesign)

[EXPERIMENTAL] PutWriterDesignToSql: Generates writer SQL from a valid writer-design structure

SQL Writer Design specification to generate Writer SQL from

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class PutWriterDesignToSqlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SqlDesignApi(config);
            var writerDesign = new WriterDesign(); // WriterDesign | Structured Writer Design design object to generate Writer SQL from

            try
            {
                // [EXPERIMENTAL] PutWriterDesignToSql: Generates writer SQL from a valid writer-design structure
                string result = apiInstance.PutWriterDesignToSql(writerDesign);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlDesignApi.PutWriterDesignToSql: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutWriterDesignToSqlWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] PutWriterDesignToSql: Generates writer SQL from a valid writer-design structure
    ApiResponse<string> response = apiInstance.PutWriterDesignToSqlWithHttpInfo(writerDesign);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SqlDesignApi.PutWriterDesignToSqlWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **writerDesign** | [**WriterDesign**](WriterDesign.md) | Structured Writer Design design object to generate Writer SQL from |  |

### Return type

**string**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


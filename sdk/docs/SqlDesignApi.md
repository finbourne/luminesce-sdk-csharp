# Finbourne.Luminesce.Sdk.Api.SqlDesignApi

All URIs are relative to *https://fbn-prd.lusid.com/honeycomb*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetProviderTemplateForExport**](SqlDesignApi.md#getprovidertemplateforexport) | **GET** /api/Sql/providertemplateforexport | GetProviderTemplateForExport: Makes a fields template for file importing via a writer |
| [**PutCaseStatementDesignSqlToDesign**](SqlDesignApi.md#putcasestatementdesignsqltodesign) | **PUT** /api/Sql/tocasestatementdesign | [EXPERIMENTAL] PutCaseStatementDesignSqlToDesign: Convert SQL to a case statement design object |
| [**PutCaseStatementDesignToSql**](SqlDesignApi.md#putcasestatementdesigntosql) | **PUT** /api/Sql/fromcasestatementdesign | [EXPERIMENTAL] PutCaseStatementDesignToSql: Convert a case statement design object to SQL |
| [**PutFileReadDesignToSql**](SqlDesignApi.md#putfilereaddesigntosql) | **PUT** /api/Sql/fromfilereaddesign | [EXPERIMENTAL] PutFileReadDesignToSql: Make file read SQL from a design object |
| [**PutInlinedPropertiesDesignSqlToDesign**](SqlDesignApi.md#putinlinedpropertiesdesignsqltodesign) | **PUT** /api/Sql/toinlinedpropertiesdesign | [EXPERIMENTAL] PutInlinedPropertiesDesignSqlToDesign: Make an inlined properties design from SQL |
| [**PutInlinedPropertiesDesignToSql**](SqlDesignApi.md#putinlinedpropertiesdesigntosql) | **PUT** /api/Sql/frominlinedpropertiesdesign | [EXPERIMENTAL] PutInlinedPropertiesDesignToSql: Make inlined properties SQL from a design object |
| [**PutIntellisense**](SqlDesignApi.md#putintellisense) | **PUT** /api/Sql/intellisense | PutIntellisense: Make intellisense prompts given an SQL snip-it |
| [**PutIntellisenseError**](SqlDesignApi.md#putintellisenseerror) | **PUT** /api/Sql/intellisenseError | PutIntellisenseError: Get error ranges from SQL |
| [**PutQueryDesignToSql**](SqlDesignApi.md#putquerydesigntosql) | **PUT** /api/Sql/fromdesign | [EXPERIMENTAL] PutQueryDesignToSql: Make SQL from a structured query design |
| [**PutQueryToFormat**](SqlDesignApi.md#putquerytoformat) | **PUT** /api/Sql/pretty | PutQueryToFormat: Format SQL into a more readable form |
| [**PutSqlToExtractScalarParameters**](SqlDesignApi.md#putsqltoextractscalarparameters) | **PUT** /api/Sql/extractscalarparameters | [EXPERIMENTAL] PutSqlToExtractScalarParameters: Extract scalar parameter information from SQL |
| [**PutSqlToFileReadDesign**](SqlDesignApi.md#putsqltofilereaddesign) | **PUT** /api/Sql/tofilereaddesign | [EXPERIMENTAL] PutSqlToFileReadDesign: Make a design object from file-read SQL |
| [**PutSqlToQueryDesign**](SqlDesignApi.md#putsqltoquerydesign) | **PUT** /api/Sql/todesign | [EXPERIMENTAL] PutSqlToQueryDesign: Make a SQL-design object from SQL if possible |
| [**PutSqlToViewDesign**](SqlDesignApi.md#putsqltoviewdesign) | **PUT** /api/Sql/toviewdesign | [EXPERIMENTAL] PutSqlToViewDesign: Make a view-design from view creation SQL |
| [**PutSqlToWriterDesign**](SqlDesignApi.md#putsqltowriterdesign) | **PUT** /api/Sql/towriterdesign | [EXPERIMENTAL] PutSqlToWriterDesign: Make a SQL-writer-design object from SQL |
| [**PutViewDesignToSql**](SqlDesignApi.md#putviewdesigntosql) | **PUT** /api/Sql/fromviewdesign | [EXPERIMENTAL] PutViewDesignToSql: Make view creation sql from a view-design |
| [**PutWriterDesignToSql**](SqlDesignApi.md#putwriterdesigntosql) | **PUT** /api/Sql/fromwriterdesign | [EXPERIMENTAL] PutWriterDesignToSql: Make writer SQL from a writer-design object |

<a id="getprovidertemplateforexport"></a>
# **GetProviderTemplateForExport**
> System.IO.Stream GetProviderTemplateForExport (string provider, string contentType)

GetProviderTemplateForExport: Makes a fields template for file importing via a writer

Generates a template file for all the writable fields for a given provider returned in CSV or Excel (xlsx) format (as a file to be downloaded)

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SqlDesignApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SqlDesignApi>();
            var provider = "provider_example";  // string | Name of the provider for which this template is for
            var contentType = "contentType_example";  // string | File content type for the Template. csv or excel

            try
            {
                // uncomment the below to set overrides at the request level
                // System.IO.Stream result = apiInstance.GetProviderTemplateForExport(provider, contentType, opts: opts);

                // GetProviderTemplateForExport: Makes a fields template for file importing via a writer
                System.IO.Stream result = apiInstance.GetProviderTemplateForExport(provider, contentType);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SqlDesignApi.GetProviderTemplateForExport: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProviderTemplateForExportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetProviderTemplateForExport: Makes a fields template for file importing via a writer
    ApiResponse<System.IO.Stream> response = apiInstance.GetProviderTemplateForExportWithHttpInfo(provider, contentType);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SqlDesignApi.GetProviderTemplateForExportWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **provider** | **string** | Name of the provider for which this template is for |  |
| **contentType** | **string** | File content type for the Template. csv or excel |  |

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

<a id="putcasestatementdesignsqltodesign"></a>
# **PutCaseStatementDesignSqlToDesign**
> CaseStatementDesign PutCaseStatementDesignSqlToDesign (string? body = null)

[EXPERIMENTAL] PutCaseStatementDesignSqlToDesign: Convert SQL to a case statement design object

Converts a SQL query to a CaseStatementDesign object  > This method is generally only intended for IDE generation purposes.  > It is largely internal to the Finbourne web user interfaces and subject to change without notice. 

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SqlDesignApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SqlDesignApi>();
            var body = CASE 
 WHEN [currency] = 'US' THEN 'USD' 
 WHEN [currency] = 'Gb' THEN 'GBP' 
 ELSE [currency] 
 END;  // string? | SQL to attempt to create an case statement Design object from (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // CaseStatementDesign result = apiInstance.PutCaseStatementDesignSqlToDesign(body, opts: opts);

                // [EXPERIMENTAL] PutCaseStatementDesignSqlToDesign: Convert SQL to a case statement design object
                CaseStatementDesign result = apiInstance.PutCaseStatementDesignSqlToDesign(body);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SqlDesignApi.PutCaseStatementDesignSqlToDesign: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutCaseStatementDesignSqlToDesignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] PutCaseStatementDesignSqlToDesign: Convert SQL to a case statement design object
    ApiResponse<CaseStatementDesign> response = apiInstance.PutCaseStatementDesignSqlToDesignWithHttpInfo(body);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SqlDesignApi.PutCaseStatementDesignSqlToDesignWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **string?** | SQL to attempt to create an case statement Design object from | [optional]  |

### Return type

[**CaseStatementDesign**](CaseStatementDesign.md)

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="putcasestatementdesigntosql"></a>
# **PutCaseStatementDesignToSql**
> string PutCaseStatementDesignToSql (CaseStatementDesign caseStatementDesign)

[EXPERIMENTAL] PutCaseStatementDesignToSql: Convert a case statement design object to SQL

Generates a SQL case statement query from a structured CaseStatementDesign object  > This method is generally only intended for IDE generation purposes.  > It is largely internal to the Finbourne web user interfaces and subject to change without notice. 

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SqlDesignApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SqlDesignApi>();
            var caseStatementDesign = new CaseStatementDesign(); // CaseStatementDesign | CaseStatementDesign object to try and create a SQL query from

            try
            {
                // uncomment the below to set overrides at the request level
                // string result = apiInstance.PutCaseStatementDesignToSql(caseStatementDesign, opts: opts);

                // [EXPERIMENTAL] PutCaseStatementDesignToSql: Convert a case statement design object to SQL
                string result = apiInstance.PutCaseStatementDesignToSql(caseStatementDesign);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SqlDesignApi.PutCaseStatementDesignToSql: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutCaseStatementDesignToSqlWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] PutCaseStatementDesignToSql: Convert a case statement design object to SQL
    ApiResponse<string> response = apiInstance.PutCaseStatementDesignToSqlWithHttpInfo(caseStatementDesign);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SqlDesignApi.PutCaseStatementDesignToSqlWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **caseStatementDesign** | [**CaseStatementDesign**](CaseStatementDesign.md) | CaseStatementDesign object to try and create a SQL query from |  |

### Return type

**string**

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="putfilereaddesigntosql"></a>
# **PutFileReadDesignToSql**
> FileReaderBuilderResponse PutFileReadDesignToSql (FileReaderBuilderDef fileReaderBuilderDef, bool? executeQuery = null)

[EXPERIMENTAL] PutFileReadDesignToSql: Make file read SQL from a design object

Generates SQL from a FileReaderBuilderDef object  > This method is generally only intended for IDE generation purposes.  > It is largely internal to the Finbourne web user interfaces and subject to change without notice. 

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SqlDesignApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SqlDesignApi>();
            var fileReaderBuilderDef = new FileReaderBuilderDef(); // FileReaderBuilderDef | Structured file read design object to generate SQL from
            var executeQuery = true;  // bool? | Should the generated query be executed to build preview data or determine errors.> (optional)  (default to true)

            try
            {
                // uncomment the below to set overrides at the request level
                // FileReaderBuilderResponse result = apiInstance.PutFileReadDesignToSql(fileReaderBuilderDef, executeQuery, opts: opts);

                // [EXPERIMENTAL] PutFileReadDesignToSql: Make file read SQL from a design object
                FileReaderBuilderResponse result = apiInstance.PutFileReadDesignToSql(fileReaderBuilderDef, executeQuery);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SqlDesignApi.PutFileReadDesignToSql: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    // [EXPERIMENTAL] PutFileReadDesignToSql: Make file read SQL from a design object
    ApiResponse<FileReaderBuilderResponse> response = apiInstance.PutFileReadDesignToSqlWithHttpInfo(fileReaderBuilderDef, executeQuery);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SqlDesignApi.PutFileReadDesignToSqlWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileReaderBuilderDef** | [**FileReaderBuilderDef**](FileReaderBuilderDef.md) | Structured file read design object to generate SQL from |  |
| **executeQuery** | **bool?** | Should the generated query be executed to build preview data or determine errors.&gt; | [optional] [default to true] |

### Return type

[**FileReaderBuilderResponse**](FileReaderBuilderResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="putinlinedpropertiesdesignsqltodesign"></a>
# **PutInlinedPropertiesDesignSqlToDesign**
> InlinedPropertyDesign PutInlinedPropertiesDesignSqlToDesign (string? body = null)

[EXPERIMENTAL] PutInlinedPropertiesDesignSqlToDesign: Make an inlined properties design from SQL

Generates a SQL-inlined-properties-design object from SQL string, if possible.  > This method is generally only intended for IDE generation purposes.  > It is largely internal to the Finbourne web user interfaces and subject to change without notice. 

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SqlDesignApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SqlDesignApi>();
            var body = @keysToCatalog = values('Portfolio/3897-78d4-e91c-26/location', 'PortfolioLocation', false, '');
 @config = select column1 as [Key], column2 as Name, column3 as IsMain, column4 as Description from @keysToCatalog; 
 select * from Sys.Admin.Lusid.Provider.Configure where Provider = 'Lusid.Portfolio' and Configuration = @config;;  // string? | SQL query to attempt to generate the inlined properties design object from (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // InlinedPropertyDesign result = apiInstance.PutInlinedPropertiesDesignSqlToDesign(body, opts: opts);

                // [EXPERIMENTAL] PutInlinedPropertiesDesignSqlToDesign: Make an inlined properties design from SQL
                InlinedPropertyDesign result = apiInstance.PutInlinedPropertiesDesignSqlToDesign(body);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SqlDesignApi.PutInlinedPropertiesDesignSqlToDesign: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutInlinedPropertiesDesignSqlToDesignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] PutInlinedPropertiesDesignSqlToDesign: Make an inlined properties design from SQL
    ApiResponse<InlinedPropertyDesign> response = apiInstance.PutInlinedPropertiesDesignSqlToDesignWithHttpInfo(body);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SqlDesignApi.PutInlinedPropertiesDesignSqlToDesignWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **string?** | SQL query to attempt to generate the inlined properties design object from | [optional]  |

### Return type

[**InlinedPropertyDesign**](InlinedPropertyDesign.md)

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="putinlinedpropertiesdesigntosql"></a>
# **PutInlinedPropertiesDesignToSql**
> string PutInlinedPropertiesDesignToSql (InlinedPropertyDesign inlinedPropertyDesign)

[EXPERIMENTAL] PutInlinedPropertiesDesignToSql: Make inlined properties SQL from a design object

Generates inlined properties SQL from a structured design  > This method is generally only intended for IDE generation purposes.  > It is largely internal to the Finbourne web user interfaces and subject to change without notice. 

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SqlDesignApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SqlDesignApi>();
            var inlinedPropertyDesign = new InlinedPropertyDesign(); // InlinedPropertyDesign | Inlined properties Designer specification to generate SQL from

            try
            {
                // uncomment the below to set overrides at the request level
                // string result = apiInstance.PutInlinedPropertiesDesignToSql(inlinedPropertyDesign, opts: opts);

                // [EXPERIMENTAL] PutInlinedPropertiesDesignToSql: Make inlined properties SQL from a design object
                string result = apiInstance.PutInlinedPropertiesDesignToSql(inlinedPropertyDesign);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SqlDesignApi.PutInlinedPropertiesDesignToSql: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutInlinedPropertiesDesignToSqlWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] PutInlinedPropertiesDesignToSql: Make inlined properties SQL from a design object
    ApiResponse<string> response = apiInstance.PutInlinedPropertiesDesignToSqlWithHttpInfo(inlinedPropertyDesign);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SqlDesignApi.PutInlinedPropertiesDesignToSqlWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inlinedPropertyDesign** | [**InlinedPropertyDesign**](InlinedPropertyDesign.md) | Inlined properties Designer specification to generate SQL from |  |

### Return type

**string**

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="putintellisense"></a>
# **PutIntellisense**
> IntellisenseResponse PutIntellisense (IntellisenseRequest intellisenseRequest)

PutIntellisense: Make intellisense prompts given an SQL snip-it

Generate a set of possible intellisense prompts given a SQL snip-it (in need not yet be valid SQL) and cursor location  > This method is generally only intended for IDE generation purposes.  > It is largely internal to the Finbourne web user interfaces and subject to change without notice. 

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SqlDesignApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SqlDesignApi>();
            var intellisenseRequest = new IntellisenseRequest(); // IntellisenseRequest | SQL and a row/colum position within it from which to determine intellisense options for the user to potentially choose from.

            try
            {
                // uncomment the below to set overrides at the request level
                // IntellisenseResponse result = apiInstance.PutIntellisense(intellisenseRequest, opts: opts);

                // PutIntellisense: Make intellisense prompts given an SQL snip-it
                IntellisenseResponse result = apiInstance.PutIntellisense(intellisenseRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SqlDesignApi.PutIntellisense: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    // PutIntellisense: Make intellisense prompts given an SQL snip-it
    ApiResponse<IntellisenseResponse> response = apiInstance.PutIntellisenseWithHttpInfo(intellisenseRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SqlDesignApi.PutIntellisenseWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **intellisenseRequest** | [**IntellisenseRequest**](IntellisenseRequest.md) | SQL and a row/colum position within it from which to determine intellisense options for the user to potentially choose from. |  |

### Return type

[**IntellisenseResponse**](IntellisenseResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="putintellisenseerror"></a>
# **PutIntellisenseError**
> ErrorHighlightResponse PutIntellisenseError (ErrorHighlightRequest errorHighlightRequest)

PutIntellisenseError: Get error ranges from SQL

Generate a set of error ranges, if any, in the given SQL (expressed as Lines)  > This method is generally only intended for IDE generation purposes.  > It is largely internal to the Finbourne web user interfaces and subject to change without notice. 

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SqlDesignApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SqlDesignApi>();
            var errorHighlightRequest = new ErrorHighlightRequest(); // ErrorHighlightRequest | SQL (by line) to syntax check and return error ranges from within, if any.

            try
            {
                // uncomment the below to set overrides at the request level
                // ErrorHighlightResponse result = apiInstance.PutIntellisenseError(errorHighlightRequest, opts: opts);

                // PutIntellisenseError: Get error ranges from SQL
                ErrorHighlightResponse result = apiInstance.PutIntellisenseError(errorHighlightRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SqlDesignApi.PutIntellisenseError: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    // PutIntellisenseError: Get error ranges from SQL
    ApiResponse<ErrorHighlightResponse> response = apiInstance.PutIntellisenseErrorWithHttpInfo(errorHighlightRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SqlDesignApi.PutIntellisenseErrorWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **errorHighlightRequest** | [**ErrorHighlightRequest**](ErrorHighlightRequest.md) | SQL (by line) to syntax check and return error ranges from within, if any. |  |

### Return type

[**ErrorHighlightResponse**](ErrorHighlightResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="putquerydesigntosql"></a>
# **PutQueryDesignToSql**
> string PutQueryDesignToSql (QueryDesign queryDesign)

[EXPERIMENTAL] PutQueryDesignToSql: Make SQL from a structured query design

Generates SQL from a QueryDesign object  > This method is generally only intended for IDE generation purposes.  > It is largely internal to the Finbourne web user interfaces and subject to change without notice. 

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SqlDesignApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SqlDesignApi>();
            var queryDesign = new QueryDesign(); // QueryDesign | Structured Query design object to generate SQL from

            try
            {
                // uncomment the below to set overrides at the request level
                // string result = apiInstance.PutQueryDesignToSql(queryDesign, opts: opts);

                // [EXPERIMENTAL] PutQueryDesignToSql: Make SQL from a structured query design
                string result = apiInstance.PutQueryDesignToSql(queryDesign);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SqlDesignApi.PutQueryDesignToSql: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    // [EXPERIMENTAL] PutQueryDesignToSql: Make SQL from a structured query design
    ApiResponse<string> response = apiInstance.PutQueryDesignToSqlWithHttpInfo(queryDesign);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SqlDesignApi.PutQueryDesignToSqlWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **queryDesign** | [**QueryDesign**](QueryDesign.md) | Structured Query design object to generate SQL from |  |

### Return type

**string**

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="putquerytoformat"></a>
# **PutQueryToFormat**
> string PutQueryToFormat (string body, bool? trailingCommas = null, bool? uppercaseKeywords = null, bool? breakJoinOnSections = null, bool? spaceAfterExpandedComma = null, bool? keywordStandardization = null, bool? expandCommaLists = null, bool? expandInLists = null, bool? expandBooleanExpressions = null, bool? expandBetweenConditions = null, bool? expandCaseStatements = null, int? maxLineWidth = null, bool? spaceBeforeTrailingSingleLineComments = null, bool? multilineCommentExtraLineBreak = null)

PutQueryToFormat: Format SQL into a more readable form

 This formats SQL (given a set of options as to how to do so), a.k.a. Pretty-Print the SQL. It takes some SQL (or a fragment thereof, it need not fully parse as yet and certainly need not execute correctly) and returns the reformatted version. e.g. ```sql select x,y,z from a inner join b on a.x=b.x where x>y or y!=z ``` becomes ```sql select x, y, z from a inner join b    on a.x = b.x where x > y    or y != z ``` 

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SqlDesignApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SqlDesignApi>();
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
                // uncomment the below to set overrides at the request level
                // string result = apiInstance.PutQueryToFormat(body, trailingCommas, uppercaseKeywords, breakJoinOnSections, spaceAfterExpandedComma, keywordStandardization, expandCommaLists, expandInLists, expandBooleanExpressions, expandBetweenConditions, expandCaseStatements, maxLineWidth, spaceBeforeTrailingSingleLineComments, multilineCommentExtraLineBreak, opts: opts);

                // PutQueryToFormat: Format SQL into a more readable form
                string result = apiInstance.PutQueryToFormat(body, trailingCommas, uppercaseKeywords, breakJoinOnSections, spaceAfterExpandedComma, keywordStandardization, expandCommaLists, expandInLists, expandBooleanExpressions, expandBetweenConditions, expandCaseStatements, maxLineWidth, spaceBeforeTrailingSingleLineComments, multilineCommentExtraLineBreak);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SqlDesignApi.PutQueryToFormat: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    // PutQueryToFormat: Format SQL into a more readable form
    ApiResponse<string> response = apiInstance.PutQueryToFormatWithHttpInfo(body, trailingCommas, uppercaseKeywords, breakJoinOnSections, spaceAfterExpandedComma, keywordStandardization, expandCommaLists, expandInLists, expandBooleanExpressions, expandBetweenConditions, expandCaseStatements, maxLineWidth, spaceBeforeTrailingSingleLineComments, multilineCommentExtraLineBreak);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SqlDesignApi.PutQueryToFormatWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
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

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="putsqltoextractscalarparameters"></a>
# **PutSqlToExtractScalarParameters**
> List&lt;ScalarParameter&gt; PutSqlToExtractScalarParameters (string body)

[EXPERIMENTAL] PutSqlToExtractScalarParameters: Extract scalar parameter information from SQL

Extracts information about all the scalar parameters defined in the given SQL statement  > This method is generally only intended for IDE generation purposes.  > It is largely internal to the Finbourne web user interfaces and subject to change without notice. 

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SqlDesignApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SqlDesignApi>();
            var body = select abc, :p1:'this' as c1 from xxx where abc = :abcP:123 or xyz in (:p2:, 'zzz');  // string | SQL query to generate the design object from

            try
            {
                // uncomment the below to set overrides at the request level
                // List<ScalarParameter> result = apiInstance.PutSqlToExtractScalarParameters(body, opts: opts);

                // [EXPERIMENTAL] PutSqlToExtractScalarParameters: Extract scalar parameter information from SQL
                List<ScalarParameter> result = apiInstance.PutSqlToExtractScalarParameters(body);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SqlDesignApi.PutSqlToExtractScalarParameters: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutSqlToExtractScalarParametersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] PutSqlToExtractScalarParameters: Extract scalar parameter information from SQL
    ApiResponse<List<ScalarParameter>> response = apiInstance.PutSqlToExtractScalarParametersWithHttpInfo(body);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SqlDesignApi.PutSqlToExtractScalarParametersWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **string** | SQL query to generate the design object from |  |

### Return type

[**List&lt;ScalarParameter&gt;**](ScalarParameter.md)

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="putsqltofilereaddesign"></a>
# **PutSqlToFileReadDesign**
> FileReaderBuilderDef PutSqlToFileReadDesign (bool? determineAvailableSources = null, string? body = null)

[EXPERIMENTAL] PutSqlToFileReadDesign: Make a design object from file-read SQL

Generates a SQL-file-read-design object from SQL string, if possible.  > This method is generally only intended for IDE generation purposes.  > It is largely internal to the Finbourne web user interfaces and subject to change without notice. 

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SqlDesignApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SqlDesignApi>();
            var determineAvailableSources = true;  // bool? | Should the available sources be determined from `Sys.Registration` (optional)  (default to true)
            var body = @x = 
use Drive.Csv
  --file=/some/folder/somefile.csv
enduse;

select * from @x;;  // string? | SQL query to generate the file read design object from (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // FileReaderBuilderDef result = apiInstance.PutSqlToFileReadDesign(determineAvailableSources, body, opts: opts);

                // [EXPERIMENTAL] PutSqlToFileReadDesign: Make a design object from file-read SQL
                FileReaderBuilderDef result = apiInstance.PutSqlToFileReadDesign(determineAvailableSources, body);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SqlDesignApi.PutSqlToFileReadDesign: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    // [EXPERIMENTAL] PutSqlToFileReadDesign: Make a design object from file-read SQL
    ApiResponse<FileReaderBuilderDef> response = apiInstance.PutSqlToFileReadDesignWithHttpInfo(determineAvailableSources, body);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SqlDesignApi.PutSqlToFileReadDesignWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **determineAvailableSources** | **bool?** | Should the available sources be determined from &#x60;Sys.Registration&#x60; | [optional] [default to true] |
| **body** | **string?** | SQL query to generate the file read design object from | [optional]  |

### Return type

[**FileReaderBuilderDef**](FileReaderBuilderDef.md)

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="putsqltoquerydesign"></a>
# **PutSqlToQueryDesign**
> QueryDesign PutSqlToQueryDesign (string body, bool? validateWithMetadata = null)

[EXPERIMENTAL] PutSqlToQueryDesign: Make a SQL-design object from SQL if possible

Generates a QueryDesign object from simple SQL if possible  > This method is generally only intended for IDE generation purposes.  > It is largely internal to the Finbourne web user interfaces and subject to change without notice. 

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SqlDesignApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SqlDesignApi>();
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
                // uncomment the below to set overrides at the request level
                // QueryDesign result = apiInstance.PutSqlToQueryDesign(body, validateWithMetadata, opts: opts);

                // [EXPERIMENTAL] PutSqlToQueryDesign: Make a SQL-design object from SQL if possible
                QueryDesign result = apiInstance.PutSqlToQueryDesign(body, validateWithMetadata);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SqlDesignApi.PutSqlToQueryDesign: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    // [EXPERIMENTAL] PutSqlToQueryDesign: Make a SQL-design object from SQL if possible
    ApiResponse<QueryDesign> response = apiInstance.PutSqlToQueryDesignWithHttpInfo(body, validateWithMetadata);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SqlDesignApi.PutSqlToQueryDesignWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **string** | SQL query to generate the design object from |  |
| **validateWithMetadata** | **bool?** | Should the table be validated against the users&#39; view of Sys.Field to fill in DataTypes, etc.? | [optional] [default to true] |

### Return type

[**QueryDesign**](QueryDesign.md)

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="putsqltoviewdesign"></a>
# **PutSqlToViewDesign**
> ConvertToViewData PutSqlToViewDesign (string body)

[EXPERIMENTAL] PutSqlToViewDesign: Make a view-design from view creation SQL

Converts SQL which creates a view into a structured ConvertToViewData object  > This method is generally only intended for IDE generation purposes.  > It is largely internal to the Finbourne web user interfaces and subject to change without notice. 

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SqlDesignApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SqlDesignApi>();
            var body = @x = 
use Sys.Admin.SetupView
  --provider=YourView
----
select * from Lusid.Instrument
enduse;

select * from @x;;  // string | SQL Query to generate the ConvertToViewData object from

            try
            {
                // uncomment the below to set overrides at the request level
                // ConvertToViewData result = apiInstance.PutSqlToViewDesign(body, opts: opts);

                // [EXPERIMENTAL] PutSqlToViewDesign: Make a view-design from view creation SQL
                ConvertToViewData result = apiInstance.PutSqlToViewDesign(body);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SqlDesignApi.PutSqlToViewDesign: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    // [EXPERIMENTAL] PutSqlToViewDesign: Make a view-design from view creation SQL
    ApiResponse<ConvertToViewData> response = apiInstance.PutSqlToViewDesignWithHttpInfo(body);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SqlDesignApi.PutSqlToViewDesignWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **string** | SQL Query to generate the ConvertToViewData object from |  |

### Return type

[**ConvertToViewData**](ConvertToViewData.md)

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="putsqltowriterdesign"></a>
# **PutSqlToWriterDesign**
> WriterDesign PutSqlToWriterDesign (string body, bool? mergeAdditionalMappingFields = null)

[EXPERIMENTAL] PutSqlToWriterDesign: Make a SQL-writer-design object from SQL

Generates a SQL-writer-design object (WriterDesign) from a SQL query, if possible  > This method is generally only intended for IDE generation purposes.  > It is largely internal to the Finbourne web user interfaces and subject to change without notice. 

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SqlDesignApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SqlDesignApi>();
            var body = Select abc from xyz;  // string | SQL query to generate the writer design object from
            var mergeAdditionalMappingFields = false;  // bool? | Should `Sys.Field` be used to find additional potential fields to map from? (not always possible) (optional)  (default to false)

            try
            {
                // uncomment the below to set overrides at the request level
                // WriterDesign result = apiInstance.PutSqlToWriterDesign(body, mergeAdditionalMappingFields, opts: opts);

                // [EXPERIMENTAL] PutSqlToWriterDesign: Make a SQL-writer-design object from SQL
                WriterDesign result = apiInstance.PutSqlToWriterDesign(body, mergeAdditionalMappingFields);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SqlDesignApi.PutSqlToWriterDesign: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    // [EXPERIMENTAL] PutSqlToWriterDesign: Make a SQL-writer-design object from SQL
    ApiResponse<WriterDesign> response = apiInstance.PutSqlToWriterDesignWithHttpInfo(body, mergeAdditionalMappingFields);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SqlDesignApi.PutSqlToWriterDesignWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **string** | SQL query to generate the writer design object from |  |
| **mergeAdditionalMappingFields** | **bool?** | Should &#x60;Sys.Field&#x60; be used to find additional potential fields to map from? (not always possible) | [optional] [default to false] |

### Return type

[**WriterDesign**](WriterDesign.md)

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="putviewdesigntosql"></a>
# **PutViewDesignToSql**
> string PutViewDesignToSql (ConvertToViewData convertToViewData)

[EXPERIMENTAL] PutViewDesignToSql: Make view creation sql from a view-design

Converts a ConvertToView specification into SQL that creates a view  > This method is generally only intended for IDE generation purposes.  > It is largely internal to the Finbourne web user interfaces and subject to change without notice. 

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SqlDesignApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SqlDesignApi>();
            var convertToViewData = new ConvertToViewData(); // ConvertToViewData | Structured Query design object to generate SQL from

            try
            {
                // uncomment the below to set overrides at the request level
                // string result = apiInstance.PutViewDesignToSql(convertToViewData, opts: opts);

                // [EXPERIMENTAL] PutViewDesignToSql: Make view creation sql from a view-design
                string result = apiInstance.PutViewDesignToSql(convertToViewData);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SqlDesignApi.PutViewDesignToSql: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    // [EXPERIMENTAL] PutViewDesignToSql: Make view creation sql from a view-design
    ApiResponse<string> response = apiInstance.PutViewDesignToSqlWithHttpInfo(convertToViewData);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SqlDesignApi.PutViewDesignToSqlWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **convertToViewData** | [**ConvertToViewData**](ConvertToViewData.md) | Structured Query design object to generate SQL from |  |

### Return type

**string**

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="putwriterdesigntosql"></a>
# **PutWriterDesignToSql**
> string PutWriterDesignToSql (WriterDesign writerDesign)

[EXPERIMENTAL] PutWriterDesignToSql: Make writer SQL from a writer-design object

Generates writer SQL from a valid WriterDesign structure  > This method is generally only intended for IDE generation purposes.  > It is largely internal to the Finbourne web user interfaces and subject to change without notice. 

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SqlDesignApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SqlDesignApi>();
            var writerDesign = new WriterDesign(); // WriterDesign | Structured Writer Design design object to generate Writer SQL from

            try
            {
                // uncomment the below to set overrides at the request level
                // string result = apiInstance.PutWriterDesignToSql(writerDesign, opts: opts);

                // [EXPERIMENTAL] PutWriterDesignToSql: Make writer SQL from a writer-design object
                string result = apiInstance.PutWriterDesignToSql(writerDesign);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SqlDesignApi.PutWriterDesignToSql: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    // [EXPERIMENTAL] PutWriterDesignToSql: Make writer SQL from a writer-design object
    ApiResponse<string> response = apiInstance.PutWriterDesignToSqlWithHttpInfo(writerDesign);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SqlDesignApi.PutWriterDesignToSqlWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **writerDesign** | [**WriterDesign**](WriterDesign.md) | Structured Writer Design design object to generate Writer SQL from |  |

### Return type

**string**

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)


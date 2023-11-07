# Finbourne.Luminesce.Sdk.Api.CurrentTableFieldCatalogApi

All URIs are relative to *https://fbn-ci.lusid.com/honeycomb*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetCatalog**](CurrentTableFieldCatalogApi.md#getcatalog) | **GET** /api/Catalog | GetCatalog: Shows Table and Field level information on Providers that are currently running that you have access to (in Json format) |

<a id="getcatalog"></a>
# **GetCatalog**
> string GetCatalog (string? freeTextSearch = null, bool? jsonProper = null)

GetCatalog: Shows Table and Field level information on Providers that are currently running that you have access to (in Json format)

 The following LuminesceSql is executed to return this information:  ```sql @reg = select     Name,     min(Description) as Description,     min(DocumentationLink) as DocumentationLink,     iif(Category = 'View' and Client is not null, true, false) as IsView from     Sys.Registration where     Type in ('DirectProvider', 'DataProvider')     and      ShowAll = false group by     1     ;  @fld = select     TableName,     FieldName,     DataType,     FieldType,     IsPrimaryKey,     IsMain,     Description,     ParamDefaultValue,     TableParamColumns from     Sys.Field     ;  @x = select     coalesce(f.TableName, r.Name) as TableName,     coalesce(f.FieldName, 'N/A') as FieldName,     f.DataType,     f.FieldType,     f.IsPrimaryKey,     f.IsMain,     case          when f.TableName is not null then             f.Description         else             r.Name || ' returns a different set of columns depending on use.'         end as Description,     f.ParamDefaultValue,     f.TableParamColumns,     r.Description as ProviderDescription,     r.DocumentationLink,     r.IsView from     @reg r     left outer join @fld f         on r.Name = f.TableName order by     1, 5 desc, 6 desc, 2     ;     ```  The following error codes are to be anticipated with standard Problem Detail reports: - 401 Unauthorized 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;

namespace Example
{
    public class GetCatalogExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-ci.lusid.com/honeycomb";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CurrentTableFieldCatalogApi(config);
            var freeTextSearch = "freeTextSearch_example";  // string? | Limit the catalog to only things in some way dealing with the passed in text string (optional) 
            var jsonProper = false;  // bool? | Should this be text/json (not json-encoded-as-a-string) (optional)  (default to false)

            try
            {
                // GetCatalog: Shows Table and Field level information on Providers that are currently running that you have access to (in Json format)
                string result = apiInstance.GetCatalog(freeTextSearch, jsonProper);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CurrentTableFieldCatalogApi.GetCatalog: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCatalogWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetCatalog: Shows Table and Field level information on Providers that are currently running that you have access to (in Json format)
    ApiResponse<string> response = apiInstance.GetCatalogWithHttpInfo(freeTextSearch, jsonProper);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CurrentTableFieldCatalogApi.GetCatalogWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **freeTextSearch** | **string?** | Limit the catalog to only things in some way dealing with the passed in text string | [optional]  |
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


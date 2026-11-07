# Finbourne.Luminesce.Sdk.Model.ExportFormatting

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Timezone** | **string** |  | [optional] 
**Locale** | **string** |  | [optional] 
**Tables** | [**List&lt;TableExport&gt;**](TableExport.md) |  | [optional] 

```csharp
using Finbourne.Luminesce.Sdk.Model;
using System;

string timezone = "example timezone";
string locale = "example locale";
List<TableExport> tables = new List<TableExport>();

ExportFormatting exportFormattingInstance = new ExportFormatting(
    timezone: timezone,
    locale: locale,
    tables: tables);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

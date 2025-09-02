# Finbourne.Luminesce.Sdk.Model.OptionsSqLite
Additional options applicable to the given SourceType

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Table** | **string** | Table name to read.  If missing then an error will be raised if there is any number of tables other than one. | [optional] 

```csharp
using Finbourne.Luminesce.Sdk.Model;
using System;

string table = "example table";

OptionsSqLite optionsSqLiteInstance = new OptionsSqLite(
    table: table);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

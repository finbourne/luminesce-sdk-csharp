# Finbourne.Luminesce.Sdk.Model.MultiQueryExportState
What became of the export of a custom multi-query once its queries were done (persisted in its shared state, so known to every pod).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DriveLocationAndFileName** | **string** | Where it was to be saved, its placeholders filled in | [optional] 
**SavedTo** | **string** | The Drive path (and file name, with its extension) it was saved to, once it has been | [optional] 
**Error** | **string** | Why it was not saved, if it was not | [optional] 

```csharp
using Finbourne.Luminesce.Sdk.Model;
using System;

string driveLocationAndFileName = "example driveLocationAndFileName";
string savedTo = "example savedTo";
string error = "example error";

MultiQueryExportState multiQueryExportStateInstance = new MultiQueryExportState(
    driveLocationAndFileName: driveLocationAndFileName,
    savedTo: savedTo,
    error: error);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

# Finbourne.Luminesce.Sdk.Model.ViewItem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the view | [optional] 
**Domain** | **string** | The domain the view applies to | [optional] 
**FilePath** | **string** | The full file path in the HcFs | [optional] 
**FileContent** | **string** | The full file content in the HcFs. This will be needed for Upserting the view to a different domain / for use in fbn-config. | [optional] 
**LastUpdatedExecutionId** | **Guid?** | The last ExecutionId, needed to get the creating Sql out of the logs | [optional] 
**LastUpdatedAt** | **DateTimeOffset?** | The last updated at time, needed to get the creating Sql out of the logs | [optional] 
**LastUpdatedBy** | **string** | The last updated by this user | [optional] 
**CreatedByUserId** | **string** | Originally created by this user | [optional] 
**Notes** | **string** | Any notes around saving or whatnot | [optional] 

```csharp
using Finbourne.Luminesce.Sdk.Model;
using System;

string name = "example name";
string domain = "example domain";
string filePath = "example filePath";
string fileContent = "example fileContent";
Guid? lastUpdatedExecutionId = "example lastUpdatedExecutionId";
string lastUpdatedBy = "example lastUpdatedBy";
string createdByUserId = "example createdByUserId";
string notes = "example notes";

ViewItem viewItemInstance = new ViewItem(
    name: name,
    domain: domain,
    filePath: filePath,
    fileContent: fileContent,
    lastUpdatedExecutionId: lastUpdatedExecutionId,
    lastUpdatedAt: lastUpdatedAt,
    lastUpdatedBy: lastUpdatedBy,
    createdByUserId: createdByUserId,
    notes: notes);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

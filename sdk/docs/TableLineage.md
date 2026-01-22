# Finbourne.Luminesce.Sdk.Model.TableLineage

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ColumnLineage** | [**List&lt;Lineage&gt;**](Lineage.md) |  | [optional] 
**RowLineage** | [**Lineage**](Lineage.md) |  | [optional] 
**FailureReason** | **string** |  | [optional] 

```csharp
using Finbourne.Luminesce.Sdk.Model;
using System;

List<Lineage> columnLineage = new List<Lineage>();
Lineage? rowLineage = new Lineage();

string failureReason = "example failureReason";

TableLineage tableLineageInstance = new TableLineage(
    columnLineage: columnLineage,
    rowLineage: rowLineage,
    failureReason: failureReason);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

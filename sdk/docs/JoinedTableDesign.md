# Finbourne.Luminesce.Sdk.Model.JoinedTableDesign
Treatment of a joined-to-table a QueryDesign

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**JoinedTableName** | **string** | Name of the table on the right side of the join | 
**JoinedTableAlias** | **string** | Alias for the table on the right side of the join | 
**LeftTableAlias** | **string** | Alias for the table on the left side of the join | 
**JoinType** | **DesignJoinType** |  | 
**OnClauseTerms** | [**List&lt;OnClauseTermDesign&gt;**](OnClauseTermDesign.md) | Filter clauses to apply to this join in the on clause | 
**RightTableAvailableFields** | [**List&lt;AvailableField&gt;**](AvailableField.md) | Fields that are known to be available for design when parsing SQL, of the right hand table | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)


# Finbourne.Luminesce.Sdk.Model.FeedbackEventArgs

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**When** | **DateTimeOffset** |  | [optional] 
**SessionId** | **Guid** |  | [optional] 
**ExecutionId** | **Guid** |  | [optional] 
**Level** | **FeedbackLevel** |  | [optional] 
**Sender** | **string** |  | [optional] 
**StateId** | **int?** |  | [optional] 
**MessageTemplate** | **string** |  | [optional] 
**PropertyValues** | **List&lt;Object&gt;** |  | [optional] 
**Message** | **string** |  | [optional] [readonly] 

```csharp
using Finbourne.Luminesce.Sdk.Model;
using System;

Guid sessionId = "example sessionId";
Guid executionId = "example executionId";
string sender = "example sender";
string messageTemplate = "example messageTemplate";
List<Object> propertyValues = new List<Object>();
string message = "example message";

FeedbackEventArgs feedbackEventArgsInstance = new FeedbackEventArgs(
    when: when,
    sessionId: sessionId,
    executionId: executionId,
    level: level,
    sender: sender,
    stateId: stateId,
    messageTemplate: messageTemplate,
    propertyValues: propertyValues,
    message: message);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

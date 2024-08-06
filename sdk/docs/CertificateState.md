# Finbourne.Luminesce.Sdk.Model.CertificateState
Information held about the minting / revoking of a certificate.  It does *not* contain the certificate itself

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | The \&quot;key\&quot; to which this belongs in the dictionary,  basically the CN without any version information | [optional] 
**_Version** | **int** | The version of this certificate | [optional] 
**CommonName** | **string** | The common Name of the Certificate | [optional] 
**Type** | **CertificateType** |  | [optional] 
**CreationStatus** | **CertificateStatus** |  | [optional] 
**RevocationStatus** | **CertificateStatus** |  | [optional] 
**ValidityStart** | **DateTimeOffset?** | The earliest point at which a certificate can be used | [optional] 
**ValidityEnd** | **DateTimeOffset?** | The latest point at which a certificate can be used | [optional] 
**RevokedAt** | **DateTimeOffset?** | The point at which this was revoked, if any | [optional] 
**RevokedBy** | **string** | The user which revoked this, if any | [optional] 
**CreatedAt** | **DateTimeOffset?** | The point at which this was created | [optional] 
**CreatedBy** | **string** | The user which created this | [optional] 
**SerialNumber** | **string** | The Vault-issued serial number of the certificate, if any - used for revocation | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) | The location within Configuration Store that this is saved to | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)


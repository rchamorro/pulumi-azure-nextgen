// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20201201preview

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// User cert and permissions associated with that user
type ConfidentialLedgerCertUser struct {
	// Base64 encoded public key of the user cert (.pem or .cer)
	Cert *string `pulumi:"cert"`
}

// ConfidentialLedgerCertUserInput is an input type that accepts ConfidentialLedgerCertUserArgs and ConfidentialLedgerCertUserOutput values.
// You can construct a concrete instance of `ConfidentialLedgerCertUserInput` via:
//
//          ConfidentialLedgerCertUserArgs{...}
type ConfidentialLedgerCertUserInput interface {
	pulumi.Input

	ToConfidentialLedgerCertUserOutput() ConfidentialLedgerCertUserOutput
	ToConfidentialLedgerCertUserOutputWithContext(context.Context) ConfidentialLedgerCertUserOutput
}

// User cert and permissions associated with that user
type ConfidentialLedgerCertUserArgs struct {
	// Base64 encoded public key of the user cert (.pem or .cer)
	Cert pulumi.StringPtrInput `pulumi:"cert"`
}

func (ConfidentialLedgerCertUserArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ConfidentialLedgerCertUser)(nil)).Elem()
}

func (i ConfidentialLedgerCertUserArgs) ToConfidentialLedgerCertUserOutput() ConfidentialLedgerCertUserOutput {
	return i.ToConfidentialLedgerCertUserOutputWithContext(context.Background())
}

func (i ConfidentialLedgerCertUserArgs) ToConfidentialLedgerCertUserOutputWithContext(ctx context.Context) ConfidentialLedgerCertUserOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ConfidentialLedgerCertUserOutput)
}

// ConfidentialLedgerCertUserArrayInput is an input type that accepts ConfidentialLedgerCertUserArray and ConfidentialLedgerCertUserArrayOutput values.
// You can construct a concrete instance of `ConfidentialLedgerCertUserArrayInput` via:
//
//          ConfidentialLedgerCertUserArray{ ConfidentialLedgerCertUserArgs{...} }
type ConfidentialLedgerCertUserArrayInput interface {
	pulumi.Input

	ToConfidentialLedgerCertUserArrayOutput() ConfidentialLedgerCertUserArrayOutput
	ToConfidentialLedgerCertUserArrayOutputWithContext(context.Context) ConfidentialLedgerCertUserArrayOutput
}

type ConfidentialLedgerCertUserArray []ConfidentialLedgerCertUserInput

func (ConfidentialLedgerCertUserArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]ConfidentialLedgerCertUser)(nil)).Elem()
}

func (i ConfidentialLedgerCertUserArray) ToConfidentialLedgerCertUserArrayOutput() ConfidentialLedgerCertUserArrayOutput {
	return i.ToConfidentialLedgerCertUserArrayOutputWithContext(context.Background())
}

func (i ConfidentialLedgerCertUserArray) ToConfidentialLedgerCertUserArrayOutputWithContext(ctx context.Context) ConfidentialLedgerCertUserArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ConfidentialLedgerCertUserArrayOutput)
}

// User cert and permissions associated with that user
type ConfidentialLedgerCertUserOutput struct{ *pulumi.OutputState }

func (ConfidentialLedgerCertUserOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ConfidentialLedgerCertUser)(nil)).Elem()
}

func (o ConfidentialLedgerCertUserOutput) ToConfidentialLedgerCertUserOutput() ConfidentialLedgerCertUserOutput {
	return o
}

func (o ConfidentialLedgerCertUserOutput) ToConfidentialLedgerCertUserOutputWithContext(ctx context.Context) ConfidentialLedgerCertUserOutput {
	return o
}

// Base64 encoded public key of the user cert (.pem or .cer)
func (o ConfidentialLedgerCertUserOutput) Cert() pulumi.StringPtrOutput {
	return o.ApplyT(func(v ConfidentialLedgerCertUser) *string { return v.Cert }).(pulumi.StringPtrOutput)
}

type ConfidentialLedgerCertUserArrayOutput struct{ *pulumi.OutputState }

func (ConfidentialLedgerCertUserArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]ConfidentialLedgerCertUser)(nil)).Elem()
}

func (o ConfidentialLedgerCertUserArrayOutput) ToConfidentialLedgerCertUserArrayOutput() ConfidentialLedgerCertUserArrayOutput {
	return o
}

func (o ConfidentialLedgerCertUserArrayOutput) ToConfidentialLedgerCertUserArrayOutputWithContext(ctx context.Context) ConfidentialLedgerCertUserArrayOutput {
	return o
}

func (o ConfidentialLedgerCertUserArrayOutput) Index(i pulumi.IntInput) ConfidentialLedgerCertUserOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) ConfidentialLedgerCertUser {
		return vs[0].([]ConfidentialLedgerCertUser)[vs[1].(int)]
	}).(ConfidentialLedgerCertUserOutput)
}

// User cert and permissions associated with that user
type ConfidentialLedgerCertUserResponse struct {
	// Base64 encoded public key of the user cert (.pem or .cer)
	Cert *string `pulumi:"cert"`
}

// ConfidentialLedgerCertUserResponseInput is an input type that accepts ConfidentialLedgerCertUserResponseArgs and ConfidentialLedgerCertUserResponseOutput values.
// You can construct a concrete instance of `ConfidentialLedgerCertUserResponseInput` via:
//
//          ConfidentialLedgerCertUserResponseArgs{...}
type ConfidentialLedgerCertUserResponseInput interface {
	pulumi.Input

	ToConfidentialLedgerCertUserResponseOutput() ConfidentialLedgerCertUserResponseOutput
	ToConfidentialLedgerCertUserResponseOutputWithContext(context.Context) ConfidentialLedgerCertUserResponseOutput
}

// User cert and permissions associated with that user
type ConfidentialLedgerCertUserResponseArgs struct {
	// Base64 encoded public key of the user cert (.pem or .cer)
	Cert pulumi.StringPtrInput `pulumi:"cert"`
}

func (ConfidentialLedgerCertUserResponseArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ConfidentialLedgerCertUserResponse)(nil)).Elem()
}

func (i ConfidentialLedgerCertUserResponseArgs) ToConfidentialLedgerCertUserResponseOutput() ConfidentialLedgerCertUserResponseOutput {
	return i.ToConfidentialLedgerCertUserResponseOutputWithContext(context.Background())
}

func (i ConfidentialLedgerCertUserResponseArgs) ToConfidentialLedgerCertUserResponseOutputWithContext(ctx context.Context) ConfidentialLedgerCertUserResponseOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ConfidentialLedgerCertUserResponseOutput)
}

// ConfidentialLedgerCertUserResponseArrayInput is an input type that accepts ConfidentialLedgerCertUserResponseArray and ConfidentialLedgerCertUserResponseArrayOutput values.
// You can construct a concrete instance of `ConfidentialLedgerCertUserResponseArrayInput` via:
//
//          ConfidentialLedgerCertUserResponseArray{ ConfidentialLedgerCertUserResponseArgs{...} }
type ConfidentialLedgerCertUserResponseArrayInput interface {
	pulumi.Input

	ToConfidentialLedgerCertUserResponseArrayOutput() ConfidentialLedgerCertUserResponseArrayOutput
	ToConfidentialLedgerCertUserResponseArrayOutputWithContext(context.Context) ConfidentialLedgerCertUserResponseArrayOutput
}

type ConfidentialLedgerCertUserResponseArray []ConfidentialLedgerCertUserResponseInput

func (ConfidentialLedgerCertUserResponseArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]ConfidentialLedgerCertUserResponse)(nil)).Elem()
}

func (i ConfidentialLedgerCertUserResponseArray) ToConfidentialLedgerCertUserResponseArrayOutput() ConfidentialLedgerCertUserResponseArrayOutput {
	return i.ToConfidentialLedgerCertUserResponseArrayOutputWithContext(context.Background())
}

func (i ConfidentialLedgerCertUserResponseArray) ToConfidentialLedgerCertUserResponseArrayOutputWithContext(ctx context.Context) ConfidentialLedgerCertUserResponseArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ConfidentialLedgerCertUserResponseArrayOutput)
}

// User cert and permissions associated with that user
type ConfidentialLedgerCertUserResponseOutput struct{ *pulumi.OutputState }

func (ConfidentialLedgerCertUserResponseOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ConfidentialLedgerCertUserResponse)(nil)).Elem()
}

func (o ConfidentialLedgerCertUserResponseOutput) ToConfidentialLedgerCertUserResponseOutput() ConfidentialLedgerCertUserResponseOutput {
	return o
}

func (o ConfidentialLedgerCertUserResponseOutput) ToConfidentialLedgerCertUserResponseOutputWithContext(ctx context.Context) ConfidentialLedgerCertUserResponseOutput {
	return o
}

// Base64 encoded public key of the user cert (.pem or .cer)
func (o ConfidentialLedgerCertUserResponseOutput) Cert() pulumi.StringPtrOutput {
	return o.ApplyT(func(v ConfidentialLedgerCertUserResponse) *string { return v.Cert }).(pulumi.StringPtrOutput)
}

type ConfidentialLedgerCertUserResponseArrayOutput struct{ *pulumi.OutputState }

func (ConfidentialLedgerCertUserResponseArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]ConfidentialLedgerCertUserResponse)(nil)).Elem()
}

func (o ConfidentialLedgerCertUserResponseArrayOutput) ToConfidentialLedgerCertUserResponseArrayOutput() ConfidentialLedgerCertUserResponseArrayOutput {
	return o
}

func (o ConfidentialLedgerCertUserResponseArrayOutput) ToConfidentialLedgerCertUserResponseArrayOutputWithContext(ctx context.Context) ConfidentialLedgerCertUserResponseArrayOutput {
	return o
}

func (o ConfidentialLedgerCertUserResponseArrayOutput) Index(i pulumi.IntInput) ConfidentialLedgerCertUserResponseOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) ConfidentialLedgerCertUserResponse {
		return vs[0].([]ConfidentialLedgerCertUserResponse)[vs[1].(int)]
	}).(ConfidentialLedgerCertUserResponseOutput)
}

// Additional Confidential Ledger properties.
type LedgerProperties struct {
	// Array of all the cert based users who can access Confidential Ledger
	CertUsers []ConfidentialLedgerCertUser `pulumi:"certUsers"`
	// Name of the Blob Storage Account for saving ledger files
	LedgerStorageAccount *string `pulumi:"ledgerStorageAccount"`
	// Type of Confidential Ledger
	LedgerType *string `pulumi:"ledgerType"`
}

// LedgerPropertiesInput is an input type that accepts LedgerPropertiesArgs and LedgerPropertiesOutput values.
// You can construct a concrete instance of `LedgerPropertiesInput` via:
//
//          LedgerPropertiesArgs{...}
type LedgerPropertiesInput interface {
	pulumi.Input

	ToLedgerPropertiesOutput() LedgerPropertiesOutput
	ToLedgerPropertiesOutputWithContext(context.Context) LedgerPropertiesOutput
}

// Additional Confidential Ledger properties.
type LedgerPropertiesArgs struct {
	// Array of all the cert based users who can access Confidential Ledger
	CertUsers ConfidentialLedgerCertUserArrayInput `pulumi:"certUsers"`
	// Name of the Blob Storage Account for saving ledger files
	LedgerStorageAccount pulumi.StringPtrInput `pulumi:"ledgerStorageAccount"`
	// Type of Confidential Ledger
	LedgerType pulumi.StringPtrInput `pulumi:"ledgerType"`
}

func (LedgerPropertiesArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LedgerProperties)(nil)).Elem()
}

func (i LedgerPropertiesArgs) ToLedgerPropertiesOutput() LedgerPropertiesOutput {
	return i.ToLedgerPropertiesOutputWithContext(context.Background())
}

func (i LedgerPropertiesArgs) ToLedgerPropertiesOutputWithContext(ctx context.Context) LedgerPropertiesOutput {
	return pulumi.ToOutputWithContext(ctx, i).(LedgerPropertiesOutput)
}

func (i LedgerPropertiesArgs) ToLedgerPropertiesPtrOutput() LedgerPropertiesPtrOutput {
	return i.ToLedgerPropertiesPtrOutputWithContext(context.Background())
}

func (i LedgerPropertiesArgs) ToLedgerPropertiesPtrOutputWithContext(ctx context.Context) LedgerPropertiesPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(LedgerPropertiesOutput).ToLedgerPropertiesPtrOutputWithContext(ctx)
}

// LedgerPropertiesPtrInput is an input type that accepts LedgerPropertiesArgs, LedgerPropertiesPtr and LedgerPropertiesPtrOutput values.
// You can construct a concrete instance of `LedgerPropertiesPtrInput` via:
//
//          LedgerPropertiesArgs{...}
//
//  or:
//
//          nil
type LedgerPropertiesPtrInput interface {
	pulumi.Input

	ToLedgerPropertiesPtrOutput() LedgerPropertiesPtrOutput
	ToLedgerPropertiesPtrOutputWithContext(context.Context) LedgerPropertiesPtrOutput
}

type ledgerPropertiesPtrType LedgerPropertiesArgs

func LedgerPropertiesPtr(v *LedgerPropertiesArgs) LedgerPropertiesPtrInput {
	return (*ledgerPropertiesPtrType)(v)
}

func (*ledgerPropertiesPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**LedgerProperties)(nil)).Elem()
}

func (i *ledgerPropertiesPtrType) ToLedgerPropertiesPtrOutput() LedgerPropertiesPtrOutput {
	return i.ToLedgerPropertiesPtrOutputWithContext(context.Background())
}

func (i *ledgerPropertiesPtrType) ToLedgerPropertiesPtrOutputWithContext(ctx context.Context) LedgerPropertiesPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(LedgerPropertiesPtrOutput)
}

// Additional Confidential Ledger properties.
type LedgerPropertiesOutput struct{ *pulumi.OutputState }

func (LedgerPropertiesOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LedgerProperties)(nil)).Elem()
}

func (o LedgerPropertiesOutput) ToLedgerPropertiesOutput() LedgerPropertiesOutput {
	return o
}

func (o LedgerPropertiesOutput) ToLedgerPropertiesOutputWithContext(ctx context.Context) LedgerPropertiesOutput {
	return o
}

func (o LedgerPropertiesOutput) ToLedgerPropertiesPtrOutput() LedgerPropertiesPtrOutput {
	return o.ToLedgerPropertiesPtrOutputWithContext(context.Background())
}

func (o LedgerPropertiesOutput) ToLedgerPropertiesPtrOutputWithContext(ctx context.Context) LedgerPropertiesPtrOutput {
	return o.ApplyT(func(v LedgerProperties) *LedgerProperties {
		return &v
	}).(LedgerPropertiesPtrOutput)
}

// Array of all the cert based users who can access Confidential Ledger
func (o LedgerPropertiesOutput) CertUsers() ConfidentialLedgerCertUserArrayOutput {
	return o.ApplyT(func(v LedgerProperties) []ConfidentialLedgerCertUser { return v.CertUsers }).(ConfidentialLedgerCertUserArrayOutput)
}

// Name of the Blob Storage Account for saving ledger files
func (o LedgerPropertiesOutput) LedgerStorageAccount() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LedgerProperties) *string { return v.LedgerStorageAccount }).(pulumi.StringPtrOutput)
}

// Type of Confidential Ledger
func (o LedgerPropertiesOutput) LedgerType() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LedgerProperties) *string { return v.LedgerType }).(pulumi.StringPtrOutput)
}

type LedgerPropertiesPtrOutput struct{ *pulumi.OutputState }

func (LedgerPropertiesPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**LedgerProperties)(nil)).Elem()
}

func (o LedgerPropertiesPtrOutput) ToLedgerPropertiesPtrOutput() LedgerPropertiesPtrOutput {
	return o
}

func (o LedgerPropertiesPtrOutput) ToLedgerPropertiesPtrOutputWithContext(ctx context.Context) LedgerPropertiesPtrOutput {
	return o
}

func (o LedgerPropertiesPtrOutput) Elem() LedgerPropertiesOutput {
	return o.ApplyT(func(v *LedgerProperties) LedgerProperties { return *v }).(LedgerPropertiesOutput)
}

// Array of all the cert based users who can access Confidential Ledger
func (o LedgerPropertiesPtrOutput) CertUsers() ConfidentialLedgerCertUserArrayOutput {
	return o.ApplyT(func(v *LedgerProperties) []ConfidentialLedgerCertUser {
		if v == nil {
			return nil
		}
		return v.CertUsers
	}).(ConfidentialLedgerCertUserArrayOutput)
}

// Name of the Blob Storage Account for saving ledger files
func (o LedgerPropertiesPtrOutput) LedgerStorageAccount() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *LedgerProperties) *string {
		if v == nil {
			return nil
		}
		return v.LedgerStorageAccount
	}).(pulumi.StringPtrOutput)
}

// Type of Confidential Ledger
func (o LedgerPropertiesPtrOutput) LedgerType() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *LedgerProperties) *string {
		if v == nil {
			return nil
		}
		return v.LedgerType
	}).(pulumi.StringPtrOutput)
}

// Additional Confidential Ledger properties.
type LedgerPropertiesResponse struct {
	// Array of all the cert based users who can access Confidential Ledger
	CertUsers []ConfidentialLedgerCertUserResponse `pulumi:"certUsers"`
	// Endpoint for accessing network identity.
	IdentityServiceUri string `pulumi:"identityServiceUri"`
	// Internal namespace for the Ledger
	LedgerInternalNamespace string `pulumi:"ledgerInternalNamespace"`
	// Unique name for the Confidential Ledger.
	LedgerName string `pulumi:"ledgerName"`
	// Name of the Blob Storage Account for saving ledger files
	LedgerStorageAccount *string `pulumi:"ledgerStorageAccount"`
	// Type of Confidential Ledger
	LedgerType *string `pulumi:"ledgerType"`
	// Endpoint for calling Ledger Service.
	LedgerUri string `pulumi:"ledgerUri"`
	// Provisioning state of Ledger Resource
	ProvisioningState string `pulumi:"provisioningState"`
}

// LedgerPropertiesResponseInput is an input type that accepts LedgerPropertiesResponseArgs and LedgerPropertiesResponseOutput values.
// You can construct a concrete instance of `LedgerPropertiesResponseInput` via:
//
//          LedgerPropertiesResponseArgs{...}
type LedgerPropertiesResponseInput interface {
	pulumi.Input

	ToLedgerPropertiesResponseOutput() LedgerPropertiesResponseOutput
	ToLedgerPropertiesResponseOutputWithContext(context.Context) LedgerPropertiesResponseOutput
}

// Additional Confidential Ledger properties.
type LedgerPropertiesResponseArgs struct {
	// Array of all the cert based users who can access Confidential Ledger
	CertUsers ConfidentialLedgerCertUserResponseArrayInput `pulumi:"certUsers"`
	// Endpoint for accessing network identity.
	IdentityServiceUri pulumi.StringInput `pulumi:"identityServiceUri"`
	// Internal namespace for the Ledger
	LedgerInternalNamespace pulumi.StringInput `pulumi:"ledgerInternalNamespace"`
	// Unique name for the Confidential Ledger.
	LedgerName pulumi.StringInput `pulumi:"ledgerName"`
	// Name of the Blob Storage Account for saving ledger files
	LedgerStorageAccount pulumi.StringPtrInput `pulumi:"ledgerStorageAccount"`
	// Type of Confidential Ledger
	LedgerType pulumi.StringPtrInput `pulumi:"ledgerType"`
	// Endpoint for calling Ledger Service.
	LedgerUri pulumi.StringInput `pulumi:"ledgerUri"`
	// Provisioning state of Ledger Resource
	ProvisioningState pulumi.StringInput `pulumi:"provisioningState"`
}

func (LedgerPropertiesResponseArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LedgerPropertiesResponse)(nil)).Elem()
}

func (i LedgerPropertiesResponseArgs) ToLedgerPropertiesResponseOutput() LedgerPropertiesResponseOutput {
	return i.ToLedgerPropertiesResponseOutputWithContext(context.Background())
}

func (i LedgerPropertiesResponseArgs) ToLedgerPropertiesResponseOutputWithContext(ctx context.Context) LedgerPropertiesResponseOutput {
	return pulumi.ToOutputWithContext(ctx, i).(LedgerPropertiesResponseOutput)
}

func (i LedgerPropertiesResponseArgs) ToLedgerPropertiesResponsePtrOutput() LedgerPropertiesResponsePtrOutput {
	return i.ToLedgerPropertiesResponsePtrOutputWithContext(context.Background())
}

func (i LedgerPropertiesResponseArgs) ToLedgerPropertiesResponsePtrOutputWithContext(ctx context.Context) LedgerPropertiesResponsePtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(LedgerPropertiesResponseOutput).ToLedgerPropertiesResponsePtrOutputWithContext(ctx)
}

// LedgerPropertiesResponsePtrInput is an input type that accepts LedgerPropertiesResponseArgs, LedgerPropertiesResponsePtr and LedgerPropertiesResponsePtrOutput values.
// You can construct a concrete instance of `LedgerPropertiesResponsePtrInput` via:
//
//          LedgerPropertiesResponseArgs{...}
//
//  or:
//
//          nil
type LedgerPropertiesResponsePtrInput interface {
	pulumi.Input

	ToLedgerPropertiesResponsePtrOutput() LedgerPropertiesResponsePtrOutput
	ToLedgerPropertiesResponsePtrOutputWithContext(context.Context) LedgerPropertiesResponsePtrOutput
}

type ledgerPropertiesResponsePtrType LedgerPropertiesResponseArgs

func LedgerPropertiesResponsePtr(v *LedgerPropertiesResponseArgs) LedgerPropertiesResponsePtrInput {
	return (*ledgerPropertiesResponsePtrType)(v)
}

func (*ledgerPropertiesResponsePtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**LedgerPropertiesResponse)(nil)).Elem()
}

func (i *ledgerPropertiesResponsePtrType) ToLedgerPropertiesResponsePtrOutput() LedgerPropertiesResponsePtrOutput {
	return i.ToLedgerPropertiesResponsePtrOutputWithContext(context.Background())
}

func (i *ledgerPropertiesResponsePtrType) ToLedgerPropertiesResponsePtrOutputWithContext(ctx context.Context) LedgerPropertiesResponsePtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(LedgerPropertiesResponsePtrOutput)
}

// Additional Confidential Ledger properties.
type LedgerPropertiesResponseOutput struct{ *pulumi.OutputState }

func (LedgerPropertiesResponseOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LedgerPropertiesResponse)(nil)).Elem()
}

func (o LedgerPropertiesResponseOutput) ToLedgerPropertiesResponseOutput() LedgerPropertiesResponseOutput {
	return o
}

func (o LedgerPropertiesResponseOutput) ToLedgerPropertiesResponseOutputWithContext(ctx context.Context) LedgerPropertiesResponseOutput {
	return o
}

func (o LedgerPropertiesResponseOutput) ToLedgerPropertiesResponsePtrOutput() LedgerPropertiesResponsePtrOutput {
	return o.ToLedgerPropertiesResponsePtrOutputWithContext(context.Background())
}

func (o LedgerPropertiesResponseOutput) ToLedgerPropertiesResponsePtrOutputWithContext(ctx context.Context) LedgerPropertiesResponsePtrOutput {
	return o.ApplyT(func(v LedgerPropertiesResponse) *LedgerPropertiesResponse {
		return &v
	}).(LedgerPropertiesResponsePtrOutput)
}

// Array of all the cert based users who can access Confidential Ledger
func (o LedgerPropertiesResponseOutput) CertUsers() ConfidentialLedgerCertUserResponseArrayOutput {
	return o.ApplyT(func(v LedgerPropertiesResponse) []ConfidentialLedgerCertUserResponse { return v.CertUsers }).(ConfidentialLedgerCertUserResponseArrayOutput)
}

// Endpoint for accessing network identity.
func (o LedgerPropertiesResponseOutput) IdentityServiceUri() pulumi.StringOutput {
	return o.ApplyT(func(v LedgerPropertiesResponse) string { return v.IdentityServiceUri }).(pulumi.StringOutput)
}

// Internal namespace for the Ledger
func (o LedgerPropertiesResponseOutput) LedgerInternalNamespace() pulumi.StringOutput {
	return o.ApplyT(func(v LedgerPropertiesResponse) string { return v.LedgerInternalNamespace }).(pulumi.StringOutput)
}

// Unique name for the Confidential Ledger.
func (o LedgerPropertiesResponseOutput) LedgerName() pulumi.StringOutput {
	return o.ApplyT(func(v LedgerPropertiesResponse) string { return v.LedgerName }).(pulumi.StringOutput)
}

// Name of the Blob Storage Account for saving ledger files
func (o LedgerPropertiesResponseOutput) LedgerStorageAccount() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LedgerPropertiesResponse) *string { return v.LedgerStorageAccount }).(pulumi.StringPtrOutput)
}

// Type of Confidential Ledger
func (o LedgerPropertiesResponseOutput) LedgerType() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LedgerPropertiesResponse) *string { return v.LedgerType }).(pulumi.StringPtrOutput)
}

// Endpoint for calling Ledger Service.
func (o LedgerPropertiesResponseOutput) LedgerUri() pulumi.StringOutput {
	return o.ApplyT(func(v LedgerPropertiesResponse) string { return v.LedgerUri }).(pulumi.StringOutput)
}

// Provisioning state of Ledger Resource
func (o LedgerPropertiesResponseOutput) ProvisioningState() pulumi.StringOutput {
	return o.ApplyT(func(v LedgerPropertiesResponse) string { return v.ProvisioningState }).(pulumi.StringOutput)
}

type LedgerPropertiesResponsePtrOutput struct{ *pulumi.OutputState }

func (LedgerPropertiesResponsePtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**LedgerPropertiesResponse)(nil)).Elem()
}

func (o LedgerPropertiesResponsePtrOutput) ToLedgerPropertiesResponsePtrOutput() LedgerPropertiesResponsePtrOutput {
	return o
}

func (o LedgerPropertiesResponsePtrOutput) ToLedgerPropertiesResponsePtrOutputWithContext(ctx context.Context) LedgerPropertiesResponsePtrOutput {
	return o
}

func (o LedgerPropertiesResponsePtrOutput) Elem() LedgerPropertiesResponseOutput {
	return o.ApplyT(func(v *LedgerPropertiesResponse) LedgerPropertiesResponse { return *v }).(LedgerPropertiesResponseOutput)
}

// Array of all the cert based users who can access Confidential Ledger
func (o LedgerPropertiesResponsePtrOutput) CertUsers() ConfidentialLedgerCertUserResponseArrayOutput {
	return o.ApplyT(func(v *LedgerPropertiesResponse) []ConfidentialLedgerCertUserResponse {
		if v == nil {
			return nil
		}
		return v.CertUsers
	}).(ConfidentialLedgerCertUserResponseArrayOutput)
}

// Endpoint for accessing network identity.
func (o LedgerPropertiesResponsePtrOutput) IdentityServiceUri() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *LedgerPropertiesResponse) *string {
		if v == nil {
			return nil
		}
		return &v.IdentityServiceUri
	}).(pulumi.StringPtrOutput)
}

// Internal namespace for the Ledger
func (o LedgerPropertiesResponsePtrOutput) LedgerInternalNamespace() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *LedgerPropertiesResponse) *string {
		if v == nil {
			return nil
		}
		return &v.LedgerInternalNamespace
	}).(pulumi.StringPtrOutput)
}

// Unique name for the Confidential Ledger.
func (o LedgerPropertiesResponsePtrOutput) LedgerName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *LedgerPropertiesResponse) *string {
		if v == nil {
			return nil
		}
		return &v.LedgerName
	}).(pulumi.StringPtrOutput)
}

// Name of the Blob Storage Account for saving ledger files
func (o LedgerPropertiesResponsePtrOutput) LedgerStorageAccount() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *LedgerPropertiesResponse) *string {
		if v == nil {
			return nil
		}
		return v.LedgerStorageAccount
	}).(pulumi.StringPtrOutput)
}

// Type of Confidential Ledger
func (o LedgerPropertiesResponsePtrOutput) LedgerType() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *LedgerPropertiesResponse) *string {
		if v == nil {
			return nil
		}
		return v.LedgerType
	}).(pulumi.StringPtrOutput)
}

// Endpoint for calling Ledger Service.
func (o LedgerPropertiesResponsePtrOutput) LedgerUri() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *LedgerPropertiesResponse) *string {
		if v == nil {
			return nil
		}
		return &v.LedgerUri
	}).(pulumi.StringPtrOutput)
}

// Provisioning state of Ledger Resource
func (o LedgerPropertiesResponsePtrOutput) ProvisioningState() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *LedgerPropertiesResponse) *string {
		if v == nil {
			return nil
		}
		return &v.ProvisioningState
	}).(pulumi.StringPtrOutput)
}

// Metadata pertaining to creation and last modification of the resource.
type SystemDataResponse struct {
	// The timestamp of resource creation (UTC).
	CreatedAt *string `pulumi:"createdAt"`
	// The identity that created the resource.
	CreatedBy *string `pulumi:"createdBy"`
	// The type of identity that created the resource.
	CreatedByType *string `pulumi:"createdByType"`
	// The type of identity that last modified the resource.
	LastModifiedAt *string `pulumi:"lastModifiedAt"`
	// The identity that last modified the resource.
	LastModifiedBy *string `pulumi:"lastModifiedBy"`
	// The type of identity that last modified the resource.
	LastModifiedByType *string `pulumi:"lastModifiedByType"`
}

// SystemDataResponseInput is an input type that accepts SystemDataResponseArgs and SystemDataResponseOutput values.
// You can construct a concrete instance of `SystemDataResponseInput` via:
//
//          SystemDataResponseArgs{...}
type SystemDataResponseInput interface {
	pulumi.Input

	ToSystemDataResponseOutput() SystemDataResponseOutput
	ToSystemDataResponseOutputWithContext(context.Context) SystemDataResponseOutput
}

// Metadata pertaining to creation and last modification of the resource.
type SystemDataResponseArgs struct {
	// The timestamp of resource creation (UTC).
	CreatedAt pulumi.StringPtrInput `pulumi:"createdAt"`
	// The identity that created the resource.
	CreatedBy pulumi.StringPtrInput `pulumi:"createdBy"`
	// The type of identity that created the resource.
	CreatedByType pulumi.StringPtrInput `pulumi:"createdByType"`
	// The type of identity that last modified the resource.
	LastModifiedAt pulumi.StringPtrInput `pulumi:"lastModifiedAt"`
	// The identity that last modified the resource.
	LastModifiedBy pulumi.StringPtrInput `pulumi:"lastModifiedBy"`
	// The type of identity that last modified the resource.
	LastModifiedByType pulumi.StringPtrInput `pulumi:"lastModifiedByType"`
}

func (SystemDataResponseArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*SystemDataResponse)(nil)).Elem()
}

func (i SystemDataResponseArgs) ToSystemDataResponseOutput() SystemDataResponseOutput {
	return i.ToSystemDataResponseOutputWithContext(context.Background())
}

func (i SystemDataResponseArgs) ToSystemDataResponseOutputWithContext(ctx context.Context) SystemDataResponseOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SystemDataResponseOutput)
}

func (i SystemDataResponseArgs) ToSystemDataResponsePtrOutput() SystemDataResponsePtrOutput {
	return i.ToSystemDataResponsePtrOutputWithContext(context.Background())
}

func (i SystemDataResponseArgs) ToSystemDataResponsePtrOutputWithContext(ctx context.Context) SystemDataResponsePtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SystemDataResponseOutput).ToSystemDataResponsePtrOutputWithContext(ctx)
}

// SystemDataResponsePtrInput is an input type that accepts SystemDataResponseArgs, SystemDataResponsePtr and SystemDataResponsePtrOutput values.
// You can construct a concrete instance of `SystemDataResponsePtrInput` via:
//
//          SystemDataResponseArgs{...}
//
//  or:
//
//          nil
type SystemDataResponsePtrInput interface {
	pulumi.Input

	ToSystemDataResponsePtrOutput() SystemDataResponsePtrOutput
	ToSystemDataResponsePtrOutputWithContext(context.Context) SystemDataResponsePtrOutput
}

type systemDataResponsePtrType SystemDataResponseArgs

func SystemDataResponsePtr(v *SystemDataResponseArgs) SystemDataResponsePtrInput {
	return (*systemDataResponsePtrType)(v)
}

func (*systemDataResponsePtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**SystemDataResponse)(nil)).Elem()
}

func (i *systemDataResponsePtrType) ToSystemDataResponsePtrOutput() SystemDataResponsePtrOutput {
	return i.ToSystemDataResponsePtrOutputWithContext(context.Background())
}

func (i *systemDataResponsePtrType) ToSystemDataResponsePtrOutputWithContext(ctx context.Context) SystemDataResponsePtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SystemDataResponsePtrOutput)
}

// Metadata pertaining to creation and last modification of the resource.
type SystemDataResponseOutput struct{ *pulumi.OutputState }

func (SystemDataResponseOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*SystemDataResponse)(nil)).Elem()
}

func (o SystemDataResponseOutput) ToSystemDataResponseOutput() SystemDataResponseOutput {
	return o
}

func (o SystemDataResponseOutput) ToSystemDataResponseOutputWithContext(ctx context.Context) SystemDataResponseOutput {
	return o
}

func (o SystemDataResponseOutput) ToSystemDataResponsePtrOutput() SystemDataResponsePtrOutput {
	return o.ToSystemDataResponsePtrOutputWithContext(context.Background())
}

func (o SystemDataResponseOutput) ToSystemDataResponsePtrOutputWithContext(ctx context.Context) SystemDataResponsePtrOutput {
	return o.ApplyT(func(v SystemDataResponse) *SystemDataResponse {
		return &v
	}).(SystemDataResponsePtrOutput)
}

// The timestamp of resource creation (UTC).
func (o SystemDataResponseOutput) CreatedAt() pulumi.StringPtrOutput {
	return o.ApplyT(func(v SystemDataResponse) *string { return v.CreatedAt }).(pulumi.StringPtrOutput)
}

// The identity that created the resource.
func (o SystemDataResponseOutput) CreatedBy() pulumi.StringPtrOutput {
	return o.ApplyT(func(v SystemDataResponse) *string { return v.CreatedBy }).(pulumi.StringPtrOutput)
}

// The type of identity that created the resource.
func (o SystemDataResponseOutput) CreatedByType() pulumi.StringPtrOutput {
	return o.ApplyT(func(v SystemDataResponse) *string { return v.CreatedByType }).(pulumi.StringPtrOutput)
}

// The type of identity that last modified the resource.
func (o SystemDataResponseOutput) LastModifiedAt() pulumi.StringPtrOutput {
	return o.ApplyT(func(v SystemDataResponse) *string { return v.LastModifiedAt }).(pulumi.StringPtrOutput)
}

// The identity that last modified the resource.
func (o SystemDataResponseOutput) LastModifiedBy() pulumi.StringPtrOutput {
	return o.ApplyT(func(v SystemDataResponse) *string { return v.LastModifiedBy }).(pulumi.StringPtrOutput)
}

// The type of identity that last modified the resource.
func (o SystemDataResponseOutput) LastModifiedByType() pulumi.StringPtrOutput {
	return o.ApplyT(func(v SystemDataResponse) *string { return v.LastModifiedByType }).(pulumi.StringPtrOutput)
}

type SystemDataResponsePtrOutput struct{ *pulumi.OutputState }

func (SystemDataResponsePtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**SystemDataResponse)(nil)).Elem()
}

func (o SystemDataResponsePtrOutput) ToSystemDataResponsePtrOutput() SystemDataResponsePtrOutput {
	return o
}

func (o SystemDataResponsePtrOutput) ToSystemDataResponsePtrOutputWithContext(ctx context.Context) SystemDataResponsePtrOutput {
	return o
}

func (o SystemDataResponsePtrOutput) Elem() SystemDataResponseOutput {
	return o.ApplyT(func(v *SystemDataResponse) SystemDataResponse { return *v }).(SystemDataResponseOutput)
}

// The timestamp of resource creation (UTC).
func (o SystemDataResponsePtrOutput) CreatedAt() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SystemDataResponse) *string {
		if v == nil {
			return nil
		}
		return v.CreatedAt
	}).(pulumi.StringPtrOutput)
}

// The identity that created the resource.
func (o SystemDataResponsePtrOutput) CreatedBy() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SystemDataResponse) *string {
		if v == nil {
			return nil
		}
		return v.CreatedBy
	}).(pulumi.StringPtrOutput)
}

// The type of identity that created the resource.
func (o SystemDataResponsePtrOutput) CreatedByType() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SystemDataResponse) *string {
		if v == nil {
			return nil
		}
		return v.CreatedByType
	}).(pulumi.StringPtrOutput)
}

// The type of identity that last modified the resource.
func (o SystemDataResponsePtrOutput) LastModifiedAt() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SystemDataResponse) *string {
		if v == nil {
			return nil
		}
		return v.LastModifiedAt
	}).(pulumi.StringPtrOutput)
}

// The identity that last modified the resource.
func (o SystemDataResponsePtrOutput) LastModifiedBy() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SystemDataResponse) *string {
		if v == nil {
			return nil
		}
		return v.LastModifiedBy
	}).(pulumi.StringPtrOutput)
}

// The type of identity that last modified the resource.
func (o SystemDataResponsePtrOutput) LastModifiedByType() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SystemDataResponse) *string {
		if v == nil {
			return nil
		}
		return v.LastModifiedByType
	}).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(ConfidentialLedgerCertUserOutput{})
	pulumi.RegisterOutputType(ConfidentialLedgerCertUserArrayOutput{})
	pulumi.RegisterOutputType(ConfidentialLedgerCertUserResponseOutput{})
	pulumi.RegisterOutputType(ConfidentialLedgerCertUserResponseArrayOutput{})
	pulumi.RegisterOutputType(LedgerPropertiesOutput{})
	pulumi.RegisterOutputType(LedgerPropertiesPtrOutput{})
	pulumi.RegisterOutputType(LedgerPropertiesResponseOutput{})
	pulumi.RegisterOutputType(LedgerPropertiesResponsePtrOutput{})
	pulumi.RegisterOutputType(SystemDataResponseOutput{})
	pulumi.RegisterOutputType(SystemDataResponsePtrOutput{})
}

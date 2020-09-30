// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20180501

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Identity for the resource.
type Identity struct {
	// The identity type.
	Type *string `pulumi:"type"`
}

// IdentityInput is an input type that accepts IdentityArgs and IdentityOutput values.
// You can construct a concrete instance of `IdentityInput` via:
//
//          IdentityArgs{...}
type IdentityInput interface {
	pulumi.Input

	ToIdentityOutput() IdentityOutput
	ToIdentityOutputWithContext(context.Context) IdentityOutput
}

// Identity for the resource.
type IdentityArgs struct {
	// The identity type.
	Type pulumi.StringPtrInput `pulumi:"type"`
}

func (IdentityArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*Identity)(nil)).Elem()
}

func (i IdentityArgs) ToIdentityOutput() IdentityOutput {
	return i.ToIdentityOutputWithContext(context.Background())
}

func (i IdentityArgs) ToIdentityOutputWithContext(ctx context.Context) IdentityOutput {
	return pulumi.ToOutputWithContext(ctx, i).(IdentityOutput)
}

func (i IdentityArgs) ToIdentityPtrOutput() IdentityPtrOutput {
	return i.ToIdentityPtrOutputWithContext(context.Background())
}

func (i IdentityArgs) ToIdentityPtrOutputWithContext(ctx context.Context) IdentityPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(IdentityOutput).ToIdentityPtrOutputWithContext(ctx)
}

// IdentityPtrInput is an input type that accepts IdentityArgs, IdentityPtr and IdentityPtrOutput values.
// You can construct a concrete instance of `IdentityPtrInput` via:
//
//          IdentityArgs{...}
//
//  or:
//
//          nil
type IdentityPtrInput interface {
	pulumi.Input

	ToIdentityPtrOutput() IdentityPtrOutput
	ToIdentityPtrOutputWithContext(context.Context) IdentityPtrOutput
}

type identityPtrType IdentityArgs

func IdentityPtr(v *IdentityArgs) IdentityPtrInput {
	return (*identityPtrType)(v)
}

func (*identityPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**Identity)(nil)).Elem()
}

func (i *identityPtrType) ToIdentityPtrOutput() IdentityPtrOutput {
	return i.ToIdentityPtrOutputWithContext(context.Background())
}

func (i *identityPtrType) ToIdentityPtrOutputWithContext(ctx context.Context) IdentityPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(IdentityPtrOutput)
}

// Identity for the resource.
type IdentityOutput struct{ *pulumi.OutputState }

func (IdentityOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Identity)(nil)).Elem()
}

func (o IdentityOutput) ToIdentityOutput() IdentityOutput {
	return o
}

func (o IdentityOutput) ToIdentityOutputWithContext(ctx context.Context) IdentityOutput {
	return o
}

func (o IdentityOutput) ToIdentityPtrOutput() IdentityPtrOutput {
	return o.ToIdentityPtrOutputWithContext(context.Background())
}

func (o IdentityOutput) ToIdentityPtrOutputWithContext(ctx context.Context) IdentityPtrOutput {
	return o.ApplyT(func(v Identity) *Identity {
		return &v
	}).(IdentityPtrOutput)
}

// The identity type.
func (o IdentityOutput) Type() pulumi.StringPtrOutput {
	return o.ApplyT(func(v Identity) *string { return v.Type }).(pulumi.StringPtrOutput)
}

type IdentityPtrOutput struct{ *pulumi.OutputState }

func (IdentityPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Identity)(nil)).Elem()
}

func (o IdentityPtrOutput) ToIdentityPtrOutput() IdentityPtrOutput {
	return o
}

func (o IdentityPtrOutput) ToIdentityPtrOutputWithContext(ctx context.Context) IdentityPtrOutput {
	return o
}

func (o IdentityPtrOutput) Elem() IdentityOutput {
	return o.ApplyT(func(v *Identity) Identity { return *v }).(IdentityOutput)
}

// The identity type.
func (o IdentityPtrOutput) Type() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Identity) *string {
		if v == nil {
			return nil
		}
		return v.Type
	}).(pulumi.StringPtrOutput)
}

// Identity for the resource.
type IdentityResponse struct {
	// The principal ID of the resource identity.
	PrincipalId string `pulumi:"principalId"`
	// The tenant ID of the resource identity.
	TenantId string `pulumi:"tenantId"`
	// The identity type.
	Type *string `pulumi:"type"`
}

// IdentityResponseInput is an input type that accepts IdentityResponseArgs and IdentityResponseOutput values.
// You can construct a concrete instance of `IdentityResponseInput` via:
//
//          IdentityResponseArgs{...}
type IdentityResponseInput interface {
	pulumi.Input

	ToIdentityResponseOutput() IdentityResponseOutput
	ToIdentityResponseOutputWithContext(context.Context) IdentityResponseOutput
}

// Identity for the resource.
type IdentityResponseArgs struct {
	// The principal ID of the resource identity.
	PrincipalId pulumi.StringInput `pulumi:"principalId"`
	// The tenant ID of the resource identity.
	TenantId pulumi.StringInput `pulumi:"tenantId"`
	// The identity type.
	Type pulumi.StringPtrInput `pulumi:"type"`
}

func (IdentityResponseArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*IdentityResponse)(nil)).Elem()
}

func (i IdentityResponseArgs) ToIdentityResponseOutput() IdentityResponseOutput {
	return i.ToIdentityResponseOutputWithContext(context.Background())
}

func (i IdentityResponseArgs) ToIdentityResponseOutputWithContext(ctx context.Context) IdentityResponseOutput {
	return pulumi.ToOutputWithContext(ctx, i).(IdentityResponseOutput)
}

func (i IdentityResponseArgs) ToIdentityResponsePtrOutput() IdentityResponsePtrOutput {
	return i.ToIdentityResponsePtrOutputWithContext(context.Background())
}

func (i IdentityResponseArgs) ToIdentityResponsePtrOutputWithContext(ctx context.Context) IdentityResponsePtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(IdentityResponseOutput).ToIdentityResponsePtrOutputWithContext(ctx)
}

// IdentityResponsePtrInput is an input type that accepts IdentityResponseArgs, IdentityResponsePtr and IdentityResponsePtrOutput values.
// You can construct a concrete instance of `IdentityResponsePtrInput` via:
//
//          IdentityResponseArgs{...}
//
//  or:
//
//          nil
type IdentityResponsePtrInput interface {
	pulumi.Input

	ToIdentityResponsePtrOutput() IdentityResponsePtrOutput
	ToIdentityResponsePtrOutputWithContext(context.Context) IdentityResponsePtrOutput
}

type identityResponsePtrType IdentityResponseArgs

func IdentityResponsePtr(v *IdentityResponseArgs) IdentityResponsePtrInput {
	return (*identityResponsePtrType)(v)
}

func (*identityResponsePtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**IdentityResponse)(nil)).Elem()
}

func (i *identityResponsePtrType) ToIdentityResponsePtrOutput() IdentityResponsePtrOutput {
	return i.ToIdentityResponsePtrOutputWithContext(context.Background())
}

func (i *identityResponsePtrType) ToIdentityResponsePtrOutputWithContext(ctx context.Context) IdentityResponsePtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(IdentityResponsePtrOutput)
}

// Identity for the resource.
type IdentityResponseOutput struct{ *pulumi.OutputState }

func (IdentityResponseOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*IdentityResponse)(nil)).Elem()
}

func (o IdentityResponseOutput) ToIdentityResponseOutput() IdentityResponseOutput {
	return o
}

func (o IdentityResponseOutput) ToIdentityResponseOutputWithContext(ctx context.Context) IdentityResponseOutput {
	return o
}

func (o IdentityResponseOutput) ToIdentityResponsePtrOutput() IdentityResponsePtrOutput {
	return o.ToIdentityResponsePtrOutputWithContext(context.Background())
}

func (o IdentityResponseOutput) ToIdentityResponsePtrOutputWithContext(ctx context.Context) IdentityResponsePtrOutput {
	return o.ApplyT(func(v IdentityResponse) *IdentityResponse {
		return &v
	}).(IdentityResponsePtrOutput)
}

// The principal ID of the resource identity.
func (o IdentityResponseOutput) PrincipalId() pulumi.StringOutput {
	return o.ApplyT(func(v IdentityResponse) string { return v.PrincipalId }).(pulumi.StringOutput)
}

// The tenant ID of the resource identity.
func (o IdentityResponseOutput) TenantId() pulumi.StringOutput {
	return o.ApplyT(func(v IdentityResponse) string { return v.TenantId }).(pulumi.StringOutput)
}

// The identity type.
func (o IdentityResponseOutput) Type() pulumi.StringPtrOutput {
	return o.ApplyT(func(v IdentityResponse) *string { return v.Type }).(pulumi.StringPtrOutput)
}

type IdentityResponsePtrOutput struct{ *pulumi.OutputState }

func (IdentityResponsePtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**IdentityResponse)(nil)).Elem()
}

func (o IdentityResponsePtrOutput) ToIdentityResponsePtrOutput() IdentityResponsePtrOutput {
	return o
}

func (o IdentityResponsePtrOutput) ToIdentityResponsePtrOutputWithContext(ctx context.Context) IdentityResponsePtrOutput {
	return o
}

func (o IdentityResponsePtrOutput) Elem() IdentityResponseOutput {
	return o.ApplyT(func(v *IdentityResponse) IdentityResponse { return *v }).(IdentityResponseOutput)
}

// The principal ID of the resource identity.
func (o IdentityResponsePtrOutput) PrincipalId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *IdentityResponse) *string {
		if v == nil {
			return nil
		}
		return &v.PrincipalId
	}).(pulumi.StringPtrOutput)
}

// The tenant ID of the resource identity.
func (o IdentityResponsePtrOutput) TenantId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *IdentityResponse) *string {
		if v == nil {
			return nil
		}
		return &v.TenantId
	}).(pulumi.StringPtrOutput)
}

// The identity type.
func (o IdentityResponsePtrOutput) Type() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *IdentityResponse) *string {
		if v == nil {
			return nil
		}
		return v.Type
	}).(pulumi.StringPtrOutput)
}

// The policy definition reference.
type PolicyDefinitionReference struct {
	// Required if a parameter is used in policy rule.
	Parameters interface{} `pulumi:"parameters"`
	// The ID of the policy definition or policy set definition.
	PolicyDefinitionId *string `pulumi:"policyDefinitionId"`
}

// PolicyDefinitionReferenceInput is an input type that accepts PolicyDefinitionReferenceArgs and PolicyDefinitionReferenceOutput values.
// You can construct a concrete instance of `PolicyDefinitionReferenceInput` via:
//
//          PolicyDefinitionReferenceArgs{...}
type PolicyDefinitionReferenceInput interface {
	pulumi.Input

	ToPolicyDefinitionReferenceOutput() PolicyDefinitionReferenceOutput
	ToPolicyDefinitionReferenceOutputWithContext(context.Context) PolicyDefinitionReferenceOutput
}

// The policy definition reference.
type PolicyDefinitionReferenceArgs struct {
	// Required if a parameter is used in policy rule.
	Parameters pulumi.Input `pulumi:"parameters"`
	// The ID of the policy definition or policy set definition.
	PolicyDefinitionId pulumi.StringPtrInput `pulumi:"policyDefinitionId"`
}

func (PolicyDefinitionReferenceArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*PolicyDefinitionReference)(nil)).Elem()
}

func (i PolicyDefinitionReferenceArgs) ToPolicyDefinitionReferenceOutput() PolicyDefinitionReferenceOutput {
	return i.ToPolicyDefinitionReferenceOutputWithContext(context.Background())
}

func (i PolicyDefinitionReferenceArgs) ToPolicyDefinitionReferenceOutputWithContext(ctx context.Context) PolicyDefinitionReferenceOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PolicyDefinitionReferenceOutput)
}

// PolicyDefinitionReferenceArrayInput is an input type that accepts PolicyDefinitionReferenceArray and PolicyDefinitionReferenceArrayOutput values.
// You can construct a concrete instance of `PolicyDefinitionReferenceArrayInput` via:
//
//          PolicyDefinitionReferenceArray{ PolicyDefinitionReferenceArgs{...} }
type PolicyDefinitionReferenceArrayInput interface {
	pulumi.Input

	ToPolicyDefinitionReferenceArrayOutput() PolicyDefinitionReferenceArrayOutput
	ToPolicyDefinitionReferenceArrayOutputWithContext(context.Context) PolicyDefinitionReferenceArrayOutput
}

type PolicyDefinitionReferenceArray []PolicyDefinitionReferenceInput

func (PolicyDefinitionReferenceArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]PolicyDefinitionReference)(nil)).Elem()
}

func (i PolicyDefinitionReferenceArray) ToPolicyDefinitionReferenceArrayOutput() PolicyDefinitionReferenceArrayOutput {
	return i.ToPolicyDefinitionReferenceArrayOutputWithContext(context.Background())
}

func (i PolicyDefinitionReferenceArray) ToPolicyDefinitionReferenceArrayOutputWithContext(ctx context.Context) PolicyDefinitionReferenceArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PolicyDefinitionReferenceArrayOutput)
}

// The policy definition reference.
type PolicyDefinitionReferenceOutput struct{ *pulumi.OutputState }

func (PolicyDefinitionReferenceOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*PolicyDefinitionReference)(nil)).Elem()
}

func (o PolicyDefinitionReferenceOutput) ToPolicyDefinitionReferenceOutput() PolicyDefinitionReferenceOutput {
	return o
}

func (o PolicyDefinitionReferenceOutput) ToPolicyDefinitionReferenceOutputWithContext(ctx context.Context) PolicyDefinitionReferenceOutput {
	return o
}

// Required if a parameter is used in policy rule.
func (o PolicyDefinitionReferenceOutput) Parameters() pulumi.AnyOutput {
	return o.ApplyT(func(v PolicyDefinitionReference) interface{} { return v.Parameters }).(pulumi.AnyOutput)
}

// The ID of the policy definition or policy set definition.
func (o PolicyDefinitionReferenceOutput) PolicyDefinitionId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v PolicyDefinitionReference) *string { return v.PolicyDefinitionId }).(pulumi.StringPtrOutput)
}

type PolicyDefinitionReferenceArrayOutput struct{ *pulumi.OutputState }

func (PolicyDefinitionReferenceArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]PolicyDefinitionReference)(nil)).Elem()
}

func (o PolicyDefinitionReferenceArrayOutput) ToPolicyDefinitionReferenceArrayOutput() PolicyDefinitionReferenceArrayOutput {
	return o
}

func (o PolicyDefinitionReferenceArrayOutput) ToPolicyDefinitionReferenceArrayOutputWithContext(ctx context.Context) PolicyDefinitionReferenceArrayOutput {
	return o
}

func (o PolicyDefinitionReferenceArrayOutput) Index(i pulumi.IntInput) PolicyDefinitionReferenceOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) PolicyDefinitionReference {
		return vs[0].([]PolicyDefinitionReference)[vs[1].(int)]
	}).(PolicyDefinitionReferenceOutput)
}

// The policy definition reference.
type PolicyDefinitionReferenceResponse struct {
	// Required if a parameter is used in policy rule.
	Parameters interface{} `pulumi:"parameters"`
	// The ID of the policy definition or policy set definition.
	PolicyDefinitionId *string `pulumi:"policyDefinitionId"`
}

// PolicyDefinitionReferenceResponseInput is an input type that accepts PolicyDefinitionReferenceResponseArgs and PolicyDefinitionReferenceResponseOutput values.
// You can construct a concrete instance of `PolicyDefinitionReferenceResponseInput` via:
//
//          PolicyDefinitionReferenceResponseArgs{...}
type PolicyDefinitionReferenceResponseInput interface {
	pulumi.Input

	ToPolicyDefinitionReferenceResponseOutput() PolicyDefinitionReferenceResponseOutput
	ToPolicyDefinitionReferenceResponseOutputWithContext(context.Context) PolicyDefinitionReferenceResponseOutput
}

// The policy definition reference.
type PolicyDefinitionReferenceResponseArgs struct {
	// Required if a parameter is used in policy rule.
	Parameters pulumi.Input `pulumi:"parameters"`
	// The ID of the policy definition or policy set definition.
	PolicyDefinitionId pulumi.StringPtrInput `pulumi:"policyDefinitionId"`
}

func (PolicyDefinitionReferenceResponseArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*PolicyDefinitionReferenceResponse)(nil)).Elem()
}

func (i PolicyDefinitionReferenceResponseArgs) ToPolicyDefinitionReferenceResponseOutput() PolicyDefinitionReferenceResponseOutput {
	return i.ToPolicyDefinitionReferenceResponseOutputWithContext(context.Background())
}

func (i PolicyDefinitionReferenceResponseArgs) ToPolicyDefinitionReferenceResponseOutputWithContext(ctx context.Context) PolicyDefinitionReferenceResponseOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PolicyDefinitionReferenceResponseOutput)
}

// PolicyDefinitionReferenceResponseArrayInput is an input type that accepts PolicyDefinitionReferenceResponseArray and PolicyDefinitionReferenceResponseArrayOutput values.
// You can construct a concrete instance of `PolicyDefinitionReferenceResponseArrayInput` via:
//
//          PolicyDefinitionReferenceResponseArray{ PolicyDefinitionReferenceResponseArgs{...} }
type PolicyDefinitionReferenceResponseArrayInput interface {
	pulumi.Input

	ToPolicyDefinitionReferenceResponseArrayOutput() PolicyDefinitionReferenceResponseArrayOutput
	ToPolicyDefinitionReferenceResponseArrayOutputWithContext(context.Context) PolicyDefinitionReferenceResponseArrayOutput
}

type PolicyDefinitionReferenceResponseArray []PolicyDefinitionReferenceResponseInput

func (PolicyDefinitionReferenceResponseArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]PolicyDefinitionReferenceResponse)(nil)).Elem()
}

func (i PolicyDefinitionReferenceResponseArray) ToPolicyDefinitionReferenceResponseArrayOutput() PolicyDefinitionReferenceResponseArrayOutput {
	return i.ToPolicyDefinitionReferenceResponseArrayOutputWithContext(context.Background())
}

func (i PolicyDefinitionReferenceResponseArray) ToPolicyDefinitionReferenceResponseArrayOutputWithContext(ctx context.Context) PolicyDefinitionReferenceResponseArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PolicyDefinitionReferenceResponseArrayOutput)
}

// The policy definition reference.
type PolicyDefinitionReferenceResponseOutput struct{ *pulumi.OutputState }

func (PolicyDefinitionReferenceResponseOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*PolicyDefinitionReferenceResponse)(nil)).Elem()
}

func (o PolicyDefinitionReferenceResponseOutput) ToPolicyDefinitionReferenceResponseOutput() PolicyDefinitionReferenceResponseOutput {
	return o
}

func (o PolicyDefinitionReferenceResponseOutput) ToPolicyDefinitionReferenceResponseOutputWithContext(ctx context.Context) PolicyDefinitionReferenceResponseOutput {
	return o
}

// Required if a parameter is used in policy rule.
func (o PolicyDefinitionReferenceResponseOutput) Parameters() pulumi.AnyOutput {
	return o.ApplyT(func(v PolicyDefinitionReferenceResponse) interface{} { return v.Parameters }).(pulumi.AnyOutput)
}

// The ID of the policy definition or policy set definition.
func (o PolicyDefinitionReferenceResponseOutput) PolicyDefinitionId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v PolicyDefinitionReferenceResponse) *string { return v.PolicyDefinitionId }).(pulumi.StringPtrOutput)
}

type PolicyDefinitionReferenceResponseArrayOutput struct{ *pulumi.OutputState }

func (PolicyDefinitionReferenceResponseArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]PolicyDefinitionReferenceResponse)(nil)).Elem()
}

func (o PolicyDefinitionReferenceResponseArrayOutput) ToPolicyDefinitionReferenceResponseArrayOutput() PolicyDefinitionReferenceResponseArrayOutput {
	return o
}

func (o PolicyDefinitionReferenceResponseArrayOutput) ToPolicyDefinitionReferenceResponseArrayOutputWithContext(ctx context.Context) PolicyDefinitionReferenceResponseArrayOutput {
	return o
}

func (o PolicyDefinitionReferenceResponseArrayOutput) Index(i pulumi.IntInput) PolicyDefinitionReferenceResponseOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) PolicyDefinitionReferenceResponse {
		return vs[0].([]PolicyDefinitionReferenceResponse)[vs[1].(int)]
	}).(PolicyDefinitionReferenceResponseOutput)
}

// The policy sku. This property is optional, obsolete, and will be ignored.
type PolicySku struct {
	// The name of the policy sku. Possible values are A0 and A1.
	Name string `pulumi:"name"`
	// The policy sku tier. Possible values are Free and Standard.
	Tier *string `pulumi:"tier"`
}

// PolicySkuInput is an input type that accepts PolicySkuArgs and PolicySkuOutput values.
// You can construct a concrete instance of `PolicySkuInput` via:
//
//          PolicySkuArgs{...}
type PolicySkuInput interface {
	pulumi.Input

	ToPolicySkuOutput() PolicySkuOutput
	ToPolicySkuOutputWithContext(context.Context) PolicySkuOutput
}

// The policy sku. This property is optional, obsolete, and will be ignored.
type PolicySkuArgs struct {
	// The name of the policy sku. Possible values are A0 and A1.
	Name pulumi.StringInput `pulumi:"name"`
	// The policy sku tier. Possible values are Free and Standard.
	Tier pulumi.StringPtrInput `pulumi:"tier"`
}

func (PolicySkuArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*PolicySku)(nil)).Elem()
}

func (i PolicySkuArgs) ToPolicySkuOutput() PolicySkuOutput {
	return i.ToPolicySkuOutputWithContext(context.Background())
}

func (i PolicySkuArgs) ToPolicySkuOutputWithContext(ctx context.Context) PolicySkuOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PolicySkuOutput)
}

func (i PolicySkuArgs) ToPolicySkuPtrOutput() PolicySkuPtrOutput {
	return i.ToPolicySkuPtrOutputWithContext(context.Background())
}

func (i PolicySkuArgs) ToPolicySkuPtrOutputWithContext(ctx context.Context) PolicySkuPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PolicySkuOutput).ToPolicySkuPtrOutputWithContext(ctx)
}

// PolicySkuPtrInput is an input type that accepts PolicySkuArgs, PolicySkuPtr and PolicySkuPtrOutput values.
// You can construct a concrete instance of `PolicySkuPtrInput` via:
//
//          PolicySkuArgs{...}
//
//  or:
//
//          nil
type PolicySkuPtrInput interface {
	pulumi.Input

	ToPolicySkuPtrOutput() PolicySkuPtrOutput
	ToPolicySkuPtrOutputWithContext(context.Context) PolicySkuPtrOutput
}

type policySkuPtrType PolicySkuArgs

func PolicySkuPtr(v *PolicySkuArgs) PolicySkuPtrInput {
	return (*policySkuPtrType)(v)
}

func (*policySkuPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**PolicySku)(nil)).Elem()
}

func (i *policySkuPtrType) ToPolicySkuPtrOutput() PolicySkuPtrOutput {
	return i.ToPolicySkuPtrOutputWithContext(context.Background())
}

func (i *policySkuPtrType) ToPolicySkuPtrOutputWithContext(ctx context.Context) PolicySkuPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PolicySkuPtrOutput)
}

// The policy sku. This property is optional, obsolete, and will be ignored.
type PolicySkuOutput struct{ *pulumi.OutputState }

func (PolicySkuOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*PolicySku)(nil)).Elem()
}

func (o PolicySkuOutput) ToPolicySkuOutput() PolicySkuOutput {
	return o
}

func (o PolicySkuOutput) ToPolicySkuOutputWithContext(ctx context.Context) PolicySkuOutput {
	return o
}

func (o PolicySkuOutput) ToPolicySkuPtrOutput() PolicySkuPtrOutput {
	return o.ToPolicySkuPtrOutputWithContext(context.Background())
}

func (o PolicySkuOutput) ToPolicySkuPtrOutputWithContext(ctx context.Context) PolicySkuPtrOutput {
	return o.ApplyT(func(v PolicySku) *PolicySku {
		return &v
	}).(PolicySkuPtrOutput)
}

// The name of the policy sku. Possible values are A0 and A1.
func (o PolicySkuOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v PolicySku) string { return v.Name }).(pulumi.StringOutput)
}

// The policy sku tier. Possible values are Free and Standard.
func (o PolicySkuOutput) Tier() pulumi.StringPtrOutput {
	return o.ApplyT(func(v PolicySku) *string { return v.Tier }).(pulumi.StringPtrOutput)
}

type PolicySkuPtrOutput struct{ *pulumi.OutputState }

func (PolicySkuPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**PolicySku)(nil)).Elem()
}

func (o PolicySkuPtrOutput) ToPolicySkuPtrOutput() PolicySkuPtrOutput {
	return o
}

func (o PolicySkuPtrOutput) ToPolicySkuPtrOutputWithContext(ctx context.Context) PolicySkuPtrOutput {
	return o
}

func (o PolicySkuPtrOutput) Elem() PolicySkuOutput {
	return o.ApplyT(func(v *PolicySku) PolicySku { return *v }).(PolicySkuOutput)
}

// The name of the policy sku. Possible values are A0 and A1.
func (o PolicySkuPtrOutput) Name() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *PolicySku) *string {
		if v == nil {
			return nil
		}
		return &v.Name
	}).(pulumi.StringPtrOutput)
}

// The policy sku tier. Possible values are Free and Standard.
func (o PolicySkuPtrOutput) Tier() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *PolicySku) *string {
		if v == nil {
			return nil
		}
		return v.Tier
	}).(pulumi.StringPtrOutput)
}

// The policy sku. This property is optional, obsolete, and will be ignored.
type PolicySkuResponse struct {
	// The name of the policy sku. Possible values are A0 and A1.
	Name string `pulumi:"name"`
	// The policy sku tier. Possible values are Free and Standard.
	Tier *string `pulumi:"tier"`
}

// PolicySkuResponseInput is an input type that accepts PolicySkuResponseArgs and PolicySkuResponseOutput values.
// You can construct a concrete instance of `PolicySkuResponseInput` via:
//
//          PolicySkuResponseArgs{...}
type PolicySkuResponseInput interface {
	pulumi.Input

	ToPolicySkuResponseOutput() PolicySkuResponseOutput
	ToPolicySkuResponseOutputWithContext(context.Context) PolicySkuResponseOutput
}

// The policy sku. This property is optional, obsolete, and will be ignored.
type PolicySkuResponseArgs struct {
	// The name of the policy sku. Possible values are A0 and A1.
	Name pulumi.StringInput `pulumi:"name"`
	// The policy sku tier. Possible values are Free and Standard.
	Tier pulumi.StringPtrInput `pulumi:"tier"`
}

func (PolicySkuResponseArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*PolicySkuResponse)(nil)).Elem()
}

func (i PolicySkuResponseArgs) ToPolicySkuResponseOutput() PolicySkuResponseOutput {
	return i.ToPolicySkuResponseOutputWithContext(context.Background())
}

func (i PolicySkuResponseArgs) ToPolicySkuResponseOutputWithContext(ctx context.Context) PolicySkuResponseOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PolicySkuResponseOutput)
}

func (i PolicySkuResponseArgs) ToPolicySkuResponsePtrOutput() PolicySkuResponsePtrOutput {
	return i.ToPolicySkuResponsePtrOutputWithContext(context.Background())
}

func (i PolicySkuResponseArgs) ToPolicySkuResponsePtrOutputWithContext(ctx context.Context) PolicySkuResponsePtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PolicySkuResponseOutput).ToPolicySkuResponsePtrOutputWithContext(ctx)
}

// PolicySkuResponsePtrInput is an input type that accepts PolicySkuResponseArgs, PolicySkuResponsePtr and PolicySkuResponsePtrOutput values.
// You can construct a concrete instance of `PolicySkuResponsePtrInput` via:
//
//          PolicySkuResponseArgs{...}
//
//  or:
//
//          nil
type PolicySkuResponsePtrInput interface {
	pulumi.Input

	ToPolicySkuResponsePtrOutput() PolicySkuResponsePtrOutput
	ToPolicySkuResponsePtrOutputWithContext(context.Context) PolicySkuResponsePtrOutput
}

type policySkuResponsePtrType PolicySkuResponseArgs

func PolicySkuResponsePtr(v *PolicySkuResponseArgs) PolicySkuResponsePtrInput {
	return (*policySkuResponsePtrType)(v)
}

func (*policySkuResponsePtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**PolicySkuResponse)(nil)).Elem()
}

func (i *policySkuResponsePtrType) ToPolicySkuResponsePtrOutput() PolicySkuResponsePtrOutput {
	return i.ToPolicySkuResponsePtrOutputWithContext(context.Background())
}

func (i *policySkuResponsePtrType) ToPolicySkuResponsePtrOutputWithContext(ctx context.Context) PolicySkuResponsePtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PolicySkuResponsePtrOutput)
}

// The policy sku. This property is optional, obsolete, and will be ignored.
type PolicySkuResponseOutput struct{ *pulumi.OutputState }

func (PolicySkuResponseOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*PolicySkuResponse)(nil)).Elem()
}

func (o PolicySkuResponseOutput) ToPolicySkuResponseOutput() PolicySkuResponseOutput {
	return o
}

func (o PolicySkuResponseOutput) ToPolicySkuResponseOutputWithContext(ctx context.Context) PolicySkuResponseOutput {
	return o
}

func (o PolicySkuResponseOutput) ToPolicySkuResponsePtrOutput() PolicySkuResponsePtrOutput {
	return o.ToPolicySkuResponsePtrOutputWithContext(context.Background())
}

func (o PolicySkuResponseOutput) ToPolicySkuResponsePtrOutputWithContext(ctx context.Context) PolicySkuResponsePtrOutput {
	return o.ApplyT(func(v PolicySkuResponse) *PolicySkuResponse {
		return &v
	}).(PolicySkuResponsePtrOutput)
}

// The name of the policy sku. Possible values are A0 and A1.
func (o PolicySkuResponseOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v PolicySkuResponse) string { return v.Name }).(pulumi.StringOutput)
}

// The policy sku tier. Possible values are Free and Standard.
func (o PolicySkuResponseOutput) Tier() pulumi.StringPtrOutput {
	return o.ApplyT(func(v PolicySkuResponse) *string { return v.Tier }).(pulumi.StringPtrOutput)
}

type PolicySkuResponsePtrOutput struct{ *pulumi.OutputState }

func (PolicySkuResponsePtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**PolicySkuResponse)(nil)).Elem()
}

func (o PolicySkuResponsePtrOutput) ToPolicySkuResponsePtrOutput() PolicySkuResponsePtrOutput {
	return o
}

func (o PolicySkuResponsePtrOutput) ToPolicySkuResponsePtrOutputWithContext(ctx context.Context) PolicySkuResponsePtrOutput {
	return o
}

func (o PolicySkuResponsePtrOutput) Elem() PolicySkuResponseOutput {
	return o.ApplyT(func(v *PolicySkuResponse) PolicySkuResponse { return *v }).(PolicySkuResponseOutput)
}

// The name of the policy sku. Possible values are A0 and A1.
func (o PolicySkuResponsePtrOutput) Name() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *PolicySkuResponse) *string {
		if v == nil {
			return nil
		}
		return &v.Name
	}).(pulumi.StringPtrOutput)
}

// The policy sku tier. Possible values are Free and Standard.
func (o PolicySkuResponsePtrOutput) Tier() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *PolicySkuResponse) *string {
		if v == nil {
			return nil
		}
		return v.Tier
	}).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(IdentityOutput{})
	pulumi.RegisterOutputType(IdentityPtrOutput{})
	pulumi.RegisterOutputType(IdentityResponseOutput{})
	pulumi.RegisterOutputType(IdentityResponsePtrOutput{})
	pulumi.RegisterOutputType(PolicyDefinitionReferenceOutput{})
	pulumi.RegisterOutputType(PolicyDefinitionReferenceArrayOutput{})
	pulumi.RegisterOutputType(PolicyDefinitionReferenceResponseOutput{})
	pulumi.RegisterOutputType(PolicyDefinitionReferenceResponseArrayOutput{})
	pulumi.RegisterOutputType(PolicySkuOutput{})
	pulumi.RegisterOutputType(PolicySkuPtrOutput{})
	pulumi.RegisterOutputType(PolicySkuResponseOutput{})
	pulumi.RegisterOutputType(PolicySkuResponsePtrOutput{})
}

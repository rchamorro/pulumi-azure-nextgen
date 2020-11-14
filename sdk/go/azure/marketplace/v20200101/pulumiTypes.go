// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200101

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Icon File Uris
type OfferPropertiesIconFileUris struct {
	// Icon size
	IconKind *string `pulumi:"iconKind"`
	// Icon uri
	Uri *string `pulumi:"uri"`
}

// OfferPropertiesIconFileUrisInput is an input type that accepts OfferPropertiesIconFileUrisArgs and OfferPropertiesIconFileUrisOutput values.
// You can construct a concrete instance of `OfferPropertiesIconFileUrisInput` via:
//
//          OfferPropertiesIconFileUrisArgs{...}
type OfferPropertiesIconFileUrisInput interface {
	pulumi.Input

	ToOfferPropertiesIconFileUrisOutput() OfferPropertiesIconFileUrisOutput
	ToOfferPropertiesIconFileUrisOutputWithContext(context.Context) OfferPropertiesIconFileUrisOutput
}

// Icon File Uris
type OfferPropertiesIconFileUrisArgs struct {
	// Icon size
	IconKind pulumi.StringPtrInput `pulumi:"iconKind"`
	// Icon uri
	Uri pulumi.StringPtrInput `pulumi:"uri"`
}

func (OfferPropertiesIconFileUrisArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*OfferPropertiesIconFileUris)(nil)).Elem()
}

func (i OfferPropertiesIconFileUrisArgs) ToOfferPropertiesIconFileUrisOutput() OfferPropertiesIconFileUrisOutput {
	return i.ToOfferPropertiesIconFileUrisOutputWithContext(context.Background())
}

func (i OfferPropertiesIconFileUrisArgs) ToOfferPropertiesIconFileUrisOutputWithContext(ctx context.Context) OfferPropertiesIconFileUrisOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OfferPropertiesIconFileUrisOutput)
}

func (i OfferPropertiesIconFileUrisArgs) ToOfferPropertiesIconFileUrisPtrOutput() OfferPropertiesIconFileUrisPtrOutput {
	return i.ToOfferPropertiesIconFileUrisPtrOutputWithContext(context.Background())
}

func (i OfferPropertiesIconFileUrisArgs) ToOfferPropertiesIconFileUrisPtrOutputWithContext(ctx context.Context) OfferPropertiesIconFileUrisPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OfferPropertiesIconFileUrisOutput).ToOfferPropertiesIconFileUrisPtrOutputWithContext(ctx)
}

// OfferPropertiesIconFileUrisPtrInput is an input type that accepts OfferPropertiesIconFileUrisArgs, OfferPropertiesIconFileUrisPtr and OfferPropertiesIconFileUrisPtrOutput values.
// You can construct a concrete instance of `OfferPropertiesIconFileUrisPtrInput` via:
//
//          OfferPropertiesIconFileUrisArgs{...}
//
//  or:
//
//          nil
type OfferPropertiesIconFileUrisPtrInput interface {
	pulumi.Input

	ToOfferPropertiesIconFileUrisPtrOutput() OfferPropertiesIconFileUrisPtrOutput
	ToOfferPropertiesIconFileUrisPtrOutputWithContext(context.Context) OfferPropertiesIconFileUrisPtrOutput
}

type offerPropertiesIconFileUrisPtrType OfferPropertiesIconFileUrisArgs

func OfferPropertiesIconFileUrisPtr(v *OfferPropertiesIconFileUrisArgs) OfferPropertiesIconFileUrisPtrInput {
	return (*offerPropertiesIconFileUrisPtrType)(v)
}

func (*offerPropertiesIconFileUrisPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**OfferPropertiesIconFileUris)(nil)).Elem()
}

func (i *offerPropertiesIconFileUrisPtrType) ToOfferPropertiesIconFileUrisPtrOutput() OfferPropertiesIconFileUrisPtrOutput {
	return i.ToOfferPropertiesIconFileUrisPtrOutputWithContext(context.Background())
}

func (i *offerPropertiesIconFileUrisPtrType) ToOfferPropertiesIconFileUrisPtrOutputWithContext(ctx context.Context) OfferPropertiesIconFileUrisPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OfferPropertiesIconFileUrisPtrOutput)
}

// Icon File Uris
type OfferPropertiesIconFileUrisOutput struct{ *pulumi.OutputState }

func (OfferPropertiesIconFileUrisOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*OfferPropertiesIconFileUris)(nil)).Elem()
}

func (o OfferPropertiesIconFileUrisOutput) ToOfferPropertiesIconFileUrisOutput() OfferPropertiesIconFileUrisOutput {
	return o
}

func (o OfferPropertiesIconFileUrisOutput) ToOfferPropertiesIconFileUrisOutputWithContext(ctx context.Context) OfferPropertiesIconFileUrisOutput {
	return o
}

func (o OfferPropertiesIconFileUrisOutput) ToOfferPropertiesIconFileUrisPtrOutput() OfferPropertiesIconFileUrisPtrOutput {
	return o.ToOfferPropertiesIconFileUrisPtrOutputWithContext(context.Background())
}

func (o OfferPropertiesIconFileUrisOutput) ToOfferPropertiesIconFileUrisPtrOutputWithContext(ctx context.Context) OfferPropertiesIconFileUrisPtrOutput {
	return o.ApplyT(func(v OfferPropertiesIconFileUris) *OfferPropertiesIconFileUris {
		return &v
	}).(OfferPropertiesIconFileUrisPtrOutput)
}

// Icon size
func (o OfferPropertiesIconFileUrisOutput) IconKind() pulumi.StringPtrOutput {
	return o.ApplyT(func(v OfferPropertiesIconFileUris) *string { return v.IconKind }).(pulumi.StringPtrOutput)
}

// Icon uri
func (o OfferPropertiesIconFileUrisOutput) Uri() pulumi.StringPtrOutput {
	return o.ApplyT(func(v OfferPropertiesIconFileUris) *string { return v.Uri }).(pulumi.StringPtrOutput)
}

type OfferPropertiesIconFileUrisPtrOutput struct{ *pulumi.OutputState }

func (OfferPropertiesIconFileUrisPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**OfferPropertiesIconFileUris)(nil)).Elem()
}

func (o OfferPropertiesIconFileUrisPtrOutput) ToOfferPropertiesIconFileUrisPtrOutput() OfferPropertiesIconFileUrisPtrOutput {
	return o
}

func (o OfferPropertiesIconFileUrisPtrOutput) ToOfferPropertiesIconFileUrisPtrOutputWithContext(ctx context.Context) OfferPropertiesIconFileUrisPtrOutput {
	return o
}

func (o OfferPropertiesIconFileUrisPtrOutput) Elem() OfferPropertiesIconFileUrisOutput {
	return o.ApplyT(func(v *OfferPropertiesIconFileUris) OfferPropertiesIconFileUris { return *v }).(OfferPropertiesIconFileUrisOutput)
}

// Icon size
func (o OfferPropertiesIconFileUrisPtrOutput) IconKind() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *OfferPropertiesIconFileUris) *string {
		if v == nil {
			return nil
		}
		return v.IconKind
	}).(pulumi.StringPtrOutput)
}

// Icon uri
func (o OfferPropertiesIconFileUrisPtrOutput) Uri() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *OfferPropertiesIconFileUris) *string {
		if v == nil {
			return nil
		}
		return v.Uri
	}).(pulumi.StringPtrOutput)
}

// Icon File Uris
type OfferPropertiesResponseIconFileUris struct {
	// Icon size
	IconKind *string `pulumi:"iconKind"`
	// Icon uri
	Uri *string `pulumi:"uri"`
}

// OfferPropertiesResponseIconFileUrisInput is an input type that accepts OfferPropertiesResponseIconFileUrisArgs and OfferPropertiesResponseIconFileUrisOutput values.
// You can construct a concrete instance of `OfferPropertiesResponseIconFileUrisInput` via:
//
//          OfferPropertiesResponseIconFileUrisArgs{...}
type OfferPropertiesResponseIconFileUrisInput interface {
	pulumi.Input

	ToOfferPropertiesResponseIconFileUrisOutput() OfferPropertiesResponseIconFileUrisOutput
	ToOfferPropertiesResponseIconFileUrisOutputWithContext(context.Context) OfferPropertiesResponseIconFileUrisOutput
}

// Icon File Uris
type OfferPropertiesResponseIconFileUrisArgs struct {
	// Icon size
	IconKind pulumi.StringPtrInput `pulumi:"iconKind"`
	// Icon uri
	Uri pulumi.StringPtrInput `pulumi:"uri"`
}

func (OfferPropertiesResponseIconFileUrisArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*OfferPropertiesResponseIconFileUris)(nil)).Elem()
}

func (i OfferPropertiesResponseIconFileUrisArgs) ToOfferPropertiesResponseIconFileUrisOutput() OfferPropertiesResponseIconFileUrisOutput {
	return i.ToOfferPropertiesResponseIconFileUrisOutputWithContext(context.Background())
}

func (i OfferPropertiesResponseIconFileUrisArgs) ToOfferPropertiesResponseIconFileUrisOutputWithContext(ctx context.Context) OfferPropertiesResponseIconFileUrisOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OfferPropertiesResponseIconFileUrisOutput)
}

func (i OfferPropertiesResponseIconFileUrisArgs) ToOfferPropertiesResponseIconFileUrisPtrOutput() OfferPropertiesResponseIconFileUrisPtrOutput {
	return i.ToOfferPropertiesResponseIconFileUrisPtrOutputWithContext(context.Background())
}

func (i OfferPropertiesResponseIconFileUrisArgs) ToOfferPropertiesResponseIconFileUrisPtrOutputWithContext(ctx context.Context) OfferPropertiesResponseIconFileUrisPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OfferPropertiesResponseIconFileUrisOutput).ToOfferPropertiesResponseIconFileUrisPtrOutputWithContext(ctx)
}

// OfferPropertiesResponseIconFileUrisPtrInput is an input type that accepts OfferPropertiesResponseIconFileUrisArgs, OfferPropertiesResponseIconFileUrisPtr and OfferPropertiesResponseIconFileUrisPtrOutput values.
// You can construct a concrete instance of `OfferPropertiesResponseIconFileUrisPtrInput` via:
//
//          OfferPropertiesResponseIconFileUrisArgs{...}
//
//  or:
//
//          nil
type OfferPropertiesResponseIconFileUrisPtrInput interface {
	pulumi.Input

	ToOfferPropertiesResponseIconFileUrisPtrOutput() OfferPropertiesResponseIconFileUrisPtrOutput
	ToOfferPropertiesResponseIconFileUrisPtrOutputWithContext(context.Context) OfferPropertiesResponseIconFileUrisPtrOutput
}

type offerPropertiesResponseIconFileUrisPtrType OfferPropertiesResponseIconFileUrisArgs

func OfferPropertiesResponseIconFileUrisPtr(v *OfferPropertiesResponseIconFileUrisArgs) OfferPropertiesResponseIconFileUrisPtrInput {
	return (*offerPropertiesResponseIconFileUrisPtrType)(v)
}

func (*offerPropertiesResponseIconFileUrisPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**OfferPropertiesResponseIconFileUris)(nil)).Elem()
}

func (i *offerPropertiesResponseIconFileUrisPtrType) ToOfferPropertiesResponseIconFileUrisPtrOutput() OfferPropertiesResponseIconFileUrisPtrOutput {
	return i.ToOfferPropertiesResponseIconFileUrisPtrOutputWithContext(context.Background())
}

func (i *offerPropertiesResponseIconFileUrisPtrType) ToOfferPropertiesResponseIconFileUrisPtrOutputWithContext(ctx context.Context) OfferPropertiesResponseIconFileUrisPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OfferPropertiesResponseIconFileUrisPtrOutput)
}

// Icon File Uris
type OfferPropertiesResponseIconFileUrisOutput struct{ *pulumi.OutputState }

func (OfferPropertiesResponseIconFileUrisOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*OfferPropertiesResponseIconFileUris)(nil)).Elem()
}

func (o OfferPropertiesResponseIconFileUrisOutput) ToOfferPropertiesResponseIconFileUrisOutput() OfferPropertiesResponseIconFileUrisOutput {
	return o
}

func (o OfferPropertiesResponseIconFileUrisOutput) ToOfferPropertiesResponseIconFileUrisOutputWithContext(ctx context.Context) OfferPropertiesResponseIconFileUrisOutput {
	return o
}

func (o OfferPropertiesResponseIconFileUrisOutput) ToOfferPropertiesResponseIconFileUrisPtrOutput() OfferPropertiesResponseIconFileUrisPtrOutput {
	return o.ToOfferPropertiesResponseIconFileUrisPtrOutputWithContext(context.Background())
}

func (o OfferPropertiesResponseIconFileUrisOutput) ToOfferPropertiesResponseIconFileUrisPtrOutputWithContext(ctx context.Context) OfferPropertiesResponseIconFileUrisPtrOutput {
	return o.ApplyT(func(v OfferPropertiesResponseIconFileUris) *OfferPropertiesResponseIconFileUris {
		return &v
	}).(OfferPropertiesResponseIconFileUrisPtrOutput)
}

// Icon size
func (o OfferPropertiesResponseIconFileUrisOutput) IconKind() pulumi.StringPtrOutput {
	return o.ApplyT(func(v OfferPropertiesResponseIconFileUris) *string { return v.IconKind }).(pulumi.StringPtrOutput)
}

// Icon uri
func (o OfferPropertiesResponseIconFileUrisOutput) Uri() pulumi.StringPtrOutput {
	return o.ApplyT(func(v OfferPropertiesResponseIconFileUris) *string { return v.Uri }).(pulumi.StringPtrOutput)
}

type OfferPropertiesResponseIconFileUrisPtrOutput struct{ *pulumi.OutputState }

func (OfferPropertiesResponseIconFileUrisPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**OfferPropertiesResponseIconFileUris)(nil)).Elem()
}

func (o OfferPropertiesResponseIconFileUrisPtrOutput) ToOfferPropertiesResponseIconFileUrisPtrOutput() OfferPropertiesResponseIconFileUrisPtrOutput {
	return o
}

func (o OfferPropertiesResponseIconFileUrisPtrOutput) ToOfferPropertiesResponseIconFileUrisPtrOutputWithContext(ctx context.Context) OfferPropertiesResponseIconFileUrisPtrOutput {
	return o
}

func (o OfferPropertiesResponseIconFileUrisPtrOutput) Elem() OfferPropertiesResponseIconFileUrisOutput {
	return o.ApplyT(func(v *OfferPropertiesResponseIconFileUris) OfferPropertiesResponseIconFileUris { return *v }).(OfferPropertiesResponseIconFileUrisOutput)
}

// Icon size
func (o OfferPropertiesResponseIconFileUrisPtrOutput) IconKind() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *OfferPropertiesResponseIconFileUris) *string {
		if v == nil {
			return nil
		}
		return v.IconKind
	}).(pulumi.StringPtrOutput)
}

// Icon uri
func (o OfferPropertiesResponseIconFileUrisPtrOutput) Uri() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *OfferPropertiesResponseIconFileUris) *string {
		if v == nil {
			return nil
		}
		return v.Uri
	}).(pulumi.StringPtrOutput)
}

type Plan struct {
	// Plan accessibility
	Accessibility *string `pulumi:"accessibility"`
}

// PlanInput is an input type that accepts PlanArgs and PlanOutput values.
// You can construct a concrete instance of `PlanInput` via:
//
//          PlanArgs{...}
type PlanInput interface {
	pulumi.Input

	ToPlanOutput() PlanOutput
	ToPlanOutputWithContext(context.Context) PlanOutput
}

type PlanArgs struct {
	// Plan accessibility
	Accessibility pulumi.StringPtrInput `pulumi:"accessibility"`
}

func (PlanArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*Plan)(nil)).Elem()
}

func (i PlanArgs) ToPlanOutput() PlanOutput {
	return i.ToPlanOutputWithContext(context.Background())
}

func (i PlanArgs) ToPlanOutputWithContext(ctx context.Context) PlanOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PlanOutput)
}

// PlanArrayInput is an input type that accepts PlanArray and PlanArrayOutput values.
// You can construct a concrete instance of `PlanArrayInput` via:
//
//          PlanArray{ PlanArgs{...} }
type PlanArrayInput interface {
	pulumi.Input

	ToPlanArrayOutput() PlanArrayOutput
	ToPlanArrayOutputWithContext(context.Context) PlanArrayOutput
}

type PlanArray []PlanInput

func (PlanArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]Plan)(nil)).Elem()
}

func (i PlanArray) ToPlanArrayOutput() PlanArrayOutput {
	return i.ToPlanArrayOutputWithContext(context.Background())
}

func (i PlanArray) ToPlanArrayOutputWithContext(ctx context.Context) PlanArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PlanArrayOutput)
}

type PlanOutput struct{ *pulumi.OutputState }

func (PlanOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Plan)(nil)).Elem()
}

func (o PlanOutput) ToPlanOutput() PlanOutput {
	return o
}

func (o PlanOutput) ToPlanOutputWithContext(ctx context.Context) PlanOutput {
	return o
}

// Plan accessibility
func (o PlanOutput) Accessibility() pulumi.StringPtrOutput {
	return o.ApplyT(func(v Plan) *string { return v.Accessibility }).(pulumi.StringPtrOutput)
}

type PlanArrayOutput struct{ *pulumi.OutputState }

func (PlanArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]Plan)(nil)).Elem()
}

func (o PlanArrayOutput) ToPlanArrayOutput() PlanArrayOutput {
	return o
}

func (o PlanArrayOutput) ToPlanArrayOutputWithContext(ctx context.Context) PlanArrayOutput {
	return o
}

func (o PlanArrayOutput) Index(i pulumi.IntInput) PlanOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) Plan {
		return vs[0].([]Plan)[vs[1].(int)]
	}).(PlanOutput)
}

type PlanResponse struct {
	// Plan accessibility
	Accessibility *string `pulumi:"accessibility"`
	// Alternative stack type
	AltStackReference string `pulumi:"altStackReference"`
	// Friendly name for the plan for display in the marketplace
	PlanDisplayName string `pulumi:"planDisplayName"`
	// Text identifier for this plan
	PlanId string `pulumi:"planId"`
	// Identifier for this plan
	SkuId string `pulumi:"skuId"`
	// Stack type (classic or arm)
	StackType string `pulumi:"stackType"`
}

// PlanResponseInput is an input type that accepts PlanResponseArgs and PlanResponseOutput values.
// You can construct a concrete instance of `PlanResponseInput` via:
//
//          PlanResponseArgs{...}
type PlanResponseInput interface {
	pulumi.Input

	ToPlanResponseOutput() PlanResponseOutput
	ToPlanResponseOutputWithContext(context.Context) PlanResponseOutput
}

type PlanResponseArgs struct {
	// Plan accessibility
	Accessibility pulumi.StringPtrInput `pulumi:"accessibility"`
	// Alternative stack type
	AltStackReference pulumi.StringInput `pulumi:"altStackReference"`
	// Friendly name for the plan for display in the marketplace
	PlanDisplayName pulumi.StringInput `pulumi:"planDisplayName"`
	// Text identifier for this plan
	PlanId pulumi.StringInput `pulumi:"planId"`
	// Identifier for this plan
	SkuId pulumi.StringInput `pulumi:"skuId"`
	// Stack type (classic or arm)
	StackType pulumi.StringInput `pulumi:"stackType"`
}

func (PlanResponseArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*PlanResponse)(nil)).Elem()
}

func (i PlanResponseArgs) ToPlanResponseOutput() PlanResponseOutput {
	return i.ToPlanResponseOutputWithContext(context.Background())
}

func (i PlanResponseArgs) ToPlanResponseOutputWithContext(ctx context.Context) PlanResponseOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PlanResponseOutput)
}

// PlanResponseArrayInput is an input type that accepts PlanResponseArray and PlanResponseArrayOutput values.
// You can construct a concrete instance of `PlanResponseArrayInput` via:
//
//          PlanResponseArray{ PlanResponseArgs{...} }
type PlanResponseArrayInput interface {
	pulumi.Input

	ToPlanResponseArrayOutput() PlanResponseArrayOutput
	ToPlanResponseArrayOutputWithContext(context.Context) PlanResponseArrayOutput
}

type PlanResponseArray []PlanResponseInput

func (PlanResponseArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]PlanResponse)(nil)).Elem()
}

func (i PlanResponseArray) ToPlanResponseArrayOutput() PlanResponseArrayOutput {
	return i.ToPlanResponseArrayOutputWithContext(context.Background())
}

func (i PlanResponseArray) ToPlanResponseArrayOutputWithContext(ctx context.Context) PlanResponseArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PlanResponseArrayOutput)
}

type PlanResponseOutput struct{ *pulumi.OutputState }

func (PlanResponseOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*PlanResponse)(nil)).Elem()
}

func (o PlanResponseOutput) ToPlanResponseOutput() PlanResponseOutput {
	return o
}

func (o PlanResponseOutput) ToPlanResponseOutputWithContext(ctx context.Context) PlanResponseOutput {
	return o
}

// Plan accessibility
func (o PlanResponseOutput) Accessibility() pulumi.StringPtrOutput {
	return o.ApplyT(func(v PlanResponse) *string { return v.Accessibility }).(pulumi.StringPtrOutput)
}

// Alternative stack type
func (o PlanResponseOutput) AltStackReference() pulumi.StringOutput {
	return o.ApplyT(func(v PlanResponse) string { return v.AltStackReference }).(pulumi.StringOutput)
}

// Friendly name for the plan for display in the marketplace
func (o PlanResponseOutput) PlanDisplayName() pulumi.StringOutput {
	return o.ApplyT(func(v PlanResponse) string { return v.PlanDisplayName }).(pulumi.StringOutput)
}

// Text identifier for this plan
func (o PlanResponseOutput) PlanId() pulumi.StringOutput {
	return o.ApplyT(func(v PlanResponse) string { return v.PlanId }).(pulumi.StringOutput)
}

// Identifier for this plan
func (o PlanResponseOutput) SkuId() pulumi.StringOutput {
	return o.ApplyT(func(v PlanResponse) string { return v.SkuId }).(pulumi.StringOutput)
}

// Stack type (classic or arm)
func (o PlanResponseOutput) StackType() pulumi.StringOutput {
	return o.ApplyT(func(v PlanResponse) string { return v.StackType }).(pulumi.StringOutput)
}

type PlanResponseArrayOutput struct{ *pulumi.OutputState }

func (PlanResponseArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]PlanResponse)(nil)).Elem()
}

func (o PlanResponseArrayOutput) ToPlanResponseArrayOutput() PlanResponseArrayOutput {
	return o
}

func (o PlanResponseArrayOutput) ToPlanResponseArrayOutputWithContext(ctx context.Context) PlanResponseArrayOutput {
	return o
}

func (o PlanResponseArrayOutput) Index(i pulumi.IntInput) PlanResponseOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) PlanResponse {
		return vs[0].([]PlanResponse)[vs[1].(int)]
	}).(PlanResponseOutput)
}

func init() {
	pulumi.RegisterOutputType(OfferPropertiesIconFileUrisOutput{})
	pulumi.RegisterOutputType(OfferPropertiesIconFileUrisPtrOutput{})
	pulumi.RegisterOutputType(OfferPropertiesResponseIconFileUrisOutput{})
	pulumi.RegisterOutputType(OfferPropertiesResponseIconFileUrisPtrOutput{})
	pulumi.RegisterOutputType(PlanOutput{})
	pulumi.RegisterOutputType(PlanArrayOutput{})
	pulumi.RegisterOutputType(PlanResponseOutput{})
	pulumi.RegisterOutputType(PlanResponseArrayOutput{})
}

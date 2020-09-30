// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20190601preview

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

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

// Represents a Template Spec artifact containing an embedded Azure Resource Manager template.
type TemplateSpecTemplateArtifact struct {
	// The kind of artifact.
	Kind string `pulumi:"kind"`
	// A filesystem safe relative path of the artifact.
	Path string `pulumi:"path"`
	// The Azure Resource Manager template.
	Template interface{} `pulumi:"template"`
}

// TemplateSpecTemplateArtifactInput is an input type that accepts TemplateSpecTemplateArtifactArgs and TemplateSpecTemplateArtifactOutput values.
// You can construct a concrete instance of `TemplateSpecTemplateArtifactInput` via:
//
//          TemplateSpecTemplateArtifactArgs{...}
type TemplateSpecTemplateArtifactInput interface {
	pulumi.Input

	ToTemplateSpecTemplateArtifactOutput() TemplateSpecTemplateArtifactOutput
	ToTemplateSpecTemplateArtifactOutputWithContext(context.Context) TemplateSpecTemplateArtifactOutput
}

// Represents a Template Spec artifact containing an embedded Azure Resource Manager template.
type TemplateSpecTemplateArtifactArgs struct {
	// The kind of artifact.
	Kind pulumi.StringInput `pulumi:"kind"`
	// A filesystem safe relative path of the artifact.
	Path pulumi.StringInput `pulumi:"path"`
	// The Azure Resource Manager template.
	Template pulumi.Input `pulumi:"template"`
}

func (TemplateSpecTemplateArtifactArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*TemplateSpecTemplateArtifact)(nil)).Elem()
}

func (i TemplateSpecTemplateArtifactArgs) ToTemplateSpecTemplateArtifactOutput() TemplateSpecTemplateArtifactOutput {
	return i.ToTemplateSpecTemplateArtifactOutputWithContext(context.Background())
}

func (i TemplateSpecTemplateArtifactArgs) ToTemplateSpecTemplateArtifactOutputWithContext(ctx context.Context) TemplateSpecTemplateArtifactOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TemplateSpecTemplateArtifactOutput)
}

// TemplateSpecTemplateArtifactArrayInput is an input type that accepts TemplateSpecTemplateArtifactArray and TemplateSpecTemplateArtifactArrayOutput values.
// You can construct a concrete instance of `TemplateSpecTemplateArtifactArrayInput` via:
//
//          TemplateSpecTemplateArtifactArray{ TemplateSpecTemplateArtifactArgs{...} }
type TemplateSpecTemplateArtifactArrayInput interface {
	pulumi.Input

	ToTemplateSpecTemplateArtifactArrayOutput() TemplateSpecTemplateArtifactArrayOutput
	ToTemplateSpecTemplateArtifactArrayOutputWithContext(context.Context) TemplateSpecTemplateArtifactArrayOutput
}

type TemplateSpecTemplateArtifactArray []TemplateSpecTemplateArtifactInput

func (TemplateSpecTemplateArtifactArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]TemplateSpecTemplateArtifact)(nil)).Elem()
}

func (i TemplateSpecTemplateArtifactArray) ToTemplateSpecTemplateArtifactArrayOutput() TemplateSpecTemplateArtifactArrayOutput {
	return i.ToTemplateSpecTemplateArtifactArrayOutputWithContext(context.Background())
}

func (i TemplateSpecTemplateArtifactArray) ToTemplateSpecTemplateArtifactArrayOutputWithContext(ctx context.Context) TemplateSpecTemplateArtifactArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TemplateSpecTemplateArtifactArrayOutput)
}

// Represents a Template Spec artifact containing an embedded Azure Resource Manager template.
type TemplateSpecTemplateArtifactOutput struct{ *pulumi.OutputState }

func (TemplateSpecTemplateArtifactOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*TemplateSpecTemplateArtifact)(nil)).Elem()
}

func (o TemplateSpecTemplateArtifactOutput) ToTemplateSpecTemplateArtifactOutput() TemplateSpecTemplateArtifactOutput {
	return o
}

func (o TemplateSpecTemplateArtifactOutput) ToTemplateSpecTemplateArtifactOutputWithContext(ctx context.Context) TemplateSpecTemplateArtifactOutput {
	return o
}

// The kind of artifact.
func (o TemplateSpecTemplateArtifactOutput) Kind() pulumi.StringOutput {
	return o.ApplyT(func(v TemplateSpecTemplateArtifact) string { return v.Kind }).(pulumi.StringOutput)
}

// A filesystem safe relative path of the artifact.
func (o TemplateSpecTemplateArtifactOutput) Path() pulumi.StringOutput {
	return o.ApplyT(func(v TemplateSpecTemplateArtifact) string { return v.Path }).(pulumi.StringOutput)
}

// The Azure Resource Manager template.
func (o TemplateSpecTemplateArtifactOutput) Template() pulumi.AnyOutput {
	return o.ApplyT(func(v TemplateSpecTemplateArtifact) interface{} { return v.Template }).(pulumi.AnyOutput)
}

type TemplateSpecTemplateArtifactArrayOutput struct{ *pulumi.OutputState }

func (TemplateSpecTemplateArtifactArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]TemplateSpecTemplateArtifact)(nil)).Elem()
}

func (o TemplateSpecTemplateArtifactArrayOutput) ToTemplateSpecTemplateArtifactArrayOutput() TemplateSpecTemplateArtifactArrayOutput {
	return o
}

func (o TemplateSpecTemplateArtifactArrayOutput) ToTemplateSpecTemplateArtifactArrayOutputWithContext(ctx context.Context) TemplateSpecTemplateArtifactArrayOutput {
	return o
}

func (o TemplateSpecTemplateArtifactArrayOutput) Index(i pulumi.IntInput) TemplateSpecTemplateArtifactOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) TemplateSpecTemplateArtifact {
		return vs[0].([]TemplateSpecTemplateArtifact)[vs[1].(int)]
	}).(TemplateSpecTemplateArtifactOutput)
}

// Represents a Template Spec artifact containing an embedded Azure Resource Manager template.
type TemplateSpecTemplateArtifactResponse struct {
	// The kind of artifact.
	Kind string `pulumi:"kind"`
	// A filesystem safe relative path of the artifact.
	Path string `pulumi:"path"`
	// The Azure Resource Manager template.
	Template interface{} `pulumi:"template"`
}

// TemplateSpecTemplateArtifactResponseInput is an input type that accepts TemplateSpecTemplateArtifactResponseArgs and TemplateSpecTemplateArtifactResponseOutput values.
// You can construct a concrete instance of `TemplateSpecTemplateArtifactResponseInput` via:
//
//          TemplateSpecTemplateArtifactResponseArgs{...}
type TemplateSpecTemplateArtifactResponseInput interface {
	pulumi.Input

	ToTemplateSpecTemplateArtifactResponseOutput() TemplateSpecTemplateArtifactResponseOutput
	ToTemplateSpecTemplateArtifactResponseOutputWithContext(context.Context) TemplateSpecTemplateArtifactResponseOutput
}

// Represents a Template Spec artifact containing an embedded Azure Resource Manager template.
type TemplateSpecTemplateArtifactResponseArgs struct {
	// The kind of artifact.
	Kind pulumi.StringInput `pulumi:"kind"`
	// A filesystem safe relative path of the artifact.
	Path pulumi.StringInput `pulumi:"path"`
	// The Azure Resource Manager template.
	Template pulumi.Input `pulumi:"template"`
}

func (TemplateSpecTemplateArtifactResponseArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*TemplateSpecTemplateArtifactResponse)(nil)).Elem()
}

func (i TemplateSpecTemplateArtifactResponseArgs) ToTemplateSpecTemplateArtifactResponseOutput() TemplateSpecTemplateArtifactResponseOutput {
	return i.ToTemplateSpecTemplateArtifactResponseOutputWithContext(context.Background())
}

func (i TemplateSpecTemplateArtifactResponseArgs) ToTemplateSpecTemplateArtifactResponseOutputWithContext(ctx context.Context) TemplateSpecTemplateArtifactResponseOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TemplateSpecTemplateArtifactResponseOutput)
}

// TemplateSpecTemplateArtifactResponseArrayInput is an input type that accepts TemplateSpecTemplateArtifactResponseArray and TemplateSpecTemplateArtifactResponseArrayOutput values.
// You can construct a concrete instance of `TemplateSpecTemplateArtifactResponseArrayInput` via:
//
//          TemplateSpecTemplateArtifactResponseArray{ TemplateSpecTemplateArtifactResponseArgs{...} }
type TemplateSpecTemplateArtifactResponseArrayInput interface {
	pulumi.Input

	ToTemplateSpecTemplateArtifactResponseArrayOutput() TemplateSpecTemplateArtifactResponseArrayOutput
	ToTemplateSpecTemplateArtifactResponseArrayOutputWithContext(context.Context) TemplateSpecTemplateArtifactResponseArrayOutput
}

type TemplateSpecTemplateArtifactResponseArray []TemplateSpecTemplateArtifactResponseInput

func (TemplateSpecTemplateArtifactResponseArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]TemplateSpecTemplateArtifactResponse)(nil)).Elem()
}

func (i TemplateSpecTemplateArtifactResponseArray) ToTemplateSpecTemplateArtifactResponseArrayOutput() TemplateSpecTemplateArtifactResponseArrayOutput {
	return i.ToTemplateSpecTemplateArtifactResponseArrayOutputWithContext(context.Background())
}

func (i TemplateSpecTemplateArtifactResponseArray) ToTemplateSpecTemplateArtifactResponseArrayOutputWithContext(ctx context.Context) TemplateSpecTemplateArtifactResponseArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TemplateSpecTemplateArtifactResponseArrayOutput)
}

// Represents a Template Spec artifact containing an embedded Azure Resource Manager template.
type TemplateSpecTemplateArtifactResponseOutput struct{ *pulumi.OutputState }

func (TemplateSpecTemplateArtifactResponseOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*TemplateSpecTemplateArtifactResponse)(nil)).Elem()
}

func (o TemplateSpecTemplateArtifactResponseOutput) ToTemplateSpecTemplateArtifactResponseOutput() TemplateSpecTemplateArtifactResponseOutput {
	return o
}

func (o TemplateSpecTemplateArtifactResponseOutput) ToTemplateSpecTemplateArtifactResponseOutputWithContext(ctx context.Context) TemplateSpecTemplateArtifactResponseOutput {
	return o
}

// The kind of artifact.
func (o TemplateSpecTemplateArtifactResponseOutput) Kind() pulumi.StringOutput {
	return o.ApplyT(func(v TemplateSpecTemplateArtifactResponse) string { return v.Kind }).(pulumi.StringOutput)
}

// A filesystem safe relative path of the artifact.
func (o TemplateSpecTemplateArtifactResponseOutput) Path() pulumi.StringOutput {
	return o.ApplyT(func(v TemplateSpecTemplateArtifactResponse) string { return v.Path }).(pulumi.StringOutput)
}

// The Azure Resource Manager template.
func (o TemplateSpecTemplateArtifactResponseOutput) Template() pulumi.AnyOutput {
	return o.ApplyT(func(v TemplateSpecTemplateArtifactResponse) interface{} { return v.Template }).(pulumi.AnyOutput)
}

type TemplateSpecTemplateArtifactResponseArrayOutput struct{ *pulumi.OutputState }

func (TemplateSpecTemplateArtifactResponseArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]TemplateSpecTemplateArtifactResponse)(nil)).Elem()
}

func (o TemplateSpecTemplateArtifactResponseArrayOutput) ToTemplateSpecTemplateArtifactResponseArrayOutput() TemplateSpecTemplateArtifactResponseArrayOutput {
	return o
}

func (o TemplateSpecTemplateArtifactResponseArrayOutput) ToTemplateSpecTemplateArtifactResponseArrayOutputWithContext(ctx context.Context) TemplateSpecTemplateArtifactResponseArrayOutput {
	return o
}

func (o TemplateSpecTemplateArtifactResponseArrayOutput) Index(i pulumi.IntInput) TemplateSpecTemplateArtifactResponseOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) TemplateSpecTemplateArtifactResponse {
		return vs[0].([]TemplateSpecTemplateArtifactResponse)[vs[1].(int)]
	}).(TemplateSpecTemplateArtifactResponseOutput)
}

func init() {
	pulumi.RegisterOutputType(SystemDataResponseOutput{})
	pulumi.RegisterOutputType(SystemDataResponsePtrOutput{})
	pulumi.RegisterOutputType(TemplateSpecTemplateArtifactOutput{})
	pulumi.RegisterOutputType(TemplateSpecTemplateArtifactArrayOutput{})
	pulumi.RegisterOutputType(TemplateSpecTemplateArtifactResponseOutput{})
	pulumi.RegisterOutputType(TemplateSpecTemplateArtifactResponseArrayOutput{})
}

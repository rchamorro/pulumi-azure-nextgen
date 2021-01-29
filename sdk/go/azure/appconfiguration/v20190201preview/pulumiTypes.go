// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20190201preview

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// An API key used for authenticating with a configuration store endpoint.
type ApiKeyResponse struct {
	// A connection string that can be used by supporting clients for authentication.
	ConnectionString string `pulumi:"connectionString"`
	// The key ID.
	Id string `pulumi:"id"`
	// The last time any of the key's properties were modified.
	LastModified string `pulumi:"lastModified"`
	// A name for the key describing its usage.
	Name string `pulumi:"name"`
	// Whether this key can only be used for read operations.
	ReadOnly bool `pulumi:"readOnly"`
	// The value of the key that is used for authentication purposes.
	Value string `pulumi:"value"`
}

// ApiKeyResponseInput is an input type that accepts ApiKeyResponseArgs and ApiKeyResponseOutput values.
// You can construct a concrete instance of `ApiKeyResponseInput` via:
//
//          ApiKeyResponseArgs{...}
type ApiKeyResponseInput interface {
	pulumi.Input

	ToApiKeyResponseOutput() ApiKeyResponseOutput
	ToApiKeyResponseOutputWithContext(context.Context) ApiKeyResponseOutput
}

// An API key used for authenticating with a configuration store endpoint.
type ApiKeyResponseArgs struct {
	// A connection string that can be used by supporting clients for authentication.
	ConnectionString pulumi.StringInput `pulumi:"connectionString"`
	// The key ID.
	Id pulumi.StringInput `pulumi:"id"`
	// The last time any of the key's properties were modified.
	LastModified pulumi.StringInput `pulumi:"lastModified"`
	// A name for the key describing its usage.
	Name pulumi.StringInput `pulumi:"name"`
	// Whether this key can only be used for read operations.
	ReadOnly pulumi.BoolInput `pulumi:"readOnly"`
	// The value of the key that is used for authentication purposes.
	Value pulumi.StringInput `pulumi:"value"`
}

func (ApiKeyResponseArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ApiKeyResponse)(nil)).Elem()
}

func (i ApiKeyResponseArgs) ToApiKeyResponseOutput() ApiKeyResponseOutput {
	return i.ToApiKeyResponseOutputWithContext(context.Background())
}

func (i ApiKeyResponseArgs) ToApiKeyResponseOutputWithContext(ctx context.Context) ApiKeyResponseOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ApiKeyResponseOutput)
}

// ApiKeyResponseArrayInput is an input type that accepts ApiKeyResponseArray and ApiKeyResponseArrayOutput values.
// You can construct a concrete instance of `ApiKeyResponseArrayInput` via:
//
//          ApiKeyResponseArray{ ApiKeyResponseArgs{...} }
type ApiKeyResponseArrayInput interface {
	pulumi.Input

	ToApiKeyResponseArrayOutput() ApiKeyResponseArrayOutput
	ToApiKeyResponseArrayOutputWithContext(context.Context) ApiKeyResponseArrayOutput
}

type ApiKeyResponseArray []ApiKeyResponseInput

func (ApiKeyResponseArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]ApiKeyResponse)(nil)).Elem()
}

func (i ApiKeyResponseArray) ToApiKeyResponseArrayOutput() ApiKeyResponseArrayOutput {
	return i.ToApiKeyResponseArrayOutputWithContext(context.Background())
}

func (i ApiKeyResponseArray) ToApiKeyResponseArrayOutputWithContext(ctx context.Context) ApiKeyResponseArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ApiKeyResponseArrayOutput)
}

// An API key used for authenticating with a configuration store endpoint.
type ApiKeyResponseOutput struct{ *pulumi.OutputState }

func (ApiKeyResponseOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ApiKeyResponse)(nil)).Elem()
}

func (o ApiKeyResponseOutput) ToApiKeyResponseOutput() ApiKeyResponseOutput {
	return o
}

func (o ApiKeyResponseOutput) ToApiKeyResponseOutputWithContext(ctx context.Context) ApiKeyResponseOutput {
	return o
}

// A connection string that can be used by supporting clients for authentication.
func (o ApiKeyResponseOutput) ConnectionString() pulumi.StringOutput {
	return o.ApplyT(func(v ApiKeyResponse) string { return v.ConnectionString }).(pulumi.StringOutput)
}

// The key ID.
func (o ApiKeyResponseOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v ApiKeyResponse) string { return v.Id }).(pulumi.StringOutput)
}

// The last time any of the key's properties were modified.
func (o ApiKeyResponseOutput) LastModified() pulumi.StringOutput {
	return o.ApplyT(func(v ApiKeyResponse) string { return v.LastModified }).(pulumi.StringOutput)
}

// A name for the key describing its usage.
func (o ApiKeyResponseOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v ApiKeyResponse) string { return v.Name }).(pulumi.StringOutput)
}

// Whether this key can only be used for read operations.
func (o ApiKeyResponseOutput) ReadOnly() pulumi.BoolOutput {
	return o.ApplyT(func(v ApiKeyResponse) bool { return v.ReadOnly }).(pulumi.BoolOutput)
}

// The value of the key that is used for authentication purposes.
func (o ApiKeyResponseOutput) Value() pulumi.StringOutput {
	return o.ApplyT(func(v ApiKeyResponse) string { return v.Value }).(pulumi.StringOutput)
}

type ApiKeyResponseArrayOutput struct{ *pulumi.OutputState }

func (ApiKeyResponseArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]ApiKeyResponse)(nil)).Elem()
}

func (o ApiKeyResponseArrayOutput) ToApiKeyResponseArrayOutput() ApiKeyResponseArrayOutput {
	return o
}

func (o ApiKeyResponseArrayOutput) ToApiKeyResponseArrayOutputWithContext(ctx context.Context) ApiKeyResponseArrayOutput {
	return o
}

func (o ApiKeyResponseArrayOutput) Index(i pulumi.IntInput) ApiKeyResponseOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) ApiKeyResponse {
		return vs[0].([]ApiKeyResponse)[vs[1].(int)]
	}).(ApiKeyResponseOutput)
}

func init() {
	pulumi.RegisterOutputType(ApiKeyResponseOutput{})
	pulumi.RegisterOutputType(ApiKeyResponseArrayOutput{})
}

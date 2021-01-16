// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20180301beta

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// properties for creation saas
type SaasCreationProperties struct {
	// Whether the SaaS subscription will auto renew upon term end.
	AutoRenew *bool `pulumi:"autoRenew"`
	// The offer id.
	OfferId *string `pulumi:"offerId"`
	// The metadata about the SaaS subscription such as the AzureSubscriptionId and ResourceUri.
	PaymentChannelMetadata map[string]string `pulumi:"paymentChannelMetadata"`
	// The Payment channel for the SaasSubscription.
	PaymentChannelType *string `pulumi:"paymentChannelType"`
	// The publisher id.
	PublisherId *string `pulumi:"publisherId"`
	// The environment in the publisher side for this resource.
	PublisherTestEnvironment *string `pulumi:"publisherTestEnvironment"`
	// The seat count.
	Quantity *float64 `pulumi:"quantity"`
	// The SaaS resource name.
	SaasResourceName *string `pulumi:"saasResourceName"`
	// The saas session id used for dev service migration request.
	SaasSessionId *string `pulumi:"saasSessionId"`
	// The saas subscription id used for tenant to subscription level migration request.
	SaasSubscriptionId *string `pulumi:"saasSubscriptionId"`
	// The plan id.
	SkuId *string `pulumi:"skuId"`
	// The current Term id.
	TermId *string `pulumi:"termId"`
}

// SaasCreationPropertiesInput is an input type that accepts SaasCreationPropertiesArgs and SaasCreationPropertiesOutput values.
// You can construct a concrete instance of `SaasCreationPropertiesInput` via:
//
//          SaasCreationPropertiesArgs{...}
type SaasCreationPropertiesInput interface {
	pulumi.Input

	ToSaasCreationPropertiesOutput() SaasCreationPropertiesOutput
	ToSaasCreationPropertiesOutputWithContext(context.Context) SaasCreationPropertiesOutput
}

// properties for creation saas
type SaasCreationPropertiesArgs struct {
	// Whether the SaaS subscription will auto renew upon term end.
	AutoRenew pulumi.BoolPtrInput `pulumi:"autoRenew"`
	// The offer id.
	OfferId pulumi.StringPtrInput `pulumi:"offerId"`
	// The metadata about the SaaS subscription such as the AzureSubscriptionId and ResourceUri.
	PaymentChannelMetadata pulumi.StringMapInput `pulumi:"paymentChannelMetadata"`
	// The Payment channel for the SaasSubscription.
	PaymentChannelType pulumi.StringPtrInput `pulumi:"paymentChannelType"`
	// The publisher id.
	PublisherId pulumi.StringPtrInput `pulumi:"publisherId"`
	// The environment in the publisher side for this resource.
	PublisherTestEnvironment pulumi.StringPtrInput `pulumi:"publisherTestEnvironment"`
	// The seat count.
	Quantity pulumi.Float64PtrInput `pulumi:"quantity"`
	// The SaaS resource name.
	SaasResourceName pulumi.StringPtrInput `pulumi:"saasResourceName"`
	// The saas session id used for dev service migration request.
	SaasSessionId pulumi.StringPtrInput `pulumi:"saasSessionId"`
	// The saas subscription id used for tenant to subscription level migration request.
	SaasSubscriptionId pulumi.StringPtrInput `pulumi:"saasSubscriptionId"`
	// The plan id.
	SkuId pulumi.StringPtrInput `pulumi:"skuId"`
	// The current Term id.
	TermId pulumi.StringPtrInput `pulumi:"termId"`
}

func (SaasCreationPropertiesArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*SaasCreationProperties)(nil)).Elem()
}

func (i SaasCreationPropertiesArgs) ToSaasCreationPropertiesOutput() SaasCreationPropertiesOutput {
	return i.ToSaasCreationPropertiesOutputWithContext(context.Background())
}

func (i SaasCreationPropertiesArgs) ToSaasCreationPropertiesOutputWithContext(ctx context.Context) SaasCreationPropertiesOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SaasCreationPropertiesOutput)
}

func (i SaasCreationPropertiesArgs) ToSaasCreationPropertiesPtrOutput() SaasCreationPropertiesPtrOutput {
	return i.ToSaasCreationPropertiesPtrOutputWithContext(context.Background())
}

func (i SaasCreationPropertiesArgs) ToSaasCreationPropertiesPtrOutputWithContext(ctx context.Context) SaasCreationPropertiesPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SaasCreationPropertiesOutput).ToSaasCreationPropertiesPtrOutputWithContext(ctx)
}

// SaasCreationPropertiesPtrInput is an input type that accepts SaasCreationPropertiesArgs, SaasCreationPropertiesPtr and SaasCreationPropertiesPtrOutput values.
// You can construct a concrete instance of `SaasCreationPropertiesPtrInput` via:
//
//          SaasCreationPropertiesArgs{...}
//
//  or:
//
//          nil
type SaasCreationPropertiesPtrInput interface {
	pulumi.Input

	ToSaasCreationPropertiesPtrOutput() SaasCreationPropertiesPtrOutput
	ToSaasCreationPropertiesPtrOutputWithContext(context.Context) SaasCreationPropertiesPtrOutput
}

type saasCreationPropertiesPtrType SaasCreationPropertiesArgs

func SaasCreationPropertiesPtr(v *SaasCreationPropertiesArgs) SaasCreationPropertiesPtrInput {
	return (*saasCreationPropertiesPtrType)(v)
}

func (*saasCreationPropertiesPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**SaasCreationProperties)(nil)).Elem()
}

func (i *saasCreationPropertiesPtrType) ToSaasCreationPropertiesPtrOutput() SaasCreationPropertiesPtrOutput {
	return i.ToSaasCreationPropertiesPtrOutputWithContext(context.Background())
}

func (i *saasCreationPropertiesPtrType) ToSaasCreationPropertiesPtrOutputWithContext(ctx context.Context) SaasCreationPropertiesPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SaasCreationPropertiesPtrOutput)
}

// properties for creation saas
type SaasCreationPropertiesOutput struct{ *pulumi.OutputState }

func (SaasCreationPropertiesOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*SaasCreationProperties)(nil)).Elem()
}

func (o SaasCreationPropertiesOutput) ToSaasCreationPropertiesOutput() SaasCreationPropertiesOutput {
	return o
}

func (o SaasCreationPropertiesOutput) ToSaasCreationPropertiesOutputWithContext(ctx context.Context) SaasCreationPropertiesOutput {
	return o
}

func (o SaasCreationPropertiesOutput) ToSaasCreationPropertiesPtrOutput() SaasCreationPropertiesPtrOutput {
	return o.ToSaasCreationPropertiesPtrOutputWithContext(context.Background())
}

func (o SaasCreationPropertiesOutput) ToSaasCreationPropertiesPtrOutputWithContext(ctx context.Context) SaasCreationPropertiesPtrOutput {
	return o.ApplyT(func(v SaasCreationProperties) *SaasCreationProperties {
		return &v
	}).(SaasCreationPropertiesPtrOutput)
}

// Whether the SaaS subscription will auto renew upon term end.
func (o SaasCreationPropertiesOutput) AutoRenew() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v SaasCreationProperties) *bool { return v.AutoRenew }).(pulumi.BoolPtrOutput)
}

// The offer id.
func (o SaasCreationPropertiesOutput) OfferId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v SaasCreationProperties) *string { return v.OfferId }).(pulumi.StringPtrOutput)
}

// The metadata about the SaaS subscription such as the AzureSubscriptionId and ResourceUri.
func (o SaasCreationPropertiesOutput) PaymentChannelMetadata() pulumi.StringMapOutput {
	return o.ApplyT(func(v SaasCreationProperties) map[string]string { return v.PaymentChannelMetadata }).(pulumi.StringMapOutput)
}

// The Payment channel for the SaasSubscription.
func (o SaasCreationPropertiesOutput) PaymentChannelType() pulumi.StringPtrOutput {
	return o.ApplyT(func(v SaasCreationProperties) *string { return v.PaymentChannelType }).(pulumi.StringPtrOutput)
}

// The publisher id.
func (o SaasCreationPropertiesOutput) PublisherId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v SaasCreationProperties) *string { return v.PublisherId }).(pulumi.StringPtrOutput)
}

// The environment in the publisher side for this resource.
func (o SaasCreationPropertiesOutput) PublisherTestEnvironment() pulumi.StringPtrOutput {
	return o.ApplyT(func(v SaasCreationProperties) *string { return v.PublisherTestEnvironment }).(pulumi.StringPtrOutput)
}

// The seat count.
func (o SaasCreationPropertiesOutput) Quantity() pulumi.Float64PtrOutput {
	return o.ApplyT(func(v SaasCreationProperties) *float64 { return v.Quantity }).(pulumi.Float64PtrOutput)
}

// The SaaS resource name.
func (o SaasCreationPropertiesOutput) SaasResourceName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v SaasCreationProperties) *string { return v.SaasResourceName }).(pulumi.StringPtrOutput)
}

// The saas session id used for dev service migration request.
func (o SaasCreationPropertiesOutput) SaasSessionId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v SaasCreationProperties) *string { return v.SaasSessionId }).(pulumi.StringPtrOutput)
}

// The saas subscription id used for tenant to subscription level migration request.
func (o SaasCreationPropertiesOutput) SaasSubscriptionId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v SaasCreationProperties) *string { return v.SaasSubscriptionId }).(pulumi.StringPtrOutput)
}

// The plan id.
func (o SaasCreationPropertiesOutput) SkuId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v SaasCreationProperties) *string { return v.SkuId }).(pulumi.StringPtrOutput)
}

// The current Term id.
func (o SaasCreationPropertiesOutput) TermId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v SaasCreationProperties) *string { return v.TermId }).(pulumi.StringPtrOutput)
}

type SaasCreationPropertiesPtrOutput struct{ *pulumi.OutputState }

func (SaasCreationPropertiesPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**SaasCreationProperties)(nil)).Elem()
}

func (o SaasCreationPropertiesPtrOutput) ToSaasCreationPropertiesPtrOutput() SaasCreationPropertiesPtrOutput {
	return o
}

func (o SaasCreationPropertiesPtrOutput) ToSaasCreationPropertiesPtrOutputWithContext(ctx context.Context) SaasCreationPropertiesPtrOutput {
	return o
}

func (o SaasCreationPropertiesPtrOutput) Elem() SaasCreationPropertiesOutput {
	return o.ApplyT(func(v *SaasCreationProperties) SaasCreationProperties { return *v }).(SaasCreationPropertiesOutput)
}

// Whether the SaaS subscription will auto renew upon term end.
func (o SaasCreationPropertiesPtrOutput) AutoRenew() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *SaasCreationProperties) *bool {
		if v == nil {
			return nil
		}
		return v.AutoRenew
	}).(pulumi.BoolPtrOutput)
}

// The offer id.
func (o SaasCreationPropertiesPtrOutput) OfferId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SaasCreationProperties) *string {
		if v == nil {
			return nil
		}
		return v.OfferId
	}).(pulumi.StringPtrOutput)
}

// The metadata about the SaaS subscription such as the AzureSubscriptionId and ResourceUri.
func (o SaasCreationPropertiesPtrOutput) PaymentChannelMetadata() pulumi.StringMapOutput {
	return o.ApplyT(func(v *SaasCreationProperties) map[string]string {
		if v == nil {
			return nil
		}
		return v.PaymentChannelMetadata
	}).(pulumi.StringMapOutput)
}

// The Payment channel for the SaasSubscription.
func (o SaasCreationPropertiesPtrOutput) PaymentChannelType() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SaasCreationProperties) *string {
		if v == nil {
			return nil
		}
		return v.PaymentChannelType
	}).(pulumi.StringPtrOutput)
}

// The publisher id.
func (o SaasCreationPropertiesPtrOutput) PublisherId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SaasCreationProperties) *string {
		if v == nil {
			return nil
		}
		return v.PublisherId
	}).(pulumi.StringPtrOutput)
}

// The environment in the publisher side for this resource.
func (o SaasCreationPropertiesPtrOutput) PublisherTestEnvironment() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SaasCreationProperties) *string {
		if v == nil {
			return nil
		}
		return v.PublisherTestEnvironment
	}).(pulumi.StringPtrOutput)
}

// The seat count.
func (o SaasCreationPropertiesPtrOutput) Quantity() pulumi.Float64PtrOutput {
	return o.ApplyT(func(v *SaasCreationProperties) *float64 {
		if v == nil {
			return nil
		}
		return v.Quantity
	}).(pulumi.Float64PtrOutput)
}

// The SaaS resource name.
func (o SaasCreationPropertiesPtrOutput) SaasResourceName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SaasCreationProperties) *string {
		if v == nil {
			return nil
		}
		return v.SaasResourceName
	}).(pulumi.StringPtrOutput)
}

// The saas session id used for dev service migration request.
func (o SaasCreationPropertiesPtrOutput) SaasSessionId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SaasCreationProperties) *string {
		if v == nil {
			return nil
		}
		return v.SaasSessionId
	}).(pulumi.StringPtrOutput)
}

// The saas subscription id used for tenant to subscription level migration request.
func (o SaasCreationPropertiesPtrOutput) SaasSubscriptionId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SaasCreationProperties) *string {
		if v == nil {
			return nil
		}
		return v.SaasSubscriptionId
	}).(pulumi.StringPtrOutput)
}

// The plan id.
func (o SaasCreationPropertiesPtrOutput) SkuId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SaasCreationProperties) *string {
		if v == nil {
			return nil
		}
		return v.SkuId
	}).(pulumi.StringPtrOutput)
}

// The current Term id.
func (o SaasCreationPropertiesPtrOutput) TermId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SaasCreationProperties) *string {
		if v == nil {
			return nil
		}
		return v.TermId
	}).(pulumi.StringPtrOutput)
}

// The current Term object.
type SaasPropertiesResponseTerm struct {
	// The end date of the current term
	EndDate *string `pulumi:"endDate"`
	// The start date of the current term
	StartDate *string `pulumi:"startDate"`
	// The unit indicating Monthly / Yearly
	TermUnit *string `pulumi:"termUnit"`
}

// SaasPropertiesResponseTermInput is an input type that accepts SaasPropertiesResponseTermArgs and SaasPropertiesResponseTermOutput values.
// You can construct a concrete instance of `SaasPropertiesResponseTermInput` via:
//
//          SaasPropertiesResponseTermArgs{...}
type SaasPropertiesResponseTermInput interface {
	pulumi.Input

	ToSaasPropertiesResponseTermOutput() SaasPropertiesResponseTermOutput
	ToSaasPropertiesResponseTermOutputWithContext(context.Context) SaasPropertiesResponseTermOutput
}

// The current Term object.
type SaasPropertiesResponseTermArgs struct {
	// The end date of the current term
	EndDate pulumi.StringPtrInput `pulumi:"endDate"`
	// The start date of the current term
	StartDate pulumi.StringPtrInput `pulumi:"startDate"`
	// The unit indicating Monthly / Yearly
	TermUnit pulumi.StringPtrInput `pulumi:"termUnit"`
}

func (SaasPropertiesResponseTermArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*SaasPropertiesResponseTerm)(nil)).Elem()
}

func (i SaasPropertiesResponseTermArgs) ToSaasPropertiesResponseTermOutput() SaasPropertiesResponseTermOutput {
	return i.ToSaasPropertiesResponseTermOutputWithContext(context.Background())
}

func (i SaasPropertiesResponseTermArgs) ToSaasPropertiesResponseTermOutputWithContext(ctx context.Context) SaasPropertiesResponseTermOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SaasPropertiesResponseTermOutput)
}

func (i SaasPropertiesResponseTermArgs) ToSaasPropertiesResponseTermPtrOutput() SaasPropertiesResponseTermPtrOutput {
	return i.ToSaasPropertiesResponseTermPtrOutputWithContext(context.Background())
}

func (i SaasPropertiesResponseTermArgs) ToSaasPropertiesResponseTermPtrOutputWithContext(ctx context.Context) SaasPropertiesResponseTermPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SaasPropertiesResponseTermOutput).ToSaasPropertiesResponseTermPtrOutputWithContext(ctx)
}

// SaasPropertiesResponseTermPtrInput is an input type that accepts SaasPropertiesResponseTermArgs, SaasPropertiesResponseTermPtr and SaasPropertiesResponseTermPtrOutput values.
// You can construct a concrete instance of `SaasPropertiesResponseTermPtrInput` via:
//
//          SaasPropertiesResponseTermArgs{...}
//
//  or:
//
//          nil
type SaasPropertiesResponseTermPtrInput interface {
	pulumi.Input

	ToSaasPropertiesResponseTermPtrOutput() SaasPropertiesResponseTermPtrOutput
	ToSaasPropertiesResponseTermPtrOutputWithContext(context.Context) SaasPropertiesResponseTermPtrOutput
}

type saasPropertiesResponseTermPtrType SaasPropertiesResponseTermArgs

func SaasPropertiesResponseTermPtr(v *SaasPropertiesResponseTermArgs) SaasPropertiesResponseTermPtrInput {
	return (*saasPropertiesResponseTermPtrType)(v)
}

func (*saasPropertiesResponseTermPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**SaasPropertiesResponseTerm)(nil)).Elem()
}

func (i *saasPropertiesResponseTermPtrType) ToSaasPropertiesResponseTermPtrOutput() SaasPropertiesResponseTermPtrOutput {
	return i.ToSaasPropertiesResponseTermPtrOutputWithContext(context.Background())
}

func (i *saasPropertiesResponseTermPtrType) ToSaasPropertiesResponseTermPtrOutputWithContext(ctx context.Context) SaasPropertiesResponseTermPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SaasPropertiesResponseTermPtrOutput)
}

// The current Term object.
type SaasPropertiesResponseTermOutput struct{ *pulumi.OutputState }

func (SaasPropertiesResponseTermOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*SaasPropertiesResponseTerm)(nil)).Elem()
}

func (o SaasPropertiesResponseTermOutput) ToSaasPropertiesResponseTermOutput() SaasPropertiesResponseTermOutput {
	return o
}

func (o SaasPropertiesResponseTermOutput) ToSaasPropertiesResponseTermOutputWithContext(ctx context.Context) SaasPropertiesResponseTermOutput {
	return o
}

func (o SaasPropertiesResponseTermOutput) ToSaasPropertiesResponseTermPtrOutput() SaasPropertiesResponseTermPtrOutput {
	return o.ToSaasPropertiesResponseTermPtrOutputWithContext(context.Background())
}

func (o SaasPropertiesResponseTermOutput) ToSaasPropertiesResponseTermPtrOutputWithContext(ctx context.Context) SaasPropertiesResponseTermPtrOutput {
	return o.ApplyT(func(v SaasPropertiesResponseTerm) *SaasPropertiesResponseTerm {
		return &v
	}).(SaasPropertiesResponseTermPtrOutput)
}

// The end date of the current term
func (o SaasPropertiesResponseTermOutput) EndDate() pulumi.StringPtrOutput {
	return o.ApplyT(func(v SaasPropertiesResponseTerm) *string { return v.EndDate }).(pulumi.StringPtrOutput)
}

// The start date of the current term
func (o SaasPropertiesResponseTermOutput) StartDate() pulumi.StringPtrOutput {
	return o.ApplyT(func(v SaasPropertiesResponseTerm) *string { return v.StartDate }).(pulumi.StringPtrOutput)
}

// The unit indicating Monthly / Yearly
func (o SaasPropertiesResponseTermOutput) TermUnit() pulumi.StringPtrOutput {
	return o.ApplyT(func(v SaasPropertiesResponseTerm) *string { return v.TermUnit }).(pulumi.StringPtrOutput)
}

type SaasPropertiesResponseTermPtrOutput struct{ *pulumi.OutputState }

func (SaasPropertiesResponseTermPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**SaasPropertiesResponseTerm)(nil)).Elem()
}

func (o SaasPropertiesResponseTermPtrOutput) ToSaasPropertiesResponseTermPtrOutput() SaasPropertiesResponseTermPtrOutput {
	return o
}

func (o SaasPropertiesResponseTermPtrOutput) ToSaasPropertiesResponseTermPtrOutputWithContext(ctx context.Context) SaasPropertiesResponseTermPtrOutput {
	return o
}

func (o SaasPropertiesResponseTermPtrOutput) Elem() SaasPropertiesResponseTermOutput {
	return o.ApplyT(func(v *SaasPropertiesResponseTerm) SaasPropertiesResponseTerm { return *v }).(SaasPropertiesResponseTermOutput)
}

// The end date of the current term
func (o SaasPropertiesResponseTermPtrOutput) EndDate() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SaasPropertiesResponseTerm) *string {
		if v == nil {
			return nil
		}
		return v.EndDate
	}).(pulumi.StringPtrOutput)
}

// The start date of the current term
func (o SaasPropertiesResponseTermPtrOutput) StartDate() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SaasPropertiesResponseTerm) *string {
		if v == nil {
			return nil
		}
		return v.StartDate
	}).(pulumi.StringPtrOutput)
}

// The unit indicating Monthly / Yearly
func (o SaasPropertiesResponseTermPtrOutput) TermUnit() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SaasPropertiesResponseTerm) *string {
		if v == nil {
			return nil
		}
		return v.TermUnit
	}).(pulumi.StringPtrOutput)
}

// saas properties
type SaasResourceResponseProperties struct {
	// Whether the SaaS subscription will auto renew upon term end.
	AutoRenew *bool `pulumi:"autoRenew"`
	// The created date of this resource.
	Created string `pulumi:"created"`
	// Whether the current term is a Free Trial term
	IsFreeTrial *bool `pulumi:"isFreeTrial"`
	// The last modifier date if this resource.
	LastModified *string `pulumi:"lastModified"`
	// The offer id.
	OfferId *string `pulumi:"offerId"`
	// The metadata about the SaaS subscription such as the AzureSubscriptionId and ResourceUri.
	PaymentChannelMetadata map[string]string `pulumi:"paymentChannelMetadata"`
	// The Payment channel for the SaasSubscription.
	PaymentChannelType *string `pulumi:"paymentChannelType"`
	// The publisher id.
	PublisherId *string `pulumi:"publisherId"`
	// The environment in the publisher side for this resource.
	PublisherTestEnvironment *string `pulumi:"publisherTestEnvironment"`
	// The seat count.
	Quantity *float64 `pulumi:"quantity"`
	// The SaaS resource name.
	SaasResourceName *string `pulumi:"saasResourceName"`
	// The saas session id used for dev service migration request.
	SaasSessionId *string `pulumi:"saasSessionId"`
	// The saas subscription id used for tenant to subscription level migration request.
	SaasSubscriptionId *string `pulumi:"saasSubscriptionId"`
	// The plan id.
	SkuId *string `pulumi:"skuId"`
	// The SaaS Subscription Status.
	Status *string `pulumi:"status"`
	// The current Term object.
	Term *SaasPropertiesResponseTerm `pulumi:"term"`
	// The current Term id.
	TermId *string `pulumi:"termId"`
}

// SaasResourceResponsePropertiesInput is an input type that accepts SaasResourceResponsePropertiesArgs and SaasResourceResponsePropertiesOutput values.
// You can construct a concrete instance of `SaasResourceResponsePropertiesInput` via:
//
//          SaasResourceResponsePropertiesArgs{...}
type SaasResourceResponsePropertiesInput interface {
	pulumi.Input

	ToSaasResourceResponsePropertiesOutput() SaasResourceResponsePropertiesOutput
	ToSaasResourceResponsePropertiesOutputWithContext(context.Context) SaasResourceResponsePropertiesOutput
}

// saas properties
type SaasResourceResponsePropertiesArgs struct {
	// Whether the SaaS subscription will auto renew upon term end.
	AutoRenew pulumi.BoolPtrInput `pulumi:"autoRenew"`
	// The created date of this resource.
	Created pulumi.StringInput `pulumi:"created"`
	// Whether the current term is a Free Trial term
	IsFreeTrial pulumi.BoolPtrInput `pulumi:"isFreeTrial"`
	// The last modifier date if this resource.
	LastModified pulumi.StringPtrInput `pulumi:"lastModified"`
	// The offer id.
	OfferId pulumi.StringPtrInput `pulumi:"offerId"`
	// The metadata about the SaaS subscription such as the AzureSubscriptionId and ResourceUri.
	PaymentChannelMetadata pulumi.StringMapInput `pulumi:"paymentChannelMetadata"`
	// The Payment channel for the SaasSubscription.
	PaymentChannelType pulumi.StringPtrInput `pulumi:"paymentChannelType"`
	// The publisher id.
	PublisherId pulumi.StringPtrInput `pulumi:"publisherId"`
	// The environment in the publisher side for this resource.
	PublisherTestEnvironment pulumi.StringPtrInput `pulumi:"publisherTestEnvironment"`
	// The seat count.
	Quantity pulumi.Float64PtrInput `pulumi:"quantity"`
	// The SaaS resource name.
	SaasResourceName pulumi.StringPtrInput `pulumi:"saasResourceName"`
	// The saas session id used for dev service migration request.
	SaasSessionId pulumi.StringPtrInput `pulumi:"saasSessionId"`
	// The saas subscription id used for tenant to subscription level migration request.
	SaasSubscriptionId pulumi.StringPtrInput `pulumi:"saasSubscriptionId"`
	// The plan id.
	SkuId pulumi.StringPtrInput `pulumi:"skuId"`
	// The SaaS Subscription Status.
	Status pulumi.StringPtrInput `pulumi:"status"`
	// The current Term object.
	Term SaasPropertiesResponseTermPtrInput `pulumi:"term"`
	// The current Term id.
	TermId pulumi.StringPtrInput `pulumi:"termId"`
}

func (SaasResourceResponsePropertiesArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*SaasResourceResponseProperties)(nil)).Elem()
}

func (i SaasResourceResponsePropertiesArgs) ToSaasResourceResponsePropertiesOutput() SaasResourceResponsePropertiesOutput {
	return i.ToSaasResourceResponsePropertiesOutputWithContext(context.Background())
}

func (i SaasResourceResponsePropertiesArgs) ToSaasResourceResponsePropertiesOutputWithContext(ctx context.Context) SaasResourceResponsePropertiesOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SaasResourceResponsePropertiesOutput)
}

func (i SaasResourceResponsePropertiesArgs) ToSaasResourceResponsePropertiesPtrOutput() SaasResourceResponsePropertiesPtrOutput {
	return i.ToSaasResourceResponsePropertiesPtrOutputWithContext(context.Background())
}

func (i SaasResourceResponsePropertiesArgs) ToSaasResourceResponsePropertiesPtrOutputWithContext(ctx context.Context) SaasResourceResponsePropertiesPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SaasResourceResponsePropertiesOutput).ToSaasResourceResponsePropertiesPtrOutputWithContext(ctx)
}

// SaasResourceResponsePropertiesPtrInput is an input type that accepts SaasResourceResponsePropertiesArgs, SaasResourceResponsePropertiesPtr and SaasResourceResponsePropertiesPtrOutput values.
// You can construct a concrete instance of `SaasResourceResponsePropertiesPtrInput` via:
//
//          SaasResourceResponsePropertiesArgs{...}
//
//  or:
//
//          nil
type SaasResourceResponsePropertiesPtrInput interface {
	pulumi.Input

	ToSaasResourceResponsePropertiesPtrOutput() SaasResourceResponsePropertiesPtrOutput
	ToSaasResourceResponsePropertiesPtrOutputWithContext(context.Context) SaasResourceResponsePropertiesPtrOutput
}

type saasResourceResponsePropertiesPtrType SaasResourceResponsePropertiesArgs

func SaasResourceResponsePropertiesPtr(v *SaasResourceResponsePropertiesArgs) SaasResourceResponsePropertiesPtrInput {
	return (*saasResourceResponsePropertiesPtrType)(v)
}

func (*saasResourceResponsePropertiesPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**SaasResourceResponseProperties)(nil)).Elem()
}

func (i *saasResourceResponsePropertiesPtrType) ToSaasResourceResponsePropertiesPtrOutput() SaasResourceResponsePropertiesPtrOutput {
	return i.ToSaasResourceResponsePropertiesPtrOutputWithContext(context.Background())
}

func (i *saasResourceResponsePropertiesPtrType) ToSaasResourceResponsePropertiesPtrOutputWithContext(ctx context.Context) SaasResourceResponsePropertiesPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SaasResourceResponsePropertiesPtrOutput)
}

// saas properties
type SaasResourceResponsePropertiesOutput struct{ *pulumi.OutputState }

func (SaasResourceResponsePropertiesOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*SaasResourceResponseProperties)(nil)).Elem()
}

func (o SaasResourceResponsePropertiesOutput) ToSaasResourceResponsePropertiesOutput() SaasResourceResponsePropertiesOutput {
	return o
}

func (o SaasResourceResponsePropertiesOutput) ToSaasResourceResponsePropertiesOutputWithContext(ctx context.Context) SaasResourceResponsePropertiesOutput {
	return o
}

func (o SaasResourceResponsePropertiesOutput) ToSaasResourceResponsePropertiesPtrOutput() SaasResourceResponsePropertiesPtrOutput {
	return o.ToSaasResourceResponsePropertiesPtrOutputWithContext(context.Background())
}

func (o SaasResourceResponsePropertiesOutput) ToSaasResourceResponsePropertiesPtrOutputWithContext(ctx context.Context) SaasResourceResponsePropertiesPtrOutput {
	return o.ApplyT(func(v SaasResourceResponseProperties) *SaasResourceResponseProperties {
		return &v
	}).(SaasResourceResponsePropertiesPtrOutput)
}

// Whether the SaaS subscription will auto renew upon term end.
func (o SaasResourceResponsePropertiesOutput) AutoRenew() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v SaasResourceResponseProperties) *bool { return v.AutoRenew }).(pulumi.BoolPtrOutput)
}

// The created date of this resource.
func (o SaasResourceResponsePropertiesOutput) Created() pulumi.StringOutput {
	return o.ApplyT(func(v SaasResourceResponseProperties) string { return v.Created }).(pulumi.StringOutput)
}

// Whether the current term is a Free Trial term
func (o SaasResourceResponsePropertiesOutput) IsFreeTrial() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v SaasResourceResponseProperties) *bool { return v.IsFreeTrial }).(pulumi.BoolPtrOutput)
}

// The last modifier date if this resource.
func (o SaasResourceResponsePropertiesOutput) LastModified() pulumi.StringPtrOutput {
	return o.ApplyT(func(v SaasResourceResponseProperties) *string { return v.LastModified }).(pulumi.StringPtrOutput)
}

// The offer id.
func (o SaasResourceResponsePropertiesOutput) OfferId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v SaasResourceResponseProperties) *string { return v.OfferId }).(pulumi.StringPtrOutput)
}

// The metadata about the SaaS subscription such as the AzureSubscriptionId and ResourceUri.
func (o SaasResourceResponsePropertiesOutput) PaymentChannelMetadata() pulumi.StringMapOutput {
	return o.ApplyT(func(v SaasResourceResponseProperties) map[string]string { return v.PaymentChannelMetadata }).(pulumi.StringMapOutput)
}

// The Payment channel for the SaasSubscription.
func (o SaasResourceResponsePropertiesOutput) PaymentChannelType() pulumi.StringPtrOutput {
	return o.ApplyT(func(v SaasResourceResponseProperties) *string { return v.PaymentChannelType }).(pulumi.StringPtrOutput)
}

// The publisher id.
func (o SaasResourceResponsePropertiesOutput) PublisherId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v SaasResourceResponseProperties) *string { return v.PublisherId }).(pulumi.StringPtrOutput)
}

// The environment in the publisher side for this resource.
func (o SaasResourceResponsePropertiesOutput) PublisherTestEnvironment() pulumi.StringPtrOutput {
	return o.ApplyT(func(v SaasResourceResponseProperties) *string { return v.PublisherTestEnvironment }).(pulumi.StringPtrOutput)
}

// The seat count.
func (o SaasResourceResponsePropertiesOutput) Quantity() pulumi.Float64PtrOutput {
	return o.ApplyT(func(v SaasResourceResponseProperties) *float64 { return v.Quantity }).(pulumi.Float64PtrOutput)
}

// The SaaS resource name.
func (o SaasResourceResponsePropertiesOutput) SaasResourceName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v SaasResourceResponseProperties) *string { return v.SaasResourceName }).(pulumi.StringPtrOutput)
}

// The saas session id used for dev service migration request.
func (o SaasResourceResponsePropertiesOutput) SaasSessionId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v SaasResourceResponseProperties) *string { return v.SaasSessionId }).(pulumi.StringPtrOutput)
}

// The saas subscription id used for tenant to subscription level migration request.
func (o SaasResourceResponsePropertiesOutput) SaasSubscriptionId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v SaasResourceResponseProperties) *string { return v.SaasSubscriptionId }).(pulumi.StringPtrOutput)
}

// The plan id.
func (o SaasResourceResponsePropertiesOutput) SkuId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v SaasResourceResponseProperties) *string { return v.SkuId }).(pulumi.StringPtrOutput)
}

// The SaaS Subscription Status.
func (o SaasResourceResponsePropertiesOutput) Status() pulumi.StringPtrOutput {
	return o.ApplyT(func(v SaasResourceResponseProperties) *string { return v.Status }).(pulumi.StringPtrOutput)
}

// The current Term object.
func (o SaasResourceResponsePropertiesOutput) Term() SaasPropertiesResponseTermPtrOutput {
	return o.ApplyT(func(v SaasResourceResponseProperties) *SaasPropertiesResponseTerm { return v.Term }).(SaasPropertiesResponseTermPtrOutput)
}

// The current Term id.
func (o SaasResourceResponsePropertiesOutput) TermId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v SaasResourceResponseProperties) *string { return v.TermId }).(pulumi.StringPtrOutput)
}

type SaasResourceResponsePropertiesPtrOutput struct{ *pulumi.OutputState }

func (SaasResourceResponsePropertiesPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**SaasResourceResponseProperties)(nil)).Elem()
}

func (o SaasResourceResponsePropertiesPtrOutput) ToSaasResourceResponsePropertiesPtrOutput() SaasResourceResponsePropertiesPtrOutput {
	return o
}

func (o SaasResourceResponsePropertiesPtrOutput) ToSaasResourceResponsePropertiesPtrOutputWithContext(ctx context.Context) SaasResourceResponsePropertiesPtrOutput {
	return o
}

func (o SaasResourceResponsePropertiesPtrOutput) Elem() SaasResourceResponsePropertiesOutput {
	return o.ApplyT(func(v *SaasResourceResponseProperties) SaasResourceResponseProperties { return *v }).(SaasResourceResponsePropertiesOutput)
}

// Whether the SaaS subscription will auto renew upon term end.
func (o SaasResourceResponsePropertiesPtrOutput) AutoRenew() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *SaasResourceResponseProperties) *bool {
		if v == nil {
			return nil
		}
		return v.AutoRenew
	}).(pulumi.BoolPtrOutput)
}

// The created date of this resource.
func (o SaasResourceResponsePropertiesPtrOutput) Created() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SaasResourceResponseProperties) *string {
		if v == nil {
			return nil
		}
		return &v.Created
	}).(pulumi.StringPtrOutput)
}

// Whether the current term is a Free Trial term
func (o SaasResourceResponsePropertiesPtrOutput) IsFreeTrial() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *SaasResourceResponseProperties) *bool {
		if v == nil {
			return nil
		}
		return v.IsFreeTrial
	}).(pulumi.BoolPtrOutput)
}

// The last modifier date if this resource.
func (o SaasResourceResponsePropertiesPtrOutput) LastModified() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SaasResourceResponseProperties) *string {
		if v == nil {
			return nil
		}
		return v.LastModified
	}).(pulumi.StringPtrOutput)
}

// The offer id.
func (o SaasResourceResponsePropertiesPtrOutput) OfferId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SaasResourceResponseProperties) *string {
		if v == nil {
			return nil
		}
		return v.OfferId
	}).(pulumi.StringPtrOutput)
}

// The metadata about the SaaS subscription such as the AzureSubscriptionId and ResourceUri.
func (o SaasResourceResponsePropertiesPtrOutput) PaymentChannelMetadata() pulumi.StringMapOutput {
	return o.ApplyT(func(v *SaasResourceResponseProperties) map[string]string {
		if v == nil {
			return nil
		}
		return v.PaymentChannelMetadata
	}).(pulumi.StringMapOutput)
}

// The Payment channel for the SaasSubscription.
func (o SaasResourceResponsePropertiesPtrOutput) PaymentChannelType() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SaasResourceResponseProperties) *string {
		if v == nil {
			return nil
		}
		return v.PaymentChannelType
	}).(pulumi.StringPtrOutput)
}

// The publisher id.
func (o SaasResourceResponsePropertiesPtrOutput) PublisherId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SaasResourceResponseProperties) *string {
		if v == nil {
			return nil
		}
		return v.PublisherId
	}).(pulumi.StringPtrOutput)
}

// The environment in the publisher side for this resource.
func (o SaasResourceResponsePropertiesPtrOutput) PublisherTestEnvironment() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SaasResourceResponseProperties) *string {
		if v == nil {
			return nil
		}
		return v.PublisherTestEnvironment
	}).(pulumi.StringPtrOutput)
}

// The seat count.
func (o SaasResourceResponsePropertiesPtrOutput) Quantity() pulumi.Float64PtrOutput {
	return o.ApplyT(func(v *SaasResourceResponseProperties) *float64 {
		if v == nil {
			return nil
		}
		return v.Quantity
	}).(pulumi.Float64PtrOutput)
}

// The SaaS resource name.
func (o SaasResourceResponsePropertiesPtrOutput) SaasResourceName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SaasResourceResponseProperties) *string {
		if v == nil {
			return nil
		}
		return v.SaasResourceName
	}).(pulumi.StringPtrOutput)
}

// The saas session id used for dev service migration request.
func (o SaasResourceResponsePropertiesPtrOutput) SaasSessionId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SaasResourceResponseProperties) *string {
		if v == nil {
			return nil
		}
		return v.SaasSessionId
	}).(pulumi.StringPtrOutput)
}

// The saas subscription id used for tenant to subscription level migration request.
func (o SaasResourceResponsePropertiesPtrOutput) SaasSubscriptionId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SaasResourceResponseProperties) *string {
		if v == nil {
			return nil
		}
		return v.SaasSubscriptionId
	}).(pulumi.StringPtrOutput)
}

// The plan id.
func (o SaasResourceResponsePropertiesPtrOutput) SkuId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SaasResourceResponseProperties) *string {
		if v == nil {
			return nil
		}
		return v.SkuId
	}).(pulumi.StringPtrOutput)
}

// The SaaS Subscription Status.
func (o SaasResourceResponsePropertiesPtrOutput) Status() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SaasResourceResponseProperties) *string {
		if v == nil {
			return nil
		}
		return v.Status
	}).(pulumi.StringPtrOutput)
}

// The current Term object.
func (o SaasResourceResponsePropertiesPtrOutput) Term() SaasPropertiesResponseTermPtrOutput {
	return o.ApplyT(func(v *SaasResourceResponseProperties) *SaasPropertiesResponseTerm {
		if v == nil {
			return nil
		}
		return v.Term
	}).(SaasPropertiesResponseTermPtrOutput)
}

// The current Term id.
func (o SaasResourceResponsePropertiesPtrOutput) TermId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SaasResourceResponseProperties) *string {
		if v == nil {
			return nil
		}
		return v.TermId
	}).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(SaasCreationPropertiesOutput{})
	pulumi.RegisterOutputType(SaasCreationPropertiesPtrOutput{})
	pulumi.RegisterOutputType(SaasPropertiesResponseTermOutput{})
	pulumi.RegisterOutputType(SaasPropertiesResponseTermPtrOutput{})
	pulumi.RegisterOutputType(SaasResourceResponsePropertiesOutput{})
	pulumi.RegisterOutputType(SaasResourceResponsePropertiesPtrOutput{})
}

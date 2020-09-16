// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20170601

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupCustomerSubscription(ctx *pulumi.Context, args *LookupCustomerSubscriptionArgs, opts ...pulumi.InvokeOption) (*LookupCustomerSubscriptionResult, error) {
	var rv LookupCustomerSubscriptionResult
	err := ctx.Invoke("azure-nextgen:azurestack/v20170601:getCustomerSubscription", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupCustomerSubscriptionArgs struct {
	// Name of the product.
	CustomerSubscriptionName string `pulumi:"customerSubscriptionName"`
	// Name of the Azure Stack registration.
	RegistrationName string `pulumi:"registrationName"`
	// Name of the resource group.
	ResourceGroup string `pulumi:"resourceGroup"`
}

// Customer subscription.
type LookupCustomerSubscriptionResult struct {
	// The entity tag used for optimistic concurrency when modifying the resource.
	Etag *string `pulumi:"etag"`
	// Name of the resource.
	Name string `pulumi:"name"`
	// Tenant Id.
	TenantId *string `pulumi:"tenantId"`
	// Type of Resource.
	Type string `pulumi:"type"`
}
// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200601preview

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupLinkedSubscription(ctx *pulumi.Context, args *LookupLinkedSubscriptionArgs, opts ...pulumi.InvokeOption) (*LookupLinkedSubscriptionResult, error) {
	var rv LookupLinkedSubscriptionResult
	err := ctx.Invoke("azure-nextgen:azurestack/v20200601preview:getLinkedSubscription", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupLinkedSubscriptionArgs struct {
	// Name of the Linked Subscription resource.
	LinkedSubscriptionName string `pulumi:"linkedSubscriptionName"`
	// Name of the resource group.
	ResourceGroup string `pulumi:"resourceGroup"`
}

// Linked Subscription information.
type LookupLinkedSubscriptionResult struct {
	// The status of the remote management connection of the Azure Stack device.
	DeviceConnectionStatus string `pulumi:"deviceConnectionStatus"`
	// The identifier of the Azure Stack device for remote management.
	DeviceId string `pulumi:"deviceId"`
	// The connection state of the Azure Stack device.
	DeviceLinkState string `pulumi:"deviceLinkState"`
	// The object identifier associated with the Azure Stack device connecting to Azure.
	DeviceObjectId string `pulumi:"deviceObjectId"`
	// The entity tag used for optimistic concurrency when modifying the resource.
	Etag *string `pulumi:"etag"`
	// ID of the resource.
	Id string `pulumi:"id"`
	// The kind of the resource.
	Kind string `pulumi:"kind"`
	// The last remote management connection time for the Azure Stack device connected to the linked subscription resource.
	LastConnectedTime string `pulumi:"lastConnectedTime"`
	// The identifier associated with the device subscription.
	LinkedSubscriptionId *string `pulumi:"linkedSubscriptionId"`
	// Location of the resource.
	Location string `pulumi:"location"`
	// Name of the resource.
	Name string `pulumi:"name"`
	// The identifier associated with the device registration.
	RegistrationResourceId *string `pulumi:"registrationResourceId"`
	// Metadata pertaining to creation and last modification of the resource.
	SystemData SystemDataResponse `pulumi:"systemData"`
	// Custom tags for the resource.
	Tags map[string]string `pulumi:"tags"`
	// Type of Resource.
	Type string `pulumi:"type"`
}

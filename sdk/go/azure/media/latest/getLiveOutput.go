// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupLiveOutput(ctx *pulumi.Context, args *LookupLiveOutputArgs, opts ...pulumi.InvokeOption) (*LookupLiveOutputResult, error) {
	var rv LookupLiveOutputResult
	err := ctx.Invoke("azure-nextgen:media/latest:getLiveOutput", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupLiveOutputArgs struct {
	// The Media Services account name.
	AccountName string `pulumi:"accountName"`
	// The name of the live event, maximum length is 32.
	LiveEventName string `pulumi:"liveEventName"`
	// The name of the live output.
	LiveOutputName string `pulumi:"liveOutputName"`
	// The name of the resource group within the Azure subscription.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// The Live Output.
type LookupLiveOutputResult struct {
	// ISO 8601 time between 1 minute to 25 hours to indicate the maximum content length that can be archived in the asset for this live output. This also sets the maximum content length for the rewind window. For example, use PT1H30M to indicate 1 hour and 30 minutes of archive window.
	ArchiveWindowLength string `pulumi:"archiveWindowLength"`
	// The asset that the live output will write to.
	AssetName string `pulumi:"assetName"`
	// The creation time the live output.
	Created string `pulumi:"created"`
	// The description of the live output.
	Description *string `pulumi:"description"`
	// HTTP Live Streaming (HLS) packing setting for the live output.
	Hls *HlsResponse `pulumi:"hls"`
	// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
	Id string `pulumi:"id"`
	// The time the live output was last modified.
	LastModified string `pulumi:"lastModified"`
	// The manifest file name. If not provided, the service will generate one automatically.
	ManifestName *string `pulumi:"manifestName"`
	// The name of the resource
	Name string `pulumi:"name"`
	// The initial timestamp that the live output will start at, any content before this value will not be archived.
	OutputSnapTime *float64 `pulumi:"outputSnapTime"`
	// The provisioning state of the live output.
	ProvisioningState string `pulumi:"provisioningState"`
	// The resource state of the live output.
	ResourceState string `pulumi:"resourceState"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type string `pulumi:"type"`
}

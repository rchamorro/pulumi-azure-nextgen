// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20150320

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupStorageInsight(ctx *pulumi.Context, args *LookupStorageInsightArgs, opts ...pulumi.InvokeOption) (*LookupStorageInsightResult, error) {
	var rv LookupStorageInsightResult
	err := ctx.Invoke("azure-nextgen:operationalinsights/v20150320:getStorageInsight", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupStorageInsightArgs struct {
	// The Resource Group name.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Name of the storageInsightsConfigs resource
	StorageInsightName string `pulumi:"storageInsightName"`
	// The Log Analytics Workspace name.
	WorkspaceName string `pulumi:"workspaceName"`
}

// The top level storage insight resource container.
type LookupStorageInsightResult struct {
	// The names of the blob containers that the workspace should read
	Containers []string `pulumi:"containers"`
	// The ETag of the storage insight.
	ETag *string `pulumi:"eTag"`
	// Resource name.
	Name string `pulumi:"name"`
	// The status of the storage insight
	Status StorageInsightStatusResponse `pulumi:"status"`
	// The storage account connection details
	StorageAccount StorageAccountResponse `pulumi:"storageAccount"`
	// The names of the Azure tables that the workspace should read
	Tables []string `pulumi:"tables"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// Resource type.
	Type string `pulumi:"type"`
}
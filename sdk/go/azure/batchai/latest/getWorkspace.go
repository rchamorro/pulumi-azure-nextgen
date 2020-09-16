// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupWorkspace(ctx *pulumi.Context, args *LookupWorkspaceArgs, opts ...pulumi.InvokeOption) (*LookupWorkspaceResult, error) {
	var rv LookupWorkspaceResult
	err := ctx.Invoke("azure-nextgen:batchai/latest:getWorkspace", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupWorkspaceArgs struct {
	// Name of the resource group to which the resource belongs.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the workspace. Workspace names can only contain a combination of alphanumeric characters along with dash (-) and underscore (_). The name must be from 1 through 64 characters long.
	WorkspaceName string `pulumi:"workspaceName"`
}

// Batch AI Workspace information.
type LookupWorkspaceResult struct {
	// Time when the Workspace was created.
	CreationTime string `pulumi:"creationTime"`
	// The location of the resource
	Location string `pulumi:"location"`
	// The name of the resource
	Name string `pulumi:"name"`
	// The provisioned state of the Workspace
	ProvisioningState string `pulumi:"provisioningState"`
	// The time at which the workspace entered its current provisioning state.
	ProvisioningStateTransitionTime string `pulumi:"provisioningStateTransitionTime"`
	// The tags of the resource
	Tags map[string]string `pulumi:"tags"`
	// The type of the resource
	Type string `pulumi:"type"`
}
// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20190601preview

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupTaskRun(ctx *pulumi.Context, args *LookupTaskRunArgs, opts ...pulumi.InvokeOption) (*LookupTaskRunResult, error) {
	var rv LookupTaskRunResult
	err := ctx.Invoke("azure-nextgen:containerregistry/v20190601preview:getTaskRun", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupTaskRunArgs struct {
	// The name of the container registry.
	RegistryName string `pulumi:"registryName"`
	// The name of the resource group to which the container registry belongs.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the task run.
	TaskRunName string `pulumi:"taskRunName"`
}

// The task run that has the ARM resource and properties.
// The task run will have the information of request and result of a run.
type LookupTaskRunResult struct {
	// How the run should be forced to rerun even if the run request configuration has not changed
	ForceUpdateTag *string `pulumi:"forceUpdateTag"`
	// Identity for the resource.
	Identity *IdentityPropertiesResponse `pulumi:"identity"`
	// The location of the resource
	Location *string `pulumi:"location"`
	// The name of the resource.
	Name string `pulumi:"name"`
	// The provisioning state of this task run
	ProvisioningState string `pulumi:"provisioningState"`
	// The request (parameters) for the run
	RunRequest interface{} `pulumi:"runRequest"`
	// The result of this task run
	RunResult RunResponse `pulumi:"runResult"`
	// The type of the resource.
	Type string `pulumi:"type"`
}
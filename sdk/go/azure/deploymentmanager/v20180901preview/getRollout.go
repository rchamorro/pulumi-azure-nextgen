// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20180901preview

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupRollout(ctx *pulumi.Context, args *LookupRolloutArgs, opts ...pulumi.InvokeOption) (*LookupRolloutResult, error) {
	var rv LookupRolloutResult
	err := ctx.Invoke("azure-nextgen:deploymentmanager/v20180901preview:getRollout", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupRolloutArgs struct {
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Rollout retry attempt ordinal to get the result of. If not specified, result of the latest attempt will be returned.
	RetryAttempt *int `pulumi:"retryAttempt"`
	// The rollout name.
	RolloutName string `pulumi:"rolloutName"`
}

// Defines the rollout.
type LookupRolloutResult struct {
	// The reference to the artifact source resource Id where the payload is located.
	ArtifactSourceId *string `pulumi:"artifactSourceId"`
	// The version of the build being deployed.
	BuildVersion string `pulumi:"buildVersion"`
	// Identity for the resource.
	Identity *IdentityResponse `pulumi:"identity"`
	// The geo-location where the resource lives
	Location string `pulumi:"location"`
	// The name of the resource
	Name string `pulumi:"name"`
	// Operational information of the rollout.
	OperationInfo RolloutOperationInfoResponse `pulumi:"operationInfo"`
	// The detailed information on the services being deployed.
	Services []ServiceResponse `pulumi:"services"`
	// The current status of the rollout.
	Status string `pulumi:"status"`
	// The list of step groups that define the orchestration.
	StepGroups []StepResponse `pulumi:"stepGroups"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// The resource Id of the service topology from which service units are being referenced in step groups to be deployed.
	TargetServiceTopologyId string `pulumi:"targetServiceTopologyId"`
	// The cardinal count of total number of retries performed on the rollout at a given time.
	TotalRetryAttempts int `pulumi:"totalRetryAttempts"`
	// The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts.
	Type string `pulumi:"type"`
}
// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200301preview

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func ListClusterStreamingJobs(ctx *pulumi.Context, args *ListClusterStreamingJobsArgs, opts ...pulumi.InvokeOption) (*ListClusterStreamingJobsResult, error) {
	var rv ListClusterStreamingJobsResult
	err := ctx.Invoke("azure-nextgen:streamanalytics/v20200301preview:listClusterStreamingJobs", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type ListClusterStreamingJobsArgs struct {
	// The name of the cluster.
	ClusterName string `pulumi:"clusterName"`
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// A list of streaming jobs. Populated by a List operation.
type ListClusterStreamingJobsResult struct {
	// The URL to fetch the next set of streaming jobs.
	NextLink string `pulumi:"nextLink"`
	// A list of streaming jobs.
	Value []ClusterJobResponse `pulumi:"value"`
}
// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200901

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func ListShareSynchronizationDetails(ctx *pulumi.Context, args *ListShareSynchronizationDetailsArgs, opts ...pulumi.InvokeOption) (*ListShareSynchronizationDetailsResult, error) {
	var rv ListShareSynchronizationDetailsResult
	err := ctx.Invoke("azure-nextgen:datashare/v20200901:listShareSynchronizationDetails", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type ListShareSynchronizationDetailsArgs struct {
	// The name of the share account.
	AccountName string `pulumi:"accountName"`
	// Email of the user who created the synchronization
	ConsumerEmail *string `pulumi:"consumerEmail"`
	// Name of the user who created the synchronization
	ConsumerName *string `pulumi:"consumerName"`
	// Tenant name of the consumer who created the synchronization
	ConsumerTenantName *string `pulumi:"consumerTenantName"`
	// synchronization duration
	DurationMs *int `pulumi:"durationMs"`
	// End time of synchronization
	EndTime *string `pulumi:"endTime"`
	// Filters the results using OData syntax.
	Filter *string `pulumi:"filter"`
	// message of synchronization
	Message *string `pulumi:"message"`
	// Sorts the results using OData syntax.
	Orderby *string `pulumi:"orderby"`
	// The resource group name.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the share.
	ShareName string `pulumi:"shareName"`
	// Continuation token
	SkipToken *string `pulumi:"skipToken"`
	// start time of synchronization
	StartTime *string `pulumi:"startTime"`
	// Raw Status
	Status *string `pulumi:"status"`
	// Synchronization id
	SynchronizationId *string `pulumi:"synchronizationId"`
}

// details of synchronization
type ListShareSynchronizationDetailsResult struct {
	// The Url of next result page.
	NextLink *string `pulumi:"nextLink"`
	// Collection of items of type DataTransferObjects.
	Value []SynchronizationDetailsResponse `pulumi:"value"`
}

// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupBandwidthSchedule(ctx *pulumi.Context, args *LookupBandwidthScheduleArgs, opts ...pulumi.InvokeOption) (*LookupBandwidthScheduleResult, error) {
	var rv LookupBandwidthScheduleResult
	err := ctx.Invoke("azure-nextgen:databoxedge/latest:getBandwidthSchedule", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupBandwidthScheduleArgs struct {
	// The device name.
	DeviceName string `pulumi:"deviceName"`
	// The bandwidth schedule name.
	Name string `pulumi:"name"`
	// The resource group name.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// The bandwidth schedule details.
type LookupBandwidthScheduleResult struct {
	// The days of the week when this schedule is applicable.
	Days []string `pulumi:"days"`
	// The path ID that uniquely identifies the object.
	Id string `pulumi:"id"`
	// The object name.
	Name string `pulumi:"name"`
	// The bandwidth rate in Mbps.
	RateInMbps int `pulumi:"rateInMbps"`
	// The start time of the schedule in UTC.
	Start string `pulumi:"start"`
	// The stop time of the schedule in UTC.
	Stop string `pulumi:"stop"`
	// Bandwidth object related to ASE resource
	SystemData SystemDataResponse `pulumi:"systemData"`
	// The hierarchical type of the object.
	Type string `pulumi:"type"`
}

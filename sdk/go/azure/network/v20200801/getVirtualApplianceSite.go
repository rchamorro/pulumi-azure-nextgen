// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200801

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupVirtualApplianceSite(ctx *pulumi.Context, args *LookupVirtualApplianceSiteArgs, opts ...pulumi.InvokeOption) (*LookupVirtualApplianceSiteResult, error) {
	var rv LookupVirtualApplianceSiteResult
	err := ctx.Invoke("azure-nextgen:network/v20200801:getVirtualApplianceSite", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupVirtualApplianceSiteArgs struct {
	// The name of the Network Virtual Appliance.
	NetworkVirtualApplianceName string `pulumi:"networkVirtualApplianceName"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the site.
	SiteName string `pulumi:"siteName"`
}

// Virtual Appliance Site resource.
type LookupVirtualApplianceSiteResult struct {
	// Address Prefix.
	AddressPrefix *string `pulumi:"addressPrefix"`
	// A unique read-only string that changes whenever the resource is updated.
	Etag string `pulumi:"etag"`
	// Resource ID.
	Id *string `pulumi:"id"`
	// Name of the virtual appliance site.
	Name *string `pulumi:"name"`
	// Office 365 Policy.
	O365Policy *Office365PolicyPropertiesResponse `pulumi:"o365Policy"`
	// The provisioning state of the resource.
	ProvisioningState string `pulumi:"provisioningState"`
	// Site type.
	Type string `pulumi:"type"`
}

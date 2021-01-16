// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200401preview

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupConfigurationProfile(ctx *pulumi.Context, args *LookupConfigurationProfileArgs, opts ...pulumi.InvokeOption) (*LookupConfigurationProfileResult, error) {
	var rv LookupConfigurationProfileResult
	err := ctx.Invoke("azure-nextgen:changeanalysis/v20200401preview:getConfigurationProfile", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupConfigurationProfileArgs struct {
	// The name of the configuration profile. The profile name should be set to 'default', all other names will be overwritten.
	ProfileName string `pulumi:"profileName"`
}

// A profile object that contains change analysis configuration, such as notification settings, for this subscription
type LookupConfigurationProfileResult struct {
	// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
	Id string `pulumi:"id"`
	// The identity block returned by ARM resource that supports managed identity.
	Identity *ResourceIdentityResponse `pulumi:"identity"`
	// The name of the resource
	Name string `pulumi:"name"`
	// The properties of a configuration profile.
	Properties ConfigurationProfileResourcePropertiesResponse `pulumi:"properties"`
	// Top level metadata https://github.com/Azure/azure-resource-manager-rpc/blob/master/v1.0/common-api-contracts.md#system-metadata-for-all-azure-resources
	SystemData *SystemDataResponse `pulumi:"systemData"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type string `pulumi:"type"`
}

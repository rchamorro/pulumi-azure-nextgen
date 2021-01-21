// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupRemoteRenderingAccount(ctx *pulumi.Context, args *LookupRemoteRenderingAccountArgs, opts ...pulumi.InvokeOption) (*LookupRemoteRenderingAccountResult, error) {
	var rv LookupRemoteRenderingAccountResult
	err := ctx.Invoke("azure-nextgen:mixedreality/latest:getRemoteRenderingAccount", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupRemoteRenderingAccountArgs struct {
	// Name of an Mixed Reality Account.
	AccountName string `pulumi:"accountName"`
	// Name of an Azure resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// RemoteRenderingAccount Response.
type LookupRemoteRenderingAccountResult struct {
	// Correspond domain name of certain Spatial Anchors Account
	AccountDomain string `pulumi:"accountDomain"`
	// unique id of certain account.
	AccountId string `pulumi:"accountId"`
	// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
	Id string `pulumi:"id"`
	// The identity associated with this account
	Identity *IdentityResponse `pulumi:"identity"`
	// The kind of account, if supported
	Kind *SkuResponse `pulumi:"kind"`
	// The geo-location where the resource lives
	Location string `pulumi:"location"`
	// The name of the resource
	Name string `pulumi:"name"`
	// The plan associated with this account
	Plan *IdentityResponse `pulumi:"plan"`
	// The sku associated with this account
	Sku *SkuResponse `pulumi:"sku"`
	// System metadata for this account
	SystemData SystemDataResponse `pulumi:"systemData"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type string `pulumi:"type"`
}

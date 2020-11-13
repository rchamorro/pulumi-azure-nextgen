// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupDomainService(ctx *pulumi.Context, args *LookupDomainServiceArgs, opts ...pulumi.InvokeOption) (*LookupDomainServiceResult, error) {
	var rv LookupDomainServiceResult
	err := ctx.Invoke("azure-nextgen:aad/latest:getDomainService", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupDomainServiceArgs struct {
	// The name of the domain service.
	DomainServiceName string `pulumi:"domainServiceName"`
	// The name of the resource group within the user's subscription. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// Domain service.
type LookupDomainServiceResult struct {
	// Deployment Id
	DeploymentId string `pulumi:"deploymentId"`
	// Domain Configuration Type
	DomainConfigurationType *string `pulumi:"domainConfigurationType"`
	// The name of the Azure domain that the user would like to deploy Domain Services to.
	DomainName *string `pulumi:"domainName"`
	// DomainSecurity Settings
	DomainSecuritySettings *DomainSecuritySettingsResponse `pulumi:"domainSecuritySettings"`
	// Resource etag
	Etag *string `pulumi:"etag"`
	// Enabled or Disabled flag to turn on Group-based filtered sync
	FilteredSync *string `pulumi:"filteredSync"`
	// Secure LDAP Settings
	LdapsSettings *LdapsSettingsResponse `pulumi:"ldapsSettings"`
	// Resource location
	Location *string `pulumi:"location"`
	// Resource name
	Name string `pulumi:"name"`
	// Notification Settings
	NotificationSettings *NotificationSettingsResponse `pulumi:"notificationSettings"`
	// the current deployment or provisioning state, which only appears in the response.
	ProvisioningState string `pulumi:"provisioningState"`
	// List of ReplicaSets
	ReplicaSets []ReplicaSetResponse `pulumi:"replicaSets"`
	// Resource Forest Settings
	ResourceForestSettings *ResourceForestSettingsResponse `pulumi:"resourceForestSettings"`
	// Sku Type
	Sku *string `pulumi:"sku"`
	// SyncOwner ReplicaSet Id
	SyncOwner string `pulumi:"syncOwner"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// Azure Active Directory Tenant Id
	TenantId string `pulumi:"tenantId"`
	// Resource type
	Type string `pulumi:"type"`
	// Data Model Version
	Version int `pulumi:"version"`
}

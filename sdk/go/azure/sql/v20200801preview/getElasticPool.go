// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200801preview

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupElasticPool(ctx *pulumi.Context, args *LookupElasticPoolArgs, opts ...pulumi.InvokeOption) (*LookupElasticPoolResult, error) {
	var rv LookupElasticPoolResult
	err := ctx.Invoke("azure-nextgen:sql/v20200801preview:getElasticPool", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupElasticPoolArgs struct {
	// The name of the elastic pool.
	ElasticPoolName string `pulumi:"elasticPoolName"`
	// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the server.
	ServerName string `pulumi:"serverName"`
}

// An elastic pool.
type LookupElasticPoolResult struct {
	// The creation date of the elastic pool (ISO8601 format).
	CreationDate string `pulumi:"creationDate"`
	// Resource ID.
	Id string `pulumi:"id"`
	// Kind of elastic pool. This is metadata used for the Azure portal experience.
	Kind string `pulumi:"kind"`
	// The license type to apply for this elastic pool.
	LicenseType *string `pulumi:"licenseType"`
	// Resource location.
	Location string `pulumi:"location"`
	// Maintenance configuration id assigned to the elastic pool. This configuration defines the period when the maintenance updates will will occur.
	MaintenanceConfigurationId *string `pulumi:"maintenanceConfigurationId"`
	// The storage limit for the database elastic pool in bytes.
	MaxSizeBytes *float64 `pulumi:"maxSizeBytes"`
	// Resource name.
	Name string `pulumi:"name"`
	// The per database settings for the elastic pool.
	PerDatabaseSettings *ElasticPoolPerDatabaseSettingsResponse `pulumi:"perDatabaseSettings"`
	// The elastic pool SKU.
	//
	// The list of SKUs may vary by region and support offer. To determine the SKUs (including the SKU name, tier/edition, family, and capacity) that are available to your subscription in an Azure region, use the `Capabilities_ListByLocation` REST API or the following command:
	Sku *SkuResponse `pulumi:"sku"`
	// The state of the elastic pool.
	State string `pulumi:"state"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Resource type.
	Type string `pulumi:"type"`
	// Whether or not this elastic pool is zone redundant, which means the replicas of this elastic pool will be spread across multiple availability zones.
	ZoneRedundant *bool `pulumi:"zoneRedundant"`
}

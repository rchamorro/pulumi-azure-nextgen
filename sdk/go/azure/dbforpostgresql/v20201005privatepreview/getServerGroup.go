// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20201005privatepreview

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupServerGroup(ctx *pulumi.Context, args *LookupServerGroupArgs, opts ...pulumi.InvokeOption) (*LookupServerGroupResult, error) {
	var rv LookupServerGroupResult
	err := ctx.Invoke("azure-nextgen:dbforpostgresql/v20201005privatepreview:getServerGroup", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupServerGroupArgs struct {
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the server group.
	ServerGroupName string `pulumi:"serverGroupName"`
}

// Represents a server group for create.
type LookupServerGroupResult struct {
	// The administrator's login name of servers in server group. Can only be specified when the server is being created (and is required for creation).
	AdministratorLogin *string `pulumi:"administratorLogin"`
	// The password of the administrator login.
	AdministratorLoginPassword *string `pulumi:"administratorLoginPassword"`
	// Availability Zone information of the server group.
	AvailabilityZone *string `pulumi:"availabilityZone"`
	// The backup retention days for server group.
	BackupRetentionDays *int `pulumi:"backupRetentionDays"`
	// The Citus version of server group.
	CitusVersion *string `pulumi:"citusVersion"`
	// The mode to create a new server group.
	CreateMode *string `pulumi:"createMode"`
	// The delegated subnet arguments for a server group.
	DelegatedSubnetArguments *ServerGroupPropertiesResponseDelegatedSubnetArguments `pulumi:"delegatedSubnetArguments"`
	// The earliest restore point time (ISO8601 format) for server group.
	EarliestRestoreTime string `pulumi:"earliestRestoreTime"`
	// If Citus MX is enabled or not for the server group.
	EnableMx *bool `pulumi:"enableMx"`
	// If shards on coordinator is enabled or not for the server group.
	EnableShardsOnCoordinator *bool `pulumi:"enableShardsOnCoordinator"`
	// If ZFS compression is enabled or not for the server group.
	EnableZfs *bool `pulumi:"enableZfs"`
	// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
	Id string `pulumi:"id"`
	// The geo-location where the resource lives
	Location string `pulumi:"location"`
	// Maintenance window of a server group.
	MaintenanceWindow *MaintenanceWindowResponse `pulumi:"maintenanceWindow"`
	// The name of the resource
	Name string `pulumi:"name"`
	// Restore point creation time (ISO8601 format), specifying the time to restore from. It's required when 'createMode' is 'PointInTimeRestore'
	PointInTimeUTC *string `pulumi:"pointInTimeUTC"`
	// The PostgreSQL version of server group.
	PostgresqlVersion *string `pulumi:"postgresqlVersion"`
	// The resource provider type of server group.
	ResourceProviderType string `pulumi:"resourceProviderType"`
	// The list of server role groups.
	ServerRoleGroups []ServerRoleGroupResponse `pulumi:"serverRoleGroups"`
	// The source server group location to restore from. It's required when 'createMode' is 'PointInTimeRestore'
	SourceLocation *string `pulumi:"sourceLocation"`
	// The source resource group name to restore from. It's required when 'createMode' is 'PointInTimeRestore'
	SourceResourceGroupName *string `pulumi:"sourceResourceGroupName"`
	// The source server group name to restore from. It's required when 'createMode' is 'PointInTimeRestore'
	SourceServerGroupName *string `pulumi:"sourceServerGroupName"`
	// The source subscription id to restore from. It's required when 'createMode' is 'PointInTimeRestore'
	SourceSubscriptionId *string `pulumi:"sourceSubscriptionId"`
	// Standby Availability Zone information of the server group.
	StandbyAvailabilityZone *string `pulumi:"standbyAvailabilityZone"`
	// A state of a server group that is visible to user.
	State string `pulumi:"state"`
	// The system metadata relating to this resource
	SystemData SystemDataResponse `pulumi:"systemData"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type string `pulumi:"type"`
}

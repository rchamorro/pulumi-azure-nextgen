// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20180601preview

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// An Azure SQL managed instance.
type ManagedInstance struct {
	pulumi.CustomResourceState

	// Administrator username for the managed instance. Can only be specified when the managed instance is being created (and is required for creation).
	AdministratorLogin pulumi.StringPtrOutput `pulumi:"administratorLogin"`
	// The administrator login password (required for managed instance creation).
	AdministratorLoginPassword pulumi.StringPtrOutput `pulumi:"administratorLoginPassword"`
	// Collation of the managed instance.
	Collation pulumi.StringPtrOutput `pulumi:"collation"`
	// The Dns Zone that the managed instance is in.
	DnsZone pulumi.StringOutput `pulumi:"dnsZone"`
	// The resource id of another managed instance whose DNS zone this managed instance will share after creation.
	DnsZonePartner pulumi.StringPtrOutput `pulumi:"dnsZonePartner"`
	// The fully qualified domain name of the managed instance.
	FullyQualifiedDomainName pulumi.StringOutput `pulumi:"fullyQualifiedDomainName"`
	// The Azure Active Directory identity of the managed instance.
	Identity ResourceIdentityResponsePtrOutput `pulumi:"identity"`
	// The Id of the instance pool this managed server belongs to.
	InstancePoolId pulumi.StringPtrOutput `pulumi:"instancePoolId"`
	// The license type. Possible values are 'LicenseIncluded' (regular price inclusive of a new SQL license) and 'BasePrice' (discounted AHB price for bringing your own SQL licenses).
	LicenseType pulumi.StringPtrOutput `pulumi:"licenseType"`
	// Resource location.
	Location pulumi.StringOutput `pulumi:"location"`
	// Specifies maintenance configuration id to apply to this managed instance.
	MaintenanceConfigurationId pulumi.StringPtrOutput `pulumi:"maintenanceConfigurationId"`
	// Specifies the mode of database creation.
	//
	// Default: Regular instance creation.
	//
	// Restore: Creates an instance by restoring a set of backups to specific point in time. RestorePointInTime and SourceManagedInstanceId must be specified.
	ManagedInstanceCreateMode pulumi.StringPtrOutput `pulumi:"managedInstanceCreateMode"`
	// Minimal TLS version. Allowed values: 'None', '1.0', '1.1', '1.2'
	MinimalTlsVersion pulumi.StringPtrOutput `pulumi:"minimalTlsVersion"`
	// Resource name.
	Name pulumi.StringOutput `pulumi:"name"`
	// Connection type used for connecting to the instance.
	ProxyOverride pulumi.StringPtrOutput `pulumi:"proxyOverride"`
	// Whether or not the public data endpoint is enabled.
	PublicDataEndpointEnabled pulumi.BoolPtrOutput `pulumi:"publicDataEndpointEnabled"`
	// Specifies the point in time (ISO8601 format) of the source database that will be restored to create the new database.
	RestorePointInTime pulumi.StringPtrOutput `pulumi:"restorePointInTime"`
	// Managed instance SKU. Allowed values for sku.name: GP_Gen4, GP_Gen5, BC_Gen4, BC_Gen5
	Sku SkuResponsePtrOutput `pulumi:"sku"`
	// The resource identifier of the source managed instance associated with create operation of this instance.
	SourceManagedInstanceId pulumi.StringPtrOutput `pulumi:"sourceManagedInstanceId"`
	// The state of the managed instance.
	State pulumi.StringOutput `pulumi:"state"`
	// Storage size in GB. Minimum value: 32. Maximum value: 8192. Increments of 32 GB allowed only.
	StorageSizeInGB pulumi.IntPtrOutput `pulumi:"storageSizeInGB"`
	// Subnet resource ID for the managed instance.
	SubnetId pulumi.StringPtrOutput `pulumi:"subnetId"`
	// Resource tags.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Id of the timezone. Allowed values are timezones supported by Windows.
	// Windows keeps details on supported timezones, including the id, in registry under
	// KEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Time Zones.
	// You can get those registry values via SQL Server by querying SELECT name AS timezone_id FROM sys.time_zone_info.
	// List of Ids can also be obtained by executing [System.TimeZoneInfo]::GetSystemTimeZones() in PowerShell.
	// An example of valid timezone id is "Pacific Standard Time" or "W. Europe Standard Time".
	TimezoneId pulumi.StringPtrOutput `pulumi:"timezoneId"`
	// Resource type.
	Type pulumi.StringOutput `pulumi:"type"`
	// The number of vCores. Allowed values: 8, 16, 24, 32, 40, 64, 80.
	VCores pulumi.IntPtrOutput `pulumi:"vCores"`
}

// NewManagedInstance registers a new resource with the given unique name, arguments, and options.
func NewManagedInstance(ctx *pulumi.Context,
	name string, args *ManagedInstanceArgs, opts ...pulumi.ResourceOption) (*ManagedInstance, error) {
	if args == nil || args.Location == nil {
		return nil, errors.New("missing required argument 'Location'")
	}
	if args == nil || args.ManagedInstanceName == nil {
		return nil, errors.New("missing required argument 'ManagedInstanceName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &ManagedInstanceArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:sql/v20150501preview:ManagedInstance"),
		},
		{
			Type: pulumi.String("azure-nextgen:sql/v20200202preview:ManagedInstance"),
		},
	})
	opts = append(opts, aliases)
	var resource ManagedInstance
	err := ctx.RegisterResource("azure-nextgen:sql/v20180601preview:ManagedInstance", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetManagedInstance gets an existing ManagedInstance resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetManagedInstance(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ManagedInstanceState, opts ...pulumi.ResourceOption) (*ManagedInstance, error) {
	var resource ManagedInstance
	err := ctx.ReadResource("azure-nextgen:sql/v20180601preview:ManagedInstance", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ManagedInstance resources.
type managedInstanceState struct {
	// Administrator username for the managed instance. Can only be specified when the managed instance is being created (and is required for creation).
	AdministratorLogin *string `pulumi:"administratorLogin"`
	// The administrator login password (required for managed instance creation).
	AdministratorLoginPassword *string `pulumi:"administratorLoginPassword"`
	// Collation of the managed instance.
	Collation *string `pulumi:"collation"`
	// The Dns Zone that the managed instance is in.
	DnsZone *string `pulumi:"dnsZone"`
	// The resource id of another managed instance whose DNS zone this managed instance will share after creation.
	DnsZonePartner *string `pulumi:"dnsZonePartner"`
	// The fully qualified domain name of the managed instance.
	FullyQualifiedDomainName *string `pulumi:"fullyQualifiedDomainName"`
	// The Azure Active Directory identity of the managed instance.
	Identity *ResourceIdentityResponse `pulumi:"identity"`
	// The Id of the instance pool this managed server belongs to.
	InstancePoolId *string `pulumi:"instancePoolId"`
	// The license type. Possible values are 'LicenseIncluded' (regular price inclusive of a new SQL license) and 'BasePrice' (discounted AHB price for bringing your own SQL licenses).
	LicenseType *string `pulumi:"licenseType"`
	// Resource location.
	Location *string `pulumi:"location"`
	// Specifies maintenance configuration id to apply to this managed instance.
	MaintenanceConfigurationId *string `pulumi:"maintenanceConfigurationId"`
	// Specifies the mode of database creation.
	//
	// Default: Regular instance creation.
	//
	// Restore: Creates an instance by restoring a set of backups to specific point in time. RestorePointInTime and SourceManagedInstanceId must be specified.
	ManagedInstanceCreateMode *string `pulumi:"managedInstanceCreateMode"`
	// Minimal TLS version. Allowed values: 'None', '1.0', '1.1', '1.2'
	MinimalTlsVersion *string `pulumi:"minimalTlsVersion"`
	// Resource name.
	Name *string `pulumi:"name"`
	// Connection type used for connecting to the instance.
	ProxyOverride *string `pulumi:"proxyOverride"`
	// Whether or not the public data endpoint is enabled.
	PublicDataEndpointEnabled *bool `pulumi:"publicDataEndpointEnabled"`
	// Specifies the point in time (ISO8601 format) of the source database that will be restored to create the new database.
	RestorePointInTime *string `pulumi:"restorePointInTime"`
	// Managed instance SKU. Allowed values for sku.name: GP_Gen4, GP_Gen5, BC_Gen4, BC_Gen5
	Sku *SkuResponse `pulumi:"sku"`
	// The resource identifier of the source managed instance associated with create operation of this instance.
	SourceManagedInstanceId *string `pulumi:"sourceManagedInstanceId"`
	// The state of the managed instance.
	State *string `pulumi:"state"`
	// Storage size in GB. Minimum value: 32. Maximum value: 8192. Increments of 32 GB allowed only.
	StorageSizeInGB *int `pulumi:"storageSizeInGB"`
	// Subnet resource ID for the managed instance.
	SubnetId *string `pulumi:"subnetId"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Id of the timezone. Allowed values are timezones supported by Windows.
	// Windows keeps details on supported timezones, including the id, in registry under
	// KEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Time Zones.
	// You can get those registry values via SQL Server by querying SELECT name AS timezone_id FROM sys.time_zone_info.
	// List of Ids can also be obtained by executing [System.TimeZoneInfo]::GetSystemTimeZones() in PowerShell.
	// An example of valid timezone id is "Pacific Standard Time" or "W. Europe Standard Time".
	TimezoneId *string `pulumi:"timezoneId"`
	// Resource type.
	Type *string `pulumi:"type"`
	// The number of vCores. Allowed values: 8, 16, 24, 32, 40, 64, 80.
	VCores *int `pulumi:"vCores"`
}

type ManagedInstanceState struct {
	// Administrator username for the managed instance. Can only be specified when the managed instance is being created (and is required for creation).
	AdministratorLogin pulumi.StringPtrInput
	// The administrator login password (required for managed instance creation).
	AdministratorLoginPassword pulumi.StringPtrInput
	// Collation of the managed instance.
	Collation pulumi.StringPtrInput
	// The Dns Zone that the managed instance is in.
	DnsZone pulumi.StringPtrInput
	// The resource id of another managed instance whose DNS zone this managed instance will share after creation.
	DnsZonePartner pulumi.StringPtrInput
	// The fully qualified domain name of the managed instance.
	FullyQualifiedDomainName pulumi.StringPtrInput
	// The Azure Active Directory identity of the managed instance.
	Identity ResourceIdentityResponsePtrInput
	// The Id of the instance pool this managed server belongs to.
	InstancePoolId pulumi.StringPtrInput
	// The license type. Possible values are 'LicenseIncluded' (regular price inclusive of a new SQL license) and 'BasePrice' (discounted AHB price for bringing your own SQL licenses).
	LicenseType pulumi.StringPtrInput
	// Resource location.
	Location pulumi.StringPtrInput
	// Specifies maintenance configuration id to apply to this managed instance.
	MaintenanceConfigurationId pulumi.StringPtrInput
	// Specifies the mode of database creation.
	//
	// Default: Regular instance creation.
	//
	// Restore: Creates an instance by restoring a set of backups to specific point in time. RestorePointInTime and SourceManagedInstanceId must be specified.
	ManagedInstanceCreateMode pulumi.StringPtrInput
	// Minimal TLS version. Allowed values: 'None', '1.0', '1.1', '1.2'
	MinimalTlsVersion pulumi.StringPtrInput
	// Resource name.
	Name pulumi.StringPtrInput
	// Connection type used for connecting to the instance.
	ProxyOverride pulumi.StringPtrInput
	// Whether or not the public data endpoint is enabled.
	PublicDataEndpointEnabled pulumi.BoolPtrInput
	// Specifies the point in time (ISO8601 format) of the source database that will be restored to create the new database.
	RestorePointInTime pulumi.StringPtrInput
	// Managed instance SKU. Allowed values for sku.name: GP_Gen4, GP_Gen5, BC_Gen4, BC_Gen5
	Sku SkuResponsePtrInput
	// The resource identifier of the source managed instance associated with create operation of this instance.
	SourceManagedInstanceId pulumi.StringPtrInput
	// The state of the managed instance.
	State pulumi.StringPtrInput
	// Storage size in GB. Minimum value: 32. Maximum value: 8192. Increments of 32 GB allowed only.
	StorageSizeInGB pulumi.IntPtrInput
	// Subnet resource ID for the managed instance.
	SubnetId pulumi.StringPtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// Id of the timezone. Allowed values are timezones supported by Windows.
	// Windows keeps details on supported timezones, including the id, in registry under
	// KEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Time Zones.
	// You can get those registry values via SQL Server by querying SELECT name AS timezone_id FROM sys.time_zone_info.
	// List of Ids can also be obtained by executing [System.TimeZoneInfo]::GetSystemTimeZones() in PowerShell.
	// An example of valid timezone id is "Pacific Standard Time" or "W. Europe Standard Time".
	TimezoneId pulumi.StringPtrInput
	// Resource type.
	Type pulumi.StringPtrInput
	// The number of vCores. Allowed values: 8, 16, 24, 32, 40, 64, 80.
	VCores pulumi.IntPtrInput
}

func (ManagedInstanceState) ElementType() reflect.Type {
	return reflect.TypeOf((*managedInstanceState)(nil)).Elem()
}

type managedInstanceArgs struct {
	// Administrator username for the managed instance. Can only be specified when the managed instance is being created (and is required for creation).
	AdministratorLogin *string `pulumi:"administratorLogin"`
	// The administrator login password (required for managed instance creation).
	AdministratorLoginPassword *string `pulumi:"administratorLoginPassword"`
	// Collation of the managed instance.
	Collation *string `pulumi:"collation"`
	// The resource id of another managed instance whose DNS zone this managed instance will share after creation.
	DnsZonePartner *string `pulumi:"dnsZonePartner"`
	// The Azure Active Directory identity of the managed instance.
	Identity *ResourceIdentity `pulumi:"identity"`
	// The Id of the instance pool this managed server belongs to.
	InstancePoolId *string `pulumi:"instancePoolId"`
	// The license type. Possible values are 'LicenseIncluded' (regular price inclusive of a new SQL license) and 'BasePrice' (discounted AHB price for bringing your own SQL licenses).
	LicenseType *string `pulumi:"licenseType"`
	// Resource location.
	Location string `pulumi:"location"`
	// Specifies maintenance configuration id to apply to this managed instance.
	MaintenanceConfigurationId *string `pulumi:"maintenanceConfigurationId"`
	// Specifies the mode of database creation.
	//
	// Default: Regular instance creation.
	//
	// Restore: Creates an instance by restoring a set of backups to specific point in time. RestorePointInTime and SourceManagedInstanceId must be specified.
	ManagedInstanceCreateMode *string `pulumi:"managedInstanceCreateMode"`
	// The name of the managed instance.
	ManagedInstanceName string `pulumi:"managedInstanceName"`
	// Minimal TLS version. Allowed values: 'None', '1.0', '1.1', '1.2'
	MinimalTlsVersion *string `pulumi:"minimalTlsVersion"`
	// Connection type used for connecting to the instance.
	ProxyOverride *string `pulumi:"proxyOverride"`
	// Whether or not the public data endpoint is enabled.
	PublicDataEndpointEnabled *bool `pulumi:"publicDataEndpointEnabled"`
	// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Specifies the point in time (ISO8601 format) of the source database that will be restored to create the new database.
	RestorePointInTime *string `pulumi:"restorePointInTime"`
	// Managed instance SKU. Allowed values for sku.name: GP_Gen4, GP_Gen5, BC_Gen4, BC_Gen5
	Sku *Sku `pulumi:"sku"`
	// The resource identifier of the source managed instance associated with create operation of this instance.
	SourceManagedInstanceId *string `pulumi:"sourceManagedInstanceId"`
	// Storage size in GB. Minimum value: 32. Maximum value: 8192. Increments of 32 GB allowed only.
	StorageSizeInGB *int `pulumi:"storageSizeInGB"`
	// Subnet resource ID for the managed instance.
	SubnetId *string `pulumi:"subnetId"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// Id of the timezone. Allowed values are timezones supported by Windows.
	// Windows keeps details on supported timezones, including the id, in registry under
	// KEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Time Zones.
	// You can get those registry values via SQL Server by querying SELECT name AS timezone_id FROM sys.time_zone_info.
	// List of Ids can also be obtained by executing [System.TimeZoneInfo]::GetSystemTimeZones() in PowerShell.
	// An example of valid timezone id is "Pacific Standard Time" or "W. Europe Standard Time".
	TimezoneId *string `pulumi:"timezoneId"`
	// The number of vCores. Allowed values: 8, 16, 24, 32, 40, 64, 80.
	VCores *int `pulumi:"vCores"`
}

// The set of arguments for constructing a ManagedInstance resource.
type ManagedInstanceArgs struct {
	// Administrator username for the managed instance. Can only be specified when the managed instance is being created (and is required for creation).
	AdministratorLogin pulumi.StringPtrInput
	// The administrator login password (required for managed instance creation).
	AdministratorLoginPassword pulumi.StringPtrInput
	// Collation of the managed instance.
	Collation pulumi.StringPtrInput
	// The resource id of another managed instance whose DNS zone this managed instance will share after creation.
	DnsZonePartner pulumi.StringPtrInput
	// The Azure Active Directory identity of the managed instance.
	Identity ResourceIdentityPtrInput
	// The Id of the instance pool this managed server belongs to.
	InstancePoolId pulumi.StringPtrInput
	// The license type. Possible values are 'LicenseIncluded' (regular price inclusive of a new SQL license) and 'BasePrice' (discounted AHB price for bringing your own SQL licenses).
	LicenseType pulumi.StringPtrInput
	// Resource location.
	Location pulumi.StringInput
	// Specifies maintenance configuration id to apply to this managed instance.
	MaintenanceConfigurationId pulumi.StringPtrInput
	// Specifies the mode of database creation.
	//
	// Default: Regular instance creation.
	//
	// Restore: Creates an instance by restoring a set of backups to specific point in time. RestorePointInTime and SourceManagedInstanceId must be specified.
	ManagedInstanceCreateMode pulumi.StringPtrInput
	// The name of the managed instance.
	ManagedInstanceName pulumi.StringInput
	// Minimal TLS version. Allowed values: 'None', '1.0', '1.1', '1.2'
	MinimalTlsVersion pulumi.StringPtrInput
	// Connection type used for connecting to the instance.
	ProxyOverride pulumi.StringPtrInput
	// Whether or not the public data endpoint is enabled.
	PublicDataEndpointEnabled pulumi.BoolPtrInput
	// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
	ResourceGroupName pulumi.StringInput
	// Specifies the point in time (ISO8601 format) of the source database that will be restored to create the new database.
	RestorePointInTime pulumi.StringPtrInput
	// Managed instance SKU. Allowed values for sku.name: GP_Gen4, GP_Gen5, BC_Gen4, BC_Gen5
	Sku SkuPtrInput
	// The resource identifier of the source managed instance associated with create operation of this instance.
	SourceManagedInstanceId pulumi.StringPtrInput
	// Storage size in GB. Minimum value: 32. Maximum value: 8192. Increments of 32 GB allowed only.
	StorageSizeInGB pulumi.IntPtrInput
	// Subnet resource ID for the managed instance.
	SubnetId pulumi.StringPtrInput
	// Resource tags.
	Tags pulumi.StringMapInput
	// Id of the timezone. Allowed values are timezones supported by Windows.
	// Windows keeps details on supported timezones, including the id, in registry under
	// KEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Time Zones.
	// You can get those registry values via SQL Server by querying SELECT name AS timezone_id FROM sys.time_zone_info.
	// List of Ids can also be obtained by executing [System.TimeZoneInfo]::GetSystemTimeZones() in PowerShell.
	// An example of valid timezone id is "Pacific Standard Time" or "W. Europe Standard Time".
	TimezoneId pulumi.StringPtrInput
	// The number of vCores. Allowed values: 8, 16, 24, 32, 40, 64, 80.
	VCores pulumi.IntPtrInput
}

func (ManagedInstanceArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*managedInstanceArgs)(nil)).Elem()
}

type ManagedInstanceInput interface {
	pulumi.Input

	ToManagedInstanceOutput() ManagedInstanceOutput
	ToManagedInstanceOutputWithContext(ctx context.Context) ManagedInstanceOutput
}

func (ManagedInstance) ElementType() reflect.Type {
	return reflect.TypeOf((*ManagedInstance)(nil)).Elem()
}

func (i ManagedInstance) ToManagedInstanceOutput() ManagedInstanceOutput {
	return i.ToManagedInstanceOutputWithContext(context.Background())
}

func (i ManagedInstance) ToManagedInstanceOutputWithContext(ctx context.Context) ManagedInstanceOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ManagedInstanceOutput)
}

type ManagedInstanceOutput struct {
	*pulumi.OutputState
}

func (ManagedInstanceOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ManagedInstanceOutput)(nil)).Elem()
}

func (o ManagedInstanceOutput) ToManagedInstanceOutput() ManagedInstanceOutput {
	return o
}

func (o ManagedInstanceOutput) ToManagedInstanceOutputWithContext(ctx context.Context) ManagedInstanceOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(ManagedInstanceOutput{})
}

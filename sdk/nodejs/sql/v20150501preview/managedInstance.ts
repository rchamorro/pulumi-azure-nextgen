// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * An Azure SQL managed instance.
 */
export class ManagedInstance extends pulumi.CustomResource {
    /**
     * Get an existing ManagedInstance resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ManagedInstance {
        return new ManagedInstance(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:sql/v20150501preview:ManagedInstance';

    /**
     * Returns true if the given object is an instance of ManagedInstance.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ManagedInstance {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ManagedInstance.__pulumiType;
    }

    /**
     * Administrator username for the managed instance. Can only be specified when the managed instance is being created (and is required for creation).
     */
    public readonly administratorLogin!: pulumi.Output<string | undefined>;
    /**
     * The administrator login password (required for managed instance creation).
     */
    public readonly administratorLoginPassword!: pulumi.Output<string | undefined>;
    /**
     * Collation of the managed instance.
     */
    public readonly collation!: pulumi.Output<string | undefined>;
    /**
     * The Dns Zone that the managed instance is in.
     */
    public /*out*/ readonly dnsZone!: pulumi.Output<string>;
    /**
     * The resource id of another managed instance whose DNS zone this managed instance will share after creation.
     */
    public readonly dnsZonePartner!: pulumi.Output<string | undefined>;
    /**
     * The fully qualified domain name of the managed instance.
     */
    public /*out*/ readonly fullyQualifiedDomainName!: pulumi.Output<string>;
    /**
     * The Azure Active Directory identity of the managed instance.
     */
    public readonly identity!: pulumi.Output<outputs.sql.v20150501preview.ResourceIdentityResponse | undefined>;
    /**
     * The Id of the instance pool this managed server belongs to.
     */
    public readonly instancePoolId!: pulumi.Output<string | undefined>;
    /**
     * The license type. Possible values are 'LicenseIncluded' (regular price inclusive of a new SQL license) and 'BasePrice' (discounted AHB price for bringing your own SQL licenses).
     */
    public readonly licenseType!: pulumi.Output<string | undefined>;
    /**
     * Resource location.
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * Specifies maintenance configuration id to apply to this managed instance.
     */
    public readonly maintenanceConfigurationId!: pulumi.Output<string | undefined>;
    /**
     * Specifies the mode of database creation.
     * 
     * Default: Regular instance creation.
     * 
     * Restore: Creates an instance by restoring a set of backups to specific point in time. RestorePointInTime and SourceManagedInstanceId must be specified.
     */
    public readonly managedInstanceCreateMode!: pulumi.Output<string | undefined>;
    /**
     * Minimal TLS version. Allowed values: 'None', '1.0', '1.1', '1.2'
     */
    public readonly minimalTlsVersion!: pulumi.Output<string | undefined>;
    /**
     * Resource name.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Connection type used for connecting to the instance.
     */
    public readonly proxyOverride!: pulumi.Output<string | undefined>;
    /**
     * Whether or not the public data endpoint is enabled.
     */
    public readonly publicDataEndpointEnabled!: pulumi.Output<boolean | undefined>;
    /**
     * Specifies the point in time (ISO8601 format) of the source database that will be restored to create the new database.
     */
    public readonly restorePointInTime!: pulumi.Output<string | undefined>;
    /**
     * Managed instance SKU. Allowed values for sku.name: GP_Gen4, GP_Gen5, BC_Gen4, BC_Gen5
     */
    public readonly sku!: pulumi.Output<outputs.sql.v20150501preview.SkuResponse | undefined>;
    /**
     * The resource identifier of the source managed instance associated with create operation of this instance.
     */
    public readonly sourceManagedInstanceId!: pulumi.Output<string | undefined>;
    /**
     * The state of the managed instance.
     */
    public /*out*/ readonly state!: pulumi.Output<string>;
    /**
     * Storage size in GB. Minimum value: 32. Maximum value: 8192. Increments of 32 GB allowed only.
     */
    public readonly storageSizeInGB!: pulumi.Output<number | undefined>;
    /**
     * Subnet resource ID for the managed instance.
     */
    public readonly subnetId!: pulumi.Output<string | undefined>;
    /**
     * Resource tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Id of the timezone. Allowed values are timezones supported by Windows.
     * Windows keeps details on supported timezones, including the id, in registry under
     * KEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Time Zones.
     * You can get those registry values via SQL Server by querying SELECT name AS timezone_id FROM sys.time_zone_info.
     * List of Ids can also be obtained by executing [System.TimeZoneInfo]::GetSystemTimeZones() in PowerShell.
     * An example of valid timezone id is "Pacific Standard Time" or "W. Europe Standard Time".
     */
    public readonly timezoneId!: pulumi.Output<string | undefined>;
    /**
     * Resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * The number of vCores. Allowed values: 8, 16, 24, 32, 40, 64, 80.
     */
    public readonly vCores!: pulumi.Output<number | undefined>;

    /**
     * Create a ManagedInstance resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ManagedInstanceArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.location === undefined) {
                throw new Error("Missing required property 'location'");
            }
            if (!args || args.managedInstanceName === undefined) {
                throw new Error("Missing required property 'managedInstanceName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["administratorLogin"] = args ? args.administratorLogin : undefined;
            inputs["administratorLoginPassword"] = args ? args.administratorLoginPassword : undefined;
            inputs["collation"] = args ? args.collation : undefined;
            inputs["dnsZonePartner"] = args ? args.dnsZonePartner : undefined;
            inputs["identity"] = args ? args.identity : undefined;
            inputs["instancePoolId"] = args ? args.instancePoolId : undefined;
            inputs["licenseType"] = args ? args.licenseType : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["maintenanceConfigurationId"] = args ? args.maintenanceConfigurationId : undefined;
            inputs["managedInstanceCreateMode"] = args ? args.managedInstanceCreateMode : undefined;
            inputs["managedInstanceName"] = args ? args.managedInstanceName : undefined;
            inputs["minimalTlsVersion"] = args ? args.minimalTlsVersion : undefined;
            inputs["proxyOverride"] = args ? args.proxyOverride : undefined;
            inputs["publicDataEndpointEnabled"] = args ? args.publicDataEndpointEnabled : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["restorePointInTime"] = args ? args.restorePointInTime : undefined;
            inputs["sku"] = args ? args.sku : undefined;
            inputs["sourceManagedInstanceId"] = args ? args.sourceManagedInstanceId : undefined;
            inputs["storageSizeInGB"] = args ? args.storageSizeInGB : undefined;
            inputs["subnetId"] = args ? args.subnetId : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["timezoneId"] = args ? args.timezoneId : undefined;
            inputs["vCores"] = args ? args.vCores : undefined;
            inputs["dnsZone"] = undefined /*out*/;
            inputs["fullyQualifiedDomainName"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["state"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["administratorLogin"] = undefined /*out*/;
            inputs["administratorLoginPassword"] = undefined /*out*/;
            inputs["collation"] = undefined /*out*/;
            inputs["dnsZone"] = undefined /*out*/;
            inputs["dnsZonePartner"] = undefined /*out*/;
            inputs["fullyQualifiedDomainName"] = undefined /*out*/;
            inputs["identity"] = undefined /*out*/;
            inputs["instancePoolId"] = undefined /*out*/;
            inputs["licenseType"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["maintenanceConfigurationId"] = undefined /*out*/;
            inputs["managedInstanceCreateMode"] = undefined /*out*/;
            inputs["minimalTlsVersion"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["proxyOverride"] = undefined /*out*/;
            inputs["publicDataEndpointEnabled"] = undefined /*out*/;
            inputs["restorePointInTime"] = undefined /*out*/;
            inputs["sku"] = undefined /*out*/;
            inputs["sourceManagedInstanceId"] = undefined /*out*/;
            inputs["state"] = undefined /*out*/;
            inputs["storageSizeInGB"] = undefined /*out*/;
            inputs["subnetId"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["timezoneId"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["vCores"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:sql/v20180601preview:ManagedInstance" }, { type: "azure-nextgen:sql/v20200202preview:ManagedInstance" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(ManagedInstance.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a ManagedInstance resource.
 */
export interface ManagedInstanceArgs {
    /**
     * Administrator username for the managed instance. Can only be specified when the managed instance is being created (and is required for creation).
     */
    readonly administratorLogin?: pulumi.Input<string>;
    /**
     * The administrator login password (required for managed instance creation).
     */
    readonly administratorLoginPassword?: pulumi.Input<string>;
    /**
     * Collation of the managed instance.
     */
    readonly collation?: pulumi.Input<string>;
    /**
     * The resource id of another managed instance whose DNS zone this managed instance will share after creation.
     */
    readonly dnsZonePartner?: pulumi.Input<string>;
    /**
     * The Azure Active Directory identity of the managed instance.
     */
    readonly identity?: pulumi.Input<inputs.sql.v20150501preview.ResourceIdentity>;
    /**
     * The Id of the instance pool this managed server belongs to.
     */
    readonly instancePoolId?: pulumi.Input<string>;
    /**
     * The license type. Possible values are 'LicenseIncluded' (regular price inclusive of a new SQL license) and 'BasePrice' (discounted AHB price for bringing your own SQL licenses).
     */
    readonly licenseType?: pulumi.Input<string>;
    /**
     * Resource location.
     */
    readonly location: pulumi.Input<string>;
    /**
     * Specifies maintenance configuration id to apply to this managed instance.
     */
    readonly maintenanceConfigurationId?: pulumi.Input<string>;
    /**
     * Specifies the mode of database creation.
     * 
     * Default: Regular instance creation.
     * 
     * Restore: Creates an instance by restoring a set of backups to specific point in time. RestorePointInTime and SourceManagedInstanceId must be specified.
     */
    readonly managedInstanceCreateMode?: pulumi.Input<string>;
    /**
     * The name of the managed instance.
     */
    readonly managedInstanceName: pulumi.Input<string>;
    /**
     * Minimal TLS version. Allowed values: 'None', '1.0', '1.1', '1.2'
     */
    readonly minimalTlsVersion?: pulumi.Input<string>;
    /**
     * Connection type used for connecting to the instance.
     */
    readonly proxyOverride?: pulumi.Input<string>;
    /**
     * Whether or not the public data endpoint is enabled.
     */
    readonly publicDataEndpointEnabled?: pulumi.Input<boolean>;
    /**
     * The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Specifies the point in time (ISO8601 format) of the source database that will be restored to create the new database.
     */
    readonly restorePointInTime?: pulumi.Input<string>;
    /**
     * Managed instance SKU. Allowed values for sku.name: GP_Gen4, GP_Gen5, BC_Gen4, BC_Gen5
     */
    readonly sku?: pulumi.Input<inputs.sql.v20150501preview.Sku>;
    /**
     * The resource identifier of the source managed instance associated with create operation of this instance.
     */
    readonly sourceManagedInstanceId?: pulumi.Input<string>;
    /**
     * Storage size in GB. Minimum value: 32. Maximum value: 8192. Increments of 32 GB allowed only.
     */
    readonly storageSizeInGB?: pulumi.Input<number>;
    /**
     * Subnet resource ID for the managed instance.
     */
    readonly subnetId?: pulumi.Input<string>;
    /**
     * Resource tags.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Id of the timezone. Allowed values are timezones supported by Windows.
     * Windows keeps details on supported timezones, including the id, in registry under
     * KEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Time Zones.
     * You can get those registry values via SQL Server by querying SELECT name AS timezone_id FROM sys.time_zone_info.
     * List of Ids can also be obtained by executing [System.TimeZoneInfo]::GetSystemTimeZones() in PowerShell.
     * An example of valid timezone id is "Pacific Standard Time" or "W. Europe Standard Time".
     */
    readonly timezoneId?: pulumi.Input<string>;
    /**
     * The number of vCores. Allowed values: 8, 16, 24, 32, 40, 64, 80.
     */
    readonly vCores?: pulumi.Input<number>;
}

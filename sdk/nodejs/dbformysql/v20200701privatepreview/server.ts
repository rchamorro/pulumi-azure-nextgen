// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * Represents a server.
 */
export class Server extends pulumi.CustomResource {
    /**
     * Get an existing Server resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Server {
        return new Server(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:dbformysql/v20200701privatepreview:Server';

    /**
     * Returns true if the given object is an instance of Server.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Server {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Server.__pulumiType;
    }

    /**
     * The administrator's login name of a server. Can only be specified when the server is being created (and is required for creation).
     */
    public readonly administratorLogin!: pulumi.Output<string | undefined>;
    /**
     * The password of the administrator login (required for server creation).
     */
    public readonly administratorLoginPassword!: pulumi.Output<string | undefined>;
    /**
     * availability Zone information of the server.
     */
    public readonly availabilityZone!: pulumi.Output<string | undefined>;
    /**
     * Status showing whether the data encryption is enabled with customer-managed keys.
     */
    public /*out*/ readonly byokEnforcement!: pulumi.Output<string>;
    /**
     * The mode to create a new MySQL server.
     */
    public readonly createMode!: pulumi.Output<string | undefined>;
    /**
     * Delegated subnet arguments.
     */
    public readonly delegatedSubnetArguments!: pulumi.Output<outputs.dbformysql.v20200701privatepreview.DelegatedSubnetArgumentsResponse | undefined>;
    /**
     * Earliest restore point creation time (ISO8601 format)
     */
    public /*out*/ readonly earliestRestoreDate!: pulumi.Output<string>;
    /**
     * The fully qualified domain name of a server.
     */
    public /*out*/ readonly fullyQualifiedDomainName!: pulumi.Output<string>;
    /**
     * Enable HA or not for a server.
     */
    public readonly haEnabled!: pulumi.Output<string | undefined>;
    /**
     * The state of a HA server.
     */
    public /*out*/ readonly haState!: pulumi.Output<string>;
    /**
     * The Azure Active Directory identity of the server.
     */
    public readonly identity!: pulumi.Output<outputs.dbformysql.v20200701privatepreview.IdentityResponse | undefined>;
    /**
     * Status showing whether the server enabled infrastructure encryption.
     */
    public readonly infrastructureEncryption!: pulumi.Output<string | undefined>;
    /**
     * The geo-location where the resource lives
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * Maintenance window of a server.
     */
    public readonly maintenanceWindow!: pulumi.Output<outputs.dbformysql.v20200701privatepreview.MaintenanceWindowResponse | undefined>;
    /**
     * The name of the resource
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Whether or not public network access is allowed for this server. Value is optional but if passed in, must be 'Enabled' or 'Disabled'
     */
    public /*out*/ readonly publicNetworkAccess!: pulumi.Output<string>;
    /**
     * The maximum number of replicas that a primary server can have.
     */
    public /*out*/ readonly replicaCapacity!: pulumi.Output<number>;
    /**
     * The replication role.
     */
    public readonly replicationRole!: pulumi.Output<string | undefined>;
    /**
     * Restore point creation time (ISO8601 format), specifying the time to restore from.
     */
    public readonly restorePointInTime!: pulumi.Output<string | undefined>;
    /**
     * The SKU (pricing tier) of the server.
     */
    public readonly sku!: pulumi.Output<outputs.dbformysql.v20200701privatepreview.SkuResponse | undefined>;
    /**
     * The source MySQL server id.
     */
    public readonly sourceServerId!: pulumi.Output<string | undefined>;
    /**
     * Enable ssl enforcement or not when connect to server.
     */
    public readonly sslEnforcement!: pulumi.Output<string | undefined>;
    /**
     * availability Zone information of the server.
     */
    public /*out*/ readonly standbyAvailabilityZone!: pulumi.Output<string>;
    /**
     * The state of a server.
     */
    public /*out*/ readonly state!: pulumi.Output<string>;
    /**
     * Storage profile of a server.
     */
    public readonly storageProfile!: pulumi.Output<outputs.dbformysql.v20200701privatepreview.StorageProfileResponse | undefined>;
    /**
     * Resource tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * Server version.
     */
    public readonly version!: pulumi.Output<string | undefined>;

    /**
     * Create a Server resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ServerArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.location === undefined) {
                throw new Error("Missing required property 'location'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.serverName === undefined) {
                throw new Error("Missing required property 'serverName'");
            }
            inputs["administratorLogin"] = args ? args.administratorLogin : undefined;
            inputs["administratorLoginPassword"] = args ? args.administratorLoginPassword : undefined;
            inputs["availabilityZone"] = args ? args.availabilityZone : undefined;
            inputs["createMode"] = args ? args.createMode : undefined;
            inputs["delegatedSubnetArguments"] = args ? args.delegatedSubnetArguments : undefined;
            inputs["haEnabled"] = args ? args.haEnabled : undefined;
            inputs["identity"] = args ? args.identity : undefined;
            inputs["infrastructureEncryption"] = args ? args.infrastructureEncryption : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["maintenanceWindow"] = args ? args.maintenanceWindow : undefined;
            inputs["replicationRole"] = args ? args.replicationRole : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["restorePointInTime"] = args ? args.restorePointInTime : undefined;
            inputs["serverName"] = args ? args.serverName : undefined;
            inputs["sku"] = args ? args.sku : undefined;
            inputs["sourceServerId"] = args ? args.sourceServerId : undefined;
            inputs["sslEnforcement"] = args ? args.sslEnforcement : undefined;
            inputs["storageProfile"] = args ? args.storageProfile : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["version"] = args ? args.version : undefined;
            inputs["byokEnforcement"] = undefined /*out*/;
            inputs["earliestRestoreDate"] = undefined /*out*/;
            inputs["fullyQualifiedDomainName"] = undefined /*out*/;
            inputs["haState"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["publicNetworkAccess"] = undefined /*out*/;
            inputs["replicaCapacity"] = undefined /*out*/;
            inputs["standbyAvailabilityZone"] = undefined /*out*/;
            inputs["state"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["administratorLogin"] = undefined /*out*/;
            inputs["administratorLoginPassword"] = undefined /*out*/;
            inputs["availabilityZone"] = undefined /*out*/;
            inputs["byokEnforcement"] = undefined /*out*/;
            inputs["createMode"] = undefined /*out*/;
            inputs["delegatedSubnetArguments"] = undefined /*out*/;
            inputs["earliestRestoreDate"] = undefined /*out*/;
            inputs["fullyQualifiedDomainName"] = undefined /*out*/;
            inputs["haEnabled"] = undefined /*out*/;
            inputs["haState"] = undefined /*out*/;
            inputs["identity"] = undefined /*out*/;
            inputs["infrastructureEncryption"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["maintenanceWindow"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["publicNetworkAccess"] = undefined /*out*/;
            inputs["replicaCapacity"] = undefined /*out*/;
            inputs["replicationRole"] = undefined /*out*/;
            inputs["restorePointInTime"] = undefined /*out*/;
            inputs["sku"] = undefined /*out*/;
            inputs["sourceServerId"] = undefined /*out*/;
            inputs["sslEnforcement"] = undefined /*out*/;
            inputs["standbyAvailabilityZone"] = undefined /*out*/;
            inputs["state"] = undefined /*out*/;
            inputs["storageProfile"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["version"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:dbformysql/v20200701preview:Server" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(Server.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Server resource.
 */
export interface ServerArgs {
    /**
     * The administrator's login name of a server. Can only be specified when the server is being created (and is required for creation).
     */
    readonly administratorLogin?: pulumi.Input<string>;
    /**
     * The password of the administrator login (required for server creation).
     */
    readonly administratorLoginPassword?: pulumi.Input<string>;
    /**
     * availability Zone information of the server.
     */
    readonly availabilityZone?: pulumi.Input<string>;
    /**
     * The mode to create a new MySQL server.
     */
    readonly createMode?: pulumi.Input<string>;
    /**
     * Delegated subnet arguments.
     */
    readonly delegatedSubnetArguments?: pulumi.Input<inputs.dbformysql.v20200701privatepreview.DelegatedSubnetArguments>;
    /**
     * Enable HA or not for a server.
     */
    readonly haEnabled?: pulumi.Input<string>;
    /**
     * The Azure Active Directory identity of the server.
     */
    readonly identity?: pulumi.Input<inputs.dbformysql.v20200701privatepreview.Identity>;
    /**
     * Status showing whether the server enabled infrastructure encryption.
     */
    readonly infrastructureEncryption?: pulumi.Input<string>;
    /**
     * The geo-location where the resource lives
     */
    readonly location: pulumi.Input<string>;
    /**
     * Maintenance window of a server.
     */
    readonly maintenanceWindow?: pulumi.Input<inputs.dbformysql.v20200701privatepreview.MaintenanceWindow>;
    /**
     * The replication role.
     */
    readonly replicationRole?: pulumi.Input<string>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Restore point creation time (ISO8601 format), specifying the time to restore from.
     */
    readonly restorePointInTime?: pulumi.Input<string>;
    /**
     * The name of the server.
     */
    readonly serverName: pulumi.Input<string>;
    /**
     * The SKU (pricing tier) of the server.
     */
    readonly sku?: pulumi.Input<inputs.dbformysql.v20200701privatepreview.Sku>;
    /**
     * The source MySQL server id.
     */
    readonly sourceServerId?: pulumi.Input<string>;
    /**
     * Enable ssl enforcement or not when connect to server.
     */
    readonly sslEnforcement?: pulumi.Input<string>;
    /**
     * Storage profile of a server.
     */
    readonly storageProfile?: pulumi.Input<inputs.dbformysql.v20200701privatepreview.StorageProfile>;
    /**
     * Resource tags.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Server version.
     */
    readonly version?: pulumi.Input<string>;
}

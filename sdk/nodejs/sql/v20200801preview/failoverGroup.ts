// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * A failover group.
 */
export class FailoverGroup extends pulumi.CustomResource {
    /**
     * Get an existing FailoverGroup resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): FailoverGroup {
        return new FailoverGroup(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:sql/v20200801preview:FailoverGroup';

    /**
     * Returns true if the given object is an instance of FailoverGroup.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is FailoverGroup {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === FailoverGroup.__pulumiType;
    }

    /**
     * List of databases in the failover group.
     */
    public readonly databases!: pulumi.Output<string[] | undefined>;
    /**
     * Resource location.
     */
    public /*out*/ readonly location!: pulumi.Output<string>;
    /**
     * Resource name.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * List of partner server information for the failover group.
     */
    public readonly partnerServers!: pulumi.Output<outputs.sql.v20200801preview.PartnerInfoResponse[]>;
    /**
     * Read-only endpoint of the failover group instance.
     */
    public readonly readOnlyEndpoint!: pulumi.Output<outputs.sql.v20200801preview.FailoverGroupReadOnlyEndpointResponse | undefined>;
    /**
     * Read-write endpoint of the failover group instance.
     */
    public readonly readWriteEndpoint!: pulumi.Output<outputs.sql.v20200801preview.FailoverGroupReadWriteEndpointResponse>;
    /**
     * Local replication role of the failover group instance.
     */
    public /*out*/ readonly replicationRole!: pulumi.Output<string>;
    /**
     * Replication state of the failover group instance.
     */
    public /*out*/ readonly replicationState!: pulumi.Output<string>;
    /**
     * Resource tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a FailoverGroup resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: FailoverGroupArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.failoverGroupName === undefined) {
                throw new Error("Missing required property 'failoverGroupName'");
            }
            if (!args || args.partnerServers === undefined) {
                throw new Error("Missing required property 'partnerServers'");
            }
            if (!args || args.readWriteEndpoint === undefined) {
                throw new Error("Missing required property 'readWriteEndpoint'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.serverName === undefined) {
                throw new Error("Missing required property 'serverName'");
            }
            inputs["databases"] = args ? args.databases : undefined;
            inputs["failoverGroupName"] = args ? args.failoverGroupName : undefined;
            inputs["partnerServers"] = args ? args.partnerServers : undefined;
            inputs["readOnlyEndpoint"] = args ? args.readOnlyEndpoint : undefined;
            inputs["readWriteEndpoint"] = args ? args.readWriteEndpoint : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["serverName"] = args ? args.serverName : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["replicationRole"] = undefined /*out*/;
            inputs["replicationState"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["databases"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["partnerServers"] = undefined /*out*/;
            inputs["readOnlyEndpoint"] = undefined /*out*/;
            inputs["readWriteEndpoint"] = undefined /*out*/;
            inputs["replicationRole"] = undefined /*out*/;
            inputs["replicationState"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:sql/v20150501preview:FailoverGroup" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(FailoverGroup.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a FailoverGroup resource.
 */
export interface FailoverGroupArgs {
    /**
     * List of databases in the failover group.
     */
    readonly databases?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The name of the failover group.
     */
    readonly failoverGroupName: pulumi.Input<string>;
    /**
     * List of partner server information for the failover group.
     */
    readonly partnerServers: pulumi.Input<pulumi.Input<inputs.sql.v20200801preview.PartnerInfo>[]>;
    /**
     * Read-only endpoint of the failover group instance.
     */
    readonly readOnlyEndpoint?: pulumi.Input<inputs.sql.v20200801preview.FailoverGroupReadOnlyEndpoint>;
    /**
     * Read-write endpoint of the failover group instance.
     */
    readonly readWriteEndpoint: pulumi.Input<inputs.sql.v20200801preview.FailoverGroupReadWriteEndpoint>;
    /**
     * The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the server containing the failover group.
     */
    readonly serverName: pulumi.Input<string>;
    /**
     * Resource tags.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}
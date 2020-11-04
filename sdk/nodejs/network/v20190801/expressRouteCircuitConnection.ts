// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

/**
 * Express Route Circuit Connection in an ExpressRouteCircuitPeering resource.
 */
export class ExpressRouteCircuitConnection extends pulumi.CustomResource {
    /**
     * Get an existing ExpressRouteCircuitConnection resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ExpressRouteCircuitConnection {
        return new ExpressRouteCircuitConnection(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:network/v20190801:ExpressRouteCircuitConnection';

    /**
     * Returns true if the given object is an instance of ExpressRouteCircuitConnection.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ExpressRouteCircuitConnection {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ExpressRouteCircuitConnection.__pulumiType;
    }

    /**
     * /29 IP address space to carve out Customer addresses for tunnels.
     */
    public readonly addressPrefix!: pulumi.Output<string | undefined>;
    /**
     * The authorization key.
     */
    public readonly authorizationKey!: pulumi.Output<string | undefined>;
    /**
     * Express Route Circuit connection state.
     */
    public /*out*/ readonly circuitConnectionStatus!: pulumi.Output<string>;
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    public /*out*/ readonly etag!: pulumi.Output<string>;
    /**
     * Reference to Express Route Circuit Private Peering Resource of the circuit initiating connection.
     */
    public readonly expressRouteCircuitPeering!: pulumi.Output<outputs.network.v20190801.SubResourceResponse | undefined>;
    /**
     * The name of the resource that is unique within a resource group. This name can be used to access the resource.
     */
    public readonly name!: pulumi.Output<string | undefined>;
    /**
     * Reference to Express Route Circuit Private Peering Resource of the peered circuit.
     */
    public readonly peerExpressRouteCircuitPeering!: pulumi.Output<outputs.network.v20190801.SubResourceResponse | undefined>;
    /**
     * The provisioning state of the express route circuit connection resource.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * Type of the resource.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a ExpressRouteCircuitConnection resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ExpressRouteCircuitConnectionArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.circuitName === undefined) {
                throw new Error("Missing required property 'circuitName'");
            }
            if (!args || args.connectionName === undefined) {
                throw new Error("Missing required property 'connectionName'");
            }
            if (!args || args.peeringName === undefined) {
                throw new Error("Missing required property 'peeringName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["addressPrefix"] = args ? args.addressPrefix : undefined;
            inputs["authorizationKey"] = args ? args.authorizationKey : undefined;
            inputs["circuitName"] = args ? args.circuitName : undefined;
            inputs["connectionName"] = args ? args.connectionName : undefined;
            inputs["expressRouteCircuitPeering"] = args ? args.expressRouteCircuitPeering : undefined;
            inputs["id"] = args ? args.id : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["peerExpressRouteCircuitPeering"] = args ? args.peerExpressRouteCircuitPeering : undefined;
            inputs["peeringName"] = args ? args.peeringName : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["circuitConnectionStatus"] = undefined /*out*/;
            inputs["etag"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["addressPrefix"] = undefined /*out*/;
            inputs["authorizationKey"] = undefined /*out*/;
            inputs["circuitConnectionStatus"] = undefined /*out*/;
            inputs["etag"] = undefined /*out*/;
            inputs["expressRouteCircuitPeering"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["peerExpressRouteCircuitPeering"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:network/latest:ExpressRouteCircuitConnection" }, { type: "azure-nextgen:network/v20180201:ExpressRouteCircuitConnection" }, { type: "azure-nextgen:network/v20180401:ExpressRouteCircuitConnection" }, { type: "azure-nextgen:network/v20180601:ExpressRouteCircuitConnection" }, { type: "azure-nextgen:network/v20180701:ExpressRouteCircuitConnection" }, { type: "azure-nextgen:network/v20180801:ExpressRouteCircuitConnection" }, { type: "azure-nextgen:network/v20181001:ExpressRouteCircuitConnection" }, { type: "azure-nextgen:network/v20181101:ExpressRouteCircuitConnection" }, { type: "azure-nextgen:network/v20181201:ExpressRouteCircuitConnection" }, { type: "azure-nextgen:network/v20190201:ExpressRouteCircuitConnection" }, { type: "azure-nextgen:network/v20190401:ExpressRouteCircuitConnection" }, { type: "azure-nextgen:network/v20190601:ExpressRouteCircuitConnection" }, { type: "azure-nextgen:network/v20190701:ExpressRouteCircuitConnection" }, { type: "azure-nextgen:network/v20190901:ExpressRouteCircuitConnection" }, { type: "azure-nextgen:network/v20191101:ExpressRouteCircuitConnection" }, { type: "azure-nextgen:network/v20191201:ExpressRouteCircuitConnection" }, { type: "azure-nextgen:network/v20200301:ExpressRouteCircuitConnection" }, { type: "azure-nextgen:network/v20200401:ExpressRouteCircuitConnection" }, { type: "azure-nextgen:network/v20200501:ExpressRouteCircuitConnection" }, { type: "azure-nextgen:network/v20200601:ExpressRouteCircuitConnection" }, { type: "azure-nextgen:network/v20200701:ExpressRouteCircuitConnection" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(ExpressRouteCircuitConnection.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a ExpressRouteCircuitConnection resource.
 */
export interface ExpressRouteCircuitConnectionArgs {
    /**
     * /29 IP address space to carve out Customer addresses for tunnels.
     */
    readonly addressPrefix?: pulumi.Input<string>;
    /**
     * The authorization key.
     */
    readonly authorizationKey?: pulumi.Input<string>;
    /**
     * The name of the express route circuit.
     */
    readonly circuitName: pulumi.Input<string>;
    /**
     * The name of the express route circuit connection.
     */
    readonly connectionName: pulumi.Input<string>;
    /**
     * Reference to Express Route Circuit Private Peering Resource of the circuit initiating connection.
     */
    readonly expressRouteCircuitPeering?: pulumi.Input<inputs.network.v20190801.SubResource>;
    /**
     * Resource ID.
     */
    readonly id?: pulumi.Input<string>;
    /**
     * The name of the resource that is unique within a resource group. This name can be used to access the resource.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Reference to Express Route Circuit Private Peering Resource of the peered circuit.
     */
    readonly peerExpressRouteCircuitPeering?: pulumi.Input<inputs.network.v20190801.SubResource>;
    /**
     * The name of the peering.
     */
    readonly peeringName: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
}

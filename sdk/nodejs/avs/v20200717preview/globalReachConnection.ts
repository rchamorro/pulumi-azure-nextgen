// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * A global reach connection resource
 */
export class GlobalReachConnection extends pulumi.CustomResource {
    /**
     * Get an existing GlobalReachConnection resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): GlobalReachConnection {
        return new GlobalReachConnection(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:avs/v20200717preview:GlobalReachConnection';

    /**
     * Returns true if the given object is an instance of GlobalReachConnection.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is GlobalReachConnection {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === GlobalReachConnection.__pulumiType;
    }

    /**
     * The network used for global reach carved out from the original network block provided for the private cloud
     */
    public /*out*/ readonly addressPrefix!: pulumi.Output<string>;
    /**
     * Authorization key from the peer express route used for the global reach connection
     */
    public readonly authorizationKey!: pulumi.Output<string | undefined>;
    /**
     * The connection status of the global reach connection
     */
    public /*out*/ readonly circuitConnectionStatus!: pulumi.Output<string>;
    /**
     * Resource name.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Identifier of the ExpressRoute Circuit to peer with in the global reach connection
     */
    public readonly peerExpressRouteCircuit!: pulumi.Output<string | undefined>;
    /**
     * The state of the  ExpressRoute Circuit Authorization provisioning
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * Resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a GlobalReachConnection resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: GlobalReachConnectionArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.globalReachConnectionName === undefined) {
                throw new Error("Missing required property 'globalReachConnectionName'");
            }
            if (!args || args.privateCloudName === undefined) {
                throw new Error("Missing required property 'privateCloudName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["authorizationKey"] = args ? args.authorizationKey : undefined;
            inputs["globalReachConnectionName"] = args ? args.globalReachConnectionName : undefined;
            inputs["peerExpressRouteCircuit"] = args ? args.peerExpressRouteCircuit : undefined;
            inputs["privateCloudName"] = args ? args.privateCloudName : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["addressPrefix"] = undefined /*out*/;
            inputs["circuitConnectionStatus"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["addressPrefix"] = undefined /*out*/;
            inputs["authorizationKey"] = undefined /*out*/;
            inputs["circuitConnectionStatus"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["peerExpressRouteCircuit"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(GlobalReachConnection.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a GlobalReachConnection resource.
 */
export interface GlobalReachConnectionArgs {
    /**
     * Authorization key from the peer express route used for the global reach connection
     */
    readonly authorizationKey?: pulumi.Input<string>;
    /**
     * Name of the global reach connection in the private cloud
     */
    readonly globalReachConnectionName: pulumi.Input<string>;
    /**
     * Identifier of the ExpressRoute Circuit to peer with in the global reach connection
     */
    readonly peerExpressRouteCircuit?: pulumi.Input<string>;
    /**
     * The name of the private cloud.
     */
    readonly privateCloudName: pulumi.Input<string>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    readonly resourceGroupName: pulumi.Input<string>;
}

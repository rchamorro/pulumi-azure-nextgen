// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * A common class for general resource information.
 */
export class VirtualNetworkGatewayConnection extends pulumi.CustomResource {
    /**
     * Get an existing VirtualNetworkGatewayConnection resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): VirtualNetworkGatewayConnection {
        return new VirtualNetworkGatewayConnection(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:network/v20200701:VirtualNetworkGatewayConnection';

    /**
     * Returns true if the given object is an instance of VirtualNetworkGatewayConnection.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is VirtualNetworkGatewayConnection {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === VirtualNetworkGatewayConnection.__pulumiType;
    }

    /**
     * The authorizationKey.
     */
    public readonly authorizationKey!: pulumi.Output<string | undefined>;
    /**
     * The connection mode for this connection.
     */
    public readonly connectionMode!: pulumi.Output<string | undefined>;
    /**
     * Connection protocol used for this connection.
     */
    public readonly connectionProtocol!: pulumi.Output<string | undefined>;
    /**
     * Virtual Network Gateway connection status.
     */
    public /*out*/ readonly connectionStatus!: pulumi.Output<string>;
    /**
     * Gateway connection type.
     */
    public readonly connectionType!: pulumi.Output<string>;
    /**
     * The dead peer detection timeout of this connection in seconds.
     */
    public readonly dpdTimeoutSeconds!: pulumi.Output<number | undefined>;
    /**
     * The egress bytes transferred in this connection.
     */
    public /*out*/ readonly egressBytesTransferred!: pulumi.Output<number>;
    /**
     * EnableBgp flag.
     */
    public readonly enableBgp!: pulumi.Output<boolean | undefined>;
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    public /*out*/ readonly etag!: pulumi.Output<string>;
    /**
     * Bypass ExpressRoute Gateway for data forwarding.
     */
    public readonly expressRouteGatewayBypass!: pulumi.Output<boolean | undefined>;
    /**
     * The ingress bytes transferred in this connection.
     */
    public /*out*/ readonly ingressBytesTransferred!: pulumi.Output<number>;
    /**
     * The IPSec Policies to be considered by this connection.
     */
    public readonly ipsecPolicies!: pulumi.Output<outputs.network.v20200701.IpsecPolicyResponse[] | undefined>;
    /**
     * The reference to local network gateway resource.
     */
    public readonly localNetworkGateway2!: pulumi.Output<outputs.network.v20200701.LocalNetworkGatewayResponse | undefined>;
    /**
     * Resource location.
     */
    public readonly location!: pulumi.Output<string | undefined>;
    /**
     * Resource name.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The reference to peerings resource.
     */
    public readonly peer!: pulumi.Output<outputs.network.v20200701.SubResourceResponse | undefined>;
    /**
     * The provisioning state of the virtual network gateway connection resource.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * The resource GUID property of the virtual network gateway connection resource.
     */
    public /*out*/ readonly resourceGuid!: pulumi.Output<string>;
    /**
     * The routing weight.
     */
    public readonly routingWeight!: pulumi.Output<number | undefined>;
    /**
     * The IPSec shared key.
     */
    public readonly sharedKey!: pulumi.Output<string | undefined>;
    /**
     * Resource tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * The Traffic Selector Policies to be considered by this connection.
     */
    public readonly trafficSelectorPolicies!: pulumi.Output<outputs.network.v20200701.TrafficSelectorPolicyResponse[] | undefined>;
    /**
     * Collection of all tunnels' connection health status.
     */
    public /*out*/ readonly tunnelConnectionStatus!: pulumi.Output<outputs.network.v20200701.TunnelConnectionHealthResponse[]>;
    /**
     * Resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * Use private local Azure IP for the connection.
     */
    public readonly useLocalAzureIpAddress!: pulumi.Output<boolean | undefined>;
    /**
     * Enable policy-based traffic selectors.
     */
    public readonly usePolicyBasedTrafficSelectors!: pulumi.Output<boolean | undefined>;
    /**
     * The reference to virtual network gateway resource.
     */
    public readonly virtualNetworkGateway1!: pulumi.Output<outputs.network.v20200701.VirtualNetworkGatewayResponse>;
    /**
     * The reference to virtual network gateway resource.
     */
    public readonly virtualNetworkGateway2!: pulumi.Output<outputs.network.v20200701.VirtualNetworkGatewayResponse | undefined>;

    /**
     * Create a VirtualNetworkGatewayConnection resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: VirtualNetworkGatewayConnectionArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.connectionType === undefined) {
                throw new Error("Missing required property 'connectionType'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.virtualNetworkGateway1 === undefined) {
                throw new Error("Missing required property 'virtualNetworkGateway1'");
            }
            if (!args || args.virtualNetworkGatewayConnectionName === undefined) {
                throw new Error("Missing required property 'virtualNetworkGatewayConnectionName'");
            }
            inputs["authorizationKey"] = args ? args.authorizationKey : undefined;
            inputs["connectionMode"] = args ? args.connectionMode : undefined;
            inputs["connectionProtocol"] = args ? args.connectionProtocol : undefined;
            inputs["connectionType"] = args ? args.connectionType : undefined;
            inputs["dpdTimeoutSeconds"] = args ? args.dpdTimeoutSeconds : undefined;
            inputs["enableBgp"] = args ? args.enableBgp : undefined;
            inputs["expressRouteGatewayBypass"] = args ? args.expressRouteGatewayBypass : undefined;
            inputs["id"] = args ? args.id : undefined;
            inputs["ipsecPolicies"] = args ? args.ipsecPolicies : undefined;
            inputs["localNetworkGateway2"] = args ? args.localNetworkGateway2 : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["peer"] = args ? args.peer : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["routingWeight"] = args ? args.routingWeight : undefined;
            inputs["sharedKey"] = args ? args.sharedKey : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["trafficSelectorPolicies"] = args ? args.trafficSelectorPolicies : undefined;
            inputs["useLocalAzureIpAddress"] = args ? args.useLocalAzureIpAddress : undefined;
            inputs["usePolicyBasedTrafficSelectors"] = args ? args.usePolicyBasedTrafficSelectors : undefined;
            inputs["virtualNetworkGateway1"] = args ? args.virtualNetworkGateway1 : undefined;
            inputs["virtualNetworkGateway2"] = args ? args.virtualNetworkGateway2 : undefined;
            inputs["virtualNetworkGatewayConnectionName"] = args ? args.virtualNetworkGatewayConnectionName : undefined;
            inputs["connectionStatus"] = undefined /*out*/;
            inputs["egressBytesTransferred"] = undefined /*out*/;
            inputs["etag"] = undefined /*out*/;
            inputs["ingressBytesTransferred"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["resourceGuid"] = undefined /*out*/;
            inputs["tunnelConnectionStatus"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["authorizationKey"] = undefined /*out*/;
            inputs["connectionMode"] = undefined /*out*/;
            inputs["connectionProtocol"] = undefined /*out*/;
            inputs["connectionStatus"] = undefined /*out*/;
            inputs["connectionType"] = undefined /*out*/;
            inputs["dpdTimeoutSeconds"] = undefined /*out*/;
            inputs["egressBytesTransferred"] = undefined /*out*/;
            inputs["enableBgp"] = undefined /*out*/;
            inputs["etag"] = undefined /*out*/;
            inputs["expressRouteGatewayBypass"] = undefined /*out*/;
            inputs["ingressBytesTransferred"] = undefined /*out*/;
            inputs["ipsecPolicies"] = undefined /*out*/;
            inputs["localNetworkGateway2"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["peer"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["resourceGuid"] = undefined /*out*/;
            inputs["routingWeight"] = undefined /*out*/;
            inputs["sharedKey"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["trafficSelectorPolicies"] = undefined /*out*/;
            inputs["tunnelConnectionStatus"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["useLocalAzureIpAddress"] = undefined /*out*/;
            inputs["usePolicyBasedTrafficSelectors"] = undefined /*out*/;
            inputs["virtualNetworkGateway1"] = undefined /*out*/;
            inputs["virtualNetworkGateway2"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:network/latest:VirtualNetworkGatewayConnection" }, { type: "azure-nextgen:network/v20150615:VirtualNetworkGatewayConnection" }, { type: "azure-nextgen:network/v20160330:VirtualNetworkGatewayConnection" }, { type: "azure-nextgen:network/v20160601:VirtualNetworkGatewayConnection" }, { type: "azure-nextgen:network/v20160901:VirtualNetworkGatewayConnection" }, { type: "azure-nextgen:network/v20161201:VirtualNetworkGatewayConnection" }, { type: "azure-nextgen:network/v20170301:VirtualNetworkGatewayConnection" }, { type: "azure-nextgen:network/v20170601:VirtualNetworkGatewayConnection" }, { type: "azure-nextgen:network/v20170801:VirtualNetworkGatewayConnection" }, { type: "azure-nextgen:network/v20170901:VirtualNetworkGatewayConnection" }, { type: "azure-nextgen:network/v20171001:VirtualNetworkGatewayConnection" }, { type: "azure-nextgen:network/v20171101:VirtualNetworkGatewayConnection" }, { type: "azure-nextgen:network/v20180101:VirtualNetworkGatewayConnection" }, { type: "azure-nextgen:network/v20180201:VirtualNetworkGatewayConnection" }, { type: "azure-nextgen:network/v20180401:VirtualNetworkGatewayConnection" }, { type: "azure-nextgen:network/v20180601:VirtualNetworkGatewayConnection" }, { type: "azure-nextgen:network/v20180701:VirtualNetworkGatewayConnection" }, { type: "azure-nextgen:network/v20180801:VirtualNetworkGatewayConnection" }, { type: "azure-nextgen:network/v20181001:VirtualNetworkGatewayConnection" }, { type: "azure-nextgen:network/v20181101:VirtualNetworkGatewayConnection" }, { type: "azure-nextgen:network/v20181201:VirtualNetworkGatewayConnection" }, { type: "azure-nextgen:network/v20190201:VirtualNetworkGatewayConnection" }, { type: "azure-nextgen:network/v20190401:VirtualNetworkGatewayConnection" }, { type: "azure-nextgen:network/v20190601:VirtualNetworkGatewayConnection" }, { type: "azure-nextgen:network/v20190701:VirtualNetworkGatewayConnection" }, { type: "azure-nextgen:network/v20190801:VirtualNetworkGatewayConnection" }, { type: "azure-nextgen:network/v20190901:VirtualNetworkGatewayConnection" }, { type: "azure-nextgen:network/v20191101:VirtualNetworkGatewayConnection" }, { type: "azure-nextgen:network/v20191201:VirtualNetworkGatewayConnection" }, { type: "azure-nextgen:network/v20200301:VirtualNetworkGatewayConnection" }, { type: "azure-nextgen:network/v20200401:VirtualNetworkGatewayConnection" }, { type: "azure-nextgen:network/v20200501:VirtualNetworkGatewayConnection" }, { type: "azure-nextgen:network/v20200601:VirtualNetworkGatewayConnection" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(VirtualNetworkGatewayConnection.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a VirtualNetworkGatewayConnection resource.
 */
export interface VirtualNetworkGatewayConnectionArgs {
    /**
     * The authorizationKey.
     */
    readonly authorizationKey?: pulumi.Input<string>;
    /**
     * The connection mode for this connection.
     */
    readonly connectionMode?: pulumi.Input<string>;
    /**
     * Connection protocol used for this connection.
     */
    readonly connectionProtocol?: pulumi.Input<string>;
    /**
     * Gateway connection type.
     */
    readonly connectionType: pulumi.Input<string>;
    /**
     * The dead peer detection timeout of this connection in seconds.
     */
    readonly dpdTimeoutSeconds?: pulumi.Input<number>;
    /**
     * EnableBgp flag.
     */
    readonly enableBgp?: pulumi.Input<boolean>;
    /**
     * Bypass ExpressRoute Gateway for data forwarding.
     */
    readonly expressRouteGatewayBypass?: pulumi.Input<boolean>;
    /**
     * Resource ID.
     */
    readonly id?: pulumi.Input<string>;
    /**
     * The IPSec Policies to be considered by this connection.
     */
    readonly ipsecPolicies?: pulumi.Input<pulumi.Input<inputs.network.v20200701.IpsecPolicy>[]>;
    /**
     * The reference to local network gateway resource.
     */
    readonly localNetworkGateway2?: pulumi.Input<inputs.network.v20200701.LocalNetworkGateway>;
    /**
     * Resource location.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * The reference to peerings resource.
     */
    readonly peer?: pulumi.Input<inputs.network.v20200701.SubResource>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The routing weight.
     */
    readonly routingWeight?: pulumi.Input<number>;
    /**
     * The IPSec shared key.
     */
    readonly sharedKey?: pulumi.Input<string>;
    /**
     * Resource tags.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The Traffic Selector Policies to be considered by this connection.
     */
    readonly trafficSelectorPolicies?: pulumi.Input<pulumi.Input<inputs.network.v20200701.TrafficSelectorPolicy>[]>;
    /**
     * Use private local Azure IP for the connection.
     */
    readonly useLocalAzureIpAddress?: pulumi.Input<boolean>;
    /**
     * Enable policy-based traffic selectors.
     */
    readonly usePolicyBasedTrafficSelectors?: pulumi.Input<boolean>;
    /**
     * The reference to virtual network gateway resource.
     */
    readonly virtualNetworkGateway1: pulumi.Input<inputs.network.v20200701.VirtualNetworkGateway>;
    /**
     * The reference to virtual network gateway resource.
     */
    readonly virtualNetworkGateway2?: pulumi.Input<inputs.network.v20200701.VirtualNetworkGateway>;
    /**
     * The name of the virtual network gateway connection.
     */
    readonly virtualNetworkGatewayConnectionName: pulumi.Input<string>;
}

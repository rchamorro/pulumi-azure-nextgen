// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * P2SVpnGateway Resource.
 */
export class P2sVpnGateway extends pulumi.CustomResource {
    /**
     * Get an existing P2sVpnGateway resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): P2sVpnGateway {
        return new P2sVpnGateway(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:network/v20191101:P2sVpnGateway';

    /**
     * Returns true if the given object is an instance of P2sVpnGateway.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is P2sVpnGateway {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === P2sVpnGateway.__pulumiType;
    }

    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    public /*out*/ readonly etag!: pulumi.Output<string>;
    /**
     * Resource location.
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * Resource name.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * List of all p2s connection configurations of the gateway.
     */
    public readonly p2SConnectionConfigurations!: pulumi.Output<outputs.network.v20191101.P2SConnectionConfigurationResponse[] | undefined>;
    /**
     * The provisioning state of the P2S VPN gateway resource.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * Resource tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * The VirtualHub to which the gateway belongs.
     */
    public readonly virtualHub!: pulumi.Output<outputs.network.v20191101.SubResourceResponse | undefined>;
    /**
     * All P2S VPN clients' connection health status.
     */
    public /*out*/ readonly vpnClientConnectionHealth!: pulumi.Output<outputs.network.v20191101.VpnClientConnectionHealthResponse>;
    /**
     * The scale unit for this p2s vpn gateway.
     */
    public readonly vpnGatewayScaleUnit!: pulumi.Output<number | undefined>;
    /**
     * The VpnServerConfiguration to which the p2sVpnGateway is attached to.
     */
    public readonly vpnServerConfiguration!: pulumi.Output<outputs.network.v20191101.SubResourceResponse | undefined>;

    /**
     * Create a P2sVpnGateway resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: P2sVpnGatewayArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.gatewayName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'gatewayName'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["gatewayName"] = args ? args.gatewayName : undefined;
            inputs["id"] = args ? args.id : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["p2SConnectionConfigurations"] = args ? args.p2SConnectionConfigurations : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["virtualHub"] = args ? args.virtualHub : undefined;
            inputs["vpnGatewayScaleUnit"] = args ? args.vpnGatewayScaleUnit : undefined;
            inputs["vpnServerConfiguration"] = args ? args.vpnServerConfiguration : undefined;
            inputs["etag"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["vpnClientConnectionHealth"] = undefined /*out*/;
        } else {
            inputs["etag"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["p2SConnectionConfigurations"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["virtualHub"] = undefined /*out*/;
            inputs["vpnClientConnectionHealth"] = undefined /*out*/;
            inputs["vpnGatewayScaleUnit"] = undefined /*out*/;
            inputs["vpnServerConfiguration"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:network/latest:P2sVpnGateway" }, { type: "azure-nextgen:network/v20180801:P2sVpnGateway" }, { type: "azure-nextgen:network/v20181001:P2sVpnGateway" }, { type: "azure-nextgen:network/v20181101:P2sVpnGateway" }, { type: "azure-nextgen:network/v20181201:P2sVpnGateway" }, { type: "azure-nextgen:network/v20190201:P2sVpnGateway" }, { type: "azure-nextgen:network/v20190401:P2sVpnGateway" }, { type: "azure-nextgen:network/v20190601:P2sVpnGateway" }, { type: "azure-nextgen:network/v20190701:P2sVpnGateway" }, { type: "azure-nextgen:network/v20190801:P2sVpnGateway" }, { type: "azure-nextgen:network/v20190901:P2sVpnGateway" }, { type: "azure-nextgen:network/v20191201:P2sVpnGateway" }, { type: "azure-nextgen:network/v20200301:P2sVpnGateway" }, { type: "azure-nextgen:network/v20200401:P2sVpnGateway" }, { type: "azure-nextgen:network/v20200501:P2sVpnGateway" }, { type: "azure-nextgen:network/v20200601:P2sVpnGateway" }, { type: "azure-nextgen:network/v20200701:P2sVpnGateway" }, { type: "azure-nextgen:network/v20200801:P2sVpnGateway" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(P2sVpnGateway.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a P2sVpnGateway resource.
 */
export interface P2sVpnGatewayArgs {
    /**
     * The name of the gateway.
     */
    readonly gatewayName: pulumi.Input<string>;
    /**
     * Resource ID.
     */
    readonly id?: pulumi.Input<string>;
    /**
     * Resource location.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * List of all p2s connection configurations of the gateway.
     */
    readonly p2SConnectionConfigurations?: pulumi.Input<pulumi.Input<inputs.network.v20191101.P2SConnectionConfiguration>[]>;
    /**
     * The resource group name of the P2SVpnGateway.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Resource tags.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The VirtualHub to which the gateway belongs.
     */
    readonly virtualHub?: pulumi.Input<inputs.network.v20191101.SubResource>;
    /**
     * The scale unit for this p2s vpn gateway.
     */
    readonly vpnGatewayScaleUnit?: pulumi.Input<number>;
    /**
     * The VpnServerConfiguration to which the p2sVpnGateway is attached to.
     */
    readonly vpnServerConfiguration?: pulumi.Input<inputs.network.v20191101.SubResource>;
}

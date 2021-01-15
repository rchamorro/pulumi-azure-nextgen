// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * VirtualHub Resource.
 */
export class VirtualHub extends pulumi.CustomResource {
    /**
     * Get an existing VirtualHub resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): VirtualHub {
        return new VirtualHub(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:network/v20200501:VirtualHub';

    /**
     * Returns true if the given object is an instance of VirtualHub.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is VirtualHub {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === VirtualHub.__pulumiType;
    }

    /**
     * Address-prefix for this VirtualHub.
     */
    public readonly addressPrefix!: pulumi.Output<string | undefined>;
    /**
     * The azureFirewall associated with this VirtualHub.
     */
    public readonly azureFirewall!: pulumi.Output<outputs.network.v20200501.SubResourceResponse | undefined>;
    /**
     * List of references to Bgp Connections.
     */
    public /*out*/ readonly bgpConnections!: pulumi.Output<outputs.network.v20200501.SubResourceResponse[]>;
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    public /*out*/ readonly etag!: pulumi.Output<string>;
    /**
     * The expressRouteGateway associated with this VirtualHub.
     */
    public readonly expressRouteGateway!: pulumi.Output<outputs.network.v20200501.SubResourceResponse | undefined>;
    /**
     * List of references to IpConfigurations.
     */
    public /*out*/ readonly ipConfigurations!: pulumi.Output<outputs.network.v20200501.SubResourceResponse[]>;
    /**
     * Resource location.
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * Resource name.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The P2SVpnGateway associated with this VirtualHub.
     */
    public readonly p2SVpnGateway!: pulumi.Output<outputs.network.v20200501.SubResourceResponse | undefined>;
    /**
     * The provisioning state of the virtual hub resource.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * The routeTable associated with this virtual hub.
     */
    public readonly routeTable!: pulumi.Output<outputs.network.v20200501.VirtualHubRouteTableResponse | undefined>;
    /**
     * The routing state.
     */
    public /*out*/ readonly routingState!: pulumi.Output<string>;
    /**
     * The securityPartnerProvider associated with this VirtualHub.
     */
    public readonly securityPartnerProvider!: pulumi.Output<outputs.network.v20200501.SubResourceResponse | undefined>;
    /**
     * The Security Provider name.
     */
    public readonly securityProviderName!: pulumi.Output<string | undefined>;
    /**
     * The sku of this VirtualHub.
     */
    public readonly sku!: pulumi.Output<string | undefined>;
    /**
     * Resource tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * List of all virtual hub route table v2s associated with this VirtualHub.
     */
    public readonly virtualHubRouteTableV2s!: pulumi.Output<outputs.network.v20200501.VirtualHubRouteTableV2Response[] | undefined>;
    /**
     * VirtualRouter ASN.
     */
    public readonly virtualRouterAsn!: pulumi.Output<number | undefined>;
    /**
     * VirtualRouter IPs.
     */
    public readonly virtualRouterIps!: pulumi.Output<string[] | undefined>;
    /**
     * The VirtualWAN to which the VirtualHub belongs.
     */
    public readonly virtualWan!: pulumi.Output<outputs.network.v20200501.SubResourceResponse | undefined>;
    /**
     * The VpnGateway associated with this VirtualHub.
     */
    public readonly vpnGateway!: pulumi.Output<outputs.network.v20200501.SubResourceResponse | undefined>;

    /**
     * Create a VirtualHub resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: VirtualHubArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.location === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'location'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if ((!args || args.virtualHubName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'virtualHubName'");
            }
            inputs["addressPrefix"] = args ? args.addressPrefix : undefined;
            inputs["azureFirewall"] = args ? args.azureFirewall : undefined;
            inputs["expressRouteGateway"] = args ? args.expressRouteGateway : undefined;
            inputs["id"] = args ? args.id : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["p2SVpnGateway"] = args ? args.p2SVpnGateway : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["routeTable"] = args ? args.routeTable : undefined;
            inputs["securityPartnerProvider"] = args ? args.securityPartnerProvider : undefined;
            inputs["securityProviderName"] = args ? args.securityProviderName : undefined;
            inputs["sku"] = args ? args.sku : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["virtualHubName"] = args ? args.virtualHubName : undefined;
            inputs["virtualHubRouteTableV2s"] = args ? args.virtualHubRouteTableV2s : undefined;
            inputs["virtualRouterAsn"] = args ? args.virtualRouterAsn : undefined;
            inputs["virtualRouterIps"] = args ? args.virtualRouterIps : undefined;
            inputs["virtualWan"] = args ? args.virtualWan : undefined;
            inputs["vpnGateway"] = args ? args.vpnGateway : undefined;
            inputs["bgpConnections"] = undefined /*out*/;
            inputs["etag"] = undefined /*out*/;
            inputs["ipConfigurations"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["routingState"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["addressPrefix"] = undefined /*out*/;
            inputs["azureFirewall"] = undefined /*out*/;
            inputs["bgpConnections"] = undefined /*out*/;
            inputs["etag"] = undefined /*out*/;
            inputs["expressRouteGateway"] = undefined /*out*/;
            inputs["ipConfigurations"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["p2SVpnGateway"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["routeTable"] = undefined /*out*/;
            inputs["routingState"] = undefined /*out*/;
            inputs["securityPartnerProvider"] = undefined /*out*/;
            inputs["securityProviderName"] = undefined /*out*/;
            inputs["sku"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["virtualHubRouteTableV2s"] = undefined /*out*/;
            inputs["virtualRouterAsn"] = undefined /*out*/;
            inputs["virtualRouterIps"] = undefined /*out*/;
            inputs["virtualWan"] = undefined /*out*/;
            inputs["vpnGateway"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:network/latest:VirtualHub" }, { type: "azure-nextgen:network/v20180401:VirtualHub" }, { type: "azure-nextgen:network/v20180601:VirtualHub" }, { type: "azure-nextgen:network/v20180701:VirtualHub" }, { type: "azure-nextgen:network/v20180801:VirtualHub" }, { type: "azure-nextgen:network/v20181001:VirtualHub" }, { type: "azure-nextgen:network/v20181101:VirtualHub" }, { type: "azure-nextgen:network/v20181201:VirtualHub" }, { type: "azure-nextgen:network/v20190201:VirtualHub" }, { type: "azure-nextgen:network/v20190401:VirtualHub" }, { type: "azure-nextgen:network/v20190601:VirtualHub" }, { type: "azure-nextgen:network/v20190701:VirtualHub" }, { type: "azure-nextgen:network/v20190801:VirtualHub" }, { type: "azure-nextgen:network/v20190901:VirtualHub" }, { type: "azure-nextgen:network/v20191101:VirtualHub" }, { type: "azure-nextgen:network/v20191201:VirtualHub" }, { type: "azure-nextgen:network/v20200301:VirtualHub" }, { type: "azure-nextgen:network/v20200401:VirtualHub" }, { type: "azure-nextgen:network/v20200601:VirtualHub" }, { type: "azure-nextgen:network/v20200701:VirtualHub" }, { type: "azure-nextgen:network/v20200801:VirtualHub" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(VirtualHub.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a VirtualHub resource.
 */
export interface VirtualHubArgs {
    /**
     * Address-prefix for this VirtualHub.
     */
    readonly addressPrefix?: pulumi.Input<string>;
    /**
     * The azureFirewall associated with this VirtualHub.
     */
    readonly azureFirewall?: pulumi.Input<inputs.network.v20200501.SubResource>;
    /**
     * The expressRouteGateway associated with this VirtualHub.
     */
    readonly expressRouteGateway?: pulumi.Input<inputs.network.v20200501.SubResource>;
    /**
     * Resource ID.
     */
    readonly id?: pulumi.Input<string>;
    /**
     * Resource location.
     */
    readonly location: pulumi.Input<string>;
    /**
     * The P2SVpnGateway associated with this VirtualHub.
     */
    readonly p2SVpnGateway?: pulumi.Input<inputs.network.v20200501.SubResource>;
    /**
     * The resource group name of the VirtualHub.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The routeTable associated with this virtual hub.
     */
    readonly routeTable?: pulumi.Input<inputs.network.v20200501.VirtualHubRouteTable>;
    /**
     * The securityPartnerProvider associated with this VirtualHub.
     */
    readonly securityPartnerProvider?: pulumi.Input<inputs.network.v20200501.SubResource>;
    /**
     * The Security Provider name.
     */
    readonly securityProviderName?: pulumi.Input<string>;
    /**
     * The sku of this VirtualHub.
     */
    readonly sku?: pulumi.Input<string>;
    /**
     * Resource tags.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The name of the VirtualHub.
     */
    readonly virtualHubName: pulumi.Input<string>;
    /**
     * List of all virtual hub route table v2s associated with this VirtualHub.
     */
    readonly virtualHubRouteTableV2s?: pulumi.Input<pulumi.Input<inputs.network.v20200501.VirtualHubRouteTableV2>[]>;
    /**
     * VirtualRouter ASN.
     */
    readonly virtualRouterAsn?: pulumi.Input<number>;
    /**
     * VirtualRouter IPs.
     */
    readonly virtualRouterIps?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The VirtualWAN to which the VirtualHub belongs.
     */
    readonly virtualWan?: pulumi.Input<inputs.network.v20200501.SubResource>;
    /**
     * The VpnGateway associated with this VirtualHub.
     */
    readonly vpnGateway?: pulumi.Input<inputs.network.v20200501.SubResource>;
}

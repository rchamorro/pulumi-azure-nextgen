// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * VpnSite Resource.
 */
export class VpnSite extends pulumi.CustomResource {
    /**
     * Get an existing VpnSite resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): VpnSite {
        return new VpnSite(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:network/v20200601:VpnSite';

    /**
     * Returns true if the given object is an instance of VpnSite.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is VpnSite {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === VpnSite.__pulumiType;
    }

    /**
     * The AddressSpace that contains an array of IP address ranges.
     */
    public readonly addressSpace!: pulumi.Output<outputs.network.v20200601.AddressSpaceResponse | undefined>;
    /**
     * The set of bgp properties.
     */
    public readonly bgpProperties!: pulumi.Output<outputs.network.v20200601.BgpSettingsResponse | undefined>;
    /**
     * The device properties.
     */
    public readonly deviceProperties!: pulumi.Output<outputs.network.v20200601.DevicePropertiesResponse | undefined>;
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    public /*out*/ readonly etag!: pulumi.Output<string>;
    /**
     * The ip-address for the vpn-site.
     */
    public readonly ipAddress!: pulumi.Output<string | undefined>;
    /**
     * IsSecuritySite flag.
     */
    public readonly isSecuritySite!: pulumi.Output<boolean | undefined>;
    /**
     * Resource location.
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * Resource name.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Office365 Policy.
     */
    public readonly o365Policy!: pulumi.Output<outputs.network.v20200601.O365PolicyPropertiesResponse | undefined>;
    /**
     * The provisioning state of the VPN site resource.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * The key for vpn-site that can be used for connections.
     */
    public readonly siteKey!: pulumi.Output<string | undefined>;
    /**
     * Resource tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * The VirtualWAN to which the vpnSite belongs.
     */
    public readonly virtualWan!: pulumi.Output<outputs.network.v20200601.SubResourceResponse | undefined>;
    /**
     * List of all vpn site links.
     */
    public readonly vpnSiteLinks!: pulumi.Output<outputs.network.v20200601.VpnSiteLinkResponse[] | undefined>;

    /**
     * Create a VpnSite resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: VpnSiteArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.location === undefined) {
                throw new Error("Missing required property 'location'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.vpnSiteName === undefined) {
                throw new Error("Missing required property 'vpnSiteName'");
            }
            inputs["addressSpace"] = args ? args.addressSpace : undefined;
            inputs["bgpProperties"] = args ? args.bgpProperties : undefined;
            inputs["deviceProperties"] = args ? args.deviceProperties : undefined;
            inputs["id"] = args ? args.id : undefined;
            inputs["ipAddress"] = args ? args.ipAddress : undefined;
            inputs["isSecuritySite"] = args ? args.isSecuritySite : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["o365Policy"] = args ? args.o365Policy : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["siteKey"] = args ? args.siteKey : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["virtualWan"] = args ? args.virtualWan : undefined;
            inputs["vpnSiteLinks"] = args ? args.vpnSiteLinks : undefined;
            inputs["vpnSiteName"] = args ? args.vpnSiteName : undefined;
            inputs["etag"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["addressSpace"] = undefined /*out*/;
            inputs["bgpProperties"] = undefined /*out*/;
            inputs["deviceProperties"] = undefined /*out*/;
            inputs["etag"] = undefined /*out*/;
            inputs["ipAddress"] = undefined /*out*/;
            inputs["isSecuritySite"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["o365Policy"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["siteKey"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["virtualWan"] = undefined /*out*/;
            inputs["vpnSiteLinks"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:network/latest:VpnSite" }, { type: "azure-nextgen:network/v20180401:VpnSite" }, { type: "azure-nextgen:network/v20180601:VpnSite" }, { type: "azure-nextgen:network/v20180701:VpnSite" }, { type: "azure-nextgen:network/v20180801:VpnSite" }, { type: "azure-nextgen:network/v20181001:VpnSite" }, { type: "azure-nextgen:network/v20181101:VpnSite" }, { type: "azure-nextgen:network/v20181201:VpnSite" }, { type: "azure-nextgen:network/v20190201:VpnSite" }, { type: "azure-nextgen:network/v20190401:VpnSite" }, { type: "azure-nextgen:network/v20190601:VpnSite" }, { type: "azure-nextgen:network/v20190701:VpnSite" }, { type: "azure-nextgen:network/v20190801:VpnSite" }, { type: "azure-nextgen:network/v20190901:VpnSite" }, { type: "azure-nextgen:network/v20191101:VpnSite" }, { type: "azure-nextgen:network/v20191201:VpnSite" }, { type: "azure-nextgen:network/v20200301:VpnSite" }, { type: "azure-nextgen:network/v20200401:VpnSite" }, { type: "azure-nextgen:network/v20200501:VpnSite" }, { type: "azure-nextgen:network/v20200701:VpnSite" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(VpnSite.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a VpnSite resource.
 */
export interface VpnSiteArgs {
    /**
     * The AddressSpace that contains an array of IP address ranges.
     */
    readonly addressSpace?: pulumi.Input<inputs.network.v20200601.AddressSpace>;
    /**
     * The set of bgp properties.
     */
    readonly bgpProperties?: pulumi.Input<inputs.network.v20200601.BgpSettings>;
    /**
     * The device properties.
     */
    readonly deviceProperties?: pulumi.Input<inputs.network.v20200601.DeviceProperties>;
    /**
     * Resource ID.
     */
    readonly id?: pulumi.Input<string>;
    /**
     * The ip-address for the vpn-site.
     */
    readonly ipAddress?: pulumi.Input<string>;
    /**
     * IsSecuritySite flag.
     */
    readonly isSecuritySite?: pulumi.Input<boolean>;
    /**
     * Resource location.
     */
    readonly location: pulumi.Input<string>;
    /**
     * Office365 Policy.
     */
    readonly o365Policy?: pulumi.Input<inputs.network.v20200601.O365PolicyProperties>;
    /**
     * The resource group name of the VpnSite.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The key for vpn-site that can be used for connections.
     */
    readonly siteKey?: pulumi.Input<string>;
    /**
     * Resource tags.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The VirtualWAN to which the vpnSite belongs.
     */
    readonly virtualWan?: pulumi.Input<inputs.network.v20200601.SubResource>;
    /**
     * List of all vpn site links.
     */
    readonly vpnSiteLinks?: pulumi.Input<pulumi.Input<inputs.network.v20200601.VpnSiteLink>[]>;
    /**
     * The name of the VpnSite being created or updated.
     */
    readonly vpnSiteName: pulumi.Input<string>;
}

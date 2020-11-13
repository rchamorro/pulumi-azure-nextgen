// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * A common class for general resource information
 */
export class LocalNetworkGateway extends pulumi.CustomResource {
    /**
     * Get an existing LocalNetworkGateway resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): LocalNetworkGateway {
        return new LocalNetworkGateway(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:network/v20181101:LocalNetworkGateway';

    /**
     * Returns true if the given object is an instance of LocalNetworkGateway.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is LocalNetworkGateway {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === LocalNetworkGateway.__pulumiType;
    }

    /**
     * Local network gateway's BGP speaker settings.
     */
    public readonly bgpSettings!: pulumi.Output<outputs.network.v20181101.BgpSettingsResponse | undefined>;
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    public readonly etag!: pulumi.Output<string | undefined>;
    /**
     * IP address of local network gateway.
     */
    public readonly gatewayIpAddress!: pulumi.Output<string | undefined>;
    /**
     * Local network site address space.
     */
    public readonly localNetworkAddressSpace!: pulumi.Output<outputs.network.v20181101.AddressSpaceResponse | undefined>;
    /**
     * Resource location.
     */
    public readonly location!: pulumi.Output<string | undefined>;
    /**
     * Resource name.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The provisioning state of the LocalNetworkGateway resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * The resource GUID property of the LocalNetworkGateway resource.
     */
    public readonly resourceGuid!: pulumi.Output<string | undefined>;
    /**
     * Resource tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a LocalNetworkGateway resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: LocalNetworkGatewayArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.localNetworkGatewayName === undefined) {
                throw new Error("Missing required property 'localNetworkGatewayName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["bgpSettings"] = args ? args.bgpSettings : undefined;
            inputs["etag"] = args ? args.etag : undefined;
            inputs["gatewayIpAddress"] = args ? args.gatewayIpAddress : undefined;
            inputs["id"] = args ? args.id : undefined;
            inputs["localNetworkAddressSpace"] = args ? args.localNetworkAddressSpace : undefined;
            inputs["localNetworkGatewayName"] = args ? args.localNetworkGatewayName : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["resourceGuid"] = args ? args.resourceGuid : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["bgpSettings"] = undefined /*out*/;
            inputs["etag"] = undefined /*out*/;
            inputs["gatewayIpAddress"] = undefined /*out*/;
            inputs["localNetworkAddressSpace"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["resourceGuid"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:network/latest:LocalNetworkGateway" }, { type: "azure-nextgen:network/v20150615:LocalNetworkGateway" }, { type: "azure-nextgen:network/v20160330:LocalNetworkGateway" }, { type: "azure-nextgen:network/v20160601:LocalNetworkGateway" }, { type: "azure-nextgen:network/v20160901:LocalNetworkGateway" }, { type: "azure-nextgen:network/v20161201:LocalNetworkGateway" }, { type: "azure-nextgen:network/v20170301:LocalNetworkGateway" }, { type: "azure-nextgen:network/v20170601:LocalNetworkGateway" }, { type: "azure-nextgen:network/v20170801:LocalNetworkGateway" }, { type: "azure-nextgen:network/v20170901:LocalNetworkGateway" }, { type: "azure-nextgen:network/v20171001:LocalNetworkGateway" }, { type: "azure-nextgen:network/v20171101:LocalNetworkGateway" }, { type: "azure-nextgen:network/v20180101:LocalNetworkGateway" }, { type: "azure-nextgen:network/v20180201:LocalNetworkGateway" }, { type: "azure-nextgen:network/v20180401:LocalNetworkGateway" }, { type: "azure-nextgen:network/v20180601:LocalNetworkGateway" }, { type: "azure-nextgen:network/v20180701:LocalNetworkGateway" }, { type: "azure-nextgen:network/v20180801:LocalNetworkGateway" }, { type: "azure-nextgen:network/v20181001:LocalNetworkGateway" }, { type: "azure-nextgen:network/v20181201:LocalNetworkGateway" }, { type: "azure-nextgen:network/v20190201:LocalNetworkGateway" }, { type: "azure-nextgen:network/v20190401:LocalNetworkGateway" }, { type: "azure-nextgen:network/v20190601:LocalNetworkGateway" }, { type: "azure-nextgen:network/v20190701:LocalNetworkGateway" }, { type: "azure-nextgen:network/v20190801:LocalNetworkGateway" }, { type: "azure-nextgen:network/v20190901:LocalNetworkGateway" }, { type: "azure-nextgen:network/v20191101:LocalNetworkGateway" }, { type: "azure-nextgen:network/v20191201:LocalNetworkGateway" }, { type: "azure-nextgen:network/v20200301:LocalNetworkGateway" }, { type: "azure-nextgen:network/v20200401:LocalNetworkGateway" }, { type: "azure-nextgen:network/v20200501:LocalNetworkGateway" }, { type: "azure-nextgen:network/v20200601:LocalNetworkGateway" }, { type: "azure-nextgen:network/v20200701:LocalNetworkGateway" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(LocalNetworkGateway.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a LocalNetworkGateway resource.
 */
export interface LocalNetworkGatewayArgs {
    /**
     * Local network gateway's BGP speaker settings.
     */
    readonly bgpSettings?: pulumi.Input<inputs.network.v20181101.BgpSettings>;
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    readonly etag?: pulumi.Input<string>;
    /**
     * IP address of local network gateway.
     */
    readonly gatewayIpAddress?: pulumi.Input<string>;
    /**
     * Resource ID.
     */
    readonly id?: pulumi.Input<string>;
    /**
     * Local network site address space.
     */
    readonly localNetworkAddressSpace?: pulumi.Input<inputs.network.v20181101.AddressSpace>;
    /**
     * The name of the local network gateway.
     */
    readonly localNetworkGatewayName: pulumi.Input<string>;
    /**
     * Resource location.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The resource GUID property of the LocalNetworkGateway resource.
     */
    readonly resourceGuid?: pulumi.Input<string>;
    /**
     * Resource tags.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}

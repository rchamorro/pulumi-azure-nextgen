// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * PublicIPAddress resource
 */
export class PublicIPAddress extends pulumi.CustomResource {
    /**
     * Get an existing PublicIPAddress resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): PublicIPAddress {
        return new PublicIPAddress(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:network/v20160601:PublicIPAddress';

    /**
     * Returns true if the given object is an instance of PublicIPAddress.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is PublicIPAddress {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === PublicIPAddress.__pulumiType;
    }

    /**
     * Gets or sets FQDN of the DNS record associated with the public IP address
     */
    public readonly dnsSettings!: pulumi.Output<outputs.network.v20160601.PublicIPAddressDnsSettingsResponse | undefined>;
    /**
     * Gets a unique read-only string that changes whenever the resource is updated
     */
    public readonly etag!: pulumi.Output<string | undefined>;
    /**
     * Gets or sets the idle timeout of the public IP address
     */
    public readonly idleTimeoutInMinutes!: pulumi.Output<number | undefined>;
    public readonly ipAddress!: pulumi.Output<string | undefined>;
    /**
     * IPConfiguration
     */
    public /*out*/ readonly ipConfiguration!: pulumi.Output<outputs.network.v20160601.IPConfigurationResponse>;
    /**
     * Resource location
     */
    public readonly location!: pulumi.Output<string | undefined>;
    /**
     * Resource name
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Gets provisioning state of the PublicIP resource Updating/Deleting/Failed
     */
    public readonly provisioningState!: pulumi.Output<string | undefined>;
    /**
     * Gets or sets PublicIP address version (IPv4/IPv6)
     */
    public readonly publicIPAddressVersion!: pulumi.Output<string | undefined>;
    /**
     * Gets or sets PublicIP allocation method (Static/Dynamic)
     */
    public readonly publicIPAllocationMethod!: pulumi.Output<string | undefined>;
    /**
     * Gets or sets resource guid property of the PublicIP resource
     */
    public readonly resourceGuid!: pulumi.Output<string | undefined>;
    /**
     * Resource tags
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Resource type
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a PublicIPAddress resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: PublicIPAddressArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.publicIpAddressName === undefined) {
                throw new Error("Missing required property 'publicIpAddressName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["dnsSettings"] = args ? args.dnsSettings : undefined;
            inputs["etag"] = args ? args.etag : undefined;
            inputs["id"] = args ? args.id : undefined;
            inputs["idleTimeoutInMinutes"] = args ? args.idleTimeoutInMinutes : undefined;
            inputs["ipAddress"] = args ? args.ipAddress : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["provisioningState"] = args ? args.provisioningState : undefined;
            inputs["publicIPAddressVersion"] = args ? args.publicIPAddressVersion : undefined;
            inputs["publicIPAllocationMethod"] = args ? args.publicIPAllocationMethod : undefined;
            inputs["publicIpAddressName"] = args ? args.publicIpAddressName : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["resourceGuid"] = args ? args.resourceGuid : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["ipConfiguration"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["dnsSettings"] = undefined /*out*/;
            inputs["etag"] = undefined /*out*/;
            inputs["idleTimeoutInMinutes"] = undefined /*out*/;
            inputs["ipAddress"] = undefined /*out*/;
            inputs["ipConfiguration"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["publicIPAddressVersion"] = undefined /*out*/;
            inputs["publicIPAllocationMethod"] = undefined /*out*/;
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
        const aliasOpts = { aliases: [{ type: "azure-nextgen:network/latest:PublicIPAddress" }, { type: "azure-nextgen:network/v20150501preview:PublicIPAddress" }, { type: "azure-nextgen:network/v20150615:PublicIPAddress" }, { type: "azure-nextgen:network/v20160330:PublicIPAddress" }, { type: "azure-nextgen:network/v20160901:PublicIPAddress" }, { type: "azure-nextgen:network/v20161201:PublicIPAddress" }, { type: "azure-nextgen:network/v20170301:PublicIPAddress" }, { type: "azure-nextgen:network/v20170601:PublicIPAddress" }, { type: "azure-nextgen:network/v20170801:PublicIPAddress" }, { type: "azure-nextgen:network/v20170901:PublicIPAddress" }, { type: "azure-nextgen:network/v20171001:PublicIPAddress" }, { type: "azure-nextgen:network/v20171101:PublicIPAddress" }, { type: "azure-nextgen:network/v20180101:PublicIPAddress" }, { type: "azure-nextgen:network/v20180201:PublicIPAddress" }, { type: "azure-nextgen:network/v20180401:PublicIPAddress" }, { type: "azure-nextgen:network/v20180601:PublicIPAddress" }, { type: "azure-nextgen:network/v20180701:PublicIPAddress" }, { type: "azure-nextgen:network/v20180801:PublicIPAddress" }, { type: "azure-nextgen:network/v20181001:PublicIPAddress" }, { type: "azure-nextgen:network/v20181101:PublicIPAddress" }, { type: "azure-nextgen:network/v20181201:PublicIPAddress" }, { type: "azure-nextgen:network/v20190201:PublicIPAddress" }, { type: "azure-nextgen:network/v20190401:PublicIPAddress" }, { type: "azure-nextgen:network/v20190601:PublicIPAddress" }, { type: "azure-nextgen:network/v20190701:PublicIPAddress" }, { type: "azure-nextgen:network/v20190801:PublicIPAddress" }, { type: "azure-nextgen:network/v20190901:PublicIPAddress" }, { type: "azure-nextgen:network/v20191101:PublicIPAddress" }, { type: "azure-nextgen:network/v20191201:PublicIPAddress" }, { type: "azure-nextgen:network/v20200301:PublicIPAddress" }, { type: "azure-nextgen:network/v20200401:PublicIPAddress" }, { type: "azure-nextgen:network/v20200501:PublicIPAddress" }, { type: "azure-nextgen:network/v20200601:PublicIPAddress" }, { type: "azure-nextgen:network/v20200701:PublicIPAddress" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(PublicIPAddress.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a PublicIPAddress resource.
 */
export interface PublicIPAddressArgs {
    /**
     * Gets or sets FQDN of the DNS record associated with the public IP address
     */
    readonly dnsSettings?: pulumi.Input<inputs.network.v20160601.PublicIPAddressDnsSettings>;
    /**
     * Gets a unique read-only string that changes whenever the resource is updated
     */
    readonly etag?: pulumi.Input<string>;
    /**
     * Resource Id
     */
    readonly id?: pulumi.Input<string>;
    /**
     * Gets or sets the idle timeout of the public IP address
     */
    readonly idleTimeoutInMinutes?: pulumi.Input<number>;
    readonly ipAddress?: pulumi.Input<string>;
    /**
     * Resource location
     */
    readonly location?: pulumi.Input<string>;
    /**
     * Gets provisioning state of the PublicIP resource Updating/Deleting/Failed
     */
    readonly provisioningState?: pulumi.Input<string>;
    /**
     * Gets or sets PublicIP address version (IPv4/IPv6)
     */
    readonly publicIPAddressVersion?: pulumi.Input<string>;
    /**
     * Gets or sets PublicIP allocation method (Static/Dynamic)
     */
    readonly publicIPAllocationMethod?: pulumi.Input<string>;
    /**
     * The name of the publicIpAddress.
     */
    readonly publicIpAddressName: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Gets or sets resource guid property of the PublicIP resource
     */
    readonly resourceGuid?: pulumi.Input<string>;
    /**
     * Resource tags
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}

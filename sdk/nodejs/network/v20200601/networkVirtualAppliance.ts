// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * NetworkVirtualAppliance Resource.
 */
export class NetworkVirtualAppliance extends pulumi.CustomResource {
    /**
     * Get an existing NetworkVirtualAppliance resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): NetworkVirtualAppliance {
        return new NetworkVirtualAppliance(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:network/v20200601:NetworkVirtualAppliance';

    /**
     * Returns true if the given object is an instance of NetworkVirtualAppliance.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is NetworkVirtualAppliance {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === NetworkVirtualAppliance.__pulumiType;
    }

    /**
     * Address Prefix.
     */
    public /*out*/ readonly addressPrefix!: pulumi.Output<string>;
    /**
     * BootStrapConfigurationBlobs storage URLs.
     */
    public readonly bootStrapConfigurationBlobs!: pulumi.Output<string[] | undefined>;
    /**
     * CloudInitConfiguration string in plain text.
     */
    public readonly cloudInitConfiguration!: pulumi.Output<string | undefined>;
    /**
     * CloudInitConfigurationBlob storage URLs.
     */
    public readonly cloudInitConfigurationBlobs!: pulumi.Output<string[] | undefined>;
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    public /*out*/ readonly etag!: pulumi.Output<string>;
    /**
     * The service principal that has read access to cloud-init and config blob.
     */
    public readonly identity!: pulumi.Output<outputs.network.v20200601.ManagedServiceIdentityResponse | undefined>;
    /**
     * List of references to InboundSecurityRules.
     */
    public /*out*/ readonly inboundSecurityRules!: pulumi.Output<outputs.network.v20200601.SubResourceResponse[]>;
    /**
     * Resource location.
     */
    public readonly location!: pulumi.Output<string | undefined>;
    /**
     * Resource name.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Network Virtual Appliance SKU.
     */
    public readonly nvaSku!: pulumi.Output<outputs.network.v20200601.VirtualApplianceSkuPropertiesResponse | undefined>;
    /**
     * The provisioning state of the resource.
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
     * VirtualAppliance ASN.
     */
    public readonly virtualApplianceAsn!: pulumi.Output<number | undefined>;
    /**
     * List of Virtual Appliance Network Interfaces.
     */
    public /*out*/ readonly virtualApplianceNics!: pulumi.Output<outputs.network.v20200601.VirtualApplianceNicPropertiesResponse[]>;
    /**
     * List of references to VirtualApplianceSite.
     */
    public /*out*/ readonly virtualApplianceSites!: pulumi.Output<outputs.network.v20200601.SubResourceResponse[]>;
    /**
     * The Virtual Hub where Network Virtual Appliance is being deployed.
     */
    public readonly virtualHub!: pulumi.Output<outputs.network.v20200601.SubResourceResponse | undefined>;

    /**
     * Create a NetworkVirtualAppliance resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: NetworkVirtualApplianceArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.networkVirtualApplianceName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'networkVirtualApplianceName'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["bootStrapConfigurationBlobs"] = args ? args.bootStrapConfigurationBlobs : undefined;
            inputs["cloudInitConfiguration"] = args ? args.cloudInitConfiguration : undefined;
            inputs["cloudInitConfigurationBlobs"] = args ? args.cloudInitConfigurationBlobs : undefined;
            inputs["id"] = args ? args.id : undefined;
            inputs["identity"] = args ? args.identity : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["networkVirtualApplianceName"] = args ? args.networkVirtualApplianceName : undefined;
            inputs["nvaSku"] = args ? args.nvaSku : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["virtualApplianceAsn"] = args ? args.virtualApplianceAsn : undefined;
            inputs["virtualHub"] = args ? args.virtualHub : undefined;
            inputs["addressPrefix"] = undefined /*out*/;
            inputs["etag"] = undefined /*out*/;
            inputs["inboundSecurityRules"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["virtualApplianceNics"] = undefined /*out*/;
            inputs["virtualApplianceSites"] = undefined /*out*/;
        } else {
            inputs["addressPrefix"] = undefined /*out*/;
            inputs["bootStrapConfigurationBlobs"] = undefined /*out*/;
            inputs["cloudInitConfiguration"] = undefined /*out*/;
            inputs["cloudInitConfigurationBlobs"] = undefined /*out*/;
            inputs["etag"] = undefined /*out*/;
            inputs["identity"] = undefined /*out*/;
            inputs["inboundSecurityRules"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["nvaSku"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["virtualApplianceAsn"] = undefined /*out*/;
            inputs["virtualApplianceNics"] = undefined /*out*/;
            inputs["virtualApplianceSites"] = undefined /*out*/;
            inputs["virtualHub"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:network/latest:NetworkVirtualAppliance" }, { type: "azure-nextgen:network/v20191201:NetworkVirtualAppliance" }, { type: "azure-nextgen:network/v20200301:NetworkVirtualAppliance" }, { type: "azure-nextgen:network/v20200401:NetworkVirtualAppliance" }, { type: "azure-nextgen:network/v20200501:NetworkVirtualAppliance" }, { type: "azure-nextgen:network/v20200701:NetworkVirtualAppliance" }, { type: "azure-nextgen:network/v20200801:NetworkVirtualAppliance" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(NetworkVirtualAppliance.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a NetworkVirtualAppliance resource.
 */
export interface NetworkVirtualApplianceArgs {
    /**
     * BootStrapConfigurationBlobs storage URLs.
     */
    readonly bootStrapConfigurationBlobs?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * CloudInitConfiguration string in plain text.
     */
    readonly cloudInitConfiguration?: pulumi.Input<string>;
    /**
     * CloudInitConfigurationBlob storage URLs.
     */
    readonly cloudInitConfigurationBlobs?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Resource ID.
     */
    readonly id?: pulumi.Input<string>;
    /**
     * The service principal that has read access to cloud-init and config blob.
     */
    readonly identity?: pulumi.Input<inputs.network.v20200601.ManagedServiceIdentity>;
    /**
     * Resource location.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * The name of Network Virtual Appliance.
     */
    readonly networkVirtualApplianceName: pulumi.Input<string>;
    /**
     * Network Virtual Appliance SKU.
     */
    readonly nvaSku?: pulumi.Input<inputs.network.v20200601.VirtualApplianceSkuProperties>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Resource tags.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * VirtualAppliance ASN.
     */
    readonly virtualApplianceAsn?: pulumi.Input<number>;
    /**
     * The Virtual Hub where Network Virtual Appliance is being deployed.
     */
    readonly virtualHub?: pulumi.Input<inputs.network.v20200601.SubResource>;
}

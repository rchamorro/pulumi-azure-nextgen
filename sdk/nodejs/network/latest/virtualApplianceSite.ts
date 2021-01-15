// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Virtual Appliance Site resource.
 * Latest API Version: 2020-08-01.
 */
export class VirtualApplianceSite extends pulumi.CustomResource {
    /**
     * Get an existing VirtualApplianceSite resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): VirtualApplianceSite {
        return new VirtualApplianceSite(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:network/latest:VirtualApplianceSite';

    /**
     * Returns true if the given object is an instance of VirtualApplianceSite.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is VirtualApplianceSite {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === VirtualApplianceSite.__pulumiType;
    }

    /**
     * Address Prefix.
     */
    public readonly addressPrefix!: pulumi.Output<string | undefined>;
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    public /*out*/ readonly etag!: pulumi.Output<string>;
    /**
     * Name of the virtual appliance site.
     */
    public readonly name!: pulumi.Output<string | undefined>;
    /**
     * Office 365 Policy.
     */
    public readonly o365Policy!: pulumi.Output<outputs.network.latest.Office365PolicyPropertiesResponse | undefined>;
    /**
     * The provisioning state of the resource.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * Site type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a VirtualApplianceSite resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: VirtualApplianceSiteArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.networkVirtualApplianceName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'networkVirtualApplianceName'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if ((!args || args.siteName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'siteName'");
            }
            inputs["addressPrefix"] = args ? args.addressPrefix : undefined;
            inputs["id"] = args ? args.id : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["networkVirtualApplianceName"] = args ? args.networkVirtualApplianceName : undefined;
            inputs["o365Policy"] = args ? args.o365Policy : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["siteName"] = args ? args.siteName : undefined;
            inputs["etag"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["addressPrefix"] = undefined /*out*/;
            inputs["etag"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["o365Policy"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:network/v20200501:VirtualApplianceSite" }, { type: "azure-nextgen:network/v20200601:VirtualApplianceSite" }, { type: "azure-nextgen:network/v20200701:VirtualApplianceSite" }, { type: "azure-nextgen:network/v20200801:VirtualApplianceSite" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(VirtualApplianceSite.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a VirtualApplianceSite resource.
 */
export interface VirtualApplianceSiteArgs {
    /**
     * Address Prefix.
     */
    readonly addressPrefix?: pulumi.Input<string>;
    /**
     * Resource ID.
     */
    readonly id?: pulumi.Input<string>;
    /**
     * Name of the virtual appliance site.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The name of the Network Virtual Appliance.
     */
    readonly networkVirtualApplianceName: pulumi.Input<string>;
    /**
     * Office 365 Policy.
     */
    readonly o365Policy?: pulumi.Input<inputs.network.latest.Office365PolicyProperties>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the site.
     */
    readonly siteName: pulumi.Input<string>;
}

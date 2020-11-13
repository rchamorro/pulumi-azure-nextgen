// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * Custom IP prefix resource.
 */
export class CustomIPPrefix extends pulumi.CustomResource {
    /**
     * Get an existing CustomIPPrefix resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): CustomIPPrefix {
        return new CustomIPPrefix(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:network/v20200701:CustomIPPrefix';

    /**
     * Returns true if the given object is an instance of CustomIPPrefix.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is CustomIPPrefix {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === CustomIPPrefix.__pulumiType;
    }

    /**
     * The prefix range in CIDR notation. Should include the start address and the prefix length.
     */
    public readonly cidr!: pulumi.Output<string | undefined>;
    /**
     * The commissioned state of the Custom IP Prefix.
     */
    public readonly commissionedState!: pulumi.Output<string | undefined>;
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    public /*out*/ readonly etag!: pulumi.Output<string>;
    /**
     * Resource location.
     */
    public readonly location!: pulumi.Output<string | undefined>;
    /**
     * Resource name.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The provisioning state of the custom IP prefix resource.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * The list of all referenced PublicIpPrefixes.
     */
    public /*out*/ readonly publicIpPrefixes!: pulumi.Output<outputs.network.v20200701.SubResourceResponse[]>;
    /**
     * The resource GUID property of the custom IP prefix resource.
     */
    public /*out*/ readonly resourceGuid!: pulumi.Output<string>;
    /**
     * Resource tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * A list of availability zones denoting the IP allocated for the resource needs to come from.
     */
    public readonly zones!: pulumi.Output<string[] | undefined>;

    /**
     * Create a CustomIPPrefix resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: CustomIPPrefixArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.customIpPrefixName === undefined) {
                throw new Error("Missing required property 'customIpPrefixName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["cidr"] = args ? args.cidr : undefined;
            inputs["commissionedState"] = args ? args.commissionedState : undefined;
            inputs["customIpPrefixName"] = args ? args.customIpPrefixName : undefined;
            inputs["id"] = args ? args.id : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["zones"] = args ? args.zones : undefined;
            inputs["etag"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["publicIpPrefixes"] = undefined /*out*/;
            inputs["resourceGuid"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["cidr"] = undefined /*out*/;
            inputs["commissionedState"] = undefined /*out*/;
            inputs["etag"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["publicIpPrefixes"] = undefined /*out*/;
            inputs["resourceGuid"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["zones"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:network/latest:CustomIPPrefix" }, { type: "azure-nextgen:network/v20200601:CustomIPPrefix" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(CustomIPPrefix.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a CustomIPPrefix resource.
 */
export interface CustomIPPrefixArgs {
    /**
     * The prefix range in CIDR notation. Should include the start address and the prefix length.
     */
    readonly cidr?: pulumi.Input<string>;
    /**
     * The commissioned state of the Custom IP Prefix.
     */
    readonly commissionedState?: pulumi.Input<string>;
    /**
     * The name of the custom IP prefix.
     */
    readonly customIpPrefixName: pulumi.Input<string>;
    /**
     * Resource ID.
     */
    readonly id?: pulumi.Input<string>;
    /**
     * Resource location.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Resource tags.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * A list of availability zones denoting the IP allocated for the resource needs to come from.
     */
    readonly zones?: pulumi.Input<pulumi.Input<string>[]>;
}

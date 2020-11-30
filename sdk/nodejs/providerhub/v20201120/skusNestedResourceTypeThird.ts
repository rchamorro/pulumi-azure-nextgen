// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export class SkusNestedResourceTypeThird extends pulumi.CustomResource {
    /**
     * Get an existing SkusNestedResourceTypeThird resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): SkusNestedResourceTypeThird {
        return new SkusNestedResourceTypeThird(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:providerhub/v20201120:SkusNestedResourceTypeThird';

    /**
     * Returns true if the given object is an instance of SkusNestedResourceTypeThird.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is SkusNestedResourceTypeThird {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === SkusNestedResourceTypeThird.__pulumiType;
    }

    /**
     * The name of the resource
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    public /*out*/ readonly properties!: pulumi.Output<outputs.providerhub.v20201120.SkuResourceResponseProperties>;
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a SkusNestedResourceTypeThird resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: SkusNestedResourceTypeThirdArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.nestedResourceTypeFirst === undefined) {
                throw new Error("Missing required property 'nestedResourceTypeFirst'");
            }
            if (!args || args.nestedResourceTypeSecond === undefined) {
                throw new Error("Missing required property 'nestedResourceTypeSecond'");
            }
            if (!args || args.nestedResourceTypeThird === undefined) {
                throw new Error("Missing required property 'nestedResourceTypeThird'");
            }
            if (!args || args.providerNamespace === undefined) {
                throw new Error("Missing required property 'providerNamespace'");
            }
            if (!args || args.resourceType === undefined) {
                throw new Error("Missing required property 'resourceType'");
            }
            if (!args || args.sku === undefined) {
                throw new Error("Missing required property 'sku'");
            }
            inputs["nestedResourceTypeFirst"] = args ? args.nestedResourceTypeFirst : undefined;
            inputs["nestedResourceTypeSecond"] = args ? args.nestedResourceTypeSecond : undefined;
            inputs["nestedResourceTypeThird"] = args ? args.nestedResourceTypeThird : undefined;
            inputs["providerNamespace"] = args ? args.providerNamespace : undefined;
            inputs["resourceType"] = args ? args.resourceType : undefined;
            inputs["sku"] = args ? args.sku : undefined;
            inputs["name"] = undefined /*out*/;
            inputs["properties"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["name"] = undefined /*out*/;
            inputs["properties"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:providerhub/latest:SkusNestedResourceTypeThird" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(SkusNestedResourceTypeThird.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a SkusNestedResourceTypeThird resource.
 */
export interface SkusNestedResourceTypeThirdArgs {
    /**
     * The first child resource type.
     */
    readonly nestedResourceTypeFirst: pulumi.Input<string>;
    /**
     * The second child resource type.
     */
    readonly nestedResourceTypeSecond: pulumi.Input<string>;
    /**
     * The third child resource type.
     */
    readonly nestedResourceTypeThird: pulumi.Input<string>;
    /**
     * The name of the resource provider hosted within ProviderHub.
     */
    readonly providerNamespace: pulumi.Input<string>;
    /**
     * The resource type.
     */
    readonly resourceType: pulumi.Input<string>;
    /**
     * The SKU.
     */
    readonly sku: pulumi.Input<string>;
}
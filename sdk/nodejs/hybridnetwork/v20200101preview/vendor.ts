// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * Vendor resource.
 */
export class Vendor extends pulumi.CustomResource {
    /**
     * Get an existing Vendor resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Vendor {
        return new Vendor(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:hybridnetwork/v20200101preview:Vendor';

    /**
     * Returns true if the given object is an instance of Vendor.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Vendor {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Vendor.__pulumiType;
    }

    /**
     * The name of the resource
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The provisioning state of the vendor resource.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * A list of IDs of the vendor skus offered by the vendor.
     */
    public /*out*/ readonly skus!: pulumi.Output<outputs.hybridnetwork.v20200101preview.SubResourceResponse[]>;
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a Vendor resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: VendorArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.vendorName === undefined) {
                throw new Error("Missing required property 'vendorName'");
            }
            inputs["vendorName"] = args ? args.vendorName : undefined;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["skus"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["skus"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(Vendor.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Vendor resource.
 */
export interface VendorArgs {
    /**
     * The name of the vendor.
     */
    readonly vendorName: pulumi.Input<string>;
}

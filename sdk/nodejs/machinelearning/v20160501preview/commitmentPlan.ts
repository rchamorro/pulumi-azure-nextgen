// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * An Azure ML commitment plan resource.
 */
export class CommitmentPlan extends pulumi.CustomResource {
    /**
     * Get an existing CommitmentPlan resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): CommitmentPlan {
        return new CommitmentPlan(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:machinelearning/v20160501preview:CommitmentPlan';

    /**
     * Returns true if the given object is an instance of CommitmentPlan.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is CommitmentPlan {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === CommitmentPlan.__pulumiType;
    }

    /**
     * An entity tag used to enforce optimistic concurrency.
     */
    public readonly etag!: pulumi.Output<string | undefined>;
    /**
     * Resource location.
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * Resource name.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The commitment plan properties.
     */
    public /*out*/ readonly properties!: pulumi.Output<outputs.machinelearning.v20160501preview.CommitmentPlanPropertiesResponse>;
    /**
     * The commitment plan SKU.
     */
    public readonly sku!: pulumi.Output<outputs.machinelearning.v20160501preview.ResourceSkuResponse | undefined>;
    /**
     * User-defined tags for the resource.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a CommitmentPlan resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: CommitmentPlanArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.commitmentPlanName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'commitmentPlanName'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["commitmentPlanName"] = args ? args.commitmentPlanName : undefined;
            inputs["etag"] = args ? args.etag : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["sku"] = args ? args.sku : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["name"] = undefined /*out*/;
            inputs["properties"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["etag"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["properties"] = undefined /*out*/;
            inputs["sku"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(CommitmentPlan.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a CommitmentPlan resource.
 */
export interface CommitmentPlanArgs {
    /**
     * The Azure ML commitment plan name.
     */
    readonly commitmentPlanName: pulumi.Input<string>;
    /**
     * An entity tag used to enforce optimistic concurrency.
     */
    readonly etag?: pulumi.Input<string>;
    /**
     * Resource location.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * The resource group name.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The commitment plan SKU.
     */
    readonly sku?: pulumi.Input<inputs.machinelearning.v20160501preview.ResourceSku>;
    /**
     * User-defined tags for the resource.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}

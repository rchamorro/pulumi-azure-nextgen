// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * An object that represents a pipeline run for a container registry.
 */
export class PipelineRun extends pulumi.CustomResource {
    /**
     * Get an existing PipelineRun resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): PipelineRun {
        return new PipelineRun(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:containerregistry/v20191201preview:PipelineRun';

    /**
     * Returns true if the given object is an instance of PipelineRun.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is PipelineRun {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === PipelineRun.__pulumiType;
    }

    /**
     * How the pipeline run should be forced to recreate even if the pipeline run configuration has not changed.
     */
    public readonly forceUpdateTag!: pulumi.Output<string | undefined>;
    /**
     * The name of the resource.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The provisioning state of a pipeline run.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * The request parameters for a pipeline run.
     */
    public readonly request!: pulumi.Output<outputs.containerregistry.v20191201preview.PipelineRunRequestResponse | undefined>;
    /**
     * The response of a pipeline run.
     */
    public /*out*/ readonly response!: pulumi.Output<outputs.containerregistry.v20191201preview.PipelineRunResponseResponse>;
    /**
     * The type of the resource.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a PipelineRun resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: PipelineRunArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.pipelineRunName === undefined) {
                throw new Error("Missing required property 'pipelineRunName'");
            }
            if (!args || args.registryName === undefined) {
                throw new Error("Missing required property 'registryName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["forceUpdateTag"] = args ? args.forceUpdateTag : undefined;
            inputs["pipelineRunName"] = args ? args.pipelineRunName : undefined;
            inputs["registryName"] = args ? args.registryName : undefined;
            inputs["request"] = args ? args.request : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["response"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["forceUpdateTag"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["request"] = undefined /*out*/;
            inputs["response"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(PipelineRun.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a PipelineRun resource.
 */
export interface PipelineRunArgs {
    /**
     * How the pipeline run should be forced to recreate even if the pipeline run configuration has not changed.
     */
    readonly forceUpdateTag?: pulumi.Input<string>;
    /**
     * The name of the pipeline run.
     */
    readonly pipelineRunName: pulumi.Input<string>;
    /**
     * The name of the container registry.
     */
    readonly registryName: pulumi.Input<string>;
    /**
     * The request parameters for a pipeline run.
     */
    readonly request?: pulumi.Input<inputs.containerregistry.v20191201preview.PipelineRunRequest>;
    /**
     * The name of the resource group to which the container registry belongs.
     */
    readonly resourceGroupName: pulumi.Input<string>;
}

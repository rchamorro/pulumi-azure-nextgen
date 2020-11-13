// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * Response to put/get patch schedules for Redis cache.
 */
export class PatchSchedule extends pulumi.CustomResource {
    /**
     * Get an existing PatchSchedule resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): PatchSchedule {
        return new PatchSchedule(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:cache/v20180301:PatchSchedule';

    /**
     * Returns true if the given object is an instance of PatchSchedule.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is PatchSchedule {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === PatchSchedule.__pulumiType;
    }

    /**
     * Resource name.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * List of patch schedules for a Redis cache.
     */
    public readonly scheduleEntries!: pulumi.Output<outputs.cache.v20180301.ScheduleEntryResponse[]>;
    /**
     * Resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a PatchSchedule resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: PatchScheduleArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.default === undefined) {
                throw new Error("Missing required property 'default'");
            }
            if (!args || args.name === undefined) {
                throw new Error("Missing required property 'name'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.scheduleEntries === undefined) {
                throw new Error("Missing required property 'scheduleEntries'");
            }
            inputs["default"] = args ? args.default : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["scheduleEntries"] = args ? args.scheduleEntries : undefined;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["name"] = undefined /*out*/;
            inputs["scheduleEntries"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:cache/latest:PatchSchedule" }, { type: "azure-nextgen:cache/v20171001:PatchSchedule" }, { type: "azure-nextgen:cache/v20190701:PatchSchedule" }, { type: "azure-nextgen:cache/v20200601:PatchSchedule" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(PatchSchedule.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a PatchSchedule resource.
 */
export interface PatchScheduleArgs {
    /**
     * Default string modeled as parameter for auto generation to work correctly.
     */
    readonly default: pulumi.Input<string>;
    /**
     * The name of the Redis cache.
     */
    readonly name: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * List of patch schedules for a Redis cache.
     */
    readonly scheduleEntries: pulumi.Input<pulumi.Input<inputs.cache.v20180301.ScheduleEntry>[]>;
}

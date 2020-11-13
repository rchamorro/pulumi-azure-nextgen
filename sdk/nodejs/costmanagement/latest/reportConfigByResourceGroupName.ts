// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * A report config resource.
 */
export class ReportConfigByResourceGroupName extends pulumi.CustomResource {
    /**
     * Get an existing ReportConfigByResourceGroupName resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ReportConfigByResourceGroupName {
        return new ReportConfigByResourceGroupName(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:costmanagement/latest:ReportConfigByResourceGroupName';

    /**
     * Returns true if the given object is an instance of ReportConfigByResourceGroupName.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ReportConfigByResourceGroupName {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ReportConfigByResourceGroupName.__pulumiType;
    }

    /**
     * Has definition for the report config.
     */
    public readonly definition!: pulumi.Output<outputs.costmanagement.latest.ReportConfigDefinitionResponse>;
    /**
     * Has delivery information for the report config.
     */
    public readonly deliveryInfo!: pulumi.Output<outputs.costmanagement.latest.ReportConfigDeliveryInfoResponse>;
    /**
     * The format of the report being delivered.
     */
    public readonly format!: pulumi.Output<string | undefined>;
    /**
     * Resource name.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Has schedule information for the report config.
     */
    public readonly schedule!: pulumi.Output<outputs.costmanagement.latest.ReportConfigScheduleResponse | undefined>;
    /**
     * Resource tags.
     */
    public /*out*/ readonly tags!: pulumi.Output<{[key: string]: string}>;
    /**
     * Resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a ReportConfigByResourceGroupName resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ReportConfigByResourceGroupNameArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.definition === undefined) {
                throw new Error("Missing required property 'definition'");
            }
            if (!args || args.deliveryInfo === undefined) {
                throw new Error("Missing required property 'deliveryInfo'");
            }
            if (!args || args.reportConfigName === undefined) {
                throw new Error("Missing required property 'reportConfigName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["definition"] = args ? args.definition : undefined;
            inputs["deliveryInfo"] = args ? args.deliveryInfo : undefined;
            inputs["format"] = args ? args.format : undefined;
            inputs["reportConfigName"] = args ? args.reportConfigName : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["schedule"] = args ? args.schedule : undefined;
            inputs["name"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["definition"] = undefined /*out*/;
            inputs["deliveryInfo"] = undefined /*out*/;
            inputs["format"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["schedule"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:costmanagement/v20180531:ReportConfigByResourceGroupName" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(ReportConfigByResourceGroupName.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a ReportConfigByResourceGroupName resource.
 */
export interface ReportConfigByResourceGroupNameArgs {
    /**
     * Has definition for the report config.
     */
    readonly definition: pulumi.Input<inputs.costmanagement.latest.ReportConfigDefinition>;
    /**
     * Has delivery information for the report config.
     */
    readonly deliveryInfo: pulumi.Input<inputs.costmanagement.latest.ReportConfigDeliveryInfo>;
    /**
     * The format of the report being delivered.
     */
    readonly format?: pulumi.Input<string>;
    /**
     * Report Config Name.
     */
    readonly reportConfigName: pulumi.Input<string>;
    /**
     * Azure Resource Group Name.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Has schedule information for the report config.
     */
    readonly schedule?: pulumi.Input<inputs.costmanagement.latest.ReportConfigSchedule>;
}

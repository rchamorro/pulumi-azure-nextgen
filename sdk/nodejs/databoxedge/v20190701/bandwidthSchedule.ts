// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * The bandwidth schedule details.
 */
export class BandwidthSchedule extends pulumi.CustomResource {
    /**
     * Get an existing BandwidthSchedule resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): BandwidthSchedule {
        return new BandwidthSchedule(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:databoxedge/v20190701:BandwidthSchedule';

    /**
     * Returns true if the given object is an instance of BandwidthSchedule.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is BandwidthSchedule {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === BandwidthSchedule.__pulumiType;
    }

    /**
     * The days of the week when this schedule is applicable.
     */
    public readonly days!: pulumi.Output<string[]>;
    /**
     * The object name.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The bandwidth rate in Mbps.
     */
    public readonly rateInMbps!: pulumi.Output<number>;
    /**
     * The start time of the schedule in UTC.
     */
    public readonly start!: pulumi.Output<string>;
    /**
     * The stop time of the schedule in UTC.
     */
    public readonly stop!: pulumi.Output<string>;
    /**
     * The hierarchical type of the object.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a BandwidthSchedule resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: BandwidthScheduleArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.days === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'days'");
            }
            if ((!args || args.deviceName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'deviceName'");
            }
            if ((!args || args.name === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'name'");
            }
            if ((!args || args.rateInMbps === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'rateInMbps'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if ((!args || args.start === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'start'");
            }
            if ((!args || args.stop === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'stop'");
            }
            inputs["days"] = args ? args.days : undefined;
            inputs["deviceName"] = args ? args.deviceName : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["rateInMbps"] = args ? args.rateInMbps : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["start"] = args ? args.start : undefined;
            inputs["stop"] = args ? args.stop : undefined;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["days"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["rateInMbps"] = undefined /*out*/;
            inputs["start"] = undefined /*out*/;
            inputs["stop"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:databoxedge/latest:BandwidthSchedule" }, { type: "azure-nextgen:databoxedge/v20190301:BandwidthSchedule" }, { type: "azure-nextgen:databoxedge/v20190801:BandwidthSchedule" }, { type: "azure-nextgen:databoxedge/v20200501preview:BandwidthSchedule" }, { type: "azure-nextgen:databoxedge/v20200901:BandwidthSchedule" }, { type: "azure-nextgen:databoxedge/v20200901preview:BandwidthSchedule" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(BandwidthSchedule.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a BandwidthSchedule resource.
 */
export interface BandwidthScheduleArgs {
    /**
     * The days of the week when this schedule is applicable.
     */
    readonly days: pulumi.Input<pulumi.Input<string | enums.databoxedge.v20190701.DayOfWeek>[]>;
    /**
     * The device name.
     */
    readonly deviceName: pulumi.Input<string>;
    /**
     * The bandwidth schedule name which needs to be added/updated.
     */
    readonly name: pulumi.Input<string>;
    /**
     * The bandwidth rate in Mbps.
     */
    readonly rateInMbps: pulumi.Input<number>;
    /**
     * The resource group name.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The start time of the schedule in UTC.
     */
    readonly start: pulumi.Input<string>;
    /**
     * The stop time of the schedule in UTC.
     */
    readonly stop: pulumi.Input<string>;
}

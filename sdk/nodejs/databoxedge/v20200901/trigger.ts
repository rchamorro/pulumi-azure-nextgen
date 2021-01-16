// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Trigger details.
 */
export class Trigger extends pulumi.CustomResource {
    /**
     * Get an existing Trigger resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Trigger {
        return new Trigger(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:databoxedge/v20200901:Trigger';

    /**
     * Returns true if the given object is an instance of Trigger.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Trigger {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Trigger.__pulumiType;
    }

    /**
     * Trigger Kind.
     */
    public readonly kind!: pulumi.Output<string>;
    /**
     * The object name.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Trigger in DataBoxEdge Resource
     */
    public /*out*/ readonly systemData!: pulumi.Output<outputs.databoxedge.v20200901.SystemDataResponse>;
    /**
     * The hierarchical type of the object.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a Trigger resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: TriggerArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.deviceName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'deviceName'");
            }
            if ((!args || args.kind === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'kind'");
            }
            if ((!args || args.name === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'name'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["deviceName"] = args ? args.deviceName : undefined;
            inputs["kind"] = args ? args.kind : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["systemData"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["kind"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["systemData"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:databoxedge/latest:Trigger" }, { type: "azure-nextgen:databoxedge/v20190301:Trigger" }, { type: "azure-nextgen:databoxedge/v20190701:Trigger" }, { type: "azure-nextgen:databoxedge/v20190801:Trigger" }, { type: "azure-nextgen:databoxedge/v20200501preview:Trigger" }, { type: "azure-nextgen:databoxedge/v20200901preview:Trigger" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(Trigger.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Trigger resource.
 */
export interface TriggerArgs {
    /**
     * Creates or updates a trigger
     */
    readonly deviceName: pulumi.Input<string>;
    /**
     * Trigger Kind.
     */
    readonly kind: pulumi.Input<string | enums.databoxedge.v20200901.TriggerEventType>;
    /**
     * The trigger name.
     */
    readonly name: pulumi.Input<string>;
    /**
     * The resource group name.
     */
    readonly resourceGroupName: pulumi.Input<string>;
}

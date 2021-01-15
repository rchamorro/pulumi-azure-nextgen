// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * An activity log alert resource.
 */
export class ActivityLogAlert extends pulumi.CustomResource {
    /**
     * Get an existing ActivityLogAlert resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ActivityLogAlert {
        return new ActivityLogAlert(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:insights/v20170401:ActivityLogAlert';

    /**
     * Returns true if the given object is an instance of ActivityLogAlert.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ActivityLogAlert {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ActivityLogAlert.__pulumiType;
    }

    /**
     * The actions that will activate when the condition is met.
     */
    public readonly actions!: pulumi.Output<outputs.insights.v20170401.ActivityLogAlertActionListResponse>;
    /**
     * The condition that will cause this alert to activate.
     */
    public readonly condition!: pulumi.Output<outputs.insights.v20170401.ActivityLogAlertAllOfConditionResponse>;
    /**
     * A description of this activity log alert.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * Indicates whether this activity log alert is enabled. If an activity log alert is not enabled, then none of its actions will be activated.
     */
    public readonly enabled!: pulumi.Output<boolean | undefined>;
    /**
     * Resource location
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * Azure resource name
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * A list of resourceIds that will be used as prefixes. The alert will only apply to activityLogs with resourceIds that fall under one of these prefixes. This list must include at least one item.
     */
    public readonly scopes!: pulumi.Output<string[]>;
    /**
     * Resource tags
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Azure resource type
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a ActivityLogAlert resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ActivityLogAlertArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.actions === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'actions'");
            }
            if ((!args || args.activityLogAlertName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'activityLogAlertName'");
            }
            if ((!args || args.condition === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'condition'");
            }
            if ((!args || args.location === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'location'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if ((!args || args.scopes === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'scopes'");
            }
            inputs["actions"] = args ? args.actions : undefined;
            inputs["activityLogAlertName"] = args ? args.activityLogAlertName : undefined;
            inputs["condition"] = args ? args.condition : undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["enabled"] = (args ? args.enabled : undefined) || true;
            inputs["location"] = args ? args.location : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["scopes"] = args ? args.scopes : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["name"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["actions"] = undefined /*out*/;
            inputs["condition"] = undefined /*out*/;
            inputs["description"] = undefined /*out*/;
            inputs["enabled"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["scopes"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:insights/latest:ActivityLogAlert" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(ActivityLogAlert.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a ActivityLogAlert resource.
 */
export interface ActivityLogAlertArgs {
    /**
     * The actions that will activate when the condition is met.
     */
    readonly actions: pulumi.Input<inputs.insights.v20170401.ActivityLogAlertActionList>;
    /**
     * The name of the activity log alert.
     */
    readonly activityLogAlertName: pulumi.Input<string>;
    /**
     * The condition that will cause this alert to activate.
     */
    readonly condition: pulumi.Input<inputs.insights.v20170401.ActivityLogAlertAllOfCondition>;
    /**
     * A description of this activity log alert.
     */
    readonly description?: pulumi.Input<string>;
    /**
     * Indicates whether this activity log alert is enabled. If an activity log alert is not enabled, then none of its actions will be activated.
     */
    readonly enabled?: pulumi.Input<boolean>;
    /**
     * Resource location
     */
    readonly location: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * A list of resourceIds that will be used as prefixes. The alert will only apply to activityLogs with resourceIds that fall under one of these prefixes. This list must include at least one item.
     */
    readonly scopes: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Resource tags
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}

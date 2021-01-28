// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * The metric alert resource.
 */
export class MetricAlert extends pulumi.CustomResource {
    /**
     * Get an existing MetricAlert resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): MetricAlert {
        return new MetricAlert(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:insights/v20180301:MetricAlert';

    /**
     * Returns true if the given object is an instance of MetricAlert.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is MetricAlert {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === MetricAlert.__pulumiType;
    }

    /**
     * the array of actions that are performed when the alert rule becomes active, and when an alert condition is resolved.
     */
    public readonly actions!: pulumi.Output<outputs.insights.v20180301.MetricAlertActionResponse[] | undefined>;
    /**
     * the flag that indicates whether the alert should be auto resolved or not. The default is true.
     */
    public readonly autoMitigate!: pulumi.Output<boolean | undefined>;
    /**
     * defines the specific alert criteria information.
     */
    public readonly criteria!: pulumi.Output<outputs.insights.v20180301.MetricAlertMultipleResourceMultipleMetricCriteriaResponse | outputs.insights.v20180301.MetricAlertSingleResourceMultipleMetricCriteriaResponse | outputs.insights.v20180301.WebtestLocationAvailabilityCriteriaResponse>;
    /**
     * the description of the metric alert that will be included in the alert email.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * the flag that indicates whether the metric alert is enabled.
     */
    public readonly enabled!: pulumi.Output<boolean>;
    /**
     * how often the metric alert is evaluated represented in ISO 8601 duration format.
     */
    public readonly evaluationFrequency!: pulumi.Output<string>;
    /**
     * the value indicating whether this alert rule is migrated.
     */
    public /*out*/ readonly isMigrated!: pulumi.Output<boolean>;
    /**
     * Last time the rule was updated in ISO8601 format.
     */
    public /*out*/ readonly lastUpdatedTime!: pulumi.Output<string>;
    /**
     * Resource location
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * Azure resource name
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * the list of resource id's that this metric alert is scoped to.
     */
    public readonly scopes!: pulumi.Output<string[]>;
    /**
     * Alert severity {0, 1, 2, 3, 4}
     */
    public readonly severity!: pulumi.Output<number>;
    /**
     * Resource tags
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * the region of the target resource(s) on which the alert is created/updated. Mandatory if the scope contains a subscription, resource group, or more than one resource.
     */
    public readonly targetResourceRegion!: pulumi.Output<string | undefined>;
    /**
     * the resource type of the target resource(s) on which the alert is created/updated. Mandatory if the scope contains a subscription, resource group, or more than one resource.
     */
    public readonly targetResourceType!: pulumi.Output<string | undefined>;
    /**
     * Azure resource type
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * the period of time (in ISO 8601 duration format) that is used to monitor alert activity based on the threshold.
     */
    public readonly windowSize!: pulumi.Output<string>;

    /**
     * Create a MetricAlert resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: MetricAlertArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.criteria === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'criteria'");
            }
            if ((!args || args.enabled === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'enabled'");
            }
            if ((!args || args.evaluationFrequency === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'evaluationFrequency'");
            }
            if ((!args || args.location === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'location'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if ((!args || args.ruleName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'ruleName'");
            }
            if ((!args || args.scopes === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'scopes'");
            }
            if ((!args || args.severity === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'severity'");
            }
            if ((!args || args.windowSize === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'windowSize'");
            }
            inputs["actions"] = args ? args.actions : undefined;
            inputs["autoMitigate"] = args ? args.autoMitigate : undefined;
            inputs["criteria"] = args ? args.criteria : undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["enabled"] = args ? args.enabled : undefined;
            inputs["evaluationFrequency"] = args ? args.evaluationFrequency : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["ruleName"] = args ? args.ruleName : undefined;
            inputs["scopes"] = args ? args.scopes : undefined;
            inputs["severity"] = args ? args.severity : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["targetResourceRegion"] = args ? args.targetResourceRegion : undefined;
            inputs["targetResourceType"] = args ? args.targetResourceType : undefined;
            inputs["windowSize"] = args ? args.windowSize : undefined;
            inputs["isMigrated"] = undefined /*out*/;
            inputs["lastUpdatedTime"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["actions"] = undefined /*out*/;
            inputs["autoMitigate"] = undefined /*out*/;
            inputs["criteria"] = undefined /*out*/;
            inputs["description"] = undefined /*out*/;
            inputs["enabled"] = undefined /*out*/;
            inputs["evaluationFrequency"] = undefined /*out*/;
            inputs["isMigrated"] = undefined /*out*/;
            inputs["lastUpdatedTime"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["scopes"] = undefined /*out*/;
            inputs["severity"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["targetResourceRegion"] = undefined /*out*/;
            inputs["targetResourceType"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["windowSize"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:insights/latest:MetricAlert" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(MetricAlert.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a MetricAlert resource.
 */
export interface MetricAlertArgs {
    /**
     * the array of actions that are performed when the alert rule becomes active, and when an alert condition is resolved.
     */
    readonly actions?: pulumi.Input<pulumi.Input<inputs.insights.v20180301.MetricAlertAction>[]>;
    /**
     * the flag that indicates whether the alert should be auto resolved or not. The default is true.
     */
    readonly autoMitigate?: pulumi.Input<boolean>;
    /**
     * defines the specific alert criteria information.
     */
    readonly criteria: pulumi.Input<inputs.insights.v20180301.MetricAlertMultipleResourceMultipleMetricCriteria | inputs.insights.v20180301.MetricAlertSingleResourceMultipleMetricCriteria | inputs.insights.v20180301.WebtestLocationAvailabilityCriteria>;
    /**
     * the description of the metric alert that will be included in the alert email.
     */
    readonly description?: pulumi.Input<string>;
    /**
     * the flag that indicates whether the metric alert is enabled.
     */
    readonly enabled: pulumi.Input<boolean>;
    /**
     * how often the metric alert is evaluated represented in ISO 8601 duration format.
     */
    readonly evaluationFrequency: pulumi.Input<string>;
    /**
     * Resource location
     */
    readonly location: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the rule.
     */
    readonly ruleName: pulumi.Input<string>;
    /**
     * the list of resource id's that this metric alert is scoped to.
     */
    readonly scopes: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Alert severity {0, 1, 2, 3, 4}
     */
    readonly severity: pulumi.Input<number>;
    /**
     * Resource tags
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * the region of the target resource(s) on which the alert is created/updated. Mandatory if the scope contains a subscription, resource group, or more than one resource.
     */
    readonly targetResourceRegion?: pulumi.Input<string>;
    /**
     * the resource type of the target resource(s) on which the alert is created/updated. Mandatory if the scope contains a subscription, resource group, or more than one resource.
     */
    readonly targetResourceType?: pulumi.Input<string>;
    /**
     * the period of time (in ISO 8601 duration format) that is used to monitor alert activity based on the threshold.
     */
    readonly windowSize: pulumi.Input<string>;
}

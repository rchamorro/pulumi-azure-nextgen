// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * Route Filter Rule Resource
 */
export class RouteFilterRule extends pulumi.CustomResource {
    /**
     * Get an existing RouteFilterRule resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): RouteFilterRule {
        return new RouteFilterRule(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:network/v20170801:RouteFilterRule';

    /**
     * Returns true if the given object is an instance of RouteFilterRule.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is RouteFilterRule {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === RouteFilterRule.__pulumiType;
    }

    /**
     * The access type of the rule. Valid values are: 'Allow', 'Deny'
     */
    public readonly access!: pulumi.Output<string>;
    /**
     * The collection for bgp community values to filter on. e.g. ['12076:5010','12076:5020']
     */
    public readonly communities!: pulumi.Output<string[]>;
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    public /*out*/ readonly etag!: pulumi.Output<string>;
    /**
     * Resource location.
     */
    public readonly location!: pulumi.Output<string | undefined>;
    /**
     * The name of the resource that is unique within a resource group. This name can be used to access the resource.
     */
    public readonly name!: pulumi.Output<string | undefined>;
    /**
     * The provisioning state of the resource. Possible values are: 'Updating', 'Deleting', 'Succeeded' and 'Failed'.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * The rule type of the rule. Valid value is: 'Community'
     */
    public readonly routeFilterRuleType!: pulumi.Output<string>;
    /**
     * Resource tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;

    /**
     * Create a RouteFilterRule resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: RouteFilterRuleArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.access === undefined) {
                throw new Error("Missing required property 'access'");
            }
            if (!args || args.communities === undefined) {
                throw new Error("Missing required property 'communities'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.routeFilterName === undefined) {
                throw new Error("Missing required property 'routeFilterName'");
            }
            if (!args || args.routeFilterRuleType === undefined) {
                throw new Error("Missing required property 'routeFilterRuleType'");
            }
            if (!args || args.ruleName === undefined) {
                throw new Error("Missing required property 'ruleName'");
            }
            inputs["access"] = args ? args.access : undefined;
            inputs["communities"] = args ? args.communities : undefined;
            inputs["id"] = args ? args.id : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["routeFilterName"] = args ? args.routeFilterName : undefined;
            inputs["routeFilterRuleType"] = args ? args.routeFilterRuleType : undefined;
            inputs["ruleName"] = args ? args.ruleName : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["etag"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
        } else {
            inputs["access"] = undefined /*out*/;
            inputs["communities"] = undefined /*out*/;
            inputs["etag"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["routeFilterRuleType"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:network/latest:RouteFilterRule" }, { type: "azure-nextgen:network/v20161201:RouteFilterRule" }, { type: "azure-nextgen:network/v20170301:RouteFilterRule" }, { type: "azure-nextgen:network/v20170601:RouteFilterRule" }, { type: "azure-nextgen:network/v20170901:RouteFilterRule" }, { type: "azure-nextgen:network/v20171001:RouteFilterRule" }, { type: "azure-nextgen:network/v20171101:RouteFilterRule" }, { type: "azure-nextgen:network/v20180101:RouteFilterRule" }, { type: "azure-nextgen:network/v20180201:RouteFilterRule" }, { type: "azure-nextgen:network/v20180401:RouteFilterRule" }, { type: "azure-nextgen:network/v20180601:RouteFilterRule" }, { type: "azure-nextgen:network/v20180701:RouteFilterRule" }, { type: "azure-nextgen:network/v20180801:RouteFilterRule" }, { type: "azure-nextgen:network/v20181001:RouteFilterRule" }, { type: "azure-nextgen:network/v20181101:RouteFilterRule" }, { type: "azure-nextgen:network/v20181201:RouteFilterRule" }, { type: "azure-nextgen:network/v20190201:RouteFilterRule" }, { type: "azure-nextgen:network/v20190401:RouteFilterRule" }, { type: "azure-nextgen:network/v20190601:RouteFilterRule" }, { type: "azure-nextgen:network/v20190701:RouteFilterRule" }, { type: "azure-nextgen:network/v20190801:RouteFilterRule" }, { type: "azure-nextgen:network/v20190901:RouteFilterRule" }, { type: "azure-nextgen:network/v20191101:RouteFilterRule" }, { type: "azure-nextgen:network/v20191201:RouteFilterRule" }, { type: "azure-nextgen:network/v20200301:RouteFilterRule" }, { type: "azure-nextgen:network/v20200401:RouteFilterRule" }, { type: "azure-nextgen:network/v20200501:RouteFilterRule" }, { type: "azure-nextgen:network/v20200601:RouteFilterRule" }, { type: "azure-nextgen:network/v20200701:RouteFilterRule" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(RouteFilterRule.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a RouteFilterRule resource.
 */
export interface RouteFilterRuleArgs {
    /**
     * The access type of the rule. Valid values are: 'Allow', 'Deny'
     */
    readonly access: pulumi.Input<string>;
    /**
     * The collection for bgp community values to filter on. e.g. ['12076:5010','12076:5020']
     */
    readonly communities: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Resource ID.
     */
    readonly id?: pulumi.Input<string>;
    /**
     * Resource location.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * The name of the resource that is unique within a resource group. This name can be used to access the resource.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the route filter.
     */
    readonly routeFilterName: pulumi.Input<string>;
    /**
     * The rule type of the rule. Valid value is: 'Community'
     */
    readonly routeFilterRuleType: pulumi.Input<string>;
    /**
     * The name of the route filter rule.
     */
    readonly ruleName: pulumi.Input<string>;
    /**
     * Resource tags.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}

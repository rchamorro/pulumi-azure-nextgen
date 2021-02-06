// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Route Filter Resource.
 */
export class RouteFilter extends pulumi.CustomResource {
    /**
     * Get an existing RouteFilter resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): RouteFilter {
        return new RouteFilter(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:network/v20190701:RouteFilter';

    /**
     * Returns true if the given object is an instance of RouteFilter.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is RouteFilter {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === RouteFilter.__pulumiType;
    }

    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    public /*out*/ readonly etag!: pulumi.Output<string>;
    /**
     * A collection of references to express route circuit ipv6 peerings.
     */
    public readonly ipv6Peerings!: pulumi.Output<outputs.network.v20190701.ExpressRouteCircuitPeeringResponse[] | undefined>;
    /**
     * Resource location.
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * Resource name.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * A collection of references to express route circuit peerings.
     */
    public readonly peerings!: pulumi.Output<outputs.network.v20190701.ExpressRouteCircuitPeeringResponse[] | undefined>;
    /**
     * The provisioning state of the route filter resource.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * Collection of RouteFilterRules contained within a route filter.
     */
    public readonly rules!: pulumi.Output<outputs.network.v20190701.RouteFilterRuleResponse[] | undefined>;
    /**
     * Resource tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a RouteFilter resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: RouteFilterArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if ((!args || args.routeFilterName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'routeFilterName'");
            }
            inputs["id"] = args ? args.id : undefined;
            inputs["ipv6Peerings"] = args ? args.ipv6Peerings : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["peerings"] = args ? args.peerings : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["routeFilterName"] = args ? args.routeFilterName : undefined;
            inputs["rules"] = args ? args.rules : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["etag"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["etag"] = undefined /*out*/;
            inputs["ipv6Peerings"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["peerings"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["rules"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:network/latest:RouteFilter" }, { type: "azure-nextgen:network/v20161201:RouteFilter" }, { type: "azure-nextgen:network/v20170301:RouteFilter" }, { type: "azure-nextgen:network/v20170601:RouteFilter" }, { type: "azure-nextgen:network/v20170801:RouteFilter" }, { type: "azure-nextgen:network/v20170901:RouteFilter" }, { type: "azure-nextgen:network/v20171001:RouteFilter" }, { type: "azure-nextgen:network/v20171101:RouteFilter" }, { type: "azure-nextgen:network/v20180101:RouteFilter" }, { type: "azure-nextgen:network/v20180201:RouteFilter" }, { type: "azure-nextgen:network/v20180401:RouteFilter" }, { type: "azure-nextgen:network/v20180601:RouteFilter" }, { type: "azure-nextgen:network/v20180701:RouteFilter" }, { type: "azure-nextgen:network/v20180801:RouteFilter" }, { type: "azure-nextgen:network/v20181001:RouteFilter" }, { type: "azure-nextgen:network/v20181101:RouteFilter" }, { type: "azure-nextgen:network/v20181201:RouteFilter" }, { type: "azure-nextgen:network/v20190201:RouteFilter" }, { type: "azure-nextgen:network/v20190401:RouteFilter" }, { type: "azure-nextgen:network/v20190601:RouteFilter" }, { type: "azure-nextgen:network/v20190801:RouteFilter" }, { type: "azure-nextgen:network/v20190901:RouteFilter" }, { type: "azure-nextgen:network/v20191101:RouteFilter" }, { type: "azure-nextgen:network/v20191201:RouteFilter" }, { type: "azure-nextgen:network/v20200301:RouteFilter" }, { type: "azure-nextgen:network/v20200401:RouteFilter" }, { type: "azure-nextgen:network/v20200501:RouteFilter" }, { type: "azure-nextgen:network/v20200601:RouteFilter" }, { type: "azure-nextgen:network/v20200701:RouteFilter" }, { type: "azure-nextgen:network/v20200801:RouteFilter" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(RouteFilter.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a RouteFilter resource.
 */
export interface RouteFilterArgs {
    /**
     * Resource ID.
     */
    readonly id?: pulumi.Input<string>;
    /**
     * A collection of references to express route circuit ipv6 peerings.
     */
    readonly ipv6Peerings?: pulumi.Input<pulumi.Input<inputs.network.v20190701.ExpressRouteCircuitPeering>[]>;
    /**
     * Resource location.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * A collection of references to express route circuit peerings.
     */
    readonly peerings?: pulumi.Input<pulumi.Input<inputs.network.v20190701.ExpressRouteCircuitPeering>[]>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the route filter.
     */
    readonly routeFilterName: pulumi.Input<string>;
    /**
     * Collection of RouteFilterRules contained within a route filter.
     */
    readonly rules?: pulumi.Input<pulumi.Input<inputs.network.v20190701.RouteFilterRule>[]>;
    /**
     * Resource tags.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}

// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getRouteFilterRule(args: GetRouteFilterRuleArgs, opts?: pulumi.InvokeOptions): Promise<GetRouteFilterRuleResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:network/v20190901:getRouteFilterRule", {
        "resourceGroupName": args.resourceGroupName,
        "routeFilterName": args.routeFilterName,
        "ruleName": args.ruleName,
    }, opts);
}

export interface GetRouteFilterRuleArgs {
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the route filter.
     */
    readonly routeFilterName: string;
    /**
     * The name of the rule.
     */
    readonly ruleName: string;
}

/**
 * Route Filter Rule Resource.
 */
export interface GetRouteFilterRuleResult {
    /**
     * The access type of the rule.
     */
    readonly access: string;
    /**
     * The collection for bgp community values to filter on. e.g. ['12076:5010','12076:5020'].
     */
    readonly communities: string[];
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    readonly etag: string;
    /**
     * Resource location.
     */
    readonly location?: string;
    /**
     * The name of the resource that is unique within a resource group. This name can be used to access the resource.
     */
    readonly name?: string;
    /**
     * The provisioning state of the route filter rule resource.
     */
    readonly provisioningState: string;
    /**
     * The rule type of the rule.
     */
    readonly routeFilterRuleType: string;
}

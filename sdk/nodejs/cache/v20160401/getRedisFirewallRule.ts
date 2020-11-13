// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getRedisFirewallRule(args: GetRedisFirewallRuleArgs, opts?: pulumi.InvokeOptions): Promise<GetRedisFirewallRuleResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:cache/v20160401:getRedisFirewallRule", {
        "cacheName": args.cacheName,
        "resourceGroupName": args.resourceGroupName,
        "ruleName": args.ruleName,
    }, opts);
}

export interface GetRedisFirewallRuleArgs {
    /**
     * The name of the Redis cache.
     */
    readonly cacheName: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the firewall rule.
     */
    readonly ruleName: string;
}

/**
 * A firewall rule on a redis cache has a name, and describes a contiguous range of IP addresses permitted to connect
 */
export interface GetRedisFirewallRuleResult {
    /**
     * highest IP address included in the range
     */
    readonly endIP: string;
    /**
     * name of the firewall rule
     */
    readonly name: string;
    /**
     * lowest IP address included in the range
     */
    readonly startIP: string;
    /**
     * type (of the firewall rule resource = 'Microsoft.Cache/redis/firewallRule')
     */
    readonly type: string;
}

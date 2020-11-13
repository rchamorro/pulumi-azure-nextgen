// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getFirewallPolicyRuleCollectionGroup(args: GetFirewallPolicyRuleCollectionGroupArgs, opts?: pulumi.InvokeOptions): Promise<GetFirewallPolicyRuleCollectionGroupResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:network/latest:getFirewallPolicyRuleCollectionGroup", {
        "firewallPolicyName": args.firewallPolicyName,
        "resourceGroupName": args.resourceGroupName,
        "ruleCollectionGroupName": args.ruleCollectionGroupName,
    }, opts);
}

export interface GetFirewallPolicyRuleCollectionGroupArgs {
    /**
     * The name of the Firewall Policy.
     */
    readonly firewallPolicyName: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the FirewallPolicyRuleCollectionGroup.
     */
    readonly ruleCollectionGroupName: string;
}

/**
 * Rule Collection Group resource.
 */
export interface GetFirewallPolicyRuleCollectionGroupResult {
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    readonly etag: string;
    /**
     * The name of the resource that is unique within a resource group. This name can be used to access the resource.
     */
    readonly name?: string;
    /**
     * Priority of the Firewall Policy Rule Collection Group resource.
     */
    readonly priority?: number;
    /**
     * The provisioning state of the firewall policy rule collection group resource.
     */
    readonly provisioningState: string;
    /**
     * Group of Firewall Policy rule collections.
     */
    readonly ruleCollections?: outputs.network.latest.FirewallPolicyFilterRuleCollectionResponse | outputs.network.latest.FirewallPolicyNatRuleCollectionResponse[];
    /**
     * Rule Group type.
     */
    readonly type: string;
}

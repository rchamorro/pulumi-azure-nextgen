// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getPolicy(args: GetPolicyArgs, opts?: pulumi.InvokeOptions): Promise<GetPolicyResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:cdn/latest:getPolicy", {
        "policyName": args.policyName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetPolicyArgs {
    /**
     * The name of the CdnWebApplicationFirewallPolicy.
     */
    readonly policyName: string;
    /**
     * Name of the Resource group within the Azure subscription.
     */
    readonly resourceGroupName: string;
}

/**
 * Defines web application firewall policy for Azure CDN.
 */
export interface GetPolicyResult {
    /**
     * Describes custom rules inside the policy.
     */
    readonly customRules?: outputs.cdn.latest.CustomRuleListResponse;
    /**
     * Describes Azure CDN endpoints associated with this Web Application Firewall policy.
     */
    readonly endpointLinks: outputs.cdn.latest.CdnEndpointResponse[];
    /**
     * Gets a unique read-only string that changes whenever the resource is updated.
     */
    readonly etag?: string;
    /**
     * Resource location.
     */
    readonly location: string;
    /**
     * Describes managed rules inside the policy.
     */
    readonly managedRules?: outputs.cdn.latest.ManagedRuleSetListResponse;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * Describes  policySettings for policy
     */
    readonly policySettings?: outputs.cdn.latest.PolicySettingsResponse;
    /**
     * Provisioning state of the WebApplicationFirewallPolicy.
     */
    readonly provisioningState: string;
    /**
     * Describes rate limit rules inside the policy.
     */
    readonly rateLimitRules?: outputs.cdn.latest.RateLimitRuleListResponse;
    readonly resourceState: string;
    /**
     * The pricing tier (defines a CDN provider, feature list and rate) of the CdnWebApplicationFirewallPolicy.
     */
    readonly sku: outputs.cdn.latest.SkuResponse;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type.
     */
    readonly type: string;
}

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
/**
 * Defines web application firewall policy for Azure CDN.
 */
export declare class Policy extends pulumi.CustomResource {
    /**
     * Get an existing Policy resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Policy;
    /**
     * Returns true if the given object is an instance of Policy.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    static isInstance(obj: any): obj is Policy;
    /**
     * Describes custom rules inside the policy.
     */
    readonly customRules: pulumi.Output<outputs.cdn.v20190615.CustomRuleListResponse | undefined>;
    /**
     * Describes Azure CDN endpoints associated with this Web Application Firewall policy.
     */
    readonly endpointLinks: pulumi.Output<outputs.cdn.v20190615.CdnEndpointResponse[]>;
    /**
     * Gets a unique read-only string that changes whenever the resource is updated.
     */
    readonly etag: pulumi.Output<string | undefined>;
    /**
     * Resource location.
     */
    readonly location: pulumi.Output<string>;
    /**
     * Describes managed rules inside the policy.
     */
    readonly managedRules: pulumi.Output<outputs.cdn.v20190615.ManagedRuleSetListResponse | undefined>;
    /**
     * Resource name.
     */
    readonly name: pulumi.Output<string>;
    /**
     * Describes  policySettings for policy
     */
    readonly policySettings: pulumi.Output<outputs.cdn.v20190615.PolicySettingsResponse | undefined>;
    /**
     * Provisioning state of the WebApplicationFirewallPolicy.
     */
    readonly provisioningState: pulumi.Output<string>;
    /**
     * Describes rate limit rules inside the policy.
     */
    readonly rateLimitRules: pulumi.Output<outputs.cdn.v20190615.RateLimitRuleListResponse | undefined>;
    readonly resourceState: pulumi.Output<string>;
    /**
     * The pricing tier (defines a CDN provider, feature list and rate) of the CdnWebApplicationFirewallPolicy.
     */
    readonly sku: pulumi.Output<outputs.cdn.v20190615.SkuResponse>;
    /**
     * Resource tags.
     */
    readonly tags: pulumi.Output<{
        [key: string]: string;
    } | undefined>;
    /**
     * Resource type.
     */
    readonly type: pulumi.Output<string>;
    /**
     * Create a Policy resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: PolicyArgs, opts?: pulumi.CustomResourceOptions);
    constructor(name: string, state: undefined, opts: pulumi.CustomResourceOptions);
}
/**
 * The set of arguments for constructing a Policy resource.
 */
export interface PolicyArgs {
    /**
     * Describes custom rules inside the policy.
     */
    readonly customRules?: pulumi.Input<inputs.cdn.v20190615.CustomRuleList>;
    /**
     * Gets a unique read-only string that changes whenever the resource is updated.
     */
    readonly etag?: pulumi.Input<string>;
    /**
     * Resource location.
     */
    readonly location: pulumi.Input<string>;
    /**
     * Describes managed rules inside the policy.
     */
    readonly managedRules?: pulumi.Input<inputs.cdn.v20190615.ManagedRuleSetList>;
    /**
     * The name of the CdnWebApplicationFirewallPolicy.
     */
    readonly policyName: pulumi.Input<string>;
    /**
     * Describes  policySettings for policy
     */
    readonly policySettings?: pulumi.Input<inputs.cdn.v20190615.PolicySettings>;
    /**
     * Describes rate limit rules inside the policy.
     */
    readonly rateLimitRules?: pulumi.Input<inputs.cdn.v20190615.RateLimitRuleList>;
    /**
     * Name of the Resource group within the Azure subscription.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The pricing tier (defines a CDN provider, feature list and rate) of the CdnWebApplicationFirewallPolicy.
     */
    readonly sku: pulumi.Input<inputs.cdn.v20190615.Sku>;
    /**
     * Resource tags.
     */
    readonly tags?: pulumi.Input<{
        [key: string]: pulumi.Input<string>;
    }>;
}
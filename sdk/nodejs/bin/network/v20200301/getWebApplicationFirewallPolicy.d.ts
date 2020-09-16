import * as pulumi from "@pulumi/pulumi";
import * as outputs from "../../types/output";
export declare function getWebApplicationFirewallPolicy(args: GetWebApplicationFirewallPolicyArgs, opts?: pulumi.InvokeOptions): Promise<GetWebApplicationFirewallPolicyResult>;
export interface GetWebApplicationFirewallPolicyArgs {
    /**
     * The name of the policy.
     */
    readonly policyName: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
}
/**
 * Defines web application firewall policy.
 */
export interface GetWebApplicationFirewallPolicyResult {
    /**
     * A collection of references to application gateways.
     */
    readonly applicationGateways: outputs.network.v20200301.ApplicationGatewayResponse[];
    /**
     * The custom rules inside the policy.
     */
    readonly customRules?: outputs.network.v20200301.WebApplicationFirewallCustomRuleResponse[];
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    readonly etag: string;
    /**
     * A collection of references to application gateway http listeners.
     */
    readonly httpListeners: outputs.network.v20200301.SubResourceResponse[];
    /**
     * Resource location.
     */
    readonly location?: string;
    /**
     * Describes the managedRules structure.
     */
    readonly managedRules: outputs.network.v20200301.ManagedRulesDefinitionResponse;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * A collection of references to application gateway path rules.
     */
    readonly pathBasedRules: outputs.network.v20200301.SubResourceResponse[];
    /**
     * The PolicySettings for policy.
     */
    readonly policySettings?: outputs.network.v20200301.PolicySettingsResponse;
    /**
     * The provisioning state of the web application firewall policy resource.
     */
    readonly provisioningState: string;
    /**
     * Resource status of the policy.
     */
    readonly resourceState: string;
    /**
     * Resource tags.
     */
    readonly tags?: {
        [key: string]: string;
    };
    /**
     * Resource type.
     */
    readonly type: string;
}
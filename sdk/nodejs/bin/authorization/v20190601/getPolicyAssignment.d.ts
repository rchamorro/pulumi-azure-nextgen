import * as pulumi from "@pulumi/pulumi";
import * as outputs from "../../types/output";
export declare function getPolicyAssignment(args: GetPolicyAssignmentArgs, opts?: pulumi.InvokeOptions): Promise<GetPolicyAssignmentResult>;
export interface GetPolicyAssignmentArgs {
    /**
     * The name of the policy assignment to get.
     */
    readonly policyAssignmentName: string;
    /**
     * The scope of the policy assignment. Valid scopes are: management group (format: '/providers/Microsoft.Management/managementGroups/{managementGroup}'), subscription (format: '/subscriptions/{subscriptionId}'), resource group (format: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}', or resource (format: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/[{parentResourcePath}/]{resourceType}/{resourceName}'
     */
    readonly scope: string;
}
/**
 * The policy assignment.
 */
export interface GetPolicyAssignmentResult {
    /**
     * This message will be part of response in case of policy violation.
     */
    readonly description?: string;
    /**
     * The display name of the policy assignment.
     */
    readonly displayName?: string;
    /**
     * The policy assignment enforcement mode. Possible values are Default and DoNotEnforce.
     */
    readonly enforcementMode?: string;
    /**
     * The managed identity associated with the policy assignment.
     */
    readonly identity?: outputs.authorization.v20190601.IdentityResponse;
    /**
     * The location of the policy assignment. Only required when utilizing managed identity.
     */
    readonly location?: string;
    /**
     * The policy assignment metadata.
     */
    readonly metadata?: {
        [key: string]: any;
    };
    /**
     * The name of the policy assignment.
     */
    readonly name: string;
    /**
     * The policy's excluded scopes.
     */
    readonly notScopes?: string[];
    /**
     * Required if a parameter is used in policy rule.
     */
    readonly parameters?: {
        [key: string]: any;
    };
    /**
     * The ID of the policy definition or policy set definition being assigned.
     */
    readonly policyDefinitionId?: string;
    /**
     * The scope for the policy assignment.
     */
    readonly scope?: string;
    /**
     * The policy sku. This property is optional, obsolete, and will be ignored.
     */
    readonly sku?: outputs.authorization.v20190601.PolicySkuResponse;
    /**
     * The type of the policy assignment.
     */
    readonly type: string;
}
import * as pulumi from "@pulumi/pulumi";
import * as outputs from "../../types/output";
export declare function listMapContentCallbackUrl(args: ListMapContentCallbackUrlArgs, opts?: pulumi.InvokeOptions): Promise<ListMapContentCallbackUrlResult>;
export interface ListMapContentCallbackUrlArgs {
    /**
     * The integration account name.
     */
    readonly integrationAccountName: string;
    /**
     * The key type.
     */
    readonly keyType?: string;
    /**
     * The integration account map name.
     */
    readonly mapName: string;
    /**
     * The expiry time.
     */
    readonly notAfter?: string;
    /**
     * The resource group name.
     */
    readonly resourceGroupName: string;
}
/**
 * The workflow trigger callback URL.
 */
export interface ListMapContentCallbackUrlResult {
    /**
     * Gets the workflow trigger callback URL base path.
     */
    readonly basePath: string;
    /**
     * Gets the workflow trigger callback URL HTTP method.
     */
    readonly method: string;
    /**
     * Gets the workflow trigger callback URL query parameters.
     */
    readonly queries?: outputs.logic.v20160601.WorkflowTriggerListCallbackUrlQueriesResponse;
    /**
     * Gets the workflow trigger callback URL relative path.
     */
    readonly relativePath: string;
    /**
     * Gets the workflow trigger callback URL relative path parameters.
     */
    readonly relativePathParameters?: string[];
    /**
     * Gets the workflow trigger callback URL.
     */
    readonly value: string;
}
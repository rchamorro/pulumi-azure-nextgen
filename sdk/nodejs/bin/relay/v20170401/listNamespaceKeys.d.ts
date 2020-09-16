import * as pulumi from "@pulumi/pulumi";
export declare function listNamespaceKeys(args: ListNamespaceKeysArgs, opts?: pulumi.InvokeOptions): Promise<ListNamespaceKeysResult>;
export interface ListNamespaceKeysArgs {
    /**
     * The authorization rule name.
     */
    readonly authorizationRuleName: string;
    /**
     * The namespace name
     */
    readonly namespaceName: string;
    /**
     * Name of the Resource group within the Azure subscription.
     */
    readonly resourceGroupName: string;
}
/**
 * Namespace/Relay Connection String
 */
export interface ListNamespaceKeysResult {
    /**
     * A string that describes the authorization rule.
     */
    readonly keyName?: string;
    /**
     * Primary connection string of the created namespace authorization rule.
     */
    readonly primaryConnectionString?: string;
    /**
     * A base64-encoded 256-bit primary key for signing and validating the SAS token.
     */
    readonly primaryKey?: string;
    /**
     * Secondary connection string of the created namespace authorization rule.
     */
    readonly secondaryConnectionString?: string;
    /**
     * A base64-encoded 256-bit secondary key for signing and validating the SAS token.
     */
    readonly secondaryKey?: string;
}
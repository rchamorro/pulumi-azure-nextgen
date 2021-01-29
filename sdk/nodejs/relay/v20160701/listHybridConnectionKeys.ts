// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

export function listHybridConnectionKeys(args: ListHybridConnectionKeysArgs, opts?: pulumi.InvokeOptions): Promise<ListHybridConnectionKeysResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:relay/v20160701:listHybridConnectionKeys", {
        "authorizationRuleName": args.authorizationRuleName,
        "hybridConnectionName": args.hybridConnectionName,
        "namespaceName": args.namespaceName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface ListHybridConnectionKeysArgs {
    /**
     * The authorizationRule name.
     */
    readonly authorizationRuleName: string;
    /**
     * The hybrid connection name.
     */
    readonly hybridConnectionName: string;
    /**
     * The Namespace Name
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
export interface ListHybridConnectionKeysResult {
    /**
     * A string that describes the authorization rule
     */
    readonly keyName?: string;
    /**
     * PrimaryConnectionString of the created Namespace AuthorizationRule.
     */
    readonly primaryConnectionString?: string;
    /**
     * A base64-encoded 256-bit primary key for signing and validating the SAS token
     */
    readonly primaryKey?: string;
    /**
     * SecondaryConnectionString of the created Namespace AuthorizationRule
     */
    readonly secondaryConnectionString?: string;
    /**
     * A base64-encoded 256-bit secondary key for signing and validating the SAS token
     */
    readonly secondaryKey?: string;
}

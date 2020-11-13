// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function listEventHubKeys(args: ListEventHubKeysArgs, opts?: pulumi.InvokeOptions): Promise<ListEventHubKeysResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:eventhub/v20170401:listEventHubKeys", {
        "authorizationRuleName": args.authorizationRuleName,
        "eventHubName": args.eventHubName,
        "namespaceName": args.namespaceName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface ListEventHubKeysArgs {
    /**
     * The authorization rule name.
     */
    readonly authorizationRuleName: string;
    /**
     * The Event Hub name
     */
    readonly eventHubName: string;
    /**
     * The Namespace name
     */
    readonly namespaceName: string;
    /**
     * Name of the resource group within the azure subscription.
     */
    readonly resourceGroupName: string;
}

/**
 * Namespace/EventHub Connection String
 */
export interface ListEventHubKeysResult {
    /**
     * Primary connection string of the alias if GEO DR is enabled
     */
    readonly aliasPrimaryConnectionString: string;
    /**
     * Secondary  connection string of the alias if GEO DR is enabled
     */
    readonly aliasSecondaryConnectionString: string;
    /**
     * A string that describes the AuthorizationRule.
     */
    readonly keyName: string;
    /**
     * Primary connection string of the created namespace AuthorizationRule.
     */
    readonly primaryConnectionString: string;
    /**
     * A base64-encoded 256-bit primary key for signing and validating the SAS token.
     */
    readonly primaryKey: string;
    /**
     * Secondary connection string of the created namespace AuthorizationRule.
     */
    readonly secondaryConnectionString: string;
    /**
     * A base64-encoded 256-bit primary key for signing and validating the SAS token.
     */
    readonly secondaryKey: string;
}

// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function listSubscriptionSecrets(args: ListSubscriptionSecretsArgs, opts?: pulumi.InvokeOptions): Promise<ListSubscriptionSecretsResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:apimanagement/latest:listSubscriptionSecrets", {
        "resourceGroupName": args.resourceGroupName,
        "serviceName": args.serviceName,
        "sid": args.sid,
    }, opts);
}

export interface ListSubscriptionSecretsArgs {
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the API Management service.
     */
    readonly serviceName: string;
    /**
     * Subscription entity Identifier. The entity represents the association between a user and a product in API Management.
     */
    readonly sid: string;
}

/**
 * Subscription keys.
 */
export interface ListSubscriptionSecretsResult {
    /**
     * Subscription primary key.
     */
    readonly primaryKey?: string;
    /**
     * Subscription secondary key.
     */
    readonly secondaryKey?: string;
}

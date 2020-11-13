// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function listIotDpsResourceKeysForKeyName(args: ListIotDpsResourceKeysForKeyNameArgs, opts?: pulumi.InvokeOptions): Promise<ListIotDpsResourceKeysForKeyNameResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:devices/v20200101:listIotDpsResourceKeysForKeyName", {
        "keyName": args.keyName,
        "provisioningServiceName": args.provisioningServiceName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface ListIotDpsResourceKeysForKeyNameArgs {
    /**
     * Logical key name to get key-values for.
     */
    readonly keyName: string;
    /**
     * Name of the provisioning service.
     */
    readonly provisioningServiceName: string;
    /**
     * The name of the resource group that contains the provisioning service.
     */
    readonly resourceGroupName: string;
}

/**
 * Description of the shared access key.
 */
export interface ListIotDpsResourceKeysForKeyNameResult {
    /**
     * Name of the key.
     */
    readonly keyName: string;
    /**
     * Primary SAS key value.
     */
    readonly primaryKey?: string;
    /**
     * Rights that this key has.
     */
    readonly rights: string;
    /**
     * Secondary SAS key value.
     */
    readonly secondaryKey?: string;
}

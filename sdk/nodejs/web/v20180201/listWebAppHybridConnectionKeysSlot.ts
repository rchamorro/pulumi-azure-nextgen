// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function listWebAppHybridConnectionKeysSlot(args: ListWebAppHybridConnectionKeysSlotArgs, opts?: pulumi.InvokeOptions): Promise<ListWebAppHybridConnectionKeysSlotResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:web/v20180201:listWebAppHybridConnectionKeysSlot", {
        "name": args.name,
        "namespaceName": args.namespaceName,
        "relayName": args.relayName,
        "resourceGroupName": args.resourceGroupName,
        "slot": args.slot,
    }, opts);
}

export interface ListWebAppHybridConnectionKeysSlotArgs {
    /**
     * The name of the web app.
     */
    readonly name: string;
    /**
     * The namespace for this hybrid connection.
     */
    readonly namespaceName: string;
    /**
     * The relay name for this hybrid connection.
     */
    readonly relayName: string;
    /**
     * Name of the resource group to which the resource belongs.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the slot for the web app.
     */
    readonly slot: string;
}

/**
 * Hybrid Connection key contract. This has the send key name and value for a Hybrid Connection.
 */
export interface ListWebAppHybridConnectionKeysSlotResult {
    /**
     * Kind of resource.
     */
    readonly kind?: string;
    /**
     * Resource Name.
     */
    readonly name: string;
    /**
     * The name of the send key.
     */
    readonly sendKeyName: string;
    /**
     * The value of the send key.
     */
    readonly sendKeyValue: string;
    /**
     * Resource type.
     */
    readonly type: string;
}

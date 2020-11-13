// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function listSiteConnectionStringsSlot(args: ListSiteConnectionStringsSlotArgs, opts?: pulumi.InvokeOptions): Promise<ListSiteConnectionStringsSlotResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:web/v20150801:listSiteConnectionStringsSlot", {
        "name": args.name,
        "resourceGroupName": args.resourceGroupName,
        "slot": args.slot,
    }, opts);
}

export interface ListSiteConnectionStringsSlotArgs {
    /**
     * Name of web app
     */
    readonly name: string;
    /**
     * Name of resource group
     */
    readonly resourceGroupName: string;
    /**
     * Name of web app slot. If not specified then will default to production slot.
     */
    readonly slot: string;
}

/**
 * String dictionary resource
 */
export interface ListSiteConnectionStringsSlotResult {
    /**
     * Kind of resource
     */
    readonly kind?: string;
    /**
     * Resource Location
     */
    readonly location: string;
    /**
     * Resource Name
     */
    readonly name?: string;
    /**
     * Connection strings
     */
    readonly properties: {[key: string]: outputs.web.v20150801.ConnStringValueTypePairResponse};
    /**
     * Resource tags
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type
     */
    readonly type?: string;
}

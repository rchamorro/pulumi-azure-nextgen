// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getSkus(args: GetSkusArgs, opts?: pulumi.InvokeOptions): Promise<GetSkusResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:providerhub/latest:getSkus", {
        "providerNamespace": args.providerNamespace,
        "resourceType": args.resourceType,
        "sku": args.sku,
    }, opts);
}

export interface GetSkusArgs {
    /**
     * The name of the resource provider hosted within ProviderHub.
     */
    readonly providerNamespace: string;
    /**
     * The resource type.
     */
    readonly resourceType: string;
    /**
     * The SKU.
     */
    readonly sku: string;
}

export interface GetSkusResult {
    /**
     * The name of the resource
     */
    readonly name: string;
    readonly properties: outputs.providerhub.latest.SkuResourceResponseProperties;
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    readonly type: string;
}
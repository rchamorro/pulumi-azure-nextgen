// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getSharedPrivateLinkResource(args: GetSharedPrivateLinkResourceArgs, opts?: pulumi.InvokeOptions): Promise<GetSharedPrivateLinkResourceResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:search/v20200801preview:getSharedPrivateLinkResource", {
        "resourceGroupName": args.resourceGroupName,
        "searchServiceName": args.searchServiceName,
        "sharedPrivateLinkResourceName": args.sharedPrivateLinkResourceName,
    }, opts);
}

export interface GetSharedPrivateLinkResourceArgs {
    /**
     * The name of the resource group within the current subscription. You can obtain this value from the Azure Resource Manager API or the portal.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the Azure Cognitive Search service associated with the specified resource group.
     */
    readonly searchServiceName: string;
    /**
     * The name of the shared private link resource managed by the Azure Cognitive Search service within the specified resource group.
     */
    readonly sharedPrivateLinkResourceName: string;
}

/**
 * Describes a Shared Private Link Resource managed by the Azure Cognitive Search service.
 */
export interface GetSharedPrivateLinkResourceResult {
    /**
     * The name of the resource
     */
    readonly name: string;
    /**
     * Describes the properties of a Shared Private Link Resource managed by the Azure Cognitive Search service.
     */
    readonly properties: outputs.search.v20200801preview.SharedPrivateLinkResourcePropertiesResponse;
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    readonly type: string;
}

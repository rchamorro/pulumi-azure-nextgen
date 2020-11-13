// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getEnterpriseKnowledgeGraph(args: GetEnterpriseKnowledgeGraphArgs, opts?: pulumi.InvokeOptions): Promise<GetEnterpriseKnowledgeGraphResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:enterpriseknowledgegraph/v20181203:getEnterpriseKnowledgeGraph", {
        "resourceGroupName": args.resourceGroupName,
        "resourceName": args.resourceName,
    }, opts);
}

export interface GetEnterpriseKnowledgeGraphArgs {
    /**
     * The name of the EnterpriseKnowledgeGraph resource group in the user subscription.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the EnterpriseKnowledgeGraph resource.
     */
    readonly resourceName: string;
}

/**
 * EnterpriseKnowledgeGraph resource definition
 */
export interface GetEnterpriseKnowledgeGraphResult {
    /**
     * Specifies the location of the resource.
     */
    readonly location?: string;
    /**
     * Specifies the name of the resource.
     */
    readonly name: string;
    /**
     * The set of properties specific to EnterpriseKnowledgeGraph resource
     */
    readonly properties: outputs.enterpriseknowledgegraph.v20181203.EnterpriseKnowledgeGraphPropertiesResponse;
    /**
     * Gets or sets the SKU of the resource.
     */
    readonly sku?: outputs.enterpriseknowledgegraph.v20181203.SkuResponse;
    /**
     * Contains resource tags defined as key/value pairs.
     */
    readonly tags?: {[key: string]: string};
    /**
     * Specifies the type of the resource.
     */
    readonly type: string;
}

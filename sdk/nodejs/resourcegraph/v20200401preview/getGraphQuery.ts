// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getGraphQuery(args: GetGraphQueryArgs, opts?: pulumi.InvokeOptions): Promise<GetGraphQueryResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:resourcegraph/v20200401preview:getGraphQuery", {
        "resourceGroupName": args.resourceGroupName,
        "resourceName": args.resourceName,
    }, opts);
}

export interface GetGraphQueryArgs {
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the Graph Query resource.
     */
    readonly resourceName: string;
}

/**
 * Graph Query entity definition.
 */
export interface GetGraphQueryResult {
    /**
     * The description of a graph query.
     */
    readonly description?: string;
    /**
     * This will be used to handle Optimistic Concurrency.
     */
    readonly eTag?: string;
    /**
     * The location of the resource
     */
    readonly location: string;
    /**
     * Azure resource name. This is GUID value. The display name should be assigned within properties field.
     */
    readonly name: string;
    /**
     * KQL query that will be graph.
     */
    readonly query: string;
    /**
     * Enum indicating a type of graph query.
     */
    readonly resultKind: string;
    /**
     * Metadata pertaining to creation and last modification of the resource.
     */
    readonly systemData: outputs.resourcegraph.v20200401preview.SystemDataResponse;
    /**
     * Resource tags
     */
    readonly tags?: {[key: string]: string};
    /**
     * Date and time in UTC of the last modification that was made to this graph query definition.
     */
    readonly timeModified: string;
    /**
     * Azure resource type
     */
    readonly type: string;
}

// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getIntegrationRuntime(args: GetIntegrationRuntimeArgs, opts?: pulumi.InvokeOptions): Promise<GetIntegrationRuntimeResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:datafactory/v20170901preview:getIntegrationRuntime", {
        "factoryName": args.factoryName,
        "integrationRuntimeName": args.integrationRuntimeName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetIntegrationRuntimeArgs {
    /**
     * The factory name.
     */
    readonly factoryName: string;
    /**
     * The integration runtime name.
     */
    readonly integrationRuntimeName: string;
    /**
     * The resource group name.
     */
    readonly resourceGroupName: string;
}

/**
 * Integration runtime resource type.
 */
export interface GetIntegrationRuntimeResult {
    /**
     * Etag identifies change in the resource.
     */
    readonly etag: string;
    /**
     * The resource name.
     */
    readonly name: string;
    /**
     * Integration runtime properties.
     */
    readonly properties: outputs.datafactory.v20170901preview.ManagedIntegrationRuntimeResponse | outputs.datafactory.v20170901preview.SelfHostedIntegrationRuntimeResponse;
    /**
     * The resource type.
     */
    readonly type: string;
}

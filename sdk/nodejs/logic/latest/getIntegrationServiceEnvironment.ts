// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getIntegrationServiceEnvironment(args: GetIntegrationServiceEnvironmentArgs, opts?: pulumi.InvokeOptions): Promise<GetIntegrationServiceEnvironmentResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:logic/latest:getIntegrationServiceEnvironment", {
        "integrationServiceEnvironmentName": args.integrationServiceEnvironmentName,
        "resourceGroup": args.resourceGroup,
    }, opts);
}

export interface GetIntegrationServiceEnvironmentArgs {
    /**
     * The integration service environment name.
     */
    readonly integrationServiceEnvironmentName: string;
    /**
     * The resource group.
     */
    readonly resourceGroup: string;
}

/**
 * The integration service environment.
 */
export interface GetIntegrationServiceEnvironmentResult {
    /**
     * The resource location.
     */
    readonly location?: string;
    /**
     * Gets the resource name.
     */
    readonly name: string;
    /**
     * The integration service environment properties.
     */
    readonly properties: outputs.logic.latest.IntegrationServiceEnvironmentPropertiesResponse;
    /**
     * The sku.
     */
    readonly sku?: outputs.logic.latest.IntegrationServiceEnvironmentSkuResponse;
    /**
     * The resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * Gets the resource type.
     */
    readonly type: string;
}

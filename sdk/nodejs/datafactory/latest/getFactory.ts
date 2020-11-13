// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getFactory(args: GetFactoryArgs, opts?: pulumi.InvokeOptions): Promise<GetFactoryResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:datafactory/latest:getFactory", {
        "factoryName": args.factoryName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetFactoryArgs {
    /**
     * The factory name.
     */
    readonly factoryName: string;
    /**
     * The resource group name.
     */
    readonly resourceGroupName: string;
}

/**
 * Factory resource type.
 */
export interface GetFactoryResult {
    /**
     * Time the factory was created in ISO8601 format.
     */
    readonly createTime: string;
    /**
     * Etag identifies change in the resource.
     */
    readonly eTag: string;
    /**
     * List of parameters for factory.
     */
    readonly globalParameters?: {[key: string]: outputs.datafactory.latest.GlobalParameterSpecificationResponse};
    /**
     * Managed service identity of the factory.
     */
    readonly identity?: outputs.datafactory.latest.FactoryIdentityResponse;
    /**
     * The resource location.
     */
    readonly location?: string;
    /**
     * The resource name.
     */
    readonly name: string;
    /**
     * Factory provisioning state, example Succeeded.
     */
    readonly provisioningState: string;
    /**
     * Whether or not public network access is allowed for the data factory.
     */
    readonly publicNetworkAccess?: string;
    /**
     * Git repo information of the factory.
     */
    readonly repoConfiguration?: outputs.datafactory.latest.FactoryGitHubConfigurationResponse | outputs.datafactory.latest.FactoryVSTSConfigurationResponse;
    /**
     * The resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * The resource type.
     */
    readonly type: string;
    /**
     * Version of the factory.
     */
    readonly version: string;
}

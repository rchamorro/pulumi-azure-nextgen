// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

export function listConfigurationStoreKeys(args: ListConfigurationStoreKeysArgs, opts?: pulumi.InvokeOptions): Promise<ListConfigurationStoreKeysResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:appconfiguration/v20191001:listConfigurationStoreKeys", {
        "configStoreName": args.configStoreName,
        "resourceGroupName": args.resourceGroupName,
        "skipToken": args.skipToken,
    }, opts);
}

export interface ListConfigurationStoreKeysArgs {
    /**
     * The name of the configuration store.
     */
    readonly configStoreName: string;
    /**
     * The name of the resource group to which the container registry belongs.
     */
    readonly resourceGroupName: string;
    /**
     * A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls.
     */
    readonly skipToken?: string;
}

/**
 * The result of a request to list API keys.
 */
export interface ListConfigurationStoreKeysResult {
    /**
     * The URI that can be used to request the next set of paged results.
     */
    readonly nextLink?: string;
    /**
     * The collection value.
     */
    readonly value?: outputs.appconfiguration.v20191001.ApiKeyResponse[];
}

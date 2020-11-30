// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getWebAppSlotConfigurationNames(args: GetWebAppSlotConfigurationNamesArgs, opts?: pulumi.InvokeOptions): Promise<GetWebAppSlotConfigurationNamesResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:web/latest:getWebAppSlotConfigurationNames", {
        "name": args.name,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetWebAppSlotConfigurationNamesArgs {
    /**
     * Name of the app.
     */
    readonly name: string;
    /**
     * Name of the resource group to which the resource belongs.
     */
    readonly resourceGroupName: string;
}

/**
 * Slot Config names azure resource.
 */
export interface GetWebAppSlotConfigurationNamesResult {
    /**
     * List of application settings names.
     */
    readonly appSettingNames?: string[];
    /**
     * List of external Azure storage account identifiers.
     */
    readonly azureStorageConfigNames?: string[];
    /**
     * List of connection string names.
     */
    readonly connectionStringNames?: string[];
    /**
     * Kind of resource.
     */
    readonly kind?: string;
    /**
     * Resource Name.
     */
    readonly name: string;
    /**
     * Resource type.
     */
    readonly type: string;
}
// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

export function getDataController(args: GetDataControllerArgs, opts?: pulumi.InvokeOptions): Promise<GetDataControllerResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:azuredata/v20200908preview:getDataController", {
        "dataControllerName": args.dataControllerName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetDataControllerArgs {
    readonly dataControllerName: string;
    /**
     * The name of the Azure resource group
     */
    readonly resourceGroupName: string;
}

/**
 * Data controller resource
 */
export interface GetDataControllerResult {
    /**
     * Fully qualified resource Id for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
     */
    readonly id: string;
    /**
     * The raw kubernetes information
     */
    readonly k8sRaw?: any;
    /**
     * Last uploaded date from on premise cluster. Defaults to current date time
     */
    readonly lastUploadedDate?: string;
    /**
     * The geo-location where the resource lives
     */
    readonly location: string;
    /**
     * The name of the resource
     */
    readonly name: string;
    /**
     * Properties from the on premise data controller
     */
    readonly onPremiseProperty: outputs.azuredata.v20200908preview.OnPremisePropertyResponse;
    /**
     * Read only system data
     */
    readonly systemData: outputs.azuredata.v20200908preview.SystemDataResponse;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts.
     */
    readonly type: string;
}

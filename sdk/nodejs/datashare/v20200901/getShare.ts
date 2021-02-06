// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

export function getShare(args: GetShareArgs, opts?: pulumi.InvokeOptions): Promise<GetShareResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:datashare/v20200901:getShare", {
        "accountName": args.accountName,
        "resourceGroupName": args.resourceGroupName,
        "shareName": args.shareName,
    }, opts);
}

export interface GetShareArgs {
    /**
     * The name of the share account.
     */
    readonly accountName: string;
    /**
     * The resource group name.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the share to retrieve.
     */
    readonly shareName: string;
}

/**
 * A share data transfer object.
 */
export interface GetShareResult {
    /**
     * Time at which the share was created.
     */
    readonly createdAt: string;
    /**
     * Share description.
     */
    readonly description?: string;
    /**
     * The resource id of the azure resource
     */
    readonly id: string;
    /**
     * Name of the azure resource
     */
    readonly name: string;
    /**
     * Gets or sets the provisioning state
     */
    readonly provisioningState: string;
    /**
     * Share kind.
     */
    readonly shareKind?: string;
    /**
     * System Data of the Azure resource.
     */
    readonly systemData: outputs.datashare.v20200901.ProxyDtoResponseSystemData;
    /**
     * Share terms.
     */
    readonly terms?: string;
    /**
     * Type of the azure resource
     */
    readonly type: string;
    /**
     * Email of the user who created the resource
     */
    readonly userEmail: string;
    /**
     * Name of the user who created the resource
     */
    readonly userName: string;
}

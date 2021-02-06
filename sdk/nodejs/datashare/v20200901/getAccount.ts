// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

export function getAccount(args: GetAccountArgs, opts?: pulumi.InvokeOptions): Promise<GetAccountResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:datashare/v20200901:getAccount", {
        "accountName": args.accountName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetAccountArgs {
    /**
     * The name of the share account.
     */
    readonly accountName: string;
    /**
     * The resource group name.
     */
    readonly resourceGroupName: string;
}

/**
 * An account data transfer object.
 */
export interface GetAccountResult {
    /**
     * Time at which the account was created.
     */
    readonly createdAt: string;
    /**
     * The resource id of the azure resource
     */
    readonly id: string;
    /**
     * Identity Info on the Account
     */
    readonly identity: outputs.datashare.v20200901.IdentityResponse;
    /**
     * Location of the azure resource.
     */
    readonly location?: string;
    /**
     * Name of the azure resource
     */
    readonly name: string;
    /**
     * Provisioning state of the Account
     */
    readonly provisioningState: string;
    /**
     * System Data of the Azure resource.
     */
    readonly systemData: outputs.datashare.v20200901.DefaultDtoResponseSystemData;
    /**
     * Tags on the azure resource.
     */
    readonly tags?: {[key: string]: string};
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

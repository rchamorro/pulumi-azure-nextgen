// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getTransparentDataEncryption(args: GetTransparentDataEncryptionArgs, opts?: pulumi.InvokeOptions): Promise<GetTransparentDataEncryptionResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:sql/v20140401:getTransparentDataEncryption", {
        "databaseName": args.databaseName,
        "resourceGroupName": args.resourceGroupName,
        "serverName": args.serverName,
        "transparentDataEncryptionName": args.transparentDataEncryptionName,
    }, opts);
}

export interface GetTransparentDataEncryptionArgs {
    /**
     * The name of the database for which the transparent data encryption applies.
     */
    readonly databaseName: string;
    /**
     * The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the server.
     */
    readonly serverName: string;
    /**
     * The name of the transparent data encryption configuration.
     */
    readonly transparentDataEncryptionName: string;
}

/**
 * Represents a database transparent data encryption configuration.
 */
export interface GetTransparentDataEncryptionResult {
    /**
     * Resource location.
     */
    readonly location: string;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * The status of the database transparent data encryption.
     */
    readonly status?: string;
    /**
     * Resource type.
     */
    readonly type: string;
}
// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getAccount(args: GetAccountArgs, opts?: pulumi.InvokeOptions): Promise<GetAccountResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:maps/latest:getAccount", {
        "accountName": args.accountName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetAccountArgs {
    /**
     * The name of the Maps Account.
     */
    readonly accountName: string;
    /**
     * The name of the Azure Resource Group.
     */
    readonly resourceGroupName: string;
}

/**
 * An Azure resource which represents access to a suite of Maps REST APIs.
 */
export interface GetAccountResult {
    /**
     * The location of the resource.
     */
    readonly location: string;
    /**
     * The name of the Maps Account, which is unique within a Resource Group.
     */
    readonly name: string;
    /**
     * The map account properties.
     */
    readonly properties: outputs.maps.latest.MapsAccountPropertiesResponse;
    /**
     * The SKU of this account.
     */
    readonly sku: outputs.maps.latest.SkuResponse;
    /**
     * Gets a list of key value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no greater than 128 characters and value no greater than 256 characters.
     */
    readonly tags: {[key: string]: string};
    /**
     * Azure resource type.
     */
    readonly type: string;
}

// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getBastionShareableLink(args: GetBastionShareableLinkArgs, opts?: pulumi.InvokeOptions): Promise<GetBastionShareableLinkResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:network/v20191201:getBastionShareableLink", {
        "bastionHostName": args.bastionHostName,
        "resourceGroupName": args.resourceGroupName,
        "vms": args.vms,
    }, opts);
}

export interface GetBastionShareableLinkArgs {
    /**
     * The name of the Bastion Host.
     */
    readonly bastionHostName: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
    /**
     * List of VM references.
     */
    readonly vms?: inputs.network.v20191201.BastionShareableLink[];
}

/**
 * Response for all the Bastion Shareable Link endpoints.
 */
export interface GetBastionShareableLinkResult {
    /**
     * The URL to get the next set of results.
     */
    readonly nextLink?: string;
    /**
     * List of Bastion Shareable Links for the request.
     */
    readonly value?: outputs.network.v20191201.BastionShareableLinkResponse[];
}

// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getBastionHost(args: GetBastionHostArgs, opts?: pulumi.InvokeOptions): Promise<GetBastionHostResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:network/v20200701:getBastionHost", {
        "bastionHostName": args.bastionHostName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetBastionHostArgs {
    /**
     * The name of the Bastion Host.
     */
    readonly bastionHostName: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
}

/**
 * Bastion Host resource.
 */
export interface GetBastionHostResult {
    /**
     * FQDN for the endpoint on which bastion host is accessible.
     */
    readonly dnsName?: string;
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    readonly etag: string;
    /**
     * IP configuration of the Bastion Host resource.
     */
    readonly ipConfigurations?: outputs.network.v20200701.BastionHostIPConfigurationResponse[];
    /**
     * Resource location.
     */
    readonly location?: string;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * The provisioning state of the bastion host resource.
     */
    readonly provisioningState: string;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type.
     */
    readonly type: string;
}

// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getDelegatedSubnetServiceDetails(args: GetDelegatedSubnetServiceDetailsArgs, opts?: pulumi.InvokeOptions): Promise<GetDelegatedSubnetServiceDetailsResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:delegatednetwork/v20200808preview:getDelegatedSubnetServiceDetails", {
        "resourceGroupName": args.resourceGroupName,
        "resourceName": args.resourceName,
    }, opts);
}

export interface GetDelegatedSubnetServiceDetailsArgs {
    /**
     * The name of the Azure Resource group of which a given DelegatedNetwork resource is part. This name must be at least 1 character in length, and no more than 90.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the resource. It must be a minimum of 3 characters, and a maximum of 63.
     */
    readonly resourceName: string;
}

/**
 * Represents an instance of a orchestrator.
 */
export interface GetDelegatedSubnetServiceDetailsResult {
    /**
     * controller details
     */
    readonly controllerDetails?: outputs.delegatednetwork.v20200808preview.ControllerDetailsResponse;
    /**
     * Location of the resource.
     */
    readonly location?: string;
    /**
     * The name of the resource.
     */
    readonly name: string;
    /**
     * The current state of dnc delegated subnet resource.
     */
    readonly provisioningState: string;
    /**
     * Resource guid.
     */
    readonly resourceGuid: string;
    /**
     * orchestrator details
     */
    readonly subnetDetails?: outputs.delegatednetwork.v20200808preview.SubnetDetailsResponse;
    /**
     * The resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * The type of resource.
     */
    readonly type: string;
}

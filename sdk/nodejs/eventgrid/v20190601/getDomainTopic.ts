// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getDomainTopic(args: GetDomainTopicArgs, opts?: pulumi.InvokeOptions): Promise<GetDomainTopicResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:eventgrid/v20190601:getDomainTopic", {
        "domainName": args.domainName,
        "domainTopicName": args.domainTopicName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetDomainTopicArgs {
    /**
     * Name of the domain.
     */
    readonly domainName: string;
    /**
     * Name of the topic.
     */
    readonly domainTopicName: string;
    /**
     * The name of the resource group within the user's subscription.
     */
    readonly resourceGroupName: string;
}

/**
 * Domain Topic.
 */
export interface GetDomainTopicResult {
    /**
     * Name of the resource.
     */
    readonly name: string;
    /**
     * Provisioning state of the domain topic.
     */
    readonly provisioningState?: string;
    /**
     * Type of the resource.
     */
    readonly type: string;
}

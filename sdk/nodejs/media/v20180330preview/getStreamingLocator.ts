// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getStreamingLocator(args: GetStreamingLocatorArgs, opts?: pulumi.InvokeOptions): Promise<GetStreamingLocatorResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:media/v20180330preview:getStreamingLocator", {
        "accountName": args.accountName,
        "resourceGroupName": args.resourceGroupName,
        "streamingLocatorName": args.streamingLocatorName,
    }, opts);
}

export interface GetStreamingLocatorArgs {
    /**
     * The Media Services account name.
     */
    readonly accountName: string;
    /**
     * The name of the resource group within the Azure subscription.
     */
    readonly resourceGroupName: string;
    /**
     * The Streaming Locator name.
     */
    readonly streamingLocatorName: string;
}

/**
 * A Streaming Locator resource
 */
export interface GetStreamingLocatorResult {
    /**
     * Asset Name
     */
    readonly assetName: string;
    /**
     * ContentKeys used by this Streaming Locator
     */
    readonly contentKeys?: outputs.media.v20180330preview.StreamingLocatorUserDefinedContentKeyResponse[];
    /**
     * Creation time of Streaming Locator
     */
    readonly created: string;
    /**
     * Default ContentKeyPolicy used by this Streaming Locator
     */
    readonly defaultContentKeyPolicyName?: string;
    /**
     * EndTime of Streaming Locator
     */
    readonly endTime?: string;
    /**
     * The name of the resource.
     */
    readonly name: string;
    /**
     * StartTime of Streaming Locator
     */
    readonly startTime?: string;
    /**
     * StreamingLocatorId of Streaming Locator
     */
    readonly streamingLocatorId?: string;
    /**
     * Streaming policy name used by this streaming locator. Either specify the name of streaming policy you created or use one of the predefined streaming polices. The predefined streaming policies available are: 'Predefined_DownloadOnly', 'Predefined_ClearStreamingOnly', 'Predefined_DownloadAndClearStreaming', 'Predefined_ClearKey', 'Predefined_SecureStreaming' and 'Predefined_SecureStreamingWithFairPlay'
     */
    readonly streamingPolicyName: string;
    /**
     * The type of the resource.
     */
    readonly type: string;
}

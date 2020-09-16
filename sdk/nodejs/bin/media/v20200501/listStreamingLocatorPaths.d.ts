import * as pulumi from "@pulumi/pulumi";
import * as outputs from "../../types/output";
export declare function listStreamingLocatorPaths(args: ListStreamingLocatorPathsArgs, opts?: pulumi.InvokeOptions): Promise<ListStreamingLocatorPathsResult>;
export interface ListStreamingLocatorPathsArgs {
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
 * Class of response for listPaths action
 */
export interface ListStreamingLocatorPathsResult {
    /**
     * Download Paths supported by current Streaming Locator
     */
    readonly downloadPaths?: string[];
    /**
     * Streaming Paths supported by current Streaming Locator
     */
    readonly streamingPaths?: outputs.media.v20200501.StreamingPathResponse[];
}
import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
/**
 * A Streaming Locator resource
 */
export declare class StreamingLocator extends pulumi.CustomResource {
    /**
     * Get an existing StreamingLocator resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): StreamingLocator;
    /**
     * Returns true if the given object is an instance of StreamingLocator.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    static isInstance(obj: any): obj is StreamingLocator;
    /**
     * Alternative Media ID of this Streaming Locator
     */
    readonly alternativeMediaId: pulumi.Output<string | undefined>;
    /**
     * Asset Name
     */
    readonly assetName: pulumi.Output<string>;
    /**
     * The ContentKeys used by this Streaming Locator.
     */
    readonly contentKeys: pulumi.Output<outputs.media.v20180701.StreamingLocatorContentKeyResponse[] | undefined>;
    /**
     * The creation time of the Streaming Locator.
     */
    readonly created: pulumi.Output<string>;
    /**
     * Name of the default ContentKeyPolicy used by this Streaming Locator.
     */
    readonly defaultContentKeyPolicyName: pulumi.Output<string | undefined>;
    /**
     * The end time of the Streaming Locator.
     */
    readonly endTime: pulumi.Output<string | undefined>;
    /**
     * A list of asset or account filters which apply to this streaming locator
     */
    readonly filters: pulumi.Output<string[] | undefined>;
    /**
     * The name of the resource.
     */
    readonly name: pulumi.Output<string>;
    /**
     * The start time of the Streaming Locator.
     */
    readonly startTime: pulumi.Output<string | undefined>;
    /**
     * The StreamingLocatorId of the Streaming Locator.
     */
    readonly streamingLocatorId: pulumi.Output<string | undefined>;
    /**
     * Name of the Streaming Policy used by this Streaming Locator. Either specify the name of Streaming Policy you created or use one of the predefined Streaming Policies. The predefined Streaming Policies available are: 'Predefined_DownloadOnly', 'Predefined_ClearStreamingOnly', 'Predefined_DownloadAndClearStreaming', 'Predefined_ClearKey', 'Predefined_MultiDrmCencStreaming' and 'Predefined_MultiDrmStreaming'
     */
    readonly streamingPolicyName: pulumi.Output<string>;
    /**
     * The type of the resource.
     */
    readonly type: pulumi.Output<string>;
    /**
     * Create a StreamingLocator resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: StreamingLocatorArgs, opts?: pulumi.CustomResourceOptions);
    constructor(name: string, state: undefined, opts: pulumi.CustomResourceOptions);
}
/**
 * The set of arguments for constructing a StreamingLocator resource.
 */
export interface StreamingLocatorArgs {
    /**
     * The Media Services account name.
     */
    readonly accountName: pulumi.Input<string>;
    /**
     * Alternative Media ID of this Streaming Locator
     */
    readonly alternativeMediaId?: pulumi.Input<string>;
    /**
     * Asset Name
     */
    readonly assetName: pulumi.Input<string>;
    /**
     * The ContentKeys used by this Streaming Locator.
     */
    readonly contentKeys?: pulumi.Input<pulumi.Input<inputs.media.v20180701.StreamingLocatorContentKey>[]>;
    /**
     * Name of the default ContentKeyPolicy used by this Streaming Locator.
     */
    readonly defaultContentKeyPolicyName?: pulumi.Input<string>;
    /**
     * The end time of the Streaming Locator.
     */
    readonly endTime?: pulumi.Input<string>;
    /**
     * A list of asset or account filters which apply to this streaming locator
     */
    readonly filters?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The name of the resource group within the Azure subscription.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The start time of the Streaming Locator.
     */
    readonly startTime?: pulumi.Input<string>;
    /**
     * The StreamingLocatorId of the Streaming Locator.
     */
    readonly streamingLocatorId?: pulumi.Input<string>;
    /**
     * The Streaming Locator name.
     */
    readonly streamingLocatorName: pulumi.Input<string>;
    /**
     * Name of the Streaming Policy used by this Streaming Locator. Either specify the name of Streaming Policy you created or use one of the predefined Streaming Policies. The predefined Streaming Policies available are: 'Predefined_DownloadOnly', 'Predefined_ClearStreamingOnly', 'Predefined_DownloadAndClearStreaming', 'Predefined_ClearKey', 'Predefined_MultiDrmCencStreaming' and 'Predefined_MultiDrmStreaming'
     */
    readonly streamingPolicyName: pulumi.Input<string>;
}
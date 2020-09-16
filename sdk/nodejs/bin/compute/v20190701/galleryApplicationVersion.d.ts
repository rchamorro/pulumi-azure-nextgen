import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
/**
 * Specifies information about the gallery Application Version that you want to create or update.
 */
export declare class GalleryApplicationVersion extends pulumi.CustomResource {
    /**
     * Get an existing GalleryApplicationVersion resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): GalleryApplicationVersion;
    /**
     * Returns true if the given object is an instance of GalleryApplicationVersion.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    static isInstance(obj: any): obj is GalleryApplicationVersion;
    /**
     * Resource location
     */
    readonly location: pulumi.Output<string>;
    /**
     * Resource name
     */
    readonly name: pulumi.Output<string>;
    /**
     * The provisioning state, which only appears in the response.
     */
    readonly provisioningState: pulumi.Output<string>;
    /**
     * The publishing profile of a gallery Image Version.
     */
    readonly publishingProfile: pulumi.Output<outputs.compute.v20190701.GalleryApplicationVersionPublishingProfileResponse>;
    /**
     * This is the replication status of the gallery Image Version.
     */
    readonly replicationStatus: pulumi.Output<outputs.compute.v20190701.ReplicationStatusResponse>;
    /**
     * Resource tags
     */
    readonly tags: pulumi.Output<{
        [key: string]: string;
    } | undefined>;
    /**
     * Resource type
     */
    readonly type: pulumi.Output<string>;
    /**
     * Create a GalleryApplicationVersion resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: GalleryApplicationVersionArgs, opts?: pulumi.CustomResourceOptions);
    constructor(name: string, state: undefined, opts: pulumi.CustomResourceOptions);
}
/**
 * The set of arguments for constructing a GalleryApplicationVersion resource.
 */
export interface GalleryApplicationVersionArgs {
    /**
     * The name of the gallery Application Definition in which the Application Version is to be created.
     */
    readonly galleryApplicationName: pulumi.Input<string>;
    /**
     * The name of the gallery Application Version to be created. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: <MajorVersion>.<MinorVersion>.<Patch>
     */
    readonly galleryApplicationVersionName: pulumi.Input<string>;
    /**
     * The name of the Shared Application Gallery in which the Application Definition resides.
     */
    readonly galleryName: pulumi.Input<string>;
    /**
     * Resource location
     */
    readonly location: pulumi.Input<string>;
    /**
     * The publishing profile of a gallery Image Version.
     */
    readonly publishingProfile: pulumi.Input<inputs.compute.v20190701.GalleryApplicationVersionPublishingProfile>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Resource tags
     */
    readonly tags?: pulumi.Input<{
        [key: string]: pulumi.Input<string>;
    }>;
}
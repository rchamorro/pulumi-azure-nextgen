// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * Represents an image from the Azure Marketplace
 */
export class GalleryImage extends pulumi.CustomResource {
    /**
     * Get an existing GalleryImage resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): GalleryImage {
        return new GalleryImage(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:labservices/v20181015:GalleryImage';

    /**
     * Returns true if the given object is an instance of GalleryImage.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is GalleryImage {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === GalleryImage.__pulumiType;
    }

    /**
     * The author of the gallery image.
     */
    public /*out*/ readonly author!: pulumi.Output<string>;
    /**
     * The creation date of the gallery image.
     */
    public /*out*/ readonly createdDate!: pulumi.Output<string>;
    /**
     * The description of the gallery image.
     */
    public /*out*/ readonly description!: pulumi.Output<string>;
    /**
     * The icon of the gallery image.
     */
    public /*out*/ readonly icon!: pulumi.Output<string>;
    /**
     * The image reference of the gallery image.
     */
    public /*out*/ readonly imageReference!: pulumi.Output<outputs.labservices.v20181015.GalleryImageReferenceResponse>;
    /**
     * Indicates whether this gallery image is enabled.
     */
    public readonly isEnabled!: pulumi.Output<boolean | undefined>;
    /**
     * Indicates whether this gallery has been overridden for this lab account
     */
    public readonly isOverride!: pulumi.Output<boolean | undefined>;
    /**
     * Indicates if the plan has been authorized for programmatic deployment.
     */
    public readonly isPlanAuthorized!: pulumi.Output<boolean | undefined>;
    /**
     * The details of the latest operation. ex: status, error
     */
    public /*out*/ readonly latestOperationResult!: pulumi.Output<outputs.labservices.v20181015.LatestOperationResultResponse>;
    /**
     * The location of the resource.
     */
    public readonly location!: pulumi.Output<string | undefined>;
    /**
     * The name of the resource.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The third party plan that applies to this image
     */
    public /*out*/ readonly planId!: pulumi.Output<string>;
    /**
     * The provisioning status of the resource.
     */
    public readonly provisioningState!: pulumi.Output<string | undefined>;
    /**
     * The tags of the resource.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * The type of the resource.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * The unique immutable identifier of a resource (Guid).
     */
    public readonly uniqueIdentifier!: pulumi.Output<string | undefined>;

    /**
     * Create a GalleryImage resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: GalleryImageArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.galleryImageName === undefined) {
                throw new Error("Missing required property 'galleryImageName'");
            }
            if (!args || args.labAccountName === undefined) {
                throw new Error("Missing required property 'labAccountName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["galleryImageName"] = args ? args.galleryImageName : undefined;
            inputs["isEnabled"] = args ? args.isEnabled : undefined;
            inputs["isOverride"] = args ? args.isOverride : undefined;
            inputs["isPlanAuthorized"] = args ? args.isPlanAuthorized : undefined;
            inputs["labAccountName"] = args ? args.labAccountName : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["provisioningState"] = args ? args.provisioningState : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["uniqueIdentifier"] = args ? args.uniqueIdentifier : undefined;
            inputs["author"] = undefined /*out*/;
            inputs["createdDate"] = undefined /*out*/;
            inputs["description"] = undefined /*out*/;
            inputs["icon"] = undefined /*out*/;
            inputs["imageReference"] = undefined /*out*/;
            inputs["latestOperationResult"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["planId"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["author"] = undefined /*out*/;
            inputs["createdDate"] = undefined /*out*/;
            inputs["description"] = undefined /*out*/;
            inputs["icon"] = undefined /*out*/;
            inputs["imageReference"] = undefined /*out*/;
            inputs["isEnabled"] = undefined /*out*/;
            inputs["isOverride"] = undefined /*out*/;
            inputs["isPlanAuthorized"] = undefined /*out*/;
            inputs["latestOperationResult"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["planId"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["uniqueIdentifier"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:labservices/latest:GalleryImage" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(GalleryImage.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a GalleryImage resource.
 */
export interface GalleryImageArgs {
    /**
     * The name of the gallery Image.
     */
    readonly galleryImageName: pulumi.Input<string>;
    /**
     * Indicates whether this gallery image is enabled.
     */
    readonly isEnabled?: pulumi.Input<boolean>;
    /**
     * Indicates whether this gallery has been overridden for this lab account
     */
    readonly isOverride?: pulumi.Input<boolean>;
    /**
     * Indicates if the plan has been authorized for programmatic deployment.
     */
    readonly isPlanAuthorized?: pulumi.Input<boolean>;
    /**
     * The name of the lab Account.
     */
    readonly labAccountName: pulumi.Input<string>;
    /**
     * The location of the resource.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * The provisioning status of the resource.
     */
    readonly provisioningState?: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The tags of the resource.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The unique immutable identifier of a resource (Guid).
     */
    readonly uniqueIdentifier?: pulumi.Input<string>;
}

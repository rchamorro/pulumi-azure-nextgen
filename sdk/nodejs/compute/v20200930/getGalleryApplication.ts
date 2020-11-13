// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getGalleryApplication(args: GetGalleryApplicationArgs, opts?: pulumi.InvokeOptions): Promise<GetGalleryApplicationResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:compute/v20200930:getGalleryApplication", {
        "galleryApplicationName": args.galleryApplicationName,
        "galleryName": args.galleryName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetGalleryApplicationArgs {
    /**
     * The name of the gallery Application Definition to be retrieved.
     */
    readonly galleryApplicationName: string;
    /**
     * The name of the Shared Application Gallery from which the Application Definitions are to be retrieved.
     */
    readonly galleryName: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
}

/**
 * Specifies information about the gallery Application Definition that you want to create or update.
 */
export interface GetGalleryApplicationResult {
    /**
     * The description of this gallery Application Definition resource. This property is updatable.
     */
    readonly description?: string;
    /**
     * The end of life date of the gallery Application Definition. This property can be used for decommissioning purposes. This property is updatable.
     */
    readonly endOfLifeDate?: string;
    /**
     * The Eula agreement for the gallery Application Definition.
     */
    readonly eula?: string;
    /**
     * Resource location
     */
    readonly location: string;
    /**
     * Resource name
     */
    readonly name: string;
    /**
     * The privacy statement uri.
     */
    readonly privacyStatementUri?: string;
    /**
     * The release note uri.
     */
    readonly releaseNoteUri?: string;
    /**
     * This property allows you to specify the supported type of the OS that application is built for. <br><br> Possible values are: <br><br> **Windows** <br><br> **Linux**
     */
    readonly supportedOSType: string;
    /**
     * Resource tags
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type
     */
    readonly type: string;
}

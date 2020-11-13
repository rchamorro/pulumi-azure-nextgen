// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getMSIXPackage(args: GetMSIXPackageArgs, opts?: pulumi.InvokeOptions): Promise<GetMSIXPackageResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:desktopvirtualization/v20201019preview:getMSIXPackage", {
        "hostPoolName": args.hostPoolName,
        "msixPackageFullName": args.msixPackageFullName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetMSIXPackageArgs {
    /**
     * The name of the host pool within the specified resource group
     */
    readonly hostPoolName: string;
    /**
     * The version specific package full name of the MSIX package within specified hostpool
     */
    readonly msixPackageFullName: string;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    readonly resourceGroupName: string;
}

/**
 * Schema for MSIX Package properties.
 */
export interface GetMSIXPackageResult {
    /**
     * User friendly Name to be displayed in the portal. 
     */
    readonly displayName?: string;
    /**
     * VHD/CIM image path on Network Share.
     */
    readonly imagePath?: string;
    /**
     * Make this version of the package the active one across the hostpool. 
     */
    readonly isActive?: boolean;
    /**
     * Specifies how to register Package in feed.
     */
    readonly isRegularRegistration?: boolean;
    /**
     * Date Package was last updated, found in the appxmanifest.xml. 
     */
    readonly lastUpdated?: string;
    /**
     * The name of the resource
     */
    readonly name: string;
    /**
     * List of package applications. 
     */
    readonly packageApplications?: outputs.desktopvirtualization.v20201019preview.MsixPackageApplicationsResponse[];
    /**
     * List of package dependencies. 
     */
    readonly packageDependencies?: outputs.desktopvirtualization.v20201019preview.MsixPackageDependenciesResponse[];
    /**
     * Package Family Name from appxmanifest.xml. Contains Package Name and Publisher name. 
     */
    readonly packageFamilyName?: string;
    /**
     * Package Name from appxmanifest.xml. 
     */
    readonly packageName?: string;
    /**
     * Relative Path to the package inside the image. 
     */
    readonly packageRelativePath?: string;
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    readonly type: string;
    /**
     * Package Version found in the appxmanifest.xml. 
     */
    readonly version?: string;
}

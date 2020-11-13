// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getSiteSourceControl(args: GetSiteSourceControlArgs, opts?: pulumi.InvokeOptions): Promise<GetSiteSourceControlResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:web/v20150801:getSiteSourceControl", {
        "name": args.name,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetSiteSourceControlArgs {
    /**
     * Name of web app
     */
    readonly name: string;
    /**
     * Name of resource group
     */
    readonly resourceGroupName: string;
}

/**
 * Describes the source control configuration for web app
 */
export interface GetSiteSourceControlResult {
    /**
     * Name of branch to use for deployment
     */
    readonly branch?: string;
    /**
     * Whether to manual or continuous integration
     */
    readonly deploymentRollbackEnabled?: boolean;
    /**
     * Whether to manual or continuous integration
     */
    readonly isManualIntegration?: boolean;
    /**
     * Mercurial or Git repository type
     */
    readonly isMercurial?: boolean;
    /**
     * Kind of resource
     */
    readonly kind?: string;
    /**
     * Resource Location
     */
    readonly location: string;
    /**
     * Resource Name
     */
    readonly name?: string;
    /**
     * Repository or source control url
     */
    readonly repoUrl?: string;
    /**
     * Resource tags
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type
     */
    readonly type?: string;
}

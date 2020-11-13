// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function listStaticSiteUsers(args: ListStaticSiteUsersArgs, opts?: pulumi.InvokeOptions): Promise<ListStaticSiteUsersResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:web/latest:listStaticSiteUsers", {
        "authprovider": args.authprovider,
        "name": args.name,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface ListStaticSiteUsersArgs {
    /**
     * The auth provider for the users.
     */
    readonly authprovider: string;
    /**
     * Name of the static site.
     */
    readonly name: string;
    /**
     * Name of the resource group to which the resource belongs.
     */
    readonly resourceGroupName: string;
}

/**
 * Collection of static site custom users.
 */
export interface ListStaticSiteUsersResult {
    /**
     * Link to next page of resources.
     */
    readonly nextLink: string;
    /**
     * Collection of resources.
     */
    readonly value: outputs.web.latest.StaticSiteUserARMResourceResponse[];
}

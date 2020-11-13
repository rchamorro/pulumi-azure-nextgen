// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getSiteHostNameBinding(args: GetSiteHostNameBindingArgs, opts?: pulumi.InvokeOptions): Promise<GetSiteHostNameBindingResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:web/v20150801:getSiteHostNameBinding", {
        "hostName": args.hostName,
        "name": args.name,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetSiteHostNameBindingArgs {
    /**
     * Name of host
     */
    readonly hostName: string;
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
 * A host name binding object
 */
export interface GetSiteHostNameBindingResult {
    /**
     * Azure resource name
     */
    readonly azureResourceName?: string;
    /**
     * Azure resource type
     */
    readonly azureResourceType?: string;
    /**
     * Custom DNS record type
     */
    readonly customHostNameDnsRecordType?: string;
    /**
     * Fully qualified ARM domain resource URI
     */
    readonly domainId?: string;
    /**
     * Host name type
     */
    readonly hostNameType?: string;
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
     * Web app name
     */
    readonly siteName?: string;
    /**
     * Resource tags
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type
     */
    readonly type?: string;
}

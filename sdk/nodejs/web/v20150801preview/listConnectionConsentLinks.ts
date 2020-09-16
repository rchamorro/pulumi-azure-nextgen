// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function listConnectionConsentLinks(args: ListConnectionConsentLinksArgs, opts?: pulumi.InvokeOptions): Promise<ListConnectionConsentLinksResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:web/v20150801preview:listConnectionConsentLinks", {
        "connectionName": args.connectionName,
        "id": args.id,
        "kind": args.kind,
        "location": args.location,
        "name": args.name,
        "parameters": args.parameters,
        "resourceGroupName": args.resourceGroupName,
        "tags": args.tags,
        "type": args.type,
    }, opts);
}

export interface ListConnectionConsentLinksArgs {
    /**
     * The connection name.
     */
    readonly connectionName: string;
    /**
     * Resource Id
     */
    readonly id?: string;
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
     * Array of links
     */
    readonly parameters?: inputs.web.v20150801preview.ConsentLinkInputParameter[];
    /**
     * The resource group name.
     */
    readonly resourceGroupName: string;
    /**
     * Resource tags
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type
     */
    readonly type?: string;
}

/**
 * Collection of consent links
 */
export interface ListConnectionConsentLinksResult {
    /**
     * Collection of resources
     */
    readonly value?: outputs.web.v20150801preview.ConsentLinkResponse[];
}
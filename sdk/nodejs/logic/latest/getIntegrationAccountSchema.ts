// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getIntegrationAccountSchema(args: GetIntegrationAccountSchemaArgs, opts?: pulumi.InvokeOptions): Promise<GetIntegrationAccountSchemaResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:logic/latest:getIntegrationAccountSchema", {
        "integrationAccountName": args.integrationAccountName,
        "resourceGroupName": args.resourceGroupName,
        "schemaName": args.schemaName,
    }, opts);
}

export interface GetIntegrationAccountSchemaArgs {
    /**
     * The integration account name.
     */
    readonly integrationAccountName: string;
    /**
     * The resource group name.
     */
    readonly resourceGroupName: string;
    /**
     * The integration account schema name.
     */
    readonly schemaName: string;
}

/**
 * The integration account schema.
 */
export interface GetIntegrationAccountSchemaResult {
    /**
     * The changed time.
     */
    readonly changedTime: string;
    /**
     * The content.
     */
    readonly content?: string;
    /**
     * The content link.
     */
    readonly contentLink: outputs.logic.latest.ContentLinkResponse;
    /**
     * The content type.
     */
    readonly contentType?: string;
    /**
     * The created time.
     */
    readonly createdTime: string;
    /**
     * The document name.
     */
    readonly documentName?: string;
    /**
     * The file name.
     */
    readonly fileName?: string;
    /**
     * The resource location.
     */
    readonly location?: string;
    /**
     * The metadata.
     */
    readonly metadata?: any;
    /**
     * Gets the resource name.
     */
    readonly name: string;
    /**
     * The schema type.
     */
    readonly schemaType: string;
    /**
     * The resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * The target namespace of the schema.
     */
    readonly targetNamespace?: string;
    /**
     * Gets the resource type.
     */
    readonly type: string;
}

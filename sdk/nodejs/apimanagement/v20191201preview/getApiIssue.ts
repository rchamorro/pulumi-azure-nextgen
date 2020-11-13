// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getApiIssue(args: GetApiIssueArgs, opts?: pulumi.InvokeOptions): Promise<GetApiIssueResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:apimanagement/v20191201preview:getApiIssue", {
        "apiId": args.apiId,
        "expandCommentsAttachments": args.expandCommentsAttachments,
        "issueId": args.issueId,
        "resourceGroupName": args.resourceGroupName,
        "serviceName": args.serviceName,
    }, opts);
}

export interface GetApiIssueArgs {
    /**
     * API identifier. Must be unique in the current API Management service instance.
     */
    readonly apiId: string;
    /**
     * Expand the comment attachments. 
     */
    readonly expandCommentsAttachments?: boolean;
    /**
     * Issue identifier. Must be unique in the current API Management service instance.
     */
    readonly issueId: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the API Management service.
     */
    readonly serviceName: string;
}

/**
 * Issue Contract details.
 */
export interface GetApiIssueResult {
    /**
     * A resource identifier for the API the issue was created for.
     */
    readonly apiId?: string;
    /**
     * Date and time when the issue was created.
     */
    readonly createdDate?: string;
    /**
     * Text describing the issue.
     */
    readonly description: string;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * Status of the issue.
     */
    readonly state?: string;
    /**
     * The issue title.
     */
    readonly title: string;
    /**
     * Resource type for API Management resource.
     */
    readonly type: string;
    /**
     * A resource identifier for the user created the issue.
     */
    readonly userId: string;
}

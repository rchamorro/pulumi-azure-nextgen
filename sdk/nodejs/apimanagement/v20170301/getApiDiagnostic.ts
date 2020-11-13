// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getApiDiagnostic(args: GetApiDiagnosticArgs, opts?: pulumi.InvokeOptions): Promise<GetApiDiagnosticResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:apimanagement/v20170301:getApiDiagnostic", {
        "apiId": args.apiId,
        "diagnosticId": args.diagnosticId,
        "resourceGroupName": args.resourceGroupName,
        "serviceName": args.serviceName,
    }, opts);
}

export interface GetApiDiagnosticArgs {
    /**
     * API identifier. Must be unique in the current API Management service instance.
     */
    readonly apiId: string;
    /**
     * Diagnostic identifier. Must be unique in the current API Management service instance.
     */
    readonly diagnosticId: string;
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
 * Diagnostic details.
 */
export interface GetApiDiagnosticResult {
    /**
     * Indicates whether a diagnostic should receive data or not.
     */
    readonly enabled: boolean;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * Resource type for API Management resource.
     */
    readonly type: string;
}

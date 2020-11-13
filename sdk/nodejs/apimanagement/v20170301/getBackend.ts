// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getBackend(args: GetBackendArgs, opts?: pulumi.InvokeOptions): Promise<GetBackendResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:apimanagement/v20170301:getBackend", {
        "backendid": args.backendid,
        "resourceGroupName": args.resourceGroupName,
        "serviceName": args.serviceName,
    }, opts);
}

export interface GetBackendArgs {
    /**
     * Identifier of the Backend entity. Must be unique in the current API Management service instance.
     */
    readonly backendid: string;
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
 * Backend details.
 */
export interface GetBackendResult {
    /**
     * Backend Credentials Contract Properties
     */
    readonly credentials?: outputs.apimanagement.v20170301.BackendCredentialsContractResponse;
    /**
     * Backend Description.
     */
    readonly description?: string;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * Backend Properties contract
     */
    readonly properties: outputs.apimanagement.v20170301.BackendPropertiesResponse;
    /**
     * Backend communication protocol.
     */
    readonly protocol: string;
    /**
     * Backend Proxy Contract Properties
     */
    readonly proxy?: outputs.apimanagement.v20170301.BackendProxyContractResponse;
    /**
     * Management Uri of the Resource in External System. This url can be the Arm Resource Id of Logic Apps, Function Apps or Api Apps.
     */
    readonly resourceId?: string;
    /**
     * Backend Title.
     */
    readonly title?: string;
    /**
     * Backend TLS Properties
     */
    readonly tls?: outputs.apimanagement.v20170301.BackendTlsPropertiesResponse;
    /**
     * Resource type for API Management resource.
     */
    readonly type: string;
    /**
     * Runtime Url of the Backend.
     */
    readonly url: string;
}

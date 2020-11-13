// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getConfigurationStore(args: GetConfigurationStoreArgs, opts?: pulumi.InvokeOptions): Promise<GetConfigurationStoreResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:appconfiguration/v20200701preview:getConfigurationStore", {
        "configStoreName": args.configStoreName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetConfigurationStoreArgs {
    /**
     * The name of the configuration store.
     */
    readonly configStoreName: string;
    /**
     * The name of the resource group to which the container registry belongs.
     */
    readonly resourceGroupName: string;
}

/**
 * The configuration store along with all resource properties. The Configuration Store will have all information to begin utilizing it.
 */
export interface GetConfigurationStoreResult {
    /**
     * The creation date of configuration store.
     */
    readonly creationDate: string;
    /**
     * The encryption settings of the configuration store.
     */
    readonly encryption?: outputs.appconfiguration.v20200701preview.EncryptionPropertiesResponse;
    /**
     * The DNS endpoint where the configuration store API will be available.
     */
    readonly endpoint: string;
    /**
     * The managed identity information, if configured.
     */
    readonly identity?: outputs.appconfiguration.v20200701preview.ResourceIdentityResponse;
    /**
     * The location of the resource. This cannot be changed after the resource is created.
     */
    readonly location: string;
    /**
     * The name of the resource.
     */
    readonly name: string;
    /**
     * The list of private endpoint connections that are set up for this resource.
     */
    readonly privateEndpointConnections: outputs.appconfiguration.v20200701preview.PrivateEndpointConnectionReferenceResponse[];
    /**
     * The provisioning state of the configuration store.
     */
    readonly provisioningState: string;
    /**
     * Control permission for data plane traffic coming from public networks while private endpoint is enabled.
     */
    readonly publicNetworkAccess?: string;
    /**
     * The sku of the configuration store.
     */
    readonly sku: outputs.appconfiguration.v20200701preview.SkuResponse;
    /**
     * The tags of the resource.
     */
    readonly tags?: {[key: string]: string};
    /**
     * The type of the resource.
     */
    readonly type: string;
}

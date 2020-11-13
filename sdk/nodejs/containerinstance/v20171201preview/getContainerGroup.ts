// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getContainerGroup(args: GetContainerGroupArgs, opts?: pulumi.InvokeOptions): Promise<GetContainerGroupResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:containerinstance/v20171201preview:getContainerGroup", {
        "containerGroupName": args.containerGroupName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetContainerGroupArgs {
    /**
     * The name of the container group.
     */
    readonly containerGroupName: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
}

/**
 * A container group.
 */
export interface GetContainerGroupResult {
    /**
     * The containers within the container group.
     */
    readonly containers: outputs.containerinstance.v20171201preview.ContainerResponse[];
    /**
     * The image registry credentials by which the container group is created from.
     */
    readonly imageRegistryCredentials?: outputs.containerinstance.v20171201preview.ImageRegistryCredentialResponse[];
    /**
     * The instance view of the container group. Only valid in response.
     */
    readonly instanceView: outputs.containerinstance.v20171201preview.ContainerGroupResponseInstanceView;
    /**
     * The IP address type of the container group.
     */
    readonly ipAddress?: outputs.containerinstance.v20171201preview.IpAddressResponse;
    /**
     * The resource location.
     */
    readonly location: string;
    /**
     * The resource name.
     */
    readonly name: string;
    /**
     * The operating system type required by the containers in the container group.
     */
    readonly osType: string;
    /**
     * The provisioning state of the container group. This only appears in the response.
     */
    readonly provisioningState: string;
    /**
     * Restart policy for all containers within the container group. 
     * - `Always` Always restart
     * - `OnFailure` Restart on failure
     * - `Never` Never restart
     */
    readonly restartPolicy?: string;
    /**
     * The resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * The resource type.
     */
    readonly type: string;
    /**
     * The list of volumes that can be mounted by containers in this container group.
     */
    readonly volumes?: outputs.containerinstance.v20171201preview.VolumeResponse[];
}

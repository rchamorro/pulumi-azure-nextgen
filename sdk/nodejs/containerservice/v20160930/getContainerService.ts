// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getContainerService(args: GetContainerServiceArgs, opts?: pulumi.InvokeOptions): Promise<GetContainerServiceResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:containerservice/v20160930:getContainerService", {
        "containerServiceName": args.containerServiceName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetContainerServiceArgs {
    /**
     * The name of the container service in the specified subscription and resource group.
     */
    readonly containerServiceName: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
}

/**
 * Container service.
 */
export interface GetContainerServiceResult {
    /**
     * Properties of the agent pool.
     */
    readonly agentPoolProfiles: outputs.containerservice.v20160930.ContainerServiceAgentPoolProfileResponse[];
    /**
     * Properties for custom clusters.
     */
    readonly customProfile?: outputs.containerservice.v20160930.ContainerServiceCustomProfileResponse;
    /**
     * Properties of the diagnostic agent.
     */
    readonly diagnosticsProfile?: outputs.containerservice.v20160930.ContainerServiceDiagnosticsProfileResponse;
    /**
     * Properties of Linux VMs.
     */
    readonly linuxProfile: outputs.containerservice.v20160930.ContainerServiceLinuxProfileResponse;
    /**
     * Resource location
     */
    readonly location: string;
    /**
     * Properties of master agents.
     */
    readonly masterProfile: outputs.containerservice.v20160930.ContainerServiceMasterProfileResponse;
    /**
     * Resource name
     */
    readonly name: string;
    /**
     * Properties of the orchestrator.
     */
    readonly orchestratorProfile?: outputs.containerservice.v20160930.ContainerServiceOrchestratorProfileResponse;
    /**
     * the current deployment or provisioning state, which only appears in the response.
     */
    readonly provisioningState: string;
    /**
     * Properties for cluster service principals.
     */
    readonly servicePrincipalProfile?: outputs.containerservice.v20160930.ContainerServiceServicePrincipalProfileResponse;
    /**
     * Resource tags
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type
     */
    readonly type: string;
    /**
     * Properties of Windows VMs.
     */
    readonly windowsProfile?: outputs.containerservice.v20160930.ContainerServiceWindowsProfileResponse;
}

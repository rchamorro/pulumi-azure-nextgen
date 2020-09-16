import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
/**
 * A container group.
 */
export declare class ContainerGroup extends pulumi.CustomResource {
    /**
     * Get an existing ContainerGroup resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ContainerGroup;
    /**
     * Returns true if the given object is an instance of ContainerGroup.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    static isInstance(obj: any): obj is ContainerGroup;
    /**
     * The containers within the container group.
     */
    readonly containers: pulumi.Output<outputs.containerinstance.v20180901.ContainerResponse[]>;
    /**
     * The diagnostic information for a container group.
     */
    readonly diagnostics: pulumi.Output<outputs.containerinstance.v20180901.ContainerGroupDiagnosticsResponse | undefined>;
    /**
     * The image registry credentials by which the container group is created from.
     */
    readonly imageRegistryCredentials: pulumi.Output<outputs.containerinstance.v20180901.ImageRegistryCredentialResponse[] | undefined>;
    /**
     * The instance view of the container group. Only valid in response.
     */
    readonly instanceView: pulumi.Output<outputs.containerinstance.v20180901.ContainerGroupResponseInstanceView>;
    /**
     * The IP address type of the container group.
     */
    readonly ipAddress: pulumi.Output<outputs.containerinstance.v20180901.IpAddressResponse | undefined>;
    /**
     * The resource location.
     */
    readonly location: pulumi.Output<string | undefined>;
    /**
     * The resource name.
     */
    readonly name: pulumi.Output<string>;
    /**
     * The network profile information for a container group.
     */
    readonly networkProfile: pulumi.Output<outputs.containerinstance.v20180901.ContainerGroupNetworkProfileResponse | undefined>;
    /**
     * The operating system type required by the containers in the container group.
     */
    readonly osType: pulumi.Output<string>;
    /**
     * The provisioning state of the container group. This only appears in the response.
     */
    readonly provisioningState: pulumi.Output<string>;
    /**
     * Restart policy for all containers within the container group.
     * - `Always` Always restart
     * - `OnFailure` Restart on failure
     * - `Never` Never restart
     */
    readonly restartPolicy: pulumi.Output<string | undefined>;
    /**
     * The resource tags.
     */
    readonly tags: pulumi.Output<{
        [key: string]: string;
    } | undefined>;
    /**
     * The resource type.
     */
    readonly type: pulumi.Output<string>;
    /**
     * The list of volumes that can be mounted by containers in this container group.
     */
    readonly volumes: pulumi.Output<outputs.containerinstance.v20180901.VolumeResponse[] | undefined>;
    /**
     * Create a ContainerGroup resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ContainerGroupArgs, opts?: pulumi.CustomResourceOptions);
    constructor(name: string, state: undefined, opts: pulumi.CustomResourceOptions);
}
/**
 * The set of arguments for constructing a ContainerGroup resource.
 */
export interface ContainerGroupArgs {
    /**
     * The name of the container group.
     */
    readonly containerGroupName: pulumi.Input<string>;
    /**
     * The containers within the container group.
     */
    readonly containers: pulumi.Input<pulumi.Input<inputs.containerinstance.v20180901.Container>[]>;
    /**
     * The diagnostic information for a container group.
     */
    readonly diagnostics?: pulumi.Input<inputs.containerinstance.v20180901.ContainerGroupDiagnostics>;
    /**
     * The image registry credentials by which the container group is created from.
     */
    readonly imageRegistryCredentials?: pulumi.Input<pulumi.Input<inputs.containerinstance.v20180901.ImageRegistryCredential>[]>;
    /**
     * The IP address type of the container group.
     */
    readonly ipAddress?: pulumi.Input<inputs.containerinstance.v20180901.IpAddress>;
    /**
     * The resource location.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * The network profile information for a container group.
     */
    readonly networkProfile?: pulumi.Input<inputs.containerinstance.v20180901.ContainerGroupNetworkProfile>;
    /**
     * The operating system type required by the containers in the container group.
     */
    readonly osType: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Restart policy for all containers within the container group.
     * - `Always` Always restart
     * - `OnFailure` Restart on failure
     * - `Never` Never restart
     */
    readonly restartPolicy?: pulumi.Input<string>;
    /**
     * The resource tags.
     */
    readonly tags?: pulumi.Input<{
        [key: string]: pulumi.Input<string>;
    }>;
    /**
     * The list of volumes that can be mounted by containers in this container group.
     */
    readonly volumes?: pulumi.Input<pulumi.Input<inputs.containerinstance.v20180901.Volume>[]>;
}
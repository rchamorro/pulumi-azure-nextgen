import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
/**
 * Managed cluster.
 */
export declare class ManagedCluster extends pulumi.CustomResource {
    /**
     * Get an existing ManagedCluster resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ManagedCluster;
    /**
     * Returns true if the given object is an instance of ManagedCluster.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    static isInstance(obj: any): obj is ManagedCluster;
    /**
     * Profile of Azure Active Directory configuration.
     */
    readonly aadProfile: pulumi.Output<outputs.containerservice.v20190601.ManagedClusterAADProfileResponse | undefined>;
    /**
     * Profile of managed cluster add-on.
     */
    readonly addonProfiles: pulumi.Output<{
        [key: string]: outputs.containerservice.v20190601.ManagedClusterAddonProfileResponse;
    } | undefined>;
    /**
     * Properties of the agent pool.
     */
    readonly agentPoolProfiles: pulumi.Output<outputs.containerservice.v20190601.ManagedClusterAgentPoolProfileResponse[] | undefined>;
    /**
     * (PREVIEW) Authorized IP Ranges to kubernetes API server.
     */
    readonly apiServerAuthorizedIPRanges: pulumi.Output<string[] | undefined>;
    /**
     * DNS prefix specified when creating the managed cluster.
     */
    readonly dnsPrefix: pulumi.Output<string | undefined>;
    /**
     * (DEPRECATING) Whether to enable Kubernetes pod security policy (preview). This feature is set for removal on October 15th, 2020. Learn more at aka.ms/aks/azpodpolicy.
     */
    readonly enablePodSecurityPolicy: pulumi.Output<boolean | undefined>;
    /**
     * Whether to enable Kubernetes Role-Based Access Control.
     */
    readonly enableRBAC: pulumi.Output<boolean | undefined>;
    /**
     * FQDN for the master pool.
     */
    readonly fqdn: pulumi.Output<string>;
    /**
     * The identity of the managed cluster, if configured.
     */
    readonly identity: pulumi.Output<outputs.containerservice.v20190601.ManagedClusterIdentityResponse | undefined>;
    /**
     * Version of Kubernetes specified when creating the managed cluster.
     */
    readonly kubernetesVersion: pulumi.Output<string | undefined>;
    /**
     * Profile for Linux VMs in the container service cluster.
     */
    readonly linuxProfile: pulumi.Output<outputs.containerservice.v20190601.ContainerServiceLinuxProfileResponse | undefined>;
    /**
     * Resource location
     */
    readonly location: pulumi.Output<string>;
    /**
     * The max number of agent pools for the managed cluster.
     */
    readonly maxAgentPools: pulumi.Output<number>;
    /**
     * Resource name
     */
    readonly name: pulumi.Output<string>;
    /**
     * Profile of network configuration.
     */
    readonly networkProfile: pulumi.Output<outputs.containerservice.v20190601.ContainerServiceNetworkProfileResponse | undefined>;
    /**
     * Name of the resource group containing agent pool nodes.
     */
    readonly nodeResourceGroup: pulumi.Output<string | undefined>;
    /**
     * The current deployment or provisioning state, which only appears in the response.
     */
    readonly provisioningState: pulumi.Output<string>;
    /**
     * Information about a service principal identity for the cluster to use for manipulating Azure APIs.
     */
    readonly servicePrincipalProfile: pulumi.Output<outputs.containerservice.v20190601.ManagedClusterServicePrincipalProfileResponse | undefined>;
    /**
     * Resource tags
     */
    readonly tags: pulumi.Output<{
        [key: string]: string;
    } | undefined>;
    /**
     * Resource type
     */
    readonly type: pulumi.Output<string>;
    /**
     * Profile for Windows VMs in the container service cluster.
     */
    readonly windowsProfile: pulumi.Output<outputs.containerservice.v20190601.ManagedClusterWindowsProfileResponse | undefined>;
    /**
     * Create a ManagedCluster resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ManagedClusterArgs, opts?: pulumi.CustomResourceOptions);
    constructor(name: string, state: undefined, opts: pulumi.CustomResourceOptions);
}
/**
 * The set of arguments for constructing a ManagedCluster resource.
 */
export interface ManagedClusterArgs {
    /**
     * Profile of Azure Active Directory configuration.
     */
    readonly aadProfile?: pulumi.Input<inputs.containerservice.v20190601.ManagedClusterAADProfile>;
    /**
     * Profile of managed cluster add-on.
     */
    readonly addonProfiles?: pulumi.Input<{
        [key: string]: pulumi.Input<inputs.containerservice.v20190601.ManagedClusterAddonProfile>;
    }>;
    /**
     * Properties of the agent pool.
     */
    readonly agentPoolProfiles?: pulumi.Input<pulumi.Input<inputs.containerservice.v20190601.ManagedClusterAgentPoolProfile>[]>;
    /**
     * (PREVIEW) Authorized IP Ranges to kubernetes API server.
     */
    readonly apiServerAuthorizedIPRanges?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * DNS prefix specified when creating the managed cluster.
     */
    readonly dnsPrefix?: pulumi.Input<string>;
    /**
     * (DEPRECATING) Whether to enable Kubernetes pod security policy (preview). This feature is set for removal on October 15th, 2020. Learn more at aka.ms/aks/azpodpolicy.
     */
    readonly enablePodSecurityPolicy?: pulumi.Input<boolean>;
    /**
     * Whether to enable Kubernetes Role-Based Access Control.
     */
    readonly enableRBAC?: pulumi.Input<boolean>;
    /**
     * The identity of the managed cluster, if configured.
     */
    readonly identity?: pulumi.Input<inputs.containerservice.v20190601.ManagedClusterIdentity>;
    /**
     * Version of Kubernetes specified when creating the managed cluster.
     */
    readonly kubernetesVersion?: pulumi.Input<string>;
    /**
     * Profile for Linux VMs in the container service cluster.
     */
    readonly linuxProfile?: pulumi.Input<inputs.containerservice.v20190601.ContainerServiceLinuxProfile>;
    /**
     * Resource location
     */
    readonly location: pulumi.Input<string>;
    /**
     * Profile of network configuration.
     */
    readonly networkProfile?: pulumi.Input<inputs.containerservice.v20190601.ContainerServiceNetworkProfile>;
    /**
     * Name of the resource group containing agent pool nodes.
     */
    readonly nodeResourceGroup?: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the managed cluster resource.
     */
    readonly resourceName: pulumi.Input<string>;
    /**
     * Information about a service principal identity for the cluster to use for manipulating Azure APIs.
     */
    readonly servicePrincipalProfile?: pulumi.Input<inputs.containerservice.v20190601.ManagedClusterServicePrincipalProfile>;
    /**
     * Resource tags
     */
    readonly tags?: pulumi.Input<{
        [key: string]: pulumi.Input<string>;
    }>;
    /**
     * Profile for Windows VMs in the container service cluster.
     */
    readonly windowsProfile?: pulumi.Input<inputs.containerservice.v20190601.ManagedClusterWindowsProfile>;
}
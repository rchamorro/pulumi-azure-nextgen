// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * A container group.
 */
export class ContainerGroup extends pulumi.CustomResource {
    /**
     * Get an existing ContainerGroup resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ContainerGroup {
        return new ContainerGroup(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:containerinstance/v20170801preview:ContainerGroup';

    /**
     * Returns true if the given object is an instance of ContainerGroup.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ContainerGroup {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ContainerGroup.__pulumiType;
    }

    /**
     * The containers within the container group.
     */
    public readonly containers!: pulumi.Output<outputs.containerinstance.v20170801preview.ContainerResponse[]>;
    /**
     * The image registry credentials by which the container group is created from.
     */
    public readonly imageRegistryCredentials!: pulumi.Output<outputs.containerinstance.v20170801preview.ImageRegistryCredentialResponse[] | undefined>;
    /**
     * The IP address type of the container group.
     */
    public readonly ipAddress!: pulumi.Output<outputs.containerinstance.v20170801preview.IpAddressResponse | undefined>;
    /**
     * The resource location.
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * The resource name.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The operating system type required by the containers in the container group.
     */
    public readonly osType!: pulumi.Output<string>;
    /**
     * The provisioning state of the container group. This only appears in the response.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * Restart policy for all containers within the container group. Currently the only available option is `always`.
     */
    public readonly restartPolicy!: pulumi.Output<string | undefined>;
    /**
     * The current state of the container group. This is only valid for the response.
     */
    public /*out*/ readonly state!: pulumi.Output<string>;
    /**
     * The resource tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * The resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * The list of volumes that can be mounted by containers in this container group.
     */
    public readonly volumes!: pulumi.Output<outputs.containerinstance.v20170801preview.VolumeResponse[] | undefined>;

    /**
     * Create a ContainerGroup resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ContainerGroupArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.containerGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'containerGroupName'");
            }
            if ((!args || args.containers === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'containers'");
            }
            if ((!args || args.osType === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'osType'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["containerGroupName"] = args ? args.containerGroupName : undefined;
            inputs["containers"] = args ? args.containers : undefined;
            inputs["imageRegistryCredentials"] = args ? args.imageRegistryCredentials : undefined;
            inputs["ipAddress"] = args ? args.ipAddress : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["osType"] = args ? args.osType : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["restartPolicy"] = args ? args.restartPolicy : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["volumes"] = args ? args.volumes : undefined;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["state"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["containers"] = undefined /*out*/;
            inputs["imageRegistryCredentials"] = undefined /*out*/;
            inputs["ipAddress"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["osType"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["restartPolicy"] = undefined /*out*/;
            inputs["state"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["volumes"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:containerinstance/latest:ContainerGroup" }, { type: "azure-nextgen:containerinstance/v20171001preview:ContainerGroup" }, { type: "azure-nextgen:containerinstance/v20171201preview:ContainerGroup" }, { type: "azure-nextgen:containerinstance/v20180201preview:ContainerGroup" }, { type: "azure-nextgen:containerinstance/v20180401:ContainerGroup" }, { type: "azure-nextgen:containerinstance/v20180601:ContainerGroup" }, { type: "azure-nextgen:containerinstance/v20180901:ContainerGroup" }, { type: "azure-nextgen:containerinstance/v20181001:ContainerGroup" }, { type: "azure-nextgen:containerinstance/v20191201:ContainerGroup" }, { type: "azure-nextgen:containerinstance/v20201101:ContainerGroup" }, { type: "azure-nextgen:containerinstance/v20210301:ContainerGroup" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(ContainerGroup.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a ContainerGroup resource.
 */
export interface ContainerGroupArgs {
    /**
     * The name of the container group to be created or updated.
     */
    readonly containerGroupName: pulumi.Input<string>;
    /**
     * The containers within the container group.
     */
    readonly containers: pulumi.Input<pulumi.Input<inputs.containerinstance.v20170801preview.Container>[]>;
    /**
     * The image registry credentials by which the container group is created from.
     */
    readonly imageRegistryCredentials?: pulumi.Input<pulumi.Input<inputs.containerinstance.v20170801preview.ImageRegistryCredential>[]>;
    /**
     * The IP address type of the container group.
     */
    readonly ipAddress?: pulumi.Input<inputs.containerinstance.v20170801preview.IpAddress>;
    /**
     * The resource location.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * The operating system type required by the containers in the container group.
     */
    readonly osType: pulumi.Input<string | enums.containerinstance.v20170801preview.OperatingSystemTypes>;
    /**
     * The name of the resource group to contain the container group to be created or updated.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Restart policy for all containers within the container group. Currently the only available option is `always`.
     */
    readonly restartPolicy?: pulumi.Input<string | enums.containerinstance.v20170801preview.ContainerRestartPolicy>;
    /**
     * The resource tags.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The list of volumes that can be mounted by containers in this container group.
     */
    readonly volumes?: pulumi.Input<pulumi.Input<inputs.containerinstance.v20170801preview.Volume>[]>;
}

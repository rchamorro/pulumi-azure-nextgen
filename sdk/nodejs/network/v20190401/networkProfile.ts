// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

/**
 * Network profile resource.
 */
export class NetworkProfile extends pulumi.CustomResource {
    /**
     * Get an existing NetworkProfile resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): NetworkProfile {
        return new NetworkProfile(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:network/v20190401:NetworkProfile';

    /**
     * Returns true if the given object is an instance of NetworkProfile.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is NetworkProfile {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === NetworkProfile.__pulumiType;
    }

    /**
     * List of chid container network interface configurations.
     */
    public readonly containerNetworkInterfaceConfigurations!: pulumi.Output<outputs.network.v20190401.ContainerNetworkInterfaceConfigurationResponse[] | undefined>;
    /**
     * List of child container network interfaces.
     */
    public readonly containerNetworkInterfaces!: pulumi.Output<outputs.network.v20190401.ContainerNetworkInterfaceResponse[] | undefined>;
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    public readonly etag!: pulumi.Output<string | undefined>;
    /**
     * Resource location.
     */
    public readonly location!: pulumi.Output<string | undefined>;
    /**
     * Resource name.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The provisioning state of the resource.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * The resource GUID property of the network interface resource.
     */
    public /*out*/ readonly resourceGuid!: pulumi.Output<string>;
    /**
     * Resource tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a NetworkProfile resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: NetworkProfileArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.networkProfileName === undefined) {
                throw new Error("Missing required property 'networkProfileName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["containerNetworkInterfaceConfigurations"] = args ? args.containerNetworkInterfaceConfigurations : undefined;
            inputs["containerNetworkInterfaces"] = args ? args.containerNetworkInterfaces : undefined;
            inputs["etag"] = args ? args.etag : undefined;
            inputs["id"] = args ? args.id : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["networkProfileName"] = args ? args.networkProfileName : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["resourceGuid"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["containerNetworkInterfaceConfigurations"] = undefined /*out*/;
            inputs["containerNetworkInterfaces"] = undefined /*out*/;
            inputs["etag"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["resourceGuid"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:network/latest:NetworkProfile" }, { type: "azure-nextgen:network/v20180801:NetworkProfile" }, { type: "azure-nextgen:network/v20181001:NetworkProfile" }, { type: "azure-nextgen:network/v20181101:NetworkProfile" }, { type: "azure-nextgen:network/v20181201:NetworkProfile" }, { type: "azure-nextgen:network/v20190201:NetworkProfile" }, { type: "azure-nextgen:network/v20190601:NetworkProfile" }, { type: "azure-nextgen:network/v20190701:NetworkProfile" }, { type: "azure-nextgen:network/v20190801:NetworkProfile" }, { type: "azure-nextgen:network/v20190901:NetworkProfile" }, { type: "azure-nextgen:network/v20191101:NetworkProfile" }, { type: "azure-nextgen:network/v20191201:NetworkProfile" }, { type: "azure-nextgen:network/v20200301:NetworkProfile" }, { type: "azure-nextgen:network/v20200401:NetworkProfile" }, { type: "azure-nextgen:network/v20200501:NetworkProfile" }, { type: "azure-nextgen:network/v20200601:NetworkProfile" }, { type: "azure-nextgen:network/v20200701:NetworkProfile" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(NetworkProfile.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a NetworkProfile resource.
 */
export interface NetworkProfileArgs {
    /**
     * List of chid container network interface configurations.
     */
    readonly containerNetworkInterfaceConfigurations?: pulumi.Input<pulumi.Input<inputs.network.v20190401.ContainerNetworkInterfaceConfiguration>[]>;
    /**
     * List of child container network interfaces.
     */
    readonly containerNetworkInterfaces?: pulumi.Input<pulumi.Input<inputs.network.v20190401.ContainerNetworkInterface>[]>;
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    readonly etag?: pulumi.Input<string>;
    /**
     * Resource ID.
     */
    readonly id?: pulumi.Input<string>;
    /**
     * Resource location.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * The name of the network profile.
     */
    readonly networkProfileName: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Resource tags.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}

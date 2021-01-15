// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * PrivateEndpointConnection resource.
 */
export class PrivateLinkServicePrivateEndpointConnection extends pulumi.CustomResource {
    /**
     * Get an existing PrivateLinkServicePrivateEndpointConnection resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): PrivateLinkServicePrivateEndpointConnection {
        return new PrivateLinkServicePrivateEndpointConnection(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:network/v20190901:PrivateLinkServicePrivateEndpointConnection';

    /**
     * Returns true if the given object is an instance of PrivateLinkServicePrivateEndpointConnection.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is PrivateLinkServicePrivateEndpointConnection {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === PrivateLinkServicePrivateEndpointConnection.__pulumiType;
    }

    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    public /*out*/ readonly etag!: pulumi.Output<string>;
    /**
     * The consumer link id.
     */
    public /*out*/ readonly linkIdentifier!: pulumi.Output<string>;
    /**
     * The name of the resource that is unique within a resource group. This name can be used to access the resource.
     */
    public readonly name!: pulumi.Output<string | undefined>;
    /**
     * The resource of private end point.
     */
    public /*out*/ readonly privateEndpoint!: pulumi.Output<outputs.network.v20190901.PrivateEndpointResponse>;
    /**
     * A collection of information about the state of the connection between service consumer and provider.
     */
    public readonly privateLinkServiceConnectionState!: pulumi.Output<outputs.network.v20190901.PrivateLinkServiceConnectionStateResponse | undefined>;
    /**
     * The provisioning state of the private endpoint connection resource.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * The resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a PrivateLinkServicePrivateEndpointConnection resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: PrivateLinkServicePrivateEndpointConnectionArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.peConnectionName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'peConnectionName'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if ((!args || args.serviceName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'serviceName'");
            }
            inputs["id"] = args ? args.id : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["peConnectionName"] = args ? args.peConnectionName : undefined;
            inputs["privateLinkServiceConnectionState"] = args ? args.privateLinkServiceConnectionState : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["serviceName"] = args ? args.serviceName : undefined;
            inputs["etag"] = undefined /*out*/;
            inputs["linkIdentifier"] = undefined /*out*/;
            inputs["privateEndpoint"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["etag"] = undefined /*out*/;
            inputs["linkIdentifier"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["privateEndpoint"] = undefined /*out*/;
            inputs["privateLinkServiceConnectionState"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:network/latest:PrivateLinkServicePrivateEndpointConnection" }, { type: "azure-nextgen:network/v20191101:PrivateLinkServicePrivateEndpointConnection" }, { type: "azure-nextgen:network/v20191201:PrivateLinkServicePrivateEndpointConnection" }, { type: "azure-nextgen:network/v20200301:PrivateLinkServicePrivateEndpointConnection" }, { type: "azure-nextgen:network/v20200401:PrivateLinkServicePrivateEndpointConnection" }, { type: "azure-nextgen:network/v20200501:PrivateLinkServicePrivateEndpointConnection" }, { type: "azure-nextgen:network/v20200601:PrivateLinkServicePrivateEndpointConnection" }, { type: "azure-nextgen:network/v20200701:PrivateLinkServicePrivateEndpointConnection" }, { type: "azure-nextgen:network/v20200801:PrivateLinkServicePrivateEndpointConnection" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(PrivateLinkServicePrivateEndpointConnection.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a PrivateLinkServicePrivateEndpointConnection resource.
 */
export interface PrivateLinkServicePrivateEndpointConnectionArgs {
    /**
     * Resource ID.
     */
    readonly id?: pulumi.Input<string>;
    /**
     * The name of the resource that is unique within a resource group. This name can be used to access the resource.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The name of the private end point connection.
     */
    readonly peConnectionName: pulumi.Input<string>;
    /**
     * A collection of information about the state of the connection between service consumer and provider.
     */
    readonly privateLinkServiceConnectionState?: pulumi.Input<inputs.network.v20190901.PrivateLinkServiceConnectionState>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the private link service.
     */
    readonly serviceName: pulumi.Input<string>;
}

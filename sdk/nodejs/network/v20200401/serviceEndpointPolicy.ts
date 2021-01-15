// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Service End point policy resource.
 */
export class ServiceEndpointPolicy extends pulumi.CustomResource {
    /**
     * Get an existing ServiceEndpointPolicy resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ServiceEndpointPolicy {
        return new ServiceEndpointPolicy(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:network/v20200401:ServiceEndpointPolicy';

    /**
     * Returns true if the given object is an instance of ServiceEndpointPolicy.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ServiceEndpointPolicy {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ServiceEndpointPolicy.__pulumiType;
    }

    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    public /*out*/ readonly etag!: pulumi.Output<string>;
    /**
     * Resource location.
     */
    public readonly location!: pulumi.Output<string | undefined>;
    /**
     * Resource name.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The provisioning state of the service endpoint policy resource.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * The resource GUID property of the service endpoint policy resource.
     */
    public /*out*/ readonly resourceGuid!: pulumi.Output<string>;
    /**
     * A collection of service endpoint policy definitions of the service endpoint policy.
     */
    public readonly serviceEndpointPolicyDefinitions!: pulumi.Output<outputs.network.v20200401.ServiceEndpointPolicyDefinitionResponse[] | undefined>;
    /**
     * A collection of references to subnets.
     */
    public /*out*/ readonly subnets!: pulumi.Output<outputs.network.v20200401.SubnetResponse[]>;
    /**
     * Resource tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a ServiceEndpointPolicy resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ServiceEndpointPolicyArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if ((!args || args.serviceEndpointPolicyName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'serviceEndpointPolicyName'");
            }
            inputs["id"] = args ? args.id : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["serviceEndpointPolicyDefinitions"] = args ? args.serviceEndpointPolicyDefinitions : undefined;
            inputs["serviceEndpointPolicyName"] = args ? args.serviceEndpointPolicyName : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["etag"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["resourceGuid"] = undefined /*out*/;
            inputs["subnets"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["etag"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["resourceGuid"] = undefined /*out*/;
            inputs["serviceEndpointPolicyDefinitions"] = undefined /*out*/;
            inputs["subnets"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:network/latest:ServiceEndpointPolicy" }, { type: "azure-nextgen:network/v20180701:ServiceEndpointPolicy" }, { type: "azure-nextgen:network/v20180801:ServiceEndpointPolicy" }, { type: "azure-nextgen:network/v20181001:ServiceEndpointPolicy" }, { type: "azure-nextgen:network/v20181101:ServiceEndpointPolicy" }, { type: "azure-nextgen:network/v20181201:ServiceEndpointPolicy" }, { type: "azure-nextgen:network/v20190201:ServiceEndpointPolicy" }, { type: "azure-nextgen:network/v20190401:ServiceEndpointPolicy" }, { type: "azure-nextgen:network/v20190601:ServiceEndpointPolicy" }, { type: "azure-nextgen:network/v20190701:ServiceEndpointPolicy" }, { type: "azure-nextgen:network/v20190801:ServiceEndpointPolicy" }, { type: "azure-nextgen:network/v20190901:ServiceEndpointPolicy" }, { type: "azure-nextgen:network/v20191101:ServiceEndpointPolicy" }, { type: "azure-nextgen:network/v20191201:ServiceEndpointPolicy" }, { type: "azure-nextgen:network/v20200301:ServiceEndpointPolicy" }, { type: "azure-nextgen:network/v20200501:ServiceEndpointPolicy" }, { type: "azure-nextgen:network/v20200601:ServiceEndpointPolicy" }, { type: "azure-nextgen:network/v20200701:ServiceEndpointPolicy" }, { type: "azure-nextgen:network/v20200801:ServiceEndpointPolicy" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(ServiceEndpointPolicy.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a ServiceEndpointPolicy resource.
 */
export interface ServiceEndpointPolicyArgs {
    /**
     * Resource ID.
     */
    readonly id?: pulumi.Input<string>;
    /**
     * Resource location.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * A collection of service endpoint policy definitions of the service endpoint policy.
     */
    readonly serviceEndpointPolicyDefinitions?: pulumi.Input<pulumi.Input<inputs.network.v20200401.ServiceEndpointPolicyDefinition>[]>;
    /**
     * The name of the service endpoint policy.
     */
    readonly serviceEndpointPolicyName: pulumi.Input<string>;
    /**
     * Resource tags.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}

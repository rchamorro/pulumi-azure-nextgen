import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
/**
 * Single Namespace item in List or Get Operation
 */
export declare class Namespace extends pulumi.CustomResource {
    /**
     * Get an existing Namespace resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Namespace;
    /**
     * Returns true if the given object is an instance of Namespace.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    static isInstance(obj: any): obj is Namespace;
    /**
     * The time the Namespace was created.
     */
    readonly createdAt: pulumi.Output<string | undefined>;
    /**
     * Specifies whether this instance is enabled.
     */
    readonly enabled: pulumi.Output<boolean | undefined>;
    /**
     * Resource location
     */
    readonly location: pulumi.Output<string>;
    /**
     * Identifier for Azure Insights metrics
     */
    readonly metricId: pulumi.Output<string>;
    /**
     * Resource name
     */
    readonly name: pulumi.Output<string>;
    /**
     * Provisioning state of the Namespace.
     */
    readonly provisioningState: pulumi.Output<string | undefined>;
    /**
     * Endpoint you can use to perform Service Bus operations.
     */
    readonly serviceBusEndpoint: pulumi.Output<string | undefined>;
    /**
     * SKU parameters supplied to the create Namespace operation
     */
    readonly sku: pulumi.Output<outputs.eventhub.v20150801.SkuResponse | undefined>;
    /**
     * State of the Namespace.
     */
    readonly status: pulumi.Output<string | undefined>;
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
     * The time the Namespace was updated.
     */
    readonly updatedAt: pulumi.Output<string | undefined>;
    /**
     * Create a Namespace resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: NamespaceArgs, opts?: pulumi.CustomResourceOptions);
    constructor(name: string, state: undefined, opts: pulumi.CustomResourceOptions);
}
/**
 * The set of arguments for constructing a Namespace resource.
 */
export interface NamespaceArgs {
    /**
     * The time the Namespace was created.
     */
    readonly createdAt?: pulumi.Input<string>;
    /**
     * Specifies whether this instance is enabled.
     */
    readonly enabled?: pulumi.Input<boolean>;
    /**
     * Namespace location.
     */
    readonly location: pulumi.Input<string>;
    /**
     * The Namespace name
     */
    readonly namespaceName: pulumi.Input<string>;
    /**
     * Provisioning state of the Namespace.
     */
    readonly provisioningState?: pulumi.Input<string>;
    /**
     * Name of the resource group within the azure subscription.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Endpoint you can use to perform Service Bus operations.
     */
    readonly serviceBusEndpoint?: pulumi.Input<string>;
    /**
     * SKU parameters supplied to the create Namespace operation
     */
    readonly sku?: pulumi.Input<inputs.eventhub.v20150801.Sku>;
    /**
     * State of the Namespace.
     */
    readonly status?: pulumi.Input<string>;
    /**
     * Namespace tags.
     */
    readonly tags?: pulumi.Input<{
        [key: string]: pulumi.Input<string>;
    }>;
    /**
     * The time the Namespace was updated.
     */
    readonly updatedAt?: pulumi.Input<string>;
}
import * as pulumi from "@pulumi/pulumi";
/**
 * A PostgreSQL Server key.
 */
export declare class ServerKey extends pulumi.CustomResource {
    /**
     * Get an existing ServerKey resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ServerKey;
    /**
     * Returns true if the given object is an instance of ServerKey.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    static isInstance(obj: any): obj is ServerKey;
    /**
     * The key creation date.
     */
    readonly creationDate: pulumi.Output<string>;
    /**
     * Kind of encryption protector used to protect the key.
     */
    readonly kind: pulumi.Output<string>;
    /**
     * The name of the resource
     */
    readonly name: pulumi.Output<string>;
    /**
     * The key type like 'AzureKeyVault'.
     */
    readonly serverKeyType: pulumi.Output<string>;
    /**
     * The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts.
     */
    readonly type: pulumi.Output<string>;
    /**
     * The URI of the key.
     */
    readonly uri: pulumi.Output<string | undefined>;
    /**
     * Create a ServerKey resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ServerKeyArgs, opts?: pulumi.CustomResourceOptions);
    constructor(name: string, state: undefined, opts: pulumi.CustomResourceOptions);
}
/**
 * The set of arguments for constructing a ServerKey resource.
 */
export interface ServerKeyArgs {
    /**
     * The name of the PostgreSQL Server key to be operated on (updated or created).
     */
    readonly keyName: pulumi.Input<string>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The key type like 'AzureKeyVault'.
     */
    readonly serverKeyType: pulumi.Input<string>;
    /**
     * The name of the server.
     */
    readonly serverName: pulumi.Input<string>;
    /**
     * The URI of the key.
     */
    readonly uri?: pulumi.Input<string>;
}
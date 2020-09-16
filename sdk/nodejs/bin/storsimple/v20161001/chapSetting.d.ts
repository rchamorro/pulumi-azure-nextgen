import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
/**
 * Challenge-Handshake Authentication Protocol (CHAP) setting
 */
export declare class ChapSetting extends pulumi.CustomResource {
    /**
     * Get an existing ChapSetting resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ChapSetting;
    /**
     * Returns true if the given object is an instance of ChapSetting.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    static isInstance(obj: any): obj is ChapSetting;
    /**
     * The name.
     */
    readonly name: pulumi.Output<string>;
    /**
     * The chap password.
     */
    readonly password: pulumi.Output<outputs.storsimple.v20161001.AsymmetricEncryptedSecretResponse>;
    /**
     * The type.
     */
    readonly type: pulumi.Output<string>;
    /**
     * Create a ChapSetting resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ChapSettingArgs, opts?: pulumi.CustomResourceOptions);
    constructor(name: string, state: undefined, opts: pulumi.CustomResourceOptions);
}
/**
 * The set of arguments for constructing a ChapSetting resource.
 */
export interface ChapSettingArgs {
    /**
     * The chap user name.
     */
    readonly chapUserName: pulumi.Input<string>;
    /**
     * The device name.
     */
    readonly deviceName: pulumi.Input<string>;
    /**
     * The manager name
     */
    readonly managerName: pulumi.Input<string>;
    /**
     * The chap password.
     */
    readonly password: pulumi.Input<inputs.storsimple.v20161001.AsymmetricEncryptedSecret>;
    /**
     * The resource group name
     */
    readonly resourceGroupName: pulumi.Input<string>;
}
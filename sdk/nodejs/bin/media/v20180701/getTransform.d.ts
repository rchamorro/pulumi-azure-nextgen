import * as pulumi from "@pulumi/pulumi";
import * as outputs from "../../types/output";
export declare function getTransform(args: GetTransformArgs, opts?: pulumi.InvokeOptions): Promise<GetTransformResult>;
export interface GetTransformArgs {
    /**
     * The Media Services account name.
     */
    readonly accountName: string;
    /**
     * The name of the resource group within the Azure subscription.
     */
    readonly resourceGroupName: string;
    /**
     * The Transform name.
     */
    readonly transformName: string;
}
/**
 * A Transform encapsulates the rules or instructions for generating desired outputs from input media, such as by transcoding or by extracting insights. After the Transform is created, it can be applied to input media by creating Jobs.
 */
export interface GetTransformResult {
    /**
     * The UTC date and time when the Transform was created, in 'YYYY-MM-DDThh:mm:ssZ' format.
     */
    readonly created: string;
    /**
     * An optional verbose description of the Transform.
     */
    readonly description?: string;
    /**
     * The UTC date and time when the Transform was last updated, in 'YYYY-MM-DDThh:mm:ssZ' format.
     */
    readonly lastModified: string;
    /**
     * The name of the resource.
     */
    readonly name: string;
    /**
     * An array of one or more TransformOutputs that the Transform should generate.
     */
    readonly outputs: outputs.media.v20180701.TransformOutputResponse[];
    /**
     * The type of the resource.
     */
    readonly type: string;
}
// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * Issue Comment Contract details.
 * Latest API Version: 2019-12-01.
 */
export class ApiIssueComment extends pulumi.CustomResource {
    /**
     * Get an existing ApiIssueComment resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ApiIssueComment {
        return new ApiIssueComment(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:apimanagement/latest:ApiIssueComment';

    /**
     * Returns true if the given object is an instance of ApiIssueComment.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ApiIssueComment {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ApiIssueComment.__pulumiType;
    }

    /**
     * Date and time when the comment was created.
     */
    public readonly createdDate!: pulumi.Output<string | undefined>;
    /**
     * Resource name.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Comment text.
     */
    public readonly text!: pulumi.Output<string>;
    /**
     * Resource type for API Management resource.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * A resource identifier for the user who left the comment.
     */
    public readonly userId!: pulumi.Output<string>;

    /**
     * Create a ApiIssueComment resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ApiIssueCommentArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.apiId === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'apiId'");
            }
            if ((!args || args.commentId === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'commentId'");
            }
            if ((!args || args.issueId === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'issueId'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if ((!args || args.serviceName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'serviceName'");
            }
            if ((!args || args.text === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'text'");
            }
            if ((!args || args.userId === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'userId'");
            }
            inputs["apiId"] = args ? args.apiId : undefined;
            inputs["commentId"] = args ? args.commentId : undefined;
            inputs["createdDate"] = args ? args.createdDate : undefined;
            inputs["issueId"] = args ? args.issueId : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["serviceName"] = args ? args.serviceName : undefined;
            inputs["text"] = args ? args.text : undefined;
            inputs["userId"] = args ? args.userId : undefined;
            inputs["name"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["createdDate"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["text"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["userId"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:apimanagement/v20170301:ApiIssueComment" }, { type: "azure-nextgen:apimanagement/v20180101:ApiIssueComment" }, { type: "azure-nextgen:apimanagement/v20180601preview:ApiIssueComment" }, { type: "azure-nextgen:apimanagement/v20190101:ApiIssueComment" }, { type: "azure-nextgen:apimanagement/v20191201:ApiIssueComment" }, { type: "azure-nextgen:apimanagement/v20191201preview:ApiIssueComment" }, { type: "azure-nextgen:apimanagement/v20200601preview:ApiIssueComment" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(ApiIssueComment.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a ApiIssueComment resource.
 */
export interface ApiIssueCommentArgs {
    /**
     * API identifier. Must be unique in the current API Management service instance.
     */
    readonly apiId: pulumi.Input<string>;
    /**
     * Comment identifier within an Issue. Must be unique in the current Issue.
     */
    readonly commentId: pulumi.Input<string>;
    /**
     * Date and time when the comment was created.
     */
    readonly createdDate?: pulumi.Input<string>;
    /**
     * Issue identifier. Must be unique in the current API Management service instance.
     */
    readonly issueId: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the API Management service.
     */
    readonly serviceName: pulumi.Input<string>;
    /**
     * Comment text.
     */
    readonly text: pulumi.Input<string>;
    /**
     * A resource identifier for the user who left the comment.
     */
    readonly userId: pulumi.Input<string>;
}

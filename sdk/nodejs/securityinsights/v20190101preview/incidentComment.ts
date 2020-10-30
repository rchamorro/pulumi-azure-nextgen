// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

/**
 * Represents an incident comment
 */
export class IncidentComment extends pulumi.CustomResource {
    /**
     * Get an existing IncidentComment resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): IncidentComment {
        return new IncidentComment(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:securityinsights/v20190101preview:IncidentComment';

    /**
     * Returns true if the given object is an instance of IncidentComment.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is IncidentComment {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === IncidentComment.__pulumiType;
    }

    /**
     * Describes the client that created the comment
     */
    public /*out*/ readonly author!: pulumi.Output<outputs.securityinsights.v20190101preview.ClientInfoResponse>;
    /**
     * The time the comment was created
     */
    public /*out*/ readonly createdTimeUtc!: pulumi.Output<string>;
    /**
     * Etag of the azure resource
     */
    public readonly etag!: pulumi.Output<string | undefined>;
    /**
     * The time the comment was updated
     */
    public /*out*/ readonly lastModifiedTimeUtc!: pulumi.Output<string>;
    /**
     * The comment message
     */
    public readonly message!: pulumi.Output<string>;
    /**
     * Azure resource name
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Azure resource type
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a IncidentComment resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: IncidentCommentArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.incidentCommentId === undefined) {
                throw new Error("Missing required property 'incidentCommentId'");
            }
            if (!args || args.incidentId === undefined) {
                throw new Error("Missing required property 'incidentId'");
            }
            if (!args || args.message === undefined) {
                throw new Error("Missing required property 'message'");
            }
            if (!args || args.operationalInsightsResourceProvider === undefined) {
                throw new Error("Missing required property 'operationalInsightsResourceProvider'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.workspaceName === undefined) {
                throw new Error("Missing required property 'workspaceName'");
            }
            inputs["etag"] = args ? args.etag : undefined;
            inputs["incidentCommentId"] = args ? args.incidentCommentId : undefined;
            inputs["incidentId"] = args ? args.incidentId : undefined;
            inputs["message"] = args ? args.message : undefined;
            inputs["operationalInsightsResourceProvider"] = args ? args.operationalInsightsResourceProvider : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["workspaceName"] = args ? args.workspaceName : undefined;
            inputs["author"] = undefined /*out*/;
            inputs["createdTimeUtc"] = undefined /*out*/;
            inputs["lastModifiedTimeUtc"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["author"] = undefined /*out*/;
            inputs["createdTimeUtc"] = undefined /*out*/;
            inputs["etag"] = undefined /*out*/;
            inputs["lastModifiedTimeUtc"] = undefined /*out*/;
            inputs["message"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(IncidentComment.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a IncidentComment resource.
 */
export interface IncidentCommentArgs {
    /**
     * Etag of the azure resource
     */
    readonly etag?: pulumi.Input<string>;
    /**
     * Incident comment ID
     */
    readonly incidentCommentId: pulumi.Input<string>;
    /**
     * Incident ID
     */
    readonly incidentId: pulumi.Input<string>;
    /**
     * The comment message
     */
    readonly message: pulumi.Input<string>;
    /**
     * The namespace of workspaces resource provider- Microsoft.OperationalInsights.
     */
    readonly operationalInsightsResourceProvider: pulumi.Input<string>;
    /**
     * The name of the resource group within the user's subscription. The name is case insensitive.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the workspace.
     */
    readonly workspaceName: pulumi.Input<string>;
}
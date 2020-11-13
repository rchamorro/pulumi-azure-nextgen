// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * The relationship link resource format.
 */
export class RelationshipLink extends pulumi.CustomResource {
    /**
     * Get an existing RelationshipLink resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): RelationshipLink {
        return new RelationshipLink(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:customerinsights/latest:RelationshipLink';

    /**
     * Returns true if the given object is an instance of RelationshipLink.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is RelationshipLink {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === RelationshipLink.__pulumiType;
    }

    /**
     * Localized descriptions for the Relationship Link.
     */
    public readonly description!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Localized display name for the Relationship Link.
     */
    public readonly displayName!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * The InteractionType associated with the Relationship Link.
     */
    public readonly interactionType!: pulumi.Output<string>;
    /**
     * The name of the Relationship Link.
     */
    public /*out*/ readonly linkName!: pulumi.Output<string>;
    /**
     * The mappings between Interaction and Relationship fields.
     */
    public readonly mappings!: pulumi.Output<outputs.customerinsights.latest.RelationshipLinkFieldMappingResponse[] | undefined>;
    /**
     * Resource name.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The property references for the Profile of the Relationship.
     */
    public readonly profilePropertyReferences!: pulumi.Output<outputs.customerinsights.latest.ParticipantProfilePropertyReferenceResponse[]>;
    /**
     * Provisioning state.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * The property references for the Related Profile of the Relationship.
     */
    public readonly relatedProfilePropertyReferences!: pulumi.Output<outputs.customerinsights.latest.ParticipantProfilePropertyReferenceResponse[]>;
    /**
     * The relationship guid id.
     */
    public /*out*/ readonly relationshipGuidId!: pulumi.Output<string>;
    /**
     * The Relationship associated with the Link.
     */
    public readonly relationshipName!: pulumi.Output<string>;
    /**
     * The hub name.
     */
    public /*out*/ readonly tenantId!: pulumi.Output<string>;
    /**
     * Resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a RelationshipLink resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: RelationshipLinkArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.hubName === undefined) {
                throw new Error("Missing required property 'hubName'");
            }
            if (!args || args.interactionType === undefined) {
                throw new Error("Missing required property 'interactionType'");
            }
            if (!args || args.profilePropertyReferences === undefined) {
                throw new Error("Missing required property 'profilePropertyReferences'");
            }
            if (!args || args.relatedProfilePropertyReferences === undefined) {
                throw new Error("Missing required property 'relatedProfilePropertyReferences'");
            }
            if (!args || args.relationshipLinkName === undefined) {
                throw new Error("Missing required property 'relationshipLinkName'");
            }
            if (!args || args.relationshipName === undefined) {
                throw new Error("Missing required property 'relationshipName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["description"] = args ? args.description : undefined;
            inputs["displayName"] = args ? args.displayName : undefined;
            inputs["hubName"] = args ? args.hubName : undefined;
            inputs["interactionType"] = args ? args.interactionType : undefined;
            inputs["mappings"] = args ? args.mappings : undefined;
            inputs["profilePropertyReferences"] = args ? args.profilePropertyReferences : undefined;
            inputs["relatedProfilePropertyReferences"] = args ? args.relatedProfilePropertyReferences : undefined;
            inputs["relationshipLinkName"] = args ? args.relationshipLinkName : undefined;
            inputs["relationshipName"] = args ? args.relationshipName : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["linkName"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["relationshipGuidId"] = undefined /*out*/;
            inputs["tenantId"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["description"] = undefined /*out*/;
            inputs["displayName"] = undefined /*out*/;
            inputs["interactionType"] = undefined /*out*/;
            inputs["linkName"] = undefined /*out*/;
            inputs["mappings"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["profilePropertyReferences"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["relatedProfilePropertyReferences"] = undefined /*out*/;
            inputs["relationshipGuidId"] = undefined /*out*/;
            inputs["relationshipName"] = undefined /*out*/;
            inputs["tenantId"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:customerinsights/v20170101:RelationshipLink" }, { type: "azure-nextgen:customerinsights/v20170426:RelationshipLink" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(RelationshipLink.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a RelationshipLink resource.
 */
export interface RelationshipLinkArgs {
    /**
     * Localized descriptions for the Relationship Link.
     */
    readonly description?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Localized display name for the Relationship Link.
     */
    readonly displayName?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The name of the hub.
     */
    readonly hubName: pulumi.Input<string>;
    /**
     * The InteractionType associated with the Relationship Link.
     */
    readonly interactionType: pulumi.Input<string>;
    /**
     * The mappings between Interaction and Relationship fields.
     */
    readonly mappings?: pulumi.Input<pulumi.Input<inputs.customerinsights.latest.RelationshipLinkFieldMapping>[]>;
    /**
     * The property references for the Profile of the Relationship.
     */
    readonly profilePropertyReferences: pulumi.Input<pulumi.Input<inputs.customerinsights.latest.ParticipantProfilePropertyReference>[]>;
    /**
     * The property references for the Related Profile of the Relationship.
     */
    readonly relatedProfilePropertyReferences: pulumi.Input<pulumi.Input<inputs.customerinsights.latest.ParticipantProfilePropertyReference>[]>;
    /**
     * The name of the relationship link.
     */
    readonly relationshipLinkName: pulumi.Input<string>;
    /**
     * The Relationship associated with the Link.
     */
    readonly relationshipName: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
}

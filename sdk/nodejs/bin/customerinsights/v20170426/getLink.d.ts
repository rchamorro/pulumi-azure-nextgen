import * as pulumi from "@pulumi/pulumi";
import * as outputs from "../../types/output";
export declare function getLink(args: GetLinkArgs, opts?: pulumi.InvokeOptions): Promise<GetLinkResult>;
export interface GetLinkArgs {
    /**
     * The name of the hub.
     */
    readonly hubName: string;
    /**
     * The name of the link.
     */
    readonly linkName: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
}
/**
 * The link resource format.
 */
export interface GetLinkResult {
    /**
     * Localized descriptions for the Link.
     */
    readonly description?: {
        [key: string]: string;
    };
    /**
     * Localized display name for the Link.
     */
    readonly displayName?: {
        [key: string]: string;
    };
    /**
     * The link name.
     */
    readonly linkName: string;
    /**
     * The set of properties mappings between the source and target Types.
     */
    readonly mappings?: outputs.customerinsights.v20170426.TypePropertiesMappingResponse[];
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * Determines whether this link is supposed to create or delete instances if Link is NOT Reference Only.
     */
    readonly operationType?: string;
    /**
     * The properties that represent the participating profile.
     */
    readonly participantPropertyReferences: outputs.customerinsights.v20170426.ParticipantPropertyReferenceResponse[];
    /**
     * Provisioning state.
     */
    readonly provisioningState: string;
    /**
     * Indicating whether the link is reference only link. This flag is ignored if the Mappings are defined. If the mappings are not defined and it is set to true, links processing will not create or update profiles.
     */
    readonly referenceOnly?: boolean;
    /**
     * Type of source entity.
     */
    readonly sourceEntityType: string;
    /**
     * Name of the source Entity Type.
     */
    readonly sourceEntityTypeName: string;
    /**
     * Type of target entity.
     */
    readonly targetEntityType: string;
    /**
     * Name of the target Entity Type.
     */
    readonly targetEntityTypeName: string;
    /**
     * The hub name.
     */
    readonly tenantId: string;
    /**
     * Resource type.
     */
    readonly type: string;
}
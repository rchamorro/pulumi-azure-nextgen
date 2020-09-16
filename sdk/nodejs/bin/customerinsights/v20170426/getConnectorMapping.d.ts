import * as pulumi from "@pulumi/pulumi";
import * as outputs from "../../types/output";
export declare function getConnectorMapping(args: GetConnectorMappingArgs, opts?: pulumi.InvokeOptions): Promise<GetConnectorMappingResult>;
export interface GetConnectorMappingArgs {
    /**
     * The name of the connector.
     */
    readonly connectorName: string;
    /**
     * The name of the hub.
     */
    readonly hubName: string;
    /**
     * The name of the connector mapping.
     */
    readonly mappingName: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
}
/**
 * The connector mapping resource format.
 */
export interface GetConnectorMappingResult {
    /**
     * The connector mapping name
     */
    readonly connectorMappingName: string;
    /**
     * The connector name.
     */
    readonly connectorName: string;
    /**
     * Type of connector.
     */
    readonly connectorType?: string;
    /**
     * The created time.
     */
    readonly created: string;
    /**
     * The DataFormat ID.
     */
    readonly dataFormatId: string;
    /**
     * The description of the connector mapping.
     */
    readonly description?: string;
    /**
     * Display name for the connector mapping.
     */
    readonly displayName?: string;
    /**
     * Defines which entity type the file should map to.
     */
    readonly entityType: string;
    /**
     * The mapping entity name.
     */
    readonly entityTypeName: string;
    /**
     * The last modified time.
     */
    readonly lastModified: string;
    /**
     * The properties of the mapping.
     */
    readonly mappingProperties: outputs.customerinsights.v20170426.ConnectorMappingPropertiesResponse;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * The next run time based on customer's settings.
     */
    readonly nextRunTime: string;
    /**
     * The RunId.
     */
    readonly runId: string;
    /**
     * State of connector mapping.
     */
    readonly state: string;
    /**
     * The hub name.
     */
    readonly tenantId: string;
    /**
     * Resource type.
     */
    readonly type: string;
}
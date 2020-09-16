import * as pulumi from "@pulumi/pulumi";
export declare function getFavorite(args: GetFavoriteArgs, opts?: pulumi.InvokeOptions): Promise<GetFavoriteResult>;
export interface GetFavoriteArgs {
    /**
     * The Id of a specific favorite defined in the Application Insights component
     */
    readonly favoriteId: string;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the Application Insights component resource.
     */
    readonly resourceName: string;
}
/**
 * Properties that define a favorite that is associated to an Application Insights component.
 */
export interface GetFavoriteResult {
    /**
     * Favorite category, as defined by the user at creation time.
     */
    readonly category?: string;
    /**
     * Configuration of this particular favorite, which are driven by the Azure portal UX. Configuration data is a string containing valid JSON
     */
    readonly config?: string;
    /**
     * Internally assigned unique id of the favorite definition.
     */
    readonly favoriteId: string;
    /**
     * Enum indicating if this favorite definition is owned by a specific user or is shared between all users with access to the Application Insights component.
     */
    readonly favoriteType?: string;
    /**
     * Flag denoting wether or not this favorite was generated from a template.
     */
    readonly isGeneratedFromTemplate?: boolean;
    /**
     * The user-defined name of the favorite.
     */
    readonly name?: string;
    /**
     * The source of the favorite definition.
     */
    readonly sourceType?: string;
    /**
     * A list of 0 or more tags that are associated with this favorite definition
     */
    readonly tags?: string[];
    /**
     * Date and time in UTC of the last modification that was made to this favorite definition.
     */
    readonly timeModified: string;
    /**
     * Unique user id of the specific user that owns this favorite.
     */
    readonly userId: string;
    /**
     * This instance's version of the data model. This can change as new features are added that can be marked favorite. Current examples include MetricsExplorer (ME) and Search.
     */
    readonly version?: string;
}
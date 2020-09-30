// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * Azure Migrate Project.
 */
export class Project extends pulumi.CustomResource {
    /**
     * Get an existing Project resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Project {
        return new Project(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:migrate/v20171111preview:Project';

    /**
     * Returns true if the given object is an instance of Project.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Project {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Project.__pulumiType;
    }

    /**
     * Time when this project was created. Date-Time represented in ISO-8601 format.
     */
    public /*out*/ readonly createdTimestamp!: pulumi.Output<string>;
    /**
     * ARM ID of the Service Map workspace created by user.
     */
    public readonly customerWorkspaceId!: pulumi.Output<string | undefined>;
    /**
     * Reports whether project is under discovery.
     */
    public /*out*/ readonly discoveryStatus!: pulumi.Output<string>;
    /**
     * For optimistic concurrency control.
     */
    public readonly eTag!: pulumi.Output<string | undefined>;
    /**
     * Azure location in which project is created.
     */
    public readonly location!: pulumi.Output<string | undefined>;
    /**
     * Name of the project.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Number of assessments created in the project.
     */
    public /*out*/ readonly numberOfAssessments!: pulumi.Output<number>;
    /**
     * Number of groups created in the project.
     */
    public /*out*/ readonly numberOfGroups!: pulumi.Output<number>;
    /**
     * Number of machines in the project.
     */
    public /*out*/ readonly numberOfMachines!: pulumi.Output<number>;
    /**
     * Provisioning state of the project.
     */
    public readonly provisioningState!: pulumi.Output<string | undefined>;
    /**
     * Tags provided by Azure Tagging service.
     */
    public readonly tags!: pulumi.Output<any | undefined>;
    /**
     * Type of the object = [Microsoft.Migrate/projects].
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * Time when this project was last updated. Date-Time represented in ISO-8601 format.
     */
    public /*out*/ readonly updatedTimestamp!: pulumi.Output<string>;

    /**
     * Create a Project resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ProjectArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.projectName === undefined) {
                throw new Error("Missing required property 'projectName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["customerWorkspaceId"] = args ? args.customerWorkspaceId : undefined;
            inputs["eTag"] = args ? args.eTag : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["projectName"] = args ? args.projectName : undefined;
            inputs["provisioningState"] = args ? args.provisioningState : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["createdTimestamp"] = undefined /*out*/;
            inputs["discoveryStatus"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["numberOfAssessments"] = undefined /*out*/;
            inputs["numberOfGroups"] = undefined /*out*/;
            inputs["numberOfMachines"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["updatedTimestamp"] = undefined /*out*/;
        } else {
            inputs["createdTimestamp"] = undefined /*out*/;
            inputs["customerWorkspaceId"] = undefined /*out*/;
            inputs["discoveryStatus"] = undefined /*out*/;
            inputs["eTag"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["numberOfAssessments"] = undefined /*out*/;
            inputs["numberOfGroups"] = undefined /*out*/;
            inputs["numberOfMachines"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["updatedTimestamp"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:migrate/v20180202:Project" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(Project.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Project resource.
 */
export interface ProjectArgs {
    /**
     * ARM ID of the Service Map workspace created by user.
     */
    readonly customerWorkspaceId?: pulumi.Input<string>;
    /**
     * For optimistic concurrency control.
     */
    readonly eTag?: pulumi.Input<string>;
    /**
     * Azure location in which project is created.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * Name of the Azure Migrate project.
     */
    readonly projectName: pulumi.Input<string>;
    /**
     * Provisioning state of the project.
     */
    readonly provisioningState?: pulumi.Input<string>;
    /**
     * Name of the Azure Resource Group that project is part of.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Tags provided by Azure Tagging service.
     */
    readonly tags?: any;
}

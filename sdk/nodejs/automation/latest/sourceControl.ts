// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Definition of the source control.
 * Latest API Version: 2019-06-01.
 */
export class SourceControl extends pulumi.CustomResource {
    /**
     * Get an existing SourceControl resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): SourceControl {
        return new SourceControl(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:automation/latest:SourceControl';

    /**
     * Returns true if the given object is an instance of SourceControl.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is SourceControl {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === SourceControl.__pulumiType;
    }

    /**
     * The auto sync of the source control. Default is false.
     */
    public readonly autoSync!: pulumi.Output<boolean | undefined>;
    /**
     * The repo branch of the source control. Include branch as empty string for VsoTfvc.
     */
    public readonly branch!: pulumi.Output<string | undefined>;
    /**
     * The creation time.
     */
    public /*out*/ readonly creationTime!: pulumi.Output<string | undefined>;
    /**
     * The description.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * The folder path of the source control.
     */
    public readonly folderPath!: pulumi.Output<string | undefined>;
    /**
     * The last modified time.
     */
    public /*out*/ readonly lastModifiedTime!: pulumi.Output<string | undefined>;
    /**
     * The name of the resource
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The auto publish of the source control. Default is true.
     */
    public readonly publishRunbook!: pulumi.Output<boolean | undefined>;
    /**
     * The repo url of the source control.
     */
    public readonly repoUrl!: pulumi.Output<string | undefined>;
    /**
     * The source type. Must be one of VsoGit, VsoTfvc, GitHub.
     */
    public readonly sourceType!: pulumi.Output<string | undefined>;
    /**
     * The type of the resource.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a SourceControl resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: SourceControlArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.automationAccountName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'automationAccountName'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if ((!args || args.sourceControlName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'sourceControlName'");
            }
            inputs["autoSync"] = args ? args.autoSync : undefined;
            inputs["automationAccountName"] = args ? args.automationAccountName : undefined;
            inputs["branch"] = args ? args.branch : undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["folderPath"] = args ? args.folderPath : undefined;
            inputs["publishRunbook"] = args ? args.publishRunbook : undefined;
            inputs["repoUrl"] = args ? args.repoUrl : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["securityToken"] = args ? args.securityToken : undefined;
            inputs["sourceControlName"] = args ? args.sourceControlName : undefined;
            inputs["sourceType"] = args ? args.sourceType : undefined;
            inputs["creationTime"] = undefined /*out*/;
            inputs["lastModifiedTime"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["autoSync"] = undefined /*out*/;
            inputs["branch"] = undefined /*out*/;
            inputs["creationTime"] = undefined /*out*/;
            inputs["description"] = undefined /*out*/;
            inputs["folderPath"] = undefined /*out*/;
            inputs["lastModifiedTime"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["publishRunbook"] = undefined /*out*/;
            inputs["repoUrl"] = undefined /*out*/;
            inputs["sourceType"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:automation/v20170515preview:SourceControl" }, { type: "azure-nextgen:automation/v20190601:SourceControl" }, { type: "azure-nextgen:automation/v20200113preview:SourceControl" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(SourceControl.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a SourceControl resource.
 */
export interface SourceControlArgs {
    /**
     * The auto async of the source control. Default is false.
     */
    readonly autoSync?: pulumi.Input<boolean>;
    /**
     * The name of the automation account.
     */
    readonly automationAccountName: pulumi.Input<string>;
    /**
     * The repo branch of the source control. Include branch as empty string for VsoTfvc.
     */
    readonly branch?: pulumi.Input<string>;
    /**
     * The user description of the source control.
     */
    readonly description?: pulumi.Input<string>;
    /**
     * The folder path of the source control. Path must be relative.
     */
    readonly folderPath?: pulumi.Input<string>;
    /**
     * The auto publish of the source control. Default is true.
     */
    readonly publishRunbook?: pulumi.Input<boolean>;
    /**
     * The repo url of the source control.
     */
    readonly repoUrl?: pulumi.Input<string>;
    /**
     * Name of an Azure Resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The authorization token for the repo of the source control.
     */
    readonly securityToken?: pulumi.Input<inputs.automation.latest.SourceControlSecurityTokenProperties>;
    /**
     * The source control name.
     */
    readonly sourceControlName: pulumi.Input<string>;
    /**
     * The source type. Must be one of VsoGit, VsoTfvc, GitHub, case sensitive.
     */
    readonly sourceType?: pulumi.Input<string | enums.automation.latest.SourceType>;
}

// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Contains information about the job.
 */
export class Job extends pulumi.CustomResource {
    /**
     * Get an existing Job resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Job {
        return new Job(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:batchai/v20170901preview:Job';

    /**
     * Returns true if the given object is an instance of Job.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Job {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Job.__pulumiType;
    }

    /**
     * Specifies the settings for Caffe job.
     */
    public readonly caffeSettings!: pulumi.Output<outputs.batchai.v20170901preview.CaffeSettingsResponse | undefined>;
    /**
     * Specifies the settings for Chainer job.
     */
    public readonly chainerSettings!: pulumi.Output<outputs.batchai.v20170901preview.ChainerSettingsResponse | undefined>;
    /**
     * Represents a resource ID. For example, for a subnet, it is the resource URL for the subnet.
     */
    public readonly cluster!: pulumi.Output<outputs.batchai.v20170901preview.ResourceIdResponse | undefined>;
    /**
     * Specifies the settings for CNTK (aka Microsoft Cognitive Toolkit) job.
     */
    public readonly cntkSettings!: pulumi.Output<outputs.batchai.v20170901preview.CNTKsettingsResponse | undefined>;
    /**
     * Constraints associated with the Job.
     */
    public readonly constraints!: pulumi.Output<outputs.batchai.v20170901preview.JobPropertiesResponseConstraints | undefined>;
    /**
     * If the container was downloaded as part of cluster setup then the same container image will be used. If not provided, the job will run on the VM.
     */
    public readonly containerSettings!: pulumi.Output<outputs.batchai.v20170901preview.ContainerSettingsResponse | undefined>;
    /**
     * The creation time of the job.
     */
    public /*out*/ readonly creationTime!: pulumi.Output<string>;
    /**
     * Specifies the settings for a custom tool kit job.
     */
    public readonly customToolkitSettings!: pulumi.Output<outputs.batchai.v20170901preview.CustomToolkitSettingsResponse | undefined>;
    /**
     * Batch AI services sets the following environment variables for all jobs: AZ_BATCHAI_INPUT_id, AZ_BATCHAI_OUTPUT_id, AZ_BATCHAI_NUM_GPUS_PER_NODE, For distributed TensorFlow jobs, following additional environment variables are set by the Batch AI Service: AZ_BATCHAI_PS_HOSTS, AZ_BATCHAI_WORKER_HOSTS.
     */
    public readonly environmentVariables!: pulumi.Output<outputs.batchai.v20170901preview.EnvironmentSettingResponse[] | undefined>;
    /**
     * Contains information about the execution of a job in the Azure Batch service.
     */
    public /*out*/ readonly executionInfo!: pulumi.Output<outputs.batchai.v20170901preview.JobPropertiesResponseExecutionInfo | undefined>;
    /**
     * The current state of the job. Possible values are: queued - The job is queued and able to run. A job enters this state when it is created, or when it is awaiting a retry after a failed run. running - The job is running on a compute cluster. This includes job-level preparation such as downloading resource files or set up container specified on the job - it does not necessarily mean that the job command line has started executing. terminating - The job is terminated by the user, the terminate operation is in progress. succeeded - The job has completed running successfully and exited with exit code 0. failed - The job has finished unsuccessfully (failed with a non-zero exit code) and has exhausted its retry limit. A job is also marked as failed if an error occurred launching the job.
     */
    public /*out*/ readonly executionState!: pulumi.Output<string | undefined>;
    /**
     * The time at which the job entered its current execution state.
     */
    public /*out*/ readonly executionStateTransitionTime!: pulumi.Output<string>;
    /**
     * Describe the experiment information of the job
     */
    public readonly experimentName!: pulumi.Output<string | undefined>;
    public readonly inputDirectories!: pulumi.Output<outputs.batchai.v20170901preview.InputDirectoryResponse[] | undefined>;
    /**
     * The specified actions will run on all the nodes that are part of the job
     */
    public readonly jobPreparation!: pulumi.Output<outputs.batchai.v20170901preview.JobPreparationResponse | undefined>;
    /**
     * The location of the resource
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * The name of the resource
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The job will be gang scheduled on that many compute nodes
     */
    public readonly nodeCount!: pulumi.Output<number | undefined>;
    public readonly outputDirectories!: pulumi.Output<outputs.batchai.v20170901preview.OutputDirectoryResponse[] | undefined>;
    /**
     * Priority associated with the job. Priority values can range from -1000 to 1000, with -1000 being the lowest priority and 1000 being the highest priority. The default value is 0.
     */
    public readonly priority!: pulumi.Output<number | undefined>;
    /**
     * The provisioned state of the Batch AI job
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * The time at which the job entered its current provisioning state.
     */
    public /*out*/ readonly provisioningStateTransitionTime!: pulumi.Output<string>;
    /**
     * The path where the Batch AI service will upload stdout and stderror of the job.
     */
    public readonly stdOutErrPathPrefix!: pulumi.Output<string | undefined>;
    /**
     * The tags of the resource
     */
    public readonly tags!: pulumi.Output<{[key: string]: string}>;
    /**
     * Specifies the settings for TensorFlow job.
     */
    public readonly tensorFlowSettings!: pulumi.Output<outputs.batchai.v20170901preview.TensorFlowSettingsResponse | undefined>;
    /**
     * Possible values are: cntk, tensorflow, caffe, caffe2, chainer, custom.
     */
    public /*out*/ readonly toolType!: pulumi.Output<string | undefined>;
    /**
     * The type of the resource
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a Job resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: JobArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.cluster === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'cluster'");
            }
            if ((!args || args.jobName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'jobName'");
            }
            if ((!args || args.location === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'location'");
            }
            if ((!args || args.nodeCount === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'nodeCount'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if ((!args || args.stdOutErrPathPrefix === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'stdOutErrPathPrefix'");
            }
            inputs["caffe2Settings"] = args ? args.caffe2Settings : undefined;
            inputs["caffeSettings"] = args ? args.caffeSettings : undefined;
            inputs["chainerSettings"] = args ? args.chainerSettings : undefined;
            inputs["cluster"] = args ? args.cluster : undefined;
            inputs["cntkSettings"] = args ? args.cntkSettings : undefined;
            inputs["constraints"] = args ? args.constraints : undefined;
            inputs["containerSettings"] = args ? args.containerSettings : undefined;
            inputs["customToolkitSettings"] = args ? args.customToolkitSettings : undefined;
            inputs["environmentVariables"] = args ? args.environmentVariables : undefined;
            inputs["experimentName"] = args ? args.experimentName : undefined;
            inputs["inputDirectories"] = args ? args.inputDirectories : undefined;
            inputs["jobName"] = args ? args.jobName : undefined;
            inputs["jobPreparation"] = args ? args.jobPreparation : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["nodeCount"] = args ? args.nodeCount : undefined;
            inputs["outputDirectories"] = args ? args.outputDirectories : undefined;
            inputs["priority"] = (args ? args.priority : undefined) || 0;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["stdOutErrPathPrefix"] = args ? args.stdOutErrPathPrefix : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["tensorFlowSettings"] = args ? args.tensorFlowSettings : undefined;
            inputs["creationTime"] = undefined /*out*/;
            inputs["executionInfo"] = undefined /*out*/;
            inputs["executionState"] = undefined /*out*/;
            inputs["executionStateTransitionTime"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["provisioningStateTransitionTime"] = undefined /*out*/;
            inputs["toolType"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["caffeSettings"] = undefined /*out*/;
            inputs["chainerSettings"] = undefined /*out*/;
            inputs["cluster"] = undefined /*out*/;
            inputs["cntkSettings"] = undefined /*out*/;
            inputs["constraints"] = undefined /*out*/;
            inputs["containerSettings"] = undefined /*out*/;
            inputs["creationTime"] = undefined /*out*/;
            inputs["customToolkitSettings"] = undefined /*out*/;
            inputs["environmentVariables"] = undefined /*out*/;
            inputs["executionInfo"] = undefined /*out*/;
            inputs["executionState"] = undefined /*out*/;
            inputs["executionStateTransitionTime"] = undefined /*out*/;
            inputs["experimentName"] = undefined /*out*/;
            inputs["inputDirectories"] = undefined /*out*/;
            inputs["jobPreparation"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["nodeCount"] = undefined /*out*/;
            inputs["outputDirectories"] = undefined /*out*/;
            inputs["priority"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["provisioningStateTransitionTime"] = undefined /*out*/;
            inputs["stdOutErrPathPrefix"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["tensorFlowSettings"] = undefined /*out*/;
            inputs["toolType"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:batchai/v20180301:Job" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(Job.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Job resource.
 */
export interface JobArgs {
    /**
     * Specifies the settings for Caffe2 job.
     */
    readonly caffe2Settings?: pulumi.Input<inputs.batchai.v20170901preview.Caffe2Settings>;
    /**
     * Specifies the settings for Caffe job.
     */
    readonly caffeSettings?: pulumi.Input<inputs.batchai.v20170901preview.CaffeSettings>;
    /**
     * Specifies the settings for Chainer job.
     */
    readonly chainerSettings?: pulumi.Input<inputs.batchai.v20170901preview.ChainerSettings>;
    /**
     * Represents a resource ID. For example, for a subnet, it is the resource URL for the subnet.
     */
    readonly cluster: pulumi.Input<inputs.batchai.v20170901preview.ResourceId>;
    /**
     * Specifies the settings for CNTK (aka Microsoft Cognitive Toolkit) job.
     */
    readonly cntkSettings?: pulumi.Input<inputs.batchai.v20170901preview.CNTKsettings>;
    /**
     * Constraints associated with the Job.
     */
    readonly constraints?: pulumi.Input<inputs.batchai.v20170901preview.JobBasePropertiesConstraints>;
    /**
     * If the container was downloaded as part of cluster setup then the same container image will be used. If not provided, the job will run on the VM.
     */
    readonly containerSettings?: pulumi.Input<inputs.batchai.v20170901preview.ContainerSettings>;
    /**
     * Specifies the settings for a custom tool kit job.
     */
    readonly customToolkitSettings?: pulumi.Input<inputs.batchai.v20170901preview.CustomToolkitSettings>;
    /**
     * Batch AI service sets the following environment variables for all jobs: AZ_BATCHAI_INPUT_id, AZ_BATCHAI_OUTPUT_id, AZ_BATCHAI_NUM_GPUS_PER_NODE. For distributed TensorFlow jobs, following additional environment variables are set by the Batch AI Service: AZ_BATCHAI_PS_HOSTS, AZ_BATCHAI_WORKER_HOSTS
     */
    readonly environmentVariables?: pulumi.Input<pulumi.Input<inputs.batchai.v20170901preview.EnvironmentSetting>[]>;
    /**
     * Describe the experiment information of the job
     */
    readonly experimentName?: pulumi.Input<string>;
    readonly inputDirectories?: pulumi.Input<pulumi.Input<inputs.batchai.v20170901preview.InputDirectory>[]>;
    /**
     * The name of the job within the specified resource group. Job names can only contain a combination of alphanumeric characters along with dash (-) and underscore (_). The name must be from 1 through 64 characters long.
     */
    readonly jobName: pulumi.Input<string>;
    /**
     * The specified actions will run on all the nodes that are part of the job
     */
    readonly jobPreparation?: pulumi.Input<inputs.batchai.v20170901preview.JobPreparation>;
    /**
     * The region in which to create the job.
     */
    readonly location: pulumi.Input<string>;
    /**
     * The job will be gang scheduled on that many compute nodes
     */
    readonly nodeCount: pulumi.Input<number>;
    readonly outputDirectories?: pulumi.Input<pulumi.Input<inputs.batchai.v20170901preview.OutputDirectory>[]>;
    /**
     * Priority associated with the job. Priority values can range from -1000 to 1000, with -1000 being the lowest priority and 1000 being the highest priority. The default value is 0.
     */
    readonly priority?: pulumi.Input<number>;
    /**
     * Name of the resource group to which the resource belongs.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The path where the Batch AI service will upload stdout and stderror of the job.
     */
    readonly stdOutErrPathPrefix: pulumi.Input<string>;
    /**
     * The user specified tags associated with the job.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Specifies the settings for TensorFlow job.
     */
    readonly tensorFlowSettings?: pulumi.Input<inputs.batchai.v20170901preview.TensorFlowSettings>;
}

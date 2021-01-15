// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ServiceFabric.V20190301.Inputs
{

    /// <summary>
    /// Defines a health policy used to evaluate the health of an application or one of its children entities.
    /// </summary>
    public sealed class ArmApplicationHealthPolicyArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Indicates whether warnings are treated with the same severity as errors.
        /// </summary>
        [Input("considerWarningAsError")]
        public Input<bool>? ConsiderWarningAsError { get; set; }

        /// <summary>
        /// The health policy used by default to evaluate the health of a service type.
        /// </summary>
        [Input("defaultServiceTypeHealthPolicy")]
        public Input<Inputs.ArmServiceTypeHealthPolicyArgs>? DefaultServiceTypeHealthPolicy { get; set; }

        /// <summary>
        /// The maximum allowed percentage of unhealthy deployed applications. Allowed values are Byte values from zero to 100.
        /// The percentage represents the maximum tolerated percentage of deployed applications that can be unhealthy before the application is considered in error.
        /// This is calculated by dividing the number of unhealthy deployed applications over the number of nodes where the application is currently deployed on in the cluster.
        /// The computation rounds up to tolerate one failure on small numbers of nodes. Default percentage is zero.
        /// </summary>
        [Input("maxPercentUnhealthyDeployedApplications")]
        public Input<int>? MaxPercentUnhealthyDeployedApplications { get; set; }

        [Input("serviceTypeHealthPolicyMap")]
        private InputMap<Inputs.ArmServiceTypeHealthPolicyArgs>? _serviceTypeHealthPolicyMap;

        /// <summary>
        /// The map with service type health policy per service type name. The map is empty by default.
        /// </summary>
        public InputMap<Inputs.ArmServiceTypeHealthPolicyArgs> ServiceTypeHealthPolicyMap
        {
            get => _serviceTypeHealthPolicyMap ?? (_serviceTypeHealthPolicyMap = new InputMap<Inputs.ArmServiceTypeHealthPolicyArgs>());
            set => _serviceTypeHealthPolicyMap = value;
        }

        public ArmApplicationHealthPolicyArgs()
        {
            ConsiderWarningAsError = false;
            MaxPercentUnhealthyDeployedApplications = 0;
        }
    }
}

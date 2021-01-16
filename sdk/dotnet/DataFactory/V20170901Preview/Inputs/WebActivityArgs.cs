// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.V20170901Preview.Inputs
{

    /// <summary>
    /// Web activity.
    /// </summary>
    public sealed class WebActivityArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Authentication method used for calling the endpoint.
        /// </summary>
        [Input("authentication")]
        public Input<Inputs.WebActivityAuthenticationArgs>? Authentication { get; set; }

        /// <summary>
        /// Represents the payload that will be sent to the endpoint. Required for POST/PUT method, not allowed for GET method Type: string (or Expression with resultType string).
        /// </summary>
        [Input("body")]
        public Input<object>? Body { get; set; }

        [Input("datasets")]
        private InputList<Inputs.DatasetReferenceArgs>? _datasets;

        /// <summary>
        /// List of datasets passed to web endpoint.
        /// </summary>
        public InputList<Inputs.DatasetReferenceArgs> Datasets
        {
            get => _datasets ?? (_datasets = new InputList<Inputs.DatasetReferenceArgs>());
            set => _datasets = value;
        }

        [Input("dependsOn")]
        private InputList<Inputs.ActivityDependencyArgs>? _dependsOn;

        /// <summary>
        /// Activity depends on condition.
        /// </summary>
        public InputList<Inputs.ActivityDependencyArgs> DependsOn
        {
            get => _dependsOn ?? (_dependsOn = new InputList<Inputs.ActivityDependencyArgs>());
            set => _dependsOn = value;
        }

        /// <summary>
        /// Activity description.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Represents the headers that will be sent to the request. For example, to set the language and type on a request: "headers" : { "Accept-Language": "en-us", "Content-Type": "application/json" }. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("headers")]
        public Input<object>? Headers { get; set; }

        /// <summary>
        /// Linked service reference.
        /// </summary>
        [Input("linkedServiceName")]
        public Input<Inputs.LinkedServiceReferenceArgs>? LinkedServiceName { get; set; }

        [Input("linkedServices")]
        private InputList<Inputs.LinkedServiceReferenceArgs>? _linkedServices;

        /// <summary>
        /// List of linked services passed to web endpoint.
        /// </summary>
        public InputList<Inputs.LinkedServiceReferenceArgs> LinkedServices
        {
            get => _linkedServices ?? (_linkedServices = new InputList<Inputs.LinkedServiceReferenceArgs>());
            set => _linkedServices = value;
        }

        /// <summary>
        /// Rest API method for target endpoint.
        /// </summary>
        [Input("method", required: true)]
        public InputUnion<string, Pulumi.AzureNextGen.DataFactory.V20170901Preview.WebActivityMethod> Method { get; set; } = null!;

        /// <summary>
        /// Activity name.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Activity policy.
        /// </summary>
        [Input("policy")]
        public Input<Inputs.ActivityPolicyArgs>? Policy { get; set; }

        /// <summary>
        /// Type of activity.
        /// Expected value is 'Execution'.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        /// <summary>
        /// Web activity target endpoint and path. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("url", required: true)]
        public Input<object> Url { get; set; } = null!;

        public WebActivityArgs()
        {
        }
    }
}

// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.MachineLearning.V20160501Preview.Outputs
{

    [OutputType]
    public sealed class ExampleRequestResponse
    {
        /// <summary>
        /// Sample input data for the web service's global parameters
        /// </summary>
        public readonly ImmutableDictionary<string, object>? GlobalParameters;
        /// <summary>
        /// Sample input data for the web service's input(s) given as an input name to sample input values matrix map.
        /// </summary>
        public readonly ImmutableDictionary<string, ImmutableArray<ImmutableArray<object>>>? Inputs;

        [OutputConstructor]
        private ExampleRequestResponse(
            ImmutableDictionary<string, object>? globalParameters,

            ImmutableDictionary<string, ImmutableArray<ImmutableArray<object>>>? inputs)
        {
            GlobalParameters = globalParameters;
            Inputs = inputs;
        }
    }
}

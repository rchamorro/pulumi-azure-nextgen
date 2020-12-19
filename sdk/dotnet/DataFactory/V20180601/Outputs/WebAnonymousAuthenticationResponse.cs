// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.V20180601.Outputs
{

    [OutputType]
    public sealed class WebAnonymousAuthenticationResponse
    {
        /// <summary>
        /// Type of authentication used to connect to the web table source.
        /// Expected value is 'Anonymous'.
        /// </summary>
        public readonly string AuthenticationType;
        /// <summary>
        /// The URL of the web service endpoint, e.g. http://www.microsoft.com . Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object Url;

        [OutputConstructor]
        private WebAnonymousAuthenticationResponse(
            string authenticationType,

            object url)
        {
            AuthenticationType = authenticationType;
            Url = url;
        }
    }
}

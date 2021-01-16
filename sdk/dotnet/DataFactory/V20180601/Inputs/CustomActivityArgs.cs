// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.V20180601.Inputs
{

    /// <summary>
    /// Custom activity type.
    /// </summary>
    public sealed class CustomActivityArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Command for custom activity Type: string (or Expression with resultType string).
        /// </summary>
        [Input("command", required: true)]
        public Input<object> Command { get; set; } = null!;

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

        [Input("extendedProperties")]
        private InputMap<object>? _extendedProperties;

        /// <summary>
        /// User defined property bag. There is no restriction on the keys or values that can be used. The user specified custom activity has the full responsibility to consume and interpret the content defined.
        /// </summary>
        public InputMap<object> ExtendedProperties
        {
            get => _extendedProperties ?? (_extendedProperties = new InputMap<object>());
            set => _extendedProperties = value;
        }

        /// <summary>
        /// Folder path for resource files Type: string (or Expression with resultType string).
        /// </summary>
        [Input("folderPath")]
        public Input<object>? FolderPath { get; set; }

        /// <summary>
        /// Linked service reference.
        /// </summary>
        [Input("linkedServiceName")]
        public Input<Inputs.LinkedServiceReferenceArgs>? LinkedServiceName { get; set; }

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
        /// Reference objects
        /// </summary>
        [Input("referenceObjects")]
        public Input<Inputs.CustomActivityReferenceObjectArgs>? ReferenceObjects { get; set; }

        /// <summary>
        /// Resource linked service reference.
        /// </summary>
        [Input("resourceLinkedService")]
        public Input<Inputs.LinkedServiceReferenceArgs>? ResourceLinkedService { get; set; }

        /// <summary>
        /// The retention time for the files submitted for custom activity. Type: double (or Expression with resultType double).
        /// </summary>
        [Input("retentionTimeInDays")]
        public Input<object>? RetentionTimeInDays { get; set; }

        /// <summary>
        /// Type of activity.
        /// Expected value is 'Execution'.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        [Input("userProperties")]
        private InputList<Inputs.UserPropertyArgs>? _userProperties;

        /// <summary>
        /// Activity user properties.
        /// </summary>
        public InputList<Inputs.UserPropertyArgs> UserProperties
        {
            get => _userProperties ?? (_userProperties = new InputList<Inputs.UserPropertyArgs>());
            set => _userProperties = value;
        }

        public CustomActivityArgs()
        {
        }
    }
}

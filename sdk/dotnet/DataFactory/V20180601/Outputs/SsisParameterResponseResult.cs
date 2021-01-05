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
    public sealed class SsisParameterResponseResult
    {
        /// <summary>
        /// Parameter type.
        /// </summary>
        public readonly string? DataType;
        /// <summary>
        /// Default value of parameter.
        /// </summary>
        public readonly string? DefaultValue;
        /// <summary>
        /// Parameter description.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// Design default value of parameter.
        /// </summary>
        public readonly string? DesignDefaultValue;
        /// <summary>
        /// Parameter id.
        /// </summary>
        public readonly double? Id;
        /// <summary>
        /// Parameter name.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Whether parameter is required.
        /// </summary>
        public readonly bool? Required;
        /// <summary>
        /// Whether parameter is sensitive.
        /// </summary>
        public readonly bool? Sensitive;
        /// <summary>
        /// Default sensitive value of parameter.
        /// </summary>
        public readonly string? SensitiveDefaultValue;
        /// <summary>
        /// Parameter value set.
        /// </summary>
        public readonly bool? ValueSet;
        /// <summary>
        /// Parameter value type.
        /// </summary>
        public readonly string? ValueType;
        /// <summary>
        /// Parameter reference variable.
        /// </summary>
        public readonly string? Variable;

        [OutputConstructor]
        private SsisParameterResponseResult(
            string? dataType,

            string? defaultValue,

            string? description,

            string? designDefaultValue,

            double? id,

            string? name,

            bool? required,

            bool? sensitive,

            string? sensitiveDefaultValue,

            bool? valueSet,

            string? valueType,

            string? variable)
        {
            DataType = dataType;
            DefaultValue = defaultValue;
            Description = description;
            DesignDefaultValue = designDefaultValue;
            Id = id;
            Name = name;
            Required = required;
            Sensitive = sensitive;
            SensitiveDefaultValue = sensitiveDefaultValue;
            ValueSet = valueSet;
            ValueType = valueType;
            Variable = variable;
        }
    }
}

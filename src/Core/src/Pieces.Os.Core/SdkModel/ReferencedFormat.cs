/*
 * Pieces Isomorphic OpenAPI
 *
 * Endpoints for Assets, Formats, Users, Asset, Format, User.
 *
 * The version of the OpenAPI document: 1.0
 * Contact: tsavo@pieces.app
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Pieces.Os.Core.Client.OpenAPIDateConverter;

namespace Pieces.Os.Core.SdkModel
{
    /// <summary>
    /// A reference to a format which at minimum must have the format&#39;s id. But in the case of a hydrated client API it may have a populated reference of type Format.
    /// </summary>
    [DataContract(Name = "ReferencedFormat")]
    public partial class ReferencedFormat : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReferencedFormat" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReferencedFormat() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReferencedFormat" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="id">The id of the Format (required).</param>
        /// <param name="reference">reference.</param>
        public ReferencedFormat(EmbeddedModelSchema schema = default(EmbeddedModelSchema), string id = default(string), FlattenedFormat reference = default(FlattenedFormat))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for ReferencedFormat and cannot be null");
            }
            this.Id = id;
            this.Schema = schema;
            this.Reference = reference;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// The id of the Format
        /// </summary>
        /// <value>The id of the Format</value>
        /*
        <example>102ff265-fdfb-4142-8d94-4932d400199c</example>
        */
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public FlattenedFormat Reference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReferencedFormat {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

            /// <summary>
            /// To validate all properties of the instance
            /// </summary>
            /// <param name="validationContext">Validation context</param>
            /// <returns>Validation Result</returns>
            IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
            {
            yield break;
        }
    }

}

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
    /// SeededRangeConversationAssociation
    /// </summary>
    [DataContract(Name = "SeededRangeConversationAssociation")]
    public partial class SeededRangeConversationAssociation : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SeededRangeConversationAssociation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SeededRangeConversationAssociation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SeededRangeConversationAssociation" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="reference">reference (required).</param>
        /// <param name="grounding">grounding.</param>
        public SeededRangeConversationAssociation(EmbeddedModelSchema schema = default(EmbeddedModelSchema), ReferencedConversation reference = default(ReferencedConversation), SeededRangeConversationGroundingAssociation grounding = default(SeededRangeConversationGroundingAssociation))
        {
            // to ensure "reference" is required (not null)
            if (reference == null)
            {
                throw new ArgumentNullException("reference is a required property for SeededRangeConversationAssociation and cannot be null");
            }
            this.Reference = reference;
            this.Schema = schema;
            this.Grounding = grounding;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name = "reference", IsRequired = true, EmitDefaultValue = true)]
        public ReferencedConversation Reference { get; set; }

        /// <summary>
        /// Gets or Sets Grounding
        /// </summary>
        [DataMember(Name = "grounding", EmitDefaultValue = false)]
        public SeededRangeConversationGroundingAssociation Grounding { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SeededRangeConversationAssociation {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Grounding: ").Append(Grounding).Append("\n");
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

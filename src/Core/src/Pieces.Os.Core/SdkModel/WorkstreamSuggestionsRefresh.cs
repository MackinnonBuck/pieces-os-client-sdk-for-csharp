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
    /// This will return the new refreshed suggestions, about what data changed, and the data that was used to bias the suggestions.
    /// </summary>
    [DataContract(Name = "WorkstreamSuggestionsRefresh")]
    public partial class WorkstreamSuggestionsRefresh : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkstreamSuggestionsRefresh" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorkstreamSuggestionsRefresh() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkstreamSuggestionsRefresh" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="suggestions">suggestions (required).</param>
        public WorkstreamSuggestionsRefresh(EmbeddedModelSchema schema = default(EmbeddedModelSchema), WorkstreamSuggestions suggestions = default(WorkstreamSuggestions))
        {
            // to ensure "suggestions" is required (not null)
            if (suggestions == null)
            {
                throw new ArgumentNullException("suggestions is a required property for WorkstreamSuggestionsRefresh and cannot be null");
            }
            this.Suggestions = suggestions;
            this.Schema = schema;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Gets or Sets Suggestions
        /// </summary>
        [DataMember(Name = "suggestions", IsRequired = true, EmitDefaultValue = true)]
        public WorkstreamSuggestions Suggestions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WorkstreamSuggestionsRefresh {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Suggestions: ").Append(Suggestions).Append("\n");
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

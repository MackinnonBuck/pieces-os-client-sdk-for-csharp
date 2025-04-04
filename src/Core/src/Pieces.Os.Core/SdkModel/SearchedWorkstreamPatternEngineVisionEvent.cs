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
    /// This will return a list of the returned events.
    /// </summary>
    [DataContract(Name = "SearchedWorkstreamPatternEngineVisionEvent")]
    public partial class SearchedWorkstreamPatternEngineVisionEvent : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchedWorkstreamPatternEngineVisionEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SearchedWorkstreamPatternEngineVisionEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchedWorkstreamPatternEngineVisionEvent" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="varEvent">varEvent.</param>
        /// <param name="exact">exact.</param>
        /// <param name="similarity">similarity.</param>
        /// <param name="temporal">temporal.</param>
        /// <param name="application">application.</param>
        /// <param name="identifier">This is the uuid of the event. (required).</param>
        public SearchedWorkstreamPatternEngineVisionEvent(EmbeddedModelSchema schema = default(EmbeddedModelSchema), WorkstreamPatternEngineVisionEvent varEvent = default(WorkstreamPatternEngineVisionEvent), bool exact = default(bool), decimal similarity = default(decimal), bool temporal = default(bool), string application = default(string), string identifier = default(string))
        {
            // to ensure "identifier" is required (not null)
            if (identifier == null)
            {
                throw new ArgumentNullException("identifier is a required property for SearchedWorkstreamPatternEngineVisionEvent and cannot be null");
            }
            this.Identifier = identifier;
            this.Schema = schema;
            this.Event = varEvent;
            this.Exact = exact;
            this.Similarity = similarity;
            this.Temporal = temporal;
            this.Application = application;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Gets or Sets Event
        /// </summary>
        [DataMember(Name = "event", EmitDefaultValue = false)]
        public WorkstreamPatternEngineVisionEvent Event { get; set; }

        /// <summary>
        /// Gets or Sets Exact
        /// </summary>
        [DataMember(Name = "exact", EmitDefaultValue = true)]
        public bool Exact { get; set; }

        /// <summary>
        /// Gets or Sets Similarity
        /// </summary>
        [DataMember(Name = "similarity", EmitDefaultValue = false)]
        public decimal Similarity { get; set; }

        /// <summary>
        /// Gets or Sets Temporal
        /// </summary>
        [DataMember(Name = "temporal", EmitDefaultValue = true)]
        public bool Temporal { get; set; }

        /// <summary>
        /// Gets or Sets Application
        /// </summary>
        [DataMember(Name = "application", EmitDefaultValue = false)]
        public string Application { get; set; }

        /// <summary>
        /// This is the uuid of the event.
        /// </summary>
        /// <value>This is the uuid of the event.</value>
        [DataMember(Name = "identifier", IsRequired = true, EmitDefaultValue = true)]
        public string Identifier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SearchedWorkstreamPatternEngineVisionEvent {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Event: ").Append(Event).Append("\n");
            sb.Append("  Exact: ").Append(Exact).Append("\n");
            sb.Append("  Similarity: ").Append(Similarity).Append("\n");
            sb.Append("  Temporal: ").Append(Temporal).Append("\n");
            sb.Append("  Application: ").Append(Application).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
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

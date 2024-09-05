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
    /// This model is used for the output of the /qgpt/related/persons endpoint.  Explanations here is a custom object with key value pairs, when the key is the personUUId and the value is an explanation as to why this person was reccommended.
    /// </summary>
    [DataContract(Name = "QGPTPersonsRelatedOutput")]
    public partial class QGPTPersonsRelatedOutput : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QGPTPersonsRelatedOutput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QGPTPersonsRelatedOutput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QGPTPersonsRelatedOutput" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="persons">persons (required).</param>
        /// <param name="explanations">This is a Map&lt;String, String&gt; where the the key is a person id. and the value is the explanation..</param>
        public QGPTPersonsRelatedOutput(EmbeddedModelSchema schema = default(EmbeddedModelSchema), Persons persons = default(Persons), Dictionary<string, string> explanations = default(Dictionary<string, string>))
        {
            // to ensure "persons" is required (not null)
            if (persons == null)
            {
                throw new ArgumentNullException("persons is a required property for QGPTPersonsRelatedOutput and cannot be null");
            }
            this.Persons = persons;
            this.Schema = schema;
            this.Explanations = explanations;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Gets or Sets Persons
        /// </summary>
        [DataMember(Name = "persons", IsRequired = true, EmitDefaultValue = true)]
        public Persons Persons { get; set; }

        /// <summary>
        /// This is a Map&lt;String, String&gt; where the the key is a person id. and the value is the explanation.
        /// </summary>
        /// <value>This is a Map&lt;String, String&gt; where the the key is a person id. and the value is the explanation.</value>
        [DataMember(Name = "explanations", EmitDefaultValue = false)]
        public Dictionary<string, string> Explanations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QGPTPersonsRelatedOutput {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Persons: ").Append(Persons).Append("\n");
            sb.Append("  Explanations: ").Append(Explanations).Append("\n");
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

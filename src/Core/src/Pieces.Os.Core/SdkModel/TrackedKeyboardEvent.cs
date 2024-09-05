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
    /// This is a model that will hold relavent information in relation to a keyboard(including shortcuts) analytics event (usage).
    /// </summary>
    [DataContract(Name = "TrackedKeyboardEvent")]
    public partial class TrackedKeyboardEvent : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackedKeyboardEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TrackedKeyboardEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackedKeyboardEvent" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="description">this is a description of the event, optional. (required).</param>
        /// <param name="shortcut">this is an array of of ascii values that represent numerics on your keyboard. (required).</param>
        public TrackedKeyboardEvent(EmbeddedModelSchema schema = default(EmbeddedModelSchema), string description = default(string), List<int> shortcut = default(List<int>))
        {
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for TrackedKeyboardEvent and cannot be null");
            }
            this.Description = description;
            // to ensure "shortcut" is required (not null)
            if (shortcut == null)
            {
                throw new ArgumentNullException("shortcut is a required property for TrackedKeyboardEvent and cannot be null");
            }
            this.Shortcut = shortcut;
            this.Schema = schema;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// this is a description of the event, optional.
        /// </summary>
        /// <value>this is a description of the event, optional.</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// this is an array of of ascii values that represent numerics on your keyboard.
        /// </summary>
        /// <value>this is an array of of ascii values that represent numerics on your keyboard.</value>
        [DataMember(Name = "shortcut", IsRequired = true, EmitDefaultValue = true)]
        public List<int> Shortcut { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TrackedKeyboardEvent {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Shortcut: ").Append(Shortcut).Append("\n");
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

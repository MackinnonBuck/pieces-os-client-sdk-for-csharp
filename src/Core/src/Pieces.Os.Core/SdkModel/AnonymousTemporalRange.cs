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
    /// if you want a range between you can use from &amp;&amp; to.  if you want anything before, use to and NO from.  if you want anything after, use from and NO to.
    /// </summary>
    [DataContract(Name = "AnonymousTemporalRange")]
    public partial class AnonymousTemporalRange : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnonymousTemporalRange" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="from">from.</param>
        /// <param name="to">to.</param>
        /// <param name="between">between.</param>
        /// <param name="continuous">continuous.</param>
        public AnonymousTemporalRange(EmbeddedModelSchema schema = default(EmbeddedModelSchema), GroupedTimestamp from = default(GroupedTimestamp), GroupedTimestamp to = default(GroupedTimestamp), bool between = default(bool), bool continuous = default(bool))
        {
            this.Schema = schema;
            this.From = from;
            this.To = to;
            this.Between = between;
            this.Continuous = continuous;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Gets or Sets From
        /// </summary>
        [DataMember(Name = "from", EmitDefaultValue = false)]
        public GroupedTimestamp From { get; set; }

        /// <summary>
        /// Gets or Sets To
        /// </summary>
        [DataMember(Name = "to", EmitDefaultValue = false)]
        public GroupedTimestamp To { get; set; }

        /// <summary>
        /// Gets or Sets Between
        /// </summary>
        [DataMember(Name = "between", EmitDefaultValue = true)]
        public bool Between { get; set; }

        /// <summary>
        /// Gets or Sets Continuous
        /// </summary>
        [DataMember(Name = "continuous", EmitDefaultValue = true)]
        public bool Continuous { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AnonymousTemporalRange {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Between: ").Append(Between).Append("\n");
            sb.Append("  Continuous: ").Append(Continuous).Append("\n");
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

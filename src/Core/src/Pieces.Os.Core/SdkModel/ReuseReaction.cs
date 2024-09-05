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
    /// if reuse was used in the reaction then we can provide the uuid of the asset that was reused.
    /// </summary>
    [DataContract(Name = "ReuseReaction")]
    public partial class ReuseReaction : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReuseReaction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReuseReaction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReuseReaction" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="asset">asset (required).</param>
        public ReuseReaction(EmbeddedModelSchema schema = default(EmbeddedModelSchema), string asset = default(string))
        {
            // to ensure "asset" is required (not null)
            if (asset == null)
            {
                throw new ArgumentNullException("asset is a required property for ReuseReaction and cannot be null");
            }
            this.Asset = asset;
            this.Schema = schema;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Gets or Sets Asset
        /// </summary>
        [DataMember(Name = "asset", IsRequired = true, EmitDefaultValue = true)]
        public string Asset { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReuseReaction {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Asset: ").Append(Asset).Append("\n");
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

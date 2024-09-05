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
    /// similarity: you will want to pass in a value from 0-1. (where 1 is exact and 0 is everything)  exact: (optional) this will default to false, which will run a fuzzy search, unless set to true.
    /// </summary>
    [DataContract(Name = "FullTextSearchOptions")]
    public partial class FullTextSearchOptions : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FullTextSearchOptions" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="similarity">similarity.</param>
        /// <param name="exact">exact.</param>
        public FullTextSearchOptions(EmbeddedModelSchema schema = default(EmbeddedModelSchema), decimal? similarity = default(decimal?), bool exact = default(bool))
        {
            this.Schema = schema;
            this.Similarity = similarity;
            this.Exact = exact;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Gets or Sets Similarity
        /// </summary>
        [DataMember(Name = "similarity", EmitDefaultValue = true)]
        public decimal? Similarity { get; set; }

        /// <summary>
        /// Gets or Sets Exact
        /// </summary>
        [DataMember(Name = "exact", EmitDefaultValue = true)]
        public bool Exact { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FullTextSearchOptions {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Similarity: ").Append(Similarity).Append("\n");
            sb.Append("  Exact: ").Append(Exact).Append("\n");
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

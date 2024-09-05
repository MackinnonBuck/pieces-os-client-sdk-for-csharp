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
    /// This is a pre-created accessor that simply takes an os id and an optional user(flattened)
    /// </summary>
    [DataContract(Name = "SeededAccessor")]
    public partial class SeededAccessor : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SeededAccessor" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SeededAccessor() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SeededAccessor" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="os">this is an os id. (required).</param>
        /// <param name="user">user.</param>
        /// <param name="share">this is the share that the asset is apart of. (required).</param>
        public SeededAccessor(EmbeddedModelSchema schema = default(EmbeddedModelSchema), string os = default(string), FlattenedUserProfile user = default(FlattenedUserProfile), string share = default(string))
        {
            // to ensure "os" is required (not null)
            if (os == null)
            {
                throw new ArgumentNullException("os is a required property for SeededAccessor and cannot be null");
            }
            this.Os = os;
            // to ensure "share" is required (not null)
            if (share == null)
            {
                throw new ArgumentNullException("share is a required property for SeededAccessor and cannot be null");
            }
            this.Share = share;
            this.Schema = schema;
            this.User = user;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// this is an os id.
        /// </summary>
        /// <value>this is an os id.</value>
        [DataMember(Name = "os", IsRequired = true, EmitDefaultValue = true)]
        public string Os { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name = "user", EmitDefaultValue = false)]
        public FlattenedUserProfile User { get; set; }

        /// <summary>
        /// this is the share that the asset is apart of.
        /// </summary>
        /// <value>this is the share that the asset is apart of.</value>
        [DataMember(Name = "share", IsRequired = true, EmitDefaultValue = true)]
        public string Share { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SeededAccessor {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Os: ").Append(Os).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Share: ").Append(Share).Append("\n");
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

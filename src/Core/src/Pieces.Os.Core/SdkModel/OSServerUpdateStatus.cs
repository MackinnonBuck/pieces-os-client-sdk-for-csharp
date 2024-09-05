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
    /// This is the model for the progress of the current update of Pieces os.  /os/update/check/stream &amp;&amp; /os/update/check/  we will emit on a progress update  updated: is an optional property that will let us know when the update was checked last.  NOTE: it is reccommended to use the stream instead of pulling. NOTE: lets think about if we want to have a closing(as well as how we want to handle restarts)
    /// </summary>
    [DataContract(Name = "OSServerUpdateStatus")]
    public partial class OSServerUpdateStatus : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public UpdatingStatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OSServerUpdateStatus" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OSServerUpdateStatus() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OSServerUpdateStatus" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="status">status (required).</param>
        /// <param name="updated">updated.</param>
        /// <param name="percentage">Optionally if the update is in progress you will recieve a download percent(from 0-100)..</param>
        public OSServerUpdateStatus(EmbeddedModelSchema schema = default(EmbeddedModelSchema), UpdatingStatusEnum status = default(UpdatingStatusEnum), GroupedTimestamp updated = default(GroupedTimestamp), decimal? percentage = default(decimal?))
        {
            this.Status = status;
            this.Schema = schema;
            this.Updated = updated;
            this.Percentage = percentage;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Gets or Sets Updated
        /// </summary>
        [DataMember(Name = "updated", EmitDefaultValue = false)]
        public GroupedTimestamp Updated { get; set; }

        /// <summary>
        /// Optionally if the update is in progress you will recieve a download percent(from 0-100).
        /// </summary>
        /// <value>Optionally if the update is in progress you will recieve a download percent(from 0-100).</value>
        [DataMember(Name = "percentage", EmitDefaultValue = true)]
        public decimal? Percentage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OSServerUpdateStatus {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
            sb.Append("  Percentage: ").Append(Percentage).Append("\n");
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

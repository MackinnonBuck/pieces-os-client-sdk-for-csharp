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
    /// TODO add more description to this.  can eventually add a number that display the percent downloaded an so on.(this is called percent 0-100)
    /// </summary>
    [DataContract(Name = "BackupStatus")]
    public partial class BackupStatus : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public BackupStatusEnum? Value { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BackupStatus" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BackupStatus() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BackupStatus" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="value">value.</param>
        /// <param name="percentage">Optionally if the download is in progress you will receive a download percent(from 0-100)..</param>
        /// <param name="backup">backup (required).</param>
        public BackupStatus(EmbeddedModelSchema schema = default(EmbeddedModelSchema), BackupStatusEnum? value = default(BackupStatusEnum?), decimal? percentage = default(decimal?), Backup backup = default(Backup))
        {
            // to ensure "backup" is required (not null)
            if (backup == null)
            {
                throw new ArgumentNullException("backup is a required property for BackupStatus and cannot be null");
            }
            this.Backup = backup;
            this.Schema = schema;
            this.Value = value;
            this.Percentage = percentage;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Optionally if the download is in progress you will receive a download percent(from 0-100).
        /// </summary>
        /// <value>Optionally if the download is in progress you will receive a download percent(from 0-100).</value>
        [DataMember(Name = "percentage", EmitDefaultValue = true)]
        public decimal? Percentage { get; set; }

        /// <summary>
        /// Gets or Sets Backup
        /// </summary>
        [DataMember(Name = "backup", IsRequired = true, EmitDefaultValue = true)]
        public Backup Backup { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BackupStatus {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Percentage: ").Append(Percentage).Append("\n");
            sb.Append("  Backup: ").Append(Backup).Append("\n");
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

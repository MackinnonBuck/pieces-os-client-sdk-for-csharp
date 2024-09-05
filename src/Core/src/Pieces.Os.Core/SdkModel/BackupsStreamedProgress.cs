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
    /// This is used in the backups plural stream to stream the changes to all the restorations and backups in progress.
    /// </summary>
    [DataContract(Name = "BackupsStreamedProgress")]
    public partial class BackupsStreamedProgress : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BackupsStreamedProgress" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="backups">backups.</param>
        /// <param name="restorations">restorations.</param>
        public BackupsStreamedProgress(EmbeddedModelSchema schema = default(EmbeddedModelSchema), List<BackupStreamedProgress> backups = default(List<BackupStreamedProgress>), List<BackupStreamedProgress> restorations = default(List<BackupStreamedProgress>))
        {
            this.Schema = schema;
            this.Backups = backups;
            this.Restorations = restorations;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Gets or Sets Backups
        /// </summary>
        [DataMember(Name = "backups", EmitDefaultValue = false)]
        public List<BackupStreamedProgress> Backups { get; set; }

        /// <summary>
        /// Gets or Sets Restorations
        /// </summary>
        [DataMember(Name = "restorations", EmitDefaultValue = false)]
        public List<BackupStreamedProgress> Restorations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BackupsStreamedProgress {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Backups: ").Append(Backups).Append("\n");
            sb.Append("  Restorations: ").Append(Restorations).Append("\n");
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

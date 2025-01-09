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
    /// ExportedDatabase
    /// </summary>
    [DataContract(Name = "ExportedDatabase")]
    public partial class ExportedDatabase : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExportedDatabase" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExportedDatabase() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExportedDatabase" /> class.
        /// </summary>
        /// <param name="analyses">analyses (required).</param>
        /// <param name="applications">applications (required).</param>
        /// <param name="assets">assets (required).</param>
        /// <param name="codeAnalyses">codeAnalyses (required).</param>
        /// <param name="files">files (required).</param>
        /// <param name="formatMetrics">formatMetrics (required).</param>
        /// <param name="formats">formats (required).</param>
        /// <param name="fragments">fragments (required).</param>
        /// <param name="imageAnalyses">imageAnalyses (required).</param>
        /// <param name="models">models (required).</param>
        /// <param name="ocrAnalyses">ocrAnalyses (required).</param>
        /// <param name="persons">persons (required).</param>
        /// <param name="sensitives">sensitives (required).</param>
        /// <param name="tags">tags (required).</param>
        /// <param name="websites">websites (required).</param>
        /// <param name="values">values (required).</param>
        /// <param name="varVersion">This is the version of your os_server or cloud_server that we we exporting from. (required).</param>
        /// <param name="schema">schema.</param>
        /// <param name="relationships">relationships.</param>
        /// <param name="activities">activities.</param>
        /// <param name="annotations">annotations.</param>
        /// <param name="hints">hints.</param>
        /// <param name="anchors">anchors.</param>
        /// <param name="anchorPoints">anchorPoints.</param>
        /// <param name="conversations">conversations.</param>
        /// <param name="conversationMessages">conversationMessages.</param>
        /// <param name="workstreamEvents">workstreamEvents.</param>
        /// <param name="ranges">ranges.</param>
        /// <param name="workstreamSummaries">workstreamSummaries.</param>
        /// <param name="workstreamPatternEngineSources">workstreamPatternEngineSources.</param>
        /// <param name="messageValues">messageValues.</param>
        /// <param name="workstreamEventValues">workstreamEventValues.</param>
        public ExportedDatabase(List<int> analyses = default(List<int>), List<int> applications = default(List<int>), List<int> assets = default(List<int>), List<int> codeAnalyses = default(List<int>), List<int> files = default(List<int>), List<int> formatMetrics = default(List<int>), List<int> formats = default(List<int>), List<int> fragments = default(List<int>), List<int> imageAnalyses = default(List<int>), List<int> models = default(List<int>), List<int> ocrAnalyses = default(List<int>), List<int> persons = default(List<int>), List<int> sensitives = default(List<int>), List<int> tags = default(List<int>), List<int> websites = default(List<int>), ExportedDatabaseFormats values = default(ExportedDatabaseFormats), string varVersion = default(string), EmbeddedModelSchema schema = default(EmbeddedModelSchema), List<int> relationships = default(List<int>), List<int> activities = default(List<int>), List<int> annotations = default(List<int>), List<int> hints = default(List<int>), List<int> anchors = default(List<int>), List<int> anchorPoints = default(List<int>), List<int> conversations = default(List<int>), List<int> conversationMessages = default(List<int>), List<int> workstreamEvents = default(List<int>), List<int> ranges = default(List<int>), List<int> workstreamSummaries = default(List<int>), List<int> workstreamPatternEngineSources = default(List<int>), ExportedDatabaseFormats messageValues = default(ExportedDatabaseFormats), ExportedDatabaseFormats workstreamEventValues = default(ExportedDatabaseFormats))
        {
            // to ensure "analyses" is required (not null)
            if (analyses == null)
            {
                throw new ArgumentNullException("analyses is a required property for ExportedDatabase and cannot be null");
            }
            this.Analyses = analyses;
            // to ensure "applications" is required (not null)
            if (applications == null)
            {
                throw new ArgumentNullException("applications is a required property for ExportedDatabase and cannot be null");
            }
            this.Applications = applications;
            // to ensure "assets" is required (not null)
            if (assets == null)
            {
                throw new ArgumentNullException("assets is a required property for ExportedDatabase and cannot be null");
            }
            this.Assets = assets;
            // to ensure "codeAnalyses" is required (not null)
            if (codeAnalyses == null)
            {
                throw new ArgumentNullException("codeAnalyses is a required property for ExportedDatabase and cannot be null");
            }
            this.CodeAnalyses = codeAnalyses;
            // to ensure "files" is required (not null)
            if (files == null)
            {
                throw new ArgumentNullException("files is a required property for ExportedDatabase and cannot be null");
            }
            this.Files = files;
            // to ensure "formatMetrics" is required (not null)
            if (formatMetrics == null)
            {
                throw new ArgumentNullException("formatMetrics is a required property for ExportedDatabase and cannot be null");
            }
            this.FormatMetrics = formatMetrics;
            // to ensure "formats" is required (not null)
            if (formats == null)
            {
                throw new ArgumentNullException("formats is a required property for ExportedDatabase and cannot be null");
            }
            this.Formats = formats;
            // to ensure "fragments" is required (not null)
            if (fragments == null)
            {
                throw new ArgumentNullException("fragments is a required property for ExportedDatabase and cannot be null");
            }
            this.Fragments = fragments;
            // to ensure "imageAnalyses" is required (not null)
            if (imageAnalyses == null)
            {
                throw new ArgumentNullException("imageAnalyses is a required property for ExportedDatabase and cannot be null");
            }
            this.ImageAnalyses = imageAnalyses;
            // to ensure "models" is required (not null)
            if (models == null)
            {
                throw new ArgumentNullException("models is a required property for ExportedDatabase and cannot be null");
            }
            this.Models = models;
            // to ensure "ocrAnalyses" is required (not null)
            if (ocrAnalyses == null)
            {
                throw new ArgumentNullException("ocrAnalyses is a required property for ExportedDatabase and cannot be null");
            }
            this.OcrAnalyses = ocrAnalyses;
            // to ensure "persons" is required (not null)
            if (persons == null)
            {
                throw new ArgumentNullException("persons is a required property for ExportedDatabase and cannot be null");
            }
            this.Persons = persons;
            // to ensure "sensitives" is required (not null)
            if (sensitives == null)
            {
                throw new ArgumentNullException("sensitives is a required property for ExportedDatabase and cannot be null");
            }
            this.Sensitives = sensitives;
            // to ensure "tags" is required (not null)
            if (tags == null)
            {
                throw new ArgumentNullException("tags is a required property for ExportedDatabase and cannot be null");
            }
            this.Tags = tags;
            // to ensure "websites" is required (not null)
            if (websites == null)
            {
                throw new ArgumentNullException("websites is a required property for ExportedDatabase and cannot be null");
            }
            this.Websites = websites;
            // to ensure "values" is required (not null)
            if (values == null)
            {
                throw new ArgumentNullException("values is a required property for ExportedDatabase and cannot be null");
            }
            this.Values = values;
            // to ensure "varVersion" is required (not null)
            if (varVersion == null)
            {
                throw new ArgumentNullException("varVersion is a required property for ExportedDatabase and cannot be null");
            }
            this.VarVersion = varVersion;
            this.Schema = schema;
            this.Relationships = relationships;
            this.Activities = activities;
            this.Annotations = annotations;
            this.Hints = hints;
            this.Anchors = anchors;
            this.AnchorPoints = anchorPoints;
            this.Conversations = conversations;
            this.ConversationMessages = conversationMessages;
            this.WorkstreamEvents = workstreamEvents;
            this.Ranges = ranges;
            this.WorkstreamSummaries = workstreamSummaries;
            this.WorkstreamPatternEngineSources = workstreamPatternEngineSources;
            this.MessageValues = messageValues;
            this.WorkstreamEventValues = workstreamEventValues;
        }

        /// <summary>
        /// Gets or Sets Analyses
        /// </summary>
        [DataMember(Name = "analyses", IsRequired = true, EmitDefaultValue = true)]
        public List<int> Analyses { get; set; }

        /// <summary>
        /// Gets or Sets Applications
        /// </summary>
        [DataMember(Name = "applications", IsRequired = true, EmitDefaultValue = true)]
        public List<int> Applications { get; set; }

        /// <summary>
        /// Gets or Sets Assets
        /// </summary>
        [DataMember(Name = "assets", IsRequired = true, EmitDefaultValue = true)]
        public List<int> Assets { get; set; }

        /// <summary>
        /// Gets or Sets CodeAnalyses
        /// </summary>
        [DataMember(Name = "codeAnalyses", IsRequired = true, EmitDefaultValue = true)]
        public List<int> CodeAnalyses { get; set; }

        /// <summary>
        /// Gets or Sets Files
        /// </summary>
        [DataMember(Name = "files", IsRequired = true, EmitDefaultValue = true)]
        public List<int> Files { get; set; }

        /// <summary>
        /// Gets or Sets FormatMetrics
        /// </summary>
        [DataMember(Name = "formatMetrics", IsRequired = true, EmitDefaultValue = true)]
        public List<int> FormatMetrics { get; set; }

        /// <summary>
        /// Gets or Sets Formats
        /// </summary>
        [DataMember(Name = "formats", IsRequired = true, EmitDefaultValue = true)]
        public List<int> Formats { get; set; }

        /// <summary>
        /// Gets or Sets Fragments
        /// </summary>
        [DataMember(Name = "fragments", IsRequired = true, EmitDefaultValue = true)]
        public List<int> Fragments { get; set; }

        /// <summary>
        /// Gets or Sets ImageAnalyses
        /// </summary>
        [DataMember(Name = "imageAnalyses", IsRequired = true, EmitDefaultValue = true)]
        public List<int> ImageAnalyses { get; set; }

        /// <summary>
        /// Gets or Sets Models
        /// </summary>
        [DataMember(Name = "models", IsRequired = true, EmitDefaultValue = true)]
        public List<int> Models { get; set; }

        /// <summary>
        /// Gets or Sets OcrAnalyses
        /// </summary>
        [DataMember(Name = "ocrAnalyses", IsRequired = true, EmitDefaultValue = true)]
        public List<int> OcrAnalyses { get; set; }

        /// <summary>
        /// Gets or Sets Persons
        /// </summary>
        [DataMember(Name = "persons", IsRequired = true, EmitDefaultValue = true)]
        public List<int> Persons { get; set; }

        /// <summary>
        /// Gets or Sets Sensitives
        /// </summary>
        [DataMember(Name = "sensitives", IsRequired = true, EmitDefaultValue = true)]
        public List<int> Sensitives { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", IsRequired = true, EmitDefaultValue = true)]
        public List<int> Tags { get; set; }

        /// <summary>
        /// Gets or Sets Websites
        /// </summary>
        [DataMember(Name = "websites", IsRequired = true, EmitDefaultValue = true)]
        public List<int> Websites { get; set; }

        /// <summary>
        /// Gets or Sets Values
        /// </summary>
        [DataMember(Name = "values", IsRequired = true, EmitDefaultValue = true)]
        public ExportedDatabaseFormats Values { get; set; }

        /// <summary>
        /// This is the version of your os_server or cloud_server that we we exporting from.
        /// </summary>
        /// <value>This is the version of your os_server or cloud_server that we we exporting from.</value>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        public string VarVersion { get; set; }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Gets or Sets Relationships
        /// </summary>
        [DataMember(Name = "relationships", EmitDefaultValue = false)]
        public List<int> Relationships { get; set; }

        /// <summary>
        /// Gets or Sets Activities
        /// </summary>
        [DataMember(Name = "activities", EmitDefaultValue = false)]
        public List<int> Activities { get; set; }

        /// <summary>
        /// Gets or Sets Annotations
        /// </summary>
        [DataMember(Name = "annotations", EmitDefaultValue = false)]
        public List<int> Annotations { get; set; }

        /// <summary>
        /// Gets or Sets Hints
        /// </summary>
        [DataMember(Name = "hints", EmitDefaultValue = false)]
        public List<int> Hints { get; set; }

        /// <summary>
        /// Gets or Sets Anchors
        /// </summary>
        [DataMember(Name = "anchors", EmitDefaultValue = false)]
        public List<int> Anchors { get; set; }

        /// <summary>
        /// Gets or Sets AnchorPoints
        /// </summary>
        [DataMember(Name = "anchorPoints", EmitDefaultValue = false)]
        public List<int> AnchorPoints { get; set; }

        /// <summary>
        /// Gets or Sets Conversations
        /// </summary>
        [DataMember(Name = "conversations", EmitDefaultValue = false)]
        public List<int> Conversations { get; set; }

        /// <summary>
        /// Gets or Sets ConversationMessages
        /// </summary>
        [DataMember(Name = "conversationMessages", EmitDefaultValue = false)]
        public List<int> ConversationMessages { get; set; }

        /// <summary>
        /// Gets or Sets WorkstreamEvents
        /// </summary>
        [DataMember(Name = "workstreamEvents", EmitDefaultValue = false)]
        public List<int> WorkstreamEvents { get; set; }

        /// <summary>
        /// Gets or Sets Ranges
        /// </summary>
        [DataMember(Name = "ranges", EmitDefaultValue = false)]
        public List<int> Ranges { get; set; }

        /// <summary>
        /// Gets or Sets WorkstreamSummaries
        /// </summary>
        [DataMember(Name = "workstreamSummaries", EmitDefaultValue = false)]
        public List<int> WorkstreamSummaries { get; set; }

        /// <summary>
        /// Gets or Sets WorkstreamPatternEngineSources
        /// </summary>
        [DataMember(Name = "workstreamPatternEngineSources", EmitDefaultValue = false)]
        public List<int> WorkstreamPatternEngineSources { get; set; }

        /// <summary>
        /// Gets or Sets MessageValues
        /// </summary>
        [DataMember(Name = "messageValues", EmitDefaultValue = false)]
        public ExportedDatabaseFormats MessageValues { get; set; }

        /// <summary>
        /// Gets or Sets WorkstreamEventValues
        /// </summary>
        [DataMember(Name = "workstreamEventValues", EmitDefaultValue = false)]
        public ExportedDatabaseFormats WorkstreamEventValues { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ExportedDatabase {\n");
            sb.Append("  Analyses: ").Append(Analyses).Append("\n");
            sb.Append("  Applications: ").Append(Applications).Append("\n");
            sb.Append("  Assets: ").Append(Assets).Append("\n");
            sb.Append("  CodeAnalyses: ").Append(CodeAnalyses).Append("\n");
            sb.Append("  Files: ").Append(Files).Append("\n");
            sb.Append("  FormatMetrics: ").Append(FormatMetrics).Append("\n");
            sb.Append("  Formats: ").Append(Formats).Append("\n");
            sb.Append("  Fragments: ").Append(Fragments).Append("\n");
            sb.Append("  ImageAnalyses: ").Append(ImageAnalyses).Append("\n");
            sb.Append("  Models: ").Append(Models).Append("\n");
            sb.Append("  OcrAnalyses: ").Append(OcrAnalyses).Append("\n");
            sb.Append("  Persons: ").Append(Persons).Append("\n");
            sb.Append("  Sensitives: ").Append(Sensitives).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Websites: ").Append(Websites).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Relationships: ").Append(Relationships).Append("\n");
            sb.Append("  Activities: ").Append(Activities).Append("\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("  Hints: ").Append(Hints).Append("\n");
            sb.Append("  Anchors: ").Append(Anchors).Append("\n");
            sb.Append("  AnchorPoints: ").Append(AnchorPoints).Append("\n");
            sb.Append("  Conversations: ").Append(Conversations).Append("\n");
            sb.Append("  ConversationMessages: ").Append(ConversationMessages).Append("\n");
            sb.Append("  WorkstreamEvents: ").Append(WorkstreamEvents).Append("\n");
            sb.Append("  Ranges: ").Append(Ranges).Append("\n");
            sb.Append("  WorkstreamSummaries: ").Append(WorkstreamSummaries).Append("\n");
            sb.Append("  WorkstreamPatternEngineSources: ").Append(WorkstreamPatternEngineSources).Append("\n");
            sb.Append("  MessageValues: ").Append(MessageValues).Append("\n");
            sb.Append("  WorkstreamEventValues: ").Append(WorkstreamEventValues).Append("\n");
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

/*
 * FINBOURNE Luminesce Web API
 *
 * Contact: info@finbourne.com
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
using OpenAPIDateConverter = Finbourne.Luminesce.Sdk.Client.OpenAPIDateConverter;

namespace Finbourne.Luminesce.Sdk.Model
{
    /// <summary>
    /// Information leading to choosing the provider
    /// </summary>
    [DataContract(Name = "Source")]
    public partial class Source : IEquatable<Source>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public SourceType? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Source" /> class.
        /// </summary>
        /// <param name="location">The source location.  Start of a provider name, &#x60;Drive&#x60;, &#x60;LocalFs&#x60;, &#x60;AwsS3&#x60; etc..</param>
        /// <param name="type">type.</param>
        public Source(string location = default(string), SourceType ?type = default(SourceType?))
        {
            this.Location = location;
            this.Type = type;
        }

        /// <summary>
        /// The source location.  Start of a provider name, &#x60;Drive&#x60;, &#x60;LocalFs&#x60;, &#x60;AwsS3&#x60; etc.
        /// </summary>
        /// <value>The source location.  Start of a provider name, &#x60;Drive&#x60;, &#x60;LocalFs&#x60;, &#x60;AwsS3&#x60; etc.</value>
        [DataMember(Name = "location", EmitDefaultValue = true)]
        public string Location { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Source {\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Source);
        }

        /// <summary>
        /// Returns true if Source instances are equal
        /// </summary>
        /// <param name="input">Instance of Source to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Source input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Location != null)
                {
                    hashCode = (hashCode * 59) + this.Location.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Location (string) maxLength
            if (this.Location != null && this.Location.Length > 256)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Location, length must be less than 256.", new [] { "Location" });
            }

            // Location (string) minLength
            if (this.Location != null && this.Location.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Location, length must be greater than 0.", new [] { "Location" });
            }

            yield break;
        }
    }
}

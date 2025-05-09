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
    /// Information about a case statement.  A typical case statement would look like:  CASE WHEN Field {Filter} Source THEN Target  For example: CASE WHEN &#39;currency&#39; &#x3D; &#39;USD&#39; THEN &#39;US&#39;  Here the Field is &#39;currency&#39;, the Source is &#39;USD&#39;, the Filter is &#39;&#x3D;&#39;, and the Target is &#39;US&#39;
    /// </summary>
    [DataContract(Name = "CaseStatementItem")]
    public partial class CaseStatementItem : IEquatable<CaseStatementItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CaseStatementItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CaseStatementItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CaseStatementItem" /> class.
        /// </summary>
        /// <param name="filter">The operator in the case statement SQL expression (required).</param>
        /// <param name="source">The expression that is on the LHS of the operator  A typical case statement would look like:  CASE Field {Filter} Source THEN Target (required).</param>
        /// <param name="target">The expression that is on the RHS of the operator  A typical case statement would look like:  CASE Field {Filter} Source THEN Target (required).</param>
        /// <param name="isTargetNonLiteral">The Target can be a literal value or a non literal (field) and  hence will be interpreted differently.  This can be determined from the UI and passed down as a true / false.</param>
        public CaseStatementItem(string filter = default(string), string source = default(string), string target = default(string), bool isTargetNonLiteral = default(bool))
        {
            // to ensure "filter" is required (not null)
            if (filter == null)
            {
                throw new ArgumentNullException("filter is a required property for CaseStatementItem and cannot be null");
            }
            this.Filter = filter;
            // to ensure "source" is required (not null)
            if (source == null)
            {
                throw new ArgumentNullException("source is a required property for CaseStatementItem and cannot be null");
            }
            this.Source = source;
            // to ensure "target" is required (not null)
            if (target == null)
            {
                throw new ArgumentNullException("target is a required property for CaseStatementItem and cannot be null");
            }
            this.Target = target;
            this.IsTargetNonLiteral = isTargetNonLiteral;
        }

        /// <summary>
        /// The operator in the case statement SQL expression
        /// </summary>
        /// <value>The operator in the case statement SQL expression</value>
        [DataMember(Name = "filter", IsRequired = true, EmitDefaultValue = true)]
        public string Filter { get; set; }

        /// <summary>
        /// The expression that is on the LHS of the operator  A typical case statement would look like:  CASE Field {Filter} Source THEN Target
        /// </summary>
        /// <value>The expression that is on the LHS of the operator  A typical case statement would look like:  CASE Field {Filter} Source THEN Target</value>
        [DataMember(Name = "source", IsRequired = true, EmitDefaultValue = true)]
        public string Source { get; set; }

        /// <summary>
        /// The expression that is on the RHS of the operator  A typical case statement would look like:  CASE Field {Filter} Source THEN Target
        /// </summary>
        /// <value>The expression that is on the RHS of the operator  A typical case statement would look like:  CASE Field {Filter} Source THEN Target</value>
        [DataMember(Name = "target", IsRequired = true, EmitDefaultValue = true)]
        public string Target { get; set; }

        /// <summary>
        /// The Target can be a literal value or a non literal (field) and  hence will be interpreted differently.  This can be determined from the UI and passed down as a true / false
        /// </summary>
        /// <value>The Target can be a literal value or a non literal (field) and  hence will be interpreted differently.  This can be determined from the UI and passed down as a true / false</value>
        [DataMember(Name = "isTargetNonLiteral", EmitDefaultValue = true)]
        public bool IsTargetNonLiteral { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CaseStatementItem {\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
            sb.Append("  IsTargetNonLiteral: ").Append(IsTargetNonLiteral).Append("\n");
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
            return this.Equals(input as CaseStatementItem);
        }

        /// <summary>
        /// Returns true if CaseStatementItem instances are equal
        /// </summary>
        /// <param name="input">Instance of CaseStatementItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CaseStatementItem input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Filter == input.Filter ||
                    (this.Filter != null &&
                    this.Filter.Equals(input.Filter))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.Target == input.Target ||
                    (this.Target != null &&
                    this.Target.Equals(input.Target))
                ) && 
                (
                    this.IsTargetNonLiteral == input.IsTargetNonLiteral ||
                    this.IsTargetNonLiteral.Equals(input.IsTargetNonLiteral)
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
                if (this.Filter != null)
                {
                    hashCode = (hashCode * 59) + this.Filter.GetHashCode();
                }
                if (this.Source != null)
                {
                    hashCode = (hashCode * 59) + this.Source.GetHashCode();
                }
                if (this.Target != null)
                {
                    hashCode = (hashCode * 59) + this.Target.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsTargetNonLiteral.GetHashCode();
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
            // Filter (string) minLength
            if (this.Filter != null && this.Filter.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Filter, length must be greater than 1.", new [] { "Filter" });
            }

            // Source (string) minLength
            if (this.Source != null && this.Source.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Source, length must be greater than 1.", new [] { "Source" });
            }

            // Target (string) minLength
            if (this.Target != null && this.Target.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Target, length must be greater than 1.", new [] { "Target" });
            }

            yield break;
        }
    }
}

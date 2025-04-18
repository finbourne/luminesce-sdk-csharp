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
    /// Contract for an expression of data we \&quot;have\&quot; that we may \&quot;want to map to a table-parameter&#39;s column\&quot;
    /// </summary>
    [DataContract(Name = "ExpressionWithAlias")]
    public partial class ExpressionWithAlias : IEquatable<ExpressionWithAlias>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Flags
        /// </summary>
        [DataMember(Name = "flags", EmitDefaultValue = false)]
        public MappingFlags? Flags { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpressionWithAlias" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExpressionWithAlias() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpressionWithAlias" /> class.
        /// </summary>
        /// <param name="expression">Expression (column name, constant, complex expression, etc.) (required).</param>
        /// <param name="alias">Column Alias for the expression.</param>
        /// <param name="flags">flags.</param>
        public ExpressionWithAlias(string expression = default(string), string alias = default(string), MappingFlags ?flags = default(MappingFlags?))
        {
            // to ensure "expression" is required (not null)
            if (expression == null)
            {
                throw new ArgumentNullException("expression is a required property for ExpressionWithAlias and cannot be null");
            }
            this.Expression = expression;
            this.Alias = alias;
            this.Flags = flags;
        }

        /// <summary>
        /// Expression (column name, constant, complex expression, etc.)
        /// </summary>
        /// <value>Expression (column name, constant, complex expression, etc.)</value>
        [DataMember(Name = "expression", IsRequired = true, EmitDefaultValue = true)]
        public string Expression { get; set; }

        /// <summary>
        /// Column Alias for the expression
        /// </summary>
        /// <value>Column Alias for the expression</value>
        [DataMember(Name = "alias", EmitDefaultValue = true)]
        public string Alias { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ExpressionWithAlias {\n");
            sb.Append("  Expression: ").Append(Expression).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            sb.Append("  Flags: ").Append(Flags).Append("\n");
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
            return this.Equals(input as ExpressionWithAlias);
        }

        /// <summary>
        /// Returns true if ExpressionWithAlias instances are equal
        /// </summary>
        /// <param name="input">Instance of ExpressionWithAlias to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExpressionWithAlias input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Expression == input.Expression ||
                    (this.Expression != null &&
                    this.Expression.Equals(input.Expression))
                ) && 
                (
                    this.Alias == input.Alias ||
                    (this.Alias != null &&
                    this.Alias.Equals(input.Alias))
                ) && 
                (
                    this.Flags == input.Flags ||
                    this.Flags.Equals(input.Flags)
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
                if (this.Expression != null)
                {
                    hashCode = (hashCode * 59) + this.Expression.GetHashCode();
                }
                if (this.Alias != null)
                {
                    hashCode = (hashCode * 59) + this.Alias.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Flags.GetHashCode();
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
            // Expression (string) minLength
            if (this.Expression != null && this.Expression.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Expression, length must be greater than 1.", new [] { "Expression" });
            }

            yield break;
        }
    }
}

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
    /// Type of join between two tables
    /// </summary>
    /// <value>Type of join between two tables</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DesignJoinType
    {
        /// <summary>
        /// Enum LeftOuter for value: LeftOuter
        /// </summary>
        [EnumMember(Value = "LeftOuter")]
        LeftOuter = 1,

        /// <summary>
        /// Enum Inner for value: Inner
        /// </summary>
        [EnumMember(Value = "Inner")]
        Inner = 2,

        /// <summary>
        /// Enum FullOuter for value: FullOuter
        /// </summary>
        [EnumMember(Value = "FullOuter")]
        FullOuter = 3
    }

}

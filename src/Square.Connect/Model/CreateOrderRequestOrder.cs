/* 
 * Square Connect API
 *
 * No descripton provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 2.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Square.Connect.Model
{
    /// <summary>
    /// The object describes the order.
    /// </summary>
    [DataContract]
    public partial class CreateOrderRequestOrder :  IEquatable<CreateOrderRequestOrder>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrderRequestOrder" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateOrderRequestOrder() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrderRequestOrder" /> class.
        /// </summary>
        /// <param name="ReferenceId">An optional ID you can associate with the order for your own purposes (such as to associate the order with an entity ID in your own database).  This value cannot exceed 40 characters..</param>
        /// <param name="LineItems">The line items to associate with this order.  Each line item represents a different product (or a custom monetary amount) to include in a purchase. (required).</param>
        public CreateOrderRequestOrder(string ReferenceId = null, List<CreateOrderRequestLineItem> LineItems = null)
        {
            // to ensure "LineItems" is required (not null)
            if (LineItems == null)
            {
                throw new InvalidDataException("LineItems is a required property for CreateOrderRequestOrder and cannot be null");
            }
            else
            {
                this.LineItems = LineItems;
            }
            this.ReferenceId = ReferenceId;
        }
        
        /// <summary>
        /// An optional ID you can associate with the order for your own purposes (such as to associate the order with an entity ID in your own database).  This value cannot exceed 40 characters.
        /// </summary>
        /// <value>An optional ID you can associate with the order for your own purposes (such as to associate the order with an entity ID in your own database).  This value cannot exceed 40 characters.</value>
        [DataMember(Name="reference_id", EmitDefaultValue=false)]
        public string ReferenceId { get; set; }
        /// <summary>
        /// The line items to associate with this order.  Each line item represents a different product (or a custom monetary amount) to include in a purchase.
        /// </summary>
        /// <value>The line items to associate with this order.  Each line item represents a different product (or a custom monetary amount) to include in a purchase.</value>
        [DataMember(Name="line_items", EmitDefaultValue=false)]
        public List<CreateOrderRequestLineItem> LineItems { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateOrderRequestOrder {\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as CreateOrderRequestOrder);
        }

        /// <summary>
        /// Returns true if CreateOrderRequestOrder instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateOrderRequestOrder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateOrderRequestOrder other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ReferenceId == other.ReferenceId ||
                    this.ReferenceId != null &&
                    this.ReferenceId.Equals(other.ReferenceId)
                ) && 
                (
                    this.LineItems == other.LineItems ||
                    this.LineItems != null &&
                    this.LineItems.SequenceEqual(other.LineItems)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.ReferenceId != null)
                    hash = hash * 59 + this.ReferenceId.GetHashCode();
                if (this.LineItems != null)
                    hash = hash * 59 + this.LineItems.GetHashCode();
                return hash;
            }
        }
    }

}

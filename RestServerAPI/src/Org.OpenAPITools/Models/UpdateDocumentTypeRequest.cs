/*
 * Paperless Rest Server
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using PaperlessRestAPI.Converters;

namespace PaperlessRestAPI.Models
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class UpdateDocumentTypeRequest : IEquatable<UpdateDocumentTypeRequest>
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [Required]
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Slug
        /// </summary>
        [Required]
        [DataMember(Name = "slug", EmitDefaultValue = false)]
        public string Slug { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [Required]
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Match
        /// </summary>
        [Required]
        [DataMember(Name = "match", EmitDefaultValue = false)]
        public string Match { get; set; }

        /// <summary>
        /// Gets or Sets MatchingAlgorithm
        /// </summary>
        [Required]
        [DataMember(Name = "matching_algorithm", EmitDefaultValue = true)]
        public int MatchingAlgorithm { get; set; }

        /// <summary>
        /// Gets or Sets IsInsensitive
        /// </summary>
        [Required]
        [DataMember(Name = "is_insensitive", EmitDefaultValue = true)]
        public bool IsInsensitive { get; set; }

        /// <summary>
        /// Gets or Sets DocumentCount
        /// </summary>
        [Required]
        [DataMember(Name = "document_count", EmitDefaultValue = true)]
        public int DocumentCount { get; set; }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [Required]
        [DataMember(Name = "owner", EmitDefaultValue = true)]
        public int Owner { get; set; }

        /// <summary>
        /// Gets or Sets Permissions
        /// </summary>
        [Required]
        [DataMember(Name = "permissions", EmitDefaultValue = false)]
        public GetCorrespondents200ResponseResultsInnerPermissions Permissions { get; set; }

        /// <summary>
        /// Gets or Sets SetPermissions
        /// </summary>
        [Required]
        [DataMember(Name = "set_permissions", EmitDefaultValue = false)]
        public GetCorrespondents200ResponseResultsInnerPermissions SetPermissions { get; set; }

        /// <summary>
        /// Gets or Sets PermissionsForm
        /// </summary>
        [Required]
        [DataMember(Name = "permissions_form", EmitDefaultValue = false)]
        public UpdateCorrespondentRequestPermissionsForm PermissionsForm { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateDocumentTypeRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Match: ").Append(Match).Append("\n");
            sb.Append("  MatchingAlgorithm: ").Append(MatchingAlgorithm).Append("\n");
            sb.Append("  IsInsensitive: ").Append(IsInsensitive).Append("\n");
            sb.Append("  DocumentCount: ").Append(DocumentCount).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  SetPermissions: ").Append(SetPermissions).Append("\n");
            sb.Append("  PermissionsForm: ").Append(PermissionsForm).Append("\n");
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
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((UpdateDocumentTypeRequest)obj);
        }

        /// <summary>
        /// Returns true if UpdateDocumentTypeRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateDocumentTypeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateDocumentTypeRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Id == other.Id ||

                    Id.Equals(other.Id)
                ) &&
                (
                    Slug == other.Slug ||
                    Slug != null &&
                    Slug.Equals(other.Slug)
                ) &&
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) &&
                (
                    Match == other.Match ||
                    Match != null &&
                    Match.Equals(other.Match)
                ) &&
                (
                    MatchingAlgorithm == other.MatchingAlgorithm ||

                    MatchingAlgorithm.Equals(other.MatchingAlgorithm)
                ) &&
                (
                    IsInsensitive == other.IsInsensitive ||

                    IsInsensitive.Equals(other.IsInsensitive)
                ) &&
                (
                    DocumentCount == other.DocumentCount ||

                    DocumentCount.Equals(other.DocumentCount)
                ) &&
                (
                    Owner == other.Owner ||

                    Owner.Equals(other.Owner)
                ) &&
                (
                    Permissions == other.Permissions ||
                    Permissions != null &&
                    Permissions.Equals(other.Permissions)
                ) &&
                (
                    SetPermissions == other.SetPermissions ||
                    SetPermissions != null &&
                    SetPermissions.Equals(other.SetPermissions)
                ) &&
                (
                    PermissionsForm == other.PermissionsForm ||
                    PermissionsForm != null &&
                    PermissionsForm.Equals(other.PermissionsForm)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)

                hashCode = hashCode * 59 + Id.GetHashCode();
                if (Slug != null)
                    hashCode = hashCode * 59 + Slug.GetHashCode();
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                if (Match != null)
                    hashCode = hashCode * 59 + Match.GetHashCode();

                hashCode = hashCode * 59 + MatchingAlgorithm.GetHashCode();

                hashCode = hashCode * 59 + IsInsensitive.GetHashCode();

                hashCode = hashCode * 59 + DocumentCount.GetHashCode();

                hashCode = hashCode * 59 + Owner.GetHashCode();
                if (Permissions != null)
                    hashCode = hashCode * 59 + Permissions.GetHashCode();
                if (SetPermissions != null)
                    hashCode = hashCode * 59 + SetPermissions.GetHashCode();
                if (PermissionsForm != null)
                    hashCode = hashCode * 59 + PermissionsForm.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(UpdateDocumentTypeRequest left, UpdateDocumentTypeRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(UpdateDocumentTypeRequest left, UpdateDocumentTypeRequest right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
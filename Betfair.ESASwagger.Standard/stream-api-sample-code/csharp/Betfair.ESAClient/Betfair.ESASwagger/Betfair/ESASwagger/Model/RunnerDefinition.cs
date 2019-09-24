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

namespace Betfair.ESASwagger.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class RunnerDefinition :  IEquatable<RunnerDefinition>
    { 
    
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum {
            
            [EnumMember(Value = "ACTIVE")]
            Active,
            
            [EnumMember(Value = "WINNER")]
            Winner,
            
            [EnumMember(Value = "LOSER")]
            Loser,
            
            [EnumMember(Value = "REMOVED")]
            Removed,
            
            [EnumMember(Value = "REMOVED_VACANT")]
            RemovedVacant,
            
            [EnumMember(Value = "HIDDEN")]
            Hidden,
            
            [EnumMember(Value = "PLACED")]
            Placed
        }

    
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RunnerDefinition" /> class.
        /// Initializes a new instance of the <see cref="RunnerDefinition" />class.
        /// </summary>
        /// <param name="SortPriority">SortPriority.</param>
        /// <param name="RemovalDate">RemovalDate.</param>
        /// <param name="Id">Selection Id - the id of the runner (selection).</param>
        /// <param name="Hc">Handicap - the handicap of the runner (selection) (null if not applicable).</param>
        /// <param name="AdjustmentFactor">AdjustmentFactor.</param>
        /// <param name="Bsp">Bsp.</param>
        /// <param name="Status">Status.</param>

        public RunnerDefinition(int? SortPriority = null, DateTime? RemovalDate = null, long? Id = null, double? Hc = null, double? AdjustmentFactor = null, double? Bsp = null, StatusEnum? Status = null)
        {
            this.SortPriority = SortPriority;
            this.RemovalDate = RemovalDate;
            this.Id = Id;
            this.Hc = Hc;
            this.AdjustmentFactor = AdjustmentFactor;
            this.Bsp = Bsp;
            this.Status = Status;
            
        }
        
    
        /// <summary>
        /// Gets or Sets SortPriority
        /// </summary>
        [DataMember(Name="sortPriority", EmitDefaultValue=false)]
        public int? SortPriority { get; set; }
    
        /// <summary>
        /// Gets or Sets RemovalDate
        /// </summary>
        [DataMember(Name="removalDate", EmitDefaultValue=false)]
        public DateTime? RemovalDate { get; set; }
    
        /// <summary>
        /// Selection Id - the id of the runner (selection)
        /// </summary>
        /// <value>Selection Id - the id of the runner (selection)</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Handicap - the handicap of the runner (selection) (null if not applicable)
        /// </summary>
        /// <value>Handicap - the handicap of the runner (selection) (null if not applicable)</value>
        [DataMember(Name="hc", EmitDefaultValue=false)]
        public double? Hc { get; set; }
    
        /// <summary>
        /// Gets or Sets AdjustmentFactor
        /// </summary>
        [DataMember(Name="adjustmentFactor", EmitDefaultValue=false)]
        public double? AdjustmentFactor { get; set; }
    
        /// <summary>
        /// Gets or Sets Bsp
        /// </summary>
        [DataMember(Name="bsp", EmitDefaultValue=false)]
        public double? Bsp { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RunnerDefinition {\n");
            sb.Append("  SortPriority: ").Append(SortPriority).Append("\n");
            sb.Append("  RemovalDate: ").Append(RemovalDate).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Hc: ").Append(Hc).Append("\n");
            sb.Append("  AdjustmentFactor: ").Append(AdjustmentFactor).Append("\n");
            sb.Append("  Bsp: ").Append(Bsp).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            
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
            return this.Equals(obj as RunnerDefinition);
        }

        /// <summary>
        /// Returns true if RunnerDefinition instances are equal
        /// </summary>
        /// <param name="other">Instance of RunnerDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RunnerDefinition other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SortPriority == other.SortPriority ||
                    this.SortPriority != null &&
                    this.SortPriority.Equals(other.SortPriority)
                ) && 
                (
                    this.RemovalDate == other.RemovalDate ||
                    this.RemovalDate != null &&
                    this.RemovalDate.Equals(other.RemovalDate)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Hc == other.Hc ||
                    this.Hc != null &&
                    this.Hc.Equals(other.Hc)
                ) && 
                (
                    this.AdjustmentFactor == other.AdjustmentFactor ||
                    this.AdjustmentFactor != null &&
                    this.AdjustmentFactor.Equals(other.AdjustmentFactor)
                ) && 
                (
                    this.Bsp == other.Bsp ||
                    this.Bsp != null &&
                    this.Bsp.Equals(other.Bsp)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                
                if (this.SortPriority != null)
                    hash = hash * 59 + this.SortPriority.GetHashCode();
                
                if (this.RemovalDate != null)
                    hash = hash * 59 + this.RemovalDate.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Hc != null)
                    hash = hash * 59 + this.Hc.GetHashCode();
                
                if (this.AdjustmentFactor != null)
                    hash = hash * 59 + this.AdjustmentFactor.GetHashCode();
                
                if (this.Bsp != null)
                    hash = hash * 59 + this.Bsp.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                return hash;
            }
        }

    }
}

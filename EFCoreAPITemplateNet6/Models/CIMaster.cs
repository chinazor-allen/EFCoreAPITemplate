using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreAPITemplateNet6.Models
{
    [Table("CI_MASTER", Schema = "CI")]
    public class CiMaster
    {
        [JsonProperty("CI_UUID")]
        public string? CI_UUID { get; set; }
        [JsonProperty("SOURCETYPE")]
        public string? SOURCETYPE { get; set; }
        [JsonProperty("PROJECT_KIND")]
        public string? PROJECT_KIND { get; set; }
        [JsonProperty("COUNTRIES")]
        public string? COUNTRIES { get; set; }
        [JsonProperty("ORGINAZATION")]
        public string? ORGINAZATION { get; set; }
        [JsonProperty("UNIT")]
        public string? UNIT { get; set; }
        [JsonProperty("ASSET")]
        public string? ASSET { get; set; }
        [JsonProperty("PRO_ROW_ID")]
        public int? PRO_ROW_ID { get; set; }
        [JsonProperty("WELL_ID")]
        public int? WELL_ID { get; set; }
        [JsonProperty("WELLBORE_ID")]
        public int? WELLBORE_ID { get; set; }
        [JsonProperty("TARGET_ID")]
        public string? TARGET_ID { get; set; }
        [JsonProperty("PROSPECT_ID")]
        public string? PROSPECT_ID { get; set; }
        [JsonProperty("CONFIDENCE_ON_TARGET")]
        public string? CONFIDENCE_ON_TARGET { get; set; }
        [JsonProperty("COURSEL_TAR_MAT")]
        public string? COURSEL_TAR_MAT { get; set; }
        [JsonProperty("PRODUCTION_PROFILE_ID")]
        public string? PRODUCTION_PROFILE_ID { get; set; }
        [JsonProperty("COST_PROFILE_ID")]
        public string? COST_PROFILE_ID { get; set; }
        [JsonProperty("AMAP_WELL_PRO_ID")]
        public string? AMAP_WELL_PRO_ID { get; set; }
        [JsonProperty("WELL_MATURATION")]
        public string? WELL_MATURATION { get; set; }
        [JsonProperty("WELL_MATURATION_STATUS")]
        public string? WELL_MATURATION_STATUS { get; set; }
        [JsonProperty("WELL_ACTIVITY")]
        public string? WELL_ACTIVITY { get; set; }
        [JsonProperty("PRO_DEV_DG_PHASE")]
        public string? PRO_DEV_DG_PHASE { get; set; }
        [JsonProperty("WELLTYPE")]
        public string? WELLTYPE { get; set; }
        [JsonProperty("INSTALLATION_TYPE")]
        public string? INSTALLATION_TYPE { get; set; }
        [JsonProperty("DW_SUBSEA_NAME")]
        public string? DW_SUBSEA_NAME { get; set; }
        [JsonProperty("OFFICIAL_WELLSLOT_NAME")]
        public string? OFFICIAL_WELLSLOT_NAME { get; set; }
        [JsonProperty("DRILLING_TYPE")]
        public string? DRILLING_TYPE { get; set; }
        [JsonProperty("OPERATION_IN_DEPLETED_RESERVOIR")]
        public string? OPERATION_IN_DEPLETED_RESERVOIR { get; set; }
        [JsonProperty("ACTIVE_WELL_PROJECT")]
        public string? ACTIVE_WELL_PROJECT { get; set; }
        [JsonProperty("STAR_ID")]
        public int? STAR_ID { get; set; }
        [JsonProperty("WELLCOM_PROJECT_ID")]
        public string? WELLCOM_PROJECT_ID { get; set; }
        [JsonProperty("WELLCOM_DELIVERY_NO")]
        public string? WELLCOM_DELIVERY_NO { get; set; }
        [JsonProperty("STEA_VERSION_NUMBER")]
        public string? STEA_VERSION_NUMBER { get; set; }
        [JsonProperty("STEA_PROJECT_ALT_ID")]
        public string? STEA_PROJECT_ALT_ID { get; set; }
        [JsonProperty("CI_START_DATE")]
        public DateTime? CI_START_DATE { get; set; }
        [JsonProperty("CI_END_DATE")]
        public DateTime? CI_END_DATE { get; set; }
        [JsonProperty("CI_V_START_DATE")]
        public DateTime? CI_V_START_DATE { get; set; }
        [JsonProperty("CI_V_END_DATE")]
        public DateTime? CI_V_END_DATE { get; set; }
        [JsonProperty("CREATED_DATE")]
        public DateTime? CREATED_DATE { get; set; }
        [JsonProperty("LAST_CHANGED")]
        public DateTime? LAST_CHANGED { get; set; }
        [JsonProperty("COPYDATE")]
        public DateTime? COPYDATE { get; set; }
        [JsonProperty("DBSOURCE")]
        public string? DBSOURCE { get; set; }
        [JsonProperty("DBSOURCE_ID")]
        public string? DBSOURCE_ID { get; set; }
        [JsonProperty("DWH_TIMESTAMP")]
        public DateTime? DWH_TIMESTAMP { get; set; }
    }
}
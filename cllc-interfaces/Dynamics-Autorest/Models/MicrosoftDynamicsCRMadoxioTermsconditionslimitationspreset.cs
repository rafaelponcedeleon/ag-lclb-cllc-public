// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// adoxio_termsconditionslimitationspreset
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioTermsconditionslimitationspreset
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioTermsconditionslimitationspreset class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioTermsconditionslimitationspreset()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioTermsconditionslimitationspreset class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioTermsconditionslimitationspreset(string _owninguserValue = default(string), string _modifiedbyValue = default(string), int? statuscode = default(int?), bool? adoxioIsdefault = default(bool?), int? statecode = default(int?), string adoxioTermsconditionslimitationspresetid = default(string), string _modifiedonbehalfbyValue = default(string), int? timezoneruleversionnumber = default(int?), string _owneridValue = default(string), string _createdonbehalfbyValue = default(string), string _owningbusinessunitValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _createdbyValue = default(string), string _owningteamValue = default(string), string adoxioName = default(string), string adoxioContents = default(string), int? adoxioDisplayorder = default(int?), int? utcconversiontimezonecode = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? importsequencenumber = default(int?), string _adoxioLicencetypeValue = default(string), long? versionnumber = default(long?), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> adoxioTermsconditionslimitationspresetSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioTermsconditionslimitationspresetDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioTermsconditionslimitationspresetDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioTermsconditionslimitationspresetAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioTermsconditionslimitationspresetBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMadoxioLicencetype adoxioLicenceType = default(MicrosoftDynamicsCRMadoxioLicencetype), IList<MicrosoftDynamicsCRMadoxioApplicationtermsconditionslimitation> adoxioAdoxioTermsconditionspresetAdoxioApplicationtermsconditionsTermsConditionsPreset = default(IList<MicrosoftDynamicsCRMadoxioApplicationtermsconditionslimitation>))
        {
            this._owninguserValue = _owninguserValue;
            this._modifiedbyValue = _modifiedbyValue;
            Statuscode = statuscode;
            AdoxioIsdefault = adoxioIsdefault;
            Statecode = statecode;
            AdoxioTermsconditionslimitationspresetid = adoxioTermsconditionslimitationspresetid;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._owneridValue = _owneridValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Modifiedon = modifiedon;
            Overriddencreatedon = overriddencreatedon;
            this._createdbyValue = _createdbyValue;
            this._owningteamValue = _owningteamValue;
            AdoxioName = adoxioName;
            AdoxioContents = adoxioContents;
            AdoxioDisplayorder = adoxioDisplayorder;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Createdon = createdon;
            Importsequencenumber = importsequencenumber;
            this._adoxioLicencetypeValue = _adoxioLicencetypeValue;
            Versionnumber = versionnumber;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioTermsconditionslimitationspresetSyncErrors = adoxioTermsconditionslimitationspresetSyncErrors;
            AdoxioTermsconditionslimitationspresetDuplicateMatchingRecord = adoxioTermsconditionslimitationspresetDuplicateMatchingRecord;
            AdoxioTermsconditionslimitationspresetDuplicateBaseRecord = adoxioTermsconditionslimitationspresetDuplicateBaseRecord;
            AdoxioTermsconditionslimitationspresetAsyncOperations = adoxioTermsconditionslimitationspresetAsyncOperations;
            AdoxioTermsconditionslimitationspresetBulkDeleteFailures = adoxioTermsconditionslimitationspresetBulkDeleteFailures;
            AdoxioLicenceType = adoxioLicenceType;
            AdoxioAdoxioTermsconditionspresetAdoxioApplicationtermsconditionsTermsConditionsPreset = adoxioAdoxioTermsconditionspresetAdoxioApplicationtermsconditionsTermsConditionsPreset;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isdefault")]
        public bool? AdoxioIsdefault { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_termsconditionslimitationspresetid")]
        public string AdoxioTermsconditionslimitationspresetid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contents")]
        public string AdoxioContents { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_displayorder")]
        public int? AdoxioDisplayorder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_licencetype_value")]
        public string _adoxioLicencetypeValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_termsconditionslimitationspreset_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioTermsconditionslimitationspresetSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_termsconditionslimitationspreset_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioTermsconditionslimitationspresetDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_termsconditionslimitationspreset_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioTermsconditionslimitationspresetDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_termsconditionslimitationspreset_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioTermsconditionslimitationspresetAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_termsconditionslimitationspreset_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioTermsconditionslimitationspresetBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_LicenceType")]
        public MicrosoftDynamicsCRMadoxioLicencetype AdoxioLicenceType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_adoxio_termsconditionspreset_adoxio_applicationtermsconditions_TermsConditionsPreset")]
        public IList<MicrosoftDynamicsCRMadoxioApplicationtermsconditionslimitation> AdoxioAdoxioTermsconditionspresetAdoxioApplicationtermsconditionsTermsConditionsPreset { get; set; }

    }
}

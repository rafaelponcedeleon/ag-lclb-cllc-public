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

    public partial class MicrosoftDynamicsCRMnewBpfA5f48dac03e04d1498b374c0638698a2
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMnewBpfA5f48dac03e04d1498b374c0638698a2 class.
        /// </summary>
        public MicrosoftDynamicsCRMnewBpfA5f48dac03e04d1498b374c0638698a2()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMnewBpfA5f48dac03e04d1498b374c0638698a2 class.
        /// </summary>
        public MicrosoftDynamicsCRMnewBpfA5f48dac03e04d1498b374c0638698a2(string _activestageidValue = default(string), string _bpfAdoxioApplicationidValue = default(string), string _createdbyValue = default(string), string _createdonbehalfbyValue = default(string), string _modifiedbyValue = default(string), string _modifiedonbehalfbyValue = default(string), string _organizationidValue = default(string), string _processidValue = default(string), MicrosoftDynamicsCRMprocessstage activestageidname = default(MicrosoftDynamicsCRMprocessstage), System.DateTimeOffset? activestagestartedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMadoxioApplication bpfAdoxioApplicationid = default(MicrosoftDynamicsCRMadoxioApplication), int? bpfDuration = default(int?), string bpfName = default(string), string businessprocessflowinstanceid = default(string), System.DateTimeOffset? completedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), int? importsequencenumber = default(int?), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMasyncoperation> newBpfA5f48dac03e04d1498b374c0638698a2AsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> newBpfA5f48dac03e04d1498b374c0638698a2BulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMsyncerror> newBpfA5f48dac03e04d1498b374c0638698a2SyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMworkflowlog> newBpfA5f48dac03e04d1498b374c0638698a2WorkflowLogs = default(IList<MicrosoftDynamicsCRMworkflowlog>), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMworkflow processidname = default(MicrosoftDynamicsCRMworkflow), int? statecode = default(int?), int? statuscode = default(int?), int? timezoneruleversionnumber = default(int?), string traversedpath = default(string), int? utcconversiontimezonecode = default(int?), object versionnumber = default(object))
        {
            this._activestageidValue = _activestageidValue;
            this._bpfAdoxioApplicationidValue = _bpfAdoxioApplicationidValue;
            this._createdbyValue = _createdbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._organizationidValue = _organizationidValue;
            this._processidValue = _processidValue;
            Activestageidname = activestageidname;
            Activestagestartedon = activestagestartedon;
            BpfAdoxioApplicationid = bpfAdoxioApplicationid;
            BpfDuration = bpfDuration;
            BpfName = bpfName;
            Businessprocessflowinstanceid = businessprocessflowinstanceid;
            Completedon = completedon;
            Createdbyname = createdbyname;
            Createdon = createdon;
            Createdonbehalfbyname = createdonbehalfbyname;
            Importsequencenumber = importsequencenumber;
            Modifiedbyname = modifiedbyname;
            Modifiedon = modifiedon;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            NewBpfA5f48dac03e04d1498b374c0638698a2AsyncOperations = newBpfA5f48dac03e04d1498b374c0638698a2AsyncOperations;
            NewBpfA5f48dac03e04d1498b374c0638698a2BulkDeleteFailures = newBpfA5f48dac03e04d1498b374c0638698a2BulkDeleteFailures;
            NewBpfA5f48dac03e04d1498b374c0638698a2SyncErrors = newBpfA5f48dac03e04d1498b374c0638698a2SyncErrors;
            NewBpfA5f48dac03e04d1498b374c0638698a2WorkflowLogs = newBpfA5f48dac03e04d1498b374c0638698a2WorkflowLogs;
            Organizationid = organizationid;
            Overriddencreatedon = overriddencreatedon;
            Processidname = processidname;
            Statecode = statecode;
            Statuscode = statuscode;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Traversedpath = traversedpath;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Versionnumber = versionnumber;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_activestageid_value")]
        public string _activestageidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_bpf_adoxio_applicationid_value")]
        public string _bpfAdoxioApplicationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_processid_value")]
        public string _processidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activestageidname")]
        public MicrosoftDynamicsCRMprocessstage Activestageidname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activestagestartedon")]
        public System.DateTimeOffset? Activestagestartedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bpf_adoxio_applicationid")]
        public MicrosoftDynamicsCRMadoxioApplication BpfAdoxioApplicationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bpf_duration")]
        public int? BpfDuration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bpf_name")]
        public string BpfName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "businessprocessflowinstanceid")]
        public string Businessprocessflowinstanceid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "completedon")]
        public System.DateTimeOffset? Completedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "new_bpf_a5f48dac03e04d1498b374c0638698a2_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> NewBpfA5f48dac03e04d1498b374c0638698a2AsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "new_bpf_a5f48dac03e04d1498b374c0638698a2_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> NewBpfA5f48dac03e04d1498b374c0638698a2BulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "new_bpf_a5f48dac03e04d1498b374c0638698a2_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> NewBpfA5f48dac03e04d1498b374c0638698a2SyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "new_bpf_a5f48dac03e04d1498b374c0638698a2_WorkflowLogs")]
        public IList<MicrosoftDynamicsCRMworkflowlog> NewBpfA5f48dac03e04d1498b374c0638698a2WorkflowLogs { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processidname")]
        public MicrosoftDynamicsCRMworkflow Processidname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "traversedpath")]
        public string Traversedpath { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public object Versionnumber { get; set; }

    }
}
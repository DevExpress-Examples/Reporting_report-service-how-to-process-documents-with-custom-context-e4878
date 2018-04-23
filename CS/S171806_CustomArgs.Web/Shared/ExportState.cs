using System.Runtime.Serialization;

namespace S171806_CustomArgs {
    [DataContract]
    public class ExportState {
        [DataMember]
        public string FileName { get; set; }
    }
}
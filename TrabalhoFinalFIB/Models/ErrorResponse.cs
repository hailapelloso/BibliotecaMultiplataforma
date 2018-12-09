using System.Runtime.Serialization;

namespace TrabalhoFinalFIB.Models
{
    [DataContract]
    public class ErrorResponse
    {
        [DataMember(Name="message")]
        public string Message { get; set; }

        [DataMember(Name="code")]
        public int Code { get; set; }
    }
}

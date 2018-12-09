using System.Runtime.Serialization;

namespace TrabalhoFinalFIB.Models
{
    [DataContract]
    public class Author : BaseDTO
    {
        [DataMember(Name = "name")]
        public string Name
        {
            get;
            set;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}


namespace Demo.Services.Interface
{
    using System.Runtime.Serialization;

    [DataContract]
    public class People
    {
        [DataMember(Order = 1)]
        public string Name { get; set; }
    }
}

namespace Digiruokalista.com.Models
{
    public class Device
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PushEndpoint { get; set; }
        public string PushP256DH { get; set; }
        public string PushAuth { get; set; }
    }
}

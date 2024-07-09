using System.Net.NetworkInformation;

namespace CSD09
{
    public class FTP
    {
        public static FTP Obj { get; } = new FTP();

        public string Manufacture { get; set; }
        public string Mac { get; set; }

        public NType NetworkType { get; set; }

        public enum NType
        {
            Ethernet,
            TokenRing
        }

        private FTP()
        {
            Manufacture = "Intel";
            Mac = "c2:23:0c:04:aa:3d";
            NetworkType = NType.Ethernet;
        }

        public override string ToString()
        {
            return $"Manufacture: {Manufacture}\nmac address: {Mac}\nnetwork type: {NetworkType}";
        }
    }
}

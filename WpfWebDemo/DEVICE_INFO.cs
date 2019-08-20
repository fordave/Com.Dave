namespace YKBLClient.HanvonSdk
{
    public struct DEVICE_INFO
    {
      
        public byte[] VendorName;

      
        public byte[] ProductName;

   
        public byte[] DllVersion;

        public ushort vendorID;

        public ushort productID;

        public int DeviceType;

        public int PressureLevel;

        public HWTabletRect MonitorBounds;

     
        public byte[] serial;
    }
}
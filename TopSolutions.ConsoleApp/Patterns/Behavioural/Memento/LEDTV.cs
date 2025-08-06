namespace TopSolutions.ConsoleApp.Patterns.Behavioural.Memento
{
    public class LEDTV
    {
        //Properties of the LED TV
        public string Size { get; set; }
        public double Price { get; set; }
        public bool USBSupport { get; set; }
        public bool HDMISupport { get; set; }
        public bool VGASupport { get; set; }
        //Initializing the Properties using Constructor
        public LEDTV(string Size, double Price, bool USBSupport, bool HDMISupport, bool VGASupport)
        {
            this.Size = Size;
            this.Price = Price;
            this.USBSupport = USBSupport;
            this.HDMISupport = HDMISupport;
            this.VGASupport = VGASupport;
        }
        //Fetching the Details of the LedTV
        public string GetDetails()
        {
            return "LEDTV [Size=" + Size + ", Price=" + Price + ", USBSupport=" + USBSupport + 
                " HDMISupport=" + HDMISupport + " VGASupport=" + VGASupport + "]";
        }
    }
}

﻿namespace TopSolutions.ConsoleApp.Patterns.Behavioural.Memento
{
    public class LEDTV
    {//Properties of the LED TV
        public string Size { get; set; }
        public string Price { get; set; }
        public bool USBSupport { get; set; }
        //Initializing the Properties using Constructor
        public LEDTV(string Size, string Price, bool USBSupport)
        {
            this.Size = Size;
            this.Price = Price;
            this.USBSupport = USBSupport;
        }
        //Fetching the Details of the LedTV
        public string GetDetails()
        {
            return "LEDTV [Size=" + Size + ", Price=" + Price + ", USBSupport=" + USBSupport + "]";
        }
    }
}

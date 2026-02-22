namespace TopSolutions.ConsoleApp.Patterns.Structural.Bridge.Simple
{
    public class BridgeMain
    {
        static void Main(string[] args)
        {
            // Except for the initialization phase, where an Abstraction object gets i.e. SonyRemoteControl or SamsungRemoteControl
            // linked with a specific Implementation object i.e. new SonyLedTv() or new SamsungLedTv(), 
            // the client code should only depend on the Abstraction class i.e. SonyRemoteControl or SamsungRemoteControl. 
            AbstractRemoteControl sonyRemoteControl = new SonyRemoteControl(new SonyLedTv());
            sonyRemoteControl.SwitchOn();
            sonyRemoteControl.SetChannel(101);
            sonyRemoteControl.SwitchOff();
            sonyRemoteControl.
            Console.WriteLine();
            AbstractRemoteControl samsungRemoteControl = new SamsungRemoteControl(new SamsungLedTv());
            samsungRemoteControl.SwitchOn();
            samsungRemoteControl.SetChannel(202);
            samsungRemoteControl.SwitchOff();
            Console.WriteLine("Panasonic");
            AbstractRemoteControl panasonicRemoteControl = new PanasonicRemoteControl(new PanasonicLedTv());
            panasonicRemoteControl.SwitchOn();
            panasonicRemoteControl.SwitchOff();
            panasonicRemoteControl.SetChannel(309);
            Console.ReadKey();
        }
    }
}

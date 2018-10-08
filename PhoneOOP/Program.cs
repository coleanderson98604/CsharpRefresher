using System;

namespace PhoneOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Galaxy s8 = new Galaxy("s8", 69, "T-Mobile", "Mayuri phrase");
            Nokia N8 = new Nokia("N8",100,"Verizon","Boom Bap");
            s8.DisplayInfo();
            System.Console.WriteLine(s8.Ring());
            System.Console.WriteLine(s8.Unlock());
            System.Console.WriteLine("");

            N8.DisplayInfo();
            System.Console.WriteLine(N8.Ring());
            System.Console.WriteLine(N8.Unlock());
            System.Console.WriteLine("");
        }
    }
    public abstract class Phone
    {
        private string _versionNumber;
        private int _batteryPercentage;
        private string _carrier;
        private string _ringtone;
        public Phone(string versionNumber,int batteryPercentage, string carrier,string ringtone)
        {
            _versionNumber = versionNumber;
            _batteryPercentage = batteryPercentage;
            _carrier = carrier;
            _ringtone = ringtone;
        }
        public abstract void DisplayInfo();
        public string _VersionNumber
        {
            get { return _versionNumber;}
        }
        public int _BatteryPercentage
        {
            get { return _batteryPercentage; }
        }
        public string _Carrier
        {
            get { return _carrier; }
        }
        public string _Ringtone
        {
            get { return _ringtone; }
        }
    }
    interface IRingable
    {
        string Ring();
        string Unlock();

    }
    public class Nokia: Phone, IRingable
    {
        public Nokia(string versionNumber, int batteryPercentage, string carrier, string ringtone)
        : base(versionNumber, batteryPercentage, carrier, ringtone){}
        
        public string Ring()
        {
            return "Too ta roo";
        }
        public string Unlock()
        {
            return ($"Nokia {_VersionNumber}");
        }
        public override void DisplayInfo()
        {
            System.Console.WriteLine("######################");
            System.Console.WriteLine($"Version: {_VersionNumber}");
            System.Console.WriteLine($"Battery %: {_BatteryPercentage}");
            System.Console.WriteLine($"Carrier: {_Carrier}");
            System.Console.WriteLine($"Ringtone: {_Ringtone}");
            System.Console.WriteLine("######################");
        }
    }
        public class Galaxy: Phone, IRingable
    {
        public Galaxy(string versionNumber, int batteryPercentage, string carrier, string ringtone)
        : base(versionNumber, batteryPercentage, carrier, ringtone){}
        
        public string Ring()
        {
            return "Too ta ro too dooo";
        }
        public string Unlock()
        {
            return ($"Galaxy {_VersionNumber}");
        }
        public override void DisplayInfo()
        {
            System.Console.WriteLine("######################");
            System.Console.WriteLine($"Version: {_VersionNumber}");
            System.Console.WriteLine($"Battery %: {_BatteryPercentage}");
            System.Console.WriteLine($"Carrier: {_Carrier}");
            System.Console.WriteLine($"Ringtone: {_Ringtone}");
            System.Console.WriteLine("######################");
        }
    }
}

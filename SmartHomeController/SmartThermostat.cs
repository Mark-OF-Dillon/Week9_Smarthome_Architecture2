using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeController
{
    internal class SmartThermostat : SmartDevice
    {
        // Private Fields //
        private double currentTemperature;
        private double targetTemperature;

        // Public Properties //
        public double CurrentTemperature
        {
            get { return currentTemperature; }
            set { currentTemperature = value; }
        }
        public double TargetTemperature
        {
            get { return targetTemperature; }
            set { targetTemperature = value; }
        }

        // Paramaterised Constructor //
        public SmartThermostat(int smartDeviceID, 
            string smartDeviceName, 
            bool smartDeviceStatus, 
            double currentTemperature, 
            double targetTemperature)
            : base(smartDeviceID, 
                  smartDeviceName, 
                  smartDeviceStatus)
        {
            CurrentTemperature = currentTemperature;
            TargetTemperature = targetTemperature;
        }

        public void SetTemperature()
        {

        }

        public void SetCurrentTemperature()
        {

        }

        public override void GetStatus()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeController
{
    internal class SmartSecurityCamera : SmartDevice
    {
        // Private Fields//
        private string resolution;
        private bool recordingStatus;

        // Public Properties //
        public string Resolution
        {
            get { return resolution;  }
            set { resolution = value;  }
        }
           
        public bool RecordingStatus 
        {
            get { return recordingStatus; }
            set { recordingStatus = value; }
        }

        // Paramaterised Constructor //
        public SmartSecurityCamera(string resolution, 
            bool recordingStatus,
            int smartDeviceID,
            string smartDeviceName, 
            bool smartDeviceStatus) : base( smartDeviceID, smartDeviceName, smartDeviceStatus)
        {
            Resolution = resolution;
            RecordingStatus = recordingStatus;
        }
        
        // Methods //
        public void StartRecording()
        {

        }
        public void StopRecording()
        {

        }

        public override void GetStatus()
        {
            
        }

        public void TurnOff()
        {

        }
    }
}

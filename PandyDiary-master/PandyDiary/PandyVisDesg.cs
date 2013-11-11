using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Phidgets;
using Phidgets.Events;

namespace WindowsFormsApplication1
{
    public partial class PandyVisDesg : Form
    {
       // private RFID rfid2;
        public PandyVisDesg()
        {
            InitializeComponent();
        }


        private void PandyVisDesg_Load(object sender, EventArgs e)
        {
         /*   rfid2 = new RFID();
            rfid2.Attach += new AttachEventHandler(rfid2_Attach);

            rfid2.Detach += new DetachEventHandler(rfid2_Detach);

            //     rfid.Error += new ErrorEventHandler(rfid_Error);

       //     rfid.Tag += new TagEventHandler(rfid_Tag);
            rfid2.TagLost += new TagEventHandler(rfid2_TagLost);

            rfid2.open();*/
        }

        public void PandyVisDesg_bodySensor()
        {
            RFIDBodyOn.BringToFront();
            CollarPictureLike.Visible = true;
        }

        public void PandyVisDesg_bodySensorOff()
        {
            RFIDBodyOff.BringToFront();
            CollarPictureLike.Visible = false; 
        }

/*
        // This code runs when you attach the RFID Phidget to your computer
        public void rfid2_Attach(object sender, AttachEventArgs e)
        {
            RFID attached = (RFID)sender;
        }

        // This code runs when you detach the RFID Phidget from your computer
        //detach event handler...clear all the fields, display the attached status, and disable the checkboxes.
        public void rfid2_Detach(object sender, DetachEventArgs e)
        {
            RFID detached = (RFID)sender;

        }

        // When the Phidget is reading an RFID...
        public void rfid2_Tag(object sender, TagEventArgs e)
        {
            if (e.Tag.Equals("010693293c")) // black circle 
            {
                RFIDBodyOn.BringToFront();
            }

        }

        //Tag lost event handler...here we simply want to clear our tag field in the GUI
        public void rfid2_TagLost(object sender, TagEventArgs e)
        {

            RFIDBodyOff.BringToFront();
        }
        */

    }
}

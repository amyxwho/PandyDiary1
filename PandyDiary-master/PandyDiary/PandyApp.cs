using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Phidgets;
using Phidgets.Events;

namespace WindowsFormsApplication1
{
    public partial class PandyApp : Form
    {
        private RFID rfid;
        PandyVisDesg Pandy = new PandyVisDesg();
        public PandyApp()
        {
            InitializeComponent();

            
         
            Pandy.Show();

        }

        private void PandyApp_Load(object sender, EventArgs e)
        {
            rfid = new RFID();
            rfid.Attach += new AttachEventHandler(rfid_Attach);

            rfid.Detach += new DetachEventHandler(rfid_Detach);

            //     rfid.Error += new ErrorEventHandler(rfid_Error);

            rfid.Tag += new TagEventHandler(rfid_Tag);
            rfid.TagLost += new TagEventHandler(rfid_TagLost);

            rfid.open();
        }

        //hook up to touch/pressure sensor
        private void timerSocial_Tick(object sender, EventArgs e)
        {
            if (prgbar_social.Value < prgbar_social.Maximum)
            {
                prgbar_social.Increment(-1);
            }
            else
            {
                timerSocial.Stop();
            }

        }

        //hook up to rfid tag
        private void timerFood_Tick(object sender, EventArgs e)
        {
            if ((prgbar_food.Value < prgbar_food.Maximum))
            {
                prgbar_food.Increment(-1);
            }
            else
            {
                timerFood.Stop();
            }

        }


        //done for now... investigate battery
        private void timerRest_Tick(object sender, EventArgs e)
       {
            if (prgbar_rest.Value < prgbar_rest.Maximum)
            {
                prgbar_rest.Increment(1);
            }
            else
            {
                timerRest.Stop();
            }

        }


        

        // This code runs when you attach the RFID Phidget to your computer
        public void rfid_Attach(object sender, AttachEventArgs e)
        {
            RFID attached = (RFID)sender;
        }

        // This code runs when you detach the RFID Phidget from your computer
        //detach event handler...clear all the fields, display the attached status, and disable the checkboxes.
        public void rfid_Detach(object sender, DetachEventArgs e)
        {
            RFID detached = (RFID)sender;

        }

        // When the Phidget is reading an RFID...
        public void rfid_Tag(object sender, TagEventArgs e)
        {
            if (e.Tag.Equals("0106932b02")) 
            {
                prgbar_food.Value = 100;
            }
            else if (e.Tag.Equals("010693293c"))
            {
                Pandy.PandyVisDesg_bodySensor();
            }

        }

        //Tag lost event handler...here we simply want to clear our tag field in the GUI
        public void rfid_TagLost(object sender, TagEventArgs e)
        {
            Pandy.PandyVisDesg_bodySensorOff();

        }


        //IfKit attach event handler
        public void ifKit_Attach(object sender, AttachEventArgs e)
        {

        }

        //Ifkit detach event handler
        public void ifKit_Detach(object sender, DetachEventArgs e)
        {

        }

        //Sensor input change event handler
        public void ifKit_SensorChange(object sender, SensorChangeEventArgs e)
        {

            if (e.Value < 400)
            {
                prgbar_social.Value = 100;
            }
            else if (e.Value >= 400)
            {
                prgbar_social.Value = 0;
            }

        /*    if (e.Index == 0)
            {
                circleArray[e.Index].changeColor(Color.FromArgb(e.Value * 1 / 4, e.Value * 1 / 4, e.Value * 1 / 4));
                circleArray[e.Index].changeSize(new Point((e.Value) + 1, (e.Value) + 1));
            }



            g.Clear(Color.Black);

            for (int i = 0; i < 8; i++)
            {
                // Draw (with gradients)
                circleArray[i].Draw("");

            }*/
        }

        
    }
}

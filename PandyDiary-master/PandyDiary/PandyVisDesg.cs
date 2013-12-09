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

        public void PandyVisDesg_bambooFoodOn()
        {
            RFIDMouthOn.BringToFront();
            BambooFood.Visible = true;
        }

        public void PandyVisDesg_bambooFoodOff()
        {
            RFIDMouthOff.BringToFront();
            BambooFood.Visible = false;
        }

        public void PandyVisDesg_TouchSensorOn()
        {
            TouchSenBellyOn.BringToFront();
            TouchSenHeadOn.BringToFront();
            TouchSenLShoulderOn.BringToFront();
            TouchSenRShoulderOn.BringToFront();
        }

        public void PandyVisDesg_TouchSensorOff()
        {
            TouchSenBellyOff.BringToFront();
            TouchSenHeadOff.BringToFront();
            TouchSenLShoulder.BringToFront();
            TouchSenRShoulder.BringToFront();
        }

        public void PandyVisDesg_BodySensorNo()
        {
            RFIDBodyOn.BringToFront();
            BowPic.Visible = true;

        }

        public void PandyVisDesg_BodySensorNoOff()
        {
            RFIDBodyOff.BringToFront();
            BowPic.Visible = false;

        }

        public void PandyVisDesg_PresentOn()
        {
            RFIDBodyOn.BringToFront();
            PresentPic.Visible = true;
        }


        public void PandyVisDesg_PresentOff()
        {
            RFIDBodyOff.BringToFront();
            PresentPic.Visible = false;
        }

        public void PandyVisDesg_cupcakeOn()
        {
            cupcakePic.Visible = true;
        }

        public void PandyVisDesg_cupcakeOff()
        {
            cupcakePic.Visible = false;
        }
    }
}

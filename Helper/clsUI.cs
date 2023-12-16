using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DisburstmentJournal.Helper
{
    class clsUI
    {   
        public static void LoadSplash(Form frm,Timer tmr)
        {
            string ImageName = Environment.CurrentDirectory + "\\Resources\\" + Utils.GetAppValue("SplashImg").ToString();
            string SystemName = Utils.GetAppValue("SystemName").ToString();

            if (!string.IsNullOrEmpty(ImageName) && File.Exists(ImageName))
            {
                frm.BackgroundImage = Image.FromFile(ImageName);
                frm.BackgroundImageLayout = ImageLayout.Stretch;

            }
            //Initialize each control properties
            foreach(Control ctrl in frm.Controls)
            {
                if(ctrl is Label)
                {
                    switch(ctrl.Name)
                    {
                        case "lblTitle":
                            Label lblTitle = (Label)ctrl;
                            lblTitle.Text = string.IsNullOrWhiteSpace(SystemName) ? "SYSTEM" : SystemName;
                            break;
                    }
                }    
                if(ctrl is ProgressBar)
                {
                    ProgressBar pb = (ProgressBar)ctrl;
                    pb.Maximum = 100;                    
                }
            }
            tmr.Enabled = true;
            tmr.Start();
        }
        
        

        
    }
}

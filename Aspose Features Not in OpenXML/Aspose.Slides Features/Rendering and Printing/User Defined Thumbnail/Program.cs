﻿using Aspose.Slides;
using Aspose.Slides.Pptx;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Defined_Thumbnail
{
    class Program
    {
        static void Main(string[] args)
        {
            string MyDir = "";
            //Instantiate a Presentation class that represents the presentation file
            using (PresentationEx pres = new PresentationEx(MyDir+"Slides Test Presentation.pptx"))
            {

                //Access the first slide
                SlideEx sld = pres.Slides[0];

                //User defined dimension
                int desiredX = 1200;
                int desiredY = 800;

                //Getting scaled value  of X and Y
                float ScaleX = (float)(1.0 / pres.SlideSize.Size.Width) * desiredX;
                float ScaleY = (float)(1.0 / pres.SlideSize.Size.Height) * desiredY;

                //Create a full scale image
                Bitmap bmp = sld.GetThumbnail(ScaleX, ScaleY);

                //Save the image to disk in JPEG format
                bmp.Save(MyDir + "Thumbnail2.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

            }
        }
    }
}

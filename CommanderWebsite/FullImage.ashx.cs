using CommanderWebsite.Controllers;
using CommanderWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommanderWebsite
{
    /// <summary>
    /// Summary description for FullImage
    /// </summary>
    public class FullImage : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            try { 
            string imageid = context.Request.QueryString["ImID"];

            if (imageid == null || imageid == "")

            {

                //Set a default imageID

                imageid = "1";

            }

            CommanderEDM _db = new CommanderEDM();
            
            var prodimg = ProductsController.getByImg(int.Parse(imageid));
  //          context.Response.ContentType = "image/png";
//context.Response.BinaryWrite((Byte[])prodimg);

            string url = imageid;
            byte[] imageData;
            using (System.Net.WebClient client = new System.Net.WebClient())
            {
                imageData = prodimg;
            }

            context.Response.ContentType = "image/png";  // Change the content type if necessary
            context.Response.OutputStream.Write(imageData, 0, imageData.Length);
            context.Response.Flush();
            context.Response.End();
            }
            catch (Exception)
            {
                context.Response.Write("alert('failed to load images properly, please reload page');");
            }

        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}
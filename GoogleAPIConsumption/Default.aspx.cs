using GoogleAPIConsumption.Helpers;
using GoogleAPIConsumption.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GoogleAPIConsumption
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected async void SubmitURL_Click(object sender, EventArgs e)
        {
            var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
            string Lurl = LongURL.Text;
            string APIKEY = APIKey.Text;
            Dictionary<string, string> Input = new Dictionary<string, string>();
            Input.Add("longUrl", Lurl);
            GoogleApiRes Response = new GoogleApiRes();
            var response = await HTTP.PostHttpRequestAsync(new Uri("https://www.googleapis.com/urlshortener/v1/url?key="+ APIKEY), Input);
            if (response != null)
            {
                try
                {
                    Response = JsonConvert.DeserializeObject< GoogleApiRes>(response);
                    ShortLink.NavigateUrl = Response.id;
                    ShortLink.Text = Response.id;
                }
                catch (Exception ex)
                { }
            }
        }

    }
}
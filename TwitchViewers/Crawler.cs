using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace TwitchViewers
{
    public class Crawler
    {
        private int PAUSE = 10000;
        private Window form = null;
        
        public Crawler(Window form)
        {
            this.form = form;
        }

        public void Start()
        {
            while (true) {
                String username = getUsername();
                String viewers = getViewers(username);
                Console.WriteLine(username + " " + viewers);
                this.setViewers(viewers);
                Thread.Sleep(this.PAUSE);
            }
            
        }

        private String getUsername()
        {
            return this.form.getUsername();
        }

        private void setViewers(string viewers)
        {
            this.form.setViewers(viewers);
            
            
        }

        private String getViewers(String username)
        {
            String viewers = GET("http://api.twitch.tv/kraken/streams/"+username+"?on_site=1");
            Regex regex = new Regex(@"""viewers"":(\d+)");
            Match match = regex.Match(viewers);
            if (match.Success)
            {
                return match.Groups[1].ToString();
            }
            return "0 (failed)";
        }

        // Returns JSON string
        string GET(string url) 
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            try {
                WebResponse response = request.GetResponse();
                using (Stream responseStream = response.GetResponseStream()) {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    return reader.ReadToEnd();
                }
            }
            catch (WebException ex) {
                WebResponse errorResponse = ex.Response;
                using (Stream responseStream = errorResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));
                    String errorText = reader.ReadToEnd();
                    // log errorText
                }
                //throw;
            }
            return "";
        }
    }
    

}

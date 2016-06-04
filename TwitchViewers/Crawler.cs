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
        private int PAUSE_FAILED = 15000;
        private int PAUSE_SUCCESS = 30000;
        private bool success = false;
        private Window form = null;
        private String originalTitle = "";
        

        public Crawler(Window form)
        {
            this.form = form;
            this.originalTitle = form.Text;
        }

        public void Start()
        {
            while (true) {
                String username = getUsername();
                String viewers = getViewers(username);
                Console.WriteLine(username + " " + viewers);
                this.setViewers(viewers);
                if (this.success) {
                  this.Pause(this.PAUSE_SUCCESS);
                } else {
                  this.Pause(this.PAUSE_FAILED);
                }
            }
            
        }

        private void Pause(int pause) {
          int counter = pause / 1000;
          while (counter-- > 0) {
            this.setTitle(this.originalTitle + " (PAUSE: " + counter + " secs)");
            Thread.Sleep(1000);
          }
        }

        private void setTitle(String title) {
          this.form.setTitle(title);
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
                this.success = true;
                return match.Groups[1].ToString();

            }
            else if (viewers.Equals("")) 
            {
              this.success = false;
              return "0 (failed)";
            }
            this.success = false;
            return "not connected";
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

using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventsArgs e)
        {
            Console.WriteLine("Sending an email with video : " + e.Video.Title);
        }
    }
}

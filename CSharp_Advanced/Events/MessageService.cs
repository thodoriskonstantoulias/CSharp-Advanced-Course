using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventsArgs e)
        {
            Console.WriteLine("Sending a text message with video : " + e.Video.Title);
        }
    }
}

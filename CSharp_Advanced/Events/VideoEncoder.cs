using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Events
{
    public class VideoEncoder
    {
        // public delegate void VideoEncoderEventHandler(object source, VideoEventsArgs args);
        // public event VideoEncoderEventHandler VideoEncoded;

        // new way of declaring an event below
        public event EventHandler<VideoEventsArgs> VideoEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventsArgs() { Video = video});
            }
        }
    }
}

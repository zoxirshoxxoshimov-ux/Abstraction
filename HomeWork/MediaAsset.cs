using System;

namespace Homework
{
    public abstract class MediaAsset
    {
        public MediaAsset(string title)
        {
            Title = title;
        }

        public string Title { get; }

        public abstract string Play();
        public abstract string GetFormat();

        public void ShowTitle()
        {
            Console.WriteLine($"Media: {Title}");
        }
    }

    public class AudioAsset : MediaAsset
    {
        public AudioAsset(string title) : base(title)
        {
        }

        public override string Play()
        {
            return $"Audio ijro etildi: {Title}";
        }

        public override string GetFormat()
        {
            return "Audio format: MP3";
        }
    }

    public class VideoAsset : MediaAsset
    {
        public VideoAsset(string title) : base(title)
        {
        }

        public override string Play()
        {
            return $"Video ijro etildi: {Title}";
        }

        public override string GetFormat()
        {
            return "Video format: MP4";
        }
    }

    public class PodcastAsset : MediaAsset
    {
        public PodcastAsset(string title) : base(title)
        {
        }

        public override string Play()
        {
            return $"Podkast tinglandi: {Title}";
        }

        public override string GetFormat()
        {
            return "Podcast format: MP3";
        }
    }
}
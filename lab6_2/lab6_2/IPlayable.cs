namespace laba6_2
{
    public interface IPlayable : IMedia
    {
        void Play();
        void Pause();
        void Stop();
    }
}

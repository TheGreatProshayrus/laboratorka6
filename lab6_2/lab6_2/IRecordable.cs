namespace laba6_2
{
    public interface IRecordable : IMedia
    {
        void Record();
        void Pause();
        void Stop();
    }
}

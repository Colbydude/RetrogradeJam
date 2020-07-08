namespace RetrogradeJam.Assets
{
    public class Animation
    {
        public int Frames { get; private set; }
        public int Speed  { get; private set; }
        public int StartIndex { get; private set; }

        public Animation(int startIndex, int frames, int speed = 60)
        {
            StartIndex = startIndex;
            Frames = frames;
            Speed = speed;
        }
    }
}

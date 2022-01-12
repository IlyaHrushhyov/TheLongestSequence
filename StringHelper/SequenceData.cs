namespace Helpers
{
    public class SequenceData
    {
        public SequenceData(string character, int count)
        {
            Character = character;
            Count = count;
        }
        public string Character { get; set; }
        public int Count { get; set; }
    }
}

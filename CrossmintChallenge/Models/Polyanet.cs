namespace CrossmintChallenge.Models
{
    public class Polyanet : IAstralObject
    {
        public string CandidateId { get { return "5b2c58ec-3cc8-490b-9e20-74e6f535525c"; } }
        public int Row { get; set; }
        public int Column { get; set; }

        public string GetEndpoint()
        { return "/api/polyanets"; }
        public Polyanet(int row, int column)
        {
            Row = row;
            Column = column;
        }
    }
}

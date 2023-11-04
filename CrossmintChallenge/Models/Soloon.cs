using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossmintChallenge.Models
{
    public class Soloon : IAstralObject
    {
        public string CandidateId { get { return "5b2c58ec-3cc8-490b-9e20-74e6f535525c"; } }
        public int Row { get; set; }
        public int Column { get; set; }
        public string Color { get; set; }

        public string GetEndpoint()
        { return "/api/soloons"; }
        public Soloon(int row, int column, string color)
        {
            Row = row;
            Column = column;
            Color = color;
        }
    }
}

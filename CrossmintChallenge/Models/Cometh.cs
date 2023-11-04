using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossmintChallenge.Models
{
    public class Cometh : IAstralObject
    {
        public string CandidateId { get { return "5b2c58ec-3cc8-490b-9e20-74e6f535525c"; } }
        public int Row { get; set; }
        public int Column { get; set; }
        public string Direction { get; set; }

        public string GetEndpoint()
        { return "/api/comeths"; }
        public Cometh(int row, int column, string direction)
        {
            Row = row;
            Column = column;
            Direction = direction;
        }
    }
}

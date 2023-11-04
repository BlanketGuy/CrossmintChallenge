using CrossmintChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CrossmintChallenge
{
    public class PhaseOne
    {
        public static async Task Solution(Megaverse megaverse)
        {
            Polyanet polyanet;

            for (int i = 2; i < 9; i++)
            {
                polyanet = new(i,i);
                await megaverse.CreateAstralObject(polyanet);
                polyanet = new(i, 10 - i);
                await megaverse.CreateAstralObject(polyanet);
            }
        }
    }
}

using CrossmintChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CrossmintChallenge
{
    public static class PhaseTwo
    {
        public static async Task Solution(Megaverse megaverse)
        {
            IAstralObject astralObject = null;
            for (int i = 0; i < megaverse.Goal.Length; i++)
            {
                for (int j = 0; j < megaverse.Goal[i].Length; j++)
                {
                    var goalObject = megaverse.Goal[i][j].ToLower();
                    if (goalObject != "space")
                    {
                        switch (goalObject)
                        {
                            case "polyanet":
                                astralObject = new Polyanet(i, j);
                                break;
                            case "up_cometh":
                            case "down_cometh":
                            case "left_cometh":
                            case "right_cometh":
                                astralObject = new Cometh(i, j, goalObject.Split('_')[0]);
                                break;
                            case "blue_soloon":
                            case "red_soloon":
                            case "purple_soloon":
                            case "white_soloon":
                                astralObject = new Soloon(i, j, goalObject.Split('_')[0]);
                                break;
                        }
                        await megaverse.CreateAstralObject(astralObject);
                    }
                }
            }
        }
    }
}

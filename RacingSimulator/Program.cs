using System;
using RacingSimulator.RaceWithBuilder;
using RacingSimulator.RaceWithFactory;
using RacingSimulator.RaceWithFactory.Factories;
using RacingSimulator.Transport;
using static System.Console;

namespace RacingSimulator
{
    internal static class Program
    {
        static void Main()
        {
            try
            {

                var races = new ITransportRaceFactory[]
                {
                    new AirTransportRaceFactory(), new AllTransportRaceFactory(), new LandTransportRaceFactory(),
                };
                WriteLine("Demonstration of the race using the factory pattern.");
                WriteLine(races[0].CreatRace()
                    .AddCompetitor(new Stupa()).AddCompetitor(new Broom()).AddCompetitor(new MagicCarpet())
                    .AddDistance(11).StartGame().ToString());
                WriteLine(races[1].CreatRace()
                    .AddCompetitor(new Stupa()).AddCompetitor(new Broom()).AddCompetitor(new MagicCarpet())
                    .AddCompetitor(new Centaur()).AddCompetitor(new BactrianCamel()).AddCompetitor(new SpeedCamel())
                    .AddCompetitor(new AllTerrainBoots())
                    .AddDistance(1000).StartGame().ToString());
                WriteLine(races[2].CreatRace()
                    .AddCompetitor(new Centaur()).AddCompetitor(new BactrianCamel()).AddCompetitor(new SpeedCamel())
                    .AddCompetitor(new AllTerrainBoots())
                    .AddDistance(1).StartGame().ToString());

                WriteLine();
                WriteLine("Demonstration of the race using the builder pattern.");
                var raceAir = new AirTransportRaceBuilder();
                WriteLine(raceAir.AddCompetitor(new Stupa()).AddCompetitor(new Broom())
                    .AddCompetitor(new MagicCarpet())
                    .AddDistance(1).Build().StartGame().ToString());
                var raceMix = new AllTransportRaceBuilder();
                WriteLine(raceMix.AddCompetitor(new Stupa()).AddCompetitor(new Broom())
                    .AddCompetitor(new MagicCarpet()).AddCompetitor(new Centaur()).AddCompetitor(new BactrianCamel())
                    .AddCompetitor(new SpeedCamel()).AddCompetitor(new AllTerrainBoots())
                    .AddDistance(100000).Build().StartGame().ToString());
                var raceLand = new LandTransportRaceBuilder();
                WriteLine(raceLand.AddCompetitor(new Centaur()).AddCompetitor(new BactrianCamel())
                    .AddCompetitor(new SpeedCamel()).AddCompetitor(new AllTerrainBoots())
                    .AddDistance(1000).Build().StartGame().ToString());
            }
            catch (Exception e)
            {
                Error.WriteLine(e.Message);
            }
        }
    }
}
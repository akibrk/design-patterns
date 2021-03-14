using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Design_Patterns.Structural.Composite
{
    public class CompositePatternApp
    {
        public CompositePatternApp()
        {
            IRacingSeriesComponent f1 = new RacingSeries("Formula 1", "Formula 1 is the pinnacle of motorsport");
            IRacingSeriesComponent f4 = new RacingSeries("Formula 4", "Formula 4 is a feeder series for Formula 1");
            IRacingSeriesComponent motoGP = new RacingSeries("MotoGP", "MotoGP is the top tier of motor bike racing");
            IRacingSeriesComponent motoGP3 = new RacingSeries("MotoGP 3", "MotoGP is the feeder series for MotoGP");
            
            motoGP.AddRacingSeriesComponent(motoGP3);

            IRacingSeriesComponent allRacingSeries = new RacingSeries("All Racing", "All the racing done");

            f1.AddRacingSeriesComponent(f4);
            f1.AddNewRace(new Race("Bahrain International Circuit", "Bahrain", new DateTime(2021, 3, 29)));

            allRacingSeries.AddRacingSeriesComponent(f1);
            allRacingSeries.AddRacingSeriesComponent(motoGP);




        }
    }



    /// <summary>
    /// Component
    /// </summary>
    interface IRacingSeriesComponent
    {
        public void AddRacingSeriesComponent(IRacingSeriesComponent component);
        public void RemoveRacingSeriesComponent(IRacingSeriesComponent component);
        public string GetRacingSeriesDescription();
        public string GetRacingSeriesName();
        void AddNewRace(Race race);
    }

    /// <summary>
    /// Leaf
    /// </summary>
    class Race
    {
        private readonly string track;
        private readonly string country;
        private readonly DateTime raceDate;

        public Race(string track, string hostCountry, DateTime raceDate)
        {
            this.track = track;
            this.country = hostCountry;
            this.raceDate = raceDate;
        }

        public string GetRaceInfo()
        {
            return $"Track: {track}\nHost: {country}\nRace Day: {raceDate.ToShortDateString()}";
        }
    }
    class RacingSeries : IRacingSeriesComponent
    {
        protected List<IRacingSeriesComponent> racingSeriesComponents;
        protected string Name { get; set; }
        protected string Description { get; set; }

        protected List<Race> races;

        public RacingSeries(string name, string description)
        {
            Name = name;
            Description = description;
            racingSeriesComponents = new List<IRacingSeriesComponent>();
            this.races = new List<Race>();
        }
        public void AddRacingSeriesComponent(IRacingSeriesComponent component)
        {
            racingSeriesComponents.Add(component);   
        }

        public string GetRacingSeriesDescription()
        {
            return this.Description;
        }

        public string GetRacingSeriesName()
        {
            return this.Name;
        }

        public void RemoveRacingSeriesComponent(IRacingSeriesComponent component)
        {
            racingSeriesComponents.Remove(component);
        }


        public void AddNewRace(Race race)
        {
            this.races.Add(race);
        }

        public string GetRaceInfo(int raceIndex)
        {
            if(races.Count() <= raceIndex)
            {
                throw new IndexOutOfRangeException("Calender is smaller than that");
            }
            return this.races[raceIndex].GetRaceInfo();
        }

    }


    /// <summary>
    /// Further dividing
    /// </summary>
    class Formula : RacingSeries
    {
        public Formula(string name, string description)
            : base(name, description)
        {

        }
    }

    class MotoGP : RacingSeries
    {
        public MotoGP(string name, string description)
            : base(name, description)
        {

        }
    }



}

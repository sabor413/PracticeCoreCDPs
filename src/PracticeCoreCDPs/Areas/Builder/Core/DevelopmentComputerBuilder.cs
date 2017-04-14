using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeCoreCDPs.Areas.Builder.Core
{
    public class DevelopmentComputerBuilder : IComputerBuilder
    {
        private Computer computer;

        public DevelopmentComputerBuilder()
        {
            computer = new Computer {Parts = new List<ComputerPart>()};
        }
        public void AddCPU()
        {
            using (AppDbComputerParts db = new AppDbComputerParts())
            {
                var query = from p in db.ComputerParts
                            where p.UseType == "DEV" && p.Part == "CPU"
                            select p;
                computer.Parts.Add(query.SingleOrDefault());
            }
        }

        public void AddCabinet()
        {
            using (AppDbComputerParts db = new AppDbComputerParts())
            {
                var query = from p in db.ComputerParts
                            where p.UseType == "DEV" && p.Part == "CABINET"
                            select p;
                computer.Parts.Add(query.SingleOrDefault());
            }
        }

        public void AddMouse()
        {
            using (AppDbComputerParts db = new AppDbComputerParts())
            {
                var query = from p in db.ComputerParts
                            where p.UseType == "DEV" && p.Part == "MOUSE"
                            select p;
                computer.Parts.Add(query.SingleOrDefault());
            }
        }

        public void AddKeyboard()
        {
            using (AppDbComputerParts db = new AppDbComputerParts())
            {
                var query = from p in db.ComputerParts
                            where p.UseType == "DEV" && p.Part == "KEYBOARD"
                            select p;
                computer.Parts.Add(query.SingleOrDefault());
            }
        }

        public void AddMonitor()
        {
            using (AppDbComputerParts db = new AppDbComputerParts())
            {
                var query = from p in db.ComputerParts
                            where p.UseType == "DEV" && p.Part == "MONITOR"
                            select p;
                computer.Parts.Add(query.SingleOrDefault());
            }
        }

        public Computer GetComputer()
        {
            return computer;
        }
    }
}

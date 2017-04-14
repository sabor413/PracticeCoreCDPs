using System.Collections.Generic;
using System.Linq;

namespace PracticeCoreCDPs.Areas.Builder.Core
{
    public class OfficeComputerBuilder : IComputerBuilder
    {
        private Computer computer;

        public OfficeComputerBuilder()
        {
            computer = new Computer { Parts = new List<ComputerPart>() };
        }
        public void AddCPU()
        {
            using (AppDbComputerParts db = new AppDbComputerParts())
            {
                var query = from p in db.ComputerParts
                            where p.UseType == "OFFICE" && p.Part == "CPU"
                            select p;
                computer.Parts.Add(query.SingleOrDefault());
            }
        }

        public void AddCabinet()
        {
            using (AppDbComputerParts db = new AppDbComputerParts())
            {
                var query = from p in db.ComputerParts
                            where p.UseType == "OFFICE" && p.Part == "CABINET"
                            select p;
                computer.Parts.Add(query.SingleOrDefault());
            }
        }

        public void AddMouse()
        {
            using (AppDbComputerParts db = new AppDbComputerParts())
            {
                var query = from p in db.ComputerParts
                            where p.UseType == "OFFICE" && p.Part == "MOUSE"
                            select p;
                computer.Parts.Add(query.SingleOrDefault());
            }
        }

        public void AddKeyboard()
        {
            using (AppDbComputerParts db = new AppDbComputerParts())
            {
                var query = from p in db.ComputerParts
                            where p.UseType == "OFFICE" && p.Part == "KEYBOARD"
                            select p;
                computer.Parts.Add(query.SingleOrDefault());
            }
        }

        public void AddMonitor()
        {
            using (AppDbComputerParts db = new AppDbComputerParts())
            {
                var query = from p in db.ComputerParts
                            where p.UseType == "OFFICE" && p.Part == "MONITOR"
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

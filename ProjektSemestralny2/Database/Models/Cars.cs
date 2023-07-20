
namespace ProjektSemestralny
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cars
    {
        public int State { get; set; }
        public int CarMileage { get; set; }
        public int Year { get; set; }
        public int Id { get; set; }
        public int Engine { get; set; }
        public int Color { get; set; }
        public string CarName { get; set; }

        public virtual Colors Colors { get; set; }
        public virtual Engines Engines { get; set; }
        public virtual States States { get; set; }

    }
}

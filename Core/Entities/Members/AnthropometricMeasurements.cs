using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson.Serialization.Attributes;

namespace Core.Entities.Members
{
    public class AnthropometricMeasurements
    {
        public double RightArm { get; set; }
        public double LeftArm { get; set; }
        public double Chest { get; set; }
        public double Waist { get; set; }
        public double Abdomen { get; set; }
        public double RightThigh { get; set; }
        public double LeftThigh { get; set; }

        public double Weight { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime RegisterDate { get; set; }

    }
}

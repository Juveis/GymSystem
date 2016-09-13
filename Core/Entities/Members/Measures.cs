using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Entities.Members
{
    public class Measures
    {
        public double Weight { get; set; }
        public List<AnthropometricMeasurements> AnthropometricMeasurementses { get; set; }
    }
}

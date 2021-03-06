﻿using System.Runtime.Serialization;

namespace EntityFX.EconomicsArcade.Contract.Common.Counters
{
    [DataContract]
    public class GenericCounter : CounterBase
    {
        [DataMember]
        public decimal Bonus { get; set; }
        [DataMember]
        public int BonusPercentage { get; set; }
        [DataMember]
        public int Inflation { get; set; }
        [DataMember]
        public bool UseInAutoSteps { get; set; }
        [DataMember]
        public decimal SubValue { get; set; }
    }
}
﻿using System;
using EntityFX.EconomicsArcade.Contract.Common.Incrementors;
using EntityFX.EconomicsArcade.DataAccess.Model;
using EntityFX.EconomicsArcade.Infrastructure.Common;

namespace EntityFX.EconomicsArcade.DataAccess.Repository.Mappers
{
    public class IncrementorContractMapper : IMapper<IncrementorEntity, Incrementor>
    {
        public Incrementor Map(IncrementorEntity source, Incrementor destionation = null)
        {
            destionation = destionation ?? new Incrementor();
            destionation.IncrementorType = (IncrementorTypeEnum) source.Type;
            destionation.Value = Convert.ToInt32(source.Value);
            return destionation;
        }
    }
}
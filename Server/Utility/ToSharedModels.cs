﻿using System.Linq;

namespace daedalus.Server.Utility
{
    static public class ToSharedModels
    {
        static public Shared.Model.Condition ToSharedCondition(this Database.Condition model)
        {
            var condition = new Shared.Model.Condition()
            {
                Id = model.Id,
                LoggedAt = model.LoggedAt,
                DegreesCelsius = model.DegreesCelsius,
                HumidityPercentage = model.HumidityPercentage,
                PressureMillibars = model.PressureMillibars
            };

            return condition;
        }

        static public Database.Condition ToCondition(this Shared.Model.Condition model)
        {
            var condition = new Database.Condition()
            {
                Id = model.Id,
                LoggedAt = model.LoggedAt,
                DegreesCelsius = model.DegreesCelsius,
                HumidityPercentage = model.HumidityPercentage,
                PressureMillibars = model.PressureMillibars
            };

            return condition;
        }
    }
}

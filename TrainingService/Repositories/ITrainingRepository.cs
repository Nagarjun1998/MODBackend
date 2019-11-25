﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingService.Models;
namespace TrainingService.Repositories
{
    public interface ITrainingRepository
    {
        void Add(Training item);
        
        void Update(Training item);
        IEnumerable<Training> GetAll();
        
    }
}
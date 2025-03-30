﻿using DAL.Interfaces;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class EmpleadoDALImpl : GenericDALImpl<Empleado>, IEmpleadoDAL
    {
        QuizContext _context;

        public EmpleadoDALImpl(QuizContext context)
            : base(context)
        {
            _context = context;
        }
    }
}

﻿using EF_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Layer
{
    public interface IRepo
    {
        List<Patient> GetAllPatient();
        Patient AddPatient(Patient patient);
        Patient UpdatePatient(Patient patient);
        Patient GetByID(int id);
    }
}

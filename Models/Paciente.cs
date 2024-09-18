﻿using Java.Sql;
using Microsoft.VisualBasic;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaUTP.Models
{
    public class Paciente
    {
        [PrimaryKey, AutoIncrement]

        public int Id { get; set; }

        public string Nombre { get; set; }    

        public string Apellido { get; set; }

        public string Correo { get; set; }

        public string Cedula { get; set; }

        public string Direccion { get; set; }

        public Date FechaDeNacimiento { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrestamosPersona.Models
{
    public class Prestamo
    {
        [Key]
        [Required(ErrorMessage = "El campo Id no puede estar vacío.")]
        [Range(0, 1000000, ErrorMessage = "El campo Id no puede ser menor que cero o mayor a 1000000.")]
        public int PrestamoId { get; set; }

        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "El campo fecha no puede estar vacío.")]
        [DisplayFormat(DataFormatString = "{0:dd,mm, yyyy}")]
        public DateTime Fecha { get; set; }

        public int PersonaId { get; set; }

        [Required(ErrorMessage = "El campo concepto no puede estar vacía.")]
        [MinLength(5, ErrorMessage = "El concepto es muy corta.")]
        [MaxLength(40, ErrorMessage = "El concepto debe contener menos de 60 caracteres.")]
        public string Concepto { get; set; }

        [Required(ErrorMessage = "El campo monto no puede estar vacio.")]
        [Range(1, 100000000, ErrorMessage = "El rango es de 1 a 1000000.")]
        public decimal Monto { get; set; }
        [Required(ErrorMessage = "El campo balance no puede estar vacio.")]
        public decimal Balance { get; set; }

        public Prestamo()
        {
            PrestamoId = 0;
            Fecha = DateTime.Now;
            PersonaId = 0;
            Concepto = string.Empty;
            Monto = 0;
            Balance = 0;
        }

        public Prestamo(int prestamoId, DateTime fecha, int personaId, string concepto, decimal monto, decimal balance)
        {
            PrestamoId = prestamoId;
            Fecha = fecha;
            PersonaId = personaId;
            Concepto = concepto;
            Monto = monto;
            Balance = balance;
        }
    }
}
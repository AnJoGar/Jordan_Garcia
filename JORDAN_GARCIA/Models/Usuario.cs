using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using JORDAN_GARCIA.Models;
using System.Collections.Generic;

namespace JORDAN_GARCIA.Models
{
  public class Usuario
  {

    public int Id { get; set; }

    [Required]
    [Column(TypeName = "varchar(10)")]

    public string NombreUsuario { get; set; }


    [Required]
    [Column(TypeName = "varchar(10)")]

    public string clave { get; set; }

    [Required]
    public Boolean estado { get; set; }

    public int GeneroId { get; set; }

    public Genero Genero { get; set; }

  }
}

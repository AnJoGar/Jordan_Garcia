
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using JORDAN_GARCIA.Models;
using System.Collections.Generic;
namespace JORDAN_GARCIA.Models
{
  public class Genero
  {
    public int Id { get; set; }
    public string nombre { get; set; }
    public Boolean estado { get; set; }



  }
}

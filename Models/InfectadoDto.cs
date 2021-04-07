using System;

namespace dio_mongo_api.Models
{
  public class InfectadoDto
  {
    public DateTime DataNascimento { get; set; }
    public string Sexo { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
  }
}
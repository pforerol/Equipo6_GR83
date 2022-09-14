using System;
using System.ComponentModel.DataAnnotations;
namespace ProyectoCiclo3.App.Dominio{
    public class Estaciones{
 
        public int id {get;set;} 
        [Required, StringLength(30,  MinimumLength = 3, ErrorMessage = "Maximo 30 characters")]
        public string nombre {get;set;}            
        public string direccion {get;set;}            
        public string coord_x {get;set;}            
        public string coord_y {get;set;}            
        public string tipo {get;set;}            
           
    }
}
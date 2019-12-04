using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace DTO
{

    public class DTOVentaCompleta
    {
       
        public int Id { get; set; }
      
        public string NombreApellido { get; set; }
 
        public string Tipo { get; set; }
   
        public string Estado { get; set; }
        
        public DateTime Fecha { get; set; }

        

    }



}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductEnum.Models
{
    public enum CategoryType
    { 
        Electronicos=10,
        Alimenticios=20,
        Moda=30,
        Belleza=40,
        Auotmotriz=50,
        Libros=60
    
    }

    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [Display(Name ="Nombre del producto")]
        [Required(ErrorMessage ="Debe insgresar el nombre del producto")]
        public string Name { get; set; }
        [Display(Name = "Categoria")]
        [Required(ErrorMessage = "Debe insgresar la categoria del producto")]
        public CategoryType Category { get; set; }



    }


}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZadatakProizvod.Models
{
    [Table("Proizvod")]
    public class Proizvod
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Unesite naziv")]
        [StringLength(30,ErrorMessage ="Može biti uneto najviše 30 karaktera")]
        public string Naziv { get; set; }

        [Required(ErrorMessage = "Unesite opis proizvoda")]
        [StringLength(30, ErrorMessage = "Može biti uneto najviše 30 karaktera")]
        public string Opis { get; set; }

        [Required(ErrorMessage = "Unesite Kategoriju proizvoda")]
        [StringLength(30, ErrorMessage = "Može biti uneto najviše 30 karaktera")]
        public string Kategorija { get; set; }

        [Required(ErrorMessage = "Unesite proizvodjača")]
        [StringLength(30, ErrorMessage = "Može biti uneto najviše 30 karaktera")]
        public string Proizvodjac { get; set; }

        [Required(ErrorMessage = "Unesite dobavljača")]
        [StringLength(30, ErrorMessage = "Može biti uneto najviše 30 karaktera")]
        public string Dobavljac { get; set; }

        [Required(ErrorMessage = "Unesite cenu")]
        public int Cena { get; set; }



     

    }


}

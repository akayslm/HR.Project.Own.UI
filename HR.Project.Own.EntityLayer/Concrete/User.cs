using HR.Project.Own.EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Project.Own.EntityLayer.Concrete
{
    public class User : BaseEntity
    {
        public string Adi { get; set; }
        public string? Adi2 { get; set; }
        public string Soyadi { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string DogumYeri { get; set; }
        public string TCNo { get; set; }
        public DateTime IseGirisTarihi { get; set; }
        public DateTime? IstenCikisTarihi { get; set; }
        public string Meslek { get; set; }
        public string Departman { get; set; }
        public string Email { get; set; }
        public string Adres { get; set; }
        public string CepTelefonu { get; set; }
    }
}

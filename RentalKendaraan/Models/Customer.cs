using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_004.Models
{
    public partial class Customer
    {
        public int IdCustomer { get; set; }

        [Required(ErrorMessage = "Nama Customer Tidak Boleh Kosong")]
        public string NamaCustomer { get; set; }

        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya Boleh Diisi Oleh Angka")]
        public string Nik { get; set; }

        [Required(ErrorMessage = "Alamat Tidak Boleh Kosong")]
        public string Alamat { get; set; }

        [MinLength(10, ErrorMessage = "No HP minimal 10 angka")]
        [MaxLength(13, ErrorMessage = "No HP maksimal 13 angka")]
        public string NoHp { get; set; }

        public int? IdGender { get; set; }
        public object IdGenderNavigation { get; internal set; }
        public IEnumerable<Peminjaman> Peminjaman { get; internal set; }
    }
}

using System;
using System.Collections.Generic;

namespace RentalKendaraan_004.Models
{
    public partial class Kendaraan
    {
        internal readonly object IdJenisKendaraanNavigation;

        public int IdKendaraan { get; set; }
        public string NamaKendaraan { get; set; }
        public string NoPolisi { get; set; }
        public string NoStnk { get; set; }
        public int? IdJenisKendaraan { get; set; }
        public string Ketersediaan { get; set; }
    }
}

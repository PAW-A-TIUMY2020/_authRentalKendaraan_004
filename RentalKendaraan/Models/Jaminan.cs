using System;
using System.Collections.Generic;

namespace RentalKendaraan_004.Models
{
    public partial class Jaminan
    {
        public int IdJaminan { get; set; }
        public string NamaJaminan { get; set; }
        public IEnumerable<Peminjaman> Peminjaman { get; internal set; }
    }
}

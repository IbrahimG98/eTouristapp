using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eTouristapp.Models.Request
{
    public class TerminInsertRequest
    {
        public int Id { get; set; }
        [Required]
        public int DestinacijaId { get; set; }
        public decimal Cijena { get; set; }
        public float Popust { get; set; }
        public int HotelId { get; set; }
        public decimal? CijenaPopust { get; set; }
        public bool AktivanTermin { get; set; }
        public DateTime DatumPolaska { get; set; }
        public DateTime DatumDolaska { get; set; }
        public int GradId { get; set; }
    }
}

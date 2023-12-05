using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reppair_App.Models
{
    public class Engine
    {
        [Key]
        public int EngineId { get; set; }
        public string? EngineType { get; set; }
        public EngineEuroType EuroType { get; set; }

        public enum EngineEuroType
        {
            Euro1,
            Euro2,
            Euro3,
            Euro4,
            Euro5,
            Euro6,
            Euro7,
            Euro8,
            Euro9,
            Euro10
        }


    }
}

using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoAlek.Models
{
    public class Todos
    {
        public int Id { get; set; }
        public DateTime TimeExpire { get; set; }
        public string TitleJob { get; set; }
        public string DescriptionJob { get; set; }
        public int PercentageComplete { get; set; }
        public byte IsComplete { get; set; }
    }
}

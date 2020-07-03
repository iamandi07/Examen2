using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Examen2.Model
{
    public class Equipments
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public string EquipementType { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
        public long PersonId { get; set; }
        public Person Person { get; set; }
        public long InspectionPlanId { get; set; }
        public InspectionPlan InpectionPlan { get; set; }
        public DateTime CalibrationDate { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PRG1_MAUI_ERP_Activum.Models
{
    public class Insurance
    {
        public string Id { get; set;  } = Guid.NewGuid().ToString();
        public string InsuranceNumber { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Status {  get; set; } = string.Empty;
        public string Description {  get; set; } = string.Empty;
    }
}

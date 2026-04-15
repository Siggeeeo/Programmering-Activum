using PRG1_MAUI_ERP_Activum.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PRG1_MAUI_ERP_Activum.ViewModels
{
    public class InsuranceViewModel
    {
        public ObservableCollection<Insurance> Insurances { get; set; } = new();
        private List<Insurance> _allInsurances = new();

        public InsuranceViewModel() {
            LoadTestData();
        }

        private void LoadTestData()
        {
            _allInsurances.Add(new Insurance { InsuranceNumber = "11-22-33", Type = "Brand", Status = "Under utredning", Description = "Brand i köket" });
            _allInsurances.Add(new Insurance { InsuranceNumber = "44-555-66", Type = "Vattenskada", Status = "Avslutad", Description = "Vattenskada på golv" });

            UpdateVisibleList(_allInsurances);
        }

        public void SearchInsurance(string searchText)
        {
            if (string.IsNullOrEmpty(searchText))
            {
                UpdateVisibleList(_allInsurances);

                return;
            }

            var filtered = _allInsurances.Where(i =>
            i.InsuranceNumber.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
            i.Type.Contains(searchText, StringComparison.OrdinalIgnoreCase)).ToList();
                
            UpdateVisibleList(filtered);
                    
            }
        

        private void UpdateVisibleList(IEnumerable<Insurance> list)
        {
            Insurances.Clear();
            foreach (var ins in list)
            {
                Insurance.Add(ins);
            }
        
        }
    }
}


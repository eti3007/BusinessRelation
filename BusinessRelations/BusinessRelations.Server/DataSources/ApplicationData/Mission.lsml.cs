using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class Mission
    {
        partial void dateFin_Validate(EntityValidationResultsBuilder results)
        {
            // RDG : la durée minimum d'une mission est de 7 jours
            if (this.dateFin != null && this.dateFin <= this.dateDebut.AddDays(7)) {
                results.AddPropertyError(string.Format("La date de fin doit être supérieur au {0}", 
                    this.dateDebut.AddDays(7).ToShortDateString()));
            }
        }

        partial void nombreJour_Compute(ref string result)
        {
            TimeSpan? ts = null;
            string msg = "{0}";

            if (this.dateFin != null) {
                ts = this.dateFin - this.dateDebut;
                msg = "nombre de jours {0}";
            }
            else
                if (this.dateDebut < DateTime.Now) {
                    ts = DateTime.Now - this.dateDebut;
                    msg = "actuellement {0} jours";
                }

            if (ts.HasValue) {
                result = string.Format(msg, ts.Value.Days.ToString());
            }
        }
    }
}

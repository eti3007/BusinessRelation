using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;

namespace LightSwitchApplication
{
    public partial class MissionCreateNew
    {
        partial void MissionCreateNew_InitializeDataWorkspace(global::System.Collections.Generic.List<global::Microsoft.LightSwitch.IDataService> saveChangesTo)
        {
            if (this.MissionId.HasValue) {
                this.MissionProperty = this.DataWorkspace.ApplicationData.Missions_Single(this.MissionId.Value);
                this.DisplayName = "Editer mission";
            }
            else {
                this.MissionProperty = new Mission();
                this.DisplayName = "Ajouter mission";
            }
        }

        partial void MissionCreateNew_Saved()
        {
            this.Close(true);
            Application.Current.ShowMissionEnCoursSearch();
        }
    }
}
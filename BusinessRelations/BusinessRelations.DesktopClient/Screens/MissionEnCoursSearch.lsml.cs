﻿using System;
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
    public partial class MissionEnCoursSearch
    {
        partial void gridAddNew_CanExecute(ref bool result)
        {
            // Write your code here.

        }

        partial void gridAddNew_Execute()
        {
            Application.Current.ShowMissionCreateNew(null);
        }

        partial void gridEditSelected_CanExecute(ref bool result)
        {
            // Write your code here.

        }

        partial void gridEditSelected_Execute()
        {
            Application.Current.ShowMissionCreateNew(this.MissionEnCours.SelectedItem.Id);
        }
    }
}

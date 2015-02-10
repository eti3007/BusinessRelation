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
    public partial class CommercialsEditGrid
    {

        partial void gridEditSelected_CanExecute(ref bool result)
        {
            // on peut vérifier ici si l'utilisateur à les droits nécessaire pour utiliser ce bouton 
            // ex : result = this.Commercials.CanEdit;
        }

        partial void gridEditSelected_Execute()
        {
            Application.Current.ShowCommercialsDetail(this.Commercials.SelectedItem.Id);
        }
    }
}

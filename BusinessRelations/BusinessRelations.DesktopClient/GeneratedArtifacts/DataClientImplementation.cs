﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication.Implementation
{
    
    #region Collaborateur
    [global::System.Runtime.Serialization.DataContract(Namespace = "http://schemas.datacontract.org/2004/07/ApplicationData.Implementation")]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Collaborateur :
        global::LightSwitchApplication.Collaborateur.DetailsClass.IImplementation
    {
        partial void OnIdChanged()
        {
            this.___OnPropertyChanged("Id");
        }
        
        partial void OnnomChanged()
        {
            this.___OnPropertyChanged("nom");
        }
        
        partial void OnprenomChanged()
        {
            this.___OnPropertyChanged("prenom");
        }
        
        partial void OnemailChanged()
        {
            this.___OnPropertyChanged("email");
        }
        
        partial void OnportableChanged()
        {
            this.___OnPropertyChanged("portable");
        }
        
        partial void OnPortraitChanged()
        {
            this.___OnPropertyChanged("Portrait");
        }
        
        partial void OnCreatedByChanged()
        {
            this.___OnPropertyChanged("CreatedBy");
        }
        
        partial void OnCreatedChanged()
        {
            this.___OnPropertyChanged("Created");
        }
        
        partial void OnModifiedByChanged()
        {
            this.___OnPropertyChanged("ModifiedBy");
        }
        
        partial void OnModifiedChanged()
        {
            this.___OnPropertyChanged("Modified");
        }
        
        partial void OnRowVersionChanged()
        {
            this.___OnPropertyChanged("RowVersion");
        }
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.Collaborateur.DetailsClass.IImplementation.Missions
        {
            get
            {
                return this.Missions;
            }
        }
        
        internal global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.Mission> __Missions
        {
            get
            {
                if (this.___Missions == null)
                {
                    this.___Missions = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.Mission>(
                        this,
                        "Missions",
                        () => this._Missions,
                        e => global::System.Object.Equals(e.Mission_Collaborateur, this.Id));
                }
                return this.___Missions;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.Mission> ___Missions;
        
    }
    #endregion
    
    #region Commercial
    [global::System.Runtime.Serialization.DataContract(Namespace = "http://schemas.datacontract.org/2004/07/ApplicationData.Implementation")]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Commercial :
        global::LightSwitchApplication.Commercial.DetailsClass.IImplementation
    {
        partial void OnIdChanged()
        {
            this.___OnPropertyChanged("Id");
        }
        
        partial void OnnomChanged()
        {
            this.___OnPropertyChanged("nom");
        }
        
        partial void OnprenomChanged()
        {
            this.___OnPropertyChanged("prenom");
        }
        
        partial void OnGradeChanged()
        {
            this.___OnPropertyChanged("Grade");
        }
        
        partial void OnCreatedByChanged()
        {
            this.___OnPropertyChanged("CreatedBy");
        }
        
        partial void OnCreatedChanged()
        {
            this.___OnPropertyChanged("Created");
        }
        
        partial void OnModifiedByChanged()
        {
            this.___OnPropertyChanged("ModifiedBy");
        }
        
        partial void OnModifiedChanged()
        {
            this.___OnPropertyChanged("Modified");
        }
        
        partial void OnRowVersionChanged()
        {
            this.___OnPropertyChanged("RowVersion");
        }
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.Commercial.DetailsClass.IImplementation.Missions
        {
            get
            {
                return this.Missions;
            }
        }
        
        internal global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.Mission> __Missions
        {
            get
            {
                if (this.___Missions == null)
                {
                    this.___Missions = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.Mission>(
                        this,
                        "Missions",
                        () => this._Missions,
                        e => global::System.Object.Equals(e.Mission_Commercial, this.Id));
                }
                return this.___Missions;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.Mission> ___Missions;
        
    }
    #endregion
    
    #region Mission
    [global::System.Runtime.Serialization.DataContract(Namespace = "http://schemas.datacontract.org/2004/07/ApplicationData.Implementation")]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Mission :
        global::LightSwitchApplication.Mission.DetailsClass.IImplementation
    {
        partial void OnMission_CommercialChanged()
        {
            this.___OnPropertyChanged("Mission_Commercial");
            this.___OnPropertyChanged("Commercial");
        }
        
        partial void OnMission_CollaborateurChanged()
        {
            this.___OnPropertyChanged("Mission_Collaborateur");
            this.___OnPropertyChanged("Collaborateur");
        }
        
        partial void OnIdChanged()
        {
            this.___OnPropertyChanged("Id");
        }
        
        partial void OndateDebutChanged()
        {
            this.___OnPropertyChanged("dateDebut");
        }
        
        partial void OndateFinChanged()
        {
            this.___OnPropertyChanged("dateFin");
        }
        
        partial void OnnomClientChanged()
        {
            this.___OnPropertyChanged("nomClient");
        }
        
        partial void OnposteOccupeChanged()
        {
            this.___OnPropertyChanged("posteOccupe");
        }
        
        partial void OnCreatedByChanged()
        {
            this.___OnPropertyChanged("CreatedBy");
        }
        
        partial void OnCreatedChanged()
        {
            this.___OnPropertyChanged("Created");
        }
        
        partial void OnModifiedByChanged()
        {
            this.___OnPropertyChanged("ModifiedBy");
        }
        
        partial void OnModifiedChanged()
        {
            this.___OnPropertyChanged("Modified");
        }
        
        partial void OnRowVersionChanged()
        {
            this.___OnPropertyChanged("RowVersion");
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Mission.DetailsClass.IImplementation.Commercial
        {
            get
            {
                return this.Commercial;
            }
            set
            {
                this.Commercial = (global::LightSwitchApplication.Implementation.Commercial)value;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Commercial> __Commercial
        {
            get
            {
                if (this.___Commercial == null)
                {
                    this.___Commercial = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Commercial>(
                        this,
                        "Commercial",
                        new string[] { "Mission_Commercial" },
                        e => global::System.Object.Equals(e.Id, this.Mission_Commercial),
                        () => this._Commercial,
                        e => this._Commercial = e);
                }
                return this.___Commercial;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Commercial> ___Commercial;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Mission.DetailsClass.IImplementation.Collaborateur
        {
            get
            {
                return this.Collaborateur;
            }
            set
            {
                this.Collaborateur = (global::LightSwitchApplication.Implementation.Collaborateur)value;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Collaborateur> __Collaborateur
        {
            get
            {
                if (this.___Collaborateur == null)
                {
                    this.___Collaborateur = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Collaborateur>(
                        this,
                        "Collaborateur",
                        new string[] { "Mission_Collaborateur" },
                        e => global::System.Object.Equals(e.Id, this.Mission_Collaborateur),
                        () => this._Collaborateur,
                        e => this._Collaborateur = e);
                }
                return this.___Collaborateur;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Collaborateur> ___Collaborateur;
        
    }
    #endregion
    
    #region ApplicationData
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class ApplicationData
    {
        protected override global::Microsoft.LightSwitch.Internal.IEntityImplementation CreateEntityImplementation<T>()
        {
            if (typeof(T) == typeof(global::LightSwitchApplication.Collaborateur))
            {
                return new global::LightSwitchApplication.Implementation.Collaborateur();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.Commercial))
            {
                return new global::LightSwitchApplication.Implementation.Commercial();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.Mission))
            {
                return new global::LightSwitchApplication.Implementation.Mission();
            }
            return null;
        }
        
        protected override void InitializeDataServiceContext()
        {
            this.Format.LoadServiceModel = global::LightSwitchApplication.Implementation.ApplicationData.GeneratedEdmModel.GetInstance;
            this.Format.UseJson();
        }
    }
    #endregion
    
    #region DataServiceImplementationFactory
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.IDataServiceFactory))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class __DataServiceFactory :
        global::Microsoft.LightSwitch.ClientGenerated.Implementation.DataServiceFactory
    {
    
        protected override global::Microsoft.LightSwitch.IDataService CreateDataService(global::System.Type dataServiceType)
        {
            if (dataServiceType == typeof(global::LightSwitchApplication.ApplicationData))
            {
                return new global::LightSwitchApplication.ApplicationData();
            }
            return base.CreateDataService(dataServiceType);
        }
    
        protected override global::Microsoft.LightSwitch.Internal.IDataServiceImplementation CreateDataServiceImplementation<TDataService>(TDataService dataService)
        {
            if (typeof(TDataService) == typeof(global::LightSwitchApplication.ApplicationData))
            {
                return new global::LightSwitchApplication.Implementation.ApplicationData(global::Microsoft.LightSwitch.ClientGenerated.Implementation.DataServiceContext.CreateServiceUri("../../ApplicationData.svc"));
            }
            return base.CreateDataServiceImplementation(dataService);
        }
    }
    #endregion
    
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.ITypeMappingProvider))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class __TypeMapping
        : global::Microsoft.LightSwitch.Internal.ITypeMappingProvider
    {
        global::System.Type global::Microsoft.LightSwitch.Internal.ITypeMappingProvider.GetImplementationType(global::System.Type definitionType)
        {
            if (typeof(global::LightSwitchApplication.Collaborateur) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Collaborateur);
            }
            if (typeof(global::LightSwitchApplication.Commercial) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Commercial);
            }
            if (typeof(global::LightSwitchApplication.Mission) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Mission);
            }
            return null;
        }
    }
}
﻿/*

   Copyright 2020 Esri

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.

   See the License for the specific language governing permissions and
   limitations under the License.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Threading.Tasks;
using ArcGIS.Core.CIM;
using ArcGIS.Core.Data;
using ArcGIS.Core.Geometry;
using ArcGIS.Desktop.Catalog;
using ArcGIS.Desktop.Core;
using ArcGIS.Desktop.Editing;
using ArcGIS.Desktop.Extensions;
using ArcGIS.Desktop.Framework;
using ArcGIS.Desktop.Framework.Contracts;
using ArcGIS.Desktop.Framework.Dialogs;
using ArcGIS.Desktop.Framework.Threading.Tasks;
using ArcGIS.Desktop.Mapping;

namespace ValidateChanges
{
    /// <summary>
    /// This add-in demonstrates running Validate Network Topology on data changes.  When used on a file geodatabase or on the default version of a branch-versioned feature service, it runs Validate Network Topology on the entire network.
    /// If used on a named version of a branch-versioned feature service, it does a version differences on the dirty areas table, and uses the resulting extent for the Validate Network Topology operation.
    ///
    /// Community Sample data(see under the "Resources" section for downloading sample data) has a UtilityNetworkSamples.aprx project that contains a utility network that can be used with this sample.This project can be found under the
    /// C:\Data\UtilityNetwork folder. However, to demonstrate the version differences functionality, a utility network should be published to a feature service. 
    /// </summary>    
    /// <remarks>
    /// 1. In Visual Studio click the Build menu. Then select Build Solution.
    /// 1. Click Start button to open ArcGIS Pro.
    /// 1. ArcGIS Pro will open.
    /// 1. Open a project and map view that references a utility network.
    /// 1. Switch to a branch version that contains edits to utility network features.
    /// 1. Select a feature layer or subtype group layer that participates in a utility network or a utility network layer.
    /// 1. Click on the Add-in tab on the ribbon.
    /// 1. Click on the Validate Changes button.
    /// </remarks>
    internal class Module1 : Module
  {
    private static Module1 _this = null;

    /// <summary>
    /// Retrieve the singleton instance to this module here
    /// </summary>
    public static Module1 Current
    {
      get
      {
        return _this ?? (_this = (Module1)FrameworkApplication.FindModule("ValidateChanges_Module"));
      }
    }

    #region Overrides
    /// <summary>
    /// Called by Framework when ArcGIS Pro is closing
    /// </summary>
    /// <returns>False to prevent Pro from closing, otherwise True</returns>
    protected override bool CanUnload()
    {
      //TODO - add your business logic
      //return false to ~cancel~ Application close
      return true;
    }

    #endregion Overrides

  }
}

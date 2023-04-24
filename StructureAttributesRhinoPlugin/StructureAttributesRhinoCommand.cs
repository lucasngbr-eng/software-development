using Rhino;
using Rhino.Commands;
using Rhino.Geometry;
using Rhino.Input;
using Rhino.Input.Custom;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Rhino.UI;
using StructureAttributes.UI;
using RhinoWindows.Controls;
using RhinoWindows;
using RhinoWindows.Forms;
using Rhino.DocObjects;
using Rhino.FileIO;


namespace StructureAttributesRhinoPlugin
{
   
    
    public class StructureAttributesRhinoCommand : Command
    {
        public StructureAttributesRhinoCommand()
        {
        }

        ///<summary>The only instance of this command.</summary>
        public static StructureAttributesRhinoCommand Instance { get; private set; }

        ///<returns>The command name as it appears on the Rhino command line.</returns>
        public override string EnglishName => "AttributesITA";

        protected override Result RunCommand(RhinoDoc doc, RunMode mode)
        {

            RhinoWindows.Controls.DockBar.Show(WpfDockBar.BarId, false);
            return Result.Success;

        }
    }
}

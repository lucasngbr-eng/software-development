using Rhino;
using Rhino.PlugIns;
using RhinoWindows.Controls;
using System;
using StructureAttributes.UI;

namespace StructureAttributesRhinoPlugin
{
    ///<summary>
    /// <para>Every RhinoCommon .rhp assembly must have one and only one PlugIn-derived
    /// class. DO NOT create instances of this class yourself. It is the
    /// responsibility of Rhino to create an instance of this class.</para>
    /// <para>To complete plug-in information, please also see all PlugInDescription
    /// attributes in AssemblyInfo.cs (you might need to click "Project" ->
    /// "Show All Files" to see it in the "Solution Explorer" window).</para>
    ///</summary>
    public class StructureAttributesRhinoPlugin : Rhino.PlugIns.PlugIn
    {
        private WpfDockBar m_wpf_bar;
        public StructureAttributesRhinoPlugin()
        {
            Instance = this;
        }

        ///<summary>Gets the only instance of the StructureAttributesRhinoPlugin plug-in.</summary>
        public static StructureAttributesRhinoPlugin Instance { get; private set; }

        protected override LoadReturnCode OnLoad(ref string errorMessage)
        {
            CreateMyDockBar();
            return base.OnLoad(ref errorMessage);
        }

        private void CreateMyDockBar()
        {
            var create_options = new DockBarCreateOptions
            {
                DockLocation = DockBarDockLocation.Right,
                Visible = false,
                DockStyle = DockBarDockStyle.Any,
                FloatPoint = new System.Drawing.Point(100, 100)
            };

            m_wpf_bar = new WpfDockBar();
            m_wpf_bar.Create(create_options);
        }
    }


    internal class WpfDockBar : DockBar
    {
        public static Guid BarId => new Guid("{b924b685-160e-461d-adf9-c2b457965ac8}");
        public WpfDockBar() : base(StructureAttributesRhinoPlugin.Instance, BarId, "Ita Construtora")
        {
            SetContentControl(new WpfHost(new MainView(), null));
        }

    }
}
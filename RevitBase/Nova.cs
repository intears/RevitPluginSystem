using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using Autodesk.Revit.DB.Architecture;

namespace RevitBase
{
    public class Nova : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication application)
        {
            string tabName = "Nova";

            string panelAnnotationName = "Annotation Commands";
            
            application.CreateRibbonTab(tabName);

            var panelAnnotation = application.CreateRibbonPanel(tabName, panelAnnotationName);

            var doSomethingBtn = new PushButtonData("DoSomethingBtn", "Button\nText",
                Assembly.GetExecutingAssembly().Location, "RevitBase.Commands.DoSomething")
            {
                ToolTip = "Testing Tooltip"
            };

            panelAnnotation.AddItem(doSomethingBtn);


            return Result.Succeeded; // return 0
        }

        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded; // return 0
        }
    }
}
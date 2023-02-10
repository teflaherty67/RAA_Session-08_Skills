#region Namespaces
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System;
using System.Collections.Generic;
using System.Diagnostics;

#endregion

namespace RAA_Session_08_Skills
{
    [Transaction(TransactionMode.Manual)]
    public class Command : IExternalCommand
    {
        public Result Execute(
          ExternalCommandData commandData,
          ref string message,
          ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Application app = uiapp.Application;
            Document doc = uidoc.Document;

            string userName = app.Username;
            string filePath = doc.PathName;
            string date = DateTime.Now.ToString();

            string curAssembly = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            string curMethod = this.GetType().Name;

            Logger curLog = new Logger(filePath, userName);

            Globals.curLog = curLog;
            Globals.UserName = userName;
            Globals.FilePath = filePath;

            curLog.method1();

            curLog.method2();

            curLog.method3();

            TaskDialog td = new TaskDialog("Log Results");
            td.MainInstruction = "Here are the log results";
            td.MainContent = "Would you lioke to view the results?";
            td.CommonButtons = TaskDialogCommonButtons.Yes | TaskDialogCommonButtons.No;

            TaskDialogResult result = td.Show();

            if (result == TaskDialogResult.Yes)
            {

            }

            return Result.Succeeded;
        }
    }
}

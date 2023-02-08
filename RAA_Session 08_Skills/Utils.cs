using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAA_Session_08_Skills
{
    internal static class Utils
    {
        public static void method1()
        {
            TaskDialog.Show("Test", "The current user is" + Globals.UserName);
        }

        public static void method2()
        {
            try
            {

            }
            catch (Exception)
            {

                Globals.curLog.method3();
            }
        }
    }
}

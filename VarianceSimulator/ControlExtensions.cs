using System.Reflection;
using System.Windows.Forms;

namespace VarianceSimulator
{
    internal static class ControlExtensions
    {
        internal static void SetDoubleBuffered(this Control control)
        {
            if (SystemInformation.TerminalServerSession)
                return;

            BindingFlags flags = BindingFlags.NonPublic | BindingFlags.Instance;
            PropertyInfo property = typeof(Control).GetProperty("DoubleBuffered", flags);
            property.SetValue(control, true);
        }
    }
}

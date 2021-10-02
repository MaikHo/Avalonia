using Avalonia.Automation.Peers;
using Avalonia.Controls.Primitives;

namespace Avalonia.Controls
{
    /// <summary>
    /// A check box control.
    /// </summary>
    public class CheckBox : ToggleButton
    {
        protected override AutomationPeer OnCreateAutomationPeer()
        {
            return new CheckBoxAutomationPeer(this);
        }
    }
}

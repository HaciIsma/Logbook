using System;
using System.Windows.Forms;

namespace Logbook.View.Interface
{
    public interface IForm
    {
        event EventHandler<EventArgs> Adding;
        FlowLayoutPanel Panel { get; }
    }
}

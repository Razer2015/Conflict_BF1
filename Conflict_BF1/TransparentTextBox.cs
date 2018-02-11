using System.Drawing;
using System.Windows.Forms;

namespace Conflict_BF1
{
    public partial class TransparentTextBox : TextBox
    {
        public TransparentTextBox() {
            InitializeComponent();

            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            //SetStyle(ControlStyles.SupportsTransparentBackColor |
            //         ControlStyles.OptimizedDoubleBuffer |
            //         ControlStyles.AllPaintingInWmPaint |
            //         ControlStyles.ResizeRedraw |
            //         ControlStyles.UserPaint, true);
            BackColor = Color.Transparent;
        }
    }
}
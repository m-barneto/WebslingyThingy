using System;
using System.Windows.Forms;

namespace WebslingyThingy {
    public partial class Overlay : Form {
        Character c;
        public Overlay() {
            InitializeComponent();
            c = new Character();
        }

        protected override CreateParams CreateParams {
            get {
                const int WS_EX_LAYERED = 0x80000;
                const int WS_EX_TRANSPARENT = 0x20;
                CreateParams param = base.CreateParams;
                param.ExStyle |= WS_EX_LAYERED;
                param.ExStyle |= WS_EX_TRANSPARENT;
                return param;
            }
        }

        private void engineTimer_Tick(object sender, EventArgs e) {
            c.Update(1f / engineTimer.Interval);
        }
    }
}

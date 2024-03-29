using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WebslingyThingy {
    public enum MouseEventType {
        DOWN,
        UP,
        MOVE
    }
    public partial class Overlay : Form {
        Stopwatch sw;

        Spider spider;
        public Overlay() {
            InitializeComponent();
            spider = new Spider();
            sw = Stopwatch.StartNew();
        }

        private void MouseDownEvent(object sender, MouseEventArgs e) {
            spider.MouseEvent(MouseEventType.DOWN, e);
        }

        private void MouseUpEvent(object sender, MouseEventArgs e) {
            spider.MouseEvent(MouseEventType.UP, e);
        }

        private void MouseMoveEvent(object sender, MouseEventArgs e) {
            spider.MouseEvent(MouseEventType.MOVE, e);
        }

        private void engineTimer_Tick(object sender, EventArgs e) {
            spider.Update((float)sw.Elapsed.TotalSeconds);
            sw.Restart();
        }

        private void Overlay_Load(object sender, EventArgs e) {
            spider.Start(pbSpider, Bounds);
        }
    }
}

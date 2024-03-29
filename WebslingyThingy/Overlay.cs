using System;
using System.Windows.Forms;

namespace WebslingyThingy {
    public enum MouseEventType {
        DOWN,
        UP,
        MOVE
    }
    public partial class Overlay : Form {

        Spider spider;
        public Overlay() {
            InitializeComponent();
            spider = new Spider();
            
        }

        private void MouseDownEvent(object sender, MouseEventArgs e) {
            Console.WriteLine("Down");
            spider.MouseEvent(MouseEventType.DOWN, e);
        }

        private void MouseUpEvent(object sender, MouseEventArgs e) {
            Console.WriteLine("Up");
            spider.MouseEvent(MouseEventType.UP, e);
        }

        private void MouseMoveEvent(object sender, MouseEventArgs e) {
            spider.MouseEvent(MouseEventType.MOVE, e);
        }

        private void engineTimer_Tick(object sender, EventArgs e) {
            spider.Update(1f / engineTimer.Interval);
        }

        private void Overlay_Load(object sender, EventArgs e) {
            spider.Start(pbSpider);
        }
    }
}

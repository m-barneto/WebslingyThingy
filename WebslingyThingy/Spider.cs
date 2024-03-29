using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebslingyThingy {
    internal class Spider {
        [DllImport("User32.dll")]
        public static extern IntPtr GetDC(IntPtr hwnd);
        [DllImport("User32.dll")]
        public static extern void ReleaseDC(IntPtr hwnd, IntPtr dc);

        enum State {
            IDLE,
            WALKING,
        }

        enum Direction {
            LEFT,
            RIGHT
        }
        enum Orientation {
            UP,
            DOWN
        }


        const float PADDING = 90f;

        State currentState;
        Direction currentDirection;
        Orientation currentOrientation;

        PictureBox pb;
        public Vector2f pos, vel, acc;
        public Vector2f prevPos;
        bool isDragging = false;
        Vector2f mouseOffset;
        Rectangle bounds;

        public Spider() {
            currentState = State.IDLE;
            currentDirection = Direction.RIGHT;
            currentOrientation = Orientation.DOWN;

            mouseOffset = new Vector2f(0f, 0f);
            pos = new Vector2f(0f, 0f);
            prevPos = new Vector2f(0f, 0f);
            vel = new Vector2f(0f, 0f);
            acc = new Vector2f(0f, 0f);
        }

        public Point GetAnchor() {
            Point p = pb.Location;
            p.X += pb.Width / 2;


            if (currentOrientation == Orientation.UP) {
                p.Y += pb.Height;
            }

            return p;

        }

        public void Start(PictureBox pb, Rectangle bounds) {
            this.bounds = bounds;
            this.pb = pb;
            this.pb.Image = Properties.Resources.SpiderIdleRight;
        }

        public void Update(float dt) {
            if (Form.ActiveForm == null) return;
            if (isDragging) {
                Vector2f off = new Vector2f(Cursor.Position.X - (mouseOffset.x + pos.x), Cursor.Position.Y - (mouseOffset.y + pos.y));
                acc += off * 10f;
            }


            acc += Physics.GRAVITY;

            // Apply acc to vel
            vel += acc * dt;
            pos += vel * dt;

            vel *= Physics.FRICTION;

            acc = new Vector2f(0f, 0f);

            if (pos.y + pb.Height > bounds.Height) {
                pos.y = bounds.Height - pb.Height;
            }

            if (pos.x < -PADDING) {
                pos.x = -PADDING;
            }

            if (pos.x > bounds.Width - PADDING) {
                pos.x = bounds.Width - PADDING;
            }

            IntPtr desktopPtr = GetDC(IntPtr.Zero);
            Graphics g = Graphics.FromHdc(desktopPtr);

            SolidBrush b = new SolidBrush(Color.White);
            //g.FillRectangle(b, new Rectangle(GetAnchor(), new Size(16, 15)));

            g.Dispose();
            ReleaseDC(IntPtr.Zero, desktopPtr);

            this.pb.Location = new Point((int)pos.x, (int)pos.y);
        }

        internal void MouseEvent(MouseEventType eventType, MouseEventArgs e) {
            switch (eventType) {
                case MouseEventType.UP:
                    isDragging = false;
                    break;
                case MouseEventType.DOWN:
                    isDragging = true;
                    mouseOffset.x = Cursor.Position.X - pb.Left;
                    mouseOffset.y = Cursor.Position.Y - pb.Top;
                    break;
                case MouseEventType.MOVE:
                    break;
            }
        }
    }
}

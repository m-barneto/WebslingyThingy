using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebslingyThingy {
    internal class Spider {
        PictureBox pb;
        Vector2f pos, vel, acc;
        bool isDragging = false;
        Vector2f mouseOffset = Vector2f.Zero;



        public Spider() {
            pos = vel = acc = new Vector2f(0f, 0f);
        }

        public void Start(PictureBox pb) {
            this.pb = pb;
        }

        public void Update(float dt) {
            dt = .1f;
            if (isDragging) {
                Vector2f off = new Vector2f(Cursor.Position.X - (mouseOffset.x + pos.x), Cursor.Position.Y - (mouseOffset.y + pos.y));
                acc += off / 50f;

                //if (off.Magnitude() > 400f) isDragging = false;

            } else {
                //Apply gravity
                //acc += new Vector2f(0f, 1f);
            }

            // apply drag
            Vector2f dragForce = vel * -Physics.DRAG;
            acc += dragForce;

            var t = vel * dt;
            var r = acc * .5f;
            var q = r * dt;
            var f = q * dt;

            pos += t + f;
            vel += acc * dt;


            // Apply acc to vel
            //pos += vel * dt;
            //vel += acc * dt;
            //pos += vel * dt + acc * dt * dt * 0.5f;

            //vel *= Physics.DRAG;

            //acc = Vector2f.Zero;
            /*vel += acc;
            pos += vel;
            acc *= 0.6f;
            vel *= 0.9f;*/
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

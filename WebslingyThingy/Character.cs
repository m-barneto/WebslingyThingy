using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebslingyThingy {
    internal class Character {
        PointF pos, vel, acc;


        public Character() {
            pos = vel = acc = new PointF(0f, 0f);


        }

        public void Update(float dt) {

        }
    }
}

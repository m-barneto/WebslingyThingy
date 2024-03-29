using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebslingyThingy {
    internal class Physics {
        public static readonly Vector2f GRAVITY = new Vector2f(0f, 2000f);
        public const float FRICTION = .99f;
    }
}

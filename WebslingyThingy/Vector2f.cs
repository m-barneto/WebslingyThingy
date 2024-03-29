using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebslingyThingy {
    internal class Vector2f {
        public static Vector2f Zero = new Vector2f(0f, 0f);
        public float x, y;
        public Vector2f(float x, float y) {
            this.x = x;
            this.y = y;
        }
        public float Magnitude() {
            return (float)Math.Sqrt((x * x) + (y * y));
        }
        public static Vector2f operator +(Vector2f a, Vector2f b) {
            return new Vector2f(a.x + b.x, a.y + b.y);
        }
        public static Vector2f operator *(Vector2f a, float b) {
            return new Vector2f(a.x * b, a.y * b);
        }
        public static Vector2f operator /(Vector2f a, float b) {
            return new Vector2f(a.x / b, a.y / b);
        }
    }
}

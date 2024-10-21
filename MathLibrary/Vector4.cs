using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public struct Vector4
    {
        public float x, y, z, t;

        public float Magnitude
        {
            get
            {
                //(x*x+y*y+z*z+t*t)
                return (float)Math.Abs(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2) + Math.Pow(t, 2)));
            }
        }
        public Vector4 Normalized
        {
            get
            {
                return this / Magnitude;
            }
        }
        public override string ToString()
        {
            return "(" + x + ", " + y + ", " + z + ", " + t + ")";
        }
        public float DotProduct(Vector4 other)
        {
            return (x * other.x) + (y * other.y) + (z * other.z) + (t * other.t);
        }
        public Vector4 CrossProduct(Vector4 left, Vector4 right)
        {
            return new Vector4((left.y * right.z) - (left.z * right.y), (left.z * right.t) - (left.t * right.z), (left.t * right.x) - (left.x * right.t), (left.x * right.y) - (left.y * right.x));
        }
        public Vector4(float x = 0, float y = 0, float z = 0, float t = 0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.t = t;
        }
        public Vector4 Normalize()
        {
            this = Normalized;
            return this;
        }
        public static bool operator ==(Vector4 lhs, Vector4 rhs)
        {
            return (lhs.x == rhs.x && lhs.y == rhs.y && lhs.z == rhs.z && lhs.t == rhs.t);
        }
        public static bool operator !=(Vector4 lhs, Vector4 rhs)
        {
            return !(lhs == rhs);
        }
        //operater overload for addition
        public static Vector4 operator +(Vector4 left, Vector4 right)
        {
            return new Vector4(left.x + right.x, left.y + right.y, left.z + right.z, left.t + right.t);
        }
        public static Vector4 operator -(Vector4 left, Vector4 right)
        {
            return new Vector4(left.x - right.x, left.y - right.y, left.z - right.z, left.t - right.t);
        }
        //operator overload for multiplication by a scalar
        public static Vector4 operator *(Vector4 left, float scalar)
        {
            return new Vector4(left.x * scalar, left.y * scalar, left.z * scalar, left.t * scalar);
        }

        public static Vector4 operator /(Vector4 left, float scalar)
        {
            return new Vector4(left.x / scalar, left.y / scalar, left.z / scalar, left.t / scalar);
        }

        //implicit conversion from System.Numerics.Vector4 to Vector4
        public static implicit operator Vector4(System.Numerics.Vector4 vector)
        {
            return new Vector4(vector.X, vector.Y, vector.Z);
        }

        //implicit conversion from Vector4 to System.Numerics.Vector4
        public static implicit operator System.Numerics.Vector4(Vector4 vector)
        {
            return new System.Numerics.Vector4(vector.x, vector.y, vector.z, vector.t);
        }
    }
}

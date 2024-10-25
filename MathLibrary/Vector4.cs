using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public struct Vector4
    {
        public float x, y, z, w;

        public float Magnitude
        {
            get
            {
                //(x*x+y*y+z*z+t*t)
                return (float)Math.Abs(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2) + Math.Pow(w, 2)));
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
            return "(" + x + ", " + y + ", " + z + ", " + w + ")";
        }
        public float DotProduct(Vector4 other)
        {
            return (x * other.x) + (y * other.y) + (z * other.z) + (w * other.w);
        }
        public Vector4 CrossProduct(Vector4 left, Vector4 right)
        {
            return new Vector4((left.y * right.z) - (left.z * right.y), (left.z * right.w) - (left.w * right.z), (left.w * right.x) - (left.x * right.w), (left.x * right.y) - (left.y * right.x));
        }
        public Vector4 CrossProduct(Vector4 right)
        {
            return new Vector4((this.y * right.z) - (this.z * right.y), (this.z * right.w) - (this.w * right.z), (this.w * right.x) - (this.x * right.w), (this.x * right.y) - (this.y * right.x));
        }
        public static Vector4 operator *(float scalar, Vector4 right)
        {
            return new Vector4(scalar * right.x, scalar * right.y, scalar * right.z, scalar * right.w);
        }
        public Vector4(float x = 0, float y = 0, float z = 0, float w = 0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
        public Vector4 Normalize()
        {
            this = Normalized;
            return this;
        }
        public static bool operator ==(Vector4 lhs, Vector4 rhs)
        {
            return (lhs.x == rhs.x && lhs.y == rhs.y && lhs.z == rhs.z && lhs.w == rhs.w);
        }
        public static bool operator !=(Vector4 lhs, Vector4 rhs)
        {
            return !(lhs == rhs);
        }
        //operater overload for addition
        public static Vector4 operator +(Vector4 left, Vector4 right)
        {
            return new Vector4(left.x + right.x, left.y + right.y, left.z + right.z, left.w + right.w);
        }
        public static Vector4 operator -(Vector4 left, Vector4 right)
        {
            return new Vector4(left.x - right.x, left.y - right.y, left.z - right.z, left.w - right.w);
        }
        //operator overload for multiplication by a scalar
        public static Vector4 operator *(Vector4 left, float scalar)
        {
            return new Vector4(left.x * scalar, left.y * scalar, left.z * scalar, left.w * scalar);
        }

        public static Vector4 operator /(Vector4 left, float scalar)
        {
            return new Vector4(left.x / scalar, left.y / scalar, left.z / scalar, left.w / scalar);
        }

        //implicit conversion from System.Numerics.Vector4 to Vector4
        public static implicit operator Vector4(System.Numerics.Vector4 vector)
        {
            return new Vector4(vector.X, vector.Y, vector.Z, vector.W);
        }

        //implicit conversion from Vector4 to System.Numerics.Vector4
        public static implicit operator System.Numerics.Vector4(Vector4 vector)
        {
            return new System.Numerics.Vector4(vector.x, vector.y, vector.z, vector.w);
        }
    }
}

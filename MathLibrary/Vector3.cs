﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public struct Vector3
    {
        public float x, y, z;

        public float Magnitude
        {
            get
            {
                //(x*x+y*y+z*z)
                return (float)Math.Abs(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2)));
            }
        }
        public Vector3 Normalized
        {
            get
            {
                if (Magnitude == 0)
                    return new Vector3();
                return this / Magnitude;
            }
        }
        public override string ToString()
        {
            return "(" + x + ", " + y + ", " + z + ")";
        }
        public float DotProduct(Vector3 other)
        {
            return (x * other.x) + (y * other.y) + (z * other.z);
        }
        public Vector3 CrossProduct(Vector3 left, Vector3 right)
        {
            return new Vector3((left.y * right.z) - (left.z * right.y), (left.z * right.x) - (left.x * right.z), (left.x * right.y) - (left.y * right.x));
        }
        public Vector3 CrossProduct(Vector3 right)
        {
            return new Vector3((this.y * right.z) - (this.z * right.y), (this.z * right.x) - (this.x * right.z), (this.x * right.y) - (this.y * right.x));
        }
        public static Vector3 operator *(float scalar, Vector3 right)
        {
            return new Vector3(scalar * right.x, scalar * right.y, scalar * right.z);
        }
        public Vector3(float x = 0, float y = 0, float z = 0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public Vector3 Normalize()
        {
            this = Normalized;
            return this;
        }
        public static bool operator ==(Vector3 lhs, Vector3 rhs)
        {
            return (lhs.x == rhs.x && lhs.y == rhs.y && lhs.z == rhs.z);
        }
        public static bool operator !=(Vector3 lhs, Vector3 rhs)
        {
            return !(lhs == rhs);
        }
        //operater overload for addition
        public static Vector3 operator +(Vector3 left, Vector3 right)
        {
            return new Vector3(left.x + right.x, left.y + right.y, left.z + right.z);
        }        
        public static Vector3 operator -(Vector3 left, Vector3 right)
        {
            return new Vector3(left.x - right.x, left.y - right.y, left.z - right.z);
        }
        //operator overload for multiplication by a scalar
        public static Vector3 operator *(Vector3 left, float scalar)
        {
            return new Vector3(left.x * scalar, left.y * scalar, left.z * scalar);
        }
        public static Vector3 operator /(Vector3 left, float scalar)
        {
            return new Vector3(left.x / scalar, left.y / scalar, left.z / scalar);
        }

        //implicit conversion from System.Numerics.Vector3 to Vector3
        public static implicit operator Vector3(System.Numerics.Vector3 vector)
        {
            return new Vector3(vector.X, vector.Y, vector.Z);
        }

        //implicit conversion from Vector3 to System.Numerics.Vector3
        public static implicit operator System.Numerics.Vector3(Vector3 vector)
        {
            return new System.Numerics.Vector3(vector.x, vector.y, vector.z);
        }
    }
}

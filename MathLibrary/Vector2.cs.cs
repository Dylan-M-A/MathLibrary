using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace MathLibrary
{
    public struct Vector2
    {
        float x, y;

        public Vector2(float x = 0, float y = 0)
        {
            this.x = x;
            this.y = y;
        }

        public static bool operator ==(Vector2 lhs, Vector2 rhs)
        {
            return (lhs.x == rhs.x && lhs.y == rhs.y);
        }

        public static bool operator !=(Vector2 lhs, Vector2 rhs)
        {
            return !(lhs == rhs);
        }
        //operater overload for addition
        public static Vector2 operator +(Vector2 left, Vector2 right)
        {
            return new Vector2(left.x + right.x, left.y + right.y);
        }

        //operater overload for subtraction
        public static Vector2 operator -(Vector2 left, Vector2 right)
        {
            return new Vector2(left.x - right.x, left.y - right.y);
        }

        //operater overload for multiplication by vecyor
        public static Vector2 operator *(Vector2 left, Vector2 right)
        {
            return new Vector2(left.x * right.x, left.y * right.y);
        }

        //operator overload for multiplication by a scalar
        public static Vector2 operator *( Vector2 left, float right)
        {
            return new Vector2(left.x * right, left.y * right);
        }

        //operater overload for division
        public static Vector2 operator /(Vector2 left, Vector2 right)
        {
            return new Vector2(left.x / right.x, left.y / right.y);
        }

        //implicit conversion from System.Numerics.Vector2 to Vector2
        public static implicit operator Vector2(System.Numerics.Vector2 vector)
        {
            return new Vector2(vector.X, vector.Y);
        }

        //implicit conversion from Vector2 to System.Numerics.Vector2
        public static implicit operator System.Numerics.Vector2(Vector2 vector)
        {
            return new System.Numerics.Vector2(vector.x, vector.y);
        }
    }
}

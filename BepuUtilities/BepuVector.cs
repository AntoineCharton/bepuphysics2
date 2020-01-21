using System.Numerics;

namespace BepuUtilities
{
    public struct BepuVector : IVector
    {
        public Vector<T> Abs<T>(Vector<T> value) where T : struct
        {
            return Vector.Abs<T>(value);
        }

        public Vector<T> Add<T>(Vector<T> left, Vector<T> right) where T : struct
        {
            return Vector.Add<T>(left, right);
        }

        public Vector<T> AndNot<T>(Vector<T> left, Vector<T> right) where T : struct
        {
            return Vector.AndNot<T>(left, right);
        }

        public Vector<byte> AsVectorByte<T>(Vector<T> value) where T : struct
        {
            return Vector.AsVectorByte<T>(value);
        }

        public Vector<double> AsVectorDouble<T>(Vector<T> value) where T : struct
        {
            return Vector.AsVectorDouble<T>(value);
        }

        public Vector<short> AsVectorInt16<T>(Vector<T> value) where T : struct
        {
            return Vector.AsVectorInt16<T>(value);
        }

        public Vector<int> AsVectorInt32<T>(Vector<T> value) where T : struct
        {
            return Vector.AsVectorInt32<T>(value);
        }

        public Vector<long> AsVectorInt64<T>(Vector<T> value) where T : struct
        {
            return Vector.AsVectorInt64<T>(value);
        }

        public Vector<sbyte> AsVectorSByte<T>(Vector<T> value) where T : struct
        {
            return Vector.AsVectorSByte<T>(value);
        }

        public Vector<float> AsVectorSingle<T>(Vector<T> value) where T : struct
        {
            return Vector.AsVectorSingle<T>(value);
        }

        public Vector<ushort> AsVectorUInt16<T>(Vector<T> value) where T : struct
        {
            return Vector.AsVectorUInt16<T>(value);
        }

        public Vector<uint> AsVectorUInt32<T>(Vector<T> value) where T : struct
        {
            return Vector.AsVectorUInt32<T>(value);
        }

        public Vector<ulong> AsVectorUInt64<T>(Vector<T> value) where T : struct
        {
            return Vector.AsVectorUInt64<T>(value);
        }

        public Vector<T> BitwiseAnd<T>(Vector<T> left, Vector<T> right) where T : struct
        {
            return Vector.BitwiseAnd<T>(left, right);
        }

        public Vector<T> BitwiseOr<T>(Vector<T> left, Vector<T> right) where T : struct
        {
            return Vector.BitwiseOr<T>(left, right);
        }

        public Vector<float> ConditionalSelect(Vector<int> condition, Vector<float> left, Vector<float> right)
        {
            return Vector.ConditionalSelect(condition, left, right);
        }

        public Vector<double> ConditionalSelect(Vector<long> condition, Vector<double> left, Vector<double> right)
        {
            return Vector.ConditionalSelect(condition, left, right);
        }

        public Vector<T> ConditionalSelect<T>(Vector<T> condition, Vector<T> left, Vector<T> right) where T : struct
        {
            return Vector.ConditionalSelect(condition, left, right);
        }

        public Vector<double> ConvertToDouble(Vector<long> value)
        {
            return Vector.ConvertToDouble(value);
        }

        public Vector<double> ConvertToDouble(Vector<ulong> value)
        {
            return Vector.ConvertToDouble(value);
        }

        public Vector<int> ConvertToInt32(Vector<float> value)
        {
            return Vector.ConvertToInt32(value);
        }

        public Vector<long> ConvertToInt64(Vector<double> value)
        {
            return Vector.ConvertToInt64(value);
        }

        public Vector<float> ConvertToSingle(Vector<uint> value)
        {
            return Vector.ConvertToSingle(value);
        }

        public Vector<float> ConvertToSingle(Vector<int> value)
        {
            return Vector.ConvertToSingle(value);
        }

        public Vector<uint> ConvertToUInt32(Vector<float> value)
        {
            return Vector.ConvertToUInt32(value);
        }

        public Vector<ulong> ConvertToUInt64(Vector<double> value)
        {
            return Vector.ConvertToUInt64(value);
        }

        public Vector<T> Divide<T>(Vector<T> left, Vector<T> right) where T : struct
        {
            return Vector.Divide<T>(left, right);
        }

        public T Dot<T>(Vector<T> left, Vector<T> right) where T : struct
        {
            return Vector.Dot<T>(left, right);
        }

        public Vector<int> Equals(Vector<float> left, Vector<float> right)
        {
            return Vector.Equals(left, right);
        }

        public new Vector<T> Equals<T>(Vector<T> left, Vector<T> right) where T : struct
        {
            return Vector.Equals<T>(left, right);
        }

        public Vector<int> Equals(Vector<int> left, Vector<int> right)
        {
            return Vector.Equals(left, right);
        }

        public Vector<long> Equals(Vector<double> left, Vector<double> right)
        {
            return Vector.Equals(left, right);
        }

        public Vector<long> Equals(Vector<long> left, Vector<long> right)
        {
            return Vector.Equals(left, right);
        }

        public bool EqualsAll<T>(Vector<T> left, Vector<T> right) where T : struct
        {
            return Vector.EqualsAll<T>(left, right);
        }

        public bool EqualsAny<T>(Vector<T> left, Vector<T> right) where T : struct
        {
            return Vector.EqualsAny<T>(left, right);
        }

        public Vector<int> GreaterThan(Vector<int> left, Vector<int> right)
        {
            return Vector.GreaterThan(left, right);
        }

        public Vector<long> GreaterThan(Vector<long> left, Vector<long> right)
        {
            return Vector.GreaterThan(left, right);
        }

        public Vector<int> GreaterThan(Vector<float> left, Vector<float> right)
        {
            return Vector.GreaterThan(left, right);
        }

        public Vector<T> GreaterThan<T>(Vector<T> left, Vector<T> right) where T : struct
        {
            return Vector.GreaterThan<T>(left, right);
        }

        public Vector<long> GreaterThan(Vector<double> left, Vector<double> right)
        {
            return Vector.GreaterThan(left, right);
        }

        public bool GreaterThanAll<T>(Vector<T> left, Vector<T> right) where T : struct
        {
            return Vector.GreaterThanAll<T>(left, right);
        }

        public bool GreaterThanAny<T>(Vector<T> left, Vector<T> right) where T : struct
        {
            return Vector.GreaterThanAny<T>(left, right);
        }

        public Vector<int> GreaterThanOrEqual(Vector<float> left, Vector<float> right)
        {
            return Vector.GreaterThanOrEqual(left, right);
        }

        public Vector<T> GreaterThanOrEqual<T>(Vector<T> left, Vector<T> right) where T : struct
        {
            return Vector.GreaterThanOrEqual<T>(left, right);
        }

        public Vector<long> GreaterThanOrEqual(Vector<long> left, Vector<long> right)
        {
            return Vector.GreaterThanOrEqual(left, right);
        }

        public Vector<long> GreaterThanOrEqual(Vector<double> left, Vector<double> right)
        {
            return Vector.GreaterThanOrEqual(left, right);
        }

        public Vector<int> GreaterThanOrEqual(Vector<int> left, Vector<int> right)
        {
            return Vector.GreaterThanOrEqual(left, right);
        }

        public bool GreaterThanOrEqualAll<T>(Vector<T> left, Vector<T> right) where T : struct
        {
            return Vector.GreaterThanOrEqualAll<T>(left, right);
        }

        public bool GreaterThanOrEqualAny<T>(Vector<T> left, Vector<T> right) where T : struct
        {
            return Vector.GreaterThanOrEqualAny<T>(left, right);
        }

        public Vector<int> LessThan(Vector<int> left, Vector<int> right)
        {
            return Vector.LessThan(left, right);
        }

        public Vector<long> LessThan(Vector<long> left, Vector<long> right)
        {
            return Vector.LessThan(left, right);
        }

        public Vector<int> LessThan(Vector<float> left, Vector<float> right)
        {
            return Vector.LessThan(left, right);
        }

        public Vector<T> LessThan<T>(Vector<T> left, Vector<T> right) where T : struct
        {
            return Vector.LessThan<T>(left, right);
        }

        public Vector<long> LessThan(Vector<double> left, Vector<double> right)
        {
            return Vector.LessThan(left, right);
        }

        public bool LessThanAll<T>(Vector<T> left, Vector<T> right) where T : struct
        {
            return Vector.LessThanAll<T>(left, right);
        }

        public bool LessThanAny<T>(Vector<T> left, Vector<T> right) where T : struct
        {
            return Vector.LessThanAny<T>(left, right);
        }

        public Vector<int> LessThanOrEqual(Vector<int> left, Vector<int> right)
        {
            return Vector.LessThanOrEqual(left, right);
        }

        public Vector<long> LessThanOrEqual(Vector<long> left, Vector<long> right)
        {
            return Vector.LessThanOrEqual(left, right);
        }

        public Vector<int> LessThanOrEqual(Vector<float> left, Vector<float> right)
        {
            return Vector.LessThanOrEqual(left, right);
        }

        public Vector<T> LessThanOrEqual<T>(Vector<T> left, Vector<T> right) where T : struct
        {
            return Vector.LessThanOrEqual<T>(left, right);
        }

        public Vector<long> LessThanOrEqual(Vector<double> left, Vector<double> right)
        {
            return Vector.LessThanOrEqual(left, right);
        }

        public bool LessThanOrEqualAll<T>(Vector<T> left, Vector<T> right) where T : struct
        {
            return Vector.LessThanOrEqualAll<T>(left, right);
        }

        public bool LessThanOrEqualAny<T>(Vector<T> left, Vector<T> right) where T : struct
        {
            return Vector.LessThanOrEqualAny<T>(left, right);
        }

        public Vector<T> Max<T>(Vector<T> left, Vector<T> right) where T : struct
        {
            return Vector.Max<T>(left, right);
        }

        public Vector<T> Min<T>(Vector<T> left, Vector<T> right) where T : struct
        {
            return Vector.Min<T>(left, right);
        }

        public Vector<T> Multiply<T>(Vector<T> left, Vector<T> right) where T : struct
        {
            return Vector.Multiply<T>(left, right);
        }

        public Vector<T> Multiply<T>(T left, Vector<T> right) where T : struct
        {
            return Vector.Multiply<T>(left, right);
        }

        public Vector<T> Multiply<T>(Vector<T> left, T right) where T : struct
        {
            return Vector.Multiply<T>(left, right);
        }

        public Vector<ushort> Narrow(Vector<uint> source1, Vector<uint> source2)
        {
            return Vector.Narrow(source1, source2);
        }

        public Vector<uint> Narrow(Vector<ulong> source1, Vector<ulong> source2)
        {
            return Vector.Narrow(source1, source2);
        }

        public Vector<sbyte> Narrow(Vector<short> source1, Vector<short> source2)
        {
            return Vector.Narrow(source1, source2);
        }

        public Vector<short> Narrow(Vector<int> source1, Vector<int> source2)
        {
            return Vector.Narrow(source1, source2);
        }

        public Vector<int> Narrow(Vector<long> source1, Vector<long> source2)
        {
            return Vector.Narrow(source1, source2);
        }

        public Vector<float> Narrow(Vector<double> source1, Vector<double> source2)
        {
            return Vector.Narrow(source1, source2);
        }

        public Vector<byte> Narrow(Vector<ushort> source1, Vector<ushort> source2)
        {
            return Vector.Narrow(source1, source2);
        }

        public Vector<T> Negate<T>(Vector<T> value) where T : struct
        {
            return Vector.Negate<T>(value);
        }

        public Vector<T> OnesComplement<T>(Vector<T> value) where T : struct
        {
            return Vector.OnesComplement<T>(value);
        }

        public Vector<T> SquareRoot<T>(Vector<T> value) where T : struct
        {
            return Vector.SquareRoot<T>(value);
        }

        public Vector<T> Subtract<T>(Vector<T> left, Vector<T> right) where T : struct
        {
            return Vector.Subtract<T>(left, right);
        }

        public void Widen(Vector<byte> source, out Vector<ushort> dest1, out Vector<ushort> dest2)
        {
            Vector.Widen(source, out dest1, out dest2);
        }

        public void Widen(Vector<ushort> source, out Vector<uint> dest1, out Vector<uint> dest2)
        {
            Vector.Widen(source, out dest1, out dest2);
        }

        public void Widen(Vector<uint> source, out Vector<ulong> dest1, out Vector<ulong> dest2)
        {
            Vector.Widen(source, out dest1, out dest2);
        }

        public void Widen(Vector<sbyte> source, out Vector<short> dest1, out Vector<short> dest2)
        {
            Vector.Widen(source, out dest1, out dest2);
        }

        public void Widen(Vector<short> source, out Vector<int> dest1, out Vector<int> dest2)
        {
            Vector.Widen(source, out dest1, out dest2);
        }

        public void Widen(Vector<int> source, out Vector<long> dest1, out Vector<long> dest2)
        {
            Vector.Widen(source, out dest1, out dest2);
        }

        public void Widen(Vector<float> source, out Vector<double> dest1, out Vector<double> dest2)
        {
            Vector.Widen(source, out dest1, out dest2);
        }

        public Vector<T> Xor<T>(Vector<T> left, Vector<T> right) where T : struct
        {
            return Vector.Xor(left, right);
        }
    }
}

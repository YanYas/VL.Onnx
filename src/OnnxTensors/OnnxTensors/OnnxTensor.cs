using System;
using System.Numerics.Tensors;


namespace VL.ONNX
{
    public static class OnnxTensors<T>
    {
        public static Tensor<T> CreateNewTensor(Memory<T> InputData, int[] Dimensions)
        {
            var DimSpan = new ReadOnlySpan<int>(Dimensions);
            return new DenseTensor<T>(InputData, DimSpan);
        }
    }
}

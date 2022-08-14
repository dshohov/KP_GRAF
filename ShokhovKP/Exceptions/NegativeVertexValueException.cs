using System;

namespace ShokhovKP.Exceptions
{
    public class NegativeVertexValueException: Exception
    {
        public NegativeVertexValueException() : base("отрицательное значение вершины") { }
    }
}

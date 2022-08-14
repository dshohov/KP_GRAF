using System;

namespace ShokhovKP.Exceptions
{
    public class NumberOfEdgesOverMaximumException : Exception
    {
        public NumberOfEdgesOverMaximumException()
            : base("Количество ребер указано больше чем возможно вместить в граф") { }
    }
}

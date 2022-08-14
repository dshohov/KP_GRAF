using System;

namespace ShokhovKP.Exceptions
{
    public class NullVertexValueException: Exception
    {
        public NullVertexValueException() 
            : base("Значение количества вершин в графе не может равнятся нулю") { }
    }
}

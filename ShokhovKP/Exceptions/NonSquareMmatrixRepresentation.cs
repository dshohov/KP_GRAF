using System;

namespace ShokhovKP.Exceptions
{
    public class NonSquareMmatrixRepresentation: Exception
    {
         public NonSquareMmatrixRepresentation() :base("Не квадратное представление матрицы") { }
    }
}

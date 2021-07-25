using System;

namespace ExercicioException.Entities.Exceptions
{
    class WithdrawException : ApplicationException
    {
        public WithdrawException(string message) : base(message)
        {
        }
    }
}
namespace Homework22._11.Task2.Excep
{
    internal class NotFoundException : Exception
    {
        public NotFoundException() : base("The requested item was not found.")
        { 
        }
        public NotFoundException(string? message) : base(message) 
        {
        }
        public NotFoundException(string? message, Exception? innerException) : base(message, innerException) 
        {
        }
    }
}

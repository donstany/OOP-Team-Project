namespace RPG.Exceptions
{
    using System;

    public class ObjectOutOfMapException : Exception
    {
        public ObjectOutOfMapException(string message) : base(message)
        {
        }
    }
}

using System;
using System.IO;
using System.Runtime.Serialization;

namespace Custom_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new UserAlreadyLoggedInException("User is already logged in");
            }
            catch(UserAlreadyLoggedInException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    [Serializable]
    public class UserAlreadyLoggedInException : Exception
    {
        public UserAlreadyLoggedInException() : base()
        {
        }   
    public UserAlreadyLoggedInException(string message) : base(message)
        {
        }
    public UserAlreadyLoggedInException(string message , Exception innerexp) : base(message , innerexp)
        {
        }
    public UserAlreadyLoggedInException(SerializationInfo info , StreamingContext sc) : base(info , sc)
        {
        }
    }       
}

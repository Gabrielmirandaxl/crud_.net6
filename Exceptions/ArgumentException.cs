namespace test_crud.Exceptions
{
  public class ArgumentException : Exception
  {


    public ArgumentException()
    {

    }

    public ArgumentException(string message)
        : base(message)
    {

    }

    public ArgumentException(string message, Exception inner)
        : base(message, inner)
    {

    }

    public ArgumentException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
       : base(info, context)
    {

    }



  }
}
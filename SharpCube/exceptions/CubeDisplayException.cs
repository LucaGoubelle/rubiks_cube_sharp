namespace SharpCube.exceptions;


[Serializable]
public class CubeDisplayException : Exception
{
    public CubeDisplayException ()
    {}

    public CubeDisplayException (string message) 
        : base(message)
    {}

    public CubeDisplayException (string message, Exception innerException)
        : base (message, innerException)
    {}    
}
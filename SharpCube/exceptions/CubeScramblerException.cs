namespace SharpCube.exceptions;


[Serializable]
public class CubeScramblerException : Exception
{
    public CubeScramblerException ()
    {}

    public CubeScramblerException (string message) 
        : base(message)
    {}

    public CubeScramblerException (string message, Exception innerException)
        : base (message, innerException)
    {}
}

namespace SharpCube.exceptions;


[Serializable]
public class DSVSaveHandlerException : Exception
{
    public DSVSaveHandlerException ()
    {}

    public DSVSaveHandlerException (string message) 
        : base(message)
    {}

    public DSVSaveHandlerException (string message, Exception innerException)
        : base (message, innerException)
    {}      
}

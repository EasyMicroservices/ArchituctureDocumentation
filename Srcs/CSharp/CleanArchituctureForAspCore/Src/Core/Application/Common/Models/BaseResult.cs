namespace Application.Common.Models;

public class BaseResult<T>
{
    internal BaseResult(bool succeeded, IEnumerable<string>? errors , T data)
    {
        Succeeded = succeeded;
        Errors = errors;
        Data = data;
    }

    public bool Succeeded { get;   }

    public IEnumerable<string>? Errors { get;   }
    public T Data { get;   }
}


public class BaseResult
{
    internal BaseResult(bool succeeded, IEnumerable<string> errors )
    {
        Succeeded = succeeded;
        Errors = errors.ToArray();
         
    }

    public bool Succeeded { get;   }

    public string[] Errors { get;   }
 

}
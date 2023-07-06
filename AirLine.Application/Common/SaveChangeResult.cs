using System.ComponentModel.DataAnnotations;

namespace AirLine.Application.Common;

public class SaveChangeResult
{
    public SaveChangeResult()
    {
        IsSuccess = true;
        ResultType = SaveChangeResultType.Success;
        // Message = ResultType.GetDisplayName();
    }
    public SaveChangeResult(SaveChangeResultType resultType)
    {
        IsSuccess = resultType switch
        {
            SaveChangeResultType.Success => true,
            _ => false
        };
        ResultType = resultType;
        //Message = resultType.GetDisplayName();
    }
    public SaveChangeResult(SaveChangeResultType resultType, string message) : this(resultType)
    {
        Message = message;
    }

    public bool IsSuccess { get; set; }
    public SaveChangeResultType ResultType { get; set; }
    public string Message { get; set; }

    public enum SaveChangeResultType : byte
    {
        [Display(Name = "Success")]
        Success = 1,
        [Display(Name = "UpdateException")]
        UpdateException = 2,
        [Display(Name = "UpdateConcurrencyException")]
        UpdateConcurrencyException = 3,
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseDemo.Application.Common.Responses
{
    public class ApiResponse<T>
    {
        public bool Succeeded { get; set; }
        public string Message { get; set; }

        public object Errors { get; set; }
        public T Data { get; set; }

        public ApiResponse() { }

        public ApiResponse(T data, string message = null)
        {
            Succeeded = true;
            Message = message;
            Data = data;
        }

        public ApiResponse(string message)
        {
            Succeeded = false; 
            Message = message;
        }

        public ApiResponse(string message, List<string> errors)
        {
            Succeeded = false;
            Message = message;
            Errors = errors;
        }

    }
}

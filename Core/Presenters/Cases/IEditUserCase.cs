﻿using Core.Presenters.Requests;
using Core.Presenters.Responses;

namespace Core.Presenters.Cases
{
    public interface IEditUserCase
        
    {
        SignUpResponse Execute(EditUserRequest request, int userId);
    }
}

﻿namespace NetTemplate.DAL.Data.Responses.Auth
{
    public class ChangePasswordResponse
    {
        public bool Success { get; set; }
        public int AttemptsLeft { get; set; }
    }
}

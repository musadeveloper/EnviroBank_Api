﻿namespace EnviroBank.Helpers
{
    public class ApiResponse
    {
        public bool Success { get; set; }
        public object Data { get; set; }
        public string ErrorMessage { get; set; }
    }
}

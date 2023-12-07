﻿using System.Text.Json.Serialization;

namespace Core.Presenters.Requests
{
    public class SignUpRequest
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Fullname { get; set; } = string.Empty;

        [JsonPropertyName("birth_date")]
        public DateOnly BirthDate { get; set; }
    }
}

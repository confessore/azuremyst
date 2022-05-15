﻿namespace azuremyst.models.options
{
    sealed class SqlClientOptions
    {
        public string? Server { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Database { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;
using Raven.Imports.Newtonsoft.Json;

namespace AspNetCore.Identity.RavenDB
{
    public class EmailInfo
    {
        public string Address { get; internal set; }

        public string NormalizedAddress { get; internal set; }

        public DateTime? ConfirmationTime { get; internal set; }
        public bool IsConfirmed => (ConfirmationTime != null);

        public static implicit operator EmailInfo(string input)
            => new EmailInfo {Address = input, NormalizedAddress = input};

        [JsonIgnore]
        public bool AllPropertiesAreSetToDefaults =>
            Address == null &&
            NormalizedAddress == null &&
            ConfirmationTime == null;
    }
}

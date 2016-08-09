﻿
namespace GeekLearning.Storage.FileSystem.Server
{
    using Microsoft.AspNetCore.Http;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.IdentityModel.Tokens;

    public class FileSystemStorageServerOptions
    {
        public Uri BaseUri { get; set; }

        public PathString EndpointPath { get; set; } = "/.well-known/storage";

        public byte[] SigningKey { get; set; }
    }
}

﻿namespace Api.Client.Cert
{
    public class CertificateValidationConfig
    {
        public string Subject { get; set; }
        public string IssuerCN { get; set; }
        public string Thumbprint { get; set; }
    }
}
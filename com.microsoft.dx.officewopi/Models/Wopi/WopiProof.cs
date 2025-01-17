﻿namespace com.chalkline.wopi.Models.Wopi
{
    /// <summary>
    /// Represents the WOPI Proof details returned in WOPI Discovery
    /// </summary>
    public class WopiProof
    {
        public string oldvalue { get; set; }
        public string oldmodulus { get; set; }
        public string oldexponent { get; set; }
        public string value { get; set; }
        public string modulus { get; set; }
        public string exponent { get; set; }
    }
}

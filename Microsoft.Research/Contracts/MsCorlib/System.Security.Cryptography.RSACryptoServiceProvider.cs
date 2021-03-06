// CodeContracts
// 
// Copyright (c) Microsoft Corporation
// 
// All rights reserved. 
// 
// MIT License
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

using System.Diagnostics.Contracts;
using System;

namespace System.Security.Cryptography
{

    public class RSACryptoServiceProvider
    {

        public static bool UseMachineKeyStore
        {
          get;
          set;
        }

        public bool PersistKeyInCsp
        {
          get;
          set;
        }

        public string SignatureAlgorithm
        {
          get;
        }

        public string KeyExchangeAlgorithm
        {
          get;
        }

        public int KeySize
        {
          get;
        }

        public Byte[] EncryptValue (Byte[] rgb) {

          return default(Byte[]);
        }
        public Byte[] DecryptValue (Byte[] rgb) {

          return default(Byte[]);
        }
        public Byte[] Decrypt (Byte[] rgb, bool fOAEP) {
            // INVALID BECUASE IT MENTIONS PRIVATE FIELD
            //Contract.Requires(System.Security.Cryptography.RSACryptoServiceProvider._runningWin2KOrLaterCrypto != false);

          return default(Byte[]);
        }
        public Byte[] Encrypt (Byte[] rgb, bool fOAEP) {
            // INVALID BECUASE IT MENTIONS PRIVATE FIELD
            //Contract.Requires(System.Security.Cryptography.RSACryptoServiceProvider._runningWin2KOrLaterCrypto != false);

          return default(Byte[]);
        }
        public bool VerifyHash (Byte[] rgbHash, string str, Byte[] rgbSignature) {
            Contract.Requires(rgbHash != null);
            Contract.Requires(rgbSignature != null);
            Contract.Requires(rgbHash.Length == 20);
            Contract.Requires(rgbHash.Length == 16);

          return default(bool);
        }
        public Byte[] SignHash (Byte[] rgbHash, string str) {
            Contract.Requires(rgbHash != null);
            Contract.Requires(rgbHash.Length == 20);
            Contract.Requires(rgbHash.Length == 16);

          return default(Byte[]);
        }
        public bool VerifyData (Byte[] buffer, object halg, Byte[] signature) {

          return default(bool);
        }
        public Byte[] SignData (Byte[] buffer, int offset, int count, object halg) {

          return default(Byte[]);
        }
        public Byte[] SignData (Byte[] buffer, object halg) {

          return default(Byte[]);
        }
        public Byte[] SignData (System.IO.Stream inputStream, object halg) {

          return default(Byte[]);
        }
        public void ImportParameters (RSAParameters parameters) {

        }
        public RSAParameters ExportParameters (bool includePrivateParameters) {

          return default(RSAParameters);
        }
        public RSACryptoServiceProvider (int dwKeySize, CspParameters parameters) {

          return default(RSACryptoServiceProvider);
        }
        public RSACryptoServiceProvider (CspParameters parameters) {

          return default(RSACryptoServiceProvider);
        }
        public RSACryptoServiceProvider (int dwKeySize) {

          return default(RSACryptoServiceProvider);
        }
        public RSACryptoServiceProvider () {
          return default(RSACryptoServiceProvider);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ctiencrypt
{
    class Language
    {
        public static string

            // Application Title
            CTITextEncryption = "CTI Text Encryption",

            // About
            AboutDescription = config.Version + @"
Features

- Freeware
- A text encryption tool
- Core encryption algorithm: AES(Rijndael) 256 bits
- Password hashing algorithm: SHA512",

            // UI
            Pwd1 = "Password 1",
            Pwd2 = "Password 2",
            Pwd3 = "Password 3",
            Pwd4 = "Password 4",
            NormalText = "Normal Text.",
            EncryptedText = "Encrypted Text.",
            Length = "Length:",
            Passwords = "Passwords",
            ButtonErasePwd = "Erase Password",
            ButtonEraseAll = "Erase All",
            ButtonInfo = "Info",
            ButtonEncrypt="Encrypt",
            ButtonDecrypt="Decrypt",
            ButtonCopy="Copy",
            ButtonPaste="Paste",
            ButtonErase="Erase",
            ButtonFont="Font",

            // Tooltip
            TooltipEncrypt = "Encrypt",
            TooltipDecrypt = "Decrypt",
            TooltipResetAll = "Reset/Clear all",
            TooltipResetPwd = "Reset/Clear all passwords",
            TooltipChangeFont = "Change Font",
            TooltipCopyTxtNormal = "Copy all normal text",
            TooltipPasteTxtNormal = "Paste to normal text",
            TooltipResetTxtNormal = "Reset/Clear normal text",
            TooltipCopyTxtEncrypted = "Copy all encrypted text",
            TooltipPasteTxtEncrypted = "paste encrypted text",
            TooltipResetTxtEncrypted = "Reset/Clear encrypted text",
            TooltipInformation = "Information",

            // General Messages
            MsgNormalTextIsEmpty = "Normal text is empty. Nothing to encrypt.",
            MsgEncryptedTextIsEmpty = "Encrypted text is empty. Nothing to decrypt.",

            // Error Messages
            Error = "Error",
            ErrorGeneralMessage = "An unknown error has occured. Please contact the developer. Thanks you.",
            ErrorEncryptFail = "Encryptin Fail",
            ErrorEncryptFailDescription = "Fail to encrypt. Please try again.",
            ErrorDecryptionFail = "Decryption Fail",            
            ErrorWrongPassword = "Wrong password or incomplete context.",
            ErrorCopy = "Error. Unable to copy.",
            ErrorCut = "Error. Unable to cut.",
            ErrorPaste = "Error. Unable to paste.";
    }
}

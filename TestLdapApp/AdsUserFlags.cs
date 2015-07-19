using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLdapApp
{
    [Flags]
    public enum AdsUserFlags
    {
        script = 1,                             //0x1
        AccountDisabled=2,                      //0x2
        HomeDirectoryRequired=8,                //0x8
        AccountLockedout=16,                    //0x10
        PasswordNotRequired=32,                 //0x20
        PasswordCannotChange=64,                //0x40
        EncryptedTextPasswordAllowed=128,       //0x80
        TempDuplicateAccount=256,               //0x100
        NormalAccount=512,
        InterDomainTrustAccount=2048,
        WorkstationTrustAccount=4096,
        ServerTrustAccount=8192,
        PasswordDoesNotExpire=65536,
        MnsLogonAccount=131072,
        SmartCardRequired=262144,
        TrustedForDelegation=524288,
        AccountNotDelegated=1048576,
        UseDesKeyOnly=1097152,
        DontRequirePreAuth=4194304,
        PasswordExpired=8388608,
        TrustedToAuthenticateForDelegation=16777216,
        NoAuthDataRequired=33554432
        
    }
}

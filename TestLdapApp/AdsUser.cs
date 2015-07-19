using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLdapApp
{
    class AdsUser
    {
        public string ErrorMessage { get; private set; }

        /// <summary>
        /// Creates a user in an organisational unit(ou) called People within 
        /// Active Directory. this ou exists inside the root of the domain.
        /// </summary>
        /// <returns>true on success or false on failure</returns>
        public bool CreateAdUser()
        {
            DirectoryEntry parent = new DirectoryEntry("LDAP://OU=people,DC=ad.validationresourece.com, DC=com",null,null,AuthenticationTypes.Secure)
            DirectoryEntry user = parent.Children.Add("CN=test.user","user");

            using(user)
	        {
		        //sAMAccountName is required for W2k AD, we would not use this for ADAM, however.
                user.Properties["sAMAccountName"].Value="test.user";
                //userPrincipleName is not required, but recommended
                //For ADAM AD also contains this , so we can use it.
                user.Properties["userPrincipleName"].Value="test.user";
                
                try 
	            {	        
		            user.CommitChanges();
                    
	            }
	            catch (Exception ex)
	            {
		            ErrorMessage = ex.Message;
                    return false;
	            }
                return true;
	        }
        }

        public AdsUserFlags GetUserFlags()
        {
            DirectoryEntry user = new DirectoryEntry( "LDAP://CN=User1,CN=users,DC=domain,DC=com", null, null, AuthenticationTypes.Secure ); 
            AdsUserFlags userFlags = (AdsUserFlags)user.Properties["userAccountControl"].Value;
            return userFlags;
        }
    
    }
}

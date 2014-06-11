using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGluck.Domain;
using MyGluck.Dal.Implementation;

namespace MyGluck.BI
{
    public static class UserManager
    {
        public bool IsValidUser(string UserName, string password)
        {
            bool result = false;

            return result;
        }

        public UserProfile CreateUser(UserProfile userProfile, string password)
        {
            UserProfile result = null;
            if (userProfile != null)
            {
                UserProfileDaoImpl userProfileDaoImpl = new UserProfileDaoImpl();
                userProfile=userProfileDaoImpl.Insert(userProfile);
                if (userProfileDaoImpl != null)
                {
                    webpages_Membership membership = new webpages_Membership();
                    membership.CreateDate = DateTime.Now;
                    membership.IsConfirmed = false;
                    membership.UserId = userProfile.UserId;
                    membership.PasswordSalt = Tools.Encryptor.GenerataSaltValue();
                    membership.Password=Tools.Encryptor.HashPassword(membership.Password,membership.PasswordSalt,System.Security.Cryptography.MD5.Create());
                    membership.PasswordFailuresSinceLastSuccess = 0;
                    string tokenconfirmation = Tools.TokenGenerator.GenerateTokenTime();
                    membership.ConfirmationToken = Tools.Encryptor.Encrypt(tokenconfirmation, membership.PasswordSalt);
                    webpages_MembershipDaoImpl membershipDaoImpl = new webpages_MembershipDaoImpl();
                    if (membershipDaoImpl.Insert(membership) != null)
                    {
                        //Todo correcto se devuelve true
                        result = userProfile;
                    }
                    else
                    {
                        //Error se deshace la operación del UserProfile Insert
                        userProfileDaoImpl.Delete(userProfile);
                    }
                }

            }
            return result;
        }

        public bool CreateOAuth(webpages_OAuthMembership oAuthMemberShip)
        {
            bool result = false;
            oAuthMemberShip = new webpages_OAuthMembershipDaoImpl().Insert(oAuthMemberShip);
            if (oAuthMemberShip != null)
            {
                result = true;
            }
            return result;
        }

        public bool AsingUserToRole(webpages_UsersInRole userInRole)
        {
            bool result = false;
            userInRole = new webpages_UsersInRoleDaoImpl().Insert(userInRole);
            if (userInRole != null)
            {
                result = true;
            }
            return result;
        }
    }
}

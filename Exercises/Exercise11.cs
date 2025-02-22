using Microsoft.IdentityModel.Tokens;

public class Test
{

        public void TokenValidationMethod()
        {
            TokenValidationParameters tokenvalidate = new TokenValidationParameters
            {
                ValidateIssuer = false,
                ValidateAudience = false,
                RequireExpirationTime = false,
                ValidateLifetime = false,
                RequireSignedTokens = false
            };


            TokenValidationParameters parametersinsecure = new TokenValidationParameters();
            parametersinsecure.ValidateIssuer = false;
            parametersinsecure.ValidateAudience = false;
            parametersinsecure.ValidateLifetime = false;
            parametersinsecure.RequireSignedTokens = false;


            TokenValidationParameters parameterssecure = new TokenValidationParameters();
            parameterssecure.ValidateIssuer = true;
            parameterssecure.ValidateAudience = true;
            parameterssecure.RequireSignedTokens = true;
        }

}
using System;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;


namespace WebAPIDemo.Helpers
{
    // Generates a JWT token.
    public static class JwtToken
    {
        // DON'T DO THIS IN PRODUCTION - DEMOSTRATION ONLY!
        private const string SECRET_KEY = "notforproduction";
        public static readonly SymmetricSecurityKey SIGNING_KEY = new
            SymmetricSecurityKey(Encoding.UTF8.GetBytes(SECRET_KEY));

        public static string GenerateJwtToken()
        {
            // Create security key.
            var credentials = new SigningCredentials(SIGNING_KEY, SecurityAlgorithms.HmacSha256);

            // Create the token.
            var header = new JwtHeader(credentials);

            // Token expiration time length.
            DateTime expiration = DateTime.UtcNow.AddHours(1);

            // Convert actual time to Unix time.
            int ts = (int)(expiration - new DateTime(1970, 1, 1)).TotalSeconds;

            var payload = new JwtPayload
            {
                { "sub", "testSubject"},
                { "name", "Scot"},
                { "email", "scot@tesst.com" },
                { "exp", ts},
                //{ "nbf", new DateTimeOffset(DateTime.Now).DateTime},
                { "iss", "https://localhost:44316" }, // Issuer - Party generating the JWT.
                { "aud", "https://localhost:44316" }, // Audiuence - The address of the resource
            };

            var secToken = new JwtSecurityToken(header, payload);

            var handler = new JwtSecurityTokenHandler();

            var tokenString = handler.WriteToken(secToken);


            Console.WriteLine(tokenString);
            Console.WriteLine("Consume token");

            return tokenString;
            
        }
    }
}

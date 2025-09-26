# NETCoreAPI-JWT

**Sample JWT authentication in .NET Core Web API**  
> ⚠️ **Educational Demo – Not for Production Use**

---

## About This Project

This repository demonstrates how JWT (JSON Web Token) authentication works in a .NET Core Web API. It includes custom logic for generating and validating JWTs, implementing refresh tokens, and managing authentication flow manually.

**Why does this exist?**  
Rolling your own authentication is _not_ recommended for production projects. However, understanding the mechanics behind authentication is important for every developer. This repo was built to showcase those mechanics, help others learn, and serve as a reference for blog posts and tutorials.

---

## 🚨 Not for Production

- **Do not use this code in real-world applications!**
- Custom security implementations are risky and error-prone.
- .NET Core provides robust, secure JWT authentication middleware and ASP.NET Core Identity framework.  
  See: [Microsoft Docs: JWT Bearer Authentication](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/jwt?view=aspnetcore-7.0)

---

## What You'll Find

- Manual JWT token creation and validation
- Basic refresh token implementation
- Authentication endpoints for register, login, and token refresh
- Comments and code to illustrate the underlying principles

---

## Recommended Practices

For production, use official libraries and middleware:
- [ASP.NET Core Identity](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/identity?view=aspnetcore-7.0)
- [Microsoft.AspNetCore.Authentication.JwtBearer](https://www.nuget.org/packages/Microsoft.AspNetCore.Authentication.JwtBearer)

---

## License

This project is provided as-is for educational purposes.
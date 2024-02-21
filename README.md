# dotnet-spa-auth-template
Dotnet Spa Auth Template with Identity Scaffolded

- Launch the App, it will install ClientApp npm packages dependencies

- Update Database
```
PM> Update-Database
```
- Set your Google Login Secrets
```
dotnet user-secrets set "Authentication:Google:ClientId" "<client-id>"
dotnet user-secrets set "Authentication:Google:ClientSecret" "<client-secret>"
```
- Set your Facebook Login Secrets
https://docs.microsoft.com/en-us/aspnet/core/security/authentication/social/facebook-logins?view=aspnetcore-5.0

- Set your SendGrid Api key
https://docs.microsoft.com/en-us/aspnet/core/security/authentication/accconfirm?view=aspnetcore-5.0&tabs=visual-studio

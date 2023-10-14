using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// this is not a jwt token
builder.Services.AddAuthentication().AddBearerToken(IdentityConstants.BearerScheme);
builder.Services.AddAuthorizationBuilder();

var app = builder.Build();

app.Run();

class MyUser : IdentityUser {}
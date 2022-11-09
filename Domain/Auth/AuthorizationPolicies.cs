﻿using System.Security.Claims;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.Auth;

public class AuthorizationPolicies
{
    public static void AddPolicies(IServiceCollection services)
    {
        services.AddAuthorizationCore(options =>
        {
            options.AddPolicy("MustBeLogged", a =>
                a.RequireAuthenticatedUser().RequireClaim("Domain", "via"));
    
        });
    }
}
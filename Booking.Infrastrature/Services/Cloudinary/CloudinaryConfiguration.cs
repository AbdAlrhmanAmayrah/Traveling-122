﻿



using Booking.Domain.Interfaces.Services;
using Booking.Shared.OptionsValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Booking.Infrastrature.Services;
public static class CloudinaryConfiguration
{
    // to learn more about this topic, visit => https://www.linkedin.com/posts/anton-martyniuk-93980994_csharp-dotnet-programming-activity-7220699033999208448-W80r?utm_source=share&utm_medium=member_desktop
    public static IServiceCollection AddCloudinaryService(this IServiceCollection services)
    {

        services.AddOptionsWithFIuentVatidation<CloudinaryConfig>(nameof(CloudinaryConfig));

        services.AddTransient<ICloudinaryService, CloudinaryService>();

        return services;
    }
}
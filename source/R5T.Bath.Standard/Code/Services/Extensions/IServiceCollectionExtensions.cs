﻿using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Bath.File.Standard;
using R5T.Dacia;


namespace R5T.Bath.Standard
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds a file-based <see cref="IHumanOutput"/> service.
        /// </summary>
        public static IServiceCollection AddHumanOutput(this IServiceCollection services)
        {
            services.AddFileHumanOutput();

            return services;
        }

        /// <summary>
        /// Adds a file-based <see cref="IHumanOutput"/> service.
        /// </summary>
        public static ServiceAction<IHumanOutput> AddHumanOutputAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<IHumanOutput>(() => services.AddHumanOutput());
            return serviceAction;
        }
    }
}

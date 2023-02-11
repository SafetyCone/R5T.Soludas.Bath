using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Bath;
using R5T.Cambridge.Types;
using R5T.Dacia;
using R5T.Vandalia;


namespace R5T.Soludas.Bath
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="SolutionFileValueEqualityComparer"/> implementation of <see cref="IValueEqualityComparer{T}"/>, T: <see cref="SolutionFile"/>, as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddBathVisualStudioSolutionFileValueEqualityComparer(this IServiceCollection services,
            IServiceAction<IHumanOutput> addHumanOutput)
        {
            services
                .AddSingleton<IValueEqualityComparer<SolutionFile>, SolutionFileValueEqualityComparer>()
                .RunServiceAction(addHumanOutput)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="SolutionFileValueEqualityComparer"/> implementation of <see cref="IValueEqualityComparer{T}"/>, T: <see cref="SolutionFile"/>, as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<IValueEqualityComparer<SolutionFile>> AddBathVisualStudioSolutionFileValueEqualityComparerAction(this IServiceCollection services,
            IServiceAction<IHumanOutput> addHumanOutput)
        {
            var serviceAction = new ServiceAction<IValueEqualityComparer<SolutionFile>>(() => services.AddBathVisualStudioSolutionFileValueEqualityComparer(
                addHumanOutput));
            return serviceAction;
        }
    }
}

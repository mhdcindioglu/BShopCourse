using System.Reflection;

namespace BShop.Apis;

public static class ApiEndpointExtensions
{
    public static void MapApiEndpoints(this IEndpointRouteBuilder app)
    {
        var assembly = Assembly.GetExecutingAssembly();
        
        var apiTypes = assembly.GetTypes()
            .Where(t => t.Namespace == "BShop.Apis" &&
                       t.Name != nameof(ApiEndpointExtensions) &&
                       t.GetMethods(BindingFlags.Public | BindingFlags.Static)
                           .Any(m => m.Name.StartsWith("Map") &&
                                   m.Name.EndsWith("Endpoints") &&
                                   m.GetParameters().Length == 1 &&
                                   m.GetParameters()[0].ParameterType == typeof(IEndpointRouteBuilder)));

        foreach (var apiType in apiTypes)
        {
            var mapEndpointsMethod = apiType.GetMethods(BindingFlags.Public | BindingFlags.Static)
                .FirstOrDefault(m => m.Name.StartsWith("Map") && 
                                   m.Name.EndsWith("Endpoints") &&
                                   m.GetParameters().Length == 1 &&
                                   m.GetParameters()[0].ParameterType == typeof(IEndpointRouteBuilder));

            if (mapEndpointsMethod != null)
            {
                mapEndpointsMethod.Invoke(null, new object[] { app });
            }
        }
    }
}
using Backend_APIs.Data;
using Backend_APIs.Mapping;
using Microsoft.EntityFrameworkCore;
//using Project.Dtos;

namespace Backend_APIs.Entities;

    public static class CategoryEndpoint
    {
        /*    private static readonly List<CategoryDto> categories = [
            new (1, "Kids and Family"),
            new (2, "Eco-Friendly Living")
        ];*/

        public static RouteGroupBuilder MapCategoryEndpoint(this WebApplication app)
        {
            var group = app.MapGroup("categories");
            group.MapGet("/", (ProjectContext dbContext) =>
            dbContext.Categories
                        .Select(category => category.ToDto())
                        .AsNoTracking()
                        .ToList());
            return group;
        }

}


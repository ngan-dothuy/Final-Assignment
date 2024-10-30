using System;
using Backend_APIs.Entities;
using Library.Dtos;

namespace Backend_APIs.Mapping;

public static class CategoryMapping
{
    public static CategoryDto ToDto(this CategoryEntity category){
        return new CategoryDto(category.Id, category.Name);

    }

}

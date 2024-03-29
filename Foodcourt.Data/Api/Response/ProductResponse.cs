﻿using Foodcourt.Data.Api.Entities.Cafes;

namespace Foodcourt.Data.Api.Response;

public class ProductResponse
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Avatar { get; set; }
    public ProductStatus Status { get; set; }
    public double Price { get; set; }
    public double Proteins { get; set; }
    public double Fats { get; set; }
    public double Carbohydrates { get; set; }
    public double Weight { get; set; }
    public double Kcal { get; set; }
    public long CafeId { get; set; }
    public List<ProductVariantResponse> ProductVariants {get; set; }
    public List<ProductTypeResponse> ProductTypes {get; set; }
}
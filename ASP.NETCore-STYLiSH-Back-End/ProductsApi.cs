using ASP.NETCore_STYLiSH_Back_End.Data;
using ASP.NETCore_STYLiSH_Back_End.Models;
using Microsoft.EntityFrameworkCore;
using STYLiSH.Types;

public static class ProductsApi
{
    public static void MapProductsApi(this WebApplication app)
    {
        var group = app.MapGroup("/api/1.0/products").WithTags("Products");

        #region products
        group.MapGet("/{category}", async (StylishContext context, string category, int paging, string? search, long? id) =>
        {
            Product[] _products = await context.Products.ToArrayAsync();

            List<ASP.NETCore_STYLiSH_Back_End.Models.Variant> _ef_variant = await context.Variants.ToListAsync();
            List<Otherimage> _ef_otherimages = await context.Otherimages.ToListAsync();

            List<ProductDetailsData>? _data = new();

            for (int i = 0; i < _products.Length; i++)
            {
                List<ASP.NETCore_STYLiSH_Back_End.Models.Variant> _id_variant = _ef_variant.Where(x => x.Id == _products[i].Id).ToList();
                List<Color> _color = new();
                List<STYLiSH.Types.Variant> _variant = new();
                List<string> _images = _ef_otherimages.Where(x => x.Id == _products[i].Id).Select(x => x.ImagesUrl).ToList()!;
                foreach (ASP.NETCore_STYLiSH_Back_End.Models.Variant variant in _id_variant)
                {
                    _color.Add(new Color() { code = variant.ColorCode, name = variant.ColorName });
                    _variant.Add(new STYLiSH.Types.Variant() { color_code = variant.ColorCode, size = variant.Size, stock = variant.Stock });
                }
                _data.Add(new ProductDetailsData { id = _products[i].Id, category = _products[i].Category, title = _products[i].Title, description = _products[i].Description, price = _products[i].Price, texture = _products[i].Texture, wash = _products[i].Wash, place = _products[i].Place, note = _products[i].Note, story = _products[i].Story, main_image = _products[i].MainImage, images = _images, variants = _variant, colors = _color.Distinct().ToList(), sizes = _variant.Select(x => x.size).Distinct().ToList()! });

            }

            if (category != "all")
            {
                _data = _data.Where(x => x.category == category).ToList();
            }

            if (paging * 6 > _data.Count)
            {
                return new ProductsSearch();
            }

            ProductsSearch result = new() { data = _data[(paging * 6)..((paging + 1) * 6 < _data.Count ? (paging + 1) * 6 : _data.Count)], next_paging = (paging + 1) * 6 < _data.Count ? paging + 1 : null };
            return result;
        }
        )
        .WithName("GetProducts");
        #endregion


        #region productDetails
        group.MapGet("/details", async (StylishContext context, long id) =>
         {
             Product[] _products = await context.Products.ToArrayAsync();

             List<ASP.NETCore_STYLiSH_Back_End.Models.Variant> _ef_variant = await context.Variants.ToListAsync();
             List<Otherimage> _ef_otherimages = await context.Otherimages.ToListAsync();

             List<ProductDetailsData>? _data = new();

             for (int i = 0; i < _products.Length; i++)
             {
                 List<ASP.NETCore_STYLiSH_Back_End.Models.Variant> _id_variant = _ef_variant.Where(x => x.Id == _products[i].Id).ToList();
                 List<Color> _color = new();
                 List<STYLiSH.Types.Variant> _variant = new();
                 List<string> _images = _ef_otherimages.Where(x => x.Id == _products[i].Id).Select(x => x.ImagesUrl).ToList()!;
                 foreach (ASP.NETCore_STYLiSH_Back_End.Models.Variant variant in _id_variant)
                 {
                     _color.Add(new Color() { code = variant.ColorCode, name = variant.ColorName });
                     _variant.Add(new STYLiSH.Types.Variant() { color_code = variant.ColorCode, size = variant.Size, stock = variant.Stock });
                 }
                 _data.Add(new ProductDetailsData { id = _products[i].Id, category = _products[i].Category, title = _products[i].Title, description = _products[i].Description, price = _products[i].Price, texture = _products[i].Texture, wash = _products[i].Wash, place = _products[i].Place, note = _products[i].Note, story = _products[i].Story, main_image = _products[i].MainImage, images = _images, variants = _variant, colors = _color.Distinct().ToList(), sizes = _variant.Select(x => x.size).Distinct().ToList()! });

             }

             ProductDetails result = new() { data = _data.Where(x => x.id == id).ToList().First() };
             return result;
         }
        )
        .WithName("GetProductDetails");
        #endregion

    }
}
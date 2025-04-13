using ASP.NETCore_STYLiSH_Back_End.Data;
using ASP.NETCore_STYLiSH_Back_End.Models;
using Microsoft.EntityFrameworkCore;
using STYLiSH.Types;

public static class MarketingApi
{
    public static void MapMarketingApi(this WebApplication app)
    {
        var group = app.MapGroup("/api/1.0/marketing").WithTags("Marketing");

        #region campaigns
        group.MapGet("/campaigns", async (StylishContext context) =>
        {
            Campaign[] _campaign = await context.Campaigns.ToArrayAsync();

            List<CarouselDetails> _data = new();

            for (int i = 0; i < _campaign.Length; i++)
            {
                _data.Add(new CarouselDetails { id = i, product_id = _campaign[i].ProductId, picture = _campaign[i].Picture!, story = _campaign[i].Story! });
            }

            return new MarketingCampaigns() { data = _data.ToArray() };
        }
        )
        .WithName("GetCampaigns");
        #endregion

    }
}
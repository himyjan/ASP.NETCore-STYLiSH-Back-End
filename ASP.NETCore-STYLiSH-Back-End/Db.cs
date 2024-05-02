namespace ASP.NETCore_STYLiSH_Back_End.DB;

// public record CarouselDetails
// {
//   public long id { get; set; }
//   public long product_id { get; set; }
//   public required string picture { get; set; }
//   public required string story { get; set; }
// }

// public record MarketingCampaigns
// {
//   public required CarouselDetails[] data { get; set; }
// }

// public class STYLiSHDB
// {
//   // private static List<CarouselDetails> _campaignData = new()
//   //  {
//   //    new CarouselDetails{ id=1, product_id=201807242228, picture="https://api.appworks-school.tw/assets/201807242228/keyvisual.jpg", story="於是\r\n我也想要給你\r\n一個那麼美好的自己。\r\n不朽《與自己和好如初》" },
//   //    new CarouselDetails{ id=2, product_id=201807242222, picture="https://api.appworks-school.tw/assets/201807242222/keyvisual.jpg", story="永遠\r\n展現自信與專業\r\n無法抵擋的男人魅力。\r\n復古《再一次經典》" },
//   //    new CarouselDetails{ id=3, product_id=201807202140, picture="https://api.appworks-school.tw/assets/201807202140/keyvisual.jpg", story="瞬間\r\n在城市的角落\r\n找到失落多時的記憶。\r\n印象《都會故事集》" },
//   //  };

//   // private static MarketingCampaigns _campaign = new()
//   // {
//   //   data = _campaignData.ToArray()
//   // };


//   // public static MarketingCampaigns GetCampaign()
//   // {
//   //   return _campaign;
//   // }

//   // internal static object GetProducts(string category, int paging)
//   // {
//   //   throw new NotImplementedException();
//   // }

//   // public static Pizza? GetPizza(int id)
//   // {
//   //   return _pizzas.SingleOrDefault(pizza => pizza.Id == id);
//   // }

//   // public static Pizza CreatePizza(Pizza pizza)
//   // {
//   //   _pizzas.Add(pizza);
//   //   return pizza;
//   // }

//   // public static Pizza UpdatePizza(Pizza update)
//   // {
//   //   _pizzas = _pizzas.Select(pizza =>
//   //   {
//   //     if (pizza.Id == update.Id)
//   //     {
//   //       pizza.Name = update.Name;
//   //     }
//   //     return pizza;
//   //   }).ToList();
//   //   return update;
//   // }

//   // public static void RemovePizza(int id)
//   // {
//   //   _pizzas = _pizzas.FindAll(pizza => pizza.Id != id).ToList();
//   // }
// }
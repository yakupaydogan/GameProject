using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class OrderManager : IOrderService
    {
        ICampaignService _campaignService;
        public OrderManager(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }

        public void Sell(Gamer gamer)
        {
            
        }
    }
}

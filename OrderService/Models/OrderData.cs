﻿using System.Collections.Generic;

namespace OrderService.Models
{
    public class OrderData
    {
        public int? Id { get; set; }
        public string Code { get; set; }

        public int IdUser { get; set; }

       //public List<OrderDetailData> Details { get; set; }
    }
}

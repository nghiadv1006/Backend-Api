﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.ViewModels
{
    public class RevenueStatisticViewModel
    {
        public DateTime Date { set; get; }
        public decimal Revenues { set; get; }
        public decimal Benefit { set; get; }
    }
    public class RevenueStatisticMonthViewModel
    {
        public string Month { set; get; }
        public decimal Revenues { set; get; }
        public decimal Benefit { set; get; }
    }

    public class RevenueStatisticYearViewModel
    {
        public string Year { set; get; }
        public decimal Revenues { set; get; }
        public decimal Benefit { set; get; }
    }
}

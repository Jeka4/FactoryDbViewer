﻿using System;

namespace FactoryDbViewer.Tables
{
    public class MonthAccount
    {
        public int DetailId { get; set; }
        public DateTime Date { get; set; }
        public int DepartmentId { get; set; }
        public int MustProduce { get; set; }
    }
}

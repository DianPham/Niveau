﻿namespace Sales_Web.Areas.Admin.Models
{
    public class AdminActivity
    {
        public string? CreatedById { get; set; }
        public DateTime CreatedOn { get; set; }

        public string? ModifiedById { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}

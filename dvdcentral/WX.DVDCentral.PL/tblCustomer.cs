﻿using System;
using System.Collections.Generic;

namespace WX.DVDCentral.PL
{
    public partial class tblCustomer
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Zip { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public int UserId { get; set; }
    }
}

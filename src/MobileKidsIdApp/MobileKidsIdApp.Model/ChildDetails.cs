﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileKidsIdApp.Model
{
    public class ChildDetails
    {
        public string GivenName { get; set; }
        public string AdditonalName { get; set; }
        public string FamilyName { get; set; }
        public DateTime? Birthday { get; set; }
        public IContactReference ContactReference { get; set; }
    }
}

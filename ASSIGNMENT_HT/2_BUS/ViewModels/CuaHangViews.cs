﻿using _1_DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.ViewModels
{
    public class CuaHangViews
    {
        public Guid Id { get; set; }

        public string Ma { get; set; }

        public string Ten { get; set; }

        public string DiaChi { get; set; }

        public string ThanhPho { get; set; }

        public string QuocGia { get; set; }
    }
}

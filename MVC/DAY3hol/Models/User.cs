﻿using System.ComponentModel.DataAnnotations.Schema;

using System.ComponentModel.DataAnnotations;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAY3hol.Models
{
    public class User
    {
        

        

            [Key]

            [DatabaseGenerated(DatabaseGeneratedOption.None)]

            public string UserName { get; set; }

            public string Password { get; set; }

        }
    }

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class Contents
    {

        [ForeignKey("Contents")]
        public int CategoryId { get; set; }

        public virtual Contents Content { get; set; }


    }
}
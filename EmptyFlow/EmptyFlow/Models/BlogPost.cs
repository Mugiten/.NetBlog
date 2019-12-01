using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EmptyFlow.Models
{
    public class BlogPost
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Post { get; set; }
        public string Author { get; set; }
        [DataType(DataType.Date)]
        public DateTime PostDate { get; set; }
    }
}

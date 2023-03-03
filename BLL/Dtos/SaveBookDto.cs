using BAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Dtos
{
    public class SaveBookDto
    {
       
        public string Name { get; set; }


        public float? Rating { get; set; }
        [Required(ErrorMessage = "Category is Required")]
        public int CategoryId { get; set; }

        public List<Author>? Authors { get; set; }

        public List<AuthorBook>? AuthorBooks { get; set; }
    }
}

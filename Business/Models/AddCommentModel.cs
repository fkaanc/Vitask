using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class AddCommentModel
    {
        
        public int TaskId { get; set; }

        [Required]
        public string Content { get; set; }


    }
}

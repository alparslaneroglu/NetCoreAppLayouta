using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreAppLayout.Models
{
    
    public class CategoryCreateInputModel
    {
        [Required(ErrorMessage ="Name alanı boş geçilemez.")]
        public string Name { get; set; }
        [MaxLength(200,ErrorMessage ="En fazla 200 karakter uzunluğunda giriniz.")]
        public string Description { get; set; }

    }
}

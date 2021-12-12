using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NLayerProject.WEB.DTOs
{
    public class CategoryDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="{0} alanı boş olamaz")] // client yeni bir kategori eklemek isterse bu alan zorunlu tutulacak
        public String Name { get; set; }
    }
}

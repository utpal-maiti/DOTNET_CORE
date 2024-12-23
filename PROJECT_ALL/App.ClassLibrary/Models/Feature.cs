using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace App_ClassLibrary
{
    public class Feature
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}

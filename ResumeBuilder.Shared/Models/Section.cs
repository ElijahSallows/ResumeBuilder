using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeBuilder.Shared.Models
{
    public class Section<T> where T : class, new()
    {
        public T Info { get; set; } = new();
        public bool IsActive { get; set; } = default;
    }
}

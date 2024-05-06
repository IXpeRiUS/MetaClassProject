using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaClassProject
{
    // Класс Metadata со свойством Name и списком MetaProperty
    public class MetaData
    {
        public string Name { get; set; }
        public List<MetaProperty> Properties { get; set; }

        public MetaData()
        {
            Properties = new List<MetaProperty>();
        }
    }
}

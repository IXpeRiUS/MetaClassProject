using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaClassProject
{
    public static class ClassGenerator
    {
        public static string GenerateClass(MetaData metaData)
        {
            StringBuilder sb = new StringBuilder();
           
            // Добавляем имя класса
            sb.AppendLine($"public class {metaData.Name}");
            sb.AppendLine("{");

            // Добавляем поля на основе свойств Metadata
            foreach(var property  in metaData.Properties)
            {
                sb.AppendLine($"public {GetTypeName(property.Type)} {property.Name} {{ get; set; }}");
            }

            sb.AppendLine("}");
            return sb.ToString();
        }

        // Метод для получения имени типа C# на основе типа MetaProperty
        private static string GetTypeName(MetaPropertyType type)
        {
            switch (type) 
            {
                case MetaPropertyType.intType:
                    return "int";
                case MetaPropertyType.doubleType:
                    return "double";
                case MetaPropertyType.stringType:
                    return "string";
                default:
                    throw new ArgumentException("Неизвестный тип свойства");
            }


        }

    }
}

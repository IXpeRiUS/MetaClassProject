namespace MetaClassProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем экземпляр Metadata
            MetaData metaData = new MetaData
            {
                Name = "ТЕСТ",
                Properties = new List<MetaProperty>()
                {
                    new MetaProperty {Name = "ИНТ", Type = MetaPropertyType.intType},
                    new MetaProperty {Name = "СТРИНГ", Type = MetaPropertyType.stringType},
                    new MetaProperty {Name = "ДАБЛ", Type = MetaPropertyType.doubleType}
                }
            };

            // Генерируем код класса на основе Metadata
            string generatedClassCode = ClassGenerator.GenerateClass(metaData);
            
            // Выводим сгенерированный код
            Console.WriteLine(generatedClassCode);

        }
    }
}

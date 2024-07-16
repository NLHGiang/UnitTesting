using System.Collections.Generic;

namespace UnitTesting
{
    public class ObjectService
    {
        public List<ObjectModel> Datas;

        public List<ObjectModel> InputDatas()
        {
            Datas = new List<ObjectModel>();

            Datas.Add(new ObjectModel(1, "Obj 1", "NULL"));
            Datas.Add(new ObjectModel(2, "Obj 2", "NULL"));
            Datas.Add(new ObjectModel(3, "Obj 3", "NULL"));

            return Datas;
        }
    }

    public class ObjectModel
    {
        public ObjectModel(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
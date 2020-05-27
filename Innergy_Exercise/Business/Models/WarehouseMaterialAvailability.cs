using System.Collections.Generic;
using System.Linq;

namespace Innergy_Exercise.Business.Models
{
    public class WarehouseMaterialAvailability
    {
        private IList<MaterialAvailability> _materials;

        public WarehouseMaterialAvailability()
        {
            Materials = new List<MaterialAvailability>();
        }

        public string WarehouseName { get; set; }

        public IList<MaterialAvailability> Materials
        {
            get
            {
                return _materials.OrderBy(x=>x.MaterialId).ToList();
            }

            set => _materials = value;
        }

        public int TotalMaterials
        {
            get
            {
                return Materials.Sum(x => x.MaterialQuantity);
            }
        }
    }

    public class MaterialAvailability
    {
        public string MaterialId { get; set; }
        public int MaterialQuantity { get; set; }
    }
}

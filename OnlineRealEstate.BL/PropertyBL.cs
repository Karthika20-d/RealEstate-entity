using OnlineRealEstate.DAL;
using OnlineRealEstate.Entity;
using System.Collections.Generic;

namespace OnlineRealEstate.BL
{
    public class PropertyBL
    {
        PropertyRepositary propertyRepositary = new PropertyRepositary();
        public int Create(Property property)
        {
            return propertyRepositary.Create(property);
        }
        public IEnumerable<Property> DisplayPropertyDetails()
        {
            return propertyRepositary.DisplayPropertyDetails();
        }
        public Property Update(int landId)
        {
           return propertyRepositary.Update(landId);
        }
        public void UpdatePropertyDetails(Property property)
        {
            propertyRepositary.UpdatePropertyDetails(property);
        }
        public void Delete(int landId)
        {
            propertyRepositary.Delete(landId);
        }
    }
}

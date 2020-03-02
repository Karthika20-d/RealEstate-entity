using OnlineRealEstate.Entity;
using System.Collections.Generic;
using System.Linq;

namespace OnlineRealEstate.DAL
{
    public class PropertyRepositary
    {
        List<Property> propertyList = new List<Property>();
        PropertyContext propertyContext = new PropertyContext();
        public int Create(Property property)
        {
           
            propertyContext.Property.Add(property);
            return propertyContext.SaveChanges();
        }
        public IEnumerable<Property> DisplayPropertyDetails()
        {
            return propertyContext.Property.ToList();
        }
        public Property Update(int landId)
        {
            Property property = new Property();
            property=propertyContext.Property.Find(landId);
            return property;
            
        }
        public void UpdatePropertyDetails(Property property)
        {
            Property propertyValue= propertyContext.Property.Find(property.LandId);
            propertyValue.LandId = property.LandId;
            propertyValue.Area = property.Area;
            propertyValue.PropertyType = property.PropertyType;
            propertyValue.Location = property.Location;
            propertyContext.SaveChanges();
        }
        public void Delete(int landId)
        {
            Property propertyValue = propertyContext.Property.Find(landId);
            propertyContext.Property.Remove(propertyValue);
            propertyContext.SaveChanges();

        }
    }
}

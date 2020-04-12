using MemberShipsPro.Models;
using System.Collections.Generic;

namespace MemberShipsPro.Comparers
{
    public class ProductSectionEqualityComparer : IEqualityComparer<ProductSection>
    {
        public bool Equals(ProductSection section1, ProductSection section2)
        {
            return section1.Id.Equals(section2.Id);
        }

        public int GetHashCode(ProductSection section)
        {
            return (section.Id).GetHashCode();
        }
    }
}
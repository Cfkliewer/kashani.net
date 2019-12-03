using GraphQL.Types;
using Properties.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Properties.Schema
{
    public class PropertyType : ObjectGraphType<Property>
    {

        /*
         *  Set type so be able to be able to query GraphQL
         *  Can also tell GraphQL to look for other class/Type via resolve:
         */
        public PropertyType()
        {
            Field(p => p.MlsId);
            Field(p => p.Roof);
            Field(p => p.Cooling);
            Field(p => p.Style);
            Field(p => p.BathsFull);
            Field(p => p.BathsHalf);
            Field(p => p.Stories);
            Field(p => p.Fireplaces);
            Field(p => p.Flooring);
            Field(p => p.Heating);
            Field(p => p.Bathrooms);
            Field(p => p.Foundation);
            Field(p => p.LaundryFeatures);
            Field(p => p.OccupantName);
            Field(p => p.OwnerName);
            Field(p => p.LotDescription);
            Field(p => p.Pool);
            Field(p => p.SubType);
            Field(p => p.Bedrooms);
            Field(p => p.InteriorFeatures);
            Field(p => p.LotSize);
            Field(p => p.AreaSource);
            Field(p => p.MaintenanceExpense);
            Field(p => p.AdditionalRooms);
            Field(p => p.ExteriorFeatures);
            Field(p => p.Water);
            Field(p => p.View);
            Field(p => p.LotSizeArea);
            Field(p => p.Subdivision);
            Field(p => p.Construction);
            Field(p => p.LotSizeAreaUnits);
            Field(p => p.Type);
            Field(p => p.GarageSpaces);
            Field(p => p.BathsThreeQuarter);
            Field(p => p.Accessibility);
            Field(p => p.Acres);
            Field(p => p.OccupantType);
            Field(p => p.SubTypeText);
            Field(p => p.YearBuilt);
            Field(p => p.ListPrice);
            Field(p => p.ListingId);
        }
    }
}

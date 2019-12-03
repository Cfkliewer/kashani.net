using System;
using System.Collections.Generic;
using System.Text;

namespace Properties.Models
{
    public class Property
    {
        public Property(string mlsId, string roof, string cooling, string style, string area, int bathsFull, int bathsHalf, int stories, int fireplaces, string flooring, string heating, string bathrooms, string foundation, string laundryFeatures, string occupantName, string ownerName, string lotDescription, string pool, string subType, int bedrooms, string interiorFeatures, string lotSize, string areaSource, string maintenanceExpense, string additionalRooms, string exteriorFeatures, string water, string view, int lotSizeArea, string subdivision, string construction, string lotSizeAreaUnits, string type, float garageSpaces, string bathsThreeQuarter, string accessibility, string acres, string occupantType, string subTypeText, string yearBuilt, int listPrice, string listingId)
        {
            MlsId = mlsId;
            Roof = roof;
            Cooling = cooling;
            Style = style;
            Area = area;
            BathsFull = bathsFull;
            BathsHalf = bathsHalf;
            Stories = stories;
            Fireplaces = fireplaces;
            Flooring = flooring;
            Heating = heating;
            Bathrooms = bathrooms;
            Foundation = foundation;
            LaundryFeatures = laundryFeatures;
            OccupantName = occupantName;
            OwnerName = ownerName;
            LotDescription = lotDescription;
            Pool = pool;
            SubType = subType;
            Bedrooms = bedrooms;
            InteriorFeatures = interiorFeatures;
            LotSize = lotSize;
            AreaSource = areaSource;
            MaintenanceExpense = maintenanceExpense;
            AdditionalRooms = additionalRooms;
            ExteriorFeatures = exteriorFeatures;
            Water = water;
            View = view;
            LotSizeArea = lotSizeArea;
            Subdivision = subdivision;
            Construction = construction;
            LotSizeAreaUnits = lotSizeAreaUnits;
            Type = type;
            GarageSpaces = garageSpaces;
            BathsThreeQuarter = bathsThreeQuarter;
            Accessibility = accessibility;
            Acres = acres;
            OccupantType = occupantType;
            SubTypeText = subTypeText;
            YearBuilt = yearBuilt;
            ListPrice = listPrice;
            ListingId = listingId;
        }

        public string MlsId { get; set; }
        public string Roof { get; set; }
        public string Cooling { get; set; }
        public string Style { get; set; }
        public string Area { get; set; }
        public int BathsFull { get; set; }
        public int BathsHalf { get; set; }
        public int Stories { get; set; }
        public int Fireplaces { get; set; }
        public string Flooring { get; set; }
        public string Heating { get; set; }
        public string Bathrooms { get; set; }
        public string Foundation { get; set; }
        public string LaundryFeatures { get; set; }
        public string OccupantName { get; set; }
        public string OwnerName { get; set; }
        public string LotDescription { get; set; }
        public string Pool { get; set; }
        public string SubType { get; set; }
        public int Bedrooms { get; set; }
        public string InteriorFeatures { get; set; }
        public string LotSize { get; set; }
        public string AreaSource { get; set; }
        public string MaintenanceExpense { get; set; }
        public string AdditionalRooms { get; set; }
        public string ExteriorFeatures { get; set; }
        public string Water { get; set; }
        public string View { get; set; }
        public int LotSizeArea { get; set; }
        public string Subdivision { get; set; }
        public string Construction { get; set; }
        public string LotSizeAreaUnits { get; set; }
        public string Type { get; set; }
        public float GarageSpaces { get; set; }
        public string BathsThreeQuarter { get; set; }
        public string Accessibility { get; set; }
        public string Acres { get; set; }
        public string OccupantType { get; set; }
        public string SubTypeText { get; set; }
        public string YearBuilt { get; set; }
        public int ListPrice { get; set; }
        public string ListingId {get;set;}
        
    }
}

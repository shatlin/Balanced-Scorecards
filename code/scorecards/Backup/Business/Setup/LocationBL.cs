using System;
using System.Collections.Generic;
using System.Text;
using Data.Setup.LocationTableAdapters;
using Data.Setup;
namespace Business.Setup
{
    [System.ComponentModel.DataObject]
   public class LocationBL
    {
        private LocationDAL locationAdapter = new LocationDAL();

        protected LocationDAL LocationAdapter
        {
            get
            {
                if (locationAdapter == null)
                {
                    locationAdapter = new LocationDAL();
                }

                return locationAdapter;
            }

        }

        

        public string GetLocationNameByID(int iLocationId)
        {
            return LocationAdapter.GetLocationNameById(iLocationId).ToString();
            
        }


       [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Select, true)]
       public Location.LocationDataTable GetLocation()
       {
           return LocationAdapter.GetLocations();
       }

        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Insert, true)]
        public bool AddLocation(string LocationName, string LocationAddress)
        {

            Location.LocationDataTable objLocation = new Location.LocationDataTable();
           Location.LocationRow objLocationRow = objLocation.NewLocationRow();

            objLocationRow.LocationName = LocationName;
            if (LocationAddress == string.Empty) objLocationRow.SetLocationAddressNull();
            else objLocationRow.LocationAddress = LocationAddress;


            objLocation.AddLocationRow(objLocationRow);

            int rowsAffected = LocationAdapter.Update(objLocationRow);
            // Return true if precisely one row was inserted,
            // otherwise false
            return rowsAffected == 1;
        }

        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Update, true)]
        public bool UpdateLocation(int LocationID, string LocationName, string LocationAddress)
        {

            Location.LocationDataTable objLocation = LocationAdapter.GetLocationById(LocationID);


            if (objLocation.Count == 0)
                // no matching record found, return false
                return false;
            Location.LocationRow objLocationRow = objLocation[0];

            objLocationRow.LocationName = LocationName;
            if (LocationAddress == string.Empty) objLocationRow.SetLocationAddressNull();
            else objLocationRow.LocationAddress = LocationAddress;

            int rowsAffected = LocationAdapter.Update(objLocationRow);
            // Return true if precisely one row was updated,
            // otherwise false
            return rowsAffected == 1;
        }


        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Delete, true)]
        public bool DeleteLocation(int LocationID)
        {
            int rowsAffected = LocationAdapter.Delete(LocationID);
            // Return true if precisely one row was deleted,
            // otherwise false
            return rowsAffected == 1;
        }


    }


   
}

using System;
using System.Collections.Generic;
using System.Text;
using Data.Setup.OrgHierarchyTableAdapters;

using Data.Setup;

namespace Business.Setup
{
    [System.ComponentModel.DataObject]
    public class OrgHierarchyBL
    {
        private OrgHierarchyTableAdapter oHAdapter = new OrgHierarchyTableAdapter();

        protected OrgHierarchyTableAdapter orgHierarchyAdapter
         {
             get
             {
                 if (oHAdapter == null)
                 {
                     oHAdapter = new OrgHierarchyTableAdapter();
                 }

                 return oHAdapter;
             }

         }


        public string GetOrganizationNameByID(int iOrgId)
        {
            return orgHierarchyAdapter.GetOrgHierarchyNameById(iOrgId).ToString();

        }

       [System.ComponentModel.DataObjectMethodAttribute
       (System.ComponentModel.DataObjectMethodType.Select, true)]
        public OrgHierarchy.OrgHierarchyDataTable GetOrganizationHierarchy()
        {
            return orgHierarchyAdapter.GetOrgHierarchyDetails();
        }



        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Insert, true)]
        public bool AddOrganizationHierarchy(string OrgHierarchyName, int LocationId, 
                                             System.Nullable<int> ParentOrgHierarchyId, 
                                             System.Nullable<int> OrgHierarchySequence)
        {

            OrgHierarchy.OrgHierarchyDataTable objOHDataTable = new OrgHierarchy.OrgHierarchyDataTable();

            OrgHierarchy.OrgHierarchyRow objOHRow = objOHDataTable.NewOrgHierarchyRow();


            objOHRow.OrgHierarchyName = OrgHierarchyName;
            objOHRow.LocationId = LocationId;
            
            if (ParentOrgHierarchyId.HasValue)
                objOHRow.ParentOrgHierarchyId = ParentOrgHierarchyId.Value;
             else
                objOHRow.SetParentOrgHierarchyIdNull();

            if (OrgHierarchySequence.HasValue)
                objOHRow.OrgHierarchySequence = OrgHierarchySequence.Value;
              else
                objOHRow.SetOrgHierarchySequenceNull();

            objOHDataTable.AddOrgHierarchyRow(objOHRow);
            int rowsAffected = orgHierarchyAdapter.Update(objOHRow);
            // Return true if precisely one row was inserted,
            // otherwise false
            return rowsAffected == 1;
        }



        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Update, true)]
        public bool UpdateOrganizationHierarchy(int OrgHierarchyID, string OrgHierarchyName, int LocationId,
                                             System.Nullable<int> ParentOrgHierarchyId,
                                             System.Nullable<int> OrgHierarchySequence)
        {
            OrgHierarchy.OrgHierarchyDataTable objOHDataTable = orgHierarchyAdapter.GetOrgHierarchyById(OrgHierarchyID);






            if (objOHDataTable.Count == 0)
                // no matching record found, return false
                return false;

            OrgHierarchy.OrgHierarchyRow objOHRow = objOHDataTable[0];

            objOHRow.OrgHierarchyName = OrgHierarchyName;
            objOHRow.LocationId = LocationId;

            if (ParentOrgHierarchyId.HasValue)
                objOHRow.ParentOrgHierarchyId = ParentOrgHierarchyId.Value;
            else
                objOHRow.SetParentOrgHierarchyIdNull();

            if (OrgHierarchySequence.HasValue)
                objOHRow.OrgHierarchySequence = OrgHierarchySequence.Value;
            else
                objOHRow.SetOrgHierarchySequenceNull();


            int rowsAffected = orgHierarchyAdapter.Update(objOHRow);
            // Return true if precisely one row was updated,
            // otherwise false
            return rowsAffected == 1;
        }

        [System.ComponentModel.DataObjectMethodAttribute
       (System.ComponentModel.DataObjectMethodType.Delete, true)]
        public bool DeleteOrgHierarchy(int OrgHierarchyID)
        {
            int rowsAffected = orgHierarchyAdapter.Delete(OrgHierarchyID);
            // Return true if precisely one row was deleted,
            // otherwise false
            return rowsAffected == 1;
        }



    }
}

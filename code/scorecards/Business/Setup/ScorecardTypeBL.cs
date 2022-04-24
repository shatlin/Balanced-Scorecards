using System;
using System.Collections.Generic;
using System.Text;
using Data.Setup;
using Data.Setup.ScorecardTypesTableAdapters;

namespace Business.Setup
{
    [System.ComponentModel.DataObject]
    public class ScorecardTypeBL
    {
        private ScorecardTypeTableAdapter SCTAdapter = new ScorecardTypeTableAdapter();

        protected ScorecardTypeTableAdapter ScorecardAdapter
        {
            get
            {
                if (SCTAdapter == null)
                {
                    SCTAdapter = new ScorecardTypeTableAdapter();
                }

                return SCTAdapter;
            }

        }

        [System.ComponentModel.DataObjectMethodAttribute
       (System.ComponentModel.DataObjectMethodType.Select, true)]
        public ScorecardTypes.ScorecardTypeDataTable GetScorecardTypes()
        {
            return ScorecardAdapter.GetScorecardDetails();
        }

        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Update, true)]
        public bool UpdateScorecardTypes(int ScorecardId, string ScorecardName, string ScorecardDetail)
        {

            ScorecardTypes.ScorecardTypeDataTable objScorecardTypes = ScorecardAdapter.GetScorecardById(ScorecardId);


            if (objScorecardTypes.Count == 0)
                // no matching record found, return false
                return false;
            ScorecardTypes.ScorecardTypeRow objScorecardRow = objScorecardTypes[0];

            objScorecardRow.ScorecardName = ScorecardName;
            if (ScorecardDetail == string.Empty) objScorecardRow.SetScorecardDetailNull();
            else objScorecardRow.ScorecardDetail = ScorecardDetail;

            int rowsAffected = ScorecardAdapter.Update(objScorecardRow);
            // Return true if precisely one row was updated,
            // otherwise false
            return rowsAffected == 1;
        }
    }


    
}

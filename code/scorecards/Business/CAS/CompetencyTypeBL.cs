using System;
using System.Collections.Generic;
using System.Text;
using Data.CAS.CompetencyTypeTableAdapters;
using Data.CAS;

namespace Business.CAS
{
    [System.ComponentModel.DataObject]
    public class CompetencyTypeBL
    {
        private CompetencyTypeTableAdapter competencyTypeAdapter = new CompetencyTypeTableAdapter();

        protected CompetencyTypeTableAdapter CompetencyTypeAdapter
        {
            get
            {
                if (competencyTypeAdapter == null)
                {
                    competencyTypeAdapter = new CompetencyTypeTableAdapter();
                }

                return competencyTypeAdapter;
            }

        }

        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Select, true)]
        public CompetencyType.CompetencyTypeDataTable GetCompetencyTypes()
        {
            return CompetencyTypeAdapter.GetCompetencyTypes();
        }

               [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Select, true)]
        public string GetCompetencyTypeNameByID(int iCompetencyTypeId)
        {
            return CompetencyTypeAdapter.GetCompetencyTypeNameById(iCompetencyTypeId).ToString();

        }

        [System.ComponentModel.DataObjectMethodAttribute
   (System.ComponentModel.DataObjectMethodType.Insert, true)]
        public bool AddCompetencyType(string CompetencyTypeName, string CompetencyTypeDescription)
        {

            CompetencyType.CompetencyTypeDataTable objCompetencyType = new CompetencyType.CompetencyTypeDataTable();
            CompetencyType.CompetencyTypeRow objCompetencyTypeRow = objCompetencyType.NewCompetencyTypeRow();

            objCompetencyTypeRow.CompetencyTypeName = CompetencyTypeName;
            if (CompetencyTypeDescription == string.Empty) objCompetencyTypeRow.SetCompetencyTypeDescriptionNull();
            else objCompetencyTypeRow.CompetencyTypeDescription = CompetencyTypeDescription;


            objCompetencyType.AddCompetencyTypeRow(objCompetencyTypeRow);

            int rowsAffected = CompetencyTypeAdapter.Update(objCompetencyTypeRow);
            // Return true if precisely one row was inserted,
            // otherwise false
            return rowsAffected == 1;
        }

        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Update, true)]
        public bool UpdateCompetencyType(int CompetencyTypeId, string CompetencyTypeName, string CompetencyTypeDescription)
        {

            CompetencyType.CompetencyTypeDataTable objCompetencyType = CompetencyTypeAdapter.GetCompetencyTypeById(CompetencyTypeId);

            if (objCompetencyType.Count == 0)
                // no matching record found, return false
                return false;

            CompetencyType.CompetencyTypeRow objCompetencyTypeRow = objCompetencyType[0];

            objCompetencyTypeRow.CompetencyTypeName = CompetencyTypeName;
            if (CompetencyTypeDescription == string.Empty) objCompetencyTypeRow.SetCompetencyTypeDescriptionNull();
            else objCompetencyTypeRow.CompetencyTypeDescription = CompetencyTypeDescription;

            int rowsAffected = CompetencyTypeAdapter.Update(objCompetencyTypeRow);
            // Return true if precisely one row was updated,
            // otherwise false
            return rowsAffected == 1;
        }


        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Delete, true)]
        public bool DeleteCompetencyType(int CompetencyTypeID)
        {
            int rowsAffected = CompetencyTypeAdapter.Delete(CompetencyTypeID);
            // Return true if precisely one row was deleted,
            // otherwise false
            return rowsAffected == 1;
        }


    }


}
 
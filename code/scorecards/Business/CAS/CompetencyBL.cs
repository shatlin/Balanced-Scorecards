using System;
using System.Collections.Generic;
using System.Text;
using Data.CAS.CompetencyTableAdapters;
using Data.CAS;

namespace Business.CAS
{
    [System.ComponentModel.DataObject]
    public class CompetencyBL
    {
        private CompetencyTableAdapter competencyAdapter = new CompetencyTableAdapter();

        protected CompetencyTableAdapter CompetencyAdapter
        {
            get
            {
                if (competencyAdapter == null)
                {
                    competencyAdapter = new CompetencyTableAdapter();
                }

                return competencyAdapter;
            }

        }

        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Select, true)]
        public Competency.CompetencyDataTable GetCompetencies()
        {
            return CompetencyAdapter.GetCompetencies();
        }

        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Select, true)]
        public Competency.CompetencyDataTable GetCompetenciesByType(int iCompetencyTypeId)
        {
            return CompetencyAdapter.GetCompetenciesByType(iCompetencyTypeId);
        }


        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Select, true)]
        public string GetCompetencyNameByID(int iCompetencyId)
        {
            return CompetencyAdapter.GetCompetencyNamebyID(iCompetencyId).ToString();
        }

        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Insert, true)]
        public bool AddCompetency(int CompetencyTypeId, string CompetencyName, string CompetencyDesc)
        {
            
            Competency.CompetencyDataTable objCompetency = new Competency.CompetencyDataTable();
            Competency.CompetencyRow objCompetencyRow = objCompetency.NewCompetencyRow();

            objCompetencyRow.CompetencyTypeId = CompetencyTypeId;
            objCompetencyRow.CompetencyName = CompetencyName;
            if (CompetencyDesc == string.Empty) objCompetencyRow.SetCompetencyDescNull();
            else objCompetencyRow.CompetencyDesc = CompetencyDesc;


            objCompetency.AddCompetencyRow(objCompetencyRow);

            int rowsAffected = CompetencyAdapter.Update(objCompetencyRow);
            // Return true if precisely one row was inserted,
            // otherwise false
            return rowsAffected == 1;
        }

        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Update, true)]
        public bool UpdateCompetency(int CompetencyId, int CompetencyTypeId, string CompetencyName, string CompetencyDesc)
        {
            
            Competency.CompetencyDataTable objCompetency = CompetencyAdapter.GetCompetencyById(CompetencyId);

            if (objCompetency.Count == 0)
                // no matching record found, return false
                return false;

            Competency.CompetencyRow objCompetencyRow = objCompetency[0];

            objCompetencyRow.CompetencyName = CompetencyName;

            if (CompetencyDesc == string.Empty) objCompetencyRow.SetCompetencyDescNull();
            else objCompetencyRow.CompetencyDesc = CompetencyDesc;

            int rowsAffected = CompetencyAdapter.Update(objCompetencyRow);
            // Return true if precisely one row was updated,
            // otherwise false
            return rowsAffected == 1;
        }


        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Delete, true)]
        public bool DeleteCompetency(int CompetencyID)
        {
            int rowsAffected = CompetencyAdapter.Delete(CompetencyID);
            // Return true if precisely one row was deleted,
            // otherwise false
            return rowsAffected == 1;
        }

    }


}
 
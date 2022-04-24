using System;
using System.Collections.Generic;
using System.Text;
using Data.Setup;
using Data.Setup.PeriodTableAdapters;

namespace Business.Setup
{
    [System.ComponentModel.DataObject]
    public class PeriodBL
    {
        private PeriodTableAdapter periodAdapter = new PeriodTableAdapter();

        protected PeriodTableAdapter PeriodAdapter
        {
            get
            {
                if (periodAdapter == null)
                {
                    periodAdapter = new PeriodTableAdapter();
                }

                return periodAdapter;
            }

        }

        [System.ComponentModel.DataObjectMethodAttribute
       (System.ComponentModel.DataObjectMethodType.Select, true)]
        public Period.PeriodDataTable GetPeriod()
        {
            return PeriodAdapter.GetPeriods();
        }


        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Update, true)]
        public bool UpdatePeriod(int PeriodId, int ScorecardTypeId, DateTime ExercisePeriodStartDate, DateTime ExercisePeriodEndDate, DateTime ExerciseStartDate, DateTime ExerciseEndDate)
        {

            Period.PeriodDataTable objPeriod = PeriodAdapter.GetPeriodById(PeriodId);


            if (objPeriod.Count == 0)
                // no matching record found, return false
                return false;
            Period.PeriodRow objPeriodRow = objPeriod[0];

            objPeriodRow.ScorecardTypeId = ScorecardTypeId;
            objPeriodRow.ExercisePeriodStartDate=ExercisePeriodStartDate;
            objPeriodRow.ExercisePeriodEndDate=ExercisePeriodEndDate;
            objPeriodRow.ExerciseStartDate=ExerciseStartDate;
            objPeriodRow.ExerciseEndDate=ExerciseEndDate;
                
            
            int rowsAffected = PeriodAdapter.Update(objPeriodRow);
            // Return true if precisely one row was updated,
            // otherwise false
            return rowsAffected == 1;
        }
    }


    
}

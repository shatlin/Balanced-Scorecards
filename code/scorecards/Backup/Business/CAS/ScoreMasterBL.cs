using System;
using System.Collections.Generic;
using System.Text;
using Data.CAS.ScoreMasterTableAdapters;
using Data.CAS;
using System.Data;
namespace Business.CAS
{
    [System.ComponentModel.DataObject]
    public class ScoreMasterBL
    {
        private ScoreMasterTableAdapter scoreMasterAdapter = new ScoreMasterTableAdapter();

        protected ScoreMasterTableAdapter ScoreMasterAdapter
        {
            get
            {
                if (scoreMasterAdapter == null)
                {
                    scoreMasterAdapter = new ScoreMasterTableAdapter();
                }

                return scoreMasterAdapter;
            }

        }

        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Select, true)]
        public ScoreMaster.ScoreMasterDataTable GetScoreMaster()
        {
            return ScoreMasterAdapter.GetScoreMaster();
        }

        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Select, true)]
        public ScoreMaster.ScoreMasterDataTable GetScoreMasterbyId(int iScoreMasterId)
        {
            return ScoreMasterAdapter.GetScoreMasterbyId(iScoreMasterId);
        }


        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Select, true)]
        public int GetScoreMasterbyAppUsesrId(int iAppUserId)
        {

            ScoreMaster.ScoreMasterDataTable objScoreMaster = ScoreMasterAdapter.GetScoreMasterByAppUserId(iAppUserId);

            if (objScoreMaster.Count == 0)

                return 0;
            else
                return Convert.ToInt32(objScoreMaster[0][0]);

        
        }

        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Insert, true)]
        public bool AddScoreMaster(int? MasterPhaseId, int AppUserId, int? ScoreStatusId)
        {

            ScoreMaster.ScoreMasterDataTable objScoreMaster = new ScoreMaster.ScoreMasterDataTable();
            ScoreMaster.ScoreMasterRow objScoreMasterRow = objScoreMaster.NewScoreMasterRow();

            if(MasterPhaseId.HasValue)
                objScoreMasterRow.MasterPhaseId = MasterPhaseId.Value;
            else 
                objScoreMasterRow.SetMasterPhaseIdNull();
            
            objScoreMasterRow.AppUserId = AppUserId;

            if (ScoreStatusId.HasValue)
                objScoreMasterRow.ScoreStatusId = ScoreStatusId.Value;
            else
                objScoreMasterRow.SetScoreStatusIdNull();

            

            objScoreMaster.AddScoreMasterRow(objScoreMasterRow);

            int rowsAffected = ScoreMasterAdapter.Update(objScoreMasterRow);
            // Return true if precisely one row was inserted,
            // otherwise false
            return rowsAffected == 1;
        }

        public int GetLatestScoreMasterId()
        {
            int? iLatestScoreMasterId = ScoreMasterAdapter.GetLatestScoreMasterId();
            if (iLatestScoreMasterId.HasValue)
                return iLatestScoreMasterId.Value;
            else
                return 0;
        }

        // returns 0 if the user is not found
        // if user is found it returns the scoremasterid
        public int CheckifUserExistsinScoreMaster(int iAppUserId)
        {
            ScoreMaster.ScoreMasterDataTable objScoreMaster = ScoreMasterAdapter.CheckifUserExistsinScoreMaster(iAppUserId);

            if (objScoreMaster.Count == 0)

                return 0;
            else
                return Convert.ToInt32(objScoreMaster[0][0]);
        }



        [System.ComponentModel.DataObjectMethodAttribute
 (System.ComponentModel.DataObjectMethodType.Delete, true)]
        public void DeleteAllScoreMaster()
        {
            ScoreMasterAdapter.DeleteAllScoreMaster();
            
        }

    }
}

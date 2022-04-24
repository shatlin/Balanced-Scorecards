using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Data.CAS.ScoreDetailTableAdapters;
using Data.CAS;

namespace Business.CAS
{
    [System.ComponentModel.DataObject]
    public class ScoreDetailBL
    {
        private ScoreDetailTableAdapter scoreDetailAdapter = new ScoreDetailTableAdapter();

        protected ScoreDetailTableAdapter ScoreDetailAdapter
        {
            get
            {
                if (scoreDetailAdapter == null)
                {
                    scoreDetailAdapter = new ScoreDetailTableAdapter();
                }

                return scoreDetailAdapter;
            }

        }

        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Select, true)]
        public ScoreDetail.ScoreDetailDataTable GetScoreDetail()
        {
            return ScoreDetailAdapter.GetScoreDetail();
        }

        [System.ComponentModel.DataObjectMethodAttribute
(System.ComponentModel.DataObjectMethodType.Select, true)]
        public ScoreDetail.ScoreDetailDataTable GetScoreDetailForAppUser(int iAppUserId)
        {
            return ScoreDetailAdapter.GetScoreDetailForAppUser(iAppUserId);
        }


        [System.ComponentModel.DataObjectMethodAttribute
(System.ComponentModel.DataObjectMethodType.Select, true)]
        public bool isUserRatedByOrdinate(int iAppUserId)
        {
            bool bUserRatedByOrdinate = false;
            DataTable DtDetailScore=ScoreDetailAdapter.GetScoreDetailForAppUser(iAppUserId);
            foreach (DataRow dtrow in DtDetailScore.Rows)
            {
                

                if (Convert.ToString(dtrow[4])==String.Empty)
                    bUserRatedByOrdinate = false;
                else
                    bUserRatedByOrdinate = true;
            }


            return bUserRatedByOrdinate;
        }


        [System.ComponentModel.DataObjectMethodAttribute
(System.ComponentModel.DataObjectMethodType.Select, true)]
        public bool isUserAgreedRated(int iAppUserId)
        {
            bool bUserAgreedRated = false;
            DataTable DtDetailScore = ScoreDetailAdapter.GetScoreDetailForAppUser(iAppUserId);
            foreach (DataRow dtrow in DtDetailScore.Rows)
            {


                if (Convert.ToString(dtrow[5]) == String.Empty)
                    bUserAgreedRated = false;
                else
                    bUserAgreedRated = true;
            }


            return bUserAgreedRated;
        }


        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Select, true)]
        public ScoreDetail.ScoreDetailDataTable GetScoreDetailbyId(int iScoreDetailId)
        {
            return ScoreDetailAdapter.GetScoreDetailbyId(iScoreDetailId);
        }

        [System.ComponentModel.DataObjectMethodAttribute
       (System.ComponentModel.DataObjectMethodType.Select, true)]
        public int GetScoreDetailIDForCompetencyAndScoreMasterId(int iScoreDetailId,int iCompetencyId)
        {
            return Convert.ToInt32 (ScoreDetailAdapter.GetScoreDetailIDForCompetencyAndScoreMasterId(iScoreDetailId,iCompetencyId));
        }


        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Select, true)]
        public ScoreDetail.ScoreDetailDataTable GetScoreDetailsByScoreMasterId(int iScoreMasterIdId)
        {
            return ScoreDetailAdapter.GetScoreDetailsByScoreMasterId(iScoreMasterIdId);
        }

        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Insert, true)]
        public bool AddScoreDetail(int ScoreMasterId, int competencyId, int? selfrating, int? Ordinaterating, int? agreedrating)
        {

            ScoreDetail.ScoreDetailDataTable objScoreDetail = new ScoreDetail.ScoreDetailDataTable();
            ScoreDetail.ScoreDetailRow objScoreDetailRow = objScoreDetail.NewScoreDetailRow();

                objScoreDetailRow.ScoreMasterId = ScoreMasterId;

                objScoreDetailRow.CompetencyId = competencyId;
            
            if (selfrating.HasValue)
                    objScoreDetailRow.SelfRating = selfrating.Value;
            else
                objScoreDetailRow.SetSelfRatingNull();
            
            if (Ordinaterating.HasValue)
                objScoreDetailRow.OrdinateRating = Ordinaterating.Value;
            else
                objScoreDetailRow.SetOrdinateRatingNull();


            if (agreedrating.HasValue)
                objScoreDetailRow.AgreedRating = agreedrating.Value;
            else
                objScoreDetailRow.SetAgreedRatingNull();


            objScoreDetail.AddScoreDetailRow(objScoreDetailRow);

            int rowsAffected = ScoreDetailAdapter.Update(objScoreDetailRow);
            // Return true if precisely one row was inserted,
            // otherwise false
            return rowsAffected == 1;
        }


        [System.ComponentModel.DataObjectMethodAttribute
       (System.ComponentModel.DataObjectMethodType.Update, true)]
        public bool UpdateScoreDetail(int ScoreDetailId,int ScoreMasterId, int CompetencyId, int? selfrating, int? ordinaterating, int? agreedrating)
        {

            ScoreDetail.ScoreDetailDataTable objScoreDetail = ScoreDetailAdapter.GetScoreDetailbyId(ScoreDetailId);

            if (objScoreDetail.Count == 0)
                // no matching record found, return false
                return false;

            ScoreDetail.ScoreDetailRow objScoreDetailRow = objScoreDetail[0];

            objScoreDetailRow.ScoreMasterId = ScoreMasterId;
            objScoreDetailRow.CompetencyId = CompetencyId;

            if (selfrating.HasValue) objScoreDetailRow.SelfRating = selfrating.Value;
            if (ordinaterating.HasValue) objScoreDetailRow.OrdinateRating = ordinaterating.Value;
            if (agreedrating.HasValue) objScoreDetailRow.AgreedRating = agreedrating.Value;

            int rowsAffected = ScoreDetailAdapter.Update(objScoreDetailRow);
            // Return true if precisely one row was updated,
            // otherwise false
            return rowsAffected == 1;
        }


        [System.ComponentModel.DataObjectMethodAttribute
(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public void DeleteAllScoreDetail()
        {
            ScoreDetailAdapter.DeleteAllScoreDetail();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Data.Setup;
using Data.Setup.ScorecardTableAdapters;

namespace Business.Setup
{
    [System.ComponentModel.DataObject]
    public class CreateScorecardBL
    {

        public bool createSccorecard()
        {
            CreateScorecardDB objcreateScorecard=new CreateScorecardDB();
            objcreateScorecard.CreateIntegratedScorecard();
            return true;
        }

        private ScorecardDetailTableAdapter scorecarddetailAdapter = new ScorecardDetailTableAdapter();

        protected ScorecardDetailTableAdapter ScorecarddetailAdapter
        {
            get
            {
                if (scorecarddetailAdapter == null)
                {
                    scorecarddetailAdapter = new ScorecardDetailTableAdapter();
                }

                return scorecarddetailAdapter;
            }

        }


        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Select, true)]
        public Scorecard.ScorecardDetailDataTable GetCASScorecardForUser(int iAppUserId)
        {
            return ScorecarddetailAdapter.GetCASScorecardForUser(iAppUserId);

        }


        [System.ComponentModel.DataObjectMethodAttribute
         (System.ComponentModel.DataObjectMethodType.Select, true)]
        public Scorecard.ScorecardDetailDataTable GetBSScorecardForUser(int iAppUserId)
        {
            return ScorecarddetailAdapter.GetBSScorecardForUser(iAppUserId);

        }

    }
}

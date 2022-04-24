using System;
using System.Collections.Generic;
using System.Text;
using Data.Setup;
using Data.Setup.TitleTableAdapters;

namespace Business.Setup
{
    [System.ComponentModel.DataObject]
    public class TitleBL
    {
        private TitleTableAdapter titleAdapter = new TitleTableAdapter();

        protected TitleTableAdapter TitleAdapter
        {
            get
            {
                if (titleAdapter == null)
                {
                    titleAdapter = new TitleTableAdapter();
                }

                return titleAdapter;
            }

        }

        public string GetTitleNameByID(int iTitleId)
        {
            return TitleAdapter.GetTitleById((iTitleId)).ToString();

        }


        [System.ComponentModel.DataObjectMethodAttribute
         (System.ComponentModel.DataObjectMethodType.Select, true)]
        public Title.TitleDataTable GetTitles()
        {
            return TitleAdapter.GetTitles();
        }
    }
}

using System.ComponentModel;
using Data.CAS;
using Data.CAS.RoleCompTableAdapters;

namespace Business.CAS
{
    [System.ComponentModel.DataObject]
    public class RoleCompetencyBL
    {
        private RoleCompetencyTableAdapter roleCompetencyAdapter = new RoleCompetencyTableAdapter();

        protected RoleCompetencyTableAdapter RoleCompetencyAdapter
        {
            get
            {
                if (roleCompetencyAdapter == null)
                {
                    roleCompetencyAdapter = new RoleCompetencyTableAdapter();
                }

                return roleCompetencyAdapter;
            }
        }

        [DataObjectMethod
            (DataObjectMethodType.Select, true)]
        public RoleComp.RoleCompetencyDataTable GetRoleCompetencyList()
        {
            return RoleCompetencyAdapter.GetRoleCompetency();
        }

        [DataObjectMethod
            (DataObjectMethodType.Select, true)]
        public RoleComp.RoleCompetencyDataTable GetCompetenciesForRole(int iRoleId)
        {
            return RoleCompetencyAdapter.GetRoleCompetencyForRole(iRoleId);
        }


        public bool AddRoleCompetency(int OrgroleId, int CompetencyId, int RatingMasterId, int DesiredRating)
        {
            RoleComp.RoleCompetencyDataTable objRoleCompetency = new RoleComp.RoleCompetencyDataTable();
            RoleComp.RoleCompetencyRow objRoleCompetencyRow = objRoleCompetency.NewRoleCompetencyRow();


            objRoleCompetencyRow.OrgRoleId = OrgroleId;
            objRoleCompetencyRow.CompetencyId = CompetencyId;
            objRoleCompetencyRow.RatingMasterId = 1; // hardcoded.Rating master id is not used.
            objRoleCompetencyRow.DesiredRating = DesiredRating;
            objRoleCompetency.AddRoleCompetencyRow(objRoleCompetencyRow);

            int rowsAffected = roleCompetencyAdapter.Update(objRoleCompetencyRow);
            // Return true if precisely one row was inserted,
            // otherwise false
            return rowsAffected == 1;
        }

        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public bool UpdateRoleCompetency(int RoleCompetencyId, int OrgroleId, int CompetencyId, int RatingMasterId,
                                         int DesiredRating)
        {
            RoleComp.RoleCompetencyDataTable objRoleCompetency =
                roleCompetencyAdapter.GetRoleCompetencybyId(RoleCompetencyId);

            if (objRoleCompetency.Count == 0)
                // no matching record found, return false
                return false;
            RoleComp.RoleCompetencyRow objRoleCompetencyRow = objRoleCompetency[0];

            objRoleCompetencyRow.OrgRoleId = OrgroleId;
            objRoleCompetencyRow.CompetencyId =  CompetencyId;
            objRoleCompetencyRow.RatingMasterId = 1; // hardcoded.Rating master id is not used.
            objRoleCompetencyRow.DesiredRating = DesiredRating;
           // objRoleCompetency.AddRoleCompetencyRow(objRoleCompetencyRow);

            int rowsAffected = roleCompetencyAdapter.Update(objRoleCompetencyRow);
            // Return true if precisely one row was updated,
            // otherwise false
            return rowsAffected == 1;
        }

        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public string UpdateTest()
        {
            return "hi hi hi";
        }


        [DataObjectMethod
            (DataObjectMethodType.Delete, true)]
        public bool DeleteRoleCompetency(int RoleCompetencyID)
        {
            int rowsAffected = RoleCompetencyAdapter.Delete(RoleCompetencyID);
            // Return true if precisely one row was deleted,// otherwise false
            return rowsAffected == 1;
        }
    }
}
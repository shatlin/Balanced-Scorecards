using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Data.Setup
{
    public class CreateScorecardDB : SystemManagerDB
    {
        public bool CreateIntegratedScorecard()
        {
            CreateScorecardDB objSC = new CreateScorecardDB();
            if(!ClearScorecardData())
                return false;
            CreateCompetencyScorecard();

            CreatePerformanceScorecard();
            CreateBalancedScorecard();

            return false;
        }

        public bool ClearScorecardData()
        {
            CreateScorecardDB objSC=new CreateScorecardDB();

            SqlTransaction sqlTran = sqlConn.BeginTransaction();
            try
            {
                sqlComm.Transaction = sqlTran;
                sqlAdap.DeleteCommand = sqlComm;
                sqlComm.CommandType = CommandType.Text;
                sqlComm.CommandText = "delete  from Scorecarddetail";

                sqlComm.ExecuteNonQuery();

                sqlAdap.DeleteCommand = sqlComm;
                sqlComm.CommandType = CommandType.Text;
                sqlComm.CommandText = "delete from ScorecardMaster";
                sqlComm.ExecuteNonQuery();
                sqlTran.Commit();
            }

            catch (Exception objException)
            {
                sqlTran.Rollback();
                return false;
            }
            finally
            {
                sqlConn.Close();
            }
            return true;
        }

        public bool CreateCompetencyScorecard()
        {
            CreateScorecardDB objSC = new CreateScorecardDB();
            
                try
                {
                    sqlAdap.InsertCommand = sqlComm;
                    sqlComm.CommandType = CommandType.Text;
                    sqlComm.CommandText =  "insert into ScoreCardMaster(AppUserId,ScorecardTypeId) select appuserid,1 from scoremaster";
                    sqlComm.ExecuteNonQuery();
                }
                catch (Exception objException)
                {
                    return false;
                }

                DataSet dsScoreMaster = new DataSet();
                DataTable dtScoreMaster = new DataTable();



                try
                {
                    sqlAdap.SelectCommand = sqlComm;
                    sqlComm.CommandType = CommandType.Text;
                    sqlComm.CommandText = "select A.ScoreMasterId,B.AppuserId,B.ScorecardMasterId from Scoremaster A, ScorecardMaster B where A.AppuserId=B.AppUserId";
                    
                    sqlAdap.Fill(dsScoreMaster);
                    dtScoreMaster = dsScoreMaster.Tables[0];

                }
                catch (Exception objException)
                {
                    return false;
                }

            
                foreach (DataRow dtrow in dtScoreMaster.Rows)
                {

                    try
                    {
                
                        sqlAdap.InsertCommand = sqlComm;
                        sqlComm.CommandType = CommandType.Text;
                        sqlComm.CommandText =

  " INSERT INTO ScorecardDetail(ScorecardMasterId, MeasureClusterName, MeasureGroupName, MeasureName, actual, Target, [Sequence]) " +
  " SELECT " + Convert.ToInt32(dtrow[2])+",'',CompetencyType.CompetencyTypeName,"+
  " Competency.CompetencyName,RoleCompetency.DesiredRating,"+
  " ScoreDetail.AgreedRating,0 "+
  " FROM         CompetencyType INNER JOIN "+
  " Competency ON CompetencyType.CompetencyTypeId = Competency.CompetencyTypeId INNER JOIN "+
  " ScoreDetail ON Competency.CompetencyId = ScoreDetail.CompetencyId INNER JOIN "+
  " ScoreMaster ON ScoreDetail.ScoreMasterId = ScoreMaster.ScoreMasterId INNER JOIN "+
  " AppUser ON ScoreMaster.AppUserId = AppUser.AppUserId INNER JOIN "+
  " RoleCompetency ON Competency.CompetencyId = RoleCompetency.CompetencyId INNER JOIN "+
  " OrgRole ON AppUser.OrgRoleId = OrgRole.OrgRoleId AND RoleCompetency.OrgRoleId = OrgRole.OrgRoleId "+
  " where ScoreMaster.ScoreMasterId= " + Convert.ToInt32(dtrow[0]) +
  " order by CompetencyType.CompetencyTypeName";

                        sqlComm.ExecuteNonQuery();



                           
                            
                    
                    }
                    catch (Exception objException)
                    {
                        return false;
                    }

                }
          

            return true;
        }

        public bool CreateBalancedScorecard()
        {
            CreateScorecardDB objSC = new CreateScorecardDB();

            try
            {
                sqlAdap.InsertCommand = sqlComm;
                sqlComm.CommandType = CommandType.Text;
                sqlComm.CommandText =
                    "insert into ScoreCardMaster(AppUserId,ScorecardTypeId) select distinct appuserid,2 from usermeasure";
                sqlComm.ExecuteNonQuery();
            }
            catch (Exception objException)
            {
                return false;
            }

            DataSet dsScoreMaster = new DataSet();
            DataTable dtScoreMaster = new DataTable();


            try
            {
                sqlAdap.SelectCommand = sqlComm;
                sqlComm.CommandType = CommandType.Text;
                sqlComm.CommandText =
                    "select distinct B.AppuserId,B.ScorecardMasterId from ScorecardMaster B where B.ScorecardTypeId=2";

                sqlAdap.Fill(dsScoreMaster);
                dtScoreMaster = dsScoreMaster.Tables[0];
            }
            catch (Exception objException)
            {
                return false;
            }


            foreach (DataRow dtrow in dtScoreMaster.Rows)
            {
                try
                {
                    sqlAdap.InsertCommand = sqlComm;
                    sqlComm.CommandType = CommandType.Text;
                    sqlComm.CommandText =
                        " INSERT INTO ScorecardDetail(ScorecardMasterId, MeasureClusterName, MeasureGroupName, MeasureName, actual, Target, [Sequence]) " +
                        " SELECT " + Convert.ToInt32(dtrow[1]) +
                        ",Perspective.PerspectiveName, Objective.ObjectiveName,Measure.MeasureName, UserMeasure.Actual, MeasureRoleDetail.Target,0 " +
                        " FROM         Objective INNER JOIN RoleMeasure ON Objective.ObjectiveId = RoleMeasure.ObjectiveId " +
                        " INNER JOIN   Perspective ON RoleMeasure.Perspectiveid = Perspective.PerspectiveId " +
                        " INNER JOIN   Measure ON RoleMeasure.MeasureId = Measure.MeasureId " +
                        " INNER JOIN  UserMeasure ON Measure.MeasureId = UserMeasure.MeasureId " +
                        " INNER JOIN   MeasureRoleDetail ON Measure.MeasureId = MeasureRoleDetail.MeasureId " +
                        " INNER JOIN   AppUser ON UserMeasure.AppUserId = AppUser.AppUserId" +
                        " INNER JOIN  ScorecardMaster ON AppUser.AppUserId = ScorecardMaster.AppUserId " +
                        " where scorecardmaster.ScorecardTypeId=2 " +
                        " and UserMeasure.AppUserId=scorecardmaster.appuserid " +
                        " and MeasureRoleDetail.MeasureId=usermeasure.MeasureId " +
                        " and MeasureRoleDetail.MeasureId=measure.MeasureId " +
                        " and RoleMeasure.OrgRoleId=measureroledetail.OrgRoleId " +
                        " and RoleMeasure.MeasureId=measure.MeasureId " +
                        " and RoleMeasure.MeasureId=usermeasure.MeasureId " +
                        " and AppUser.OrgRoleId=MeasureRoledetail.OrgRoleId " +
                        " and ScorecardMaster.AppUserId= " + Convert.ToInt32(dtrow[0]);


                    sqlComm.ExecuteNonQuery();
                }
                catch (Exception objException)
                {
                    return false;
                }

                
            }
            return true;
        }

        public bool CreatePerformanceScorecard()
        {
            return false;
        }

        public DataSet GetIntegratedScorecard(int iAppUserId)
        {
            return null;
        }
    }
}

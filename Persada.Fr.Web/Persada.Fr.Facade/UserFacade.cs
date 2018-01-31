using Persada.Fr.Model;
using Persada.Fr.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persada.Fr.CommonFunction;
using System.Data.Entity;

namespace Persada.Fr.Facade
{
    public class UserFacade : ApiResData
    {
        public ApiGridResponse RetrieveDataUser()
        {
            ApiGridResponse res = new ApiGridResponse();
            try
            {
                List<TOURIS_TM_USER> users = new List<TOURIS_TM_USER>();
                List<TOURIS_TV_USER> userViews = new List<TOURIS_TV_USER>();

                using (TourismpediaEntities tourisdb = new TourismpediaEntities())
                {
                    users = tourisdb.TOURIS_TM_USER.ToList();
                }

                if (users.Count > 0)
                {
                    foreach (var item in users)
                    {
                        TOURIS_TV_USER userView = new TOURIS_TV_USER();
                        userView.USER_NAME = item.USER_NAME;
                        userView.USER_MAIL = item.USER_MAIL;

                        userViews.Add(userView);
                    }
                }
                res = ResGetDataTable(new object[] { userViews }, null);
            }
            catch (Exception ex)
            {
                res = ResGetDataTable(null, ex);
            }

            return res;
        }

        public ApiGridResponse InsertDataUser(TOURIS_TV_USER userView)
        {
            ApiGridResponse res = new ApiGridResponse();
            ResultStatus rs = new ResultStatus();
            try
            {
                TOURIS_TM_USER user = new TOURIS_TM_USER();
                using (TourismpediaEntities tourisdb = new TourismpediaEntities())
                {
                    user.USER_NAME = userView.USER_NAME;
                    user.USER_MAIL = userView.USER_MAIL;
                    user.CREATED_BY = userView.CREATED_BY;
                    user.CREATED_TIME = userView.CREATED_TIME;

                    tourisdb.TOURIS_TM_USER.Add(user);
                    tourisdb.SaveChanges();
                    rs.SetSuccessStatus();
                }
                res = ResGetDataTable(new object[] { rs }, null);
            }
            catch (Exception ex)
            {
                res = ResGetDataTable(null, ex);
            }

            return res;
        }

        public ApiGridResponse EditDataUser(TOURIS_TV_USER userView)
        {
            ApiGridResponse res = new ApiGridResponse();
            ResultStatus rs = new ResultStatus();
            try
            {
                using (TourismpediaEntities tourisdb = new TourismpediaEntities())
                {
                    TOURIS_TM_USER user = tourisdb.TOURIS_TM_USER.Find(userView.ID);
                    user.USER_NAME = userView.USER_NAME;
                    user.USER_MAIL = userView.USER_MAIL;
                    user.LAST_MODIFIED_BY = userView.LAST_MODIFIED_BY;
                    user.LAST_MODIFIED_TIME = userView.LAST_MODIFIED_TIME;

                    tourisdb.Entry(user).State = EntityState.Modified;
                    tourisdb.SaveChanges();
                    rs.SetSuccessStatus();
                }
                res = ResGetDataTable(new object[] { rs }, null);
            }
            catch (Exception ex)
            {
                res = ResGetDataTable(null, ex);
            }

            return res;
        }

        public ApiGridResponse DeleteDataUser(TOURIS_TV_USER userView)
        {
            ApiGridResponse res = new ApiGridResponse();
            ResultStatus rs = new ResultStatus();
            try
            {
                using (TourismpediaEntities tourisdb = new TourismpediaEntities())
                {
                    TOURIS_TM_USER user = tourisdb.TOURIS_TM_USER.Find(userView.ID);

                    tourisdb.TOURIS_TM_USER.Remove(user);
                    tourisdb.SaveChanges();
                    rs.SetSuccessStatus();
                }
                res = ResGetDataTable(new object[] { rs }, null);
            }
            catch (Exception ex)
            {
                res = ResGetDataTable(null, ex);
            }

            return res;
        }
    }
}

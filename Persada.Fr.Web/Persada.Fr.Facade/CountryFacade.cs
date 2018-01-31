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
    public class CountryFacade : ApiResData
    {
        public ApiGridResponse RetrieveDataCountryList()
        {
            ResultStatus rs = new ResultStatus();
            ApiGridResponse res = new ApiGridResponse();
            try
            {
                List<TOURIS_TM_COUNTRY> countries = new List<TOURIS_TM_COUNTRY>();
                List<TOURIS_TV_COUNTRY> countryViews = new List<TOURIS_TV_COUNTRY>();

                using (TourismpediaEntities tourisdb = new TourismpediaEntities())
                {
                    countries = tourisdb.TOURIS_TM_COUNTRY.ToList();
                }

                if (countries.Count > 0)
                {
                    foreach (var item in countries)
                    {
                        TOURIS_TV_COUNTRY countryView = new TOURIS_TV_COUNTRY();
                        countryView.ID = item.ID;
                        countryView.COUNTRY_CODE = item.COUNTRY_CODE;
                        countryView.COUNTRY_NAME = item.COUNTRY_NAME;
                        countryView.COUNTRY_DESCRIPTION = item.COUNTRY_DESCRIPTION;
                        countryView.CREATED_BY = item.CREATED_BY;
                        countryView.CREATED_TIME = item.CREATED_TIME;
                        countryView.LAST_MODIFIED_BY = item.LAST_MODIFIED_BY;
                        countryView.LAST_MODIFIED_TIME = item.LAST_MODIFIED_TIME;

                        countryViews.Add(countryView);
                    }
                    rs.SetSuccessStatus();
                }
               
                res = ResGetDataTable(new object[] { countryViews }, null);
            }
            catch (Exception ex)
            {
                rs.SetErrorStatus(ex.Message);
                res = ResGetDataTable(new object[] { rs }, ex);
            }

            return res;
        }

        public ApiGridResponse RetrieveDataCountry(TOURIS_TV_COUNTRY countryView)
        {
            ResultStatus rs = new ResultStatus();
            ApiGridResponse res = new ApiGridResponse();
            TOURIS_TM_COUNTRY country = new TOURIS_TM_COUNTRY();
            try
            {
                using (TourismpediaEntities tourisdb = new TourismpediaEntities())
                {
                    country = tourisdb.TOURIS_TM_COUNTRY.Find(countryView.ID);
                    rs.SetSuccessStatus();
                }

                res = ResGetDataTable(new object[] { country }, null);
            }
            catch (Exception ex)
            {
                rs.SetErrorStatus(ex.Message);
                res = ResGetDataTable(new object[] { rs }, ex);
            }

            return res;
        }

        public ApiGridResponse InsertDataCountry(TOURIS_TV_COUNTRY countryView)
        {
            ApiGridResponse res = new ApiGridResponse();
            ResultStatus rs = new ResultStatus();
            try
            {
                TOURIS_TM_COUNTRY country = new TOURIS_TM_COUNTRY();
                using (TourismpediaEntities tourisdb = new TourismpediaEntities())
                {
                    country.COUNTRY_CODE = countryView.COUNTRY_CODE;
                    country.COUNTRY_NAME = countryView.COUNTRY_NAME;
                    country.COUNTRY_DESCRIPTION = countryView.COUNTRY_DESCRIPTION;
                    country.CREATED_BY = countryView.CREATED_BY;
                    country.CREATED_TIME = countryView.CREATED_TIME;

                    tourisdb.TOURIS_TM_COUNTRY.Add(country);
                    tourisdb.SaveChanges();
                    rs.SetSuccessStatus();
                }
                res = ResGetDataTable(new object[] { rs }, null);
            }
            catch (Exception ex)
            {
                rs.SetErrorStatus(ex.Message);
                res = ResGetDataTable(new object[] { rs }, ex);
            }

            return res;
        }

        public ApiGridResponse EditDataCountry(TOURIS_TV_COUNTRY countryView)
        {
            ApiGridResponse res = new ApiGridResponse();
            ResultStatus rs = new ResultStatus();
            try
            {
                using (TourismpediaEntities tourisdb = new TourismpediaEntities())
                {
                    TOURIS_TM_COUNTRY country = tourisdb.TOURIS_TM_COUNTRY.Find(countryView.ID);
                    country.COUNTRY_CODE = countryView.COUNTRY_CODE;
                    country.COUNTRY_NAME = countryView.COUNTRY_NAME;
                    country.COUNTRY_DESCRIPTION = countryView.COUNTRY_DESCRIPTION;
                    country.LAST_MODIFIED_BY = countryView.LAST_MODIFIED_BY;
                    country.LAST_MODIFIED_TIME = countryView.LAST_MODIFIED_TIME;

                    tourisdb.Entry(country).State = EntityState.Modified;
                    tourisdb.SaveChanges();
                    rs.SetSuccessStatus();
                }
                res = ResGetDataTable(new object[] { rs }, null);
            }
            catch (Exception ex)
            {
                rs.SetErrorStatus(ex.Message);
                res = ResGetDataTable(new object[] { rs }, ex);
            }

            return res;
        }

        public ApiGridResponse DeleteDataCountry(TOURIS_TV_COUNTRY countryView)
        {
            ApiGridResponse res = new ApiGridResponse();
            ResultStatus rs = new ResultStatus();
            try
            {
                using (TourismpediaEntities tourisdb = new TourismpediaEntities())
                {
                    TOURIS_TM_COUNTRY country = tourisdb.TOURIS_TM_COUNTRY.Find(countryView.ID);

                    tourisdb.TOURIS_TM_COUNTRY.Remove(country);
                    tourisdb.SaveChanges();
                    rs.SetSuccessStatus();
                }
                res = ResGetDataTable(new object[] { rs }, null);
            }
            catch (Exception ex)
            {
                rs.SetErrorStatus(ex.Message);
                res = ResGetDataTable(new object[] { rs }, ex);
            }

            return res;
        }
    }
}
